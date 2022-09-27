Public Class Form3
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Decimal.TryParse(TextBox2.Text, carrots)
    End Sub
End Class