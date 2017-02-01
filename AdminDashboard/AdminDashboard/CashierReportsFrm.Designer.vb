<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierReportsFrm
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
        Me.AllPatientsDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LoadByDate = New System.Windows.Forms.DateTimePicker()
        Me.SearchCashierRepBtn = New System.Windows.Forms.Button()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.TransNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AllPatientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.adminTitleLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1002, 60)
        Me.HeaderPanel.TabIndex = 16
        '
        'adminTitleLbl
        '
        Me.adminTitleLbl.AutoSize = True
        Me.adminTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.adminTitleLbl.Location = New System.Drawing.Point(26, 12)
        Me.adminTitleLbl.Name = "adminTitleLbl"
        Me.adminTitleLbl.Size = New System.Drawing.Size(237, 31)
        Me.adminTitleLbl.TabIndex = 17
        Me.adminTitleLbl.Text = "Cashier Audit Trail"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AllPatientsDGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(16, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(969, 357)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'AllPatientsDGV
        '
        Me.AllPatientsDGV.AllowUserToAddRows = False
        Me.AllPatientsDGV.AllowUserToDeleteRows = False
        Me.AllPatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllPatientsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AllPatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllPatientsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransNo, Me.TransDate, Me.Department, Me.TransAmount, Me.TransStatus})
        Me.AllPatientsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllPatientsDGV.Location = New System.Drawing.Point(3, 22)
        Me.AllPatientsDGV.Name = "AllPatientsDGV"
        Me.AllPatientsDGV.ReadOnly = True
        Me.AllPatientsDGV.Size = New System.Drawing.Size(963, 332)
        Me.AllPatientsDGV.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalTxt)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(529, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(389, 83)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'TotalTxt
        '
        Me.TotalTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTxt.Location = New System.Drawing.Point(51, 27)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Size = New System.Drawing.Size(259, 31)
        Me.TotalTxt.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LoadByDate)
        Me.GroupBox5.Controls.Add(Me.SearchCashierRepBtn)
        Me.GroupBox5.Controls.Add(Me.DateLbl)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(19, 66)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(455, 83)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search By Date"
        '
        'LoadByDate
        '
        Me.LoadByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadByDate.Location = New System.Drawing.Point(55, 32)
        Me.LoadByDate.Name = "LoadByDate"
        Me.LoadByDate.Size = New System.Drawing.Size(271, 26)
        Me.LoadByDate.TabIndex = 29
        '
        'SearchCashierRepBtn
        '
        Me.SearchCashierRepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCashierRepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCashierRepBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchCashierRepBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchCashierRepBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchCashierRepBtn.Location = New System.Drawing.Point(332, 19)
        Me.SearchCashierRepBtn.Name = "SearchCashierRepBtn"
        Me.SearchCashierRepBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchCashierRepBtn.TabIndex = 27
        Me.SearchCashierRepBtn.Text = "Search"
        Me.SearchCashierRepBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchCashierRepBtn.UseVisualStyleBackColor = True
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DateLbl.Location = New System.Drawing.Point(6, 32)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(43, 18)
        Me.DateLbl.TabIndex = 28
        Me.DateLbl.Text = "Date"
        '
        'TransNo
        '
        Me.TransNo.HeaderText = "Transaction No"
        Me.TransNo.Name = "TransNo"
        Me.TransNo.ReadOnly = True
        '
        'TransDate
        '
        Me.TransDate.HeaderText = "Date"
        Me.TransDate.Name = "TransDate"
        Me.TransDate.ReadOnly = True
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        '
        'TransAmount
        '
        Me.TransAmount.HeaderText = "Amount"
        Me.TransAmount.Name = "TransAmount"
        Me.TransAmount.ReadOnly = True
        '
        'TransStatus
        '
        Me.TransStatus.HeaderText = "Employee"
        Me.TransStatus.Name = "TransStatus"
        Me.TransStatus.ReadOnly = True
        '
        'CashierReportsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CashierReportsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashierReportsFrm"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AllPatientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents adminTitleLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AllPatientsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadByDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SearchCashierRepBtn As System.Windows.Forms.Button
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents TransNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
