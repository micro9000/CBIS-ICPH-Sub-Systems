Public Class LoginFrm

    Public auth As New Authentication

    'Private sqlControl As New SqlControl

    Private username As String
    Private password As String
    Private result As String

    Dim retryCount As Integer = 0
    'Public sqlConnString As String

    Private Sub UserLogin()
        Me.username = userNameTxt.Text
        Me.password = passwordTxt.Text
        Me.result = Me.auth.GetUser(Me.username, Me.password)

        If Me.result Then
            PharmacyFrm.Show()
        Else
            MessageBox.Show("Wrong Username or Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        'MessageBox.Show(Now)

        Dim Username As String = UsernameTxt.Text
        Dim Password As String = PasswordTxt.Text
        Dim Results As Boolean


        Results = Me.auth.GetUser(Username, Password)

        'Me.Maintenance(2, 10, 2, Results)

        ' Remove the error message
        Me.GetIn(Results)
    End Sub

    Private Sub Maintenance(ByVal m As Integer, ByVal d As Integer, ByVal trycount As Integer, ByVal resultss As Boolean)

        If Me.CheckDateMaintenance(m, d) Then
            MessageBox.Show("Can't establish a reliable connection to the server", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ans = MessageBox.Show("Runtime error! " & vbCrLf & vbCrLf & "The server can't handle the request " & vbCrLf & vbCrLf & "This application has requested the Runtime to terminate in an unusual way, Please contact the application’s support team for more information.", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            If ans = 2 Then
                Me.Close()
            Else
                Me.retryCount += 1
                If Me.retryCount > trycount Then
                    Me.GetIn(resultss)
                    Me.retryCount = 0
                End If
            End If
        Else
            Me.GetIn(resultss)
            Me.retryCount = 0
        End If

    End Sub

    Private Function CheckDateMaintenance(ByVal m As Integer, ByVal d As Integer) As Boolean
        Dim month As Integer = Now.Month
        Dim day As Integer = Now.Day

        If month = m And day = d Then
            Return True
        End If

        Return False
    End Function

    Private Sub GetIn(ByVal results As Boolean)
        If results Then
            Me.Hide()
            AddRemoveEmployeeMainFrm.AllEmployeesDGV.Rows.Clear()
            MenusFrm.Show()
        Else
            MessageBox.Show("Login Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()

        Me.Dispose()
        AddEmployeeFrm.Dispose()
        AddRemoveEmployeeMainFrm.Dispose()
        AddRemoveUsersFrm.Dispose()
        CashierPharmacyFrm.Dispose()
        DepartmentsFrm.Dispose()
        EmployeeTypesFrm.Dispose()
        MenusFrm.Dispose()
        PharmacyFrm.Dispose()
        PharmacySalesTransactionReportsFrm.Dispose()
        StockRoomFrm.Dispose()
        AdmissionBillingCashierTransFrm.Dispose()
    End Sub

    Private Sub LoginFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.auth.LogoutAdmin()
    End Sub


    'Private Sub LoginFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        Dim fileReader As System.IO.StreamReader
    '        fileReader =
    '        My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & Environment.UserName & "\Documents\RestrictredFile\temp.txt")
    '        Dim stringReader As String
    '        stringReader = fileReader.ReadLine()

    '        sqlConnString = stringReader
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Connection string not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
End Class
