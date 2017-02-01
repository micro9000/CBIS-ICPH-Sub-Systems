Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class UsersManagement : Inherits SqlControl

    Delegate Sub DisplayUsersDataGrid(ByVal userId As String, ByVal username As String, ByVal status As String, ByVal dateCreated As String, ByVal lastUpdated As String)

    Public Function InsertNewUser(ByVal employeeId As Integer, ByVal username As String, ByVal password As String) As Boolean

        Try
            If Me.IsEmployeeExists(employeeId) Then
                If Me.isUserExists(employeeId) Then
                    MessageBox.Show("User is already exists in the database", "Already has an account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim InsertNewUserQuery As String = "INSERT INTO Users(username,password,employeeId, dateCreated) VALUES('" & username & "', '" & password & "', " & employeeId & ", '" & Now & "')"

                    If Me.ExecuteCommand(InsertNewUserQuery) Then
                        Return True
                    End If
                End If
               
            Else
                MessageBox.Show("Employee doesn't exists in the database please register your employee", "Can't find employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Insert new user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Private Function isUserExists(ByVal employeeId As Integer) As Boolean

        Try
            Dim SelectUserExitsQuery As String = "SELECT id FROM Users WHERE employeeId=" & employeeId
            Dim sqlCommand As New SqlCommand(SelectUserExitsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Check User existence in the database (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check User existence in the database (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Private Function IsEmployeeExists(ByVal employeeId As Integer) As Boolean

        Try
            Dim SelectEmployeeExistsQuery As String = "SELECT id FROM Employees WHERE id=" & employeeId
            Dim sqlCommand As New SqlCommand(SelectEmployeeExistsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = SqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Check Employee existence in the database (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                SqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Employee existence in the database (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function UpdateUser(ByVal userId As Integer, ByVal employeeId As Integer, ByVal username As String, ByVal password As String) As Boolean

        Try
            If Me.IsEmployeeExists(employeeId) Then
                Dim UpdateUserQuery As String = "UPDATE Users SET username='" & username & "',password='" & password & "',employeeId=" & employeeId & ",dateUpdated='" & Now & "'  WHERE id=" & userId

                If Me.ExecuteCommand(UpdateUserQuery) Then
                    Return True
                End If
            Else
                MessageBox.Show("Employee doesn't exists in the database please register your employee", "Can't find employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Sub SelectAllUsers(ByRef DisplayUsersDataGrid As DisplayUsersDataGrid)

        Try
            Dim selectAllUsersQuery As String = "SELECT * FROM Users"

            Dim sqlCommand As New SqlCommand(selectAllUsersQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    If reader("dateUpdated").Equals(System.DBNull.Value) Then
                        DisplayUsersDataGrid(reader("id"), reader("employeeId"), reader("username"), reader("dateCreated"), "None")
                    Else
                        DisplayUsersDataGrid(reader("id"), reader("employeeId"), reader("username"), reader("dateCreated"), reader("dateUpdated"))
                    End If


                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get all Users (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Select all Users (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub GetUserEmployeeInfos(ByRef fullNameTxtbox As Object, ByRef departmentTxtBox As Object, ByVal userEmpId As Integer)

        Dim fullname As String = ""

        Try

            Dim selectUsersEmployeeInfoQuery As String = "SELECT Employees.firstName, Employees.middleName, Employees.lastName, Departments.department FROM Employees, Departments WHERE Employees.id=" & userEmpId & " AND Employees.departmentId = Departments.id"
            Dim sqlCommand As New SqlCommand(selectUsersEmployeeInfoQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    fullname = reader("lastName").ToString.ToUpper & " " & reader("firstName").ToString & " " & reader("middleName").ToString
                    fullNameTxtbox.Text = fullname

                    departmentTxtBox.Text = reader("department")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get all employees (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get the Employee Infos (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub GetUsersAccountStatus(ByRef UserAccStatusInfoTxt As Object, ByVal userId As Integer)

        Try
            Dim getUserAccountStatusQuery As String = "SELECT * FROM Users_session_status WHERE userId=" & userId

            Dim sqlCommand As New SqlCommand(getUserAccountStatusQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    UserAccStatusInfoTxt.Text = "Online"
                Else
                    UserAccStatusInfoTxt.Text = "Offline"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get User account status (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get User account status (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub GetUsersLastLogin(ByRef UserLastLoginInfoTxt As Object, ByVal userId As Integer)

        Try
            Dim getUserAccountStatusQuery As String = "SELECT TOP 1 * FROM Users_activity_logs WHERE userId=" & userId

            Dim sqlCommand As New SqlCommand(getUserAccountStatusQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    UserLastLoginInfoTxt.Text = reader("timeLogin")
                Else
                    UserLastLoginInfoTxt.Text = "None"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Get User Last login date (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Get User Last login date (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function DeleteUser(ByVal userId As Integer) As Boolean

        Try
            Dim deleteUserQuery As String = "DELETE FROM Users WHERE id=" & userId

            If Me.ExecuteCommand(deleteUserQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function



    Public Sub SearchUsers(ByRef DisplayUsersDataGrid As DisplayUsersDataGrid, ByVal userid As Integer)

        Try
            Dim searchUsersQuery As String = "SELECT * FROM Users WHERE id=" & userid

            Dim sqlCommand As New SqlCommand(searchUsersQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    If reader("dateUpdated").Equals(System.DBNull.Value) Then
                        DisplayUsersDataGrid(reader("id"), reader("employeeId"), reader("username"), reader("dateCreated"), "None")
                    Else
                        DisplayUsersDataGrid(reader("id"), reader("employeeId"), reader("username"), reader("dateCreated"), reader("dateUpdated"))
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 Search Users (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Search Users (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
