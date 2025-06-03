Imports System.Globalization
Imports System.Text

Public Class HelperPrice
    ' ------------------ Compute Final Price ------------------
    Public Shared Function ComputeFinalPrice(numGuests As Integer, eventPlaceCapacity As Integer, basePricePerDay As Decimal,
                                         dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
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

        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1

        Dim outsideFees As Decimal = ComputeOutsideHoursFee(eventStartTime, eventEndTime, openingTime, closingTime)
        Dim additionalCharges As Decimal = outsideFees * totalDays

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
    Public Shared Function ComputeOutsideHoursFee(eventStartTime As DateTime, eventEndTime As DateTime,
                                              openingTime As DateTime, closingTime As DateTime) As Decimal
        Dim additionalCharges As Decimal = 0D
        Dim perMinuteRate As Decimal = 17D

        If eventStartTime < openingTime Then
            Dim earlyMinutes As Integer = Math.Max(0, CInt((openingTime - eventStartTime).TotalMinutes))
            additionalCharges += Math.Max(0, earlyMinutes * perMinuteRate)
        End If

        If eventEndTime > closingTime Then
            Dim overtimeMinutes As Integer = Math.Max(0, CInt((eventEndTime - closingTime).TotalMinutes))
            additionalCharges += Math.Max(0, overtimeMinutes * perMinuteRate)
        End If

        Return additionalCharges
    End Function



    ' ------------------ Generate Price Breakdown ------------------
    Public Shared Function GeneratePriceBreakdown(numGuests As Integer, eventPlaceCapacity As Integer,
                                                    basePricePerDay As Decimal, totalDays As Integer,
                                                    outsideFeePerDay As Decimal, finalTotalPrice As Decimal,
                                                    chkCatering As Boolean, chkClown As Boolean, chkSinger As Boolean,
                                                    chkDancer As Boolean, chkVideoke As Boolean) As String
        Dim breakdown As New StringBuilder()

        breakdown.AppendLine($"Base Price: {totalDays} Day/s x ₱{basePricePerDay:F2} = ₱{(basePricePerDay * totalDays):F2}")

        Dim excessGuests As Integer = Math.Max(0, numGuests - eventPlaceCapacity)
        Dim excessGuestCost As Decimal = excessGuests * 100D * totalDays
        If excessGuestCost > 0 Then
            breakdown.AppendLine($"Guest Capacity Exceeded Fee: {totalDays} Day/s x ({excessGuests} Pax x ₱100.00) = ₱{excessGuestCost:F2}")
        End If

        Dim cateringCost As Decimal = If(chkCatering, numGuests * 400D * totalDays, 0D)
        Dim clownCost As Decimal = If(chkClown, numGuests * 200D * totalDays, 0D)
        Dim singerCost As Decimal = If(chkSinger, numGuests * 140D * totalDays, 0D)
        Dim dancerCost As Decimal = If(chkDancer, numGuests * 140D * totalDays, 0D)
        Dim videokeCost As Decimal = If(chkVideoke, numGuests * 20D * totalDays, 0D)

        If cateringCost > 0 Then breakdown.AppendLine($"Catering: {totalDays} Day/s x ({numGuests} Pax x ₱400.00) = ₱{cateringCost:F2}")
        If clownCost > 0 Then breakdown.AppendLine($"Clown: {totalDays} Day/s x ({numGuests} Pax x ₱200.00) = ₱{clownCost:F2}")
        If singerCost > 0 Then breakdown.AppendLine($"Singer: {totalDays} Day/s x ({numGuests} Pax x ₱140.00) = ₱{singerCost:F2}")
        If dancerCost > 0 Then breakdown.AppendLine($"Dancer: {totalDays} Day/s x ({numGuests} Pax x ₱140.00) = ₱{dancerCost:F2}")
        If videokeCost > 0 Then breakdown.AppendLine($"Videoke: {totalDays} Day/s x ({numGuests} Pax x ₱20.00) = ₱{videokeCost:F2}")

        Dim adjustedOutsideFee As Decimal = outsideFeePerDay * totalDays
        If adjustedOutsideFee > 0 Then
            breakdown.AppendLine($"Outside Available Hours Fee: {totalDays} Day/s x ₱{outsideFeePerDay:F2} = ₱{adjustedOutsideFee:F2}")
        End If

        breakdown.AppendLine($"TOTAL: ₱{finalTotalPrice:F2}")

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

    Public Shared Sub UpdateTotalPriceAndGenerateBreakdown(
             txtNumGuests As TextBox,
             chkCatering As CheckBox,
             chkClown As CheckBox,
             chkSinger As CheckBox,
             chkDancer As CheckBox,
             chkVideoke As CheckBox,
             cbStartHour As ComboBox,
             cbStartMinutes As ComboBox,
             cbStartAMPM As ComboBox,
             cbEndHour As ComboBox,
             cbEndMinutes As ComboBox,
             cbEndAMPM As ComboBox,
             openingHours As String,
             closingHours As String,
             dtpEventDateStart As DateTimePicker,
             dtpEventDateEnd As DateTimePicker,
             eventPlaceCapacity As Integer,
             basePricePerDay As Decimal,
             lblTotalPricePaymentContainer As Label,
             dgvPriceBreakdown As DataGridView,
             txtTotalPrice As TextBox)

        Dim numGuests As Integer
        If Not Integer.TryParse(txtNumGuests.Text, numGuests) Then numGuests = 0

        Dim finalTotalPrice As Decimal = ComputeFinalPrice(numGuests, eventPlaceCapacity, basePricePerDay,
                                                        dtpEventDateStart, dtpEventDateEnd,
                                                        cbStartHour, cbStartMinutes, cbStartAMPM,
                                                        cbEndHour, cbEndMinutes, cbEndAMPM,
                                                        openingHours, closingHours,
                                                        chkCatering, chkClown, chkSinger, chkDancer, chkVideoke)

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

        Dim outsideFees As Decimal = ComputeOutsideHoursFee(eventStartTime, eventEndTime, parsedOpeningTime, parsedClosingTime)

        Dim startTime, endTime, openingTime, closingTime As DateTime
        If Not DateTime.TryParseExact(startInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, startTime) Then
            MessageBox.Show("Invalid start time format. Please re-enter correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not DateTime.TryParseExact(endInput, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, endTime) Then
            MessageBox.Show("Invalid end time format. Please re-enter correctly.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not DateTime.TryParse(openingHours, openingTime) Then
            MessageBox.Show("Invalid opening hours format. Please check the venue's schedule.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not DateTime.TryParse(closingHours, closingTime) Then
            MessageBox.Show("Invalid closing hours format. Please check the venue's schedule.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim totalDays As Integer = (dtpEventDateEnd.Value - dtpEventDateStart.Value).Days + 1

        Dim basePriceTotal As Decimal = basePricePerDay * totalDays
        Dim extraGuestCount As Integer = Math.Max(0, numGuests - eventPlaceCapacity)
        Dim extraGuestFeeTotal As Decimal = extraGuestCount * 100 * totalDays
        Dim outsideFeeTotal As Decimal = outsideFees * totalDays

        Dim cateringCost As Decimal = If(chkCatering.Checked, 400D * numGuests * totalDays, 0D)
        Dim clownCost As Decimal = If(chkClown.Checked, 200D * numGuests * totalDays, 0D)
        Dim singerCost As Decimal = If(chkSinger.Checked, 140D * numGuests * totalDays, 0D)
        Dim dancerCost As Decimal = If(chkDancer.Checked, 140D * numGuests * totalDays, 0D)
        Dim videokeCost As Decimal = If(chkVideoke.Checked, 20D * numGuests * totalDays, 0D)

        txtTotalPrice.Text = "₱" & finalTotalPrice.ToString("F2")
        lblTotalPricePaymentContainer.Text = txtTotalPrice.Text
        lblTotalPricePaymentContainer.Tag = finalTotalPrice

        dgvPriceBreakdown.Columns.Clear()
        dgvPriceBreakdown.Rows.Clear()

        dgvPriceBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPriceBreakdown.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgvPriceBreakdown.Columns.Add("Item", "Item")
        dgvPriceBreakdown.Columns.Add("BaseCost", "Base Cost")
        dgvPriceBreakdown.Columns.Add("Days", "Days")
        dgvPriceBreakdown.Columns.Add("Quantity", "Quantity")
        dgvPriceBreakdown.Columns.Add("Subtotal", "Subtotal")

        dgvPriceBreakdown.Rows.Add("Event Place Base Price", "₱" & basePricePerDay.ToString("F2"),
                                   totalDays.ToString(), "1", "₱" & basePriceTotal.ToString("F2"))

        If extraGuestFeeTotal > 0 Then
            dgvPriceBreakdown.Rows.Add("Capacity Exceedance Fee", "₱100.00",
                                       totalDays.ToString(), extraGuestCount.ToString(), "₱" & extraGuestFeeTotal.ToString("F2"))
        End If

        If outsideFeeTotal > 0 Then
            dgvPriceBreakdown.Rows.Add("Outside Available Hours Fee", "₱" & outsideFees.ToString("F2"),
                                       totalDays.ToString(), "1", "₱" & outsideFeeTotal.ToString("F2"))
        End If

        If cateringCost > 0 Then
            dgvPriceBreakdown.Rows.Add("Catering", "₱400.00", totalDays.ToString(), numGuests.ToString(), "₱" & cateringCost.ToString("F2"))
        End If
        If clownCost > 0 Then
            dgvPriceBreakdown.Rows.Add("Clown", "₱200.00", totalDays.ToString(), numGuests.ToString(), "₱" & clownCost.ToString("F2"))
        End If
        If singerCost > 0 Then
            dgvPriceBreakdown.Rows.Add("Singer", "₱140.00", totalDays.ToString(), numGuests.ToString(), "₱" & singerCost.ToString("F2"))
        End If
        If dancerCost > 0 Then
            dgvPriceBreakdown.Rows.Add("Dancer", "₱140.00", totalDays.ToString(), numGuests.ToString(), "₱" & dancerCost.ToString("F2"))
        End If
        If videokeCost > 0 Then
            dgvPriceBreakdown.Rows.Add("Videoke", "₱20.00", totalDays.ToString(), numGuests.ToString(), "₱" & videokeCost.ToString("F2"))
        End If

        Dim finalRowIndex As Integer = dgvPriceBreakdown.Rows.Add("Overall Total Price", "", "", "", "₱" & finalTotalPrice.ToString("F2"))

        With dgvPriceBreakdown
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.Font = New Font("Poppins", 8)
        End With


    End Sub

End Class