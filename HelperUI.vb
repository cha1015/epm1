Imports System.Globalization
Imports System.IO
Imports System.Drawing

Public Class HelperUI
    ' ------------------ Update Payment Details ------------------
    Public Shared Sub UpdatePaymentDetails(lblCustomerContainer As Label, lblEventPlacePaymentContainer As Label, lblEventTypePaymentContainer As Label,
                                           cbEventType As ComboBox, lblNumGuestsPaymentContainer As Label, txtNumGuests As TextBox,
                                           cbSameDayEvent As CheckBox, dtpEventDateStart As DateTimePicker, dtpEventDateEnd As DateTimePicker,
                                           lblEventDatePaymentContainer As Label, cbStartHour As ComboBox, cbStartMinutes As ComboBox, cbStartAMPM As ComboBox,
                                           cbEndHour As ComboBox, cbEndMinutes As ComboBox, cbEndAMPM As ComboBox,
                                           lblEventTimePaymentContainer As Label, lblTotalPricePaymentContainer As Label, txtTotalPrice As TextBox,
                                           txtCustomerName As TextBox, eventPlaceName As String)

        lblCustomerContainer.Text = If(String.IsNullOrWhiteSpace(txtCustomerName.Text), "Not Provided", txtCustomerName.Text)
        lblEventPlacePaymentContainer.Text = If(String.IsNullOrWhiteSpace(eventPlaceName), "Unknown Venue", eventPlaceName)
        lblEventTypePaymentContainer.Text = If(String.IsNullOrWhiteSpace(cbEventType.Text), "Not Selected", cbEventType.Text)
        lblNumGuestsPaymentContainer.Text = If(String.IsNullOrWhiteSpace(txtNumGuests.Text), "0", txtNumGuests.Text)

        lblEventDatePaymentContainer.Text = If(cbSameDayEvent.Checked, dtpEventDateStart.Value.ToShortDateString(),
                                               $"{dtpEventDateStart.Value.ToShortDateString()} - {dtpEventDateEnd.Value.ToShortDateString()}")

        lblEventTimePaymentContainer.Text = If(String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
                                               String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse String.IsNullOrWhiteSpace(cbEndAMPM.Text),
                                               "Time Not Set",
                                               $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text} - {cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}")

        lblTotalPricePaymentContainer.Text = If(String.IsNullOrWhiteSpace(txtTotalPrice.Text), "₱0.00", txtTotalPrice.Text)
    End Sub

    ' ------------------ Load Event Place Image ------------------
    Public Shared Sub LoadEventPlaceImage(imgPath As String, pb As PictureBox)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        Dim defaultImagePath As String = "C:\event images\No Image.png"
        Dim fullImagePath As String = If(String.IsNullOrWhiteSpace(imgPath), defaultImagePath, imgPath.Trim())

        Try
            If File.Exists(fullImagePath) Then
                pb.Image = Image.FromFile(fullImagePath)
            Else
                pb.Image = Image.FromFile(defaultImagePath)
                MessageBox.Show($"File not found: {fullImagePath}. Using fallback image.", "Image Load Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As OutOfMemoryException
            MessageBox.Show("Error: The image file format is not supported.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pb.Image = Image.FromFile(defaultImagePath)
        Catch ex As FileNotFoundException
            MessageBox.Show("Error: The specified image file does not exist.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pb.Image = Image.FromFile(defaultImagePath)
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pb.Image = Image.FromFile(defaultImagePath)
        End Try
    End Sub
End Class

