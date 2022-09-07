Public Class Form1
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        BallsLabel1.Text = "Baseball"
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        BallsLabel1.Text = "Football"
    End Sub
End Class
