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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
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
        Me.btnNext.Location = New System.Drawing.Point(60, 13)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(42, 23)
        Me.btnNext.TabIndex = 89
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 88
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(817, 43)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(116, 28)
        Me.btnLogOut.TabIndex = 93
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(817, 11)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(116, 28)
        Me.btnEdit.TabIndex = 92
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(697, 32)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(56, 25)
        Me.lblRole.TabIndex = 91
        Me.lblRole.Text = "Admin"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(666, 14)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
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
        Me.tcAdminCenter.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAdminCenter.Location = New System.Drawing.Point(12, 44)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(921, 452)
        Me.tcAdminCenter.TabIndex = 94
        '
        'tpBookings
        '
        Me.tpBookings.Controls.Add(Me.lblBookedDates)
        Me.tpBookings.Controls.Add(Me.flpBookedDates)
        Me.tpBookings.Controls.Add(Me.lblPendingBookings)
        Me.tpBookings.Controls.Add(Me.lblAvailability)
        Me.tpBookings.Controls.Add(Me.flpAvailability)
        Me.tpBookings.Controls.Add(Me.flpPendingBookings)
        Me.tpBookings.Location = New System.Drawing.Point(4, 34)
        Me.tpBookings.Name = "tpBookings"
        Me.tpBookings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookings.Size = New System.Drawing.Size(913, 414)
        Me.tpBookings.TabIndex = 6
        Me.tpBookings.Text = "Bookings"
        Me.tpBookings.UseVisualStyleBackColor = True
        '
        'lblBookedDates
        '
        Me.lblBookedDates.AutoSize = True
        Me.lblBookedDates.Location = New System.Drawing.Point(6, 10)
        Me.lblBookedDates.Name = "lblBookedDates"
        Me.lblBookedDates.Size = New System.Drawing.Size(108, 25)
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
        Me.lblPendingBookings.Location = New System.Drawing.Point(553, 10)
        Me.lblPendingBookings.Name = "lblPendingBookings"
        Me.lblPendingBookings.Size = New System.Drawing.Size(134, 25)
        Me.lblPendingBookings.TabIndex = 3
        Me.lblPendingBookings.Text = "Pending Bookings"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(3, 180)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(84, 25)
        Me.lblAvailability.TabIndex = 2
        Me.lblAvailability.Text = "Availability"
        '
        'flpAvailability
        '
        Me.flpAvailability.Location = New System.Drawing.Point(6, 202)
        Me.flpAvailability.Name = "flpAvailability"
        Me.flpAvailability.Size = New System.Drawing.Size(302, 212)
        Me.flpAvailability.TabIndex = 1
        '
        'flpPendingBookings
        '
        Me.flpPendingBookings.Location = New System.Drawing.Point(557, 32)
        Me.flpPendingBookings.Name = "flpPendingBookings"
        Me.flpPendingBookings.Size = New System.Drawing.Size(350, 385)
        Me.flpPendingBookings.TabIndex = 0
        '
        'tpInvoicesAndPayments
        '
        Me.tpInvoicesAndPayments.Controls.Add(Me.flpInvoices)
        Me.tpInvoicesAndPayments.Location = New System.Drawing.Point(4, 34)
        Me.tpInvoicesAndPayments.Name = "tpInvoicesAndPayments"
        Me.tpInvoicesAndPayments.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInvoicesAndPayments.Size = New System.Drawing.Size(913, 414)
        Me.tpInvoicesAndPayments.TabIndex = 5
        Me.tpInvoicesAndPayments.Text = "Invoices and Payments"
        Me.tpInvoicesAndPayments.UseVisualStyleBackColor = True
        '
        'flpInvoices
        '
        Me.flpInvoices.Location = New System.Drawing.Point(7, 35)
        Me.flpInvoices.Name = "flpInvoices"
        Me.flpInvoices.Size = New System.Drawing.Size(900, 379)
        Me.flpInvoices.TabIndex = 0
        '
        'tpReports
        '
        Me.tpReports.Controls.Add(Me.Label11)
        Me.tpReports.Controls.Add(Me.chartTotalStatus)
        Me.tpReports.Controls.Add(Me.flpRevenueReports)
        Me.tpReports.Location = New System.Drawing.Point(4, 34)
        Me.tpReports.Name = "tpReports"
        Me.tpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReports.Size = New System.Drawing.Size(913, 414)
        Me.tpReports.TabIndex = 7
        Me.tpReports.Text = "Reports"
        Me.tpReports.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(5, 5)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 25)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Status"
        '
        'chartTotalStatus
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTotalStatus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTotalStatus.Legends.Add(Legend1)
        Me.chartTotalStatus.Location = New System.Drawing.Point(6, 27)
        Me.chartTotalStatus.Name = "chartTotalStatus"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTotalStatus.Series.Add(Series1)
        Me.chartTotalStatus.Size = New System.Drawing.Size(300, 387)
        Me.chartTotalStatus.TabIndex = 40
        Me.chartTotalStatus.Text = "Chart1"
        '
        'flpRevenueReports
        '
        Me.flpRevenueReports.Location = New System.Drawing.Point(312, 6)
        Me.flpRevenueReports.Name = "flpRevenueReports"
        Me.flpRevenueReports.Size = New System.Drawing.Size(594, 408)
        Me.flpRevenueReports.TabIndex = 0
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEventPlaceMgmt.Controls.Add(Me.flpEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(4, 34)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(913, 414)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Places"
        '
        'flpEventPlaces
        '
        Me.flpEventPlaces.AutoScroll = True
        Me.flpEventPlaces.BackColor = System.Drawing.Color.Transparent
        Me.flpEventPlaces.Location = New System.Drawing.Point(11, 5)
        Me.flpEventPlaces.Margin = New System.Windows.Forms.Padding(2)
        Me.flpEventPlaces.Name = "flpEventPlaces"
        Me.flpEventPlaces.Size = New System.Drawing.Size(445, 410)
        Me.flpEventPlaces.TabIndex = 95
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(461, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 410)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'txtPlaceID
        '
        Me.txtPlaceID.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPlaceID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceID.ForeColor = System.Drawing.Color.Black
        Me.txtPlaceID.Location = New System.Drawing.Point(103, 20)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.Size = New System.Drawing.Size(305, 21)
        Me.txtPlaceID.TabIndex = 34
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.Black
        Me.lblPlaceID.Location = New System.Drawing.Point(6, 20)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(67, 25)
        Me.lblPlaceID.TabIndex = 33
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblErrorCapacity
        '
        Me.lblErrorCapacity.AutoSize = True
        Me.lblErrorCapacity.Location = New System.Drawing.Point(192, 98)
        Me.lblErrorCapacity.Name = "lblErrorCapacity"
        Me.lblErrorCapacity.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorCapacity.TabIndex = 31
        Me.lblErrorCapacity.Text = "-"
        '
        'lblErrorOpeningHours
        '
        Me.lblErrorOpeningHours.AutoSize = True
        Me.lblErrorOpeningHours.Location = New System.Drawing.Point(414, 190)
        Me.lblErrorOpeningHours.Name = "lblErrorOpeningHours"
        Me.lblErrorOpeningHours.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorOpeningHours.TabIndex = 30
        Me.lblErrorOpeningHours.Text = "-"
        '
        'lblErrorPrice
        '
        Me.lblErrorPrice.AutoSize = True
        Me.lblErrorPrice.Location = New System.Drawing.Point(192, 121)
        Me.lblErrorPrice.Name = "lblErrorPrice"
        Me.lblErrorPrice.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorPrice.TabIndex = 32
        Me.lblErrorPrice.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(78, 374)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(312, 374)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(195, 374)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 30)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtAvailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableDays.Location = New System.Drawing.Point(103, 207)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.Size = New System.Drawing.Size(305, 21)
        Me.txtAvailableDays.TabIndex = 27
        '
        'lblAvailableDays
        '
        Me.lblAvailableDays.AutoSize = True
        Me.lblAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableDays.Location = New System.Drawing.Point(6, 207)
        Me.lblAvailableDays.Name = "lblAvailableDays"
        Me.lblAvailableDays.Size = New System.Drawing.Size(112, 25)
        Me.lblAvailableDays.TabIndex = 26
        Me.lblAvailableDays.Text = "Available Days"
        '
        'txtClosingHours
        '
        Me.txtClosingHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtClosingHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingHours.ForeColor = System.Drawing.Color.Black
        Me.txtClosingHours.Location = New System.Drawing.Point(325, 185)
        Me.txtClosingHours.Name = "txtClosingHours"
        Me.txtClosingHours.Size = New System.Drawing.Size(83, 21)
        Me.txtClosingHours.TabIndex = 25
        '
        'lblClosingHours
        '
        Me.lblClosingHours.AutoSize = True
        Me.lblClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosingHours.ForeColor = System.Drawing.Color.Black
        Me.lblClosingHours.Location = New System.Drawing.Point(234, 185)
        Me.lblClosingHours.Name = "lblClosingHours"
        Me.lblClosingHours.Size = New System.Drawing.Size(107, 25)
        Me.lblClosingHours.TabIndex = 24
        Me.lblClosingHours.Text = "Closing Hours"
        '
        'txtOpeningHours
        '
        Me.txtOpeningHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtOpeningHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.txtOpeningHours.Location = New System.Drawing.Point(103, 185)
        Me.txtOpeningHours.Name = "txtOpeningHours"
        Me.txtOpeningHours.Size = New System.Drawing.Size(83, 21)
        Me.txtOpeningHours.TabIndex = 23
        '
        'lblOpeningHours
        '
        Me.lblOpeningHours.AutoSize = True
        Me.lblOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.lblOpeningHours.Location = New System.Drawing.Point(6, 188)
        Me.lblOpeningHours.Name = "lblOpeningHours"
        Me.lblOpeningHours.Size = New System.Drawing.Size(115, 25)
        Me.lblOpeningHours.TabIndex = 22
        Me.lblOpeningHours.Text = "Opening Hours"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImageUrl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageUrl.ForeColor = System.Drawing.Color.Black
        Me.txtImageUrl.Location = New System.Drawing.Point(103, 162)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(305, 21)
        Me.txtImageUrl.TabIndex = 21
        '
        'lblImageUrl
        '
        Me.lblImageUrl.AutoSize = True
        Me.lblImageUrl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageUrl.ForeColor = System.Drawing.Color.Black
        Me.lblImageUrl.Location = New System.Drawing.Point(6, 164)
        Me.lblImageUrl.Name = "lblImageUrl"
        Me.lblImageUrl.Size = New System.Drawing.Size(56, 25)
        Me.lblImageUrl.TabIndex = 20
        Me.lblImageUrl.Text = "Image"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeatures.ForeColor = System.Drawing.Color.Black
        Me.lblFeatures.Location = New System.Drawing.Point(6, 140)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(72, 25)
        Me.lblFeatures.TabIndex = 19
        Me.lblFeatures.Text = "Features"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeatures.ForeColor = System.Drawing.Color.Black
        Me.txtFeatures.Location = New System.Drawing.Point(103, 139)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(305, 21)
        Me.txtFeatures.TabIndex = 18
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
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
        Me.lblDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(6, 226)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(90, 25)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtEventType
        '
        Me.txtEventType.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEventType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventType.ForeColor = System.Drawing.Color.Black
        Me.txtEventType.Location = New System.Drawing.Point(103, 68)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(305, 21)
        Me.txtEventType.TabIndex = 13
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.ForeColor = System.Drawing.Color.Black
        Me.lblEventType.Location = New System.Drawing.Point(6, 68)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(106, 25)
        Me.lblEventType.TabIndex = 13
        Me.lblEventType.Text = "Type of Event"
        '
        'txtEventPlace
        '
        Me.txtEventPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEventPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventPlace.ForeColor = System.Drawing.Color.Black
        Me.txtEventPlace.Location = New System.Drawing.Point(103, 43)
        Me.txtEventPlace.Name = "txtEventPlace"
        Me.txtEventPlace.Size = New System.Drawing.Size(305, 21)
        Me.txtEventPlace.TabIndex = 12
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.ForeColor = System.Drawing.Color.Black
        Me.lblEventPlace.Location = New System.Drawing.Point(6, 44)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(92, 25)
        Me.lblEventPlace.TabIndex = 12
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDay.ForeColor = System.Drawing.Color.Black
        Me.lblPricePerDay.Location = New System.Drawing.Point(6, 116)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(104, 25)
        Me.lblPricePerDay.TabIndex = 5
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.Black
        Me.lblCapacity.Location = New System.Drawing.Point(6, 92)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(75, 25)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity"
        '
        'txtPricePerDay
        '
        Me.txtPricePerDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPricePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPricePerDay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerDay.ForeColor = System.Drawing.Color.Black
        Me.txtPricePerDay.Location = New System.Drawing.Point(103, 116)
        Me.txtPricePerDay.Name = "txtPricePerDay"
        Me.txtPricePerDay.Size = New System.Drawing.Size(83, 21)
        Me.txtPricePerDay.TabIndex = 2
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.ForeColor = System.Drawing.Color.Black
        Me.txtCapacity.Location = New System.Drawing.Point(103, 92)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(83, 21)
        Me.txtCapacity.TabIndex = 1
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpCustomerRecords.Controls.Add(Me.Label4)
        Me.tpCustomerRecords.Controls.Add(Me.lblNumCustomersContainer)
        Me.tpCustomerRecords.Controls.Add(Me.flpCustomerRecords)
        Me.tpCustomerRecords.Location = New System.Drawing.Point(4, 34)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(913, 414)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(806, 398)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Customers"
        '
        'lblNumCustomersContainer
        '
        Me.lblNumCustomersContainer.AutoSize = True
        Me.lblNumCustomersContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCustomersContainer.ForeColor = System.Drawing.Color.Black
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(806, 380)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblNumCustomersContainer.TabIndex = 33
        Me.lblNumCustomersContainer.Text = "0"
        '
        'flpCustomerRecords
        '
        Me.flpCustomerRecords.Location = New System.Drawing.Point(7, 6)
        Me.flpCustomerRecords.Name = "flpCustomerRecords"
        Me.flpCustomerRecords.Size = New System.Drawing.Size(900, 371)
        Me.flpCustomerRecords.TabIndex = 0
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnEdit)
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
    Friend WithEvents btnEdit As Button
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
