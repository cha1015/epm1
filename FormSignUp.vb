Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormSignUp
    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideErrorLabels()
        txtAdminCode.Visible = False
        lblAdminCode.Visible = False


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

        AddHandler cbRole.SelectedIndexChanged, Sub(x, y) _
        lblRole.Text = If(cbRole.SelectedItem Is Nothing, "Role *", "Role")

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
    Private Sub ValidateAdminCode()
        Dim predefinedAdminCode As String = "SECURE123"

        If txtAdminCode.Text <> predefinedAdminCode Then
            lblAdminCodeError.Text = "Invalid admin authentication code."
            lblAdminCodeError.Visible = True
            Return
        End If
    End Sub

    Private Sub txtConfPass_Leave(sender As Object, e As EventArgs)
        lblPasswordError.Text = If(txtPass.Text <> txtConfPass.Text, "Passwords do not match!", "")
        lblPasswordError.Visible = txtPass.Text <> txtConfPass.Text
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

        Dim hashedPassword As String = HashPassword(txtPass.Text)
        ' Modified query to include additional personal information fields.
        Dim query As String = "INSERT INTO Users (first_name, last_name, username, email, password_hash, role, birthday, age, sex, address) " &
                              "VALUES (@fname, @lname, @uname, @email, @pass, @role, @birthday, @age, @sex, @address)"
        Dim parameters As New Dictionary(Of String, Object) From {
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
            DBHelper.ExecuteQuery(query, parameters)
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginForm As New FormLogIn()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If lblUsernameError.Visible OrElse lblEmailError.Visible OrElse lblPasswordError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub

    Private Function GetAdminCodeFromDatabase(username As String) As String
        Dim query As String = "SELECT admin_code FROM Users WHERE username = @uname"
        Dim parameters As New Dictionary(Of String, Object) From {{"@uname", username}}
        Return Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))
    End Function
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


    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs)
        lblRole.Text = "Role"
        If cbRole.SelectedItem.ToString() = "Admin" Then
            txtAdminCode.Visible = True
            lblAdminCode.Visible = True
        Else
            txtAdminCode.Visible = False
            lblAdminCode.Visible = False
        End If
    End Sub

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

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs)
        If txtPass.PasswordChar = "*"c Then
            txtPass.PasswordChar = ControlChars.NullChar
        Else
            txtPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs)
        If txtConfPass.PasswordChar = "*"c Then
            txtConfPass.PasswordChar = ControlChars.NullChar
        Else
            txtConfPass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If HelperNavigation.ForwardHistory.Count > 0 Then
            Dim nextForm As System.Windows.Forms.Form = HelperNavigation.ForwardHistory.Pop()
            HelperNavigation.GoNext(Me, nextForm, btnNext, btnBack)
        Else
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me, btnNext, btnBack)
    End Sub
End Class