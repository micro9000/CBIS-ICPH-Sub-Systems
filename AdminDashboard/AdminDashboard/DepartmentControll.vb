Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DepartmentControll : Inherits SqlControl

    Delegate Sub DisplayDepartment(ByVal id As Integer, ByVal deptName As String, ByVal numOfEmp As Integer)

    Private departmentsDictionary As New Dictionary(Of Integer, Array)

    Public Sub GetAllDepartments(ByVal dispalyDepartments As DisplayDepartment)

        Try
            Dim getAllDeptQuery As String = "SELECT * FROM Departments"
            Dim sqlCommand As New SqlCommand(getAllDeptQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    Dim departments As String() = {reader("department"), "0"}
                    Me.departmentsDictionary.Add(reader("id"), departments)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get all departments (>2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

            If departmentsDictionary.Count > 0 Then
                ' Get number of employees in one departments
                Dim getNumOfEmpInDept As String = "SELECT departmentId, COUNT(id) AS count FROM Employees WHERE departmentId IN (SELECT departmentId FROM Employees GROUP BY departmentId) GROUP BY departmentId"
                Dim sqlCommandTwo As New SqlCommand(getNumOfEmpInDept, Me.Connection)

                If Me.Connection.State = False Then
                    Me.Connection.Open()
                End If
                Dim readerTwo As SqlDataReader = sqlCommandTwo.ExecuteReader()

                Try
                    While (readerTwo.Read())

                        Dim temp As String() = Me.departmentsDictionary.Item(readerTwo("departmentId"))
                        temp(1) = readerTwo("count").ToString
                        Me.departmentsDictionary.Remove(readerTwo("departmentId"))
                        Me.departmentsDictionary.Add(readerTwo("departmentId"), temp)

                    End While
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error: 0x101 - Get Number of employees in every department (>2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Clossing connections
                    readerTwo.Close()
                    sqlCommandTwo.Dispose()
                    Me.Connection.Close()
                End Try


                For Each department In Me.departmentsDictionary
                    Dim temp As String() = Me.departmentsDictionary.Item(department.Key)
                    dispalyDepartments(department.Key, temp(0), temp(1))
                Next

                Me.departmentsDictionary.Clear()
            End If

            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get all Departments (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function InsertNewDepartment(ByVal departmentName As String) As Boolean

        Try
            Dim insertNewDeptQuery As String = "INSERT INTO Departments(department) VALUES('" & departmentName & "')"

            If Me.ExecuteCommand(insertNewDeptQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new Departments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function UpdateDepartment(ByVal deptId As Integer, ByVal departmentName As String) As Boolean

        Try
            Dim insertNewDeptQuery As String = "UPDATE Departments SET department='" & departmentName & "' WHERE id=" & deptId

            If Me.ExecuteCommand(insertNewDeptQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update Departments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function DeleteDepartment(ByVal deptId As Integer) As Boolean
        Try
            Dim deleteDeptQuery As String = "DELETE FROM Departments WHERE id=" & deptId

            If Me.ExecuteCommand(deleteDeptQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Delete department", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

End Class
