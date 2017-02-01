<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomsFrm
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
        Me.adminTitleLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RoomsDGV = New System.Windows.Forms.DataGridView()
        Me.roomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UpdateRoomBtnTwo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomNumberTxt = New System.Windows.Forms.TextBox()
        Me.AddNewRoomBtn = New System.Windows.Forms.Button()
        Me.RoomsTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UpdateRoomBtn = New System.Windows.Forms.Button()
        Me.RemoveRoomBtn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RoomTypesDGVtwo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RoomTypesDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateRoomTypeBtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.UpdateRoomTypeTwoBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomPriceTxt = New System.Windows.Forms.TextBox()
        Me.RoomTypeNameLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoomTypeNameTxt = New System.Windows.Forms.TextBox()
        Me.AddRoomTypeBtn = New System.Windows.Forms.Button()
        Me.RemoveRoomTypeBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RoomsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.RoomsTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.RoomTypesDGVtwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RoomTypesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.adminTitleLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(973, 64)
        Me.HeaderPanel.TabIndex = 16
        '
        'adminTitleLbl
        '
        Me.adminTitleLbl.AutoSize = True
        Me.adminTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.adminTitleLbl.Location = New System.Drawing.Point(26, 22)
        Me.adminTitleLbl.Name = "adminTitleLbl"
        Me.adminTitleLbl.Size = New System.Drawing.Size(100, 31)
        Me.adminTitleLbl.TabIndex = 17
        Me.adminTitleLbl.Text = "Rooms"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RoomsDGV)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(26, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 454)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rooms"
        '
        'RoomsDGV
        '
        Me.RoomsDGV.AllowUserToAddRows = False
        Me.RoomsDGV.AllowUserToDeleteRows = False
        Me.RoomsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoomsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roomID, Me.roomNo, Me.roomType, Me.roomPrice})
        Me.RoomsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomsDGV.Location = New System.Drawing.Point(3, 18)
        Me.RoomsDGV.Name = "RoomsDGV"
        Me.RoomsDGV.ReadOnly = True
        Me.RoomsDGV.Size = New System.Drawing.Size(450, 433)
        Me.RoomsDGV.TabIndex = 0
        '
        'roomID
        '
        Me.roomID.HeaderText = "ID"
        Me.roomID.Name = "roomID"
        Me.roomID.ReadOnly = True
        Me.roomID.Visible = False
        '
        'roomNo
        '
        Me.roomNo.HeaderText = "Number"
        Me.roomNo.Name = "roomNo"
        Me.roomNo.ReadOnly = True
        '
        'roomType
        '
        Me.roomType.HeaderText = "Type"
        Me.roomType.Name = "roomType"
        Me.roomType.ReadOnly = True
        '
        'roomPrice
        '
        Me.roomPrice.HeaderText = "Price"
        Me.roomPrice.Name = "roomPrice"
        Me.roomPrice.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdateRoomBtnTwo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RoomNumberTxt)
        Me.GroupBox2.Controls.Add(Me.AddNewRoomBtn)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(512, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 160)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Rooms"
        '
        'UpdateRoomBtnTwo
        '
        Me.UpdateRoomBtnTwo.Enabled = False
        Me.UpdateRoomBtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRoomBtnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRoomBtnTwo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateRoomBtnTwo.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateRoomBtnTwo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateRoomBtnTwo.Location = New System.Drawing.Point(211, 80)
        Me.UpdateRoomBtnTwo.Name = "UpdateRoomBtnTwo"
        Me.UpdateRoomBtnTwo.Size = New System.Drawing.Size(119, 51)
        Me.UpdateRoomBtnTwo.TabIndex = 60
        Me.UpdateRoomBtnTwo.Text = "Update"
        Me.UpdateRoomBtnTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateRoomBtnTwo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(34, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Room Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 18
        '
        'RoomNumberTxt
        '
        Me.RoomNumberTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumberTxt.Location = New System.Drawing.Point(152, 32)
        Me.RoomNumberTxt.Name = "RoomNumberTxt"
        Me.RoomNumberTxt.Size = New System.Drawing.Size(158, 26)
        Me.RoomNumberTxt.TabIndex = 55
        '
        'AddNewRoomBtn
        '
        Me.AddNewRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewRoomBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewRoomBtn.Image = Global.AdminDashboard.My.Resources.Resources.OK
        Me.AddNewRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewRoomBtn.Location = New System.Drawing.Point(86, 80)
        Me.AddNewRoomBtn.Name = "AddNewRoomBtn"
        Me.AddNewRoomBtn.Size = New System.Drawing.Size(119, 51)
        Me.AddNewRoomBtn.TabIndex = 54
        Me.AddNewRoomBtn.Text = "Add New"
        Me.AddNewRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewRoomBtn.UseVisualStyleBackColor = True
        '
        'RoomsTabControl
        '
        Me.RoomsTabControl.Controls.Add(Me.TabPage1)
        Me.RoomsTabControl.Controls.Add(Me.TabPage2)
        Me.RoomsTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsTabControl.Location = New System.Drawing.Point(12, 70)
        Me.RoomsTabControl.Name = "RoomsTabControl"
        Me.RoomsTabControl.SelectedIndex = 0
        Me.RoomsTabControl.Size = New System.Drawing.Size(940, 520)
        Me.RoomsTabControl.TabIndex = 54
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.UpdateRoomBtn)
        Me.TabPage1.Controls.Add(Me.RemoveRoomBtn)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(932, 491)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add New Room"
        '
        'UpdateRoomBtn
        '
        Me.UpdateRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRoomBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateRoomBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateRoomBtn.Location = New System.Drawing.Point(512, 400)
        Me.UpdateRoomBtn.Name = "UpdateRoomBtn"
        Me.UpdateRoomBtn.Size = New System.Drawing.Size(119, 51)
        Me.UpdateRoomBtn.TabIndex = 59
        Me.UpdateRoomBtn.Text = "Update"
        Me.UpdateRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateRoomBtn.UseVisualStyleBackColor = True
        '
        'RemoveRoomBtn
        '
        Me.RemoveRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRoomBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveRoomBtn.Image = Global.AdminDashboard.My.Resources.Resources.cancel
        Me.RemoveRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveRoomBtn.Location = New System.Drawing.Point(637, 400)
        Me.RemoveRoomBtn.Name = "RemoveRoomBtn"
        Me.RemoveRoomBtn.Size = New System.Drawing.Size(119, 51)
        Me.RemoveRoomBtn.TabIndex = 58
        Me.RemoveRoomBtn.Text = "Remove"
        Me.RemoveRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveRoomBtn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RoomTypesDGVtwo)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(512, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(394, 193)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rooms"
        '
        'RoomTypesDGVtwo
        '
        Me.RoomTypesDGVtwo.AllowUserToAddRows = False
        Me.RoomTypesDGVtwo.AllowUserToDeleteRows = False
        Me.RoomTypesDGVtwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoomTypesDGVtwo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomTypesDGVtwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomTypesDGVtwo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RoomTypesDGVtwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomTypesDGVtwo.Location = New System.Drawing.Point(3, 18)
        Me.RoomTypesDGVtwo.Name = "RoomTypesDGVtwo"
        Me.RoomTypesDGVtwo.ReadOnly = True
        Me.RoomTypesDGVtwo.Size = New System.Drawing.Size(388, 172)
        Me.RoomTypesDGVtwo.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.UpdateRoomTypeBtn)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.RemoveRoomTypeBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(932, 491)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Types"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RoomTypesDGV)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 400)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rooms"
        '
        'RoomTypesDGV
        '
        Me.RoomTypesDGV.AllowUserToAddRows = False
        Me.RoomTypesDGV.AllowUserToDeleteRows = False
        Me.RoomTypesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoomTypesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomTypesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomTypesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.RoomTypesDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomTypesDGV.Location = New System.Drawing.Point(3, 18)
        Me.RoomTypesDGV.Name = "RoomTypesDGV"
        Me.RoomTypesDGV.ReadOnly = True
        Me.RoomTypesDGV.Size = New System.Drawing.Size(388, 379)
        Me.RoomTypesDGV.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'UpdateRoomTypeBtn
        '
        Me.UpdateRoomTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRoomTypeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRoomTypeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateRoomTypeBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateRoomTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateRoomTypeBtn.Location = New System.Drawing.Point(470, 78)
        Me.UpdateRoomTypeBtn.Name = "UpdateRoomTypeBtn"
        Me.UpdateRoomTypeBtn.Size = New System.Drawing.Size(119, 51)
        Me.UpdateRoomTypeBtn.TabIndex = 57
        Me.UpdateRoomTypeBtn.Text = "Update"
        Me.UpdateRoomTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateRoomTypeBtn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UpdateRoomTypeTwoBtn)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.RoomPriceTxt)
        Me.GroupBox4.Controls.Add(Me.RoomTypeNameLbl)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.RoomTypeNameTxt)
        Me.GroupBox4.Controls.Add(Me.AddRoomTypeBtn)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(433, 187)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 227)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add Rooms"
        '
        'UpdateRoomTypeTwoBtn
        '
        Me.UpdateRoomTypeTwoBtn.Enabled = False
        Me.UpdateRoomTypeTwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateRoomTypeTwoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRoomTypeTwoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateRoomTypeTwoBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateRoomTypeTwoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateRoomTypeTwoBtn.Location = New System.Drawing.Point(304, 134)
        Me.UpdateRoomTypeTwoBtn.Name = "UpdateRoomTypeTwoBtn"
        Me.UpdateRoomTypeTwoBtn.Size = New System.Drawing.Size(119, 51)
        Me.UpdateRoomTypeTwoBtn.TabIndex = 58
        Me.UpdateRoomTypeTwoBtn.Text = "Update"
        Me.UpdateRoomTypeTwoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateRoomTypeTwoBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(72, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Room Price"
        '
        'RoomPriceTxt
        '
        Me.RoomPriceTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomPriceTxt.Location = New System.Drawing.Point(179, 93)
        Me.RoomPriceTxt.Name = "RoomPriceTxt"
        Me.RoomPriceTxt.Size = New System.Drawing.Size(244, 26)
        Me.RoomPriceTxt.TabIndex = 57
        '
        'RoomTypeNameLbl
        '
        Me.RoomTypeNameLbl.AutoSize = True
        Me.RoomTypeNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RoomTypeNameLbl.Location = New System.Drawing.Point(33, 50)
        Me.RoomTypeNameLbl.Name = "RoomTypeNameLbl"
        Me.RoomTypeNameLbl.Size = New System.Drawing.Size(130, 20)
        Me.RoomTypeNameLbl.TabIndex = 18
        Me.RoomTypeNameLbl.Text = "Room type name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(27, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 18
        '
        'RoomTypeNameTxt
        '
        Me.RoomTypeNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeNameTxt.Location = New System.Drawing.Point(179, 47)
        Me.RoomTypeNameTxt.Name = "RoomTypeNameTxt"
        Me.RoomTypeNameTxt.Size = New System.Drawing.Size(244, 26)
        Me.RoomTypeNameTxt.TabIndex = 55
        '
        'AddRoomTypeBtn
        '
        Me.AddRoomTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRoomTypeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRoomTypeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddRoomTypeBtn.Image = Global.AdminDashboard.My.Resources.Resources.OK
        Me.AddRoomTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRoomTypeBtn.Location = New System.Drawing.Point(179, 134)
        Me.AddRoomTypeBtn.Name = "AddRoomTypeBtn"
        Me.AddRoomTypeBtn.Size = New System.Drawing.Size(119, 51)
        Me.AddRoomTypeBtn.TabIndex = 54
        Me.AddRoomTypeBtn.Text = "Add New"
        Me.AddRoomTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddRoomTypeBtn.UseVisualStyleBackColor = True
        '
        'RemoveRoomTypeBtn
        '
        Me.RemoveRoomTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRoomTypeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRoomTypeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveRoomTypeBtn.Image = Global.AdminDashboard.My.Resources.Resources.cancel
        Me.RemoveRoomTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveRoomTypeBtn.Location = New System.Drawing.Point(627, 78)
        Me.RemoveRoomTypeBtn.Name = "RemoveRoomTypeBtn"
        Me.RemoveRoomTypeBtn.Size = New System.Drawing.Size(119, 51)
        Me.RemoveRoomTypeBtn.TabIndex = 56
        Me.RemoveRoomTypeBtn.Text = "Remove"
        Me.RemoveRoomTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveRoomTypeBtn.UseVisualStyleBackColor = True
        '
        'RoomsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(973, 602)
        Me.Controls.Add(Me.RoomsTabControl)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RoomsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RoomsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.RoomsTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.RoomTypesDGVtwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.RoomTypesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents adminTitleLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AddNewRoomBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RoomNumberTxt As System.Windows.Forms.TextBox
    Friend WithEvents RoomsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomTypesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents UpdateRoomTypeBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RoomTypeNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddRoomTypeBtn As System.Windows.Forms.Button
    Friend WithEvents RemoveRoomTypeBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roomID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roomNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roomType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roomPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RoomPriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents UpdateRoomTypeTwoBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomTypesDGVtwo As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RemoveRoomBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateRoomBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateRoomBtnTwo As System.Windows.Forms.Button
End Class
