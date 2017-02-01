Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CashierReportController : Inherits SqlControl

    Delegate Sub DisplayCashierRepTrans(ByVal totalAmount As Decimal, ByVal transNo As String, ByVal transDate As String, ByVal transDept As String, ByVal transAmount As Decimal, ByVal transCurrUser As String)

    Public Sub GETAllCashierTrans(ByRef displayCashierRepTrans As DisplayCashierRepTrans, ByVal selectedDate As String)
        Try
            Dim GETAllCashierTransQuery As String = "SELECT CashierAuditTrail.cash_transac_no, CashierAuditTrail.cash_transac_date, CashierAuditTrail.cash_dept," & _
                                                    "CashierAuditTrail.cash_total, Users.username FROM CashierAuditTrail, Users " & _
                                                    "WHERE CashierAuditTrail.cash_actor_id=Users.id AND DATEDIFF(dd,CashierAuditTrail.cash_transac_date, '" & selectedDate & "') = 0"


            '"SELECT PharmacyCashierTransactions.transStatus, CashierAuditTrail.cash_transac_no, CashierAuditTrail.cash_transac_date, CashierAuditTrail.cash_dept, CashierAuditTrail.cash_total, Users.username " & _
            '"FROM CashierAuditTrail, Users, PharmacyCashierTransactions " & _
            '"WHERE CashierAuditTrail.cash_actor_id = Users.id And (PharmacyCashierTransactions.transStatus = 1 OR PharmacyCashierTransactions.transStatus = 2) " & _
            '"AND DATEDIFF(dd, CashierAuditTrail.cash_transac_date, '" & selectedDate & "') = 0  AND CashierAuditTrail.cash_transac_no = PharmacyCashierTransactions.transID"

            Dim sqlCommand As New SqlCommand(GETAllCashierTransQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim totalAmount As Decimal
            Try
                While (reader.Read())
                    'If (reader("transStatus") = 1 Or reader("transStatus") = 2) Then
                    'End If
                    totalAmount += Decimal.Parse(reader("cash_total"))
                    displayCashierRepTrans(totalAmount, reader("cash_transac_no"), reader("cash_transac_date"), reader("cash_dept"), reader("cash_total"), reader("username"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get all departments (>2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get all Departments (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
