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
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.lnklblLogIn = New System.Windows.Forms.LinkLabel()
        Me.btnShowConfPass = New System.Windows.Forms.Button()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.lblUsernameError = New System.Windows.Forms.Label()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblPwStrength = New System.Windows.Forms.Label()
        Me.txtAdminCode = New System.Windows.Forms.TextBox()
        Me.lblAdminCode = New System.Windows.Forms.Label()
        Me.lblRequiredMessage = New System.Windows.Forms.Label()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.lblAdminCodeError = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(221, 378)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(33, 19)
        Me.lblRole.TabIndex = 47
        Me.lblRole.Text = "Role"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmPassword.Location = New System.Drawing.Point(221, 314)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(108, 19)
        Me.lblConfirmPassword.TabIndex = 46
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(221, 244)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 19)
        Me.lblPassword.TabIndex = 45
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(221, 167)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 19)
        Me.lblEmail.TabIndex = 44
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(221, 102)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(65, 19)
        Me.lblUsername.TabIndex = 43
        Me.lblUsername.Text = "Username"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(484, 30)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(67, 19)
        Me.lblLastName.TabIndex = 42
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(221, 30)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(68, 19)
        Me.lblFirstName.TabIndex = 41
        Me.lblFirstName.Text = "First Name"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.Location = New System.Drawing.Point(802, 451)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(110, 38)
        Me.btnSignUp.TabIndex = 37
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnShowPass
        '
        Me.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowPass.Location = New System.Drawing.Point(644, 269)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(84, 24)
        Me.btnShowPass.TabIndex = 39
        Me.btnShowPass.Text = "Show"
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'lnklblLogIn
        '
        Me.lnklblLogIn.AutoSize = True
        Me.lnklblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblLogIn.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblLogIn.ForeColor = System.Drawing.Color.Black
        Me.lnklblLogIn.Location = New System.Drawing.Point(217, 451)
        Me.lnklblLogIn.Name = "lnklblLogIn"
        Me.lnklblLogIn.Size = New System.Drawing.Size(145, 19)
        Me.lnklblLogIn.TabIndex = 36
        Me.lnklblLogIn.TabStop = True
        Me.lnklblLogIn.Text = "I have an account. Log In"
        '
        'btnShowConfPass
        '
        Me.btnShowConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowConfPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowConfPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowConfPass.Location = New System.Drawing.Point(643, 339)
        Me.btnShowConfPass.Name = "btnShowConfPass"
        Me.btnShowConfPass.Size = New System.Drawing.Size(84, 24)
        Me.btnShowConfPass.TabIndex = 38
        Me.btnShowConfPass.Text = "Show"
        Me.btnShowConfPass.UseVisualStyleBackColor = True
        '
        'cbRole
        '
        Me.cbRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRole.ForeColor = System.Drawing.Color.Black
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"User", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(221, 404)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(507, 27)
        Me.cbRole.TabIndex = 40
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(487, 56)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(240, 24)
        Me.txtFirstName.TabIndex = 30
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(221, 56)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(238, 24)
        Me.txtLastName.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(221, 192)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(507, 24)
        Me.txtEmail.TabIndex = 33
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(221, 127)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(507, 24)
        Me.txtUsername.TabIndex = 32
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(221, 269)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(417, 24)
        Me.txtPass.TabIndex = 34
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfPass.Location = New System.Drawing.Point(221, 339)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPass.Size = New System.Drawing.Size(415, 24)
        Me.txtConfPass.TabIndex = 35
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameError.Location = New System.Drawing.Point(581, 105)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(146, 19)
        Me.lblUsernameError.TabIndex = 48
        Me.lblUsernameError.Text = "Username already exists!"
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailError.Location = New System.Drawing.Point(607, 170)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(120, 19)
        Me.lblEmailError.TabIndex = 49
        Me.lblEmailError.Text = "Email already exists!"
        '
        'lblPwStrength
        '
        Me.lblPwStrength.AutoSize = True
        Me.lblPwStrength.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwStrength.Location = New System.Drawing.Point(581, 247)
        Me.lblPwStrength.Name = "lblPwStrength"
        Me.lblPwStrength.Size = New System.Drawing.Size(57, 19)
        Me.lblPwStrength.TabIndex = 50
        Me.lblPwStrength.Text = "Strength:"
        '
        'txtAdminCode
        '
        Me.txtAdminCode.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminCode.ForeColor = System.Drawing.Color.Black
        Me.txtAdminCode.Location = New System.Drawing.Point(734, 407)
        Me.txtAdminCode.Name = "txtAdminCode"
        Me.txtAdminCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminCode.Size = New System.Drawing.Size(152, 24)
        Me.txtAdminCode.TabIndex = 51
        '
        'lblAdminCode
        '
        Me.lblAdminCode.AutoSize = True
        Me.lblAdminCode.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminCode.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminCode.ForeColor = System.Drawing.Color.Black
        Me.lblAdminCode.Location = New System.Drawing.Point(730, 378)
        Me.lblAdminCode.Name = "lblAdminCode"
        Me.lblAdminCode.Size = New System.Drawing.Size(76, 19)
        Me.lblAdminCode.TabIndex = 52
        Me.lblAdminCode.Text = "Admin Code"
        '
        'lblRequiredMessage
        '
        Me.lblRequiredMessage.AutoSize = True
        Me.lblRequiredMessage.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequiredMessage.Location = New System.Drawing.Point(535, 451)
        Me.lblRequiredMessage.Name = "lblRequiredMessage"
        Me.lblRequiredMessage.Size = New System.Drawing.Size(192, 19)
        Me.lblRequiredMessage.TabIndex = 53
        Me.lblRequiredMessage.Text = "Fields marked with * are required."
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordError.ForeColor = System.Drawing.Color.Black
        Me.lblPasswordError.Location = New System.Drawing.Point(581, 314)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(147, 19)
        Me.lblPasswordError.TabIndex = 54
        Me.lblPasswordError.Text = "Passwords do not match!"
        '
        'lblAdminCodeError
        '
        Me.lblAdminCodeError.AutoSize = True
        Me.lblAdminCodeError.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminCodeError.Location = New System.Drawing.Point(892, 412)
        Me.lblAdminCodeError.Name = "lblAdminCodeError"
        Me.lblAdminCodeError.Size = New System.Drawing.Size(47, 19)
        Me.lblAdminCodeError.TabIndex = 55
        Me.lblAdminCodeError.Text = "Invalid."
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(56, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(42, 23)
        Me.btnNext.TabIndex = 87
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(8, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 86
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAdminCodeError)
        Me.Controls.Add(Me.lblPasswordError)
        Me.Controls.Add(Me.lblRequiredMessage)
        Me.Controls.Add(Me.lblAdminCode)
        Me.Controls.Add(Me.txtAdminCode)
        Me.Controls.Add(Me.lblPwStrength)
        Me.Controls.Add(Me.lblEmailError)
        Me.Controls.Add(Me.lblUsernameError)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.lnklblLogIn)
        Me.Controls.Add(Me.btnShowConfPass)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtConfPass)
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRole As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnShowPass As Button
    Friend WithEvents lnklblLogIn As LinkLabel
    Friend WithEvents btnShowConfPass As Button
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents lblUsernameError As Label
    Friend WithEvents lblEmailError As Label
    Friend WithEvents lblPwStrength As Label
    Friend WithEvents txtAdminCode As TextBox
    Friend WithEvents lblAdminCode As Label
    Friend WithEvents lblRequiredMessage As Label
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents lblAdminCodeError As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
