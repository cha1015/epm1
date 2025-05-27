Imports System
Imports System.Text
Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

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

    ' ------------------ Form Load ------------------
    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateWarning.Visible = False

        lblEventPlace.Text = EventPlaceName
        lblPlaceIDContainer.Text = PlaceId.ToString()
        lblCapacityContainer.Text = EventPlaceCapacity.ToString()
        lblPricePerDayContainer.Text = "₱" & BasePricePerDay.ToString("F2")
        lblFeaturesContainer.Text = EventPlaceFeatures
        lblDescriptionContainer.Text = EventPlaceDescription

        Try
            lblHoursContainer.Text = If(String.IsNullOrWhiteSpace(OpeningHours) OrElse String.IsNullOrWhiteSpace(ClosingHours),
                        "N/A",
                        $"{DateTime.Parse(OpeningHours):hh:mm tt} - {DateTime.Parse(ClosingHours):hh:mm tt}")
        Catch ex As Exception
            lblHoursContainer.Text = "N/A"
        End Try

        lblAvailableDaysContainer.Text = $"Available: {HelperEvent.FormatAvailableDays(AvailableDays)}"

        dtpEventDateStart.Value = Date.Today
        dtpEventDateStart.MinDate = Date.Today
        dtpEventDateEnd.MinDate = Date.Today
        cbSameDayEvent.Checked = True
        dtpEventDateEnd.Value = dtpEventDateStart.Value
        dtpEventDateEnd.Enabled = False
        lblEventDatePaymentContainer.Text = dtpEventDateStart.Value.ToShortDateString()

        Try
            HelperDatabase.PopulateEventTypeCombo(EventPlaceName, cbEventType)
        Catch ex As Exception
            MessageBox.Show("Failed to load event types.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            bookedDates = HelperDatabase.LoadBookedDates(PlaceId)
        Catch ex As Exception
            bookedDates = New List(Of Date)
            MessageBox.Show("Failed to load booked dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
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
        Catch ex As Exception
            MessageBox.Show("Failed to load last booking details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            HelperUI.LoadEventPlaceImage(EventPlaceImageUrl, pb)
        Catch ex As Exception
            ' Ignore image load errors
        End Try

        Try
            Dim customerData As DataTable = HelperDatabase.GetCustomerData(CurrentUser.UserID)
            If customerData.Rows.Count > 0 Then
                txtCustomerName.Text = customerData.Rows(0)("name").ToString()
                dtpBirthday.Value = Convert.ToDateTime(customerData.Rows(0)("birthday"))
                cmbSex.Text = customerData.Rows(0)("sex").ToString()
                txtAddress.Text = customerData.Rows(0)("address").ToString()
            Else
                MessageBox.Show("Customer information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load customer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        AddHandler dtpEventDateStart.ValueChanged, Sub(s, evt)
                                                       HelperValidation.PreventBookedDate(dtpEventDateStart, bookedDates, lblDateWarning)
                                                   End Sub

        AddHandler dtpEventDateStart.ValueChanged, Sub(s, evt)
                                                       HelperValidation.PreventBookedDate(dtpEventDateStart, bookedDates, lblDateWarning)
                                                   End Sub

        Try
            HelperPrice.UpdateTotalPrice(txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke,
                          chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                          cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                          dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity, BasePricePerDay,
                          lblTotalPricePaymentContainer, lblPriceBreakdown, txtTotalPrice)
        Catch ex As Exception
            MessageBox.Show("Failed to update total price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        Try
            PopulatePaymentDetails()
        Catch ex As Exception
            MessageBox.Show("Failed to populate payment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        tcDetails.SelectedTab = tpPaymentDetails
        If Not HelperValidation.ValidateCustomerAge(dtpBirthday) Then Exit Sub
    End Sub

    Private Sub btnPlaceBooking_Click(sender As Object, e As EventArgs) Handles btnPlaceBooking.Click
        If bookedDates.Contains(dtpEventDateStart.Value.Date) Then
            MessageBox.Show("This date is already booked. Please select another.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim finalTotalPrice As Decimal
        Try
            finalTotalPrice = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                     dtpEventDateStart, dtpEventDateEnd,
                                                     chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                     cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                     chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)
        Catch ex As Exception
            MessageBox.Show("Failed to compute final price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim bookingId As Integer
        Try
            bookingId = HelperDatabase.PlaceBooking(CurrentUser.CustomerId, PlaceId, txtNumGuests.Text,
                                                 dtpEventDateStart.Value.Date, cbStartHour.Text, cbEndHour.Text, finalTotalPrice)
        Catch ex As Exception
            MessageBox.Show("Booking failed due to a database error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If bookingId > 0 Then
            Try
                HelperDatabase.SaveBookingServices(bookingId, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)
                HelperDatabase.InsertPaymentRecord(bookingId, CurrentUser.CustomerId, finalTotalPrice)
            Catch ex As Exception
                MessageBox.Show("Booking saved, but failed to save services or payment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            Dim result = MessageBox.Show("Booking and payment recorded successfully! Do you want to review your customer details?",
                                         "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = DialogResult.Yes Then
                Try
                    Dim customerViewForm As New FormCustomerView(CurrentUser.CustomerId)
                    customerViewForm.Show()
                Catch
                End Try
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
        Dim extraServicesCost As Decimal
        Try
            extraServicesCost = HelperPrice.ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)
        Catch
            extraServicesCost = 0
        End Try

        Dim outsideHoursFee As Decimal
        Try
            outsideHoursFee = HelperPrice.ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked,
                                                                DateTime.Parse($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"),
                                                                DateTime.Parse($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"),
                                                                DateTime.Parse(OpeningHours), DateTime.Parse(ClosingHours))
        Catch
            outsideHoursFee = 0
        End Try

        Dim finalTotalPrice As Decimal
        Try
            finalTotalPrice = HelperPrice.ComputeFinalPrice(numGuests, EventPlaceCapacity, BasePricePerDay,
                                                       dtpEventDateStart, dtpEventDateEnd,
                                                       chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                       cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                                       chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)
        Catch
            finalTotalPrice = 0
        End Try

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text

        Dim breakdown As New StringBuilder()
        breakdown.AppendLine($"Base Price: ₱{BasePricePerDay:F2}")
        breakdown.AppendLine($"Guests: {numGuests} (Capacity: {EventPlaceCapacity})")

        If excessGuestFee > 0 Then breakdown.AppendLine($"Excess Guest Fee: ₱{excessGuestFee:F2}")
        If extraServicesCost > 0 Then breakdown.AppendLine($"Extra Services: ₱{extraServicesCost:F2}")
        If outsideHoursFee > 0 Then breakdown.AppendLine($"Outside Available Hours Fee: ₱{outsideHoursFee:F2}")

        breakdown.AppendLine($"Final Total Price: {txtTotalPrice.Text}")

        lblPriceBreakdown.Text = breakdown.ToString()
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

        Try
            HelperPrice.UpdateTotalPrice(txtNumGuests, chkCatering, chkClown, chkSinger, chkDancer, chkVideoke, chkOutsideAvailableHours, cbStartHour,
                                   cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, OpeningHours, ClosingHours,
                                   dtpEventDateStart, dtpEventDateEnd, EventPlaceCapacity, BasePricePerDay,
                                   lblTotalPricePaymentContainer, lblPriceBreakdown, txtTotalPrice)
        Catch
        End Try
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
        Try
            DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime)
            DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime)
            DateTime.TryParse(OpeningHours, openingTime)
            DateTime.TryParse(ClosingHours, closingTime)
        Catch
            MessageBox.Show("Invalid time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim finalTotalPrice As Decimal
        Try
            finalTotalPrice = Convert.ToDecimal(lblTotalPricePaymentContainer.Tag)
        Catch
            finalTotalPrice = 0
        End Try

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

    Private Sub lblEventTypePaymentContainer_Click(sender As Object, e As EventArgs) Handles lblEventTypePaymentContainer.Click

    End Sub
End Class
