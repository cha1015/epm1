Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text
Imports System.IO

Public Class HelperBooking
    Public Shared Function GetCustomerData(userId As Integer) As DataTable
        Dim query As String = "SELECT name, birthday, sex, address FROM Customers WHERE user_id = @userId"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userId", userId}}
        Return DBHelper.GetDataTable(query, parameters)
    End Function

    Public Shared Function GetBookedDates(placeId As Integer) As List(Of Date)
        Dim bookedDates As New List(Of Date)
        Dim query As String = "SELECT DISTINCT event_date FROM Bookings WHERE place_id = @place_id"

        Try
            Using connection As MySqlConnection = DBHelper.GetConnection()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@place_id", placeId)
                    connection.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            bookedDates.Add(Convert.ToDateTime(reader("event_date")))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving booked dates: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bookedDates
    End Function


    ' ------------------ UI & Validation Methods ------------------
    Public Shared Sub LoadCustomerData(userId As Integer, txtName As TextBox, dtpBirthday As DateTimePicker, cmbSex As ComboBox, txtAddress As TextBox)
        Dim dt As DataTable = GetCustomerData(userId)

        If dt.Rows.Count > 0 Then
            txtName.Text = If(String.IsNullOrWhiteSpace(dt.Rows(0)("name").ToString()), "Not Provided", dt.Rows(0)("name").ToString())

            Dim birthdayValue As Object = dt.Rows(0)("birthday")
            If birthdayValue IsNot DBNull.Value Then
                dtpBirthday.Value = Convert.ToDateTime(birthdayValue)
            Else
                dtpBirthday.Value = Date.Today
            End If

            cmbSex.Text = If(String.IsNullOrWhiteSpace(dt.Rows(0)("sex").ToString()), "Not Specified", dt.Rows(0)("sex").ToString())
            txtAddress.Text = If(String.IsNullOrWhiteSpace(dt.Rows(0)("address").ToString()), "No Address Provided", dt.Rows(0)("address").ToString())
        Else
            MessageBox.Show("Customer information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
