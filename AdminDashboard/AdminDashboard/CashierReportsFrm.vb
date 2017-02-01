Imports System.Threading

Public Class CashierReportsFrm

    Private LoadCashierRepThread As Thread
    Private cashierReportController As New CashierReportController

    Private Sub CashierReportsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub DisplayCashierRepTrans(ByVal totalAmount As Decimal, ByVal transNo As String, ByVal transDate As String, ByVal transDept As String, ByVal transAmount As Decimal, ByVal transCurrUser As String)
        Try
            Me.AllPatientsDGV.ForeColor = Color.Black

            Me.AllPatientsDGV.Rows.Add(transNo, transDate, transDept, transAmount, transCurrUser)

            Me.TotalTxt.Text = totalAmount
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Cashier Report transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCashierReports()
        Try
            Dim selectedDate As String = Me.LoadByDate.Value.Date

            Me.AllPatientsDGV.Rows.Clear()
            cashierReportController.GETAllCashierTrans(AddressOf Me.DisplayCashierRepTrans, selectedDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchCashierRepBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchCashierRepBtn.Click
        Try
            Me.LoadCashierRepThread = New Thread(AddressOf Me.LoadCashierReports)
            Me.LoadCashierRepThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search ")
        End Try
    End Sub
End Class