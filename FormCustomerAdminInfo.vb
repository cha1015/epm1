Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormCustomerAdminInfo
    Private userId As Integer
    Private passwordVisible As Boolean = True
    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    Private Sub FormCustomerAdminInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnShowPass.Image = epm1.My.Resources.Resources.BttnHide
        btnShowConfPass.Image = epm1.My.Resources.Resources.BttnHide

        Dim query As String = "SELECT first_name, last_name, username, email, password, birthday, sex, address FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            txtFirstName.Text = dt.Rows(0)("first_name").ToString()
            txtLastName.Text = dt.Rows(0)("last_name").ToString()
            txtUsername.Text = dt.Rows(0)("username").ToString()
            txtEmail.Text = dt.Rows(0)("email").ToString()
            txtPass.Text = ""
            dtpBirthday.Value = Convert.ToDateTime(dt.Rows(0)("birthday"))
            cmbSex.SelectedItem = dt.Rows(0)("sex").ToString()
            txtAddress.Text = dt.Rows(0)("address").ToString()

            lblAgeContainer.Text = CalculateAge(dtpBirthday.Value).ToString()
        End If

        lblUsernameError.Visible = False
        lblEmailError.Visible = False

        pnlPass.Visible = False
    End Sub

    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1
        Return age
    End Function

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

    Private Sub btnChangePassClick(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim currentPassword As String = InputBox("Please enter your current password:", "Current Password")

        Dim query As String = "SELECT password FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}
        Dim currentPasswordFromDb As String = Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))

        If currentPassword <> currentPasswordFromDb Then
            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        pnlPass.Visible = True
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

        txtPass.PasswordChar = If(txtPass.PasswordChar = "*"c, ControlChars.NullChar, "*"c)
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

        txtConfPass.PasswordChar = If(txtConfPass.PasswordChar = "*"c, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub btnConfirmEdit_Click(sender As Object, e As EventArgs) Handles btnConfirmEdit.Click
        If Not ValidateFormFields() Then
            MessageBox.Show("All fields are required and must be valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If lblUsernameError.Visible OrElse lblEmailError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "SELECT password FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}
        Dim currentPasswordFromDb As String = Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))

        Dim password As String = If(String.IsNullOrWhiteSpace(txtPass.Text), currentPasswordFromDb, txtPass.Text)

        Dim updateQuery As String = "UPDATE Users SET first_name = @first_name, last_name = @last_name, username = @username, email = @email, password = @password, birthday = @birthday, sex = @sex, address = @address WHERE user_id = @user_id"
        Dim updateParams As New Dictionary(Of String, Object) From {
            {"@first_name", txtFirstName.Text},
            {"@last_name", txtLastName.Text},
            {"@username", txtUsername.Text},
            {"@email", txtEmail.Text},
            {"@password", password},
            {"@birthday", dtpBirthday.Value},
            {"@sex", cmbSex.SelectedItem.ToString()},
            {"@address", txtAddress.Text},
            {"@user_id", userId}
        }

        Try
            DBHelper.ExecuteQuery(updateQuery, updateParams)
            MessageBox.Show("Your details have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim roleQuery As String = "SELECT role FROM Users WHERE user_id = @user_id"
            Dim roleParams As New Dictionary(Of String, Object) From {{"@user_id", userId}}
            Dim userRole As String = Convert.ToString(DBHelper.ExecuteScalarQuery(roleQuery, roleParams))

            If userRole = "Admin" Then
                Me.Hide()
                FormAdminCenter.Show()
            ElseIf userRole = "User" Then
                Me.Hide()
                FormCustomerView.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating your details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConfirmPasswordChange_Click(sender As Object, e As EventArgs) Handles btnConfirmPasswordChange.Click
        If txtPass.Text = txtConfPass.Text Then
            Dim query As String = "SELECT password FROM Users WHERE user_id = @user_id"
            Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}
            Dim currentPasswordFromDb As String = Convert.ToString(DBHelper.ExecuteScalarQuery(query, parameters))

            If txtPass.Text = currentPasswordFromDb Then
                If MessageBox.Show("You are attempting to use your old password. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    UpdatePassword()
                End If
            Else
                UpdatePassword()
            End If
        Else
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdatePassword()
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

    Private Sub LoadUserDetails()
        Dim query As String = "SELECT first_name, last_name, username, email, password, birthday, sex, address FROM Users WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        If dt.Rows.Count > 0 Then
            txtFirstName.Text = dt.Rows(0)("first_name").ToString()
            txtLastName.Text = dt.Rows(0)("last_name").ToString()
            txtUsername.Text = dt.Rows(0)("username").ToString()
            txtEmail.Text = dt.Rows(0)("email").ToString()
            txtPass.Text = ""
            dtpBirthday.Value = Convert.ToDateTime(dt.Rows(0)("birthday"))
            cmbSex.SelectedItem = dt.Rows(0)("sex").ToString()
            txtAddress.Text = dt.Rows(0)("address").ToString()

            lblAgeContainer.Text = CalculateAge(dtpBirthday.Value).ToString()
        End If

        pnlPass.Visible = False
    End Sub
    Private Function ValidateFormFields() As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) Then
            isValid = False
        End If

        If cmbSex.SelectedItem Is Nothing Then
            isValid = False
        End If

        Dim age As Integer = DateTime.Now.Year - dtpBirthday.Value.Year
        If dtpBirthday.Value > DateTime.Now.AddYears(-age) Then age -= 1
        If age < 18 Then
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub MoveToNextField(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, dtpBirthday.KeyDown, cmbSex.KeyDown, txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub MoveToNextFieldAccount(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtEmail.KeyDown, btnChangePass.KeyDown, txtPass.KeyDown, txtConfPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If Not ValidateFormFields() Then
            MessageBox.Show("Please complete all required personal information and ensure you meet the age requirement of 18 years old.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If lblUsernameError.Visible OrElse lblEmailError.Visible Then
            MessageBox.Show("Please resolve the indicated errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to change your details?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            tcSignUp.SelectedTab = tpAccountDetails
        Else
            LoadUserDetails()
            MessageBox.Show("Changes have been reverted.", "Changes Reverted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Private Sub FormCustomerAdminInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    Dim bookingForm As FormBooking = Application.OpenForms.OfType(Of FormBooking)().FirstOrDefault()
    '    If bookingForm IsNot Nothing Then
    '        bookingForm.RefreshBookingDetails() ' Explicitly refresh booking details
    '    End If
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub
End Class