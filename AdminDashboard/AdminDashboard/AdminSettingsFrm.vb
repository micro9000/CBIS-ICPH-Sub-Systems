Public Class AdminSettingsFrm

    Private adminSettingsController As New AdminSettingsController

    Private adminId As Integer

    Private Sub AdminSettingsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.adminId = LoginFrm.auth.adminId
    End Sub


    Private Sub UpdateUsernameBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateUsernameBtn.Click
        Try
            If Me.NewUsernameTxt.Text <> "" And Me.CurPasswordTxt.Text <> "" Then
                If adminSettingsController.UpdateAdminUsername(Me.NewUsernameTxt.Text, Me.CurPasswordTxt.Text, Me.adminId) Then
                    MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update username button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePasswordBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdatePasswordBtn.Click
        Try
            If Me.NewPasswordTxt.Text <> "" And Me.CurPassword2Txt.Text <> "" Then
                If adminSettingsController.UpdateAdminPassword(Me.NewPasswordTxt.Text, Me.CurPassword2Txt.Text, Me.adminId) Then
                    MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update password button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class