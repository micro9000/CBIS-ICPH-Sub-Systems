<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERPharmacyFrm
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
        Me.BatchGpbox = New System.Windows.Forms.GroupBox()
        Me.BatchDGV = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ClassificationDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SearchClassificationBtn = New System.Windows.Forms.Button()
        Me.classificationNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProductsDGV = New System.Windows.Forms.DataGridView()
        Me.lotNumb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchProductBtn = New System.Windows.Forms.Button()
        Me.ProductNameTxt = New System.Windows.Forms.TextBox()
        Me.ProductNameLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SearchCategoryBtn = New System.Windows.Forms.Button()
        Me.CategoryNameTxt = New System.Windows.Forms.TextBox()
        Me.CategoryNameLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.medCategoryDGV = New System.Windows.Forms.DataGridView()
        Me.catId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadByBatchBtn = New System.Windows.Forms.Button()
        Me.LoadAllBtn = New System.Windows.Forms.Button()
        Me.FilterBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.BatchGpbox.SuspendLayout()
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HeaderPanel.Size = New System.Drawing.Size(1315, 93)
        Me.HeaderPanel.TabIndex = 18
        '
        'reportsFrmTitleLbl_2
        '
        Me.reportsFrmTitleLbl_2.AutoSize = True
        Me.reportsFrmTitleLbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_2.Location = New System.Drawing.Point(28, 53)
        Me.reportsFrmTitleLbl_2.Name = "reportsFrmTitleLbl_2"
        Me.reportsFrmTitleLbl_2.Size = New System.Drawing.Size(115, 20)
        Me.reportsFrmTitleLbl_2.TabIndex = 18
        Me.reportsFrmTitleLbl_2.Text = "Current Stocks"
        '
        'reportsFrmTitleLbl_1
        '
        Me.reportsFrmTitleLbl_1.AutoSize = True
        Me.reportsFrmTitleLbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_1.Location = New System.Drawing.Point(26, 22)
        Me.reportsFrmTitleLbl_1.Name = "reportsFrmTitleLbl_1"
        Me.reportsFrmTitleLbl_1.Size = New System.Drawing.Size(334, 31)
        Me.reportsFrmTitleLbl_1.TabIndex = 17
        Me.reportsFrmTitleLbl_1.Text = "ER-PHARMACY STOCKS"
        '
        'BatchGpbox
        '
        Me.BatchGpbox.Controls.Add(Me.BatchDGV)
        Me.BatchGpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchGpbox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BatchGpbox.Location = New System.Drawing.Point(12, 99)
        Me.BatchGpbox.Name = "BatchGpbox"
        Me.BatchGpbox.Size = New System.Drawing.Size(227, 171)
        Me.BatchGpbox.TabIndex = 47
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ClassificationDGV)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Location = New System.Drawing.Point(246, 98)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(292, 255)
        Me.GroupBox6.TabIndex = 40
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
        Me.ClassificationDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ClassificationDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassificationDGV.Location = New System.Drawing.Point(3, 22)
        Me.ClassificationDGV.Name = "ClassificationDGV"
        Me.ClassificationDGV.ReadOnly = True
        Me.ClassificationDGV.Size = New System.Drawing.Size(286, 230)
        Me.ClassificationDGV.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.60914!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 159.3909!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Classification"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SearchClassificationBtn)
        Me.GroupBox5.Controls.Add(Me.classificationNameTxt)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(952, 98)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(342, 83)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SEARCH CATEGORY"
        '
        'SearchClassificationBtn
        '
        Me.SearchClassificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchClassificationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchClassificationBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchClassificationBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchClassificationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchClassificationBtn.Location = New System.Drawing.Point(216, 23)
        Me.SearchClassificationBtn.Name = "SearchClassificationBtn"
        Me.SearchClassificationBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchClassificationBtn.TabIndex = 27
        Me.SearchClassificationBtn.Text = "Search"
        Me.SearchClassificationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchClassificationBtn.UseVisualStyleBackColor = True
        '
        'classificationNameTxt
        '
        Me.classificationNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classificationNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classificationNameTxt.Location = New System.Drawing.Point(8, 48)
        Me.classificationNameTxt.Name = "classificationNameTxt"
        Me.classificationNameTxt.Size = New System.Drawing.Size(181, 24)
        Me.classificationNameTxt.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Classification Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ProductsDGV)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(15, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1279, 305)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ITEMS"
        '
        'ProductsDGV
        '
        Me.ProductsDGV.AllowUserToAddRows = False
        Me.ProductsDGV.AllowUserToDeleteRows = False
        Me.ProductsDGV.AllowUserToOrderColumns = True
        Me.ProductsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lotNumb, Me.brandName, Me.genericName, Me.Category, Me.Classification, Me.unitCost, Me.stocks, Me.expDate})
        Me.ProductsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDGV.Location = New System.Drawing.Point(3, 22)
        Me.ProductsDGV.Name = "ProductsDGV"
        Me.ProductsDGV.ReadOnly = True
        Me.ProductsDGV.Size = New System.Drawing.Size(1273, 280)
        Me.ProductsDGV.TabIndex = 3
        '
        'lotNumb
        '
        Me.lotNumb.HeaderText = "Lot Number"
        Me.lotNumb.Name = "lotNumb"
        Me.lotNumb.ReadOnly = True
        '
        'brandName
        '
        Me.brandName.FillWeight = 107.8173!
        Me.brandName.HeaderText = "Brand Name"
        Me.brandName.Name = "brandName"
        Me.brandName.ReadOnly = True
        '
        'genericName
        '
        Me.genericName.FillWeight = 107.8173!
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
        'unitCost
        '
        Me.unitCost.HeaderText = "Unit Cost"
        Me.unitCost.Name = "unitCost"
        Me.unitCost.ReadOnly = True
        '
        'stocks
        '
        Me.stocks.FillWeight = 107.8173!
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        Me.stocks.ReadOnly = True
        '
        'expDate
        '
        Me.expDate.FillWeight = 107.8173!
        Me.expDate.HeaderText = "Expiration Date"
        Me.expDate.Name = "expDate"
        Me.expDate.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchProductBtn)
        Me.GroupBox2.Controls.Add(Me.ProductNameTxt)
        Me.GroupBox2.Controls.Add(Me.ProductNameLbl)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(952, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 83)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH PRODUCT"
        '
        'SearchProductBtn
        '
        Me.SearchProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchProductBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchProductBtn.Location = New System.Drawing.Point(216, 19)
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
        Me.ProductNameTxt.Location = New System.Drawing.Point(9, 44)
        Me.ProductNameTxt.Name = "ProductNameTxt"
        Me.ProductNameTxt.Size = New System.Drawing.Size(181, 24)
        Me.ProductNameTxt.TabIndex = 29
        '
        'ProductNameLbl
        '
        Me.ProductNameLbl.AutoSize = True
        Me.ProductNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductNameLbl.Location = New System.Drawing.Point(6, 19)
        Me.ProductNameLbl.Name = "ProductNameLbl"
        Me.ProductNameLbl.Size = New System.Drawing.Size(165, 18)
        Me.ProductNameLbl.TabIndex = 28
        Me.ProductNameLbl.Text = "Brand/Generic Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SearchCategoryBtn)
        Me.GroupBox3.Controls.Add(Me.CategoryNameTxt)
        Me.GroupBox3.Controls.Add(Me.CategoryNameLbl)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(952, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 83)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH CATEGORY"
        '
        'SearchCategoryBtn
        '
        Me.SearchCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCategoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCategoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchCategoryBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchCategoryBtn.Location = New System.Drawing.Point(216, 19)
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
        Me.CategoryNameTxt.Location = New System.Drawing.Point(6, 42)
        Me.CategoryNameTxt.Name = "CategoryNameTxt"
        Me.CategoryNameTxt.Size = New System.Drawing.Size(181, 24)
        Me.CategoryNameTxt.TabIndex = 29
        '
        'CategoryNameLbl
        '
        Me.CategoryNameLbl.AutoSize = True
        Me.CategoryNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CategoryNameLbl.Location = New System.Drawing.Point(23, 19)
        Me.CategoryNameLbl.Name = "CategoryNameLbl"
        Me.CategoryNameLbl.Size = New System.Drawing.Size(125, 18)
        Me.CategoryNameLbl.TabIndex = 28
        Me.CategoryNameLbl.Text = "Category Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.medCategoryDGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(544, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 255)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CATEGORIES"
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
        Me.medCategoryDGV.Size = New System.Drawing.Size(286, 230)
        Me.medCategoryDGV.TabIndex = 1
        '
        'catId
        '
        Me.catId.FillWeight = 40.60914!
        Me.catId.HeaderText = "ID"
        Me.catId.Name = "catId"
        Me.catId.ReadOnly = True
        Me.catId.Visible = False
        '
        'CategoryName
        '
        Me.CategoryName.FillWeight = 159.3909!
        Me.CategoryName.HeaderText = "Category"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        '
        'LoadByBatchBtn
        '
        Me.LoadByBatchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadByBatchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadByBatchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadByBatchBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadByBatchBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadByBatchBtn.Location = New System.Drawing.Point(45, 287)
        Me.LoadByBatchBtn.Name = "LoadByBatchBtn"
        Me.LoadByBatchBtn.Size = New System.Drawing.Size(151, 61)
        Me.LoadByBatchBtn.TabIndex = 48
        Me.LoadByBatchBtn.Text = "Load By Batch"
        Me.LoadByBatchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadByBatchBtn.UseVisualStyleBackColor = True
        '
        'LoadAllBtn
        '
        Me.LoadAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadAllBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadAllBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadAllBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadAllBtn.Location = New System.Drawing.Point(850, 202)
        Me.LoadAllBtn.Name = "LoadAllBtn"
        Me.LoadAllBtn.Size = New System.Drawing.Size(92, 61)
        Me.LoadAllBtn.TabIndex = 46
        Me.LoadAllBtn.Text = "Load All"
        Me.LoadAllBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadAllBtn.UseVisualStyleBackColor = True
        '
        'FilterBtn
        '
        Me.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterBtn.Image = Global.AdminDashboard.My.Resources.Resources.filter
        Me.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FilterBtn.Location = New System.Drawing.Point(850, 275)
        Me.FilterBtn.Name = "FilterBtn"
        Me.FilterBtn.Size = New System.Drawing.Size(92, 64)
        Me.FilterBtn.TabIndex = 42
        Me.FilterBtn.Text = "Filter"
        Me.FilterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FilterBtn.UseVisualStyleBackColor = True
        '
        'ERPharmacyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1315, 677)
        Me.Controls.Add(Me.LoadByBatchBtn)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.BatchGpbox)
        Me.Controls.Add(Me.LoadAllBtn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.FilterBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ERPharmacyFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.BatchGpbox.ResumeLayout(False)
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_2 As System.Windows.Forms.Label
    Friend WithEvents reportsFrmTitleLbl_1 As System.Windows.Forms.Label
    Friend WithEvents LoadByBatchBtn As System.Windows.Forms.Button
    Friend WithEvents LoadAllBtn As System.Windows.Forms.Button
    Friend WithEvents BatchGpbox As System.Windows.Forms.GroupBox
    Friend WithEvents BatchDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ClassificationDGV As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchClassificationBtn As System.Windows.Forms.Button
    Friend WithEvents classificationNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents lotNumb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brandName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genericName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Classification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchProductBtn As System.Windows.Forms.Button
    Friend WithEvents ProductNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ProductNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents CategoryNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents CategoryNameLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents medCategoryDGV As System.Windows.Forms.DataGridView
    Friend WithEvents catId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
