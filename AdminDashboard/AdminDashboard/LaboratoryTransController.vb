Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class LaboratoryTransController : Inherits SqlControl

    Delegate Sub DisplayLabTrans(ByVal transID As Integer, ByVal pName As String, ByVal gender As String, ByVal transDate As String, ByVal serviceName As String, ByVal servicePrice As Decimal, ByVal status As String, ByVal total As Decimal)

    Public Sub DisplayAllLabTrans(ByRef displayLabTrans As DisplayLabTrans, ByVal selectedDate As String)

        Try
            Dim displayAllLabTrans As String
            If selectedDate = "" Then
                displayAllLabTrans = "SELECT laboratory_transaction_out_patient.trns_ID, laboratory_transaction_out_patient.Name," & _
                                    "laboratory_transaction_out_patient.Gender, laboratory_transaction_out_patient.date," & _
                                    "services.srvc_Name, services.srvc_Price, laboratory_transaction_out_patient.status " & _
                                    "FROM services, laboratory_transaction_out_patient " & _
                                    "WHERE laboratory_transaction_out_patient.srvcID = services.srvc_ID"
            Else
                displayAllLabTrans = "SELECT laboratory_transaction_out_patient.trns_ID, laboratory_transaction_out_patient.Name," & _
                                    "laboratory_transaction_out_patient.Gender, laboratory_transaction_out_patient.date," & _
                                    "services.srvc_Name, services.srvc_Price, laboratory_transaction_out_patient.status " & _
                                    "FROM services, laboratory_transaction_out_patient " & _
                                    "WHERE laboratory_transaction_out_patient.srvcID = services.srvc_ID " & _
                                    "AND datediff(dd, laboratory_transaction_out_patient.date, '" & selectedDate & "') = 0"
            End If

            Dim sqlCommand As New SqlCommand(displayAllLabTrans, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Dim status As String
            Dim total As Decimal
            Try
                While (reader.Read())
                    If (reader("status") = 0) Then
                        status = "Unpaid"
                    ElseIf (reader("status") = 1) Then
                        total += Decimal.Parse(reader("srvc_Price"))
                        status = "Paid"
                    ElseIf (reader("status") = 2) Then
                        total += Decimal.Parse(reader("srvc_Price"))
                        status = "Claimed"
                    Else
                        status = "Unkonwn"
                    End If

                    displayLabTrans(reader("trns_ID"), reader("Name"), reader("Gender"), reader("date"), reader("srvc_Name"), reader("srvc_Price"), status, total)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All Laboratory Transaction (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Laboratory Transaction (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
