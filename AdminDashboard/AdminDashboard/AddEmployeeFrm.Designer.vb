<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeFrm
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
        Me.addRemoveEmployeeTitleLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnameError = New System.Windows.Forms.Label()
        Me.depError = New System.Windows.Forms.Label()
        Me.empTypeError = New System.Windows.Forms.Label()
        Me.bdateError = New System.Windows.Forms.Label()
        Me.addressError = New System.Windows.Forms.Label()
        Me.genderError = New System.Windows.Forms.Label()
        Me.mnameError = New System.Windows.Forms.Label()
        Me.fnameError = New System.Windows.Forms.Label()
        Me.EmpDepartmentCBox = New System.Windows.Forms.ComboBox()
        Me.EmpTypeCBox = New System.Windows.Forms.ComboBox()
        Me.EmpBrithDateDPkr = New System.Windows.Forms.DateTimePicker()
        Me.EmpGenderCbox = New System.Windows.Forms.ComboBox()
        Me.EmpLastNameTxt = New System.Windows.Forms.TextBox()
        Me.EmpLastNameLbl = New System.Windows.Forms.Label()
        Me.EmpMiddleNameTxt = New System.Windows.Forms.TextBox()
        Me.EmpMiddleNameLbl = New System.Windows.Forms.Label()
        Me.EmpEmployeeTypeLbl1 = New System.Windows.Forms.Label()
        Me.EmpBirthDateLbl1 = New System.Windows.Forms.Label()
        Me.EmpDepartmentLbl1 = New System.Windows.Forms.Label()
        Me.EmpGenderLbl1 = New System.Windows.Forms.Label()
        Me.EmpAddressTxt = New System.Windows.Forms.TextBox()
        Me.EmpFirstNameTxt = New System.Windows.Forms.TextBox()
        Me.EmpAddressLbl1 = New System.Windows.Forms.Label()
        Me.EmpFirstNameLbl = New System.Windows.Forms.Label()
        Me.AddNewEmployeeBtn = New System.Windows.Forms.Button()
        Me.UpdateEmployeeInfoBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.addRemoveEmployeeTitleLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(558, 65)
        Me.HeaderPanel.TabIndex = 22
        '
        'addRemoveEmployeeTitleLbl
        '
        Me.addRemoveEmployeeTitleLbl.AutoSize = True
        Me.addRemoveEmployeeTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRemoveEmployeeTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addRemoveEmployeeTitleLbl.Location = New System.Drawing.Point(26, 22)
        Me.addRemoveEmployeeTitleLbl.Name = "addRemoveEmployeeTitleLbl"
        Me.addRemoveEmployeeTitleLbl.Size = New System.Drawing.Size(57, 31)
        Me.addRemoveEmployeeTitleLbl.TabIndex = 17
        Me.addRemoveEmployeeTitleLbl.Text = "title"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnameError)
        Me.GroupBox1.Controls.Add(Me.depError)
        Me.GroupBox1.Controls.Add(Me.empTypeError)
        Me.GroupBox1.Controls.Add(Me.bdateError)
        Me.GroupBox1.Controls.Add(Me.addressError)
        Me.GroupBox1.Controls.Add(Me.genderError)
        Me.GroupBox1.Controls.Add(Me.mnameError)
        Me.GroupBox1.Controls.Add(Me.fnameError)
        Me.GroupBox1.Controls.Add(Me.EmpDepartmentCBox)
        Me.GroupBox1.Controls.Add(Me.EmpTypeCBox)
        Me.GroupBox1.Controls.Add(Me.EmpBrithDateDPkr)
        Me.GroupBox1.Controls.Add(Me.EmpGenderCbox)
        Me.GroupBox1.Controls.Add(Me.EmpLastNameTxt)
        Me.GroupBox1.Controls.Add(Me.EmpLastNameLbl)
        Me.GroupBox1.Controls.Add(Me.EmpMiddleNameTxt)
        Me.GroupBox1.Controls.Add(Me.EmpMiddleNameLbl)
        Me.GroupBox1.Controls.Add(Me.AddNewEmployeeBtn)
        Me.GroupBox1.Controls.Add(Me.EmpEmployeeTypeLbl1)
        Me.GroupBox1.Controls.Add(Me.UpdateEmployeeInfoBtn)
        Me.GroupBox1.Controls.Add(Me.EmpBirthDateLbl1)
        Me.GroupBox1.Controls.Add(Me.EmpDepartmentLbl1)
        Me.GroupBox1.Controls.Add(Me.EmpGenderLbl1)
        Me.GroupBox1.Controls.Add(Me.EmpAddressTxt)
        Me.GroupBox1.Controls.Add(Me.EmpFirstNameTxt)
        Me.GroupBox1.Controls.Add(Me.EmpAddressLbl1)
        Me.GroupBox1.Controls.Add(Me.EmpFirstNameLbl)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 474)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'lnameError
        '
        Me.lnameError.AutoSize = True
        Me.lnameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnameError.ForeColor = System.Drawing.Color.Red
        Me.lnameError.Location = New System.Drawing.Point(473, 114)
        Me.lnameError.Name = "lnameError"
        Me.lnameError.Size = New System.Drawing.Size(15, 20)
        Me.lnameError.TabIndex = 54
        Me.lnameError.Text = "*"
        Me.lnameError.Visible = False
        '
        'depError
        '
        Me.depError.AutoSize = True
        Me.depError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depError.ForeColor = System.Drawing.Color.Red
        Me.depError.Location = New System.Drawing.Point(473, 347)
        Me.depError.Name = "depError"
        Me.depError.Size = New System.Drawing.Size(15, 20)
        Me.depError.TabIndex = 53
        Me.depError.Text = "*"
        Me.depError.Visible = False
        '
        'empTypeError
        '
        Me.empTypeError.AutoSize = True
        Me.empTypeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empTypeError.ForeColor = System.Drawing.Color.Red
        Me.empTypeError.Location = New System.Drawing.Point(473, 304)
        Me.empTypeError.Name = "empTypeError"
        Me.empTypeError.Size = New System.Drawing.Size(15, 20)
        Me.empTypeError.TabIndex = 52
        Me.empTypeError.Text = "*"
        Me.empTypeError.Visible = False
        '
        'bdateError
        '
        Me.bdateError.AutoSize = True
        Me.bdateError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdateError.ForeColor = System.Drawing.Color.Red
        Me.bdateError.Location = New System.Drawing.Point(473, 265)
        Me.bdateError.Name = "bdateError"
        Me.bdateError.Size = New System.Drawing.Size(15, 20)
        Me.bdateError.TabIndex = 51
        Me.bdateError.Text = "*"
        Me.bdateError.Visible = False
        '
        'addressError
        '
        Me.addressError.AutoSize = True
        Me.addressError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressError.ForeColor = System.Drawing.Color.Red
        Me.addressError.Location = New System.Drawing.Point(473, 222)
        Me.addressError.Name = "addressError"
        Me.addressError.Size = New System.Drawing.Size(15, 20)
        Me.addressError.TabIndex = 50
        Me.addressError.Text = "*"
        Me.addressError.Visible = False
        '
        'genderError
        '
        Me.genderError.AutoSize = True
        Me.genderError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderError.ForeColor = System.Drawing.Color.Red
        Me.genderError.Location = New System.Drawing.Point(297, 161)
        Me.genderError.Name = "genderError"
        Me.genderError.Size = New System.Drawing.Size(15, 20)
        Me.genderError.TabIndex = 49
        Me.genderError.Text = "*"
        Me.genderError.Visible = False
        '
        'mnameError
        '
        Me.mnameError.AutoSize = True
        Me.mnameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnameError.ForeColor = System.Drawing.Color.Red
        Me.mnameError.Location = New System.Drawing.Point(473, 72)
        Me.mnameError.Name = "mnameError"
        Me.mnameError.Size = New System.Drawing.Size(15, 20)
        Me.mnameError.TabIndex = 48
        Me.mnameError.Text = "*"
        Me.mnameError.Visible = False
        '
        'fnameError
        '
        Me.fnameError.AutoSize = True
        Me.fnameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameError.ForeColor = System.Drawing.Color.Red
        Me.fnameError.Location = New System.Drawing.Point(473, 34)
        Me.fnameError.Name = "fnameError"
        Me.fnameError.Size = New System.Drawing.Size(15, 20)
        Me.fnameError.TabIndex = 47
        Me.fnameError.Text = "*"
        Me.fnameError.Visible = False
        '
        'EmpDepartmentCBox
        '
        Me.EmpDepartmentCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EmpDepartmentCBox.FormattingEnabled = True
        Me.EmpDepartmentCBox.Location = New System.Drawing.Point(170, 339)
        Me.EmpDepartmentCBox.Name = "EmpDepartmentCBox"
        Me.EmpDepartmentCBox.Size = New System.Drawing.Size(297, 28)
        Me.EmpDepartmentCBox.TabIndex = 46
        '
        'EmpTypeCBox
        '
        Me.EmpTypeCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EmpTypeCBox.FormattingEnabled = True
        Me.EmpTypeCBox.Location = New System.Drawing.Point(170, 296)
        Me.EmpTypeCBox.Name = "EmpTypeCBox"
        Me.EmpTypeCBox.Size = New System.Drawing.Size(297, 28)
        Me.EmpTypeCBox.TabIndex = 45
        '
        'EmpBrithDateDPkr
        '
        Me.EmpBrithDateDPkr.CustomFormat = ""
        Me.EmpBrithDateDPkr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EmpBrithDateDPkr.Location = New System.Drawing.Point(170, 259)
        Me.EmpBrithDateDPkr.Name = "EmpBrithDateDPkr"
        Me.EmpBrithDateDPkr.Size = New System.Drawing.Size(297, 26)
        Me.EmpBrithDateDPkr.TabIndex = 44
        '
        'EmpGenderCbox
        '
        Me.EmpGenderCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EmpGenderCbox.FormattingEnabled = True
        Me.EmpGenderCbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.EmpGenderCbox.Location = New System.Drawing.Point(170, 153)
        Me.EmpGenderCbox.Name = "EmpGenderCbox"
        Me.EmpGenderCbox.Size = New System.Drawing.Size(121, 28)
        Me.EmpGenderCbox.TabIndex = 43
        '
        'EmpLastNameTxt
        '
        Me.EmpLastNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpLastNameTxt.Location = New System.Drawing.Point(170, 111)
        Me.EmpLastNameTxt.Name = "EmpLastNameTxt"
        Me.EmpLastNameTxt.Size = New System.Drawing.Size(297, 26)
        Me.EmpLastNameTxt.TabIndex = 42
        '
        'EmpLastNameLbl
        '
        Me.EmpLastNameLbl.AutoSize = True
        Me.EmpLastNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpLastNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpLastNameLbl.Location = New System.Drawing.Point(40, 114)
        Me.EmpLastNameLbl.Name = "EmpLastNameLbl"
        Me.EmpLastNameLbl.Size = New System.Drawing.Size(86, 20)
        Me.EmpLastNameLbl.TabIndex = 41
        Me.EmpLastNameLbl.Text = "Last Name"
        '
        'EmpMiddleNameTxt
        '
        Me.EmpMiddleNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpMiddleNameTxt.Location = New System.Drawing.Point(170, 69)
        Me.EmpMiddleNameTxt.Name = "EmpMiddleNameTxt"
        Me.EmpMiddleNameTxt.Size = New System.Drawing.Size(297, 26)
        Me.EmpMiddleNameTxt.TabIndex = 40
        '
        'EmpMiddleNameLbl
        '
        Me.EmpMiddleNameLbl.AutoSize = True
        Me.EmpMiddleNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpMiddleNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpMiddleNameLbl.Location = New System.Drawing.Point(40, 72)
        Me.EmpMiddleNameLbl.Name = "EmpMiddleNameLbl"
        Me.EmpMiddleNameLbl.Size = New System.Drawing.Size(101, 20)
        Me.EmpMiddleNameLbl.TabIndex = 39
        Me.EmpMiddleNameLbl.Text = "Middle Name"
        '
        'EmpEmployeeTypeLbl1
        '
        Me.EmpEmployeeTypeLbl1.AutoSize = True
        Me.EmpEmployeeTypeLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEmployeeTypeLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpEmployeeTypeLbl1.Location = New System.Drawing.Point(40, 296)
        Me.EmpEmployeeTypeLbl1.Name = "EmpEmployeeTypeLbl1"
        Me.EmpEmployeeTypeLbl1.Size = New System.Drawing.Size(117, 20)
        Me.EmpEmployeeTypeLbl1.TabIndex = 37
        Me.EmpEmployeeTypeLbl1.Text = "Employee Type"
        '
        'EmpBirthDateLbl1
        '
        Me.EmpBirthDateLbl1.AutoSize = True
        Me.EmpBirthDateLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpBirthDateLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpBirthDateLbl1.Location = New System.Drawing.Point(40, 264)
        Me.EmpBirthDateLbl1.Name = "EmpBirthDateLbl1"
        Me.EmpBirthDateLbl1.Size = New System.Drawing.Size(81, 20)
        Me.EmpBirthDateLbl1.TabIndex = 35
        Me.EmpBirthDateLbl1.Text = "Birth Date"
        '
        'EmpDepartmentLbl1
        '
        Me.EmpDepartmentLbl1.AutoSize = True
        Me.EmpDepartmentLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDepartmentLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpDepartmentLbl1.Location = New System.Drawing.Point(40, 342)
        Me.EmpDepartmentLbl1.Name = "EmpDepartmentLbl1"
        Me.EmpDepartmentLbl1.Size = New System.Drawing.Size(94, 20)
        Me.EmpDepartmentLbl1.TabIndex = 33
        Me.EmpDepartmentLbl1.Text = "Department"
        '
        'EmpGenderLbl1
        '
        Me.EmpGenderLbl1.AutoSize = True
        Me.EmpGenderLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGenderLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpGenderLbl1.Location = New System.Drawing.Point(40, 161)
        Me.EmpGenderLbl1.Name = "EmpGenderLbl1"
        Me.EmpGenderLbl1.Size = New System.Drawing.Size(63, 20)
        Me.EmpGenderLbl1.TabIndex = 31
        Me.EmpGenderLbl1.Text = "Gender"
        '
        'EmpAddressTxt
        '
        Me.EmpAddressTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddressTxt.Location = New System.Drawing.Point(170, 198)
        Me.EmpAddressTxt.Multiline = True
        Me.EmpAddressTxt.Name = "EmpAddressTxt"
        Me.EmpAddressTxt.Size = New System.Drawing.Size(297, 44)
        Me.EmpAddressTxt.TabIndex = 30
        '
        'EmpFirstNameTxt
        '
        Me.EmpFirstNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFirstNameTxt.Location = New System.Drawing.Point(170, 28)
        Me.EmpFirstNameTxt.Name = "EmpFirstNameTxt"
        Me.EmpFirstNameTxt.Size = New System.Drawing.Size(297, 26)
        Me.EmpFirstNameTxt.TabIndex = 26
        '
        'EmpAddressLbl1
        '
        Me.EmpAddressLbl1.AutoSize = True
        Me.EmpAddressLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddressLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpAddressLbl1.Location = New System.Drawing.Point(40, 213)
        Me.EmpAddressLbl1.Name = "EmpAddressLbl1"
        Me.EmpAddressLbl1.Size = New System.Drawing.Size(68, 20)
        Me.EmpAddressLbl1.TabIndex = 27
        Me.EmpAddressLbl1.Text = "Address"
        '
        'EmpFirstNameLbl
        '
        Me.EmpFirstNameLbl.AutoSize = True
        Me.EmpFirstNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFirstNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpFirstNameLbl.Location = New System.Drawing.Point(40, 34)
        Me.EmpFirstNameLbl.Name = "EmpFirstNameLbl"
        Me.EmpFirstNameLbl.Size = New System.Drawing.Size(86, 20)
        Me.EmpFirstNameLbl.TabIndex = 26
        Me.EmpFirstNameLbl.Text = "First Name"
        '
        'AddNewEmployeeBtn
        '
        Me.AddNewEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewEmployeeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewEmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewEmployeeBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_add
        Me.AddNewEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewEmployeeBtn.Location = New System.Drawing.Point(333, 384)
        Me.AddNewEmployeeBtn.Name = "AddNewEmployeeBtn"
        Me.AddNewEmployeeBtn.Size = New System.Drawing.Size(113, 57)
        Me.AddNewEmployeeBtn.TabIndex = 37
        Me.AddNewEmployeeBtn.Text = "Add"
        Me.AddNewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'UpdateEmployeeInfoBtn
        '
        Me.UpdateEmployeeInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateEmployeeInfoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateEmployeeInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateEmployeeInfoBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Edit_Male_User
        Me.UpdateEmployeeInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateEmployeeInfoBtn.Location = New System.Drawing.Point(193, 384)
        Me.UpdateEmployeeInfoBtn.Name = "UpdateEmployeeInfoBtn"
        Me.UpdateEmployeeInfoBtn.Size = New System.Drawing.Size(113, 57)
        Me.UpdateEmployeeInfoBtn.TabIndex = 28
        Me.UpdateEmployeeInfoBtn.Text = "Update"
        Me.UpdateEmployeeInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateEmployeeInfoBtn.UseVisualStyleBackColor = True
        '
        'AddEmployeeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(564, 596)
        Me.MinimumSize = New System.Drawing.Size(564, 596)
        Me.Name = "AddEmployeeFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents addRemoveEmployeeTitleLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddNewEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents EmpEmployeeTypeLbl1 As System.Windows.Forms.Label
    Friend WithEvents EmpBirthDateLbl1 As System.Windows.Forms.Label
    Friend WithEvents UpdateEmployeeInfoBtn As System.Windows.Forms.Button
    Friend WithEvents EmpDepartmentLbl1 As System.Windows.Forms.Label
    Friend WithEvents EmpGenderLbl1 As System.Windows.Forms.Label
    Friend WithEvents EmpAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpFirstNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpAddressLbl1 As System.Windows.Forms.Label
    Friend WithEvents EmpFirstNameLbl As System.Windows.Forms.Label
    Friend WithEvents EmpLastNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpLastNameLbl As System.Windows.Forms.Label
    Friend WithEvents EmpMiddleNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpMiddleNameLbl As System.Windows.Forms.Label
    Friend WithEvents EmpGenderCbox As System.Windows.Forms.ComboBox
    Friend WithEvents EmpBrithDateDPkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmpTypeCBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmpDepartmentCBox As System.Windows.Forms.ComboBox
    Friend WithEvents depError As System.Windows.Forms.Label
    Friend WithEvents empTypeError As System.Windows.Forms.Label
    Friend WithEvents bdateError As System.Windows.Forms.Label
    Friend WithEvents addressError As System.Windows.Forms.Label
    Friend WithEvents genderError As System.Windows.Forms.Label
    Friend WithEvents mnameError As System.Windows.Forms.Label
    Friend WithEvents fnameError As System.Windows.Forms.Label
    Friend WithEvents lnameError As System.Windows.Forms.Label
End Class
