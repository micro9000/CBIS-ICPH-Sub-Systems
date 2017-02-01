Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class AdminSettingsController : Inherits SqlControl

    Private security As New Security


    Public Function UpdateAdminUsername(ByVal newUsername As String, ByVal curPassword As String, ByVal adminId As Integer) As Boolean
        Try

            Dim curPassHash As String = Me.security.GetHashPassSHA(curPassword)

            Dim updateAdminUsernameQuery As String = "UPDATE AdminUsers SET username='" & newUsername & "' WHERE password='" & curPassHash & "' AND id=" & adminId

            If Me.ExecuteCommand(updateAdminUsernameQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Admin awareness (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function UpdateAdminPassword(ByVal newPassword As String, ByVal curPassword As String, ByVal adminId As Integer) As Boolean
        Try

            Dim curPassHash As String = Me.security.GetHashPassSHA(curPassword)
            Dim newPassHash As String = Me.security.GetHashPassSHA(newPassword)

            Dim updateAdminPasswordQuery As String = "UPDATE AdminUsers SET password='" & newPassHash & "' WHERE password='" & curPassHash & "' AND id=" & adminId

            If Me.ExecuteCommand(updateAdminPasswordQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Check Admin awareness (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
End Class
