Public Class FormCustomerDetails

    ' Labels for customer details
    Public lblCustomerName As Label
    Public lblBirthday As Label
    Public lblAge As Label
    Public lblSex As Label
    Public lblAddress As Label

    ' Labels for account details
    Public lblUsername As Label
    Public lblEmail As Label

    ' Controls for displaying bookings
    Public flpBookings As FlowLayoutPanel

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Initialize the labels for personal info and account info
        lblCustomerName = New Label()
        lblBirthday = New Label()
        lblAge = New Label()
        lblSex = New Label()
        lblAddress = New Label()

        lblUsername = New Label()
        lblEmail = New Label()

        ' Initialize FlowLayoutPanel for bookings
        flpBookings = New FlowLayoutPanel()
    End Sub

    ' Method to add booking details to the form
    Public Sub AddBookingDetails(booking As DataRow)
        Dim panel As New Panel() With {
            .Size = New Size(300, 100),
            .BorderStyle = BorderStyle.FixedSingle,
            .Margin = New Padding(5)
        }

        ' Add booking details to the panel
        Dim lblBookingPlace As New Label() With {
            .Text = "Event Place: " & booking("event_place").ToString(),
            .Location = New Point(5, 5),
            .AutoSize = True
        }
        Dim lblBookingDate As New Label() With {
            .Text = "Event Date: " & booking("event_date").ToString(),
            .Location = New Point(5, 25),
            .AutoSize = True
        }
        Dim lblBookingCost As New Label() With {
            .Text = "Total Price: ₱" & booking("total_price").ToString(),
            .Location = New Point(5, 45),
            .AutoSize = True
        }
        Dim lblBookingStatus As New Label() With {
            .Text = "Status: " & booking("status").ToString(),
            .Location = New Point(5, 65),
            .AutoSize = True
        }

        ' Add the labels to the panel
        panel.Controls.Add(lblBookingPlace)
        panel.Controls.Add(lblBookingDate)
        panel.Controls.Add(lblBookingCost)
        panel.Controls.Add(lblBookingStatus)

        ' Add the panel to the FlowLayoutPanel for bookings
        flpBookings.Controls.Add(panel)
    End Sub

    Private Sub FormCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
