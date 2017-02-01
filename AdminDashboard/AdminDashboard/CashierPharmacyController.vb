Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CashierPharmacyController : Inherits SqlControl

    Delegate Sub DisplayReports(ByVal transNumber As Integer, ByVal amount As Decimal, ByVal transDate As String, ByVal status As String, ByVal total As Decimal)

    Public Sub GetDailyReports_CPH(ByRef displayReports As DisplayReports, ByVal selectedDate As String)

        Try

            Dim dailyReportQuery As String = "SELECT  * FROM PharmacyCashierTransactions WHERE datediff(dd, transDate, '" & selectedDate & "') = 0 "

            Dim sqlCommand As New SqlCommand(dailyReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Dim status As String
            Dim total As Decimal
            Try
                While (reader.Read())
                    If (reader("transStatus") = 1) Then
                        status = "Paid"
                        total += reader("amount")
                    ElseIf (reader("transStatus") = 2) Then
                        status = "Claimed"
                        total += reader("amount")
                    ElseIf (reader("transStatus") = 0) Then
                        status = "Unpaid"
                    Else
                        status = "Unknown"
                    End If
                    displayReports(reader("transID"), reader("amount"), reader("transDate"), status, total)

                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Daily reports (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get Daily reports (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetWeeklyReports_CPH(ByRef displayReports As DisplayReports, ByVal startDate As String, ByVal endDate As String)

        Try

            Dim dailyReportQuery As String = "SELECT  * FROM PharmacyCashierTransactions WHERE transDate between '" & startDate & "' AND '" & endDate & "'"

            Dim sqlCommand As New SqlCommand(dailyReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Dim status As String
            Dim total As Decimal
            Try
                While (reader.Read())
                    If (reader("transStatus") = 1) Then
                        status = "Paid"
                        total += reader("amount")
                    ElseIf (reader("transStatus") = 2) Then
                        status = "Claimed"
                        total += reader("amount")
                    ElseIf (reader("transStatus") = 0) Then
                        status = "Unpaid"
                    Else
                        status = "Unknown"
                    End If
                    displayReports(reader("transID"), reader("amount"), reader("transDate"), status, total)

                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Daily reports (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get Daily reports (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
