Public Class Empleados

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Llene el campo")
            Return
        Else
            ErrorProvider1.SetError(TextBox1, Nothing)
        End If

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Llene el campo")
            Return
        Else
            ErrorProvider1.SetError(TextBox2, Nothing)
        End If

        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Llene el campo")
            Return
        Else
            ErrorProvider1.SetError(TextBox3, Nothing)
        End If

        sql = "SELECT * FROM `empleados` WHERE Nombres = '" & TextBox1.Text & "' AND Apellidos = '" & TextBox2.Text & "' AND Materia = '" & TextBox3.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Empleado ya Existe!")
            Return
        End If

        sql = "INSERT INTO `empleados`(`Nombres`, `Apellidos`, `Materia`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"

        Try
            openCon()
            MsgBox("Operación Exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pantalla_Principal.currentForm.Close()
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class