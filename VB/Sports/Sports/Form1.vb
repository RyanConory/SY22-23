Public Class Form1
    Private Sub Rhinoceros_Click(sender As Object, e As EventArgs) Handles Rhinoceros.Click
        displayPictureBox1.Image = RhinoPictureBox1.Image
        OrginLabel.Text = "Eurasia"
        LifespanLabel.Text = "35-50 Years"
        EndangeredLabel.Text = "Yes"
        DomesticatedLabel.Text = "No"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LifespanLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles OrginLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles HippoButton1.Click
        displayPictureBox1.Image = HippoPictureBox1.Image
        OrginLabel.Text = "Africa"
        LifespanLabel.Text = "40-50 Years"
        EndangeredLabel.Text = "Yes"
        DomesticatedLabel.Text = "No"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles HippoPictureBox1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles VultureButton1.Click
        displayPictureBox1.Image = VulturePictureBox1.Image
        OrginLabel.Text = "Europe, Africa and Asia"
        LifespanLabel.Text = "20 Years"
        EndangeredLabel.Text = "No"
        DomesticatedLabel.Text = "No"
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles VulturePictureBox1.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles EagleButton1.Click
        displayPictureBox1.Image = EaglePictureBox1.Image
        OrginLabel.Text = "All over (Mostly Eurasia and Africa)"
        LifespanLabel.Text = "10 Years"
        EndangeredLabel.Text = "Yes"
        DomesticatedLabel.Text = "No"
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles EaglePictureBox1.Click
    End Sub

    Private Sub DogButton1_Click(sender As Object, e As EventArgs) Handles DogButton1.Click
        displayPictureBox1.Image = DogPictureBox1.Image
        OrginLabel.Text = "Eurasia"
        LifespanLabel.Text = "10-15 Years"
        EndangeredLabel.Text = "No"
        DomesticatedLabel.Text = "Yes"
    End Sub

    Private Sub displayPictureBox1_Click(sender As Object, e As EventArgs) Handles displayPictureBox1.Click

    End Sub
End Class
