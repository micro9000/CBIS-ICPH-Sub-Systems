<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSettingsFrm
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
        Me.adminSettingsTabCon = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UpdateUsernameBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurPasswordTxt = New System.Windows.Forms.TextBox()
        Me.NewUsernameTxt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UpdatePasswordBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurPassword2Txt = New System.Windows.Forms.TextBox()
        Me.NewPasswordTxt = New System.Windows.Forms.TextBox()
        Me.adminSettingsTabCon.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminSettingsTabCon
        '
        Me.adminSettingsTabCon.Controls.Add(Me.TabPage1)
        Me.adminSettingsTabCon.Controls.Add(Me.TabPage2)
        Me.adminSettingsTabCon.Location = New System.Drawing.Point(12, 12)
        Me.adminSettingsTabCon.Name = "adminSettingsTabCon"
        Me.adminSettingsTabCon.SelectedIndex = 0
        Me.adminSettingsTabCon.Size = New System.Drawing.Size(445, 203)
        Me.adminSettingsTabCon.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.UpdateUsernameBtn)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CurPasswordTxt)
        Me.TabPage1.Controls.Add(Me.NewUsernameTxt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(437, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change Username"
        '
        'UpdateUsernameBtn
        '
        Me.UpdateUsernameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateUsernameBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateUsernameBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UpdateUsernameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateUsernameBtn.Location = New System.Drawing.Point(209, 109)
        Me.UpdateUsernameBtn.Name = "UpdateUsernameBtn"
        Me.UpdateUsernameBtn.Size = New System.Drawing.Size(204, 45)
        Me.UpdateUsernameBtn.TabIndex = 10
        Me.UpdateUsernameBtn.Text = "Update"
        Me.UpdateUsernameBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Username"
        '
        'CurPasswordTxt
        '
        Me.CurPasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurPasswordTxt.Location = New System.Drawing.Point(209, 65)
        Me.CurPasswordTxt.Name = "CurPasswordTxt"
        Me.CurPasswordTxt.Size = New System.Drawing.Size(204, 29)
        Me.CurPasswordTxt.TabIndex = 1
        '
        'NewUsernameTxt
        '
        Me.NewUsernameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUsernameTxt.Location = New System.Drawing.Point(209, 18)
        Me.NewUsernameTxt.Name = "NewUsernameTxt"
        Me.NewUsernameTxt.Size = New System.Drawing.Size(204, 29)
        Me.NewUsernameTxt.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.UpdatePasswordBtn)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.CurPassword2Txt)
        Me.TabPage2.Controls.Add(Me.NewPasswordTxt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(437, 177)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Change Password"
        '
        'UpdatePasswordBtn
        '
        Me.UpdatePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdatePasswordBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatePasswordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UpdatePasswordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdatePasswordBtn.Location = New System.Drawing.Point(207, 114)
        Me.UpdatePasswordBtn.Name = "UpdatePasswordBtn"
        Me.UpdatePasswordBtn.Size = New System.Drawing.Size(204, 45)
        Me.UpdatePasswordBtn.TabIndex = 15
        Me.UpdatePasswordBtn.Text = "Update"
        Me.UpdatePasswordBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Current Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(15, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "New Password"
        '
        'CurPassword2Txt
        '
        Me.CurPassword2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurPassword2Txt.Location = New System.Drawing.Point(207, 70)
        Me.CurPassword2Txt.Name = "CurPassword2Txt"
        Me.CurPassword2Txt.Size = New System.Drawing.Size(204, 29)
        Me.CurPassword2Txt.TabIndex = 12
        '
        'NewPasswordTxt
        '
        Me.NewPasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordTxt.Location = New System.Drawing.Point(207, 23)
        Me.NewPasswordTxt.Name = "NewPasswordTxt"
        Me.NewPasswordTxt.Size = New System.Drawing.Size(204, 29)
        Me.NewPasswordTxt.TabIndex = 11
        '
        'AdminSettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 231)
        Me.Controls.Add(Me.adminSettingsTabCon)
        Me.Name = "AdminSettingsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminSettingsFrm"
        Me.adminSettingsTabCon.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adminSettingsTabCon As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents NewUsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurPasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UpdateUsernameBtn As System.Windows.Forms.Button
    Friend WithEvents UpdatePasswordBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CurPassword2Txt As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordTxt As System.Windows.Forms.TextBox
End Class
