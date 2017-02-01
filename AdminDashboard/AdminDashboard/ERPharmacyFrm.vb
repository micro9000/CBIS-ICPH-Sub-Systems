Public Class ERPharmacyFrm

    Private stocksController As New StocksController

    'Private Sub StocksFrm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    '    PharmacyFrm.Show()
    'End Sub

    Private Sub StocksFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.LoadAll()
        Me.BatchDGV.Rows.Clear()
        Me.ClassificationDGV.Rows.Clear()
        Me.medCategoryDGV.Rows.Clear()
        Me.ProductsDGV.Rows.Clear()
    End Sub

    Private Sub LoadByBatchBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadByBatchBtn.Click

        Try
            Dim batchCurrentIndex As Integer = BatchDGV.CurrentRow.Index
            Dim batchId = BatchDGV.Item(0, batchCurrentIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.stocksController.GetAllProducts(AddressOf Me.DisplayProducts, batchId)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load By Batch button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadAll()
        Me.BatchDGV.Rows.Clear()
        Me.stocksController.GetAllBatch(AddressOf Me.DisplayBatch)

        Me.medCategoryDGV.Rows.Clear()
        Me.stocksController.GetAllProductCategories(AddressOf Me.DisplayProductCategories)


        Me.ClassificationDGV.Rows.Clear()
        Me.stocksController.GetAllMedicineClassification(AddressOf DisplayClassification)
    End Sub

    Private Sub LoadAllBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadAllBtn.Click
        Me.LoadAll()
    End Sub

    Public Sub DisplayProductCategories(ByVal catId As Integer, ByVal catName As String)
        medCategoryDGV.ForeColor = Color.Black

        Dim medItems As New DataTable("PurchaseProductList")

        Try
            medCategoryDGV.Rows.Add(catId, catName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Categories", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayClassification(ByVal classID As Integer, ByVal className As String)
        ClassificationDGV.ForeColor = Color.Black

        Dim medItems As New DataTable("ClassficationTable")

        Try
            ClassificationDGV.Rows.Add(classID, className)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Categories", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'BatchDGV

    Public Sub DisplayBatch(ByVal batchId As Integer, ByVal batchNo As String)
        Try
            BatchDGV.ForeColor = Color.Black
            BatchDGV.Rows.Add(batchId, batchNo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Me.stocksController.GetAllProductsInProdCategory(categoryId, AddressOf Me.DisplayProducts)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Category Double click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub SearchCategoryBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchCategoryBtn.Click
        Me.SearchCategory()
    End Sub

    Private Sub SearchCategory()
        Dim CategoryName As String = ""
        Try

            If Me.CategoryNameTxt.Text <> "" Then
                CategoryName = Me.CategoryNameTxt.Text
                Me.medCategoryDGV.Rows.Clear()
                Me.stocksController.SearchCategory(CategoryName, AddressOf Me.DisplayProductCategories)
            Else
                Me.medCategoryDGV.Rows.Clear()
                Me.stocksController.GetAllProductCategories(AddressOf Me.DisplayProductCategories)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Category button click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                Me.stocksController.SearchProduct(brandGenericName, batchId, AddressOf Me.DisplayProducts)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchProductBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchProductBtn.Click
        Me.SearchProduct()
    End Sub


    Private Sub ProductNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles ProductNameTxt.TextChanged
        Me.SearchProduct()
    End Sub

    Private Sub SearchClassification()
        Dim className As String = ""
        Try

            If Me.classificationNameTxt.Text <> "" Then
                className = Me.classificationNameTxt.Text
                Me.ClassificationDGV.Rows.Clear()
                Me.stocksController.SearchClassification(className, AddressOf Me.DisplayClassification)
            Else
                Me.ClassificationDGV.Rows.Clear()
                Me.stocksController.GetAllMedicineClassification(AddressOf DisplayClassification)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub classificationNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles classificationNameTxt.TextChanged
        Me.SearchClassification()
    End Sub

    Private Sub SearchClassificationBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchClassificationBtn.Click
        Me.SearchClassification()
    End Sub



    Private Sub FilterBtn_Click(sender As System.Object, e As System.EventArgs) Handles FilterBtn.Click
        Try
            Dim batchCurrentIndex As Integer = BatchDGV.CurrentRow.Index
            Dim batchId = BatchDGV.Item(0, batchCurrentIndex).Value.ToString

            Dim classificationCurrentRowIndex As Integer = ClassificationDGV.CurrentRow.Index
            Dim classificationID = ClassificationDGV.Item(0, classificationCurrentRowIndex).Value.ToString

            Dim categoryCurrentRowIndex As Integer = medCategoryDGV.CurrentRow.Index
            Dim categoryId As Integer = medCategoryDGV.Item(0, categoryCurrentRowIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.stocksController.FilterAllProducts(classificationID, categoryId, batchId, AddressOf Me.DisplayProducts)
        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Filter button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Private Sub ClearBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearBtn.Click
    '    Me.BatchDGV.Rows.Clear()
    '    Me.ClassificationDGV.Rows.Clear()
    '    Me.medCategoryDGV.Rows.Clear()
    '    Me.ProductsDGV.Rows.Clear()
    'End Sub

End Class