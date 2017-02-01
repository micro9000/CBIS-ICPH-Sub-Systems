Imports System.Threading

Public Class LaboratoryTransactionsFrm

    Private labTransController As New LaboratoryTransController
    Private loadAllLabThread As Thread
    Private loadAllLabThreadByDate As Thread

    Private Sub LaboratoryTransactionsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub DisplayLabTrans(ByVal transID As Integer, ByVal pName As String, ByVal gender As String, ByVal transDate As String, ByVal serviceName As String, ByVal servicePrice As Decimal, ByVal status As String, ByVal total As Decimal)
        Try
            Me.LaboratoryTransDGV.ForeColor = Color.Black
            Me.LaboratoryTransDGV.Rows.Add(transID, pName, gender, transDate, serviceName, servicePrice, status)

            Me.TotalOutTxt.Text = total
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Laboratory transactions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllLabTrans()
        Me.LaboratoryTransDGV.Rows.Clear()
        Me.labTransController.DisplayAllLabTrans(AddressOf Me.DisplayLabTrans, "")
    End Sub

    Private Sub LoadAllLabTransByDate()
        Dim selectedDate As Date = Me.SelectedDateDTP.Value.Date
        Me.LaboratoryTransDGV.Rows.Clear()
        Me.labTransController.DisplayAllLabTrans(AddressOf Me.DisplayLabTrans, selectedDate)
    End Sub

    Private Sub LoadAllLabTransBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadAllLabTransBtn.Click
        Try
            Me.loadAllLabThread = New Thread(AddressOf Me.LoadAllLabTrans)
            Me.loadAllLabThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load All Laboratory transaction button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadByDateLabTransBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadByDateLabTransBtn.Click
        Try
            Me.loadAllLabThreadByDate = New Thread(AddressOf Me.LoadAllLabTransByDate)
            Me.loadAllLabThreadByDate.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Laboratory Transaction button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class