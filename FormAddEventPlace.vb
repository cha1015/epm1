Public Class FormAddEventPlace
    Private Function EventPlaceExists(eventPlaceName As String) As Boolean
        Dim result As Object = DBHelper.ExecuteScalarQuery("SELECT COUNT(*) FROM eventplace WHERE event_place=@name",
                                                            New Dictionary(Of String, Object) From {{"@name", eventPlaceName}})
        Return Convert.ToInt32(result) > 0
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not HelperValidation.ValidateOpeningClosingHours(txtOpeningHours.Text, txtClosingHours.Text) Then Exit Sub

        Dim openingHours As String = HelperValidation.FormatTime(txtOpeningHours.Text)
        Dim closingHours As String = HelperValidation.FormatTime(txtClosingHours.Text)
        If String.IsNullOrEmpty(openingHours) OrElse String.IsNullOrEmpty(closingHours) Then Exit Sub

        If EventPlaceExists(txtEventPlace.Text) Then
            MessageBox.Show("Event place already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        DBHelper.ExecuteQuery("INSERT INTO eventplace (event_place, event_type, capacity, features, price_per_day, description, image_url, opening_hours, closing_hours, available_days) " &
                              "VALUES (@event_place, @event_type, @capacity, @features, @price_per_day, @description, @image_url, @opening_hours, @closing_hours, @available_days)",
                              New Dictionary(Of String, Object) From {
                                  {"@event_place", txtEventPlace.Text},
                                  {"@event_type", txtEventType.Text},
                                  {"@capacity", If(Not IsNumeric(txtCapacity.Text), DBNull.Value, txtCapacity.Text)},
                                  {"@features", txtFeatures.Text},
                                  {"@price_per_day", If(Not IsNumeric(txtPricePerDay.Text), DBNull.Value, txtPricePerDay.Text)},
                                  {"@description", txtDescription.Text},
                                  {"@image_url", txtImageUrl.Text},
                                  {"@opening_hours", openingHours},
                                  {"@closing_hours", closingHours},
                                  {"@available_days", txtAvailableDays.Text}
                              })
        Dim formAdminCenter As New FormAdminCenter()
        formAdminCenter.LoadSearchResults()

    End Sub
End Class