<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksFrm
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
        Me.s_headerPan = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.medListPan = New System.Windows.Forms.Panel()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.LoadByBatchBtn = New System.Windows.Forms.Button()
        Me.BatchGpbox = New System.Windows.Forms.GroupBox()
        Me.BatchDGV = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.FilterBtn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ProductsDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SearchClassificationBtn = New System.Windows.Forms.Button()
        Me.ClassificationTxt = New System.Windows.Forms.TextBox()
        Me.ClassificationNamelbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchProductBtn = New System.Windows.Forms.Button()
        Me.ProductNameTxt = New System.Windows.Forms.TextBox()
        Me.ProductNameLbl = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ClassificationDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchCategoryBtn = New System.Windows.Forms.Button()
        Me.CategoryNameTxt = New System.Windows.Forms.TextBox()
        Me.CategoryNameLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.medCategoryDGV = New System.Windows.Forms.DataGridView()
        Me.catId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curStocksQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_headerPan.SuspendLayout()
        Me.medListPan.SuspendLayout()
        Me.BatchGpbox.SuspendLayout()
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        's_headerPan
        '
        Me.s_headerPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.s_headerPan.Controls.Add(Me.Label2)
        Me.s_headerPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.s_headerPan.Location = New System.Drawing.Point(0, 0)
        Me.s_headerPan.Name = "s_headerPan"
        Me.s_headerPan.Size = New System.Drawing.Size(1243, 45)
        Me.s_headerPan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCT STOCKS"
        '
        'medListPan
        '
        Me.medListPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.medListPan.Controls.Add(Me.ClearBtn)
        Me.medListPan.Controls.Add(Me.LoadByBatchBtn)
        Me.medListPan.Controls.Add(Me.BatchGpbox)
        Me.medListPan.Controls.Add(Me.RefreshBtn)
        Me.medListPan.Controls.Add(Me.FilterBtn)
        Me.medListPan.Controls.Add(Me.GroupBox5)
        Me.medListPan.Controls.Add(Me.GroupBox4)
        Me.medListPan.Controls.Add(Me.Panel1)
        Me.medListPan.Controls.Add(Me.GroupBox2)
        Me.medListPan.Controls.Add(Me.GroupBox6)
        Me.medListPan.Controls.Add(Me.GroupBox1)
        Me.medListPan.Controls.Add(Me.GroupBox3)
        Me.medListPan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medListPan.Location = New System.Drawing.Point(0, 45)
        Me.medListPan.Name = "medListPan"
        Me.medListPan.Size = New System.Drawing.Size(1243, 632)
        Me.medListPan.TabIndex = 2
        '
        'ClearBtn
        '
        Me.ClearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClearBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources._as
        Me.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ClearBtn.Location = New System.Drawing.Point(776, 168)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(100, 64)
        Me.ClearBtn.TabIndex = 38
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'LoadByBatchBtn
        '
        Me.LoadByBatchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadByBatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadByBatchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadByBatchBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.LoadByBatchBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadByBatchBtn.Location = New System.Drawing.Point(38, 238)
        Me.LoadByBatchBtn.Name = "LoadByBatchBtn"
        Me.LoadByBatchBtn.Size = New System.Drawing.Size(176, 67)
        Me.LoadByBatchBtn.TabIndex = 37
        Me.LoadByBatchBtn.Text = "Load By Batch"
        Me.LoadByBatchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadByBatchBtn.UseVisualStyleBackColor = True
        '
        'BatchGpbox
        '
        Me.BatchGpbox.Controls.Add(Me.BatchDGV)
        Me.BatchGpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchGpbox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BatchGpbox.Location = New System.Drawing.Point(19, 51)
        Me.BatchGpbox.Name = "BatchGpbox"
        Me.BatchGpbox.Size = New System.Drawing.Size(227, 171)
        Me.BatchGpbox.TabIndex = 36
        Me.BatchGpbox.TabStop = False
        Me.BatchGpbox.Text = "Batch"
        '
        'BatchDGV
        '
        Me.BatchDGV.AllowUserToAddRows = False
        Me.BatchDGV.AllowUserToDeleteRows = False
        Me.BatchDGV.AllowUserToOrderColumns = True
        Me.BatchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BatchDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BatchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatchDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.BatchDate})
        Me.BatchDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatchDGV.Location = New System.Drawing.Point(3, 18)
        Me.BatchDGV.Name = "BatchDGV"
        Me.BatchDGV.ReadOnly = True
        Me.BatchDGV.Size = New System.Drawing.Size(221, 150)
        Me.BatchDGV.TabIndex = 19
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'BatchDate
        '
        Me.BatchDate.HeaderText = "Lot Number"
        Me.BatchDate.Name = "BatchDate"
        Me.BatchDate.ReadOnly = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RefreshBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RefreshBtn.Location = New System.Drawing.Point(776, 91)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(100, 64)
        Me.RefreshBtn.TabIndex = 30
        Me.RefreshBtn.Text = "Load All"
        Me.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'FilterBtn
        '
        Me.FilterBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.filter
        Me.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FilterBtn.Location = New System.Drawing.Point(776, 238)
        Me.FilterBtn.Name = "FilterBtn"
        Me.FilterBtn.Size = New System.Drawing.Size(100, 64)
        Me.FilterBtn.TabIndex = 35
        Me.FilterBtn.Text = "Filter"
        Me.FilterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FilterBtn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ProductsDGV)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(22, 318)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1192, 302)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CLASIFICATIONS"
        '
        'ProductsDGV
        '
        Me.ProductsDGV.AllowUserToAddRows = False
        Me.ProductsDGV.AllowUserToDeleteRows = False
        Me.ProductsDGV.AllowUserToOrderColumns = True
        Me.ProductsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.qty, Me.curStocksQty, Me.prodID, Me.brandName, Me.genericName, Me.Category, Me.Classification, Me.UnitCost, Me.stocks, Me.ExpirationDate})
        Me.ProductsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDGV.Location = New System.Drawing.Point(3, 22)
        Me.ProductsDGV.Name = "ProductsDGV"
        Me.ProductsDGV.ReadOnly = True
        Me.ProductsDGV.Size = New System.Drawing.Size(1186, 277)
        Me.ProductsDGV.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SearchClassificationBtn)
        Me.GroupBox4.Controls.Add(Me.ClassificationTxt)
        Me.GroupBox4.Controls.Add(Me.ClassificationNamelbl)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(887, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 83)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SEARCH CLASSIFICATION"
        '
        'SearchClassificationBtn
        '
        Me.SearchClassificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchClassificationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchClassificationBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchClassificationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchClassificationBtn.Location = New System.Drawing.Point(208, 19)
        Me.SearchClassificationBtn.Name = "SearchClassificationBtn"
        Me.SearchClassificationBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchClassificationBtn.TabIndex = 27
        Me.SearchClassificationBtn.Text = "Search"
        Me.SearchClassificationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchClassificationBtn.UseVisualStyleBackColor = True
        '
        'ClassificationTxt
        '
        Me.ClassificationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClassificationTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassificationTxt.Location = New System.Drawing.Point(11, 44)
        Me.ClassificationTxt.Name = "ClassificationTxt"
        Me.ClassificationTxt.Size = New System.Drawing.Size(181, 24)
        Me.ClassificationTxt.TabIndex = 29
        '
        'ClassificationNamelbl
        '
        Me.ClassificationNamelbl.AutoSize = True
        Me.ClassificationNamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassificationNamelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ClassificationNamelbl.Location = New System.Drawing.Point(34, 16)
        Me.ClassificationNamelbl.Name = "ClassificationNamelbl"
        Me.ClassificationNamelbl.Size = New System.Drawing.Size(105, 18)
        Me.ClassificationNamelbl.TabIndex = 28
        Me.ClassificationNamelbl.Text = "Classificition"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1243, 41)
        Me.Panel1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(34, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CATEGORIES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchProductBtn)
        Me.GroupBox2.Controls.Add(Me.ProductNameTxt)
        Me.GroupBox2.Controls.Add(Me.ProductNameLbl)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(887, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 83)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH PRODUCT"
        '
        'SearchProductBtn
        '
        Me.SearchProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchProductBtn.Location = New System.Drawing.Point(199, 19)
        Me.SearchProductBtn.Name = "SearchProductBtn"
        Me.SearchProductBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchProductBtn.TabIndex = 27
        Me.SearchProductBtn.Text = "Search"
        Me.SearchProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchProductBtn.UseVisualStyleBackColor = True
        '
        'ProductNameTxt
        '
        Me.ProductNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTxt.Location = New System.Drawing.Point(6, 44)
        Me.ProductNameTxt.Name = "ProductNameTxt"
        Me.ProductNameTxt.Size = New System.Drawing.Size(181, 24)
        Me.ProductNameTxt.TabIndex = 29
        '
        'ProductNameLbl
        '
        Me.ProductNameLbl.AutoSize = True
        Me.ProductNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductNameLbl.Location = New System.Drawing.Point(13, 16)
        Me.ProductNameLbl.Name = "ProductNameLbl"
        Me.ProductNameLbl.Size = New System.Drawing.Size(165, 18)
        Me.ProductNameLbl.TabIndex = 28
        Me.ProductNameLbl.Text = "Brand/Generic Name"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ClassificationDGV)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Location = New System.Drawing.Point(252, 47)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(253, 255)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CLASIFICATIONS"
        '
        'ClassificationDGV
        '
        Me.ClassificationDGV.AllowUserToAddRows = False
        Me.ClassificationDGV.AllowUserToDeleteRows = False
        Me.ClassificationDGV.AllowUserToOrderColumns = True
        Me.ClassificationDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClassificationDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClassificationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassificationDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClassificationDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassificationDGV.Location = New System.Drawing.Point(3, 22)
        Me.ClassificationDGV.Name = "ClassificationDGV"
        Me.ClassificationDGV.ReadOnly = True
        Me.ClassificationDGV.Size = New System.Drawing.Size(247, 230)
        Me.ClassificationDGV.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Classification"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchCategoryBtn)
        Me.GroupBox1.Controls.Add(Me.CategoryNameTxt)
        Me.GroupBox1.Controls.Add(Me.CategoryNameLbl)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(887, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 83)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH CATEGORY"
        '
        'SearchCategoryBtn
        '
        Me.SearchCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCategoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCategoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchCategoryBtn.Location = New System.Drawing.Point(205, 19)
        Me.SearchCategoryBtn.Name = "SearchCategoryBtn"
        Me.SearchCategoryBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchCategoryBtn.TabIndex = 27
        Me.SearchCategoryBtn.Text = "Search"
        Me.SearchCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchCategoryBtn.UseVisualStyleBackColor = True
        '
        'CategoryNameTxt
        '
        Me.CategoryNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CategoryNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameTxt.Location = New System.Drawing.Point(7, 44)
        Me.CategoryNameTxt.Name = "CategoryNameTxt"
        Me.CategoryNameTxt.Size = New System.Drawing.Size(181, 24)
        Me.CategoryNameTxt.TabIndex = 29
        '
        'CategoryNameLbl
        '
        Me.CategoryNameLbl.AutoSize = True
        Me.CategoryNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CategoryNameLbl.Location = New System.Drawing.Point(45, 16)
        Me.CategoryNameLbl.Name = "CategoryNameLbl"
        Me.CategoryNameLbl.Size = New System.Drawing.Size(76, 18)
        Me.CategoryNameLbl.TabIndex = 28
        Me.CategoryNameLbl.Text = "Category"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.medCategoryDGV)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(511, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 255)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CLASIFICATIONS"
        '
        'medCategoryDGV
        '
        Me.medCategoryDGV.AllowUserToAddRows = False
        Me.medCategoryDGV.AllowUserToDeleteRows = False
        Me.medCategoryDGV.AllowUserToOrderColumns = True
        Me.medCategoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.medCategoryDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.medCategoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medCategoryDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.catId, Me.CategoryName})
        Me.medCategoryDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medCategoryDGV.Location = New System.Drawing.Point(3, 22)
        Me.medCategoryDGV.Name = "medCategoryDGV"
        Me.medCategoryDGV.ReadOnly = True
        Me.medCategoryDGV.Size = New System.Drawing.Size(253, 230)
        Me.medCategoryDGV.TabIndex = 0
        '
        'catId
        '
        Me.catId.HeaderText = "ID"
        Me.catId.Name = "catId"
        Me.catId.ReadOnly = True
        Me.catId.Visible = False
        '
        'CategoryName
        '
        Me.CategoryName.HeaderText = "Category"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Visible = False
        '
        'curStocksQty
        '
        Me.curStocksQty.HeaderText = "CurrentStocksQty"
        Me.curStocksQty.Name = "curStocksQty"
        Me.curStocksQty.ReadOnly = True
        Me.curStocksQty.Visible = False
        '
        'prodID
        '
        Me.prodID.HeaderText = "Lot Number"
        Me.prodID.Name = "prodID"
        Me.prodID.ReadOnly = True
        '
        'brandName
        '
        Me.brandName.HeaderText = "Brand Name"
        Me.brandName.Name = "brandName"
        Me.brandName.ReadOnly = True
        '
        'genericName
        '
        Me.genericName.HeaderText = "Generic Name"
        Me.genericName.Name = "genericName"
        Me.genericName.ReadOnly = True
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
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
        Me.ExpirationDate.HeaderText = "ExpirationDate"
        Me.ExpirationDate.Name = "ExpirationDate"
        Me.ExpirationDate.ReadOnly = True
        '
        'StocksFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 677)
        Me.Controls.Add(Me.medListPan)
        Me.Controls.Add(Me.s_headerPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StocksFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StocksFrm"
        Me.s_headerPan.ResumeLayout(False)
        Me.s_headerPan.PerformLayout()
        Me.medListPan.ResumeLayout(False)
        Me.BatchGpbox.ResumeLayout(False)
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents s_headerPan As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents medListPan As System.Windows.Forms.Panel
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents LoadByBatchBtn As System.Windows.Forms.Button
    Friend WithEvents BatchGpbox As System.Windows.Forms.GroupBox
    Friend WithEvents BatchDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents FilterBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchClassificationBtn As System.Windows.Forms.Button
    Friend WithEvents ClassificationTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClassificationNamelbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchProductBtn As System.Windows.Forms.Button
    Friend WithEvents ProductNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ProductNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ClassificationDGV As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents CategoryNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents CategoryNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents medCategoryDGV As System.Windows.Forms.DataGridView
    Friend WithEvents catId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents curStocksQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brandName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genericName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Classification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
