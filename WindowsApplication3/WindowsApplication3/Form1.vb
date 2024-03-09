Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VarName As String = "HEELO"
        'Dim Age As String = 20

        'Const MaxSize As Integer = 999


        'Dim stringVar As String
        'Dim IntVar As String
        'Dim BooleanVar As String
        'Dim DecimalVar As String


        'stringVar = "this is string"
        'IntVar = 777777
        'BooleanVar = False
        'DecimalVar = 77.77777

        ''WRITE  COMMENTS  USING  SINGLE  '


        ''ARITHMETIC OPERATORS
        'Age = Age + 34
        'Age = Age - 10
        'Age = Age / 34
        'Age = Age * 20


        ''ASSIGNMENT OPERATORS
        'Dim Firstname As String
        'Firstname = "inserting value using equal (=) assignment operators"
        ''COMPARISON OPERATORS
        '' = 
        'If (1 = 1) Then
        '    MsgBox("TRUE")
        'End If
        '' <> not equal
        'If (45 <> 78) Then
        '    MsgBox("TRUE")
        'End If
        ''graterthan
        'If (100 > 85) Then
        '    MsgBox("TRUE")
        'End If
        ''lessthan
        'If (35 < 65) Then
        '    MsgBox("TRUE")
        'End If
        ''greaterthan equal
        'If (100 >= 99) Then
        '    MsgBox("TRUE")
        'End If
        ''lessthan equal
        'If (100 <= 101) Then
        '    MsgBox("TRUE")
        'End If


        'If Age = 10 Then
        '    'TRUE
        '    MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")

        'End If

        'If Age = 11 Then
        '    'TRUE
        '    MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")
        'Else
        '    'FALSE
        '    MessageBox.Show("ITS FALSE,AGE IS NOT EQUAL TO 10")
        'End If

        'If Age = 10 Then
        '    If Age = 9 Then
        '        'TRUE
        '        MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10 & greaterthan 9")

        '        If Age > 0 Then
        '            'TRUE
        '            MessageBox.Show("ITS TRUE age is greater then 0")
        '        End If
        '    End If
        'Else
        '    If Age > 11 Then
        '        'FALSE
        '        MessageBox.Show("ITS FALSE,AGE IS NOT greater then TO 11")
        '    End If

        'End If


        'Dim grade As Char
        'grade = "B"
        'Select Case grade
        '    Case "A"
        '        MessageBox.show("Excellent")
        '    Case "B", "C"
        '        MessageBox.Show("Well done")
        '    Case "D"
        '        MessageBox.Show("You passed")
        '    Case "F"
        '        MessageBox.Show("Better try again")
        '    Case Else
        '        MessageBox.Show("Invalid grade")
        'End Select



























    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles age_textbox.TextChanged

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btn_evaluate_click.Click
        Dim AGE As Integer = Convert.ToDecimal(age_textbox.Text)

        If AGE >= 100 Then
            MsgBox("DINOSAUR AGE")
        ElseIf AGE >= 90 Then
            MsgBox("century Age")
        ElseIf AGE >= 80 Then
            MsgBox("grandfather Age")
        ElseIf AGE >= 60 Then
            MsgBox("senior citizen Age")
        ElseIf AGE >= 45 Then
            MsgBox("Middle Age")
        Else
            MsgBox("Unknown Age")


        End If

    End Sub
End Class
