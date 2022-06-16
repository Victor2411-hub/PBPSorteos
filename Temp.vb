Public Class Temp
    Dim selecionado As String
    Dim ganadorf As String
    Sub resetganador()
        sql = "DELETE FROM `ganadores`"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Sub PreSeleccionador()
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 1 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3roa ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 2 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3rob ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 3 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3roc ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 4 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3rod ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 5 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3roe ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 6 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 3rof ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 7 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4toa ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 8 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4tob ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 9 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4toc ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 10 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4tod ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 11 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4toe ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 12 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 4tof ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 13 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5toa ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 14 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5tob ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 15 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5toc ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 16 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5tod ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 17 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5toe ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 18 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5tof ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 19 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 5tog ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 20 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6toa ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 21 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6tob ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 22 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6toc ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 23 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6tod ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 24 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6toe ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 25 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6tof ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 26 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM 6tog ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 27 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombres FROM `empleados` ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------
        sql = "SELECT * FROM `seleccion` WHERE CheckID = 28 AND Status = 'TRUE'"
        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If dr.Read Then
            sql = "SELECT Nombre FROM `invitados` ORDER BY RAND () LIMIT 1"
            openCon()
            While dr.Read()
                selecionado = (String.Format("{0}",
               dr(0)))
            End While
            sql = "INSERT INTO `ganadores`(`Nombre`) VALUES ('" & selecionado & "')"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        '----------------------------------------------------------------------

    End Sub

    Sub Ganador_F()
        sql = "SELECT Nombre FROM ganadores ORDER BY RAND () LIMIT 1"
        openCon()
        While dr.Read()
            ganadorf = (String.Format("{0}",
               dr(0)))
        End While
        Ganador_Final.ganador = ganadorf
    End Sub

    Private Sub Up1_Click(sender As Object, e As EventArgs) Handles Up1.Click
        L_min.Text += 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles L_min.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles L_seg.Click


    End Sub

    Private Sub Up2_Click(sender As Object, e As EventArgs) Handles Up2.Click
        L_seg.Text += 1
    End Sub

    Private Sub Down2_Click(sender As Object, e As EventArgs) Handles Down2.Click
        If L_seg.Text <> 0 Then
            L_seg.Text -= 1
        End If
    End Sub

    Private Sub Down1_Click(sender As Object, e As EventArgs) Handles Down1.Click
        If L_min.Text <> 0 Then
            L_min.Text -= 1
        End If

    End Sub

    Private Sub Control_Tick(sender As Object, e As EventArgs) Handles Control.Tick
        L_min.Left = Up1.Left - ((L_min.Width - Up1.Width) / 2)
        L_seg.Left = Up2.Left - ((L_seg.Width - Up2.Width) / 2)

    End Sub
    Dim minutos As Integer
    Dim segundos As Integer
    Dim pro As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Iniciar1.Click
        Up1.Visible = False
        Up2.Visible = False
        Down1.Visible = False
        Down2.Visible = False
        minutos = L_min.Text
        segundos = L_seg.Text
        If pro = True Then
            Progreso.Enabled = True
        End If
        Parar.BringToFront()
        Temporizador.Interval = 1000
        Temporizador.Start()

    End Sub

    Private Sub Parar_Click(sender As Object, e As EventArgs) Handles Parar.Click
        Iniciar1.BringToFront()
        Temporizador.Enabled = False
        Progreso.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Up1.Visible = True
        Down1.Visible = True
        Up2.Visible = True
        Down2.Visible = True
        Progreso.Stop()
        Temporizador.Stop()
        Iniciar1.BringToFront()
        L_min.Text = "00"
        L_seg.Text = "30"

    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        If segundos = 0 And minutos > 0 Then
            segundos = 60
            minutos -= 1
            L_min.Text -= 1
            L_seg.Text = 60
        End If
        segundos -= 1
        L_seg.Text -= 1
        If L_seg.Text = "0" Or L_seg.Text = "00" Then
            If L_min.Text = "0" Or L_min.Text = "00" Then
                Temporizador.Enabled = False
                Parar.Enabled = False
                PreSeleccionador()
                Ganador_F()
                Animacion.Show()
                Pantalla_Principal.Hide()
                resetganador()
            End If
        End If
    End Sub

    Private Sub Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
