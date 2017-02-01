Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StockRoomController : Inherits SqlControl

    Delegate Sub DisplayAllBatch(ByVal id As Integer, ByVal lotNumber As String, ByVal batchDate As String)
    Delegate Sub DisplayProductCategories(ByVal catId As Integer, ByVal catName As String)
    Delegate Sub DisplayMedicineClassification(ByVal medClassId As Integer, ByVal classification As String)
    Delegate Sub DisplayProducts(ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)

    Public Sub GetAllBatch(ByRef displayAllBatch As DisplayAllBatch)
        Try

            Dim getAllBatchQuery As String = "SELECT * FROM MedicinesStockBatch"

            Dim sqlCommand As New SqlCommand(getAllBatchQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayAllBatch(reader("id"), reader("lotNumber"), reader("batchDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get all batch (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get all batch (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub GetBatchSupplierInfo(ByVal batchId As Integer)
        Try

            Dim getBatchSupplierInfoQuery As String = "SELECT * FROM Suppliers WHERE id=(SELECT supplierId FROM MedicinesStockBatch WHERE id = " & batchId & ")"

            Dim sqlCommand As New SqlCommand(getBatchSupplierInfoQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    SupplierFrm.companyTxt.Text = reader("companyName")
                    SupplierFrm.nameTxt.Text = reader("name")
                    SupplierFrm.contactNoTxt.Text = reader("phoneNum")
                    SupplierFrm.emailTxt.Text = reader("email")
                    SupplierFrm.addressTxt.Text = reader("address")
                End While
                SupplierFrm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get all batch (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get all batch (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetAllProductCategories(ByRef displayProductCategories As DisplayProductCategories)

        Try

            Dim getAllProductCategoriesQuery As String = "SELECT * FROM MedicineCategory"
            Dim sqlCommand As New SqlCommand(getAllProductCategoriesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProductCategories(reader("id"), reader("category"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Product Categories (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Product Categories (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub GetAllMedicineClassification(ByRef displayMedicineClassification As DisplayMedicineClassification)

        Try

            Dim getAllProductCategoriesQuery As String = "SELECT * FROM MedicineClassification"
            Dim sqlCommand As New SqlCommand(getAllProductCategoriesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayMedicineClassification(reader("id"), reader("classification"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetStocksByBatch(ByRef displayProducts As DisplayProducts, ByVal batchId As Integer)
        Try

            Dim getAllProductByBatchQuery As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName,Medicines.genericName,MedicineCategory.category," & _
                                                    "MedicineClassification.classification,Medicines.unitCost, MedicinesStockBatchItems.currentStocks,MedicinesStockBatchItems.expirationDate " & _
                                                    "FROM MedicinesStockBatch, Medicines, MedicineCategory, MedicineClassification, MedicinesStockBatchItems " & _
                                                    "WHERE MedicinesStockBatchItems.medicineID = Medicines.id " & _
                                                    "AND Medicines.categoryId = MedicineCategory.id AND Medicines.medClassificationId = MedicineClassification.id AND MedicinesStockBatchItems.batchId = MedicinesStockBatch.id AND MedicinesStockBatchItems.batchId=" & batchId

            Dim sqlCommand As New SqlCommand(getAllProductByBatchQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocks"), reader("expirationDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetStocksByFilter(ByRef displayProducts As DisplayProducts, ByVal batchId As Integer, ByVal catId As Integer, ByVal classId As Integer)
        Try

            Dim getAllProductByBatchQuery As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category," & _
                                                        " MedicineClassification.classification, Medicines.unitCost, MedicinesStockBatchItems.currentStocks, MedicinesStockBatchItems.expirationDate " & _
                                                        "FROM MedicinesStockBatch, Medicines, MedicineCategory, MedicineClassification, MedicinesStockBatchItems " & _
                                                        "WHERE  Medicines.categoryId = MedicineCategory.id " & _
                                                        "AND Medicines.medClassificationId = MedicineClassification.id " & _
                                                        "AND MedicinesStockBatchItems.medicineId = Medicines.id " & _
                                                        "AND MedicinesStockBatchItems.batchId = MedicinesStockBatch.id " & _
                                                        "AND Medicines.categoryId = " & catId & _
                                                        " AND Medicines.medClassificationId = " & classId & _
                                                        " AND MedicinesStockBatchItems.batchId=" & batchId


            Dim sqlCommand As New SqlCommand(getAllProductByBatchQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocks"), reader("expirationDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All medicine classification (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
