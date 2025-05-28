Public Class FormUpdateEventPlace
    ' Assume this property is set by FormAdminCenter before showing this form.
    Public Property SelectedPlaceId As Integer

    Private Sub FormUpdateEventPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the event place data using a parameterized SELECT query.
        Dim query As String = "SELECT * FROM eventplace WHERE place_id = @place_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@place_id", SelectedPlaceId}
        }

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            ' Populate controls with values from the database.
            txtPlaceID.Text = row("place_id").ToString()
            txtEventPlace.Text = row("event_place").ToString()
            txtEventType.Text = row("event_type").ToString()
            txtCapacity.Text = row("capacity").ToString()

            ' Converting price to a decimal and then formatting it with two decimals.
            txtPricePerDay.Text = Convert.ToDecimal(row("price_per_Day")).ToString("F2")
            txtFeatures.Text = row("features").ToString()
            txtImageUrl.Text = row("image_url").ToString()

            ' For time fields, we convert to DateTime. You might add TryParseExact similar to FormBooking
            ' if your data might have single or double digit hours.
            txtOpeningHours.Text = Convert.ToDateTime(row("opening_hours")).ToString("HH:mm")
            txtClosingHours.Text = Convert.ToDateTime(row("closing_hours")).ToString("HH:mm")

            txtAvailableDays.Text = row("available_days").ToString()
            txtDescription.Text = row("description").ToString()
        Else
            MessageBox.Show("No event place record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Build the UPDATE SQL command using parameters.
        Dim query As String = "UPDATE eventplace SET 
                                event_place = @event_place, 
                                event_type = @event_type, 
                                capacity = @capacity, 
                                features = @features, 
                                price_per_Day = @price_per_Day, 
                                description = @description, 
                                image_url = @image_url, 
                                opening_hours = @opening_hours, 
                                closing_hours = @closing_hours, 
                                available_days = @available_days 
                             WHERE place_id = @place_id"

        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@event_place", txtEventPlace.Text)
        parameters.Add("@event_type", txtEventType.Text)
        parameters.Add("@capacity", Convert.ToInt32(txtCapacity.Text))
        parameters.Add("@features", txtFeatures.Text)
        parameters.Add("@price_per_Day", Convert.ToDecimal(txtPricePerDay.Text))
        parameters.Add("@description", txtDescription.Text)
        parameters.Add("@image_url", txtImageUrl.Text)

        ' Convert the provided times to strings in "HH:mm:ss" format.
        ' You can extend this by checking formats (as in FormBooking) if needed.
        parameters.Add("@opening_hours", DateTime.Parse(txtOpeningHours.Text).ToString("HH:mm:ss"))
        parameters.Add("@closing_hours", DateTime.Parse(txtClosingHours.Text).ToString("HH:mm:ss"))

        ' available_days should be entered in a valid format matching your SET definition.
        parameters.Add("@available_days", txtAvailableDays.Text)
        parameters.Add("@place_id", Convert.ToInt32(txtPlaceID.Text))

        ' Execute the update command and notify the admin.
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, parameters)

        If rowsAffected > 0 Then
            MessageBox.Show("Event Place details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Optionally, refresh the admin center or close this form.
            Me.Close()
        Else
            MessageBox.Show("Failed to update event place details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
