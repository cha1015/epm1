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
        Me.btnSignUp = New System.Windows.Forms.Button()
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
        Me.lblAdminCodeError = New System.Windows.Forms.Label()
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
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.tcSignUp.SuspendLayout()
        Me.tpPersonalInfo.SuspendLayout()
        Me.tpAccountDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BackgroundImage = Global.epm1.My.Resources.Resources.BttnCreateAccount
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.Location = New System.Drawing.Point(587, 348)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(161, 34)
        Me.btnSignUp.TabIndex = 8
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lnklblLogIn
        '
        Me.lnklblLogIn.AutoSize = True
        Me.lnklblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblLogIn.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblLogIn.ForeColor = System.Drawing.Color.Black
        Me.lnklblLogIn.LinkColor = System.Drawing.Color.Gray
        Me.lnklblLogIn.Location = New System.Drawing.Point(245, 532)
        Me.lnklblLogIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklblLogIn.Name = "lnklblLogIn"
        Me.lnklblLogIn.Size = New System.Drawing.Size(168, 23)
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
        Me.lblRequiredMessage.Location = New System.Drawing.Point(792, 530)
        Me.lblRequiredMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRequiredMessage.Name = "lblRequiredMessage"
        Me.lblRequiredMessage.Size = New System.Drawing.Size(226, 23)
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
        Me.btnNext.Location = New System.Drawing.Point(61, 14)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 32)
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
        Me.btnBack.Location = New System.Drawing.Point(27, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 32)
        Me.btnBack.TabIndex = 86
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tcSignUp
        '
        Me.tcSignUp.Controls.Add(Me.tpPersonalInfo)
        Me.tcSignUp.Controls.Add(Me.tpAccountDetails)
        Me.tcSignUp.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSignUp.Location = New System.Drawing.Point(236, 98)
        Me.tcSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.tcSignUp.Name = "tcSignUp"
        Me.tcSignUp.SelectedIndex = 0
        Me.tcSignUp.Size = New System.Drawing.Size(787, 433)
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
        Me.tpPersonalInfo.Location = New System.Drawing.Point(4, 27)
        Me.tpPersonalInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPersonalInfo.Name = "tpPersonalInfo"
        Me.tpPersonalInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPersonalInfo.Size = New System.Drawing.Size(779, 402)
        Me.tpPersonalInfo.TabIndex = 0
        Me.tpPersonalInfo.Text = "Personal Information"
        '
        'lblAgeContainer
        '
        Me.lblAgeContainer.AutoSize = True
        Me.lblAgeContainer.Location = New System.Drawing.Point(269, 176)
        Me.lblAgeContainer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgeContainer.Name = "lblAgeContainer"
        Me.lblAgeContainer.Size = New System.Drawing.Size(13, 18)
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
        Me.btnProceed.Location = New System.Drawing.Point(477, 313)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(117, 27)
        Me.btnProceed.TabIndex = 80
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(275, 134)
        Me.dtpBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(319, 25)
        Me.dtpBirthday.TabIndex = 73
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(171, 137)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(74, 18)
        Me.lblBirthday.TabIndex = 77
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbSex.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(275, 208)
        Me.cmbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(319, 24)
        Me.cmbSex.TabIndex = 74
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(171, 254)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 18)
        Me.lblAddress.TabIndex = 79
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(174, 212)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(31, 18)
        Me.lblSex.TabIndex = 78
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(275, 250)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(319, 24)
        Me.txtAddress.TabIndex = 75
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(174, 176)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 18)
        Me.lblAge.TabIndex = 76
        Me.lblAge.Text = "Age"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(171, 100)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 18)
        Me.lblLastName.TabIndex = 71
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(171, 65)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(85, 18)
        Me.lblFirstName.TabIndex = 70
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(275, 62)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(319, 24)
        Me.txtFirstName.TabIndex = 68
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Cinzel", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(275, 97)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(319, 24)
        Me.txtLastName.TabIndex = 69
        '
        'tpAccountDetails
        '
        Me.tpAccountDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tpAccountDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpAccountDetails.Controls.Add(Me.lblAdminCodeError)
        Me.tpAccountDetails.Controls.Add(Me.lblPasswordError)
        Me.tpAccountDetails.Controls.Add(Me.btnSignUp)
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
        Me.tpAccountDetails.Controls.Add(Me.cbRole)
        Me.tpAccountDetails.Controls.Add(Me.txtEmail)
        Me.tpAccountDetails.Controls.Add(Me.txtUsername)
        Me.tpAccountDetails.Controls.Add(Me.txtPass)
        Me.tpAccountDetails.Controls.Add(Me.txtConfPass)
        Me.tpAccountDetails.Location = New System.Drawing.Point(4, 27)
        Me.tpAccountDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tpAccountDetails.Name = "tpAccountDetails"
        Me.tpAccountDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tpAccountDetails.Size = New System.Drawing.Size(779, 402)
        Me.tpAccountDetails.TabIndex = 1
        Me.tpAccountDetails.Text = "Account Details"
        '
        'lblAdminCodeError
        '
        Me.lblAdminCodeError.AutoSize = True
        Me.lblAdminCodeError.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminCodeError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblAdminCodeError.ForeColor = System.Drawing.Color.Gray
        Me.lblAdminCodeError.Location = New System.Drawing.Point(489, 295)
        Me.lblAdminCodeError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminCodeError.Name = "lblAdminCodeError"
        Me.lblAdminCodeError.Size = New System.Drawing.Size(55, 23)
        Me.lblAdminCodeError.TabIndex = 78
        Me.lblAdminCodeError.Text = "Invalid."
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblPasswordError.ForeColor = System.Drawing.Color.Gray
        Me.lblPasswordError.Location = New System.Drawing.Point(369, 207)
        Me.lblPasswordError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(175, 23)
        Me.lblPasswordError.TabIndex = 77
        Me.lblPasswordError.Text = "Passwords do not match!"
        '
        'lblPwStrength
        '
        Me.lblPwStrength.AutoSize = True
        Me.lblPwStrength.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwStrength.ForeColor = System.Drawing.Color.Gray
        Me.lblPwStrength.Location = New System.Drawing.Point(475, 149)
        Me.lblPwStrength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPwStrength.Name = "lblPwStrength"
        Me.lblPwStrength.Size = New System.Drawing.Size(69, 23)
        Me.lblPwStrength.TabIndex = 75
        Me.lblPwStrength.Text = "Strength:"
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblEmailError.ForeColor = System.Drawing.Color.Gray
        Me.lblEmailError.Location = New System.Drawing.Point(403, 89)
        Me.lblEmailError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(141, 23)
        Me.lblEmailError.TabIndex = 74
        Me.lblEmailError.Text = "Email already exists!"
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Poppins", 7.8!)
        Me.lblUsernameError.ForeColor = System.Drawing.Color.Gray
        Me.lblUsernameError.Location = New System.Drawing.Point(371, 25)
        Me.lblUsernameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(173, 23)
        Me.lblUsernameError.TabIndex = 73
        Me.lblUsernameError.Text = "Username already exists!"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(225, 270)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(42, 18)
        Me.lblRole.TabIndex = 72
        Me.lblRole.Text = "Role"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(225, 209)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(143, 18)
        Me.lblConfirmPassword.TabIndex = 71
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(225, 149)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 18)
        Me.lblPassword.TabIndex = 70
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(225, 89)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 18)
        Me.lblEmail.TabIndex = 69
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(225, 25)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 18)
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
        Me.btnShowPass.Location = New System.Drawing.Point(523, 178)
        Me.btnShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(21, 21)
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
        Me.btnShowConfPass.Location = New System.Drawing.Point(523, 239)
        Me.btnShowConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(21, 21)
        Me.btnShowConfPass.TabIndex = 64
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'cbRole
        '
        Me.cbRole.AutoCompleteCustomSource.AddRange(New String() {"User", "Admin"})
        Me.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbRole.Font = New System.Drawing.Font("Cinzel", 7.2!)
        Me.cbRole.ForeColor = System.Drawing.Color.Black
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"User", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(225, 295)
        Me.cbRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(256, 24)
        Me.cbRole.TabIndex = 62
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Cinzel", 7.2!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(225, 114)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(319, 24)
        Me.txtEmail.TabIndex = 59
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Cinzel", 7.2!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(225, 55)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(319, 24)
        Me.txtUsername.TabIndex = 58
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Cinzel", 7.2!)
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(225, 176)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(295, 24)
        Me.txtPass.TabIndex = 60
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Cinzel", 7.2!)
        Me.txtConfPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfPass.Location = New System.Drawing.Point(225, 236)
        Me.txtConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(295, 24)
        Me.txtConfPass.TabIndex = 61
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.Sign_Up
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 617)
        Me.Controls.Add(Me.tcSignUp)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblRequiredMessage)
        Me.Controls.Add(Me.lnklblLogIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents btnSignUp As Button
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
    Friend WithEvents lblAdminCodeError As Label
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
    Friend WithEvents cbRole As ComboBox
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
End Class
