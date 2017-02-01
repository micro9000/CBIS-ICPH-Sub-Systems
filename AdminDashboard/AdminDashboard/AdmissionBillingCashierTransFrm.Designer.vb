<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmissionBillingCashierTransFrm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.reportsFrmTitleLbl_1 = New System.Windows.Forms.Label()
        Me.AllPatientsDGV = New System.Windows.Forms.DataGridView()
        Me.patientAdmissionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.admitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DischargeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalMedicinesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proFeeTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppliesTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DateAdmit = New System.Windows.Forms.DateTimePicker()
        Me.SearchPatientByDateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PatientIDTxt = New System.Windows.Forms.TextBox()
        Me.SearchByPatientIdBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalPriceTxt = New System.Windows.Forms.TextBox()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.AllPatientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.reportsFrmTitleLbl_1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1219, 69)
        Me.HeaderPanel.TabIndex = 19
        '
        'reportsFrmTitleLbl_1
        '
        Me.reportsFrmTitleLbl_1.AutoSize = True
        Me.reportsFrmTitleLbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsFrmTitleLbl_1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reportsFrmTitleLbl_1.Location = New System.Drawing.Point(23, 24)
        Me.reportsFrmTitleLbl_1.Name = "reportsFrmTitleLbl_1"
        Me.reportsFrmTitleLbl_1.Size = New System.Drawing.Size(492, 31)
        Me.reportsFrmTitleLbl_1.TabIndex = 17
        Me.reportsFrmTitleLbl_1.Text = "Admission-Billing to Cashier transaction"
        '
        'AllPatientsDGV
        '
        Me.AllPatientsDGV.AllowUserToAddRows = False
        Me.AllPatientsDGV.AllowUserToDeleteRows = False
        Me.AllPatientsDGV.AllowUserToOrderColumns = True
        Me.AllPatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllPatientsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllPatientsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.AllPatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllPatientsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patientAdmissionID, Me.ID, Me.Fname, Me.Mname, Me.Lname, Me.room, Me.admitDate, Me.DischargeDate, Me.roomTotal, Me.TotalMedicinesPrice, Me.proFeeTotal, Me.LabTotal, Me.suppliesTotal, Me.Total, Me.patientStatus})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AllPatientsDGV.DefaultCellStyle = DataGridViewCellStyle11
        Me.AllPatientsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllPatientsDGV.Location = New System.Drawing.Point(3, 16)
        Me.AllPatientsDGV.Name = "AllPatientsDGV"
        Me.AllPatientsDGV.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllPatientsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.AllPatientsDGV.Size = New System.Drawing.Size(1189, 460)
        Me.AllPatientsDGV.TabIndex = 20
        '
        'patientAdmissionID
        '
        Me.patientAdmissionID.HeaderText = "ptAdmissionID"
        Me.patientAdmissionID.Name = "patientAdmissionID"
        Me.patientAdmissionID.ReadOnly = True
        Me.patientAdmissionID.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Fname
        '
        Me.Fname.HeaderText = "First Name"
        Me.Fname.Name = "Fname"
        Me.Fname.ReadOnly = True
        '
        'Mname
        '
        Me.Mname.HeaderText = "Middle Name"
        Me.Mname.Name = "Mname"
        Me.Mname.ReadOnly = True
        '
        'Lname
        '
        Me.Lname.HeaderText = "Last Name"
        Me.Lname.Name = "Lname"
        Me.Lname.ReadOnly = True
        '
        'room
        '
        Me.room.HeaderText = "Room Number"
        Me.room.Name = "room"
        Me.room.ReadOnly = True
        '
        'admitDate
        '
        Me.admitDate.HeaderText = "Admit Date"
        Me.admitDate.Name = "admitDate"
        Me.admitDate.ReadOnly = True
        '
        'DischargeDate
        '
        Me.DischargeDate.HeaderText = "Discharge Date"
        Me.DischargeDate.Name = "DischargeDate"
        Me.DischargeDate.ReadOnly = True
        '
        'roomTotal
        '
        Me.roomTotal.HeaderText = "Room Total"
        Me.roomTotal.Name = "roomTotal"
        Me.roomTotal.ReadOnly = True
        '
        'TotalMedicinesPrice
        '
        Me.TotalMedicinesPrice.HeaderText = "Medicines"
        Me.TotalMedicinesPrice.Name = "TotalMedicinesPrice"
        Me.TotalMedicinesPrice.ReadOnly = True
        '
        'proFeeTotal
        '
        Me.proFeeTotal.HeaderText = "Professinal Fee"
        Me.proFeeTotal.Name = "proFeeTotal"
        Me.proFeeTotal.ReadOnly = True
        '
        'LabTotal
        '
        Me.LabTotal.HeaderText = "Lab Total"
        Me.LabTotal.Name = "LabTotal"
        Me.LabTotal.ReadOnly = True
        '
        'suppliesTotal
        '
        Me.suppliesTotal.HeaderText = "Supplies Total"
        Me.suppliesTotal.Name = "suppliesTotal"
        Me.suppliesTotal.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'patientStatus
        '
        Me.patientStatus.HeaderText = "Status"
        Me.patientStatus.Name = "patientStatus"
        Me.patientStatus.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.AllPatientsDGV)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1195, 479)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admission information"
        '
        'LoadBtn
        '
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadBtn.Image = Global.AdminDashboard.My.Resources.Resources.Load
        Me.LoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoadBtn.Location = New System.Drawing.Point(15, 89)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(136, 55)
        Me.LoadBtn.TabIndex = 35
        Me.LoadBtn.Text = "LOAD ALL"
        Me.LoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateAdmit)
        Me.GroupBox5.Controls.Add(Me.SearchPatientByDateBtn)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(515, 77)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(455, 83)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search By Date"
        '
        'DateAdmit
        '
        Me.DateAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAdmit.Location = New System.Drawing.Point(55, 32)
        Me.DateAdmit.Name = "DateAdmit"
        Me.DateAdmit.Size = New System.Drawing.Size(271, 26)
        Me.DateAdmit.TabIndex = 29
        '
        'SearchPatientByDateBtn
        '
        Me.SearchPatientByDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchPatientByDateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchPatientByDateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchPatientByDateBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchPatientByDateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchPatientByDateBtn.Location = New System.Drawing.Point(332, 19)
        Me.SearchPatientByDateBtn.Name = "SearchPatientByDateBtn"
        Me.SearchPatientByDateBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchPatientByDateBtn.TabIndex = 27
        Me.SearchPatientByDateBtn.Text = "Search"
        Me.SearchPatientByDateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchPatientByDateBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PatientIDTxt)
        Me.GroupBox2.Controls.Add(Me.SearchByPatientIdBtn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(157, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 83)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search By Patient No"
        '
        'PatientIDTxt
        '
        Me.PatientIDTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDTxt.Location = New System.Drawing.Point(37, 26)
        Me.PatientIDTxt.Name = "PatientIDTxt"
        Me.PatientIDTxt.Size = New System.Drawing.Size(184, 26)
        Me.PatientIDTxt.TabIndex = 29
        '
        'SearchByPatientIdBtn
        '
        Me.SearchByPatientIdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchByPatientIdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByPatientIdBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchByPatientIdBtn.Image = Global.AdminDashboard.My.Resources.Resources.Search
        Me.SearchByPatientIdBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchByPatientIdBtn.Location = New System.Drawing.Point(227, 19)
        Me.SearchByPatientIdBtn.Name = "SearchByPatientIdBtn"
        Me.SearchByPatientIdBtn.Size = New System.Drawing.Size(114, 49)
        Me.SearchByPatientIdBtn.TabIndex = 27
        Me.SearchByPatientIdBtn.Text = "Search"
        Me.SearchByPatientIdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchByPatientIdBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalPriceTxt)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(976, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 83)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'TotalPriceTxt
        '
        Me.TotalPriceTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceTxt.Location = New System.Drawing.Point(6, 34)
        Me.TotalPriceTxt.Name = "TotalPriceTxt"
        Me.TotalPriceTxt.Size = New System.Drawing.Size(210, 26)
        Me.TotalPriceTxt.TabIndex = 30
        '
        'AdmissionBillingCashierTransFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1219, 669)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdmissionBillingCashierTransFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.AllPatientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents reportsFrmTitleLbl_1 As System.Windows.Forms.Label
    Friend WithEvents AllPatientsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchPatientByDateBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateAdmit As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchByPatientIdBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PatientIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents patientAdmissionID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents admitDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DischargeDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roomTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalMedicinesPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proFeeTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suppliesTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceTxt As System.Windows.Forms.TextBox
End Class
