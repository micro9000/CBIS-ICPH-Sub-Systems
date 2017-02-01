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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userNameLbl = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.userNameTxt = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(180, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ER-Pharmacy Login"
        '
        'PictureBox4
        '
        Me.PictureBox4.AccessibleDescription = ""
        Me.PictureBox4.BackgroundImage = Global.ER_Pharmacy_POS.My.Resources.Resources.user_login_icon
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(28, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(145, 110)
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = ""
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(273, 240)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(117, 43)
        Me.closeBtn.TabIndex = 17
        Me.closeBtn.Text = "CLOSE"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(19, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PASSWORD"
        '
        'userNameLbl
        '
        Me.userNameLbl.AutoSize = True
        Me.userNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.userNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.userNameLbl.Location = New System.Drawing.Point(19, 150)
        Me.userNameLbl.Name = "userNameLbl"
        Me.userNameLbl.Size = New System.Drawing.Size(125, 24)
        Me.userNameLbl.TabIndex = 15
        Me.userNameLbl.Text = "USERNAME"
        '
        'loginBtn
        '
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(150, 240)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(117, 43)
        Me.loginBtn.TabIndex = 14
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'passwordTxt
        '
        Me.passwordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTxt.Location = New System.Drawing.Point(151, 194)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTxt.Size = New System.Drawing.Size(242, 29)
        Me.passwordTxt.TabIndex = 13
        Me.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passwordTxt.UseSystemPasswordChar = True
        '
        'userNameTxt
        '
        Me.userNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameTxt.Location = New System.Drawing.Point(150, 150)
        Me.userNameTxt.Name = "userNameTxt"
        Me.userNameTxt.Size = New System.Drawing.Size(242, 29)
        Me.userNameTxt.TabIndex = 12
        Me.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 305)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userNameLbl)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.userNameTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents userNameLbl As System.Windows.Forms.Label
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents passwordTxt As System.Windows.Forms.TextBox
    Friend WithEvents userNameTxt As System.Windows.Forms.TextBox

End Class
