<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_evaluate = New System.Windows.Forms.Button()
        Me.science_txtbox = New System.Windows.Forms.TextBox()
        Me.math_txtbox = New System.Windows.Forms.TextBox()
        Me.english_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_evaluate
        '
        Me.btn_evaluate.Location = New System.Drawing.Point(137, 226)
        Me.btn_evaluate.Name = "btn_evaluate"
        Me.btn_evaluate.Size = New System.Drawing.Size(80, 36)
        Me.btn_evaluate.TabIndex = 0
        Me.btn_evaluate.Text = "EVALUATE"
        Me.btn_evaluate.UseVisualStyleBackColor = True
        '
        'science_txtbox
        '
        Me.science_txtbox.Location = New System.Drawing.Point(86, 118)
        Me.science_txtbox.Name = "science_txtbox"
        Me.science_txtbox.Size = New System.Drawing.Size(192, 20)
        Me.science_txtbox.TabIndex = 1
        '
        'math_txtbox
        '
        Me.math_txtbox.Location = New System.Drawing.Point(86, 61)
        Me.math_txtbox.Name = "math_txtbox"
        Me.math_txtbox.Size = New System.Drawing.Size(192, 20)
        Me.math_txtbox.TabIndex = 2
        '
        'english_txtbox
        '
        Me.english_txtbox.Location = New System.Drawing.Point(86, 180)
        Me.english_txtbox.Name = "english_txtbox"
        Me.english_txtbox.Size = New System.Drawing.Size(192, 20)
        Me.english_txtbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "math"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "science"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "english"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 372)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.english_txtbox)
        Me.Controls.Add(Me.math_txtbox)
        Me.Controls.Add(Me.science_txtbox)
        Me.Controls.Add(Me.btn_evaluate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_evaluate As Button
    Friend WithEvents science_txtbox As TextBox
    Friend WithEvents math_txtbox As TextBox
    Friend WithEvents english_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
