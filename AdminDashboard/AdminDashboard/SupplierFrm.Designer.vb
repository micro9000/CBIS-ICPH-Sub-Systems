<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierFrm
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
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.reportsFrmTitleLbl_2 = New System.Windows.Forms.Label()
        Me.companyLbl = New System.Windows.Forms.Label()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.contactNoLbl = New System.Windows.Forms.Label()
        Me.emailLbl = New System.Windows.Forms.Label()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.companyTxt = New System.Windows.Forms.TextBox()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.contactNoTxt = New System.Windows.Forms.TextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.addressTxt = New System.Windows.Forms.TextBox()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.reportsFrmTitleLbl_2)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(486, 46)
        Me.HeaderPanel.TabIndex = 18
        '
        'reportsFrmTitleLbl_2
        '
        Me.reportsFrmTitleLbl_2.AutoSize = True
        Me.reportsFrmTitleLbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_2.Location = New System.Drawing.Point(12, 9)
        Me.reportsFrmTitleLbl_2.Name = "reportsFrmTitleLbl_2"
        Me.reportsFrmTitleLbl_2.Size = New System.Drawing.Size(152, 20)
        Me.reportsFrmTitleLbl_2.TabIndex = 18
        Me.reportsFrmTitleLbl_2.Text = "Supplier Information"
        '
        'companyLbl
        '
        Me.companyLbl.AutoSize = True
        Me.companyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.companyLbl.Location = New System.Drawing.Point(12, 68)
        Me.companyLbl.Name = "companyLbl"
        Me.companyLbl.Size = New System.Drawing.Size(76, 20)
        Me.companyLbl.TabIndex = 19
        Me.companyLbl.Text = "Company"
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nameLbl.Location = New System.Drawing.Point(12, 102)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(51, 20)
        Me.nameLbl.TabIndex = 20
        Me.nameLbl.Text = "Name"
        '
        'contactNoLbl
        '
        Me.contactNoLbl.AutoSize = True
        Me.contactNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.contactNoLbl.Location = New System.Drawing.Point(12, 140)
        Me.contactNoLbl.Name = "contactNoLbl"
        Me.contactNoLbl.Size = New System.Drawing.Size(93, 20)
        Me.contactNoLbl.TabIndex = 21
        Me.contactNoLbl.Text = "Contact No."
        '
        'emailLbl
        '
        Me.emailLbl.AutoSize = True
        Me.emailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.emailLbl.Location = New System.Drawing.Point(12, 175)
        Me.emailLbl.Name = "emailLbl"
        Me.emailLbl.Size = New System.Drawing.Size(48, 20)
        Me.emailLbl.TabIndex = 22
        Me.emailLbl.Text = "Email"
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addressLbl.Location = New System.Drawing.Point(12, 207)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(68, 20)
        Me.addressLbl.TabIndex = 23
        Me.addressLbl.Text = "Address"
        '
        'companyTxt
        '
        Me.companyTxt.Enabled = False
        Me.companyTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyTxt.Location = New System.Drawing.Point(114, 68)
        Me.companyTxt.Name = "companyTxt"
        Me.companyTxt.Size = New System.Drawing.Size(342, 26)
        Me.companyTxt.TabIndex = 25
        '
        'nameTxt
        '
        Me.nameTxt.Enabled = False
        Me.nameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTxt.Location = New System.Drawing.Point(114, 102)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(342, 26)
        Me.nameTxt.TabIndex = 26
        '
        'contactNoTxt
        '
        Me.contactNoTxt.Enabled = False
        Me.contactNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNoTxt.Location = New System.Drawing.Point(114, 136)
        Me.contactNoTxt.Name = "contactNoTxt"
        Me.contactNoTxt.Size = New System.Drawing.Size(342, 26)
        Me.contactNoTxt.TabIndex = 27
        '
        'emailTxt
        '
        Me.emailTxt.Enabled = False
        Me.emailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxt.Location = New System.Drawing.Point(114, 169)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(342, 26)
        Me.emailTxt.TabIndex = 28
        '
        'addressTxt
        '
        Me.addressTxt.Enabled = False
        Me.addressTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTxt.Location = New System.Drawing.Point(114, 201)
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.Size = New System.Drawing.Size(342, 26)
        Me.addressTxt.TabIndex = 29
        '
        'SupplierFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 261)
        Me.Controls.Add(Me.addressTxt)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.contactNoTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.companyTxt)
        Me.Controls.Add(Me.addressLbl)
        Me.Controls.Add(Me.emailLbl)
        Me.Controls.Add(Me.contactNoLbl)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.companyLbl)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SupplierFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_2 As System.Windows.Forms.Label
    Friend WithEvents companyLbl As System.Windows.Forms.Label
    Friend WithEvents nameLbl As System.Windows.Forms.Label
    Friend WithEvents contactNoLbl As System.Windows.Forms.Label
    Friend WithEvents emailLbl As System.Windows.Forms.Label
    Friend WithEvents addressLbl As System.Windows.Forms.Label
    Friend WithEvents companyTxt As System.Windows.Forms.TextBox
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents contactNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents addressTxt As System.Windows.Forms.TextBox
End Class
