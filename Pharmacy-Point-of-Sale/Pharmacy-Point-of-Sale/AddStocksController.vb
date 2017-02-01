Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class AddStocksController : Inherits SqlControl

    Delegate Sub DisplayAllProducts(ByVal id As Integer, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String)

    Public Sub GetAllProducts(ByRef displayAllProducts As DisplayAllProducts, ByVal brandGenName As String)
        'Dim query As String = "SELECT Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice,Pharmacy_Product_Stocks.prodQuantity FROM Products,Product_Categories,Pharmacy_Product_Stocks WHERE (Product_Categories.id=Products.prodCatId AND Pharmacy_Product_Stocks.prodId=Products.id)"

        Try
            Dim getAllProducts As String = "SELECT Medicines.id, Medicines.brandName, Medicines.genericName, MedicineCategory.category, MedicineClassification.classification " & _
                                            "FROM Medicines, MedicineClassification, MedicineCategory " & _
                                            "WHERE Medicines.categoryId = MedicineCategory.id AND Medicines.medClassificationId = MedicineClassification.id AND (Medicines.brandName LIKE '%" & brandGenName & "%' OR Medicines.genericName LIKE '%" & brandGenName & "%')"

            '"SELECT PharmacyStocks.medicineID, MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,PharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
            '"FROM Medicines,PharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
            '"WHERE PharmacyStocks.batchID=MedicinesStockBatch.id AND PharmacyStocks.medicineID=Medicines.id AND PharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id"

            Dim sqlCommand As New SqlCommand(getAllProducts, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayAllProducts(reader("id"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function InsertNewRequests(ByVal userID As Integer) As Boolean
        Try
            Dim insertNewRequestsQuery As String = "INSERT INTO PharmacyRequests(requestStatus, userID) VALUES('new requests', " & userID & ")"

            If Me.ExecuteCommand(insertNewRequestsQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new requests", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function GetNewRequestsID(ByVal userID As Integer) As Integer
        Dim id As Integer
        Try
            Dim getNewRequestIDQuery As String = "SELECT TOP 1 id FROM PharmacyRequests WHERE userID=" & userID & " ORDER BY id DESC"

            Dim sqlCommand As New SqlCommand(getNewRequestIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    id = reader("id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id
    End Function

    Public Function GetNewRequestsStatus(ByVal userID As Integer) As String
        Dim status As String = ""
        Try
            Dim getNewRequestIDQuery As String = "SELECT TOP 1 requestStatus FROM PharmacyRequests WHERE userID=" & userID & " ORDER BY id DESC"

            Dim sqlCommand As New SqlCommand(getNewRequestIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    status = reader("requestStatus")
                    Return status
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return status
    End Function

    Public Function InsertNewRequestItems(ByVal medId As Integer, ByVal medQuantity As Integer, ByVal pharRequestsId As Integer) As Boolean
        Try
            Dim insertNewRequestItemQuery As String = "INSERT INTO PharmacyRequestsItems(medicineID, medQuantity, pharmaRequestID) VALUES(" & medId & ", " & medQuantity & ", " & pharRequestsId & ")"

            If Me.ExecuteCommand(insertNewRequestItemQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new requests", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
End Class
