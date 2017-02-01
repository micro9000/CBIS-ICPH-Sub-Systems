Imports System.Security.Cryptography
Imports System.Text

Public Class Security

    Public Function GetHashPassSHA(ByVal password As String) As String

        Dim ASCIIENC As New ASCIIEncoding
        Dim hashPass As String = vbNullString

        Dim bytesourceText() As Byte = ASCIIENC.GetBytes(password)

        Dim SHA512Hash As New SHA512CryptoServiceProvider

        Dim byteHash() As Byte = SHA512Hash.ComputeHash(bytesourceText)

        For Each b As Byte In byteHash
            hashPass &= b.ToString("x2")
        Next

        Return hashPass
    End Function

    Public Function CompareUserInputPassToDBHashPass(ByVal inputPass As String, ByVal dbHashPass As String) As Boolean

        Dim inputPassHash As String = Me.GetHashPassSHA(inputPass)

        If String.Compare(dbHashPass, inputPassHash, False) = 0 Then
            Return True
        End If

        Return False
    End Function

End Class
