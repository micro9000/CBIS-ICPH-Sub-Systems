

Public Class InPatientFrm

    Private pharProdController As New PharProdController

    'Private Sub InPatientFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    PharmacyFrm.Show()
    'End Sub

    Private Sub getPatientBtn_Click(sender As System.Object, e As System.EventArgs) Handles getPatientBtn.Click
        Try
            Dim transIDTemp As String = Now.ToString("yyyy")
            Dim userID = p_LoginFrm.userId
            Dim currentStockQuantity As Integer
            Dim currentBatchID As Integer
            Dim purchaseQuantity As Integer
            Dim newStockQuantity As Integer

            Dim purchaseTotalPrice As Decimal

            Dim patientAdmissionID As Integer

            If Me.patientIdTxt.Text <> "" Then
                Dim patientId As Integer = Integer.Parse(Me.patientIdTxt.Text)
                If Me.pharProdController.CheckPatient(patientId) Then
                    ' if admited
                    If Me.pharProdController.CheckPatientAdmit(patientId) Then

                        Me.pharProdController.GetPatientInfo(patientId, Me.patientFullNameTxt, Me.patientRoomNoTxt)

                        Dim ans As Integer = MessageBox.Show("Same?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If ans = 6 Then
                            If PharmacyFrm.purchaseItems.Count > 0 Then

                                patientAdmissionID = Me.pharProdController.GetPatientAdmitID(patientId)

                                Dim purchaseItems = PharmacyFrm.purchaseItems
                                Dim itemsTemps As String()
                                For Each item In purchaseItems
                                    ' Generic Name, Trade Name, Quantity, SellingPrice
                                    itemsTemps = purchaseItems(item.Key)

                                    purchaseQuantity = itemsTemps(2)
                                    ' Get the Total purchase price of one item
                                    purchaseTotalPrice = Decimal.Parse(itemsTemps(3)) * Integer.Parse(purchaseQuantity) 'Integer.Parse(itemsTemps(2))



                                    ' The current stock quantity of the item
                                    currentStockQuantity = Me.pharProdController.GetThisProductStockQuantity(item.Key)
                                    ' batch id of the item
                                    currentBatchID = Me.pharProdController.GetTheCurrentBatchID(item.Key)

                                    ' insert the patient medicines
                                    If Me.pharProdController.InsertPatientMedicines(item.Key, purchaseQuantity, purchaseTotalPrice, patientAdmissionID) Then

                                        If (currentStockQuantity >= purchaseQuantity) Then
                                            ' Get the new quantity for stock in pharmacy
                                            newStockQuantity = currentStockQuantity - purchaseQuantity
                                            ' Update the stock quantity
                                            Me.pharProdController.UpdateProdStockQuantity(newStockQuantity, currentBatchID)
                                            ' Insert new pharmacy transactions
                                            Me.pharProdController.InsertPharmacyTransactions(itemsTemps(2), itemsTemps(3), "Patient", "IN", item.Key, userID, transIDTemp)

                                        End If
                                    Else
                                        MessageBox.Show("Error Inserting patient medicines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Next
                                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                PharmacyFrm.ClearItemsBtn.PerformClick()
                                Me.Close()
                            End If
                        End If

                        
                    Else
                        MessageBox.Show("Patient is not admitted", "Invalid Patient No", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Patient doesn't exists in the database", "Invalid Patient No", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get patient button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InPatientFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class