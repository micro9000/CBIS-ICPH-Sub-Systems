Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class PharmacyTransSalesController : Inherits SqlControl

    Delegate Sub DisplayStockOutTransactionData(ByVal totalSalesPrice As Decimal, ByVal id As Integer, ByVal transDate As String, ByVal patientType As String, ByVal price As Decimal, ByVal quantity As Integer, ByVal itemName As String, ByVal username As String)
    Delegate Sub DisplayStockOutTransactionDataForSummary(ByVal totalSalesPrice As Decimal, ByVal id As Integer, ByVal transDate As String, ByVal patientType As String, ByVal price As Decimal, ByVal quantity As Integer, ByVal TotalPrice As Decimal, ByVal itemName As String, ByVal username As String)



    Public Sub GetDailyReports(ByRef displayStockOutTransactionData As DisplayStockOutTransactionData, ByVal selectedDate As String, ByVal inOrOutP As String)

        Try

            Dim dailyReportQuery As String = ""

            If inOrOutP = "" Then
                dailyReportQuery = "SELECT PharmacyStockOutTransactions.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND datediff(dd, transDate, '" & selectedDate & "') = 0 ORDER BY PharmacyStockOutTransactions.id DESC"
            End If

            If inOrOutP = "IN" Then
                dailyReportQuery = "SELECT PharmacyStockOutTransactions.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID " & _
                                                            "AND PharmacyStockOutTransactions.patientType='" & inOrOutP & "' AND datediff(dd, transDate, '" & selectedDate & "') = 0 ORDER BY PharmacyStockOutTransactions.id DESC"

            End If


            If inOrOutP = "OUT" Then
                dailyReportQuery = "SELECT PharmacyStockOutTransactions.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID " & _
                                                            "AND PharmacyStockOutTransactions.patientType='" & inOrOutP & "' AND datediff(dd, transDate, '" & selectedDate & "') = 0 ORDER BY PharmacyStockOutTransactions.id DESC"

            End If
            
            Dim sqlCommand As New SqlCommand(dailyReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim totalSalesPrice As Decimal

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try
                While (reader.Read())
                    totalSalesPrice += Decimal.Parse(reader("stockOutQuantity") * reader("stockOutPrice"))
                    displayStockOutTransactionData(totalSalesPrice, reader("id"), reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), reader("medName"), reader("username"))
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

    Public Sub GetWeeklyReports(ByRef displayStockOutTransactionData As DisplayStockOutTransactionData, ByVal startDate As String, ByVal endDate As String, ByVal inOrOutP As String)

        Try
            ' PharmacyStockOutTransactions.id,
            Dim WeeklyReportQuery As String = ""

            If inOrOutP = "" Then
                WeeklyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "' ORDER BY PharmacyStockOutTransactions.id DESC"

            End If

            If inOrOutP = "IN" Then
                WeeklyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOutP & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "' ORDER BY PharmacyStockOutTransactions.id DESC"

            End If

            If inOrOutP = "OUT" Then
                WeeklyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOutP & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "' ORDER BY PharmacyStockOutTransactions.id DESC"

            End If


            Dim sqlCommand As New SqlCommand(WeeklyReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim totalSalesPrice As Decimal

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    totalSalesPrice += Decimal.Parse(reader("stockOutQuantity") * reader("stockOutPrice"))
                    displayStockOutTransactionData(totalSalesPrice, reader("id"), reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), reader("medName"), reader("username"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Weekly reports (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get Weekly reports (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Public Sub GetWeeklySummaryReports(ByRef displayStockOutTransactionDataForSummary As DisplayStockOutTransactionDataForSummary, ByVal startDate As String, ByVal endDate As String, ByVal inOrOut As String)

        Try

            Dim WeeklySummaryReportQuery As String = ""

            If inOrOut = "" Then
                WeeklySummaryReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "'"
            End If

            If inOrOut = "IN" Then
                WeeklySummaryReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOut & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "'"
            End If

            If inOrOut = "OUT" Then
                WeeklySummaryReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                            "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                            "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOut & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND transDate between '" & startDate & "' AND '" & endDate & "'"
            End If

            Dim sqlCommand As New SqlCommand(WeeklySummaryReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim totalPrice As Decimal
            Dim sumRepItems As New Dictionary(Of Integer, Array)
            Dim items As String()
            Dim tempItems As String()
            Try

                While (reader.Read())
                    totalPrice = Decimal.Parse(Integer.Parse(reader("stockOutQuantity")) * Decimal.Parse(reader("stockOutPrice")))
                    items = {reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), totalPrice, reader("medName"), reader("username")}

                    'sumRepItems.Add(reader("id"), items)

                    If (sumRepItems.ContainsKey(reader("id"))) Then
                        tempItems = sumRepItems.Item(reader("id"))
                        ' date of the latest item sale
                        tempItems(0) = reader("transDate")
                        ' patientType
                        tempItems(1) = reader("patientType")
                        ' price of the latest item sale
                        tempItems(2) = reader("stockOutPrice")
                        ' Add the quantity
                        tempItems(3) = (Integer.Parse(tempItems(3)) + Integer.Parse(reader("stockOutQuantity")))
                        ' totalPrice
                        tempItems(4) = Decimal.Parse(tempItems(4)) + totalPrice
                        ' user of the last item
                        tempItems(6) = reader("username")

                    Else
                        sumRepItems.Add(reader("id"), items)
                    End If

                    'totalSalesPrice += Decimal.Parse(reader("stockOutQuantity") * reader("stockOutPrice"))
                    'displayStockOutTransactionData(totalSalesPrice, reader("id"), reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), reader("medName"), reader("username"))
                End While

                Dim temp As String()
                Dim totalSalesPrice As Decimal
                If sumRepItems.Count > 0 Then
                    For Each item In sumRepItems
                        temp = sumRepItems.Item(item.Key)
                        totalSalesPrice += Decimal.Parse(temp(4))
                        displayStockOutTransactionDataForSummary(totalSalesPrice, item.Key, temp(0), temp(1), temp(2), temp(3), temp(4), temp(5), temp(6))
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Weekly reports (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get Weekly reports (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub GetDailySummaryReports(ByRef displayStockOutTransactionDataForSummary As DisplayStockOutTransactionDataForSummary, ByVal selectedDate As String, ByVal inOrOut As String)

        Try

            Dim dailyReportQuery As String = ""
            If inOrOut = "" Then
                dailyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                           "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                           "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND datediff(dd, transDate, '" & selectedDate & "') = 0"
            End If

            If inOrOut = "IN" Then
                dailyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                           "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                           "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOut & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND datediff(dd, transDate, '" & selectedDate & "') = 0"
            End If

            If inOrOut = "OUT" Then
                dailyReportQuery = "SELECT Medicines.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
                                                           "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
                                                           "FROM Users, PharmacyStockOutTransactions, Medicines WHERE PharmacyStockOutTransactions.patientType='" & inOrOut & "' AND Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID  AND datediff(dd, transDate, '" & selectedDate & "') = 0"
            End If
           
            Dim sqlCommand As New SqlCommand(dailyReportQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If


            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Dim totalPrice As Decimal
            Dim sumRepItems As New Dictionary(Of Integer, Array)
            Dim items As String()
            Dim tempItems As String()
            Try
                While (reader.Read())
                    totalPrice = Decimal.Parse(Integer.Parse(reader("stockOutQuantity")) * Decimal.Parse(reader("stockOutPrice")))
                    items = {reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), totalPrice, reader("medName"), reader("username")}

                    'sumRepItems.Add(reader("id"), items)

                    If (sumRepItems.ContainsKey(reader("id"))) Then
                        tempItems = sumRepItems.Item(reader("id"))
                        ' date of the latest item sale
                        tempItems(0) = reader("transDate")
                        ' patientType
                        tempItems(1) = reader("patientType")
                        ' price of the latest item sale
                        tempItems(2) = reader("stockOutPrice")
                        ' Add the quantity
                        tempItems(3) = (Integer.Parse(tempItems(3)) + Integer.Parse(reader("stockOutQuantity")))
                        ' totalPrice
                        tempItems(4) = Decimal.Parse(tempItems(4)) + totalPrice
                        ' user of the last item
                        tempItems(6) = reader("username")

                    Else
                        sumRepItems.Add(reader("id"), items)
                    End If

                    'totalSalesPrice += Decimal.Parse(reader("stockOutQuantity") * reader("stockOutPrice"))
                    'displayStockOutTransactionData(totalSalesPrice, reader("id"), reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), reader("medName"), reader("username"))
                End While

                Dim temp As String()
                Dim totalSalesPrice As Decimal

                If sumRepItems.Count > 0 Then
                    For Each item In sumRepItems
                        temp = sumRepItems.Item(item.Key)
                        totalSalesPrice += Decimal.Parse(temp(4))
                        displayStockOutTransactionDataForSummary(totalSalesPrice, item.Key, temp(0), temp(1), temp(2), temp(3), temp(4), temp(5), temp(6))
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get Weekly reports (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



'Public Sub GetAllStockOutTransaction(ByRef displayStockOutTransactionData As DisplayStockOutTransactionData)

'    Try

'        Dim getAllStockOutTransactionQuery As String = "SELECT PharmacyStockOutTransactions.id, PharmacyStockOutTransactions.transDate, CONCAT(Medicines.brandName, '/',Medicines.genericName) as medName,PharmacyStockOutTransactions.stockOutPrice ," & _
'                                                        "PharmacyStockOutTransactions.stockOutQuantity, PharmacyStockOutTransactions.patientType,Users.username " & _
'                                                        "FROM Users, PharmacyStockOutTransactions, Medicines WHERE Medicines.id=PharmacyStockOutTransactions.medicineID AND Users.id=PharmacyStockOutTransactions.userID"

'        Dim sqlCommand As New SqlCommand(getAllStockOutTransactionQuery, Me.Connection)

'        If Me.Connection.State = False Then
'            Me.Connection.Open()
'        End If

'        Dim totalSalesPrice As Decimal

'        Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

'        Try
'            While (reader.Read())
'                totalSalesPrice += Decimal.Parse(reader("stockOutQuantity") * reader("stockOutPrice"))
'                displayStockOutTransactionData(totalSalesPrice, reader("id"), reader("transDate"), reader("patientType"), reader("stockOutPrice"), reader("stockOutQuantity"), reader("medName"), reader("username"))
'            End While
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Product Categories (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ' Clossing connections
'            reader.Close()
'            sqlCommand.Dispose()
'            Me.Connection.Close()
'        End Try
'    Catch ex As Exception
'        MessageBox.Show(ex.Message, "Error: 0x101 - Get All Product Categories (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    End Try

'End Sub