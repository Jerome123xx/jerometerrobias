Public Class Form1
    Dim firstval As Double
    Dim secondval As Double
    Dim [Operator] As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles plus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "+"
        txt_total.Text = ""


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "-"
        txt_total.Text = ""


    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub multiplication_btn_Click(sender As Object, e As EventArgs) Handles multiplication_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "*"
        txt_total.Text = ""


    End Sub

    Private Sub equal_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + secondval
                txt_total.Text = Result.ToString()
            Case = "-"
                Result = firstval - secondval
                txt_total.Text = Result.ToString()
            Case = "*"
                Result = firstval * secondval
                txt_total.Text = Result.ToString()
            Case = "/"
                Result = firstval / secondval
                txt_total.Text = Result.ToString()






        End Select
    End Sub

    Private Sub division_btn_Click(sender As Object, e As EventArgs) Handles division_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "/"
        txt_total.Text = ""


    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.text

    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.text


    End Sub
End Class
