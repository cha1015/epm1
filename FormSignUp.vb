'Imports MySql.Data.MySqlClient
'Imports System.Security.Cryptography
'Imports System.Text
'Imports System.Text.RegularExpressions

'Public Class FormSignUp
'    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        HideErrorLabels()

'        Dim labels As Label() = {lblFirstName, lblLastName, lblUsername, lblEmail, lblPassword, lblConfirmPassword, lblRole, lblAge, lblAddress}
'        Dim fields As TextBox() = {txtFirstName, txtLastName, txtUsername, txtEmail, txtPass, txtConfPass, txtAddress}
'        Dim texts As String() = {"First Name", "Last Name", "Username", "Email", "Password", "Confirm Password", "Role", "Age", "Address"}

'        HelperValidation.ApplyFieldIndicators(labels, texts)

'        Me.ActiveControl = txtFirstName
'        Me.BeginInvoke(Sub() txtFirstName.Select())

'        For Each field As TextBox In fields
'            AddHandler field.TextChanged, Sub(ctrl As Object, evArgs As EventArgs)
'                                              HelperValidation.ValidateFieldsInRealTime(fields, labels, texts)
'                                          End Sub
'            AddHandler field.Leave, Sub(ctrl As Object, evArgs As EventArgs)
'                                        HelperValidation.RemoveAsteriskOnInput(ctrl, labels, texts)
'                                    End Sub
'        Next

'        AddHandler txtUsername.TextChanged, AddressOf CheckUsernameAvailability
'        AddHandler txtEmail.TextChanged, AddressOf CheckEmailAvailability
'        AddHandler txtPass.TextChanged, AddressOf ShowPasswordStrength

'        AddHandler dtpBirthday.ValueChanged, AddressOf dtpBirthday_ValueChanged
'    End Sub
'    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs)
'        Dim birthday As Date = dtpBirthday.Value
'        Dim today As Date = Date.Today
'        Dim age As Integer = today.Year - birthday.Year
'        If birthday > today.AddYears(-age) Then age -= 1
'        lblAgeContainer.Text = age.ToString()
'    End Sub

'    Private Sub CheckUsernameAvailability(sender As Object, e As EventArgs)
'        Dim query As String = "SELECT COUNT(*) FROM Users WHERE username = @uname"
'        Dim parameters As New Dictionary(Of String, Object) From {{"@uname", txtUsername.Text}}

'        Dim userExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))

'        lblUsernameError.Text = If(userExists > 0, $"Username already exists! Try {txtUsername.Text}123", "")
'        lblUsernameError.Visible = userExists > 0
'    End Sub

'    Private Sub CheckEmailAvailability(sender As Object, e As EventArgs)
'        Dim query As String = "SELECT COUNT(*) FROM Users WHERE email = @email"
'        Dim parameters As New Dictionary(Of String, Object) From {{"@email", txtEmail.Text}}

'        Dim emailExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))

'        lblEmailError.Text = If(emailExists > 0, "Email already registered. Try a different one.", "")
'        lblEmailError.Visible = emailExists > 0
'    End Sub


'    Private Sub ShowPasswordStrength(sender As Object, e As EventArgs)
'        lblPwStrength.Text = CheckPasswordStrength(txtPass.Text)
'        lblPwStrength.Visible = True
'    End Sub

'    Private Sub txtConfPass_Leave(sender As Object, e As EventArgs)
'        lblPasswordError.Text = If(txtPass.Text <> txtConfPass.Text, "Passwords do not match!", "")
'        lblPasswordError.Visible = txtPass.Text <> txtConfPass.Text
'    End Sub

'    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
'        HideErrorLabels()

'        CheckUsernameAvailability(Nothing, Nothing)
'        CheckEmailAvailability(Nothing, Nothing)
'        txtConfPass_Leave(Nothing, Nothing)

'        If lblUsernameError.Visible OrElse lblEmailError.Visible OrElse lblPasswordError.Visible Then
'            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        ' For Admin registrations, prompt for the admin authentication code.
'        If cbRole.SelectedItem.ToString() = "Admin" Then
'            Dim adminCode As String = InputBox("Please enter the admin authentication code:", "Admin Authentication")
'            If adminCode <> "SECURE123" Then
'                MessageBox.Show("Invalid admin authentication code. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Exit Sub
'            End If
'        End If

