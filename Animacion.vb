
Public Class Animacion
    Dim Segundos As Integer
    Private Sub Animacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.Pista,
        AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Segundos += 1

        If Segundos = 21 Then
            Timer1.Stop()
            Ganador_Final.Show()
            Me.Close()
        End If

    End Sub


End Class