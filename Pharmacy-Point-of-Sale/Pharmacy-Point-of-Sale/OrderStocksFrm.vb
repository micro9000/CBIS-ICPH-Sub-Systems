Public Class OrderStocksFrm

    Private addStocksController As New AddStocksController

    Private OrderList As New Dictionary(Of Integer, Array)

    Private medicineId As Integer = -1

    Private userId As Integer = p_LoginFrm.userId

    'Private Sub OrderStocksFrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    PharmacyFrm.Show()
    'End Sub

    Private Sub OrderStocksFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ProductListDGV_Order.Rows.Clear()
        'Me.addStocksController.GetAllProducts(AddressOf Me.DisplayAllProducts)

        Me.DisplayRequestsStatus()
        Me.OrderList.Clear()
        Me.OrderListDGV.Rows.Clear()
    End Sub

    Private Sub SearchMedicine(ByVal brandGenName As String)
        Try
            If brandGenName <> "" Then
                Me.addStocksController.GetAllProducts(AddressOf Me.DisplayAllProducts, brandGenName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchMedTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchMedTxt.TextChanged
        Try
            Me.ProductListDGV_Order.Rows.Clear()
            Me.SearchMedicine(SearchMedTxt.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display purchase product to the datagridview
    Public Sub DisplayAllProducts(ByVal id As Integer, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String)

        ProductListDGV_Order.ForeColor = Color.Black

        Dim medItems As New DataTable("OrderProductList")

        Try
            ProductListDGV_Order.Rows.Add(id, brandName, genericName, category, classification)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub DisplayOrderList(ByVal id As Integer, ByVal brandName As String, ByVal genericName As String, ByVal quantity As Integer)
        OrderListDGV.ForeColor = Color.Black
        Dim orderList As New DataTable("OrderListTable")
        Try
            OrderListDGV.Rows.Add(id, brandName, genericName, quantity)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProductListDGV_Order_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProductListDGV_Order.CellMouseDoubleClick

        Try

            Dim currentRowIndex As Integer = ProductListDGV_Order.CurrentRow.Index
            ' Set value to select employee infos to update
            '
            ' Employee id to update
            'Dim prodId = ProductListDGV_Order.Item(0, currentRowIndex).Value.ToString
            Me.medicineId = ProductListDGV_Order.Item(0, currentRowIndex).Value.ToString

            Me.prodBrandNameTxt.Text = ProductListDGV_Order.Item(1, currentRowIndex).Value.ToString
            Me.prodGenNameTxt.Text = ProductListDGV_Order.Item(2, currentRowIndex).Value.ToString
            Me.prodCatTxt.Text = ProductListDGV_Order.Item(3, currentRowIndex).Value.ToString
            Me.classficationTxt.Text = ProductListDGV_Order.Item(4, currentRowIndex).Value.ToString

        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "Get product", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get product", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SaveThisBtn_Click(sender As System.Object, e As System.EventArgs) Handles SaveThisBtn.Click
        Try
            'Dim currentRowIndex As Integer = ProductListDGV_Order.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            'Dim prodId As Integer = Integer.Parse(ProductListDGV_Order.Item(0, currentRowIndex).Value.ToString)

            If Me.stocksQuantityTxt.Text <> "" And Me.prodBrandNameTxt.Text <> "" And Me.prodGenNameTxt.Text <> "" Then
                If Me.medicineId <> -1 Then

                    Dim prodId As Integer = Me.medicineId

                    Dim quantity As Integer = Me.stocksQuantityTxt.Text
                    Dim brandName As String = Me.prodBrandNameTxt.Text
                    Dim genericName As String = Me.prodGenNameTxt.Text

                    Dim orders As String() = {brandName, genericName, quantity}
                    If Me.OrderList.ContainsKey(prodId) Then
                        Me.OrderList.Remove(prodId)
                        Me.OrderList.Add(prodId, orders)
                    Else
                        Me.OrderList.Add(prodId, orders)
                    End If

                    MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.prodGenNameTxt.Text = ""
                    Me.prodBrandNameTxt.Text = ""
                    Me.prodCatTxt.Text = ""
                    Me.classficationTxt.Text = ""
                    Me.stocksQuantityTxt.Text = ""

                    Me.OrderListDGV.Rows.Clear()
                    For Each item In Me.OrderList
                        Dim temp As String() = Me.OrderList.Item(item.Key)
                        Me.DisplayOrderList(item.Key, temp(0), temp(1), temp(2))
                    Next
                Else
                    MessageBox.Show("Please Complete all required steps", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If


        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Get product", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddStocksNowBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddStocksNowBtn.Click

        Dim temp As String()
        Dim medId As Integer
        Dim quantity As Integer
        Dim newRequestsID As Integer
        Try
            If Me.addStocksController.InsertNewRequests(userId) Then
                newRequestsID = Me.addStocksController.GetNewRequestsID(Me.userId)
                'If Me.InsertNewRequestItems
            End If

            If Me.OrderList.Count > 0 Then
                For Each item In Me.OrderList
                    temp = Me.OrderList.Item(item.Key)
                    medId = Integer.Parse(item.Key)
                    quantity = Integer.Parse(temp(2))
                    Me.addStocksController.InsertNewRequestItems(medId, quantity, newRequestsID)
                Next

                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OrderList.Clear()
            End If

            Me.OrderListDGV.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Stocks now button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DisplayRequestsStatus()
        Try
            Me.RequestsStatusLbl.Text = Me.addStocksController.GetNewRequestsStatus(Me.userId)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Requests Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub refreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles refreshBtn.Click
        Me.OrderList.Clear()
        Me.OrderListDGV.Rows.Clear()
    End Sub

    Private Sub cancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub


End Class