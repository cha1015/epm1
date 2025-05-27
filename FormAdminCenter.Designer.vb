<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminCenter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminCenter))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnCustomerView = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tcAdminCenter = New System.Windows.Forms.TabControl()
        Me.tpBookings = New System.Windows.Forms.TabPage()
        Me.lblBookedDates = New System.Windows.Forms.Label()
        Me.flpBookedDates = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPendingBookings = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.flpAvailability = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpPendingBookings = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpInvoicesAndPayments = New System.Windows.Forms.TabPage()
        Me.flpInvoices = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpReports = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chartTotalStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.flpRevenueReports = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpEventPlaceMgmt = New System.Windows.Forms.TabPage()
        Me.flpEventPlaces = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPlaceID = New System.Windows.Forms.TextBox()
        Me.lblPlaceID = New System.Windows.Forms.Label()
        Me.lblErrorCapacity = New System.Windows.Forms.Label()
        Me.lblErrorOpeningHours = New System.Windows.Forms.Label()
        Me.lblErrorPrice = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtAvailableDays = New System.Windows.Forms.TextBox()
        Me.lblAvailableDays = New System.Windows.Forms.Label()
        Me.txtClosingHours = New System.Windows.Forms.TextBox()
        Me.lblClosingHours = New System.Windows.Forms.Label()
        Me.txtOpeningHours = New System.Windows.Forms.TextBox()
        Me.lblOpeningHours = New System.Windows.Forms.Label()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.lblImageUrl = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtEventType = New System.Windows.Forms.TextBox()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.txtEventPlace = New System.Windows.Forms.TextBox()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.lblPricePerDay = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtPricePerDay = New System.Windows.Forms.TextBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.tpCustomerRecords = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumCustomersContainer = New System.Windows.Forms.Label()
        Me.flpCustomerRecords = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tcAdminCenter.SuspendLayout()
        Me.tpBookings.SuspendLayout()
        Me.tpInvoicesAndPayments.SuspendLayout()
        Me.tpReports.SuspendLayout()
        CType(Me.chartTotalStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventPlaceMgmt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpCustomerRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(193, 32)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(18, 20)
        Me.btnNext.TabIndex = 89
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(169, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(18, 20)
        Me.btnBack.TabIndex = 88
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogOut
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(856, 43)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(66, 19)
        Me.btnLogOut.TabIndex = 93
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnCustomerView
        '
        Me.btnCustomerView.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomerView.BackgroundImage = Global.epm1.My.Resources.Resources.BttnMyAccount
        Me.btnCustomerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerView.FlatAppearance.BorderSize = 0
        Me.btnCustomerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerView.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerView.ForeColor = System.Drawing.Color.Black
        Me.btnCustomerView.Location = New System.Drawing.Point(856, 20)
        Me.btnCustomerView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCustomerView.Name = "btnCustomerView"
        Me.btnCustomerView.Size = New System.Drawing.Size(66, 19)
        Me.btnCustomerView.TabIndex = 92
        Me.btnCustomerView.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(746, 43)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(46, 15)
        Me.lblRole.TabIndex = 91
        Me.lblRole.Text = "Admin"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(746, 27)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 15)
        Me.lblUsername.TabIndex = 90
        Me.lblUsername.Text = "Admin Name"
        '
        'tcAdminCenter
        '
        Me.tcAdminCenter.Controls.Add(Me.tpBookings)
        Me.tcAdminCenter.Controls.Add(Me.tpInvoicesAndPayments)
        Me.tcAdminCenter.Controls.Add(Me.tpReports)
        Me.tcAdminCenter.Controls.Add(Me.tpEventPlaceMgmt)
        Me.tcAdminCenter.Controls.Add(Me.tpCustomerRecords)
        Me.tcAdminCenter.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAdminCenter.ImageList = Me.ImageList1
        Me.tcAdminCenter.Location = New System.Drawing.Point(22, 76)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(900, 405)
        Me.tcAdminCenter.TabIndex = 94
        '
        'tpBookings
        '
        Me.tpBookings.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpBookings.Controls.Add(Me.lblBookedDates)
        Me.tpBookings.Controls.Add(Me.flpBookedDates)
        Me.tpBookings.Controls.Add(Me.lblPendingBookings)
        Me.tpBookings.Controls.Add(Me.lblAvailability)
        Me.tpBookings.Controls.Add(Me.flpAvailability)
        Me.tpBookings.Controls.Add(Me.flpPendingBookings)
        Me.tpBookings.Location = New System.Drawing.Point(4, 23)
        Me.tpBookings.Name = "tpBookings"
        Me.tpBookings.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpBookings.Size = New System.Drawing.Size(892, 378)
        Me.tpBookings.TabIndex = 6
        Me.tpBookings.Text = "Bookings"
        Me.tpBookings.UseVisualStyleBackColor = True
        '
        'lblBookedDates
        '
        Me.lblBookedDates.AutoSize = True
        Me.lblBookedDates.Location = New System.Drawing.Point(6, 10)
        Me.lblBookedDates.Name = "lblBookedDates"
        Me.lblBookedDates.Size = New System.Drawing.Size(90, 15)
        Me.lblBookedDates.TabIndex = 4
        Me.lblBookedDates.Text = "Booked Dates"
        '
        'flpBookedDates
        '
        Me.flpBookedDates.Location = New System.Drawing.Point(7, 32)
        Me.flpBookedDates.Name = "flpBookedDates"
        Me.flpBookedDates.Size = New System.Drawing.Size(302, 145)
        Me.flpBookedDates.TabIndex = 2
        '
        'lblPendingBookings
        '
        Me.lblPendingBookings.AutoSize = True
        Me.lblPendingBookings.Location = New System.Drawing.Point(310, 10)
        Me.lblPendingBookings.Name = "lblPendingBookings"
        Me.lblPendingBookings.Size = New System.Drawing.Size(120, 15)
        Me.lblPendingBookings.TabIndex = 3
        Me.lblPendingBookings.Text = "Pending Bookings"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(3, 180)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(79, 15)
        Me.lblAvailability.TabIndex = 2
        Me.lblAvailability.Text = "Availability"
        '
        'flpAvailability
        '
        Me.flpAvailability.Location = New System.Drawing.Point(6, 202)
        Me.flpAvailability.Name = "flpAvailability"
        Me.flpAvailability.Size = New System.Drawing.Size(302, 165)
        Me.flpAvailability.TabIndex = 1
        '
        'flpPendingBookings
        '
        Me.flpPendingBookings.Location = New System.Drawing.Point(314, 32)
        Me.flpPendingBookings.Name = "flpPendingBookings"
        Me.flpPendingBookings.Size = New System.Drawing.Size(578, 336)
        Me.flpPendingBookings.TabIndex = 0
        '
        'tpInvoicesAndPayments
        '
        Me.tpInvoicesAndPayments.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpInvoicesAndPayments.Controls.Add(Me.flpInvoices)
        Me.tpInvoicesAndPayments.Location = New System.Drawing.Point(4, 23)
        Me.tpInvoicesAndPayments.Name = "tpInvoicesAndPayments"
        Me.tpInvoicesAndPayments.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpInvoicesAndPayments.Size = New System.Drawing.Size(892, 378)
        Me.tpInvoicesAndPayments.TabIndex = 5
        Me.tpInvoicesAndPayments.Text = "Invoices and Payments"
        Me.tpInvoicesAndPayments.UseVisualStyleBackColor = True
        '
        'flpInvoices
        '
        Me.flpInvoices.Location = New System.Drawing.Point(6, 6)
        Me.flpInvoices.Name = "flpInvoices"
        Me.flpInvoices.Size = New System.Drawing.Size(886, 361)
        Me.flpInvoices.TabIndex = 0
        '
        'tpReports
        '
        Me.tpReports.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpReports.Controls.Add(Me.Label11)
        Me.tpReports.Controls.Add(Me.chartTotalStatus)
        Me.tpReports.Controls.Add(Me.flpRevenueReports)
        Me.tpReports.Location = New System.Drawing.Point(4, 23)
        Me.tpReports.Name = "tpReports"
        Me.tpReports.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpReports.Size = New System.Drawing.Size(892, 378)
        Me.tpReports.TabIndex = 7
        Me.tpReports.Text = "Reports"
        Me.tpReports.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cinzel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(100, 6)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 19)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Status"
        '
        'chartTotalStatus
        '
        Me.chartTotalStatus.BackColor = System.Drawing.Color.Transparent
        Me.chartTotalStatus.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chartTotalStatus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTotalStatus.Legends.Add(Legend1)
        Me.chartTotalStatus.Location = New System.Drawing.Point(6, 24)
        Me.chartTotalStatus.Name = "chartTotalStatus"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTotalStatus.Series.Add(Series1)
        Me.chartTotalStatus.Size = New System.Drawing.Size(313, 275)
        Me.chartTotalStatus.TabIndex = 40
        Me.chartTotalStatus.Text = "Chart1"
        '
        'flpRevenueReports
        '
        Me.flpRevenueReports.Location = New System.Drawing.Point(325, 6)
        Me.flpRevenueReports.Name = "flpRevenueReports"
        Me.flpRevenueReports.Size = New System.Drawing.Size(568, 353)
        Me.flpRevenueReports.TabIndex = 0
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEventPlaceMgmt.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpEventPlaceMgmt.Controls.Add(Me.flpEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(4, 23)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(892, 378)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Places"
        '
        'flpEventPlaces
        '
        Me.flpEventPlaces.AutoScroll = True
        Me.flpEventPlaces.BackColor = System.Drawing.Color.Transparent
        Me.flpEventPlaces.Location = New System.Drawing.Point(11, 5)
        Me.flpEventPlaces.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flpEventPlaces.Name = "flpEventPlaces"
        Me.flpEventPlaces.Size = New System.Drawing.Size(316, 224)
        Me.flpEventPlaces.TabIndex = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.GroupBox1.Controls.Add(Me.txtPlaceID)
        Me.GroupBox1.Controls.Add(Me.lblPlaceID)
        Me.GroupBox1.Controls.Add(Me.lblErrorCapacity)
        Me.GroupBox1.Controls.Add(Me.lblErrorOpeningHours)
        Me.GroupBox1.Controls.Add(Me.lblErrorPrice)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtAvailableDays)
        Me.GroupBox1.Controls.Add(Me.lblAvailableDays)
        Me.GroupBox1.Controls.Add(Me.txtClosingHours)
        Me.GroupBox1.Controls.Add(Me.lblClosingHours)
        Me.GroupBox1.Controls.Add(Me.txtOpeningHours)
        Me.GroupBox1.Controls.Add(Me.lblOpeningHours)
        Me.GroupBox1.Controls.Add(Me.txtImageUrl)
        Me.GroupBox1.Controls.Add(Me.lblImageUrl)
        Me.GroupBox1.Controls.Add(Me.lblFeatures)
        Me.GroupBox1.Controls.Add(Me.txtFeatures)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.txtEventType)
        Me.GroupBox1.Controls.Add(Me.lblEventType)
        Me.GroupBox1.Controls.Add(Me.txtEventPlace)
        Me.GroupBox1.Controls.Add(Me.lblEventPlace)
        Me.GroupBox1.Controls.Add(Me.lblPricePerDay)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.txtPricePerDay)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(333, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 370)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'txtPlaceID
        '
        Me.txtPlaceID.BackColor = System.Drawing.Color.White
        Me.txtPlaceID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceID.ForeColor = System.Drawing.Color.Black
        Me.txtPlaceID.Location = New System.Drawing.Point(103, 20)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.Size = New System.Drawing.Size(305, 17)
        Me.txtPlaceID.TabIndex = 34
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaceID.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlaceID.Location = New System.Drawing.Point(6, 20)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(57, 15)
        Me.lblPlaceID.TabIndex = 33
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblErrorCapacity
        '
        Me.lblErrorCapacity.AutoSize = True
        Me.lblErrorCapacity.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorCapacity.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorCapacity.Location = New System.Drawing.Point(192, 98)
        Me.lblErrorCapacity.Name = "lblErrorCapacity"
        Me.lblErrorCapacity.Size = New System.Drawing.Size(15, 19)
        Me.lblErrorCapacity.TabIndex = 31
        Me.lblErrorCapacity.Text = "-"
        '
        'lblErrorOpeningHours
        '
        Me.lblErrorOpeningHours.AutoSize = True
        Me.lblErrorOpeningHours.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorOpeningHours.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorOpeningHours.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorOpeningHours.Location = New System.Drawing.Point(414, 207)
        Me.lblErrorOpeningHours.Name = "lblErrorOpeningHours"
        Me.lblErrorOpeningHours.Size = New System.Drawing.Size(15, 19)
        Me.lblErrorOpeningHours.TabIndex = 30
        Me.lblErrorOpeningHours.Text = "-"
        '
        'lblErrorPrice
        '
        Me.lblErrorPrice.AutoSize = True
        Me.lblErrorPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorPrice.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorPrice.Location = New System.Drawing.Point(192, 121)
        Me.lblErrorPrice.Name = "lblErrorPrice"
        Me.lblErrorPrice.Size = New System.Drawing.Size(15, 19)
        Me.lblErrorPrice.TabIndex = 32
        Me.lblErrorPrice.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.epm1.My.Resources.Resources.BttnAdd
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(212, 329)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 22)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = Global.epm1.My.Resources.Resources.BttnDelete
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(346, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 22)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = Global.epm1.My.Resources.Resources.BttnUpdate
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(279, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(62, 22)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.BackColor = System.Drawing.Color.White
        Me.txtAvailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableDays.Location = New System.Drawing.Point(103, 207)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.Size = New System.Drawing.Size(305, 17)
        Me.txtAvailableDays.TabIndex = 27
        '
        'lblAvailableDays
        '
        Me.lblAvailableDays.AutoSize = True
        Me.lblAvailableDays.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableDays.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAvailableDays.Location = New System.Drawing.Point(6, 207)
        Me.lblAvailableDays.Name = "lblAvailableDays"
        Me.lblAvailableDays.Size = New System.Drawing.Size(94, 15)
        Me.lblAvailableDays.TabIndex = 26
        Me.lblAvailableDays.Text = "Available Days"
        '
        'txtClosingHours
        '
        Me.txtClosingHours.BackColor = System.Drawing.Color.White
        Me.txtClosingHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingHours.ForeColor = System.Drawing.Color.Black
        Me.txtClosingHours.Location = New System.Drawing.Point(325, 185)
        Me.txtClosingHours.Name = "txtClosingHours"
        Me.txtClosingHours.Size = New System.Drawing.Size(83, 17)
        Me.txtClosingHours.TabIndex = 25
        '
        'lblClosingHours
        '
        Me.lblClosingHours.AutoSize = True
        Me.lblClosingHours.BackColor = System.Drawing.Color.Transparent
        Me.lblClosingHours.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosingHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClosingHours.Location = New System.Drawing.Point(234, 185)
        Me.lblClosingHours.Name = "lblClosingHours"
        Me.lblClosingHours.Size = New System.Drawing.Size(100, 15)
        Me.lblClosingHours.TabIndex = 24
        Me.lblClosingHours.Text = "Closing Hours"
        '
        'txtOpeningHours
        '
        Me.txtOpeningHours.BackColor = System.Drawing.Color.White
        Me.txtOpeningHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.txtOpeningHours.Location = New System.Drawing.Point(103, 185)
        Me.txtOpeningHours.Name = "txtOpeningHours"
        Me.txtOpeningHours.Size = New System.Drawing.Size(83, 17)
        Me.txtOpeningHours.TabIndex = 23
        '
        'lblOpeningHours
        '
        Me.lblOpeningHours.AutoSize = True
        Me.lblOpeningHours.BackColor = System.Drawing.Color.Transparent
        Me.lblOpeningHours.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOpeningHours.Location = New System.Drawing.Point(6, 188)
        Me.lblOpeningHours.Name = "lblOpeningHours"
        Me.lblOpeningHours.Size = New System.Drawing.Size(101, 15)
        Me.lblOpeningHours.TabIndex = 22
        Me.lblOpeningHours.Text = "Opening Hours"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.White
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImageUrl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageUrl.ForeColor = System.Drawing.Color.Black
        Me.txtImageUrl.Location = New System.Drawing.Point(103, 162)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(305, 17)
        Me.txtImageUrl.TabIndex = 21
        '
        'lblImageUrl
        '
        Me.lblImageUrl.AutoSize = True
        Me.lblImageUrl.BackColor = System.Drawing.Color.Transparent
        Me.lblImageUrl.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageUrl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblImageUrl.Location = New System.Drawing.Point(6, 164)
        Me.lblImageUrl.Name = "lblImageUrl"
        Me.lblImageUrl.Size = New System.Drawing.Size(41, 15)
        Me.lblImageUrl.TabIndex = 20
        Me.lblImageUrl.Text = "Image"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.BackColor = System.Drawing.Color.Transparent
        Me.lblFeatures.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeatures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFeatures.Location = New System.Drawing.Point(6, 140)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(60, 15)
        Me.lblFeatures.TabIndex = 19
        Me.lblFeatures.Text = "Features"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.Color.White
        Me.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeatures.ForeColor = System.Drawing.Color.Black
        Me.txtFeatures.Location = New System.Drawing.Point(103, 139)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(305, 17)
        Me.txtFeatures.TabIndex = 18
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(103, 230)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(305, 93)
        Me.txtDescription.TabIndex = 17
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(6, 226)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(82, 15)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtEventType
        '
        Me.txtEventType.BackColor = System.Drawing.Color.White
        Me.txtEventType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventType.ForeColor = System.Drawing.Color.Black
        Me.txtEventType.Location = New System.Drawing.Point(103, 68)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(305, 17)
        Me.txtEventType.TabIndex = 13
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.BackColor = System.Drawing.Color.Transparent
        Me.lblEventType.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventType.Location = New System.Drawing.Point(6, 68)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(90, 15)
        Me.lblEventType.TabIndex = 13
        Me.lblEventType.Text = "Type of Event"
        '
        'txtEventPlace
        '
        Me.txtEventPlace.BackColor = System.Drawing.Color.White
        Me.txtEventPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventPlace.ForeColor = System.Drawing.Color.Black
        Me.txtEventPlace.Location = New System.Drawing.Point(103, 43)
        Me.txtEventPlace.Name = "txtEventPlace"
        Me.txtEventPlace.Size = New System.Drawing.Size(305, 17)
        Me.txtEventPlace.TabIndex = 12
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblEventPlace.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlace.Location = New System.Drawing.Point(6, 44)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(80, 15)
        Me.lblEventPlace.TabIndex = 12
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.BackColor = System.Drawing.Color.Transparent
        Me.lblPricePerDay.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPricePerDay.Location = New System.Drawing.Point(6, 116)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(86, 15)
        Me.lblPricePerDay.TabIndex = 5
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.BackColor = System.Drawing.Color.Transparent
        Me.lblCapacity.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCapacity.Location = New System.Drawing.Point(6, 92)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(61, 15)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity"
        '
        'txtPricePerDay
        '
        Me.txtPricePerDay.BackColor = System.Drawing.Color.White
        Me.txtPricePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPricePerDay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerDay.ForeColor = System.Drawing.Color.Black
        Me.txtPricePerDay.Location = New System.Drawing.Point(103, 116)
        Me.txtPricePerDay.Name = "txtPricePerDay"
        Me.txtPricePerDay.Size = New System.Drawing.Size(83, 17)
        Me.txtPricePerDay.TabIndex = 2
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.Color.White
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.ForeColor = System.Drawing.Color.Black
        Me.txtCapacity.Location = New System.Drawing.Point(103, 92)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(83, 17)
        Me.txtCapacity.TabIndex = 1
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpCustomerRecords.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpCustomerRecords.Controls.Add(Me.Label4)
        Me.tpCustomerRecords.Controls.Add(Me.lblNumCustomersContainer)
        Me.tpCustomerRecords.Controls.Add(Me.flpCustomerRecords)
        Me.tpCustomerRecords.Location = New System.Drawing.Point(4, 23)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(892, 378)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(781, 300)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Customers"
        '
        'lblNumCustomersContainer
        '
        Me.lblNumCustomersContainer.AutoSize = True
        Me.lblNumCustomersContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblNumCustomersContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCustomersContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(780, 320)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(16, 19)
        Me.lblNumCustomersContainer.TabIndex = 33
        Me.lblNumCustomersContainer.Text = "0"
        '
        'flpCustomerRecords
        '
        Me.flpCustomerRecords.BackColor = System.Drawing.Color.Transparent
        Me.flpCustomerRecords.Location = New System.Drawing.Point(7, 6)
        Me.flpCustomerRecords.Name = "flpCustomerRecords"
        Me.flpCustomerRecords.Size = New System.Drawing.Size(887, 291)
        Me.flpCustomerRecords.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "btnFilter.png")
        Me.ImageList1.Images.SetKeyName(1, "btnSearch.png")
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGadmin_updated_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnCustomerView)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tcAdminCenter)
        Me.Name = "FormAdminCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdminCenter"
        Me.tcAdminCenter.ResumeLayout(False)
        Me.tpBookings.ResumeLayout(False)
        Me.tpBookings.PerformLayout()
        Me.tpInvoicesAndPayments.ResumeLayout(False)
        Me.tpReports.ResumeLayout(False)
        Me.tpReports.PerformLayout()
        CType(Me.chartTotalStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEventPlaceMgmt.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpCustomerRecords.ResumeLayout(False)
        Me.tpCustomerRecords.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnCustomerView As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents tcAdminCenter As TabControl
    Friend WithEvents tpEventPlaceMgmt As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAvailableDays As TextBox
    Friend WithEvents lblAvailableDays As Label
    Friend WithEvents txtClosingHours As TextBox
    Friend WithEvents lblClosingHours As Label
    Friend WithEvents txtOpeningHours As TextBox
    Friend WithEvents lblOpeningHours As Label
    Friend WithEvents txtImageUrl As TextBox
    Friend WithEvents lblImageUrl As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents txtFeatures As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtEventType As TextBox
    Friend WithEvents lblEventType As Label
    Friend WithEvents txtEventPlace As TextBox
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents lblPricePerDay As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents txtPricePerDay As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tpCustomerRecords As TabPage
    Friend WithEvents btnAdd As Button
    Friend WithEvents tpInvoicesAndPayments As TabPage
    Friend WithEvents lblErrorOpeningHours As Label
    Friend WithEvents lblErrorPrice As Label
    Friend WithEvents lblErrorCapacity As Label
    Friend WithEvents flpEventPlaces As FlowLayoutPanel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tpBookings As TabPage
    Friend WithEvents flpPendingBookings As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNumCustomersContainer As Label
    Friend WithEvents flpCustomerRecords As FlowLayoutPanel
    Friend WithEvents flpInvoices As FlowLayoutPanel
    Friend WithEvents tpReports As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents chartTotalStatus As DataVisualization.Charting.Chart
    Friend WithEvents flpRevenueReports As FlowLayoutPanel
    Friend WithEvents lblPendingBookings As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents flpAvailability As FlowLayoutPanel
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents lblBookedDates As Label
    Friend WithEvents flpBookedDates As FlowLayoutPanel
End Class
