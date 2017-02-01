Public Class RoomsFrm


    Private roomController As New RoomsController

    Private RoomTypeId As Integer
    Private RoomIdTwo As Integer

    Private Sub AddRoomTypeBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddRoomTypeBtn.Click

        Try
            If Me.RoomTypeNameTxt.Text <> "" And RoomPriceTxt.Text <> "" Then
                Dim roomTypeName As String = Me.RoomTypeNameTxt.Text
                Dim roomPrice As Decimal = Me.RoomPriceTxt.Text

                If Me.roomController.InsertNewRoomType(roomTypeName, roomPrice) Then
                    MessageBox.Show("Added!", "Add Room type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.GetAllRoomTypesInfo()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Room type button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DisplayRoomTypesInfos(ByVal id As Integer, ByVal roomTypeName As String, ByVal roomPrice As Decimal)
        Try
            Me.RoomTypesDGV.ForeColor = Color.Black

            Me.RoomTypesDGV.Rows.Add(id, roomTypeName, roomPrice)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Room types information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub DisplayRoomTypesInfosTwo(ByVal id As Integer, ByVal roomTypeName As String, ByVal roomPrice As Decimal)
        Try
            Me.RoomTypesDGVtwo.ForeColor = Color.Black

            Me.RoomTypesDGVtwo.Rows.Add(id, roomTypeName, roomPrice)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Room types information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayRooms(ByVal id As Integer, ByVal roomNumber As String, ByVal roomType As String, ByVal roomPrice As String)
        Try
            Me.RoomsDGV.ForeColor = Color.Black

            Me.RoomsDGV.Rows.Add(id, roomNumber, roomType, roomPrice)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Display Room types information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetAllRoomTypesInfo()
        Me.RoomTypesDGV.Rows.Clear()
        Me.roomController.GetAllRoomTypes(AddressOf Me.DisplayRoomTypesInfos)
    End Sub

    Private Sub GetAllRoomTypesInfoTwo()
        Me.RoomTypesDGVtwo.Rows.Clear()
        Me.roomController.GetAllRoomTypesTwo(AddressOf Me.DisplayRoomTypesInfosTwo)
    End Sub

    Private Sub GetAllRooms()
        Me.RoomsDGV.Rows.Clear()
        Me.roomController.GetAllRooms(AddressOf Me.DisplayRooms)
    End Sub

    Private Sub RoomsTabControl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RoomsTabControl.SelectedIndexChanged
        If Me.RoomsTabControl.SelectedIndex = 0 Then
            Me.GetAllRoomTypesInfoTwo()
            Me.GetAllRooms()
        End If

        If Me.RoomsTabControl.SelectedIndex = 1 Then
            Me.GetAllRoomTypesInfo()
        End If
    End Sub

    Private Sub UpdateRoomTypeBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateRoomTypeBtn.Click
        Try
            Me.AddRoomTypeBtn.Enabled = False
            Me.UpdateRoomTypeTwoBtn.Enabled = True

            Dim roomCurrentRowIndex As Integer = RoomTypesDGV.CurrentRow.Index
            Me.RoomTypeId = RoomTypesDGV.Item(0, roomCurrentRowIndex).Value.ToString

            Me.RoomTypeNameTxt.Text = RoomTypesDGV.Item(1, roomCurrentRowIndex).Value.ToString
            Me.RoomPriceTxt.Text = RoomTypesDGV.Item(2, roomCurrentRowIndex).Value.ToString

            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Room type information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveRoomTypeBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveRoomTypeBtn.Click
        Try
            Dim roomCurrentRowIndex As Integer = RoomTypesDGV.CurrentRow.Index
            Dim roomID = RoomTypesDGV.Item(0, roomCurrentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this room type?", "Remove Room type", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'MessageBox.Show(ans)

            If (ans = 6) Then
                Me.roomController.DeleteRoomType(roomID)
                Me.GetAllRoomTypesInfo()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove Room type button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRoomTypeTwoBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateRoomTypeTwoBtn.Click
        Try
            If Me.RoomTypeNameTxt.Text <> "" And RoomPriceTxt.Text <> "" Then
                Dim roomTypeName As String = Me.RoomTypeNameTxt.Text
                Dim roomPrice As Decimal = Me.RoomPriceTxt.Text

                If Me.roomController.UpdateRoomType(Me.RoomTypeId, roomTypeName, roomPrice) Then
                    MessageBox.Show("Updated!", "Update Room type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.GetAllRoomTypesInfo()
                    Me.AddRoomTypeBtn.Enabled = True
                    Me.UpdateRoomTypeTwoBtn.Enabled = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Room type button two", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddNewRoomBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddNewRoomBtn.Click
        Try
            Dim roomTypeCurrentRowIndex As Integer = RoomTypesDGVtwo.CurrentRow.Index
            Dim roomTypeID = RoomTypesDGVtwo.Item(0, roomTypeCurrentRowIndex).Value.ToString

            If (Me.RoomNumberTxt.Text <> "") Then
                Dim roomNumber As String = Me.RoomNumberTxt.Text

                If Me.roomController.InsertNewRoom(roomNumber, roomTypeID) Then
                    MessageBox.Show("Added!", "Add new Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.GetAllRooms()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add New Room button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RoomsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.GetAllRooms()
        Me.GetAllRoomTypesInfoTwo()
    End Sub

    Private Sub RemoveRoomBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveRoomBtn.Click
        Try
            Dim roomCurrentRowIndex As Integer = RoomsDGV.CurrentRow.Index
            Dim roomID = RoomsDGV.Item(0, roomCurrentRowIndex).Value.ToString

            Dim ans As Integer = MessageBox.Show("Are you sure you want to remove this room?", "Remove Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'MessageBox.Show(ans)

            If (ans = 6) Then
                Me.roomController.DeleteRoom(roomID)
                Me.GetAllRooms()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove Room button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRoomBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateRoomBtn.Click
        Try
            Me.UpdateRoomBtnTwo.Enabled = True
            Me.AddNewRoomBtn.Enabled = False

            Dim roomCurrentRowIndex As Integer = RoomsDGV.CurrentRow.Index
            Me.RoomIdTwo = RoomsDGV.Item(0, roomCurrentRowIndex).Value.ToString

            Me.RoomNumberTxt.Text = RoomsDGV.Item(1, roomCurrentRowIndex).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Remove Room button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRoomBtnTwo_Click(sender As System.Object, e As System.EventArgs) Handles UpdateRoomBtnTwo.Click
        Try
            Dim roomTypeCurrentRowIndex As Integer = RoomTypesDGVtwo.CurrentRow.Index
            Dim roomTypeID = RoomTypesDGVtwo.Item(0, roomTypeCurrentRowIndex).Value.ToString

            If Me.RoomNumberTxt.Text <> "" Then
                Dim roomNumber As String = Me.RoomNumberTxt.Text
                If Me.roomController.UpdateRoom(roomNumber, roomTypeID, Me.RoomIdTwo) Then
                    MessageBox.Show("Updated!", "Update room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.UpdateRoomBtnTwo.Enabled = False
                    Me.AddNewRoomBtn.Enabled = True
                    Me.RoomNumberTxt.Text = ""
                    Me.GetAllRooms()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Room button Two")
        End Try
    End Sub
End Class