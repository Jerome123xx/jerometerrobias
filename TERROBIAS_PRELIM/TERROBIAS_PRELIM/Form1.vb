Public Class Form1
    Private ReadOnly txt_total As Object
    Private firstval As Double
    Public Property txt_txtbox As Object
    Public Property [Operator] As String

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_txtbox.Text = txt_total.Text & sender.Text


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles times_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Fucos()



    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles plus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Fucos()
        [Operator] = "+"


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        Secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case = "+"








    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Fucos()
        [Operator] = "-"


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles divide_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Fucos()
        [Operator] = "/"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Fucos()
        [Operator] = "c"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim firstval As Double
        Dim secondval As Double
        Dim [Operator] As Double

    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub
End Class
