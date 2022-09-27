Public Class Form1
    Dim decaf As Integer
    Dim regular As Integer
    Private Sub CalcButton2_Click(sender As Object, e As EventArgs) Handles CalcButton2.Click
        Integer.TryParse(RegTextBox.Text, regular)
        regular = RegTextBox.Text
        Integer.TryParse(DecafTextBox.Text, decaf)
        decaf = DecafTextBox.Text
        PoundsTextBox.Text = decaf + regular
        TotalTextBox.Text = (decaf + regular) * 4.99
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DecafTextBox.Clear()
        RegTextBox.Clear()
        TotalTextBox.Clear()
        PoundsTextBox.Clear()
        NameTextBox1.Clear()
        AdressTextBox2.Clear()
        CityTextBox3.Clear()
        StateTextBox4.Clear()
        Ziptextbox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
