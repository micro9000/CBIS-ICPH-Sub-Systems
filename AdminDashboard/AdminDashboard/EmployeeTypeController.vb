Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class EmployeeTypeController : Inherits SqlControl

    Delegate Sub DisplayEmployeeTypes(ByVal typeId As Integer, ByVal typeName As String, ByVal numOfEmployees As Integer)

    Private empTypeId As Integer
    Private empTypeDictionary As New Dictionary(Of Integer, Array)

    Public Sub GetAllEmployeeTypes(ByRef displayEmployeeTypes As DisplayEmployeeTypes)

        Try

            Dim getAllEmpTypeQuery As String = "SELECT * FROM Employee_Types"
            Dim sqlCommand As New SqlCommand(getAllEmpTypeQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    Dim empType As String() = {reader("empType"), "0"}
                    Me.empTypeDictionary.Add(reader("id"), empType)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - All Employee types (>2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            If empTypeDictionary.Count > 0 Then
                ' Get number of employees in one departments
                Dim getNumOfEmpInDept As String = "SELECT empTypeId, COUNT(id) AS count FROM Employees WHERE empTypeId IN (SELECT empTypeId FROM Employees GROUP BY empTypeId) GROUP BY empTypeId"
                Dim sqlCommandTwo As New SqlCommand(getNumOfEmpInDept, Me.Connection)

                If Me.Connection.State = False Then
                    Me.Connection.Open()
                End If
                Dim readerTwo As SqlDataReader = sqlCommandTwo.ExecuteReader()

                Try
                    While (readerTwo.Read())

                        Dim temp As String() = Me.empTypeDictionary.Item(readerTwo("empTypeId"))
                        temp(1) = readerTwo("count").ToString
                        Me.empTypeDictionary.Remove(readerTwo("empTypeId"))
                        Me.empTypeDictionary.Add(readerTwo("empTypeId"), temp)

                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error: 0x101 - Get Number of employees in every employee type (>2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Clossing connections
                    readerTwo.Close()
                    sqlCommandTwo.Dispose()
                    Me.Connection.Close()
                End Try


                For Each empType In Me.empTypeDictionary
                    Dim temp As String() = Me.empTypeDictionary.Item(empType.Key)
                    displayEmployeeTypes(empType.Key, temp(0), temp(1))
                Next

                Me.empTypeDictionary.Clear()
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All Employee types (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function AddNewType(ByVal empTypeName As String) As Boolean
        Try
            Dim insertNewTypeQuery As String = "INSERT INTO Employee_Types(empType) VALUES('" & empTypeName & "')"

            If Me.ExecuteCommand(insertNewTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Add new type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function DeleteType(ByVal empTypeid As Integer) As Boolean
        Try
            Dim deleteTypeQuery As String = "DELETE FROM Employee_Types WHERE id=" & empTypeid

            If Me.ExecuteCommand(deleteTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Add new type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function UpdateType(ByVal empTypeId As Integer, ByVal newTypeName As String) As Boolean

        Try
            Dim updateTypeQuery As String = "UPDATE Employee_Types SET empType='" & newTypeName & "' WHERE id=" & empTypeId

            If Me.ExecuteCommand(updateTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Add new type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

End Class
