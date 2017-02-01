<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveUsersFrm
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
        Me.reportsFrmTitleLbl_1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SearchUserIdLbl = New System.Windows.Forms.Label()
        Me.SearchUserId = New System.Windows.Forms.TextBox()
        Me.SearchUserBtn = New System.Windows.Forms.Button()
        Me.UpdateUserBtn = New System.Windows.Forms.Button()
        Me.SelectUserBtn = New System.Windows.Forms.Button()
        Me.RemoveUserBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllUsersDGV = New System.Windows.Forms.DataGridView()
        Me.UsersId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddUsersGBx = New System.Windows.Forms.GroupBox()
        Me.UpdateUserBtn_addGbox = New System.Windows.Forms.Button()
        Me.HidePassLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.ViewPassLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.EmployeeIdTxt = New System.Windows.Forms.TextBox()
        Me.EmployeeIdLbl = New System.Windows.Forms.Label()
        Me.AddUserBtn = New System.Windows.Forms.Button()
        Me.UsernameLbl_add = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.UsersPasswordTxt = New System.Windows.Forms.TextBox()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.UserInfoGBx = New System.Windows.Forms.GroupBox()
        Me.UserLastLoginInfoTxt = New System.Windows.Forms.TextBox()
        Me.UserAccStatusInfoTxt = New System.Windows.Forms.TextBox()
        Me.UserDeparmentInfoTxt = New System.Windows.Forms.TextBox()
        Me.EmpFullnameInfoTxt = New System.Windows.Forms.TextBox()
        Me.LastLoginLbl = New System.Windows.Forms.Label()
        Me.AccountStatusLbl = New System.Windows.Forms.Label()
        Me.DepartmentLbl = New System.Windows.Forms.Label()
        Me.EmpFullNameLbl_info = New System.Windows.Forms.Label()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AllUsersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.AddUsersGBx.SuspendLayout()
        Me.UserInfoGBx.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.reportsFrmTitleLbl_2)
        Me.HeaderPanel.Controls.Add(Me.reportsFrmTitleLbl_1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1032, 93)
        Me.HeaderPanel.TabIndex = 20
        '
        'reportsFrmTitleLbl_2
        '
        Me.reportsFrmTitleLbl_2.AutoSize = True
        Me.reportsFrmTitleLbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_2.Location = New System.Drawing.Point(28, 53)
        Me.reportsFrmTitleLbl_2.Name = "reportsFrmTitleLbl_2"
        Me.reportsFrmTitleLbl_2.Size = New System.Drawing.Size(287, 20)
        Me.reportsFrmTitleLbl_2.TabIndex = 18
        Me.reportsFrmTitleLbl_2.Text = "Add new trusted user or Remove Users"
        '
        'reportsFrmTitleLbl_1
        '
        Me.reportsFrmTitleLbl_1.AutoSize = True
        Me.reportsFrmTitleLbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_1.Location = New System.Drawing.Point(26, 22)
        Me.reportsFrmTitleLbl_1.Name = "reportsFrmTitleLbl_1"
        Me.reportsFrmTitleLbl_1.Size = New System.Drawing.Size(298, 31)
        Me.reportsFrmTitleLbl_1.TabIndex = 17
        Me.reportsFrmTitleLbl_1.Text = "ADD/REMOVE USERS"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Controls.Add(Me.SearchUserIdLbl)
        Me.Panel1.Controls.Add(Me.SearchUserId)
        Me.Panel1.Controls.Add(Me.SearchUserBtn)
        Me.Panel1.Controls.Add(Me.UpdateUserBtn)
        Me.Panel1.Controls.Add(Me.SelectUserBtn)
        Me.Panel1.Controls.Add(Me.RemoveUserBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AllUsersDGV)
        Me.Panel1.Location = New System.Drawing.Point(12, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 285)
        Me.Panel1.TabIndex = 21
        '
        'RefreshBtn
        '
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RefreshBtn.Image = Global.AdminDashboard.My.Resources.Resources.Graphicloads_Polygon_Refresh_4
        Me.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RefreshBtn.Location = New System.Drawing.Point(471, 226)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(120, 45)
        Me.RefreshBtn.TabIndex = 37
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SearchUserIdLbl
        '
        Me.SearchUserIdLbl.AutoSize = True
        Me.SearchUserIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchUserIdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchUserIdLbl.Location = New System.Drawing.Point(21, 239)
        Me.SearchUserIdLbl.Name = "SearchUserIdLbl"
        Me.SearchUserIdLbl.Size = New System.Drawing.Size(59, 20)
        Me.SearchUserIdLbl.TabIndex = 36
        Me.SearchUserIdLbl.Text = "User id"
        '
        'SearchUserId
        '
        Me.SearchUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchUserId.Location = New System.Drawing.Point(90, 236)
        Me.SearchUserId.Name = "SearchUserId"
        Me.SearchUserId.Size = New System.Drawing.Size(202, 26)
        Me.SearchUserId.TabIndex = 35
        '
        'SearchUserBtn
        '
        Me.SearchUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_search
        Me.SearchUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchUserBtn.Location = New System.Drawing.Point(298, 226)
        Me.SearchUserBtn.Name = "SearchUserBtn"
        Me.SearchUserBtn.Size = New System.Drawing.Size(120, 45)
        Me.SearchUserBtn.TabIndex = 29
        Me.SearchUserBtn.Text = "Search"
        Me.SearchUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchUserBtn.UseVisualStyleBackColor = True
        '
        'UpdateUserBtn
        '
        Me.UpdateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Edit_Male_User
        Me.UpdateUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateUserBtn.Location = New System.Drawing.Point(723, 226)
        Me.UpdateUserBtn.Name = "UpdateUserBtn"
        Me.UpdateUserBtn.Size = New System.Drawing.Size(120, 45)
        Me.UpdateUserBtn.TabIndex = 28
        Me.UpdateUserBtn.Text = "Update"
        Me.UpdateUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateUserBtn.UseVisualStyleBackColor = True
        '
        'SelectUserBtn
        '
        Me.SelectUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SelectUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_info
        Me.SelectUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectUserBtn.Location = New System.Drawing.Point(597, 226)
        Me.SelectUserBtn.Name = "SelectUserBtn"
        Me.SelectUserBtn.Size = New System.Drawing.Size(120, 45)
        Me.SelectUserBtn.TabIndex = 27
        Me.SelectUserBtn.Text = "Select"
        Me.SelectUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SelectUserBtn.UseVisualStyleBackColor = True
        '
        'RemoveUserBtn
        '
        Me.RemoveUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_remove
        Me.RemoveUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveUserBtn.Location = New System.Drawing.Point(849, 226)
        Me.RemoveUserBtn.Name = "RemoveUserBtn"
        Me.RemoveUserBtn.Size = New System.Drawing.Size(122, 45)
        Me.RemoveUserBtn.TabIndex = 26
        Me.RemoveUserBtn.Text = "Remove"
        Me.RemoveUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveUserBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "All Users"
        '
        'AllUsersDGV
        '
        Me.AllUsersDGV.AllowUserToAddRows = False
        Me.AllUsersDGV.AllowUserToDeleteRows = False
        Me.AllUsersDGV.AllowUserToOrderColumns = True
        Me.AllUsersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllUsersDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AllUsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllUsersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsersId, Me.employeeId, Me.UsersName, Me.DateCreated, Me.DateLastUpdated})
        Me.AllUsersDGV.Location = New System.Drawing.Point(7, 33)
        Me.AllUsersDGV.Name = "AllUsersDGV"
        Me.AllUsersDGV.ReadOnly = True
        Me.AllUsersDGV.Size = New System.Drawing.Size(996, 174)
        Me.AllUsersDGV.TabIndex = 0
        '
        'UsersId
        '
        Me.UsersId.HeaderText = "Users ID"
        Me.UsersId.Name = "UsersId"
        Me.UsersId.ReadOnly = True
        '
        'employeeId
        '
        Me.employeeId.HeaderText = "Employee ID"
        Me.employeeId.Name = "employeeId"
        Me.employeeId.ReadOnly = True
        '
        'UsersName
        '
        Me.UsersName.HeaderText = "Username"
        Me.UsersName.Name = "UsersName"
        Me.UsersName.ReadOnly = True
        '
        'DateCreated
        '
        Me.DateCreated.HeaderText = "Date Created"
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.ReadOnly = True
        '
        'DateLastUpdated
        '
        Me.DateLastUpdated.HeaderText = "Last Updated"
        Me.DateLastUpdated.Name = "DateLastUpdated"
        Me.DateLastUpdated.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AddUsersGBx)
        Me.Panel2.Controls.Add(Me.UserInfoGBx)
        Me.Panel2.Location = New System.Drawing.Point(12, 402)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 255)
        Me.Panel2.TabIndex = 22
        '
        'AddUsersGBx
        '
        Me.AddUsersGBx.Controls.Add(Me.UpdateUserBtn_addGbox)
        Me.AddUsersGBx.Controls.Add(Me.HidePassLnkLbl)
        Me.AddUsersGBx.Controls.Add(Me.ViewPassLnkLbl)
        Me.AddUsersGBx.Controls.Add(Me.EmployeeIdTxt)
        Me.AddUsersGBx.Controls.Add(Me.EmployeeIdLbl)
        Me.AddUsersGBx.Controls.Add(Me.AddUserBtn)
        Me.AddUsersGBx.Controls.Add(Me.UsernameLbl_add)
        Me.AddUsersGBx.Controls.Add(Me.UsernameTxt)
        Me.AddUsersGBx.Controls.Add(Me.UsersPasswordTxt)
        Me.AddUsersGBx.Controls.Add(Me.PasswordLbl)
        Me.AddUsersGBx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddUsersGBx.Location = New System.Drawing.Point(506, 13)
        Me.AddUsersGBx.Name = "AddUsersGBx"
        Me.AddUsersGBx.Size = New System.Drawing.Size(487, 222)
        Me.AddUsersGBx.TabIndex = 1
        Me.AddUsersGBx.TabStop = False
        Me.AddUsersGBx.Text = "Add New User"
        '
        'UpdateUserBtn_addGbox
        '
        Me.UpdateUserBtn_addGbox.Enabled = False
        Me.UpdateUserBtn_addGbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateUserBtn_addGbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateUserBtn_addGbox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateUserBtn_addGbox.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_3_Edit_Male_User
        Me.UpdateUserBtn_addGbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateUserBtn_addGbox.Location = New System.Drawing.Point(310, 163)
        Me.UpdateUserBtn_addGbox.Name = "UpdateUserBtn_addGbox"
        Me.UpdateUserBtn_addGbox.Size = New System.Drawing.Size(120, 45)
        Me.UpdateUserBtn_addGbox.TabIndex = 38
        Me.UpdateUserBtn_addGbox.Text = "Update"
        Me.UpdateUserBtn_addGbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateUserBtn_addGbox.UseVisualStyleBackColor = True
        '
        'HidePassLnkLbl
        '
        Me.HidePassLnkLbl.AutoSize = True
        Me.HidePassLnkLbl.Enabled = False
        Me.HidePassLnkLbl.LinkColor = System.Drawing.Color.White
        Me.HidePassLnkLbl.Location = New System.Drawing.Point(248, 140)
        Me.HidePassLnkLbl.Name = "HidePassLnkLbl"
        Me.HidePassLnkLbl.Size = New System.Drawing.Size(78, 13)
        Me.HidePassLnkLbl.TabIndex = 38
        Me.HidePassLnkLbl.TabStop = True
        Me.HidePassLnkLbl.Text = "Hide Password"
        '
        'ViewPassLnkLbl
        '
        Me.ViewPassLnkLbl.AutoSize = True
        Me.ViewPassLnkLbl.LinkColor = System.Drawing.Color.White
        Me.ViewPassLnkLbl.Location = New System.Drawing.Point(165, 140)
        Me.ViewPassLnkLbl.Name = "ViewPassLnkLbl"
        Me.ViewPassLnkLbl.Size = New System.Drawing.Size(79, 13)
        Me.ViewPassLnkLbl.TabIndex = 37
        Me.ViewPassLnkLbl.TabStop = True
        Me.ViewPassLnkLbl.Text = "View Password"
        '
        'EmployeeIdTxt
        '
        Me.EmployeeIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdTxt.Location = New System.Drawing.Point(168, 47)
        Me.EmployeeIdTxt.Name = "EmployeeIdTxt"
        Me.EmployeeIdTxt.Size = New System.Drawing.Size(297, 26)
        Me.EmployeeIdTxt.TabIndex = 35
        '
        'EmployeeIdLbl
        '
        Me.EmployeeIdLbl.AutoSize = True
        Me.EmployeeIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeIdLbl.Location = New System.Drawing.Point(37, 53)
        Me.EmployeeIdLbl.Name = "EmployeeIdLbl"
        Me.EmployeeIdLbl.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeIdLbl.TabIndex = 36
        Me.EmployeeIdLbl.Text = "Employee ID"
        '
        'AddUserBtn
        '
        Me.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddUserBtn.Image = Global.AdminDashboard.My.Resources.Resources.Custom_Icon_Design_Flatastic_4_Male_user_add
        Me.AddUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddUserBtn.Location = New System.Drawing.Point(168, 163)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(136, 45)
        Me.AddUserBtn.TabIndex = 34
        Me.AddUserBtn.Text = "Add New"
        Me.AddUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddUserBtn.UseVisualStyleBackColor = True
        '
        'UsernameLbl_add
        '
        Me.UsernameLbl_add.AutoSize = True
        Me.UsernameLbl_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLbl_add.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UsernameLbl_add.Location = New System.Drawing.Point(37, 85)
        Me.UsernameLbl_add.Name = "UsernameLbl_add"
        Me.UsernameLbl_add.Size = New System.Drawing.Size(83, 20)
        Me.UsernameLbl_add.TabIndex = 20
        Me.UsernameLbl_add.Text = "Username"
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(168, 79)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(297, 26)
        Me.UsernameTxt.TabIndex = 0
        '
        'UsersPasswordTxt
        '
        Me.UsersPasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersPasswordTxt.Location = New System.Drawing.Point(168, 111)
        Me.UsersPasswordTxt.Name = "UsersPasswordTxt"
        Me.UsersPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UsersPasswordTxt.Size = New System.Drawing.Size(297, 26)
        Me.UsersPasswordTxt.TabIndex = 21
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PasswordLbl.Location = New System.Drawing.Point(37, 117)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(78, 20)
        Me.PasswordLbl.TabIndex = 22
        Me.PasswordLbl.Text = "Password"
        '
        'UserInfoGBx
        '
        Me.UserInfoGBx.Controls.Add(Me.UserLastLoginInfoTxt)
        Me.UserInfoGBx.Controls.Add(Me.UserAccStatusInfoTxt)
        Me.UserInfoGBx.Controls.Add(Me.UserDeparmentInfoTxt)
        Me.UserInfoGBx.Controls.Add(Me.EmpFullnameInfoTxt)
        Me.UserInfoGBx.Controls.Add(Me.LastLoginLbl)
        Me.UserInfoGBx.Controls.Add(Me.AccountStatusLbl)
        Me.UserInfoGBx.Controls.Add(Me.DepartmentLbl)
        Me.UserInfoGBx.Controls.Add(Me.EmpFullNameLbl_info)
        Me.UserInfoGBx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UserInfoGBx.Location = New System.Drawing.Point(13, 13)
        Me.UserInfoGBx.Name = "UserInfoGBx"
        Me.UserInfoGBx.Size = New System.Drawing.Size(487, 222)
        Me.UserInfoGBx.TabIndex = 0
        Me.UserInfoGBx.TabStop = False
        Me.UserInfoGBx.Text = "Users Information"
        '
        'UserLastLoginInfoTxt
        '
        Me.UserLastLoginInfoTxt.Enabled = False
        Me.UserLastLoginInfoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLastLoginInfoTxt.Location = New System.Drawing.Point(169, 144)
        Me.UserLastLoginInfoTxt.Name = "UserLastLoginInfoTxt"
        Me.UserLastLoginInfoTxt.Size = New System.Drawing.Size(297, 26)
        Me.UserLastLoginInfoTxt.TabIndex = 32
        '
        'UserAccStatusInfoTxt
        '
        Me.UserAccStatusInfoTxt.Enabled = False
        Me.UserAccStatusInfoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAccStatusInfoTxt.Location = New System.Drawing.Point(169, 112)
        Me.UserAccStatusInfoTxt.Name = "UserAccStatusInfoTxt"
        Me.UserAccStatusInfoTxt.Size = New System.Drawing.Size(297, 26)
        Me.UserAccStatusInfoTxt.TabIndex = 31
        '
        'UserDeparmentInfoTxt
        '
        Me.UserDeparmentInfoTxt.Enabled = False
        Me.UserDeparmentInfoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDeparmentInfoTxt.Location = New System.Drawing.Point(169, 79)
        Me.UserDeparmentInfoTxt.Name = "UserDeparmentInfoTxt"
        Me.UserDeparmentInfoTxt.Size = New System.Drawing.Size(297, 26)
        Me.UserDeparmentInfoTxt.TabIndex = 30
        '
        'EmpFullnameInfoTxt
        '
        Me.EmpFullnameInfoTxt.Enabled = False
        Me.EmpFullnameInfoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFullnameInfoTxt.Location = New System.Drawing.Point(169, 47)
        Me.EmpFullnameInfoTxt.Name = "EmpFullnameInfoTxt"
        Me.EmpFullnameInfoTxt.Size = New System.Drawing.Size(297, 26)
        Me.EmpFullnameInfoTxt.TabIndex = 26
        '
        'LastLoginLbl
        '
        Me.LastLoginLbl.AutoSize = True
        Me.LastLoginLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastLoginLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LastLoginLbl.Location = New System.Drawing.Point(39, 147)
        Me.LastLoginLbl.Name = "LastLoginLbl"
        Me.LastLoginLbl.Size = New System.Drawing.Size(83, 20)
        Me.LastLoginLbl.TabIndex = 29
        Me.LastLoginLbl.Text = "Last Login"
        '
        'AccountStatusLbl
        '
        Me.AccountStatusLbl.AutoSize = True
        Me.AccountStatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountStatusLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AccountStatusLbl.Location = New System.Drawing.Point(39, 118)
        Me.AccountStatusLbl.Name = "AccountStatusLbl"
        Me.AccountStatusLbl.Size = New System.Drawing.Size(119, 20)
        Me.AccountStatusLbl.TabIndex = 28
        Me.AccountStatusLbl.Text = "Account Status"
        '
        'DepartmentLbl
        '
        Me.DepartmentLbl.AutoSize = True
        Me.DepartmentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DepartmentLbl.Location = New System.Drawing.Point(39, 85)
        Me.DepartmentLbl.Name = "DepartmentLbl"
        Me.DepartmentLbl.Size = New System.Drawing.Size(94, 20)
        Me.DepartmentLbl.TabIndex = 27
        Me.DepartmentLbl.Text = "Department"
        '
        'EmpFullNameLbl_info
        '
        Me.EmpFullNameLbl_info.AutoSize = True
        Me.EmpFullNameLbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFullNameLbl_info.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpFullNameLbl_info.Location = New System.Drawing.Point(39, 53)
        Me.EmpFullNameLbl_info.Name = "EmpFullNameLbl_info"
        Me.EmpFullNameLbl_info.Size = New System.Drawing.Size(74, 20)
        Me.EmpFullNameLbl_info.TabIndex = 26
        Me.EmpFullNameLbl_info.Text = "Fullname"
        '
        'AddRemoveUsersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 669)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1038, 698)
        Me.MinimumSize = New System.Drawing.Size(1038, 698)
        Me.Name = "AddRemoveUsersFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AllUsersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.AddUsersGBx.ResumeLayout(False)
        Me.AddUsersGBx.PerformLayout()
        Me.UserInfoGBx.ResumeLayout(False)
        Me.UserInfoGBx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_2 As System.Windows.Forms.Label
    Friend WithEvents reportsFrmTitleLbl_1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AllUsersDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AddUsersGBx As System.Windows.Forms.GroupBox
    Friend WithEvents UserInfoGBx As System.Windows.Forms.GroupBox
    Friend WithEvents UsernameLbl_add As System.Windows.Forms.Label
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLbl As System.Windows.Forms.Label
    Friend WithEvents UsersPasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents RemoveUserBtn As System.Windows.Forms.Button
    Friend WithEvents SelectUserBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateUserBtn As System.Windows.Forms.Button
    Friend WithEvents LastLoginLbl As System.Windows.Forms.Label
    Friend WithEvents AccountStatusLbl As System.Windows.Forms.Label
    Friend WithEvents DepartmentLbl As System.Windows.Forms.Label
    Friend WithEvents EmpFullNameLbl_info As System.Windows.Forms.Label
    Friend WithEvents UserLastLoginInfoTxt As System.Windows.Forms.TextBox
    Friend WithEvents UserAccStatusInfoTxt As System.Windows.Forms.TextBox
    Friend WithEvents UserDeparmentInfoTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmpFullnameInfoTxt As System.Windows.Forms.TextBox
    Friend WithEvents SearchUserBtn As System.Windows.Forms.Button
    Friend WithEvents AddUserBtn As System.Windows.Forms.Button
    Friend WithEvents SearchUserIdLbl As System.Windows.Forms.Label
    Friend WithEvents SearchUserId As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIdLbl As System.Windows.Forms.Label
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents UsersId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsersName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewPassLnkLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents HidePassLnkLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents UpdateUserBtn_addGbox As System.Windows.Forms.Button
End Class
