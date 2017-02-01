<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierPharmacyFrm
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.WeeklyReportBtn = New System.Windows.Forms.Button()
        Me.weeklyEndDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.weeklyStartDateTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TotalSalesPriceTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LoadDailyReportsBtn = New System.Windows.Forms.Button()
        Me.DailySalesDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.CashierPharReportDGV = New System.Windows.Forms.DataGridView()
        Me.transNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.reportFileNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CashierPharReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.HeaderPanel.Size = New System.Drawing.Size(998, 93)
        Me.HeaderPanel.TabIndex = 16
        '
        'reportsFrmTitleLbl_2
        '
        Me.reportsFrmTitleLbl_2.AutoSize = True
        Me.reportsFrmTitleLbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_2.Location = New System.Drawing.Point(28, 53)
        Me.reportsFrmTitleLbl_2.Name = "reportsFrmTitleLbl_2"
        Me.reportsFrmTitleLbl_2.Size = New System.Drawing.Size(343, 20)
        Me.reportsFrmTitleLbl_2.TabIndex = 18
        Me.reportsFrmTitleLbl_2.Text = "Generate Daily, Weekly, Monthly, Yearly reports"
        '
        'reportsFrmTitleLbl_1
        '
        Me.reportsFrmTitleLbl_1.AutoSize = True
        Me.reportsFrmTitleLbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_1.Location = New System.Drawing.Point(26, 22)
        Me.reportsFrmTitleLbl_1.Name = "reportsFrmTitleLbl_1"
        Me.reportsFrmTitleLbl_1.Size = New System.Drawing.Size(382, 31)
        Me.reportsFrmTitleLbl_1.TabIndex = 17
        Me.reportsFrmTitleLbl_1.Text = "Cashier - Pharmacy Audit Trail"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.WeeklyReportBtn)
        Me.GroupBox5.Controls.Add(Me.weeklyEndDateTime)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.weeklyStartDateTime)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(21, 271)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(367, 166)
        Me.GroupBox5.TabIndex = 52
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Generate Weekly/Monthly/Yearly Sales"
        '
        'WeeklyReportBtn
        '
        Me.WeeklyReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeeklyReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeeklyReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.WeeklyReportBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.WeeklyReportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WeeklyReportBtn.Location = New System.Drawing.Point(95, 81)
        Me.WeeklyReportBtn.Name = "WeeklyReportBtn"
        Me.WeeklyReportBtn.Size = New System.Drawing.Size(147, 66)
        Me.WeeklyReportBtn.TabIndex = 50
        Me.WeeklyReportBtn.Text = "WMY Report "
        Me.WeeklyReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WeeklyReportBtn.UseVisualStyleBackColor = True
        '
        'weeklyEndDateTime
        '
        Me.weeklyEndDateTime.Location = New System.Drawing.Point(109, 53)
        Me.weeklyEndDateTime.Name = "weeklyEndDateTime"
        Me.weeklyEndDateTime.Size = New System.Drawing.Size(241, 22)
        Me.weeklyEndDateTime.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(16, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Between"
        '
        'weeklyStartDateTime
        '
        Me.weeklyStartDateTime.Location = New System.Drawing.Point(109, 21)
        Me.weeklyStartDateTime.Name = "weeklyStartDateTime"
        Me.weeklyStartDateTime.Size = New System.Drawing.Size(241, 22)
        Me.weeklyStartDateTime.TabIndex = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TotalSalesPriceTxt)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(21, 443)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(367, 120)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Sales"
        '
        'TotalSalesPriceTxt
        '
        Me.TotalSalesPriceTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSalesPriceTxt.Location = New System.Drawing.Point(42, 47)
        Me.TotalSalesPriceTxt.Name = "TotalSalesPriceTxt"
        Me.TotalSalesPriceTxt.Size = New System.Drawing.Size(255, 31)
        Me.TotalSalesPriceTxt.TabIndex = 57
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LoadDailyReportsBtn)
        Me.GroupBox2.Controls.Add(Me.DailySalesDatePicker)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(21, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 166)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Daily Sales"
        '
        'LoadDailyReportsBtn
        '
        Me.LoadDailyReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadDailyReportsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadDailyReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadDailyReportsBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadDailyReportsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadDailyReportsBtn.Location = New System.Drawing.Point(95, 79)
        Me.LoadDailyReportsBtn.Name = "LoadDailyReportsBtn"
        Me.LoadDailyReportsBtn.Size = New System.Drawing.Size(151, 66)
        Me.LoadDailyReportsBtn.TabIndex = 49
        Me.LoadDailyReportsBtn.Text = "Daily Report "
        Me.LoadDailyReportsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LoadDailyReportsBtn.UseVisualStyleBackColor = True
        '
        'DailySalesDatePicker
        '
        Me.DailySalesDatePicker.Location = New System.Drawing.Point(65, 32)
        Me.DailySalesDatePicker.Name = "DailySalesDatePicker"
        Me.DailySalesDatePicker.Size = New System.Drawing.Size(232, 22)
        Me.DailySalesDatePicker.TabIndex = 1
        '
        'CashierPharReportDGV
        '
        Me.CashierPharReportDGV.AllowUserToAddRows = False
        Me.CashierPharReportDGV.AllowUserToDeleteRows = False
        Me.CashierPharReportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CashierPharReportDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CashierPharReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CashierPharReportDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transNumber, Me.amount, Me.transDate, Me.transStatus})
        Me.CashierPharReportDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CashierPharReportDGV.Location = New System.Drawing.Point(3, 18)
        Me.CashierPharReportDGV.Name = "CashierPharReportDGV"
        Me.CashierPharReportDGV.ReadOnly = True
        Me.CashierPharReportDGV.Size = New System.Drawing.Size(586, 443)
        Me.CashierPharReportDGV.TabIndex = 54
        '
        'transNumber
        '
        Me.transNumber.HeaderText = "Transaction Number"
        Me.transNumber.Name = "transNumber"
        Me.transNumber.ReadOnly = True
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'transDate
        '
        Me.transDate.HeaderText = "Date Time"
        Me.transDate.Name = "transDate"
        Me.transDate.ReadOnly = True
        '
        'transStatus
        '
        Me.transStatus.HeaderText = "Status"
        Me.transStatus.Name = "transStatus"
        Me.transStatus.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CashierPharReportDGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(394, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 464)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.reportFileNameTxt)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.PrintBtn)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(21, 583)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 82)
        Me.GroupBox3.TabIndex = 60
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
        Me.PrintBtn.Image = Global.AdminDashboard.My.Resources.Resources.Generate
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.Location = New System.Drawing.Point(382, 19)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(170, 49)
        Me.PrintBtn.TabIndex = 56
        Me.PrintBtn.Text = "Generate"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'CashierPharmacyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 677)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CashierPharmacyFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CashierPharReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_1 As System.Windows.Forms.Label
    Friend WithEvents reportsFrmTitleLbl_2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents WeeklyReportBtn As System.Windows.Forms.Button
    Friend WithEvents weeklyEndDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents weeklyStartDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalSalesPriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadDailyReportsBtn As System.Windows.Forms.Button
    Friend WithEvents DailySalesDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CashierPharReportDGV As System.Windows.Forms.DataGridView
    Friend WithEvents transNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents reportFileNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
End Class
