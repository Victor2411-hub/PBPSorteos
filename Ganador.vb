Imports System.ComponentModel

Public Class Ganador_Final
    Public ganador As String


    Private Sub sound()
        My.Computer.Audio.Play(My.Resources.winner,
        AudioPlayMode.Background)
    End Sub

    Private Sub Ganador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winer.Text = ganador
        winer.TextAlign = HorizontalAlignment.Center
        WindowState = FormWindowState.Maximized
        sound()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Ganador_Final_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Pantalla_Principal.Show()
        Pantalla_Principal.sound()

    End Sub
End Class