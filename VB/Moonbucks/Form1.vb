Public Class Form1
    Dim amount As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(TextBox1.Text, amount)
        TextBox1.Text = amount
        Label1.Text = amount * 2
    End Sub
End Class
