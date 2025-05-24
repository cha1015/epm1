Imports System.Globalization

Public Class HelperValidation
    ' ------------------ Helper Method for Validation Messages ------------------
    Private Shared Sub ShowValidationError(targetControl As Control, message As String)
        If targetControl IsNot Nothing AndAlso TypeOf targetControl.Tag Is Label Then
            Dim errorLabel As Label = CType(targetControl.Tag, Label)
            errorLabel.Text = message
            errorLabel.ForeColor = Color.Red
        Else
            targetControl.BackColor = Color.LightPink
        End If
    End Sub


    ' ------------------ Validate Date Selection ------------------
    Public Shared Function IsValidDateSelection(eventStartDate As DateTimePicker, eventEndDate As DateTimePicker) As Boolean
        If eventStartDate.Value.Date < Date.Today Then
            ShowValidationError(eventStartDate, "Event start date cannot be in the past.")
            Return False
        End If

        If eventEndDate.Value.Date < eventStartDate.Value.Date Then
            ShowValidationError(eventEndDate, "Event end date must be after the start date.")
            Return False
        End If

        Return True
    End Function

    ' ------------------ Validate Customer Information ------------------
    Public Shared Function IsValidCustomerInfo(txtName As TextBox, dtpBirthday As DateTimePicker, cmbSex As ComboBox, txtAddress As TextBox) As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            ShowValidationError(txtName, "Customer name is required.")
            Return False
        End If

        If dtpBirthday.Value.Date > Date.Today Then
            ShowValidationError(dtpBirthday, "Birthday cannot be in the future.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbSex.Text) Then
            ShowValidationError(cmbSex, "Please select a gender.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            ShowValidationError(txtAddress, "Address is required.")
            Return False
        End If

        Return True
    End Function

    ' ------------------ Validate Time Selection ------------------
    Public Shared Function IsValidTimeSelection(cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                            cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                            openingHours As String, closingHours As String) As Boolean
        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime
        Dim openingTime As DateTime = DateTime.Parse(openingHours)
        Dim closingTime As DateTime = DateTime.Parse(closingHours)

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) OrElse
       Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            ShowValidationError(cbEndHour, "Invalid time format. Use HH:MM AM/PM.")
            Return False
        End If

        If eventEndTime < eventStartTime Then
            ShowValidationError(cbEndHour, "End time must be later than start time.")
            Return False
        End If

        If eventStartTime < openingTime Then
            ShowValidationError(cbStartHour, $"Opening hours start at {openingTime.ToString("h:mm tt")}. Adjust your start time.")
            Return False
        End If

        If eventEndTime > closingTime Then
            ShowValidationError(cbEndHour, $"Closing hours end at {closingTime.ToString("h:mm tt")}. Adjust your end time.")
            Return False
        End If

        Return True
    End Function


    ' ------------------ Check for Booking Date Conflicts ------------------
    Public Shared Function IsDateConflict(placeId As Integer, eventStart As Date, eventEnd As Date, dtpEventDateStart As DateTimePicker) As Boolean
        Dim query As String = "SELECT event_date FROM Bookings WHERE place_id = @PlaceId AND (event_date BETWEEN @EventDateStart AND @EventDateEnd)"
        Dim params As New Dictionary(Of String, Object) From {
        {"@PlaceId", placeId},
        {"@EventDateStart", eventStart},
        {"@EventDateEnd", eventEnd}
    }

        Dim conflictDates As DataTable = DBHelper.GetDataTable(query, params)
        If conflictDates.Rows.Count > 0 Then
            ShowValidationError(dtpEventDateStart, "This date range is unavailable. Please select another date.")
            Return True
        End If

        Return False
    End Function

    ' ------------------ Validate Booking Details with Tab Selection Logic ------------------
    Public Shared Sub ValidateBooking(e As TabControlCancelEventArgs, tcDetails As TabControl, tpCustomerDetails As TabPage, tpPaymentDetails As TabPage,
                                      cbEventType As ComboBox, txtNumGuests As TextBox, dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                      cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                      cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                      chkOutsideAvailableHours As CheckBox, txtCustomerName As TextBox, dtpBirthday As DateTimePicker, cmbSex As ComboBox,
                                      txtAddress As TextBox, openingHours As String, closingHours As String, placeId As Integer)

        ' Validate Time Formatting (Remove redundancy)
        If Not IsValidTimeSelection(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, openingHours, closingHours) Then
            e.Cancel = True
            Exit Sub
        End If

        ' Validate Event and Customer Details Based on the Selected Tab
        If e.TabPage Is tpCustomerDetails Then
            If String.IsNullOrWhiteSpace(cbEventType.Text) OrElse String.IsNullOrWhiteSpace(txtNumGuests.Text) OrElse Not IsNumeric(txtNumGuests.Text) OrElse
               dtpEventDateStart.Value.Date < Date.Today OrElse dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date Then
                ShowValidationError(txtNumGuests, "Please complete all fields before proceeding.")
                e.Cancel = True
                Exit Sub
            End If

            ' Outside Available Hours Check
            Dim eventStartTime As DateTime = DateTime.ParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", "h:mm tt", CultureInfo.InvariantCulture)
            Dim eventEndTime As DateTime = DateTime.ParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", "h:mm tt", CultureInfo.InvariantCulture)
            Dim openingTime As DateTime = DateTime.Parse(openingHours)
            Dim closingTime As DateTime = DateTime.Parse(closingHours)

            If closingTime < openingTime Then closingTime = closingTime.AddDays(1)
            If eventEndTime < eventStartTime Then eventEndTime = eventEndTime.AddDays(1)

            If (eventStartTime < openingTime OrElse eventEndTime > closingTime) AndAlso Not chkOutsideAvailableHours.Checked Then
                ShowValidationError(chkOutsideAvailableHours, "Your selected time is outside available hours. Adjust your schedule or check 'Book outside available hours' to proceed.")
                e.Cancel = True
                Exit Sub
            End If
        End If

        If e.TabPage Is tpPaymentDetails Then
            If Not IsValidCustomerInfo(txtCustomerName, dtpBirthday, cmbSex, txtAddress) Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

End Class
