Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Security.Principal
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormAdminCenter

    Private Sub FormAdminCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Location = New Point(flpEventPlaces.Right - btnAdd.Width, flpEventPlaces.Bottom - btnAdd.Height)
        btnAdd.Parent = tpBookings
        btnAdd.BringToFront()

        HelperNavigation.RegisterNewForm(Me)

        lblUsername.Text = CurrentUser.Username

        LoadSearchResults()          ' Event Places (with update/delete)
        LoadPendingBookings()        ' Pending Bookings (with Approve/Reject)
        LoadApprovedBookings()       ' Approved Bookings
        LoadRejectedBookings()       ' Rejected Bookings
        LoadAllBookings()            ' All Bookings
        LoadRevenueReports()         ' Revenue per Event Place
        LoadInvoices()               ' Invoices with Accept Payment
        LoadCustomerCount()          ' Customer Count
        LoadCustomerRecords()        ' Customer Records

        Dim labels = {lblEventPlace, lblEventType, lblCapacity, lblPricePerDay, lblFeatures, lblImageUrl, lblOpeningHours, lblClosingHours, lblAvailableDays, lblDescription}
        Dim fields = {txtEventPlace, txtEventType, txtCapacity, txtPricePerDay, txtFeatures, txtImageUrl, txtOpeningHours, txtClosingHours, txtAvailableDays, txtDescription}
        Dim texts = {"Event Place", "Event Type", "Capacity", "Price per Day", "Features", "Image URL", "Opening Hours", "Closing Hours", "Available Days", "Description"}

        HelperValidation.ApplyFieldIndicators(labels, texts)

        For Each field In fields
            AddHandler field.TextChanged, Sub(senderObj, args) HelperValidation.ValidateFieldsInRealTime(fields, labels, texts)
            AddHandler field.Leave, Sub(senderObj, args) HelperValidation.RemoveAsteriskOnInput(senderObj, labels, texts)
        Next

        SetupEventPlaceManagementUI()
    End Sub

    Private Sub SetupEventPlaceManagementUI()
        Dim btnAddEventPlace As New Button()
        btnAddEventPlace.Text = "Add New Event Place"
        btnAddEventPlace.Size = New Size(200, 30)
        btnAddEventPlace.Location = New Point(flpEventPlaces.Left, flpEventPlaces.Top - 40)
        AddHandler btnAddEventPlace.Click, AddressOf btnAdd_Click
        Me.Controls.Add(btnAddEventPlace)

        LoadSearchResults()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addForm As New FormAddEventPlace()
        addForm.ShowDialog()
        LoadSearchResults()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(btn.Tag, DataRow)

        Dim updateForm As New FormUpdateEventPlace()
        updateForm.SelectedPlaceId = Convert.ToInt32(row("place_id"))
        updateForm.ShowDialog()

        LoadSearchResults()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(btn.Tag, DataRow)

        If HasActiveBookings(txtPlaceID.Text) Then
            MessageBox.Show("Cannot delete event place with active bookings.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event place?", "Delete Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim placeId As Integer = Convert.ToInt32(row("place_id"))
            Dim query As String = "DELETE FROM eventplace WHERE place_id = @place_id"
            Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, New Dictionary(Of String, Object) From {{"@place_id", placeId}})

            If rowsAffected > 0 Then
                MessageBox.Show("Event place deleted successfully.")
            Else
                MessageBox.Show("Failed to delete event place.")
            End If
        End If

        LoadSearchResults()
    End Sub

