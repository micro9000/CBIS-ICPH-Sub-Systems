Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class EmployeesManagement : Inherits SqlControl

    Delegate Sub DisplayEmployeeDataGrid(ByVal empId As String, ByVal firstname As String, ByVal middlename As String, _
                                  ByVal lastname As String, ByVal gender As String, ByVal address As String, _
                                  ByVal brithdate As String, ByVal empType As String, ByVal emtDepartment As String)

    Public Function AddNewEmployee(ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal gender As String, _
                              ByVal address As String, ByVal bdate As String, ByVal empTypeId As Integer, ByVal depId As Integer) As Boolean

        Try
            Dim insertNewEmployeeQuery As String
            insertNewEmployeeQuery = "INSERT INTO Employees(firstName, middleName, lastName, gender, address, birthDate, empTypeId, departmentId) VALUES ('" & _
                                fname & "', '" & mname & "', '" & lname & "', '" & gender & "', '" & address & "', '" & bdate & "', " & empTypeId & ", " & depId & ")"

            If Me.ExecuteCommand(insertNewEmployeeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Adding new employee", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Sub GetAllDepartment(ByRef departmentCbox As Object)

        departmentCbox.Items.Clear()

        Try
            Dim selectAllDepartmentQuery As String = "SELECT * FROM Departments"
            Dim sqlCommand As New SqlCommand(selectAllDepartmentQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    departmentCbox.Items.Add(reader("department"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get all department (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get all department (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetAllEmployeeTypes(ByRef employeeTypeCbox As Object)
        Try
            employeeTypeCbox.Items.Clear()

            Dim selectAllEmployeeTypesQuery As String = "SELECT empType FROM Employee_Types"
            Dim sqlCommand As New SqlCommand(selectAllEmployeeTypesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    employeeTypeCbox.Items.Add(reader("empType"))
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get all employee types (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get all employee types (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetEmployeeTypeID(ByVal empType As String) As Integer
        Dim empTypeId As Integer

        Try
            Dim getEmpTypeIdQuery As String = "SELECT id FROM Employee_Types WHERE empType='" & empType & "'"
            Dim sqlCommand As New SqlCommand(getEmpTypeIdQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    empTypeId = reader("id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get employee type id (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get employee type id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return empTypeId
    End Function

    Public Function GetDepartmentID(ByVal deptName As String) As Integer
        Dim deptID As Integer

        Try
            Dim getDepatmentIDQuery As String = "SELECT id FROM Departments WHERE department='" & deptName & "'"
            Dim sqlCommand As New SqlCommand(getDepatmentIDQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    deptID = reader("id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get department id (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get department id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return deptID
    End Function

    Public Function GetEmployeeDepartment(ByVal deptId As Integer) As String
        Dim department As String = ""

        Try
            Dim getEmpDepartmentQuery As String = "SELECT department FROM Departments WHERE id = " & deptId
            Dim sqlCommand As New SqlCommand(getEmpDepartmentQuery, Me.Connection)

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Try
                If (reader.Read()) Then
                    department = reader("department")
                Else
                    MessageBox.Show("Can't see department in the database", "Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get employee department (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get employee department (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return department
    End Function

    Public Function GetEmployeeType(ByVal empTypeId As Integer) As String
        Dim type As String = ""
        Try
            ' Get the employee type
            Dim getEmpTypeQuery As String = "SELECT empType FROM Employee_Types WHERE id = " & empTypeId
            Dim sqlCommand As New SqlCommand(getEmpTypeQuery, Me.Connection)
            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Try
                If (reader.Read()) Then
                    type = reader("empType")
                Else
                    MessageBox.Show("Can't see employee type in the database", "Employee type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get employee type (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                SqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get employee type (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return type
    End Function

    Public Sub SearchEmployee(ByVal employeeId As String, ByRef DisplayEmployeeDGrid As DisplayEmployeeDataGrid)

        Try
            Dim searchEmployeeQuery As String = "SELECT Employees.id, Employees.firstName, Employees.middleName, Employees.lastName, Employees.gender, Employees.address, Employees.birthDate, Employee_Types.empType, Departments.department FROM Employees, Employee_Types, Departments where Employees.empTypeId = Employee_Types.id and Employees.departmentId = Departments.id and Employees.id=" & employeeId

            Dim sqlCommand As New SqlCommand(searchEmployeeQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try
                While (reader.Read())

                    DisplayEmployeeDGrid(reader("id"), reader("firstName"), reader("middlename"), reader("lastname"), reader("gender"), reader("address"), reader("birthDate"), reader("empType"), reader("department"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Searching employee (1)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Searching employee (1)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    ' For displaying all employees in datagrid view
    Public Sub GetAllEmployees(ByRef DisplayEmployeeDGrid As DisplayEmployeeDataGrid)

        Try
            ' SELECT Employees.id, Employees.firstName, Employee_Types.empType, Departments.department
            'FROM Employees, Employee_Types, Departments where Employees.empTypeId = Employee_Types.id AND Employees.departmentId = Departments.id

            Dim selectEmployees As String = "Employees.id, Employees.firstName, Employees.middleName, Employees.lastname, Employees.gender, Employees.address, Employees.birthDate,"
            Dim selectEmpTypes As String = "Employee_Types.empType, "
            Dim selectEmpDept As String = "Departments.department"
            Dim where As String = "Employees.empTypeId = Employee_Types.id AND Employees.departmentId = Departments.id"

            Dim getAllEmployeesQuery As String = "SELECT " & selectEmployees & selectEmpTypes & selectEmpDept & "  FROM Employees,Employee_Types, Departments WHERE " & where
            Dim sqlCommand As New SqlCommand(getAllEmployeesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    DisplayEmployeeDGrid(reader("id"), reader("firstName"), reader("middlename"), reader("lastname"), reader("gender"), reader("address"), reader("birthDate"), reader("empType"), reader("department"))
                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get all employees (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get all employees (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function UpdateEmployeeInfo(ByVal empId As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal gender As String, _
                              ByVal address As String, ByVal bdate As String, ByVal empTypeId As Integer, ByVal depId As Integer) As Boolean

        Try
            Dim updateEmployeeInfoQuery As String
            updateEmployeeInfoQuery = "UPDATE Employees SET firstName='" & fname & "', middleName='" & mname & "', lastname='" & lname & "',gender='" & gender & _
                                        "', address='" & address & "',birthDate='" & bdate & "',empTypeId=" & empTypeId & ",departmentId=" & depId & _
                                        " WHERE id=" & empId
            'MessageBox.Show(updateEmployeeInfoQuery)
            If Me.ExecuteCommand(updateEmployeeInfoQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Update Employee infos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function DeleteEmployee(ByVal empId As Integer) As Boolean

        Try
            Dim deleteEmployeeQuery As String = "DELETE FROM Employees WHERE id=" & empId

            If Me.ExecuteCommand(deleteEmployeeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Delete Employee infos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

End Class