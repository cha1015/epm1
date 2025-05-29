<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBooking))
        Me.tpCustomerDetails = New System.Windows.Forms.TabPage()
        Me.btnCustomerProceed = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateWarning = New System.Windows.Forms.Label()
        Me.lblBeyondAvailabilityFee = New System.Windows.Forms.Label()
        Me.lblCapacityExceedanceFee = New System.Windows.Forms.Label()
        Me.chkOutsideAvailableHours = New System.Windows.Forms.CheckBox()
        Me.cbSameDayEvent = New System.Windows.Forms.CheckBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.lblNumGuestsPaymentContainer = New System.Windows.Forms.Label()
        Me.lblNumGuestsPayment = New System.Windows.Forms.Label()
        Me.lblEventTypePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTypePayment = New System.Windows.Forms.Label()
        Me.lblEventPlacePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventPlacePayment = New System.Windows.Forms.Label()
        Me.lblCustomerContainer = New System.Windows.Forms.Label()
        Me.cbEndAMPM = New System.Windows.Forms.ComboBox()
        Me.cbEndMinutes = New System.Windows.Forms.ComboBox()
        Me.cbEndHour = New System.Windows.Forms.ComboBox()
        Me.cbStartAMPM = New System.Windows.Forms.ComboBox()
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.cbStartHour = New System.Windows.Forms.ComboBox()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.cbEventType = New System.Windows.Forms.ComboBox()
        Me.lblNumGuests = New System.Windows.Forms.Label()
        Me.lblEventTimeEnd = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblEventTimeStart = New System.Windows.Forms.Label()
        Me.lblEventDateStart = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblServicesAvailed = New System.Windows.Forms.Label()
        Me.lblPriceBreakdown = New System.Windows.Forms.Label()
        Me.lblTotalPricePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTimePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTimePayment = New System.Windows.Forms.Label()
        Me.lblEventDatePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventDatePayment = New System.Windows.Forms.Label()
        Me.tpPaymentDetails = New System.Windows.Forms.TabPage()
        Me.btnPlaceBooking = New System.Windows.Forms.Button()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pnlEventInfo = New System.Windows.Forms.Panel()
        Me.lblAv = New System.Windows.Forms.Label()
        Me.lblAvailableDaysContainer = New System.Windows.Forms.Label()
        Me.lblPlaceIDContainer = New System.Windows.Forms.Label()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.lblPlaceID = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblHoursContainer = New System.Windows.Forms.Label()
        Me.lblPricePerDayContainer = New System.Windows.Forms.Label()
        Me.lblCapacityContainer = New System.Windows.Forms.Label()
        Me.lblPricePerDay = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblFeaturesContainer = New System.Windows.Forms.Label()
        Me.lblDescriptionContainer = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tcDetails = New System.Windows.Forms.TabControl()
        Me.tpBookingDetails = New System.Windows.Forms.TabPage()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.dtpEventDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtNumGuests = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEventDateStart = New System.Windows.Forms.DateTimePicker()
        Me.chkCatering = New System.Windows.Forms.CheckBox()
        Me.lblEventSchedule = New System.Windows.Forms.Label()
        Me.chkClown = New System.Windows.Forms.CheckBox()
        Me.btBookingProceed = New System.Windows.Forms.Button()
        Me.chkSinger = New System.Windows.Forms.CheckBox()
        Me.chkVideoke = New System.Windows.Forms.CheckBox()
        Me.chkDancer = New System.Windows.Forms.CheckBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.tpCustomerDetails.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPaymentDetails.SuspendLayout()
        Me.pnlEventInfo.SuspendLayout()
        Me.tcDetails.SuspendLayout()
        Me.tpBookingDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpCustomerDetails
        '
        Me.tpCustomerDetails.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpCustomerDetails.Controls.Add(Me.btnCustomerProceed)
        Me.tpCustomerDetails.Controls.Add(Me.lblName)
        Me.tpCustomerDetails.Controls.Add(Me.dtpBirthday)
        Me.tpCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.tpCustomerDetails.Controls.Add(Me.lblBirthday)
        Me.tpCustomerDetails.Controls.Add(Me.cmbSex)
        Me.tpCustomerDetails.Controls.Add(Me.lblAddress)
        Me.tpCustomerDetails.Controls.Add(Me.lblSex)
        Me.tpCustomerDetails.Controls.Add(Me.txtAddress)
        Me.tpCustomerDetails.Controls.Add(Me.lblAge)
        Me.tpCustomerDetails.Controls.Add(Me.txtAge)
        Me.tpCustomerDetails.Location = New System.Drawing.Point(4, 27)
        Me.tpCustomerDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpCustomerDetails.Name = "tpCustomerDetails"
        Me.tpCustomerDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpCustomerDetails.Size = New System.Drawing.Size(804, 472)
        Me.tpCustomerDetails.TabIndex = 1
        Me.tpCustomerDetails.Text = "Customer Details"
        Me.tpCustomerDetails.UseVisualStyleBackColor = True
        '
        'btnCustomerProceed
        '
        Me.btnCustomerProceed.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomerProceed.BackgroundImage = Global.epm1.My.Resources.Resources.BttnProceed
        Me.btnCustomerProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerProceed.FlatAppearance.BorderSize = 0
        Me.btnCustomerProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerProceed.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerProceed.Location = New System.Drawing.Point(625, 421)
        Me.btnCustomerProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerProceed.Name = "btnCustomerProceed"
        Me.btnCustomerProceed.Size = New System.Drawing.Size(157, 35)
        Me.btnCustomerProceed.TabIndex = 61
        Me.btnCustomerProceed.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(46, 23)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 19)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(139, 60)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(604, 25)
        Me.dtpBirthday.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(139, 23)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(604, 25)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(46, 62)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(78, 19)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(139, 134)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(604, 26)
        Me.cmbSex.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(46, 180)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(70, 19)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(46, 141)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(34, 19)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(139, 175)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(604, 25)
        Me.txtAddress.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(46, 102)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 19)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(139, 97)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(604, 25)
        Me.txtAge.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 450)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 81
        '
        'lblDateWarning
        '
        Me.lblDateWarning.AutoSize = True
        Me.lblDateWarning.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDateWarning.Location = New System.Drawing.Point(471, 145)
        Me.lblDateWarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateWarning.Name = "lblDateWarning"
        Me.lblDateWarning.Size = New System.Drawing.Size(250, 25)
        Me.lblDateWarning.TabIndex = 80
        Me.lblDateWarning.Text = "The selected date - is unavailable."
        '
        'lblBeyondAvailabilityFee
        '
        Me.lblBeyondAvailabilityFee.AutoSize = True
        Me.lblBeyondAvailabilityFee.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeyondAvailabilityFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBeyondAvailabilityFee.Location = New System.Drawing.Point(465, 210)
        Me.lblBeyondAvailabilityFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBeyondAvailabilityFee.Name = "lblBeyondAvailabilityFee"
        Me.lblBeyondAvailabilityFee.Size = New System.Drawing.Size(174, 50)
        Me.lblBeyondAvailabilityFee.TabIndex = 79
        Me.lblBeyondAvailabilityFee.Text = "Beyond Availability Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱17 per minute)"
        '
        'lblCapacityExceedanceFee
        '
        Me.lblCapacityExceedanceFee.AutoSize = True
        Me.lblCapacityExceedanceFee.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityExceedanceFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCapacityExceedanceFee.Location = New System.Drawing.Point(471, 58)
        Me.lblCapacityExceedanceFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacityExceedanceFee.Name = "lblCapacityExceedanceFee"
        Me.lblCapacityExceedanceFee.Size = New System.Drawing.Size(195, 50)
        Me.lblCapacityExceedanceFee.TabIndex = 78
        Me.lblCapacityExceedanceFee.Text = "Capacity Exceedance Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱100 per additional)"
        '
        'chkOutsideAvailableHours
        '
        Me.chkOutsideAvailableHours.AutoSize = True
        Me.chkOutsideAvailableHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOutsideAvailableHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkOutsideAvailableHours.Location = New System.Drawing.Point(471, 260)
        Me.chkOutsideAvailableHours.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOutsideAvailableHours.Name = "chkOutsideAvailableHours"
        Me.chkOutsideAvailableHours.Size = New System.Drawing.Size(232, 54)
        Me.chkOutsideAvailableHours.TabIndex = 77
        Me.chkOutsideAvailableHours.Text = "Book outside available hours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(+ extra fee)"
        Me.chkOutsideAvailableHours.UseVisualStyleBackColor = True
        '
        'cbSameDayEvent
        '
        Me.cbSameDayEvent.AutoSize = True
        Me.cbSameDayEvent.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSameDayEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbSameDayEvent.Location = New System.Drawing.Point(325, 98)
        Me.cbSameDayEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSameDayEvent.Name = "cbSameDayEvent"
        Me.cbSameDayEvent.Size = New System.Drawing.Size(147, 29)
        Me.cbSameDayEvent.TabIndex = 76
        Me.cbSameDayEvent.Text = "Same Day Event"
        Me.cbSameDayEvent.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(35, 120)
        Me.pb.Margin = New System.Windows.Forms.Padding(4)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(366, 169)
        Me.pb.TabIndex = 95
        Me.pb.TabStop = False
        '
        'lblNumGuestsPaymentContainer
        '
        Me.lblNumGuestsPaymentContainer.AutoSize = True
        Me.lblNumGuestsPaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblNumGuestsPaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblNumGuestsPaymentContainer.Location = New System.Drawing.Point(229, 162)
        Me.lblNumGuestsPaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuestsPaymentContainer.Name = "lblNumGuestsPaymentContainer"
        Me.lblNumGuestsPaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblNumGuestsPaymentContainer.TabIndex = 7
        Me.lblNumGuestsPaymentContainer.Text = "-"
        '
        'lblNumGuestsPayment
        '
        Me.lblNumGuestsPayment.AutoSize = True
        Me.lblNumGuestsPayment.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumGuestsPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuestsPayment.Location = New System.Drawing.Point(21, 162)
        Me.lblNumGuestsPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuestsPayment.Name = "lblNumGuestsPayment"
        Me.lblNumGuestsPayment.Size = New System.Drawing.Size(146, 19)
        Me.lblNumGuestsPayment.TabIndex = 6
        Me.lblNumGuestsPayment.Text = "Number of Guests"
        '
        'lblEventTypePaymentContainer
        '
        Me.lblEventTypePaymentContainer.AutoSize = True
        Me.lblEventTypePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblEventTypePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTypePaymentContainer.Location = New System.Drawing.Point(229, 112)
        Me.lblEventTypePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTypePaymentContainer.Name = "lblEventTypePaymentContainer"
        Me.lblEventTypePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblEventTypePaymentContainer.TabIndex = 5
        Me.lblEventTypePaymentContainer.Text = "-"
        '
        'lblEventTypePayment
        '
        Me.lblEventTypePayment.AutoSize = True
        Me.lblEventTypePayment.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventTypePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTypePayment.Location = New System.Drawing.Point(21, 112)
        Me.lblEventTypePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTypePayment.Name = "lblEventTypePayment"
        Me.lblEventTypePayment.Size = New System.Drawing.Size(93, 19)
        Me.lblEventTypePayment.TabIndex = 4
        Me.lblEventTypePayment.Text = "Event Type"
        '
        'lblEventPlacePaymentContainer
        '
        Me.lblEventPlacePaymentContainer.AutoSize = True
        Me.lblEventPlacePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblEventPlacePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventPlacePaymentContainer.Location = New System.Drawing.Point(229, 55)
        Me.lblEventPlacePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlacePaymentContainer.Name = "lblEventPlacePaymentContainer"
        Me.lblEventPlacePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblEventPlacePaymentContainer.TabIndex = 3
        Me.lblEventPlacePaymentContainer.Text = "-"
        '
        'lblEventPlacePayment
        '
        Me.lblEventPlacePayment.AutoSize = True
        Me.lblEventPlacePayment.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventPlacePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlacePayment.Location = New System.Drawing.Point(21, 55)
        Me.lblEventPlacePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlacePayment.Name = "lblEventPlacePayment"
        Me.lblEventPlacePayment.Size = New System.Drawing.Size(102, 19)
        Me.lblEventPlacePayment.TabIndex = 2
        Me.lblEventPlacePayment.Text = "Event Place"
        '
        'lblCustomerContainer
        '
        Me.lblCustomerContainer.AutoSize = True
        Me.lblCustomerContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblCustomerContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCustomerContainer.Location = New System.Drawing.Point(229, 15)
        Me.lblCustomerContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerContainer.Name = "lblCustomerContainer"
        Me.lblCustomerContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblCustomerContainer.TabIndex = 1
        Me.lblCustomerContainer.Text = "-"
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndAMPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndAMPM.FormattingEnabled = True
        Me.cbEndAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEndAMPM.Location = New System.Drawing.Point(369, 240)
        Me.cbEndAMPM.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndAMPM.Name = "cbEndAMPM"
        Me.cbEndAMPM.Size = New System.Drawing.Size(87, 33)
        Me.cbEndAMPM.TabIndex = 75
        '
        'cbEndMinutes
        '
        Me.cbEndMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndMinutes.FormattingEnabled = True
        Me.cbEndMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.Location = New System.Drawing.Point(273, 240)
        Me.cbEndMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndMinutes.Name = "cbEndMinutes"
        Me.cbEndMinutes.Size = New System.Drawing.Size(87, 33)
        Me.cbEndMinutes.TabIndex = 74
        '
        'cbEndHour
        '
        Me.cbEndHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndHour.FormattingEnabled = True
        Me.cbEndHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.Location = New System.Drawing.Point(177, 240)
        Me.cbEndHour.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEndHour.Name = "cbEndHour"
        Me.cbEndHour.Size = New System.Drawing.Size(87, 33)
        Me.cbEndHour.TabIndex = 73
        '
        'cbStartAMPM
        '
        Me.cbStartAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartAMPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartAMPM.FormattingEnabled = True
        Me.cbStartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStartAMPM.Location = New System.Drawing.Point(369, 206)
        Me.cbStartAMPM.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartAMPM.Name = "cbStartAMPM"
        Me.cbStartAMPM.Size = New System.Drawing.Size(87, 33)
        Me.cbStartAMPM.TabIndex = 72
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(273, 206)
        Me.cbStartMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(87, 33)
        Me.cbStartMinutes.TabIndex = 71
        '
        'cbStartHour
        '
        Me.cbStartHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartHour.FormattingEnabled = True
        Me.cbStartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.Location = New System.Drawing.Point(177, 206)
        Me.cbStartHour.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartHour.Name = "cbStartHour"
        Me.cbStartHour.Size = New System.Drawing.Size(87, 33)
        Me.cbStartHour.TabIndex = 70
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventType.Location = New System.Drawing.Point(8, 21)
        Me.lblEventType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(93, 19)
        Me.lblEventType.TabIndex = 69
        Me.lblEventType.Text = "Event Type"
        '
        'cbEventType
        '
        Me.cbEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEventType.ForeColor = System.Drawing.Color.Gray
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Location = New System.Drawing.Point(177, 11)
        Me.cbEventType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(279, 33)
        Me.cbEventType.TabIndex = 68
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumGuests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuests.Location = New System.Drawing.Point(8, 58)
        Me.lblNumGuests.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(146, 19)
        Me.lblNumGuests.TabIndex = 50
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'lblEventTimeEnd
        '
        Me.lblEventTimeEnd.AutoSize = True
        Me.lblEventTimeEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimeEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimeEnd.Location = New System.Drawing.Point(101, 247)
        Me.lblEventTimeEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeEnd.Name = "lblEventTimeEnd"
        Me.lblEventTimeEnd.Size = New System.Drawing.Size(37, 25)
        Me.lblEventTimeEnd.TabIndex = 67
        Me.lblEventTimeEnd.Text = "End"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Gray
        Me.txtTotalPrice.Location = New System.Drawing.Point(177, 408)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(300, 28)
        Me.txtTotalPrice.TabIndex = 49
        '
        'lblEventTimeStart
        '
        Me.lblEventTimeStart.AutoSize = True
        Me.lblEventTimeStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimeStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimeStart.Location = New System.Drawing.Point(101, 210)
        Me.lblEventTimeStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeStart.Name = "lblEventTimeStart"
        Me.lblEventTimeStart.Size = New System.Drawing.Size(44, 25)
        Me.lblEventTimeStart.TabIndex = 66
        Me.lblEventTimeStart.Text = "Start"
        '
        'lblEventDateStart
        '
        Me.lblEventDateStart.AutoSize = True
        Me.lblEventDateStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDateStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventDateStart.Location = New System.Drawing.Point(101, 139)
        Me.lblEventDateStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDateStart.Name = "lblEventDateStart"
        Me.lblEventDateStart.Size = New System.Drawing.Size(44, 25)
        Me.lblEventDateStart.TabIndex = 51
        Me.lblEventDateStart.Text = "Start"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(51, 188)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 19)
        Me.lblTime.TabIndex = 65
        Me.lblTime.Text = "Time"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblServicesAvailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblServicesAvailed.Location = New System.Drawing.Point(16, 316)
        Me.lblServicesAvailed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(134, 19)
        Me.lblServicesAvailed.TabIndex = 52
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblPriceBreakdown
        '
        Me.lblPriceBreakdown.AutoSize = True
        Me.lblPriceBreakdown.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPriceBreakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPriceBreakdown.Location = New System.Drawing.Point(473, 15)
        Me.lblPriceBreakdown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceBreakdown.Name = "lblPriceBreakdown"
        Me.lblPriceBreakdown.Size = New System.Drawing.Size(142, 19)
        Me.lblPriceBreakdown.TabIndex = 48
        Me.lblPriceBreakdown.Text = "Price Breakdown"
        '
        'lblTotalPricePaymentContainer
        '
        Me.lblTotalPricePaymentContainer.AutoSize = True
        Me.lblTotalPricePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblTotalPricePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalPricePaymentContainer.Location = New System.Drawing.Point(472, 268)
        Me.lblTotalPricePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPricePaymentContainer.Name = "lblTotalPricePaymentContainer"
        Me.lblTotalPricePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblTotalPricePaymentContainer.TabIndex = 15
        Me.lblTotalPricePaymentContainer.Text = "-"
        '
        'lblEventTimePaymentContainer
        '
        Me.lblEventTimePaymentContainer.AutoSize = True
        Me.lblEventTimePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblEventTimePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTimePaymentContainer.Location = New System.Drawing.Point(229, 276)
        Me.lblEventTimePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimePaymentContainer.Name = "lblEventTimePaymentContainer"
        Me.lblEventTimePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblEventTimePaymentContainer.TabIndex = 11
        Me.lblEventTimePaymentContainer.Text = "-"
        '
        'lblEventTimePayment
        '
        Me.lblEventTimePayment.AutoSize = True
        Me.lblEventTimePayment.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventTimePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimePayment.Location = New System.Drawing.Point(21, 276)
        Me.lblEventTimePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimePayment.Name = "lblEventTimePayment"
        Me.lblEventTimePayment.Size = New System.Drawing.Size(92, 19)
        Me.lblEventTimePayment.TabIndex = 10
        Me.lblEventTimePayment.Text = "Event Time"
        '
        'lblEventDatePaymentContainer
        '
        Me.lblEventDatePaymentContainer.AutoSize = True
        Me.lblEventDatePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblEventDatePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventDatePaymentContainer.Location = New System.Drawing.Point(229, 219)
        Me.lblEventDatePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDatePaymentContainer.Name = "lblEventDatePaymentContainer"
        Me.lblEventDatePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblEventDatePaymentContainer.TabIndex = 9
        Me.lblEventDatePaymentContainer.Text = "-"
        '
        'lblEventDatePayment
        '
        Me.lblEventDatePayment.AutoSize = True
        Me.lblEventDatePayment.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventDatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventDatePayment.Location = New System.Drawing.Point(21, 219)
        Me.lblEventDatePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDatePayment.Name = "lblEventDatePayment"
        Me.lblEventDatePayment.Size = New System.Drawing.Size(93, 19)
        Me.lblEventDatePayment.TabIndex = 8
        Me.lblEventDatePayment.Text = "Event Date"
        '
        'tpPaymentDetails
        '
        Me.tpPaymentDetails.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpPaymentDetails.Controls.Add(Me.btnPlaceBooking)
        Me.tpPaymentDetails.Controls.Add(Me.lblPriceBreakdown)
        Me.tpPaymentDetails.Controls.Add(Me.lblTotalPricePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTimePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTimePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventDatePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventDatePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblNumGuestsPaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblNumGuestsPayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTypePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventTypePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventPlacePaymentContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblEventPlacePayment)
        Me.tpPaymentDetails.Controls.Add(Me.lblCustomerContainer)
        Me.tpPaymentDetails.Controls.Add(Me.lblCustomerName)
        Me.tpPaymentDetails.Location = New System.Drawing.Point(4, 27)
        Me.tpPaymentDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPaymentDetails.Name = "tpPaymentDetails"
        Me.tpPaymentDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPaymentDetails.Size = New System.Drawing.Size(804, 472)
        Me.tpPaymentDetails.TabIndex = 2
        Me.tpPaymentDetails.Text = "Payment Details"
        Me.tpPaymentDetails.UseVisualStyleBackColor = True
        '
        'btnPlaceBooking
        '
        Me.btnPlaceBooking.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaceBooking.BackgroundImage = Global.epm1.My.Resources.Resources.BttnProceed
        Me.btnPlaceBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlaceBooking.FlatAppearance.BorderSize = 0
        Me.btnPlaceBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceBooking.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceBooking.Location = New System.Drawing.Point(625, 421)
        Me.btnPlaceBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaceBooking.Name = "btnPlaceBooking"
        Me.btnPlaceBooking.Size = New System.Drawing.Size(157, 35)
        Me.btnPlaceBooking.TabIndex = 62
        Me.btnPlaceBooking.UseVisualStyleBackColor = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(21, 15)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(85, 19)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(51, 116)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 19)
        Me.lblDate.TabIndex = 64
        Me.lblDate.Text = "Date"
        '
        'pnlEventInfo
        '
        Me.pnlEventInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlEventInfo.Controls.Add(Me.lblAv)
        Me.pnlEventInfo.Controls.Add(Me.lblAvailableDaysContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblPlaceIDContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblEventPlace)
        Me.pnlEventInfo.Controls.Add(Me.lblPlaceID)
        Me.pnlEventInfo.Controls.Add(Me.lblCapacity)
        Me.pnlEventInfo.Controls.Add(Me.lblHoursContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblPricePerDayContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblCapacityContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblPricePerDay)
        Me.pnlEventInfo.Controls.Add(Me.lblFeatures)
        Me.pnlEventInfo.Controls.Add(Me.lblAvailability)
        Me.pnlEventInfo.Controls.Add(Me.lblFeaturesContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblDescriptionContainer)
        Me.pnlEventInfo.Controls.Add(Me.lblDescription)
        Me.pnlEventInfo.Location = New System.Drawing.Point(35, 289)
        Me.pnlEventInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEventInfo.Name = "pnlEventInfo"
        Me.pnlEventInfo.Size = New System.Drawing.Size(366, 298)
        Me.pnlEventInfo.TabIndex = 96
        '
        'lblAv
        '
        Me.lblAv.AutoSize = True
        Me.lblAv.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAv.Location = New System.Drawing.Point(169, 88)
        Me.lblAv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAv.Name = "lblAv"
        Me.lblAv.Size = New System.Drawing.Size(84, 19)
        Me.lblAv.TabIndex = 39
        Me.lblAv.Text = "Available:"
        '
        'lblAvailableDaysContainer
        '
        Me.lblAvailableDaysContainer.Font = New System.Drawing.Font("Poppins", 6.5!)
        Me.lblAvailableDaysContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblAvailableDaysContainer.Location = New System.Drawing.Point(169, 107)
        Me.lblAvailableDaysContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableDaysContainer.Name = "lblAvailableDaysContainer"
        Me.lblAvailableDaysContainer.Size = New System.Drawing.Size(193, 50)
        Me.lblAvailableDaysContainer.TabIndex = 38
        Me.lblAvailableDaysContainer.Text = "-"
        '
        'lblPlaceIDContainer
        '
        Me.lblPlaceIDContainer.AutoSize = True
        Me.lblPlaceIDContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceIDContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblPlaceIDContainer.Location = New System.Drawing.Point(310, 9)
        Me.lblPlaceIDContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceIDContainer.Name = "lblPlaceIDContainer"
        Me.lblPlaceIDContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblPlaceIDContainer.TabIndex = 16
        Me.lblPlaceIDContainer.Text = "0"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Cinzel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlace.Location = New System.Drawing.Point(4, 9)
        Me.lblEventPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(144, 27)
        Me.lblEventPlace.TabIndex = 9
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.Gray
        Me.lblPlaceID.Location = New System.Drawing.Point(236, 9)
        Me.lblPlaceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(66, 25)
        Me.lblPlaceID.TabIndex = 8
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCapacity.Location = New System.Drawing.Point(4, 46)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(77, 19)
        Me.lblCapacity.TabIndex = 11
        Me.lblCapacity.Text = "Capacity"
        '
        'lblHoursContainer
        '
        Me.lblHoursContainer.AutoSize = True
        Me.lblHoursContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblHoursContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblHoursContainer.Location = New System.Drawing.Point(4, 115)
        Me.lblHoursContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoursContainer.Name = "lblHoursContainer"
        Me.lblHoursContainer.Size = New System.Drawing.Size(17, 21)
        Me.lblHoursContainer.TabIndex = 36
        Me.lblHoursContainer.Text = "-"
        '
        'lblPricePerDayContainer
        '
        Me.lblPricePerDayContainer.AutoSize = True
        Me.lblPricePerDayContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDayContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblPricePerDayContainer.Location = New System.Drawing.Point(175, 62)
        Me.lblPricePerDayContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDayContainer.Name = "lblPricePerDayContainer"
        Me.lblPricePerDayContainer.Size = New System.Drawing.Size(21, 25)
        Me.lblPricePerDayContainer.TabIndex = 18
        Me.lblPricePerDayContainer.Text = "0"
        '
        'lblCapacityContainer
        '
        Me.lblCapacityContainer.AutoSize = True
        Me.lblCapacityContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblCapacityContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCapacityContainer.Location = New System.Drawing.Point(4, 65)
        Me.lblCapacityContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacityContainer.Name = "lblCapacityContainer"
        Me.lblCapacityContainer.Size = New System.Drawing.Size(18, 21)
        Me.lblCapacityContainer.TabIndex = 17
        Me.lblCapacityContainer.Text = "0"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPricePerDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPricePerDay.Location = New System.Drawing.Point(169, 43)
        Me.lblPricePerDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(111, 19)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFeatures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFeatures.Location = New System.Drawing.Point(4, 137)
        Me.lblFeatures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(75, 19)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAvailability.Location = New System.Drawing.Point(4, 93)
        Me.lblAvailability.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(100, 19)
        Me.lblAvailability.TabIndex = 33
        Me.lblAvailability.Text = "Availability"
        '
        'lblFeaturesContainer
        '
        Me.lblFeaturesContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblFeaturesContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblFeaturesContainer.Location = New System.Drawing.Point(4, 164)
        Me.lblFeaturesContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeaturesContainer.Name = "lblFeaturesContainer"
        Me.lblFeaturesContainer.Size = New System.Drawing.Size(358, 35)
        Me.lblFeaturesContainer.TabIndex = 19
        Me.lblFeaturesContainer.Text = "-"
        '
        'lblDescriptionContainer
        '
        Me.lblDescriptionContainer.Font = New System.Drawing.Font("Poppins", 6.5!)
        Me.lblDescriptionContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblDescriptionContainer.Location = New System.Drawing.Point(4, 213)
        Me.lblDescriptionContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescriptionContainer.Name = "lblDescriptionContainer"
        Me.lblDescriptionContainer.Size = New System.Drawing.Size(358, 92)
        Me.lblDescriptionContainer.TabIndex = 32
        Me.lblDescriptionContainer.Text = "-"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(4, 196)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(103, 19)
        Me.lblDescription.TabIndex = 31
        Me.lblDescription.Text = "Description"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(257, 39)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 25)
        Me.btnNext.TabIndex = 94
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(225, 39)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 25)
        Me.btnBack.TabIndex = 93
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tcDetails
        '
        Me.tcDetails.Controls.Add(Me.tpBookingDetails)
        Me.tcDetails.Controls.Add(Me.tpCustomerDetails)
        Me.tcDetails.Controls.Add(Me.tpPaymentDetails)
        Me.tcDetails.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.tcDetails.Location = New System.Drawing.Point(419, 84)
        Me.tcDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tcDetails.Name = "tcDetails"
        Me.tcDetails.SelectedIndex = 0
        Me.tcDetails.Size = New System.Drawing.Size(812, 503)
        Me.tcDetails.TabIndex = 97
        '
        'tpBookingDetails
        '
        Me.tpBookingDetails.BackgroundImage = Global.epm1.My.Resources.Resources.BGplain
        Me.tpBookingDetails.Controls.Add(Me.Label1)
        Me.tpBookingDetails.Controls.Add(Me.lblDateWarning)
        Me.tpBookingDetails.Controls.Add(Me.lblBeyondAvailabilityFee)
        Me.tpBookingDetails.Controls.Add(Me.lblCapacityExceedanceFee)
        Me.tpBookingDetails.Controls.Add(Me.chkOutsideAvailableHours)
        Me.tpBookingDetails.Controls.Add(Me.cbSameDayEvent)
        Me.tpBookingDetails.Controls.Add(Me.cbEndAMPM)
        Me.tpBookingDetails.Controls.Add(Me.cbEndMinutes)
        Me.tpBookingDetails.Controls.Add(Me.cbEndHour)
        Me.tpBookingDetails.Controls.Add(Me.cbStartAMPM)
        Me.tpBookingDetails.Controls.Add(Me.cbStartMinutes)
        Me.tpBookingDetails.Controls.Add(Me.cbStartHour)
        Me.tpBookingDetails.Controls.Add(Me.lblEventType)
        Me.tpBookingDetails.Controls.Add(Me.cbEventType)
        Me.tpBookingDetails.Controls.Add(Me.lblNumGuests)
        Me.tpBookingDetails.Controls.Add(Me.lblEventTimeEnd)
        Me.tpBookingDetails.Controls.Add(Me.txtTotalPrice)
        Me.tpBookingDetails.Controls.Add(Me.lblEventTimeStart)
        Me.tpBookingDetails.Controls.Add(Me.lblEventDateStart)
        Me.tpBookingDetails.Controls.Add(Me.lblTime)
        Me.tpBookingDetails.Controls.Add(Me.lblServicesAvailed)
        Me.tpBookingDetails.Controls.Add(Me.lblDate)
        Me.tpBookingDetails.Controls.Add(Me.lblTotalPrice)
        Me.tpBookingDetails.Controls.Add(Me.dtpEventDateEnd)
        Me.tpBookingDetails.Controls.Add(Me.txtNumGuests)
        Me.tpBookingDetails.Controls.Add(Me.lblEnd)
        Me.tpBookingDetails.Controls.Add(Me.dtpEventDateStart)
        Me.tpBookingDetails.Controls.Add(Me.chkCatering)
        Me.tpBookingDetails.Controls.Add(Me.lblEventSchedule)
        Me.tpBookingDetails.Controls.Add(Me.chkClown)
        Me.tpBookingDetails.Controls.Add(Me.btBookingProceed)
        Me.tpBookingDetails.Controls.Add(Me.chkSinger)
        Me.tpBookingDetails.Controls.Add(Me.chkVideoke)
        Me.tpBookingDetails.Controls.Add(Me.chkDancer)
        Me.tpBookingDetails.Location = New System.Drawing.Point(4, 27)
        Me.tpBookingDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpBookingDetails.Name = "tpBookingDetails"
        Me.tpBookingDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpBookingDetails.Size = New System.Drawing.Size(804, 472)
        Me.tpBookingDetails.TabIndex = 0
        Me.tpBookingDetails.Text = "Booking Details"
        Me.tpBookingDetails.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalPrice.Location = New System.Drawing.Point(16, 412)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(97, 19)
        Me.lblTotalPrice.TabIndex = 53
        Me.lblTotalPrice.Text = "Total Price"
        '
        'dtpEventDateEnd
        '
        Me.dtpEventDateEnd.CalendarFont = New System.Drawing.Font("Poppins", 7.0!)
        Me.dtpEventDateEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDateEnd.Location = New System.Drawing.Point(177, 165)
        Me.dtpEventDateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEventDateEnd.Name = "dtpEventDateEnd"
        Me.dtpEventDateEnd.Size = New System.Drawing.Size(279, 28)
        Me.dtpEventDateEnd.TabIndex = 63
        '
        'txtNumGuests
        '
        Me.txtNumGuests.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuests.ForeColor = System.Drawing.Color.Gray
        Me.txtNumGuests.Location = New System.Drawing.Point(177, 58)
        Me.txtNumGuests.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(279, 28)
        Me.txtNumGuests.TabIndex = 48
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnd.Location = New System.Drawing.Point(101, 169)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(37, 25)
        Me.lblEnd.TabIndex = 62
        Me.lblEnd.Text = "End"
        '
        'dtpEventDateStart
        '
        Me.dtpEventDateStart.CalendarFont = New System.Drawing.Font("Poppins", 7.0!)
        Me.dtpEventDateStart.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpEventDateStart.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpEventDateStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDateStart.Location = New System.Drawing.Point(177, 133)
        Me.dtpEventDateStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEventDateStart.Name = "dtpEventDateStart"
        Me.dtpEventDateStart.Size = New System.Drawing.Size(279, 28)
        Me.dtpEventDateStart.TabIndex = 54
        '
        'chkCatering
        '
        Me.chkCatering.AutoSize = True
        Me.chkCatering.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCatering.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCatering.Location = New System.Drawing.Point(177, 316)
        Me.chkCatering.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatering.Name = "chkCatering"
        Me.chkCatering.Size = New System.Drawing.Size(218, 29)
        Me.chkCatering.TabIndex = 55
        Me.chkCatering.Text = "Catering (₱400 per guest)"
        Me.chkCatering.UseVisualStyleBackColor = True
        '
        'lblEventSchedule
        '
        Me.lblEventSchedule.AutoSize = True
        Me.lblEventSchedule.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventSchedule.Location = New System.Drawing.Point(8, 87)
        Me.lblEventSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventSchedule.Name = "lblEventSchedule"
        Me.lblEventSchedule.Size = New System.Drawing.Size(131, 19)
        Me.lblEventSchedule.TabIndex = 61
        Me.lblEventSchedule.Text = "Event Schedule"
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkClown.Location = New System.Drawing.Point(177, 343)
        Me.chkClown.Margin = New System.Windows.Forms.Padding(4)
        Me.chkClown.Name = "chkClown"
        Me.chkClown.Size = New System.Drawing.Size(200, 29)
        Me.chkClown.TabIndex = 56
        Me.chkClown.Text = "Clown (₱200 per guest)"
        Me.chkClown.UseVisualStyleBackColor = True
        '
        'btBookingProceed
        '
        Me.btBookingProceed.BackColor = System.Drawing.Color.Transparent
        Me.btBookingProceed.BackgroundImage = Global.epm1.My.Resources.Resources.BttnProceed
        Me.btBookingProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBookingProceed.FlatAppearance.BorderSize = 0
        Me.btBookingProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBookingProceed.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBookingProceed.Location = New System.Drawing.Point(625, 421)
        Me.btBookingProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btBookingProceed.Name = "btBookingProceed"
        Me.btBookingProceed.Size = New System.Drawing.Size(157, 35)
        Me.btBookingProceed.TabIndex = 60
        Me.btBookingProceed.UseVisualStyleBackColor = False
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkSinger.Location = New System.Drawing.Point(177, 371)
        Me.chkSinger.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSinger.Name = "chkSinger"
        Me.chkSinger.Size = New System.Drawing.Size(196, 29)
        Me.chkSinger.TabIndex = 57
        Me.chkSinger.Text = "Singer (₱140 per guest)"
        Me.chkSinger.UseVisualStyleBackColor = True
        '
        'chkVideoke
        '
        Me.chkVideoke.AutoSize = True
        Me.chkVideoke.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVideoke.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkVideoke.Location = New System.Drawing.Point(405, 371)
        Me.chkVideoke.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVideoke.Name = "chkVideoke"
        Me.chkVideoke.Size = New System.Drawing.Size(203, 29)
        Me.chkVideoke.TabIndex = 59
        Me.chkVideoke.Text = "Videoke (₱20 per guest)"
        Me.chkVideoke.UseVisualStyleBackColor = True
        '
        'chkDancer
        '
        Me.chkDancer.AutoSize = True
        Me.chkDancer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDancer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkDancer.Location = New System.Drawing.Point(405, 345)
        Me.chkDancer.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(203, 29)
        Me.chkDancer.TabIndex = 58
        Me.chkDancer.Text = "Dancer (₱140 per guest)"
        Me.chkDancer.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.BackgroundImage = Global.epm1.My.Resources.Resources.BttnChinomsOrBackToMain
        Me.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMain.FlatAppearance.BorderSize = 0
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Location = New System.Drawing.Point(3, 24)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(225, 55)
        Me.btnMain.TabIndex = 98
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BgBooking_updated_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 617)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.pnlEventInfo)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tcDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBooking"
        Me.tpCustomerDetails.ResumeLayout(False)
        Me.tpCustomerDetails.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPaymentDetails.ResumeLayout(False)
        Me.tpPaymentDetails.PerformLayout()
        Me.pnlEventInfo.ResumeLayout(False)
        Me.pnlEventInfo.PerformLayout()
        Me.tcDetails.ResumeLayout(False)
        Me.tpBookingDetails.ResumeLayout(False)
        Me.tpBookingDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpCustomerDetails As TabPage
    Friend WithEvents lblName As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateWarning As Label
    Friend WithEvents lblBeyondAvailabilityFee As Label
    Friend WithEvents lblCapacityExceedanceFee As Label
    Friend WithEvents chkOutsideAvailableHours As CheckBox
    Friend WithEvents cbSameDayEvent As CheckBox
    Friend WithEvents pb As PictureBox
    Friend WithEvents lblNumGuestsPaymentContainer As Label
    Friend WithEvents lblNumGuestsPayment As Label
    Friend WithEvents lblEventTypePaymentContainer As Label
    Friend WithEvents lblEventTypePayment As Label
    Friend WithEvents lblEventPlacePaymentContainer As Label
    Friend WithEvents lblEventPlacePayment As Label
    Friend WithEvents lblCustomerContainer As Label
    Friend WithEvents cbEndAMPM As ComboBox
    Friend WithEvents cbEndMinutes As ComboBox
    Friend WithEvents cbEndHour As ComboBox
    Friend WithEvents cbStartAMPM As ComboBox
    Friend WithEvents cbStartMinutes As ComboBox
    Friend WithEvents cbStartHour As ComboBox
    Friend WithEvents lblEventType As Label
    Friend WithEvents cbEventType As ComboBox
    Friend WithEvents lblNumGuests As Label
    Friend WithEvents lblEventTimeEnd As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents lblEventTimeStart As Label
    Friend WithEvents lblEventDateStart As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblServicesAvailed As Label
    Friend WithEvents lblPriceBreakdown As Label
    Friend WithEvents lblTotalPricePaymentContainer As Label
    Friend WithEvents lblEventTimePaymentContainer As Label
    Friend WithEvents lblEventTimePayment As Label
    Friend WithEvents lblEventDatePaymentContainer As Label
    Friend WithEvents lblEventDatePayment As Label
    Friend WithEvents tpPaymentDetails As TabPage
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pnlEventInfo As Panel
    Friend WithEvents lblAvailableDaysContainer As Label
    Friend WithEvents lblPlaceIDContainer As Label
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents lblPlaceID As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblHoursContainer As Label
    Friend WithEvents lblPricePerDayContainer As Label
    Friend WithEvents lblCapacityContainer As Label
    Friend WithEvents lblPricePerDay As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblFeaturesContainer As Label
    Friend WithEvents lblDescriptionContainer As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents tcDetails As TabControl
    Friend WithEvents tpBookingDetails As TabPage
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents dtpEventDateEnd As DateTimePicker
    Friend WithEvents txtNumGuests As TextBox
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpEventDateStart As DateTimePicker
    Friend WithEvents chkCatering As CheckBox
    Friend WithEvents lblEventSchedule As Label
    Friend WithEvents chkClown As CheckBox
    Friend WithEvents btBookingProceed As Button
    Friend WithEvents chkSinger As CheckBox
    Friend WithEvents chkVideoke As CheckBox
    Friend WithEvents chkDancer As CheckBox
    Friend WithEvents btnCustomerProceed As Button
    Friend WithEvents btnPlaceBooking As Button
    Friend WithEvents lblAv As Label
    Friend WithEvents btnMain As Button
End Class
