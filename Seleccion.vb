Imports System.IO

Public Class Seleccion
    Private Sub yesno()
        Dim dialogResult As DialogResult = MessageBox.Show("Guardó los Datos?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dialogResult = DialogResult.Yes Then
            Pantalla_Principal.currentForm.Close()
        ElseIf dialogResult = DialogResult.No Then

        End If
    End Sub
    Sub loaad()
        '------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 1 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox1.Checked = True
            CheckBox1.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 2 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox2.Checked = True
            CheckBox2.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 3 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox3.Checked = True
            CheckBox3.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 4 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox4.Checked = True
            CheckBox4.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 5 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox5.Checked = True
            CheckBox5.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 6 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox6.Checked = True
            CheckBox6.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 7 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox7.Checked = True
            CheckBox7.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 8 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox8.Checked = True
            CheckBox8.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 9 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox9.Checked = True
            CheckBox9.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 10 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox10.Checked = True
            CheckBox10.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 11 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox11.Checked = True
            CheckBox11.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 12 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox12.Checked = True
            CheckBox12.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 13 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox13.Checked = True
            CheckBox13.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 14 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox14.Checked = True
            CheckBox14.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 15 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox15.Checked = True
            CheckBox15.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 16 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox16.Checked = True
            CheckBox16.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 17 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox17.Checked = True
            CheckBox17.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 18 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox18.Checked = True
            CheckBox18.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 19 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox19.Checked = True
            CheckBox19.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 20 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox20.Checked = True
            CheckBox20.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 21 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox21.Checked = True
            CheckBox21.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 22 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox22.Checked = True
            CheckBox22.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 23 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox23.Checked = True
            CheckBox23.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 24 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox24.Checked = True
            CheckBox24.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 25 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox25.Checked = True
            CheckBox25.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 26 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox26.Checked = True
            CheckBox26.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 27 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox27.Checked = True
            CheckBox27.Refresh()
        End If
        '-------------------------------------
        sql = "Select * From `seleccion` WHERE CheckID = 28 AND Status = 'TRUE'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error LPM")
        End Try

        If dr.Read Then
            CheckBox28.Checked = True
            CheckBox28.Refresh()
        End If
        '-------------------------------------
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 1"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 1"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox2.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 2"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 2"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox3.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 3"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 3"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox4.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 4"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 4"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox5.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 5"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 5"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox6.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 6"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 6"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox7.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 7"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 7"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox8.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 8"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 8"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox9.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 9"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 9"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox10.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 10"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 10"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox11.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 11"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 11"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox12.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 12"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 12"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox13.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 13"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 13"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox14.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 14"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 14"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox15.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 15"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 15"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox16.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 16"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 16"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox17.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 17"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 17"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox18.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 18"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 18"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox19.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 19"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 19"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox20.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 20"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 20"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox21.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 21"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 21"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox22.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 22"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 22"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox23.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 23"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 23"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox24.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 24"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 24"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox25.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 25"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 25"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox26.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 26"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 26"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox27.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 27"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 27"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        If CheckBox28.Checked = True Then
            sql = "UPDATE `seleccion` SET `Status`='TRUE' WHERE CheckID = 28"

            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        Else
            sql = "UPDATE `seleccion` SET `Status`='FALSE' WHERE CheckID = 28"
            Try
                openCon()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        MsgBox("La seleccion fue guardada correctamente")
    End Sub

    Private Sub Seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaad()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        yesno()
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged

    End Sub
End Class