Imports System.Threading

Public Class AdmissionBillingCashierTransFrm

    Private admissionBillingCashierTransControler As New AdmissionBillingCashierTransController
    Private displayAllPatientsThread As Thread
    Private displayAllPatientsByDateThread As Thread
    Private displayAllPatientsByIDThread As Thread

    Private Sub AdmissionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AllPatientsDGV.Rows.Clear()
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub DisplayAllPatients(ByVal Alltotal As Decimal, ByVal patientAdmitID As Integer, ByVal admId As Integer, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal roomNumber As String, ByVal adDate As String, ByVal disDate As String, ByVal patientStatus As String, ByVal roomTotal As Decimal, ByVal totalMedPrice As Decimal, ByVal proFeeTatal As Decimal, ByVal labTotal As Decimal, ByVal suppliesTotal As Decimal)
        Try
            Me.AllPatientsDGV.ForeColor = Color.Black
            Dim ItemTotal As Decimal
            
            ItemTotal = (totalMedPrice + proFeeTatal) + (labTotal + suppliesTotal) + roomTotal


            Me.AllPatientsDGV.Rows.Add(patientAdmitID, admId, firstName, middleName, lastName, roomNumber, adDate, disDate, roomTotal, totalMedPrice, proFeeTatal, labTotal, suppliesTotal, ItemTotal, patientStatus)

            Me.TotalPriceTxt.Text = Alltotal
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display All Patients", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoadBtn.Click
        Try
            Me.displayAllPatientsThread = New Thread(AddressOf Me.LoadAllPatients)
            Me.displayAllPatientsThread.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllPatients()
        Try
            Me.AllPatientsDGV.Rows.Clear()
            Me.admissionBillingCashierTransControler.GetAllPatients(AddressOf Me.DisplayAllPatients)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load All Patients", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllPatientByDate()
        'GetAllPatientsByDate
        Try
            Dim selectedDate As String = DateAdmit.Value.Date
            Me.AllPatientsDGV.Rows.Clear()
            Me.admissionBillingCashierTransControler.GetAllPatientsByDate(AddressOf Me.DisplayAllPatients, selectedDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load All Patients", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchPatientByDateBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchPatientByDateBtn.Click
        Try
            Me.displayAllPatientsByDateThread = New Thread(AddressOf Me.LoadAllPatientByDate)
            Me.displayAllPatientsByDateThread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Patient by date button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SearchByPatientIdBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchByPatientIdBtn.Click
        Try
            Me.displayAllPatientsByIDThread = New Thread(AddressOf Me.LoadAllPatientsByID)
            Me.displayAllPatientsByIDThread.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadAllPatientsByID()
        Try

            If Me.PatientIDTxt.Text <> "" Then

                Dim p_ID As Integer = Integer.Parse(Me.PatientIDTxt.Text)

                Me.AllPatientsDGV.Rows.Clear()
                Me.admissionBillingCashierTransControler.GetAllPatientsByID(AddressOf Me.DisplayAllPatients, p_ID)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load All Patients", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class