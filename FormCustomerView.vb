Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Text
Imports System.Drawing.Text
Public Class FormCustomerView

    Private currentFilter As String = "all" ' Options: "pending", "rejected", "approved", "paid"



    Private user_id As Integer
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
    ' At the top of FormCustomerView
    Private customer_id As Integer



    Private placeNames As String() = {
        "Auditorium", "Ballroom", "Banquet Hall", "Bar", "Cafe", "Club",
        "Conference Hall", "Country Club", "Event Space", "Function Room",
        "Gallery", "Halal Venue", "Hotel", "Kids-Friendly Venue", "Meeting Room",
        "Museum", "Outdoor Venue", "Private Estate", "Restaurant", "Rooftop Venue",
        "Seminar Room", "Studio", "Theater", "Training Room", "Yacht"
    }

    Public Sub New()
        InitializeComponent()

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

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        customer_id = id
    End Sub

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer_id = CurrentUser.CustomerId
        Debug.WriteLine("customer_id used for query: " & customer_id)
        LoadAllBookings()
        PopulateBookingPanels()
        Dim prop As Reflection.PropertyInfo = GetType(Panel).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(FlowLayoutPanel1, True, Nothing)

        lblUsername.Text = CurrentUser.Username
        lblRole.Text = CurrentUser.Role
    End Sub

    Private Sub SetPanelDoubleBuffered(p As Panel)
        Dim prop = GetType(Panel).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(p, True, Nothing)
    End Sub


    Private Sub LoadAllBookings()
        allBookings.Clear()
        Debug.WriteLine("customer_id used for query: " & CurrentUser.CustomerId)

        Dim query As String = "
        SELECT b.booking_id, b.place_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status,
               pay.payment_id, pay.amount_to_pay, pay.amount_paid, pay.payment_date, pay.payment_status,
               b.customer_id, c.name AS customer_name
        FROM bookings b
        LEFT JOIN payments pay ON pay.booking_id = b.booking_id
        JOIN eventplace p ON b.place_id = p.place_id
        JOIN customers c ON b.customer_id = c.customer_id
        WHERE b.customer_id = @customer_id
        ORDER BY b.event_date DESC, b.booking_id DESC
    "
        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", CurrentUser.CustomerId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
        For Each row As DataRow In dt.Rows
            allBookings.Add(row)
        Next
        Debug.WriteLine($"Loaded {allBookings.Count} bookings for customer {CurrentUser.CustomerId}")
    End Sub


    Private Sub ShowNoBookingPanel()
        pnlPlaceBrowser.BackgroundImage = Nothing
        pnlPlaceBrowser.BackColor = Color.Beige
        For Each ctrl As Control In pnlPlaceBrowser.Controls
            ctrl.Visible = False
        Next
        Dim lblNoBooking As New Label()
        lblNoBooking.Text = "No booking data"
        lblNoBooking.Font = New Font("Poppins", 18, FontStyle.Bold)
        lblNoBooking.ForeColor = Color.Black
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
            pnlPlaceBrowser.Refresh()
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

    ' At the class level
    Private quicheFont As Font = Nothing

    Private Sub LoadCustomFont()
        If quicheFont IsNot Nothing Then Return
        Try
            ' If the font is installed on the system:
            quicheFont = New Font("Poppins", 8, FontStyle.Bold)
        Catch
            quicheFont = New Font("Arial", 8, FontStyle.Bold) ' fallback
        End Try
    End Sub

    Private Sub PopulateBookingPanels()
        LoadCustomFont()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.Visible = True
        Debug.WriteLine("Bookings loaded: " & allBookings.Count)


        ' --- Filtering logic ---
        Dim filteredBookings = allBookings.AsEnumerable()

        filteredBookings = filteredBookings.Where(Function(row)
                                                      Dim status = row("status").ToString().ToLower()
                                                      Dim paymentStatus = If(IsDBNull(row("payment_status")), "", row("payment_status").ToString().ToLower())

                                                      Select Case currentFilter
                                                          Case "pending"
                                                              lblSelected.Text = "Currently Viewing: Pending Bookings"
                                                              Return status = "pending"
                                                          Case "rejected"
                                                              lblSelected.Text = "Currently Viewing: Rejected Bookings"
                                                              Return status = "rejected"
                                                          Case "paid"
                                                              lblSelected.Text = "Currently Viewing: Paid Bookings"
                                                              Return (status = "paid") OrElse (status = "approved" AndAlso paymentStatus = "paid")
                                                          Case "approved"
                                                              lblSelected.Text = "Currently Viewing: Approved Bookings"
                                                              Return status = "approved" AndAlso paymentStatus <> "paid"
                                                          Case Else
                                                              lblSelected.Text = "Select what to view!"
                                                              Return False
                                                      End Select
                                                  End Function)



        ' Search filtering
        Dim searchText = txtSearch.Text.Trim().ToLower()
        If searchText.Length > 0 Then
            filteredBookings = filteredBookings.Where(Function(row)
                                                          Dim placeName = row("event_place").ToString().ToLower()
                                                          Dim customerName = If(row.Table.Columns.Contains("customer_name"), row("customer_name").ToString().ToLower(), "")
                                                          Dim customerId = row("customer_id").ToString().ToLower()
                                                          Dim bookingId = row("booking_id").ToString().ToLower()
                                                          Dim paymentId = If(IsDBNull(row("payment_id")), "", row("payment_id").ToString().ToLower())
                                                          Return placeName.Contains(searchText) OrElse
                   customerName.Contains(searchText) OrElse
                   customerId.Contains(searchText) OrElse
                   bookingId.Contains(searchText) OrElse
                   paymentId.Contains(searchText)
                                                      End Function)
        End If

        ' Sort by event_date DESC, booking_id DESC (already sorted in LoadAllBookings, but ensure)
        filteredBookings = filteredBookings.OrderByDescending(Function(row) Convert.ToDateTime(row("event_date"))).ThenByDescending(Function(row) Convert.ToInt32(row("booking_id")))

        If Not filteredBookings.Any() Then
            Dim lblNoBooking As New Label()
            lblNoBooking.Text = ""
            lblNoBooking.Font = New Font(quicheFont.FontFamily, 14, FontStyle.Bold)
            lblNoBooking.ForeColor = Color.Black
            lblNoBooking.BackColor = Color.Transparent
            lblNoBooking.Size = New Size(864, 181)
            lblNoBooking.TextAlign = ContentAlignment.MiddleCenter
            FlowLayoutPanel1.Controls.Add(lblNoBooking)
            Return
        End If

        For Each dataRow As DataRow In filteredBookings
            ' Main panel
            Dim panel As New Panel()
            panel.Size = New Size(864, 181)
            panel.Margin = New Padding(10)
            panel.BackColor = Color.FromArgb(229, 222, 210)
            panel.BorderStyle = BorderStyle.None
            AddHandler panel.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel)

            ' PictureBox (rounded rectangle)
            Dim pb As New PictureBox()
            pb.Location = New Point(13, 13)
            pb.Size = New Size(218, 152)
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            Dim placeId As Integer = Convert.ToInt32(dataRow("place_id"))
            Dim imageName As String = "_" & placeId.ToString()
            pb.Image = TryCast(My.Resources.ResourceManager.GetObject(imageName), Image)
            pb.BackColor = Color.White
            pb.BorderStyle = BorderStyle.None


            ' Panel1: Place Name (rounded rectangle, set region directly)
            Dim panel1 As New Panel()
            panel1.Location = New Point(246, 14)
            panel1.Size = New Size(405, 50)
            panel1.BackColor = Color.FromArgb(255, 206, 200, 189)
            panel1.BorderStyle = BorderStyle.None
            SetPanelDoubleBuffered(panel1)

            Dim lblPlaceName As New Label()
            lblPlaceName.Text = dataRow("event_place").ToString()
            lblPlaceName.Font = New Font(quicheFont.FontFamily, 18, FontStyle.Bold)
            lblPlaceName.ForeColor = Color.Black
            lblPlaceName.Dock = DockStyle.Fill
            lblPlaceName.TextAlign = ContentAlignment.MiddleCenter
            panel1.Controls.Add(lblPlaceName)
            panel.Controls.Add(panel1)

            ' Panel2: Details (rounded rectangle)
            Dim panel2 As New Panel()
            panel2.Location = New Point(246, 71)
            panel2.Size = New Size(405, 95)
            panel2.BackColor = Color.FromArgb(255, 206, 200, 189)
            panel2.BorderStyle = BorderStyle.None
            AddHandler panel2.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel2)

            Dim detailsFont As New Font(quicheFont.FontFamily, 9, FontStyle.Regular)
            Dim y As Integer = 8

            ' Row 1: Customer Name (left), Booking ID (right)
            Dim customerName As String = If(dataRow.Table.Columns.Contains("customer_name"), dataRow("customer_name").ToString(), CurrentUser.Username)
            Dim lblCustomerName As New Label()
            lblCustomerName.Text = "Customer Name: " & customerName
            lblCustomerName.Font = detailsFont
            lblCustomerName.ForeColor = Color.Black
            lblCustomerName.Location = New Point(10, y)
            lblCustomerName.Size = New Size(180, 18)
            panel2.Controls.Add(lblCustomerName)

            Dim lblBookingId As New Label()
            lblBookingId.Text = "Booking ID: " & dataRow("booking_id").ToString()
            lblBookingId.Font = detailsFont
            lblBookingId.ForeColor = Color.Black
            lblBookingId.Location = New Point(200, y)
            lblBookingId.Size = New Size(180, 18)
            panel2.Controls.Add(lblBookingId)
            y += 20

            ' Row 2: Customer ID (left), Event Date (right)
            Dim lblCustomerId As New Label()
            lblCustomerId.Text = "Customer ID: " & CurrentUser.CustomerId.ToString()
            lblCustomerId.Font = detailsFont
            lblCustomerId.ForeColor = Color.Black
            lblCustomerId.Location = New Point(10, y)
            lblCustomerId.Size = New Size(180, 18)
            panel2.Controls.Add(lblCustomerId)

            Dim lblEventDate As New Label()
            lblEventDate.Text = "Date: " & Convert.ToDateTime(dataRow("event_date")).ToString("yyyy-MM-dd")
            lblEventDate.Font = detailsFont
            lblEventDate.ForeColor = Color.Black
            lblEventDate.Location = New Point(200, y)
            lblEventDate.Size = New Size(180, 18)
            panel2.Controls.Add(lblEventDate)
            y += 20

            ' Row 3: Payment ID (left), Event Time (right)
            Dim lblPaymentId As New Label()
            lblPaymentId.Text = "Payment ID: " & If(IsDBNull(dataRow("payment_id")), "N/A", dataRow("payment_id").ToString())
            lblPaymentId.Font = detailsFont
            lblPaymentId.ForeColor = Color.Black
            lblPaymentId.Location = New Point(10, y)
            lblPaymentId.Size = New Size(180, 18)
            panel2.Controls.Add(lblPaymentId)

            Dim lblEventTime As New Label()
            lblEventTime.Text = "Time: " & dataRow("event_time").ToString() & " - " & dataRow("event_end_time").ToString()
            lblEventTime.Font = detailsFont
            lblEventTime.ForeColor = Color.Black
            lblEventTime.Location = New Point(200, y)
            lblEventTime.Size = New Size(180, 18)
            panel2.Controls.Add(lblEventTime)
            y += 20

            ' Row 4: Payment Date (left), Amount Paid (right)
            Dim lblPaymentDate As New Label()
            lblPaymentDate.Text = "Payment Date: " & If(IsDBNull(dataRow("payment_date")), "N/A", Convert.ToDateTime(dataRow("payment_date")).ToString("yyyy-MM-dd"))
            lblPaymentDate.Font = detailsFont
            lblPaymentDate.ForeColor = Color.Black
            lblPaymentDate.Location = New Point(10, y)
            lblPaymentDate.Size = New Size(180, 18)
            panel2.Controls.Add(lblPaymentDate)

            Dim lblAmountPaid As New Label()
            lblAmountPaid.Text = "Amount Paid: " & If(IsDBNull(dataRow("amount_paid")), "N/A", "₱" & Convert.ToDecimal(dataRow("amount_paid")).ToString("F2"))
            lblAmountPaid.Font = detailsFont
            lblAmountPaid.ForeColor = Color.Black
            lblAmountPaid.Location = New Point(200, y)
            lblAmountPaid.Size = New Size(180, 18)
            panel2.Controls.Add(lblAmountPaid)



            panel.Controls.Add(panel2)

            ' Panel3: Approval & Price (rounded rectangle, match color to panel1/panel2)
            Dim panel3 As New Panel()
            Dim statusStr As String = dataRow("status").ToString().ToLower()
            Dim isApproved As Boolean = statusStr = "approved"
            Dim isRejected As Boolean = statusStr = "rejected"
            Dim isPending As Boolean = statusStr = "pending"

            panel3.Location = New Point(664, 14)
            panel3.Size = New Size(189, 152)
            panel3.BackColor = Color.FromArgb(255, 206, 200, 189) ' Match panel1/panel2
            panel3.BorderStyle = BorderStyle.None
            AddHandler panel3.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel3)

            Dim paid As Decimal = If(IsDBNull(dataRow("amount_paid")), 0D, Convert.ToDecimal(dataRow("amount_paid")))
            Dim toPay As Decimal = If(IsDBNull(dataRow("amount_to_pay")), 0D, Convert.ToDecimal(dataRow("amount_to_pay")))
            Dim isPaid As Boolean = (paid >= toPay AndAlso toPay > 0)

            panel3.Controls.Clear()

            If isPaid Then
                ' Paid: show "Paid" centered, no price
                panel3.Size = New Size(189, 152)
                Dim lblPaid As New Label()
                lblPaid.Text = "Paid"
                lblPaid.Font = New Font(quicheFont.FontFamily, 18, FontStyle.Bold)
                lblPaid.ForeColor = Color.SeaGreen
                lblPaid.Dock = DockStyle.Fill
                lblPaid.TextAlign = ContentAlignment.MiddleCenter
                panel3.Controls.Add(lblPaid)
            ElseIf isPending OrElse isApproved Then
                ' Pending or Approved: status centered, price below
                Dim lblStatus As New Label()
                lblStatus.Text = If(isApproved, "Approved", "Pending")
                lblStatus.Font = New Font(quicheFont.FontFamily, 13, FontStyle.Bold)
                lblStatus.ForeColor = If(isApproved, Color.SeaGreen, Color.OrangeRed)
                lblStatus.Dock = DockStyle.Fill
                lblStatus.TextAlign = ContentAlignment.MiddleCenter
                panel3.Controls.Add(lblStatus)

                If isApproved Then
                    panel3.Size = New Size(189, 126)
                    Dim lblAmountToPay As New Label()
                    lblAmountToPay.Text = "₱" & toPay.ToString("F2")
                    lblAmountToPay.Font = New Font(quicheFont.FontFamily, 15, FontStyle.Bold)
                    lblAmountToPay.ForeColor = Color.Black
                    lblAmountToPay.Dock = DockStyle.Bottom
                    lblAmountToPay.Height = 38
                    lblAmountToPay.TextAlign = ContentAlignment.MiddleCenter
                    panel3.Controls.Add(lblAmountToPay)
                End If

            ElseIf isRejected Then
                Dim lblRejected As New Label()
                lblRejected.Text = "Rejected"
                lblRejected.Font = New Font(quicheFont.FontFamily, 13, FontStyle.Bold)
                lblRejected.ForeColor = Color.OrangeRed
                lblRejected.Dock = DockStyle.Fill
                lblRejected.TextAlign = ContentAlignment.MiddleCenter
                panel3.Controls.Add(lblRejected)
            End If

            panel.Controls.Add(panel3)

            If isRejected Then
                panel.BackColor = Color.FromArgb(214, 211, 202)
                For Each ctrl As Control In panel.Controls
                    ctrl.Enabled = False
                Next
            End If

            ' Payment controls
            Dim txtPayment As New TextBox()
            txtPayment.Location = New Point(664, 146)
            txtPayment.Size = New Size(94, 20)
            txtPayment.Font = detailsFont
            txtPayment.Visible = isApproved AndAlso Not isPaid

            Dim btnPay As New Button()
            btnPay.Text = "Pay"
            btnPay.Location = New Point(766, 146)
            btnPay.Size = New Size(87, 22)
            btnPay.Font = New Font(detailsFont.FontFamily, 7, FontStyle.Regular)
            btnPay.BackColor = Color.FromArgb(220, 240, 220)
            btnPay.FlatStyle = FlatStyle.Flat
            btnPay.Enabled = isApproved AndAlso Not isPaid
            btnPay.Visible = isApproved AndAlso Not isPaid

            AddHandler btnPay.Click,
        Sub(senderBtn, eBtn)
            Dim payAmount As Decimal
            If Not Decimal.TryParse(txtPayment.Text, payAmount) OrElse payAmount <= 0 Then
                MessageBox.Show("Please enter a valid payment amount.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If payAmount <> toPay Then
                MessageBox.Show("You must pay the exact amount.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If paid >= toPay Then
                MessageBox.Show("Already paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim paymentId = dataRow("payment_id")
            Dim updateQuery As String = "UPDATE payments SET amount_paid = @amount_paid, payment_date = @payment_date, payment_status = @payment_status WHERE payment_id = @payment_id"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@amount_paid", payAmount},
                {"@payment_date", DateTime.Now},
                {"@payment_status", "Paid"},
                {"@payment_id", paymentId}
            }
            DBHelper.ExecuteQuery(updateQuery, parameters)

            ' Also update the booking status to "paid" BEFORE reloading bookings
            Dim bookingId = dataRow("booking_id")
            Dim updateBookingQuery As String = "UPDATE bookings SET status = @status WHERE booking_id = @booking_id"
            Dim bookingParams As New Dictionary(Of String, Object) From {
                {"@status", "paid"},
                {"@booking_id", bookingId}
            }
            DBHelper.ExecuteQuery(updateBookingQuery, bookingParams)

            MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllBookings()
            PopulateBookingPanels()





        End Sub

            If isApproved AndAlso Not isPaid Then
                panel.Controls.Add(txtPayment)
                panel.Controls.Add(btnPay)
            End If

            FlowLayoutPanel1.Controls.Add(panel)
        Next
    End Sub


    Private Sub SetPanelRect(p As Panel)
        p.Region = New Region(New Rectangle(0, 0, p.Width, p.Height))
    End Sub

    Private Sub MakePictureBoxRect(sender As Object, e As PaintEventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        pb.Region = New Region(New Rectangle(0, 0, pb.Width, pb.Height))
    End Sub



    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        PopulateBookingPanels()
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        currentFilter = "pending"
        PopulateBookingPanels()
    End Sub

    Private Sub btnRejected_Click(sender As Object, e As EventArgs) Handles btnRejected.Click
        currentFilter = "rejected"
        PopulateBookingPanels()
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        currentFilter = "approved"
        PopulateBookingPanels()
    End Sub

    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        currentFilter = "paid"
        PopulateBookingPanels()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class