<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InPatientFrm
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
        Me.inP_headerPan = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.patientInfoGbx = New System.Windows.Forms.GroupBox()
        Me.patientRoomNoTxt = New System.Windows.Forms.TextBox()
        Me.patientFullNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.enterPatientIdGbx = New System.Windows.Forms.GroupBox()
        Me.getPatientBtn = New System.Windows.Forms.Button()
        Me.patientIdTxt = New System.Windows.Forms.TextBox()
        Me.inP_headerPan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.patientInfoGbx.SuspendLayout()
        Me.enterPatientIdGbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'inP_headerPan
        '
        Me.inP_headerPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.inP_headerPan.Controls.Add(Me.Label5)
        Me.inP_headerPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.inP_headerPan.Location = New System.Drawing.Point(0, 0)
        Me.inP_headerPan.Name = "inP_headerPan"
        Me.inP_headerPan.Size = New System.Drawing.Size(957, 68)
        Me.inP_headerPan.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "IN-Patient Trasaction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PATIENT DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel2.Controls.Add(Me.patientInfoGbx)
        Me.Panel2.Controls.Add(Me.enterPatientIdGbx)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(957, 219)
        Me.Panel2.TabIndex = 1
        '
        'patientInfoGbx
        '
        Me.patientInfoGbx.Controls.Add(Me.patientRoomNoTxt)
        Me.patientInfoGbx.Controls.Add(Me.patientFullNameTxt)
        Me.patientInfoGbx.Controls.Add(Me.Label2)
        Me.patientInfoGbx.Controls.Add(Me.Label6)
        Me.patientInfoGbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInfoGbx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.patientInfoGbx.Location = New System.Drawing.Point(420, 59)
        Me.patientInfoGbx.Name = "patientInfoGbx"
        Me.patientInfoGbx.Size = New System.Drawing.Size(518, 146)
        Me.patientInfoGbx.TabIndex = 18
        Me.patientInfoGbx.TabStop = False
        Me.patientInfoGbx.Text = "PATIENT INFORMATION"
        '
        'patientRoomNoTxt
        '
        Me.patientRoomNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientRoomNoTxt.Enabled = False
        Me.patientRoomNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientRoomNoTxt.Location = New System.Drawing.Point(146, 60)
        Me.patientRoomNoTxt.Name = "patientRoomNoTxt"
        Me.patientRoomNoTxt.Size = New System.Drawing.Size(335, 29)
        Me.patientRoomNoTxt.TabIndex = 17
        Me.patientRoomNoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'patientFullNameTxt
        '
        Me.patientFullNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientFullNameTxt.Enabled = False
        Me.patientFullNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientFullNameTxt.Location = New System.Drawing.Point(146, 26)
        Me.patientFullNameTxt.Name = "patientFullNameTxt"
        Me.patientFullNameTxt.Size = New System.Drawing.Size(335, 29)
        Me.patientFullNameTxt.TabIndex = 16
        Me.patientFullNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ROOM NO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(25, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "FULL NAME"
        '
        'enterPatientIdGbx
        '
        Me.enterPatientIdGbx.Controls.Add(Me.getPatientBtn)
        Me.enterPatientIdGbx.Controls.Add(Me.patientIdTxt)
        Me.enterPatientIdGbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterPatientIdGbx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.enterPatientIdGbx.Location = New System.Drawing.Point(18, 59)
        Me.enterPatientIdGbx.Name = "enterPatientIdGbx"
        Me.enterPatientIdGbx.Size = New System.Drawing.Size(377, 146)
        Me.enterPatientIdGbx.TabIndex = 17
        Me.enterPatientIdGbx.TabStop = False
        Me.enterPatientIdGbx.Text = "ENTER PATIENT ID"
        '
        'getPatientBtn
        '
        Me.getPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.getPatientBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.getPatientBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.OK
        Me.getPatientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.getPatientBtn.Location = New System.Drawing.Point(95, 76)
        Me.getPatientBtn.Name = "getPatientBtn"
        Me.getPatientBtn.Size = New System.Drawing.Size(156, 55)
        Me.getPatientBtn.TabIndex = 15
        Me.getPatientBtn.Text = "SUBMIT"
        Me.getPatientBtn.UseVisualStyleBackColor = True
        '
        'patientIdTxt
        '
        Me.patientIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patientIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientIdTxt.Location = New System.Drawing.Point(69, 41)
        Me.patientIdTxt.Name = "patientIdTxt"
        Me.patientIdTxt.Size = New System.Drawing.Size(203, 29)
        Me.patientIdTxt.TabIndex = 14
        Me.patientIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InPatientFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 287)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.inP_headerPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InPatientFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Patient"
        Me.inP_headerPan.ResumeLayout(False)
        Me.inP_headerPan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.patientInfoGbx.ResumeLayout(False)
        Me.patientInfoGbx.PerformLayout()
        Me.enterPatientIdGbx.ResumeLayout(False)
        Me.enterPatientIdGbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inP_headerPan As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents patientInfoGbx As System.Windows.Forms.GroupBox
    Friend WithEvents patientRoomNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents patientFullNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents enterPatientIdGbx As System.Windows.Forms.GroupBox
    Friend WithEvents getPatientBtn As System.Windows.Forms.Button
    Friend WithEvents patientIdTxt As System.Windows.Forms.TextBox
End Class
