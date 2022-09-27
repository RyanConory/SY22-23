Public Class Form1
    Private Sub VehicleButton_Click(sender As Object, e As EventArgs) Handles VehicleButton.Click
        Form2.ShowDialog()
    End Sub

    Private Sub PlaneButton_Click(sender As Object, e As EventArgs) Handles PlaneButton.Click
        Form3.ShowDialog()
    End Sub

    Private Sub BoatsButton_Click(sender As Object, e As EventArgs) Handles BoatsButton.Click
        Form4.ShowDialog()
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        GrandTotalLabel.Text = jet + com + priv + truck + van + tesla + cruise + yacht + rowboat
        Trucknum.Text = truck
        Vannum.Text = van
        Teslanum.Text = tesla
        comnum.Text = com
        privnum.Text = priv
        Jetnum.Text = jet
        yachtnum.Text = yacht
        rowboatnum.Text = rowboat
        cruisenum.Text = cruise

    End Sub
End Class
