Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Authentication : Inherits SqlControl

    Public userId As Integer

    ' Use for user login
    Public Function IsUserExists(ByVal username As String, ByVal password As String) As Boolean
        Try
            ' Hash the user input password
            Dim inputPass As String = Me.security.GetHashPassSHA(password)

            Dim selectUserQuery As String = "SELECT * FROM Users WHERE (username = '" & username & "' AND password = '" & inputPass & "')"
            Dim sqlCommand As New SqlCommand(selectUserQuery, Me.Connection)

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
                MessageBox.Show(ex.Message)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return False
    End Function

    ' Just get the user id of current user
    Public Function GetUserId(ByVal username As String, ByVal password As String) As Integer
        Dim userId As Integer
        Try

            Dim inputPass As String = Me.security.GetHashPassSHA(password)

            Dim getUserIdQuery As String = "SELECT id FROM users WHERE (username = '" & username & "' AND password = '" & inputPass & "')"
            Dim sqlCommand As New SqlCommand(getUserIdQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                If (reader.Read()) Then
                    userId = reader("id")
                Else
                    MessageBox.Show("Can't see users in the database")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return userId
    End Function

    ' Just get the username of the current user
    Public Function GetUserUserName(ByVal userId As Integer) As String
        Dim username As String = ""

        Try
            Dim getUsernameQuery As String = "SELECT username FROM Users WHERE (id = " & userId & ")"
            Dim sqlCommand As New SqlCommand(getUsernameQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try
                If (reader.Read()) Then
                    username = reader("username")
                Else
                    MessageBox.Show("Can't see user in the database")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return username
    End Function

    ' Set the session of the user
    Public Sub SetUserSession(ByVal userId As Integer)
        Try
            Dim timeLogin As String = Format(Now, "hh:mm:ss")

            Dim setUserSessionQuery As String = "INSERT INTO Users_session_status(userId,timeLogin) VALUES(" & userId & ", '" & timeLogin & "')"

            Me.ExecuteCommand(setUserSessionQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Add user log
    Public Sub AddUserLog(ByVal userId As Integer)

        Try
            Dim timeLogin As String = Format(Now, "hh:mm:ss")
            Dim dateNow As String = Format(Now, "dd/MM/yyyy")

            Dim insertNewUserLogQuery As String = "INSERT INTO Users_activity_logs(userId, dateLog ,timeLogin) VALUES(" & userId & ",'" & dateNow & "','" & timeLogin & "')"

            Me.ExecuteCommand(insertNewUserLogQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Add the time logout of the current user
    Public Sub AddDateLogoutOnUserLog(ByVal userId As Integer)

        Try
            Dim lastLogId As Integer = Me.GetLastLogByUser(userId)

            Dim timeLogout As String = Format(Now, "hh:mm:ss")

            Dim updateUserLogQuery As String = "UPDATE Users_activity_logs SET timeLogout = '" & timeLogout & "' WHERE userId =" & userId & " AND id =" & lastLogId

            Me.ExecuteCommand(updateUserLogQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Just get the current log by the user
    Private Function GetLastLogByUser(ByVal userId As Integer) As Integer
        Dim logId As Integer

        Try
            Dim getLastLogQuery As String = "SELECT TOP 1 id FROM Users_activity_logs WHERE userId =" & userId & "ORDER BY id DESC"
            Dim sqlCommand As New SqlCommand(getLastLogQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
            Try
                If (reader.Read()) Then
                    logId = reader("id")
                Else
                    MessageBox.Show("Can't get log id")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return logId
    End Function

    ' Use for user logout
    ' Unset the session
    Public Sub UnsetUserSession(ByVal userId As Integer)
        Try
            Dim unsetUsersessionQuery As String = "DELETE FROM Users_session_status WHERE (userid = '" & userId & "')"

            Me.ExecuteCommand(unsetUsersessionQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            results = Me.IsUserExists(username, password)

            If results Then
                ' Get user id
                Me.userId = Me.GetUserId(username, password)

                ' Set session as online
                Me.SetUserSession(Me.userId)

                ' Insert new Log to user
                Me.AddUserLog(Me.userId)
                Return True
            End If

        End If
        Return False
    End Function

    Public Function GetUsername() As String
        Return Me.GetUserUserName(Me.userId)
    End Function

    ' Use to Logout
    ' Or it can be use on form closing
    Public Function LogoutUser() As Boolean
        Me.UnsetUserSession(Me.userId)
        Me.AddDateLogoutOnUserLog(Me.userId)
        Return True
    End Function

End Class
