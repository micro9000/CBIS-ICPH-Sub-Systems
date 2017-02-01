<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentsFrm
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
        Me.DepartmentLbl = New System.Windows.Forms.Label()
        Me.AllDepartmentsDGV = New System.Windows.Forms.DataGridView()
        Me.deptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deptNumOfEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateDeptBtn = New System.Windows.Forms.Button()
        Me.deptNameTxt = New System.Windows.Forms.TextBox()
        Me.AddNewDeptBtn = New System.Windows.Forms.Button()
        Me.DeptNameLbl = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.AllDepartmentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.DepartmentLbl)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(558, 65)
        Me.HeaderPanel.TabIndex = 23
        '
        'DepartmentLbl
        '
        Me.DepartmentLbl.AutoSize = True
        Me.DepartmentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DepartmentLbl.Location = New System.Drawing.Point(26, 22)
        Me.DepartmentLbl.Name = "DepartmentLbl"
        Me.DepartmentLbl.Size = New System.Drawing.Size(220, 31)
        Me.DepartmentLbl.TabIndex = 17
        Me.DepartmentLbl.Text = "DEPARTMENTS"
        '
        'AllDepartmentsDGV
        '
        Me.AllDepartmentsDGV.AllowUserToAddRows = False
        Me.AllDepartmentsDGV.AllowUserToDeleteRows = False
        Me.AllDepartmentsDGV.AllowUserToOrderColumns = True
        Me.AllDepartmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllDepartmentsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AllDepartmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllDepartmentsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deptId, Me.departmentName, Me.deptNumOfEmp})
        Me.AllDepartmentsDGV.Location = New System.Drawing.Point(12, 82)
        Me.AllDepartmentsDGV.Name = "AllDepartmentsDGV"
        Me.AllDepartmentsDGV.ReadOnly = True
        Me.AllDepartmentsDGV.Size = New System.Drawing.Size(534, 240)
        Me.AllDepartmentsDGV.TabIndex = 24
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
        Me.GroupBox1.Controls.Add(Me.UpdateDeptBtn)
        Me.GroupBox1.Controls.Add(Me.deptNameTxt)
        Me.GroupBox1.Controls.Add(Me.AddNewDeptBtn)
        Me.GroupBox1.Controls.Add(Me.DeptNameLbl)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 159)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD, EDIT, REMOVE DEPARTMENTS"
        '
        'UpdateDeptBtn
        '
        Me.UpdateDeptBtn.Enabled = False
        Me.UpdateDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateDeptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateDeptBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateDeptBtn.Image = Global.AdminDashboard.My.Resources.Resources.edit
        Me.UpdateDeptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateDeptBtn.Location = New System.Drawing.Point(331, 90)
        Me.UpdateDeptBtn.Name = "UpdateDeptBtn"
        Me.UpdateDeptBtn.Size = New System.Drawing.Size(145, 43)
        Me.UpdateDeptBtn.TabIndex = 47
        Me.UpdateDeptBtn.Text = "UPDATE"
        Me.UpdateDeptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateDeptBtn.UseVisualStyleBackColor = True
        '
        'deptNameTxt
        '
        Me.deptNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptNameTxt.Location = New System.Drawing.Point(217, 43)
        Me.deptNameTxt.Name = "deptNameTxt"
        Me.deptNameTxt.Size = New System.Drawing.Size(278, 26)
        Me.deptNameTxt.TabIndex = 46
        '
        'AddNewDeptBtn
        '
        Me.AddNewDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewDeptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewDeptBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNewDeptBtn.Image = Global.AdminDashboard.My.Resources.Resources.OK
        Me.AddNewDeptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewDeptBtn.Location = New System.Drawing.Point(180, 90)
        Me.AddNewDeptBtn.Name = "AddNewDeptBtn"
        Me.AddNewDeptBtn.Size = New System.Drawing.Size(145, 43)
        Me.AddNewDeptBtn.TabIndex = 45
        Me.AddNewDeptBtn.Text = "ADD NEW"
        Me.AddNewDeptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewDeptBtn.UseVisualStyleBackColor = True
        '
        'DeptNameLbl
        '
        Me.DeptNameLbl.AutoSize = True
        Me.DeptNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeptNameLbl.Location = New System.Drawing.Point(32, 41)
        Me.DeptNameLbl.Name = "DeptNameLbl"
        Me.DeptNameLbl.Size = New System.Drawing.Size(179, 20)
        Me.DeptNameLbl.TabIndex = 18
        Me.DeptNameLbl.Text = "DEPARTMENTS NAME"
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
        Me.EditBtn.TabIndex = 44
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
        Me.RemoveBtn.TabIndex = 43
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
        Me.RefreshBtn.TabIndex = 42
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'DepartmentsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AllDepartmentsDGV)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(564, 596)
        Me.MinimumSize = New System.Drawing.Size(564, 596)
        Me.Name = "DepartmentsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.AllDepartmentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents DepartmentLbl As System.Windows.Forms.Label
    Friend WithEvents AllDepartmentsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents deptId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departmentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptNumOfEmp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents DeptNameLbl As System.Windows.Forms.Label
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents AddNewDeptBtn As System.Windows.Forms.Button
    Friend WithEvents deptNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents UpdateDeptBtn As System.Windows.Forms.Button
End Class
