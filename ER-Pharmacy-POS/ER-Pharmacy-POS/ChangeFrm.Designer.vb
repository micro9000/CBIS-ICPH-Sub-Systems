<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeFrm
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
        Me.changeHeaderLbl = New System.Windows.Forms.Label()
        Me.changeTxt = New System.Windows.Forms.TextBox()
        Me.DoneOkBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transactionNoLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'changeHeaderLbl
        '
        Me.changeHeaderLbl.AutoSize = True
        Me.changeHeaderLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeHeaderLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.changeHeaderLbl.Location = New System.Drawing.Point(125, 70)
        Me.changeHeaderLbl.Name = "changeHeaderLbl"
        Me.changeHeaderLbl.Size = New System.Drawing.Size(115, 31)
        Me.changeHeaderLbl.TabIndex = 4
        Me.changeHeaderLbl.Text = "Change"
        '
        'changeTxt
        '
        Me.changeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.changeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeTxt.Location = New System.Drawing.Point(27, 113)
        Me.changeTxt.Name = "changeTxt"
        Me.changeTxt.Size = New System.Drawing.Size(335, 40)
        Me.changeTxt.TabIndex = 15
        Me.changeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DoneOkBtn
        '
        Me.DoneOkBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneOkBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DoneOkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DoneOkBtn.Location = New System.Drawing.Point(112, 170)
        Me.DoneOkBtn.Name = "DoneOkBtn"
        Me.DoneOkBtn.Size = New System.Drawing.Size(155, 55)
        Me.DoneOkBtn.TabIndex = 16
        Me.DoneOkBtn.Text = "OK"
        Me.DoneOkBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Transaction No :"
        '
        'transactionNoLbl
        '
        Me.transactionNoLbl.AutoSize = True
        Me.transactionNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionNoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.transactionNoLbl.Location = New System.Drawing.Point(171, 29)
        Me.transactionNoLbl.Name = "transactionNoLbl"
        Me.transactionNoLbl.Size = New System.Drawing.Size(69, 20)
        Me.transactionNoLbl.TabIndex = 19
        Me.transactionNoLbl.Text = "######"
        '
        'ChangeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 256)
        Me.Controls.Add(Me.transactionNoLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DoneOkBtn)
        Me.Controls.Add(Me.changeTxt)
        Me.Controls.Add(Me.changeHeaderLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangeFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangeFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents changeHeaderLbl As System.Windows.Forms.Label
    Friend WithEvents changeTxt As System.Windows.Forms.TextBox
    Friend WithEvents DoneOkBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents transactionNoLbl As System.Windows.Forms.Label
End Class
