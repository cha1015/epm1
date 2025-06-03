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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblErrorClosingHours = New System.Windows.Forms.Label()
        Me.cbEndAMPM = New System.Windows.Forms.ComboBox()
        Me.cbEndMinutes = New System.Windows.Forms.ComboBox()
        Me.cbEndHour = New System.Windows.Forms.ComboBox()
        Me.cbStartAMPM = New System.Windows.Forms.ComboBox()
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.cbStartHour = New System.Windows.Forms.ComboBox()
        Me.txtPlaceID = New System.Windows.Forms.TextBox()
        Me.lblPlaceID = New System.Windows.Forms.Label()
        Me.lblErrorCapacity = New System.Windows.Forms.Label()
        Me.lblErrorOpeningHours = New System.Windows.Forms.Label()
        Me.lblErrorPrice = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgvPaidBookings = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tpCustomerRecords = New System.Windows.Forms.TabPage()
        Me.dgvCustomerRec = New System.Windows.Forms.DataGridView()
        Me.lblNumCustomersContainer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.tpRevenue = New System.Windows.Forms.TabPage()
        Me.dgvRevenue = New System.Windows.Forms.DataGridView()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.tpInvoicesAndPayments = New System.Windows.Forms.TabPage()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tpPendings = New System.Windows.Forms.TabPage()
        Me.flpPending = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpApproved = New System.Windows.Forms.TabPage()
        Me.flpApproved = New System.Windows.Forms.FlowLayoutPanel()
        Me.tcPendApprRej = New System.Windows.Forms.TabControl()
        Me.tpRejected = New System.Windows.Forms.TabPage()
        Me.flpRejected = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpAll = New System.Windows.Forms.TabPage()
        Me.flpAll = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpBookings = New System.Windows.Forms.TabPage()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtAvailableDays = New System.Windows.Forms.TextBox()
        Me.lblAvailableDays = New System.Windows.Forms.Label()
        Me.lblClosingHours = New System.Windows.Forms.Label()
        Me.lblOpeningHours = New System.Windows.Forms.Label()
        Me.txtImageUrl = New System.Windows.Forms.TextBox()
        Me.lblImageUrl = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.tcAdminCenter = New System.Windows.Forms.TabControl()
        Me.tpEventPlaceMgmt = New System.Windows.Forms.TabPage()
        Me.flpEventPlaces = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.dgvPaidBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCustomerRecords.SuspendLayout()
        CType(Me.dgvCustomerRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRevenue.SuspendLayout()
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInvoicesAndPayments.SuspendLayout()
        Me.tpPendings.SuspendLayout()
        Me.tpApproved.SuspendLayout()
        Me.tcPendApprRej.SuspendLayout()
        Me.tpRejected.SuspendLayout()
        Me.tpAll.SuspendLayout()
        Me.tpBookings.SuspendLayout()
        Me.tcAdminCenter.SuspendLayout()
        Me.tpEventPlaceMgmt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.IndianRed
        Me.btnClear.Location = New System.Drawing.Point(410, -2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(42, 30)
        Me.btnClear.TabIndex = 83
        Me.btnClear.Text = "✖"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblErrorClosingHours
        '
        Me.lblErrorClosingHours.AutoSize = True
        Me.lblErrorClosingHours.Location = New System.Drawing.Point(316, 215)
        Me.lblErrorClosingHours.Name = "lblErrorClosingHours"
        Me.lblErrorClosingHours.Size = New System.Drawing.Size(0, 25)
        Me.lblErrorClosingHours.TabIndex = 82
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbEndAMPM.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndAMPM.FormattingEnabled = True
        Me.cbEndAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEndAMPM.Location = New System.Drawing.Point(245, 213)
        Me.cbEndAMPM.Name = "cbEndAMPM"
        Me.cbEndAMPM.Size = New System.Drawing.Size(66, 27)
        Me.cbEndAMPM.TabIndex = 81
        '
        'cbEndMinutes
        '
        Me.cbEndMinutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbEndMinutes.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndMinutes.FormattingEnabled = True
        Me.cbEndMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.Location = New System.Drawing.Point(174, 213)
        Me.cbEndMinutes.Name = "cbEndMinutes"
        Me.cbEndMinutes.Size = New System.Drawing.Size(66, 27)
        Me.cbEndMinutes.TabIndex = 80
        '
        'cbEndHour
        '
        Me.cbEndHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbEndHour.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndHour.FormattingEnabled = True
        Me.cbEndHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.Location = New System.Drawing.Point(103, 213)
        Me.cbEndHour.Name = "cbEndHour"
        Me.cbEndHour.Size = New System.Drawing.Size(66, 27)
        Me.cbEndHour.TabIndex = 79
        '
        'cbStartAMPM
        '
        Me.cbStartAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbStartAMPM.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartAMPM.FormattingEnabled = True
        Me.cbStartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStartAMPM.Location = New System.Drawing.Point(245, 185)
        Me.cbStartAMPM.Name = "cbStartAMPM"
        Me.cbStartAMPM.Size = New System.Drawing.Size(66, 27)
        Me.cbStartAMPM.TabIndex = 78
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbStartMinutes.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(174, 185)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(66, 27)
        Me.cbStartMinutes.TabIndex = 77
        '
        'cbStartHour
        '
        Me.cbStartHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbStartHour.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartHour.FormattingEnabled = True
        Me.cbStartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.Location = New System.Drawing.Point(103, 185)
        Me.cbStartHour.Name = "cbStartHour"
        Me.cbStartHour.Size = New System.Drawing.Size(66, 27)
        Me.cbStartHour.TabIndex = 76
        '
        'txtPlaceID
        '
        Me.txtPlaceID.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.lblErrorCapacity.Size = New System.Drawing.Size(0, 25)
        Me.lblErrorCapacity.TabIndex = 31
        '
        'lblErrorOpeningHours
        '
        Me.lblErrorOpeningHours.AutoSize = True
        Me.lblErrorOpeningHours.Location = New System.Drawing.Point(316, 193)
        Me.lblErrorOpeningHours.Name = "lblErrorOpeningHours"
        Me.lblErrorOpeningHours.Size = New System.Drawing.Size(0, 25)
        Me.lblErrorOpeningHours.TabIndex = 30
        '
        'lblErrorPrice
        '
        Me.lblErrorPrice.AutoSize = True
        Me.lblErrorPrice.Location = New System.Drawing.Point(192, 121)
        Me.lblErrorPrice.Name = "lblErrorPrice"
        Me.lblErrorPrice.Size = New System.Drawing.Size(0, 25)
        Me.lblErrorPrice.TabIndex = 32
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.BackgroundImage = Global.epm1.My.Resources.Resources.BttnAdd
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(103, 347)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvPaidBookings
        '
        Me.dgvPaidBookings.AllowUserToAddRows = False
        Me.dgvPaidBookings.AllowUserToDeleteRows = False
        Me.dgvPaidBookings.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvPaidBookings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaidBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaidBookings.Location = New System.Drawing.Point(6, 29)
        Me.dgvPaidBookings.Name = "dgvPaidBookings"
        Me.dgvPaidBookings.ReadOnly = True
        Me.dgvPaidBookings.RowHeadersWidth = 51
        Me.dgvPaidBookings.Size = New System.Drawing.Size(902, 358)
        Me.dgvPaidBookings.TabIndex = 98
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Black
        Me.lblSearch.Location = New System.Drawing.Point(634, 5)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(61, 25)
        Me.lblSearch.TabIndex = 97
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(685, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 17)
        Me.txtSearch.TabIndex = 96
        '
        'tpCustomerRecords
        '
        Me.tpCustomerRecords.BackColor = System.Drawing.Color.Transparent
        Me.tpCustomerRecords.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpCustomerRecords.Controls.Add(Me.dgvCustomerRec)
        Me.tpCustomerRecords.Controls.Add(Me.lblNumCustomersContainer)
        Me.tpCustomerRecords.Controls.Add(Me.Label2)
        Me.tpCustomerRecords.Controls.Add(Me.txtSearchCustomer)
        Me.tpCustomerRecords.Location = New System.Drawing.Point(4, 26)
        Me.tpCustomerRecords.Name = "tpCustomerRecords"
        Me.tpCustomerRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerRecords.Size = New System.Drawing.Size(913, 386)
        Me.tpCustomerRecords.TabIndex = 4
        Me.tpCustomerRecords.Text = "Customer Records"
        '
        'dgvCustomerRec
        '
        Me.dgvCustomerRec.AllowUserToAddRows = False
        Me.dgvCustomerRec.AllowUserToDeleteRows = False
        Me.dgvCustomerRec.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvCustomerRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomerRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerRec.Location = New System.Drawing.Point(6, 29)
        Me.dgvCustomerRec.Name = "dgvCustomerRec"
        Me.dgvCustomerRec.ReadOnly = True
        Me.dgvCustomerRec.RowHeadersWidth = 51
        Me.dgvCustomerRec.Size = New System.Drawing.Size(901, 358)
        Me.dgvCustomerRec.TabIndex = 102
        '
        'lblNumCustomersContainer
        '
        Me.lblNumCustomersContainer.AutoSize = True
        Me.lblNumCustomersContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCustomersContainer.ForeColor = System.Drawing.Color.Black
        Me.lblNumCustomersContainer.Location = New System.Drawing.Point(886, 7)
        Me.lblNumCustomersContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumCustomersContainer.Name = "lblNumCustomersContainer"
        Me.lblNumCustomersContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblNumCustomersContainer.TabIndex = 100
        Me.lblNumCustomersContainer.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Search"
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchCustomer.ForeColor = System.Drawing.Color.Black
        Me.txtSearchCustomer.Location = New System.Drawing.Point(54, 6)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(222, 17)
        Me.txtSearchCustomer.TabIndex = 98
        '
        'tpRevenue
        '
        Me.tpRevenue.Controls.Add(Me.dgvRevenue)
        Me.tpRevenue.Controls.Add(Me.lblRevenue)
        Me.tpRevenue.Location = New System.Drawing.Point(4, 26)
        Me.tpRevenue.Name = "tpRevenue"
        Me.tpRevenue.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRevenue.Size = New System.Drawing.Size(913, 386)
        Me.tpRevenue.TabIndex = 7
        Me.tpRevenue.Text = "Revenue"
        Me.tpRevenue.UseVisualStyleBackColor = True
        '
        'dgvRevenue
        '
        Me.dgvRevenue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRevenue.Location = New System.Drawing.Point(6, 26)
        Me.dgvRevenue.Name = "dgvRevenue"
        Me.dgvRevenue.RowHeadersWidth = 51
        Me.dgvRevenue.Size = New System.Drawing.Size(901, 354)
        Me.dgvRevenue.TabIndex = 50
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.Location = New System.Drawing.Point(776, 3)
        Me.lblRevenue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(76, 26)
        Me.lblRevenue.TabIndex = 49
        Me.lblRevenue.Text = "Revenue"
        '
        'tpInvoicesAndPayments
        '
        Me.tpInvoicesAndPayments.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpInvoicesAndPayments.Controls.Add(Me.dgvPaidBookings)
        Me.tpInvoicesAndPayments.Controls.Add(Me.lblSearch)
        Me.tpInvoicesAndPayments.Controls.Add(Me.txtSearch)
        Me.tpInvoicesAndPayments.Location = New System.Drawing.Point(4, 26)
        Me.tpInvoicesAndPayments.Name = "tpInvoicesAndPayments"
        Me.tpInvoicesAndPayments.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInvoicesAndPayments.Size = New System.Drawing.Size(913, 386)
        Me.tpInvoicesAndPayments.TabIndex = 5
        Me.tpInvoicesAndPayments.Text = "Invoices and Payments"
        Me.tpInvoicesAndPayments.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.BackgroundImage = Global.epm1.My.Resources.Resources.BttnChinomsOrBackToMain
        Me.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMain.FlatAppearance.BorderSize = 0
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Location = New System.Drawing.Point(4, 17)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(169, 45)
        Me.btnMain.TabIndex = 102
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.BackgroundImage = Global.epm1.My.Resources.Resources.BttnDelete
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(320, 347)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'tpPendings
        '
        Me.tpPendings.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpPendings.Controls.Add(Me.flpPending)
        Me.tpPendings.Location = New System.Drawing.Point(4, 26)
        Me.tpPendings.Margin = New System.Windows.Forms.Padding(2)
        Me.tpPendings.Name = "tpPendings"
        Me.tpPendings.Padding = New System.Windows.Forms.Padding(2)
        Me.tpPendings.Size = New System.Drawing.Size(896, 349)
        Me.tpPendings.TabIndex = 0
        Me.tpPendings.Text = "Pendings"
        Me.tpPendings.UseVisualStyleBackColor = True
        '
        'flpPending
        '
        Me.flpPending.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpPending.Location = New System.Drawing.Point(5, 6)
        Me.flpPending.Name = "flpPending"
        Me.flpPending.Size = New System.Drawing.Size(887, 336)
        Me.flpPending.TabIndex = 1
        '
        'tpApproved
        '
        Me.tpApproved.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpApproved.Controls.Add(Me.flpApproved)
        Me.tpApproved.Location = New System.Drawing.Point(4, 26)
        Me.tpApproved.Margin = New System.Windows.Forms.Padding(2)
        Me.tpApproved.Name = "tpApproved"
        Me.tpApproved.Padding = New System.Windows.Forms.Padding(2)
        Me.tpApproved.Size = New System.Drawing.Size(896, 349)
        Me.tpApproved.TabIndex = 1
        Me.tpApproved.Text = "Approved"
        Me.tpApproved.UseVisualStyleBackColor = True
        '
        'flpApproved
        '
        Me.flpApproved.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpApproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpApproved.Location = New System.Drawing.Point(5, 6)
        Me.flpApproved.Name = "flpApproved"
        Me.flpApproved.Size = New System.Drawing.Size(887, 375)
        Me.flpApproved.TabIndex = 2
        '
        'tcPendApprRej
        '
        Me.tcPendApprRej.Controls.Add(Me.tpPendings)
        Me.tcPendApprRej.Controls.Add(Me.tpApproved)
        Me.tcPendApprRej.Controls.Add(Me.tpRejected)
        Me.tcPendApprRej.Controls.Add(Me.tpAll)
        Me.tcPendApprRej.Location = New System.Drawing.Point(5, 6)
        Me.tcPendApprRej.Margin = New System.Windows.Forms.Padding(2)
        Me.tcPendApprRej.Name = "tcPendApprRej"
        Me.tcPendApprRej.SelectedIndex = 0
        Me.tcPendApprRej.Size = New System.Drawing.Size(904, 379)
        Me.tcPendApprRej.TabIndex = 45
        '
        'tpRejected
        '
        Me.tpRejected.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpRejected.Controls.Add(Me.flpRejected)
        Me.tpRejected.Location = New System.Drawing.Point(4, 26)
        Me.tpRejected.Margin = New System.Windows.Forms.Padding(2)
        Me.tpRejected.Name = "tpRejected"
        Me.tpRejected.Padding = New System.Windows.Forms.Padding(2)
        Me.tpRejected.Size = New System.Drawing.Size(896, 349)
        Me.tpRejected.TabIndex = 2
        Me.tpRejected.Text = "Rejected"
        Me.tpRejected.UseVisualStyleBackColor = True
        '
        'flpRejected
        '
        Me.flpRejected.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpRejected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flpRejected.Location = New System.Drawing.Point(5, 6)
        Me.flpRejected.Name = "flpRejected"
        Me.flpRejected.Size = New System.Drawing.Size(887, 375)
        Me.flpRejected.TabIndex = 2
        '
        'tpAll
        '
        Me.tpAll.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpAll.Controls.Add(Me.flpAll)
        Me.tpAll.Location = New System.Drawing.Point(4, 26)
        Me.tpAll.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAll.Name = "tpAll"
        Me.tpAll.Padding = New System.Windows.Forms.Padding(2)
        Me.tpAll.Size = New System.Drawing.Size(896, 349)
        Me.tpAll.TabIndex = 3
        Me.tpAll.Text = "All"
        Me.tpAll.UseVisualStyleBackColor = True
        '
        'flpAll
        '
        Me.flpAll.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpAll.Location = New System.Drawing.Point(5, 6)
        Me.flpAll.Name = "flpAll"
        Me.flpAll.Size = New System.Drawing.Size(887, 375)
        Me.flpAll.TabIndex = 2
        '
        'tpBookings
        '
        Me.tpBookings.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpBookings.Controls.Add(Me.tcPendApprRej)
        Me.tpBookings.Location = New System.Drawing.Point(4, 26)
        Me.tpBookings.Name = "tpBookings"
        Me.tpBookings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookings.Size = New System.Drawing.Size(913, 386)
        Me.tpBookings.TabIndex = 6
        Me.tpBookings.Text = "Bookings"
        Me.tpBookings.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.BackgroundImage = Global.epm1.My.Resources.Resources.BttnUpdate
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(211, 347)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 30)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtAvailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableDays.Location = New System.Drawing.Point(103, 241)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.Size = New System.Drawing.Size(305, 21)
        Me.txtAvailableDays.TabIndex = 27
        '
        'lblAvailableDays
        '
        Me.lblAvailableDays.AutoSize = True
        Me.lblAvailableDays.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableDays.ForeColor = System.Drawing.Color.Black
        Me.lblAvailableDays.Location = New System.Drawing.Point(6, 239)
        Me.lblAvailableDays.Name = "lblAvailableDays"
        Me.lblAvailableDays.Size = New System.Drawing.Size(112, 25)
        Me.lblAvailableDays.TabIndex = 26
        Me.lblAvailableDays.Text = "Available Days"
        '
        'lblClosingHours
        '
        Me.lblClosingHours.AutoSize = True
        Me.lblClosingHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosingHours.ForeColor = System.Drawing.Color.Black
        Me.lblClosingHours.Location = New System.Drawing.Point(6, 213)
        Me.lblClosingHours.Name = "lblClosingHours"
        Me.lblClosingHours.Size = New System.Drawing.Size(107, 25)
        Me.lblClosingHours.TabIndex = 24
        Me.lblClosingHours.Text = "Closing Hours"
        '
        'lblOpeningHours
        '
        Me.lblOpeningHours.AutoSize = True
        Me.lblOpeningHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningHours.ForeColor = System.Drawing.Color.Black
        Me.lblOpeningHours.Location = New System.Drawing.Point(6, 190)
        Me.lblOpeningHours.Name = "lblOpeningHours"
        Me.lblOpeningHours.Size = New System.Drawing.Size(115, 25)
        Me.lblOpeningHours.TabIndex = 22
        Me.lblOpeningHours.Text = "Opening Hours"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.lblImageUrl.Location = New System.Drawing.Point(6, 162)
        Me.lblImageUrl.Name = "lblImageUrl"
        Me.lblImageUrl.Size = New System.Drawing.Size(91, 25)
        Me.lblImageUrl.TabIndex = 20
        Me.lblImageUrl.Text = "Image Path"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeatures.ForeColor = System.Drawing.Color.Black
        Me.lblFeatures.Location = New System.Drawing.Point(6, 139)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(72, 25)
        Me.lblFeatures.TabIndex = 19
        Me.lblFeatures.Text = "Features"
        '
        'tcAdminCenter
        '
        Me.tcAdminCenter.Controls.Add(Me.tpBookings)
        Me.tcAdminCenter.Controls.Add(Me.tpEventPlaceMgmt)
        Me.tcAdminCenter.Controls.Add(Me.tpInvoicesAndPayments)
        Me.tcAdminCenter.Controls.Add(Me.tpCustomerRecords)
        Me.tcAdminCenter.Controls.Add(Me.tpRevenue)
        Me.tcAdminCenter.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAdminCenter.Location = New System.Drawing.Point(14, 70)
        Me.tcAdminCenter.Multiline = True
        Me.tcAdminCenter.Name = "tcAdminCenter"
        Me.tcAdminCenter.SelectedIndex = 0
        Me.tcAdminCenter.Size = New System.Drawing.Size(921, 416)
        Me.tcAdminCenter.TabIndex = 103
        '
        'tpEventPlaceMgmt
        '
        Me.tpEventPlaceMgmt.BackColor = System.Drawing.Color.Transparent
        Me.tpEventPlaceMgmt.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpEventPlaceMgmt.Controls.Add(Me.flpEventPlaces)
        Me.tpEventPlaceMgmt.Controls.Add(Me.GroupBox1)
        Me.tpEventPlaceMgmt.Location = New System.Drawing.Point(4, 26)
        Me.tpEventPlaceMgmt.Name = "tpEventPlaceMgmt"
        Me.tpEventPlaceMgmt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventPlaceMgmt.Size = New System.Drawing.Size(913, 386)
        Me.tpEventPlaceMgmt.TabIndex = 0
        Me.tpEventPlaceMgmt.Text = "Event Places"
        '
        'flpEventPlaces
        '
        Me.flpEventPlaces.AutoScroll = True
        Me.flpEventPlaces.BackColor = System.Drawing.Color.Transparent
        Me.flpEventPlaces.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.flpEventPlaces.Location = New System.Drawing.Point(14, 15)
        Me.flpEventPlaces.Margin = New System.Windows.Forms.Padding(2)
        Me.flpEventPlaces.Name = "flpEventPlaces"
        Me.flpEventPlaces.Size = New System.Drawing.Size(436, 367)
        Me.flpEventPlaces.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblErrorClosingHours)
        Me.GroupBox1.Controls.Add(Me.cbEndAMPM)
        Me.GroupBox1.Controls.Add(Me.cbEndMinutes)
        Me.GroupBox1.Controls.Add(Me.cbEndHour)
        Me.GroupBox1.Controls.Add(Me.cbStartAMPM)
        Me.GroupBox1.Controls.Add(Me.cbStartMinutes)
        Me.GroupBox1.Controls.Add(Me.cbStartHour)
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
        Me.GroupBox1.Controls.Add(Me.lblClosingHours)
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
        Me.GroupBox1.Size = New System.Drawing.Size(448, 392)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(103, 264)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(305, 77)
        Me.txtDescription.TabIndex = 17
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(6, 264)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(90, 25)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'txtEventType
        '
        Me.txtEventType.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.txtEventPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.lblEventPlace.Location = New System.Drawing.Point(6, 43)
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
        Me.txtPricePerDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
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
        Me.txtCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.ForeColor = System.Drawing.Color.Black
        Me.txtCapacity.Location = New System.Drawing.Point(103, 92)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(83, 21)
        Me.txtCapacity.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "btnFilter.png")
        Me.ImageList1.Images.SetKeyName(1, "btnSearch.png")
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BackgroundImage = Global.epm1.My.Resources.Resources.bttnEditInfo
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(850, 14)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 24)
        Me.btnEdit.TabIndex = 100
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(745, 37)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(56, 25)
        Me.lblRole.TabIndex = 99
        Me.lblRole.Text = "Admin"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(745, 21)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 98
        Me.lblUsername.Text = "Admin Name"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogOut
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(850, 41)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(90, 24)
        Me.btnLogOut.TabIndex = 101
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'FormAdminCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGMain_updated_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.tcAdminCenter)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogOut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdminCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdminCenter"
        CType(Me.dgvPaidBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCustomerRecords.ResumeLayout(False)
        Me.tpCustomerRecords.PerformLayout()
        CType(Me.dgvCustomerRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRevenue.ResumeLayout(False)
        Me.tpRevenue.PerformLayout()
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInvoicesAndPayments.ResumeLayout(False)
        Me.tpInvoicesAndPayments.PerformLayout()
        Me.tpPendings.ResumeLayout(False)
        Me.tpApproved.ResumeLayout(False)
        Me.tcPendApprRej.ResumeLayout(False)
        Me.tpRejected.ResumeLayout(False)
        Me.tpAll.ResumeLayout(False)
        Me.tpBookings.ResumeLayout(False)
        Me.tcAdminCenter.ResumeLayout(False)
        Me.tpEventPlaceMgmt.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents lblErrorClosingHours As Label
    Friend WithEvents cbEndAMPM As ComboBox
    Friend WithEvents cbEndMinutes As ComboBox
    Friend WithEvents cbEndHour As ComboBox
    Friend WithEvents cbStartAMPM As ComboBox
    Friend WithEvents cbStartMinutes As ComboBox
    Friend WithEvents cbStartHour As ComboBox
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents lblErrorCapacity As Label
    Friend WithEvents lblErrorOpeningHours As Label
    Friend WithEvents lblErrorPrice As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvPaidBookings As DataGridView
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents tpCustomerRecords As TabPage
    Friend WithEvents dgvCustomerRec As DataGridView
    Friend WithEvents lblNumCustomersContainer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents tpRevenue As TabPage
    Friend WithEvents dgvRevenue As DataGridView
    Friend WithEvents lblRevenue As Label
    Friend WithEvents tpInvoicesAndPayments As TabPage
    Friend WithEvents btnMain As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tpPendings As TabPage
    Friend WithEvents flpPending As FlowLayoutPanel
    Friend WithEvents tpApproved As TabPage
    Friend WithEvents flpApproved As FlowLayoutPanel
    Friend WithEvents tcPendApprRej As TabControl
    Friend WithEvents tpRejected As TabPage
    Friend WithEvents flpRejected As FlowLayoutPanel
    Friend WithEvents tpAll As TabPage
    Friend WithEvents flpAll As FlowLayoutPanel
    Friend WithEvents tpBookings As TabPage
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtAvailableDays As TextBox
    Friend WithEvents lblAvailableDays As Label
    Friend WithEvents lblClosingHours As Label
    Friend WithEvents lblOpeningHours As Label
    Friend WithEvents txtImageUrl As TextBox
    Friend WithEvents lblImageUrl As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents tcAdminCenter As TabControl
    Friend WithEvents tpEventPlaceMgmt As TabPage
    Friend WithEvents flpEventPlaces As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogOut As Button
End Class
