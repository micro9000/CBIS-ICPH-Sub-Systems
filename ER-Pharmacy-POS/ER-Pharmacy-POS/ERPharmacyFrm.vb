Public Class ERPharmacyFrm

    Private erPharProdController As New ERPharProdController

    Public purchaseItems As New Dictionary(Of Integer, Array)

    Private purchaseTotalPrice As Decimal = 0.0

    Private transNO As String

    Dim TextToPrint As String = ""
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

    Private Sub brandNameTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles brandNameTxt.TextChanged
        ProductListDGV.Rows.Clear()
        'And Me.brandNameTxt.TextLength > 3
        If Me.brandNameTxt.Text <> "" Then
            Dim brandOrGenName As String = Me.brandNameTxt.Text
            Me.erPharProdController.GetThisProduct(brandOrGenName, AddressOf Me.DisplayProductList)
        End If
    End Sub

    Private Sub showLoginForm()
        LoginFrm.userNameTxt.Text = ""
        LoginFrm.passwordTxt.Text = ""
        LoginFrm.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As System.Object, e As System.EventArgs) Handles LogoutBtn.Click
        Me.Close()

        ' Remove users session
        ' Login Form -> authentication class - LogoutUser function
        If LoginFrm.auth.LogoutUser() Then
            Me.showLoginForm()
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
        'Me.totalPurchasePriceLbl.Text = Me.purchaseTotalPrice
        TotalPurchaseTxt.Text = Me.purchaseTotalPrice

        
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
                    Dim medUnitCost As Decimal = Me.erPharProdController.GetMedicineUnitCost(medId)

                    If sellingPrice >= medUnitCost Then
                        ' Check the current stocks
                        Dim currentStocks As Integer = Me.erPharProdController.GetThisProductStockQuantity(medId)
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
            End If

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message & "No selected Item", "No Item selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exe As Exception
            MessageBox.Show(exe.Message, "Error: 0x101 - Add purchase medicine ")
        End Try
    End Sub

    Private Sub AddItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddItemBtn.Click
        Me.AddPurchaseMedicine()
    End Sub

    Private Sub ClearItemsBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearItemsBtn.Click
        Me.SellingPriceTxt.Text = ""
        Me.itemQuantityTxt.Text = ""
        Me.decreaseQuantityTxt.Text = ""
        Me.ProductListDGV.Rows.Clear()
        Me.itemsDetailsDGV.Rows.Clear()
        'Me.totalPurchasePriceLbl.Text = "000.00"
        TotalPurchaseTxt.Text = ""
        Me.purchaseItems.Clear()
    End Sub

    Private Sub DecreasePurchaseItemsbtn_Click(sender As System.Object, e As System.EventArgs) Handles DecreasePurchaseItemsbtn.Click

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

    Private Sub outPatientRbtn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles outPatientRbtn.CheckedChanged
        Me.AmountTxt.Enabled = True
    End Sub

    Private Sub inPatientRbtn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles inPatientRbtn.CheckedChanged
        Me.AmountTxt.Enabled = False
    End Sub

    Private Sub ProcessTransBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProcessTransBtn.Click
        Try
            Dim amount As Decimal = 0
            Dim change As Decimal = 0

            If Me.purchaseItems.Count <> 0 Then
                If Me.inPatientRbtn.Checked = True Then
                    InPatientFrm.ShowDialog()
                    Me.inPatientRbtn.Checked = False
                End If

                If Me.outPatientRbtn.Checked = True Then

                    If Me.purchaseTotalPrice <> 0.0 Then

                        If Me.AmountTxt.Text <> "" Then
                            amount = Me.AmountTxt.Text

                            ' change
                            If amount >= Me.purchaseTotalPrice Then
                                change = amount - Me.purchaseTotalPrice

                                Dim lastPharCashierTransId = Me.erPharProdController.GetTheLastERPharmacySalesId()
                                Dim transNoTemp As String = Now.ToString("yyyy") & lastPharCashierTransId
                                Dim transNo As String = transNoTemp

                                Dim ans As Integer = MessageBox.Show("Continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                                If ans = 6 Then

                                    If Me.erPharProdController.InsertNewERPharSale(transNo, Me.purchaseTotalPrice) Then

                                        Dim tempItems As String()
                                        Dim userID As Integer = LoginFrm.userId
                                        Dim currentBatchId As Integer
                                        Dim currentStockQuantity As Integer
                                        Dim newStockQuantity As Integer
                                        Dim purchaseQuantity As Integer

                                        ' Print start here
                                        Me.PrintHeader(transNo)

                                        Dim totalItem As Decimal
                                        For Each item In Me.purchaseItems
                                            tempItems = Me.purchaseItems.Item(item.Key)

                                            Me.erPharProdController.InsertERPharmacyStockOutTrans(tempItems(2), tempItems(3), transNo, "OUT", item.Key, userID)

                                            currentBatchId = Me.erPharProdController.GetTheCurrentBatchID(item.Key)
                                            currentStockQuantity = Me.erPharProdController.GetThisProductStockQuantity(item.Key)
                                            purchaseQuantity = tempItems(2)
                                            '{genName, tradeName, itemQuantity, sellingPrice}

                                            totalItem = purchaseQuantity * tempItems(3)
                                            ' Item to print here
                                            Me.ItemsToBePrinted(purchaseQuantity, tempItems(1), tempItems(1), totalItem)
                                            
                                            If currentStockQuantity >= purchaseQuantity Then
                                                newStockQuantity = currentStockQuantity - purchaseQuantity

                                                ' Update the product quantity
                                                Me.erPharProdController.UpdateProdStockQuantity(newStockQuantity, currentBatchId)

                                            End If

                                        Next

                                        ' Total to print
                                        Me.PrintFooter(Me.purchaseTotalPrice)

                                        ChangeFrm.transactionNoLbl.Text = transNo
                                        ChangeFrm.changeTxt.Text = change
                                        ChangeFrm.ShowDialog()

                                    End If

                                End If

                                Me.AmountTxt.Text = ""
                                Me.outPatientRbtn.Checked = False
                                Me.AmountTxt.Enabled = False
                            Else
                                MessageBox.Show("Invalid amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Process Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
        description.SetToolTip(Me.SalesReportBtn, "Sales Report")
        description.SetToolTip(Me.DecreasePurchaseItemsbtn, "Decrease the quantity")
    End Sub

    Private Sub ERPharmacyFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ph_usernameLbl.Text = LoginFrm.auth.GetUsername().ToString.ToUpper()
        Me.displayBtnDescription()

        'ReceiptPrint.PrinterSettings.PrinterName = "EPSON TM-T88V Receipt"

        Dim list As New List(Of String)

        With System.Drawing.Printing.PrinterSettings.InstalledPrinters
            For i As Integer = 0 To .Count - 1
                list.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters.Item(i))
            Next
        End With
        ReceiptPrint.PrinterSettings.PrinterName = list.Item(1)

    End Sub

    Private Sub AmountTxt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles AmountTxt.KeyPress
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

    Private Sub StockOrderBtn_Click(sender As System.Object, e As System.EventArgs) Handles StockOrderBtn.Click
        OrderStocksFrm.ShowDialog()
    End Sub

    Private Sub StocksBtn_Click(sender As System.Object, e As System.EventArgs) Handles StocksBtn.Click
        StocksFrm.ShowDialog()
    End Sub

    Private Sub SalesReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles SalesReportBtn.Click
        SalesReportFrm.ShowDialog()
    End Sub


    ' Printing receipt 

    Public Sub PrintHeader(ByVal transNo As String)

        TextToPrint = ""

        'Immaculate Concepcion Polyclinic and Hospital
        'send Business Name
        Dim StringToPrint As String = "Immaculate Concepcion"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'continue Business name
        StringToPrint = "Polyclinic and Hospital"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "Green Village, Concoption Tarlac"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine & Environment.NewLine

        'Date
        StringToPrint = "Date: " & Date.Now
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        'Transaction No
        StringToPrint = "Transaction #: " & transNo
        LineLen = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine

        ' Current employee
        StringToPrint = "Your Server:" & LoginFrm.auth.GetUsername()
        LineLen = StringToPrint.Length
        Dim spcLen6 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine & Environment.NewLine

        TextToPrint &= "Items:" & Environment.NewLine

        TextToPrint &= " Qty         Item        Total" & Environment.NewLine
    End Sub


    Public Sub ItemsToBePrinted(ByVal quantity As String, ByVal brandName As String, ByVal genName As String, ByVal medItemTotal As Decimal)

        Dim StringToPrint As String = " " & quantity & " - " & brandName & "    ₱ " & medItemTotal.ToString
        TextToPrint &= StringToPrint & Environment.NewLine
        TextToPrint &= "    " & genName & Environment.NewLine & Environment.NewLine

    End Sub

    Public Sub PrintFooter(ByVal total As Decimal)

        Dim StringToPrint = "_________________________________"
        Dim LineLen = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine & Environment.NewLine

        ' Total
        StringToPrint = "   TOTAL  ₱ " & total.ToString
        LineLen = StringToPrint.Length
        Dim spcLen6 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine & Environment.NewLine


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ReceiptPrint.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With ReceiptPrint.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub


    Public Sub PrintNow()

        Dim printControl = New Printing.StandardPrintController
        ReceiptPrint.PrintController = printControl
        Try
            ReceiptPrint.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class