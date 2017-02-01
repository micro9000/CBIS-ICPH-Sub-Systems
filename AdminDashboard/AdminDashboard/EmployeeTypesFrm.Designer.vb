<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeTypesFrm
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
        Me.EmployeeTypeLbl = New System.Windows.Forms.Label()
        Me.AllEmployeeTypesDGV = New System.Windows.Forms.DataGridView()
        Me.deptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deptNumOfEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateEmpTypeBtn = New System.Windows.Forms.Button()
        Me.empTypeTxt = New System.Windows.Forms.TextBox()
        Me.AddNewEmpTypeBtn = New System.Windows.Forms.Button()
        Me.DeptNameLbl = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.AllEmployeeTypesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.EmployeeTypeLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(558, 65)
        Me.HeaderPanel.TabIndex = 24
        '
        'EmployeeTypeLbl
        '
        Me.EmployeeTypeLbl.AutoSize = True
        Me.EmployeeTypeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeTypeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeTypeLbl.Location = New System.Drawing.Point(26, 22)
        Me.EmployeeTypeLbl.Name = "EmployeeTypeLbl"
        Me.EmployeeTypeLbl.Size = New System.Drawing.Size(258, 31)
        Me.EmployeeTypeLbl.TabIndex = 17
        Me.EmployeeTypeLbl.Text = "EMPLOYEE TYPES"
        '
        'AllEmployeeTypesDGV
        '
        Me.AllEmployeeTypesDGV.AllowUserToAddRows = False
        Me.AllEmployeeTypesDGV.AllowUserToDeleteRows = False
        Me.AllEmployeeTypesDGV.AllowUserToOrderColumns = True
        Me.AllEmployeeTypesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllEmployeeTypesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AllEmployeeTypesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllEmployeeTypesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deptId, Me.departmentName, Me.deptNumOfEmp})
        Me.AllEmployeeTypesDGV.Location = New System.Drawing.Point(12, 71)
        Me.AllEmployeeTypesDGV.Name = "AllEmployeeTypesDGV"
        Me.AllEmployeeTypesDGV.ReadOnly = True
        Me.AllEmployeeTypesDGV.Size = New System.Drawing.Size(534, 240)
        Me.AllEmployeeTypesDGV.TabIndex = 25
        '
        'deptId
        '
        Me.deptId.HeaderText = "ID"
        Me.deptId.Name = "deptId"
        Me.deptId.ReadOnly = True
        '
        'departmentName
        '
        Me.departmentName.HeaderText = "Department"
        Me.departmentName.Name = "departmentName"
        Me.departmentName.ReadOnly = True
        '
        'deptNumOfEmp
        '
        Me.deptNumOfEmp.HeaderText = "Number of Employees"
        Me.deptNumOfEmp.Name = "deptNumOfEmp"
        Me.deptNumOfEmp.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UpdateEmpTypeBtn)
        Me.GroupBox1.Controls.Add(Me.empTypeTxt)
        Me.GroupBox1.Controls.Add(Me.AddNewEmpTypeBtn)
        Me.GroupBox1.Controls.Add(Me.DeptNameLbl)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 159)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD, EDIT, REMOVE DEPARTMENTS"
        '
        'UpdateEmpTypeBtn
        '
        Me.UpdateEmpTypeBtn.Enabled = False
        Me.UpdateEmpTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateEmpTypeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateEmpTypeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateEmpTypeBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateEmpTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateEmpTypeBtn.Location = New System.Drawing.Point(264, 85)
        Me.UpdateEmpTypeBtn.Name = "UpdateEmpTypeBtn"
        Me.UpdateEmpTypeBtn.Size = New System.Drawing.Size(145, 43)
        Me.UpdateEmpTypeBtn.TabIndex = 47
        Me.UpdateEmpTypeBtn.Text = "UPDATE"
        Me.UpdateEmpTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateEmpTypeBtn.UseVisualStyleBackColor = True
        '
        'empTypeTxt
        '
        Me.empTypeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empTypeTxt.Location = New System.Drawing.Point(180, 41)
        Me.empTypeTxt.Name = "empTypeTxt"
        Me.empTypeTxt.Size = New System.Drawing.Size(278, 26)
        Me.empTypeTxt.TabIndex = 46
        '
        'AddNewEmpTypeBtn
        '
        Me.AddNewEmpTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewEmpTypeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewEmpTypeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewEmpTypeBtn.Image = Global.AdminDashboard.My.Resources.Resources.OK
        Me.AddNewEmpTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewEmpTypeBtn.Location = New System.Drawing.Point(113, 85)
        Me.AddNewEmpTypeBtn.Name = "AddNewEmpTypeBtn"
        Me.AddNewEmpTypeBtn.Size = New System.Drawing.Size(145, 43)
        Me.AddNewEmpTypeBtn.TabIndex = 45
        Me.AddNewEmpTypeBtn.Text = "ADD NEW"
        Me.AddNewEmpTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewEmpTypeBtn.UseVisualStyleBackColor = True
        '
        'DeptNameLbl
        '
        Me.DeptNameLbl.AutoSize = True
        Me.DeptNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeptNameLbl.Location = New System.Drawing.Point(32, 41)
        Me.DeptNameLbl.Name = "DeptNameLbl"
        Me.DeptNameLbl.Size = New System.Drawing.Size(142, 20)
        Me.DeptNameLbl.TabIndex = 18
        Me.DeptNameLbl.Text = "EMPLOYEE TYPE"
        '
        'EditBtn
        '
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EditBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditBtn.Location = New System.Drawing.Point(286, 339)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(127, 43)
        Me.EditBtn.TabIndex = 48
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'RemoveBtn
        '
        Me.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemoveBtn.Image = Global.AdminDashboard.My.Resources.Resources.cancel
        Me.RemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveBtn.Location = New System.Drawing.Point(419, 339)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(127, 43)
        Me.RemoveBtn.TabIndex = 47
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RefreshBtn.Image = Global.AdminDashboard.My.Resources.Resources.Graphicloads_Polygon_Refresh_4
        Me.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RefreshBtn.Location = New System.Drawing.Point(153, 339)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(127, 43)
        Me.RefreshBtn.TabIndex = 46
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'EmployeeTypesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.AllEmployeeTypesDGV)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(564, 596)
        Me.MinimumSize = New System.Drawing.Size(564, 596)
        Me.Name = "EmployeeTypesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.AllEmployeeTypesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents EmployeeTypeLbl As System.Windows.Forms.Label
    Friend WithEvents AllEmployeeTypesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents deptId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departmentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptNumOfEmp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateEmpTypeBtn As System.Windows.Forms.Button
    Friend WithEvents empTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddNewEmpTypeBtn As System.Windows.Forms.Button
    Friend WithEvents DeptNameLbl As System.Windows.Forms.Label
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
End Class
