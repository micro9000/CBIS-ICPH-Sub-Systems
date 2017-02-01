<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacyFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PharmacyFrm))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HeaderPan = New System.Windows.Forms.Panel()
        Me.MedReturnBtn = New System.Windows.Forms.Button()
        Me.SalesReportBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NavPan = New System.Windows.Forms.Panel()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.ph_usernameLbl = New System.Windows.Forms.Label()
        Me.StockOrderBtn = New System.Windows.Forms.Button()
        Me.StocksBtn = New System.Windows.Forms.Button()
        Me.BodyPan = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.totalPurchasePriceLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.brandNameTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dateNowLbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transactionNumberTxt = New System.Windows.Forms.TextBox()
        Me.DoneBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ReturnMedProcessBtn = New System.Windows.Forms.Button()
        Me.inPatientRbtn = New System.Windows.Forms.RadioButton()
        Me.outPatientRbtn = New System.Windows.Forms.RadioButton()
        Me.ProcessTransBtn = New System.Windows.Forms.Button()
        Me.ClearItemsBtn = New System.Windows.Forms.Button()
        Me.PurchaseProductLbl = New System.Windows.Forms.Label()
        Me.SellingPriceLbl = New System.Windows.Forms.Label()
        Me.ProductListLbl = New System.Windows.Forms.Label()
        Me.DecreasePurchaseItemsbtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.decreaseQuantityTxt = New System.Windows.Forms.TextBox()
        Me.decreaseQuantityLbl = New System.Windows.Forms.Label()
        Me.ProductListDGV = New System.Windows.Forms.DataGridView()
        Me.prodId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveItemBtn = New System.Windows.Forms.Button()
        Me.SellingPriceTxt = New System.Windows.Forms.TextBox()
        Me.AddItemBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemQuantityTxt = New System.Windows.Forms.TextBox()
        Me.itemsDetailsDGV = New System.Windows.Forms.DataGridView()
        Me.ProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.generic_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trade_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PharmacyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HeaderPan.SuspendLayout()
        Me.NavPan.SuspendLayout()
        Me.BodyPan.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProductListDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.itemsDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPan
        '
        Me.HeaderPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.HeaderPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HeaderPan.Controls.Add(Me.MedReturnBtn)
        Me.HeaderPan.Controls.Add(Me.SalesReportBtn)
        Me.HeaderPan.Controls.Add(Me.Label10)
        Me.HeaderPan.Controls.Add(Me.NavPan)
        Me.HeaderPan.Controls.Add(Me.StockOrderBtn)
        Me.HeaderPan.Controls.Add(Me.StocksBtn)
        Me.HeaderPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPan.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPan.Name = "HeaderPan"
        Me.HeaderPan.Size = New System.Drawing.Size(1366, 72)
        Me.HeaderPan.TabIndex = 0
        '
        'MedReturnBtn
        '
        Me.MedReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MedReturnBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedReturnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MedReturnBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources._return
        Me.MedReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MedReturnBtn.Location = New System.Drawing.Point(847, 11)
        Me.MedReturnBtn.Name = "MedReturnBtn"
        Me.MedReturnBtn.Size = New System.Drawing.Size(110, 49)
        Me.MedReturnBtn.TabIndex = 29
        Me.MedReturnBtn.Text = "Return"
        Me.MedReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MedReturnBtn.UseVisualStyleBackColor = True
        '
        'SalesReportBtn
        '
        Me.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesReportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SalesReportBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.Custom_Icon_Design_Flatastic_5_Product_sale_report
        Me.SalesReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesReportBtn.Location = New System.Drawing.Point(722, 11)
        Me.SalesReportBtn.Name = "SalesReportBtn"
        Me.SalesReportBtn.Size = New System.Drawing.Size(110, 49)
        Me.SalesReportBtn.TabIndex = 28
        Me.SalesReportBtn.Text = "Sales"
        Me.SalesReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalesReportBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(15, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Pharmacy"
        '
        'NavPan
        '
        Me.NavPan.Controls.Add(Me.LogoutBtn)
        Me.NavPan.Controls.Add(Me.ph_usernameLbl)
        Me.NavPan.Dock = System.Windows.Forms.DockStyle.Right
        Me.NavPan.Location = New System.Drawing.Point(1018, 0)
        Me.NavPan.Name = "NavPan"
        Me.NavPan.Size = New System.Drawing.Size(346, 70)
        Me.NavPan.TabIndex = 3
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LogoutBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.Logout
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(221, 9)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(110, 49)
        Me.LogoutBtn.TabIndex = 28
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'ph_usernameLbl
        '
        Me.ph_usernameLbl.AutoSize = True
        Me.ph_usernameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ph_usernameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ph_usernameLbl.Location = New System.Drawing.Point(78, 26)
        Me.ph_usernameLbl.Name = "ph_usernameLbl"
        Me.ph_usernameLbl.Size = New System.Drawing.Size(87, 24)
        Me.ph_usernameLbl.TabIndex = 4
        Me.ph_usernameLbl.Text = "_______"
        '
        'StockOrderBtn
        '
        Me.StockOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StockOrderBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StockOrderBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.Custom_Icon_Design_Flatastic_8_Order
        Me.StockOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StockOrderBtn.Location = New System.Drawing.Point(432, 11)
        Me.StockOrderBtn.Name = "StockOrderBtn"
        Me.StockOrderBtn.Size = New System.Drawing.Size(148, 49)
        Me.StockOrderBtn.TabIndex = 26
        Me.StockOrderBtn.Text = "Stock order"
        Me.StockOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StockOrderBtn.UseVisualStyleBackColor = True
        '
        'StocksBtn
        '
        Me.StocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StocksBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StocksBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StocksBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.oneoneon
        Me.StocksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StocksBtn.Location = New System.Drawing.Point(597, 11)
        Me.StocksBtn.Name = "StocksBtn"
        Me.StocksBtn.Size = New System.Drawing.Size(110, 49)
        Me.StocksBtn.TabIndex = 27
        Me.StocksBtn.Text = "Stocks"
        Me.StocksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StocksBtn.UseVisualStyleBackColor = True
        '
        'BodyPan
        '
        Me.BodyPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BodyPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BodyPan.Controls.Add(Me.GroupBox4)
        Me.BodyPan.Controls.Add(Me.Panel1)
        Me.BodyPan.Controls.Add(Me.GroupBox1)
        Me.BodyPan.Controls.Add(Me.Panel8)
        Me.BodyPan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BodyPan.ForeColor = System.Drawing.SystemColors.Control
        Me.BodyPan.Location = New System.Drawing.Point(0, 72)
        Me.BodyPan.Name = "BodyPan"
        Me.BodyPan.Size = New System.Drawing.Size(1366, 696)
        Me.BodyPan.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.totalPurchasePriceLbl)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(696, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(657, 109)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL"
        '
        'totalPurchasePriceLbl
        '
        Me.totalPurchasePriceLbl.AutoSize = True
        Me.totalPurchasePriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPurchasePriceLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.totalPurchasePriceLbl.Location = New System.Drawing.Point(98, 38)
        Me.totalPurchasePriceLbl.Name = "totalPurchasePriceLbl"
        Me.totalPurchasePriceLbl.Size = New System.Drawing.Size(128, 39)
        Me.totalPurchasePriceLbl.TabIndex = 2
        Me.totalPurchasePriceLbl.Text = "000.00"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1364, 43)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(797, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(21, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ITEM DETAILS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.brandNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(25, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 109)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GET MEDICINE"
        '
        'brandNameTxt
        '
        Me.brandNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brandNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandNameTxt.Location = New System.Drawing.Point(60, 62)
        Me.brandNameTxt.Name = "brandNameTxt"
        Me.brandNameTxt.Size = New System.Drawing.Size(454, 35)
        Me.brandNameTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(130, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 29)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "BRAND/GENERIC NAME"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel8.Controls.Add(Me.dateNowLbl)
        Me.Panel8.Controls.Add(Me.GroupBox2)
        Me.Panel8.Controls.Add(Me.GroupBox3)
        Me.Panel8.Controls.Add(Me.ClearItemsBtn)
        Me.Panel8.Controls.Add(Me.PurchaseProductLbl)
        Me.Panel8.Controls.Add(Me.SellingPriceLbl)
        Me.Panel8.Controls.Add(Me.ProductListLbl)
        Me.Panel8.Controls.Add(Me.DecreasePurchaseItemsbtn)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.decreaseQuantityTxt)
        Me.Panel8.Controls.Add(Me.decreaseQuantityLbl)
        Me.Panel8.Controls.Add(Me.ProductListDGV)
        Me.Panel8.Controls.Add(Me.RemoveItemBtn)
        Me.Panel8.Controls.Add(Me.SellingPriceTxt)
        Me.Panel8.Controls.Add(Me.AddItemBtn)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.itemQuantityTxt)
        Me.Panel8.Controls.Add(Me.itemsDetailsDGV)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 164)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1364, 530)
        Me.Panel8.TabIndex = 4
        '
        'dateNowLbl
        '
        Me.dateNowLbl.AutoSize = True
        Me.dateNowLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNowLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dateNowLbl.Location = New System.Drawing.Point(1223, 506)
        Me.dateNowLbl.Name = "dateNowLbl"
        Me.dateNowLbl.Size = New System.Drawing.Size(56, 13)
        Me.dateNowLbl.TabIndex = 30
        Me.dateNowLbl.Text = "_______"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.transactionNumberTxt)
        Me.GroupBox2.Controls.Add(Me.DoneBtn)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(655, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 143)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Done Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Transaction Number"
        '
        'transactionNumberTxt
        '
        Me.transactionNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.transactionNumberTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionNumberTxt.Location = New System.Drawing.Point(16, 63)
        Me.transactionNumberTxt.Name = "transactionNumberTxt"
        Me.transactionNumberTxt.Size = New System.Drawing.Size(251, 29)
        Me.transactionNumberTxt.TabIndex = 30
        '
        'DoneBtn
        '
        Me.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoneBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.OK
        Me.DoneBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DoneBtn.Location = New System.Drawing.Point(273, 35)
        Me.DoneBtn.Name = "DoneBtn"
        Me.DoneBtn.Size = New System.Drawing.Size(96, 78)
        Me.DoneBtn.TabIndex = 25
        Me.DoneBtn.Text = "Done"
        Me.DoneBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DoneBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ReturnMedProcessBtn)
        Me.GroupBox3.Controls.Add(Me.inPatientRbtn)
        Me.GroupBox3.Controls.Add(Me.outPatientRbtn)
        Me.GroupBox3.Controls.Add(Me.ProcessTransBtn)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(392, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 174)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PROCESS"
        '
        'ReturnMedProcessBtn
        '
        Me.ReturnMedProcessBtn.Enabled = False
        Me.ReturnMedProcessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnMedProcessBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnMedProcessBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.Icons8_Windows_8_Business_Process
        Me.ReturnMedProcessBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReturnMedProcessBtn.Location = New System.Drawing.Point(119, 77)
        Me.ReturnMedProcessBtn.Name = "ReturnMedProcessBtn"
        Me.ReturnMedProcessBtn.Size = New System.Drawing.Size(96, 78)
        Me.ReturnMedProcessBtn.TabIndex = 32
        Me.ReturnMedProcessBtn.Text = "Process Return"
        Me.ReturnMedProcessBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ReturnMedProcessBtn.UseVisualStyleBackColor = True
        '
        'inPatientRbtn
        '
        Me.inPatientRbtn.AutoSize = True
        Me.inPatientRbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inPatientRbtn.Location = New System.Drawing.Point(124, 26)
        Me.inPatientRbtn.Name = "inPatientRbtn"
        Me.inPatientRbtn.Size = New System.Drawing.Size(58, 24)
        Me.inPatientRbtn.TabIndex = 31
        Me.inPatientRbtn.TabStop = True
        Me.inPatientRbtn.Text = "IN-P"
        Me.inPatientRbtn.UseVisualStyleBackColor = True
        '
        'outPatientRbtn
        '
        Me.outPatientRbtn.AutoSize = True
        Me.outPatientRbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outPatientRbtn.Location = New System.Drawing.Point(28, 26)
        Me.outPatientRbtn.Name = "outPatientRbtn"
        Me.outPatientRbtn.Size = New System.Drawing.Size(75, 24)
        Me.outPatientRbtn.TabIndex = 30
        Me.outPatientRbtn.TabStop = True
        Me.outPatientRbtn.Text = "OUT-P"
        Me.outPatientRbtn.UseVisualStyleBackColor = True
        '
        'ProcessTransBtn
        '
        Me.ProcessTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProcessTransBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessTransBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.Icons8_Windows_8_Business_Process
        Me.ProcessTransBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProcessTransBtn.Location = New System.Drawing.Point(17, 77)
        Me.ProcessTransBtn.Name = "ProcessTransBtn"
        Me.ProcessTransBtn.Size = New System.Drawing.Size(96, 78)
        Me.ProcessTransBtn.TabIndex = 25
        Me.ProcessTransBtn.Text = "Process"
        Me.ProcessTransBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProcessTransBtn.UseVisualStyleBackColor = True
        '
        'ClearItemsBtn
        '
        Me.ClearItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearItemsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearItemsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ClearItemsBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources._as
        Me.ClearItemsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearItemsBtn.Location = New System.Drawing.Point(249, 422)
        Me.ClearItemsBtn.Name = "ClearItemsBtn"
        Me.ClearItemsBtn.Size = New System.Drawing.Size(91, 78)
        Me.ClearItemsBtn.TabIndex = 26
        Me.ClearItemsBtn.Text = "Clear"
        Me.ClearItemsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearItemsBtn.UseVisualStyleBackColor = True
        '
        'PurchaseProductLbl
        '
        Me.PurchaseProductLbl.AutoSize = True
        Me.PurchaseProductLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseProductLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PurchaseProductLbl.Location = New System.Drawing.Point(872, 49)
        Me.PurchaseProductLbl.Name = "PurchaseProductLbl"
        Me.PurchaseProductLbl.Size = New System.Drawing.Size(240, 20)
        Me.PurchaseProductLbl.TabIndex = 3
        Me.PurchaseProductLbl.Text = "PURCHASE PRODUCT LIST"
        '
        'SellingPriceLbl
        '
        Me.SellingPriceLbl.AutoSize = True
        Me.SellingPriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellingPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SellingPriceLbl.Location = New System.Drawing.Point(42, 352)
        Me.SellingPriceLbl.Name = "SellingPriceLbl"
        Me.SellingPriceLbl.Size = New System.Drawing.Size(128, 24)
        Me.SellingPriceLbl.TabIndex = 27
        Me.SellingPriceLbl.Text = "Selling Price"
        '
        'ProductListLbl
        '
        Me.ProductListLbl.AutoSize = True
        Me.ProductListLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductListLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductListLbl.Location = New System.Drawing.Point(20, 49)
        Me.ProductListLbl.Name = "ProductListLbl"
        Me.ProductListLbl.Size = New System.Drawing.Size(137, 20)
        Me.ProductListLbl.TabIndex = 2
        Me.ProductListLbl.Text = "PRODUCT LIST"
        '
        'DecreasePurchaseItemsbtn
        '
        Me.DecreasePurchaseItemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecreasePurchaseItemsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecreasePurchaseItemsbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DecreasePurchaseItemsbtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.decrease
        Me.DecreasePurchaseItemsbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DecreasePurchaseItemsbtn.Location = New System.Drawing.Point(1079, 419)
        Me.DecreasePurchaseItemsbtn.Name = "DecreasePurchaseItemsbtn"
        Me.DecreasePurchaseItemsbtn.Size = New System.Drawing.Size(97, 62)
        Me.DecreasePurchaseItemsbtn.TabIndex = 25
        Me.DecreasePurchaseItemsbtn.Text = "Decrease"
        Me.DecreasePurchaseItemsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DecreasePurchaseItemsbtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(40, 386)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 24)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Quanitity"
        '
        'decreaseQuantityTxt
        '
        Me.decreaseQuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decreaseQuantityTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decreaseQuantityTxt.Location = New System.Drawing.Point(1160, 380)
        Me.decreaseQuantityTxt.Name = "decreaseQuantityTxt"
        Me.decreaseQuantityTxt.Size = New System.Drawing.Size(86, 24)
        Me.decreaseQuantityTxt.TabIndex = 12
        '
        'decreaseQuantityLbl
        '
        Me.decreaseQuantityLbl.AutoSize = True
        Me.decreaseQuantityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decreaseQuantityLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.decreaseQuantityLbl.Location = New System.Drawing.Point(1119, 353)
        Me.decreaseQuantityLbl.Name = "decreaseQuantityLbl"
        Me.decreaseQuantityLbl.Size = New System.Drawing.Size(147, 18)
        Me.decreaseQuantityLbl.TabIndex = 13
        Me.decreaseQuantityLbl.Text = "Decrease Quantity"
        '
        'ProductListDGV
        '
        Me.ProductListDGV.AllowUserToAddRows = False
        Me.ProductListDGV.AllowUserToDeleteRows = False
        Me.ProductListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductListDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductListDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductListDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodId, Me.lotNumber, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.Classification, Me.UnitCost, Me.stocks, Me.ExpirationDate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductListDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProductListDGV.Location = New System.Drawing.Point(11, 72)
        Me.ProductListDGV.Name = "ProductListDGV"
        Me.ProductListDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductListDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ProductListDGV.Size = New System.Drawing.Size(821, 259)
        Me.ProductListDGV.TabIndex = 2
        '
        'prodId
        '
        Me.prodId.HeaderText = "ID"
        Me.prodId.Name = "prodId"
        Me.prodId.ReadOnly = True
        Me.prodId.Visible = False
        '
        'lotNumber
        '
        Me.lotNumber.HeaderText = "Lot Number"
        Me.lotNumber.Name = "lotNumber"
        Me.lotNumber.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "GENERIC NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "TRADE NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Classification
        '
        Me.Classification.HeaderText = "Classification"
        Me.Classification.Name = "Classification"
        Me.Classification.ReadOnly = True
        '
        'UnitCost
        '
        Me.UnitCost.HeaderText = "Unit Cost"
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.ReadOnly = True
        '
        'stocks
        '
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        Me.stocks.ReadOnly = True
        '
        'ExpirationDate
        '
        Me.ExpirationDate.HeaderText = "Expiration Date"
        Me.ExpirationDate.Name = "ExpirationDate"
        Me.ExpirationDate.ReadOnly = True
        '
        'RemoveItemBtn
        '
        Me.RemoveItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveItemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveItemBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveItemBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.a
        Me.RemoveItemBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RemoveItemBtn.Location = New System.Drawing.Point(1182, 419)
        Me.RemoveItemBtn.Name = "RemoveItemBtn"
        Me.RemoveItemBtn.Size = New System.Drawing.Size(132, 62)
        Me.RemoveItemBtn.TabIndex = 24
        Me.RemoveItemBtn.Text = "Remove Item"
        Me.RemoveItemBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RemoveItemBtn.UseVisualStyleBackColor = True
        '
        'SellingPriceTxt
        '
        Me.SellingPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SellingPriceTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellingPriceTxt.Location = New System.Drawing.Point(176, 347)
        Me.SellingPriceTxt.Name = "SellingPriceTxt"
        Me.SellingPriceTxt.Size = New System.Drawing.Size(164, 29)
        Me.SellingPriceTxt.TabIndex = 26
        '
        'AddItemBtn
        '
        Me.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddItemBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddItemBtn.Image = CType(resources.GetObject("AddItemBtn.Image"), System.Drawing.Image)
        Me.AddItemBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddItemBtn.Location = New System.Drawing.Point(143, 422)
        Me.AddItemBtn.Name = "AddItemBtn"
        Me.AddItemBtn.Size = New System.Drawing.Size(100, 78)
        Me.AddItemBtn.TabIndex = 23
        Me.AddItemBtn.Text = "Add Item"
        Me.AddItemBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AddItemBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 43)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(18, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ITEM WINDOW"
        '
        'itemQuantityTxt
        '
        Me.itemQuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemQuantityTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemQuantityTxt.Location = New System.Drawing.Point(176, 387)
        Me.itemQuantityTxt.Name = "itemQuantityTxt"
        Me.itemQuantityTxt.Size = New System.Drawing.Size(164, 29)
        Me.itemQuantityTxt.TabIndex = 10
        '
        'itemsDetailsDGV
        '
        Me.itemsDetailsDGV.AllowUserToAddRows = False
        Me.itemsDetailsDGV.AllowUserToDeleteRows = False
        Me.itemsDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemsDetailsDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itemsDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.itemsDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemsDetailsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductId, Me.generic_name, Me.trade_name, Me.quantity, Me.SellingPrice, Me.totalPrice})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.itemsDetailsDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.itemsDetailsDGV.Location = New System.Drawing.Point(838, 72)
        Me.itemsDetailsDGV.Name = "itemsDetailsDGV"
        Me.itemsDetailsDGV.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itemsDetailsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.itemsDetailsDGV.Size = New System.Drawing.Size(515, 259)
        Me.itemsDetailsDGV.TabIndex = 1
        '
        'ProductId
        '
        Me.ProductId.HeaderText = "ID"
        Me.ProductId.Name = "ProductId"
        Me.ProductId.ReadOnly = True
        Me.ProductId.Visible = False
        '
        'generic_name
        '
        Me.generic_name.HeaderText = "GENERIC NAME"
        Me.generic_name.Name = "generic_name"
        Me.generic_name.ReadOnly = True
        '
        'trade_name
        '
        Me.trade_name.HeaderText = "TRADE NAME"
        Me.trade_name.Name = "trade_name"
        Me.trade_name.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "QUANTITY"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'SellingPrice
        '
        Me.SellingPrice.HeaderText = "Selling Price"
        Me.SellingPrice.Name = "SellingPrice"
        Me.SellingPrice.ReadOnly = True
        '
        'totalPrice
        '
        Me.totalPrice.HeaderText = "TOTAL"
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        '
        'PharmacyTimer
        '
        '
        'PharmacyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.BodyPan)
        Me.Controls.Add(Me.HeaderPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PharmacyFrm"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HeaderPan.ResumeLayout(False)
        Me.HeaderPan.PerformLayout()
        Me.NavPan.ResumeLayout(False)
        Me.NavPan.PerformLayout()
        Me.BodyPan.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProductListDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.itemsDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPan As System.Windows.Forms.Panel
    Friend WithEvents BodyPan As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents itemsDetailsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents brandNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents NavPan As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents itemQuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RemoveItemBtn As System.Windows.Forms.Button
    Friend WithEvents AddItemBtn As System.Windows.Forms.Button
    Friend WithEvents ProcessTransBtn As System.Windows.Forms.Button
    Friend WithEvents ClearItemsBtn As System.Windows.Forms.Button
    Private WithEvents PharmacyTimer As System.Windows.Forms.Timer
    Friend WithEvents StockOrderBtn As System.Windows.Forms.Button
    Friend WithEvents StocksBtn As System.Windows.Forms.Button
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents ProductListDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PurchaseProductLbl As System.Windows.Forms.Label
    Friend WithEvents ProductListLbl As System.Windows.Forms.Label
    Friend WithEvents ph_usernameLbl As System.Windows.Forms.Label
    Friend WithEvents DecreasePurchaseItemsbtn As System.Windows.Forms.Button
    Friend WithEvents decreaseQuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents decreaseQuantityLbl As System.Windows.Forms.Label
    Friend WithEvents SellingPriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents SellingPriceLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents transactionNumberTxt As System.Windows.Forms.TextBox
    Friend WithEvents DoneBtn As System.Windows.Forms.Button
    Friend WithEvents inPatientRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents outPatientRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents totalPurchasePriceLbl As System.Windows.Forms.Label
    Friend WithEvents prodId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Classification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesReportBtn As System.Windows.Forms.Button
    Friend WithEvents dateNowLbl As System.Windows.Forms.Label
    Friend WithEvents ProductId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents generic_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trade_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedReturnBtn As System.Windows.Forms.Button
    Friend WithEvents ReturnMedProcessBtn As System.Windows.Forms.Button
End Class
