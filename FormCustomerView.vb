Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Public Class FormCustomerView

    Private customerId As Integer

    ' Constructor to accept customer ID
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        customerId = id ' Store passed customer ID
    End Sub

    Private Sub FormCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelperNavigation.RegisterNewForm(Me)

        dgvCurrentBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'MessageBox.Show($"Debug: CurrentUser.CustomerId = {CurrentUser.CustomerId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        customerId = CurrentUser.CustomerId
        'MessageBox.Show($"Debug: Assigned customerId = {customerId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Debug.WriteLine($"FormCustomerView loaded with CustomerId: {customerId}")

        lblUsername.Text = CurrentUser.Username
        LoadBookings()
        LoadPaymentHistory()
    End Sub

    ' ✅ Load only current customer bookings
    Private Sub LoadBookings()
        Debug.WriteLine($"Loading bookings for CustomerId: {customerId}")
        'MessageBox.Show($"Executing query for CustomerId: {customerId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dgvPaymentHistory.ClearSelection()

        'MessageBox.Show($"Loading bookings for CustomerId: {customerId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim query As String = $"SELECT b.booking_id, p.event_place, b.event_date, b.event_time, b.event_end_time, b.status 
                       FROM bookings b
                       JOIN eventplace p ON b.place_id = p.place_id 
                       WHERE b.customer_id = {customerId}
                       ORDER BY b.event_date DESC"

        'MessageBox.Show($"Running SQL: {query}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim parameters As New Dictionary(Of String, Object) From {{"@customer_id", customerId}}

        Try
            Dim dtBookings As DataTable = DBHelper.GetDataTable(query, parameters)
            'MessageBox.Show($"Debug: Retrieved {dtBookings.Rows.Count} bookings", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


            If dtBookings.Rows.Count > 0 Then
                dgvCurrentBooking.DataSource = dtBookings
                btnSelectBooking.Enabled = True
                btnConfirmPayment.Enabled = True
            Else
                ' Create a temporary placeholder row when no bookings exist
                Dim dtPlaceholder As New DataTable()

                dtPlaceholder.Columns.Add("Message", GetType(String))
                dtPlaceholder.Rows.Add("No bookings found. Start by booking an event!")
                dgvCurrentBooking.DataSource = dtPlaceholder
                btnSelectBooking.Enabled = False ' 🚫 Disable button when no bookings exist
                btnConfirmPayment.Enabled = False ' 🚫 Disable button when no bookings exist
                dgvCurrentBooking.Refresh() ' 🚀 Force UI update
            End If

        Catch ex As MySqlException
            'MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    ' ✅ Load payment history correctly
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
                'MessageBox.Show("No payment records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As MySqlException
            'MessageBox.Show("Error loading payment history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPayButtonColumn()
        Dim btnColumn As New DataGridViewButtonColumn()
        btnColumn.Name = "btnSelectBooking"
        btnColumn.HeaderText = "Action"
        btnColumn.Text = "Pay Now"
        btnColumn.UseColumnTextForButtonValue = True  ' Show button text
        dgvPaymentHistory.Columns.Add(btnColumn)
    End Sub

    ' Button to edit customer information
    Private Sub btnEditInformation_Click(sender As Object, e As EventArgs) Handles btnEditInformation.Click
        Dim editForm As New FormCustomerAdminInfo
        editForm.ShowDialog()
    End Sub

    ' Button to return to the main screen
    Private Sub btnMain_Click(sender As Object, e As EventArgs)
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub

    ' Button to log out
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim loginForm As New FormLogIn()
        loginForm.Show()
        Me.Hide()
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
        ' Ensure a booking is selected
        If dgvPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get payment details from the selected row
        Dim paymentStatus As String = dgvPaymentHistory.SelectedRows(0).Cells("payment_status").Value.ToString()
        Dim amountDue As Decimal = Convert.ToDecimal(dgvPaymentHistory.SelectedRows(0).Cells("amount_to_pay").Value)
        Dim amountPaid As Decimal

        ' Validate cash amount (ensure correct payment)
        If Not Decimal.TryParse(txtPaymentAmount.Text, amountPaid) OrElse amountPaid < amountDue Then
            MessageBox.Show("Invalid amount. You must pay at least the due amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Allow payment only if booking is approved
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
                LoadPaymentHistory() ' Refresh payment history
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
        ' Allow only numbers and control keys (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        HelperNavigation.GoNext(Me)
    End Sub
End Class
