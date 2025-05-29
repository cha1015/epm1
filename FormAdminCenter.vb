Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Security.Principal
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormAdminCenter

    Private Sub FormAdminCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelperNavigation.RegisterNewForm(Me)
        lblUsername.Text = CurrentUser.Username

        ' Load all datasets into FlowLayoutPanels:
        LoadSearchResults()          ' Event Places (with update/delete)
        LoadPendingBookings()        ' Pending Bookings (with Approve/Reject)
        LoadApprovedBookings()       ' Approved Bookings
        LoadRejectedBookings()       ' Rejected Bookings
        LoadAllBookings()            ' All Bookings
        LoadAvailability()           ' Availability of Event Places
        LoadRevenueReports()         ' Revenue per Event Place
        LoadInvoices()               ' Invoices with Accept Payment
        LoadCustomerCount()          ' Customer Count
        LoadCustomerRecords()        ' Customer Records

        ' Set up field indicators and validation for event place data entry.
        Dim labels = {lblEventPlace, lblEventType, lblCapacity, lblPricePerDay, lblFeatures, lblImageUrl, lblOpeningHours, lblClosingHours, lblAvailableDays, lblDescription}
        Dim fields = {txtEventPlace, txtEventType, txtCapacity, txtPricePerDay, txtFeatures, txtImageUrl, txtAvailableDays, txtDescription}
        Dim texts = {"Event Place", "Event Type", "Capacity", "Price per Day", "Features", "Image URL", "Opening Hours", "Closing Hours", "Available Days", "Description"}

        HelperValidation.ApplyFieldIndicators(labels, texts)

        For Each field In fields
            AddHandler field.TextChanged, Sub(senderObj, args) HelperValidation.ValidateFieldsInRealTime(fields, labels, texts)
            AddHandler field.Leave, Sub(senderObj, args) HelperValidation.RemoveAsteriskOnInput(senderObj, labels, texts)
        Next
    End Sub

    ' Add DateChanged event handler for the MonthCalendar control

