Public Class MenusFrm

    Public adminPermission As String

    Private Sub FormTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormTimer.Tick
        DateTimeLbl.Text = Now
        
    End Sub

    Private Sub MenusFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormTimer.Start()
        'btn descriptions
        Me.displayBtnDescription()

        ' Admin permission like linux : wrx, rx, r
        Me.adminPermission = LoginFrm.auth.GetAdminPermission()


        'MessageBox.Show(Me.adminPermission)
    End Sub

    Private Sub ReportsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsBtn.Click
        Try
            ShowInTaskbar = False
            CashierPharmacyFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RoomStocksBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStocksBtn.Click
        Try
            ShowInTaskbar = False
            StockRoomFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pharmaStocksBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pharmaStocksBtn.Click
        Try
            ShowInTaskbar = False
            PharmacyFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub addRemoveUsersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRemoveUsersBtn.Click
        Try
            ShowInTaskbar = False
            AddRemoveUsersFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MenusFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            LoginFrm.UsernameTxt.Text = ""
            LoginFrm.PasswordTxt.Text = ""
            LoginFrm.Show()

            ' Remove admin session
            LoginFrm.auth.LogoutAdmin()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub displayBtnDescription()
        Try
            ' Create the ToolTip and associate with the Form container.
            Dim description As New ToolTip()

            ' Set up the delays for the ToolTip.
            description.AutoPopDelay = 5000
            description.InitialDelay = 500
            description.ReshowDelay = 500
            ' Force the ToolTip text to be displayed whether or not the form is active.
            description.ShowAlways = True

            ' Set up the ToolTip text for the Button and Checkbox.
            ' Header menus
            description.SetToolTip(Me.logoutBtn, "Logout")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub logoutBtn_Click(sender As System.Object, e As System.EventArgs) Handles logoutBtn.Click
        Try
            ' Remove admin session
            LoginFrm.auth.LogoutAdmin()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EmployeesBtn_Click(sender As System.Object, e As System.EventArgs) Handles EmployeesBtn.Click
        Try
            'AddRemoveEmployeeMainFrm.AllEmployeesDGV.Rows.Clear()
            ShowInTaskbar = False
            AddRemoveEmployeeMainFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PharmacySalesReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles PharmacySalesReportBtn.Click
        Try
            PharmacySalesTransactionReportsFrm.ShowDialog()
        Catch null As NullReferenceException
            MessageBox.Show(null.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RoomsBtn_Click(sender As System.Object, e As System.EventArgs) Handles RoomsBtn.Click
        Try
            RoomsFrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Room button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdmissionBillingCashierBtn_Click(sender As System.Object, e As System.EventArgs) Handles AdmissionBillingCashierBtn.Click
        AdmissionBillingCashierTransFrm.ShowDialog()
    End Sub

    Private Sub LaboratoryBtn_Click(sender As System.Object, e As System.EventArgs) Handles LaboratoryBtn.Click
        LaboratoryTransactionsFrm.ShowDialog()
    End Sub

    Private Sub CashierReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles CashierReportBtn.Click
        CashierReportsFrm.ShowDialog()
    End Sub

    Private Sub er_pharmaStocksBtn_Click(sender As System.Object, e As System.EventArgs) Handles er_pharmaStocksBtn.Click
        ERPharmacyFrm.ShowDialog()
    End Sub

    Private Sub ERPharmacySalesReportBtn_Click(sender As System.Object, e As System.EventArgs) Handles ERPharmacySalesReportBtn.Click
        ERPharmacySalesReportFrm.ShowDialog()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        AdminSettingsFrm.adminSettingsTabCon.SelectedIndex = 1
        AdminSettingsFrm.ShowDialog()
    End Sub

    Private Sub ChangeUsernameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeUsernameToolStripMenuItem.Click
        AdminSettingsFrm.adminSettingsTabCon.SelectedIndex = 0
        AdminSettingsFrm.ShowDialog()
    End Sub
End Class