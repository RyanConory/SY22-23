Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal
        Decimal.TryParse(DollarsTextBox1.Text, amount)
        Dim Pesos As Decimal
        Pesos = amount * 20
        PesosTextBox1.Text = Pesos.ToString("n2")

        Dim yen As Decimal
        yen = amount * 136.51
        YenTextBox3.Text = yen.ToString("n2")

        Dim euro As Decimal
        euro = amount * 1
        EuroTextBox2.Text = euro.ToString("n2")

        Dim canaduan As Decimal
        canaduan = amount * 1.29
        CanadianTextBox6.Text = canaduan.ToString("n2")

        Dim pound As Decimal
        pound = amount * 0.84
        PoundTextBox4.Text = pound.ToString("n2")

        Dim AU As Decimal
        AU = amount * 1.43
        AustralianTextBox5.Text = AU.ToString("n2")
    End Sub
End Class
