Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Text
Imports System.Drawing.Text
Public Class FormCustomerView

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
        LoadAllBookings()
        PopulateBookingPanels()
        Dim prop As Reflection.PropertyInfo = GetType(Panel).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(FlowLayoutPanel1, True, Nothing)

    End Sub

    Private Sub SetPanelDoubleBuffered(p As Panel)
        Dim prop = GetType(Panel).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        prop.SetValue(p, True, Nothing)
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
            quicheFont = New Font("FONTSPRING DEMO - Quiche Sans", 12, FontStyle.Bold)
        Catch
            ' If the font is embedded as a resource (e.g., Resources.QuicheSans), use PrivateFontCollection:
            'Dim pfc As New PrivateFontCollection()
            'pfc.AddFontFile("path_to_your_font_file.ttf")
            'quicheFont = New Font(pfc.Families(0), 12, FontStyle.Bold)
            ' (Uncomment and adjust if using embedded font)
            quicheFont = New Font("Arial", 12, FontStyle.Bold) ' fallback
        End Try
    End Sub

    Private Sub PopulateBookingPanels()
        LoadCustomFont()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.Visible = True

        If allBookings.Count = 0 Then
            Dim lblNoBooking As New Label()
            lblNoBooking.Text = "No booking data"
            lblNoBooking.Font = New Font(quicheFont.FontFamily, 14, FontStyle.Bold)
            lblNoBooking.ForeColor = Color.FromArgb(60, 40, 20)
            lblNoBooking.BackColor = Color.Transparent
            lblNoBooking.Size = New Size(864, 181)
            lblNoBooking.TextAlign = ContentAlignment.MiddleCenter
            FlowLayoutPanel1.Controls.Add(lblNoBooking)
            Return
        End If

        For Each dataRow As DataRow In allBookings
            ' Main panel
            Dim panel As New Panel()
            panel.Size = New Size(864, 181)
            panel.Margin = New Padding(10)
            panel.BackColor = Color.FromArgb(245, 245, 250)
            panel.BorderStyle = BorderStyle.None
            AddHandler panel.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel)

            ' PictureBox
            Dim pb As New PictureBox()
            pb.Location = New Point(13, 13)
            pb.Size = New Size(218, 152)
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            Dim placeId As Integer = Convert.ToInt32(dataRow("place_id"))
            Dim imageName As String = "_" & placeId.ToString()
            pb.Image = TryCast(My.Resources.ResourceManager.GetObject(imageName), Image)
            pb.BackColor = Color.White
            pb.BorderStyle = BorderStyle.None
            panel.Controls.Add(pb)

            ' Panel1: Place Name
            Dim panel1 As New Panel()
            panel1.Location = New Point(246, 14)
            panel1.Size = New Size(405, 50)
            panel1.BackColor = Color.FromArgb(255, 255, 255, 220)
            panel1.BorderStyle = BorderStyle.None
            AddHandler panel1.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel1)

            Dim lblPlaceName As New Label()
            lblPlaceName.Text = dataRow("event_place").ToString()
            lblPlaceName.Font = New Font(quicheFont.FontFamily, 18, FontStyle.Bold)
            lblPlaceName.ForeColor = Color.FromArgb(40, 30, 20)
            lblPlaceName.Dock = DockStyle.Fill
            lblPlaceName.TextAlign = ContentAlignment.MiddleLeft
            panel1.Controls.Add(lblPlaceName)
            panel.Controls.Add(panel1)

            ' Panel2: Details
            Dim panel2 As New Panel()
            panel2.Location = New Point(246, 71)
            panel2.Size = New Size(405, 95)
            panel2.BackColor = Color.FromArgb(245, 245, 245, 200)
            panel2.BorderStyle = BorderStyle.None
            AddHandler panel2.Paint, AddressOf MakePanelRound

            Dim detailsFont As New Font(quicheFont.FontFamily, 9, FontStyle.Regular)
            Dim y As Integer = 8
            SetPanelDoubleBuffered(panel2)

            ' Customer ID only (top left)
            Dim lblCustomerId As New Label()
            lblCustomerId.Text = "Customer ID: " & CurrentUser.CustomerId.ToString()
            lblCustomerId.Font = detailsFont
            lblCustomerId.ForeColor = Color.FromArgb(60, 40, 20)
            lblCustomerId.Location = New Point(10, y)
            lblCustomerId.Size = New Size(180, 18)
            panel2.Controls.Add(lblCustomerId)
            y += 20

            ' Booking ID and Date (side by side)
            Dim lblBookingId As New Label()
            lblBookingId.Text = "Booking ID: " & dataRow("booking_id").ToString()
            lblBookingId.Font = detailsFont
            lblBookingId.ForeColor = Color.FromArgb(60, 40, 20)
            lblBookingId.Location = New Point(10, y)
            lblBookingId.Size = New Size(180, 18)
            panel2.Controls.Add(lblBookingId)

            Dim lblEventDate As New Label()
            lblEventDate.Text = "Date: " & Convert.ToDateTime(dataRow("event_date")).ToString("yyyy-MM-dd")
            lblEventDate.Font = detailsFont
            lblEventDate.ForeColor = Color.FromArgb(60, 40, 20)
            lblEventDate.Location = New Point(200, y)
            lblEventDate.Size = New Size(200, 18)
            panel2.Controls.Add(lblEventDate)
            y += 20

            ' Event Time and Payment ID (side by side)
            Dim lblEventTime As New Label()
            lblEventTime.Text = "Time: " & dataRow("event_time").ToString() & " - " & dataRow("event_end_time").ToString()
            lblEventTime.Font = detailsFont
            lblEventTime.ForeColor = Color.FromArgb(60, 40, 20)
            lblEventTime.Location = New Point(10, y)
            lblEventTime.Size = New Size(180, 18)
            panel2.Controls.Add(lblEventTime)

            Dim lblPaymentId As New Label()
            lblPaymentId.Text = "Payment ID: " & If(IsDBNull(dataRow("payment_id")), "N/A", dataRow("payment_id").ToString())
            lblPaymentId.Font = detailsFont
            lblPaymentId.ForeColor = Color.FromArgb(60, 40, 20)
            lblPaymentId.Location = New Point(200, y)
            lblPaymentId.Size = New Size(200, 18)
            panel2.Controls.Add(lblPaymentId)
            y += 20

            ' Payment Date and Amount Paid (side by side)
            Dim lblPaymentDate As New Label()
            lblPaymentDate.Text = "Payment Date: " & If(IsDBNull(dataRow("payment_date")), "N/A", Convert.ToDateTime(dataRow("payment_date")).ToString("yyyy-MM-dd"))
            lblPaymentDate.Font = detailsFont
            lblPaymentDate.ForeColor = Color.FromArgb(60, 40, 20)
            lblPaymentDate.Location = New Point(10, y)
            lblPaymentDate.Size = New Size(180, 18)
            panel2.Controls.Add(lblPaymentDate)

            Dim lblAmountPaid As New Label()
            lblAmountPaid.Text = "Amount Paid: " & If(IsDBNull(dataRow("amount_paid")), "N/A", "₱" & Convert.ToDecimal(dataRow("amount_paid")).ToString("F2"))
            lblAmountPaid.Font = detailsFont
            lblAmountPaid.ForeColor = Color.FromArgb(60, 40, 20)
            lblAmountPaid.Location = New Point(200, y)
            lblAmountPaid.Size = New Size(200, 18)
            panel2.Controls.Add(lblAmountPaid)

            panel.Controls.Add(panel2)



            ' Panel3: Approval & Price
            Dim panel3 As New Panel()
            panel3.Location = New Point(664, 14)
            panel3.Size = New Size(189, 120)
            panel3.BackColor = Color.FromArgb(255, 255, 255, 230)
            panel3.BorderStyle = BorderStyle.None
            AddHandler panel3.Paint, AddressOf MakePanelRound
            SetPanelDoubleBuffered(panel3)

            Dim lblApproval As New Label()
            Dim isApproved As Boolean = dataRow("status").ToString().ToLower() = "approved"
            lblApproval.Text = If(isApproved, "Approved", "Pending")
            lblApproval.Font = New Font(quicheFont.FontFamily, 13, FontStyle.Bold)
            lblApproval.ForeColor = If(isApproved, Color.SeaGreen, Color.OrangeRed)
            lblApproval.Location = New Point(20, 20)
            lblApproval.Size = New Size(150, 24)
            lblApproval.TextAlign = ContentAlignment.MiddleCenter
            panel3.Controls.Add(lblApproval)

            Dim lblAmountToPay As New Label()
            lblAmountToPay.Text = "₱" & If(IsDBNull(dataRow("amount_to_pay")), "0.00", Convert.ToDecimal(dataRow("amount_to_pay")).ToString("F2"))
            lblAmountToPay.Font = New Font(quicheFont.FontFamily, 15, FontStyle.Bold)
            lblAmountToPay.ForeColor = Color.FromArgb(60, 40, 20)
            lblAmountToPay.Location = New Point(20, 60)
            lblAmountToPay.Size = New Size(150, 30)
            lblAmountToPay.TextAlign = ContentAlignment.MiddleCenter
            panel3.Controls.Add(lblAmountToPay)

            panel.Controls.Add(panel3)

            ' TextBox1: Payment input
            Dim txtPayment As New TextBox()
            txtPayment.Location = New Point(664, 146)
            txtPayment.Size = New Size(94, 20)
            txtPayment.Font = detailsFont
            txtPayment.Visible = isApproved

            ' Button1: Pay
            Dim btnPay As New Button()
            btnPay.Text = "Pay"
            btnPay.Location = New Point(766, 146)
            btnPay.Size = New Size(87, 20)
            btnPay.Font = detailsFont
            btnPay.BackColor = Color.FromArgb(220, 240, 220)
            btnPay.FlatStyle = FlatStyle.Flat
            btnPay.Enabled = isApproved
            btnPay.Visible = isApproved

            ' If already paid, show as paid and disable payment
            Dim isPaid As Boolean = False
            If Not IsDBNull(dataRow("amount_paid")) AndAlso Not IsDBNull(dataRow("amount_to_pay")) Then
                Dim paid = Convert.ToDecimal(dataRow("amount_paid"))
                Dim toPay = Convert.ToDecimal(dataRow("amount_to_pay"))
                If paid >= toPay AndAlso toPay > 0 Then
                    isPaid = True
                End If
            End If
            If isPaid Then
                btnPay.Enabled = False
                btnPay.Text = "Paid"
                txtPayment.Visible = False
                Dim lblPaid As New Label()
                lblPaid.Text = "Paid"
                lblPaid.Font = New Font(quicheFont.FontFamily, 10, FontStyle.Bold)
                lblPaid.ForeColor = Color.SeaGreen
                lblPaid.Location = New Point(664, 146)
                lblPaid.Size = New Size(94, 20)
                panel.Controls.Add(lblPaid)
            End If

            ' Payment logic
            AddHandler btnPay.Click,
                Sub(senderBtn, eBtn)
                    Dim payAmount As Decimal
                    If Not Decimal.TryParse(txtPayment.Text, payAmount) OrElse payAmount <= 0 Then
                        MessageBox.Show("Please enter a valid payment amount.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    Dim toPay = Convert.ToDecimal(dataRow("amount_to_pay"))
                    Dim paid = If(IsDBNull(dataRow("amount_paid")), 0D, Convert.ToDecimal(dataRow("amount_paid")))
                    If paid + payAmount > toPay Then
                        MessageBox.Show("Payment exceeds required amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Update database
                    Dim paymentId = dataRow("payment_id")
                    Dim newPaid = paid + payAmount
                    Dim updateQuery As String = "UPDATE payments SET amount_paid = @amount_paid, payment_date = @payment_date, payment_status = @payment_status WHERE payment_id = @payment_id"
                    Dim parameters As New Dictionary(Of String, Object) From {
                        {"@amount_paid", newPaid},
                        {"@payment_date", DateTime.Now},
                        {"@payment_status", If(newPaid >= toPay, "Paid", "Partial")},
                        {"@payment_id", paymentId}
                    }
                    'DBHelper.ExecuteNonQuery(updateQuery, parameters)
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





End Class
