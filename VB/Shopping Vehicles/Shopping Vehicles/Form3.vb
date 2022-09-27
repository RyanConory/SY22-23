Public Class Form3


    Private Sub PlaneButton_Click(sender As Object, e As EventArgs) Handles PlaneButton.Click
        Integer.TryParse(JetTextBox.Text, jet)
        jet = jet * 20000
        Integer.TryParse(PrivTextBox.Text, priv)
        priv = priv * 3000000
        Integer.TryParse(ComTextBox.Text, com)
        com = com * 89100000
    End Sub
End Class