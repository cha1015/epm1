Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormCustomerAdminInfo
    Private userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    Private Sub FormCustomerAdminInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data from database
        Dim query As String = "SELECT first_name, last_name, username, email, password, birthday, sex, address FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            txtFirstName.Text = dt.Rows(0)("first_name").ToString()
            txtLastName.Text = dt.Rows(0)("last_name").ToString()
            txtUsername.Text = dt.Rows(0)("username").ToString()
            txtEmail.Text = dt.Rows(0)("email").ToString()
            txtPass.Text = "" ' Don't pre-fill password
            dtpBirthday.Value = Convert.ToDateTime(dt.Rows(0)("birthday"))
            cmbSex.SelectedItem = dt.Rows(0)("sex").ToString()
            txtAddress.Text = dt.Rows(0)("address").ToString()

            ' Calculate and display age based on birthday
            lblAgeContainer.Text = CalculateAge(dtpBirthday.Value).ToString()
        End If

        lblUsernameError.Visible = False
        lblEmailError.Visible = False

        ' Initially hide the password change panel
        pnlPass.Visible = False
    End Sub

    ' This function calculates age based on birthday
    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1
        Return age
    End Function

    ' This function validates if the entered username/email already exists
    Private Sub CheckUsernameAvailability(sender As Object, e As EventArgs)
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE username = @uname AND user_id != @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@uname", txtUsername.Text},
            {"@user_id", userId}
        }
        Dim userExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))
        lblUsernameError.Visible = userExists > 0
        lblUsernameError.Text = If(userExists > 0, "Username already exists! Try a different one.", "")
    End Sub

    Private Sub CheckEmailAvailability(sender As Object, e As EventArgs)
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE email = @email AND user_id != @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@email", txtEmail.Text},
            {"@user_id", userId}
        }
        Dim emailExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(query, parameters))
        lblEmailError.Visible = emailExists > 0
        lblEmailError.Text = If(emailExists > 0, "Email already registered. Try a different one.", "")
    End Sub

    ' Show password change panel after verifying current password
    Private Sub btnChangePassClick(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim currentPassword As String = InputBox("Please enter your current password:", "Current Password")

        ' Verify current password
        Dim query As String = "SELECT password FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}
        Dim currentPasswordFromDb As String = Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))

        If currentPassword <> currentPasswordFromDb Then
            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Show the password change panel
        pnlPass.Visible = True
    End Sub

    ' Show password field as plain text or asterisks
    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        txtPass.PasswordChar = If(txtPass.PasswordChar = "*"c, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub btnShowConfPass_Click(sender As Object, e As EventArgs) Handles btnShowConfPass.Click
        txtConfPass.PasswordChar = If(txtConfPass.PasswordChar = "*"c, ControlChars.NullChar, "*"c)
    End Sub

    ' Validate input fields before saving the edited data
    Private Sub btnConfirmEdit_Click(sender As Object, e As EventArgs) Handles btnConfirmEdit.Click
        ' Validate the fields before saving
        If Not ValidateFormFields() Then
            MessageBox.Show("All fields are required and must be valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if username or email already exists
        If lblUsernameError.Visible OrElse lblEmailError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If password is changed, only then update password
        Dim password As String = If(String.IsNullOrWhiteSpace(txtPass.Text), txtPass.Text, txtPass.Text) ' Keep current password if not changed

        ' Update the user data
        Dim query As String = "UPDATE Users SET first_name = @first_name, last_name = @last_name, username = @username, email = @email, password = @password, birthday = @birthday, sex = @sex, address = @address WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@first_name", txtFirstName.Text},
            {"@last_name", txtLastName.Text},
            {"@username", txtUsername.Text}, ' Update username here
            {"@email", txtEmail.Text},
            {"@password", password}, ' Use the new password if provided, otherwise keep the old password
            {"@birthday", dtpBirthday.Value},
            {"@sex", cmbSex.SelectedItem.ToString()},
            {"@address", txtAddress.Text},
            {"@user_id", userId}
        }

        Try
            DBHelper.ExecuteQuery(query, parameters)
            MessageBox.Show("Your details have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating your details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Confirm password change (only if the new password is not the same as the old one)
    Private Sub btnConfirmPasswordChange_Click(sender As Object, e As EventArgs) Handles btnConfirmPasswordChange.Click
        If txtPass.Text = txtConfPass.Text Then
            ' Check if the new password is the same as the current password
            Dim query As String = "SELECT password FROM Users WHERE user_id = @user_id"
            Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}
            Dim currentPasswordFromDb As String = Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))

            If txtPass.Text = currentPasswordFromDb Then
                If MessageBox.Show("You are attempting to use your old password. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Proceed with the password change
                    UpdatePassword()
                End If
            Else
                ' Proceed with the password change
                UpdatePassword()
            End If
        Else
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Update password in the database
    Private Sub UpdatePassword()
        ' Update the password in the database
        Dim query As String = "UPDATE Users SET password = @password WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@password", txtPass.Text},
            {"@user_id", userId}
        }

        Try
            DBHelper.ExecuteQuery(query, parameters)
            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            pnlPass.Visible = False
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validate all required fields before saving the changes
    Private Function ValidateFormFields() As Boolean
        Dim isValid As Boolean = True

        ' Check if any required fields are empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) Then
            isValid = False
        End If

        If cmbSex.SelectedItem Is Nothing Then
            isValid = False
        End If

        ' Validate that the user is at least 18 years old based on their birthday
        Dim age As Integer = DateTime.Now.Year - dtpBirthday.Value.Year
        If dtpBirthday.Value > DateTime.Now.AddYears(-age) Then age -= 1
        If age < 18 Then
            isValid = False
        End If

        Return isValid
    End Function

    ' Handle 'Enter' key for form field navigation
    Private Sub MoveToNextField(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, dtpBirthday.KeyDown, cmbSex.KeyDown, txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    ' Handle 'Enter' key for account details navigation
    Private Sub MoveToNextFieldAccount(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtEmail.KeyDown, btnChangePass.KeyDown, txtPass.KeyDown, txtConfPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        ' Validate the fields before proceeding
        If Not ValidateFormFields() Then
            MessageBox.Show("Please complete all required personal information and ensure you meet the age requirement of 18 years old.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check for username/email duplicates
        If lblUsernameError.Visible OrElse lblEmailError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ask user for confirmation to proceed with the changes
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to change your details?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            ' Proceed to the next tab (tpAccountDetails)
            tcSignUp.SelectedTab = tpAccountDetails
        Else
            ' If the user cancels, revert changes and load initial details
            LoadUserDetails() ' Call the method to load the initial data from the database
            MessageBox.Show("Changes have been reverted.", "Changes Reverted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Method to load initial user details in case of canceling the changes
    Private Sub LoadUserDetails()
        ' Load user data from database again
        Dim query As String = "SELECT first_name, last_name, username, email, password, birthday, sex, address FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            txtFirstName.Text = dt.Rows(0)("first_name").ToString()
            txtLastName.Text = dt.Rows(0)("last_name").ToString()
            txtUsername.Text = dt.Rows(0)("username").ToString()
            txtEmail.Text = dt.Rows(0)("email").ToString()
            txtPass.Text = "" ' Don't pre-fill password
            dtpBirthday.Value = Convert.ToDateTime(dt.Rows(0)("birthday"))
            cmbSex.SelectedItem = dt.Rows(0)("sex").ToString()
            txtAddress.Text = dt.Rows(0)("address").ToString()

            ' Calculate and display age based on birthday
            lblAgeContainer.Text = CalculateAge(dtpBirthday.Value).ToString()
        End If

        ' Revert the password change panel visibility
        pnlPass.Visible = False
    End Sub
End Class
