'Imports MySql.Data.MySqlClient
'Imports System.Data
'Imports System.Security.Cryptography
'Imports System.Text

'Public Class FormCustomerView

'    Private customerId As Integer

'    ' Constructor to accept customer ID
'    Public Sub New(ByVal id As Integer)
'        InitializeComponent()
'        customerId = id ' Store passed customer ID
'    End Sub

'    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvCurrentBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'        'MessageBox.Show($"Debug: CurrentUser.CustomerId = {CurrentUser.CustomerId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        customerId = CurrentUser.CustomerId
'        'MessageBox.Show($"Debug: Assigned customerId = {customerId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        'Debug.WriteLine($"FormCustomerView loaded with CustomerId: {customerId}")

'        lblUsername.Text = CurrentUser.Username
'        LoadBookings()
'        LoadPaymentHistory()
'    End Sub

'    ' ✅ Load only current customer bookings
'    Private Sub LoadBookings()
'        Debug.WriteLine($"Loading bookings for CustomerId: {customerId}")
'        'MessageBox.Show($"Executing query for CustomerId: {customerId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        dgvPaymentHistory.ClearSelection()

'        'MessageBox.Show($"Loading bookings for CustomerId: {customerId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        Dim query As String = $"SELECT b.booking_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status 
'                       FROM bookings b
'                       JOIN eventplace p ON b.place_id = p.place_id 
'                       WHERE b.customer_id = {customerId}
'                       ORDER BY b.event_date DESC"

'        'MessageBox.Show($"Running SQL: {query}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

'        Try
'            Dim dtBookings As DataTable = DBHelper.GetDataTable(query, parameters)
'            'MessageBox.Show($"Debug: Retrieved {dtBookings.Rows.Count} bookings", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


'            If dtBookings.Rows.Count > 0 Then
'                dgvCurrentBooking.DataSource = dtBookings
'                btnSelectBooking.Enabled = True
'                btnConfirmPayment.Enabled = True
'            Else
'                ' Create a temporary placeholder row when no bookings exist
'                Dim dtPlaceholder As New DataTable()

'                dtPlaceholder.Columns.Add("Message", GetType(String))
'                dtPlaceholder.Rows.Add("No bookings found. Start by booking an event!")
'                dgvCurrentBooking.DataSource = dtPlaceholder
'                btnSelectBooking.Enabled = False ' 🚫 Disable button when no bookings exist
'                btnConfirmPayment.Enabled = False ' 🚫 Disable button when no bookings exist
'                dgvCurrentBooking.Refresh() ' 🚀 Force UI update
'            End If

'        Catch ex As MySqlException
'            'MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub


'    ' ✅ Load payment history correctly
'    Private Sub LoadPaymentHistory()
'        Dim query As String = "SELECT payment_id, amount_to_pay, amount_paid, payment_date, payment_status 
'                           FROM payments WHERE customer_id = @customer_id"

'        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

'        Try
'            Dim dtPayments As DataTable = DBHelper.GetDataTable(query, parameters)

'            If dtPayments.Rows.Count > 0 Then
'                dgvPaymentHistory.DataSource = dtPayments
'                dgvPaymentHistory.ClearSelection()
'            Else
'                dgvPaymentHistory.DataSource = Nothing
'                dgvPaymentHistory.ClearSelection()
'                'MessageBox.Show("No payment records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            End If

'        Catch ex As MySqlException
'            'MessageBox.Show("Error loading payment history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub AddPayButtonColumn()
'        Dim btnColumn As New DataGridViewButtonColumn()
'        btnColumn.Name = "btnSelectBooking"
'        btnColumn.HeaderText = "Action"
'        btnColumn.Text = "Pay Now"
'        btnColumn.UseColumnTextForButtonValue = True  ' Show button text
'        dgvPaymentHistory.Columns.Add(btnColumn)
'    End Sub

'    ' Button to edit customer information
'    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEditInformation.Click
'        Dim editForm As New FormCustomerAdminInfo
'        editForm.ShowDialog()
'    End Sub

'    ' Button to return to the main screen
'    Private Sub btnMain_Click(sender As Object, e As EventArgs)
'        Dim mainForm As New FormMain()
'        mainForm.Show()
'        Me.Hide()
'    End Sub

'    ' Button to log out
'    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
'        Dim loginForm As New FormLogIn()
'        loginForm.Show()
'        Me.Hide()
'    End Sub


'    Private Sub btnSelectBooking_Click_1(sender As Object, e As EventArgs) Handles btnSelectBooking.Click
'        If dgvPaymentHistory.SelectedRows.Count = 0 Then
'            MessageBox.Show("Please select a payment to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
'        Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

'        If paymentStatus = "Pending" Then
'            Dim query As String = "UPDATE payments SET payment_status = 'Paid', payment_date = NOW(), amount_paid = amount_to_pay WHERE payment_id = @payment_id"
'            Dim parameters As New Dictionary(Of String, Object) From {{"@payment_id", paymentId}}

'            Try
'                DBHelper.ExecuteQuery(query, parameters)
'                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                LoadPaymentHistory() ' Refresh payment records
'            Catch ex As MySqlException
'                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        Else
'            MessageBox.Show("This payment is already completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        End If
'    End Sub

'    Private Sub btnConfirmPayment_Click_1(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
'        ' Ensure a booking is selected
'        If dgvPaymentHistory.SelectedRows.Count = 0 Then
'            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        ' Get payment details from the selected row
'        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
'        Dim amountDue As Decimal = Convert.ToDecimal(dgvPaymentHistory.SelectedRows(0).Cells("amount_to_pay").Value)
'        Dim amountPaid As Decimal

'        ' Validate cash amount (ensure correct payment)
'        If Not Decimal.TryParse(txtPaymentAmount.Text, amountPaid) OrElse amountPaid < amountDue Then
'            MessageBox.Show("Invalid amount. You must pay at least the due amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        ' Allow payment only if booking is approved
'        If paymentStatus = "Approved" Then
'            Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

'            Dim query As String = "UPDATE payments SET amount_paid = @amountPaid, payment_status = 'Paid', payment_date = NOW() WHERE payment_id = @payment_id"
'            Dim parameters As New Dictionary(Of String, Object) From {
'            {"@payment_id", paymentId},
'            {"@amountPaid", amountPaid}
'        }

'            Try
'                DBHelper.ExecuteQuery(query, parameters)
'                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                LoadPaymentHistory() ' Refresh payment history
'            Catch ex As MySqlException
'                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        Else
'            MessageBox.Show("You can only pay for approved bookings.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End If
'    End Sub

'    Private Sub dgvCurrentBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCurrentBooking.CellClick
'        dgvCurrentBooking.Rows(e.RowIndex).Selected = True
'    End Sub

'    Private Sub dgvPaymentHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaymentHistory.CellClick
'        dgvPaymentHistory.Rows(e.RowIndex).Selected = True
'    End Sub

'    Private Sub txtPaymentAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaymentAmount.KeyPress
'        ' Allow only numbers and control keys (like backspace)
'        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
'            e.Handled = True
'        End If
'    End Sub

'End Class



Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Text

Public Class FormCustomerView

    Private customerId As Integer
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

    Private allBookings As New List(Of DataRow)
    Private currentBookingIndex As Integer = 0

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
        pnlPlaceBrowser = New Panel()
        pnlPlaceBrowser.Size = New Size(863, 124)
        pnlPlaceBrowser.Location = New Point(43, 104)
        pnlPlaceBrowser.BorderStyle = BorderStyle.None
        pnlPlaceBrowser.Visible = False
        pnlPlaceBrowser.BackgroundImageLayout = ImageLayout.Stretch
        AddHandler pnlPlaceBrowser.Paint, AddressOf MakePanelRound

        Dim pnlInfoArea As New Panel()
        pnlInfoArea.Size = New Size(520, 122)
        pnlInfoArea.Location = New Point(50, 1)
        pnlInfoArea.BackColor = Color.Transparent

        lblPlaceName = New Label()
        lblPlaceName.Font = New Font("Arial", 20, FontStyle.Bold)
        lblPlaceName.ForeColor = Color.FromArgb(60, 40, 20)
        lblPlaceName.BackColor = Color.Transparent
        lblPlaceName.Size = New Size(480, 36)
        lblPlaceName.Location = New Point(20, 8)
        lblPlaceName.TextAlign = ContentAlignment.MiddleLeft

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

        pnlInfoArea.Controls.Add(lblPlaceName)
        pnlInfoArea.Controls.Add(lblPaymentId)
        pnlInfoArea.Controls.Add(lblAmountToPay)
        pnlInfoArea.Controls.Add(lblAmountPaid)
        pnlInfoArea.Controls.Add(lblPaymentDate)
        pnlInfoArea.Controls.Add(lblPaymentStatus)

        btnPrevPlace = New Button()
        btnPrevPlace.Text = "◀"
        btnPrevPlace.Size = New Size(40, 40)
        btnPrevPlace.Location = New Point(10, 42)
        btnPrevPlace.BackColor = Color.White
        btnPrevPlace.FlatStyle = FlatStyle.Flat
        btnPrevPlace.FlatAppearance.BorderSize = 0
        btnPrevPlace.Visible = True
        AddHandler btnPrevPlace.Click, AddressOf BtnPrevPlace_Click
        AddHandler btnPrevPlace.Paint, AddressOf MakeButtonRound

        btnNextPlace = New Button()
        btnNextPlace.Text = "▶"
        btnNextPlace.Size = New Size(40, 40)
        btnNextPlace.Location = New Point(805, 42)
        btnNextPlace.BackColor = Color.White
        btnNextPlace.FlatStyle = FlatStyle.Flat
        btnNextPlace.FlatAppearance.BorderSize = 0
        btnNextPlace.Visible = True
        AddHandler btnNextPlace.Click, AddressOf BtnNextPlace_Click
        AddHandler btnNextPlace.Paint, AddressOf MakeButtonRound

        pnlPlaceBrowser.Controls.Add(btnPrevPlace)
        pnlPlaceBrowser.Controls.Add(btnNextPlace)

        pnlPlaceBrowser.Controls.Add(pnlInfoArea)
        pnlPlaceBrowser.Controls.Add(btnPrevPlace)
        pnlPlaceBrowser.Controls.Add(btnNextPlace)
        Me.Controls.Add(pnlPlaceBrowser)
        pnlPlaceBrowser.BringToFront()
    End Sub

    Private Sub BtnPrevPlace_Click(sender As Object, e As EventArgs)
        Debug.WriteLine("Prev button clicked")
        If allBookings.Count <= 1 Then Return
        If currentBookingIndex > 0 Then
            currentBookingIndex -= 1
            UpdatePlaceBrowserPanel()
        End If
    End Sub

    Private Sub BtnNextPlace_Click(sender As Object, e As EventArgs)
        Debug.WriteLine("Next button clicked")
        If allBookings.Count <= 1 Then Return
        If currentBookingIndex < allBookings.Count - 1 Then
            currentBookingIndex += 1
            UpdatePlaceBrowserPanel()
        End If
    End Sub


    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPlaceBrowser.Visible = True
        customerId = CurrentUser.CustomerId
        LoadAllBookings()
        currentBookingIndex = 0
        UpdatePlaceBrowserPanel()
    End Sub

    Private Sub LoadAllBookings()
        allBookings.Clear()
        Dim query As String = "SELECT b.booking_id, b.place_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status, " &
                          "pay.payment_id, pay.amount_to_pay, pay.amount_paid, pay.payment_date, pay.payment_status " &
                          "FROM bookings b " &
                          "LEFT JOIN payments pay ON pay.booking_id = b.booking_id " &
                          "JOIN eventplace p ON b.place_id = p.place_id " &
                          "WHERE b.customer_id = @customer_id " &
                          "ORDER BY b.event_date DESC, b.booking_id DESC"
        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        For Each row As DataRow In dt.Rows
            allBookings.Add(row)
        Next
        Debug.WriteLine($"Loaded {allBookings.Count} bookings for customer {customerId}")
    End Sub


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

    Private Sub UpdatePlaceBrowserPanel()
        If allBookings.Count = 0 Then
            ShowNoBookingPanel()
            btnPrevPlace.Visible = False
            btnNextPlace.Visible = False
            Return
        End If

        Debug.WriteLine($"Showing booking {currentBookingIndex + 1} of {allBookings.Count}")

        Dim dataRow As DataRow = allBookings(currentBookingIndex)
        Dim placeId As Integer = Convert.ToInt32(dataRow("place_id"))
        Dim imageName As String = "_" & placeId.ToString()
        Dim img As Image = TryCast(My.Resources.ResourceManager.GetObject(imageName), Image)
        pnlPlaceBrowser.BackgroundImage = img

        lblPlaceName.Text = dataRow("event_place").ToString()
        lblPaymentId.Text = "Payment ID: " & If(IsDBNull(dataRow("payment_id")), "N/A", dataRow("payment_id").ToString())
        lblAmountToPay.Text = "Amount to Pay: " & If(IsDBNull(dataRow("amount_to_pay")), "N/A", "₱" & Convert.ToDecimal(dataRow("amount_to_pay")).ToString("F2"))
        lblAmountPaid.Text = "Amount Paid: " & If(IsDBNull(dataRow("amount_paid")), "N/A", "₱" & Convert.ToDecimal(dataRow("amount_paid")).ToString("F2"))
        lblPaymentDate.Text = "Payment Date: " & If(IsDBNull(dataRow("payment_date")), "N/A", Convert.ToDateTime(dataRow("payment_date")).ToString("yyyy-MM-dd"))
        lblPaymentStatus.Text = "Status: " & If(IsDBNull(dataRow("payment_status")), "N/A", dataRow("payment_status").ToString())
        pnlPlaceBrowser.Visible = True
    End Sub

    Private Sub MakeButtonRound(sender As Object, e As PaintEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, btn.Width, btn.Height)
        btn.Region = New Region(path)
    End Sub

    Private Sub MakePanelRound(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = CType(sender, Panel)
        Dim cornerRadius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

End Class