Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormSignUp
    Private passwordVisible As Boolean = True
    Private hasAttemptedSubmitPersonalInfo As Boolean = False
    Private hasAttemptedSubmitAccountDetails As Boolean = False

    Private labels As Label()
    Private fields As TextBox()
    Private texts As String()
    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnShowConfPass.Image = epm1.My.Resources.Resources.BttnHide
        btnShowPass.Image = epm1.My.Resources.Resources.BttnHide

        HelperNavigation.RegisterNewForm(Me)

        HideErrorLabels()

        tpAccountDetails.Enabled = False

        labels = New Label() {lblFirstName, lblLastName, lblUsername, lblEmail, lblPassword, lblConfirmPassword, lblAddress}
        fields = New TextBox() {txtFirstName, txtLastName, txtUsername, txtEmail, txtPass, txtConfPass, txtAddress}
        texts = New String() {"First Name", "Last Name", "Username", "Email", "Password", "Confirm Password", "Address"}

        HelperValidation.ApplyFieldIndicators(labels, texts)

        txtFirstName.Tag = lblFirstName
        txtLastName.Tag = lblLastName
        dtpBirthday.Tag = lblBirthday
        cmbSex.Tag = lblSex
        txtAddress.Tag = lblAddress
        txtUsername.Tag = lblUsername
        txtEmail.Tag = lblEmail
        txtPass.Tag = lblPassword
        txtConfPass.Tag = lblConfirmPassword
        cmbRole.Tag = lblRole

        Me.ActiveControl = txtFirstName
        Me.BeginInvoke(Sub() txtFirstName.Select())

        Dim personalInfoFields As Control() = {txtFirstName, txtLastName, dtpBirthday, cmbSex, txtAddress}
        For Each ctrl In personalInfoFields
            If TypeOf ctrl Is TextBox Then
                AddHandler CType(ctrl, TextBox).TextChanged, AddressOf PersonalInfoField_TextChanged
            ElseIf TypeOf ctrl Is DateTimePicker Then
                AddHandler CType(ctrl, DateTimePicker).ValueChanged, AddressOf PersonalInfoField_TextChanged
            ElseIf TypeOf ctrl Is ComboBox Then
                AddHandler CType(ctrl, ComboBox).SelectedIndexChanged, AddressOf PersonalInfoField_TextChanged
            End If
        Next

        Dim accountDetailFields As Control() = {txtUsername, txtEmail, txtPass, txtConfPass, cmbRole}
        For Each ctrl In accountDetailFields
            If TypeOf ctrl Is TextBox Then
                AddHandler CType(ctrl, TextBox).TextChanged, AddressOf AccountDetailsField_TextChanged
            ElseIf TypeOf ctrl Is ComboBox Then
                AddHandler CType(ctrl, ComboBox).SelectedIndexChanged, AddressOf AccountDetailsField_TextChanged
            End If
        Next

        AddHandler txtUsername.TextChanged, AddressOf CheckUsernameAvailability
        AddHandler txtEmail.TextChanged, AddressOf CheckEmailAvailability
        AddHandler txtPass.TextChanged, AddressOf ShowPasswordStrength
        AddHandler dtpBirthday.ValueChanged, AddressOf dtpBirthday_ValueChanged

        AddHandler cmbSex.SelectedIndexChanged, AddressOf cmbSex_SelectedIndexChanged
        AddHandler txtAddress.TextChanged, AddressOf txtAddress_TextChanged

        AddHandler txtPass.TextChanged, AddressOf PasswordFields_TextChanged
        AddHandler txtConfPass.TextChanged, AddressOf PasswordFields_TextChanged


        dtpBirthday_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub PersonalInfoField_TextChanged(sender As Object, e As EventArgs)
        If hasAttemptedSubmitPersonalInfo Then
            ValidatePersonalInformationFieldsRealTime()

            If ValidatePersonalInformation() Then
                lblRequiredMessage.Visible = False
            Else
                lblRequiredMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub ValidatePersonalInformationFieldsRealTime()
        HelperValidation.MarkFieldInvalidIfEmpty(txtFirstName, "First Name")
        HelperValidation.MarkFieldInvalidIfEmpty(txtLastName, "Last Name")

        Dim birthday As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then age -= 1
        lblAgeContainer.Text = age.ToString()

        Dim birthdayNotChanged As Boolean = (birthday.Date = today)
        Dim ageNotValid As Boolean = (age < 18)

        If birthdayNotChanged Or ageNotValid Then
            lblBirthday.Text = "Birthday *"
            lblBirthday.ForeColor = Color.Red
            lblAge.Text = "Age *"
            lblAge.ForeColor = Color.Red
        Else
            lblBirthday.Text = "Birthday"
            lblBirthday.ForeColor = SystemColors.ControlText
            lblAge.Text = "Age"
            lblAge.ForeColor = SystemColors.ControlText
        End If

        HelperValidation.MarkFieldInvalidIfEmpty(cmbSex, "Sex")
        HelperValidation.MarkFieldInvalidIfEmpty(txtAddress, "Address")
    End Sub

    Private Sub AccountDetailsField_TextChanged(sender As Object, e As EventArgs)
        If hasAttemptedSubmitAccountDetails Then
            ValidateAccountDetailsFieldsRealTime()
        End If
    End Sub

    Private Sub ValidateAccountDetailsFieldsRealTime()
        HelperValidation.MarkFieldInvalidIfEmpty(txtUsername, "Username")
        HelperValidation.MarkFieldInvalidIfEmpty(txtEmail, "Email")
        HelperValidation.MarkFieldInvalidIfEmpty(txtPass, "Password")
        HelperValidation.MarkFieldInvalidIfEmpty(txtConfPass, "Confirm Password")
        HelperValidation.MarkFieldInvalidIfEmpty(cmbRole, "Role")
    End Sub



    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs)
        Dim birthday As Date = dtpBirthday.Value
        Dim today As Date = Date.Today

        If birthday = today Then
            lblAgeContainer.Text = ""
        Else
            Dim age As Integer = today.Year - birthday.Year
            If birthday > today.AddYears(-age) Then age -= 1

            lblAgeContainer.Text = If(age >= 0, age.ToString(), "")

            If hasAttemptedSubmitPersonalInfo Then
                Dim birthdayIsValid As Boolean = (birthday <> today)
                Dim ageIsValid As Boolean = (age >= 18)

                If birthdayIsValid AndAlso ageIsValid Then
                    lblBirthday.Text = "Birthday"
                    lblBirthday.ForeColor = SystemColors.ControlText
                    lblAge.Text = "Age"
                    lblAge.ForeColor = SystemColors.ControlText
                Else
                    lblBirthday.Text = "Birthday *"
                    lblBirthday.ForeColor = Color.Red
                    lblAge.Text = "Age *"
                    lblAge.ForeColor = Color.Red
                End If
            Else
                lblBirthday.Text = "Birthday"
                lblBirthday.ForeColor = SystemColors.ControlText
                lblAge.Text = "Age"
                lblAge.ForeColor = SystemColors.ControlText
            End If
        End If
    End Sub

    Private Sub CheckUsernameAvailability(sender As Object, e As EventArgs)
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE username = @uname"
        Dim parameters As New Dictionary(Of String, Object) From {{"@uname", txtUsername.Text}}
        Dim userExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))
        lblUsernameError.Text = If(userExists > 0, $"Username already exists! Try {txtUsername.Text}123", "")
        lblUsernameError.Visible = userExists > 0
    End Sub


    Private Sub CheckEmailAvailability(sender As Object, e As EventArgs)
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE email = @email"
        Dim parameters As New Dictionary(Of String, Object) From {{"@email", txtEmail.Text}}
        Dim emailExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))
        lblEmailError.Text = If(emailExists > 0, "Email already registered. Try a different one.", "")
        lblEmailError.Visible = emailExists > 0
    End Sub

    Private Sub ShowPasswordStrength(sender As Object, e As EventArgs)
        Dim pwd As String = txtPass.Text

        If String.IsNullOrEmpty(pwd) Then
            lblPwStrength.Visible = False
            lblPwStrength.Text = ""
        Else
            lblPwStrength.Text = CheckPasswordStrength(pwd)
            lblPwStrength.Visible = True
        End If

        ValidatePasswordMatch()
    End Sub


    Private Sub txtConfPass_Leave(sender As Object, e As EventArgs)
        lblPasswordError.Text = If(txtPass.Text <> txtConfPass.Text, "Passwords do not match!", "")
        lblPasswordError.Visible = txtPass.Text <> txtConfPass.Text
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        hasAttemptedSubmitPersonalInfo = True
        ValidatePersonalInformationFieldsRealTime()

        If Not ValidatePersonalInformation() Then
            lblRequiredMessage.Visible = True
            MessageBox.Show("Please complete all required personal information and ensure you meet the age requirement of 18 years old.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ResetAccountDetailsLabels()

        tpAccountDetails.Enabled = True
        tcSignUp.SelectedTab = tpAccountDetails
        lblRequiredMessage.Visible = False

        txtUsername.Focus()
    End Sub

    Private Sub tcSignUp_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcSignUp.Selecting
        If e.TabPage Is tpAccountDetails AndAlso Not tpAccountDetails.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Function ValidatePersonalInformation() As Boolean
        Dim isValid As Boolean = True

        Dim birthday As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then age -= 1

        Dim birthdayNotChanged As Boolean = (birthday.Date = today)
        Dim ageNotValid As Boolean = (age < 18)

        HelperValidation.MarkFieldInvalidIfEmpty(txtFirstName, "First Name")
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then isValid = False

        HelperValidation.MarkFieldInvalidIfEmpty(txtLastName, "Last Name")
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then isValid = False

        HelperValidation.MarkFieldInvalidIfDefault(dtpBirthday, "Birthday")
        If birthdayNotChanged Then isValid = False

        If ageNotValid Then
            isValid = False
        End If

        If birthdayNotChanged Or ageNotValid Then
            lblBirthday.Text = "Birthday *"
            lblBirthday.ForeColor = Color.Red
            lblAge.Text = "Age *"
            lblAge.ForeColor = Color.Red
        Else
            lblBirthday.Text = "Birthday"
            lblBirthday.ForeColor = SystemColors.ControlText
            lblAge.Text = "Age"
            lblAge.ForeColor = SystemColors.ControlText
        End If

        HelperValidation.MarkFieldInvalidIfEmpty(cmbSex, "Sex")
        If cmbSex.SelectedIndex = -1 Then isValid = False

        HelperValidation.MarkFieldInvalidIfEmpty(txtAddress, "Address")
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then isValid = False

        Return isValid
    End Function

    Private Sub cmbSex_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbSex.SelectedIndex <> -1 Then
            lblSex.Text = "Sex"
            lblSex.ForeColor = SystemColors.ControlText
        Else
            lblSex.Text = "Sex *"
            lblSex.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs)
        If Not String.IsNullOrWhiteSpace(txtAddress.Text) Then
            lblAddress.Text = "Address"
            lblAddress.ForeColor = SystemColors.ControlText
        Else
            lblAddress.Text = "Address *"
            lblAddress.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ResetAccountDetailsLabels()
        Dim labels As Label() = {lblUsername, lblEmail, lblPassword, lblConfirmPassword, lblRole}
        Dim defaultTexts As String() = {"Username", "Email", "Password", "Confirm Password", "Role"}

        For i As Integer = 0 To labels.Length - 1
            labels(i).Text = defaultTexts(i)
            labels(i).ForeColor = SystemColors.ControlText
        Next
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        hasAttemptedSubmitAccountDetails = True
        ValidateAccountDetailsFieldsRealTime()

        HideErrorLabels()

        If Not ValidateSignUpFields() Then
            MessageBox.Show("All fields are required.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        CheckUsernameAvailability(Nothing, Nothing)
        CheckEmailAvailability(Nothing, Nothing)
        txtConfPass_Leave(Nothing, Nothing)

        Dim passwordStrength As String = CheckPasswordStrength(txtPass.Text)
        lblPwStrength.Text = passwordStrength
        lblPwStrength.Visible = True

        If passwordStrength.StartsWith("Very Weak") OrElse passwordStrength.StartsWith("Weak Password") Then
            MessageBox.Show("Your password is not strong enough. Please choose a stronger password.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ValidatePasswordMatch()

        If txtPass.Text <> txtConfPass.Text Then
            MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If lblUsernameError.Visible OrElse lblEmailError.Visible OrElse lblPasswordError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.",
                        "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbRole.SelectedItem.ToString() = "Admin" Then
            Dim adminForm As New FormAdminCode()
            If adminForm.ShowDialog() = DialogResult.OK Then
                Dim adminCode As String = adminForm.AdminCode
                If String.Compare(adminCode.Trim(), "SECURE123", True) <> 0 Then
                    MessageBox.Show("Invalid admin authentication code. Please try again.",
                        "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If

        Dim password As String = txtPass.Text

        Dim userQuery As String = "INSERT INTO Users (first_name, last_name, username, email, password, role, birthday, age, sex, address) " &
                              "VALUES (@fname, @lname, @uname, @email, @password, @role, @birthday, @age, @sex, @address); SELECT LAST_INSERT_ID();"
        Dim userParams As New Dictionary(Of String, Object) From {
        {"@fname", txtFirstName.Text},
        {"@lname", txtLastName.Text},
        {"@uname", txtUsername.Text},
        {"@email", txtEmail.Text},
        {"@password", password},
        {"@role", cmbRole.SelectedItem.ToString()},
        {"@birthday", dtpBirthday.Value.Date},
        {"@age", Convert.ToInt32(lblAgeContainer.Text)},
        {"@sex", cmbSex.SelectedItem.ToString()},
        {"@address", txtAddress.Text}
    }

        Try
            Dim newUserIdObj As Object = DBHelper.ExecuteScalarQuery(userQuery, userParams)
            Dim newUserId As Integer = If(newUserIdObj IsNot Nothing, Convert.ToInt32(newUserIdObj), -1)

            If newUserId <= 0 Then
                MessageBox.Show("Account creation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cmbRole.SelectedItem.ToString() <> "Admin" Then
                Dim customerResult As CustomerResult = HelperDatabase.CreateNewCustomer(
                txtFirstName.Text & " " & txtLastName.Text,
                dtpBirthday.Value.Date,
                cmbSex.SelectedItem.ToString(),
                txtAddress.Text,
                Convert.ToInt32(lblAgeContainer.Text),
                newUserId)

                If customerResult.CustomerId <= 0 Then
                    MessageBox.Show("Customer creation failed: " & customerResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginForm As New FormLogIn()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ValidatePasswordMatch()
        Dim pwd As String = txtPass.Text
        Dim confPwd As String = txtConfPass.Text

        If String.IsNullOrEmpty(confPwd) Then
            lblPasswordError.Visible = False
            lblPasswordError.Text = ""
            Return
        End If

        Dim passwordsMatch As Boolean = (pwd = confPwd)
        lblPasswordError.Text = If(passwordsMatch, "", "Passwords do not match!")
        lblPasswordError.Visible = Not passwordsMatch
    End Sub

    Private Sub PasswordFields_TextChanged(sender As Object, e As EventArgs)
        ValidatePasswordMatch()
    End Sub

    Private Function ValidateSignUpFields() As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            HelperValidation.MarkFieldInvalidIfEmpty(txtUsername, "Username")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            HelperValidation.MarkFieldInvalidIfEmpty(txtEmail, "Email")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(txtPass.Text) Then
            HelperValidation.MarkFieldInvalidIfEmpty(txtPass, "Password")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(txtConfPass.Text) OrElse txtPass.Text <> txtConfPass.Text Then
            HelperValidation.MarkFieldInvalidIfEmpty(txtConfPass, "Confirm Password")
            isValid = False
        End If

        If cmbRole.SelectedIndex = -1 Then
            HelperValidation.MarkFieldInvalidIfEmpty(cmbRole, "Role")
            isValid = False
        End If

        If Not ValidatePersonalInformation() Then
            isValid = False
        End If

        Return isValid
    End Function

    Private Function CheckPasswordStrength(password As String) As String
        Dim lengthCriteria As Boolean = password.Length >= 8
        Dim upperCriteria As Boolean = Regex.IsMatch(password, "[A-Z]")
        Dim lowerCriteria As Boolean = Regex.IsMatch(password, "[a-z]")
        Dim numberCriteria As Boolean = Regex.IsMatch(password, "\d")
        Dim specialCriteria As Boolean = Regex.IsMatch(password, "[^a-zA-Z0-9]")

        Dim criteriaMet As Integer = Convert.ToInt32(lengthCriteria) + Convert.ToInt32(upperCriteria) +
                                     Convert.ToInt32(lowerCriteria) + Convert.ToInt32(numberCriteria) +
                                     Convert.ToInt32(specialCriteria)

        Select Case criteriaMet
            Case 0 To 1
                Return "Very Weak Password!"
            Case 2 To 3
                Return "Weak Password!"
            Case 4
                Return "Moderate Password!"
            Case 5
                Return "Strong Password!"
        End Select

        Return "Invalid Password!"
    End Function

    Private Sub lnklblLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblLogIn.LinkClicked
        Dim loginForm As New FormLogIn()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub MoveToNextControlPersonal(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, dtpBirthday.KeyDown, cmbSex.KeyDown, txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub MoveToNextControlAccount(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtEmail.KeyDown, txtPass.KeyDown, txtConfPass.KeyDown, cmbRole.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        passwordVisible = Not passwordVisible

        If passwordVisible Then
            btnShowPass.Image = Nothing
            txtPass.PasswordChar = ControlChars.NullChar
            btnShowPass.Image = epm1.My.Resources.Resources.BttnSeek
        Else
            txtPass.PasswordChar = "*"c
            btnShowPass.Image = Nothing
            btnShowPass.Image = epm1.My.Resources.Resources.BttnHide
        End If
    End Sub

    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs) Handles btnShowConfPass.Click
        passwordVisible = Not passwordVisible

        If passwordVisible Then
            btnShowConfPass.Image = Nothing
            txtConfPass.PasswordChar = ControlChars.NullChar
            btnShowConfPass.Image = epm1.My.Resources.Resources.BttnSeek
        Else
            txtConfPass.PasswordChar = "*"c
            btnShowConfPass.Image = Nothing
            btnShowConfPass.Image = epm1.My.Resources.Resources.BttnHide
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub

    Private Sub tpAccountDetails_Click(sender As Object, e As EventArgs) Handles tpAccountDetails.Click
        ' No action needed here
    End Sub

    Private Sub HideErrorLabels()
        lblRequiredMessage.Visible = False
        lblUsernameError.Visible = False
        lblEmailError.Visible = False
        lblPasswordError.Visible = False
        lblPwStrength.Visible = False
    End Sub

End Class