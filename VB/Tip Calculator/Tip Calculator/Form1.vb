Public Class Form1
    Private Sub CalcButton1_Click(sender As Object, e As EventArgs) Handles CalcButton1.Click
        Dim total As Decimal
        Decimal.TryParse(TotalTextBox1.Text, total)

        Dim grandtotal As Decimal
        grandtotal = total * (TipTextBox1.Text / 100 + SalesTextBox1.Text / 100 + 1)
        GrandTotalLabel1.Text = grandtotal.ToString("c2")

        Dim Subtotal As Decimal
        Subtotal = total * (SalesTextBox1.Text / 100 + 1)
        SalesLabel6.Text = Subtotal.ToString("c2")

    End Sub


End Class
