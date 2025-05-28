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
