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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminCenter))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnCustomerView = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tcAdminCenter = New System.Windows.Forms.TabControl()
        Me.tpBookings = New System.Windows.Forms.TabPage()
        Me.tcPendApprRej = New System.Windows.Forms.TabControl()
        Me.tpPendings = New System.Windows.Forms.TabPage()
        Me.flpPending = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpApproved = New System.Windows.Forms.TabPage()
        Me.flpApproved = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpRejected = New System.Windows.Forms.TabPage()
        Me.flpRejected = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpAll = New System.Windows.Forms.TabPage()
        Me.flpAll = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chartTotalStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mcBookings = New System.Windows.Forms.MonthCalendar()
        Me.tpEventPlaceMgmt = New System.Windows.Forms.TabPage()
        Me.tcAvailability = New System.Windows.Forms.TabControl()
        Me.tpAvailable = New System.Windows.Forms.TabPage()
        Me.flpAvailable = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpBooked = New System.Windows.Forms.TabPage()
        Me.flpBooked = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.tpInvoicesAndPayments = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flpRevenueReports = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpInvoices = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpCustomerRecords = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumCustomersContainer = New System.Windows.Forms.Label()
        Me.flpCustomerRecords = New System.Windows.Forms.FlowLayoutPanel()
        Me.tcAdminCenter.SuspendLayout()
        Me.tpBookings.SuspendLayout()
        Me.tcPendApprRej.SuspendLayout()
        Me.tpPendings.SuspendLayout()
        Me.tpApproved.SuspendLayout()
        Me.tpRejected.SuspendLayout()
        Me.tpAll.SuspendLayout()
        CType(Me.chartTotalStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventPlaceMgmt.SuspendLayout()
        Me.tcAvailability.SuspendLayout()
        Me.tpAvailable.SuspendLayout()
        Me.tpBooked.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpInvoicesAndPayments.SuspendLayout()
        Me.tpCustomerRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(257, 39)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 25)
        Me.btnNext.TabIndex = 89
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(225, 39)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 25)
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
        Me.btnLogOut.Location = New System.Drawing.Point(1141, 53)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(88, 23)
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
        Me.btnCustomerView.Location = New System.Drawing.Point(1141, 25)
        Me.btnCustomerView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustomerView.Name = "btnCustomerView"
        Me.btnCustomerView.Size = New System.Drawing.Size(88, 23)
        Me.btnCustomerView.TabIndex = 92
        Me.btnCustomerView.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(995, 53)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(52, 18)
        Me.lblRole.TabIndex = 91
        Me.lblRole.Text = "Admin"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(995, 33)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(93, 18)
        Me.lblUsername.TabIndex = 90
        Me.lblUsername.Text = "Admin Name"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "btnFilter.png")
        Me.ImageList1.Images.SetKeyName(1, "btnSearch.png")
        '
        'tcAdminCenter
        '
        Me.tcAdminCenter.Controls.Add(Me.tpBookings)
        Me.tcAdminCenter.Controls.Add(Me.tpEventPlaceMgmt)
        Me.tcAdminCenter.Controls.Add(Me.tpInvoicesAndPayments)
        Me.tcAdminCenter.Controls.Add(Me.tpCustomerRecords)
        Me.tcAdminCenter.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.tcAdminCenter.Location = New System.Drawing.Point(13, 104)
        Me.tcAdminCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(1233, 500)
        Me.tcAdminCenter.TabIndex = 95
        '
        'tpBookings
        '
        Me.tpBookings.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpBookings.Controls.Add(Me.tcPendApprRej)
        Me.tpBookings.Controls.Add(Me.Label11)
        Me.tpBookings.Controls.Add(Me.chartTotalStatus)
        Me.tpBookings.Controls.Add(Me.mcBookings)
        Me.tpBookings.Location = New System.Drawing.Point(4, 27)
        Me.tpBookings.Margin = New System.Windows.Forms.Padding(4)
        Me.tpBookings.Name = "tpBookings"
        Me.tpBookings.Padding = New System.Windows.Forms.Padding(4)
        Me.tpBookings.Size = New System.Drawing.Size(1225, 469)
        Me.tpBookings.TabIndex = 6
        Me.tpBookings.Text = "Bookings"
        Me.tpBookings.UseVisualStyleBackColor = True
        '
        'tcPendApprRej
        '
        Me.tcPendApprRej.Controls.Add(Me.tpPendings)
        Me.tcPendApprRej.Controls.Add(Me.tpApproved)
        Me.tcPendApprRej.Controls.Add(Me.tpRejected)
        Me.tcPendApprRej.Controls.Add(Me.tpAll)
        Me.tcPendApprRej.Location = New System.Drawing.Point(287, 0)
        Me.tcPendApprRej.Name = "tcPendApprRej"
        Me.tcPendApprRej.SelectedIndex = 0
        Me.tcPendApprRej.Size = New System.Drawing.Size(935, 459)
        Me.tcPendApprRej.TabIndex = 45
        '
        'tpPendings
        '
        Me.tpPendings.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpPendings.Controls.Add(Me.flpPending)
        Me.tpPendings.Location = New System.Drawing.Point(4, 27)
        Me.tpPendings.Name = "tpPendings"
        Me.tpPendings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPendings.Size = New System.Drawing.Size(927, 428)
        Me.tpPendings.TabIndex = 0
        Me.tpPendings.Text = "Pendings"
        Me.tpPendings.UseVisualStyleBackColor = True
        '
        'flpPending
        '
        Me.flpPending.Location = New System.Drawing.Point(7, 7)
        Me.flpPending.Margin = New System.Windows.Forms.Padding(4)
        Me.flpPending.Name = "flpPending"
        Me.flpPending.Size = New System.Drawing.Size(916, 410)
        Me.flpPending.TabIndex = 1
        '
        'tpApproved
        '
        Me.tpApproved.Controls.Add(Me.flpApproved)
        Me.tpApproved.Location = New System.Drawing.Point(4, 27)
        Me.tpApproved.Name = "tpApproved"
        Me.tpApproved.Padding = New System.Windows.Forms.Padding(3)
        Me.tpApproved.Size = New System.Drawing.Size(927, 428)
        Me.tpApproved.TabIndex = 1
        Me.tpApproved.Text = "Approved"
        Me.tpApproved.UseVisualStyleBackColor = True
        '
        'flpApproved
        '
        Me.flpApproved.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpApproved.Location = New System.Drawing.Point(0, 0)
        Me.flpApproved.Margin = New System.Windows.Forms.Padding(4)
        Me.flpApproved.Name = "flpApproved"
        Me.flpApproved.Size = New System.Drawing.Size(926, 420)
        Me.flpApproved.TabIndex = 2
        '
        'tpRejected
        '
        Me.tpRejected.Controls.Add(Me.flpRejected)
        Me.tpRejected.Location = New System.Drawing.Point(4, 27)
        Me.tpRejected.Name = "tpRejected"
        Me.tpRejected.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRejected.Size = New System.Drawing.Size(927, 428)
        Me.tpRejected.TabIndex = 2
        Me.tpRejected.Text = "Rejected"
        Me.tpRejected.UseVisualStyleBackColor = True
        '
        'flpRejected
        '
        Me.flpRejected.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpRejected.Location = New System.Drawing.Point(0, 0)
        Me.flpRejected.Margin = New System.Windows.Forms.Padding(4)
        Me.flpRejected.Name = "flpRejected"
        Me.flpRejected.Size = New System.Drawing.Size(926, 420)
        Me.flpRejected.TabIndex = 2
        '
        'tpAll
        '
        Me.tpAll.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpAll.Controls.Add(Me.flpAll)
        Me.tpAll.Location = New System.Drawing.Point(4, 27)
        Me.tpAll.Name = "tpAll"
        Me.tpAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAll.Size = New System.Drawing.Size(927, 428)
        Me.tpAll.TabIndex = 3
        Me.tpAll.Text = "All"
        Me.tpAll.UseVisualStyleBackColor = True
        '
        'flpAll
        '
        Me.flpAll.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpAll.Location = New System.Drawing.Point(0, 0)
        Me.flpAll.Margin = New System.Windows.Forms.Padding(4)
        Me.flpAll.Name = "flpAll"
        Me.flpAll.Size = New System.Drawing.Size(927, 428)
        Me.flpAll.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 25)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Status"
        '
        'chartTotalStatus
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTotalStatus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTotalStatus.Legends.Add(Legend1)
        Me.chartTotalStatus.Location = New System.Drawing.Point(13, 258)
        Me.chartTotalStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.chartTotalStatus.Name = "chartTotalStatus"
        Me.chartTotalStatus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTotalStatus.Series.Add(Series1)
        Me.chartTotalStatus.Size = New System.Drawing.Size(262, 197)
        Me.chartTotalStatus.TabIndex = 41
        Me.chartTotalStatus.Text = "Chart1"
        '
        'mcBookings
        '
        Me.mcBookings.Location = New System.Drawing.Point(13, 13)
        Me.mcBookings.Name = "mcBookings"
        Me.mcBookings.TabIndex = 5
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEventPlaceMgmt.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpEventPlaceMgmt.Controls.Add(Me.tcAvailability)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(4, 27)
        Me.tpEventPlaceMgmt.Margin = New System.Windows.Forms.Padding(4)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(4)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(1225, 469)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Places"
        '
        'tcAvailability
        '
        Me.tcAvailability.Controls.Add(Me.tpAvailable)
        Me.tcAvailability.Controls.Add(Me.tpBooked)
        Me.tcAvailability.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.tcAvailability.Location = New System.Drawing.Point(7, 16)
        Me.tcAvailability.Name = "tcAvailability"
        Me.tcAvailability.SelectedIndex = 0
        Me.tcAvailability.Size = New System.Drawing.Size(573, 442)
        Me.tcAvailability.TabIndex = 47
        '
        'tpAvailable
        '
        Me.tpAvailable.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpAvailable.Controls.Add(Me.flpAvailable)
        Me.tpAvailable.Location = New System.Drawing.Point(4, 27)
        Me.tpAvailable.Name = "tpAvailable"
        Me.tpAvailable.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAvailable.Size = New System.Drawing.Size(565, 411)
        Me.tpAvailable.TabIndex = 0
        Me.tpAvailable.Text = "Available"
        Me.tpAvailable.UseVisualStyleBackColor = True
        '
        'flpAvailable
        '
        Me.flpAvailable.AutoScroll = True
        Me.flpAvailable.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpAvailable.Location = New System.Drawing.Point(0, 0)
        Me.flpAvailable.Name = "flpAvailable"
        Me.flpAvailable.Size = New System.Drawing.Size(562, 408)
        Me.flpAvailable.TabIndex = 1
        '
        'tpBooked
        '
        Me.tpBooked.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpBooked.Controls.Add(Me.flpBooked)
        Me.tpBooked.Location = New System.Drawing.Point(4, 27)
        Me.tpBooked.Name = "tpBooked"
        Me.tpBooked.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBooked.Size = New System.Drawing.Size(565, 411)
        Me.tpBooked.TabIndex = 1
        Me.tpBooked.Text = "Booked"
        Me.tpBooked.UseVisualStyleBackColor = True
        '
        'flpBooked
        '
        Me.flpBooked.AutoScroll = True
        Me.flpBooked.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpBooked.Location = New System.Drawing.Point(0, 0)
        Me.flpBooked.Name = "flpBooked"
        Me.flpBooked.Size = New System.Drawing.Size(565, 411)
        Me.flpBooked.TabIndex = 0
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
        Me.GroupBox1.Location = New System.Drawing.Point(587, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(634, 450)
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
        Me.txtPlaceID.Location = New System.Drawing.Point(137, 25)
        Me.txtPlaceID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlaceID.Name = "txtPlaceID"
        Me.txtPlaceID.Size = New System.Drawing.Size(407, 21)
        Me.txtPlaceID.TabIndex = 34
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaceID.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlaceID.Location = New System.Drawing.Point(8, 25)
        Me.lblPlaceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(74, 19)
        Me.lblPlaceID.TabIndex = 33
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblErrorCapacity
        '
        Me.lblErrorCapacity.AutoSize = True
        Me.lblErrorCapacity.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorCapacity.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorCapacity.Location = New System.Drawing.Point(256, 111)
        Me.lblErrorCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorCapacity.Name = "lblErrorCapacity"
        Me.lblErrorCapacity.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorCapacity.TabIndex = 31
        Me.lblErrorCapacity.Text = "-"
        '
        'lblErrorOpeningHours
        '
        Me.lblErrorOpeningHours.AutoSize = True
        Me.lblErrorOpeningHours.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorOpeningHours.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorOpeningHours.Location = New System.Drawing.Point(552, 234)
        Me.lblErrorOpeningHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorOpeningHours.Name = "lblErrorOpeningHours"
        Me.lblErrorOpeningHours.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorOpeningHours.TabIndex = 30
        Me.lblErrorOpeningHours.Text = "-"
        '
        'lblErrorPrice
        '
        Me.lblErrorPrice.AutoSize = True
        Me.lblErrorPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorPrice.ForeColor = System.Drawing.Color.Gray
        Me.lblErrorPrice.Location = New System.Drawing.Point(257, 139)
        Me.lblErrorPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorPrice.Name = "lblErrorPrice"
        Me.lblErrorPrice.Size = New System.Drawing.Size(20, 25)
        Me.lblErrorPrice.TabIndex = 32
        Me.lblErrorPrice.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.epm1.My.Resources.Resources.BttnAdd
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(168, 405)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = Global.epm1.My.Resources.Resources.BttnDelete
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(424, 405)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 37)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = Global.epm1.My.Resources.Resources.BttnUpdate
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(296, 405)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 37)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.BackColor = System.Drawing.Color.White
        Me.txtAvailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableDays.Location = New System.Drawing.Point(137, 255)
        Me.txtAvailableDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.Size = New System.Drawing.Size(407, 21)
        Me.txtAvailableDays.TabIndex = 27
        '
        'lblAvailableDays
        '
        Me.lblAvailableDays.AutoSize = True
        Me.lblAvailableDays.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableDays.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailableDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAvailableDays.Location = New System.Drawing.Point(8, 255)
        Me.lblAvailableDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableDays.Name = "lblAvailableDays"
        Me.lblAvailableDays.Size = New System.Drawing.Size(120, 19)
        Me.lblAvailableDays.TabIndex = 26
        Me.lblAvailableDays.Text = "Available Days"
        '
        'txtClosingHours
        '
        Me.txtClosingHours.BackColor = System.Drawing.Color.White
        Me.txtClosingHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClosingHours.ForeColor = System.Drawing.Color.Black
        Me.txtClosingHours.Location = New System.Drawing.Point(433, 228)
        Me.txtClosingHours.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClosingHours.Name = "txtClosingHours"
        Me.txtClosingHours.Size = New System.Drawing.Size(111, 21)
        Me.txtClosingHours.TabIndex = 25
        '
        'lblClosingHours
        '
        Me.lblClosingHours.AutoSize = True
        Me.lblClosingHours.BackColor = System.Drawing.Color.Transparent
        Me.lblClosingHours.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblClosingHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClosingHours.Location = New System.Drawing.Point(298, 229)
        Me.lblClosingHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClosingHours.Name = "lblClosingHours"
        Me.lblClosingHours.Size = New System.Drawing.Size(125, 19)
        Me.lblClosingHours.TabIndex = 24
        Me.lblClosingHours.Text = "Closing Hours"
        '
        'txtOpeningHours
        '
        Me.txtOpeningHours.BackColor = System.Drawing.Color.White
        Me.txtOpeningHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.txtOpeningHours.Location = New System.Drawing.Point(137, 228)
        Me.txtOpeningHours.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOpeningHours.Name = "txtOpeningHours"
        Me.txtOpeningHours.Size = New System.Drawing.Size(111, 21)
        Me.txtOpeningHours.TabIndex = 23
        '
        'lblOpeningHours
        '
        Me.lblOpeningHours.AutoSize = True
        Me.lblOpeningHours.BackColor = System.Drawing.Color.Transparent
        Me.lblOpeningHours.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblOpeningHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOpeningHours.Location = New System.Drawing.Point(8, 228)
        Me.lblOpeningHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpeningHours.Name = "lblOpeningHours"
        Me.lblOpeningHours.Size = New System.Drawing.Size(127, 19)
        Me.lblOpeningHours.TabIndex = 22
        Me.lblOpeningHours.Text = "Opening Hours"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.White
        Me.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImageUrl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageUrl.ForeColor = System.Drawing.Color.Black
        Me.txtImageUrl.Location = New System.Drawing.Point(137, 199)
        Me.txtImageUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.Size = New System.Drawing.Size(407, 21)
        Me.txtImageUrl.TabIndex = 21
        '
        'lblImageUrl
        '
        Me.lblImageUrl.AutoSize = True
        Me.lblImageUrl.BackColor = System.Drawing.Color.Transparent
        Me.lblImageUrl.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblImageUrl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblImageUrl.Location = New System.Drawing.Point(8, 202)
        Me.lblImageUrl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImageUrl.Name = "lblImageUrl"
        Me.lblImageUrl.Size = New System.Drawing.Size(53, 19)
        Me.lblImageUrl.TabIndex = 20
        Me.lblImageUrl.Text = "Image"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.BackColor = System.Drawing.Color.Transparent
        Me.lblFeatures.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFeatures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFeatures.Location = New System.Drawing.Point(8, 172)
        Me.lblFeatures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(75, 19)
        Me.lblFeatures.TabIndex = 19
        Me.lblFeatures.Text = "Features"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.Color.White
        Me.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeatures.ForeColor = System.Drawing.Color.Black
        Me.txtFeatures.Location = New System.Drawing.Point(137, 171)
        Me.txtFeatures.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(407, 21)
        Me.txtFeatures.TabIndex = 18
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(137, 283)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(407, 114)
        Me.txtDescription.TabIndex = 17
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(8, 278)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(103, 19)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtEventType
        '
        Me.txtEventType.BackColor = System.Drawing.Color.White
        Me.txtEventType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventType.ForeColor = System.Drawing.Color.Black
        Me.txtEventType.Location = New System.Drawing.Point(137, 84)
        Me.txtEventType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventType.Name = "txtEventType"
        Me.txtEventType.Size = New System.Drawing.Size(407, 21)
        Me.txtEventType.TabIndex = 13
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.BackColor = System.Drawing.Color.Transparent
        Me.lblEventType.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventType.Location = New System.Drawing.Point(8, 84)
        Me.lblEventType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(115, 19)
        Me.lblEventType.TabIndex = 13
        Me.lblEventType.Text = "Type of Event"
        '
        'txtEventPlace
        '
        Me.txtEventPlace.BackColor = System.Drawing.Color.White
        Me.txtEventPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventPlace.ForeColor = System.Drawing.Color.Black
        Me.txtEventPlace.Location = New System.Drawing.Point(137, 53)
        Me.txtEventPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventPlace.Name = "txtEventPlace"
        Me.txtEventPlace.Size = New System.Drawing.Size(407, 21)
        Me.txtEventPlace.TabIndex = 12
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblEventPlace.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlace.Location = New System.Drawing.Point(8, 54)
        Me.lblEventPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(102, 19)
        Me.lblEventPlace.TabIndex = 12
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.BackColor = System.Drawing.Color.Transparent
        Me.lblPricePerDay.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPricePerDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPricePerDay.Location = New System.Drawing.Point(8, 143)
        Me.lblPricePerDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(111, 19)
        Me.lblPricePerDay.TabIndex = 5
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.BackColor = System.Drawing.Color.Transparent
        Me.lblCapacity.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCapacity.Location = New System.Drawing.Point(8, 114)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(77, 19)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity"
        '
        'txtPricePerDay
        '
        Me.txtPricePerDay.BackColor = System.Drawing.Color.White
        Me.txtPricePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPricePerDay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerDay.ForeColor = System.Drawing.Color.Black
        Me.txtPricePerDay.Location = New System.Drawing.Point(137, 143)
        Me.txtPricePerDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPricePerDay.Name = "txtPricePerDay"
        Me.txtPricePerDay.Size = New System.Drawing.Size(111, 21)
        Me.txtPricePerDay.TabIndex = 2
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.Color.White
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.ForeColor = System.Drawing.Color.Black
        Me.txtCapacity.Location = New System.Drawing.Point(137, 113)
        Me.txtCapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(111, 21)
        Me.txtCapacity.TabIndex = 1
        '
        'tpInvoicesAndPayments
        '
        Me.tpInvoicesAndPayments.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpInvoicesAndPayments.Controls.Add(Me.Label1)
        Me.tpInvoicesAndPayments.Controls.Add(Me.flpRevenueReports)
        Me.tpInvoicesAndPayments.Controls.Add(Me.flpInvoices)
        Me.tpInvoicesAndPayments.Location = New System.Drawing.Point(4, 27)
        Me.tpInvoicesAndPayments.Margin = New System.Windows.Forms.Padding(4)
        Me.tpInvoicesAndPayments.Name = "tpInvoicesAndPayments"
        Me.tpInvoicesAndPayments.Padding = New System.Windows.Forms.Padding(4)
        Me.tpInvoicesAndPayments.Size = New System.Drawing.Size(1225, 469)
        Me.tpInvoicesAndPayments.TabIndex = 5
        Me.tpInvoicesAndPayments.Text = "Invoices and Payments"
        Me.tpInvoicesAndPayments.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cinzel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Revenue"
        '
        'flpRevenueReports
        '
        Me.flpRevenueReports.Location = New System.Drawing.Point(13, 33)
        Me.flpRevenueReports.Margin = New System.Windows.Forms.Padding(4)
        Me.flpRevenueReports.Name = "flpRevenueReports"
        Me.flpRevenueReports.Size = New System.Drawing.Size(379, 421)
        Me.flpRevenueReports.TabIndex = 44
        '
        'flpInvoices
        '
        Me.flpInvoices.Location = New System.Drawing.Point(400, 33)
        Me.flpInvoices.Margin = New System.Windows.Forms.Padding(4)
        Me.flpInvoices.Name = "flpInvoices"
        Me.flpInvoices.Size = New System.Drawing.Size(814, 421)
        Me.flpInvoices.TabIndex = 0
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpCustomerRecords.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpCustomerRecords.Controls.Add(Me.Label4)
        Me.tpCustomerRecords.Controls.Add(Me.lblNumCustomersContainer)
        Me.tpCustomerRecords.Controls.Add(Me.flpCustomerRecords)
        Me.tpCustomerRecords.Location = New System.Drawing.Point(4, 27)
        Me.tpCustomerRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(4)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(1225, 469)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1075, 490)
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
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(1075, 468)
        Me.lblNumCustomersContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblNumCustomersContainer.TabIndex = 33
        Me.lblNumCustomersContainer.Text = "0"
        '
        'flpCustomerRecords
        '
        Me.flpCustomerRecords.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpCustomerRecords.Location = New System.Drawing.Point(9, 7)
        Me.flpCustomerRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.flpCustomerRecords.Name = "flpCustomerRecords"
        Me.flpCustomerRecords.Size = New System.Drawing.Size(1200, 447)
        Me.flpCustomerRecords.TabIndex = 0
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGadmin_updated_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 617)
        Me.Controls.Add(Me.tcAdminCenter)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnCustomerView)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAdminCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdminCenter"
        Me.tcAdminCenter.ResumeLayout(False)
        Me.tpBookings.ResumeLayout(False)
        Me.tpBookings.PerformLayout()
        Me.tcPendApprRej.ResumeLayout(False)
        Me.tpPendings.ResumeLayout(False)
        Me.tpApproved.ResumeLayout(False)
        Me.tpRejected.ResumeLayout(False)
        Me.tpAll.ResumeLayout(False)
        CType(Me.chartTotalStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEventPlaceMgmt.ResumeLayout(False)
        Me.tcAvailability.ResumeLayout(False)
        Me.tpAvailable.ResumeLayout(False)
        Me.tpBooked.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpInvoicesAndPayments.ResumeLayout(False)
        Me.tpInvoicesAndPayments.PerformLayout()
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
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tcAdminCenter As TabControl
    Friend WithEvents tpBookings As TabPage
    Friend WithEvents tcPendApprRej As TabControl
    Friend WithEvents tpPendings As TabPage
    Friend WithEvents flpPending As FlowLayoutPanel
    Friend WithEvents tpApproved As TabPage
    Friend WithEvents flpApproved As FlowLayoutPanel
    Friend WithEvents tpRejected As TabPage
    Friend WithEvents flpRejected As FlowLayoutPanel
    Friend WithEvents tpAll As TabPage
    Friend WithEvents flpAll As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents chartTotalStatus As DataVisualization.Charting.Chart
    Friend WithEvents mcBookings As MonthCalendar
    Friend WithEvents tpEventPlaceMgmt As TabPage
    Friend WithEvents tcAvailability As TabControl
    Friend WithEvents tpAvailable As TabPage
    Friend WithEvents flpAvailable As FlowLayoutPanel
    Friend WithEvents tpBooked As TabPage
    Friend WithEvents flpBooked As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents lblErrorCapacity As Label
    Friend WithEvents lblErrorOpeningHours As Label
    Friend WithEvents lblErrorPrice As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
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
    Friend WithEvents tpInvoicesAndPayments As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents flpRevenueReports As FlowLayoutPanel
    Friend WithEvents flpInvoices As FlowLayoutPanel
    Friend WithEvents tpCustomerRecords As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNumCustomersContainer As Label
    Friend WithEvents flpCustomerRecords As FlowLayoutPanel
End Class
