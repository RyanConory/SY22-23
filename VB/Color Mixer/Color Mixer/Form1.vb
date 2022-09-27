Public Class Form1

    Dim red As Integer
    Dim green As Integer
    Dim blue As Integer

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Integer.TryParse(RedTextBox.Text, red)
        Integer.TryParse(BlueTextBox.Text, blue)
        Integer.TryParse(GreenTextBox.Text, green)
        ColorOvalshape.backcolor =
        Color.FromArgb(red, green, blue)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
