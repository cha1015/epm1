Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Globalization
Imports System.IO
Imports System
Public Class FormBooking

#Region "properties"
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
    Private tooltip As New ToolTip()
    ' ------------------ Constructor ------------------
    Public Sub New(customerId As Integer, placeId As Integer)
        InitializeComponent()
        _customerId = customerId
        Me.PlaceId = placeId
    End Sub

#End Region


    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With tooltip
            .ShowAlways = True
        End With

        Dim tooltipText As String = "Book outside available hours: ₱17.00 per minute"
        tooltip.SetToolTip(txtNumGuests, "Capacity exceedance fee: ₱100.00 per additional guest")
        For Each cb As Control In {cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM}
            tooltip.SetToolTip(cb, tooltipText)
        Next

        lblTotalPricePaymentContainer.Visible = False

        lblEventPlace.Text = EventPlaceName
        lblPlaceIDContainer.Text = PlaceId.ToString()
        lblCapacityContainer.Text = EventPlaceCapacity.ToString()
        lblPricePerDayContainer.Text = "₱" & BasePricePerDay.ToString("F2")
        lblFeaturesContainer.Text = EventPlaceFeatures
        lblDescriptionContainer.Text = EventPlaceDescription

        lblHoursContainer.Text = If(String.IsNullOrWhiteSpace(OpeningHours) OrElse String.IsNullOrWhiteSpace(ClosingHours),
            "N/A",
            $"{ConvertTo12HourFormat(OpeningHours)} - {ConvertTo12HourFormat(ClosingHours)}")

        lblAvailableDaysContainer.Text = $"{HelperEvent.FormatAvailableDays(AvailableDays)}"

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

            Dim eventTime As TimeSpan = DirectCast(lastBooking.Rows(0)("event_time"), TimeSpan)

            Dim eventEndTime As TimeSpan = If(lastBooking.Rows(0)("event_end_time") Is DBNull.Value, TimeSpan.Zero, DirectCast(lastBooking.Rows(0)("event_end_time"), TimeSpan))

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

            Dim servicesOffered As String = lastBooking.Rows(0)("services_offered").ToString()

            chkCatering.Checked = servicesOffered.Contains("Catering")
            chkClown.Checked = servicesOffered.Contains("Clown")
            chkSinger.Checked = servicesOffered.Contains("Singer")
            chkDancer.Checked = servicesOffered.Contains("Dancer")
            chkVideoke.Checked = servicesOffered.Contains("Videoke")

        End If

        HelperUI.LoadEventPlaceImage(EventPlaceImageUrl, pb)

        Dim query As String = "SELECT first_name, last_name, birthday, sex, address FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", CurrentUser.UserID}}

        Dim userData As DataTable = DBHelper.GetDataTable(query, parameters)

        If userData.Rows.Count > 0 Then
            txtCustomerName.Text = userData.Rows(0)("first_name").ToString() & " " & userData.Rows(0)("last_name").ToString()
            dtpBirthday.Value = Convert.ToDateTime(userData.Rows(0)("birthday"))
            cmbSex.Text = userData.Rows(0)("sex").ToString()
            txtAddress.Text = userData.Rows(0)("address").ToString()
            Me.Refresh()
            Debug.WriteLine("Retrieved User Data - Name: " & userData.Rows(0)("first_name").ToString() & " " & userData.Rows(0)("last_name").ToString() &
                ", Birthday: " & userData.Rows(0)("birthday").ToString() &
                ", Sex: " & userData.Rows(0)("sex").ToString() &
                ", Address: " & userData.Rows(0)("address").ToString())

        Else
            MessageBox.Show("Customer information not found. Base load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        AddHandler dtpEventDateStart.ValueChanged, Sub(s, evt)
                                                       HelperValidation.PreventBookedDate(dtpEventDateStart, bookedDates)
                                                   End Sub

        If Not String.IsNullOrWhiteSpace(OpeningHours) Then
            Dim parsedOpening As DateTime
            Dim formats() As String = {"HH:mm:ss", "H:mm:ss"}
            If DateTime.TryParseExact(OpeningHours, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedOpening) Then
                cbStartHour.Text = parsedOpening.ToString("hh")
                cbStartMinutes.Text = parsedOpening.ToString("mm")
                cbStartAMPM.Text = parsedOpening.ToString("tt")
            End If
        End If

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

        HelperPrice.UpdateTotalPriceAndGenerateBreakdown(
            txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
            cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
            OpeningHours, ClosingHours, dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity,
            BasePricePerDay, lblTotalPricePaymentContainer, dgvPriceBreakdown, txtTotalPrice)

        Debug.WriteLine("Retrieved User Data - Name: " & userData.Rows(0)("first_name").ToString() & " " & userData.Rows(0)("last_name").ToString() &
    ", Birthday: " & userData.Rows(0)("birthday").ToString() &
    ", Sex: " & userData.Rows(0)("sex").ToString() &
    ", Address: " & userData.Rows(0)("address").ToString())
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

    Private Sub btnCustomerProceed_Click(sender As Object, e As EventArgs) Handles btnCustomerProceed.Click
        If Not HelperValidation.IsValidCustomerInfo(txtCustomerName, dtpBirthday, cmbSex, txtAddress) Then Exit Sub

        If Not HelperValidation.ValidateCustomerAge(dtpBirthday) Then Exit Sub

        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1

        txtAge.Text = age.ToString()

        PopulatePaymentDetails()
        tcDetails.SelectedTab = tpPaymentDetails
    End Sub

    Private Sub ShowError(ByVal message As String)
        MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btnPlaceBooking_Click(sender As Object, e As EventArgs) Handles btnPlaceBooking.Click


        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then
            numGuests = 1
        End If

        Dim eventStartStr As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim eventEndStr As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                       dtpEventDateStart, dtpEventDateEnd, cbStartHour, cbStartMinutes, cbStartAMPM,
                                       cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                       chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)
        If finalTotalPrice <= 0 Then
            MessageBox.Show("Final price calculation error. Booking cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim customerId As Integer = -1
        Dim customerResult As CustomerResult = Nothing
        Dim customerData As DataTable = HelperDatabase.GetCustomerData(CurrentUser.UserID)
        If customerData.Rows.Count > 0 Then
            If customerData.Columns.Contains("customer_id") Then
                customerId = Convert.ToInt32(customerData.Rows(0)("customer_id"))
            ElseIf customerData.Columns.Contains("id") Then
                customerId = Convert.ToInt32(customerData.Rows(0)("id"))
            Else
                MessageBox.Show("Customer ID column not found in customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else

            customerResult = HelperDatabase.CreateNewCustomer(txtCustomerName.Text, dtpBirthday.Value, cmbSex.Text, txtAddress.Text, numGuests, CurrentUser.UserID)
            Debug.WriteLine("UserID: " & CurrentUser.UserID)

            If customerResult.CustomerId <= 0 Then
                MessageBox.Show($"Customer creation failed! Error: {customerResult.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            customerId = customerResult.CustomerId
            HelperDatabase.InsertUserCustomer(CurrentUser.UserID, customerId)
        End If

        CurrentUser.CustomerId = customerId

        Dim bookingId As Integer = HelperDatabase.PlaceBooking(customerId, PlaceId, numGuests, dtpEventDateStart.Value.Date, eventStartStr, eventEndStr, dtpEventDateEnd.Value.Date, finalTotalPrice, cbEventType.Text)

        If bookingId > 0 Then
            HelperDatabase.SaveBookingServices(bookingId, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)
            HelperDatabase.InsertPaymentRecord(bookingId, CurrentUser.UserID, customerId, finalTotalPrice)

            Dim result = MessageBox.Show("Booking and payment recorded successfully! Do you want to review your customer details?",
                             "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Dim customerViewForm As New FormCustomerView(customerId)
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
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 1

        Dim finalTotalPrice As Decimal = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                                   dtpEventDateStart, dtpEventDateEnd, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                                   cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                                   chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1
        Dim servicesCost As Decimal = HelperPrice.ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)

        Dim timeFormat As String = "h:mm tt"
        Dim startTime, endTime, openingTime, closingTime As DateTime

        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, startTime) Then
            MessageBox.Show("Invalid start time format. Please re-enter correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, endTime) Then
            MessageBox.Show("Invalid end time format. Please re-enter correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not DateTime.TryParse(OpeningHours, openingTime) Then
            MessageBox.Show("Invalid opening hours format. Please check the venue's schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not DateTime.TryParse(ClosingHours, closingTime) Then
            MessageBox.Show("Invalid closing hours format. Please check the venue's schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim outsideFees As Decimal = HelperPrice.ComputeOutsideHoursFee(startTime, endTime, openingTime, closingTime)

        finalTotalPrice += outsideFees
        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text
        lblTotalPricePaymentContainer.Tag = finalTotalPrice

        HelperPrice.UpdateTotalPriceAndGenerateBreakdown(
            txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
            cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
            OpeningHours, ClosingHours, dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity,
            BasePricePerDay, lblTotalPricePaymentContainer, dgvPriceBreakdown, txtTotalPrice)

    End Sub


    Private Sub cbEndHour_SelectedIndexChanged(sender As Object, e As EventArgs)
        HelperEvent.HandleEndHourChange(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
    End Sub


    Private Sub dtpEventDateStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpEventDateStart.ValueChanged, dtpEventDateEnd.ValueChanged
        HelperEvent.HandleEventStartDateChange(dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
        'If dtpEventDateStart.Value.Date > dtpEventDateEnd.Value.Date Then
        '    MessageBox.Show("The event start date cannot be after the end date. Please select valid dates.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    dtpEventDateStart.Value = dtpEventDateEnd.Value.Date
        'End If
    End Sub
    Private Sub UpdateTotalPrice() Handles cbEndHour.SelectedIndexChanged,
                                          cbEndMinutes.SelectedIndexChanged,
                                          cbEndAMPM.SelectedIndexChanged,
                                          cbStartHour.SelectedIndexChanged,
                                          cbStartMinutes.SelectedIndexChanged,
                                          cbStartAMPM.SelectedIndexChanged,
                                          txtNumGuests.TextChanged,
                                          chkCatering.CheckedChanged,
                                          chkClown.CheckedChanged,
                                          chkSinger.CheckedChanged,
                                          chkDancer.CheckedChanged,
                                          chkVideoke.CheckedChanged,
                                          dtpEventDateStart.ValueChanged,
                                          dtpEventDateEnd.ValueChanged
        HelperPrice.UpdateTotalPriceAndGenerateBreakdown(
            txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
            cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
            OpeningHours, ClosingHours, dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity,
            BasePricePerDay, lblTotalPricePaymentContainer, dgvPriceBreakdown, txtTotalPrice)
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
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            Return
        End If

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

        If eventStartTime = DateTime.MinValue Or eventEndTime = DateTime.MinValue Then
            MessageBox.Show("Invalid event time selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If eventEndTime <= eventStartTime Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
        Else
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
    End Sub

    Private Sub btBookingProceed_Click(sender As Object, e As EventArgs) Handles btBookingProceed.Click
        If String.IsNullOrWhiteSpace(cbEventType.Text) OrElse
       String.IsNullOrWhiteSpace(txtNumGuests.Text) OrElse Not Integer.TryParse(txtNumGuests.Text, Nothing) OrElse
       String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            MessageBox.Show("Please complete all required fields before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If bookedDates.Contains(dtpEventDateStart.Value.Date) Then
            MessageBox.Show("This date is already booked. Please select another.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpEventDateStart.Value.Date > dtpEventDateEnd.Value.Date Then
            MessageBox.Show("The event start date cannot be after the end date. Please select valid dates.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        btBookingProceed.Enabled = True

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) OrElse numGuests <= 0 Then
            MessageBox.Show("Number of guests must be at least 1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim eventStartTime As DateTime, eventEndTime As DateTime, openingTime As DateTime, closingTime As DateTime
        Dim timeFormat As String = "h:mm tt"
        DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime)
        DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime)
        DateTime.TryParse(OpeningHours, openingTime)
        DateTime.TryParse(ClosingHours, closingTime)

        HelperPrice.UpdateTotalPriceAndGenerateBreakdown(
            txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
            cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM,
            OpeningHours, ClosingHours, dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity,
            BasePricePerDay, lblTotalPricePaymentContainer, dgvPriceBreakdown, txtTotalPrice)

        Dim finalTotalPrice As Decimal = Convert.ToDecimal(lblTotalPricePaymentContainer.Tag)

        Dim confirmProceed As DialogResult = MessageBox.Show($"Total Price Updated: ₱{finalTotalPrice:F2}. Do you want to proceed to customer details?", "Price Confirmation",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If confirmProceed = DialogResult.Yes Then
            tcDetails.SelectedTab = tpCustomerDetails
            Application.DoEvents()
        End If
    End Sub

    'Public Sub LoadCustomerData()
    '    Dim customerData As DataTable = HelperDatabase.GetCustomerData(CurrentUser.UserID)

    '    If customerData.Rows.Count > 0 Then
    '        txtCustomerName.Text = customerData.Rows(0)("name").ToString()
    '        dtpBirthday.Value = Convert.ToDateTime(customerData.Rows(0)("birthday"))
    '        cmbSex.Text = customerData.Rows(0)("sex").ToString()
    '        txtAddress.Text = customerData.Rows(0)("address").ToString()

    '        Me.Refresh()
    '    Else
    '        MessageBox.Show("Customer information not found. LoadCustomerData", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    'Private Sub FormBooking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    LoadCustomerData()
    'End Sub

    'Public Sub RefreshBookingDetails()
    '    bookedDates = HelperDatabase.LoadBookedDates(PlaceId)
    '    LoadCustomerData()
    '    Me.Refresh()
    'End Sub

    Private Sub txtNumGuests_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumGuests.KeyPress
        ' Allow only digits and control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


#Region "back and next"
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click

        Dim mainForm As New FormMain()
        mainForm.StartPosition = FormStartPosition.CenterScreen
        mainForm.WindowState = FormWindowState.Normal
        mainForm.Show()
        mainForm.BringToFront()
        mainForm.Activate()

        Me.Refresh()
        Application.DoEvents()
    End Sub



#End Region
End Class