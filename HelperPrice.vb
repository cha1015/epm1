Imports System.Globalization
Imports System.Text

Public Class HelperPrice
    ' ------------------ Compute Final Price ------------------
    Public Shared Function ComputeFinalPrice(numGuests As Integer, eventPlaceCapacity As Integer, basePricePerDay As Decimal,
                                             dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                             chkOutsideAvailableHours As CheckBox,
                                             cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                             cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                             openingHours As String, closingHours As String,
                                             chkCatering As CheckBox, chkClown As CheckBox, chkSinger As CheckBox,
                                             chkDancer As CheckBox, chkVideoke As CheckBox) As Decimal
        Dim timeFormat As String = "h:mm tt"
        Dim eventStartTime As DateTime
        If Not DateTime.TryParseExact($"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}",
                                      timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) Then
            Return 0
        End If

        Dim eventEndTime As DateTime
        If Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}",
                                      timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            Return 0
        End If

        Dim openingTime As DateTime = DateTime.Parse(openingHours)
        Dim closingTime As DateTime = DateTime.Parse(closingHours)

        If closingTime < openingTime Then closingTime = closingTime.AddDays(1)
        If eventEndTime < eventStartTime Then eventEndTime = eventEndTime.AddDays(1)

        Dim isOutsideHours As Boolean = (eventStartTime < openingTime) OrElse (eventEndTime > closingTime)
        chkOutsideAvailableHours.Enabled = isOutsideHours
        If Not isOutsideHours Then chkOutsideAvailableHours.Checked = False

        Dim additionalCharges As Decimal = ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked, eventStartTime, eventEndTime, openingTime, closingTime)
        Dim servicesCost As Decimal = ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)

        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1

        Dim excessGuestCost As Decimal = If(numGuests > eventPlaceCapacity, (numGuests - eventPlaceCapacity) * 100, 0)
        Dim totalPrice As Decimal = basePricePerDay * totalDays + excessGuestCost + servicesCost + additionalCharges

        Return totalPrice
    End Function

    ' ------------------ Compute Services Cost ------------------
    Public Shared Function ComputeServicesCost(numGuests As Integer,
                                               cateringChecked As Boolean, clownChecked As Boolean,
                                               singerChecked As Boolean, dancerChecked As Boolean, videokeChecked As Boolean) As Decimal
        Dim servicesCost As Decimal = 0D
        Dim cateringRatePerGuest As Decimal = 400D
        Dim clownRatePerGuest As Decimal = 200D
        Dim singerRatePerGuest As Decimal = 140D
        Dim dancerRatePerGuest As Decimal = 140D
        Dim videokeRatePerGuest As Decimal = 20D

        If cateringChecked Then servicesCost += cateringRatePerGuest * numGuests
        If clownChecked Then servicesCost += clownRatePerGuest * numGuests
        If singerChecked Then servicesCost += singerRatePerGuest * numGuests
        If dancerChecked Then servicesCost += dancerRatePerGuest * numGuests
        If videokeChecked Then servicesCost += videokeRatePerGuest * numGuests

        Return servicesCost
    End Function

    ' ------------------ Compute Outside Hours Fee ------------------
    Public Shared Function ComputeOutsideHoursFee(outsideHoursChecked As Boolean, eventStartTime As DateTime,
                                              eventEndTime As DateTime, openingTime As DateTime, closingTime As DateTime) As Decimal
        If Not outsideHoursChecked Then Return 0D

        Dim additionalCharges As Decimal = 0D
        Dim perMinuteRate As Decimal = 17D
        Dim warningMessage As String = ""

        If eventStartTime < openingTime Then
            Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
            additionalCharges += earlyMinutes * perMinuteRate
            warningMessage &= $"Your event starts {earlyMinutes} minutes before opening. Extra fee: ₱{earlyMinutes * perMinuteRate}" & vbCrLf
        End If

        If eventEndTime > closingTime Then
            Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
            additionalCharges += overtimeMinutes * perMinuteRate
            warningMessage &= $"Your event ends {overtimeMinutes} minutes past closing. Extra fee: ₱{overtimeMinutes * perMinuteRate}" & vbCrLf
        End If

        If Not String.IsNullOrEmpty(warningMessage) Then
            MessageBox.Show(warningMessage, "Extra Charges Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return additionalCharges
    End Function


    ' ------------------ Generate Price Breakdown ------------------
    Public Shared Function GeneratePriceBreakdown(numGuests As Integer, eventPlaceCapacity As Integer,
                                              basePricePerDay As Decimal, totalDays As Integer, servicesCost As Decimal,
                                              additionalCharges As Decimal, finalTotalPrice As Decimal) As String
        Dim breakdown As New StringBuilder()

        breakdown.AppendLine($"Base Price ({totalDays} day/s): ₱{basePricePerDay * totalDays:F2} - Cost per day for the event place.")

        Dim excessGuestCost As Decimal = If(numGuests > eventPlaceCapacity, (numGuests - eventPlaceCapacity) * 100, 0)
        If excessGuestCost > 0 Then
            breakdown.AppendLine($"Guest Capacity Exceeded Fee: ₱{excessGuestCost:F2} - Additional charge for extra guests.")
        End If

        If servicesCost > 0 Then
            breakdown.AppendLine($"Total Services Fee: ₱{servicesCost:F2} - Includes catering, entertainment, etc.")
        End If

        If totalDays > 1 Then
            breakdown.AppendLine($"Multi-Day Fee ({totalDays} days): ₱{basePricePerDay * totalDays:F2} - Cost for multiple-day event.")
        End If

        If additionalCharges > 0 Then
            breakdown.AppendLine($"Outside Available Hours Fee: ₱{additionalCharges:F2} - Charges for scheduling beyond normal operating hours.")
        End If

        breakdown.AppendLine($"Total: ₱{finalTotalPrice:F2}")

        Return breakdown.ToString()
    End Function


    ' ------------------ Time Validation ------------------
    Public Shared Function IsValidTimeSelection(cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox) As Boolean
        Dim eventEndTime As DateTime
        Dim timeFormat As String = "h:mm tt"

        If String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then
            Return False
        End If

        If Not DateTime.TryParseExact($"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}", timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            Return False
        End If

        Return True
    End Function

    Public Shared Sub UpdateTotalPrice(txtNumGuests As TextBox, chkCatering As CheckBox, chkClown As CheckBox,
                                      chkSinger As CheckBox, chkDancer As CheckBox, chkVideoke As CheckBox, chkOutsideAvailableHours As CheckBox,
                                      cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                      cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                      openingHours As String, closingHours As String, dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                      eventPlaceCapacity As Integer, basePricePerDay As Decimal,
                                      lblTotalPricePaymentContainer As Label, lblPriceBreakdown As Label, txtTotalPrice As TextBox)

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim finalTotalPrice As Decimal = ComputeFinalPrice(numGuests, eventPlaceCapacity, basePricePerDay,
                                                       dtpEventDateStart, dtpEventDateEnd,
                                                       chkOutsideAvailableHours, cbStartHour, cbStartMinutes, cbStartAMPM,
                                                       cbEndHour, cbEndMinutes, cbEndAMPM, openingHours, closingHours,
                                                       chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text
        lblTotalPricePaymentContainer.Tag = finalTotalPrice

        Dim timeFormat As String = "h:mm tt"
        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime

        Dim startInput As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        If Not DateTime.TryParseExact(startInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) Then
            Return
        End If

        Dim endInput As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"
        If Not DateTime.TryParseExact(endInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            Return
        End If

        Dim parsedOpeningTime As DateTime = DateTime.Parse(openingHours)
        Dim parsedClosingTime As DateTime = DateTime.Parse(closingHours)

        Dim outsideFees As Decimal = ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked, eventStartTime, eventEndTime, parsedOpeningTime, parsedClosingTime)

        lblPriceBreakdown.Text = GeneratePriceBreakdown(numGuests, eventPlaceCapacity, basePricePerDay,
                                                     (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1,
                                                     ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked),
                                                     outsideFees, finalTotalPrice)
    End Sub

End Class