'        Dim hashedPassword As String = HashPassword(txtPass.Text)
'        Dim userQuery As String = "INSERT INTO Users (first_name, last_name, username, email, password_hash, role, birthday, age, sex, address) " &
'                                 "VALUES (@fname, @lname, @uname, @email, @pass, @role, @birthday, @age, @sex, @address); SELECT LAST_INSERT_ID();"
'        Dim userParams As New Dictionary(Of String, Object) From {
'            {"@fname", txtFirstName.Text},
'            {"@lname", txtLastName.Text},
'            {"@uname", txtUsername.Text},
'            {"@email", txtEmail.Text},
'            {"@pass", hashedPassword},
'            {"@role", cbRole.SelectedItem.ToString()},
'            {"@birthday", dtpBirthday.Value.Date},
'            {"@age", Convert.ToInt32(lblAgeContainer.Text)},
'            {"@sex", cmbSex.SelectedItem.ToString()},
'            {"@address", txtAddress.Text}
'        }

'        Try
'            Dim newUserIdObj As Object = DBHelper.ExecuteScalarQuery(userQuery, userParams)
'            Dim newUserId As Integer = If(newUserIdObj IsNot Nothing, Convert.ToInt32(newUserIdObj), -1)

'            If newUserId <= 0 Then
'                MessageBox.Show("Account creation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return
'            End If

'            ' Only insert into the Customers table if the role is NOT Admin.
'            If cbRole.SelectedItem.ToString() <> "Admin" Then
'                Dim customerQuery As String = "INSERT INTO Customers (user_id, name, birthday, age, sex, address) " &
'                                              "VALUES (@user_id, @name, @birthday, @age, @sex, @address)"
'                Dim customerParams As New Dictionary(Of String, Object) From {
'                    {"@user_id", newUserId},
'                    {"@name", txtFirstName.Text & " " & txtLastName.Text},
'                    {"@birthday", dtpBirthday.Value.Date},
'                    {"@age", Convert.ToInt32(lblAgeContainer.Text)},
'                    {"@sex", cmbSex.SelectedItem.ToString()},
'                    {"@address", txtAddress.Text}
'                }
'                DBHelper.ExecuteQuery(customerQuery, customerParams)
'            End If

'            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Me.Hide()
'            Dim loginForm As New FormLogIn()
'            loginForm.Show()
'        Catch ex As Exception
'            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Function GetAdminCodeFromDatabase(username As String) As String
'        Dim query As String = "SELECT admin_code FROM Users WHERE username = @uname"
'        Dim parameters As New Dictionary(Of String, Object) From {{"@uname", username}}
'        Return Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))
'    End Function
'    Private Sub SetMissingFieldIndicator(txtBox As TextBox)
'        txtBox.Text = "Required"
'        txtBox.ForeColor = Color.Gray
'        AddHandler txtBox.GotFocus, AddressOf RemovePlaceholder
'        AddHandler txtBox.LostFocus, AddressOf RestorePlaceholder
'    End Sub

'    Private Sub RemovePlaceholder(sender As Object, e As EventArgs)
'        Dim txtBox As TextBox = CType(sender, TextBox)
'        If txtBox.Text = "Required" Then
'            txtBox.Text = ""
'            txtBox.ForeColor = Color.Black
'        End If
'    End Sub

'    Private Sub RestorePlaceholder(sender As Object, e As EventArgs)
'        Dim txtBox As TextBox = CType(sender, TextBox)
'        If String.IsNullOrWhiteSpace(txtBox.Text) Then
'            txtBox.Text = "Required"
'            txtBox.ForeColor = Color.Gray
'        End If
'    End Sub

'    Private Sub HideErrorLabels()
'        lblRequiredMessage.Visible = False
'        lblUsernameError.Visible = False
'        lblEmailError.Visible = False
'        lblPasswordError.Visible = False
'        lblPwStrength.Visible = False
'        lblAdminCodeError.Visible = False
'    End Sub

'    Private Function HashPassword(password As String) As String
'        Dim sha256 As SHA256 = SHA256.Create()
'        Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
'        Return Convert.ToBase64String(hashedBytes)
'    End Function

