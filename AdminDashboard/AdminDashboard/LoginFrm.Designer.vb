<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrm
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
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoginBtn.Location = New System.Drawing.Point(166, 200)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(99, 47)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(166, 120)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(211, 31)
        Me.UsernameTxt.TabIndex = 2
        Me.UsernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.Location = New System.Drawing.Point(167, 163)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.Size = New System.Drawing.Size(210, 31)
        Me.PasswordTxt.TabIndex = 3
        Me.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UsernameLbl.Location = New System.Drawing.Point(36, 120)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(110, 25)
        Me.UsernameLbl.TabIndex = 4
        Me.UsernameLbl.Text = "Username"
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PasswordLbl.Location = New System.Drawing.Point(36, 157)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(106, 25)
        Me.PasswordLbl.TabIndex = 5
        Me.PasswordLbl.Text = "Password"
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseBtn.Location = New System.Drawing.Point(271, 200)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(106, 47)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(120, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ADMIN LOGIN"
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 303)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.UsernameLbl)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.Controls.Add(Me.LoginBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(444, 332)
        Me.MinimumSize = New System.Drawing.Size(444, 332)
        Me.Name = "LoginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLbl As System.Windows.Forms.Label
    Friend WithEvents PasswordLbl As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
