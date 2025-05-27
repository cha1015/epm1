Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC.Rfc8032
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class FormCustomerView

    Private customerId As Integer
    Private currentPlaceIndex As Integer = 1 ' Current place being viewed (1-25)
    Private isGridView As Boolean = True ' Toggle between grid and panel view
    Private pnlPlaceBrowser As Panel
    Private lblPlaceName As Label
    Private lblPlaceDetails As Label
    Private btnPrevPlace As Button
    Private btnNextPlace As Button
    Private lblPaymentId As Label
    Private lblAmountToPay As Label
    Private lblAmountPaid As Label
    Private lblPaymentDate As Label
    Private lblPaymentStatus As Label
    Private relevantPlaceIndices As New List(Of Integer)

    Private placeNames As String() = {
        "Auditorium", "Ballroom", "Banquet Hall", "Bar", "Cafe", "Club",
        "Conference Hall", "Country Club", "Event Space", "Function Room",
        "Gallery", "Halal Venue", "Hotel", "Kids-Friendly Venue", "Meeting Room",
        "Museum", "Outdoor Venue", "Private Estate", "Restaurant", "Rooftop Venue",
        "Seminar Room", "Studio", "Theater", "Training Room", "Yacht"
    }

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        customerId = id
        CreatePlaceBrowserPanel()
    End Sub

    Private Sub CreatePlaceBrowserPanel()
        ' Main panel
        pnlPlaceBrowser = New Panel()
        pnlPlaceBrowser.Size = New Size(863, 124)
        pnlPlaceBrowser.Location = New Point(43, 104)
        pnlPlaceBrowser.BorderStyle = BorderStyle.None
        pnlPlaceBrowser.Visible = False
        pnlPlaceBrowser.BackgroundImageLayout = ImageLayout.Stretch
        AddHandler pnlPlaceBrowser.Paint, AddressOf MakePanelRound

        'Info area panel 
        Dim pnlInfoArea As New Panel()
        pnlInfoArea.Size = New Size(520, 122)
        pnlInfoArea.Location = New Point(50, 1)
        pnlInfoArea.BackColor = Color.Transparent

        'Place name label 
        lblPlaceName = New Label()
        lblPlaceName.Font = New Font("Arial", 20, FontStyle.Bold)
        lblPlaceName.ForeColor = Color.FromArgb(60, 40, 20)
        lblPlaceName.BackColor = Color.Transparent
        lblPlaceName.Size = New Size(480, 36)
        lblPlaceName.Location = New Point(20, 8)
        lblPlaceName.TextAlign = ContentAlignment.MiddleLeft

        'Payment info labels 
        lblPaymentId = New Label()
        lblPaymentId.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentId.ForeColor = Color.Black
        lblPaymentId.BackColor = Color.Transparent
        lblPaymentId.Size = New Size(250, 20)
        lblPaymentId.Location = New Point(20, 53)

        lblAmountToPay = New Label()
        lblAmountToPay.Font = New Font("Arial", 10, FontStyle.Bold)
        lblAmountToPay.ForeColor = Color.Black
        lblAmountToPay.BackColor = Color.Transparent
        lblAmountToPay.Size = New Size(250, 20)
        lblAmountToPay.Location = New Point(20, 73)

        lblAmountPaid = New Label()
        lblAmountPaid.Font = New Font("Arial", 10, FontStyle.Bold)
        lblAmountPaid.ForeColor = Color.Black
        lblAmountPaid.BackColor = Color.Transparent
        lblAmountPaid.Size = New Size(250, 20)
        lblAmountPaid.Location = New Point(20, 93)

        'Payment info labels 
        lblPaymentDate = New Label()
        lblPaymentDate.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentDate.ForeColor = Color.Black
        lblPaymentDate.BackColor = Color.Transparent
        lblPaymentDate.Size = New Size(250, 20)
        lblPaymentDate.Location = New Point(270, 53)

        lblPaymentStatus = New Label()
        lblPaymentStatus.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentStatus.ForeColor = Color.Black
        lblPaymentStatus.BackColor = Color.Transparent
        lblPaymentStatus.Size = New Size(250, 20)
        lblPaymentStatus.Location = New Point(270, 73)

        'Add labels to info panel
        pnlInfoArea.Controls.Add(lblPlaceName)
        pnlInfoArea.Controls.Add(lblPaymentId)
        pnlInfoArea.Controls.Add(lblAmountToPay)
        pnlInfoArea.Controls.Add(lblAmountPaid)
        pnlInfoArea.Controls.Add(lblPaymentDate)
        pnlInfoArea.Controls.Add(lblPaymentStatus)

        ' Navigation buttons (centered more)
        btnPrevPlace = New Button()
        btnPrevPlace.Text = "◀"
        btnPrevPlace.Size = New Size(40, 40)
        btnPrevPlace.Location = New Point(10, 42) ' Move right a bit
        btnPrevPlace.BackColor = Color.White
        btnPrevPlace.FlatStyle = FlatStyle.Flat
        btnPrevPlace.FlatAppearance.BorderSize = 0
        AddHandler btnPrevPlace.Click, AddressOf BtnPrevPlace_Click
        AddHandler btnPrevPlace.Paint, AddressOf MakeButtonRound

        btnNextPlace = New Button()
        btnNextPlace.Text = "▶"
        btnNextPlace.Size = New Size(40, 40)
        btnNextPlace.Location = New Point(805, 42) ' Move left a bit
        btnNextPlace.BackColor = Color.White
        btnNextPlace.FlatStyle = FlatStyle.Flat
        btnNextPlace.FlatAppearance.BorderSize = 0
        AddHandler btnNextPlace.Click, AddressOf BtnNextPlace_Click
        AddHandler btnNextPlace.Paint, AddressOf MakeButtonRound

        ' Add controls to main panel
        pnlPlaceBrowser.Controls.Add(pnlInfoArea)
        pnlPlaceBrowser.Controls.Add(btnPrevPlace)
        pnlPlaceBrowser.Controls.Add(btnNextPlace)

        ' Add panel to form
        Me.Controls.Add(pnlPlaceBrowser)
        pnlPlaceBrowser.BringToFront()
    End Sub



    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------FOR SAMPLE DATA--------
        AddSampleBookingData()
        LoadRelevantPlaceIndices()
        '----------------------------
        dgvCurrentBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        customerId = CurrentUser.CustomerId
        lblUsername.Text = CurrentUser.Username

        '-------MY SQL DATABASE CONNECTION-------
        'LoadBookings()
        '----------------------------------------

        LoadPaymentHistory()
        SetInitialPlace()
    End Sub

    Private Sub SetInitialPlace()
        ' Check if customer has any current bookings and set the place accordingly
        Try
            Dim query As String = "SELECT p.place_id FROM bookings b JOIN eventplace p ON b.place_id = p.place_id WHERE b.customer_id = @customer_id AND b.status = 'Approved' ORDER BY b.event_date DESC LIMIT 1"
            Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

            Dim dtBooking As DataTable = DBHelper.GetDataTable(query, parameters)
            If dtBooking.Rows.Count > 0 Then
                currentPlaceIndex = Convert.ToInt32(dtBooking.Rows(0)("place_id"))
                If currentPlaceIndex < 1 Or currentPlaceIndex > 25 Then
                    currentPlaceIndex = 1
                End If
            End If
        Catch ex As Exception
            currentPlaceIndex = 1
        End Try

        UpdatePlaceDisplay()
        LoadRelevantPlaceIndices()

    End Sub

    Private Sub UpdatePlaceDisplay()
        If relevantPlaceIndices.Count = 0 Then
            ShowNoBookingPanel()
            Return
        End If

        If Not relevantPlaceIndices.Contains(currentPlaceIndex) Then
            currentPlaceIndex = relevantPlaceIndices(0)
        End If

        If currentPlaceIndex < 1 Then currentPlaceIndex = 25
        If currentPlaceIndex > 25 Then currentPlaceIndex = 1

        ' Update place name
        lblPlaceName.Text = $"{placeNames(currentPlaceIndex - 1)}"


        ' Query for the latest payment for the current place and customer
        Dim query As String = "SELECT payment_id, amount_to_pay, amount_paid, payment_date, payment_status " &
                      "FROM payments WHERE customer_id = @customer_id AND place_id = @place_id " &
                      "ORDER BY payment_date DESC LIMIT 1"
        Dim parameters As New Dictionary(Of String, Object) From {
    {"@customer_id", customerId},
    {"@place_id", currentPlaceIndex}
}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)
            lblPaymentId.Text = $"Payment ID: {row("payment_id")}"
            lblAmountToPay.Text = $"Amount To Pay: {row("amount_to_pay"):C2}"
            lblAmountPaid.Text = $"Amount Paid: {row("amount_paid"):C2}"
            lblPaymentDate.Text = $"Payment Date: {If(IsDBNull(row("payment_date")), "-", row("payment_date"))}"
            lblPaymentStatus.Text = $"Payment Status: {row("payment_status")}"
        Else
            lblPaymentId.Text = "Payment ID: -"
            lblAmountToPay.Text = "Amount To Pay: -"
            lblAmountPaid.Text = "Amount Paid: -"
            lblPaymentDate.Text = "Payment Date: -"
            lblPaymentStatus.Text = "Payment Status: -"
        End If


        ' Set background image from resources and stretch it
        Try

            Dim resourceName As String = $"_{currentPlaceIndex}"
            Dim img As Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)


            If img IsNot Nothing Then
                pnlPlaceBrowser.BackgroundImage = img
                pnlPlaceBrowser.BackgroundImageLayout = ImageLayout.Stretch
                pnlPlaceBrowser.BackColor = Color.Transparent
            Else
                pnlPlaceBrowser.BackgroundImage = Nothing
                pnlPlaceBrowser.BackColor = Color.SandyBrown
                Debug.WriteLine($"Image resource '{resourceName}' not found.")
            End If
        Catch ex As Exception
            pnlPlaceBrowser.BackgroundImage = Nothing
            pnlPlaceBrowser.BackColor = Color.SandyBrown
            Debug.WriteLine($"Error loading image for place {currentPlaceIndex}: {ex.Message}")
        End Try

    End Sub

    Private Sub BtnPrevPlace_Click(sender As Object, e As EventArgs)
        If relevantPlaceIndices.Count = 0 Then
            ShowNoBookingPanel()
            Return
        End If
        Dim idx = GetCurrentRelevantIndex()
        If idx <= 0 Then
            currentPlaceIndex = relevantPlaceIndices(relevantPlaceIndices.Count - 1)
        Else
            currentPlaceIndex = relevantPlaceIndices(idx - 1)
        End If
        UpdatePlaceDisplay()
    End Sub

    Private Sub BtnNextPlace_Click(sender As Object, e As EventArgs)
        If relevantPlaceIndices.Count = 0 Then
            ShowNoBookingPanel()
            Return
        End If
        Dim idx = GetCurrentRelevantIndex()
        If idx = -1 OrElse idx >= relevantPlaceIndices.Count - 1 Then
            currentPlaceIndex = relevantPlaceIndices(0)
        Else
            currentPlaceIndex = relevantPlaceIndices(idx + 1)
        End If
        UpdatePlaceDisplay()
    End Sub


    ' ✅ Load only current customer bookings
    Private Sub LoadBookings()
        LoadRelevantPlaceIndices()

        Debug.WriteLine($"Loading bookings for CustomerId: {customerId}")
        dgvPaymentHistory.ClearSelection()

        Dim query As String = $"SELECT b.booking_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status 
                       FROM bookings b
                       JOIN eventplace p ON b.place_id = p.place_id 
                       WHERE b.customer_id = {customerId}
                       ORDER BY b.event_date DESC"

        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

        Try
            Dim dtBookings As DataTable = DBHelper.GetDataTable(query, parameters)

            If dtBookings.Rows.Count > 0 Then
                dgvCurrentBooking.DataSource = dtBookings
                btnSelectBooking.Enabled = True
                btnConfirmPayment.Enabled = True
            Else
                ' Create a temporary placeholder row when no bookings exist
                Dim dtPlaceholder As New DataTable()
                dtPlaceholder.Columns.Add("Message", GetType(String))
                dtPlaceholder.Rows.Add("No bookings found. Start by booking an event!")
                dgvCurrentBooking.DataSource = dtPlaceholder
                btnSelectBooking.Enabled = False
                btnConfirmPayment.Enabled = False
                dgvCurrentBooking.Refresh()
            End If

        Catch ex As MySqlException
            'MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Load payment history correctly
    Private Sub LoadPaymentHistory()
        Dim query As String = "SELECT payment_id, amount_to_pay, amount_paid, payment_date, payment_status 
                           FROM payments WHERE customer_id = @customer_id"

        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

        Try
            Dim dtPayments As DataTable = DBHelper.GetDataTable(query, parameters)

            If dtPayments.Rows.Count > 0 Then
                dgvPaymentHistory.DataSource = dtPayments
                dgvPaymentHistory.ClearSelection()
            Else
                dgvPaymentHistory.DataSource = Nothing
                dgvPaymentHistory.ClearSelection()
            End If

        Catch ex As MySqlException
            'MessageBox.Show("Error loading payment history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPayButtonColumn()
        Dim btnColumn As New DataGridViewButtonColumn()
        btnColumn.Name = "btnSelectBooking"
        btnColumn.HeaderText = "Action"
        btnColumn.Text = "Pay Now"
        btnColumn.UseColumnTextForButtonValue = True
        dgvPaymentHistory.Columns.Add(btnColumn)
    End Sub

    ' Button to switch between grid view and place browser view
    Private Sub btnSwitchView_Click(sender As Object, e As EventArgs) Handles btnSwitchView.Click
        isGridView = Not isGridView

        If isGridView Then
            ' Show grid view, hide panel
            dgvCurrentBooking.Visible = True
            pnlPlaceBrowser.Visible = False
            btnSwitchView.Text = "Browse"
        Else
            ' Show panel view, hide grid
            dgvCurrentBooking.Visible = False
            pnlPlaceBrowser.Visible = True
            btnSwitchView.Text = "Show"
            UpdatePlaceDisplay()
        End If

        '--------SAMPLE DATA---------
        UpdatePanelFromCurrentBooking()
        '----------------------------
    End Sub

    ' Button to edit customer information
    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEditInformation.Click
        Dim editForm As New FormCustomerAdminInfo
        editForm.ShowDialog()
    End Sub

    ' Button to return to the main screen
    Private Sub btnMain_Click(sender As Object, e As EventArgs)
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub

    ' Button to log out
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim loginForm As New FormLogIn()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSelectBooking_Click_1(sender As Object, e As EventArgs) Handles btnSelectBooking.Click
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a payment to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

        If paymentStatus = "Pending" Then
            Dim query As String = "UPDATE payments SET payment_status = 'Paid', payment_date = NOW(), amount_paid = amount_to_pay WHERE payment_id = @payment_id"
            Dim parameters As New Dictionary(Of String, Object) From {{"@payment_id", paymentId}}

            Try
                DBHelper.ExecuteQuery(query, parameters)
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPaymentHistory() ' Refresh payment records
            Catch ex As MySqlException
                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("This payment is already completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnConfirmPayment_Click_1(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        ' Ensure a booking is selected
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get payment details from the selected row
        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim amountDue As Decimal = Convert.ToDecimal(dgvPaymentHistory.SelectedRows(0).Cells("amount_to_pay").Value)
        Dim amountPaid As Decimal

        ' Validate cash amount (ensure correct payment)
        If Not Decimal.TryParse(txtPaymentAmount.Text, amountPaid) OrElse amountPaid < amountDue Then
            MessageBox.Show("Invalid amount. You must pay at least the due amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Allow payment only if booking is approved
        If paymentStatus = "Approved" Then
            Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

            Dim query As String = "UPDATE payments SET amount_paid = @amountPaid, payment_status = 'Paid', payment_date = NOW() WHERE payment_id = @payment_id"
            Dim parameters As New Dictionary(Of String, Object) From {
            {"@payment_id", paymentId},
            {"@amountPaid", amountPaid}
        }

            Try
                DBHelper.ExecuteQuery(query, parameters)
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPaymentHistory() ' Refresh payment history
            Catch ex As MySqlException
                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("You can only pay for approved bookings.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvCurrentBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCurrentBooking.CellClick
        If e.RowIndex >= 0 Then
            dgvCurrentBooking.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub dgvPaymentHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaymentHistory.CellClick
        If e.RowIndex >= 0 Then
            dgvPaymentHistory.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub txtPaymentAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaymentAmount.KeyPress
        ' Allow only numbers and control keys (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MakeButtonRound(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, btn.Width, btn.Height)
        btn.Region = New Region(path)
    End Sub

    ' New method to make the panel round with rounded corners
    Private Sub MakePanelRound(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = CType(sender, Panel)
        Dim cornerRadius As Integer = 30 ' Adjust this value to make corners more or less rounded
        Dim path As New Drawing2D.GraphicsPath()

        ' Create rounded rectangle path
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub
    Private Sub LoadRelevantPlaceIndices()
        relevantPlaceIndices.Clear()
        If dgvCurrentBooking.DataSource Is Nothing OrElse dgvCurrentBooking.Rows.Count = 0 Then Return

        For Each row As DataGridViewRow In dgvCurrentBooking.Rows
            If row.IsNewRow OrElse row.Cells.Count = 0 Then Continue For
            Dim placeName As String = ""
            ' Safely get the event_place column if it exists
            If row.DataGridView.Columns.Contains("event_place") Then
                placeName = If(row.Cells("event_place").Value IsNot Nothing, row.Cells("event_place").Value.ToString(), "")
            ElseIf row.Cells.Count > 1 Then
                placeName = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            End If
            Dim idx As Integer = Array.IndexOf(placeNames, placeName)
            If idx >= 0 AndAlso Not relevantPlaceIndices.Contains(idx + 1) Then
                relevantPlaceIndices.Add(idx + 1)
            End If
        Next
        relevantPlaceIndices.Sort()
    End Sub
    Private Function GetCurrentRelevantIndex() As Integer
        Return relevantPlaceIndices.IndexOf(currentPlaceIndex)
    End Function
    Private Sub ShowNoBookingPanel()
        pnlPlaceBrowser.BackgroundImage = Nothing
        pnlPlaceBrowser.BackColor = Color.Beige
        For Each ctrl As Control In pnlPlaceBrowser.Controls
            ctrl.Visible = False
        Next

        Dim lblNoBooking As New Label()
        lblNoBooking.Text = "No booking data"
        lblNoBooking.Font = New Font("Arial", 18, FontStyle.Bold)
        lblNoBooking.ForeColor = Color.FromArgb(60, 40, 20)
        lblNoBooking.BackColor = Color.Transparent
        lblNoBooking.AutoSize = False
        lblNoBooking.TextAlign = ContentAlignment.MiddleCenter
        lblNoBooking.Size = pnlPlaceBrowser.Size
        lblNoBooking.Location = New Point(0, 0)
        lblNoBooking.Name = "lblNoBooking"
        pnlPlaceBrowser.Controls.Add(lblNoBooking)
        lblNoBooking.BringToFront()
        pnlPlaceBrowser.Visible = True
    End Sub


    '--------------------SAMPLE DATA--------------------- (kasi diko magamit yung database)
    Private Sub AddSampleBookingData()
        Dim dtSample As New DataTable()
        dtSample.Columns.Add("booking_id", GetType(Integer))
        dtSample.Columns.Add("event_place", GetType(String))
        dtSample.Columns.Add("event_date", GetType(Date))
        dtSample.Columns.Add("event_time", GetType(String))
        dtSample.Columns.Add("event_end_time", GetType(String))
        dtSample.Columns.Add("status", GetType(String))

        ' Add sample rows (booking_id, event_place, event_date, event_time, event_end_time, status)
        dtSample.Rows.Add(101, "Auditorium", #2025-06-01#, "10:00", "14:00", "Approved")
        dtSample.Rows.Add(102, "Club", #2025-06-05#, "18:00", "23:00", "Approved")
        dtSample.Rows.Add(103, "Rooftop Venue", #2025-06-10#, "17:00", "22:00", "Pending")

        dgvCurrentBooking.DataSource = dtSample
    End Sub

    Private Sub UpdatePanelFromCurrentBooking()
        If dgvCurrentBooking.CurrentRow Is Nothing OrElse dgvCurrentBooking.Rows.Count = 0 Then
            ShowNoBookingPanel()
            Return
        End If

        Dim row = dgvCurrentBooking.CurrentRow

        ' Defensive: check if columns exist
        Dim placeName As String = If(row.Cells.Contains("event_place"), row.Cells("event_place").Value?.ToString(), "")
        Dim bookingId As String = If(row.Cells.Contains("booking_id"), row.Cells("booking_id").Value?.ToString(), "-")
        Dim eventDate As String = If(row.Cells.Contains("event_date"), row.Cells("event_date").Value?.ToString(), "-")
        Dim eventTime As String = If(row.Cells.Contains("event_time"), row.Cells("event_time").Value?.ToString(), "-")
        Dim eventEndTime As String = If(row.Cells.Contains("event_end_time"), row.Cells("event_end_time").Value?.ToString(), "-")
        Dim status As String = If(row.Cells.Contains("status"), row.Cells("status").Value?.ToString(), "-")

        lblPlaceName.Text = placeName
        lblPaymentId.Text = $"Booking ID: {bookingId}"
        lblAmountToPay.Text = $"Event Date: {eventDate}"
        lblAmountPaid.Text = $"Time: {eventTime} - {eventEndTime}"
        lblPaymentDate.Text = $"Status: {status}"
        lblPaymentStatus.Text = "" ' Or use for something else if needed

        ' Optionally set the background image as before
        Dim idx As Integer = Array.IndexOf(placeNames, placeName)
        If idx >= 0 Then
            Dim resourceName As String = $"_{idx + 1}"
            Try
                Dim img As Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)
                If img IsNot Nothing Then
                    pnlPlaceBrowser.BackgroundImage = img
                    pnlPlaceBrowser.BackgroundImageLayout = ImageLayout.Stretch
                    pnlPlaceBrowser.BackColor = Color.Transparent
                Else
                    pnlPlaceBrowser.BackgroundImage = Nothing
                    pnlPlaceBrowser.BackColor = Color.SandyBrown
                End If
            Catch
                pnlPlaceBrowser.BackgroundImage = Nothing
                pnlPlaceBrowser.BackColor = Color.SandyBrown
            End Try
        End If
    End Sub

    Private Sub dgvCurrentBooking_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCurrentBooking.SelectionChanged
        UpdatePanelFromCurrentBooking()
    End Sub


End Class