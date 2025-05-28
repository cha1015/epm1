Public Class FormUpdateEventPlace
    Private _row As DataRow

    Public Sub New(row As DataRow)
        InitializeComponent()
        _row = row
    End Sub

    Private Sub FormUpdateEventPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _row Is Nothing Then
            MessageBox.Show("DataRow is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Debugging: log the columns to verify if 'features' and 'opening_hours' exist
        For Each column As DataColumn In _row.Table.Columns
            Debug.WriteLine("Column: " & column.ColumnName & " Value: " & _row(column).ToString())
        Next

        If _row IsNot Nothing Then
            txtPlaceID.Text = _row("place_id").ToString()
            txtEventPlace.Text = _row("event_place").ToString()
            txtEventType.Text = _row("event_type").ToString()
            txtCapacity.Text = _row("capacity").ToString()

            ' Check if the 'features' column exists before assigning its value
            If _row.Table.Columns.Contains("features") Then
                txtFeatures.Text = If(_row("features") IsNot DBNull.Value, _row("features").ToString(), String.Empty)
            Else
                txtFeatures.Text = String.Empty
                MessageBox.Show("Column 'features' not found in the data row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Check if the 'opening_hours' column exists before assigning its value
            If _row.Table.Columns.Contains("opening_hours") Then
                txtOpeningHours.Text = If(_row("opening_hours") IsNot DBNull.Value, _row("opening_hours").ToString(), String.Empty)
            Else
                txtOpeningHours.Text = String.Empty
                MessageBox.Show("Column 'opening_hours' not found in the data row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            txtPricePerDay.Text = _row("price_per_day").ToString()
            txtDescription.Text = _row("description").ToString()
            txtImageUrl.Text = _row("image_url").ToString()

            ' Ensure the 'closing_hours' and 'available_days' are also checked
            If _row.Table.Columns.Contains("closing_hours") Then
                txtClosingHours.Text = If(_row("closing_hours") IsNot DBNull.Value, _row("closing_hours").ToString(), String.Empty)
            Else
                txtClosingHours.Text = String.Empty
            End If

            If _row.Table.Columns.Contains("available_days") Then
                txtAvailableDays.Text = If(_row("available_days") IsNot DBNull.Value, _row("available_days").ToString(), String.Empty)
            Else
                txtAvailableDays.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtPlaceID.Text) Then
            MessageBox.Show("Please select an event place to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Format the opening and closing hours
        Dim openingHours As String = HelperValidation.FormatTime(txtOpeningHours.Text)
        Dim closingHours As String = HelperValidation.FormatTime(txtClosingHours.Text)
        If String.IsNullOrEmpty(openingHours) OrElse String.IsNullOrEmpty(closingHours) Then Exit Sub

        ' Prepare the update query
        Dim query As String = "UPDATE eventplace SET event_place = @event_place, event_type = @event_type, capacity = @capacity, features = @features, price_per_day = @price_per_day, description = @description, image_url = @image_url, opening_hours = @opening_hours, closing_hours = @closing_hours, available_days = @available_days WHERE place_id = @place_id"

        ' Prepare parameters for the query
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@place_id", txtPlaceID.Text},
            {"@event_place", txtEventPlace.Text},
            {"@event_type", txtEventType.Text},
            {"@capacity", If(Not IsNumeric(txtCapacity.Text), DBNull.Value, txtCapacity.Text)},
            {"@features", If(String.IsNullOrWhiteSpace(txtFeatures.Text), DBNull.Value, txtFeatures.Text)},
            {"@price_per_day", If(Not IsNumeric(txtPricePerDay.Text), DBNull.Value, txtPricePerDay.Text)},
            {"@description", txtDescription.Text},
            {"@image_url", txtImageUrl.Text},
            {"@opening_hours", openingHours},
            {"@closing_hours", closingHours},
            {"@available_days", txtAvailableDays.Text}
        }

        ' Execute the query to update the event place
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, parameters)
        If rowsAffected > 0 Then
            MessageBox.Show("Event place updated successfully.")
            ' Reload the event places in the Admin Center
            Dim formAdminCenter As New FormAdminCenter()
            formAdminCenter.LoadSearchResults()
        Else
            MessageBox.Show("Update failed. No rows were affected. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
