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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogout1 = New System.Windows.Forms.Button()
        Me.btnCustomerView = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tcAdminCenter = New System.Windows.Forms.TabControl()
        Me.tpSearchReports = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalBookingsContainer = New System.Windows.Forms.Label()
        Me.lblNumCustomersContainer = New System.Windows.Forms.Label()
        Me.dgvReportBookings = New System.Windows.Forms.DataGridView()
        Me.dgvAvailability = New System.Windows.Forms.DataGridView()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.tpEventPlaceMgmt = New System.Windows.Forms.TabPage()
        Me.dgvEventPlaces = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPlaceID = New System.Windows.Forms.TextBox()
        Me.lblPlaceID = New System.Windows.Forms.Label()
        Me.txtAvailableDays = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClosingHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOpeningHours = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtEventType = New System.Windows.Forms.TextBox()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.txtEventPlace = New System.Windows.Forms.TextBox()
        Me.lblVenueType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtPricePerDay = New System.Windows.Forms.TextBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tpCustomerRecords = New System.Windows.Forms.TabPage()
        Me.dgvCustomerRecords = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tcAdminCenter.SuspendLayout()
        Me.tpSearchReports.SuspendLayout()
        CType(Me.dgvReportBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventPlaceMgmt.SuspendLayout()
        CType(Me.dgvEventPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tpCustomerRecords.SuspendLayout()
        CType(Me.dgvCustomerRecords, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnLogout1
        '
        Me.btnLogout1.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLogout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout1.FlatAppearance.BorderSize = 0
        Me.btnLogout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout1.ForeColor = System.Drawing.Color.Black
        Me.btnLogout1.Location = New System.Drawing.Point(835, 43)
        Me.btnLogout1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout1.Name = "btnLogout1"
        Me.btnLogout1.Size = New System.Drawing.Size(98, 28)
        Me.btnLogout1.TabIndex = 93
        Me.btnLogout1.Text = "Log Out"
        Me.btnLogout1.UseVisualStyleBackColor = False
        '
        'btnCustomerView
        '
        Me.btnCustomerView.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCustomerView.FlatAppearance.BorderSize = 0
        Me.btnCustomerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerView.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerView.ForeColor = System.Drawing.Color.Black
        Me.btnCustomerView.Location = New System.Drawing.Point(835, 11)
        Me.btnCustomerView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomerView.Name = "btnCustomerView"
        Me.btnCustomerView.Size = New System.Drawing.Size(98, 28)
        Me.btnCustomerView.TabIndex = 92
        Me.btnCustomerView.Text = "My Account"
        Me.btnCustomerView.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(697, 32)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(44, 19)
        Me.lblRole.TabIndex = 91
        Me.lblRole.Text = "Admin"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(697, 13)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 19)
        Me.lblUsername.TabIndex = 90
        Me.lblUsername.Text = "Admin Name"
        '
        'tcAdminCenter
        '
        Me.tcAdminCenter.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcAdminCenter.Controls.Add(Me.tpSearchReports)
        Me.tcAdminCenter.Controls.Add(Me.tpEventPlaceMgmt)
        Me.tcAdminCenter.Controls.Add(Me.tpCustomerRecords)
        Me.tcAdminCenter.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAdminCenter.Location = New System.Drawing.Point(30, 76)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(840, 420)
        Me.tcAdminCenter.TabIndex = 94
        '
        'tpSearchReports
        '
        Me.tpSearchReports.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpSearchReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpSearchReports.Controls.Add(Me.Label7)
        Me.tpSearchReports.Controls.Add(Me.Label4)
        Me.tpSearchReports.Controls.Add(Me.lblTotalBookingsContainer)
        Me.tpSearchReports.Controls.Add(Me.lblNumCustomersContainer)
        Me.tpSearchReports.Controls.Add(Me.dgvReportBookings)
        Me.tpSearchReports.Controls.Add(Me.dgvAvailability)
        Me.tpSearchReports.Controls.Add(Me.btnReject)
        Me.tpSearchReports.Controls.Add(Me.btnApprove)
        Me.tpSearchReports.Controls.Add(Me.dgvBookings)
        Me.tpSearchReports.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpSearchReports.Location = New System.Drawing.Point(30, 4)
        Me.tpSearchReports.Name = "tpSearchReports"
        Me.tpSearchReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearchReports.Size = New System.Drawing.Size(806, 412)
        Me.tpSearchReports.TabIndex = 2
        Me.tpSearchReports.Text = "Dashboard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(38, 84)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total Approved Bookings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total Customers"
        '
        'lblTotalBookingsContainer
        '
        Me.lblTotalBookingsContainer.AutoSize = True
        Me.lblTotalBookingsContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBookingsContainer.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBookingsContainer.Location = New System.Drawing.Point(228, 84)
        Me.lblTotalBookingsContainer.Name = "lblTotalBookingsContainer"
        Me.lblTotalBookingsContainer.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalBookingsContainer.TabIndex = 1
        Me.lblTotalBookingsContainer.Text = "0"
        '
        'lblNumCustomersContainer
        '
        Me.lblNumCustomersContainer.AutoSize = True
        Me.lblNumCustomersContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCustomersContainer.ForeColor = System.Drawing.Color.Black
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(228, 23)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(16, 19)
        Me.lblNumCustomersContainer.TabIndex = 1
        Me.lblNumCustomersContainer.Text = "0"
        '
        'dgvReportBookings
        '
        Me.dgvReportBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportBookings.Location = New System.Drawing.Point(250, 23)
        Me.dgvReportBookings.Name = "dgvReportBookings"
        Me.dgvReportBookings.RowHeadersWidth = 51
        Me.dgvReportBookings.Size = New System.Drawing.Size(225, 143)
        Me.dgvReportBookings.TabIndex = 31
        '
        'dgvAvailability
        '
        Me.dgvAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailability.Location = New System.Drawing.Point(481, 23)
        Me.dgvAvailability.Name = "dgvAvailability"
        Me.dgvAvailability.RowHeadersWidth = 51
        Me.dgvAvailability.Size = New System.Drawing.Size(288, 366)
        Me.dgvAvailability.TabIndex = 29
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReject.FlatAppearance.BorderSize = 0
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.Black
        Me.btnReject.Location = New System.Drawing.Point(143, 129)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(101, 37)
        Me.btnReject.TabIndex = 27
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Gainsboro
        Me.btnApprove.FlatAppearance.BorderSize = 0
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.Black
        Me.btnApprove.Location = New System.Drawing.Point(43, 129)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(94, 37)
        Me.btnApprove.TabIndex = 26
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'dgvBookings
        '
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(43, 173)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.RowHeadersWidth = 51
        Me.dgvBookings.Size = New System.Drawing.Size(432, 216)
        Me.dgvBookings.TabIndex = 22
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEventPlaceMgmt.Controls.Add(Me.btnAdd)
        Me.tpEventPlaceMgmt.Controls.Add(Me.dgvEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Controls.Add(Me.btnUpdate)
        Me.tpEventPlaceMgmt.Controls.Add(Me.btnDelete)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(30, 4)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(806, 412)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Place Management"
        '
        'dgvEventPlaces
        '
        Me.dgvEventPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEventPlaces.Location = New System.Drawing.Point(16, 6)
        Me.dgvEventPlaces.Name = "dgvEventPlaces"
        Me.dgvEventPlaces.RowHeadersWidth = 51
        Me.dgvEventPlaces.Size = New System.Drawing.Size(314, 364)
        Me.dgvEventPlaces.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPlaceID)
        Me.GroupBox1.Controls.Add(Me.lblPlaceID)
        Me.GroupBox1.Controls.Add(Me.txtAvailableDays)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtClosingHours)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOpeningHours)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtImageUrl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblFeatures)
        Me.GroupBox1.Controls.Add(Me.txtFeatures)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.txtEventType)
        Me.GroupBox1.Controls.Add(Me.lblEventType)
        Me.GroupBox1.Controls.Add(Me.txtEventPlace)
        Me.GroupBox1.Controls.Add(Me.lblVenueType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.txtPricePerDay)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(336, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 364)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Place"
        '
        'txtPlaceID
        '
        Me.txtPlaceID.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPlaceID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceID.ForeColor = System.Drawing.Color.Black
        Me.txtPlaceID.Location = New System.Drawing.Point(141, 23)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.Size = New System.Drawing.Size(83, 17)
        Me.txtPlaceID.TabIndex = 29
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.Black
        Me.lblPlaceID.Location = New System.Drawing.Point(17, 21)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(50, 19)
        Me.lblPlaceID.TabIndex = 28
        Me.lblPlaceID.Text = "PlaceID"
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtAvailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableDays.Location = New System.Drawing.Point(141, 195)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.Size = New System.Drawing.Size(305, 17)
        Me.txtAvailableDays.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "lblAvailableDays"
        '
        'txtClosingHours
        '
        Me.txtClosingHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtClosingHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingHours.ForeColor = System.Drawing.Color.Black
        Me.txtClosingHours.Location = New System.Drawing.Point(363, 169)
        Me.txtClosingHours.Name = "txtClosingHours"
        Me.txtClosingHours.Size = New System.Drawing.Size(83, 17)
        Me.txtClosingHours.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(256, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Closing Hours"
        '
        'txtOpeningHours
        '
        Me.txtOpeningHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtOpeningHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.txtOpeningHours.Location = New System.Drawing.Point(141, 171)
        Me.txtOpeningHours.Name = "txtOpeningHours"
        Me.txtOpeningHours.Size = New System.Drawing.Size(83, 17)
        Me.txtOpeningHours.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Opening Hours"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImageUrl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageUrl.ForeColor = System.Drawing.Color.Black
        Me.txtImageUrl.Location = New System.Drawing.Point(141, 146)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(305, 17)
        Me.txtImageUrl.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Image"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeatures.ForeColor = System.Drawing.Color.Black
        Me.lblFeatures.Location = New System.Drawing.Point(17, 123)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(57, 19)
        Me.lblFeatures.TabIndex = 19
        Me.lblFeatures.Text = "Features"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeatures.ForeColor = System.Drawing.Color.Black
        Me.txtFeatures.Location = New System.Drawing.Point(141, 123)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(305, 17)
        Me.txtFeatures.TabIndex = 18
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(141, 218)
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
        Me.lblDescription.Location = New System.Drawing.Point(16, 218)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(72, 19)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtEventType
        '
        Me.txtEventType.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEventType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventType.ForeColor = System.Drawing.Color.Black
        Me.txtEventType.Location = New System.Drawing.Point(141, 75)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(305, 17)
        Me.txtEventType.TabIndex = 13
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.ForeColor = System.Drawing.Color.Black
        Me.lblEventType.Location = New System.Drawing.Point(17, 73)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(82, 19)
        Me.lblEventType.TabIndex = 13
        Me.lblEventType.Text = "Type of Event"
        '
        'txtEventPlace
        '
        Me.txtEventPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtEventPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventPlace.ForeColor = System.Drawing.Color.Black
        Me.txtEventPlace.Location = New System.Drawing.Point(141, 46)
        Me.txtEventPlace.Name = "txtEventPlace"
        Me.txtEventPlace.Size = New System.Drawing.Size(305, 17)
        Me.txtEventPlace.TabIndex = 12
        '
        'lblVenueType
        '
        Me.lblVenueType.AutoSize = True
        Me.lblVenueType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenueType.ForeColor = System.Drawing.Color.Black
        Me.lblVenueType.Location = New System.Drawing.Point(17, 46)
        Me.lblVenueType.Name = "lblVenueType"
        Me.lblVenueType.Size = New System.Drawing.Size(72, 19)
        Me.lblVenueType.TabIndex = 12
        Me.lblVenueType.Text = "Event Place"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(316, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.Black
        Me.lblCapacity.Location = New System.Drawing.Point(17, 98)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(58, 19)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity"
        '
        'txtPricePerDay
        '
        Me.txtPricePerDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPricePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPricePerDay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerDay.ForeColor = System.Drawing.Color.Black
        Me.txtPricePerDay.Location = New System.Drawing.Point(363, 98)
        Me.txtPricePerDay.Name = "txtPricePerDay"
        Me.txtPricePerDay.Size = New System.Drawing.Size(83, 17)
        Me.txtPricePerDay.TabIndex = 2
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.ForeColor = System.Drawing.Color.Black
        Me.txtCapacity.Location = New System.Drawing.Point(141, 100)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(83, 17)
        Me.txtCapacity.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(548, 376)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 30)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(672, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpCustomerRecords.Controls.Add(Me.dgvCustomerRecords)
        Me.tpCustomerRecords.Location = New System.Drawing.Point(30, 4)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(806, 412)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        '
        'dgvCustomerRecords
        '
        Me.dgvCustomerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerRecords.Location = New System.Drawing.Point(16, 17)
        Me.dgvCustomerRecords.Name = "dgvCustomerRecords"
        Me.dgvCustomerRecords.RowHeadersWidth = 51
        Me.dgvCustomerRecords.Size = New System.Drawing.Size(774, 365)
        Me.dgvCustomerRecords.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(424, 376)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.tcAdminCenter)
        Me.Controls.Add(Me.btnLogout1)
        Me.Controls.Add(Me.btnCustomerView)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "FormAdminCenter"
        Me.Text = "FormAdminCenter"
        Me.tcAdminCenter.ResumeLayout(False)
        Me.tpSearchReports.ResumeLayout(False)
        Me.tpSearchReports.PerformLayout()
        CType(Me.dgvReportBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEventPlaceMgmt.ResumeLayout(False)
        CType(Me.dgvEventPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpCustomerRecords.ResumeLayout(False)
        CType(Me.dgvCustomerRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogout1 As Button
    Friend WithEvents btnCustomerView As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents tcAdminCenter As TabControl
    Friend WithEvents tpSearchReports As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalBookingsContainer As Label
    Friend WithEvents lblNumCustomersContainer As Label
    Friend WithEvents dgvReportBookings As DataGridView
    Friend WithEvents dgvAvailability As DataGridView
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents tpEventPlaceMgmt As TabPage
    Friend WithEvents dgvEventPlaces As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents txtAvailableDays As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClosingHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOpeningHours As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtImageUrl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents txtFeatures As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtEventType As TextBox
    Friend WithEvents lblEventType As Label
    Friend WithEvents txtEventPlace As TextBox
    Friend WithEvents lblVenueType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents txtPricePerDay As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tpCustomerRecords As TabPage
    Friend WithEvents dgvCustomerRecords As DataGridView
    Friend WithEvents btnAdd As Button
End Class
