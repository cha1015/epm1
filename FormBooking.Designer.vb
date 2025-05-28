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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.tcDetails = New System.Windows.Forms.TabControl()
        Me.tpBookingDetails = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateWarning = New System.Windows.Forms.Label()
        Me.lblBeyondAvailabilityFee = New System.Windows.Forms.Label()
        Me.lblCapacityExceedanceFee = New System.Windows.Forms.Label()
        Me.chkOutsideAvailableHours = New System.Windows.Forms.CheckBox()
        Me.cbSameDayEvent = New System.Windows.Forms.CheckBox()
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
        Me.lblDate = New System.Windows.Forms.Label()
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
        Me.tpPaymentDetails = New System.Windows.Forms.TabPage()
        Me.btnPlaceBooking = New System.Windows.Forms.Button()
        Me.lblPriceBreakdown = New System.Windows.Forms.Label()
        Me.lblTotalPricePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTimePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTimePayment = New System.Windows.Forms.Label()
        Me.lblEventDatePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventDatePayment = New System.Windows.Forms.Label()
        Me.lblNumGuestsPaymentContainer = New System.Windows.Forms.Label()
        Me.lblNumGuestsPayment = New System.Windows.Forms.Label()
        Me.lblEventTypePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventTypePayment = New System.Windows.Forms.Label()
        Me.lblEventPlacePaymentContainer = New System.Windows.Forms.Label()
        Me.lblEventPlacePayment = New System.Windows.Forms.Label()
        Me.lblCustomerContainer = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.tcDetails.SuspendLayout()
        Me.tpBookingDetails.SuspendLayout()
        Me.tpCustomerDetails.SuspendLayout()
        Me.tpPaymentDetails.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(257, 39)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 25)
        Me.btnNext.TabIndex = 89
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(225, 39)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 25)
        Me.btnBack.TabIndex = 88
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblAvailableDaysContainer)
        Me.Panel1.Controls.Add(Me.lblPlaceIDContainer)
        Me.Panel1.Controls.Add(Me.lblEventPlace)
        Me.Panel1.Controls.Add(Me.lblPlaceID)
        Me.Panel1.Controls.Add(Me.lblCapacity)
        Me.Panel1.Controls.Add(Me.lblHoursContainer)
        Me.Panel1.Controls.Add(Me.lblPricePerDayContainer)
        Me.Panel1.Controls.Add(Me.lblCapacityContainer)
        Me.Panel1.Controls.Add(Me.lblPricePerDay)
        Me.Panel1.Controls.Add(Me.lblFeatures)
        Me.Panel1.Controls.Add(Me.lblAvailability)
        Me.Panel1.Controls.Add(Me.lblFeaturesContainer)
        Me.Panel1.Controls.Add(Me.lblDescriptionContainer)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Location = New System.Drawing.Point(32, 308)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 281)
        Me.Panel1.TabIndex = 91
        '
        'lblAvailableDaysContainer
        '
        Me.lblAvailableDaysContainer.AutoSize = True
        Me.lblAvailableDaysContainer.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableDaysContainer.Location = New System.Drawing.Point(185, 125)
        Me.lblAvailableDaysContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableDaysContainer.Name = "lblAvailableDaysContainer"
        Me.lblAvailableDaysContainer.Size = New System.Drawing.Size(73, 16)
        Me.lblAvailableDaysContainer.TabIndex = 38
        Me.lblAvailableDaysContainer.Text = "Available:"
        '
        'lblPlaceIDContainer
        '
        Me.lblPlaceIDContainer.AutoSize = True
        Me.lblPlaceIDContainer.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceIDContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblPlaceIDContainer.Location = New System.Drawing.Point(92, 44)
        Me.lblPlaceIDContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceIDContainer.Name = "lblPlaceIDContainer"
        Me.lblPlaceIDContainer.Size = New System.Drawing.Size(18, 21)
        Me.lblPlaceIDContainer.TabIndex = 16
        Me.lblPlaceIDContainer.Text = "0"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Cinzel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEventPlace.Location = New System.Drawing.Point(18, 17)
        Me.lblEventPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(144, 27)
        Me.lblEventPlace.TabIndex = 9
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblPlaceID
        '
        Me.lblPlaceID.AutoSize = True
        Me.lblPlaceID.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceID.ForeColor = System.Drawing.Color.Gray
        Me.lblPlaceID.Location = New System.Drawing.Point(19, 44)
        Me.lblPlaceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaceID.Name = "lblPlaceID"
        Me.lblPlaceID.Size = New System.Drawing.Size(63, 16)
        Me.lblPlaceID.TabIndex = 8
        Me.lblPlaceID.Text = "Place ID"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Location = New System.Drawing.Point(19, 75)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(65, 16)
        Me.lblCapacity.TabIndex = 11
        Me.lblCapacity.Text = "Capacity"
        '
        'lblHoursContainer
        '
        Me.lblHoursContainer.AutoSize = True
        Me.lblHoursContainer.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblHoursContainer.Location = New System.Drawing.Point(19, 146)
        Me.lblHoursContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoursContainer.Name = "lblHoursContainer"
        Me.lblHoursContainer.Size = New System.Drawing.Size(17, 21)
        Me.lblHoursContainer.TabIndex = 36
        Me.lblHoursContainer.Text = "-"
        '
        'lblPricePerDayContainer
        '
        Me.lblPricePerDayContainer.AutoSize = True
        Me.lblPricePerDayContainer.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDayContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblPricePerDayContainer.Location = New System.Drawing.Point(189, 97)
        Me.lblPricePerDayContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDayContainer.Name = "lblPricePerDayContainer"
        Me.lblPricePerDayContainer.Size = New System.Drawing.Size(18, 21)
        Me.lblPricePerDayContainer.TabIndex = 18
        Me.lblPricePerDayContainer.Text = "0"
        '
        'lblCapacityContainer
        '
        Me.lblCapacityContainer.AutoSize = True
        Me.lblCapacityContainer.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCapacityContainer.Location = New System.Drawing.Point(23, 97)
        Me.lblCapacityContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacityContainer.Name = "lblCapacityContainer"
        Me.lblCapacityContainer.Size = New System.Drawing.Size(18, 21)
        Me.lblCapacityContainer.TabIndex = 17
        Me.lblCapacityContainer.Text = "0"
        '
        'lblPricePerDay
        '
        Me.lblPricePerDay.AutoSize = True
        Me.lblPricePerDay.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerDay.Location = New System.Drawing.Point(185, 75)
        Me.lblPricePerDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerDay.Name = "lblPricePerDay"
        Me.lblPricePerDay.Size = New System.Drawing.Size(95, 16)
        Me.lblPricePerDay.TabIndex = 12
        Me.lblPricePerDay.Text = "Price per Day"
        '
        'lblFeatures
        '
        Me.lblFeatures.AutoSize = True
        Me.lblFeatures.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeatures.Location = New System.Drawing.Point(19, 176)
        Me.lblFeatures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(64, 16)
        Me.lblFeatures.TabIndex = 15
        Me.lblFeatures.Text = "Features"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(20, 126)
        Me.lblAvailability.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(86, 16)
        Me.lblAvailability.TabIndex = 33
        Me.lblAvailability.Text = "Availability"
        '
        'lblFeaturesContainer
        '
        Me.lblFeaturesContainer.Font = New System.Drawing.Font("Poppins", 7.2!)
        Me.lblFeaturesContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblFeaturesContainer.Location = New System.Drawing.Point(19, 194)
        Me.lblFeaturesContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeaturesContainer.Name = "lblFeaturesContainer"
        Me.lblFeaturesContainer.Size = New System.Drawing.Size(326, 27)
        Me.lblFeaturesContainer.TabIndex = 19
        Me.lblFeaturesContainer.Text = "-"
        '
        'lblDescriptionContainer
        '
        Me.lblDescriptionContainer.Font = New System.Drawing.Font("Poppins", 7.2!)
        Me.lblDescriptionContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblDescriptionContainer.Location = New System.Drawing.Point(19, 245)
        Me.lblDescriptionContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescriptionContainer.Name = "lblDescriptionContainer"
        Me.lblDescriptionContainer.Size = New System.Drawing.Size(326, 27)
        Me.lblDescriptionContainer.TabIndex = 32
        Me.lblDescriptionContainer.Text = "-"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(19, 226)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(86, 16)
        Me.lblDescription.TabIndex = 31
        Me.lblDescription.Text = "Description"
        '
        'tcDetails
        '
        Me.tcDetails.Controls.Add(Me.tpBookingDetails)
        Me.tcDetails.Controls.Add(Me.tpCustomerDetails)
        Me.tcDetails.Controls.Add(Me.tpPaymentDetails)
        Me.tcDetails.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetails.Location = New System.Drawing.Point(415, 89)
        Me.tcDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tcDetails.Name = "tcDetails"
        Me.tcDetails.SelectedIndex = 0
        Me.tcDetails.Size = New System.Drawing.Size(808, 495)
        Me.tcDetails.TabIndex = 92
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
        Me.tpBookingDetails.Size = New System.Drawing.Size(800, 464)
        Me.tpBookingDetails.TabIndex = 0
        Me.tpBookingDetails.Text = "Booking Details"
        Me.tpBookingDetails.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 450)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
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
        Me.lblDateWarning.Size = New System.Drawing.Size(254, 50)
        Me.lblDateWarning.TabIndex = 80
        Me.lblDateWarning.Text = "The selected date - is unavailable. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Auto-selected:"
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
        Me.chkOutsideAvailableHours.Location = New System.Drawing.Point(471, 258)
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
        Me.cbSameDayEvent.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.cbSameDayEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbSameDayEvent.Location = New System.Drawing.Point(325, 98)
        Me.cbSameDayEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSameDayEvent.Name = "cbSameDayEvent"
        Me.cbSameDayEvent.Size = New System.Drawing.Size(127, 25)
        Me.cbSameDayEvent.TabIndex = 76
        Me.cbSameDayEvent.Text = "Same Day Event"
        Me.cbSameDayEvent.UseVisualStyleBackColor = True
        '
        'cbEndAMPM
        '
        Me.cbEndAMPM.AutoCompleteCustomSource.AddRange(New String() {"AM", "PM"})
        Me.cbEndAMPM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEndAMPM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbEndAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cbEndMinutes.AutoCompleteCustomSource.AddRange(New String() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbEndMinutes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEndMinutes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbEndMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cbEndHour.AutoCompleteCustomSource.AddRange(New String() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbEndHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEndHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbEndHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cbStartAMPM.AutoCompleteCustomSource.AddRange(New String() {"AM", "PM"})
        Me.cbStartAMPM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStartAMPM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbStartAMPM.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cbStartMinutes.AutoCompleteCustomSource.AddRange(New String() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbStartMinutes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStartMinutes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbStartMinutes.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cbStartHour.AutoCompleteCustomSource.AddRange(New String() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbStartHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbStartHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbStartHour.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblEventType.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventType.Location = New System.Drawing.Point(8, 21)
        Me.lblEventType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(84, 18)
        Me.lblEventType.TabIndex = 69
        Me.lblEventType.Text = "Event Type"
        '
        'cbEventType
        '
        Me.cbEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblNumGuests.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuests.Location = New System.Drawing.Point(8, 58)
        Me.lblNumGuests.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(135, 18)
        Me.lblNumGuests.TabIndex = 50
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'lblEventTimeEnd
        '
        Me.lblEventTimeEnd.AutoSize = True
        Me.lblEventTimeEnd.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblEventTimeEnd.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTimeEnd.Location = New System.Drawing.Point(111, 246)
        Me.lblEventTimeEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeEnd.Name = "lblEventTimeEnd"
        Me.lblEventTimeEnd.Size = New System.Drawing.Size(32, 21)
        Me.lblEventTimeEnd.TabIndex = 67
        Me.lblEventTimeEnd.Text = "End"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(177, 391)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(300, 28)
        Me.txtTotalPrice.TabIndex = 49
        '
        'lblEventTimeStart
        '
        Me.lblEventTimeStart.AutoSize = True
        Me.lblEventTimeStart.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblEventTimeStart.ForeColor = System.Drawing.Color.Gray
        Me.lblEventTimeStart.Location = New System.Drawing.Point(111, 209)
        Me.lblEventTimeStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimeStart.Name = "lblEventTimeStart"
        Me.lblEventTimeStart.Size = New System.Drawing.Size(37, 21)
        Me.lblEventTimeStart.TabIndex = 66
        Me.lblEventTimeStart.Text = "Start"
        '
        'lblEventDateStart
        '
        Me.lblEventDateStart.AutoSize = True
        Me.lblEventDateStart.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblEventDateStart.ForeColor = System.Drawing.Color.Gray
        Me.lblEventDateStart.Location = New System.Drawing.Point(111, 138)
        Me.lblEventDateStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDateStart.Name = "lblEventDateStart"
        Me.lblEventDateStart.Size = New System.Drawing.Size(37, 21)
        Me.lblEventDateStart.TabIndex = 51
        Me.lblEventDateStart.Text = "Start"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(51, 188)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(40, 18)
        Me.lblTime.TabIndex = 65
        Me.lblTime.Text = "Time"
        '
        'lblServicesAvailed
        '
        Me.lblServicesAvailed.AutoSize = True
        Me.lblServicesAvailed.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesAvailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblServicesAvailed.Location = New System.Drawing.Point(16, 299)
        Me.lblServicesAvailed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesAvailed.Name = "lblServicesAvailed"
        Me.lblServicesAvailed.Size = New System.Drawing.Size(123, 18)
        Me.lblServicesAvailed.TabIndex = 52
        Me.lblServicesAvailed.Text = "Services Availed"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(51, 116)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 18)
        Me.lblDate.TabIndex = 64
        Me.lblDate.Text = "Date"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalPrice.Location = New System.Drawing.Point(16, 395)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(90, 18)
        Me.lblTotalPrice.TabIndex = 53
        Me.lblTotalPrice.Text = "Total Price"
        '
        'dtpEventDateEnd
        '
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
        Me.txtNumGuests.Location = New System.Drawing.Point(177, 58)
        Me.txtNumGuests.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(279, 28)
        Me.txtNumGuests.TabIndex = 48
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblEnd.ForeColor = System.Drawing.Color.Gray
        Me.lblEnd.Location = New System.Drawing.Point(111, 167)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(32, 21)
        Me.lblEnd.TabIndex = 62
        Me.lblEnd.Text = "End"
        '
        'dtpEventDateStart
        '
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
        Me.chkCatering.ForeColor = System.Drawing.Color.Gray
        Me.chkCatering.Location = New System.Drawing.Point(177, 299)
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
        Me.lblEventSchedule.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventSchedule.Location = New System.Drawing.Point(8, 87)
        Me.lblEventSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventSchedule.Name = "lblEventSchedule"
        Me.lblEventSchedule.Size = New System.Drawing.Size(119, 18)
        Me.lblEventSchedule.TabIndex = 61
        Me.lblEventSchedule.Text = "Event Schedule"
        '
        'chkClown
        '
        Me.chkClown.AutoSize = True
        Me.chkClown.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClown.ForeColor = System.Drawing.Color.Gray
        Me.chkClown.Location = New System.Drawing.Point(177, 326)
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
        Me.btBookingProceed.Location = New System.Drawing.Point(605, 405)
        Me.btBookingProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btBookingProceed.Name = "btBookingProceed"
        Me.btBookingProceed.Size = New System.Drawing.Size(160, 34)
        Me.btBookingProceed.TabIndex = 60
        Me.btBookingProceed.UseVisualStyleBackColor = False
        '
        'chkSinger
        '
        Me.chkSinger.AutoSize = True
        Me.chkSinger.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinger.ForeColor = System.Drawing.Color.Gray
        Me.chkSinger.Location = New System.Drawing.Point(177, 354)
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
        Me.chkVideoke.ForeColor = System.Drawing.Color.Gray
        Me.chkVideoke.Location = New System.Drawing.Point(471, 340)
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
        Me.chkDancer.ForeColor = System.Drawing.Color.Gray
        Me.chkDancer.Location = New System.Drawing.Point(471, 314)
        Me.chkDancer.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDancer.Name = "chkDancer"
        Me.chkDancer.Size = New System.Drawing.Size(203, 29)
        Me.chkDancer.TabIndex = 58
        Me.chkDancer.Text = "Dancer (₱140 per guest)"
        Me.chkDancer.UseVisualStyleBackColor = True
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
        Me.tpCustomerDetails.Size = New System.Drawing.Size(800, 464)
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
        Me.btnCustomerProceed.Location = New System.Drawing.Point(605, 405)
        Me.btnCustomerProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerProceed.Name = "btnCustomerProceed"
        Me.btnCustomerProceed.Size = New System.Drawing.Size(160, 34)
        Me.btnCustomerProceed.TabIndex = 21
        Me.btnCustomerProceed.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(23, 26)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 18)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(116, 63)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(604, 25)
        Me.dtpBirthday.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(116, 26)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(604, 25)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(23, 65)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(74, 18)
        Me.lblBirthday.TabIndex = 10
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(116, 137)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(604, 26)
        Me.cmbSex.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(23, 183)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 18)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(23, 144)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(31, 18)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(116, 178)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(607, 25)
        Me.txtAddress.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(23, 105)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 18)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(116, 100)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(604, 25)
        Me.txtAge.TabIndex = 1
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
        Me.tpPaymentDetails.Size = New System.Drawing.Size(800, 464)
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
        Me.btnPlaceBooking.Location = New System.Drawing.Point(605, 405)
        Me.btnPlaceBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaceBooking.Name = "btnPlaceBooking"
        Me.btnPlaceBooking.Size = New System.Drawing.Size(160, 34)
        Me.btnPlaceBooking.TabIndex = 61
        Me.btnPlaceBooking.UseVisualStyleBackColor = False
        '
        'lblPriceBreakdown
        '
        Me.lblPriceBreakdown.AutoSize = True
        Me.lblPriceBreakdown.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceBreakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPriceBreakdown.Location = New System.Drawing.Point(473, 15)
        Me.lblPriceBreakdown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceBreakdown.Name = "lblPriceBreakdown"
        Me.lblPriceBreakdown.Size = New System.Drawing.Size(126, 25)
        Me.lblPriceBreakdown.TabIndex = 48
        Me.lblPriceBreakdown.Text = "Price Breakdown"
        '
        'lblTotalPricePaymentContainer
        '
        Me.lblTotalPricePaymentContainer.AutoSize = True
        Me.lblTotalPricePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPricePaymentContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalPricePaymentContainer.Location = New System.Drawing.Point(411, 357)
        Me.lblTotalPricePaymentContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPricePaymentContainer.Name = "lblTotalPricePaymentContainer"
        Me.lblTotalPricePaymentContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblTotalPricePaymentContainer.TabIndex = 15
        Me.lblTotalPricePaymentContainer.Text = "-"
        '
        'lblEventTimePaymentContainer
        '
        Me.lblEventTimePaymentContainer.AutoSize = True
        Me.lblEventTimePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblEventTimePayment.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTimePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTimePayment.Location = New System.Drawing.Point(21, 276)
        Me.lblEventTimePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTimePayment.Name = "lblEventTimePayment"
        Me.lblEventTimePayment.Size = New System.Drawing.Size(84, 18)
        Me.lblEventTimePayment.TabIndex = 10
        Me.lblEventTimePayment.Text = "Event Time"
        '
        'lblEventDatePaymentContainer
        '
        Me.lblEventDatePaymentContainer.AutoSize = True
        Me.lblEventDatePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblEventDatePayment.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventDatePayment.Location = New System.Drawing.Point(21, 219)
        Me.lblEventDatePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDatePayment.Name = "lblEventDatePayment"
        Me.lblEventDatePayment.Size = New System.Drawing.Size(84, 18)
        Me.lblEventDatePayment.TabIndex = 8
        Me.lblEventDatePayment.Text = "Event Date"
        '
        'lblNumGuestsPaymentContainer
        '
        Me.lblNumGuestsPaymentContainer.AutoSize = True
        Me.lblNumGuestsPaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblNumGuestsPayment.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuestsPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumGuestsPayment.Location = New System.Drawing.Point(21, 162)
        Me.lblNumGuestsPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuestsPayment.Name = "lblNumGuestsPayment"
        Me.lblNumGuestsPayment.Size = New System.Drawing.Size(135, 18)
        Me.lblNumGuestsPayment.TabIndex = 6
        Me.lblNumGuestsPayment.Text = "Number of Guests"
        '
        'lblEventTypePaymentContainer
        '
        Me.lblEventTypePaymentContainer.AutoSize = True
        Me.lblEventTypePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblEventTypePayment.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTypePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventTypePayment.Location = New System.Drawing.Point(21, 112)
        Me.lblEventTypePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTypePayment.Name = "lblEventTypePayment"
        Me.lblEventTypePayment.Size = New System.Drawing.Size(84, 18)
        Me.lblEventTypePayment.TabIndex = 4
        Me.lblEventTypePayment.Text = "Event Type"
        '
        'lblEventPlacePaymentContainer
        '
        Me.lblEventPlacePaymentContainer.AutoSize = True
        Me.lblEventPlacePaymentContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblEventPlacePayment.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlacePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEventPlacePayment.Location = New System.Drawing.Point(21, 55)
        Me.lblEventPlacePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlacePayment.Name = "lblEventPlacePayment"
        Me.lblEventPlacePayment.Size = New System.Drawing.Size(92, 18)
        Me.lblEventPlacePayment.TabIndex = 2
        Me.lblEventPlacePayment.Text = "Event Place"
        '
        'lblCustomerContainer
        '
        Me.lblCustomerContainer.AutoSize = True
        Me.lblCustomerContainer.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerContainer.ForeColor = System.Drawing.Color.Gray
        Me.lblCustomerContainer.Location = New System.Drawing.Point(229, 15)
        Me.lblCustomerContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerContainer.Name = "lblCustomerContainer"
        Me.lblCustomerContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblCustomerContainer.TabIndex = 1
        Me.lblCustomerContainer.Text = "-"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(21, 15)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(79, 18)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(32, 117)
        Me.pb.Margin = New System.Windows.Forms.Padding(4)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(375, 183)
        Me.pb.TabIndex = 90
        Me.pb.TabStop = False
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGbooking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 617)
        Me.Controls.Add(Me.tcDetails)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBookingDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tcDetails.ResumeLayout(False)
        Me.tpBookingDetails.ResumeLayout(False)
        Me.tpBookingDetails.PerformLayout()
        Me.tpCustomerDetails.ResumeLayout(False)
        Me.tpCustomerDetails.PerformLayout()
        Me.tpPaymentDetails.ResumeLayout(False)
        Me.tpPaymentDetails.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pb As PictureBox
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents tcDetails As TabControl
    Friend WithEvents tpBookingDetails As TabPage
    Friend WithEvents lblBeyondAvailabilityFee As Label
    Friend WithEvents lblCapacityExceedanceFee As Label
    Friend WithEvents chkOutsideAvailableHours As CheckBox
    Friend WithEvents cbSameDayEvent As CheckBox
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
    Friend WithEvents lblEventTimeStart As Label
    Friend WithEvents lblEventDateStart As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblServicesAvailed As Label
    Friend WithEvents lblDate As Label
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
    Friend WithEvents tpPaymentDetails As TabPage
    Friend WithEvents btnPlaceBooking As Button
    Friend WithEvents lblPriceBreakdown As Label
    Friend WithEvents lblTotalPricePaymentContainer As Label
    Friend WithEvents lblEventTimePaymentContainer As Label
    Friend WithEvents lblEventTimePayment As Label
    Friend WithEvents lblEventDatePaymentContainer As Label
    Friend WithEvents lblEventDatePayment As Label
    Friend WithEvents lblNumGuestsPaymentContainer As Label
    Friend WithEvents lblNumGuestsPayment As Label
    Friend WithEvents lblEventTypePaymentContainer As Label
    Friend WithEvents lblEventTypePayment As Label
    Friend WithEvents lblEventPlacePaymentContainer As Label
    Friend WithEvents lblEventPlacePayment As Label
    Friend WithEvents lblCustomerContainer As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnCustomerProceed As Button
    Friend WithEvents lblDateWarning As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPrice As TextBox
End Class
