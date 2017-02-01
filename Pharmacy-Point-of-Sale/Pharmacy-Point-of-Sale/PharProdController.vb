Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class PharProdController : Inherits SqlControl

    Delegate Sub DisplayProductList(ByVal pharmacyProductId As Integer, ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)

    Public Sub GetThisProduct(ByVal brandOrGenName As String, ByRef displayProductList As DisplayProductList)

        Try
            'Dim getThisProductQuery As String = "SELECT Products.id ,Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice,Pharmacy_Product_Stocks.prodQuantity FROM Products,Product_Categories,Pharmacy_Product_Stocks WHERE (Product_Categories.id=Products.prodCatId AND Pharmacy_Product_Stocks.prodId=Products.id) AND (Products.brandName LIKE '%" & brandOrGenName & "%' OR Products.genericName LIKE '%" & brandOrGenName & "%') "
            'Dim getThisProductQuery As String = "SELECT Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice FROM Products,Product_Categories WHERE Product_Categories.id=Products.prodCatId AND (Products.brandName LIKE'%" & brandOrGenName & "%' OR Products.genericName LIKE '%" & brandOrGenName & "%')"
            Dim getThisProductQuery As String = "SELECT PharmacyStocks.medicineID, MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,PharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                            "FROM Medicines,PharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                            "WHERE PharmacyStocks.batchID=MedicinesStockBatch.id AND PharmacyStocks.medicineID=Medicines.id AND PharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id " & _
                                            "AND (Medicines.genericName LIKE '%" & brandOrGenName & "%' OR Medicines.brandName LIKE '%" & brandOrGenName & "%')  AND PharmacyStocks.currentStocksQuantity != 0 AND PharmacyStocks.currentStocksQuantity > 0"

            Dim sqlCommand As New SqlCommand(getThisProductQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProductList(reader("medicineID"), reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocksQuantity"), reader("expirationDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get this product (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get this product (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetThisProductStockQuantity(ByVal productId As Integer) As Integer

        Dim prodStocksQuantity As Integer
        Try
            Dim getThisProductStocksQuantityQuery As String = "SELECT TOP 1 currentStocksQuantity FROM PharmacyStocks WHERE medicineID=" & productId & " AND currentStocksQuantity != 0 AND currentStocksQuantity > 0"
            Dim sqlCommand As New SqlCommand(getThisProductStocksQuantityQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If reader.Read() Then
                    prodStocksQuantity = Integer.Parse(reader("currentStocksQuantity"))
                    Return prodStocksQuantity
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get this product stocks quantity (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get this product stocks quantity (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function


    'Public Function GetTheStocksQuantityDiffOfThisProd(ByVal purchaseQuantity As Integer, ByVal itemId As Integer) As Integer

    '    Dim ans As Integer

    '    Try
    '        Dim stocksDiffQuery As String = "SELECT currentStocksQuantity - " & purchaseQuantity & " as ans FROM PharmacyStocks WHERE prodId=" & itemId
    '        Dim sqlCommand As New SqlCommand(stocksDiffQuery, Me.Connection)

    '        If Me.Connection.State = False Then
    '            Me.Connection.Open()
    '        End If

    '        Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

    '        Try
    '            If (reader.Read()) Then
    '                ans = reader("ans")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Error: 0x101 - Get Stocks Quantity difference  (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Finally
    '            ' Clossing connections
    '            reader.Close()
    '            sqlCommand.Dispose()
    '            Me.Connection.Close()
    '        End Try
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error: 0x101 - Get Stocks Quantity difference (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    Return ans
    'End Function



    Public Sub InsertNewTransaction(ByVal stocksOutQuantity As Integer, ByVal stocksOutPrice As Decimal, ByVal patientType As String, ByVal prodId As Integer, ByVal userId As Integer)
        Try
            Dim insertNewTransQuery As String = "INSERT INTO PharmacyStockOutTransactions(stockOutQuantity, stockOutPrice, patientTypeID, medicineID, userId) VALUES('" & stocksOutQuantity & "', '" & stocksOutPrice & "', '" & patientType & "', " & prodId & ", " & userId & ")"

            Me.ExecuteCommand(insertNewTransQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new pharmacy transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetTheLastPharCashierTransID() As Integer

        Dim id As Integer = 0
        Try
            Dim getTheLastPharCashierTransIDQuery As String = "SELECT TOP 1 id FROM PharmacyCashierTransactions ORDER BY id DESC"
            Dim sqlCommand As New SqlCommand(getTheLastPharCashierTransIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    id = reader("id")
                    Return id
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get last id of pharmacy cashier trans id  (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get last id of pharmacy cashier trans id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id
    End Function

    Public Function InsertPharCashierTrans(ByVal transId As Integer, ByVal amount As Decimal) As Boolean
        Try
            Dim insertPharCashierTransQuery As String = "INSERT INTO PharmacyCashierTransactions(transID, amount, transStatus) VALUES(" & transId & "," & amount & ", 0)"

            If Me.ExecuteCommand(insertPharCashierTransQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new pharmacy cashier transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function Temporary_PharmacyStockOutTransactions(ByVal transId As Integer, ByVal stockOutQuantity As Integer, ByVal stockOutPrice As Decimal, ByVal whopay As String, ByVal patientType As String, ByVal medicineId As Integer, ByVal userId As Integer) As Boolean
        Try
            Dim insertPharCashierTransQuery As String = "INSERT INTO Temporary_PharmacyStockOutTransactions(pharCashierTransId, stockOutQuantity, stockOutPrice, whopay, patientType, medicineID, userID) VALUES(" & transId & "," & stockOutQuantity & ", " & stockOutPrice & ", '" & whopay & "','" & patientType & "', " & medicineId & ", " & userId & ")"

            If Me.ExecuteCommand(insertPharCashierTransQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new temporary pharmacy stock out transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function CheckPharCashierTransIfPaid(ByVal transId As Integer) As Integer
        Try
            Dim pharCashierTrans As String = "SELECT transStatus FROM PharmacyCashierTransactions WHERE transID=" & transId
            Dim sqlCommand As New SqlCommand(pharCashierTrans, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    If (reader("transStatus") = 1) Then
                        Return 1
                    ElseIf (reader("transStatus") = 2) Then
                        Return 2
                    ElseIf (reader("transStatus") = 0) Then
                        Return 0
                    Else
                        Return 3
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check pharmacy chashier transaction  (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check pharmacy chashier transaction (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function


    Public Function GetAndInsertPharmacyStockOutTransaction(ByVal transId As Integer) As Boolean
        Dim alltrans As New Dictionary(Of Integer, Array)
        Dim trans As String()
        Try
            Dim getAllPharCashierTrans As String = "SELECT * FROM Temporary_PharmacyStockOutTransactions WHERE pharCashierTransId=" & transId
            Dim sqlCommand As New SqlCommand(getAllPharCashierTrans, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    trans = {reader("stockOutQuantity"), reader("stockOutPrice"), reader("whopay"), reader("patientType"), reader("medicineId"), reader("userID"), transId}
                    alltrans.Add(reader("medicineID"), trans)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Insert Pharmacy Stock Out transaction  (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert Pharmacy Stock Out transaction  (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim temp As String()
        Dim currentBatchID As Integer
        Dim purchaseQuantity As Integer
        Dim currentStockQuantity As Integer
        Dim newStockQuantity As Integer

        If alltrans.Count > 0 Then
            For Each tran In alltrans
                ' tran.key is the id of the medicine item
                temp = alltrans.Item(tran.Key)
                InsertPharmacyTransactions(temp(0), temp(1), temp(2), temp(3), temp(4), temp(5), transId)

                ' Updating current stock of pharmacy stock start here
                purchaseQuantity = temp(0)
                ' Get the current Batch ID
                currentBatchID = Me.GetTheCurrentBatchID(tran.Key)

                'MessageBox.Show(currentBatchID)
                ' Get the quantity of the item
                currentStockQuantity = Me.GetThisProductStockQuantity(tran.Key)
                ' Get the new quantity of the purchase product/item/medicine

                If (currentStockQuantity >= purchaseQuantity) Then
                    newStockQuantity = currentStockQuantity - purchaseQuantity

                    ' Updating current stock of pharmacy stock end here
                    Me.UpdateProdStockQuantity(newStockQuantity, currentBatchID)
                    ' Delete the all temporary pharmacy stocks out transactions
                    Me.DeleteAllTemporaryPharmacyStockOutTransaction(transId, tran.Key)
                    ' 
                    Me.UpdateToClaimedThePharCashierTransaction(transId)
                End If

            Next
            Return True
        End If

        Return False
    End Function

    Public Sub InsertPharmacyTransactions(ByVal quantity As Integer, ByVal price As Decimal, ByVal whopay As String, ByVal patientType As String, ByVal medicineId As Integer, ByVal userId As Integer, ByVal pharCashierTransID As Integer)
        Try
            Dim insertPharmacyTransactionQuery As String = "INSERT INTO PharmacyStockOutTransactions(stockOutQuantity, stockOutPrice, whopay, patientType, medicineID, userID, pharCashierTransID) VALUES(" & quantity & ", " & price & ", '" & whopay & "', '" & patientType & "', " & medicineId & ", " & userId & ", " & pharCashierTransID & ")"

            Me.ExecuteCommand(insertPharmacyTransactionQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new temporary pharmacy stock out transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteAllTemporaryPharmacyStockOutTransaction(ByVal transId As Integer, ByVal medId As Integer)
        Try
            Dim deleteAllTemporaryPharmacyStockOutTransactionQuery As String = "DELETE FROM Temporary_PharmacyStockOutTransactions WHERE pharCashierTransId=" & transId & " AND medicineID=" & medId

            Me.ExecuteCommand(deleteAllTemporaryPharmacyStockOutTransactionQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new temporary pharmacy stock out transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetTheCurrentBatchID(ByVal medicineID As Integer) As Integer

        Dim id As Integer = -1
        Try
            Dim getCurrentBatchIDQuery As String = "SELECT top 1 id FROM PharmacyStocks WHERE medicineID=" & medicineID & " and currentStocksQuantity != 0 AND currentStocksQuantity > 0"
            Dim sqlCommand As New SqlCommand(getCurrentBatchIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    Return reader("id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get The current Batch ID  (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get The current Batch ID (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id
    End Function

    Public Function UpdateProdStockQuantity(ByVal newQuantity As Integer, ByVal stockID As Integer) As Boolean
        Try
            Dim updateProdStockQuantityQuery As String = "UPDATE PharmacyStocks SET currentStocksQuantity=" & newQuantity & " WHERE id=" & stockID

            If Me.ExecuteCommand(updateProdStockQuantityQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update Stocks Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Private Sub UpdateToClaimedThePharCashierTransaction(ByVal transNumber As Integer)
        Try
            Dim updateProdStockQuantity As String = "UPDATE PharmacyCashierTransactions SET transStatus=2 WHERE transID=" & transNumber

            Me.ExecuteCommand(updateProdStockQuantity)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update to done the pharmacy and cashier transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' In-patient functions

    Public Function CheckPatient(ByVal patientId As Integer) As Boolean
        Try
            Dim getPatientAdminQuery As String = "SELECT COUNT(*) AS IsEXIST FROM patient WHERE pt_ID=" & patientId

            Dim sqlCommand As New SqlCommand(getPatientAdminQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    If (reader("IsEXIST") > 0) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Sub GetPatientInfo(ByVal patientId As Integer, ByRef fullName As Object, ByRef roomNo As Object)
        Try
            Dim getPatientAdminQuery As String = "SELECT TOP 1 patient.pt_LName, patient.pt_Fname,  patient.pt_Mname, Rooms.rm_No " & _
                                                    "FROM Rooms, patient, patient_admission " & _
                                                    "WHERE patient.pt_ID = patient_admission.pt_ID And patient_admission.rm_ID = Rooms.rm_ID And patient.pt_ID=" & patientId


            Dim sqlCommand As New SqlCommand(getPatientAdminQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    fullName.Text = reader("pt_LName").ToString.ToUpper & " " & reader("pt_Fname") & " " & reader("pt_Mname")
                    roomNo.Text = reader("rm_No")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function CheckPatientAdmit(ByVal patientId As Integer) As Boolean
        Try
            Dim getPatientAdminQuery As String = "SELECT COUNT(*) AS IsEXIST FROM patient_admission WHERE pt_ID=" & patientId

            Dim sqlCommand As New SqlCommand(getPatientAdminQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    If (reader("IsEXIST") > 0) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function GetPatientAdmitID(ByVal patientId As Integer) As Integer
        Try
            Dim getPatientAdminQuery As String = "SELECT pt_admit_Id FROM patient_admission WHERE pt_ID=" & patientId

            Dim sqlCommand As New SqlCommand(getPatientAdminQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    Return reader("pt_admit_Id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function

    Public Function InsertPatientMedicines(ByVal medId As Integer, ByVal medQuantity As Integer, ByVal medTotalPrice As Decimal, ByVal ptAdmssionID As Integer) As Boolean

        Try
            Dim insertPatientMedincesQuery As String = "INSERT INTO patient_medicine(med_ID, quantity, totalprice, pt_adm_ID) VALUES(" & medId & ", " & medQuantity & ", " & medTotalPrice & ", " & ptAdmssionID & ")"

            If Me.ExecuteCommand(insertPatientMedincesQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update to done the pharmacy and cashier transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function GetMedicineUnitCost(ByVal medId As Integer) As Decimal
        Try
            Dim getMedicineUnitCostQuery As String = "SELECT unitCost FROM Medicines WHERE id=" & medId

            Dim sqlCommand As New SqlCommand(getMedicineUnitCostQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    Return reader("unitCost")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0
    End Function


    ' Return medicines functions
    '
    '
    Public Function CheckTransactionIfPaid(ByVal transNo As String) As Boolean
        Try
            Dim checkTransactionIfPaidQuery As String = "SELECT transStatus FROM PharmacyCashierTransactions WHERE transID='" & transNo & "'"

            Dim sqlCommand As New SqlCommand(checkTransactionIfPaidQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    If (reader("transStatus") = 0) Then
                        Return True
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check Transaction if paid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function GetMedicineByTransactionNo(ByVal transNo As Integer) As Dictionary(Of Integer, Array)

        Dim Items As New Dictionary(Of Integer, Array)

        Try
            Dim getMedicineByTransactionNoQuery As String = "SELECT Temporary_PharmacyStockOutTransactions.medicineID, Medicines.brandName, Medicines.genericName, Temporary_PharmacyStockOutTransactions.stockOutQuantity, " & _
                                                            "Temporary_PharmacyStockOutTransactions.stockOutPrice FROM Temporary_PharmacyStockOutTransactions, Medicines " & _
                                                            "WHERE(Temporary_PharmacyStockOutTransactions.medicineID = Medicines.id And Temporary_PharmacyStockOutTransactions.pharCashierTransId = " & transNo & ")"


            Dim sqlCommand As New SqlCommand(getMedicineByTransactionNoQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Dim itemQuantityPrice As String()
            Try
                While (reader.Read())
                    itemQuantityPrice = {reader("genericName"), reader("brandName"), reader("stockOutQuantity"), reader("stockOutPrice")}
                    If Items.ContainsKey(reader("medicineID")) Then
                        Items.Remove(reader("medicineID"))
                        Items.Add(reader("medicineID"), itemQuantityPrice)
                    Else
                        Items.Add(reader("medicineID"), itemQuantityPrice)
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Check Patient Admit (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            ' Delete all temporatory date
            'Dim tempItems As String()
            For Each temp In Items
                'tempItems = Items.Item(temp.Key)
                ' Delete the data in temporary table
                Me.DeleteAllTemporaryPharmacyStockOutTransaction(transNo, temp.Key)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check Transaction if paid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Items
    End Function


    Public Function UpdatePharCashierTrans(ByVal transId As Integer, ByVal amount As Decimal) As Boolean
        Try
            Dim updatePharCashierTransQuery As String = "UPDATE PharmacyCashierTransactions SET amount=" & amount & " WHERE transID=" & transId

            If Me.ExecuteCommand(updatePharCashierTransQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new pharmacy cashier transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Class
