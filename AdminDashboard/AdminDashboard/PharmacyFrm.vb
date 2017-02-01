Public Class PharmacyFrm

    Private pharmacyStocksController As New PharmacyStocksController

    Private Sub PharmacyFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Cursor = Cursors.WaitCursor
        'Me.LoadCategories()
        'Me.LoadAllProducts()
        'Me.LoadClassfications()
        'Me.Cursor = Cursors.Default

        Me.BatchDGV.Rows.Clear()
        Me.ClassificationDGV.Rows.Clear()
        Me.medCategoryDGV.Rows.Clear()
        Me.ProductsDGV.Rows.Clear()
    End Sub

    Private Sub LoadClassfications()
        Me.ClassificationDGV.Rows.Clear()
        Me.pharmacyStocksController.GetAllMedicineClassification(AddressOf Me.DisplayMedicineClassification)
    End Sub

    Private Sub LoadCategories()
        Me.medCategoryDGV.Rows.Clear()
        Me.pharmacyStocksController.GetAllProductCategories(AddressOf Me.DisplayProductCategories)
    End Sub



    Private Sub LoadAllBatch()
        'GetAllBatch
        Me.BatchDGV.Rows.Clear()
        Me.pharmacyStocksController.GetAllBatch(AddressOf Me.DisplayBatch)
    End Sub

    Public Sub DisplayBatch(ByVal batchId As Integer, ByVal batchNo As String)
        Try
            BatchDGV.ForeColor = Color.Black
            BatchDGV.Rows.Add(batchId, batchNo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayProductCategories(ByVal catId As Integer, ByVal catName As String)
        medCategoryDGV.ForeColor = Color.Black

        Dim medItems As New DataTable("CategoriesTable")

        Try
            medCategoryDGV.Rows.Add(catId, catName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Categories", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayMedicineClassification(ByVal medClassId As Integer, ByVal classification As String)
        Me.ClassificationDGV.ForeColor = Color.Black

        Dim classItems As New DataTable("ClassificationTable")

        Try
            Me.ClassificationDGV.Rows.Add(medClassId, classification)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayProducts(ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)
        ProductsDGV.ForeColor = Color.Black

        Dim medItems As New DataTable("PurchaseProductList")

        Try
            ProductsDGV.Rows.Add(lotNumber, brandName, genericName, category, classification, unitCost, currentStocksQuantity, expirationDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub medCategoryDGV_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles medCategoryDGV.CellMouseDoubleClick
        Try
            Dim currentRowIndex As Integer = medCategoryDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            Dim categoryId = medCategoryDGV.Item(0, currentRowIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.pharmacyStocksController.GetAllProductsInProdCategory(categoryId, AddressOf Me.DisplayProducts)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Category Double click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Private Sub RefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles RefreshBtn.Click
    '    Me.Cursor = Cursors.WaitCursor
    '    Me.LoadCategories()
    '    Me.LoadAllProducts()
    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub SearchCategory()
        Dim CategoryName As String = ""
        Try

            If Me.CategoryNameTxt.Text <> "" Then
                CategoryName = Me.CategoryNameTxt.Text
                Me.medCategoryDGV.Rows.Clear()
                Me.pharmacyStocksController.SearchCategory(CategoryName, AddressOf Me.DisplayProductCategories)
            Else
                Me.medCategoryDGV.Rows.Clear()
                Me.pharmacyStocksController.GetAllProductCategories(AddressOf Me.DisplayProductCategories)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Category button click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchCategoryBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchCategoryBtn.Click
        Me.Cursor = Cursors.WaitCursor
        Me.SearchCategory()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub CategoryNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles CategoryNameTxt.TextChanged
        Me.SearchCategory()
    End Sub

    Private Sub SearchProduct()
        Dim brandGenericName As String = ""
        Try

            If Me.ProductNameTxt.Text <> "" Then
                brandGenericName = Me.ProductNameTxt.Text

                Dim batchCurrentIndex As Integer = BatchDGV.CurrentRow.Index
                Dim batchId = BatchDGV.Item(0, batchCurrentIndex).Value.ToString


                Me.ProductsDGV.Rows.Clear()
                Me.pharmacyStocksController.SearchProduct(brandGenericName, batchId, AddressOf Me.DisplayProducts)
            Else
                Me.ProductsDGV.Rows.Clear()
                'Me.pharmacyStocksController.GetAllProducts(AddressOf Me.DisplayProducts)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SearchProductBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchProductBtn.Click
        Me.Cursor = Cursors.WaitCursor
        Me.SearchProduct()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub ProductNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles ProductNameTxt.TextChanged
        Me.SearchProduct()
    End Sub

    Private Sub ClassificationDGV_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ClassificationDGV.CellMouseDoubleClick
        Try
            Dim currentRowIndex As Integer = ClassificationDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            Dim classificationID = ClassificationDGV.Item(0, currentRowIndex).Value.ToString
            Me.ProductsDGV.Rows.Clear()
            Me.pharmacyStocksController.GetAllProductsBelongsToClassification(classificationID, AddressOf Me.DisplayProducts)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Classification Double click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub classificationNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles classificationNameTxt.TextChanged
        Me.SearchClassification()
    End Sub

    Private Sub SearchClassification()
        Dim Classfication As String = ""
        Try

            If Me.classificationNameTxt.Text <> "" Then
                Classfication = Me.classificationNameTxt.Text
                Me.ClassificationDGV.Rows.Clear()
                Me.pharmacyStocksController.SearchClassification(Classfication, AddressOf Me.DisplayMedicineClassification)
            Else
                Me.LoadClassfications()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search classification button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchClassificationBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchClassificationBtn.Click
        Me.Cursor = Cursors.WaitCursor
        Me.SearchClassification()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FilterBtn_Click(sender As System.Object, e As System.EventArgs) Handles FilterBtn.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim batchCurrentIndex As Integer = BatchDGV.CurrentRow.Index
            Dim batchId = BatchDGV.Item(0, batchCurrentIndex).Value.ToString


            Dim classificationCurrentRowIndex As Integer = ClassificationDGV.CurrentRow.Index
            Dim classificationID = ClassificationDGV.Item(0, classificationCurrentRowIndex).Value.ToString

            Dim categoryCurrentRowIndex As Integer = medCategoryDGV.CurrentRow.Index
            Dim categoryId As Integer = medCategoryDGV.Item(0, categoryCurrentRowIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.pharmacyStocksController.FilterAllProducts(classificationID, categoryId, batchId, AddressOf Me.DisplayProducts)
            Me.Cursor = Cursors.Default
        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Filter button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadAllBtn.Click
        Me.Cursor = Cursors.WaitCursor
        Me.LoadCategories()
        Me.LoadAllBatch()
        Me.LoadClassfications()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadByBatchBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadByBatchBtn.Click
        Try
            Me.LoadAllProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load By Batch button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllProducts()
        Dim batchCurrentIndex As Integer = BatchDGV.CurrentRow.Index
        Dim batchId = BatchDGV.Item(0, batchCurrentIndex).Value.ToString

        Me.ProductsDGV.Rows.Clear()
        Me.pharmacyStocksController.GetAllProducts(AddressOf Me.DisplayProducts, batchId)
    End Sub
End Class