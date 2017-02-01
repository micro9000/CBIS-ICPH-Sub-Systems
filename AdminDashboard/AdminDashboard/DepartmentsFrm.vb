Public Class DepartmentsFrm

    Private deptController As New DepartmentControll
    Private departmentId As Integer

    Private Sub DepartmentsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AllDepartmentsDGV.Rows.Clear()
        Me.deptController.GetAllDepartments(AddressOf Me.DisplayDepartment)
    End Sub

    Public Sub DisplayDepartment(ByVal id As Integer, ByVal deptName As String, ByVal numOfEmp As Integer)
        AllDepartmentsDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("DepartmentsTable")
        Try
            AllDepartmentsDGV.Rows.Add(id, deptName, numOfEmp)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying departments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles RefreshBtn.Click
        Me.RefreshAll()
    End Sub

    Private Sub RefreshAll()
        AllDepartmentsDGV.Rows.Clear()
        Me.deptController.GetAllDepartments(AddressOf Me.DisplayDepartment)

        Me.UpdateDeptBtn.Enabled = False
        Me.AddNewDeptBtn.Enabled = True
    End Sub

    Private Sub AddNewDeptBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddNewDeptBtn.Click

        Try
            If Me.deptNameTxt.Text <> "" Then
                If Me.deptController.InsertNewDepartment(Me.deptNameTxt.Text) Then
                    MessageBox.Show("Added!", "Add department", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AllDepartmentsDGV.Rows.Clear()
                    Me.deptController.GetAllDepartments(AddressOf Me.DisplayDepartment)
                Else
                    MessageBox.Show("Error", "Add department", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add new department", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub EditBtn_Click(sender As System.Object, e As System.EventArgs) Handles EditBtn.Click
        Try

            Dim currentRowIndex As Integer = AllDepartmentsDGV.CurrentRow.Index
            Me.departmentId = AllDepartmentsDGV.Item(0, currentRowIndex).Value.ToString

            Me.UpdateDeptBtn.Enabled = True
            Me.AddNewDeptBtn.Enabled = False

            Me.deptNameTxt.Text = AllDepartmentsDGV.Item(1, currentRowIndex).Value.ToString

        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Edit button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UpdateDeptBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateDeptBtn.Click
        Try
            If Me.deptNameTxt.Text <> "" Then
                If Me.deptController.UpdateDepartment(Me.departmentId, Me.deptNameTxt.Text) Then
                    MessageBox.Show("Updated", "Update Department", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.RefreshAll()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBtn.Click
        Try
            Dim currentRowIndex As Integer = AllDepartmentsDGV.CurrentRow.Index
            Me.departmentId = AllDepartmentsDGV.Item(0, currentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this department", "Removing Department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If ans = 6 Then
                Me.deptController.DeleteDepartment(Me.departmentId)
                Me.RefreshAll()
            End If

        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class