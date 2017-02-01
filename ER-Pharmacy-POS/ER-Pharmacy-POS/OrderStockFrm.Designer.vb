<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderStocksFrm
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
        Me.o_headerPan = New System.Windows.Forms.Panel()
        Me.RequestsStatusLbl = New System.Windows.Forms.Label()
        Me.RequestsStatusLblLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.o_bodyPan = New System.Windows.Forms.Panel()
        Me.SearchMedTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OrderListDGV = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductListDGV_Order = New System.Windows.Forms.DataGridView()
        Me.prodId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.prodGenNameTxt = New System.Windows.Forms.TextBox()
        Me.prodGenNameLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.AddStocksNowBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.SaveThisBtn = New System.Windows.Forms.Button()
        Me.stocksQuantityTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prodBrandNameTxt = New System.Windows.Forms.TextBox()
        Me.prodCatTxt = New System.Windows.Forms.TextBox()
        Me.classficationTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.o_headerPan.SuspendLayout()
        Me.o_bodyPan.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.OrderListDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductListDGV_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'o_headerPan
        '
        Me.o_headerPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.o_headerPan.Controls.Add(Me.RequestsStatusLbl)
        Me.o_headerPan.Controls.Add(Me.RequestsStatusLblLbl)
        Me.o_headerPan.Controls.Add(Me.Label2)
        Me.o_headerPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.o_headerPan.Location = New System.Drawing.Point(0, 0)
        Me.o_headerPan.Name = "o_headerPan"
        Me.o_headerPan.Size = New System.Drawing.Size(1255, 70)
        Me.o_headerPan.TabIndex = 2
        '
        'RequestsStatusLbl
        '
        Me.RequestsStatusLbl.AutoSize = True
        Me.RequestsStatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestsStatusLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RequestsStatusLbl.Location = New System.Drawing.Point(1015, 19)
        Me.RequestsStatusLbl.Name = "RequestsStatusLbl"
        Me.RequestsStatusLbl.Size = New System.Drawing.Size(59, 20)
        Me.RequestsStatusLbl.TabIndex = 39
        Me.RequestsStatusLbl.Text = "_____"
        '
        'RequestsStatusLblLbl
        '
        Me.RequestsStatusLblLbl.AutoSize = True
        Me.RequestsStatusLblLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestsStatusLblLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RequestsStatusLblLbl.Location = New System.Drawing.Point(800, 19)
        Me.RequestsStatusLblLbl.Name = "RequestsStatusLblLbl"
        Me.RequestsStatusLblLbl.Size = New System.Drawing.Size(209, 20)
        Me.RequestsStatusLblLbl.TabIndex = 38
        Me.RequestsStatusLblLbl.Text = "Last Requests Status :   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(17, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ADD PRODUCT STOCKS"
        '
        'o_bodyPan
        '
        Me.o_bodyPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.o_bodyPan.Controls.Add(Me.SearchMedTxt)
        Me.o_bodyPan.Controls.Add(Me.Label4)
        Me.o_bodyPan.Controls.Add(Me.GroupBox3)
        Me.o_bodyPan.Controls.Add(Me.GroupBox2)
        Me.o_bodyPan.Controls.Add(Me.GroupBox1)
        Me.o_bodyPan.Controls.Add(Me.Panel2)
        Me.o_bodyPan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.o_bodyPan.Location = New System.Drawing.Point(0, 70)
        Me.o_bodyPan.Name = "o_bodyPan"
        Me.o_bodyPan.Size = New System.Drawing.Size(1255, 605)
        Me.o_bodyPan.TabIndex = 3
        '
        'SearchMedTxt
        '
        Me.SearchMedTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchMedTxt.Location = New System.Drawing.Point(113, 49)
        Me.SearchMedTxt.Name = "SearchMedTxt"
        Me.SearchMedTxt.Size = New System.Drawing.Size(204, 26)
        Me.SearchMedTxt.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(14, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "SEARCH"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OrderListDGV)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(834, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 536)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order list"
        '
        'OrderListDGV
        '
        Me.OrderListDGV.AllowUserToAddRows = False
        Me.OrderListDGV.AllowUserToDeleteRows = False
        Me.OrderListDGV.AllowUserToOrderColumns = True
        Me.OrderListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderListDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderListDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OrderListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderListDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.BrandName, Me.GenericName, Me.Quantity})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderListDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.OrderListDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderListDGV.Location = New System.Drawing.Point(3, 16)
        Me.OrderListDGV.Name = "OrderListDGV"
        Me.OrderListDGV.ReadOnly = True
        Me.OrderListDGV.Size = New System.Drawing.Size(406, 517)
        Me.OrderListDGV.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'BrandName
        '
        Me.BrandName.HeaderText = "Brand Name"
        Me.BrandName.Name = "BrandName"
        Me.BrandName.ReadOnly = True
        '
        'GenericName
        '
        Me.GenericName.HeaderText = "Generic Name"
        Me.GenericName.Name = "GenericName"
        Me.GenericName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductListDGV_Order)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 233)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stocks Items"
        '
        'ProductListDGV_Order
        '
        Me.ProductListDGV_Order.AllowUserToAddRows = False
        Me.ProductListDGV_Order.AllowUserToDeleteRows = False
        Me.ProductListDGV_Order.AllowUserToOrderColumns = True
        Me.ProductListDGV_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductListDGV_Order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductListDGV_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductListDGV_Order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodId, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.Classification})
        Me.ProductListDGV_Order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductListDGV_Order.Location = New System.Drawing.Point(3, 18)
        Me.ProductListDGV_Order.Name = "ProductListDGV_Order"
        Me.ProductListDGV_Order.ReadOnly = True
        Me.ProductListDGV_Order.Size = New System.Drawing.Size(810, 212)
        Me.ProductListDGV_Order.TabIndex = 3
        '
        'prodId
        '
        Me.prodId.HeaderText = "ID"
        Me.prodId.Name = "prodId"
        Me.prodId.ReadOnly = True
        Me.prodId.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Generic Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Classification
        '
        Me.Classification.HeaderText = "Classification"
        Me.Classification.Name = "Classification"
        Me.Classification.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prodGenNameTxt)
        Me.GroupBox1.Controls.Add(Me.prodGenNameLbl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.refreshBtn)
        Me.GroupBox1.Controls.Add(Me.AddStocksNowBtn)
        Me.GroupBox1.Controls.Add(Me.cancelBtn)
        Me.GroupBox1.Controls.Add(Me.SaveThisBtn)
        Me.GroupBox1.Controls.Add(Me.stocksQuantityTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.prodBrandNameTxt)
        Me.GroupBox1.Controls.Add(Me.prodCatTxt)
        Me.GroupBox1.Controls.Add(Me.classficationTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 258)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM DETAILS"
        '
        'prodGenNameTxt
        '
        Me.prodGenNameTxt.Enabled = False
        Me.prodGenNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodGenNameTxt.Location = New System.Drawing.Point(221, 64)
        Me.prodGenNameTxt.Name = "prodGenNameTxt"
        Me.prodGenNameTxt.Size = New System.Drawing.Size(204, 26)
        Me.prodGenNameTxt.TabIndex = 36
        '
        'prodGenNameLbl
        '
        Me.prodGenNameLbl.AutoSize = True
        Me.prodGenNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodGenNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.prodGenNameLbl.Location = New System.Drawing.Point(27, 66)
        Me.prodGenNameLbl.Name = "prodGenNameLbl"
        Me.prodGenNameLbl.Size = New System.Drawing.Size(145, 20)
        Me.prodGenNameLbl.TabIndex = 35
        Me.prodGenNameLbl.Text = "GENERIC NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(27, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "CLASSIFICATION"
        '
        'refreshBtn
        '
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.refreshBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Custom_Icon_Design_Flatastic_8_Order
        Me.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.refreshBtn.Location = New System.Drawing.Point(543, 166)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(143, 49)
        Me.refreshBtn.TabIndex = 31
        Me.refreshBtn.Text = "REFRESH"
        Me.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'AddStocksNowBtn
        '
        Me.AddStocksNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStocksNowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStocksNowBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddStocksNowBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.OK
        Me.AddStocksNowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStocksNowBtn.Location = New System.Drawing.Point(514, 85)
        Me.AddStocksNowBtn.Name = "AddStocksNowBtn"
        Me.AddStocksNowBtn.Size = New System.Drawing.Size(214, 49)
        Me.AddStocksNowBtn.TabIndex = 30
        Me.AddStocksNowBtn.Text = "ADD STOCKS NOW"
        Me.AddStocksNowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddStocksNowBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cancelBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.cancel
        Me.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelBtn.Location = New System.Drawing.Point(223, 201)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(118, 49)
        Me.cancelBtn.TabIndex = 29
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'SaveThisBtn
        '
        Me.SaveThisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveThisBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveThisBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SaveThisBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.save
        Me.SaveThisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveThisBtn.Location = New System.Drawing.Point(103, 201)
        Me.SaveThisBtn.Name = "SaveThisBtn"
        Me.SaveThisBtn.Size = New System.Drawing.Size(114, 49)
        Me.SaveThisBtn.TabIndex = 28
        Me.SaveThisBtn.Text = "SAVE"
        Me.SaveThisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveThisBtn.UseVisualStyleBackColor = True
        '
        'stocksQuantityTxt
        '
        Me.stocksQuantityTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stocksQuantityTxt.Location = New System.Drawing.Point(221, 165)
        Me.stocksQuantityTxt.Name = "stocksQuantityTxt"
        Me.stocksQuantityTxt.Size = New System.Drawing.Size(155, 26)
        Me.stocksQuantityTxt.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(27, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ENTER QUANTITY"
        '
        'prodBrandNameTxt
        '
        Me.prodBrandNameTxt.Enabled = False
        Me.prodBrandNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodBrandNameTxt.Location = New System.Drawing.Point(221, 31)
        Me.prodBrandNameTxt.Name = "prodBrandNameTxt"
        Me.prodBrandNameTxt.Size = New System.Drawing.Size(204, 26)
        Me.prodBrandNameTxt.TabIndex = 11
        '
        'prodCatTxt
        '
        Me.prodCatTxt.Enabled = False
        Me.prodCatTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodCatTxt.Location = New System.Drawing.Point(221, 95)
        Me.prodCatTxt.Name = "prodCatTxt"
        Me.prodCatTxt.Size = New System.Drawing.Size(204, 26)
        Me.prodCatTxt.TabIndex = 10
        '
        'classficationTxt
        '
        Me.classficationTxt.Enabled = False
        Me.classficationTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classficationTxt.Location = New System.Drawing.Point(221, 129)
        Me.classficationTxt.Name = "classficationTxt"
        Me.classficationTxt.Size = New System.Drawing.Size(204, 26)
        Me.classficationTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(27, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "CATEGORY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(27, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "BRAND NAME"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1255, 41)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(27, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ITEMS"
        '
        'OrderStocksFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 675)
        Me.Controls.Add(Me.o_bodyPan)
        Me.Controls.Add(Me.o_headerPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OrderStocksFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrderStockFrm"
        Me.o_headerPan.ResumeLayout(False)
        Me.o_headerPan.PerformLayout()
        Me.o_bodyPan.ResumeLayout(False)
        Me.o_bodyPan.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.OrderListDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProductListDGV_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents o_headerPan As System.Windows.Forms.Panel
    Friend WithEvents RequestsStatusLbl As System.Windows.Forms.Label
    Friend WithEvents RequestsStatusLblLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents o_bodyPan As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OrderListDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenericName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductListDGV_Order As System.Windows.Forms.DataGridView
    Friend WithEvents prodId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Classification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents prodGenNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents prodGenNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents refreshBtn As System.Windows.Forms.Button
    Friend WithEvents AddStocksNowBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveThisBtn As System.Windows.Forms.Button
    Friend WithEvents stocksQuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prodBrandNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents prodCatTxt As System.Windows.Forms.TextBox
    Friend WithEvents classficationTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchMedTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
