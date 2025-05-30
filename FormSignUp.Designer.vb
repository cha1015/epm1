<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSignUp))
        Me.lnklblLogIn = New System.Windows.Forms.LinkLabel()
        Me.lblRequiredMessage = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tcSignUp = New System.Windows.Forms.TabControl()
        Me.tpPersonalInfo = New System.Windows.Forms.TabPage()
        Me.lblAgeContainer = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.tpAccountDetails = New System.Windows.Forms.TabPage()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.lblPwStrength = New System.Windows.Forms.Label()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblUsernameError = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.tcSignUp.SuspendLayout()
        Me.tpPersonalInfo.SuspendLayout()
        Me.tpAccountDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnklblLogIn
        '
        Me.lnklblLogIn.AutoSize = True
        Me.lnklblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblLogIn.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblLogIn.ForeColor = System.Drawing.Color.Black
        Me.lnklblLogIn.LinkColor = System.Drawing.Color.Gray
        Me.lnklblLogIn.Location = New System.Drawing.Point(177, 435)
        Me.lnklblLogIn.Name = "lnklblLogIn"
        Me.lnklblLogIn.Size = New System.Drawing.Size(145, 19)
        Me.lnklblLogIn.TabIndex = 36
        Me.lnklblLogIn.TabStop = True
        Me.lnklblLogIn.Text = "I have an account. Log In"
        '
        'lblRequiredMessage
        '
        Me.lblRequiredMessage.AutoSize = True
        Me.lblRequiredMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblRequiredMessage.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequiredMessage.ForeColor = System.Drawing.Color.Gray
        Me.lblRequiredMessage.Location = New System.Drawing.Point(571, 435)
        Me.lblRequiredMessage.Name = "lblRequiredMessage"
        Me.lblRequiredMessage.Size = New System.Drawing.Size(192, 19)
        Me.lblRequiredMessage.TabIndex = 53
        Me.lblRequiredMessage.Text = "Fields marked with * are required."
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(46, 11)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 26)
        Me.btnNext.TabIndex = 87
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(20, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 26)
        Me.btnBack.TabIndex = 86
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tcSignUp
        '
        Me.tcSignUp.Controls.Add(Me.tpPersonalInfo)
        Me.tcSignUp.Controls.Add(Me.tpAccountDetails)
        Me.tcSignUp.Font = New System.Drawing.Font("Cinzel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSignUp.Location = New System.Drawing.Point(181, 80)
        Me.tcSignUp.Name = "tcSignUp"
        Me.tcSignUp.SelectedIndex = 0
        Me.tcSignUp.Size = New System.Drawing.Size(582, 352)
        Me.tcSignUp.TabIndex = 88
        '
        'tpPersonalInfo
        '
        Me.tpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tpPersonalInfo.Controls.Add(Me.lblAgeContainer)
        Me.tpPersonalInfo.Controls.Add(Me.btnProceed)
        Me.tpPersonalInfo.Controls.Add(Me.dtpBirthday)
        Me.tpPersonalInfo.Controls.Add(Me.lblBirthday)
        Me.tpPersonalInfo.Controls.Add(Me.cmbSex)
        Me.tpPersonalInfo.Controls.Add(Me.lblAddress)
        Me.tpPersonalInfo.Controls.Add(Me.lblSex)
        Me.tpPersonalInfo.Controls.Add(Me.txtAddress)
        Me.tpPersonalInfo.Controls.Add(Me.lblAge)
        Me.tpPersonalInfo.Controls.Add(Me.lblLastName)
        Me.tpPersonalInfo.Controls.Add(Me.lblFirstName)
        Me.tpPersonalInfo.Controls.Add(Me.txtFirstName)
        Me.tpPersonalInfo.Controls.Add(Me.txtLastName)
        Me.tpPersonalInfo.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpPersonalInfo.Location = New System.Drawing.Point(4, 22)
        Me.tpPersonalInfo.Name = "tpPersonalInfo"
        Me.tpPersonalInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersonalInfo.Size = New System.Drawing.Size(574, 326)
        Me.tpPersonalInfo.TabIndex = 0
        Me.tpPersonalInfo.Text = "Personal Information"
        '
        'lblAgeContainer
        '
        Me.lblAgeContainer.AutoSize = True
        Me.lblAgeContainer.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeContainer.Location = New System.Drawing.Point(167, 168)
        Me.lblAgeContainer.Name = "lblAgeContainer"
        Me.lblAgeContainer.Size = New System.Drawing.Size(20, 26)
        Me.lblAgeContainer.TabIndex = 81
        Me.lblAgeContainer.Text = "-"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Transparent
        Me.btnProceed.BackgroundImage = Global.epm1.My.Resources.Resources.BttnProceed
        Me.btnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.Black
        Me.btnProceed.Location = New System.Drawing.Point(418, 280)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(137, 32)
        Me.btnProceed.TabIndex = 80
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dtpBirthday.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthday.Location = New System.Drawing.Point(171, 134)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(318, 24)
        Me.dtpBirthday.TabIndex = 73
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(86, 133)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(67, 14)
        Me.lblBirthday.TabIndex = 77
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbSex.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cmbSex.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.ForeColor = System.Drawing.Color.DimGray
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(171, 194)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(318, 27)
        Me.cmbSex.TabIndex = 74
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(86, 228)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 14)
        Me.lblAddress.TabIndex = 79
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(88, 194)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(28, 14)
        Me.lblSex.TabIndex = 78
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.DimGray
        Me.txtAddress.Location = New System.Drawing.Point(171, 228)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(318, 23)
        Me.txtAddress.TabIndex = 75
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(88, 165)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 14)
        Me.lblAge.TabIndex = 76
        Me.lblAge.Text = "Age"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(86, 103)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(74, 14)
        Me.lblLastName.TabIndex = 71
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(86, 75)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(78, 14)
        Me.lblFirstName.TabIndex = 70
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.DimGray
        Me.txtFirstName.Location = New System.Drawing.Point(171, 75)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(318, 23)
        Me.txtFirstName.TabIndex = 68
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastName.Location = New System.Drawing.Point(171, 104)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(318, 23)
        Me.txtLastName.TabIndex = 69
        '
        'tpAccountDetails
        '
        Me.tpAccountDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tpAccountDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpAccountDetails.Controls.Add(Me.btnSignUp)
        Me.tpAccountDetails.Controls.Add(Me.lblPasswordError)
        Me.tpAccountDetails.Controls.Add(Me.lblPwStrength)
        Me.tpAccountDetails.Controls.Add(Me.lblEmailError)
        Me.tpAccountDetails.Controls.Add(Me.lblUsernameError)
        Me.tpAccountDetails.Controls.Add(Me.lblRole)
        Me.tpAccountDetails.Controls.Add(Me.lblConfirmPassword)
        Me.tpAccountDetails.Controls.Add(Me.lblPassword)
        Me.tpAccountDetails.Controls.Add(Me.lblEmail)
        Me.tpAccountDetails.Controls.Add(Me.lblUsername)
        Me.tpAccountDetails.Controls.Add(Me.btnShowPass)
        Me.tpAccountDetails.Controls.Add(Me.btnShowConfPass)
        Me.tpAccountDetails.Controls.Add(Me.cmbRole)
        Me.tpAccountDetails.Controls.Add(Me.txtEmail)
        Me.tpAccountDetails.Controls.Add(Me.txtUsername)
        Me.tpAccountDetails.Controls.Add(Me.txtPass)
        Me.tpAccountDetails.Controls.Add(Me.txtConfPass)
        Me.tpAccountDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpAccountDetails.Name = "tpAccountDetails"
        Me.tpAccountDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccountDetails.Size = New System.Drawing.Size(574, 326)
        Me.tpAccountDetails.TabIndex = 1
        Me.tpAccountDetails.Text = "Account Details"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BackgroundImage = Global.epm1.My.Resources.Resources.signupppp
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.Location = New System.Drawing.Point(418, 280)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(137, 32)
        Me.btnSignUp.TabIndex = 81
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblPasswordError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblPasswordError.Location = New System.Drawing.Point(211, 295)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(147, 19)
        Me.lblPasswordError.TabIndex = 77
        Me.lblPasswordError.Text = "Passwords do not match!"
        Me.lblPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPwStrength
        '
        Me.lblPwStrength.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwStrength.ForeColor = System.Drawing.Color.IndianRed
        Me.lblPwStrength.Location = New System.Drawing.Point(211, 276)
        Me.lblPwStrength.Name = "lblPwStrength"
        Me.lblPwStrength.Size = New System.Drawing.Size(142, 19)
        Me.lblPwStrength.TabIndex = 75
        Me.lblPwStrength.Text = "Strength:"
        Me.lblPwStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblEmailError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblEmailError.Location = New System.Drawing.Point(211, 257)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(120, 19)
        Me.lblEmailError.TabIndex = 74
        Me.lblEmailError.Text = "Email already exists!"
        Me.lblEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblUsernameError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblUsernameError.Location = New System.Drawing.Point(211, 238)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(146, 19)
        Me.lblUsernameError.TabIndex = 73
        Me.lblUsernameError.Text = "Username already exists!"
        Me.lblUsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(75, 208)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(39, 14)
        Me.lblRole.TabIndex = 72
        Me.lblRole.Text = "Role"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(75, 181)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(134, 14)
        Me.lblConfirmPassword.TabIndex = 71
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(75, 150)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 14)
        Me.lblPassword.TabIndex = 70
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(75, 121)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 14)
        Me.lblEmail.TabIndex = 69
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(75, 92)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 14)
        Me.lblUsername.TabIndex = 68
        Me.lblUsername.Text = "Username"
        '
        'btnShowPass
        '
        Me.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowPass.Location = New System.Drawing.Point(484, 150)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(28, 23)
        Me.btnShowPass.TabIndex = 65
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowConfPass.FlatAppearance.BorderSize = 0
        Me.btnShowConfPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowConfPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowConfPass.Location = New System.Drawing.Point(484, 177)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(28, 23)
        Me.btnShowConfPass.TabIndex = 64
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'cmbRole
        '
        Me.cmbRole.AutoCompleteCustomSource.AddRange(New String() {"User", "Admin"})
        Me.cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.ForeColor = System.Drawing.Color.DimGray
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"User", "Admin"})
        Me.cmbRole.Location = New System.Drawing.Point(160, 208)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(318, 27)
        Me.cmbRole.TabIndex = 62
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.Location = New System.Drawing.Point(160, 121)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 23)
        Me.txtEmail.TabIndex = 59
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(160, 92)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(318, 23)
        Me.txtUsername.TabIndex = 58
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtPass.Location = New System.Drawing.Point(160, 150)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(318, 23)
        Me.txtPass.TabIndex = 60
        '
        'txtConfPass
        '
        Me.txtConfPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtConfPass.Location = New System.Drawing.Point(215, 179)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(263, 23)
        Me.txtConfPass.TabIndex = 61
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.Sign_Up
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.tcSignUp)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblRequiredMessage)
        Me.Controls.Add(Me.lnklblLogIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignUp"
        Me.tcSignUp.ResumeLayout(False)
        Me.tpPersonalInfo.ResumeLayout(False)
        Me.tpPersonalInfo.PerformLayout()
        Me.tpAccountDetails.ResumeLayout(False)
        Me.tpAccountDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnklblLogIn As LinkLabel
    Friend WithEvents lblRequiredMessage As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents tcSignUp As TabControl
    Friend WithEvents tpPersonalInfo As TabPage
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents tpAccountDetails As TabPage
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents lblPwStrength As Label
    Friend WithEvents lblEmailError As Label
    Friend WithEvents lblUsernameError As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents lblBirthday As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAgeContainer As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnSignUp As Button
End Class
