Imports System.Data.DataTable

Public Class PharmacyFrm

    Private pharProdController As New PharProdController

    Public purchaseItems As New Dictionary(Of Integer, Array)

    Private purchaseTotalPrice As Decimal = 0.0

    Private transNO As String

    Private Sub PharmacyFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Start the timer to display current time and date
        Me.PharmacyTimer.Start()

        ' display username
        Me.ph_usernameLbl.Text = p_LoginFrm.auth.GetUsername().ToString.ToUpper

        ' Button small description
        Me.displayBtnDescription()
    End Sub

    ' Represents a small rectangular pop-up window that displays a 
    'brief description of a control's purpose when the user rests the pointer on the control
    Private Sub displayBtnDescription()
        ' Create the ToolTip and associate with the Form container.
        Dim description As New ToolTip()

        ' Set up the delays for the ToolTip.
        description.AutoPopDelay = 5000
        description.InitialDelay = 500
        description.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        description.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        ' Header menus
        description.SetToolTip(Me.StockOrderBtn, "Get new stocks")
        description.SetToolTip(Me.StocksBtn, "View Stocks")
        description.SetToolTip(Me.LogoutBtn, "Log-out")

        ' Item details panel buttons
        description.SetToolTip(Me.AddItemBtn, "Add new item")
        description.SetToolTip(Me.RemoveItemBtn, "Remove Item")
        description.SetToolTip(Me.ProcessTransBtn, "Process")
        description.SetToolTip(Me.ClearItemsBtn, "Clear")
    End Sub

    ' Display purchase product to the datagridview
    Private Sub DisplayPurchaseProduct(ByVal prodId As String, ByVal genericName As String, ByVal tradeName As String, ByVal quantity As Integer, ByVal sellingprice As Decimal, ByVal totalprice As Decimal)

        itemsDetailsDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("PurchaseProductList")
        Try
            itemsDetailsDGV.Rows.Add(prodId, genericName, tradeName, quantity, sellingprice, totalprice)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Display related product list
    Public Sub DisplayProductList(ByVal pharmacyProductId As Integer, ByVal lotNumber As String, ByVal brandName As String, ByVal genericName As String, ByVal category As String, ByVal classification As String, ByVal unitCost As Decimal, ByVal currentStocksQuantity As Integer, ByVal expirationDate As String)
        ProductListDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("ProductList")
        Try
            ProductListDGV.Rows.Add(pharmacyProductId, lotNumber, brandName, genericName, category, classification, unitCost, currentStocksQuantity, expirationDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Show the login form
    Private Sub showLoginForm()
        p_LoginFrm.userNameTxt.Text = ""
        p_LoginFrm.passwordTxt.Text = ""
        p_LoginFrm.Show()
    End Sub

    Private Sub PharmacyFrm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ' Remove users session
        ' Login Form -> authentication class - LogoutUser function
        If p_LoginFrm.auth.LogoutUser() Then
            Me.showLoginForm()
        End If
    End Sub

    Private Sub PharmacyTimer_Tick(sender As System.Object, e As System.EventArgs) Handles PharmacyTimer.Tick
        Me.dateNowLbl.Text = Now
    End Sub


    Private Sub StockOrderBtn_Click(sender As System.Object, e As System.EventArgs) Handles StockOrderBtn.Click
        InPatientFrm.ShowInTaskbar = False
        OrderStocksFrm.ShowDialog()
    End Sub

    Private Sub StocksBtn_Click(sender As System.Object, e As System.EventArgs) Handles StocksBtn.Click
        Try
            InPatientFrm.ShowInTaskbar = False
            StocksFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Stock Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LogoutBtn_1_Click(sender As System.Object, e As System.EventArgs) Handles LogoutBtn.Click
        Me.Close()

        ' Remove users session
        ' Login Form -> authentication class - LogoutUser function
        If p_LoginFrm.auth.LogoutUser() Then
            Me.showLoginForm()
        End If
    End Sub

    Private Sub itemNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles brandNameTxt.TextChanged

        ProductListDGV.Rows.Clear()
        'And Me.brandNameTxt.TextLength > 3
        If Me.brandNameTxt.Text <> "" Then
            Dim brandOrGenName As String = Me.brandNameTxt.Text
            Me.pharProdController.GetThisProduct(brandOrGenName, AddressOf Me.DisplayProductList)
        End If

    End Sub

    Private Sub itemsDetailsDGV_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles itemsDetailsDGV.CellMouseDoubleClick
        
    End Sub

    Private Sub ProductListDGV_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProductListDGV.CellMouseDoubleClick
        'Me.GetThisPurchaseProduct(True)
    End Sub

    Private Sub AddItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddItemBtn.Click
        'Me.GetThisPurchaseProduct(False)
        Me.AddPurchaseMedicine()
    End Sub

    Private Sub AddPurchaseMedicine()
        Try

            'Me.purchaseTotalPrice = 0

            Dim currentRowIndex As Integer = ProductListDGV.CurrentRow.Index
            ' Set value to select employee infos to update
            '
            ' Employee id to update
            Dim medId = ProductListDGV.Item(0, currentRowIndex).Value.ToString
            Dim genName = ProductListDGV.Item(2, currentRowIndex).Value.ToString
            Dim tradeName = ProductListDGV.Item(3, currentRowIndex).Value.ToString

            If Me.SellingPriceTxt.Text <> "" And Me.itemQuantityTxt.Text <> "" Then
                Dim sellingPrice As Decimal = Me.SellingPriceTxt.Text
                Dim itemQuantity As Integer = Me.itemQuantityTxt.Text

                If Decimal.TryParse(sellingPrice, 0.0) Then
                    Dim medUnitCost As Decimal = Me.pharProdController.GetMedicineUnitCost(medId)

                    If sellingPrice >= medUnitCost Then
                        ' Check the current stocks
                        Dim currentStocks As Integer = Me.pharProdController.GetThisProductStockQuantity(medId)
                        If currentStocks > 0 Then
                            If itemQuantity > 0 Then
                                If currentStocks >= itemQuantity Then
                                    ' Generic Name, Trade Name, Quantity, SellingPrice
                                    Dim itemQuantityPrice As String() = {genName, tradeName, itemQuantity, sellingPrice}

                                    ' If purchase item is already in the list
                                    If Me.purchaseItems.ContainsKey(medId) Then
                                        ' then remove the item and add again
                                        Me.purchaseItems.Remove(medId)
                                        Me.purchaseItems.Add(medId, itemQuantityPrice)
                                    Else
                                        ' else just add it
                                        Me.purchaseItems.Add(medId, itemQuantityPrice)
                                    End If
                                Else
                                    MessageBox.Show("Insufficient Stock for an order item", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If
                            Else
                                MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show(genName & "/" & tradeName & " - Insufficient Stock for an order item", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Invalid Selling price", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If


                Me.DisplayAllPurchaseItems()
                'Displaying Purchase items in datagridview
                'Dim temp As String()
                'Dim ItemTotalPrice As Decimal
                'Me.itemsDetailsDGV.Rows.Clear()
                'For Each items In Me.purchaseItems
                '    temp = Me.purchaseItems.Item(items.Key)
                '    ItemTotalPrice = temp(2) * temp(3)
                '    Me.purchaseTotalPrice += ItemTotalPrice
                '    Me.DisplayPurchaseProduct(items.Key, temp(0), temp(1), temp(2), temp(3), ItemTotalPrice)
                'Next

                '' Total Purchase
                'Me.totalPurchasePriceLbl.Text = Me.purchaseTotalPrice
            End If

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message & "No selected Item", "No Item selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exe As Exception
            MessageBox.Show(exe.Message, "Error: 0x101 - Add purchase medicine ")
        End Try
    End Sub


    Private Sub ProcessTransBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProcessTransBtn.Click
        Try
            If Me.purchaseItems.Count <> 0 Then

                If Me.inPatientRbtn.Checked = True Then
                    InPatientFrm.ShowDialog()
                    Me.inPatientRbtn.Checked = False
                End If

                If Me.outPatientRbtn.Checked = True Then

                    If Me.purchaseTotalPrice <> 0.0 Then

                        Dim totalPurchasePrice As Decimal = Me.purchaseTotalPrice
                        Dim lastPharCashierTransId = Me.pharProdController.GetTheLastPharCashierTransID()
                        Dim transIDTemp As String = Now.ToString("yyyy") & lastPharCashierTransId
                        Dim transID As Integer = Integer.Parse(transIDTemp)

                        Dim tempItems As String()
                        Dim quantity As Integer = 0
                        Dim price As Decimal = 0.0
                        Dim tempMedId As Integer = 0
                        Dim userID As Integer = 0
                        If Me.pharProdController.InsertPharCashierTrans(transID, totalPurchasePrice) Then
                            'Temporary_PharmacyStockOutTransactions
                            userID = p_LoginFrm.userId
                            For Each Item In Me.purchaseItems
                                tempItems = Me.purchaseItems.Item(Item.Key)
                                quantity = tempItems(2)
                                price = tempItems(3)
                                tempMedId = Item.Key

                                Me.pharProdController.Temporary_PharmacyStockOutTransactions(transID, quantity, price, "Patient", "OUT", tempMedId, userID)

                                'PharmacyTransDialogFrm.TransactionIDLbl.Text = transID
                                'PharmacyTransDialogFrm.AmountLbl.Text = Me.purchaseTotalPrice
                            Next
                            PharmacyTransDialogFrm.TransactionIDLbl.Text = transID
                            PharmacyTransDialogFrm.AmountLbl.Text = Me.purchaseTotalPrice
                            PharmacyTransDialogFrm.ShowDialog()
                        End If
                    End If

                    Me.outPatientRbtn.Checked = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Process button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearItemsBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearItemsBtn.Click
        Me.SellingPriceTxt.Text = ""
        Me.itemQuantityTxt.Text = ""
        Me.decreaseQuantityTxt.Text = ""
        Me.ProductListDGV.Rows.Clear()
        Me.itemsDetailsDGV.Rows.Clear()
        Me.totalPurchasePriceLbl.Text = "000.00"
        Me.purchaseItems.Clear()
    End Sub


    Private Sub SellingPriceTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SellingPriceTxt.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." Then
                If SellingPriceTxt.Text.Contains(".") Then
                    Beep()
                    e.Handled = True
                End If
            End If
        End If

    End Sub

    Private Sub itemQuantityTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles itemQuantityTxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If Not (e.KeyChar = vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AmountTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." Then
                If SellingPriceTxt.Text.Contains(".") Then
                    Beep()
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub DiscountTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> "." And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." Then
                If SellingPriceTxt.Text.Contains(".") Then
                    Beep()
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub DoneBtn_Click(sender As System.Object, e As System.EventArgs) Handles DoneBtn.Click
        Try

            If Me.transactionNumberTxt.Text <> "" Then
                Dim done_transNumber As Integer = Integer.Parse(Me.transactionNumberTxt.Text)

                If (Me.pharProdController.CheckPharCashierTransIfPaid(done_transNumber) = 1) Then
                    If Me.pharProdController.GetAndInsertPharmacyStockOutTransaction(done_transNumber) Then
                        MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf (Me.pharProdController.CheckPharCashierTransIfPaid(done_transNumber) = 2) Then
                    MessageBox.Show("Warning: Already Claimed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (Me.pharProdController.CheckPharCashierTransIfPaid(done_transNumber) = 0) Then
                    MessageBox.Show("Unpaid!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (Me.pharProdController.CheckPharCashierTransIfPaid(done_transNumber) = 3) Then
                    MessageBox.Show("No " & done_transNumber & " Transaction Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No " & done_transNumber & " Transaction Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Done Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DecreasePurchaseItemsbtn_Click(sender As System.Object, e As System.EventArgs) Handles DecreasePurchaseItemsbtn.Click

        'Me.purchaseTotalPrice = 0

        Dim currentRowIndex As Integer = itemsDetailsDGV.CurrentRow.Index

        Dim medId As Integer = Integer.Parse(itemsDetailsDGV.Item(0, currentRowIndex).Value.ToString)


        If Me.purchaseItems.Count > 0 Then
            Dim temp As String() = Me.purchaseItems.Item(medId)
            Dim quantityTemp As Integer = Integer.Parse(temp(2))

            If Me.decreaseQuantityTxt.Text <> "" Then
                Dim ans As Integer = quantityTemp - Integer.Parse(Me.decreaseQuantityTxt.Text)
                temp(2) = ans
            End If

            Me.DisplayAllPurchaseItems()
            'Dim ItemTotalPrice As Decimal
            'Me.itemsDetailsDGV.Rows.Clear()
            'For Each items In Me.purchaseItems
            '    temp = Me.purchaseItems.Item(items.Key)
            '    ItemTotalPrice = temp(2) * temp(3)
            '    Me.purchaseTotalPrice += ItemTotalPrice
            '    Me.DisplayPurchaseProduct(items.Key, temp(0), temp(1), temp(2), temp(3), ItemTotalPrice)
            'Next

            '' Total Purchase
            'Me.totalPurchasePriceLbl.Text = Me.purchaseTotalPrice
        End If


    End Sub

    Private Sub RemoveItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveItemBtn.Click


        Dim currentRowIndex As Integer = itemsDetailsDGV.CurrentRow.Index

        Dim medId As Integer = Integer.Parse(itemsDetailsDGV.Item(0, currentRowIndex).Value.ToString)


        If Me.purchaseItems.Count > 0 Then
            ' remove the item
            Me.purchaseItems.Remove(medId)

            Me.DisplayAllPurchaseItems()
        End If
    End Sub

    Private Sub DisplayAllPurchaseItems()

        Me.purchaseTotalPrice = 0

        ' display all remaining item/s
        Dim temp As String()
        Dim ItemTotalPrice As Decimal
        Me.itemsDetailsDGV.Rows.Clear()

        For Each item In Me.purchaseItems
            temp = Me.purchaseItems.Item(item.Key)
            ItemTotalPrice = temp(2) * temp(3)
            Me.purchaseTotalPrice += ItemTotalPrice
            Me.DisplayPurchaseProduct(item.Key, temp(0), temp(1), temp(2), temp(3), ItemTotalPrice)
        Next


        ' Total Purchase
        Me.totalPurchasePriceLbl.Text = Me.purchaseTotalPrice
    End Sub

    Private Sub SalesReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles SalesReportBtn.Click
        SalesReportFrm.ShowDialog()
    End Sub

    Private Sub MedReturnBtn_Click(sender As System.Object, e As System.EventArgs) Handles MedReturnBtn.Click
        Try
            Me.transNO = InputBox("Enter Transaction number", "Enter Value", "")

            If Me.transNO <> "" Then
                Me.purchaseItems = Me.pharProdController.GetMedicineByTransactionNo(Integer.Parse(Me.transNO))

                If Me.pharProdController.CheckTransactionIfPaid(Integer.Parse(Me.transNO)) Then
                    MessageBox.Show("Please be sure, that you want to edit this data", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DisplayAllPurchaseItems()

                    Me.ProcessTransBtn.Enabled = False
                    Me.ReturnMedProcessBtn.Enabled = True
                Else
                    MessageBox.Show("It's already paid, we cannot modify the data", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Return Medinces button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub ReturnMedProcessBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReturnMedProcessBtn.Click
        Try
            If Me.purchaseItems.Count > 0 Then
                If Me.inPatientRbtn.Checked = True Then
                    InPatientFrm.ShowDialog()
                    Me.inPatientRbtn.Checked = False
                End If

                If Me.outPatientRbtn.Checked = True Then

                    If Me.purchaseTotalPrice <> 0.0 Then

                        Dim totalPurchasePrice As Decimal = Me.purchaseTotalPrice
                        'Dim lastPharCashierTransId = Me.pharProdController.GetTheLastPharCashierTransID()
                        'Dim transIDTemp As String = Now.ToString("yyyy") & lastPharCashierTransId
                        Dim transID As Integer = Integer.Parse(Me.transNO) 'Integer.Parse(transIDTemp)

                        Dim tempItems As String()
                        Dim quantity As Integer = 0
                        Dim price As Decimal = 0.0
                        Dim tempMedId As Integer = 0
                        Dim userID As Integer = 0
                        ' Update the amount
                        If Me.pharProdController.UpdatePharCashierTrans(transID, totalPurchasePrice) Then
                            'Temporary_PharmacyStockOutTransactions

                            For Each Item In Me.purchaseItems
                                tempItems = Me.purchaseItems.Item(Item.Key)
                                quantity = tempItems(2)
                                price = tempItems(3)
                                tempMedId = Item.Key
                                userID = p_LoginFrm.userId


                                Me.pharProdController.Temporary_PharmacyStockOutTransactions(transID, quantity, price, "Patient", "OUT", tempMedId, userID)

                                PharmacyTransDialogFrm.TransactionIDLbl.Text = transID
                                PharmacyTransDialogFrm.AmountLbl.Text = Me.purchaseTotalPrice
                            Next
                            PharmacyTransDialogFrm.ShowDialog()
                        End If
                    End If

                    Me.outPatientRbtn.Checked = False
                End If

            End If

            Me.ProcessTransBtn.Enabled = True
            Me.ReturnMedProcessBtn.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Return Medince Process Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class