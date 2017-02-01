Public Class AddRemoveEmployeeMainFrm

    Private EmpMangement As New EmployeesManagement
    Private EmployeeId As Integer

    Private Sub AddNewEmployeeBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles AddNewEmployeeBtn.Click
        AddEmployeeFrm.addRemoveEmployeeTitleLbl.Text = "Add New Employee"

        ' Set value to empty string
        AddEmployeeFrm.EmpFirstNameTxt.Text = ""
        AddEmployeeFrm.EmpMiddleNameTxt.Text = ""
        AddEmployeeFrm.EmpLastNameTxt.Text = ""

        AddEmployeeFrm.AddNewEmployeeBtn.Enabled = True
        AddEmployeeFrm.UpdateEmployeeInfoBtn.Enabled = False
        AddEmployeeFrm.ShowDialog()
    End Sub

    Private Sub UpdateEmployeeInfoBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateEmployeeInfoBtn.Click

        ' Error warning to AddEmployee form
        AddEmployeeFrm.fnameError.Visible = False
        AddEmployeeFrm.mnameError.Visible = False
        AddEmployeeFrm.lnameError.Visible = False
        AddEmployeeFrm.genderError.Visible = False
        AddEmployeeFrm.addressError.Visible = False
        AddEmployeeFrm.bdateError.Visible = False
        AddEmployeeFrm.empTypeError.Visible = False
        AddEmployeeFrm.depError.Visible = False

        AddEmployeeFrm.addRemoveEmployeeTitleLbl.Text = "Update Employee Information"
        AddEmployeeFrm.AddNewEmployeeBtn.Enabled = False
        AddEmployeeFrm.UpdateEmployeeInfoBtn.Enabled = True

        ' Get Employee Infos for update form value
        If Me.GetCurrentRowEmployeeInfoToUpdate() Then
            AddEmployeeFrm.ShowDialog()
        End If
    End Sub


    Private Sub AddRemoveEmployeeMainFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.AllEmployeesDGV.Rows.Clear()
        ' Load all employees
        ' Pass as argument the DisplayEmployeeDataGrid function to display all employees in the datagridview
        Me.EmpMangement.GetAllEmployees(AddressOf Me.DisplayEmployeeDataGrid)

    End Sub

    ' Display or add new item to med list
    Public Sub DisplayEmployeeDataGrid(ByVal empId As String, ByVal firstname As String, ByVal middlename As String, _
                                  ByVal lastname As String, ByVal gender As String, ByVal address As String, _
                                  ByVal brithdate As String, ByVal empType As String, ByVal emtDepartment As String)

        AllEmployeesDGV.ForeColor = Color.Black
        Dim medItems As New DataTable("EmployeesTable")
        Try
            AllEmployeesDGV.Rows.Add(empId, firstname, middlename, lastname, gender, address, brithdate, empType, emtDepartment)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - displaying employees", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SelectUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles SelectUserBtn.Click
        Me.GetCurrentRowEmployeeInformation()
    End Sub

    Private Function GetCurrentRowEmployeeInfoToUpdate() As Boolean

        Dim ex_message As String = ""

        Try
            Dim currentRowIndex As Integer = AllEmployeesDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            '
            ' Employee id to update
            AddEmployeeFrm.EmployeeId = AllEmployeesDGV.Item(0, currentRowIndex).Value.ToString
            AddEmployeeFrm.EmpFirstNameTxt.Text = AllEmployeesDGV.Item(1, currentRowIndex).Value.ToString
            AddEmployeeFrm.EmpMiddleNameTxt.Text = AllEmployeesDGV.Item(2, currentRowIndex).Value.ToString
            AddEmployeeFrm.EmpLastNameTxt.Text = AllEmployeesDGV.Item(3, currentRowIndex).Value.ToString

            Return True
        Catch ex As NullReferenceException
            ex_message = ex.Message & " - No Employee"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return False
    End Function


    Private Sub GetCurrentRowEmployeeInformation()

        Dim ex_message As String = ""
        Try
            Dim currentRowIndex As Integer = AllEmployeesDGV.CurrentRow.Index

            ' Display all employee in the Employee Information Group box
            Me.empIdtext.Text = AllEmployeesDGV.Item(0, currentRowIndex).Value.ToString

            Dim firstname As String = AllEmployeesDGV.Item(1, currentRowIndex).Value.ToString
            Dim middlename As String = AllEmployeesDGV.Item(2, currentRowIndex).Value.ToString
            Dim lastname As String = AllEmployeesDGV.Item(3, currentRowIndex).Value.ToString.ToUpper

            Dim fullname As String = lastname & " " & firstname & " " & middlename
            Me.EmpFullnameTxt.Text = fullname

            Me.EmpGenderTxt.Text = AllEmployeesDGV.Item(4, currentRowIndex).Value.ToString
            Me.EmpAddressTxt.Text = AllEmployeesDGV.Item(5, currentRowIndex).Value.ToString
            Me.EmpBirthDateTxt.Text = AllEmployeesDGV.Item(6, currentRowIndex).Value.ToString
            Me.EmpTypeTxt.Text = AllEmployeesDGV.Item(7, currentRowIndex).Value.ToString
            Me.EmpDepartment.Text = AllEmployeesDGV.Item(8, currentRowIndex).Value.ToString
        Catch ex As NullReferenceException
            ex_message = ex.Message & " - No Employee"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        
    End Sub

    Private Sub AllEmployeesDGV_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles AllEmployeesDGV.CellMouseDoubleClick
        Me.GetCurrentRowEmployeeInformation()
    End Sub



    Private Sub RemoveUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveUserBtn.Click

        Dim ex_message As String = ""
        Try

            Dim currentRowIndex As Integer = AllEmployeesDGV.CurrentRow.Index

            ' Set value to select employee infos to update
            ' Employee id to update
            Me.EmployeeId = AllEmployeesDGV.Item(0, currentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this employee?", "Removing Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = 6 Then
                Me.EmpMangement.DeleteEmployee(EmployeeId)

                Me.AllEmployeesDGV.Rows.Clear()
                Me.EmpMangement.GetAllEmployees(AddressOf Me.DisplayEmployeeDataGrid)

                MessageBox.Show("Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As NullReferenceException

            ex_message = ex.Message & " - No Employee"
            MessageBox.Show(ex_message, "Error: 0x101", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub SearchUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles SearchUserBtn.Click
        Dim searchEmployeeId As String = Me.SearchEmployeeId.Text

        If searchEmployeeId <> "" Then
            Me.AllEmployeesDGV.Rows.Clear()
            Me.EmpMangement.SearchEmployee(searchEmployeeId, AddressOf Me.DisplayEmployeeDataGrid)
        End If

    End Sub

    Private Sub RefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles RefreshBtn.Click
        ' Load all employees
        ' Pass as argument the DisplayEmployeeDataGrid function to display all employees in the datagridview
        Me.AllEmployeesDGV.Rows.Clear()
        Me.EmpMangement.GetAllEmployees(AddressOf Me.DisplayEmployeeDataGrid)
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewAllToolStripMenuItem.Click
        DepartmentsFrm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        EmployeeTypesFrm.ShowDialog()
    End Sub
End Class