﻿Public Class Form1
    Public User As String
    Private Sub yesno()
        Dim dialogResult As DialogResult = MessageBox.Show("Quiere cerrar el programa?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dialogResult = DialogResult.Yes Then
            Me.Close()
        ElseIf dialogResult = DialogResult.No Then

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        yesno()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        If TxtUser.Text = "" Then
            ErrorProvider1.SetError(TxtUser, "Digite el Usuario")
            Return
        Else
            ErrorProvider1.SetError(TxtUser, Nothing)
        End If

        If TxtPass.Text = "" Then
            ErrorProvider1.SetError(TxtPass, "Digite la Contraceña")
            Return
        Else
            ErrorProvider1.SetError(TxtPass, Nothing)
        End If


        sql = "Select * From usuarios Where Usuario= '" & TxtUser.Text & "' And Contraseña= '" & TxtPass.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try


        If dr.Read Then
            User = TxtUser.Text
            Me.Hide()
            Bienvenida.ShowDialog()
            Pantalla_Principal.Show()
            Me.Close()
            con.Close()

        Else
            ErrorProvider1.SetError(Button1, "Usuario o Contraceña incorrectos")
            Return
        End If

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Try
            Comprobarcon()
            MsgBox("La conección a la base de datos fue exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
