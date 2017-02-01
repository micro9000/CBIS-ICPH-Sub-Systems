Public Class p_LoginFrm

    Public auth As New Authentication
    Private loginBtnClickCount As Integer
    Private sqlcontrol As New SqlControl

    Private username As String
    Private password As String

    Public userId As Integer
    Private result As Boolean

    Private Sub p_LoginFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub UserLogin()
        Try
            Me.username = userNameTxt.Text
            Me.password = passwordTxt.Text
            Me.result = Me.auth.GetUser(Me.username, Me.password)

            If Me.result Then
                PharmacyFrm.Show()
                Me.userId = Me.auth.GetUserId(Me.username, Me.password)
                Me.Hide()
            Else
                MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - User login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub loginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        Me.UserLogin()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

   
End Class
