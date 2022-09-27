Public Class Form4


    Private Sub BoatButton_Click(sender As Object, e As EventArgs) Handles BoatButton.Click
        Integer.TryParse(YachtTextbox.Text, yacht)
        yacht = yacht * 640000
        Integer.TryParse(CruiseTextBox.Text, cruise)
        cruise = cruise * 1000000000
        Integer.TryParse(RowTextBox.Text, rowboat)
        rowboat = rowboat * 20000
    End Sub
End Class