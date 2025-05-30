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
        Me.tpCustomerDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpCustomerDetails.Name = "tpCustomerDetails"
        Me.tpCustomerDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomerDetails.Size = New System.Drawing.Size(601, 383)
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
        Me.btnCustomerProceed.Location = New System.Drawing.Point(469, 342)
        Me.btnCustomerProceed.Name = "btnCustomerProceed"
        Me.btnCustomerProceed.Size = New System.Drawing.Size(118, 28)
        Me.btnCustomerProceed.TabIndex = 61
        Me.btnCustomerProceed.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(6, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarMonthBackground = System.Drawing.Color.FloralWhite
        Me.dtpBirthday.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Location = New System.Drawing.Point(104, 49)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(454, 24)
        Me.dtpBirthday.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.FloralWhite
        Me.txtCustomerName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(104, 19)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(454, 24)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(6, 50)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(65, 13)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.BackColor = System.Drawing.Color.FloralWhite
        Me.cmbSex.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(104, 109)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(454, 27)
        Me.cmbSex.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(6, 146)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(56, 13)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(6, 115)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(26, 13)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FloralWhite
        Me.txtAddress.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(104, 142)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(454, 24)
        Me.txtAddress.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(6, 83)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FloralWhite
        Me.txtAge.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(104, 79)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(454, 24)
        Me.txtAge.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 81
        '
        'lblDateWarning
        '
        Me.lblDateWarning.AutoSize = True
        Me.lblDateWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblDateWarning.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDateWarning.Location = New System.Drawing.Point(389, 113)
        Me.lblDateWarning.Name = "lblDateWarning"
        Me.lblDateWarning.Size = New System.Drawing.Size(189, 19)
        Me.lblDateWarning.TabIndex = 80
        Me.lblDateWarning.Text = "The selected date is unavailable."
        '
        'lblBeyondAvailabilityFee
        '
        Me.lblBeyondAvailabilityFee.AutoSize = True
        Me.lblBeyondAvailabilityFee.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeyondAvailabilityFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBeyondAvailabilityFee.Location = New System.Drawing.Point(349, 171)
        Me.lblBeyondAvailabilityFee.Name = "lblBeyondAvailabilityFee"
        Me.lblBeyondAvailabilityFee.Size = New System.Drawing.Size(138, 38)
        Me.lblBeyondAvailabilityFee.TabIndex = 79
        Me.lblBeyondAvailabilityFee.Text = "Beyond Availability Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱17 per minute)"
        '
        'lblCapacityExceedanceFee
        '
        Me.lblCapacityExceedanceFee.AutoSize = True
        Me.lblCapacityExceedanceFee.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityExceedanceFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCapacityExceedanceFee.Location = New System.Drawing.Point(353, 47)
        Me.lblCapacityExceedanceFee.Name = "lblCapacityExceedanceFee"
        Me.lblCapacityExceedanceFee.Size = New System.Drawing.Size(154, 38)
        Me.lblCapacityExceedanceFee.TabIndex = 78
        Me.lblCapacityExceedanceFee.Text = "Capacity Exceedance Fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(₱100 per additional)"
        '
        'chkOutsideAvailableHours
        '
        Me.chkOutsideAvailableHours.AutoSize = True
        Me.chkOutsideAvailableHours.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOutsideAvailableHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkOutsideAvailableHours.Location = New System.Drawing.Point(353, 211)
        Me.chkOutsideAvailableHours.Name = "chkOutsideAvailableHours"
        Me.chkOutsideAvailableHours.Size = New System.Drawing.Size(186, 42)
        Me.chkOutsideAvailableHours.TabIndex = 77
        Me.chkOutsideAvailableHours.Text = "Book outside available hours" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(+ extra fee)"
        Me.chkOutsideAvailableHours.UseVisualStyleBackColor = True
        '
        'cbSameDayEvent
        '
        Me.cbSameDayEvent.AutoSize = True
        Me.cbSameDayEvent.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSameDayEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbSameDayEvent.Location = New System.Drawing.Point(244, 80)
        Me.cbSameDayEvent.Name = "cbSameDayEvent"
        Me.cbSameDayEvent.Size = New System.Drawing.Size(116, 23)
        Me.cbSameDayEvent.TabIndex = 76
        Me.cbSameDayEvent.Text = "Same Day Event"
        Me.cbSameDayEvent.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(26, 98)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(274, 137)
        Me.pb.TabIndex = 95
        Me.pb.TabStop = False
        '
        'lblNumGuestsPaymentContainer
        '
        Me.lblNumGuestsPaymentContainer.AutoSize = True
        Me.lblNumGuestsPaymentContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuestsPaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblNumGuestsPaymentContainer.Location = New System.Drawing.Point(169, 122)
        Me.lblNumGuestsPaymentContainer.Name = "lblNumGuestsPaymentContainer"
        Me.lblNumGuestsPaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblNumGuestsPaymentContainer.TabIndex = 7
        Me.lblNumGuestsPaymentContainer.Text = "-"
        '
        'lblNumGuestsPayment
        '
        Me.lblNumGuestsPayment.AutoSize = True
        Me.lblNumGuestsPayment.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuestsPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuestsPayment.Location = New System.Drawing.Point(15, 122)
        Me.lblNumGuestsPayment.Name = "lblNumGuestsPayment"
        Me.lblNumGuestsPayment.Size = New System.Drawing.Size(135, 16)
        Me.lblNumGuestsPayment.TabIndex = 6
        Me.lblNumGuestsPayment.Text = "Number of Guests"
        '
        'lblEventTypePaymentContainer
        '
        Me.lblEventTypePaymentContainer.AutoSize = True
        Me.lblEventTypePaymentContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTypePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTypePaymentContainer.Location = New System.Drawing.Point(169, 84)
        Me.lblEventTypePaymentContainer.Name = "lblEventTypePaymentContainer"
        Me.lblEventTypePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventTypePaymentContainer.TabIndex = 5
        Me.lblEventTypePaymentContainer.Text = "-"
        '
        'lblEventTypePayment
        '
        Me.lblEventTypePayment.AutoSize = True
        Me.lblEventTypePayment.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTypePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTypePayment.Location = New System.Drawing.Point(15, 84)
        Me.lblEventTypePayment.Name = "lblEventTypePayment"
        Me.lblEventTypePayment.Size = New System.Drawing.Size(85, 16)
        Me.lblEventTypePayment.TabIndex = 4
        Me.lblEventTypePayment.Text = "Event Type"
        '
        'lblEventPlacePaymentContainer
        '
        Me.lblEventPlacePaymentContainer.AutoSize = True
        Me.lblEventPlacePaymentContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlacePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventPlacePaymentContainer.Location = New System.Drawing.Point(169, 46)
        Me.lblEventPlacePaymentContainer.Name = "lblEventPlacePaymentContainer"
        Me.lblEventPlacePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventPlacePaymentContainer.TabIndex = 3
        Me.lblEventPlacePaymentContainer.Text = "-"
        '
        'lblEventPlacePayment
        '
        Me.lblEventPlacePayment.AutoSize = True
        Me.lblEventPlacePayment.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlacePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlacePayment.Location = New System.Drawing.Point(15, 46)
        Me.lblEventPlacePayment.Name = "lblEventPlacePayment"
        Me.lblEventPlacePayment.Size = New System.Drawing.Size(94, 16)
        Me.lblEventPlacePayment.TabIndex = 2
        Me.lblEventPlacePayment.Text = "Event Place"
        '
        'lblCustomerContainer
        '
        Me.lblCustomerContainer.AutoSize = True
        Me.lblCustomerContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCustomerContainer.Location = New System.Drawing.Point(169, 8)
        Me.lblCustomerContainer.Name = "lblCustomerContainer"
        Me.lblCustomerContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblCustomerContainer.TabIndex = 1
        Me.lblCustomerContainer.Text = "-"
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbEndAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndAMPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndAMPM.FormattingEnabled = True
        Me.cbEndAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbEndAMPM.Location = New System.Drawing.Point(277, 195)
        Me.cbEndAMPM.Name = "cbEndAMPM"
        Me.cbEndAMPM.Size = New System.Drawing.Size(66, 27)
        Me.cbEndAMPM.TabIndex = 75
        '
        'cbEndMinutes
        '
        Me.cbEndMinutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbEndMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndMinutes.FormattingEnabled = True
        Me.cbEndMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.Location = New System.Drawing.Point(205, 195)
        Me.cbEndMinutes.Name = "cbEndMinutes"
        Me.cbEndMinutes.Size = New System.Drawing.Size(66, 27)
        Me.cbEndMinutes.TabIndex = 74
        '
        'cbEndHour
        '
        Me.cbEndHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbEndHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEndHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbEndHour.FormattingEnabled = True
        Me.cbEndHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.Location = New System.Drawing.Point(133, 195)
        Me.cbEndHour.Name = "cbEndHour"
        Me.cbEndHour.Size = New System.Drawing.Size(66, 27)
        Me.cbEndHour.TabIndex = 73
        '
        'cbStartAMPM
        '
        Me.cbStartAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbStartAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartAMPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartAMPM.FormattingEnabled = True
        Me.cbStartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbStartAMPM.Location = New System.Drawing.Point(277, 167)
        Me.cbStartAMPM.Name = "cbStartAMPM"
        Me.cbStartAMPM.Size = New System.Drawing.Size(66, 27)
        Me.cbStartAMPM.TabIndex = 72
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbStartMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(205, 167)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(66, 27)
        Me.cbStartMinutes.TabIndex = 71
        '
        'cbStartHour
        '
        Me.cbStartHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cbStartHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbStartHour.FormattingEnabled = True
        Me.cbStartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.Location = New System.Drawing.Point(133, 167)
        Me.cbStartHour.Name = "cbStartHour"
        Me.cbStartHour.Size = New System.Drawing.Size(66, 27)
        Me.cbStartHour.TabIndex = 70
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventType.Location = New System.Drawing.Point(6, 17)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(73, 13)
        Me.lblEventType.TabIndex = 69
        Me.lblEventType.Text = "Event Type"
        '
        'cbEventType
        '
        Me.cbEventType.BackColor = System.Drawing.Color.FloralWhite
        Me.cbEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEventType.ForeColor = System.Drawing.Color.Gray
        Me.cbEventType.FormattingEnabled = True
        Me.cbEventType.Location = New System.Drawing.Point(133, 9)
        Me.cbEventType.Name = "cbEventType"
        Me.cbEventType.Size = New System.Drawing.Size(210, 27)
        Me.cbEventType.TabIndex = 68
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumGuests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuests.Location = New System.Drawing.Point(6, 47)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(116, 13)
        Me.lblNumGuests.TabIndex = 50
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'lblEventTimeEnd
        '
        Me.lblEventTimeEnd.AutoSize = True
        Me.lblEventTimeEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimeEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimeEnd.Location = New System.Drawing.Point(76, 201)
        Me.lblEventTimeEnd.Name = "lblEventTimeEnd"
        Me.lblEventTimeEnd.Size = New System.Drawing.Size(29, 19)
        Me.lblEventTimeEnd.TabIndex = 67
        Me.lblEventTimeEnd.Text = "End"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtTotalPrice.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Gray
        Me.txtTotalPrice.Location = New System.Drawing.Point(133, 332)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(226, 24)
        Me.txtTotalPrice.TabIndex = 49
        '
        'lblEventTimeStart
        '
        Me.lblEventTimeStart.AutoSize = True
        Me.lblEventTimeStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimeStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimeStart.Location = New System.Drawing.Point(76, 171)
        Me.lblEventTimeStart.Name = "lblEventTimeStart"
        Me.lblEventTimeStart.Size = New System.Drawing.Size(34, 19)
        Me.lblEventTimeStart.TabIndex = 66
        Me.lblEventTimeStart.Text = "Start"
        '
        'lblEventDateStart
        '
        Me.lblEventDateStart.AutoSize = True
        Me.lblEventDateStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDateStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventDateStart.Location = New System.Drawing.Point(76, 113)
        Me.lblEventDateStart.Name = "lblEventDateStart"
        Me.lblEventDateStart.Size = New System.Drawing.Size(34, 19)
        Me.lblEventDateStart.TabIndex = 51
        Me.lblEventDateStart.Text = "Start"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(38, 153)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 13)
        Me.lblTime.TabIndex = 65
        Me.lblTime.Text = "Time"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblServicesAvailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblServicesAvailed.Location = New System.Drawing.Point(12, 257)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(109, 13)
        Me.lblServicesAvailed.TabIndex = 52
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblPriceBreakdown
        '
        Me.lblPriceBreakdown.AutoSize = True
        Me.lblPriceBreakdown.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceBreakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPriceBreakdown.Location = New System.Drawing.Point(17, 234)
        Me.lblPriceBreakdown.Name = "lblPriceBreakdown"
        Me.lblPriceBreakdown.Size = New System.Drawing.Size(118, 23)
        Me.lblPriceBreakdown.TabIndex = 48
        Me.lblPriceBreakdown.Text = "Price Breakdown"
        '
        'lblTotalPricePaymentContainer
        '
        Me.lblTotalPricePaymentContainer.AutoSize = True
        Me.lblTotalPricePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblTotalPricePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalPricePaymentContainer.Location = New System.Drawing.Point(354, 218)
        Me.lblTotalPricePaymentContainer.Name = "lblTotalPricePaymentContainer"
        Me.lblTotalPricePaymentContainer.Size = New System.Drawing.Size(15, 19)
        Me.lblTotalPricePaymentContainer.TabIndex = 15
        Me.lblTotalPricePaymentContainer.Text = "-"
        '
        'lblEventTimePaymentContainer
        '
        Me.lblEventTimePaymentContainer.AutoSize = True
        Me.lblEventTimePaymentContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTimePaymentContainer.Location = New System.Drawing.Point(169, 198)
        Me.lblEventTimePaymentContainer.Name = "lblEventTimePaymentContainer"
        Me.lblEventTimePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventTimePaymentContainer.TabIndex = 11
        Me.lblEventTimePaymentContainer.Text = "-"
        '
        'lblEventTimePayment
        '
        Me.lblEventTimePayment.AutoSize = True
        Me.lblEventTimePayment.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimePayment.Location = New System.Drawing.Point(15, 198)
        Me.lblEventTimePayment.Name = "lblEventTimePayment"
        Me.lblEventTimePayment.Size = New System.Drawing.Size(85, 16)
        Me.lblEventTimePayment.TabIndex = 10
        Me.lblEventTimePayment.Text = "Event Time"
        '
        'lblEventDatePaymentContainer
        '
        Me.lblEventDatePaymentContainer.AutoSize = True
        Me.lblEventDatePaymentContainer.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDatePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblEventDatePaymentContainer.Location = New System.Drawing.Point(169, 160)
        Me.lblEventDatePaymentContainer.Name = "lblEventDatePaymentContainer"
        Me.lblEventDatePaymentContainer.Size = New System.Drawing.Size(17, 23)
        Me.lblEventDatePaymentContainer.TabIndex = 9
        Me.lblEventDatePaymentContainer.Text = "-"
        '
        'lblEventDatePayment
        '
        Me.lblEventDatePayment.AutoSize = True
        Me.lblEventDatePayment.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventDatePayment.Location = New System.Drawing.Point(15, 160)
        Me.lblEventDatePayment.Name = "lblEventDatePayment"
        Me.lblEventDatePayment.Size = New System.Drawing.Size(88, 16)
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
        Me.tpPaymentDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpPaymentDetails.Name = "tpPaymentDetails"
        Me.tpPaymentDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPaymentDetails.Size = New System.Drawing.Size(601, 383)
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
        Me.btnPlaceBooking.Location = New System.Drawing.Point(469, 342)
        Me.btnPlaceBooking.Name = "btnPlaceBooking"
        Me.btnPlaceBooking.Size = New System.Drawing.Size(118, 28)
        Me.btnPlaceBooking.TabIndex = 62
        Me.btnPlaceBooking.UseVisualStyleBackColor = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Cinzel", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 8)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(78, 16)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(38, 94)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 13)
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
        Me.pnlEventInfo.Location = New System.Drawing.Point(26, 235)
        Me.pnlEventInfo.Name = "pnlEventInfo"
        Me.pnlEventInfo.Size = New System.Drawing.Size(274, 242)
        Me.pnlEventInfo.TabIndex = 96
        '
        'lblAv
        '
        Me.lblAv.AutoSize = True
        Me.lblAv.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAv.Location = New System.Drawing.Point(127, 72)
        Me.lblAv.Name = "lblAv"
        Me.lblAv.Size = New System.Drawing.Size(70, 13)
        Me.lblAv.TabIndex = 39
        Me.lblAv.Text = "Available:"
        '
        'lblAvailableDaysContainer
        '
        Me.lblAvailableDaysContainer.Font = New System.Drawing.Font("Poppins", 6.5!)
        Me.lblAvailableDaysContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblAvailableDaysContainer.Location = New System.Drawing.Point(127, 87)
        Me.lblAvailableDaysContainer.Name = "lblAvailableDaysContainer"
        Me.lblAvailableDaysContainer.Size = New System.Drawing.Size(145, 41)
        Me.lblAvailableDaysContainer.TabIndex = 38
        Me.lblAvailableDaysContainer.Text = "-"
        '
        'lblPlaceIDContainer
        '
        Me.lblPlaceIDContainer.AutoSize = True
        Me.lblPlaceIDContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceIDContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblPlaceIDContainer.Location = New System.Drawing.Point(244, 11)
        Me.lblPlaceIDContainer.Name = "lblPlaceIDContainer"
        Me.lblPlaceIDContainer.Size = New System.Drawing.Size(16, 19)
        Me.lblPlaceIDContainer.TabIndex = 16
        Me.lblPlaceIDContainer.Text = "0"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Cinzel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlace.Location = New System.Drawing.Point(3, 7)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(117, 19)
        Me.lblEventPlace.TabIndex = 9
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.DimGray
        Me.lblPlaceID.Location = New System.Drawing.Point(189, 11)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(53, 19)
        Me.lblPlaceID.TabIndex = 8
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCapacity.Location = New System.Drawing.Point(3, 37)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(64, 13)
        Me.lblCapacity.TabIndex = 11
        Me.lblCapacity.Text = "Capacity"
        '
        'lblHoursContainer
        '
        Me.lblHoursContainer.AutoSize = True
        Me.lblHoursContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblHoursContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblHoursContainer.Location = New System.Drawing.Point(3, 93)
        Me.lblHoursContainer.Name = "lblHoursContainer"
        Me.lblHoursContainer.Size = New System.Drawing.Size(14, 17)
        Me.lblHoursContainer.TabIndex = 36
        Me.lblHoursContainer.Text = "-"
        '
        'lblPricePerDayContainer
        '
        Me.lblPricePerDayContainer.AutoSize = True
        Me.lblPricePerDayContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDayContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblPricePerDayContainer.Location = New System.Drawing.Point(131, 50)
        Me.lblPricePerDayContainer.Name = "lblPricePerDayContainer"
        Me.lblPricePerDayContainer.Size = New System.Drawing.Size(16, 19)
        Me.lblPricePerDayContainer.TabIndex = 18
        Me.lblPricePerDayContainer.Text = "0"
        '
        'lblCapacityContainer
        '
        Me.lblCapacityContainer.AutoSize = True
        Me.lblCapacityContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblCapacityContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblCapacityContainer.Location = New System.Drawing.Point(3, 53)
        Me.lblCapacityContainer.Name = "lblCapacityContainer"
        Me.lblCapacityContainer.Size = New System.Drawing.Size(14, 17)
        Me.lblCapacityContainer.TabIndex = 17
        Me.lblCapacityContainer.Text = "0"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPricePerDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPricePerDay.Location = New System.Drawing.Point(127, 35)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(88, 13)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFeatures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFeatures.Location = New System.Drawing.Point(3, 111)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(60, 13)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAvailability.Location = New System.Drawing.Point(3, 76)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(84, 13)
        Me.lblAvailability.TabIndex = 33
        Me.lblAvailability.Text = "Availability"
        '
        'lblFeaturesContainer
        '
        Me.lblFeaturesContainer.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblFeaturesContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblFeaturesContainer.Location = New System.Drawing.Point(3, 133)
        Me.lblFeaturesContainer.Name = "lblFeaturesContainer"
        Me.lblFeaturesContainer.Size = New System.Drawing.Size(268, 28)
        Me.lblFeaturesContainer.TabIndex = 19
        Me.lblFeaturesContainer.Text = "-"
        '
        'lblDescriptionContainer
        '
        Me.lblDescriptionContainer.Font = New System.Drawing.Font("Poppins", 6.5!)
        Me.lblDescriptionContainer.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescriptionContainer.Location = New System.Drawing.Point(3, 173)
        Me.lblDescriptionContainer.Name = "lblDescriptionContainer"
        Me.lblDescriptionContainer.Size = New System.Drawing.Size(268, 75)
        Me.lblDescriptionContainer.TabIndex = 32
        Me.lblDescriptionContainer.Text = "-"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(3, 159)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(81, 13)
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
        Me.btnNext.Location = New System.Drawing.Point(193, 32)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(18, 20)
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
        Me.btnBack.Location = New System.Drawing.Point(169, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(18, 20)
        Me.btnBack.TabIndex = 93
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tcDetails
        '
        Me.tcDetails.Controls.Add(Me.tpBookingDetails)
        Me.tcDetails.Controls.Add(Me.tpCustomerDetails)
        Me.tcDetails.Controls.Add(Me.tpPaymentDetails)
        Me.tcDetails.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetails.Location = New System.Drawing.Point(314, 68)
        Me.tcDetails.Name = "tcDetails"
        Me.tcDetails.SelectedIndex = 0
        Me.tcDetails.Size = New System.Drawing.Size(609, 409)
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
        Me.tpBookingDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpBookingDetails.Name = "tpBookingDetails"
        Me.tpBookingDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookingDetails.Size = New System.Drawing.Size(601, 383)
        Me.tpBookingDetails.TabIndex = 0
        Me.tpBookingDetails.Text = "Booking Details"
        Me.tpBookingDetails.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalPrice.Location = New System.Drawing.Point(12, 335)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalPrice.TabIndex = 53
        Me.lblTotalPrice.Text = "Total Price"
        '
        'dtpEventDateEnd
        '
        Me.dtpEventDateEnd.CalendarFont = New System.Drawing.Font("Poppins", 7.0!)
        Me.dtpEventDateEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpEventDateEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDateEnd.Location = New System.Drawing.Point(133, 134)
        Me.dtpEventDateEnd.Name = "dtpEventDateEnd"
        Me.dtpEventDateEnd.Size = New System.Drawing.Size(210, 24)
        Me.dtpEventDateEnd.TabIndex = 63
        '
        'txtNumGuests
        '
        Me.txtNumGuests.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtNumGuests.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuests.ForeColor = System.Drawing.Color.Gray
        Me.txtNumGuests.Location = New System.Drawing.Point(133, 47)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(210, 24)
        Me.txtNumGuests.TabIndex = 48
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnd.Location = New System.Drawing.Point(76, 137)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(29, 19)
        Me.lblEnd.TabIndex = 62
        Me.lblEnd.Text = "End"
        '
        'dtpEventDateStart
        '
        Me.dtpEventDateStart.CalendarFont = New System.Drawing.Font("Poppins", 7.0!)
        Me.dtpEventDateStart.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpEventDateStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpEventDateStart.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpEventDateStart.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDateStart.Location = New System.Drawing.Point(133, 108)
        Me.dtpEventDateStart.Name = "dtpEventDateStart"
        Me.dtpEventDateStart.Size = New System.Drawing.Size(210, 24)
        Me.dtpEventDateStart.TabIndex = 54
        '
        'chkCatering
        '
        Me.chkCatering.AutoSize = True
        Me.chkCatering.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCatering.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCatering.Location = New System.Drawing.Point(133, 257)
        Me.chkCatering.Name = "chkCatering"
        Me.chkCatering.Size = New System.Drawing.Size(172, 23)
        Me.chkCatering.TabIndex = 55
        Me.chkCatering.Text = "Catering (₱400 per guest)"
        Me.chkCatering.UseVisualStyleBackColor = True
        '
        'lblEventSchedule
        '
        Me.lblEventSchedule.AutoSize = True
        Me.lblEventSchedule.Font = New System.Drawing.Font("Cinzel", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventSchedule.Location = New System.Drawing.Point(6, 71)
        Me.lblEventSchedule.Name = "lblEventSchedule"
        Me.lblEventSchedule.Size = New System.Drawing.Size(105, 13)
        Me.lblEventSchedule.TabIndex = 61
        Me.lblEventSchedule.Text = "Event Schedule"
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkClown.Location = New System.Drawing.Point(133, 279)
        Me.chkClown.Name = "chkClown"
        Me.chkClown.Size = New System.Drawing.Size(158, 23)
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
        Me.btBookingProceed.Location = New System.Drawing.Point(469, 342)
        Me.btBookingProceed.Name = "btBookingProceed"
        Me.btBookingProceed.Size = New System.Drawing.Size(118, 28)
        Me.btBookingProceed.TabIndex = 60
        Me.btBookingProceed.UseVisualStyleBackColor = False
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkSinger.Location = New System.Drawing.Point(133, 301)
        Me.chkSinger.Name = "chkSinger"
        Me.chkSinger.Size = New System.Drawing.Size(156, 23)
        Me.chkSinger.TabIndex = 57
        Me.chkSinger.Text = "Singer (₱140 per guest)"
        Me.chkSinger.UseVisualStyleBackColor = True
        '
        'chkVideoke
        '
        Me.chkVideoke.AutoSize = True
        Me.chkVideoke.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVideoke.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkVideoke.Location = New System.Drawing.Point(304, 301)
        Me.chkVideoke.Name = "chkVideoke"
        Me.chkVideoke.Size = New System.Drawing.Size(161, 23)
        Me.chkVideoke.TabIndex = 59
        Me.chkVideoke.Text = "Videoke (₱20 per guest)"
        Me.chkVideoke.UseVisualStyleBackColor = True
        '
        'chkDancer
        '
        Me.chkDancer.AutoSize = True
        Me.chkDancer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDancer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkDancer.Location = New System.Drawing.Point(304, 280)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(162, 23)
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
        Me.btnMain.Location = New System.Drawing.Point(2, 20)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(169, 45)
        Me.btnMain.TabIndex = 98
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BgBooking_updated_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.pnlEventInfo)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tcDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents lblAv As Label
    Friend WithEvents btnMain As Button
    Friend WithEvents btnPlaceBooking As Button
End Class
