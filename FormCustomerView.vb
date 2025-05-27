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


    ' Place names array
    Private placeNames As String() = {
        "Auditorium", "Ballroom", "Banquet Hall", "Bar", "Cafe", "Club",
        "Conference Hall", "Country Club", "Event Space", "Function Room",
        "Gallery", "Halal Venue", "Hotel", "Kids-Friendly Venue", "Meeting Room",
        "Museum", "Outdoor Venue", "Private Estate", "Restaurant", "Rooftop Venue",
        "Seminar Room", "Studio", "Theater", "Training Room", "Yacht"
    }

    ' Constructor to accept customer ID
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        customerId = id ' Store passed customer ID
        CreatePlaceBrowserPanel()
    End Sub

    Private Sub CreatePlaceBrowserPanel()
        ' Create main panel
        pnlPlaceBrowser = New Panel()
        pnlPlaceBrowser.Size = New Size(863, 124)
        pnlPlaceBrowser.Location = New Point(43, 104)
        pnlPlaceBrowser.BorderStyle = BorderStyle.FixedSingle
        pnlPlaceBrowser.Visible = False
        pnlPlaceBrowser.BackgroundImageLayout = ImageLayout.Stretch

        ' Create navigation buttons
        btnPrevPlace = New Button()
        btnPrevPlace.Text = "◀"
        btnPrevPlace.Size = New Size(40, 40)
        btnPrevPlace.Location = New Point(10, 42)
        btnPrevPlace.BackColor = Color.LightGray
        btnPrevPlace.FlatStyle = FlatStyle.Flat
        btnPrevPlace.FlatAppearance.BorderSize = 0
        AddHandler btnPrevPlace.Click, AddressOf BtnPrevPlace_Click
        AddHandler btnPrevPlace.Paint, AddressOf MakeButtonRound

        btnNextPlace = New Button()
        btnNextPlace.Text = "▶"
        btnNextPlace.Size = New Size(40, 40)
        btnNextPlace.Location = New Point(813, 42)
        btnNextPlace.BackColor = Color.LightGray
        btnNextPlace.FlatStyle = FlatStyle.Flat
        btnNextPlace.FlatAppearance.BorderSize = 0
        AddHandler btnNextPlace.Click, AddressOf BtnNextPlace_Click
        AddHandler btnNextPlace.Paint, AddressOf MakeButtonRound

        ' Payment info labels
        lblPaymentId = New Label()
        lblPaymentId.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentId.ForeColor = Color.Black
        lblPaymentId.BackColor = Color.Transparent
        lblPaymentId.Size = New Size(300, 20)
        lblPaymentId.Location = New Point(60, 10)

        lblAmountToPay = New Label()
        lblAmountToPay.Font = New Font("Arial", 10, FontStyle.Bold)
        lblAmountToPay.ForeColor = Color.Black
        lblAmountToPay.BackColor = Color.Transparent
        lblAmountToPay.Size = New Size(300, 20)
        lblAmountToPay.Location = New Point(60, 35)

        lblAmountPaid = New Label()
        lblAmountPaid.Font = New Font("Arial", 10, FontStyle.Bold)
        lblAmountPaid.ForeColor = Color.Black
        lblAmountPaid.BackColor = Color.Transparent
        lblAmountPaid.Size = New Size(300, 20)
        lblAmountPaid.Location = New Point(60, 60)

        lblPaymentDate = New Label()
        lblPaymentDate.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentDate.ForeColor = Color.Black
        lblPaymentDate.BackColor = Color.Transparent
        lblPaymentDate.Size = New Size(300, 20)
        lblPaymentDate.Location = New Point(400, 10)

        lblPaymentStatus = New Label()
        lblPaymentStatus.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPaymentStatus.ForeColor = Color.Black
        lblPaymentStatus.BackColor = Color.Transparent
        lblPaymentStatus.Size = New Size(300, 20)
        lblPaymentStatus.Location = New Point(400, 35)

        pnlPlaceBrowser.Controls.Add(lblPaymentId)
        pnlPlaceBrowser.Controls.Add(lblAmountToPay)
        pnlPlaceBrowser.Controls.Add(lblAmountPaid)
        pnlPlaceBrowser.Controls.Add(lblPaymentDate)
        pnlPlaceBrowser.Controls.Add(lblPaymentStatus)


        ' Add controls to panel
        pnlPlaceBrowser.Controls.Add(btnPrevPlace)
        pnlPlaceBrowser.Controls.Add(btnNextPlace)
        pnlPlaceBrowser.Controls.Add(lblPlaceName)
        pnlPlaceBrowser.Controls.Add(lblPlaceDetails)

        ' Add panel to form
        Me.Controls.Add(pnlPlaceBrowser)
        pnlPlaceBrowser.BringToFront()
    End Sub

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCurrentBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        customerId = CurrentUser.CustomerId

        lblUsername.Text = CurrentUser.Username
        LoadBookings()
        LoadPaymentHistory()

        ' Set initial place based on customer's current booking
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
    End Sub

    Private Sub UpdatePlaceDisplay()
        If currentPlaceIndex < 1 Then currentPlaceIndex = 25
        If currentPlaceIndex > 25 Then currentPlaceIndex = 1

        ' Update place name


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
        currentPlaceIndex -= 1
        UpdatePlaceDisplay()
    End Sub

    Private Sub BtnNextPlace_Click(sender As Object, e As EventArgs)
        currentPlaceIndex += 1
        UpdatePlaceDisplay()
    End Sub

    ' ✅ Load only current customer bookings
    Private Sub LoadBookings()
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
            btnSwitchView.Text = "Browse Places"
        Else
            ' Show panel view, hide grid
            dgvCurrentBooking.Visible = False
            pnlPlaceBrowser.Visible = True
            btnSwitchView.Text = "Show Bookings"
            UpdatePlaceDisplay()
        End If
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

End Class