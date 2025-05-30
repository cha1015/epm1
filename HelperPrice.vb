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

        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1

        ' Apply multi-day calculations
        Dim outsideFeesResult = ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked, eventStartTime, eventEndTime, openingTime, closingTime)
        Dim additionalCharges As Decimal = outsideFeesResult.Item1 * totalDays ' Extract and multiply correctly
        Dim warningMessages As String = outsideFeesResult.Item2

        If Not String.IsNullOrWhiteSpace(warningMessages) Then
            MessageBox.Show(warningMessages, "Extra Charges Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim servicesCost As Decimal = ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked) * totalDays
        Dim excessGuestCost As Decimal = If(numGuests > eventPlaceCapacity, (numGuests - eventPlaceCapacity) * 100 * totalDays, 0)
        Dim totalPrice As Decimal = (basePricePerDay * totalDays) + excessGuestCost + servicesCost + additionalCharges

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
                                              eventEndTime As DateTime, openingTime As DateTime, closingTime As DateTime) As Tuple(Of Decimal, String)
        If Not outsideHoursChecked Then Return Tuple.Create(0D, String.Empty)

        Dim additionalCharges As Decimal = 0D
        Dim perMinuteRate As Decimal = 17D
        Dim warningMessages As New List(Of String)

        If eventStartTime < openingTime Then
            Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
            additionalCharges += earlyMinutes * perMinuteRate
            warningMessages.Add($"Your event starts {earlyMinutes} minutes before opening. Extra fee: ₱{earlyMinutes * perMinuteRate}")
        End If

        If eventEndTime > closingTime Then
            Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
            additionalCharges += overtimeMinutes * perMinuteRate
            warningMessages.Add($"Your event ends {overtimeMinutes} minutes past closing. Extra fee: ₱{overtimeMinutes * perMinuteRate}")
        End If

        Return Tuple.Create(additionalCharges, String.Join(vbCrLf, warningMessages))
    End Function


    ' ------------------ Generate Price Breakdown ------------------
    Public Shared Function GeneratePriceBreakdown(numGuests As Integer, eventPlaceCapacity As Integer,
                                              basePricePerDay As Decimal, totalDays As Integer, additionalCharges As Decimal, finalTotalPrice As Decimal,
                                              chkCatering As Boolean, chkClown As Boolean, chkSinger As Boolean,
                                              chkDancer As Boolean, chkVideoke As Boolean) As String
        Dim breakdown As New StringBuilder()

        ' Base Price Breakdown
        breakdown.AppendLine($"Base Price: {totalDays} Days x ₱{basePricePerDay:F2} = ₱{basePricePerDay * totalDays:F2}")

        ' Excess Guest Fee Breakdown
        Dim excessGuests As Integer = Math.Max(0, numGuests - eventPlaceCapacity)
        Dim excessGuestCost As Decimal = excessGuests * 100D * totalDays
        If excessGuestCost > 0 Then
            breakdown.AppendLine($"Guest Capacity Exceeded Fee: {totalDays} Days x ({excessGuests} People x ₱100.00) = ₱{excessGuestCost:F2}")
        End If

        ' Individual Service Costs (Multiplied Per Day)
        Dim cateringCost As Decimal = If(chkCatering, numGuests * 400D * totalDays, 0D)
        Dim clownCost As Decimal = If(chkClown, numGuests * 200D * totalDays, 0D)
        Dim singerCost As Decimal = If(chkSinger, numGuests * 140D * totalDays, 0D)
        Dim dancerCost As Decimal = If(chkDancer, numGuests * 140D * totalDays, 0D)
        Dim videokeCost As Decimal = If(chkVideoke, numGuests * 20D * totalDays, 0D)
        Dim servicesCost As Decimal = cateringCost + clownCost + singerCost + dancerCost + videokeCost

        ' Services Breakdown (Multi-Day Adjusted)
        If cateringCost > 0 Then breakdown.AppendLine($"Catering: {totalDays} Days x ({numGuests} People x ₱400.00) = ₱{cateringCost:F2}")
        If clownCost > 0 Then breakdown.AppendLine($"Clown: {totalDays} Days x ({numGuests} People x ₱200.00) = ₱{clownCost:F2}")
        If singerCost > 0 Then breakdown.AppendLine($"Singer: {totalDays} Days x ({numGuests} People x ₱140.00) = ₱{singerCost:F2}")
        If dancerCost > 0 Then breakdown.AppendLine($"Dancer: {totalDays} Days x ({numGuests} People x ₱140.00) = ₱{dancerCost:F2}")
        If videokeCost > 0 Then breakdown.AppendLine($"Videoke: {totalDays} Days x ({numGuests} People x ₱20.00) = ₱{videokeCost:F2}")

        ' Outside Available Hours Fee Breakdown (Multiplied Per Day)
        Dim adjustedAdditionalCharges As Decimal = additionalCharges * totalDays
        If adjustedAdditionalCharges > 0 Then
            breakdown.AppendLine($"Outside Available Hours Fee: {totalDays} Days x ₱{additionalCharges:F2} = ₱{adjustedAdditionalCharges:F2}")
        End If

        ' Final Total Price
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

    Public Shared Sub UpdateTotalPriceAndGenerateBreakdown(txtNumGuests As TextBox, chkCatering As CheckBox, chkClown As CheckBox,
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

        Dim outsideFeesResult = ComputeOutsideHoursFee(chkOutsideAvailableHours.Checked, eventStartTime, eventEndTime, parsedOpeningTime, parsedClosingTime)
        Dim outsideFees As Decimal = outsideFeesResult.Item1
        Dim warningMessages As String = outsideFeesResult.Item2

        If Not String.IsNullOrWhiteSpace(warningMessages) Then
            MessageBox.Show(warningMessages, "Extra Charges Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        Dim excessGuestFee As Decimal = If(numGuests > eventPlaceCapacity, (numGuests - eventPlaceCapacity) * 100, 0)
        Dim extraServicesCost As Decimal = ComputeServicesCost(numGuests, chkCatering.Checked, chkClown.Checked, chkSinger.Checked, chkDancer.Checked, chkVideoke.Checked)

        Dim breakdown As New StringBuilder()
        breakdown.AppendLine($"Base Price: ₱{basePricePerDay:F2}")
        breakdown.AppendLine($"Guests: {numGuests} (Capacity: {eventPlaceCapacity})")

        If excessGuestFee > 0 Then breakdown.AppendLine($"Excess Guest Fee: ₱{excessGuestFee:F2}")
        If extraServicesCost > 0 Then breakdown.AppendLine($"Extra Services: ₱{extraServicesCost:F2}")
        If outsideFees > 0 Then breakdown.AppendLine($"Outside Available Hours Fee: ₱{outsideFees:F2}")

        breakdown.AppendLine($"Final Total Price: ₱{finalTotalPrice:F2}")

        lblPriceBreakdown.Text = breakdown.ToString()

    End Sub



End Class