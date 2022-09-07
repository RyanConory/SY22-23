Public Class Form1
    Private Sub CancelButton2_Click(sender As Object, e As EventArgs) Handles CancelButton2.Click
        Me.Close()
    End Sub

    Dim Amount As Decimal

    Private Sub BuyButton1_Click(sender As Object, e As EventArgs) Handles BuyButton1.Click
        NameTextBox.Clear()
        CCTextBox5.Clear()
        ExpTextBox4.Clear()
        AmountTextBox2.Clear()
        ZipTextBox3.Clear()
    End Sub
End Class