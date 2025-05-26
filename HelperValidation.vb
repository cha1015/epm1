Imports System.Globalization
Imports System.Data

Public Class HelperValidation
    ' ------------------ Utility Helper ------------------
    Private Shared Function GetDefaultLabelText(control As Control) As String
        Dim lbl As Label = TryCast(control.Tag, Label)
        If lbl IsNot Nothing Then
            Return lbl.Text
        End If
        Return ""
    End Function
    ' ------------------ Field Indicator Setup ------------------
    ' This section sets the default labels for required fields.
    Public Shared Sub ApplyFieldIndicators(labelControls As Label(), labelTexts As String())
        For i As Integer = 0 To labelControls.Length - 1
            labelControls(i).Text = labelTexts(i)
            labelControls(i).ForeColor = SystemColors.ControlText
        Next
    End Sub

    ' Show an asterisk (or add it if missing) on required fields in real time.
    Public Shared Sub ShowAsteriskOnMissedFields(fieldControls As TextBox(), labelControls As Label(), labelTexts As String())
        For i As Integer = 0 To fieldControls.Length - 1
            If String.IsNullOrWhiteSpace(fieldControls(i).Text) Then
                labelControls(i).Text = $"{labelTexts(i)} *"
            End If
        Next
    End Sub

    ' Remove the asterisk when the user enters input.
    Public Shared Sub RemoveAsteriskOnInput(sender As Object, labelControls As Label(), labelTexts As String())
        Dim txtBox As TextBox = TryCast(sender, TextBox)
        If txtBox IsNot Nothing Then
            Dim index As Integer = Array.IndexOf(labelControls.Select(Function(lbl) lbl.Name).ToArray(), txtBox.Tag?.ToString())
            If index >= 0 Then labelControls(index).Text = labelTexts(index)
        End If
    End Sub

    ' Update the labels in real time as fields are filled or left empty.
    Public Shared Sub ValidateFieldsInRealTime(fieldControls As TextBox(), labelControls As Label(), labelTexts As String())
        For i As Integer = 0 To fieldControls.Length - 1
            labelControls(i).Text = If(String.IsNullOrWhiteSpace(fieldControls(i).Text),
                                         $"{labelTexts(i)} *",
                                         labelTexts(i))
        Next
    End Sub

    ' ------------------ Combined Validation Error Handling ------------------
    ' Combines an asterisk (indicating a required field) with a red highlight on the control.
    Private Shared Sub MarkFieldInvalid(targetControl As Control, defaultLabelText As String, Optional errorMsg As String = "")
        Dim labelIndicator As Label = TryCast(targetControl.Tag, Label)
        If labelIndicator IsNot Nothing Then
            labelIndicator.Text = $"{defaultLabelText} *"
            labelIndicator.ForeColor = Color.Red
            labelIndicator.Visible = True
        End If
        targetControl.BackColor = Color.LightPink
    End Sub

    ' Clears the red highlight and restores the original label text.
    Public Shared Sub ClearFieldError(targetControl As Control, defaultLabelText As String)
        Dim labelIndicator As Label = TryCast(targetControl.Tag, Label)
        If labelIndicator IsNot Nothing Then
            labelIndicator.Text = defaultLabelText
            labelIndicator.ForeColor = SystemColors.ControlText
            labelIndicator.Visible = True
        End If
        targetControl.BackColor = Color.White
    End Sub

    ' ------------------ Validate Numeric Fields ------------------
    Public Shared Function IsValidNumericField(txtControl As TextBox, errorLabel As Label, errorMessage As String) As Boolean
        ' Retrieve the default text from the error label.
        Dim defaultText As String = errorLabel.Text

        If String.IsNullOrWhiteSpace(txtControl.Text) OrElse Not IsNumeric(txtControl.Text) Then
            MarkFieldInvalid(txtControl, defaultText, errorMessage)
            Return False
        End If

        ClearFieldError(txtControl, defaultText)
        Return True
    End Function


    ' ------------------ Validate Date Selection ------------------
    Public Shared Function IsValidDateSelection(eventStartDate As DateTimePicker, eventEndDate As DateTimePicker) As Boolean
        ' Ensure the event start date is not in the past.
        If eventStartDate.Value.Date < Date.Today Then
            MarkFieldInvalid(eventStartDate, eventStartDate.Tag?.ToString() & "", "Start date cannot be in the past.")
            Return False
        End If

        ' Ensure the event end date comes after the start date.
        If eventEndDate.Value.Date < eventStartDate.Value.Date Then
            MarkFieldInvalid(eventEndDate, eventEndDate.Tag?.ToString() & "", "End date must follow the start date.")
            Return False
        End If

        ClearFieldError(eventStartDate, eventStartDate.Tag?.ToString() & "")
        ClearFieldError(eventEndDate, eventEndDate.Tag?.ToString() & "")
        Return True
    End Function

    ' ------------------ Validate Customer Information ------------------
    Public Shared Function IsValidCustomerInfo(txtName As TextBox, dtpBirthday As DateTimePicker, cmbSex As ComboBox,
                                               txtAddress As TextBox, Optional nameDefault As String = "", Optional birthdayDefault As String = "",
                                               Optional sexDefault As String = "", Optional addressDefault As String = "") As Boolean
        If nameDefault = "" Then nameDefault = GetDefaultLabelText(txtName)
        If birthdayDefault = "" Then birthdayDefault = GetDefaultLabelText(dtpBirthday)
        If sexDefault = "" Then sexDefault = GetDefaultLabelText(cmbSex)
        If addressDefault = "" Then addressDefault = GetDefaultLabelText(txtAddress)

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MarkFieldInvalid(txtName, nameDefault, "Customer name is required.")
            Return False
        End If

        If dtpBirthday.Value.Date > Date.Today Then
            MarkFieldInvalid(dtpBirthday, birthdayDefault, "Birthday cannot be in the future.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbSex.Text) Then
            MarkFieldInvalid(cmbSex, sexDefault, "Please select a gender.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MarkFieldInvalid(txtAddress, addressDefault, "Address is required.")
            Return False
        End If

        ClearFieldError(txtName, nameDefault)
        ClearFieldError(dtpBirthday, birthdayDefault)
        ClearFieldError(cmbSex, sexDefault)
        ClearFieldError(txtAddress, addressDefault)
        Return True
    End Function

    ' ------------------ Validate Numeric Input in KeyPress ------------------
    Public Shared Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ------------------ Validate Time Selection ------------------
    Public Shared Function IsValidTimeSelection(cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                                  cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                                  openingHours As String, closingHours As String) As Boolean
        Dim timeFormat As String = "h:mm tt"
        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime

        ' Check for complete start time selection.
        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) Then
            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", "Start time is required.")
            Return False
        End If

        ' Check for complete end time selection.
        If String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            MarkFieldInvalid(cbEndHour, cbEndHour.Tag?.ToString() & "", "End time is required.")
            Return False
        End If

        Dim startInput As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim endInput As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"
        If Not DateTime.TryParseExact(startInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) Then
            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", "Invalid start time. Use h:mm AM/PM.")
            Return False
        End If
        If Not DateTime.TryParseExact(endInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            MarkFieldInvalid(cbEndHour, cbEndHour.Tag?.ToString() & "", "Invalid end time. Use h:mm AM/PM.")
            Return False
        End If

        ' Assume events spanning midnight.
        If eventEndTime < eventStartTime Then
            eventEndTime = eventEndTime.AddDays(1)
        End If

        Dim openingTime As DateTime, closingTime As DateTime
        If Not DateTime.TryParse(openingHours, openingTime) Then
            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", "Invalid opening hours format.")
            Return False
        End If
        If Not DateTime.TryParse(closingHours, closingTime) Then
            MarkFieldInvalid(cbEndHour, cbEndHour.Tag?.ToString() & "", "Invalid closing hours format.")
            Return False
        End If

        ' Ensure event time is within operating hours.
        If eventStartTime < openingTime Then
            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", $"Opens at {openingTime.ToString("h:mm tt")}.")
            Return False
        End If
        If eventEndTime > closingTime Then
            MarkFieldInvalid(cbEndHour, cbEndHour.Tag?.ToString() & "", $"Closes at {closingTime.ToString("h:mm tt")}.")
            Return False
        End If

        ClearFieldError(cbStartHour, cbStartHour.Tag?.ToString() & "")
        ClearFieldError(cbEndHour, cbEndHour.Tag?.ToString() & "")
        Return True
    End Function

    ' ------------------ Validate Booking Date Conflicts ------------------
    Public Shared Function IsDateConflict(placeId As Integer, eventStart As Date, eventEnd As Date, dtpEventDateStart As DateTimePicker) As Boolean
        Dim query As String = "SELECT event_date FROM Bookings WHERE place_id = @PlaceId AND (event_date BETWEEN @EventDateStart AND @EventDateEnd)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@PlaceId", placeId},
            {"@EventDateStart", eventStart},
            {"@EventDateEnd", eventEnd}
        }

        Dim conflictDates As DataTable = DBHelper.GetDataTable(query, params)
        If conflictDates.Rows.Count > 0 Then
            MarkFieldInvalid(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "", "Selected date range is unavailable.")
            Return True
        End If

        ClearFieldError(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "")
        Return False
    End Function

    ' ------------------ Validate Booking Details with Tab Selection Logic ------------------
    Public Shared Sub ValidateBooking(e As TabControlCancelEventArgs, tcDetails As TabControl,
                                        tpCustomerDetails As TabPage, tpPaymentDetails As TabPage,
                                        cbEventType As ComboBox, txtNumGuests As TextBox,
                                        dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                        cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                        cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                        chkOutsideAvailableHours As CheckBox, txtCustomerName As TextBox,
                                        dtpBirthday As DateTimePicker, cmbSex As ComboBox, txtAddress As TextBox,
                                        openingHours As String, closingHours As String, placeId As Integer)
        ' Validate time selection first.
        If Not IsValidTimeSelection(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, openingHours, closingHours) Then
            e.Cancel = True
            Exit Sub
        End If

        ' ------------------ Booking Tab - Customer Details ------------------
        If e.TabPage Is tpCustomerDetails Then
            If String.IsNullOrWhiteSpace(cbEventType.Text) OrElse String.IsNullOrWhiteSpace(txtNumGuests.Text) OrElse Not IsNumeric(txtNumGuests.Text) OrElse
               dtpEventDateStart.Value.Date < Date.Today OrElse dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date Then
                MarkFieldInvalid(txtNumGuests, txtNumGuests.Tag?.ToString() & "", "Complete all fields before proceeding.")
                e.Cancel = True
                Exit Sub
            End If

            Dim timeFormat As String = "h:mm tt"
            Dim eventStartTime As DateTime = DateTime.ParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat, CultureInfo.InvariantCulture)
            Dim eventEndTime As DateTime = DateTime.ParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture)
            Dim openingTime As DateTime = DateTime.Parse(openingHours)
            Dim closingTime As DateTime = DateTime.Parse(closingHours)

            If closingTime < openingTime Then closingTime = closingTime.AddDays(1)
            If eventEndTime < eventStartTime Then eventEndTime = eventEndTime.AddDays(1)

            If (eventStartTime < openingTime OrElse eventEndTime > closingTime) AndAlso Not chkOutsideAvailableHours.Checked Then
                MarkFieldInvalid(chkOutsideAvailableHours, chkOutsideAvailableHours.Tag?.ToString() & "",
                                 "Selected time is outside available hours.")
                e.Cancel = True
                Exit Sub
            End If
        End If

        ' ------------------ Payment Tab - Customer Information ------------------
        If e.TabPage Is tpPaymentDetails Then
            If Not IsValidCustomerInfo(txtCustomerName, dtpBirthday, cmbSex, txtAddress,
                                        txtCustomerName.Tag?.ToString() & "",
                                        dtpBirthday.Tag?.ToString() & "",
                                        cmbSex.Tag?.ToString() & "",
                                        txtAddress.Tag?.ToString() & "") Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    ' ------------------ Time Format Conversion ------------------
    Public Shared Function FormatTime(inputTime As String) As String
        Try
            Dim parsedTime As DateTime = DateTime.ParseExact(inputTime, "h:mm tt", CultureInfo.InvariantCulture)
            Return parsedTime.ToString("HH:mm:ss")
        Catch ex As FormatException
            Return String.Empty
        End Try
    End Function

    ' ------------------ Validate Opening and Closing Hours ------------------
    Public Shared Function ValidateOpeningClosingHours(openingTimeStr As String, closingTimeStr As String) As Boolean
        Dim openingHours As String = FormatTime(openingTimeStr)
        Dim closingHours As String = FormatTime(closingTimeStr)

        ' Inline error indications could be added here instead of MessageBox.
        If String.IsNullOrEmpty(openingHours) OrElse String.IsNullOrEmpty(closingHours) Then
            Return False
        End If

        Dim openDt As DateTime = DateTime.ParseExact(openingHours, "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim closeDt As DateTime = DateTime.ParseExact(closingHours, "HH:mm:ss", CultureInfo.InvariantCulture)

        If closeDt <= openDt Then
            Return False
        End If

        Return True
    End Function

    ' ------------------ Validate Booking Inputs (Standalone) ------------------
    Public Shared Function ValidateBookingInputs(cbEventType As ComboBox, dtpEventDateStart As DateTimePicker,
                                                   dtpEventDateEnd As DateTimePicker,
                                                   cbStartHour As ComboBox, cbStartMinutes As ComboBox,
                                                   cbStartAMPM As ComboBox, cbEndHour As ComboBox,
                                                   cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                                   chkOutsideAvailableHours As CheckBox, OpeningHours As String,
                                                   ClosingHours As String, PlaceId As Integer) As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(cbEventType.Text) Then
            MarkFieldInvalid(cbEventType, cbEventType.Tag?.ToString() & "", "Event type is required.")
            isValid = False
        Else
            ClearFieldError(cbEventType, cbEventType.Tag?.ToString() & "")
        End If

        If dtpEventDateStart.Value.Date < Date.Today Then
            MarkFieldInvalid(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "", "Start date is in the past.")
            isValid = False
        Else
            ClearFieldError(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "")
        End If

        If dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date Then
            MarkFieldInvalid(dtpEventDateEnd, dtpEventDateEnd.Tag?.ToString() & "", "End date must follow start date.")
            isValid = False
        Else
            ClearFieldError(dtpEventDateEnd, dtpEventDateEnd.Tag?.ToString() & "")
        End If

        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", "Complete time selection is required.")
            isValid = False
        Else
            ClearFieldError(cbStartHour, cbStartHour.Tag?.ToString() & "")
        End If

        Dim checkQuery As String = "SELECT COUNT(*) FROM Bookings WHERE place_id = @PlaceId AND (event_date BETWEEN @EventDateStart AND @EventDateEnd)"
        Dim checkParams As New Dictionary(Of String, Object) From {
            {"@PlaceId", PlaceId},
            {"@EventDateStart", dtpEventDateStart.Value.Date},
            {"@EventDateEnd", dtpEventDateEnd.Value.Date}
        }
        Dim existingBookings As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(checkQuery, checkParams))
        If existingBookings > 0 Then
            MarkFieldInvalid(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "", "Venue booked for selected dates.")
            isValid = False
        Else
            ClearFieldError(dtpEventDateStart, dtpEventDateStart.Tag?.ToString() & "")
        End If

        Dim eventStartTime As DateTime, eventEndTime As DateTime, openingTime As DateTime, closingTime As DateTime
        Dim timeFormat As String = "h:mm tt"

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat,
                                      CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) OrElse
           Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                                      CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) OrElse
           Not DateTime.TryParse(OpeningHours, openingTime) OrElse
           Not DateTime.TryParse(ClosingHours, closingTime) Then

            MarkFieldInvalid(cbStartHour, cbStartHour.Tag?.ToString() & "", "Invalid time format.")
            isValid = False
        Else
            ClearFieldError(cbStartHour, cbStartHour.Tag?.ToString() & "")
        End If

        If (eventStartTime < openingTime OrElse eventEndTime > closingTime) AndAlso Not chkOutsideAvailableHours.Checked Then
            MarkFieldInvalid(chkOutsideAvailableHours, chkOutsideAvailableHours.Tag?.ToString() & "", "Time outside available hours.")
            isValid = False
        Else
            ClearFieldError(chkOutsideAvailableHours, chkOutsideAvailableHours.Tag?.ToString() & "")
        End If

        Return isValid
    End Function

    ' ------------------ Prevent Booked Date in Date Picker ------------------
    Public Shared Sub PreventBookedDate(picker As DateTimePicker, bookedDates As List(Of Date), lblDateWarning As Label)
        If bookedDates.Contains(picker.Value.Date) Then
            lblDateWarning.Text = "Oops! That date is unavailable. Please choose another."
            lblDateWarning.Visible = True

            Dim nextAvailableDate As Date = picker.Value.AddDays(1)
            While bookedDates.Contains(nextAvailableDate)
                nextAvailableDate = nextAvailableDate.AddDays(1)
            End While
            picker.Value = nextAvailableDate
            lblDateWarning.Visible = False
        End If
    End Sub

    ' ------------------ Validate Customer Age ------------------
    Public Shared Function ValidateCustomerAge(dtpBirthday As DateTimePicker) As Boolean
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1

        If age < 18 Then
            MarkFieldInvalid(dtpBirthday, dtpBirthday.Tag?.ToString() & "", "Must be 18 or older to book.")
            Return False
        End If

        ClearFieldError(dtpBirthday, dtpBirthday.Tag?.ToString() & "")
        Return True
    End Function

End Class
