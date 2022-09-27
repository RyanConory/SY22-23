Public Class Form2

    Private Sub CarButton_Click(sender As Object, e As EventArgs) Handles CarButton.Click
        Integer.TryParse(TruckTextBox.Text, truck)
        truck = truck * 38361
        Integer.TryParse(VanTextBox.Text, van)
        van = van * 33000
        Integer.TryParse(TeslaTextBox.Text, tesla)
        tesla = tesla * 47000
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class