#Region "Data Loading using HelperResultsDisplay (FlowLayoutPanels)"

    '--- Load Event Places (Search Results)
    Private Sub LoadSearchResults()
        ' Updated query to calculate status dynamically
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

        ' Separate available and booked event places
        Dim availablePlaces As DataTable = dt.Clone()
        Dim bookedPlaces As DataTable = dt.Clone()

        For Each row As DataRow In dt.Rows
            If row("status").ToString() = "Available" Then
                availablePlaces.ImportRow(row)
            Else
                bookedPlaces.ImportRow(row)
            End If
        Next

        ' Populate available event places into flpAvailable
        HelperResultsDisplay.PopulateEventPlacesForAdmin(flpAvailable, availablePlaces, True,
                                                     txtEventPlace, txtEventType, txtCapacity,
                                                     txtPricePerDay, txtFeatures, txtImageUrl,
                                                     cbStartHour, cbStartMinutes, cbStartAMPM,
                                                     cbEndHour, cbEndMinutes, cbEndAMPM,
                                                     txtAvailableDays, txtDescription,
                                                     txtPlaceID, btnUpdate, btnDelete)

        ' Populate booked event places into flpBooked
        HelperResultsDisplay.PopulateEventPlacesForAdmin(flpBooked, bookedPlaces, False,
                                                     txtEventPlace, txtEventType, txtCapacity,
                                                     txtPricePerDay, txtFeatures, txtImageUrl,
                                                     cbStartHour, cbStartMinutes, cbStartAMPM,
                                                     cbEndHour, cbEndMinutes, cbEndAMPM,
                                                     txtAvailableDays, txtDescription,
                                                     txtPlaceID, btnUpdate, btnDelete)
    End Sub


    '--- Load Pending Bookings
    Private Sub LoadPendingBookings()
        Dim query As String = "SELECT 
                            b.booking_id, 
                            c.name, 
                            e.event_place, 
                            b.event_type, 
                            b.num_guests, 
                            e.image_url, 
                            b.event_date, 
                            b.event_time, 
                            b.event_end_time, 
                            b.event_end_date, 
                            b.total_price, 
                            b.status, 
                            GROUP_CONCAT(s.service_name ORDER BY s.service_name) AS services_availed
                        FROM 
                            bookings b
                        JOIN 
                            customers c ON b.customer_id = c.customer_id
                        JOIN 
                            eventplace e ON b.place_id = e.place_id
                        LEFT JOIN 
                            bookingservices bs ON b.booking_id = bs.booking_id
                        LEFT JOIN 
                            services s ON bs.service_id = s.service_id
                        WHERE 
                            b.status = 'Pending' 
                        GROUP BY 
                            b.booking_id, c.name, e.event_place, b.event_type, b.num_guests, e.image_url, 
                            b.event_date, b.event_time, b.event_end_time, b.event_end_date, b.total_price, b.status
                        ORDER BY 
                            b.event_date ASC
                        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Populate the pending bookings panel
        HelperResultsDisplay.PopulatePendingBookings(flpPending, dt, AddressOf ApproveBooking_Click, AddressOf RejectBooking_Click, Me)
        flpPending.Refresh()

        ' Update the tab label based on the number of pending bookings
        UpdateTabLabel(tpPendings, flpPending)
    End Sub

    Private Sub LoadApprovedBookings()
        Dim query As String = "SELECT 
                            b.booking_id, 
                            c.name, 
                            e.event_place, 
                            b.event_type, 
                            b.num_guests, 
                            e.image_url, 
                            b.event_date, 
                            b.event_time, 
                            b.event_end_time, 
                            b.event_end_date, 
                            b.total_price, 
                            b.status, 
                            GROUP_CONCAT(s.service_name ORDER BY s.service_name) AS services_availed
                        FROM 
                            bookings b
                        JOIN 
                            customers c ON b.customer_id = c.customer_id
                        JOIN 
                            eventplace e ON b.place_id = e.place_id
                        LEFT JOIN 
                            bookingservices bs ON b.booking_id = bs.booking_id
                        LEFT JOIN 
                            services s ON bs.service_id = s.service_id
                        WHERE 
                            b.status = 'Approved' 
                        GROUP BY 
                            b.booking_id, c.name, e.event_place, b.event_type, b.num_guests, e.image_url, 
                            b.event_date, b.event_time, b.event_end_time, b.event_end_date, b.total_price, b.status
                        ORDER BY 
                            b.event_date ASC
                        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Populate the approved bookings panel
        HelperResultsDisplay.PopulateApprovedBookings(flpApproved, dt)

        ' Update the tab label based on the number of approved bookings
        UpdateTabLabel(tpApproved, flpApproved)
    End Sub

    Private Sub LoadRejectedBookings()
        Dim query As String = "SELECT 
                            b.booking_id, 
                            c.name, 
                            e.event_place, 
                            b.event_type, 
                            b.num_guests, 
                            e.image_url, 
                            b.event_date, 
                            b.event_time, 
                            b.event_end_time, 
                            b.event_end_date, 
                            b.total_price, 
                            b.status, 
                            GROUP_CONCAT(s.service_name ORDER BY s.service_name) AS services_availed
                        FROM 
                            bookings b
                        JOIN 
                            customers c ON b.customer_id = c.customer_id
                        JOIN 
                            eventplace e ON b.place_id = e.place_id
                        LEFT JOIN 
                            bookingservices bs ON b.booking_id = bs.booking_id
                        LEFT JOIN 
                            services s ON bs.service_id = s.service_id
                        WHERE 
                            b.status = 'Rejected' 
                        GROUP BY 
                            b.booking_id, c.name, e.event_place, b.event_type, b.num_guests, e.image_url, 
                            b.event_date, b.event_time, b.event_end_time, b.event_end_date, b.total_price, b.status
                        ORDER BY 
                            b.event_date ASC
                        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Populate the rejected bookings panel
        HelperResultsDisplay.PopulateRejectedBookings(flpRejected, dt)

        ' Update the tab label based on the number of rejected bookings
        UpdateTabLabel(tpRejected, flpRejected)
    End Sub

    Private Sub LoadAllBookings()
        Dim query As String = "SELECT 
                            b.booking_id, 
                            c.name, 
                            e.event_place, 
                            b.event_type, 
                            b.num_guests, 
                            e.image_url, 
                            b.event_date, 
                            b.event_time, 
                            b.event_end_time, 
                            b.event_end_date, 
                            b.total_price, 
                            b.status, 
                            GROUP_CONCAT(s.service_name ORDER BY s.service_name) AS services_availed
                        FROM 
                            bookings b
                        JOIN 
                            customers c ON b.customer_id = c.customer_id
                        JOIN 
                            eventplace e ON b.place_id = e.place_id
                        LEFT JOIN 
                            bookingservices bs ON b.booking_id = bs.booking_id
                        LEFT JOIN 
                            services s ON bs.service_id = s.service_id
                        GROUP BY 
                            b.booking_id, c.name, e.event_place, b.event_type, b.num_guests, e.image_url, 
                            b.event_date, b.event_time, b.event_end_time, b.event_end_date, b.total_price, b.status
                        ORDER BY 
                            b.event_date ASC"

        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Populate the all bookings panel
        HelperResultsDisplay.PopulateAllBookings(flpAll, dt)

        ' Update the tab label based on the number of all bookings
        UpdateTabLabel(tpAll, flpAll)
    End Sub



    '--- Load Availability of Event Places
    ' In FormAdminCenter

    Private Sub LoadAvailability()
        ' Corrected query: Remove reference to e.status and use the dynamically calculated Availability
        Dim query As String = "SELECT e.event_place, e.place_id, " &
                          "CASE WHEN EXISTS (SELECT 1 FROM bookings b WHERE b.place_id = e.place_id AND b.status='Approved') " &
                          "THEN 'Booked' ELSE 'Available' END AS Availability, " &
                          "e.image_url " &
                          "FROM eventplace e"

        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Split the event places into Available and Booked
        Dim availablePlaces As DataTable = dt.Clone()
        Dim bookedPlaces As DataTable = dt.Clone()

        For Each row As DataRow In dt.Rows
            If row("Availability").ToString() = "Available" Then
                availablePlaces.ImportRow(row)
            Else
                bookedPlaces.ImportRow(row)
            End If
        Next

        ' Pass the controls as arguments to PopulateEventPlacesForAdmin
        HelperResultsDisplay.PopulateEventPlacesForAdmin(flpAvailable, availablePlaces, True,
                                                     txtEventPlace, txtEventType, txtCapacity,
                                                     txtPricePerDay, txtFeatures, txtImageUrl,
                                                     cbStartHour, cbStartMinutes, cbStartAMPM,
                                                     cbEndHour, cbEndMinutes, cbEndAMPM,
                                                     txtAvailableDays, txtDescription,
                                                     txtPlaceID, btnUpdate, btnDelete)

        HelperResultsDisplay.PopulateEventPlacesForAdmin(flpBooked, bookedPlaces, False,
                                                     txtEventPlace, txtEventType, txtCapacity,
                                                     txtPricePerDay, txtFeatures, txtImageUrl,
                                                     cbStartHour, cbStartMinutes, cbStartAMPM,
                                                     cbEndHour, cbEndMinutes, cbEndAMPM,
                                                     txtAvailableDays, txtDescription,
                                                     txtPlaceID, btnUpdate, btnDelete)
    End Sub

    '--- Load Revenue Reports
    Private Sub LoadRevenueReports()
        Dim query As String = "SELECT e.event_place, " &
                          "IFNULL(SUM(b.total_price), 0) AS total_revenue " &
                          "FROM eventplace e " &
                          "LEFT JOIN bookings b ON e.place_id = b.place_id AND b.status = 'Approved' " &
                          "GROUP BY e.place_id"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateRevenueReports(flpRevenueReports, dt)
    End Sub


    '--- Load Invoices
    Private Sub LoadInvoices()
        Dim query As String = "SELECT invoice_id, user_id, event_place, total_amount, payment_status, invoice_date
        FROM invoices
        WHERE payment_status = 'Pending'
        ORDER BY invoice_date ASC
        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateInvoices(flpInvoices, dt, AddressOf AcceptPayment_Click)
    End Sub

    ' ------------------ Load Booked Dates ------------------
    Public Shared Function LoadBookedDates(placeId As Integer) As List(Of Date)
        Dim bookedDates As New List(Of Date)
        Dim query As String = "SELECT event_date, event_end_date FROM Bookings WHERE place_id = @place_id"

        Dim params As New Dictionary(Of String, Object) From {{"@place_id", placeId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, params)
        For Each row As DataRow In dt.Rows
            Dim startDate As Date = Convert.ToDateTime(row("event_date"))
            Dim endDate As Date = Convert.ToDateTime(row("event_end_date"))

            ' Add all dates in the range to the booked list
            For Each d As Date In Enumerable.Range(0, (endDate - startDate).Days + 1).Select(Function(i) startDate.AddDays(i))
                bookedDates.Add(d)
            Next
        Next

        Return bookedDates
    End Function


    '--- Load Customer Count
    Private Sub LoadCustomerCount()
        Dim query As String = "SELECT COUNT(*) FROM customers"
        Dim count As Object = DBHelper.ExecuteScalarQuery(query, New Dictionary(Of String, Object))
        lblNumCustomersContainer.Text = If(count IsNot Nothing, count.ToString(), "0")
    End Sub

    '--- Load Customer Records
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


    '--- Update Availability for the selected date
    Private Sub UpdateAvailability(selectedDate As Date)
        Dim query As String = "SELECT e.event_place, " &
                          "CASE WHEN EXISTS (SELECT 1 FROM bookings b WHERE b.place_id = e.place_id AND b.status='Approved' AND b.event_date = @selectedDate) " &
                          "THEN 'Booked' ELSE 'Available' END AS Availability " &
                          "FROM eventplace e"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object) From {{"@selectedDate", selectedDate}})

        ' Retrieve the FlowLayoutPanels for available and booked event places
        Dim flpAvailable As FlowLayoutPanel = CType(tcAvailability.TabPages("tpAvailable").Controls("flpAvailable"), FlowLayoutPanel)
        Dim flpBooked As FlowLayoutPanel = CType(tcAvailability.TabPages("tpBooked").Controls("flpBooked"), FlowLayoutPanel)

        ' Separate the data into available and booked places
        Dim availablePlaces As DataTable = dt.Clone()
        Dim bookedPlaces As DataTable = dt.Clone()

        For Each row As DataRow In dt.Rows
            If row("Availability").ToString() = "Available" Then
                availablePlaces.ImportRow(row)
            Else
                bookedPlaces.ImportRow(row)
            End If
        Next

        ' Populate the FlowLayoutPanels with the sorted event places
        HelperResultsDisplay.PopulateAvailability(flpAvailable, availablePlaces)
        HelperResultsDisplay.PopulateAvailability(flpBooked, bookedPlaces)
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
        LoadAvailability()
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
        LoadAvailability()
        ' After approving or rejecting the booking, reload the panels
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

    '--- Add a new event place
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate the opening and closing hours based on the ComboBoxes.
        If Not HelperValidation.IsValidTimeSelection(cbStartHour, cbStartMinutes, cbStartAMPM, cbEndHour, cbEndMinutes, cbEndAMPM, String.Empty, String.Empty) Then
            Exit Sub
        End If

        ' Create formatted opening and closing time from ComboBoxes
        Dim openingTime As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim closingTime As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        ' Set the formatted opening and closing time for display in the labels
        lblOpeningHours.Text = openingTime
        lblClosingHours.Text = closingTime

        ' Validate if the opening and closing hours are valid.
        If String.IsNullOrEmpty(openingTime) OrElse String.IsNullOrEmpty(closingTime) Then Exit Sub

        ' Check if the event place already exists.
        If EventPlaceExists(txtEventPlace.Text) Then
            MessageBox.Show("Event place already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert the new event place into the database.
        DBHelper.ExecuteQuery("INSERT INTO eventplace (event_place, event_type, capacity, features, price_per_day, description, image_url, opening_hours, closing_hours, available_days) " &
                          "VALUES (@event_place, @event_type, @capacity, @features, @price_per_day, @description, @image_url, @opening_hours, @closing_hours, @available_days)",
                          New Dictionary(Of String, Object) From {
                              {"@event_place", txtEventPlace.Text},
                              {"@event_type", txtEventType.Text},
                              {"@capacity", If(Not IsNumeric(txtCapacity.Text), DBNull.Value, txtCapacity.Text)},
                              {"@features", txtFeatures.Text},
                              {"@price_per_day", If(Not IsNumeric(txtPricePerDay.Text), DBNull.Value, txtPricePerDay.Text)},
                              {"@description", txtDescription.Text},
                              {"@image_url", txtImageUrl.Text},
                              {"@opening_hours", openingTime},
                              {"@closing_hours", closingTime},
                              {"@available_days", txtAvailableDays.Text}
                          })

        ' Reload the event places to reflect the new entry.
        LoadSearchResults()
    End Sub


    '--- Update the selected event place
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a place has been selected
        If String.IsNullOrWhiteSpace(txtPlaceID.Text) Then
            MessageBox.Show("Please select an event place to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the opening and closing times from the ComboBoxes
        Dim openingTime As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}"
        Dim closingTime As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}"

        ' Check if the times are empty
        If String.IsNullOrEmpty(openingTime) OrElse String.IsNullOrEmpty(closingTime) Then Exit Sub

        ' SQL query to update event place information
        Dim query As String = "UPDATE eventplace SET event_place = @event_place, event_type = @event_type, capacity = @capacity, features = @features, price_per_day = @price_per_day, description = @description, image_url = @image_url, opening_hours = @opening_hours, closing_hours = @closing_hours, available_days = @available_days WHERE place_id = @place_id"

        ' Parameters for the SQL query
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@place_id", txtPlaceID.Text},
        {"@event_place", txtEventPlace.Text},
        {"@event_type", txtEventType.Text},
        {"@capacity", If(Not IsNumeric(txtCapacity.Text), DBNull.Value, txtCapacity.Text)},
        {"@features", txtFeatures.Text},
        {"@price_per_day", If(Not IsNumeric(txtPricePerDay.Text), DBNull.Value, txtPricePerDay.Text)},
        {"@description", txtDescription.Text},
        {"@image_url", txtImageUrl.Text},
        {"@opening_hours", openingTime},
        {"@closing_hours", closingTime},
        {"@available_days", txtAvailableDays.Text}
    }

        ' Execute the query and check if any rows were affected
        Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, parameters)
        If rowsAffected > 0 Then
            MessageBox.Show("Event place updated successfully.")
            LoadSearchResults()
        Else
            MessageBox.Show("Update failed. No rows were affected. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    '--- Delete the selected event place (if no active bookings)
    Private Function HasActiveBookings(placeID As String) As Boolean
        Dim result As Object = DBHelper.ExecuteScalarQuery("SELECT COUNT(*) FROM bookings WHERE place_id=@id AND status='Approved'",
                                                            New Dictionary(Of String, Object) From {{"@id", placeID}})
        Return Convert.ToInt32(result) > 0
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If HasActiveBookings(txtPlaceID.Text) Then
            MessageBox.Show("Cannot delete event place with active bookings.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        DBHelper.ExecuteQuery("DELETE FROM eventplace WHERE place_id = @place_id", New Dictionary(Of String, Object) From {{"@place_id", txtPlaceID.Text}})
        LoadSearchResults()
    End Sub

    '--- Field Validation ---
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

    ' Store a reference to the booking details form so we can hide it later
    Private bookingDetailsForm As FormBookingDetails

    ' Show booking details
    Public Sub ShowBookingDetails(ByVal row As DataRow)
        If bookingDetailsForm Is Nothing OrElse bookingDetailsForm.IsDisposed Then
            ' Create a new form if it doesn't exist
            bookingDetailsForm = New FormBookingDetails()
        End If

        ' Ensure the bookingId is valid
        Dim bookingId As Integer = Convert.ToInt32(row("booking_id"))
        Debug.Print("Booking ID: " & bookingId.ToString())

        ' Load the booking details into the form
        bookingDetailsForm.LoadBookingDetails(bookingId)
        bookingDetailsForm.ShowDialog()
    End Sub


    ' Hide booking details
    Public Sub HideBookingDetails()
        ' Close the booking details form when the mouse button is released
        If bookingDetailsForm IsNot Nothing AndAlso bookingDetailsForm.Visible Then
            bookingDetailsForm.Hide()
        End If
    End Sub

    '--- Log Out ---
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

    Private Sub UpdateTabLabel(tabPage As TabPage, flowLayoutPanel As FlowLayoutPanel)
        ' Update the tab label with the number of items in the FlowLayoutPanel
        Dim itemCount As Integer = flowLayoutPanel.Controls.Count
        tabPage.Text = $"{tabPage.Text.Split(" "c)(0)} ({itemCount})"
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
