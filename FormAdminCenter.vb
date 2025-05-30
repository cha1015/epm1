Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Security.Principal
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormAdminCenter

    Private totalRevenueLabel As Label = Nothing
    Private paidBookingsTable As DataTable
    Private usersTable As DataTable


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
        LoadPaidBookings()


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
        ' Updated query: alias the status column as "Availability"
        Dim query As String = "SELECT place_id, event_place, event_type, capacity, price_per_day, description, image_url, " &
                          "CASE WHEN EXISTS (SELECT 1 FROM bookings WHERE bookings.place_id = eventplace.place_id) " &
                          "THEN 'Booked' ELSE 'Available' END AS Availability " &
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

        ' Now populate the single FlowLayoutPanel with the data
        HelperResultsDisplay.PopulateEventPlacesForAdmin(
        flpEventPlaces, dt,
        txtEventPlace, txtEventType, txtCapacity,
        txtPricePerDay, txtFeatures, txtImageUrl,
        cbStartHour, cbStartMinutes, cbStartAMPM,
        cbEndHour, cbEndMinutes, cbEndAMPM,
        txtAvailableDays, txtDescription, txtPlaceID, btnAdd,
        btnUpdate, btnDelete)
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
        ' Corrected query to fetch event places with the necessary columns and the alias "Availability"
        Dim query As String = "SELECT e.event_place, e.place_id, e.event_type, e.capacity, " &
                          "e.price_per_Day AS price_per_day, e.features, e.available_days, e.description, " &
                          "e.opening_hours, e.closing_hours, " &
                          "CASE WHEN EXISTS (SELECT 1 FROM bookings b WHERE b.place_id = e.place_id AND b.status='Approved') " &
                          "THEN 'Booked' ELSE 'Available' END AS Availability, " &
                          "e.image_url " &
                          "FROM eventplace e"

        ' Retrieve the data into a DataTable
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Debug: List out all column names ... check them in Visual Studio's Output window
        For Each col As DataColumn In dt.Columns
            Debug.WriteLine("Column: " & col.ColumnName)
        Next

        ' Make lookup case-insensitive (if needed)
        dt.CaseSensitive = False

        If dt.Columns.Contains("Availability") Then
            ' Populate the single FlowLayoutPanel with all event places
            HelperResultsDisplay.PopulateEventPlacesForAdmin(
            flpEventPlaces, dt,
            txtEventPlace, txtEventType, txtCapacity,
            txtPricePerDay, txtFeatures, txtImageUrl,
            cbStartHour, cbStartMinutes, cbStartAMPM,
            cbEndHour, cbEndMinutes, cbEndAMPM,
            txtAvailableDays, txtDescription, txtPlaceID, btnAdd,
            btnUpdate, btnDelete)
        Else
            MessageBox.Show("The 'Availability' column does not exist in the DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    '--- Load Revenue Reports
    Private Sub LoadRevenueReports()
        ' Get the total revenue from payments table where payment_status is Paid
        Dim query As String = "SELECT IFNULL(SUM(amount_paid), 0) AS total_revenue FROM payments WHERE payment_status = 'Paid'"
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        Dim totalRevenue As Decimal = 0
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("total_revenue")) Then
            totalRevenue = Convert.ToDecimal(dt.Rows(0)("total_revenue"))
        End If

        ' Format with peso sign and commas
        lblRevenue.Text = $"Revenue: ₱{totalRevenue:N0}"

        Dim perPlaceQuery As String = "SELECT e.event_place, IFNULL(SUM(p.amount_paid), 0) AS total_revenue " &
            "FROM eventplace e " &
            "LEFT JOIN bookings b ON e.place_id = b.place_id " &
            "LEFT JOIN payments p ON b.booking_id = p.booking_id AND p.payment_status = 'Paid' " &
            "GROUP BY e.place_id"
        Dim perPlaceDt As DataTable = DBHelper.GetDataTable(perPlaceQuery, New Dictionary(Of String, Object))
        HelperResultsDisplay.PopulateRevenueReports(flpRevenueReports, perPlaceDt)
    End Sub




    '--- Load Invoices
    Private Sub LoadInvoices()
        Dim query As String = "SELECT invoice_id, user_id, event_place, total_amount, payment_status, invoice_date
        FROM invoices
        WHERE payment_status = 'Pending'
        ORDER BY invoice_date ASC
        "
        Dim dt As DataTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))
        'HelperResultsDisplay.PopulateInvoices(flpInvoices, dt, AddressOf AcceptPayment_Click)
    End Sub

    '--- Load Paid Bookings
    Private Sub LoadPaidBookings()
        Dim query As String = "
        SELECT 
            b.customer_id, 
            u.username,
            u.email,
            b.booking_id, 
            b.place_id, 
            b.total_price, 
            b.services_availed, 
            b.num_guests, 
            b.event_date
        FROM bookings b
        LEFT JOIN customers c ON b.customer_id = c.customer_id
        LEFT JOIN users u ON c.user_id = u.user_id
        WHERE b.status = 'paid'
        ORDER BY b.event_date ASC"
        paidBookingsTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Set "N/A" for any blank or null cell in the table
        For Each row As DataRow In paidBookingsTable.Rows
            For Each col As DataColumn In paidBookingsTable.Columns
                If row.IsNull(col) OrElse String.IsNullOrWhiteSpace(row(col).ToString()) Then
                    row(col) = "N/A"
                End If
            Next
        Next

        dgvPaidBookings.DataSource = paidBookingsTable
        Debug.Print("Paid Bookings: " & paidBookingsTable.Rows.Count)
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
        Dim query As String = "SELECT COUNT(*) FROM users"
        Dim count As Object = DBHelper.ExecuteScalarQuery(query, New Dictionary(Of String, Object))
        lblNumCustomersContainer.Text = If(count IsNot Nothing, count.ToString(), "0")
    End Sub

    '--- Load Customer Records
    Private Sub LoadCustomerRecords()
        Dim query As String = "SELECT 
        user_id, 
        first_name, 
        last_name, 
        username, 
        email, 
        role, 
        birthday, 
        age, 
        sex, 
        address 
    FROM users 
    WHERE role = 'User' 
    ORDER BY first_name, last_name ASC"

        usersTable = DBHelper.GetDataTable(query, New Dictionary(Of String, Object))

        ' Set "N/A" for any blank or null cell in the table
        For Each row As DataRow In usersTable.Rows
            For Each col As DataColumn In usersTable.Columns
                If row.IsNull(col) OrElse String.IsNullOrWhiteSpace(row(col).ToString()) Then
                    row(col) = "N/A"
                End If
            Next
        Next

        dgvCustomerRec.DataSource = usersTable

        With dgvCustomerRec
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoResizeColumns()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub FilterCustomerRecords()
        If usersTable Is Nothing Then Return

        Dim searchText As String = txtSearchCustomer.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(searchText) Then
            dgvCustomerRec.DataSource = usersTable
        Else
            Dim filter As String =
            $"CONVERT(user_id, 'System.String') LIKE '%{searchText}%' OR " &
            $"first_name LIKE '%{searchText}%' OR " &
            $"last_name LIKE '%{searchText}%' OR " &
            $"username LIKE '%{searchText}%' OR " &
            $"email LIKE '%{searchText}%' OR " &
            $"role LIKE '%{searchText}%' OR " &
            $"CONVERT(birthday, 'System.String') LIKE '%{searchText}%' OR " &
            $"CONVERT(age, 'System.String') LIKE '%{searchText}%' OR " &
            $"sex LIKE '%{searchText}%' OR " &
            $"address LIKE '%{searchText}%'"

            Dim dv As New DataView(usersTable)
            dv.RowFilter = filter
            dgvCustomerRec.DataSource = dv
        End If
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
        ' Validate ComboBox selections
        If String.IsNullOrWhiteSpace(cbStartHour.Text) OrElse
       String.IsNullOrWhiteSpace(cbStartMinutes.Text) OrElse
       String.IsNullOrWhiteSpace(cbStartAMPM.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndHour.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndMinutes.Text) OrElse
       String.IsNullOrWhiteSpace(cbEndAMPM.Text) Then

            MessageBox.Show("Please select valid opening and closing times.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmation message
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to add this event place?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Exit Sub

        ' Proceed with insertion logic
        Dim openingTimeRaw As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}".Trim()
        Dim closingTimeRaw As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}".Trim()

        ' Validate and convert time format
        Dim timeFormats() As String = {"h:mm tt", "hh:mm tt"}
        Dim parsedOpening As DateTime
        Dim parsedClosing As DateTime

        If DateTime.TryParseExact(openingTimeRaw, timeFormats, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedOpening) AndAlso
       DateTime.TryParseExact(closingTimeRaw, timeFormats, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedClosing) Then

            Dim openingTime As String = parsedOpening.ToString("HH:mm:ss")
            Dim closingTime As String = parsedClosing.ToString("HH:mm:ss")

            ' Insert query
            Dim query As String = "INSERT INTO eventplace (event_place, event_type, capacity, features, price_per_day, description, image_url, opening_hours, closing_hours, available_days) " &
                              "VALUES (@event_place, @event_type, @capacity, @features, @price_per_day, @description, @image_url, @opening_hours, @closing_hours, @available_days)"

            Dim parameters As New Dictionary(Of String, Object) From {
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

            Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, parameters)
            If rowsAffected > 0 Then
                MessageBox.Show("Event place added successfully.")
                LoadSearchResults()
            Else
                MessageBox.Show("Insert failed. No rows were affected. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid time format. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a place has been selected
        If String.IsNullOrWhiteSpace(txtPlaceID.Text) Then
            MessageBox.Show("Please select an event place to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmation message
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this event place?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Exit Sub

        ' Proceed with update logic
        Dim openingTimeRaw As String = $"{cbStartHour.Text}:{cbStartMinutes.Text} {cbStartAMPM.Text}".Trim()
        Dim closingTimeRaw As String = $"{cbEndHour.Text}:{cbEndMinutes.Text} {cbEndAMPM.Text}".Trim()

        Dim timeFormats() As String = {"h:mm tt", "hh:mm tt"}
        Dim parsedOpening As DateTime
        Dim parsedClosing As DateTime

        If DateTime.TryParseExact(openingTimeRaw, timeFormats, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedOpening) AndAlso
       DateTime.TryParseExact(closingTimeRaw, timeFormats, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedClosing) Then

            Dim openingTime As String = parsedOpening.ToString("HH:mm:ss")
            Dim closingTime As String = parsedClosing.ToString("HH:mm:ss")

            Dim query As String = "UPDATE eventplace SET event_place = @event_place, event_type = @event_type, capacity = @capacity, features = @features, price_per_day = @price_per_day, description = @description, image_url = @image_url, opening_hours = @opening_hours, closing_hours = @closing_hours, available_days = @available_days WHERE place_id = @place_id"

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

            Dim rowsAffected As Integer = DBHelper.ExecuteQuery(query, parameters)
            If rowsAffected > 0 Then
                MessageBox.Show("Event place updated successfully.")
                LoadSearchResults()
            Else
                MessageBox.Show("Update failed. No rows were affected. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid time format. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If HasActiveBookings(txtPlaceID.Text) Then
            MessageBox.Show("Cannot delete event place with active bookings.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmation message
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this event place?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.No Then Exit Sub

        DBHelper.ExecuteQuery("DELETE FROM eventplace WHERE place_id = @place_id", New Dictionary(Of String, Object) From {{"@place_id", txtPlaceID.Text}})
        LoadSearchResults()
        MessageBox.Show("Event place deleted successfully.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '--- Delete the selected event place (if no active bookings)
    Private Function HasActiveBookings(placeID As String) As Boolean
        Dim result As Object = DBHelper.ExecuteScalarQuery("SELECT COUNT(*) FROM bookings WHERE place_id=@id AND status='Approved'",
                                                            New Dictionary(Of String, Object) From {{"@id", placeID}})
        Return Convert.ToInt32(result) > 0
    End Function

    '--- Field Validation ---
    Private Sub txtCapacity_Validating(sender As Object, e As EventArgs)
        HelperValidation.IsValidNumericField(txtCapacity, lblErrorCapacity, "Capacity must be a number.")
    End Sub

    Private Sub txtPricePerDay_Validating(sender As Object, e As EventArgs)
        HelperValidation.IsValidNumericField(txtPricePerDay, lblErrorPrice, "Price must be a number.")
    End Sub

    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs)
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
        'bookingDetailsForm.LoadBookingDetails(bookingId)
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
            Me.Close()
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

    Private Sub FilterPaidBookings()
        If paidBookingsTable Is Nothing Then Return

        Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(searchText) Then
            dgvPaidBookings.DataSource = paidBookingsTable
        Else
            Dim filter As String = $"CONVERT(customer_id, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(booking_id, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(place_id, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(total_price, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(services_availed, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(num_guests, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(event_date, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(username, 'System.String') LIKE '%{searchText}%' OR " &
                       $"CONVERT(email, 'System.String') LIKE '%{searchText}%'"

            Dim dv As New DataView(paidBookingsTable)
            dv.RowFilter = filter
            dgvPaidBookings.DataSource = dv
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        FilterPaidBookings()
    End Sub

    Private Sub tpCustomerRecords_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tpInvoicesAndPayments_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs)
        FilterCustomerRecords()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New FormCustomerAdminInfo(CurrentUser.UserID)
        editForm.ShowDialog()
    End Sub
End Class