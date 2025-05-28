Public Class FormBookingDetails

    Public Sub LoadBookingDetails(bookingId As Integer)
        ' Retrieve booking details from the database using the HelperDatabase method
        Dim dt As DataTable = HelperDatabase.GetBookingDetails(bookingId)

        If dt.Rows.Count > 0 Then
            ' Populate the form with the retrieved booking details
            lblCustomerName.Text = "Customer: " & dt.Rows(0)("customer_name").ToString()
            lblEventPlace.Text = "Event Place: " & dt.Rows(0)("event_place").ToString()
            lblEventType.Text = "Event Type: " & dt.Rows(0)("event_type").ToString()
            lblNumGuests.Text = "Guests: " & dt.Rows(0)("num_guests").ToString()
            lblEventDate.Text = "Event Date: " & Convert.ToDateTime(dt.Rows(0)("event_date")).ToString("MM/dd/yyyy") &
                            " to " & Convert.ToDateTime(dt.Rows(0)("event_end_date")).ToString("MM/dd/yyyy")
            lblEventTime.Text = "Event Time: " & dt.Rows(0)("event_time").ToString() & " - " & dt.Rows(0)("event_end_time").ToString()
            lblServices.Text = "Services: " & dt.Rows(0)("services_availed").ToString()
            lblTotalPrice.Text = "Total Price: ₱" & dt.Rows(0)("total_price").ToString()
            lblPaymentStatus.Text = "Payment Status: " & dt.Rows(0)("payment_status").ToString()
        Else
            MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub FormBookingDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