#Region "Data Loading using HelperResultsDisplay (FlowLayoutPanels)"

    Public Sub LoadSearchResults()
        Dim query As String = "SELECT place_id, event_place, event_type, capacity, price_per_day, description, image_url, " &
                              "CASE WHEN EXISTS (SELECT 1 FROM bookings WHERE bookings.place_id = eventplace.place_id) " &
                              "THEN 'Booked' ELSE 'Available' END AS status " &
                              "FROM eventplace WHERE 1=1"
        Dim dt As New DataTable()
        Using connection As MySqlConnection = DBHelper.GetConnection()
            Using cmd As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(cmd)
                Try
                    connection.Open()
                    dt.Clear()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error loading event places: " & ex.Message)
                End Try
            End Using
        End Using

        Dim currentRoleIsAdmin As Boolean = CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase)
        HelperResultsDisplay.PopulateEventPlaces(flpEventPlaces, dt, Nothing, AddressOf btnUpdate_Click, AddressOf btnDelete_Click, currentRoleIsAdmin)

    End Sub

    Private Sub LoadPendingBookings()
        Dim query As String = "SELECT b.booking_id, c.name, e.event_place, b.event_date, b.event_time, b.event_end_time, b.total_price, b.status " &
                          "FROM bookings b " &
                          "JOIN customers c ON b.customer_id = c.customer_id " &
                          "JOIN eventplace e ON b.place_id = e.place_id " &
                          "WHERE b.status = 'Pending' ORDER BY b.event_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        HelperResultsDisplay.PopulatePendingBookings(flpPending, dt, AddressOf ApproveBooking_Click, AddressOf RejectBooking_Click, Me)
    End Sub

    Private Sub LoadApprovedBookings()
        Dim query As String = "SELECT b.booking_id, c.name, e.event_place, b.event_date, b.event_time, b.event_end_time, b.total_price, b.status " &
                          "FROM bookings b " &
                          "JOIN customers c ON b.customer_id = c.customer_id " &
                          "JOIN eventplace e ON b.place_id = e.place_id " &
                          "WHERE b.status = 'Approved' ORDER BY b.event_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        HelperResultsDisplay.PopulateApprovedBookings(flpApproved, dt)
    End Sub

    Private Sub LoadAllBookings()
        Dim query As String = "SELECT b.booking_id, c.name, e.event_place, b.event_date, b.event_time, b.event_end_time, b.total_price, b.status " &
                          "FROM bookings b " &
                          "JOIN customers c ON b.customer_id = c.customer_id " &
                          "JOIN eventplace e ON b.place_id = e.place_id ORDER BY b.event_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        HelperResultsDisplay.PopulateAllBookings(flpAll, dt)
    End Sub


    Private Sub LoadRejectedBookings()
        Dim query As String = "SELECT b.booking_id, c.name, e.event_place, b.event_date, b.event_time, b.event_end_time, b.total_price, b.status " &
                          "FROM bookings b " &
                          "JOIN customers c ON b.customer_id = c.customer_id " &
                          "JOIN eventplace e ON b.place_id = e.place_id " &
                          "WHERE b.status = 'Rejected' ORDER BY b.event_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        HelperResultsDisplay.PopulateRejectedBookings(flpRejected, dt)
    End Sub

    Private Sub LoadRevenueReports()
        Dim query As String = "SELECT e.event_place, " &
                          "IFNULL(SUM(b.total_price), 0) AS total_revenue " &
                          "FROM eventplace e " &
                          "LEFT JOIN bookings b ON e.place_id = b.place_id AND b.status = 'Approved' " &
                          "GROUP BY e.place_id"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateRevenueReports(flpRevenueReports, dt)
    End Sub


    Private Sub LoadInvoices()
        Dim query As String = "SELECT invoice_id, user_id, event_place, total_amount, payment_status, invoice_date
        FROM invoices
        WHERE payment_status = 'Pending'
        ORDER BY invoice_date ASC
        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateInvoices(flpInvoices, dt, AddressOf AcceptPayment_Click)
    End Sub

    Public Shared Function LoadBookedDates(placeId As Integer) As List(Of Date)
        Dim bookedDates As New List(Of Date)
        Dim query As String = "SELECT event_date, event_end_date FROM Bookings WHERE place_id = @place_id"

        Dim params As New Dictionary(Of String, Object) From {{"@place_id", placeId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, params)
        For Each row As DataRow In dt.Rows
            Dim startDate As Date = Convert.ToDateTime(row("event_date"))
            Dim endDate As Date = Convert.ToDateTime(row("event_end_date"))

            For Each d As Date In Enumerable.Range(0, (endDate - startDate).Days + 1).Select(Function(i) startDate.AddDays(i))
                bookedDates.Add(d)
            Next
        Next

        Return bookedDates
    End Function

    Private Sub LoadCustomerCount()
        Dim query As String = "SELECT COUNT(*) FROM customers"
        Dim count As Object = DBHelper.ExecuteScalarQuery(query, New Dictionary(Of String, Object))
        lblNumCustomersContainer.Text = If(count IsNot Nothing, count.ToString(), "0")
    End Sub

    Private Sub LoadCustomerRecords()
        Dim query As String = "SELECT customer_id, name, age, birthday, sex, address FROM customers ORDER BY name ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateCustomerRecords(flpCustomerRecords, dt)
    End Sub

#End Region

#Region "Data Updates Based on Selected Date"

    '--- Update Revenue Reports for the selected date
    Private Sub UpdateRevenueReports(selectedDate As Date)
        Dim query As String = "SELECT e.event_place, " &
                          "IFNULL(SUM(b.total_price), 0) AS total_revenue " &
                          "FROM eventplace e " &
                          "LEFT JOIN bookings b ON e.place_id = b.place_id AND b.status='Approved' AND b.event_date = @selectedDate " &
                          "GROUP BY e.place_id"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object) From {{"@selectedDate", selectedDate}})
        HelperResultsDisplay.PopulateRevenueReports(flpRevenueReports, dt)
    End Sub


    '--- Update Pending Bookings for the selected date
    Private Sub UpdatePendingBookings(selectedDate As Date)
        Dim query As String = "SELECT b.booking_id, c.name, e.event_place, b.event_date, b.event_time, b.event_end_time, b.total_price, b.status " &
                              "FROM bookings b " &
                              "JOIN customers c ON b.customer_id = c.customer_id " &
                              "JOIN eventplace e ON b.place_id = e.place_id " &
                              "WHERE b.status = 'Pending' AND b.event_date = @selectedDate " &
                              "ORDER BY b.event_date ASC"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object) From {{"@selectedDate", selectedDate}})
        HelperResultsDisplay.PopulatePendingBookings(flpPending, dt, AddressOf ApproveBooking_Click, AddressOf RejectBooking_Click, Me)
    End Sub

