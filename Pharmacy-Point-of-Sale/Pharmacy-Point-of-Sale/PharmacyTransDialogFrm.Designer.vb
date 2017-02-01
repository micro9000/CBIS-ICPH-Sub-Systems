<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacyTransDialogFrm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransactionIDLbl = New System.Windows.Forms.Label()
        Me.AmountLbl = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.ReceiptPrint = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(39, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(101, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount"
        '
        'TransactionIDLbl
        '
        Me.TransactionIDLbl.AutoSize = True
        Me.TransactionIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionIDLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TransactionIDLbl.Location = New System.Drawing.Point(206, 59)
        Me.TransactionIDLbl.Name = "TransactionIDLbl"
        Me.TransactionIDLbl.Size = New System.Drawing.Size(76, 24)
        Me.TransactionIDLbl.TabIndex = 4
        Me.TransactionIDLbl.Text = "000000"
        '
        'AmountLbl
        '
        Me.AmountLbl.AutoSize = True
        Me.AmountLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AmountLbl.Location = New System.Drawing.Point(206, 114)
        Me.AmountLbl.Name = "AmountLbl"
        Me.AmountLbl.Size = New System.Drawing.Size(115, 24)
        Me.AmountLbl.TabIndex = 5
        Me.AmountLbl.Text = "00000.0000"
        '
        'OkBtn
        '
        Me.OkBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBtn.Image = Global.Pharmacy_Point_of_Sale.My.Resources.Resources.OK
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(158, 159)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(124, 65)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'PharmacyTransDialogFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 260)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.AmountLbl)
        Me.Controls.Add(Me.TransactionIDLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PharmacyTransDialogFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PharmacyTransDialogFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransactionIDLbl As System.Windows.Forms.Label
    Friend WithEvents AmountLbl As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents ReceiptPrint As System.Drawing.Printing.PrintDocument
End Class
