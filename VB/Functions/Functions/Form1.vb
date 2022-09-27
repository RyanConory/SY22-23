Public Class Form1
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        clear()
        highlight(Color.Orange)
    End Sub
    Sub clear()
        LengthTextBox.Clear()
        widthTextBox.Clear()
        Arealabel.Text = ""
        PerimeterLabel.Text = ""
    End Sub
    Sub highlight(C As Color)
        LengthTextBox.BackColor = C
        widthTextBox.BackColor = C
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim length As Integer
        Dim width As Integer
        Integer.TryParse(LengthTextBox.Text, length)
        Integer.TryParse(widthTextBox.Text, width)
        PerimeterLabel.Text = 2 * (length + width)
        Arealabel.Text = area(length, width)
    End Sub
    Function area(l As Integer, w As Integer) As Integer
        Return l * w
    End Function
    Function perimeter(l As Integer, w As Integer) As Integer
        Return 2 * (l + w)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button3.Click, Button1.Click
        highlight(sender.backcolor)
    End Sub
    Public Function trianglearea(base As Integer, height As Integer) As Integer
        Return (base * height) / 2
    End Function

    Private Sub triangleareabutton_Click(sender As Object, e As EventArgs) Handles triangleareabutton.Click
        Dim base As Integer
        Dim height As Integer
        Integer.TryParse(LengthTextBox.Text, height)
        Integer.TryParse(widthTextBox.Text, base)
        Arealabel.Text = trianglearea(base, height)
    End Sub
End Class