'    Private Function CheckPasswordStrength(password As String) As String
'        Dim lengthCriteria As Boolean = password.Length >= 8
'        Dim upperCriteria As Boolean = Regex.IsMatch(password, "[A-Z]")
'        Dim lowerCriteria As Boolean = Regex.IsMatch(password, "[a-z]")
'        Dim numberCriteria As Boolean = Regex.IsMatch(password, "\d")
'        Dim specialCriteria As Boolean = Regex.IsMatch(password, "[^a-zA-Z0-9]")

'        Dim criteriaMet As Integer = Convert.ToInt32(lengthCriteria) + Convert.ToInt32(upperCriteria) +
'                                 Convert.ToInt32(lowerCriteria) + Convert.ToInt32(numberCriteria) +
'                                 Convert.ToInt32(specialCriteria)

'        Select Case criteriaMet
'            Case 0 To 1
'                Return "Very Weak Password! Increase length and add varied characters."
'            Case 2 To 3
'                Return "Weak Password! Consider adding uppercase, lowercase, numbers, and special characters."
'            Case 4
'                Return "Moderate Password! Almost there—consider making it longer for extra security."
'            Case 5
'                Return "Strong Password! Your password is secure."
'        End Select

'        Return "Invalid Password!"
'    End Function


'    Private Sub lnklblLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblLogIn.LinkClicked
'        Dim loginForm As New FormLogIn()
'        loginForm.Show()
'        Me.Hide()
'    End Sub

'    Private Sub MoveToNextControl(sender As Object, e As KeyEventArgs)
'        If e.KeyCode = Keys.Enter Then
'            e.SuppressKeyPress = True
'            If sender Is cbRole Then
'                btnSignUp.PerformClick()
'            Else
'                SelectNextControl(DirectCast(sender, Control), True, True, True, True)
'            End If
'        End If
'    End Sub

'    Private Sub btnShowPass_Click(sender As Object, e As EventArgs)
'        If txtPass.PasswordChar = "*"c Then
'            txtPass.PasswordChar = ControlChars.NullChar
'        Else
'            txtPass.PasswordChar = "*"c
'        End If
'    End Sub

'    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs)
'        If txtConfPass.PasswordChar = "*"c Then
'            txtConfPass.PasswordChar = ControlChars.NullChar
'        Else
'            txtConfPass.PasswordChar = "*"c
'        End If
'    End Sub



'    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

'    End Sub

'    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
'        If HelperNavigation.ForwardHistory.Count > 0 Then
'            Dim nextForm As System.Windows.Forms.Form = HelperNavigation.ForwardHistory.Pop()
'            HelperNavigation.GoNext(Me, nextForm, btnNext, btnBack)
'        Else
'            btnNext.Enabled = False
'        End If

'    End Sub

'    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
'        HelperNavigation.GoBack(Me, btnNext, btnBack)
'    End Sub
'End Class


