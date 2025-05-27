Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogIn

    Private Sub FormLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HideErrorLabels()
        ResetFieldIndicators()

        AddHandler txtEmail.TextChanged, AddressOf RemoveAsteriskOnInput
        AddHandler txtPass.TextChanged, AddressOf RemoveAsteriskOnInput
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        HideErrorLabels()
        ResetFieldIndicators()

        Dim missingFields As Boolean = False

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then MarkFieldAsMissing(lblEmail) : missingFields = True
        If String.IsNullOrWhiteSpace(txtPass.Text) Then MarkFieldAsMissing(lblPassword) : missingFields = True

        If missingFields Then Return
        txtEmail.Text = txtEmail.Text.Trim()
        txtPass.Text = txtPass.Text.Trim()

        Try
            ValidateUserLogin()
        Catch ex As Exception
            lblGeneralError.Text = "An error occurred during login."
            lblGeneralError.Visible = True
        End Try
    End Sub

    Private Sub ValidateUserLogin()
        Dim query As String = "SELECT user_id, username, email, password_hash, role FROM users WHERE BINARY email = @email"
        Dim parameters As New Dictionary(Of String, Object) From {{"@email", txtEmail.Text}}
        Dim dt As DataTable

        Try
            dt = DBHelper.GetDataTable(query, parameters)
        Catch ex As Exception
            lblGeneralError.Text = "Database error. Please try again."
            lblGeneralError.Visible = True
            Exit Sub
        End Try

        If dt.Rows.Count > 0 Then
            Dim storedHash As String = dt.Rows(0)("password_hash").ToString()
            Dim passwordValid As Boolean
            Try
                passwordValid = VerifyPassword(txtPass.Text, storedHash)
            Catch ex As Exception
                lblGeneralError.Text = "Password verification failed."
                lblGeneralError.Visible = True
                Exit Sub
            End Try

            If passwordValid Then
                Try
                    CurrentUser.UserID = CInt(dt.Rows(0)("user_id"))
                    CurrentUser.Username = dt.Rows(0)("username").ToString()
                    CurrentUser.Email = dt.Rows(0)("email").ToString()
                    CurrentUser.Role = dt.Rows(0)("role").ToString()
                Catch ex As Exception
                    lblGeneralError.Text = "User data error."
                    lblGeneralError.Visible = True
                    Exit Sub
                End Try

                lblGeneralError.Visible = False

                Select Case CurrentUser.Role
                    Case "Admin"
                        Dim adminCode As String = InputBox("Please enter the admin authentication code:", "Admin Authentication")
                        If String.Compare(adminCode.Trim(), "SECURE123", True) <> 0 Then
                            lblGeneralError.Text = "Invalid admin authentication code."
                            lblGeneralError.Visible = True
                            Exit Sub
                        End If
                        CurrentUser.CustomerId = -1
                        MessageBox.Show("Login successful!", "Welcome " & CurrentUser.Username, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Case "User"
                        CurrentUser.CustomerId = CurrentUser.UserID
                        MessageBox.Show("Login successful!", "Welcome " & CurrentUser.Username, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Case Else
                        lblGeneralError.Text = "Invalid role detected! Contact support."
                        lblGeneralError.Visible = True
                End Select
            Else
                lblGeneralError.Text = "Invalid credentials."
                lblGeneralError.Visible = True
            End If
        Else
            lblGeneralError.Text = "Invalid credentials."
            lblGeneralError.Visible = True
        End If
    End Sub

    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Try
            Using sha256 As SHA256 = SHA256.Create()
                Dim inputHash As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword))
                Return Convert.ToBase64String(inputHash) = storedHash
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub ResetFieldIndicators()
        lblEmail.Text = "Email"
        lblPassword.Text = "Password"
    End Sub

    Private Sub MarkFieldAsMissing(lbl As Label)
        lbl.Text &= " *"
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub RemoveAsteriskOnInput(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = CType(sender, TextBox)

        Select Case txtBox.Name
            Case "txtEmail" : lblEmail.Text = "Email"
            Case "txtPass" : lblPassword.Text = "Password"
        End Select
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        txtPass.PasswordChar = If(txtPass.PasswordChar = "*"c, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub lnklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignUp.LinkClicked
        Dim signUpForm As New FormSignUp()
        Me.Hide()
        signUpForm.ShowDialog()
    End Sub

    Private Sub MoveToNextControl(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is txtPass Then
                btnLogIn.PerformClick()
            Else
                SelectNextControl(DirectCast(sender, Control), True, True, True, True)
            End If
        End If
    End Sub

    Private Sub HideErrorLabels()
        lblGeneralError.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub

End Class
