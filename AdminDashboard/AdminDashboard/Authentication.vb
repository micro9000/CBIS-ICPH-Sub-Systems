Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Authentication : Inherits SqlControl

    Public adminId As Integer = -1

    Private security As New Security

    ' Use for user login
    Public Function IsAdminExists(ByVal username As String, ByVal password As String) As Boolean
        Try
            Dim passwordHash As String = security.GetHashPassSHA(password)

            Dim selectAdminQuery As String = "SELECT * FROM AdminUsers WHERE (username = '" & username & "' AND password = '" & passwordHash & "')"
            Dim sqlCommand As New SqlCommand(selectAdminQuery, Me.Connection)

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
                MessageBox.Show(ex.Message, "Error: 0x101 - Admin authentication (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin authentication (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function



    ' Just get the user id of current user
    Public Function GetAdminId(ByVal username As String, ByVal password As String) As Integer
        Dim userId As Integer
        Try
            Dim passwordhash As String = Me.security.GetHashPassSHA(password)
            Dim getAdmindQuery As String = "SELECT id FROM AdminUsers WHERE (username = '" & username & "' AND password = '" & passwordhash & "')"
            Dim sqlCommand As New SqlCommand(getAdmindQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    userId = reader("id")
                Else
                    MessageBox.Show("Can't see users in the database", "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Admin id (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return userId
    End Function

    ' Just get the username of the current user
    Public Function GetAdminPermission(ByVal adminId As Integer) As String
        Dim permission As String = ""

        Try
            Dim getAdminPermissionQuery As String = "SELECT permission FROM AdminUsers WHERE (id = " & adminId & ")"
            Dim sqlCommand As New SqlCommand(getAdminPermissionQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try
                If (reader.Read()) Then
                    permission = reader("permission")
                Else
                    MessageBox.Show("Can't see user in the database", "Error: 0x101 Admin Permission (3)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Admin Permission (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin id (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return permission
    End Function

    ' Set the session of the user
    Public Sub SetAdminSession(ByVal adminId As Integer)
        Try
            Dim timeLogin As String = Format(Now, "hh:mm:ss")

            Dim setAdminSessionQuery As String = "INSERT INTO AdminSessionsStatus(adminId, timeLogin) VALUES(" & adminId & ", '" & timeLogin & "')"

            Me.ExecuteCommand(setAdminSessionQuery)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin session", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add user log
    Public Sub AddAdminLog(ByVal adminId As Integer)

        Try
            Dim timeLogin As String = Format(Now, "hh:mm:ss")
            Dim dateNow As String = Format(Now, "dd/MM/yyyy")

            Dim insertNewAdminLogQuery As String = "INSERT INTO AdminActivityLog(adminId, dateLog ,timeLogin) VALUES(" & adminId & ",'" & dateNow & "','" & timeLogin & "')"

            Me.ExecuteCommand(insertNewAdminLogQuery)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin login log", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add the time logout of the current user
    Public Sub AddDateLogoutOnAdminLog(ByVal adminId As Integer)

        Try
            Dim lastLogId As Integer = Me.GetLastLogByAdmin(adminId)

            Dim timeLogout As String = Format(Now, "hh:mm:ss")

            Dim updateUserLogQuery As String = "UPDATE AdminActivityLog SET timeLogout = '" & timeLogout & "' WHERE adminId =" & adminId & " AND id =" & lastLogId

            Me.ExecuteCommand(updateUserLogQuery)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin logout log", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Just get the current log by the user
    Private Function GetLastLogByAdmin(ByVal adminId As Integer) As Integer
        Dim logId As Integer

        Try
            If adminId <> -1 Then
                Dim getLastLogQuery As String = "SELECT TOP 1 id FROM AdminActivityLog WHERE adminId =" & adminId & "ORDER BY id DESC"
                Dim sqlCommand As New SqlCommand(getLastLogQuery, Me.Connection)

                If Me.Connection.State = False Then
                    Me.Connection.Open()
                End If

                Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
                Try
                    If (reader.Read()) Then
                        logId = reader("id")
                    Else
                        MessageBox.Show("Can't get log id", "Error: 0x101 - Admin log id (3)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error: 0x101 - Admin last log (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Clossing connections
                    reader.Close()
                    sqlCommand.Dispose()
                    Me.Connection.Close()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin last log (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return logId
    End Function

    ' Use for user logout
    ' Unset the session
    Public Sub UnsetAdminSession(ByVal adminId As Integer)
        Try
            Dim unsetUsersessionQuery As String = "DELETE FROM AdminSessionsStatus WHERE (adminid = '" & adminId & "')"

            Me.ExecuteCommand(unsetUsersessionQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Admin unset session", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CheckUsernamePassword(ByVal username As String, ByVal password As String) As Boolean
        If username <> "" And password <> "" Then
            Return True
        End If
        Return False
    End Function

    Public Function GetUser(ByRef username As String, ByRef password As String) As Boolean
        Dim results As Boolean

        If Me.CheckUsernamePassword(username, password) Then
            results = Me.IsAdminExists(username, password)

            If results Then
                ' Get user id
                Me.adminId = Me.GetAdminId(username, password)
                ' Set session as online
                Me.SetAdminSession(Me.adminId)

                ' Insert new Log to user
                Me.AddAdminLog(Me.adminId)
                Return True
            End If

        End If
        Return False
    End Function

    Public Function GetAdminPermission() As String
        Dim permission = Me.GetAdminPermission(Me.adminId)
        Return permission
    End Function

    Public Function LogoutAdmin() As Boolean
        Me.UnsetAdminSession(Me.adminId)
        Me.AddDateLogoutOnAdminLog(Me.adminId)
        Return True
    End Function

End Class
