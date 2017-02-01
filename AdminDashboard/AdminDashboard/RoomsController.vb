Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RoomsController : Inherits SqlControl

    Delegate Sub DisplayRoomTypesInfos(ByVal id As Integer, ByVal roomTypeName As String, ByVal roomPrice As Decimal)
    Delegate Sub DisplayRoomTypesInfosTwo(ByVal id As Integer, ByVal roomTypeName As String, ByVal roomPrice As Decimal)
    Delegate Sub DisplayRooms(ByVal id As Integer, ByVal roomNumber As String, ByVal roomType As String, ByVal roomPrice As String)

    Public Sub GetAllRoomTypes(ByVal displayRoomTypesInfos As DisplayRoomTypesInfos)
        Try

            Dim getAllRoomTypesQuery As String = "SELECT * FROM Room_types"
            Dim sqlCommand As New SqlCommand(getAllRoomTypesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayRoomTypesInfos(reader("rm_type_ID"), reader("rm_type_name"), reader("rm_price"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetAllRoomTypesTwo(ByVal displayRoomTypesInfosTwo As DisplayRoomTypesInfosTwo)
        Try

            Dim getAllRoomTypesQuery As String = "SELECT * FROM Room_types"
            Dim sqlCommand As New SqlCommand(getAllRoomTypesQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayRoomTypesInfosTwo(reader("rm_type_ID"), reader("rm_type_name"), reader("rm_price"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function InsertNewRoomType(ByVal roomName As String, ByVal roomPrice As Decimal) As Boolean

        Try
            Dim insertRoomTypeQuery As String = "INSERT INTO Room_types(rm_type_name, rm_price) VALUES('" & roomName & "', " & roomPrice & ")"

            If Me.ExecuteCommand(insertRoomTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert New Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function DeleteRoomType(ByVal roomId As Integer) As Boolean

        Try
            Dim deleteRoomTypeQuery As String = "DELETE FROM Room_types WHERE rm_type_ID=" & roomId

            If Me.ExecuteCommand(deleteRoomTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function UpdateRoomType(ByVal roomId As Integer, ByVal roomName As String, ByVal roomPrice As Decimal) As Boolean

        Try
            Dim updateRoomTypeQuery As String = "UPDATE Room_types SET rm_type_name='" & roomName & "', rm_price=" & roomPrice & " WHERE rm_type_ID=" & roomId

            If Me.ExecuteCommand(updateRoomTypeQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function


    Public Function InsertNewRoom(ByVal roomNumber As String, ByVal roomTypeID As Integer) As Boolean

        Try
            Dim insertRoomQuery As String = "INSERT INTO Rooms(rm_No, rm_type_ID) VALUES('" & roomNumber & "', " & roomTypeID & ")"

            If Me.ExecuteCommand(insertRoomQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert New Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Sub GetAllRooms(ByRef displayRooms As DisplayRooms)
        Try

            Dim getAllRoomsQuery As String = "SELECT Rooms.rm_ID, Rooms.rm_No, Room_types.rm_type_name, Room_types.rm_price FROM Rooms, Room_types WHERE Rooms.rm_type_ID = Room_types.rm_type_ID"
            Dim sqlCommand As New SqlCommand(getAllRoomsQuery, Me.Connection)

            If Me.Connection.State = False Then
                Me.Connection.Open()
            End If

            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            Try
                While (reader.Read())
                    displayRooms(reader("rm_ID"), reader("rm_no"), reader("rm_type_name"), reader("rm_price"))
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (2)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Clossing connections
                reader.Close()
                sqlCommand.Dispose()
                Me.Connection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: 0x101 - Get All room types (1)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function DeleteRoom(ByVal roomId As Integer) As Boolean

        Try
            Dim deleteRoomQuery As String = "DELETE FROM Rooms WHERE rm_ID=" & roomId

            If Me.ExecuteCommand(deleteRoomQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function UpdateRoom(ByVal roomNumber As String, ByVal roomTypeID As Integer, ByVal roomId As Integer) As Boolean

        Try
            Dim updateRoomQuery As String = "UPDATE Rooms SET rm_No='" & roomNumber & "', rm_type_ID=" & roomTypeID & " WHERE rm_ID=" & roomId

            If Me.ExecuteCommand(updateRoomQuery) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Room Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
End Class
