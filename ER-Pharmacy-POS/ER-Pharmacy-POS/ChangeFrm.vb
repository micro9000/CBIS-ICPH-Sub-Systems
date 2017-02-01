Public Class ChangeFrm

    Private Sub DoneOkBtn_Click(sender As System.Object, e As System.EventArgs) Handles DoneOkBtn.Click
        'ERPharmacyFrm.PrintNow()

        ERPharmacyFrm.ClearItemsBtn.PerformClick()

        Me.Close()
    End Sub
End Class