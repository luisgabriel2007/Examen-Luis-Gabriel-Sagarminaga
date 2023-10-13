Public Class Form1

    Dim usuario, contraseña As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        contraseña = TextBox2.Text
        If usuario = "Profesor Waldir" And contraseña = "123" Then
            Form2.Show()
            Hide()
        Else
            MsgBox("Usuario o contraseña Incorrecto")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
