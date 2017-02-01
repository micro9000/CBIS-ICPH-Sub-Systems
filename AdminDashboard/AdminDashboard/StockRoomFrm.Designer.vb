<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockRoomFrm
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
        Me.LotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadBatchClassCatBtn = New System.Windows.Forms.Button()
        Me.ViewStockBtn = New System.Windows.Forms.Button()
        Me.ViewSupplierBtn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ClassificationDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.medCategoryDGV = New System.Windows.Forms.DataGridView()
        Me.catId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilterBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductsDGV = New System.Windows.Forms.DataGridView()
        Me.lotNumb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderPanel.SuspendLayout()
        Me.BatchGpbox.SuspendLayout()
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HeaderPanel.Size = New System.Drawing.Size(1297, 84)
        Me.HeaderPanel.TabIndex = 17
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
        Me.reportsFrmTitleLbl_1.Size = New System.Drawing.Size(199, 31)
        Me.reportsFrmTitleLbl_1.TabIndex = 17
        Me.reportsFrmTitleLbl_1.Text = "STOCK ROOM"
        '
        'BatchGpbox
        '
        Me.BatchGpbox.Controls.Add(Me.BatchDGV)
        Me.BatchGpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchGpbox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BatchGpbox.Location = New System.Drawing.Point(28, 91)
        Me.BatchGpbox.Name = "BatchGpbox"
        Me.BatchGpbox.Size = New System.Drawing.Size(304, 261)
        Me.BatchGpbox.TabIndex = 18
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
        Me.BatchDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.LotNumber, Me.BatchDate})
        Me.BatchDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatchDGV.Location = New System.Drawing.Point(3, 18)
        Me.BatchDGV.Name = "BatchDGV"
        Me.BatchDGV.ReadOnly = True
        Me.BatchDGV.Size = New System.Drawing.Size(298, 240)
        Me.BatchDGV.TabIndex = 19
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'LotNumber
        '
        Me.LotNumber.HeaderText = "Lot Number"
        Me.LotNumber.Name = "LotNumber"
        Me.LotNumber.ReadOnly = True
        '
        'BatchDate
        '
        Me.BatchDate.HeaderText = "Date"
        Me.BatchDate.Name = "BatchDate"
        Me.BatchDate.ReadOnly = True
        '
        'LoadBatchClassCatBtn
        '
        Me.LoadBatchClassCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBatchClassCatBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBatchClassCatBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadBatchClassCatBtn.Image = Global.AdminDashboard.My.Resources.Resources.Graphicloads_Polygon_Refresh_4
        Me.LoadBatchClassCatBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadBatchClassCatBtn.Location = New System.Drawing.Point(407, 94)
        Me.LoadBatchClassCatBtn.Name = "LoadBatchClassCatBtn"
        Me.LoadBatchClassCatBtn.Size = New System.Drawing.Size(160, 99)
        Me.LoadBatchClassCatBtn.TabIndex = 53
        Me.LoadBatchClassCatBtn.Text = "Load Batch/Clasification/Categories"
        Me.LoadBatchClassCatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadBatchClassCatBtn.UseVisualStyleBackColor = True
        '
        'ViewStockBtn
        '
        Me.ViewStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewStockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStockBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ViewStockBtn.Image = Global.AdminDashboard.My.Resources.Resources.view_sales
        Me.ViewStockBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewStockBtn.Location = New System.Drawing.Point(407, 199)
        Me.ViewStockBtn.Name = "ViewStockBtn"
        Me.ViewStockBtn.Size = New System.Drawing.Size(160, 79)
        Me.ViewStockBtn.TabIndex = 52
        Me.ViewStockBtn.Text = "View Stocks"
        Me.ViewStockBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewStockBtn.UseVisualStyleBackColor = True
        '
        'ViewSupplierBtn
        '
        Me.ViewSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewSupplierBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSupplierBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ViewSupplierBtn.Image = Global.AdminDashboard.My.Resources.Resources.Generate
        Me.ViewSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewSupplierBtn.Location = New System.Drawing.Point(338, 287)
        Me.ViewSupplierBtn.Name = "ViewSupplierBtn"
        Me.ViewSupplierBtn.Size = New System.Drawing.Size(147, 66)
        Me.ViewSupplierBtn.TabIndex = 51
        Me.ViewSupplierBtn.Text = "View Supplier"
        Me.ViewSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewSupplierBtn.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ClassificationDGV)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Location = New System.Drawing.Point(644, 98)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(299, 255)
        Me.GroupBox6.TabIndex = 55
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
        Me.ClassificationDGV.Size = New System.Drawing.Size(293, 230)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.medCategoryDGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(958, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 255)
        Me.GroupBox1.TabIndex = 54
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
        Me.medCategoryDGV.Size = New System.Drawing.Size(295, 230)
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
        'FilterBtn
        '
        Me.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterBtn.Image = Global.AdminDashboard.My.Resources.Resources.filter
        Me.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FilterBtn.Location = New System.Drawing.Point(491, 287)
        Me.FilterBtn.Name = "FilterBtn"
        Me.FilterBtn.Size = New System.Drawing.Size(147, 67)
        Me.FilterBtn.TabIndex = 57
        Me.FilterBtn.Text = "Filter"
        Me.FilterBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FilterBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductsDGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(25, 371)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1234, 294)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stocks"
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
        Me.ProductsDGV.Location = New System.Drawing.Point(3, 18)
        Me.ProductsDGV.Name = "ProductsDGV"
        Me.ProductsDGV.ReadOnly = True
        Me.ProductsDGV.Size = New System.Drawing.Size(1228, 273)
        Me.ProductsDGV.TabIndex = 4
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
        'StockRoomFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FilterBtn)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LoadBatchClassCatBtn)
        Me.Controls.Add(Me.ViewStockBtn)
        Me.Controls.Add(Me.ViewSupplierBtn)
        Me.Controls.Add(Me.BatchGpbox)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StockRoomFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.BatchGpbox.ResumeLayout(False)
        CType(Me.BatchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.ClassificationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.medCategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProductsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_2 As System.Windows.Forms.Label
    Friend WithEvents reportsFrmTitleLbl_1 As System.Windows.Forms.Label
    Friend WithEvents BatchGpbox As System.Windows.Forms.GroupBox
    Friend WithEvents BatchDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewSupplierBtn As System.Windows.Forms.Button
    Friend WithEvents ViewStockBtn As System.Windows.Forms.Button
    Friend WithEvents LoadBatchClassCatBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ClassificationDGV As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents medCategoryDGV As System.Windows.Forms.DataGridView
    Friend WithEvents catId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents lotNumb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brandName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genericName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Classification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
