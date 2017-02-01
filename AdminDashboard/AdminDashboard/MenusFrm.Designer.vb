<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenusFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.adminTitleLbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimeLbl = New System.Windows.Forms.Label()
        Me.FormTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StockRoomLbl = New System.Windows.Forms.Label()
        Me.PharmacyStockLbl = New System.Windows.Forms.Label()
        Me.AddRemoveUserLbl = New System.Windows.Forms.Label()
        Me.EmployeesLbl = New System.Windows.Forms.Label()
        Me.PharmacySalesReportLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reportsLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ERPharmacySalesReportBtn = New System.Windows.Forms.Button()
        Me.er_pharmaStocksBtn = New System.Windows.Forms.Button()
        Me.CashierReportBtn = New System.Windows.Forms.Button()
        Me.RoomsBtn = New System.Windows.Forms.Button()
        Me.AdmissionBillingCashierBtn = New System.Windows.Forms.Button()
        Me.LaboratoryBtn = New System.Windows.Forms.Button()
        Me.PharmacySalesReportBtn = New System.Windows.Forms.Button()
        Me.EmployeesBtn = New System.Windows.Forms.Button()
        Me.addRemoveUsersBtn = New System.Windows.Forms.Button()
        Me.pharmaStocksBtn = New System.Windows.Forms.Button()
        Me.RoomStocksBtn = New System.Windows.Forms.Button()
        Me.ReportsBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.logoutBtn)
        Me.HeaderPanel.Controls.Add(Me.adminTitleLbl)
        Me.HeaderPanel.Controls.Add(Me.MenuStrip1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1133, 87)
        Me.HeaderPanel.TabIndex = 15
        '
        'logoutBtn
        '
        Me.logoutBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.logout_512
        Me.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutBtn.Location = New System.Drawing.Point(1054, 36)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(43, 41)
        Me.logoutBtn.TabIndex = 25
        Me.logoutBtn.UseVisualStyleBackColor = True
        '
        'adminTitleLbl
        '
        Me.adminTitleLbl.AutoSize = True
        Me.adminTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.adminTitleLbl.Location = New System.Drawing.Point(26, 40)
        Me.adminTitleLbl.Name = "adminTitleLbl"
        Me.adminTitleLbl.Size = New System.Drawing.Size(198, 31)
        Me.adminTitleLbl.TabIndex = 17
        Me.adminTitleLbl.Text = "ADMIN PANEL"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1133, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ChangeUsernameToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ChangeUsernameToolStripMenuItem
        '
        Me.ChangeUsernameToolStripMenuItem.Name = "ChangeUsernameToolStripMenuItem"
        Me.ChangeUsernameToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangeUsernameToolStripMenuItem.Text = "Change Username"
        '
        'DateTimeLbl
        '
        Me.DateTimeLbl.AutoSize = True
        Me.DateTimeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DateTimeLbl.Location = New System.Drawing.Point(28, 552)
        Me.DateTimeLbl.Name = "DateTimeLbl"
        Me.DateTimeLbl.Size = New System.Drawing.Size(56, 24)
        Me.DateTimeLbl.TabIndex = 18
        Me.DateTimeLbl.Text = "--/--/--"
        '
        'FormTimer
        '
        '
        'StockRoomLbl
        '
        Me.StockRoomLbl.AutoSize = True
        Me.StockRoomLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockRoomLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StockRoomLbl.Location = New System.Drawing.Point(795, 257)
        Me.StockRoomLbl.Name = "StockRoomLbl"
        Me.StockRoomLbl.Size = New System.Drawing.Size(93, 18)
        Me.StockRoomLbl.TabIndex = 20
        Me.StockRoomLbl.Text = "Stock Room"
        '
        'PharmacyStockLbl
        '
        Me.PharmacyStockLbl.AutoSize = True
        Me.PharmacyStockLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacyStockLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PharmacyStockLbl.Location = New System.Drawing.Point(40, 255)
        Me.PharmacyStockLbl.Name = "PharmacyStockLbl"
        Me.PharmacyStockLbl.Size = New System.Drawing.Size(126, 18)
        Me.PharmacyStockLbl.TabIndex = 21
        Me.PharmacyStockLbl.Text = "Pharmacy Stocks"
        '
        'AddRemoveUserLbl
        '
        Me.AddRemoveUserLbl.AutoSize = True
        Me.AddRemoveUserLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemoveUserLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddRemoveUserLbl.Location = New System.Drawing.Point(757, 480)
        Me.AddRemoveUserLbl.Name = "AddRemoveUserLbl"
        Me.AddRemoveUserLbl.Size = New System.Drawing.Size(165, 18)
        Me.AddRemoveUserLbl.TabIndex = 24
        Me.AddRemoveUserLbl.Text = "Add and Remove Users"
        '
        'EmployeesLbl
        '
        Me.EmployeesLbl.AutoSize = True
        Me.EmployeesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeesLbl.Location = New System.Drawing.Point(989, 480)
        Me.EmployeesLbl.Name = "EmployeesLbl"
        Me.EmployeesLbl.Size = New System.Drawing.Size(82, 18)
        Me.EmployeesLbl.TabIndex = 26
        Me.EmployeesLbl.Text = "Employees"
        '
        'PharmacySalesReportLbl
        '
        Me.PharmacySalesReportLbl.AutoSize = True
        Me.PharmacySalesReportLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacySalesReportLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PharmacySalesReportLbl.Location = New System.Drawing.Point(199, 257)
        Me.PharmacySalesReportLbl.Name = "PharmacySalesReportLbl"
        Me.PharmacySalesReportLbl.Size = New System.Drawing.Size(165, 18)
        Me.PharmacySalesReportLbl.TabIndex = 28
        Me.PharmacySalesReportLbl.Text = "Pharmacy Sales Report"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(199, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 36)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Laboratory-Cashier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transaction (Out Patient)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(596, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 36)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Admission-Billing to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cashier Transaction"
        '
        'reportsLbl
        '
        Me.reportsLbl.AutoSize = True
        Me.reportsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsLbl.Location = New System.Drawing.Point(376, 480)
        Me.reportsLbl.Name = "reportsLbl"
        Me.reportsLbl.Size = New System.Drawing.Size(180, 18)
        Me.reportsLbl.TabIndex = 19
        Me.reportsLbl.Text = "Cashier-Pharmacy Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(998, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Rooms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(50, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Cashier Reports"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(558, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 18)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ER-Pharmacy Sales Report"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(392, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "ER-Pharmacy Stocks"
        '
        'ERPharmacySalesReportBtn
        '
        Me.ERPharmacySalesReportBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Sales_report_icon
        Me.ERPharmacySalesReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ERPharmacySalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ERPharmacySalesReportBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERPharmacySalesReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ERPharmacySalesReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ERPharmacySalesReportBtn.Location = New System.Drawing.Point(583, 105)
        Me.ERPharmacySalesReportBtn.Name = "ERPharmacySalesReportBtn"
        Me.ERPharmacySalesReportBtn.Size = New System.Drawing.Size(141, 141)
        Me.ERPharmacySalesReportBtn.TabIndex = 40
        Me.ERPharmacySalesReportBtn.UseVisualStyleBackColor = True
        '
        'er_pharmaStocksBtn
        '
        Me.er_pharmaStocksBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Stock2_icon
        Me.er_pharmaStocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.er_pharmaStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.er_pharmaStocksBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.er_pharmaStocksBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.er_pharmaStocksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.er_pharmaStocksBtn.Location = New System.Drawing.Point(395, 105)
        Me.er_pharmaStocksBtn.Name = "er_pharmaStocksBtn"
        Me.er_pharmaStocksBtn.Size = New System.Drawing.Size(141, 141)
        Me.er_pharmaStocksBtn.TabIndex = 38
        Me.er_pharmaStocksBtn.UseVisualStyleBackColor = True
        '
        'CashierReportBtn
        '
        Me.CashierReportBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.cashier_icon
        Me.CashierReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CashierReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CashierReportBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashierReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CashierReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CashierReportBtn.Location = New System.Drawing.Point(32, 327)
        Me.CashierReportBtn.Name = "CashierReportBtn"
        Me.CashierReportBtn.Size = New System.Drawing.Size(141, 141)
        Me.CashierReportBtn.TabIndex = 36
        Me.CashierReportBtn.UseVisualStyleBackColor = True
        '
        'RoomsBtn
        '
        Me.RoomsBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.room
        Me.RoomsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoomsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomsBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RoomsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomsBtn.Location = New System.Drawing.Point(956, 105)
        Me.RoomsBtn.Name = "RoomsBtn"
        Me.RoomsBtn.Size = New System.Drawing.Size(141, 141)
        Me.RoomsBtn.TabIndex = 33
        Me.RoomsBtn.UseVisualStyleBackColor = True
        '
        'AdmissionBillingCashierBtn
        '
        Me.AdmissionBillingCashierBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.billing
        Me.AdmissionBillingCashierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdmissionBillingCashierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdmissionBillingCashierBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmissionBillingCashierBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AdmissionBillingCashierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdmissionBillingCashierBtn.Location = New System.Drawing.Point(585, 327)
        Me.AdmissionBillingCashierBtn.Name = "AdmissionBillingCashierBtn"
        Me.AdmissionBillingCashierBtn.Size = New System.Drawing.Size(141, 141)
        Me.AdmissionBillingCashierBtn.TabIndex = 31
        Me.AdmissionBillingCashierBtn.UseVisualStyleBackColor = True
        '
        'LaboratoryBtn
        '
        Me.LaboratoryBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.laboratory_icon
        Me.LaboratoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LaboratoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaboratoryBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LaboratoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LaboratoryBtn.Location = New System.Drawing.Point(210, 327)
        Me.LaboratoryBtn.Name = "LaboratoryBtn"
        Me.LaboratoryBtn.Size = New System.Drawing.Size(141, 141)
        Me.LaboratoryBtn.TabIndex = 29
        Me.LaboratoryBtn.UseVisualStyleBackColor = True
        '
        'PharmacySalesReportBtn
        '
        Me.PharmacySalesReportBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.sales
        Me.PharmacySalesReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PharmacySalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PharmacySalesReportBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PharmacySalesReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PharmacySalesReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PharmacySalesReportBtn.Location = New System.Drawing.Point(213, 105)
        Me.PharmacySalesReportBtn.Name = "PharmacySalesReportBtn"
        Me.PharmacySalesReportBtn.Size = New System.Drawing.Size(141, 141)
        Me.PharmacySalesReportBtn.TabIndex = 27
        Me.PharmacySalesReportBtn.UseVisualStyleBackColor = True
        '
        'EmployeesBtn
        '
        Me.EmployeesBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.people_icon
        Me.EmployeesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeesBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeesBtn.Location = New System.Drawing.Point(956, 327)
        Me.EmployeesBtn.Name = "EmployeesBtn"
        Me.EmployeesBtn.Size = New System.Drawing.Size(141, 141)
        Me.EmployeesBtn.TabIndex = 25
        Me.EmployeesBtn.UseVisualStyleBackColor = True
        '
        'addRemoveUsersBtn
        '
        Me.addRemoveUsersBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Administrator_icon
        Me.addRemoveUsersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addRemoveUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addRemoveUsersBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addRemoveUsersBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addRemoveUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addRemoveUsersBtn.Location = New System.Drawing.Point(769, 327)
        Me.addRemoveUsersBtn.Name = "addRemoveUsersBtn"
        Me.addRemoveUsersBtn.Size = New System.Drawing.Size(141, 141)
        Me.addRemoveUsersBtn.TabIndex = 14
        Me.addRemoveUsersBtn.UseVisualStyleBackColor = True
        '
        'pharmaStocksBtn
        '
        Me.pharmaStocksBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Stock_icon
        Me.pharmaStocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pharmaStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pharmaStocksBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharmaStocksBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pharmaStocksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pharmaStocksBtn.Location = New System.Drawing.Point(32, 105)
        Me.pharmaStocksBtn.Name = "pharmaStocksBtn"
        Me.pharmaStocksBtn.Size = New System.Drawing.Size(141, 141)
        Me.pharmaStocksBtn.TabIndex = 11
        Me.pharmaStocksBtn.UseVisualStyleBackColor = True
        '
        'RoomStocksBtn
        '
        Me.RoomStocksBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Stocks_icon
        Me.RoomStocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoomStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomStocksBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomStocksBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RoomStocksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomStocksBtn.Location = New System.Drawing.Point(769, 105)
        Me.RoomStocksBtn.Name = "RoomStocksBtn"
        Me.RoomStocksBtn.Size = New System.Drawing.Size(141, 141)
        Me.RoomStocksBtn.TabIndex = 10
        Me.RoomStocksBtn.UseVisualStyleBackColor = True
        '
        'ReportsBtn
        '
        Me.ReportsBtn.BackgroundImage = Global.AdminDashboard.My.Resources.Resources.Cashier_2_icon
        Me.ReportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportsBtn.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportsBtn.Location = New System.Drawing.Point(395, 327)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.Size = New System.Drawing.Size(141, 141)
        Me.ReportsBtn.TabIndex = 9
        Me.ReportsBtn.UseVisualStyleBackColor = True
        '
        'MenusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1133, 591)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ERPharmacySalesReportBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.er_pharmaStocksBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CashierReportBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RoomsBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AdmissionBillingCashierBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LaboratoryBtn)
        Me.Controls.Add(Me.PharmacySalesReportLbl)
        Me.Controls.Add(Me.PharmacySalesReportBtn)
        Me.Controls.Add(Me.EmployeesLbl)
        Me.Controls.Add(Me.EmployeesBtn)
        Me.Controls.Add(Me.AddRemoveUserLbl)
        Me.Controls.Add(Me.PharmacyStockLbl)
        Me.Controls.Add(Me.StockRoomLbl)
        Me.Controls.Add(Me.reportsLbl)
        Me.Controls.Add(Me.DateTimeLbl)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.addRemoveUsersBtn)
        Me.Controls.Add(Me.pharmaStocksBtn)
        Me.Controls.Add(Me.RoomStocksBtn)
        Me.Controls.Add(Me.ReportsBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menus"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoomStocksBtn As System.Windows.Forms.Button
    Friend WithEvents pharmaStocksBtn As System.Windows.Forms.Button
    Friend WithEvents addRemoveUsersBtn As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents adminTitleLbl As System.Windows.Forms.Label
    Friend WithEvents DateTimeLbl As System.Windows.Forms.Label
    Private WithEvents FormTimer As System.Windows.Forms.Timer
    Friend WithEvents StockRoomLbl As System.Windows.Forms.Label
    Friend WithEvents PharmacyStockLbl As System.Windows.Forms.Label
    Friend WithEvents AddRemoveUserLbl As System.Windows.Forms.Label
    Friend WithEvents logoutBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeesBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeesLbl As System.Windows.Forms.Label
    Friend WithEvents PharmacySalesReportBtn As System.Windows.Forms.Button
    Friend WithEvents PharmacySalesReportLbl As System.Windows.Forms.Label
    Friend WithEvents LaboratoryBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdmissionBillingCashierBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reportsLbl As System.Windows.Forms.Label
    Friend WithEvents ReportsBtn As System.Windows.Forms.Button
    Friend WithEvents RoomsBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CashierReportBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ERPharmacySalesReportBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents er_pharmaStocksBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeUsernameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
