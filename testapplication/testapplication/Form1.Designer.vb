<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class username_txtbox
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(463, 21)
        Me.TextBox1.TabIndex = 0
        '
        'password_txtbox
        '
        Me.password_txtbox.BackColor = System.Drawing.Color.White
        Me.password_txtbox.Location = New System.Drawing.Point(112, 161)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(463, 21)
        Me.password_txtbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.Image = Global.testapplication.My.Resources.Resources.passkey_FILL0_wght400_GRAD0_opsz24
        Me.Label4.Location = New System.Drawing.Point(53, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 39)
        Me.Label4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Image = Global.testapplication.My.Resources.Resources.face_FILL0_wght400_GRAD0_opsz24
        Me.Label3.Location = New System.Drawing.Point(53, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 51)
        Me.Label3.TabIndex = 5
        '
        'l
        '
        Me.l.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.Image = Global.testapplication.My.Resources.Resources.login_FILL0_wght400_GRAD0_opsz24
        Me.l.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l.Location = New System.Drawing.Point(294, 220)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(110, 33)
        Me.l.TabIndex = 2
        Me.l.Text = "Log in"
        Me.l.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "USER LOG IN"
        '
        'username_txtbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(725, 550)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "username_txtbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents l As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
End Class
