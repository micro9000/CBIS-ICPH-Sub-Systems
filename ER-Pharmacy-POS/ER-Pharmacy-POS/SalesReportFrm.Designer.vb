<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.WMYSummaryReportBtn = New System.Windows.Forms.Button()
        Me.WeeklyReportBtn = New System.Windows.Forms.Button()
        Me.weeklyEndDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.weeklyStartDateTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LoadDailySummaryReportsBtn = New System.Windows.Forms.Button()
        Me.LoadDailyReportsBtn = New System.Windows.Forms.Button()
        Me.DailySalesDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.InPatientTotalTxt = New System.Windows.Forms.TextBox()
        Me.allRbtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outPRbtn = New System.Windows.Forms.RadioButton()
        Me.InPRbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalesTransactionDGV = New System.Windows.Forms.DataGridView()
        Me.transId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transPatientType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.reportFileNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SalesTransactionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1153, 46)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(21, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sales report"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.WMYSummaryReportBtn)
        Me.GroupBox5.Controls.Add(Me.WeeklyReportBtn)
        Me.GroupBox5.Controls.Add(Me.weeklyEndDateTime)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.weeklyStartDateTime)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(416, 63)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(397, 167)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Generate Weekly/Monthly/Yearly Sales"
        '
        'WMYSummaryReportBtn
        '
        Me.WMYSummaryReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WMYSummaryReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMYSummaryReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.WMYSummaryReportBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.WMYSummaryReportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WMYSummaryReportBtn.Location = New System.Drawing.Point(183, 91)
        Me.WMYSummaryReportBtn.Name = "WMYSummaryReportBtn"
        Me.WMYSummaryReportBtn.Size = New System.Drawing.Size(194, 66)
        Me.WMYSummaryReportBtn.TabIndex = 54
        Me.WMYSummaryReportBtn.Text = "WMY Summary Report "
        Me.WMYSummaryReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WMYSummaryReportBtn.UseVisualStyleBackColor = True
        '
        'WeeklyReportBtn
        '
        Me.WeeklyReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeeklyReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeeklyReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.WeeklyReportBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.WeeklyReportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WeeklyReportBtn.Location = New System.Drawing.Point(30, 91)
        Me.WeeklyReportBtn.Name = "WeeklyReportBtn"
        Me.WeeklyReportBtn.Size = New System.Drawing.Size(147, 66)
        Me.WeeklyReportBtn.TabIndex = 50
        Me.WeeklyReportBtn.Text = "WMY Report "
        Me.WeeklyReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WeeklyReportBtn.UseVisualStyleBackColor = True
        '
        'weeklyEndDateTime
        '
        Me.weeklyEndDateTime.Location = New System.Drawing.Point(120, 53)
        Me.weeklyEndDateTime.Name = "weeklyEndDateTime"
        Me.weeklyEndDateTime.Size = New System.Drawing.Size(241, 22)
        Me.weeklyEndDateTime.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Between"
        '
        'weeklyStartDateTime
        '
        Me.weeklyStartDateTime.Location = New System.Drawing.Point(120, 21)
        Me.weeklyStartDateTime.Name = "weeklyStartDateTime"
        Me.weeklyStartDateTime.Size = New System.Drawing.Size(241, 22)
        Me.weeklyStartDateTime.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LoadDailySummaryReportsBtn)
        Me.GroupBox2.Controls.Add(Me.LoadDailyReportsBtn)
        Me.GroupBox2.Controls.Add(Me.DailySalesDatePicker)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(16, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 140)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Daily Sales"
        '
        'LoadDailySummaryReportsBtn
        '
        Me.LoadDailySummaryReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadDailySummaryReportsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadDailySummaryReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadDailySummaryReportsBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.LoadDailySummaryReportsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadDailySummaryReportsBtn.Location = New System.Drawing.Point(180, 64)
        Me.LoadDailySummaryReportsBtn.Name = "LoadDailySummaryReportsBtn"
        Me.LoadDailySummaryReportsBtn.Size = New System.Drawing.Size(194, 66)
        Me.LoadDailySummaryReportsBtn.TabIndex = 50
        Me.LoadDailySummaryReportsBtn.Text = "Daily Summary Report "
        Me.LoadDailySummaryReportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadDailySummaryReportsBtn.UseVisualStyleBackColor = True
        '
        'LoadDailyReportsBtn
        '
        Me.LoadDailyReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadDailyReportsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadDailyReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadDailyReportsBtn.Image = Global.ER_Pharmacy_POS.My.Resources.Resources.Load
        Me.LoadDailyReportsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadDailyReportsBtn.Location = New System.Drawing.Point(23, 63)
        Me.LoadDailyReportsBtn.Name = "LoadDailyReportsBtn"
        Me.LoadDailyReportsBtn.Size = New System.Drawing.Size(151, 66)
        Me.LoadDailyReportsBtn.TabIndex = 49
        Me.LoadDailyReportsBtn.Text = "Daily Report "
        Me.LoadDailyReportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadDailyReportsBtn.UseVisualStyleBackColor = True
        '
        'DailySalesDatePicker
        '
        Me.DailySalesDatePicker.Location = New System.Drawing.Point(23, 32)
        Me.DailySalesDatePicker.Name = "DailySalesDatePicker"
        Me.DailySalesDatePicker.Size = New System.Drawing.Size(232, 22)
        Me.DailySalesDatePicker.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.InPatientTotalTxt)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(823, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(318, 167)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Sales"
        '
        'InPatientTotalTxt
        '
        Me.InPatientTotalTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPatientTotalTxt.Location = New System.Drawing.Point(23, 63)
        Me.InPatientTotalTxt.Name = "InPatientTotalTxt"
        Me.InPatientTotalTxt.Size = New System.Drawing.Size(272, 31)
        Me.InPatientTotalTxt.TabIndex = 57
        '
        'allRbtn
        '
        Me.allRbtn.AutoSize = True
        Me.allRbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allRbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.allRbtn.Location = New System.Drawing.Point(338, 209)
        Me.allRbtn.Name = "allRbtn"
        Me.allRbtn.Size = New System.Drawing.Size(56, 24)
        Me.allRbtn.TabIndex = 70
        Me.allRbtn.TabStop = True
        Me.allRbtn.Text = "ALL"
        Me.allRbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(35, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Filter by patient type"
        '
        'outPRbtn
        '
        Me.outPRbtn.AutoSize = True
        Me.outPRbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outPRbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.outPRbtn.Location = New System.Drawing.Point(257, 210)
        Me.outPRbtn.Name = "outPRbtn"
        Me.outPRbtn.Size = New System.Drawing.Size(75, 24)
        Me.outPRbtn.TabIndex = 69
        Me.outPRbtn.TabStop = True
        Me.outPRbtn.Text = "OUT-P"
        Me.outPRbtn.UseVisualStyleBackColor = True
        '
        'InPRbtn
        '
        Me.InPRbtn.AutoSize = True
        Me.InPRbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPRbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InPRbtn.Location = New System.Drawing.Point(192, 210)
        Me.InPRbtn.Name = "InPRbtn"
        Me.InPRbtn.Size = New System.Drawing.Size(58, 24)
        Me.InPRbtn.TabIndex = 68
        Me.InPRbtn.TabStop = True
        Me.InPRbtn.Text = "IN-P"
        Me.InPRbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SalesTransactionDGV)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1129, 316)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'SalesTransactionDGV
        '
        Me.SalesTransactionDGV.AllowUserToAddRows = False
        Me.SalesTransactionDGV.AllowUserToDeleteRows = False
        Me.SalesTransactionDGV.AllowUserToOrderColumns = True
        Me.SalesTransactionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SalesTransactionDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesTransactionDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SalesTransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesTransactionDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transId, Me.transDate, Me.transProd, Me.transPrice, Me.transQuantity, Me.TotalPrice, Me.transPatientType, Me.transUser})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SalesTransactionDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.SalesTransactionDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesTransactionDGV.Location = New System.Drawing.Point(3, 16)
        Me.SalesTransactionDGV.Name = "SalesTransactionDGV"
        Me.SalesTransactionDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesTransactionDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SalesTransactionDGV.Size = New System.Drawing.Size(1123, 297)
        Me.SalesTransactionDGV.TabIndex = 17
        '
        'transId
        '
        Me.transId.FillWeight = 52.76405!
        Me.transId.HeaderText = "ID"
        Me.transId.Name = "transId"
        Me.transId.ReadOnly = True
        Me.transId.Visible = False
        '
        'transDate
        '
        Me.transDate.FillWeight = 149.3674!
        Me.transDate.HeaderText = "DATE TIME"
        Me.transDate.Name = "transDate"
        Me.transDate.ReadOnly = True
        '
        'transProd
        '
        Me.transProd.FillWeight = 106.7006!
        Me.transProd.HeaderText = "ITEM"
        Me.transProd.Name = "transProd"
        Me.transProd.ReadOnly = True
        '
        'transPrice
        '
        Me.transPrice.FillWeight = 106.7006!
        Me.transPrice.HeaderText = "PRICE"
        Me.transPrice.Name = "transPrice"
        Me.transPrice.ReadOnly = True
        '
        'transQuantity
        '
        Me.transQuantity.FillWeight = 106.7006!
        Me.transQuantity.HeaderText = "QUANTITY"
        Me.transQuantity.Name = "transQuantity"
        Me.transQuantity.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'transPatientType
        '
        Me.transPatientType.FillWeight = 71.06599!
        Me.transPatientType.HeaderText = "PATIENT TYPE"
        Me.transPatientType.Name = "transPatientType"
        Me.transPatientType.ReadOnly = True
        '
        'transUser
        '
        Me.transUser.FillWeight = 106.7006!
        Me.transUser.HeaderText = "USER"
        Me.transUser.Name = "transUser"
        Me.transUser.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.reportFileNameTxt)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.PrintBtn)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(563, 583)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 82)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generate Excel Report"
        '
        'reportFileNameTxt
        '
        Me.reportFileNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportFileNameTxt.Location = New System.Drawing.Point(110, 28)
        Me.reportFileNameTxt.Name = "reportFileNameTxt"
        Me.reportFileNameTxt.Size = New System.Drawing.Size(255, 29)
        Me.reportFileNameTxt.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "File name"
        '
        'PrintBtn
        '
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.Location = New System.Drawing.Point(382, 19)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(170, 49)
        Me.PrintBtn.TabIndex = 56
        Me.PrintBtn.Text = "Generate"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'SalesReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1153, 677)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.allRbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outPRbtn)
        Me.Controls.Add(Me.InPRbtn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SalesReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReportFrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SalesTransactionDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents WMYSummaryReportBtn As System.Windows.Forms.Button
    Friend WithEvents WeeklyReportBtn As System.Windows.Forms.Button
    Friend WithEvents weeklyEndDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents weeklyStartDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadDailySummaryReportsBtn As System.Windows.Forms.Button
    Friend WithEvents LoadDailyReportsBtn As System.Windows.Forms.Button
    Friend WithEvents DailySalesDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents InPatientTotalTxt As System.Windows.Forms.TextBox
    Friend WithEvents allRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents outPRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents InPRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SalesTransactionDGV As System.Windows.Forms.DataGridView
    Friend WithEvents transId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transPatientType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents reportFileNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
End Class
