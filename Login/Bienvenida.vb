﻿Public Class Bienvenida
    Public Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form1.User
        ProgressBar1.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        Timer1.Start() 'Iniciamos el temporizador 1'
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        ProgressBar1.Text = ProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
                Me.Opacity += 0.05
            End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
            Me.Opacity -= 0.1
            If Me.Opacity = 0 Then
                Timer2.Stop()
                Me.Close()
            End If
        End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class