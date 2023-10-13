Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, g, re As Double
        i = TextBox1.Text
        g = TextBox2.Text
        re = i / g
        TextBox3.Text = re
        If TextBox1.Text = 0 Then
            TextBox3.Text = "Indeterminado"
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = "Indeterminado"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class