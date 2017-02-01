Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class AdmissionBillingCashierTransController : Inherits SqlControl

    Delegate Sub DisplayAllPatients(ByVal total As Decimal, ByVal patientAdmitID As Integer, ByVal admId As Integer, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal roomNumber As String, ByVal adDate As String, ByVal disDate As String, ByVal patientStatus As String, ByVal roomFee As Decimal, ByVal totalMedPrice As Decimal, ByVal proFeeTatal As Decimal, ByVal labTotal As Decimal, ByVal suppliesTotal As Decimal)


    Public Sub GetAllPatients(ByRef displayAllPatients As DisplayAllPatients)
        Try
            Dim getAllPatientsQuery As String = "SELECT patient_admission.pt_admit_Id ,patient.pt_ID, patient.pt_Fname, patient.pt_Mname, patient.pt_LName, Rooms.rm_No," & _
                                                "patient_admission.pt_adm_startDate ,patient_admission.pt_adm_EndDate, patient_admission.pt_status " & _
                                                "FROM patient_admission, patient, Rooms " & _
                                                "WHERE patient_admission.pt_adm_EndDate IS NOT NULL AND patient_admission.pt_ID = patient.pt_ID And patient_admission.rm_ID = Rooms.rm_ID AND patient_admission.pt_status = 1"

            Dim sqlCommand As New SqlCommand(getAllPatientsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()


            Dim PatientsCollection As New Dictionary(Of Integer, Array)
            Dim PatientInfos As String()

            Dim tempPTStatus As String
            Try
                While (reader.Read())
                    'displayAllPatients(reader("pt_admit_Id"), reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_status"))

                    If reader("pt_status") = 1 Then
                        tempPTStatus = "Paid"
                        PatientInfos = {reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_adm_EndDate"), tempPTStatus, "", "", "", ""}
                        PatientsCollection.Add(reader("pt_admit_Id"), PatientInfos)
                    End If
                End While
                
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            Dim temp As String()
            If PatientsCollection.Count > 0 Then
                For Each patient In PatientsCollection
                    temp = PatientsCollection.Item(patient.Key)
                    temp(8) = Me.GetPatientMedicinesTotalPurchase(patient.Key)
                    temp(9) = Me.GetPatientProFeeTotal(patient.Key)
                    temp(10) = Me.GetPatientLaboratoryTotal(patient.Key)
                    temp(11) = Me.GetPatientSuppliesTotal(patient.Key)
                Next
            End If
            'Me.GetPatientRoomID(temp(4))
            Dim tempTwo As String()
            Dim AllTotal As Decimal
            Dim roomFee As Decimal

            Dim roomTotal As Decimal
            Dim AdmitDate As DateTime
            Dim DischargeDate As DateTime

            If PatientsCollection.Count > 0 Then
                For Each patientTwo In PatientsCollection
                    tempTwo = PatientsCollection.Item(patientTwo.Key)
                    roomFee = Me.GetPatientRoomPrice(tempTwo(4))

                    AdmitDate = Convert.ToDateTime(tempTwo(5))
                    DischargeDate = Convert.ToDateTime(tempTwo(6))

                    Dim dayStamp As TimeSpan = DischargeDate.Subtract(AdmitDate)
                    Dim dayTotal As Integer = Convert.ToInt32(dayStamp.Days)


                    roomTotal = roomFee * dayTotal

                    AllTotal += (Decimal.Parse(tempTwo(8)) + Decimal.Parse(tempTwo(9))) + (Decimal.Parse(tempTwo(10)) + Decimal.Parse(tempTwo(11))) + roomTotal
                    displayAllPatients(AllTotal, patientTwo.Key, tempTwo(0), tempTwo(1), tempTwo(2), tempTwo(3), tempTwo(4), tempTwo(5), tempTwo(6), tempTwo(7), roomTotal, tempTwo(8), tempTwo(9), tempTwo(10), tempTwo(11))
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetPatientMedicinesTotalPurchase(ByVal patientAdmissionId As Integer) As Decimal
        Try
            Dim getPatientMedicinesTotalPurchaseQuery As String = "SELECT * FROM patient_medicine WHERE pt_adm_ID=" & patientAdmissionId
            Dim sqlCommand As New SqlCommand(getPatientMedicinesTotalPurchaseQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim total As Decimal
            Try
                While (reader.Read())
                    total += reader("totalprice")
                End While

                Return total
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patient's medicines (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients medicines (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0.0
    End Function

    Private Function GetPatientProFeeTotal(ByVal patientAdmissionId As Integer) As Decimal
        Try
            Dim getPatientProFeeTotalQuery As String = "SELECT doctor_fee FROM patient_doctor WHERE pt_adm_ID=" & patientAdmissionId
            Dim sqlCommand As New SqlCommand(getPatientProFeeTotalQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim total As Decimal
            Try
                While (reader.Read())
                    total += reader("doctor_fee")
                End While

                Return total
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patient's laboratory total (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients's laboratory total (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0.0
    End Function

    Private Function GetPatientLaboratoryTotal(ByVal patientAdmissionId As Integer) As Decimal
        Try
            Dim getPatientLaboratoryTotalQuery As String = "SELECT services.srvc_Price FROM services, patient_laboratory_services WHERE patient_laboratory_services.pt_adm_ID=" & patientAdmissionId
            Dim sqlCommand As New SqlCommand(getPatientLaboratoryTotalQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim total As Decimal
            Try
                While (reader.Read())
                    total += reader("srvc_Price")
                End While

                Return total
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patient's laboratory total (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients's laboratory total (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0.0
    End Function

    Private Function GetPatientSuppliesTotal(ByVal patientAdmissionId As Integer) As Decimal
        Try
            Dim getPatientSuppliesTotalQuery As String = "SELECT sup_total FROM Supplies WHERE pt_adm_ID = " & patientAdmissionId
            Dim sqlCommand As New SqlCommand(getPatientSuppliesTotalQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim total As Decimal
            Try
                While (reader.Read())
                    total += reader("sup_total")
                End While

                Return total
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patient's supplies total (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients's supplies total (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0.0
    End Function

    Private Function GetPatientRoomPrice(ByVal roomNum As String) As Decimal
        Try
            Dim getPatientRoomIDQuery As String = "SELECT rm_price FROM Room_types WHERE rm_type_ID=(SELECT rm_type_ID FROM Rooms WHERE rm_ID=(SELECT rm_ID FROM Rooms WHERE rm_No='" & roomNum & "'))"
            Dim sqlCommand As New SqlCommand(getPatientRoomIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try

                If (reader.Read()) Then
                    Return reader("rm_price")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Room id (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get Room id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return 0.0
    End Function


    Public Sub GetAllPatientsByID(ByRef displayAllPatients As DisplayAllPatients, ByVal p_Id As Integer)
        Try
            Dim getAllPatientsQuery As String = "SELECT patient_admission.pt_admit_Id , patient.pt_ID, patient.pt_Fname, patient.pt_Mname, patient.pt_LName, Rooms.rm_No," & _
                                                "patient_admission.pt_adm_startDate ,patient_admission.pt_adm_EndDate, patient_admission.pt_status " & _
                                                "FROM patient_admission, patient, Rooms " & _
                                                "WHERE patient_admission.pt_ID = patient.pt_ID AND patient_admission.pt_status=1 And patient_admission.rm_ID = Rooms.rm_ID AND patient_admission.pt_ID=" & p_Id

            Dim sqlCommand As New SqlCommand(getAllPatientsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim PatientsCollection As New Dictionary(Of Integer, Array)
            Dim PatientInfos As String()

            Dim tempPTStatus As String
            Try
                While (reader.Read())
                    'displayAllPatients(reader("pt_admit_Id"), reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_status"))
                    If reader("pt_status") = 1 Then
                        tempPTStatus = "Paid"
                        PatientInfos = {reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_adm_EndDate"), tempPTStatus, "", "", "", ""}
                        PatientsCollection.Add(reader("pt_admit_Id"), PatientInfos)
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            Dim temp As String()
            If PatientsCollection.Count > 0 Then
                For Each patient In PatientsCollection
                    temp = PatientsCollection.Item(patient.Key)
                    temp(8) = Me.GetPatientMedicinesTotalPurchase(patient.Key)
                    temp(9) = Me.GetPatientProFeeTotal(patient.Key)
                    temp(10) = Me.GetPatientLaboratoryTotal(patient.Key)
                    temp(11) = Me.GetPatientSuppliesTotal(patient.Key)
                Next
            End If

            Dim tempTwo As String()
            Dim AllTotal As Decimal
            Dim roomFee As Decimal

            Dim roomTotal As Decimal
            Dim AdmitDate As DateTime
            Dim DischargeDate As DateTime

            If PatientsCollection.Count > 0 Then
                For Each patientTwo In PatientsCollection
                    tempTwo = PatientsCollection.Item(patientTwo.Key)
                    roomFee = Me.GetPatientRoomPrice(tempTwo(4))

                    AdmitDate = Convert.ToDateTime(tempTwo(5))
                    DischargeDate = Convert.ToDateTime(tempTwo(6))

                    Dim dayStamp As TimeSpan = DischargeDate.Subtract(AdmitDate)
                    Dim dayTotal As Integer = Convert.ToInt32(dayStamp.Days)

                    roomTotal = roomFee * dayTotal

                    AllTotal += (Decimal.Parse(tempTwo(8)) + Decimal.Parse(tempTwo(9))) + (Decimal.Parse(tempTwo(10)) + Decimal.Parse(tempTwo(11))) + roomTotal
                    displayAllPatients(AllTotal, patientTwo.Key, tempTwo(0), tempTwo(1), tempTwo(2), tempTwo(3), tempTwo(4), tempTwo(5), tempTwo(6), tempTwo(7), roomTotal, tempTwo(8), tempTwo(9), tempTwo(10), tempTwo(11))
                Next
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetAllPatientsByDate(ByRef displayAllPatients As DisplayAllPatients, ByVal selectedDate As String)
        Try
            Dim getAllPatientsQuery As String = "SELECT patient_admission.pt_admit_Id, patient.pt_ID, patient.pt_Fname, patient.pt_Mname, patient.pt_LName, Rooms.rm_No," & _
                                                "patient_admission.pt_adm_startDate,patient_admission.pt_adm_EndDate, patient_admission.pt_status " & _
                                                "FROM patient_admission, patient, Rooms " & _
                                                "WHERE patient_admission.pt_ID = patient.pt_ID AND patient_admission.pt_status = 1 And patient_admission.rm_ID = Rooms.rm_ID " & _
                                                "AND datediff(dd,patient_admission.pt_adm_startDate, '" & selectedDate & "' ) = 0"

            Dim sqlCommand As New SqlCommand(getAllPatientsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim PatientsCollection As New Dictionary(Of Integer, Array)
            Dim PatientInfos As String()

            Dim tempPTStatus As String

            Try
                While (reader.Read())
                    'displayAllPatients(reader("pt_admit_Id"), reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_status"))
                    If reader("pt_status") = 1 Then
                        tempPTStatus = "Paid"
                        PatientInfos = {reader("pt_ID"), reader("pt_Fname"), reader("pt_Mname"), reader("pt_LName"), reader("rm_No"), reader("pt_adm_startDate"), reader("pt_adm_EndDate"), tempPTStatus, "", "", "", ""}
                        PatientsCollection.Add(reader("pt_admit_Id"), PatientInfos)
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            Dim temp As String()
            If PatientsCollection.Count > 0 Then
                For Each patient In PatientsCollection
                    temp = PatientsCollection.Item(patient.Key)
                    temp(8) = Me.GetPatientMedicinesTotalPurchase(patient.Key)
                    temp(9) = Me.GetPatientProFeeTotal(patient.Key)
                    temp(10) = Me.GetPatientLaboratoryTotal(patient.Key)
                    temp(11) = Me.GetPatientSuppliesTotal(patient.Key)
                Next
            End If
            

            Dim tempTwo As String()
            Dim AllTotal As Decimal
            Dim roomFee As Decimal

            Dim roomTotal As Decimal
            Dim AdmitDate As DateTime
            Dim DischargeDate As DateTime

            If PatientsCollection.Count > 0 Then
                For Each patientTwo In PatientsCollection
                    tempTwo = PatientsCollection.Item(patientTwo.Key)
                    roomFee = Me.GetPatientRoomPrice(tempTwo(4))

                    AdmitDate = Convert.ToDateTime(tempTwo(5))
                    DischargeDate = Convert.ToDateTime(tempTwo(6))

                    Dim dayStamp As TimeSpan = DischargeDate.Subtract(AdmitDate)
                    Dim dayTotal As Integer = Convert.ToInt32(dayStamp.Days)

                    roomTotal = roomFee * dayTotal

                    AllTotal += (Decimal.Parse(tempTwo(8)) + Decimal.Parse(tempTwo(9))) + (Decimal.Parse(tempTwo(10)) + Decimal.Parse(tempTwo(11))) + roomTotal
                    displayAllPatients(AllTotal, patientTwo.Key, tempTwo(0), tempTwo(1), tempTwo(2), tempTwo(3), tempTwo(4), tempTwo(5), tempTwo(6), tempTwo(7), roomTotal, tempTwo(8), tempTwo(9), tempTwo(10), tempTwo(11))
                Next
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Patients (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
