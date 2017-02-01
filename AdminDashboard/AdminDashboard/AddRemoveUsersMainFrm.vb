Public Class AddRemoveUsersFrm


    Private usersManagement As New UsersManagement

    Private security As New Security

    Private userId As Integer = 0


    ' Display or add new item to med list
    Public Sub DisplayUsersDataGrid(ByVal userId As String, ByVal username As String, ByVal status As String, ByVal dateCreated As String, ByVal lastUpdated As String)

        AllUsersDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("UsersTable")
        Try
            AllUsersDGV.Rows.Add(userId, username, status, dateCreated, lastUpdated)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AddUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddUserBtn.Click

        Try

            If Me.EmployeeIdTxt.Text <> "" And Me.UsernameTxt.Text <> "" And Me.UsersPasswordTxt.Text <> "" Then
                Dim empId As String = Me.EmployeeIdTxt.Text
                Dim username As String = Me.UsernameTxt.Text
                Dim password As String = Me.UsersPasswordTxt.Text

                ' get the hash password SHA512
                Dim hashPassword As String = Me.security.GetHashPassSHA(password)

                If Me.usersManagement.InsertNewUser(empId, username, hashPassword) Then
                    MessageBox.Show("Successfully Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.EmployeeIdTxt.Text = ""
                    Me.UsernameTxt.Text = ""
                    Me.UsersPasswordTxt.Text = ""

                    Me.GetAllUsers()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Add user button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetAllUsers()
        Me.AllUsersDGV.Rows.Clear()

        Me.usersManagement.SelectAllUsers(AddressOf Me.DisplayUsersDataGrid)
    End Sub

    Private Sub AddRemoveUsersFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Display all users
        Me.GetAllUsers()
    End Sub

    Private Function ViewUserInformation() As Boolean

        Dim ex_message As String = ""
        Dim UsersId As Integer = 0
        Dim UserEmployeeId As Integer = 0

        Try
            Dim currentRowIndex As Integer = AllUsersDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            'AddEmployeeFrm.EmployeeId = AllEmployeesDGV.Item(0, currentRowIndex).Value.ToString

            UsersId = AllUsersDGV.Item(0, currentRowIndex).Value.ToString
            UserEmployeeId = AllUsersDGV.Item(1, currentRowIndex).Value.ToString

            ' Fullname and Department of the User
            Me.usersManagement.GetUserEmployeeInfos(Me.EmpFullnameInfoTxt, Me.UserDeparmentInfoTxt, UserEmployeeId)

            ' User account status
            Me.usersManagement.GetUsersAccountStatus(Me.UserAccStatusInfoTxt, UsersId)

            ' User last login date
            Me.usersManagement.GetUsersLastLogin(Me.UserLastLoginInfoTxt, UsersId)

            Return True
        Catch ex As NullReferenceException
            ex_message = ex.Message & " - No Users"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return False
    End Function

    Private Sub AllUsersDGV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles AllUsersDGV.DoubleClick
        Me.ViewUserInformation()
    End Sub

    Private Sub SelectUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles SelectUserBtn.Click
        Me.ViewUserInformation()
    End Sub

    Private Sub ViewPassLnkLbl_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ViewPassLnkLbl.LinkClicked
        Me.UsersPasswordTxt.PasswordChar = ""
        Me.ViewPassLnkLbl.Enabled = False
        Me.HidePassLnkLbl.Enabled = True
    End Sub

    Private Sub HidePassLnkLbl_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HidePassLnkLbl.LinkClicked
        Me.UsersPasswordTxt.PasswordChar = "*"
        Me.HidePassLnkLbl.Enabled = False
        Me.ViewPassLnkLbl.Enabled = True
    End Sub

    Private Sub RefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles RefreshBtn.Click
        Me.GetAllUsers()

        ' Reset all to empty
        Me.SearchUserId.Text = ""
        Me.EmpFullnameInfoTxt.Text = ""
        Me.UserDeparmentInfoTxt.Text = ""
        Me.UserAccStatusInfoTxt.Text = ""
        Me.UserLastLoginInfoTxt.Text = ""
        Me.EmployeeIdTxt.Text = ""
        Me.UsernameTxt.Text = ""
        Me.UsersPasswordTxt.Text = ""

        Me.AddUserBtn.Enabled = True
        Me.UpdateUserBtn_addGbox.Enabled = False

    End Sub
    ' Update button on the All User panel
    Private Sub UpdateUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateUserBtn.Click
        Dim ex_message As String = ""
        Dim userEmpId As Integer = 0
        Dim username As String = ""
        Try
            Dim currentRowIndex As Integer = AllUsersDGV.CurrentRow.Index

            ' user id
            Me.userId = AllUsersDGV.Item(0, currentRowIndex).Value.ToString

            ' Employee id
            userEmpId = AllUsersDGV.Item(1, currentRowIndex).Value.ToString
            ' username
            username = AllUsersDGV.Item(2, currentRowIndex).Value.ToString

            Me.EmployeeIdTxt.Text = userEmpId
            Me.UsernameTxt.Text = username

            Me.AddUserBtn.Enabled = False
            Me.UpdateUserBtn_addGbox.Enabled = True
        Catch ex As NullReferenceException
            ex_message = ex.Message & " - No Users"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub UpdateUserBtn_addGbox_Click(sender As System.Object, e As System.EventArgs) Handles UpdateUserBtn_addGbox.Click


        Try

            If Me.EmployeeIdTxt.Text <> "" And Me.UsernameTxt.Text <> "" And Me.UsersPasswordTxt.Text <> "" Then
                Dim empId As String = Me.EmployeeIdTxt.Text
                Dim username As String = Me.UsernameTxt.Text
                Dim password As String = Me.UsersPasswordTxt.Text

                ' get the hash password SHA512
                Dim hashPassword As String = Me.security.GetHashPassSHA(password)

                If Me.usersManagement.UpdateUser(Me.userId, empId, username, hashPassword) Then
                    MessageBox.Show("Successfully Updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.EmployeeIdTxt.Text = ""
                    Me.UsernameTxt.Text = ""
                    Me.UsersPasswordTxt.Text = ""

                    Me.GetAllUsers()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Update user button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveUserBtn.Click
        'DeleteUser
        Dim ex_message As String = ""
        Try
            Dim currentRowIndex As Integer = AllUsersDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            ' Employee id to update
            Dim userid = AllUsersDGV.Item(0, currentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this user?", "Removing users", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = 6 Then
                If Me.usersManagement.DeleteUser(userid) Then
                    Me.GetAllUsers()
                    MessageBox.Show("Deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As NullReferenceException
            ex_message = ex.Message & " - No Users"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub SearchUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchUserBtn.Click

        Try
            If Me.SearchUserId.Text <> "" Then
                Me.AllUsersDGV.Rows.Clear()
                Me.usersManagement.SearchUsers(AddressOf Me.DisplayUsersDataGrid, Me.SearchUserId.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 Search button")
        End Try
    End Sub

End Class