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
        btnPrevPlace.Location = New Point(10, 42)
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

    Private Sub BtnPrevPlace_Click(sender As Object, e As EventArgs)
        If relevantPlaceIndices.Count <= 1 Then Return
        Dim idx As Integer = relevantPlaceIndices.IndexOf(currentPlaceIndex)
        If idx > 0 Then
            currentPlaceIndex = relevantPlaceIndices(idx - 1)
            UpdatePlaceBrowserPanel()
            LoadCurrentBookingData() ' Add this line to refresh booking data
        End If
    End Sub

    Private Sub BtnNextPlace_Click(sender As Object, e As EventArgs)
        If relevantPlaceIndices.Count <= 1 Then Return
        Dim idx As Integer = relevantPlaceIndices.IndexOf(currentPlaceIndex)
        If idx < relevantPlaceIndices.Count - 1 Then
            currentPlaceIndex = relevantPlaceIndices(idx + 1)
            UpdatePlaceBrowserPanel()
            LoadCurrentBookingData() ' Add this line to refresh booking data
        End If
    End Sub

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCurrentBooking.Visible = False
        dgvCurrentBooking.Enabled = False

        pnlPlaceBrowser.Visible = True

        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        customerId = CurrentUser.CustomerId
        LoadBookings()
        LoadPaymentHistory()
        SetInitialPlace()
    End Sub

    Private Sub SetInitialPlace()
        ' Check if customer has any current payments and set the place accordingly
        Try
            Dim query As String = "SELECT b.place_id FROM payments pay " &
                                "JOIN bookings b ON pay.booking_id = b.booking_id " &
                                "WHERE pay.customer_id = @customer_id " &
                                "ORDER BY pay.payment_id DESC LIMIT 1"
            Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

            Dim dtPayment As DataTable = DBHelper.GetDataTable(query, parameters)
            If dtPayment.Rows.Count > 0 Then
                currentPlaceIndex = Convert.ToInt32(dtPayment.Rows(0)("place_id"))
                If currentPlaceIndex < 1 Or currentPlaceIndex > 25 Then
                    currentPlaceIndex = 1
                End If
            Else
                currentPlaceIndex = 1
            End If
        Catch ex As Exception
            currentPlaceIndex = 1
            Debug.WriteLine("Error setting initial place: " & ex.Message)
        End Try

        LoadRelevantPlaceIndices()
        UpdatePlaceBrowserPanel()
        LoadCurrentBookingData() ' Load initial payment data
        Debug.WriteLine($"Initial place set to: {currentPlaceIndex}")
    End Sub

    ' New method to load payment data for current place
    Private Sub LoadCurrentBookingData()
        Try
            ' Load payment data for the current place
            Dim query As String = "SELECT pay.payment_id, pay.booking_id, pay.customer_id, pay.amount_to_pay, " &
                                "pay.amount_paid, pay.payment_date, pay.payment_status, p.event_place " &
                                "FROM payments pay " &
                                "JOIN bookings b ON pay.booking_id = b.booking_id " &
                                "JOIN eventplace p ON b.place_id = p.place_id " &
                                "WHERE pay.customer_id = @customer_id AND b.place_id = @place_id " &
                                "ORDER BY pay.payment_date DESC, pay.payment_id DESC"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@customer_id", customerId},
                {"@place_id", currentPlaceIndex}
            }

            Dim dtPayments As DataTable = DBHelper.GetDataTable(query, parameters)

            If dtPayments.Rows.Count > 0 Then
                dgvPaymentHistory.DataSource = dtPayments
                btnConfirmPayment.Enabled = True
                Debug.WriteLine($"Loaded {dtPayments.Rows.Count} payment records for place {currentPlaceIndex}")
            Else
                ' Create placeholder table for no payments
                Dim dtPlaceholder As New DataTable()
                dtPlaceholder.Columns.Add("payment_id", GetType(Integer))
                dtPlaceholder.Columns.Add("booking_id", GetType(Integer))
                dtPlaceholder.Columns.Add("customer_id", GetType(Integer))
                dtPlaceholder.Columns.Add("amount_to_pay", GetType(Decimal))
                dtPlaceholder.Columns.Add("amount_paid", GetType(Decimal))
                dtPlaceholder.Columns.Add("payment_date", GetType(String))
                dtPlaceholder.Columns.Add("payment_status", GetType(String))
                dtPlaceholder.Columns.Add("event_place", GetType(String))

                Dim row As DataRow = dtPlaceholder.NewRow()
                row("payment_id") = 0
                row("booking_id") = 0
                row("customer_id") = customerId
                row("amount_to_pay") = 0
                row("amount_paid") = 0
                row("payment_date") = "N/A"
                row("payment_status") = "No payments for " & placeNames(currentPlaceIndex - 1)
                row("event_place") = placeNames(currentPlaceIndex - 1)
                dtPlaceholder.Rows.Add(row)

                dgvPaymentHistory.DataSource = dtPlaceholder
                btnConfirmPayment.Enabled = False
                Debug.WriteLine($"No payment records found for place {currentPlaceIndex}")
            End If

            dgvPaymentHistory.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading current payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

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
                btnConfirmPayment.Enabled = True
            Else
                Dim dtPlaceholder As New DataTable()
                dtPlaceholder.Columns.Add("Message", GetType(String))
                dtPlaceholder.Rows.Add("No bookings found. Start by booking an event!")
                dgvCurrentBooking.DataSource = dtPlaceholder
                btnConfirmPayment.Enabled = False
                dgvCurrentBooking.Refresh()
            End If

        Catch ex As MySqlException
        End Try
    End Sub

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
            MessageBox.Show("Error loading payment history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New FormCustomerAdminInfo(CurrentUser.UserID)
        editForm.ShowDialog()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs)
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
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

    Private Sub btnConfirmPayment_Click_1(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim amountDue As Decimal = Convert.ToDecimal(dgvPaymentHistory.SelectedRows(0).Cells("amount_to_pay").Value)
        Dim amountPaid As Decimal

        If Not Decimal.TryParse(txtPaymentAmount.Text, amountPaid) OrElse amountPaid < amountDue Then
            MessageBox.Show("Invalid amount. You must pay at least the due amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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
                LoadPaymentHistory()
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

        Try
            ' Get all place IDs that have payments for this customer
            Dim query As String = "SELECT DISTINCT b.place_id FROM payments p " &
                                "JOIN bookings b ON p.booking_id = b.booking_id " &
                                "WHERE p.customer_id = @customer_id ORDER BY b.place_id"

            Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}
            Dim dtPlaces As DataTable = DBHelper.GetDataTable(query, parameters)

            For Each row As DataRow In dtPlaces.Rows
                Dim placeId As Integer = Convert.ToInt32(row("place_id"))
                If placeId >= 1 AndAlso placeId <= 25 Then
                    relevantPlaceIndices.Add(placeId)
                End If
            Next

            relevantPlaceIndices.Sort()

            ' If no relevant places found, add current place to avoid empty list
            If relevantPlaceIndices.Count = 0 AndAlso currentPlaceIndex >= 1 AndAlso currentPlaceIndex <= 25 Then
                relevantPlaceIndices.Add(currentPlaceIndex)
            End If

        Catch ex As Exception
            Debug.WriteLine("Error loading relevant place indices: " & ex.Message)
            ' Fallback to current place
            If currentPlaceIndex >= 1 AndAlso currentPlaceIndex <= 25 Then
                relevantPlaceIndices.Add(currentPlaceIndex)
            End If
        End Try
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

    Private Sub UpdatePlaceBrowserPanel()
        Dim imageName As String = "_" & currentPlaceIndex.ToString()
        Dim img As Image = TryCast(My.Resources.ResourceManager.GetObject(imageName), Image)
        pnlPlaceBrowser.BackgroundImage = img

        For Each ctrl As Control In pnlPlaceBrowser.Controls.OfType(Of Label)().ToList()
            If ctrl.Name = "lblNoBooking" Then
                pnlPlaceBrowser.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        If relevantPlaceIndices.Count = 0 Then
            ShowNoBookingPanel()
            Return
        End If

        Dim dataRow As DataRow = GetLatestBookingPayment()
        If dataRow IsNot Nothing Then
            lblPlaceName.Text = dataRow("event_place").ToString()
            lblPaymentId.Text = "Payment ID: " & dataRow("payment_id").ToString()

            If IsDBNull(dataRow("amount_to_pay")) Then
                lblAmountToPay.Text = "Amount to Pay: N/A"
            Else
                lblAmountToPay.Text = "Amount to Pay: ₱" & Convert.ToDecimal(dataRow("amount_to_pay")).ToString("F2")
            End If

            If IsDBNull(dataRow("amount_paid")) Then
                lblAmountPaid.Text = "Amount Paid: N/A"
            Else
                lblAmountPaid.Text = "Amount Paid: ₱" & Convert.ToDecimal(dataRow("amount_paid")).ToString("F2")
            End If

            If IsDBNull(dataRow("payment_date")) Then
                lblPaymentDate.Text = "Payment Date: N/A"
            Else
                lblPaymentDate.Text = "Payment Date: " & Convert.ToDateTime(dataRow("payment_date")).ToString("yyyy-MM-dd")
            End If

            lblPaymentStatus.Text = "Status: " & dataRow("payment_status").ToString()
        Else
            lblPlaceName.Text = placeNames(currentPlaceIndex - 1)
            lblPaymentId.Text = "Payment ID: N/A"
            lblAmountToPay.Text = "Amount to Pay: N/A"
            lblAmountPaid.Text = "Amount Paid: N/A"
            lblPaymentDate.Text = "Payment Date: N/A"
            lblPaymentStatus.Text = "Status: N/A"
        End If

        For Each ctrl As Control In pnlPlaceBrowser.Controls
            ctrl.Visible = True
        Next
        pnlPlaceBrowser.Visible = True
    End Sub

    Private Function GetLatestBookingPayment() As DataRow
        Dim query As String = "SELECT p.event_place, pay.payment_id, pay.amount_to_pay, pay.amount_paid, pay.payment_date, pay.payment_status " &
                          "FROM payments pay " &
                          "JOIN bookings b ON pay.booking_id = b.booking_id " &
                          "JOIN eventplace p ON b.place_id = p.place_id " &
                          "WHERE pay.customer_id = @customer_id AND b.place_id = @place_id " &
                          "ORDER BY pay.payment_date DESC LIMIT 1"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@customer_id", customerId},
        {"@place_id", currentPlaceIndex}
    }
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If
        Return Nothing
    End Function

End Class