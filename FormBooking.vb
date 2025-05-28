Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Globalization
Imports System.IO
Imports System
Public Class FormBooking
    ' ------------------ Properties ------------------
    Public Property PlaceId As Integer
    Public Property EventPlaceName As String
    Public Property EventPlaceCapacity As Integer
    Public Property BasePricePerDay As Decimal
    Public Property EventPlaceFeatures As String
    Public Property EventVenueType As String
    Public Property OpeningHours As String
    Public Property ClosingHours As String
    Public Property AvailableDays As String
    Public Property EventPlaceDescription As String
    Public Property EventTime As String
    Public Property EventPlaceImageUrl As String

    Private _customerId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Dim bookedDates As New List(Of Date)
    ' ------------------ Constructor ------------------
    Public Sub New(customerId As Integer, placeId As Integer)
        InitializeComponent()
        _customerId = customerId
        Me.PlaceId = placeId
    End Sub


    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateWarning.Visible = False

        lblEventPlace.Text = EventPlaceName
        lblPlaceIDContainer.Text = PlaceId.ToString()
        lblCapacityContainer.Text = EventPlaceCapacity.ToString()
        lblPricePerDayContainer.Text = "₱" & BasePricePerDay.ToString("F2")
        lblFeaturesContainer.Text = EventPlaceFeatures
        lblDescriptionContainer.Text = EventPlaceDescription

        lblHoursContainer.Text = If(String.IsNullOrWhiteSpace(OpeningHours) OrElse String.IsNullOrWhiteSpace(ClosingHours),
            "N/A",
            $"{ConvertTo12HourFormat(OpeningHours)} - {ConvertTo12HourFormat(ClosingHours)}")

        lblAvailableDaysContainer.Text = $"Available: {HelperEvent.FormatAvailableDays(AvailableDays)}"

        dtpEventDateStart.Value = Date.Today
        dtpEventDateStart.MinDate = Date.Today
        dtpEventDateEnd.MinDate = Date.Today
        cbSameDayEvent.Checked = True
        dtpEventDateEnd.Value = dtpEventDateStart.Value
        dtpEventDateEnd.Enabled = False
        lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()

        HelperDatabase.PopulateEventTypeCombo(EventPlaceName, cbEventType)
        bookedDates = HelperDatabase.LoadBookedDates(PlaceId)

        Dim lastBooking As DataTable = HelperDatabase.GetLastBooking(CurrentUser.UserID)
        If lastBooking.Rows.Count > 0 Then
            cbEventType.Text = lastBooking.Rows(0)("event_type").ToString()
            txtNumGuests.Text = lastBooking.Rows(0)("num_guests").ToString()

            Dim eventTime As TimeSpan = Convert.ToDateTime(lastBooking.Rows(0)("event_time")).TimeOfDay
            Dim eventEndTime As TimeSpan = If(lastBooking.Rows(0)("event_end_time") Is DBNull.Value, TimeSpan.Zero, Convert.ToDateTime(lastBooking.Rows(0)("event_end_time")).TimeOfDay)

            ' Format using two-digit hour, so it matches the combobox items (e.g., "08")
            cbStartHour.Text = eventTime.Hours.ToString("00")
            cbStartMinutes.Text = eventTime.Minutes.ToString("00")
            cbStartAMPM.Text = If(eventTime.Hours < 12, "AM", "PM")

            If eventEndTime <> TimeSpan.Zero Then
                cbEndHour.Text = eventEndTime.Hours.ToString("00")
                cbEndMinutes.Text = eventEndTime.Minutes.ToString("00")
                cbEndAMPM.Text = If(eventEndTime.Hours < 12, "AM", "PM")
            Else
                cbEndHour.Text = "12"
                cbEndMinutes.Text = "00"
                cbEndAMPM.Text = "PM"
            End If

            chkCatering.Checked = Convert.ToBoolean(lastBooking.Rows(0)("catering"))
            chkClown.Checked = Convert.ToBoolean(lastBooking.Rows(0)("clown"))
            chkSinger.Checked = Convert.ToBoolean(lastBooking.Rows(0)("singer"))
            chkDancer.Checked = Convert.ToBoolean(lastBooking.Rows(0)("dancer"))
            chkVideoke.Checked = Convert.ToBoolean(lastBooking.Rows(0)("videoke"))
        End If

        HelperUI.LoadEventPlaceImage(EventPlaceImageUrl, pb)
        Dim customerData As DataTable = HelperDatabase.GetCustomerData(CurrentUser.UserID)

        If customerData.Rows.Count > 0 Then
            txtCustomerName.Text = customerData.Rows(0)("name").ToString()
            dtpBirthday.Value = Convert.ToDateTime(customerData.Rows(0)("birthday"))
            cmbSex.Text = customerData.Rows(0)("sex").ToString()
            txtAddress.Text = customerData.Rows(0)("address").ToString()
        Else
            MessageBox.Show("Customer information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        AddHandler dtpEventDateStart.ValueChanged, Sub(s, evt)
                                                       HelperValidation.PreventBookedDate(dtpEventDateStart, bookedDates, lblDateWarning)
                                                   End Sub

        ' Modified parsing for OpeningHours to support both single and double digit hour formats.
        If Not String.IsNullOrWhiteSpace(OpeningHours) Then
            Dim parsedOpening As DateTime
            Dim formats() As String = {"HH:mm:ss", "H:mm:ss"}
            If DateTime.TryParseExact(OpeningHours, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedOpening) Then
                cbStartHour.Text = parsedOpening.ToString("hh")   ' Use two digits (e.g., "08")
                cbStartMinutes.Text = parsedOpening.ToString("mm")
                cbStartAMPM.Text = parsedOpening.ToString("tt")
            End If
        End If

        ' Modified parsing for ClosingHours similar to OpeningHours.
        If Not String.IsNullOrWhiteSpace(ClosingHours) Then
            Dim parsedClosing As DateTime
            Dim formats() As String = {"HH:mm:ss", "H:mm:ss"}
            If DateTime.TryParseExact(ClosingHours, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedClosing) Then
                cbEndHour.Text = parsedClosing.ToString("hh")
                cbEndMinutes.Text = parsedClosing.ToString("mm")
                cbEndAMPM.Text = parsedClosing.ToString("tt")
            End If
        End If

        If String.IsNullOrWhiteSpace(txtNumGuests.Text) Then
            txtNumGuests.Text = "1"
        End If

        HelperPrice.UpdateTotalPrice(txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
                  chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                  cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                  dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity, BasePricePerDay,
                  lblTotalPricePaymentContainer, lblPriceBreakdown, txtTotalPrice)
    End Sub


    Private Function ConvertTo12HourFormat(time As String) As String
        Dim parsedTime As DateTime
        If DateTime.TryParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedTime) Then
            Return parsedTime.ToString("h:mm tt")
        End If
        Return String.Empty
    End Function


    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1
        txtAge.Text = age.ToString()
    End Sub
    Private Sub btnBookingProceed_Click(sender As Object, e As EventArgs)
        HelperValidation.ValidateBooking(Nothing, tcDetails, tpCustomerDetails, tpPaymentDetails, cbEventType, txtNumGuests,
                                     dtpEventDateStart, dtpEventDateEnd, cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
                                     chkOutsideAvailableHours, txtCustomerName, dtpBirthday, cmbSex, txtAddress, OpeningHours, ClosingHours, PlaceId)
    End Sub


    Private Sub btnCustomerProceed_Click(sender As Object, e As EventArgs) Handles btnCustomerProceed.Click
        If Not HelperValidation.IsValidCustomerInfo(txtCustomerName, dtpBirthday, cmbSex, txtAddress) Then Exit Sub
        PopulatePaymentDetails()
        tcDetails.SelectedTab = tpPaymentDetails
        ' Validate age here using the helper method:
        If Not HelperValidation.ValidateCustomerAge(dtpBirthday) Then Exit Sub
    End Sub

    Private Sub btnPlaceBooking_Click(sender As Object, e As EventArgs) Handles btnPlaceBooking.Click
        ' Check for duplicate booking
        If bookedDates.Contains(dtpEventDateStart.Value.Date) Then
            MessageBox.Show("This date is already booked. Please select another.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Parse the number of guests from text
        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
            numGuests = 0
        End If

        ' Create complete time strings by combining hour, minute, and AM/PM values.
        Dim eventStartStr As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim eventEndStr As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        ' Calculate final total price
        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                           dtpEventDateStart, dtpEventDateEnd,
                                           chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                           cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                           chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        ' Create new customer
        Dim customerResult As CustomerResult = HelperDatabase.CreateNewCustomer(txtCustomerName.Text, dtpBirthday.Value, cmbSex.Text, txtAddress.Text, numGuests)

        If CustomerResult.CustomerId <= 0 Then
            MessageBox.Show($"Customer creation failed! Error: {CustomerResult.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Link the new customer to the current user
        HelperDatabase.InsertUserCustomer(CurrentUser.UserID, CustomerResult.CustomerId)

        ' Call PlaceBooking with the complete time strings and using 'numGuests' as an integer
        Dim bookingId As Integer = HelperDatabase.PlaceBooking(CustomerResult.CustomerId, PlaceId, numGuests, dtpEventDateStart.Value.Date, eventStartStr, eventEndStr, dtpEventDateEnd.Value.Date, finalTotalPrice)


        If bookingId > 0 Then
            HelperDatabase.SaveBookingServices(bookingId, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)
            HelperDatabase.InsertPaymentRecord(bookingId, CustomerResult.CustomerId, finalTotalPrice)

            Dim result = MessageBox.Show("Booking and payment recorded successfully! Do you want to review your customer details?",
                                 "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Dim customerViewForm As New FormCustomerView(CurrentUser.CustomerId)
                customerViewForm.Show()
            End If
        Else
            MessageBox.Show("Booking failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PopulatePaymentDetails()
        lblCustomerContainer.Text = txtCustomerName.Text
        lblEventPlacePaymentContainer.Text = lblEventPlace.Text
        lblEventTypePaymentContainer.Text = cbEventType.Text
        lblNumGuestsPaymentContainer.Text = txtNumGuests.Text
        lblEventDatePaymentContainer.Text = If(cbSameDayEvent.Checked, dtpEventDateStart.Value.ToShortDateString(),
                                       $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}")
        lblEventTimePaymentContainer.Text = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text} - {cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                               dtpEventDateStart, dtpEventDateEnd,
                                                               chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                               cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                               chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text

        lblPriceBreakdown.Text = HelperPrice.GeneratePriceBreakdown(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                                dtpEventDateStart, dtpEventDateEnd, chkOutsideAvailableHours,
                                                                cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
                                                                OpeningHours, ClosingHours, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke, finalTotalPrice)
    End Sub

    Private Sub tcDetails_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcDetails.Selecting
        HelperValidation.ValidateBooking(e, tcDetails, tpCustomerDetails, tpPaymentDetails,
                                     cbEventType, txtNumGuests, dtpEventDateStart, dtpEventDateEnd,
                                     cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
                                     chkOutsideAvailableHours, txtCustomerName, dtpBirthday, cmbSex,
                                     txtAddress, OpeningHours, ClosingHours, PlaceId)
    End Sub



    Private Sub cbEndHour_SelectedIndexChanged(sender As Object, e As EventArgs)
        HelperEvent.HandleEndHourChange(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
    End Sub

    Private Sub dtpEventDateStart_ValueChanged(sender As Object, e As EventArgs)
        HelperEvent.HandleEventStartDateChange(dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
    End Sub

    Private Sub UpdateTotalPrice() Handles cbEndHour.SelectedIndexChanged, cbEndMinutes.SelectedIndexChanged, cbEndAMPM.SelectedIndexChanged,
                                    cbStartHour.SelectedIndexChanged, cbStartMinutes.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged,
                                    txtNumGuests.TextChanged, chkCatering.CheckedChanged, chkClown.CheckedChanged,
                                    chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged,
                                    chkOutsideAvailableHours.CheckedChanged

        HelperPrice.UpdateTotalPrice(txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke, chkOutsideAvailableHours, cbStartHour,
                                   cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                   dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity, BasePricePerDay,
                                   lblTotalPricePaymentContainer, lblPriceBreakdown, txtTotalPrice)
    End Sub


    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txtNumGuests.TextChanged, chkVideoke.CheckedChanged, chkSinger.CheckedChanged, chkOutsideAvailableHours.CheckedChanged, chkDancer.CheckedChanged, chkClown.CheckedChanged, chkCatering.CheckedChanged, cbStartMinutes.SelectedIndexChanged, cbStartHour.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged, cbEndMinutes.SelectedIndexChanged, cbEndHour.SelectedIndexChanged, cbEndAMPM.SelectedIndexChanged

    End Sub

    Private Sub cbSameDayEvent_CheckedChanged(sender As Object, e As EventArgs) Handles cbSameDayEvent.CheckedChanged
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            dtpEventDateEnd.Enabled = False
            lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()
        Else
            dtpEventDateEnd.Enabled = True
            lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        End If
        UpdateEventEndDate()
    End Sub

    Private Sub UpdateEventEndDate()
        ' If the same-day checkbox is checked, simply assign the start date.
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            Return
        End If

        ' Otherwise, update dtpEventDateEnd based on event time inputs.
        Dim startHour As Integer, startMinutes As Integer, endHour As Integer, endMinutes As Integer
        If Not Integer.TryParse(cbStartHour.Text, startHour) OrElse Not Integer.TryParse(cbStartMinutes.Text, startMinutes) Then Exit Sub
        If Not Integer.TryParse(cbEndHour.Text, endHour) OrElse Not Integer.TryParse(cbEndMinutes.Text, endMinutes) Then Exit Sub

        Dim startAMPM As String = cbStartAMPM.Text
        Dim endAMPM As String = cbEndAMPM.Text

        If startAMPM = "PM" AndAlso startHour < 12 Then startHour += 12
        If startAMPM = "AM" AndAlso startHour = 12 Then startHour = 0

        If endAMPM = "PM" AndAlso endHour < 12 Then endHour += 12
        If endAMPM = "AM" AndAlso endHour = 12 Then endHour = 0

        Dim eventStartTime As New DateTime(dtpEventDateStart.Value.Year, dtpEventDateStart.Value.Month, dtpEventDateStart.Value.Day, startHour, startMinutes, 0)
        Dim eventEndTime As New DateTime(dtpEventDateStart.Value.Year, dtpEventDateStart.Value.Month, dtpEventDateStart.Value.Day, endHour, endMinutes, 0)

        ' If the provided event end time is not after the start time, assume the event spans midnight.
        If eventEndTime <= eventStartTime Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
        Else
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
    End Sub


    Private Sub btBookingProceed_Click(sender As Object, e As EventArgs) Handles btBookingProceed.Click
        If Not HelperValidation.ValidateBookingInputs(cbEventType, dtpEventDateStart, dtpEventDateEnd,
                                                    cbStartHour, cbStartMinutes, cbStartAMPM,
                                                    cbEndHour, cbEndMinutes, cbEndAMPM,
                                                    chkOutsideAvailableHours, OpeningHours, ClosingHours, PlaceId) Then
            Exit Sub
        End If

        Dim eventStartTime As DateTime, eventEndTime As DateTime, openingTime As DateTime, closingTime As DateTime
        Dim timeFormat As String = "h:mm tt"
        DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime)
        DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime)
        DateTime.TryParse(OpeningHours, openingTime)
        DateTime.TryParse(ClosingHours, closingTime)

        Dim finalTotalPrice As Decimal = Convert.ToDecimal(lblTotalPricePaymentContainer.Tag)

        Dim confirmProceed As DialogResult = MessageBox.Show($"Total Price Updated: ₱{finalTotalPrice:F2}. Do you want to proceed to customer details?", "Price Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If confirmProceed = DialogResult.Yes Then
            tcDetails.SelectedTab = tpCustomerDetails
        End If

        If chkOutsideAvailableHours.Checked Then
            Dim perMinuteRate As Decimal = 17D
            Dim additionalCharges As Decimal = 0D

            If eventStartTime < openingTime Then
                Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
                additionalCharges += earlyMinutes * perMinuteRate
            End If

            If eventEndTime > closingTime Then
                Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
                additionalCharges += overtimeMinutes * perMinuteRate
            End If

            finalTotalPrice += additionalCharges
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub


End Class