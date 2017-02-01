Public Class EmployeeTypesFrm

    Private empTypeController As New EmployeeTypeController

    Private emptypeId As Integer

    Private Sub EmployeeTypesFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.LoadEmployeeTypes()
    End Sub

    Private Sub LoadEmployeeTypes()
        Me.AllEmployeeTypesDGV.Rows.Clear()
        Me.empTypeController.GetAllEmployeeTypes(AddressOf Me.DisplayEmployeeTypes)

        Me.AddNewEmpTypeBtn.Enabled = True
        Me.UpdateEmpTypeBtn.Enabled = False

        Me.empTypeTxt.Text = ""
    End Sub

    Public Sub DisplayEmployeeTypes(ByVal typeId As Integer, ByVal typeName As String, ByVal numOfEmployees As Integer)

        AllEmployeeTypesDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("EmployeeTypeTable")
        Try
            AllEmployeeTypesDGV.Rows.Add(typeId, typeName, numOfEmployees)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying employee tyeps", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles RefreshBtn.Click
        Me.LoadEmployeeTypes()
    End Sub

    Private Sub AddNewEmpTypeBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddNewEmpTypeBtn.Click

        Try
            If Me.empTypeTxt.Text <> "" Then
                If Me.empTypeController.AddNewType(Me.empTypeTxt.Text) Then
                    MessageBox.Show("Added", "Add new type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Eror", "Add new type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add new type button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBtn.Click

        Try
            Dim currentRowIndex As Integer = AllEmployeeTypesDGV.CurrentRow.Index
            Me.emptypeId = AllEmployeeTypesDGV.Item(0, currentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this type?", "Removing Employee type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If ans = 6 Then
                Me.empTypeController.DeleteType(Me.emptypeId)
                Me.LoadEmployeeTypes()
            End If

        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EditBtn_Click(sender As System.Object, e As System.EventArgs) Handles EditBtn.Click
        Try
            Dim currentRowIndex As Integer = AllEmployeeTypesDGV.CurrentRow.Index
            Me.emptypeId = AllEmployeeTypesDGV.Item(0, currentRowIndex).Value.ToString

            Me.AddNewEmpTypeBtn.Enabled = False
            Me.UpdateEmpTypeBtn.Enabled = True

            Me.empTypeTxt.Text = AllEmployeeTypesDGV.Item(1, currentRowIndex).Value.ToString
        Catch null As NullReferenceException
            MessageBox.Show(null.Message, "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Edit button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateEmpTypeBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateEmpTypeBtn.Click

        Try
            If Me.empTypeTxt.Text <> "" Then
                If Me.empTypeController.UpdateType(Me.emptypeId, Me.empTypeTxt.Text) Then
                    MessageBox.Show("Updated", "Updating Employee type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.LoadEmployeeTypes()
                Else
                    MessageBox.Show("Error", "Updating Employee type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class