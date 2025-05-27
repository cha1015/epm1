<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomerAdminInfo
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
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.btnConfirmPasswordChange = New System.Windows.Forms.Button()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.lblPwStrength = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnConfirmEdit = New System.Windows.Forms.Button()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblUsernameError = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.tcSignUp.SuspendLayout()
        Me.tpPersonalInfo.SuspendLayout()
        Me.tpAccountDetails.SuspendLayout()
        Me.pnlPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(60, 13)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(42, 23)
        Me.btnNext.TabIndex = 106
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 105
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'tcSignUp
        '
        Me.tcSignUp.Controls.Add(Me.tpPersonalInfo)
        Me.tcSignUp.Controls.Add(Me.tpAccountDetails)
        Me.tcSignUp.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSignUp.Location = New System.Drawing.Point(38, 54)
        Me.tcSignUp.Name = "tcSignUp"
        Me.tcSignUp.SelectedIndex = 0
        Me.tcSignUp.Size = New System.Drawing.Size(869, 393)
        Me.tcSignUp.TabIndex = 107
        '
        'tpPersonalInfo
        '
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
        Me.tpPersonalInfo.Location = New System.Drawing.Point(4, 34)
        Me.tpPersonalInfo.Name = "tpPersonalInfo"
        Me.tpPersonalInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersonalInfo.Size = New System.Drawing.Size(861, 355)
        Me.tpPersonalInfo.TabIndex = 0
        Me.tpPersonalInfo.Text = "Personal Information"
        Me.tpPersonalInfo.UseVisualStyleBackColor = True
        '
        'lblAgeContainer
        '
        Me.lblAgeContainer.AutoSize = True
        Me.lblAgeContainer.Location = New System.Drawing.Point(343, 185)
        Me.lblAgeContainer.Name = "lblAgeContainer"
        Me.lblAgeContainer.Size = New System.Drawing.Size(20, 25)
        Me.lblAgeContainer.TabIndex = 81
        Me.lblAgeContainer.Text = "-"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Gainsboro
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.Black
        Me.btnProceed.Location = New System.Drawing.Point(745, 311)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(110, 38)
        Me.btnProceed.TabIndex = 80
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(343, 151)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(240, 28)
        Me.dtpBirthday.TabIndex = 73
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(245, 155)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(69, 25)
        Me.lblBirthday.TabIndex = 77
        Me.lblBirthday.Text = "Birthday"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Other", "Prefer Not to Say"})
        Me.cmbSex.Location = New System.Drawing.Point(343, 211)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(240, 33)
        Me.cmbSex.TabIndex = 74
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(245, 248)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 25)
        Me.lblAddress.TabIndex = 79
        Me.lblAddress.Text = "Address"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(245, 217)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(36, 25)
        Me.lblSex.TabIndex = 78
        Me.lblSex.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(343, 245)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(240, 28)
        Me.txtAddress.TabIndex = 75
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(245, 186)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(39, 25)
        Me.lblAge.TabIndex = 76
        Me.lblAge.Text = "Age"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(245, 124)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(85, 25)
        Me.lblLastName.TabIndex = 71
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(245, 93)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(85, 25)
        Me.lblFirstName.TabIndex = 70
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(343, 92)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(240, 28)
        Me.txtFirstName.TabIndex = 68
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(343, 121)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(240, 28)
        Me.txtLastName.TabIndex = 69
        '
        'tpAccountDetails
        '
        Me.tpAccountDetails.Controls.Add(Me.pnlPass)
        Me.tpAccountDetails.Controls.Add(Me.btnChangePass)
        Me.tpAccountDetails.Controls.Add(Me.btnConfirmEdit)
        Me.tpAccountDetails.Controls.Add(Me.lblEmailError)
        Me.tpAccountDetails.Controls.Add(Me.lblUsernameError)
        Me.tpAccountDetails.Controls.Add(Me.lblEmail)
        Me.tpAccountDetails.Controls.Add(Me.lblUsername)
        Me.tpAccountDetails.Controls.Add(Me.txtEmail)
        Me.tpAccountDetails.Controls.Add(Me.txtUsername)
        Me.tpAccountDetails.Location = New System.Drawing.Point(4, 34)
        Me.tpAccountDetails.Name = "tpAccountDetails"
        Me.tpAccountDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccountDetails.Size = New System.Drawing.Size(861, 355)
        Me.tpAccountDetails.TabIndex = 1
        Me.tpAccountDetails.Text = "Account Details"
        Me.tpAccountDetails.UseVisualStyleBackColor = True
        '
        'pnlPass
        '
        Me.pnlPass.Controls.Add(Me.btnConfirmPasswordChange)
        Me.pnlPass.Controls.Add(Me.lblPasswordError)
        Me.pnlPass.Controls.Add(Me.lblPwStrength)
        Me.pnlPass.Controls.Add(Me.lblConfirmPassword)
        Me.pnlPass.Controls.Add(Me.lblPassword)
        Me.pnlPass.Controls.Add(Me.btnShowPass)
        Me.pnlPass.Controls.Add(Me.btnShowConfPass)
        Me.pnlPass.Controls.Add(Me.txtPass)
        Me.pnlPass.Controls.Add(Me.txtConfPass)
        Me.pnlPass.Location = New System.Drawing.Point(175, 183)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(564, 166)
        Me.pnlPass.TabIndex = 76
        '
        'btnConfirmPasswordChange
        '
        Me.btnConfirmPasswordChange.Location = New System.Drawing.Point(389, 117)
        Me.btnConfirmPasswordChange.Name = "btnConfirmPasswordChange"
        Me.btnConfirmPasswordChange.Size = New System.Drawing.Size(163, 37)
        Me.btnConfirmPasswordChange.TabIndex = 77
        Me.btnConfirmPasswordChange.Text = "Change Password"
        Me.btnConfirmPasswordChange.UseVisualStyleBackColor = True
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordError.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordError.Location = New System.Drawing.Point(366, 61)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(187, 25)
        Me.lblPasswordError.TabIndex = 85
        Me.lblPasswordError.Text = "Passwords do not match!"
        '
        'lblPwStrength
        '
        Me.lblPwStrength.AutoSize = True
        Me.lblPwStrength.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwStrength.Location = New System.Drawing.Point(265, 12)
        Me.lblPwStrength.Name = "lblPwStrength"
        Me.lblPwStrength.Size = New System.Drawing.Size(74, 25)
        Me.lblPwStrength.TabIndex = 84
        Me.lblPwStrength.Text = "Strength:"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmPassword.Location = New System.Drawing.Point(3, 61)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(137, 25)
        Me.lblConfirmPassword.TabIndex = 83
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(3, 12)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(77, 25)
        Me.lblPassword.TabIndex = 82
        Me.lblPassword.Text = "Password"
        '
        'btnShowPass
        '
        Me.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowPass.Location = New System.Drawing.Point(427, 27)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(84, 31)
        Me.btnShowPass.TabIndex = 81
        Me.btnShowPass.Text = "Show"
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowConfPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowConfPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowConfPass.Location = New System.Drawing.Point(427, 83)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(84, 28)
        Me.btnShowConfPass.TabIndex = 80
        Me.btnShowConfPass.Text = "Show"
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(3, 34)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(417, 28)
        Me.txtPass.TabIndex = 78
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfPass.Location = New System.Drawing.Point(3, 83)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(415, 28)
        Me.txtConfPass.TabIndex = 79
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(179, 140)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(163, 37)
        Me.btnChangePass.TabIndex = 75
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnConfirmEdit
        '
        Me.btnConfirmEdit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnConfirmEdit.FlatAppearance.BorderSize = 0
        Me.btnConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmEdit.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmEdit.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmEdit.Location = New System.Drawing.Point(745, 317)
        Me.btnConfirmEdit.Name = "btnConfirmEdit"
        Me.btnConfirmEdit.Size = New System.Drawing.Size(110, 38)
        Me.btnConfirmEdit.TabIndex = 8
        Me.btnConfirmEdit.Text = "Confirm Edit"
        Me.btnConfirmEdit.UseVisualStyleBackColor = False
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailError.Location = New System.Drawing.Point(567, 84)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(150, 25)
        Me.lblEmailError.TabIndex = 74
        Me.lblEmailError.Text = "Email already exists!"
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameError.Location = New System.Drawing.Point(542, 32)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(185, 25)
        Me.lblUsernameError.TabIndex = 73
        Me.lblUsernameError.Text = "Username already exists!"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(179, 84)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 25)
        Me.lblEmail.TabIndex = 69
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(179, 32)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 25)
        Me.lblUsername.TabIndex = 68
        Me.lblUsername.Text = "Username"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(179, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(507, 28)
        Me.txtEmail.TabIndex = 59
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(179, 57)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(507, 28)
        Me.txtUsername.TabIndex = 58
        '
        'FormCustomerAdminInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.tcSignUp)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "FormCustomerAdminInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCustomerAdminInfo"
        Me.tcSignUp.ResumeLayout(False)
        Me.tpPersonalInfo.ResumeLayout(False)
        Me.tpPersonalInfo.PerformLayout()
        Me.tpAccountDetails.ResumeLayout(False)
        Me.tpAccountDetails.PerformLayout()
        Me.pnlPass.ResumeLayout(False)
        Me.pnlPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents tcSignUp As TabControl
    Friend WithEvents tpPersonalInfo As TabPage
    Friend WithEvents lblAgeContainer As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents lblBirthday As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents tpAccountDetails As TabPage
    Friend WithEvents btnConfirmEdit As Button
    Friend WithEvents lblEmailError As Label
    Friend WithEvents lblUsernameError As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pnlPass As Panel
    Friend WithEvents btnChangePass As Button
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents lblPwStrength As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnShowPass As Button
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents btnConfirmPasswordChange As Button
End Class
