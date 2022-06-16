Public Class Usuarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "SELECT * FROM `usuarios` WHERE Usuario = '" & TextBox1.Text & "' AND Contraseña = '" & TextBox2.Text & "' "

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Usuario ya fue registrado")
            Return
        End If

        sql = "INSERT INTO `usuarios`(`Usuario`, `Contraseña`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "')"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectarse a la Base de Datos")
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pantalla_Principal.currentForm.Close()
    End Sub
End Class