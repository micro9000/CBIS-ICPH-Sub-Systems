Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ERPharProdController : Inherits SqlControl

    Delegate Sub DisplayProductList(ByVal pharmacyProductId As Integer, ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)

    Public Sub GetThisProduct(ByVal brandOrGenName As String, ByRef displayProductList As DisplayProductList)

        Try
            'Dim getThisProductQuery As String = "SELECT Products.id ,Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice,Pharmacy_Product_Stocks.prodQuantity FROM Products,Product_Categories,Pharmacy_Product_Stocks WHERE (Product_Categories.id=Products.prodCatId AND Pharmacy_Product_Stocks.prodId=Products.id) AND (Products.brandName LIKE '%" & brandOrGenName & "%' OR Products.genericName LIKE '%" & brandOrGenName & "%') "
            'Dim getThisProductQuery As String = "SELECT Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice FROM Products,Product_Categories WHERE Product_Categories.id=Products.prodCatId AND (Products.brandName LIKE'%" & brandOrGenName & "%' OR Products.genericName LIKE '%" & brandOrGenName & "%')"
            Dim getThisProductQuery As String = "SELECT ERPharmacyStocks.medicineID, MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,ERPharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                            "FROM Medicines,ERPharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                            "WHERE ERPharmacyStocks.batchID=MedicinesStockBatch.id AND ERPharmacyStocks.medicineID=Medicines.id AND ERPharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id " & _
                                            "AND (Medicines.genericName LIKE '%" & brandOrGenName & "%' OR Medicines.brandName LIKE '%" & brandOrGenName & "%')  AND ERPharmacyStocks.currentStocksQuantity != 0 AND ERPharmacyStocks.currentStocksQuantity > 0"

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

    Public Function GetThisProductStockQuantity(ByVal productId As Integer) As Integer

        Dim prodStocksQuantity As Integer
        Try
            Dim getThisProductStocksQuantityQuery As String = "SELECT TOP 1 currentStocksQuantity FROM ERPharmacyStocks WHERE medicineID=" & productId & " AND currentStocksQuantity != 0 AND currentStocksQuantity > 0"
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


    Public Function GetTheLastERPharmacySalesId() As Integer

        Try
            Dim getTheLastERPharmacySalesIdQuery As String = "SELECT TOP 1 id FROM ERPharmacySales ORDER BY id DESC"
            Dim sqlCommand As New SqlCommand(getTheLastERPharmacySalesIdQuery, Me.Connection)

            Dim id As Integer
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
                MessageBox.Show(ex.Message, "Error: 0x101 - Get the last ER pharmacy sales id (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get the last ER pharmacy sales id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return -1
    End Function

    Public Function InsertNewERPharSale(ByVal transNo As String, ByVal purchaseAmount As Decimal) As Boolean

        Try
            Dim insertNewERPharSaleQuery As String = "INSERT INTO ERPharmacySales(transactionNO, totalPurchaseAmount) VALUES('" & transNo & "'," & purchaseAmount & ")"

            If Me.ExecuteCommand(insertNewERPharSaleQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new temporary pharmacy stock out transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Sub InsertERPharmacyStockOutTrans(ByVal quantity As Integer, ByVal price As Decimal, ByVal transNo As String, ByVal patientType As String, ByVal medId As Integer, ByVal userId As Integer)
        Try
            Dim insertERPharmacyStockOutTransQuery As String = "INSERT INTO ERPharmacyStockOutTransactions(stockOutQuantity, stockOutPrice, transactionNO, whopay,patientType, medicineID, userID) " & _
                                                                "VALUES(" & quantity & ", " & price & ", '" & transNo & "', 'Patient', '" & patientType & "', " & medId & ", " & userId & ")"

            Me.ExecuteCommand(insertERPharmacyStockOutTransQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new temporary pharmacy stock out transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function UpdateProdStockQuantity(ByVal newQuantity As Integer, ByVal stockID As Integer) As Boolean
        Try
            Dim updateProdStockQuantityQuery As String = "UPDATE ERPharmacyStocks SET currentStocksQuantity=" & newQuantity & " WHERE id=" & stockID

            If Me.ExecuteCommand(updateProdStockQuantityQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update Stocks Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function GetTheCurrentBatchID(ByVal medicineID As Integer) As Integer

        Dim id As Integer = -1
        Try
            Dim getCurrentBatchIDQuery As String = "SELECT TOP 1 id FROM ERPharmacyStocks WHERE medicineID=" & medicineID & " and currentStocksQuantity != 0 AND currentStocksQuantity > 0"
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
End Class
