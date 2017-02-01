Public Class ERPharmacyTransDialogFrm

    Private Sub OkBtn_Click(sender As System.Object, e As System.EventArgs) Handles OkBtn.Click
        Me.Close()
    End Sub

    Private Sub ERPharmacyTransDialogFrm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ERPharmacyFrm.ClearItemsBtn.PerformClick()
    End Sub
End Class