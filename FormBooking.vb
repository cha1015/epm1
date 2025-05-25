Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text
Imports System.IO

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
    Public Property VoucherDiscount As Decimal = 0
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

    Private Sub PreventBookedDates(sender As Object, e As EventArgs)
        Dim picker As DateTimePicker = CType(sender, DateTimePicker)

        If bookedDates.Contains(picker.Value.Date) Then
            Dim result As DialogResult = MessageBox.Show($"The selected date ({picker.Value.ToShortDateString()}) is unavailable. Would you like to see the next available date?", "Booking Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim nextAvailableDate = picker.Value.AddDays(1)
                While bookedDates.Contains(nextAvailableDate)
                    nextAvailableDate = nextAvailableDate.AddDays(1)
                End While
                picker.Value = nextAvailableDate
            Else
                picker.Value = Date.Today
            End If
        End If
    End Sub

    ' ------------------ Form Load ------------------
    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler dtpEventDateStart.ValueChanged, AddressOf PreventBookedDates
        AddHandler dtpEventDateEnd.ValueChanged, AddressOf PreventBookedDates

        lblEventPlace.Text = EventPlaceName
        lblPlaceIDContainer.Text = PlaceId.ToString()
        lblCapacityContainer.Text = EventPlaceCapacity.ToString()
        lblPricePerDayContainer.Text = "₱" & BasePricePerDay.ToString("F2")
        lblFeaturesContainer.Text = EventPlaceFeatures
        lblDescriptionContainer.AutoSize = False
        lblDescriptionContainer.Size = New Size(Panel1.Width - 20, 0)
        lblDescriptionContainer.MaximumSize = New Size(Panel1.Width - 20, 0)
        lblDescriptionContainer.TextAlign = ContentAlignment.TopLeft

        lblHoursContainer.Text = If(String.IsNullOrWhiteSpace(OpeningHours) OrElse String.IsNullOrWhiteSpace(ClosingHours),
                    "N/A",
                    $"{DateTime.Parse(OpeningHours):hh:mm tt} - {DateTime.Parse(ClosingHours):hh:mm tt}")

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
            cbStartHour.Text = lastBooking.Rows(0)("start_hour").ToString()
            cbStartMinutes.Text = lastBooking.Rows(0)("start_minutes").ToString()
            cbStartAMPM.Text = lastBooking.Rows(0)("start_ampm").ToString()
            cbEndHour.Text = lastBooking.Rows(0)("end_hour").ToString()
            cbEndMinutes.Text = lastBooking.Rows(0)("end_minutes").ToString()
            cbEndAMPM.Text = lastBooking.Rows(0)("end_ampm").ToString()
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
    End Sub
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
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then age -= 1

        If age < 18 Then
            MessageBox.Show("Only individuals aged 18 or older can book. A parent or guardian must handle the booking.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnPlaceBooking_Click(sender As Object, e As EventArgs) Handles btnPlaceBooking.Click
        If bookedDates.Contains(dtpEventDateStart.Value.Date) Then
            MessageBox.Show("This date is already booked. Please select another.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                                 dtpEventDateStart, dtpEventDateEnd, VoucherDiscount,
                                                                 chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                                 cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                                 chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        Dim bookingId As Integer = HelperDatabase.PlaceBooking(CurrentUser.CustomerId, PlaceId, txtNumGuests.Text,
                                                             dtpEventDateStart.Value.Date, cbStartHour.Text, cbEndHour.Text, finalTotalPrice)

        If bookingId > 0 Then
            HelperDatabase.SaveBookingServices(bookingId, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)
            HelperDatabase.InsertPaymentRecord(bookingId, CurrentUser.CustomerId, finalTotalPrice)

            Dim result = MessageBox.Show("Booking and payment recorded successfully! Do you want to review your customer details?",
                                         "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = DialogResult.Yes Then
                Dim customerViewForm As New FormCustomerView(CurrentUser.CustomerId)
                customerViewForm.Show()
            End If

        Else
            MessageBox.Show("Booking failed!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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

        Dim excessGuestFee As Decimal = If(numGuests > EventPlaceCapacity, (numGuests - EventPlaceCapacity) * 100, 0)
        Dim extraServicesCost As Decimal = HelperPrice.ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)

        Dim outsideHoursFee As Decimal = HelperPrice.ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked,
                                                                        DateTime.Parse($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"),
                                                                        DateTime.Parse($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"),
                                                                        DateTime.Parse(OpeningHours), DateTime.Parse(ClosingHours))

        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                                   dtpEventDateStart, dtpEventDateEnd, VoucherDiscount,
                                                                   chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                                   cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                                   chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text

        Dim breakdown As New StringBuilder()
        breakdown.AppendLine($"Base Price: ₱{BasePricePerDay:F2}")
        breakdown.AppendLine($"Guests: {numGuests} (Capacity: {EventPlaceCapacity})")

        If excessGuestFee > 0 Then breakdown.AppendLine($"Excess Guest Fee: ₱{excessGuestFee:F2}")
        If VoucherDiscount > 0 Then breakdown.AppendLine($"Voucher Discount: -₱{VoucherDiscount:F2}")
        If extraServicesCost > 0 Then breakdown.AppendLine($"Extra Services: ₱{extraServicesCost:F2}")
        If outsideHoursFee > 0 Then breakdown.AppendLine($"Outside Available Hours Fee: ₱{outsideHoursFee:F2}")

        breakdown.AppendLine($"Final Total Price: {txtTotalPrice.Text}")

        lblPriceBreakdown.Text = breakdown.ToString()
    End Sub


    Private Sub tcDetails_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcDetails.Selecting
        HelperValidation.ValidateBooking(e, tcDetails, tpCustomerDetails, tpPaymentDetails, cbEventType, txtNumGuests,
                                     dtpEventDateStart, dtpEventDateEnd, cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
                                     chkOutsideAvailableHours, txtCustomerName, dtpBirthday, cmbSex, txtAddress, OpeningHours, ClosingHours, PlaceId)
    End Sub


    Private Sub cbEndHour_SelectedIndexChanged(sender As Object, e As EventArgs)
        HelperEvent.HandleEndHourChange(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
    End Sub

    Private Sub dtpEventDateStart_ValueChanged(sender As Object, e As EventArgs)
        HelperEvent.HandleEventStartDateChange(dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
    End Sub

    Private Sub UpdateTotalPrice() Handles cbEndHour.SelectedIndexChanged, cbEndMinutes.SelectedIndexChanged, cbEndAMPM.SelectedIndexChanged,
                                    cbStartHour.SelectedIndexChanged, cbStartMinutes.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged,
                                    txtNumGuests.TextChanged, chkCatering.CheckedChanged, chkClown.CheckedChanged,
                                    chkSinger.CheckedChanged, chkDancer.CheckedChanged, chkVideoke.CheckedChanged,
                                    chkOutsideAvailableHours.CheckedChanged

        HelperPrice.UpdateTotalPrice(txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke, chkOutsideAvailableHours, cbStartHour,
                                   cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                   dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity, BasePricePerDay, VoucherDiscount,
                                   lblTotalPricePaymentContainer, lblPriceBreakdown, txtTotalPrice)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If HelperNavigation.ForwardHistory.Count > 0 Then ' ✅ Ensure the right reference
            Dim nextForm As System.Windows.Forms.Form = HelperNavigation.ForwardHistory.Pop() ' ✅ Retrieve last undone form
            HelperNavigation.GoNext(Me, nextForm, btnNext, btnBack) ' ✅ Restore previous form
        Else
            'MessageBox.Show("No next form to redo!")
            btnNext.Enabled = False ' Disable next button if no form to redo
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me, btnNext, btnBack)
    End Sub

    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txtNumGuests.TextChanged, chkVideoke.CheckedChanged, chkSinger.CheckedChanged, chkOutsideAvailableHours.CheckedChanged, chkDancer.CheckedChanged, chkClown.CheckedChanged, chkCatering.CheckedChanged, cbStartMinutes.SelectedIndexChanged, cbStartHour.SelectedIndexChanged, cbStartAMPM.SelectedIndexChanged, cbEndMinutes.SelectedIndexChanged, cbEndHour.SelectedIndexChanged, cbEndAMPM.SelectedIndexChanged

    End Sub

    Private Sub cbSameDayEvent_CheckedChanged(sender As Object, e As EventArgs) Handles cbSameDayEvent.CheckedChanged
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            dtpEventDateEnd.Enabled = False ' Prevent user modification

            lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()
        Else
            dtpEventDateEnd.Enabled = True
            lblEventDatePaymentContainer.Text = $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}"
        End If
        UpdateEventEndDate()
    End Sub

    Private Sub UpdateEventEndDate()

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

        If eventEndTime <= eventStartTime Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
            cbSameDayEvent.Checked = False
        Else
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            cbSameDayEvent.Checked = True
        End If

    End Sub

    Private Sub btBookingProceed_Click(sender As Object, e As EventArgs) Handles btBookingProceed.Click
        If String.IsNullOrWhiteSpace(cbEventType.Text) Then
            MessageBox.Show("Please select an event type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventDateStart.Value.Date < Date.Today Then
            MessageBox.Show("Event start date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventDateEnd.Value.Date < dtpEventDateStart.Value.Date Then
            MessageBox.Show("Event end date must be after the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            MessageBox.Show("Please complete the event time selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate booking availability for single or multi-day events
        Dim checkQuery As String = "SELECT COUNT(*) FROM Bookings WHERE place_id = @PlaceId AND 
                            (event_date BETWEEN @EventDateStart AND @EventDateEnd)"
        Dim checkParams As New Dictionary(Of String, Object) From {
    {"@PlaceId", PlaceId},
    {"@EventDateStart", dtpEventDateStart.Value.Date},
    {"@EventDateEnd", dtpEventDateEnd.Value.Date}
}
        Dim existingBookings As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(checkQuery, checkParams))


        If existingBookings > 0 Then
            MessageBox.Show("This event place is already booked during your selected date range. Please choose a different date or venue.",
                    "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime
        Dim openingTime As DateTime
        Dim closingTime As DateTime
        Dim timeFormat As String = "h:mm tt"

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  System.Globalization.DateTimeStyles.None, eventStartTime) OrElse
       Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  System.Globalization.DateTimeStyles.None, eventEndTime) OrElse
       Not DateTime.TryParse(OpeningHours, openingTime) OrElse
       Not DateTime.TryParse(ClosingHours, closingTime) Then
            MessageBox.Show("Invalid time format. Please select a valid time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If (eventStartTime < openingTime OrElse eventEndTime > closingTime) AndAlso Not chkOutsideAvailableHours.Checked Then
            MessageBox.Show("Your selected time is outside the venue's available hours. To proceed, either adjust your time or check 'Book outside available hours' to accept the extra charge.",
                        "Time Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim finalTotalPrice As Decimal = Convert.ToDecimal(lblTotalPricePaymentContainer.Tag)

        Dim confirmProceed As DialogResult = MessageBox.Show($"Total Price Updated: ₱{finalTotalPrice:F2}. Do you want to proceed to customer details?",
                                             "Price Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

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
End Class