'--------------------------------------------------------------------------------------------------------------------'














Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormSignUp

    Private passwordVisible As Boolean = True


    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideErrorLabels()

        tpAccountDetails.Enabled = False ' Disable tab until user proceeds

        Dim labels As Label() = {lblFirstName, lblLastName, lblUsername, lblEmail, lblPassword, lblConfirmPassword, lblRole, lblAge, lblAddress}
        Dim fields As TextBox() = {txtFirstName, txtLastName, txtUsername, txtEmail, txtPass, txtConfPass, txtAddress}
        Dim texts As String() = {"First Name", "Last Name", "Username", "Email", "Password", "Confirm Password", "Role", "Age", "Address"}

        HelperValidation.ApplyFieldIndicators(labels, texts)

        Me.ActiveControl = txtFirstName
        Me.BeginInvoke(Sub() txtFirstName.Select())

        For Each field As TextBox In fields
            AddHandler field.TextChanged, Sub(ctrl As Object, evArgs As EventArgs)
                                              HelperValidation.ValidateFieldsInRealTime(fields, labels, texts)
                                          End Sub
            AddHandler field.Leave, Sub(ctrl As Object, evArgs As EventArgs)
                                        HelperValidation.RemoveAsteriskOnInput(ctrl, labels, texts)
                                    End Sub
        Next

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
        lblRequiredMessage.Visible = False

        ' Calculate age
        Dim birthday As Date = dtpBirthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then age -= 1
        lblAgeContainer.Text = age.ToString()

        ' Check age restriction first
        If age < 18 Then
            MessageBox.Show("You must be 18 years old or above to proceed.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Arrays for fields and labels for HelperValidation
        Dim labels As Label() = {lblFirstName, lblLastName, lblUsername, lblEmail, lblPassword, lblConfirmPassword, lblRole, lblAge, lblAddress}
        Dim fields As TextBox() = {txtFirstName, txtLastName, txtUsername, txtEmail, txtPass, txtConfPass, txtAddress}
        Dim texts As String() = {"First Name", "Last Name", "Username", "Email", "Password", "Confirm Password", "Role", "Age", "Address"}

        ' Run your helper to show asterisks on empty textbox fields
        HelperValidation.ApplyFieldIndicators(labels, texts)
        HelperValidation.ValidateFieldsInRealTime(fields, labels, texts)

        ' Manually check ComboBox cmbSex (since HelperValidation probably does not handle it)
        Dim missingFields As Boolean = False
        If cmbSex.SelectedIndex = -1 Then
            lblSex.Text = "Sex *"
            missingFields = True
        Else
            lblSex.Text = "Sex"
        End If

        ' Check if any of the textbox required fields are empty (using fields you want required)
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
       cmbSex.SelectedIndex = -1 Then

            missingFields = True
        End If

        If missingFields Then
            lblRequiredMessage.Text = "Fields marked with * are required."
            lblRequiredMessage.Visible = True
            Return
        End If

        ' If all validations passed, enable and switch tab
        tpAccountDetails.Enabled = True
        tcSignUp.SelectedTab = tpAccountDetails
    End Sub







    Private Sub tcSignUp_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tcSignUp.Selecting
        If e.TabPage Is tpAccountDetails AndAlso Not tpAccountDetails.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        HideErrorLabels()

        CheckUsernameAvailability(Nothing, Nothing)
        CheckEmailAvailability(Nothing, Nothing)
        txtConfPass_Leave(Nothing, Nothing)

        If lblUsernameError.Visible OrElse lblEmailError.Visible OrElse lblPasswordError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbRole.SelectedItem.ToString() = "Admin" Then
            Dim adminCode As String = InputBox("Please enter the admin authentication code:", "Admin Authentication")
            If adminCode <> "SECURE123" Then
                MessageBox.Show("Invalid admin authentication code. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim hashedPassword As String = HashPassword(txtPass.Text)
        Dim userQuery As String = "INSERT INTO Users (first_name, last_name, username, email, password_hash, role, birthday, age, sex, address) " &
                                 "VALUES (@fname, @lname, @uname, @email, @pass, @role, @birthday, @age, @sex, @address); SELECT LAST_INSERT_ID();"
        Dim userParams As New Dictionary(Of String, Object) From {
            {"@fname", txtFirstName.Text},
            {"@lname", txtLastName.Text},
            {"@uname", txtUsername.Text},
            {"@email", txtEmail.Text},
            {"@pass", hashedPassword},
            {"@role", cbRole.SelectedItem.ToString()},
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

            If cbRole.SelectedItem.ToString() <> "Admin" Then
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

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginForm As New FormLogIn()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        Dim sha256 As SHA256 = SHA256.Create()
        Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
        Return Convert.ToBase64String(hashedBytes)
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

    Private Sub MoveToNextControl(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is cbRole Then
                btnSignUp.PerformClick()
            Else
                SelectNextControl(DirectCast(sender, Control), True, True, True, True)
            End If
        End If
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click

        passwordVisible = Not passwordVisible
        btnShowPass.Image = epm1.My.Resources.Resources.BttnHide

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
        btnShowConfPass.Image = epm1.My.Resources.Resources.BttnHide

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
        HelperNavigation.GoBack(Me, btnNext, btnBack)
    End Sub

    Private Sub btnShowPass_Click_1(sender As Object, e As EventArgs) Handles btnShowPass.Click

    End Sub
End Class



