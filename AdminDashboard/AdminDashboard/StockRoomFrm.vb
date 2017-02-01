Imports System.Threading

Public Class StockRoomFrm

    Private stockRoomController As New StockRoomController
    Private loadBatchThread As Thread
    Private loadClasification As Thread
    Private loadCategories As Thread

    Private Sub StockRoomFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'DisplayAllBatch(1, 2, "asdf")
        Me.CheckForIllegalCrossThreadCalls = False

        Me.BatchDGV.Rows.Clear()
        Me.medCategoryDGV.Rows.Clear()
        Me.ClassificationDGV.Rows.Clear()
        Me.ProductsDGV.Rows.Clear()

    End Sub

    Public Sub DisplayAllBatch(ByVal id As Integer, ByVal lotNumber As String, ByVal batchDate As String)
        Try
            BatchDGV.ForeColor = Color.Black

            Me.BatchDGV.Rows.Add(id, lotNumber, batchDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display All Batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBatchClassCatBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadBatchClassCatBtn.Click
        Try
            Me.CheckForIllegalCrossThreadCalls = False

            Me.loadBatchThread = New Thread(AddressOf Me.LoadAllBatch)
            Me.loadBatchThread.Start()
            Me.loadBatchThread.Join()

            Me.loadClasification = New Thread(AddressOf Me.LoadAllClasification)
            Me.loadClasification.Start()
            Me.loadClasification.Join()

            Me.loadCategories = New Thread(AddressOf Me.LoadAllCategories)
            Me.loadCategories.Start()
            Me.loadCategories.Join()

        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "Load Batch Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Batch Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllBatch()
        Try
            Me.BatchDGV.Rows.Clear()
            Me.stockRoomController.GetAllBatch(AddressOf Me.DisplayAllBatch)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load all batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewSupplierBtn_Click(sender As System.Object, e As System.EventArgs) Handles ViewSupplierBtn.Click
        Try
            Dim currentRowIndex As Integer = BatchDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            Dim batchID = BatchDGV.Item(0, currentRowIndex).Value.ToString

            Me.stockRoomController.GetBatchSupplierInfo(batchID)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get supplier info")
        End Try
    End Sub

    Private Sub LoadAllCategories()
        Try
            Me.medCategoryDGV.Rows.Clear()

            Me.stockRoomController.GetAllProductCategories(AddressOf Me.DisplayProductCategories)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load all batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadAllClasification()
        Try
            Me.ClassificationDGV.Rows.Clear()
            Me.stockRoomController.GetAllMedicineClassification(AddressOf Me.DisplayMedicineClassification)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load all batch", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.ProductsDGV.ForeColor = Color.Black

        Dim medItems As New DataTable("PurchaseProductList")

        Try
            Me.ProductsDGV.Rows.Add(lotNumber, brandName, genericName, category, classification, unitCost, currentStocksQuantity, expirationDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewStockBtn_Click(sender As System.Object, e As System.EventArgs) Handles ViewStockBtn.Click
        Try
            Dim currentRowIndex As Integer = Me.BatchDGV.CurrentRow.Index
            Dim batchID = Me.BatchDGV.Item(0, currentRowIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.stockRoomController.GetStocksByBatch(AddressOf Me.DisplayProducts, batchID)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get supplier info")
        End Try
    End Sub

    Private Sub FilterBtn_Click(sender As System.Object, e As System.EventArgs) Handles FilterBtn.Click
        Try
            Dim batchCurrentRowIndex As Integer = Me.BatchDGV.CurrentRow.Index
            Dim batchID = Me.BatchDGV.Item(0, batchCurrentRowIndex).Value.ToString

            Dim classCurrentRowIndex As Integer = Me.ClassificationDGV.CurrentRow.Index
            Dim classID = Me.ClassificationDGV.Item(0, classCurrentRowIndex).Value.ToString

            Dim catCurrentRowIndex As Integer = Me.medCategoryDGV.CurrentRow.Index
            Dim catID = Me.medCategoryDGV.Item(0, catCurrentRowIndex).Value.ToString

            Me.ProductsDGV.Rows.Clear()
            Me.stockRoomController.GetStocksByFilter(AddressOf Me.DisplayProducts, batchID, catID, classID)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get supplier info")
        End Try
    End Sub
End Class