Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Threading


Public Class MainFrm

    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook

    Private insertMedNowThread As Thread
    Private insertMedCatThread As Thread
    Private insertMedClassThread As Thread
    Private insertSupplierThread As Thread

    Dim inputStocksCon As New InputStocksController

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub DisplayMedicines(ByVal brandName As String, ByVal genName As String, ByVal unitCost As String, ByVal catName As String, ByVal className As String)
        StocksDGV.ForeColor = Color.Black

        Try
            StocksDGV.Rows.Add(brandName, genName, unitCost, catName, className)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying medicines", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayCategory(ByVal catName As String)
        CategoriesDGV.ForeColor = Color.Black

        Try
            CategoriesDGV.Rows.Add(catName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying category", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub DisplayClassification(ByVal className As String)
        CategoriesDGV.ForeColor = Color.Black

        Try
            ClassificationDGV.Rows.Add(className)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplaySuppliers(ByVal compName As String, ByVal name As String, ByVal contactNo As String, ByVal email As String, ByVal address As String)
        SupplierDGV.ForeColor = Color.Black

        Try
            SupplierDGV.Rows.Add(compName, name, contactNo, email, address)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub OpenFileDialogForFileName(ByRef textBox As Object)
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        '"txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    textBox = openFileDialog1.FileName
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub BrowseBtn_Click(sender As System.Object, e As System.EventArgs) Handles BrowseBtn.Click

        Me.OpenFileDialogForFileName(fileNameTxt.Text)

    End Sub

    Private Sub InsertNow_Click(sender As System.Object, e As System.EventArgs) Handles InsertMedNowBtn.Click
        Try
            If fileNameTxt.Text <> "" Then
                Me.insertMedNowThread = New Thread(AddressOf Me.ReadMedOneByOne)
                Me.insertMedNowThread.Start()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Now button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReadMedOneByOne()

        Try
            workbook = APP.Workbooks.Open(fileNameTxt.Text)
            worksheet = workbook.Worksheets("sheet1")

            Dim excelRowLen As Integer = worksheet.UsedRange.Rows.Count
            'Dim excelColLen As Integer = worksheet.UsedRange.Columns.Count

            Dim brandName As String = ""
            Dim genName As String = ""
            Dim unitCost As String = ""
            Dim category As String = ""
            Dim classification As String = ""

            Dim catId As Integer = -1
            Dim classId As Integer = -1
            'Me.insertNowThread = New Thread(AddressOf 

            'Me.MedProgBar.Maximum = excelRowLen
            For row As Integer = 2 To excelRowLen

                brandName = worksheet.Cells(row, 2).Value
                genName = worksheet.Cells(row, 3).Value
                unitCost = worksheet.Cells(row, 6).Value
                category = worksheet.Cells(row, 5).Value
                classification = worksheet.Cells(row, 5).Value ' Temporary

                brandName = brandName.Replace("'", "")
                genName = genName.Replace("'", "")

                ' here for classification editing
                If inputStocksCon.GetMedCategoryId(category) > 0 And inputStocksCon.GetMedClassificationId(classification) > 0 Then
                    catId = inputStocksCon.GetMedCategoryId(category)
                    classId = inputStocksCon.GetMedClassificationId(classification)

                    If Not inputStocksCon.CheckMedicineExistence(brandName, genName) Then

                        inputStocksCon.InsertNewMed(brandName, genName, unitCost, catId, classId)

                        Me.DisplayMedicines(brandName, genName, unitCost, category, classification)

                        Me.StocksDGV.FirstDisplayedScrollingRowIndex = Me.StocksDGV.RowCount - 1
                    End If

                    Threading.Thread.Sleep(100)
                End If

                
            Next

            MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            workbook.Save()
            workbook.Close()
            APP.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Medicines", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub


    Private Sub BrowseCategories_Click(sender As System.Object, e As System.EventArgs) Handles BrowseCategories.Click

        Me.OpenFileDialogForFileName(catTxt.Text)

    End Sub

    Private Sub InsertCatNowBtn_Click(sender As System.Object, e As System.EventArgs) Handles InsertCatNowBtn.Click
        Try
            If Me.catTxt.Text <> "" Then
                Me.insertMedCatThread = New Thread(AddressOf Me.ReadMedCatOneByOne)
                Me.insertMedCatThread.Start()
            End If
            
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ReadMedCatOneByOne()
        Try

            workbook = APP.Workbooks.Open(catTxt.Text)
            worksheet = workbook.Worksheets("sheet1")

            Dim excelRowLen As Integer = worksheet.UsedRange.Rows.Count
            Dim excelColLen As Integer = worksheet.UsedRange.Columns.Count

            Dim category As String = ""

            For row As Integer = 2 To excelRowLen

                category = worksheet.Cells(row, 5).Value

                ' Check if category not already exits
                If Not inputStocksCon.CheckMedCategoryExistence(category) Then

                    ' insert category
                    If inputStocksCon.InsertNewMedCategory(category) Then
                        Me.DisplayCategory(category)

                        Me.CategoriesDGV.FirstDisplayedScrollingRowIndex = Me.CategoriesDGV.RowCount - 1
                    End If
                    
                End If

                Threading.Thread.Sleep(100)
            Next

            MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            workbook.Save()
            workbook.Close()
            APP.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Medicine Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MainFrm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            workbook.Save()
            workbook.Close()
            APP.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub BrowseClassification_Click(sender As System.Object, e As System.EventArgs) Handles BrowseClassification.Click
        Me.OpenFileDialogForFileName(ClassificationTxt.Text)
    End Sub

    Private Sub InsertClassificaitonBtn_Click(sender As System.Object, e As System.EventArgs) Handles InsertClassificaitonBtn.Click
        Try
            If Me.ClassificationTxt.Text <> "" Then
                Me.insertMedClassThread = New Thread(AddressOf Me.ReadMedClassOneByOne)
                Me.insertMedClassThread.Start()
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReadMedClassOneByOne()
        Try

            workbook = APP.Workbooks.Open(ClassificationTxt.Text)
            worksheet = workbook.Worksheets("sheet1")

            Dim excelRowLen As Integer = worksheet.UsedRange.Rows.Count
            Dim excelColLen As Integer = worksheet.UsedRange.Columns.Count

            Dim classification As String = ""

            For row As Integer = 2 To excelRowLen

                classification = worksheet.Cells(row, 5).Value

                If Not inputStocksCon.CheckMedClassificationExistence(classification) Then

                    If inputStocksCon.InsertNewMedClassification(classification) Then

                        Me.DisplayClassification(classification)

                        Me.ClassificationDGV.FirstDisplayedScrollingRowIndex = Me.ClassificationDGV.RowCount - 1

                    End If
                End If

                
                Threading.Thread.Sleep(100)
            Next

            MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            workbook.Save()
            workbook.Close()
            APP.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Medicine Classfication", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BrowseSuppliers_Click(sender As System.Object, e As System.EventArgs) Handles BrowseSuppliers.Click

        Me.OpenFileDialogForFileName(Me.supplierFileName.Text)

    End Sub

    Public Sub ReadSuppliersOneByOne()
        Try

            workbook = APP.Workbooks.Open(supplierFileName.Text)
            worksheet = workbook.Worksheets("sheet1")

            Dim excelRowLen As Integer = worksheet.UsedRange.Rows.Count
            Dim excelColLen As Integer = worksheet.UsedRange.Columns.Count

            Dim companyName As String = ""
            Dim name As String = ""
            Dim contactNo As String = ""
            Dim email As String = ""
            Dim address As String = ""

            For row As Integer = 2 To excelRowLen

                companyName = worksheet.Cells(row, 1).Value
                name = worksheet.Cells(row, 2).Value
                contactNo = worksheet.Cells(row, 3).Value
                email = worksheet.Cells(row, 4).Value
                address = worksheet.Cells(row, 5).Value

                If Me.inputStocksCon.InsertNewSupplier(companyName, name, contactNo, email, address) Then
                    Me.DisplaySuppliers(companyName, name, contactNo, email, address)
                End If

                Threading.Thread.Sleep(100)
            Next

            MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            workbook.Save()
            workbook.Close()
            APP.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub insertNowSupplierBtn_Click(sender As System.Object, e As System.EventArgs) Handles insertNowSupplierBtn.Click
        Try
            Me.insertSupplierThread = New Thread(AddressOf Me.ReadSuppliersOneByOne)
            Me.insertSupplierThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Now Suppliers button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayAllSuppliers(ByVal id As Integer, ByVal name As String)
        SupDGV.ForeColor = Color.Black

        Try
            SupDGV.Rows.Add(id, name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayAllMedicines(ByVal id As Integer, ByVal brandName As String, ByVal genName As String)
        MedsDGV.ForeColor = Color.Black

        Try
            MedsDGV.Rows.Add(id, brandName, genName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SearchMedTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchMedTxt.TextChanged
        Try
            '' Load all medicines
            Me.MedsDGV.Rows.Clear()
            Me.inputStocksCon.GetAllMedicines(AddressOf Me.DisplayAllMedicines, SearchMedTxt.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load All Data Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SearchSupplierTxt_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles SearchSupplierTxt.TextChanged
        Try
            ' Load all suppliers
            Me.SupDGV.Rows.Clear()
            Me.inputStocksCon.GetAllSuppliers(AddressOf Me.DisplayAllSuppliers, SearchSupplierTxt.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search supplier text", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertNewBatchBtn_Click(sender As System.Object, e As System.EventArgs) Handles InsertNewBatchBtn.Click
        Try
            

            Dim supCurIndex As Integer = SupDGV.CurrentRow.Index

            Dim supID As Integer = SupDGV.Item(0, supCurIndex).Value.ToString

            If Me.inputStocksCon.InsertNewBatch(Me.NewBatchTxt.Text, supID) Then
                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert New Batch button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MyTab_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MyTab.SelectedIndexChanged
        If MyTab.SelectedTab Is AddBatch Then
            Try
                Dim curYear As String = Now.Year
                Dim lastBatchID As Integer = Me.inputStocksCon.GetTheLastBatchID()
                Dim batchNo As String = curYear & "-" & lastBatchID

                Me.NewBatchTxt.Text = batchNo
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add batch click", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub DisplayAllBatch(ByRef id As Integer, ByVal batch As String)
        AllBatchDGV.ForeColor = Color.Black

        Try
            AllBatchDGV.Rows.Add(id, batch)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim MedPerSupplierBatchItems As New Dictionary(Of Integer, Array)

    Private Sub AddMedPerSupplierBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddMedPerSupplierBtn.Click
        Try

            If QuantityTxt.Text <> "" And QuantityTxt.Text <> 0 And CurrentStocksTxt.Text <> "" And CurrentStocksTxt.Text <> 0 Then

                Me.BatchSupplierMedsDGV.Rows.Clear()


                Dim medCurrRowIndex As Integer = MedsDGV.CurrentRow.Index

                Dim medId As Integer = MedsDGV.Item(0, medCurrRowIndex).Value.ToString
                Dim brandName As String = MedsDGV.Item(1, medCurrRowIndex).Value.ToString
                Dim genName As String = MedsDGV.Item(2, medCurrRowIndex).Value.ToString

                Dim quantity As Integer = QuantityTxt.Text
                Dim curStocks As Integer = CurrentStocksTxt.Text
                Dim expDate As Date = ExpirationDateDPr.Value.Date

                Dim batchCurrRowIndex As Integer = AllBatchDGV.CurrentRow.Index
                Dim batchId As Integer = AllBatchDGV.Item(0, batchCurrRowIndex).Value.ToString

                Dim medItem As String() = {brandName, genName, quantity, curStocks, expDate, batchId}

                If MedPerSupplierBatchItems.ContainsKey(medId) Then
                    MedPerSupplierBatchItems.Remove(medId)
                    MedPerSupplierBatchItems.Add(medId, medItem)
                Else
                    MedPerSupplierBatchItems.Add(medId, medItem)
                End If

                Me.LoadAllBatchItems()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MedsDBV cell double click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayAllBatchItems(ByVal id As Integer, ByVal brandName As String, ByVal genName As String, ByVal quantity As Integer, ByVal curStocks As Integer, ByVal expiDate As Date)
        BatchSupplierMedsDGV.ForeColor = Color.Black

        Try
            BatchSupplierMedsDGV.Rows.Add(id, brandName, genName, quantity, curStocks, expiDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying classification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadAllBatchItems()
        Try
            Dim itemsTemp As String()
            For Each item In MedPerSupplierBatchItems
                itemsTemp = MedPerSupplierBatchItems.Item(item.Key)

                DisplayAllBatchItems(item.Key, itemsTemp(0), itemsTemp(1), itemsTemp(2), itemsTemp(3), itemsTemp(4))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display All batch items", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SeachBatchTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles SeachBatchTxt.TextChanged
        Try
            Me.AllBatchDGV.Rows.Clear()
            Me.inputStocksCon.GetBatch(AddressOf Me.DisplayAllBatch, SeachBatchTxt.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Batch Text", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveBatchItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBatchItemBtn.Click
        Try
            Dim curIndex As Integer = BatchSupplierMedsDGV.CurrentRow.Index
            Dim medId As Integer = BatchSupplierMedsDGV.Item(0, curIndex).Value.ToString

            MedPerSupplierBatchItems.Remove(medId)
            BatchSupplierMedsDGV.Rows.Clear()
            Me.LoadAllBatchItems()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertBatchItemsBtn_Click(sender As System.Object, e As System.EventArgs) Handles InsertBatchItemsBtn.Click
        Try
            Dim itemsTemp As String()
            For Each item In MedPerSupplierBatchItems
                itemsTemp = MedPerSupplierBatchItems.Item(item.Key)

                Me.inputStocksCon.InsertBatchItems(item.Key, itemsTemp(2), itemsTemp(3), itemsTemp(4), itemsTemp(5))

            Next

            Me.BatchSupplierMedsDGV.Rows.Clear()

            MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Batch Items button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
