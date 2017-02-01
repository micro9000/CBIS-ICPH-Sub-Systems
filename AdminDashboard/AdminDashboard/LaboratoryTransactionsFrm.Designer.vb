<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaboratoryTransactionsFrm
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
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.adminTitleLbl = New System.Windows.Forms.Label()
        Me.LaboratoryTransDGV = New System.Windows.Forms.DataGridView()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trns_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoadAllLabTransBtn = New System.Windows.Forms.Button()
        Me.SelectedDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.LoadByDateLabTransBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotalOutTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.LaboratoryTransDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.adminTitleLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(903, 73)
        Me.HeaderPanel.TabIndex = 16
        '
        'adminTitleLbl
        '
        Me.adminTitleLbl.AutoSize = True
        Me.adminTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.adminTitleLbl.Location = New System.Drawing.Point(26, 22)
        Me.adminTitleLbl.Name = "adminTitleLbl"
        Me.adminTitleLbl.Size = New System.Drawing.Size(418, 31)
        Me.adminTitleLbl.TabIndex = 17
        Me.adminTitleLbl.Text = "Laboratory Out-Patient Audit Trail"
        '
        'LaboratoryTransDGV
        '
        Me.LaboratoryTransDGV.AllowUserToAddRows = False
        Me.LaboratoryTransDGV.AllowUserToDeleteRows = False
        Me.LaboratoryTransDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LaboratoryTransDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LaboratoryTransDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LaboratoryTransDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaboratoryTransDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trns_ID, Me.PatientName, Me.Gender, Me.SDate, Me.ServiceName, Me.ServicePrice, Me.status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LaboratoryTransDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.LaboratoryTransDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LaboratoryTransDGV.Location = New System.Drawing.Point(3, 16)
        Me.LaboratoryTransDGV.Name = "LaboratoryTransDGV"
        Me.LaboratoryTransDGV.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LaboratoryTransDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.LaboratoryTransDGV.Size = New System.Drawing.Size(873, 322)
        Me.LaboratoryTransDGV.TabIndex = 0
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'ServicePrice
        '
        Me.ServicePrice.HeaderText = "Service Price"
        Me.ServicePrice.Name = "ServicePrice"
        Me.ServicePrice.ReadOnly = True
        '
        'ServiceName
        '
        Me.ServiceName.HeaderText = "Service Name"
        Me.ServiceName.Name = "ServiceName"
        Me.ServiceName.ReadOnly = True
        '
        'SDate
        '
        Me.SDate.HeaderText = "Date"
        Me.SDate.Name = "SDate"
        Me.SDate.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "PatientName"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'trns_ID
        '
        Me.trns_ID.HeaderText = "trns_ID"
        Me.trns_ID.Name = "trns_ID"
        Me.trns_ID.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LaboratoryTransDGV)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 341)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'LoadAllLabTransBtn
        '
        Me.LoadAllLabTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadAllLabTransBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadAllLabTransBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadAllLabTransBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadAllLabTransBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoadAllLabTransBtn.Location = New System.Drawing.Point(41, 113)
        Me.LoadAllLabTransBtn.Name = "LoadAllLabTransBtn"
        Me.LoadAllLabTransBtn.Size = New System.Drawing.Size(160, 43)
        Me.LoadAllLabTransBtn.TabIndex = 46
        Me.LoadAllLabTransBtn.Text = "LOAD ALL"
        Me.LoadAllLabTransBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoadAllLabTransBtn.UseVisualStyleBackColor = True
        '
        'SelectedDateDTP
        '
        Me.SelectedDateDTP.Location = New System.Drawing.Point(65, 32)
        Me.SelectedDateDTP.Name = "SelectedDateDTP"
        Me.SelectedDateDTP.Size = New System.Drawing.Size(232, 22)
        Me.SelectedDateDTP.TabIndex = 1
        '
        'LoadByDateLabTransBtn
        '
        Me.LoadByDateLabTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadByDateLabTransBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadByDateLabTransBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoadByDateLabTransBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadByDateLabTransBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoadByDateLabTransBtn.Location = New System.Drawing.Point(99, 60)
        Me.LoadByDateLabTransBtn.Name = "LoadByDateLabTransBtn"
        Me.LoadByDateLabTransBtn.Size = New System.Drawing.Size(151, 44)
        Me.LoadByDateLabTransBtn.TabIndex = 49
        Me.LoadByDateLabTransBtn.Text = "Daily Report "
        Me.LoadByDateLabTransBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoadByDateLabTransBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LoadByDateLabTransBtn)
        Me.GroupBox2.Controls.Add(Me.SelectedDateDTP)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(245, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 122)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Daily Sales"
        '
        'TotalOutTxt
        '
        Me.TotalOutTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOutTxt.Location = New System.Drawing.Point(37, 49)
        Me.TotalOutTxt.Name = "TotalOutTxt"
        Me.TotalOutTxt.Size = New System.Drawing.Size(204, 26)
        Me.TotalOutTxt.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalOutTxt)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(607, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 122)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'LaboratoryTransactionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(903, 574)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LoadAllLabTransBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LaboratoryTransactionsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.LaboratoryTransDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents adminTitleLbl As System.Windows.Forms.Label
    Friend WithEvents LaboratoryTransDGV As System.Windows.Forms.DataGridView
    Friend WithEvents trns_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadAllLabTransBtn As System.Windows.Forms.Button
    Friend WithEvents SelectedDateDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents LoadByDateLabTransBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalOutTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
