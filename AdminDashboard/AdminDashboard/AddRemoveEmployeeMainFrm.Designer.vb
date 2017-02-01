<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveEmployeeMainFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.addRemoveEmployeeLbl1 = New System.Windows.Forms.Label()
        Me.addRemoveEmployeeTitleLbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.emloyeeListPan = New System.Windows.Forms.Panel()
        Me.SelectUserBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.AddNewEmployeeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RemoveUserBtn = New System.Windows.Forms.Button()
        Me.AllEmployeesDGV = New System.Windows.Forms.DataGridView()
        Me.EmpId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateEmployeeInfoBtn = New System.Windows.Forms.Button()
        Me.SearchEmployeeIdLbl = New System.Windows.Forms.Label()
        Me.SearchEmployeeId = New System.Windows.Forms.TextBox()
        Me.UserInfoGBx = New System.Windows.Forms.GroupBox()
        Me.empIdtext = New System.Windows.Forms.TextBox()
        Me.IdLbl = New System.Windows.Forms.Label()
        Me.EmpTypeTxt = New System.Windows.Forms.TextBox()
        Me.EmpEmployeeTypeLbl = New System.Windows.Forms.Label()
        Me.EmpBirthDateTxt = New System.Windows.Forms.TextBox()
        Me.EmpBirthDateLbl = New System.Windows.Forms.Label()
        Me.EmpDepartment = New System.Windows.Forms.TextBox()
        Me.EmpDepartmentLbl = New System.Windows.Forms.Label()
        Me.EmpGenderTxt = New System.Windows.Forms.TextBox()
        Me.EmpGenderLbl = New System.Windows.Forms.Label()
        Me.EmpAddressTxt = New System.Windows.Forms.TextBox()
        Me.EmpFullnameTxt = New System.Windows.Forms.TextBox()
        Me.EmpAddressLbl = New System.Windows.Forms.Label()
        Me.EmpFullnameLbl = New System.Windows.Forms.Label()
        Me.SearchGbox = New System.Windows.Forms.GroupBox()
        Me.SearchUserBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.emloyeeListPan.SuspendLayout()
        CType(Me.AllEmployeesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInfoGBx.SuspendLayout()
        Me.SearchGbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.addRemoveEmployeeLbl1)
        Me.HeaderPanel.Controls.Add(Me.addRemoveEmployeeTitleLbl)
        Me.HeaderPanel.Controls.Add(Me.MenuStrip1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1106, 93)
        Me.HeaderPanel.TabIndex = 21
        '
        'addRemoveEmployeeLbl1
        '
        Me.addRemoveEmployeeLbl1.AutoSize = True
        Me.addRemoveEmployeeLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRemoveEmployeeLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addRemoveEmployeeLbl1.Location = New System.Drawing.Point(28, 64)
        Me.addRemoveEmployeeLbl1.Name = "addRemoveEmployeeLbl1"
        Me.addRemoveEmployeeLbl1.Size = New System.Drawing.Size(226, 20)
        Me.addRemoveEmployeeLbl1.TabIndex = 18
        Me.addRemoveEmployeeLbl1.Text = "Add new Employee or Remove"
        '
        'addRemoveEmployeeTitleLbl
        '
        Me.addRemoveEmployeeTitleLbl.AutoSize = True
        Me.addRemoveEmployeeTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRemoveEmployeeTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addRemoveEmployeeTitleLbl.Location = New System.Drawing.Point(12, 33)
        Me.addRemoveEmployeeTitleLbl.Name = "addRemoveEmployeeTitleLbl"
        Me.addRemoveEmployeeTitleLbl.Size = New System.Drawing.Size(370, 31)
        Me.addRemoveEmployeeTitleLbl.TabIndex = 17
        Me.addRemoveEmployeeTitleLbl.Text = "ADD/REMOVE EMPLOYEES"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentsToolStripMenuItem, Me.EmployeeTypesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1106, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.DepartmentsToolStripMenuItem.Text = "Departments"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ViewAllToolStripMenuItem.Text = "View"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EmployeeTypesToolStripMenuItem
        '
        Me.EmployeeTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.AddToolStripMenuItem1, Me.RemoveToolStripMenuItem1, Me.EditToolStripMenuItem1})
        Me.EmployeeTypesToolStripMenuItem.Name = "EmployeeTypesToolStripMenuItem"
        Me.EmployeeTypesToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.EmployeeTypesToolStripMenuItem.Text = "Employee Types"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'emloyeeListPan
        '
        Me.emloyeeListPan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emloyeeListPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emloyeeListPan.Controls.Add(Me.SelectUserBtn)
        Me.emloyeeListPan.Controls.Add(Me.RefreshBtn)
        Me.emloyeeListPan.Controls.Add(Me.AddNewEmployeeBtn)
        Me.emloyeeListPan.Controls.Add(Me.Label1)
        Me.emloyeeListPan.Controls.Add(Me.RemoveUserBtn)
        Me.emloyeeListPan.Controls.Add(Me.AllEmployeesDGV)
        Me.emloyeeListPan.Controls.Add(Me.UpdateEmployeeInfoBtn)
        Me.emloyeeListPan.Location = New System.Drawing.Point(12, 99)
        Me.emloyeeListPan.Name = "emloyeeListPan"
        Me.emloyeeListPan.Size = New System.Drawing.Size(1077, 294)
        Me.emloyeeListPan.TabIndex = 22
        '
        'SelectUserBtn
        '
        Me.SelectUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SelectUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_info
        Me.SelectUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectUserBtn.Location = New System.Drawing.Point(270, 244)
        Me.SelectUserBtn.Name = "SelectUserBtn"
        Me.SelectUserBtn.Size = New System.Drawing.Size(175, 43)
        Me.SelectUserBtn.TabIndex = 27
        Me.SelectUserBtn.Text = "Select"
        Me.SelectUserBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RefreshBtn.Image = Global.AdminDashboard.My.Resources.Resources.Graphicloads_Polygon_Refresh_4
        Me.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RefreshBtn.Location = New System.Drawing.Point(89, 244)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(175, 43)
        Me.RefreshBtn.TabIndex = 40
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'AddNewEmployeeBtn
        '
        Me.AddNewEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewEmployeeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewEmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewEmployeeBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_add
        Me.AddNewEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewEmployeeBtn.Location = New System.Drawing.Point(813, 243)
        Me.AddNewEmployeeBtn.Name = "AddNewEmployeeBtn"
        Me.AddNewEmployeeBtn.Size = New System.Drawing.Size(175, 44)
        Me.AddNewEmployeeBtn.TabIndex = 39
        Me.AddNewEmployeeBtn.Text = "Add"
        Me.AddNewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "All Employees"
        '
        'RemoveUserBtn
        '
        Me.RemoveUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_remove
        Me.RemoveUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveUserBtn.Location = New System.Drawing.Point(451, 244)
        Me.RemoveUserBtn.Name = "RemoveUserBtn"
        Me.RemoveUserBtn.Size = New System.Drawing.Size(175, 43)
        Me.RemoveUserBtn.TabIndex = 26
        Me.RemoveUserBtn.Text = "Remove"
        Me.RemoveUserBtn.UseVisualStyleBackColor = True
        '
        'AllEmployeesDGV
        '
        Me.AllEmployeesDGV.AllowUserToAddRows = False
        Me.AllEmployeesDGV.AllowUserToDeleteRows = False
        Me.AllEmployeesDGV.AllowUserToOrderColumns = True
        Me.AllEmployeesDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllEmployeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllEmployeesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllEmployeesDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AllEmployeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllEmployeesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpId, Me.FirstName, Me.MiddleName, Me.LastName, Me.Gender, Me.Address, Me.BirthDate, Me.empType, Me.department})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AllEmployeesDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.AllEmployeesDGV.Location = New System.Drawing.Point(16, 34)
        Me.AllEmployeesDGV.Name = "AllEmployeesDGV"
        Me.AllEmployeesDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllEmployeesDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AllEmployeesDGV.Size = New System.Drawing.Size(1042, 204)
        Me.AllEmployeesDGV.TabIndex = 0
        '
        'EmpId
        '
        Me.EmpId.HeaderText = "Employee Id"
        Me.EmpId.Name = "EmpId"
        Me.EmpId.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'MiddleName
        '
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'BirthDate
        '
        Me.BirthDate.HeaderText = "Birth Date"
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.ReadOnly = True
        '
        'empType
        '
        Me.empType.HeaderText = "Type"
        Me.empType.Name = "empType"
        Me.empType.ReadOnly = True
        '
        'department
        '
        Me.department.HeaderText = "Department"
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        '
        'UpdateEmployeeInfoBtn
        '
        Me.UpdateEmployeeInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateEmployeeInfoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateEmployeeInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateEmployeeInfoBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Edit_Male_User
        Me.UpdateEmployeeInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateEmployeeInfoBtn.Location = New System.Drawing.Point(632, 244)
        Me.UpdateEmployeeInfoBtn.Name = "UpdateEmployeeInfoBtn"
        Me.UpdateEmployeeInfoBtn.Size = New System.Drawing.Size(175, 43)
        Me.UpdateEmployeeInfoBtn.TabIndex = 38
        Me.UpdateEmployeeInfoBtn.Text = "Update"
        Me.UpdateEmployeeInfoBtn.UseVisualStyleBackColor = True
        '
        'SearchEmployeeIdLbl
        '
        Me.SearchEmployeeIdLbl.AutoSize = True
        Me.SearchEmployeeIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEmployeeIdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchEmployeeIdLbl.Location = New System.Drawing.Point(108, 57)
        Me.SearchEmployeeIdLbl.Name = "SearchEmployeeIdLbl"
        Me.SearchEmployeeIdLbl.Size = New System.Drawing.Size(97, 20)
        Me.SearchEmployeeIdLbl.TabIndex = 36
        Me.SearchEmployeeIdLbl.Text = "Employee Id"
        '
        'SearchEmployeeId
        '
        Me.SearchEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEmployeeId.Location = New System.Drawing.Point(56, 92)
        Me.SearchEmployeeId.Name = "SearchEmployeeId"
        Me.SearchEmployeeId.Size = New System.Drawing.Size(204, 26)
        Me.SearchEmployeeId.TabIndex = 35
        '
        'UserInfoGBx
        '
        Me.UserInfoGBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserInfoGBx.Controls.Add(Me.empIdtext)
        Me.UserInfoGBx.Controls.Add(Me.IdLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpTypeTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpEmployeeTypeLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpBirthDateTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpBirthDateLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpDepartment)
        Me.UserInfoGBx.Controls.Add(Me.EmpDepartmentLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpGenderTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpGenderLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpAddressTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpFullnameTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpAddressLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpFullnameLbl)
        Me.UserInfoGBx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UserInfoGBx.Location = New System.Drawing.Point(12, 399)
        Me.UserInfoGBx.Name = "UserInfoGBx"
        Me.UserInfoGBx.Size = New System.Drawing.Size(744, 266)
        Me.UserInfoGBx.TabIndex = 23
        Me.UserInfoGBx.TabStop = False
        Me.UserInfoGBx.Text = "Employee Information"
        '
        'empIdtext
        '
        Me.empIdtext.Enabled = False
        Me.empIdtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empIdtext.Location = New System.Drawing.Point(146, 22)
        Me.empIdtext.Name = "empIdtext"
        Me.empIdtext.Size = New System.Drawing.Size(267, 26)
        Me.empIdtext.TabIndex = 40
        '
        'IdLbl
        '
        Me.IdLbl.AutoSize = True
        Me.IdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IdLbl.Location = New System.Drawing.Point(16, 28)
        Me.IdLbl.Name = "IdLbl"
        Me.IdLbl.Size = New System.Drawing.Size(26, 20)
        Me.IdLbl.TabIndex = 39
        Me.IdLbl.Text = "ID"
        '
        'EmpTypeTxt
        '
        Me.EmpTypeTxt.Enabled = False
        Me.EmpTypeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpTypeTxt.Location = New System.Drawing.Point(444, 124)
        Me.EmpTypeTxt.Name = "EmpTypeTxt"
        Me.EmpTypeTxt.Size = New System.Drawing.Size(267, 26)
        Me.EmpTypeTxt.TabIndex = 38
        '
        'EmpEmployeeTypeLbl
        '
        Me.EmpEmployeeTypeLbl.AutoSize = True
        Me.EmpEmployeeTypeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEmployeeTypeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpEmployeeTypeLbl.Location = New System.Drawing.Point(516, 92)
        Me.EmpEmployeeTypeLbl.Name = "EmpEmployeeTypeLbl"
        Me.EmpEmployeeTypeLbl.Size = New System.Drawing.Size(117, 20)
        Me.EmpEmployeeTypeLbl.TabIndex = 37
        Me.EmpEmployeeTypeLbl.Text = "Employee Type"
        '
        'EmpBirthDateTxt
        '
        Me.EmpBirthDateTxt.Enabled = False
        Me.EmpBirthDateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpBirthDateTxt.Location = New System.Drawing.Point(444, 51)
        Me.EmpBirthDateTxt.Name = "EmpBirthDateTxt"
        Me.EmpBirthDateTxt.Size = New System.Drawing.Size(267, 26)
        Me.EmpBirthDateTxt.TabIndex = 36
        '
        'EmpBirthDateLbl
        '
        Me.EmpBirthDateLbl.AutoSize = True
        Me.EmpBirthDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpBirthDateLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpBirthDateLbl.Location = New System.Drawing.Point(528, 22)
        Me.EmpBirthDateLbl.Name = "EmpBirthDateLbl"
        Me.EmpBirthDateLbl.Size = New System.Drawing.Size(81, 20)
        Me.EmpBirthDateLbl.TabIndex = 35
        Me.EmpBirthDateLbl.Text = "Birth Date"
        '
        'EmpDepartment
        '
        Me.EmpDepartment.Enabled = False
        Me.EmpDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDepartment.Location = New System.Drawing.Point(444, 193)
        Me.EmpDepartment.Name = "EmpDepartment"
        Me.EmpDepartment.Size = New System.Drawing.Size(267, 26)
        Me.EmpDepartment.TabIndex = 34
        '
        'EmpDepartmentLbl
        '
        Me.EmpDepartmentLbl.AutoSize = True
        Me.EmpDepartmentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDepartmentLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpDepartmentLbl.Location = New System.Drawing.Point(528, 161)
        Me.EmpDepartmentLbl.Name = "EmpDepartmentLbl"
        Me.EmpDepartmentLbl.Size = New System.Drawing.Size(94, 20)
        Me.EmpDepartmentLbl.TabIndex = 33
        Me.EmpDepartmentLbl.Text = "Department"
        '
        'EmpGenderTxt
        '
        Me.EmpGenderTxt.Enabled = False
        Me.EmpGenderTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGenderTxt.Location = New System.Drawing.Point(146, 124)
        Me.EmpGenderTxt.Name = "EmpGenderTxt"
        Me.EmpGenderTxt.Size = New System.Drawing.Size(267, 26)
        Me.EmpGenderTxt.TabIndex = 32
        '
        'EmpGenderLbl
        '
        Me.EmpGenderLbl.AutoSize = True
        Me.EmpGenderLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGenderLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpGenderLbl.Location = New System.Drawing.Point(16, 127)
        Me.EmpGenderLbl.Name = "EmpGenderLbl"
        Me.EmpGenderLbl.Size = New System.Drawing.Size(63, 20)
        Me.EmpGenderLbl.TabIndex = 31
        Me.EmpGenderLbl.Text = "Gender"
        '
        'EmpAddressTxt
        '
        Me.EmpAddressTxt.Enabled = False
        Me.EmpAddressTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddressTxt.Location = New System.Drawing.Point(146, 175)
        Me.EmpAddressTxt.Multiline = True
        Me.EmpAddressTxt.Name = "EmpAddressTxt"
        Me.EmpAddressTxt.Size = New System.Drawing.Size(267, 44)
        Me.EmpAddressTxt.TabIndex = 30
        '
        'EmpFullnameTxt
        '
        Me.EmpFullnameTxt.Enabled = False
        Me.EmpFullnameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFullnameTxt.Location = New System.Drawing.Point(146, 72)
        Me.EmpFullnameTxt.Name = "EmpFullnameTxt"
        Me.EmpFullnameTxt.Size = New System.Drawing.Size(267, 26)
        Me.EmpFullnameTxt.TabIndex = 26
        '
        'EmpAddressLbl
        '
        Me.EmpAddressLbl.AutoSize = True
        Me.EmpAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddressLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpAddressLbl.Location = New System.Drawing.Point(16, 190)
        Me.EmpAddressLbl.Name = "EmpAddressLbl"
        Me.EmpAddressLbl.Size = New System.Drawing.Size(68, 20)
        Me.EmpAddressLbl.TabIndex = 27
        Me.EmpAddressLbl.Text = "Address"
        '
        'EmpFullnameLbl
        '
        Me.EmpFullnameLbl.AutoSize = True
        Me.EmpFullnameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFullnameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpFullnameLbl.Location = New System.Drawing.Point(16, 78)
        Me.EmpFullnameLbl.Name = "EmpFullnameLbl"
        Me.EmpFullnameLbl.Size = New System.Drawing.Size(78, 20)
        Me.EmpFullnameLbl.TabIndex = 26
        Me.EmpFullnameLbl.Text = "Full name"
        '
        'SearchGbox
        '
        Me.SearchGbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchGbox.Controls.Add(Me.SearchUserBtn)
        Me.SearchGbox.Controls.Add(Me.SearchEmployeeId)
        Me.SearchGbox.Controls.Add(Me.SearchEmployeeIdLbl)
        Me.SearchGbox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchGbox.Location = New System.Drawing.Point(762, 399)
        Me.SearchGbox.Name = "SearchGbox"
        Me.SearchGbox.Size = New System.Drawing.Size(327, 266)
        Me.SearchGbox.TabIndex = 39
        Me.SearchGbox.TabStop = False
        Me.SearchGbox.Text = "Search Employee"
        '
        'SearchUserBtn
        '
        Me.SearchUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_search
        Me.SearchUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchUserBtn.Location = New System.Drawing.Point(79, 148)
        Me.SearchUserBtn.Name = "SearchUserBtn"
        Me.SearchUserBtn.Size = New System.Drawing.Size(168, 45)
        Me.SearchUserBtn.TabIndex = 37
        Me.SearchUserBtn.Text = "Search"
        Me.SearchUserBtn.UseVisualStyleBackColor = True
        '
        'AddRemoveEmployeeMainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 677)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.SearchGbox)
        Me.Controls.Add(Me.UserInfoGBx)
        Me.Controls.Add(Me.emloyeeListPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1112, 706)
        Me.MinimumSize = New System.Drawing.Size(1112, 706)
        Me.Name = "AddRemoveEmployeeMainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.emloyeeListPan.ResumeLayout(False)
        Me.emloyeeListPan.PerformLayout()
        CType(Me.AllEmployeesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInfoGBx.ResumeLayout(False)
        Me.UserInfoGBx.PerformLayout()
        Me.SearchGbox.ResumeLayout(False)
        Me.SearchGbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents addRemoveEmployeeLbl1 As System.Windows.Forms.Label
    Friend WithEvents addRemoveEmployeeTitleLbl As System.Windows.Forms.Label
    Friend WithEvents emloyeeListPan As System.Windows.Forms.Panel
    Friend WithEvents SearchEmployeeIdLbl As System.Windows.Forms.Label
    Friend WithEvents SearchEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents SelectUserBtn As System.Windows.Forms.Button
    Friend WithEvents RemoveUserBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AllEmployeesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents UserInfoGBx As System.Windows.Forms.GroupBox
    Friend WithEvents EmpAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpAddressLbl As System.Windows.Forms.Label
    Friend WithEvents EmpFullnameLbl As System.Windows.Forms.Label
    Friend WithEvents EmpGenderLbl As System.Windows.Forms.Label
    Friend WithEvents EmpDepartment As System.Windows.Forms.TextBox
    Friend WithEvents EmpDepartmentLbl As System.Windows.Forms.Label
    Friend WithEvents EmpTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpEmployeeTypeLbl As System.Windows.Forms.Label
    Friend WithEvents EmpBirthDateTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpBirthDateLbl As System.Windows.Forms.Label
    Friend WithEvents EmpGenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpFullnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddNewEmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateEmployeeInfoBtn As System.Windows.Forms.Button
    Friend WithEvents SearchGbox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchUserBtn As System.Windows.Forms.Button
    Friend WithEvents EmpId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empIdtext As System.Windows.Forms.TextBox
    Friend WithEvents IdLbl As System.Windows.Forms.Label
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
