Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StocksController : Inherits SqlControl

    Delegate Sub DisplayProductCategories(ByVal catId As Integer, ByVal catName As String)
    Delegate Sub DisplayProducts(ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)
    Delegate Sub DisplayClassification(ByVal classID As Integer, ByVal className As String)

    Delegate Sub DisplayBatch(ByVal batchId As Integer, ByVal batchNo As String)

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

    Public Sub GetAllMedicineClassification(ByRef classification As DisplayClassification)

        Try

            Dim getAllProductCategoriesQuery As String = "SELECT * FROM MedicineClassification"
            Dim sqlCommand As New SqlCommand(getAllProductCategoriesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    classification(reader("id"), reader("classification"))
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

    Public Sub GetAllProductsInProdCategory(ByVal prodCatID As Integer, ByRef displayProducts As DisplayProducts)

        Try
            Dim getThisProductQuery As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,ERPharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                            "FROM Medicines,ERPharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                            "WHERE ERPharmacyStocks.batchID=MedicinesStockBatch.id AND ERPharmacyStocks.medicineID=Medicines.id AND ERPharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id AND Medicines.categoryId=" & prodCatID

            Dim sqlCommand As New SqlCommand(getThisProductQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocksQuantity"), reader("expirationDate"))
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
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products In Product Category (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub GetAllBatch(ByRef displayBatch As DisplayBatch)
        Try
            Dim getAllBatchQuery As String = "SELECT id, lotNumber FROM MedicinesStockBatch ORDER BY id DESC"
            Dim sqlCommand As New SqlCommand(getAllBatchQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayBatch(reader("id"), reader("lotNumber"))
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
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Products In Product Category (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetAllProducts(ByRef displayProducts As DisplayProducts, ByVal batchID As Integer)
        'Dim query As String = "SELECT Products.productCode, Products.brandName, Products.genericName,Product_Categories.categoryName, Products.prodPrice,Pharmacy_Product_Stocks.prodQuantity FROM Products,Product_Categories,Pharmacy_Product_Stocks WHERE (Product_Categories.id=Products.prodCatId AND Pharmacy_Product_Stocks.prodId=Products.id)"

        Try
            Dim getAllProducts As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,ERPharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                            "FROM Medicines,ERPharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                            "WHERE ERPharmacyStocks.batchID=MedicinesStockBatch.id AND ERPharmacyStocks.medicineID=Medicines.id AND ERPharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id AND MedicinesStockBatchItems.batchID=" & batchID

            Dim sqlCommand As New SqlCommand(getAllProducts, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocksQuantity"), reader("expirationDate"))
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

    Public Sub SearchCategory(ByVal catName As String, ByRef displayProductCategories As DisplayProductCategories)
        Try
            Dim searchCategoryQuery As String = "SELECT * FROM MedicineCategory WHERE category LIKE '%" & catName & "%' "
            Dim sqlCommand As New SqlCommand(searchCategoryQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProductCategories(reader("id"), reader("category"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Search Category (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Search Category (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchClassification(ByVal className As String, ByRef classification As DisplayClassification)
        Try
            Dim searchCategoryQuery As String = "SELECT * FROM MedicineClassification WHERE classification LIKE '%" & className & "%' "
            Dim sqlCommand As New SqlCommand(searchCategoryQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    classification(reader("id"), reader("classification"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Search Classification (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Search Classication (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'SearchProduct
    Public Sub SearchProduct(ByVal prodBrandGernericName As String, ByVal batchId As Integer, ByRef displayProducts As DisplayProducts)
        Try
            Dim searchProductQuery As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost,ERPharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                            "FROM Medicines,ERPharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                            "WHERE ERPharmacyStocks.batchID=MedicinesStockBatch.id AND ERPharmacyStocks.medicineID=Medicines.id AND ERPharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id AND Medicines.medClassificationId=MedicineClassification.id " & _
                                            "AND MedicinesStockBatch.id=" & batchId & " AND (Medicines.genericName LIKE '%" & prodBrandGernericName & "%' OR Medicines.brandName LIKE '%" & prodBrandGernericName & "%')"

            Dim sqlCommand As New SqlCommand(searchProductQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocksQuantity"), reader("expirationDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Search Product (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Search Product (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FilterAllProducts(ByVal classId As Integer, ByVal catId As Integer, ByVal batchId As Integer, ByRef displayProducts As DisplayProducts)
        Try
            Dim getThisProductQuery As String = "SELECT MedicinesStockBatch.lotNumber, Medicines.brandName, Medicines.genericName, MedicineCategory.category,MedicineClassification.classification, Medicines.unitCost, ERPharmacyStocks.currentStocksQuantity, MedicinesStockBatchItems.expirationDate " & _
                                                "FROM Medicines,ERPharmacyStocks,MedicinesStockBatch,MedicinesStockBatchItems, MedicineCategory, MedicineClassification " & _
                                                "WHERE ERPharmacyStocks.batchID=MedicinesStockBatch.id AND ERPharmacyStocks.medicineID=Medicines.id AND ERPharmacyStocks.batchId=MedicinesStockBatchItems.batchId AND Medicines.id=MedicinesStockBatchItems.medicineId AND Medicines.categoryId=MedicineCategory.id" & _
                                                " AND Medicines.medClassificationId=MedicineClassification.id AND Medicines.medClassificationId=" & classId & " AND Medicines.categoryId=" & catId & " AND MedicinesStockBatch.id=" & batchId
            
            Dim sqlCommand As New SqlCommand(getThisProductQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    DisplayProducts(reader("lotNumber"), reader("brandName"), reader("genericName"), reader("category"), reader("classification"), reader("unitCost"), reader("currentStocksQuantity"), reader("expirationDate"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Filter Products (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Filter Products  (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
