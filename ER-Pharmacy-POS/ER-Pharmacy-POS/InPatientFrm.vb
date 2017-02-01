Public Class InPatientFrm

    Private erPharProdController As New ERPharProdController

    Private Sub getPatientBtn_Click(sender As System.Object, e As System.EventArgs) Handles getPatientBtn.Click
        Try

            If Me.patientIdTxt.Text <> "" Then
                Dim patientId As Integer = Integer.Parse(Me.patientIdTxt.Text)

                If Me.erPharProdController.CheckPatient(patientId) Then
                    ' If admited
                    If Me.erPharProdController.CheckPatientAdmit(patientId) Then

                        Me.erPharProdController.GetPatientInfo(patientId, Me.patientFullNameTxt, Me.patientRoomNoTxt)

                        Dim ans As Integer = MessageBox.Show("Same?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        Dim patientAdmissionID As Integer
                        If ans = 6 Then

                            If ERPharmacyFrm.purchaseItems.Count > 0 Then
                                patientAdmissionID = Me.erPharProdController.GetPatientAdmitID(patientId)

                                Dim purchaseItems = ERPharmacyFrm.purchaseItems
                                Dim itemsTemp As String()
                                Dim purchaseQuantity As Integer
                                Dim purchaseTotalPrice As Decimal
                                Dim currentStockQuantity As Integer
                                Dim currentBatchId As Integer
                                Dim newStockQuantity As Integer
                                Dim userId = LoginFrm.userId

                                For Each item In purchaseItems
                                    itemsTemp = purchaseItems.Item(item.Key)
                                    purchaseQuantity = itemsTemp(2)
                                    purchaseTotalPrice = Decimal.Parse(itemsTemp(3)) * Integer.Parse(purchaseQuantity)

                                    currentStockQuantity = Me.erPharProdController.GetThisProductStockQuantity(item.Key)
                                    currentBatchId = Me.erPharProdController.GetTheCurrentBatchID(item.Key)

                                    ' insert the patient medicines
                                    If Me.erPharProdController.InsertPatientMedicines(item.Key, purchaseQuantity, purchaseTotalPrice, patientAdmissionID) Then

                                        If (currentStockQuantity >= purchaseQuantity) Then
                                            ' Get the new quantity for stock in pharmacy
                                            newStockQuantity = currentStockQuantity - purchaseQuantity
                                            ' Update the stock quantity
                                            Me.erPharProdController.UpdateProdStockQuantity(newStockQuantity, currentBatchId)
                                            ' Insert new pharmacy transactions
                                            Me.erPharProdController.InsertERPharmacyStockOutTrans(itemsTemp(2), itemsTemp(3), "Patient", "IN", item.Key, userId)
                                            
                                        End If
                                    Else
                                        MessageBox.Show("Error Inserting patient medicines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Next
                                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ERPharmacyFrm.ClearItemsBtn.PerformClick()
                                Me.Close()
                            End If

                        End If

                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get Patient button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class