#End Region

#Region "Event Handlers for Booking Approval/Payment"

    '--- Approve individual booking
    Private Sub ApproveBooking_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(btn.Tag, DataRow)
        Dim bookingId As Object = row("booking_id")
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery("UPDATE bookings SET status='Approved' WHERE booking_id=@id",
                                                              New Dictionary(Of String, Object) From {{"@id", bookingId}})
        If rowsAffected > 0 Then
            MessageBox.Show("Booking approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to approve booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        LoadPendingBookings()
        ' After approving or rejecting the booking, reload the panels
        LoadApprovedBookings()
        LoadRejectedBookings()
        LoadAllBookings()
    End Sub

    '--- Reject individual booking
    Private Sub RejectBooking_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(btn.Tag, DataRow)
        Dim bookingId As Object = row("booking_id")
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery("UPDATE bookings SET status='Rejected' WHERE booking_id=@id",
                                                              New Dictionary(Of String, Object) From {{"@id", bookingId}})
        If rowsAffected > 0 Then
            MessageBox.Show("Booking rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to reject booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        LoadPendingBookings()

        LoadApprovedBookings()
        LoadRejectedBookings()
        LoadAllBookings()
    End Sub

    '--- Accept payment for an invoice
    Private Sub AcceptPayment_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(btn.Tag, DataRow)
        Dim invoiceId As Object = row("invoice_id")
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery("UPDATE invoices SET payment_status='Paid' WHERE invoice_id=@id",
                                                              New Dictionary(Of String, Object) From {{"@id", invoiceId}})
        If rowsAffected > 0 Then
            MessageBox.Show("Payment accepted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to accept payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        LoadInvoices()
    End Sub

#End Region

#Region "Event Place Add/Update/Delete and Field Validation"

    Private Function EventPlaceExists(eventPlaceName As String) As Boolean
        Dim result As Object = DBHelper.ExecuteScalarQuery("SELECT COUNT(*) FROM eventplace WHERE event_place=@name",
                                                            New Dictionary(Of String, Object) From {{"@name", eventPlaceName}})
        Return Convert.ToInt32(result) > 0
    End Function

    Private Function HasActiveBookings(placeID As String) As Boolean
        Dim result As Object = DBHelper.ExecuteScalarQuery("SELECT COUNT(*) FROM bookings WHERE place_id=@id AND status='Approved'",
                                                            New Dictionary(Of String, Object) From {{"@id", placeID}})
        Return Convert.ToInt32(result) > 0
    End Function


    Private Sub txtCapacity_Validating(sender As Object, e As EventArgs) Handles txtCapacity.Leave
        HelperValidation.IsValidNumericField(txtCapacity, lblErrorCapacity, "Capacity must be a number.")
    End Sub

    Private Sub txtPricePerDay_Validating(sender As Object, e As EventArgs) Handles txtPricePerDay.Leave
        HelperValidation.IsValidNumericField(txtPricePerDay, lblErrorPrice, "Price must be a number.")
    End Sub

    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress, txtPricePerDay.KeyPress
        HelperValidation.NumericOnly_KeyPress(sender, e)
    End Sub

    Private Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress, txtPricePerDay.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#End Region

    Private bookingDetailsForm As FormBookingDetails

    Public Sub ShowBookingDetails(ByVal row As DataRow)
        If bookingDetailsForm Is Nothing OrElse bookingDetailsForm.IsDisposed Then
            bookingDetailsForm = New FormBookingDetails()
        End If

        Dim bookingId As Integer = Convert.ToInt32(row("booking_id"))
        Debug.Print("Booking ID: " & bookingId.ToString())

        bookingDetailsForm.LoadBookingDetails(bookingId)
        bookingDetailsForm.ShowDialog()
    End Sub


    Public Sub HideBookingDetails()
        ' Close the booking details form when the mouse button is released
        If bookingDetailsForm IsNot Nothing AndAlso bookingDetailsForm.Visible Then
            bookingDetailsForm.Hide()
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CurrentUser.UserID = -1
            CurrentUser.Username = String.Empty
            CurrentUser.Email = String.Empty
            CurrentUser.Role = String.Empty
            CurrentUser.CustomerId = -1

            Me.Refresh()
            Application.DoEvents()

            Dim mainForm As New FormMain()
            mainForm.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub LogError(errorMessage As String)
        Using writer As New StreamWriter("error_log.txt", True)
            writer.WriteLine($"{DateTime.Now}: {errorMessage}")
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub
    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New FormCustomerAdminInfo(CurrentUser.UserID)
        editForm.ShowDialog()
    End Sub


End Class
