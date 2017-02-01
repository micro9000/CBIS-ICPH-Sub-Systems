Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel

Public Class CashierPharmacyFrm

    Private cashierPharController As New CashierPharmacyController

    Private DailyReportThread As Thread
    Private WMYReportThread As Thread
    Private GenerateExcelThread As Thread

    Private Sub ReportsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CashierPharReportDGV.Rows.Clear()

        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub DisplayReports(ByVal transNumber As Integer, ByVal amount As Decimal, ByVal transDate As String, ByVal status As String, ByVal total As Decimal)
        Try
            Me.CashierPharReportDGV.ForeColor = Color.Black
            Dim medItems As New DataTable("stockOutTransactions")

            Me.CashierPharReportDGV.Rows.Add(transNumber, amount, transDate, status)

            Me.TotalSalesPriceTxt.Text = total
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadDailyReportsBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadDailyReportsBtn.Click
        Try
            Me.DailyReportThread = New Thread(AddressOf Me.DailyReports)
            Me.DailyReportThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Daily Report Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub DailyReports()
        Dim selectedDate As String = DailySalesDatePicker.Value.Date

        Me.CashierPharReportDGV.Rows.Clear()

        Me.Cursor = Cursors.WaitCursor
        Me.cashierPharController.GetDailyReports_CPH(AddressOf Me.DisplayReports, selectedDate)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WeeklyReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles WeeklyReportBtn.Click
        Me.WMYReportThread = New Thread(AddressOf Me.GenerateWeeMonYearReports)
        Me.WMYReportThread.Start()
    End Sub

    Private Sub GenerateWeeMonYearReports()
        Try
            Dim startDate As String = weeklyStartDateTime.Value.Date
            Dim endDate As String = weeklyEndDateTime.Value.Date

            Me.CashierPharReportDGV.Rows.Clear()
            Me.Cursor = Cursors.WaitCursor
            Me.cashierPharController.GetWeeklyReports_CPH(AddressOf Me.DisplayReports, startDate, endDate)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Weekly report button (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GenerateExcelFileReports() As Boolean
        Try

            If CashierPharReportDGV.RowCount > 0 Then
                If Me.reportFileNameTxt.Text <> "" Then
                    Dim envUsername As String = Environment.UserName
                    Dim filename As String = Me.reportFileNameTxt.Text
                    Dim path As String = "C:\Users\" & envUsername & "\Documents\" & filename & ".xlsx"
                    MessageBox.Show("You can find the file in - " & path, "File path", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Cursor = Cursors.WaitCursor


                    Dim APP As New Excel.Application
                    Dim worksheet As Excel.Worksheet
                    Dim workbook As Excel.Workbook
                    Dim misValue As Object = System.Reflection.Missing.Value
                    Dim i As Integer
                    Dim j As Integer

                    APP = New Excel.ApplicationClass
                    workbook = APP.Workbooks.Add(misValue)
                    worksheet = workbook.Sheets("sheet1")


                    For i = 0 To CashierPharReportDGV.RowCount - 1
                        For j = 0 To CashierPharReportDGV.ColumnCount - 1
                            For k As Integer = 1 To CashierPharReportDGV.Columns.Count
                                worksheet.Cells(1, k) = CashierPharReportDGV.Columns(k - 1).HeaderText
                                worksheet.Cells(i + 2, j + 1) = CashierPharReportDGV(j, i).Value.ToString()
                            Next
                        Next
                    Next

                    worksheet.SaveAs(path) '"C:\Users\Raniel\Desktop\test.xlsx"
                    workbook.Close()
                    APP.Quit()

                    Me.releaseObject(APP)
                    Me.releaseObject(workbook)
                    Me.releaseObject(worksheet)

                    Me.Cursor = Cursors.Default

                    MessageBox.Show("Done generating report", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                    'If Me.GenerateExcelFileReports(path) Then
                    '    MessageBox.Show("Done generating report", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If
                Else
                    MessageBox.Show("Please enter the file name", "Missing File name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Generate excel file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub PrintBtn_Click(sender As System.Object, e As System.EventArgs) Handles PrintBtn.Click
        Try
            Me.GenerateExcelThread = New Thread(AddressOf Me.GenerateExcelFileReports)
            Me.GenerateExcelThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Generate Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class