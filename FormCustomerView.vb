﻿Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class FormCustomerView

    Private customerId As Integer
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        customerId = id
    End Sub

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCurrentBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Ensure correct customerId based on the current user
        customerId = GetCustomerIdByUserId(CurrentUser.UserID)

        Debug.WriteLine($"CustomerId in FormCustomerView_Load: {customerId}")

        lblUsername.Text = CurrentUser.Username
        LoadBookings()
        LoadPaymentHistory()
    End Sub

    Private Function GetCustomerIdByUserId(userId As Integer) As Integer
        Dim query As String = "SELECT customer_id FROM usercustomers WHERE user_id = @user_id"
        Dim parameters As New Dictionary(Of String, Object) From {{"@user_id", userId}}

        Try
            Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("customer_id"))
            Else
                Return -1 ' or handle error appropriately
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching customer ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Private Sub LoadBookings()
        Debug.WriteLine($"Loading bookings for CustomerId: @customerId")

        dgvPaymentHistory.ClearSelection()

        ' Log query parameters
        Debug.WriteLine($"Executing Query with customer_id: @customerId")

        Dim query As String = "SELECT b.booking_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status 
                           FROM bookings b
                           JOIN eventplace p ON b.place_id = p.place_id 
                           WHERE b.customer_id = @customer_id
                           ORDER BY b.event_date DESC"

        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

        Try
            ' Retrieve data
            Dim dtBookings As DataTable = DBHelper.GetDataTable(query, parameters)

            ' Debugging: Check if dtBookings contains rows
            If dtBookings Is Nothing OrElse dtBookings.Rows.Count = 0 Then
                Debug.WriteLine("No bookings found.")
            Else
                Debug.WriteLine($"Found {dtBookings.Rows.Count} bookings.")
            End If

            If dtBookings.Rows.Count > 0 Then
                dgvCurrentBooking.DataSource = dtBookings
                btnSelectBooking.Enabled = True
                btnConfirmPayment.Enabled = True
            Else
                ' No bookings found, provide a message
                Dim dtPlaceholder As New DataTable()
                dtPlaceholder.Columns.Add("Message", GetType(String))
                dtPlaceholder.Rows.Add("No bookings found. Start by booking an event!")
                dgvCurrentBooking.DataSource = dtPlaceholder
                btnSelectBooking.Enabled = False
                btnConfirmPayment.Enabled = False
                dgvCurrentBooking.Refresh()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadPaymentHistory()
        Dim query As String = "SELECT payment_id, amount_to_pay, amount_paid, payment_date, payment_status 
                           FROM payments WHERE customer_id = @customer_id"

        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

        Try
            Dim dtPayments As DataTable = DBHelper.GetDataTable(query, parameters)

            If dtPayments.Rows.Count > 0 Then
                dgvPaymentHistory.DataSource = dtPayments
                dgvPaymentHistory.ClearSelection()
            Else
                dgvPaymentHistory.DataSource = Nothing
                dgvPaymentHistory.ClearSelection()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error loading payment history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPayButtonColumn()
        Dim btnColumn As New DataGridViewButtonColumn()
        btnColumn.Name = "btnSelectBooking"
        btnColumn.HeaderText = "Action"
        btnColumn.Text = "Pay Now"
        btnColumn.UseColumnTextForButtonValue = True
        dgvPaymentHistory.Columns.Add(btnColumn)
    End Sub

    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New FormCustomerAdminInfo(CurrentUser.UserID)
        editForm.ShowDialog()
    End Sub


    Private Sub btnMain_Click(sender As Object, e As EventArgs)
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CurrentUser.UserID = -1
            CurrentUser.Username = String.Empty
            CurrentUser.Email = String.Empty
            CurrentUser.Role = String.Empty
            CurrentUser.CustomerId = -1

            Me.Refresh()
            Application.DoEvents()

            Dim mainForm As New FormMain()
            mainForm.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnSelectBooking_Click_1(sender As Object, e As EventArgs) Handles btnSelectBooking.Click
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a payment to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

        If paymentStatus = "Pending" Then
            Dim query As String = "UPDATE payments SET payment_status = 'Paid', payment_date = NOW(), amount_paid = amount_to_pay WHERE payment_id = @payment_id"
            Dim parameters As New Dictionary(Of String, Object) From {{"@payment_id", paymentId}}

            Try
                DBHelper.ExecuteQuery(query, parameters)
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPaymentHistory() ' Refresh payment records
            Catch ex As MySqlException
                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("This payment is already completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnConfirmPayment_Click_1(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim amountDue As Decimal = Convert.ToDecimal(dgvPaymentHistory.SelectedRows(0).Cells("amount_to_pay").Value)
        Dim amountPaid As Decimal

        If Not Decimal.TryParse(txtPaymentAmount.Text, amountPaid) OrElse amountPaid < amountDue Then
            MessageBox.Show("Invalid amount. You must pay at least the due amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If paymentStatus = "Approved" Then
            Dim paymentId As Integer = Convert.ToInt32(dgvPaymentHistory.SelectedRows(0).Cells("payment_id").Value)

            Dim query As String = "UPDATE payments SET amount_paid = @amountPaid, payment_status = 'Paid', payment_date = NOW() WHERE payment_id = @payment_id"
            Dim parameters As New Dictionary(Of String, Object) From {
            {"@payment_id", paymentId},
            {"@amountPaid", amountPaid}
        }

            Try
                DBHelper.ExecuteQuery(query, parameters)
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPaymentHistory()
            Catch ex As MySqlException
                MessageBox.Show("Payment processing error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("You can only pay for approved bookings.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvCurrentBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCurrentBooking.CellClick
        dgvCurrentBooking.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub dgvPaymentHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaymentHistory.CellClick
        dgvPaymentHistory.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub txtPaymentAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaymentAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class