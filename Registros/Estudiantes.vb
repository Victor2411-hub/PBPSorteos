Public Class Estudiantes
    Dim value As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Llene el campo")
            Return
        End If

        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Llene el campo")
            Return
        End If

        If ComboBox1.Text = "" Then
            ErrorProvider1.SetError(ComboBox1, "Seleccione un Curso")
            Return
        End If

        sql = "SELECT * FROM `" & value & "` WHERE Nombre= '" & TextBox1.Text & "' AND Numero=" & TextBox3.Text & ""

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Estudiante ya fue registrado")
            Return
        End If

        sql = "INSERT INTO `" & value & "`(`Nombre`, `Numero`) VALUES ('" & TextBox1.Text & "','" & TextBox3.Text & "')"

        Try
            openCon()
            MsgBox("Operación Exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        TextBox1.Text = ""
        ComboBox1.Text = ""
        value = Nothing
        TextBox3.Text = ""

    End Sub
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("3roA")
        ComboBox1.Items.Add("3roB")
        ComboBox1.Items.Add("3roC")
        ComboBox1.Items.Add("3roD")
        ComboBox1.Items.Add("3roE")
        ComboBox1.Items.Add("3roF")
        ComboBox1.Items.Add("4toA")
        ComboBox1.Items.Add("4toB")
        ComboBox1.Items.Add("4toC")
        ComboBox1.Items.Add("4toD")
        ComboBox1.Items.Add("4toE")
        ComboBox1.Items.Add("4toF")
        ComboBox1.Items.Add("5toA")
        ComboBox1.Items.Add("5toB")
        ComboBox1.Items.Add("5toC")
        ComboBox1.Items.Add("5toD")
        ComboBox1.Items.Add("5toE")
        ComboBox1.Items.Add("5toF")
        ComboBox1.Items.Add("5toG")
        ComboBox1.Items.Add("6toA")
        ComboBox1.Items.Add("6toB")
        ComboBox1.Items.Add("6toC")
        ComboBox1.Items.Add("6toD")
        ComboBox1.Items.Add("6toE")
        ComboBox1.Items.Add("6toF")
        ComboBox1.Items.Add("6toG")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pantalla_Principal.currentForm.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        value = ComboBox1.Text
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        value = ComboBox1.Text
    End Sub
End Class