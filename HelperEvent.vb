Imports System.Globalization

Public Class HelperEvent
    ' ------------------ Update Event End Date ------------------
    Public Shared Sub UpdateEventEndDate(cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                     cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                     dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                     cbSameDayEvent As CheckBox)

        Dim startTimeStr As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim endTimeStr As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime

        If Not DateTime.TryParseExact(startTimeStr, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) OrElse
       Not DateTime.TryParseExact(endTimeStr, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            MessageBox.Show("Invalid time format. Please select a valid time.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If eventEndTime <= eventStartTime Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
            cbSameDayEvent.Checked = False
        Else
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            cbSameDayEvent.Checked = True
        End If
    End Sub

    ' ------------------ Adjust End Date for Overnight Event ------------------
    Public Shared Sub AdjustEndDateForOvernightEvent(cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                                     cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                                     dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                                     cbSameDayEvent As CheckBox, lblEventDatePaymentContainer As Label)

        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse
           String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse
           String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then Exit Sub

        Dim startTimeStr As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim endTimeStr As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        Dim eventStartTime As DateTime
        Dim eventEndTime As DateTime

        If Not DateTime.TryParseExact(startTimeStr, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventStartTime) OrElse
           Not DateTime.TryParseExact(endTimeStr, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, eventEndTime) Then
            MessageBox.Show("Invalid time format. Please select a valid time.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If eventEndTime < eventStartTime Then
            cbSameDayEvent.Checked = False
            dtpEventDateEnd.Value = dtpEventDateStart.Value.AddDays(1)
            dtpEventDateEnd.Enabled = False
        Else
            cbSameDayEvent.Checked = True
            dtpEventDateEnd.Value = dtpEventDateStart.Value
            dtpEventDateEnd.Enabled = True
        End If

        lblEventDatePaymentContainer.Text = If(cbSameDayEvent.Checked,
                                               dtpEventDateStart.Value.ToShortDateString(),
                                               $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}")
    End Sub

    ' ------------------ Handle End Hour Change ------------------
    Public Shared Sub HandleEndHourChange(cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                          cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                          dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                          cbSameDayEvent As CheckBox)
        UpdateEventEndDate(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, dtpEventDateStart, dtpEventDateEnd, cbSameDayEvent)
    End Sub

    ' ------------------ Handle Event Start Date Change ------------------
    Public Shared Sub HandleEventStartDateChange(dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker, cbSameDayEvent As CheckBox)
        If cbSameDayEvent.Checked Then
            dtpEventDateEnd.Value = dtpEventDateStart.Value
        End If
    End Sub

    ' ------------------ Format Available Days ------------------
    Public Shared Function FormatAvailableDays(daysString As String) As String
        Dim days As String() = If(String.IsNullOrWhiteSpace(daysString), New String() {}, daysString.Split(","c).Select(Function(d) d.Trim()).ToArray())
        Dim dayNames As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

        Dim sortedDays As List(Of String) = days.OrderBy(Function(d) Array.IndexOf(dayNames, d)).ToList()

        If sortedDays.Count = 7 Then Return "All Week"
        If sortedDays.Count = 1 Then Return sortedDays.First()
        If sortedDays.Count = 2 Then Return $"{sortedDays(0)} & {sortedDays(1)}"

        Return String.Join(", ", sortedDays)
    End Function

End Class
