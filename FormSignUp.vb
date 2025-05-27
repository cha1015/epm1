Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormSignUp

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideErrorLabels()

        Dim personalLabels() As Label = {lblFirstName, lblLastName, lblAddress}
        Dim personalFields() As TextBox = {txtFirstName, txtLastName, txtAddress}
        Dim personalTexts() As String = {"First Name", "Last Name", "Address"}
        HelperValidation.ApplyFieldIndicators(personalLabels, personalTexts)
        For i As Integer = 0 To personalFields.Length - 1
            personalFields(i).Tag = personalLabels(i)
        Next

        Dim accountLabels() As Label = {lblUsername, lblEmail, lblPassword, lblConfirmPassword}
        Dim accountFields() As TextBox = {txtUsername, txtEmail, txtPass, txtConfPass}
        Dim accountTexts() As String = {"Username", "Email", "Password", "Confirm Password"}
        HelperValidation.ApplyFieldIndicators(accountLabels, accountTexts)
        For i As Integer = 0 To accountFields.Length - 1
            accountFields(i).Tag = accountLabels(i)
            AddHandler accountFields(i).TextChanged, Sub(ctrl As Object, evArgs As EventArgs)
                                                         HelperValidation.ValidateFieldsInRealTime(accountFields, accountLabels, accountTexts)
                                                     End Sub
            AddHandler accountFields(i).Leave, Sub(ctrl As Object, evArgs As EventArgs)
                                                   HelperValidation.RemoveAsteriskOnInput(ctrl, accountLabels, accountTexts)
                                               End Sub
        Next

        cmbRole.Tag = lblRole

        Me.ActiveControl = txtFirstName
        Me.BeginInvoke(Sub() txtFirstName.Select())

        AddHandler txtUsername.TextChanged, AddressOf CheckUsernameAvailability
        AddHandler txtEmail.TextChanged, AddressOf CheckEmailAvailability
        AddHandler txtPass.TextChanged, AddressOf ShowPasswordStrength
        AddHandler dtpBirthday.ValueChanged, AddressOf dtpBirthday_ValueChanged
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs)
        Dim birthday As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then age -= 1
        lblAgeContainer.Text = age.ToString()
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
        lblPwStrength.Text = CheckPasswordStrength(txtPass.Text)
        lblPwStrength.Visible = True
    End Sub

    Private Sub txtConfPass_Leave(sender As Object, e As EventArgs)
        lblPasswordError.Text = If(txtPass.Text <> txtConfPass.Text, "Passwords do not match!", "")
        lblPasswordError.Visible = txtPass.Text <> txtConfPass.Text
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If Not ValidatePersonalInformation() Then
            MessageBox.Show("Please complete all required personal information and ensure you meet the age requirement of 18 years old.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ensure navigation moves to the next tab page upon successful validation
        tcSignUp.SelectedTab = tpAccountDetails
    End Sub


    Private Function ValidatePersonalInformation() As Boolean
        Dim isValid As Boolean = True
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            HelperValidation.MarkFieldInvalid(txtFirstName, "First Name", "First Name is required.")
            isValid = False
        Else
            HelperValidation.ClearFieldError(txtFirstName, "First Name")
        End If
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            HelperValidation.MarkFieldInvalid(txtLastName, "Last Name", "Last Name is required.")
            isValid = False
        Else
            HelperValidation.ClearFieldError(txtLastName, "Last Name")
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            HelperValidation.MarkFieldInvalid(txtAddress, "Address", "Address is required.")
            isValid = False
        Else
            HelperValidation.ClearFieldError(txtAddress, "Address")
        End If
        If Not HelperValidation.ValidateCustomerAge(dtpBirthday) Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        HideErrorLabels()

        ' Run validation before proceeding
        If Not ValidateSignUpFields() Then
            ' Show general message if validation fails
            MessageBox.Show("All fields are required.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check for availability of username and email, then show password validation
        CheckUsernameAvailability(Nothing, Nothing)
        CheckEmailAvailability(Nothing, Nothing)
        txtConfPass_Leave(Nothing, Nothing)

        Dim passwordStrength As String = CheckPasswordStrength(txtPass.Text)
        If passwordStrength.StartsWith("Very Weak") OrElse passwordStrength.StartsWith("Weak Password") Then
            MessageBox.Show("Your password is not strong enough. Please choose a stronger password.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblPwStrength.Text = passwordStrength
            lblPwStrength.Visible = True
            Exit Sub
        End If

        If lblUsernameError.Visible OrElse lblEmailError.Visible OrElse lblPasswordError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.",
                        "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Admin code validation for admin role
        If cmbRole.SelectedItem.ToString() = "Admin" Then
            Dim adminCode As String = InputBox("Please enter the admin authentication code:", "Admin Authentication")
            If adminCode <> "SECURE123" Then
                MessageBox.Show("Invalid admin authentication code. Please try again.",
                            "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim password As String = txtPass.Text ' Use plain-text password directly

        ' Create new user query
        Dim userQuery As String = "INSERT INTO Users (first_name, last_name, username, email, password, role, birthday, age, sex, address) " &
                              "VALUES (@fname, @lname, @uname, @email, @password, @role, @birthday, @age, @sex, @address); SELECT LAST_INSERT_ID();"
        Dim userParams As New Dictionary(Of String, Object) From {
        {"@fname", txtFirstName.Text},
        {"@lname", txtLastName.Text},
        {"@uname", txtUsername.Text},
        {"@email", txtEmail.Text},
        {"@password", password}, ' Insert plain-text password directly
        {"@role", cmbRole.SelectedItem.ToString()},
        {"@birthday", dtpBirthday.Value.Date},
        {"@age", Convert.ToInt32(lblAgeContainer.Text)},
        {"@sex", cmbSex.SelectedItem.ToString()},
        {"@address", txtAddress.Text}
    }

        Try
            ' Execute the query to insert the new user
            Dim newUserIdObj As Object = DBHelper.ExecuteScalarQuery(userQuery, userParams)
            Dim newUserId As Integer = If(newUserIdObj IsNot Nothing, Convert.ToInt32(newUserIdObj), -1)

            If newUserId <= 0 Then
                MessageBox.Show("Account creation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If the user is not an admin, insert customer information
            If cmbRole.SelectedItem.ToString() <> "Admin" Then
                Dim customerQuery As String = "INSERT INTO Customers (user_id, name, birthday, age, sex, address) " &
                                          "VALUES (@user_id, @name, @birthday, @age, @sex, @address)"
                Dim customerParams As New Dictionary(Of String, Object) From {
                {"@user_id", newUserId},
                {"@name", txtFirstName.Text & " " & txtLastName.Text},
                {"@birthday", dtpBirthday.Value.Date},
                {"@age", Convert.ToInt32(lblAgeContainer.Text)},
                {"@sex", cmbSex.SelectedItem.ToString()},
                {"@address", txtAddress.Text}
            }
                DBHelper.ExecuteQuery(customerQuery, customerParams)
            End If

            ' Success message and navigate to login page
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginForm As New FormLogIn()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SetMissingFieldIndicator(txtBox As TextBox)
        txtBox.Text = "Required"
        txtBox.ForeColor = Color.Gray
        AddHandler txtBox.GotFocus, AddressOf RemovePlaceholder
        AddHandler txtBox.LostFocus, AddressOf RestorePlaceholder
    End Sub

    Private Sub RemovePlaceholder(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = CType(sender, TextBox)
        If txtBox.Text = "Required" Then
            txtBox.Text = ""
            txtBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RestorePlaceholder(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(txtBox.Text) Then
            txtBox.Text = "Required"
            txtBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub HideErrorLabels()
        lblRequiredMessage.Visible = False
        lblUsernameError.Visible = False
        lblEmailError.Visible = False
        lblPasswordError.Visible = False
        lblPwStrength.Visible = False
        lblAdminCodeError.Visible = False
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(hashedBytes)
        End Using
    End Function

    Private Function ValidateSignUpFields() As Boolean
        Dim isValid As Boolean = True
        Dim missingFields As Boolean = False ' To track if any fields are missing

        ' Validate Personal Information Fields
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then missingFields = True
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then missingFields = True
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then missingFields = True
        If Not HelperValidation.ValidateCustomerAge(dtpBirthday) Then missingFields = True

        ' Validate Account Details Fields
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then missingFields = True
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then missingFields = True
        If String.IsNullOrWhiteSpace(txtPass.Text) Then missingFields = True
        If String.IsNullOrWhiteSpace(txtConfPass.Text) OrElse txtPass.Text <> txtConfPass.Text Then missingFields = True

        ' Validate ComboBoxes (cmbSex and cmbRole)
        If cmbSex.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(cmbSex.SelectedItem.ToString()) Then missingFields = True
        If cmbRole.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(cmbRole.SelectedItem.ToString()) Then missingFields = True

        ' Show the general error message if any fields are missing
        If missingFields Then
            MessageBox.Show("All fields are required.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If

        ' Ensure the user is 18 years or older based on the birthday
        Dim age As Integer = DateTime.Now.Year - dtpBirthday.Value.Year
        If dtpBirthday.Value > DateTime.Now.AddYears(-age) Then age -= 1
        If age < 18 Then
            MessageBox.Show("You must be at least 18 years old to sign up.", "Age Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If

        ' Validate password strength
        Dim passwordStrength As String = CheckPasswordStrength(txtPass.Text)
        If passwordStrength.StartsWith("Very Weak") OrElse passwordStrength.StartsWith("Weak Password") Then
            MessageBox.Show("Your password is not strong enough. Please choose a stronger password.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblPwStrength.Text = passwordStrength
            lblPwStrength.Visible = True
            isValid = False
        End If

        ' Ensure password and confirm password match
        If txtPass.Text <> txtConfPass.Text Then
            MessageBox.Show("Passwords must match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                Return "Very Weak Password! Increase length and add varied characters."
            Case 2 To 3
                Return "Weak Password! Consider adding uppercase, lowercase, numbers, and special characters."
            Case 4
                Return "Moderate Password! Almost there—consider making it longer for extra security."
            Case 5
                Return "Strong Password! Your password is secure."
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
        If txtPass.PasswordChar = "*"c Then
            txtPass.PasswordChar = ControlChars.NullChar
        Else
            txtPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs) Handles btnShowConfPass.Click
        If txtConfPass.PasswordChar = "*"c Then
            txtConfPass.PasswordChar = ControlChars.NullChar
        Else
            txtConfPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub

End Class
