Public Class Form1
    Private Sub btn_evaluate_Click(sender As Object, e As EventArgs) Handles btn_evaluate.Click

        Dim math As String
        Dim science As Integer
        Dim english As Boolean
        Dim grade As Double

        math = Val(math_txtbox.Text)
        science = Val(science_txtbox.Text)
        english = Val(english_txtbox.Text)

        grade = (math + science + english)
        grade = grade / 3

        If grade >= 90 Then
            MsgBox("a+")
        ElseIf grade >= 80 Then
            MsgBox("B+")
        ElseIf grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")
        End If


    End Sub



