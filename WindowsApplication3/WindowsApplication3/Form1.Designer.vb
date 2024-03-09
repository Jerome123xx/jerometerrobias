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
        Me.btn_evaluate_click = New System.Windows.Forms.Button()
        Me.age_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_evaluate_click
        '
        Me.btn_evaluate_click.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_evaluate_click.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_evaluate_click.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_evaluate_click.Location = New System.Drawing.Point(99, 95)
        Me.btn_evaluate_click.Name = "btn_evaluate_click"
        Me.btn_evaluate_click.Size = New System.Drawing.Size(86, 31)
        Me.btn_evaluate_click.TabIndex = 0
        Me.btn_evaluate_click.Text = "EVALUATE"
        Me.btn_evaluate_click.UseVisualStyleBackColor = False
        '
        'age_textbox
        '
        Me.age_textbox.Location = New System.Drawing.Point(12, 40)
        Me.age_textbox.Name = "age_textbox"
        Me.age_textbox.Size = New System.Drawing.Size(257, 20)
        Me.age_textbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Textbox"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.age_textbox)
        Me.Controls.Add(Me.btn_evaluate_click)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_evaluate_click As Button
    Friend WithEvents age_textbox As TextBox
    Friend WithEvents Label1 As Label
End Class
