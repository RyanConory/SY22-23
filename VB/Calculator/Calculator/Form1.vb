Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles B2.Click, B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B1.Click, B0.Click
        DisplayTextBox.Text += sender.text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        oper = sender.text
        DisplayTextBox.Clear()
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        If oper = "+" Then
            Decimal.TryParse(DisplayTextBox.Text, second)
            DisplayTextBox.Text = first + second
        End If
        If oper = "-" Then
            Decimal.TryParse(DisplayTextBox.Text, second)
            DisplayTextBox.Text = first - second
        End If
        If oper = "/" Then
            Decimal.TryParse(DisplayTextBox.Text, second)
            DisplayTextBox.Text = first / second
        End If
        If oper = "x" Then
            Decimal.TryParse(DisplayTextBox.Text, second)
            DisplayTextBox.Text = first * second
        End If
    End Sub



    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        oper = sender.text
        DisplayTextBox.Clear()
    End Sub

    Private Sub timesButton_Click(sender As Object, e As EventArgs) Handles timesButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        oper = sender.text
        DisplayTextBox.Clear()
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        oper = sender.text
        DisplayTextBox.Clear()
    End Sub

    Private Sub SqrtB_Click(sender As Object, e As EventArgs) Handles SqrtB.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        DisplayTextBox.Text = Math.Sqrt(first)
    End Sub

    Private Sub piButton_Click(sender As Object, e As EventArgs) Handles piButton.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles CosButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        DisplayTextBox.Text = Math.Cos(first)
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        DisplayTextBox.Text = Math.Tan(first)
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, first)
        DisplayTextBox.Text = Math.Sin(first)
    End Sub

    Private Sub MButton_Click(sender As Object, e As EventArgs) Handles MButton.Click
        Decimal.TryParse(DisplayTextBox.Text, mem)
    End Sub

    Private Sub McButton_Click(sender As Object, e As EventArgs) Handles McButton.Click
        mem = 0
    End Sub

    Private Sub MrButton_Click(sender As Object, e As EventArgs) Handles MrButton.Click
        DisplayTextBox.Text = mem
    End Sub
End Class
