Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Linq
Imports System.Text.RegularExpressions

Public Class HelperResultsDisplay

    ' General method to populate any flow panel
    Public Shared Sub PopulateFlowPanel(ByVal flp As FlowLayoutPanel, ByVal dt As DataTable, ByVal panelCreator As Func(Of DataRow, Panel))
        flp.WrapContents = True
        flp.AutoScroll = True
        flp.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim panel As Panel = panelCreator(row)
            flp.Controls.Add(panel)
        Next
    End Sub

    ' Method for populating Event Places
    Public Shared Sub PopulateEventPlaces(ByVal flpResults As FlowLayoutPanel, ByVal dt As DataTable,
                                            ByVal btnBookHandler As EventHandler,
                                            ByVal btnUpdateHandler As EventHandler,
                                            ByVal btnDeleteHandler As EventHandler,
                                            ByVal isAdmin As Boolean)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpResults.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 280

        Dim toolTip As New ToolTip()

        ' Create the event place panel
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(panelWidth, panelHeight)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         ' PictureBox for event image
                                                         Dim pb As New PictureBox()
                                                         pb.Size = New Size(panelWidth, 140)
                                                         pb.Location = New Point(0, 0)
                                                         pb.SizeMode = PictureBoxSizeMode.StretchImage
                                                         Dim imagePath As String = row("image_url").ToString().Trim()
                                                         Dim defaultImagePath As String = "C:\event images\No Image.png"
                                                         If String.IsNullOrEmpty(imagePath) OrElse Not IO.File.Exists(imagePath) Then
                                                             imagePath = defaultImagePath
                                                         End If
                                                         Try
                                                             pb.Image = Image.FromFile(imagePath)
                                                         Catch ex As Exception
                                                             pb.Image = Nothing
                                                         End Try

                                                         ' Label for event place name
                                                         Dim lblName As New Label()
                                                         lblName.AutoSize = False
                                                         lblName.Size = New Size(panelWidth - 20, 22)
                                                         lblName.Location = New Point(5, 140)
                                                         lblName.Text = row("event_place").ToString()
                                                         lblName.Font = New Font("Poppins", 10, FontStyle.Bold)

                                                         ' Label for capacity
                                                         Dim lblCapacity As New Label()
                                                         lblCapacity.AutoSize = False
                                                         lblCapacity.Size = New Size(panelWidth - 20, 20)
                                                         lblCapacity.Location = New Point(5, 165)
                                                         lblCapacity.Text = "Capacity: " & row("capacity").ToString()
                                                         lblCapacity.Font = New Font("Poppins", 8)

                                                         ' Label for price per day
                                                         Dim lblPrice As New Label()
                                                         lblPrice.AutoSize = False
                                                         lblPrice.Size = New Size(panelWidth - 20, 20)
                                                         lblPrice.Location = New Point(5, 185)
                                                         lblPrice.Text = "Price per Day: " & row("price_per_day").ToString()
                                                         lblPrice.Font = New Font("Poppins", 8)

                                                         ' Label for event types
                                                         Dim fullEventTypesText As String = row("event_type").ToString()
                                                         Dim eventTypesList As String() = Regex.Split(fullEventTypesText, "\s*,\s*")
                                                         Dim displayEventTypes As String = String.Join(", ", eventTypesList.Take(3))
                                                         If eventTypesList.Length > 3 Then
                                                             displayEventTypes &= "..."
                                                         End If
                                                         Dim lblEventType As New Label()
                                                         lblEventType.AutoSize = False
                                                         lblEventType.Size = New Size(panelWidth - 20, 20)
                                                         lblEventType.Location = New Point(5, 205)
                                                         lblEventType.Text = "Event Types: " & displayEventTypes
                                                         toolTip.SetToolTip(lblEventType, fullEventTypesText)
                                                         lblEventType.Font = New Font("Poppins", 8)

                                                         ' Action Button(s): either Book or Update/Delete buttons
                                                         If Not isAdmin Then
                                                             Dim btnBook As New Button()
                                                             btnBook.Text = "Book Now"
                                                             btnBook.Size = New Size(panelWidth - 20, 30)
                                                             btnBook.Location = New Point(10, panelHeight - 40)
                                                             btnBook.Tag = row
                                                             AddHandler btnBook.Click, btnBookHandler
                                                             panel.Controls.Add(btnBook)
                                                             btnBook.FlatStyle = FlatStyle.Flat
                                                             btnBook.Font = New Font("Poppins", 8)
                                                         Else
                                                             ' Create update and delete buttons for admin
                                                             Dim btnUpdate As New Button()
                                                             btnUpdate.Text = "Update"
                                                             btnUpdate.Size = New Size(80, 30)
                                                             btnUpdate.Location = New Point(5, 245)
                                                             btnUpdate.Tag = row

                                                             Dim btnDelete As New Button()
                                                             btnDelete.Text = "Delete"
                                                             btnDelete.Size = New Size(80, 30)
                                                             btnDelete.Location = New Point(90, 245)
                                                             btnDelete.Tag = row

                                                             AddHandler btnUpdate.Click, btnUpdateHandler
                                                             AddHandler btnDelete.Click, btnDeleteHandler

                                                             panel.Controls.Add(btnUpdate)
                                                             panel.Controls.Add(btnDelete)
                                                         End If

                                                         panel.Controls.Add(pb)
                                                         panel.Controls.Add(lblName)
                                                         panel.Controls.Add(lblCapacity)
                                                         panel.Controls.Add(lblPrice)
                                                         panel.Controls.Add(lblEventType)

                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpResults, dt, createPanel)
    End Sub

    Private Shared Function GetServiceNamesByIds(serviceNames As String) As String
        ' Split the serviceNames string into an array of names
        Dim names As String() = serviceNames.Split(","c)
        Dim serviceNamesList As New List(Of String)()

        ' Log the service names being processed
        Debug.WriteLine("Processing service names: " & String.Join(", ", names))

        ' Loop through the service names and add them directly to the list
        For Each serviceName As String In names
            serviceName = serviceName.Trim()

            If Not String.IsNullOrEmpty(serviceName) Then
                ' Query to get the service name (since we already have it)
                ' If necessary, you can query here to make sure the service exists in the database
                ' Or you could simply add the name if you're confident it's correct
                serviceNamesList.Add(serviceName)
                ' Log the service name found
                Debug.WriteLine("Added service name: " & serviceName)
            End If
        Next

        ' Return the service names as a comma-separated string
        Dim result As String = String.Join(", ", serviceNamesList)
        Debug.WriteLine("Returning service names: " & result)
        Return result
    End Function


    Private Shared Function CreateBookingPanel(ByVal row As DataRow, ByVal panelWidth As Integer, ByVal panelHeight As Integer, ByVal status As String, ByVal approveHandler As EventHandler, ByVal rejectHandler As EventHandler) As Panel
        Dim panel As New Panel()

        panel.Size = New Size(panelWidth, panelHeight)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Margin = New Padding(10)


        ' PictureBox for event image
        Dim pb As New PictureBox()
        pb.Size = New Size(panelWidth, 140)
        pb.Location = New Point(0, 0)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        Dim imagePath As String = row("image_url").ToString().Trim()
        Dim defaultImagePath As String = "C:\event images\No Image.png"
        If String.IsNullOrEmpty(imagePath) OrElse Not IO.File.Exists(imagePath) Then
            imagePath = defaultImagePath
        End If
        Try
            pb.Image = Image.FromFile(imagePath)
        Catch ex As Exception
            pb.Image = Nothing
        End Try

        ' Customer Label
        Dim lblName As New Label With {
        .Text = "Customer: " & row("name").ToString(),
        .Location = New Point(5, 145),
        .Size = New Size(panelWidth - 20, 22),
        .Font = New Font("Poppins", 10, FontStyle.Bold)
    }

        ' Event Place Label
        Dim lblEventPlace As New Label With {
        .Text = "Event Place: " & row("event_place").ToString(),
        .Location = New Point(5, 170),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

        ' Event Type Label
        Dim lblEventType As New Label With {
        .Text = "Event Type: " & row("event_type").ToString(),
        .Location = New Point(5, 190),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

        ' Guests Label
        Dim lblGuests As New Label With {
        .Text = "Guests: " & row("num_guests").ToString(),
        .Location = New Point(5, 210),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

        ' Event Date Label - Formatted as "Month day, year"
        Dim lblEventDate As New Label With {
    .Text = "Event Date: " & Convert.ToDateTime(row("event_date")).ToString("MMMM d, yyyy"),
    .Location = New Point(5, 230),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}
        Dim lblEventEndDate As New Label With {
    .Text = "Event End Date: " & Convert.ToDateTime(row("event_end_date")).ToString("MMMM d, yyyy"),
    .Location = New Point(5, 250),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}
        ' Event Time Label
        Dim startTime As String = "N/A"
        Dim endTime As String = "N/A"

        If Not IsDBNull(row("event_time")) Then
            Dim dtStart As DateTime
            If DateTime.TryParse(row("event_time").ToString(), dtStart) Then
                startTime = dtStart.ToString("h:mm tt")
            End If
        End If

        If Not IsDBNull(row("event_end_time")) Then
            Dim dtEnd As DateTime
            If DateTime.TryParse(row("event_end_time").ToString(), dtEnd) Then
                endTime = dtEnd.ToString("h:mm tt")
            End If
        End If

        Dim lblEventTime As New Label With {
    .Text = "Event Time: " & startTime,
    .Location = New Point(5, 270),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}
        Dim lblEventEndTime As New Label With {
    .Text = "To: " & endTime,
    .Location = New Point(5, 290),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}

        ' Services Label
        Dim services As String = row("services_availed").ToString()
        Debug.WriteLine("Services Availed (ID list): " & services)
        Dim serviceIds As String() = services.Split(","c)
        Dim serviceNames As New List(Of String)

        For Each serviceId As String In serviceIds
            serviceId = serviceId.Trim()

            If Not String.IsNullOrEmpty(serviceId) AndAlso IsNumeric(serviceId) Then
                Debug.WriteLine("Processing service ID: " & serviceId)
                Dim serviceName As String = GetServiceNamesByIds(Convert.ToInt32(serviceId))
                If Not String.IsNullOrEmpty(serviceName) Then
                    serviceNames.Add(serviceName)
                    Debug.WriteLine("Added service: " & serviceName)
                End If
            End If
        Next

        ' Update the label text with the correct services string
        Dim lblServices As New Label With {
    .Text = "Services: " & String.Join(", ", services.Split(","c)),
    .Location = New Point(5, 310), ' Position below the total price label
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}
        Debug.WriteLine("Services to display: " & lblServices.Text)

        ' Total Price Label
        Dim lblTotalPrice As New Label With {
    .Text = "Total Price: ₱" & row("total_price").ToString(),
    .Location = New Point(5, 330),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}

        If status = "Pending" Then
            ' Show Approve and Reject buttons for pending bookings
            Dim btnApprove As New Button()
            btnApprove.Text = "Approve"
            btnApprove.Size = New Size(panelWidth - 20, 30)
            btnApprove.Location = New Point((panelWidth - btnApprove.Width) / 2, 350) ' Move the button further down
            btnApprove.Tag = row
            AddHandler btnApprove.Click, approveHandler
            btnApprove.FlatStyle = FlatStyle.Flat
            btnApprove.Font = New Font("Poppins", 8)
            btnApprove.BackColor = Color.LightGreen

            Dim btnReject As New Button()
            btnReject.Text = "Reject"
            btnReject.Size = New Size(panelWidth - 20, 30)
            btnReject.Location = New Point((panelWidth - btnReject.Width) / 2, btnApprove.Location.Y + btnApprove.Height + 5) ' 5px below the "Approve" button
            btnReject.Tag = row
            AddHandler btnReject.Click, rejectHandler
            btnReject.FlatStyle = FlatStyle.Flat
            btnReject.Font = New Font("Poppins", 8)
            btnReject.BackColor = Color.LightCoral

            panel.Controls.Add(btnApprove)
            panel.Controls.Add(btnReject)

        ElseIf status = "Approved" Then
            Dim lblStatus As New Label With {
        .Text = "Approved",
        .Location = New Point(panelWidth - 105, panelHeight - 55),
        .AutoSize = True,
        .BorderStyle = BorderStyle.FixedSingle,
        .Font = New Font("Poppins", 8),
        .BackColor = Color.LightGreen
    }
            panel.Controls.Add(lblStatus)

        ElseIf status = "Rejected" Then
            Dim lblStatus As New Label With {
        .Text = "Rejected",
        .Location = New Point(panelWidth - 105, panelHeight - 55),
        .AutoSize = True,
        .BorderStyle = BorderStyle.FixedSingle,
        .Font = New Font("Poppins", 8),
        .BackColor = Color.LightCoral
    }
            panel.Controls.Add(lblStatus)
        End If

        panel.Controls.Add(pb)
        panel.Controls.Add(lblName)
        panel.Controls.Add(lblEventPlace)
        panel.Controls.Add(lblEventType)
        panel.Controls.Add(lblGuests)
        panel.Controls.Add(lblEventDate)
        panel.Controls.Add(lblEventEndDate)
        panel.Controls.Add(lblEventTime)
        panel.Controls.Add(lblEventEndTime)
        panel.Controls.Add(lblServices)
        panel.Controls.Add(lblTotalPrice)

        Dim eventDate As DateTime
        If DateTime.TryParse(row("event_date").ToString(), eventDate) Then
            Dim eventDateOnly As DateTime = eventDate.Date
            Dim currentDateOnly As DateTime = DateTime.Now.Date

            Dim daysUntilEvent As Integer = (eventDateOnly - currentDateOnly).Days

            If daysUntilEvent = 0 Then
                panel.BackColor = Color.LightPink
            ElseIf daysUntilEvent < 0 Then
                panel.BackColor = Color.Gray
            ElseIf daysUntilEvent <= 2 Then
                panel.BackColor = Color.Orange
            ElseIf daysUntilEvent <= 7 Then
                panel.BackColor = Color.Yellow
            Else
                panel.BackColor = Color.LightGreen
            End If
        Else
            panel.BackColor = Color.LightGray
        End If

        Return panel
    End Function

    Public Shared Sub PopulatePendingBookings(ByVal flpPending As FlowLayoutPanel, ByVal dt As DataTable, ByVal approveHandler As EventHandler, ByVal rejectHandler As EventHandler, ByVal adminForm As FormAdminCenter)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpPending.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 420

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         ' Fetch the service names for the booking
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         ' Create the booking panel with service names included
                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Pending", approveHandler, rejectHandler)

                                                         ' Add the services label
                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330), ' Position below the total price label
                                                         .Size = New Size(panelWidth - 20, 20),
                                                         .Font = New Font("Poppins", 8)
                                                     }

                                                         panel.Controls.Add(lblServices)
                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpPending, dt, createPanel)
    End Sub

    Public Shared Sub PopulateApprovedBookings(ByVal flpApproved As FlowLayoutPanel, ByVal dt As DataTable)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpApproved.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 420

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         ' Fetch the service names for the booking
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         ' Create the booking panel with service names included
                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Approved", Nothing, Nothing)

                                                         ' Add the services label
                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330), ' Position below the total price label
                                                         .Size = New Size(panelWidth - 20, 20),
                                                         .Font = New Font("Poppins", 8)
                                                     }

                                                         panel.Controls.Add(lblServices)
                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpApproved, dt, createPanel)
    End Sub

    Public Shared Sub PopulateRejectedBookings(ByVal flpRejected As FlowLayoutPanel, ByVal dt As DataTable)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpRejected.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 420

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         ' Fetch the service names for the booking
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         ' Create the booking panel with service names included
                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Rejected", Nothing, Nothing)

                                                         ' Add the services label
                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330), ' Position below the total price label
                                                         .Size = New Size(panelWidth - 20, 20),
                                                         .Font = New Font("Poppins", 8)
                                                     }

                                                         panel.Controls.Add(lblServices)
                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpRejected, dt, createPanel)
    End Sub

    Public Shared Sub PopulateAllBookings(ByVal flpAll As FlowLayoutPanel, ByVal dt As DataTable)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpAll.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 420

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         ' Fetch the service names for the booking
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         ' Create the booking panel with service names included
                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, row("status").ToString(), Nothing, Nothing)

                                                         ' Add the services label
                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330), ' Position below the total price label
                                                         .Size = New Size(panelWidth - 20, 20),
                                                         .Font = New Font("Poppins", 8)
                                                     }

                                                         panel.Controls.Add(lblServices)
                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpAll, dt, createPanel)
    End Sub


    '--- Specialized method for Event Place Availability ---
    Public Shared Sub PopulateAvailability(ByVal flpAvailability As FlowLayoutPanel, ByVal dt As DataTable)
        ' Create separate panels for available and booked places
        Dim createAvailablePanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                                  Dim panel As New Panel()
                                                                  panel.Size = New Size(200, 50)
                                                                  panel.BorderStyle = BorderStyle.FixedSingle
                                                                  panel.Margin = New Padding(10)

                                                                  Dim lblEventPlace As New Label With {
                                                                   .Text = row("event_place").ToString(),
                                                                   .Location = New Point(5, 5),
                                                                   .AutoSize = True
                                                               }
                                                                  Dim lblStatus As New Label With {
                                                                   .Text = "Status: " & row("Availability").ToString(),
                                                                   .Location = New Point(5, 25),
                                                                   .AutoSize = True
                                                               }

                                                                  panel.Controls.Add(lblEventPlace)
                                                                  panel.Controls.Add(lblStatus)

                                                                  ' Set the background color for available event places
                                                                  If row("Availability").ToString() = "Available" Then
                                                                      panel.BackColor = Color.LightGreen
                                                                  End If

                                                                  Return panel
                                                              End Function

        Dim createBookedPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                               Dim panel As New Panel()
                                                               panel.Size = New Size(200, 50)
                                                               panel.BorderStyle = BorderStyle.FixedSingle
                                                               panel.Margin = New Padding(10)

                                                               Dim lblEventPlace As New Label With {
                                                                .Text = row("event_place").ToString(),
                                                                .Location = New Point(5, 5),
                                                                .AutoSize = True
                                                            }
                                                               Dim lblStatus As New Label With {
                                                                .Text = "Status: " & row("Availability").ToString(),
                                                                .Location = New Point(5, 25),
                                                                .AutoSize = True
                                                            }

                                                               panel.Controls.Add(lblEventPlace)
                                                               panel.Controls.Add(lblStatus)

                                                               ' Set the background color for booked event places
                                                               If row("Availability").ToString() = "Booked" Then
                                                                   panel.BackColor = Color.Orange
                                                               End If

                                                               Return panel
                                                           End Function

        ' Populate the FlowLayoutPanel with the correct event places
        PopulateFlowPanel(flpAvailability, dt, createAvailablePanel)  ' This is where available places will be populated
    End Sub

    '--- Specialized method for Revenue Reports ---
    Public Shared Sub PopulateRevenueReports(ByVal flpRevenueReports As FlowLayoutPanel, ByVal dt As DataTable)
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(250, 60)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         Dim lblEvent As New Label With {
                                                             .Text = row("event_place").ToString(),
                                                             .Location = New Point(5, 5),
                                                             .AutoSize = True
                                                         }
                                                         Dim lblRevenue As New Label With {
                                                             .Text = "Revenue: " & row("total_revenue").ToString(),
                                                             .Location = New Point(5, 30),
                                                             .AutoSize = True
                                                         }
                                                         panel.Controls.Add(lblEvent)
                                                         panel.Controls.Add(lblRevenue)
                                                         Return panel
                                                     End Function
        PopulateFlowPanel(flpRevenueReports, dt, createPanel)
    End Sub

    '--- Specialized method for Invoices (with Accept Payment handler) ---
    Public Shared Sub PopulateInvoices(ByVal flpInvoices As FlowLayoutPanel, ByVal dt As DataTable, ByVal paymentHandler As EventHandler)
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(250, 80)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         Dim lblInvoiceID As New Label With {
                                                             .Text = "Invoice #" & row("invoice_id").ToString(),
                                                             .Location = New Point(5, 5),
                                                             .AutoSize = True
                                                         }
                                                         Dim lblEventPlace As New Label With {
                                                             .Text = "Event: " & row("event_place").ToString(),
                                                             .Location = New Point(5, 25),
                                                             .AutoSize = True
                                                         }
                                                         Dim lblAmount As New Label With {
                                                             .Text = "Amount: " & row("total_amount").ToString(),
                                                             .Location = New Point(5, 45),
                                                             .AutoSize = True
                                                         }
                                                         panel.Controls.Add(lblInvoiceID)
                                                         panel.Controls.Add(lblEventPlace)
                                                         panel.Controls.Add(lblAmount)

                                                         Dim btnPayment As New Button()
                                                         btnPayment.Text = "Accept Payment"
                                                         btnPayment.Size = New Size(100, 25)
                                                         btnPayment.Location = New Point(135, 30)
                                                         btnPayment.Tag = row
                                                         AddHandler btnPayment.Click, paymentHandler
                                                         panel.Controls.Add(btnPayment)

                                                         Return panel
                                                     End Function
        PopulateFlowPanel(flpInvoices, dt, createPanel)
    End Sub

    '--- Specialized method for Customer Records ---
    Public Shared Sub PopulateCustomerRecords(ByVal flpCustomerRecords As FlowLayoutPanel, ByVal dt As DataTable)
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(300, 80)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         ' Label for customer name
                                                         Dim lblName As New Label With {
                                                         .Text = row("name").ToString(),
                                                         .Location = New Point(5, 5),
                                                         .AutoSize = True
                                                     }
                                                         ' Label for age
                                                         Dim lblAge As New Label With {
                                                         .Text = "Age: " & row("age").ToString(),
                                                         .Location = New Point(5, 25),
                                                         .AutoSize = True
                                                     }
                                                         ' Label for address
                                                         Dim lblAddress As New Label With {
                                                         .Text = "Address: " & row("address").ToString(),
                                                         .Location = New Point(5, 45),
                                                         .AutoSize = True
                                                     }

                                                         panel.Controls.Add(lblName)
                                                         panel.Controls.Add(lblAge)
                                                         panel.Controls.Add(lblAddress)

                                                         ' Add click event to open customer details
                                                         AddHandler panel.Click, Sub(sender, e)
                                                                                     ShowCustomerDetails(row)
                                                                                 End Sub

                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpCustomerRecords, dt, createPanel)
    End Sub

    ' This method will be called when a customer panel is clicked to show their details
    Public Shared Sub ShowCustomerDetails(row As DataRow)
        ' Create a new form to show customer details
        Dim customerDetailsForm As New FormCustomerDetails()

        ' Set the personal information in the form
        customerDetailsForm.lblCustomerName.Text = row("name").ToString()
        customerDetailsForm.lblBirthday.Text = row("birthday").ToString()
        customerDetailsForm.lblAge.Text = row("age").ToString()
        customerDetailsForm.lblSex.Text = row("sex").ToString()
        customerDetailsForm.lblAddress.Text = row("address").ToString()

        ' Retrieve account details from the User table or related tables
        Dim userId As Integer = row("customer_id")  ' Assuming 'customer_id' is the linking field
        Dim accountDetails As DataTable = DBHelper.GetDataTable("SELECT username, email FROM Users WHERE customer_id = @customer_id", New Dictionary(Of String, Object) From {{"@customer_id", userId}})
        If accountDetails.Rows.Count > 0 Then
            customerDetailsForm.lblUsername.Text = accountDetails.Rows(0)("username").ToString()
            customerDetailsForm.lblEmail.Text = accountDetails.Rows(0)("email").ToString()
        End If

        ' Load the bookings for the customer
        Dim bookings As DataTable = DBHelper.GetDataTable("SELECT booking_id, event_place, event_date, total_price, status FROM bookings WHERE customer_id = @customer_id", New Dictionary(Of String, Object) From {{"@customer_id", userId}})
        For Each booking As DataRow In bookings.Rows
            ' For each booking, show details like event place, booking date, cost, status, etc.
            customerDetailsForm.AddBookingDetails(booking)
        Next

        ' Show the customer details form
        customerDetailsForm.ShowDialog()
    End Sub


    '--- Specialized method for Booked Dates ---
    Public Shared Sub PopulateBookedDates(ByVal flpBookedDates As FlowLayoutPanel, ByVal dt As DataTable)
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(150, 40)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(5)

                                                         Dim lblDate As New Label()
                                                         lblDate.AutoSize = True
                                                         lblDate.Location = New Point(5, 10)
                                                         lblDate.Text = "Date: " & row("event_date").ToString()
                                                         panel.Controls.Add(lblDate)
                                                         Return panel
                                                     End Function
        PopulateFlowPanel(flpBookedDates, dt, createPanel)
    End Sub

    ' Modified PopulateEventPlacesForAdmin method
    Public Shared Sub PopulateEventPlacesForAdmin(ByVal flpEventPlaces As FlowLayoutPanel,
                                                  ByVal dt As DataTable,
                                                  ByVal txtEventPlace As TextBox,
                                                  ByVal txtEventType As TextBox,
                                                  ByVal txtCapacity As TextBox,
                                                  ByVal txtPricePerDay As TextBox,
                                                  ByVal txtFeatures As TextBox,
                                                  ByVal txtImageUrl As TextBox,
                                                  ByVal cbStartHour As ComboBox,
                                                  ByVal cbStartMinutes As ComboBox,
                                                  ByVal cbStartAMPM As ComboBox,
                                                  ByVal cbEndHour As ComboBox,
                                                  ByVal cbEndMinutes As ComboBox,
                                                  ByVal cbEndAMPM As ComboBox,
                                                  ByVal txtAvailableDays As TextBox,
                                                  ByVal txtDescription As TextBox,
                                                  ByVal txtPlaceID As TextBox,
                                                  ByVal btnUpdate As Button,
                                                  ByVal btnDelete As Button)

        ' Clear the FlowLayoutPanel before adding new controls
        flpEventPlaces.Controls.Clear()

        ' Compute the dimensions for each panel
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpEventPlaces.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 180 ' Adjusted height for image and name

        ' Create the event place panel for each DataRow
        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(panelWidth, panelHeight)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         ' PictureBox for event image
                                                         Dim pb As New PictureBox()
                                                         pb.Size = New Size(panelWidth, 120) ' Adjust height for image section
                                                         pb.Location = New Point(0, 0)
                                                         pb.SizeMode = PictureBoxSizeMode.StretchImage

                                                         Dim imagePath As String = row("image_url").ToString().Trim()
                                                         Dim defaultImagePath As String = "C:\event images\No Image.png"
                                                         If String.IsNullOrEmpty(imagePath) OrElse Not IO.File.Exists(imagePath) Then
                                                             imagePath = defaultImagePath
                                                         End If
                                                         Try
                                                             pb.Image = Image.FromFile(imagePath)
                                                         Catch ex As Exception
                                                             pb.Image = Nothing
                                                         End Try

                                                         ' Label for event place name
                                                         Dim lblName As New Label()
                                                         lblName.AutoSize = False
                                                         lblName.Size = New Size(panelWidth, 22)
                                                         lblName.Location = New Point(0, 120) ' Position just below the image
                                                         lblName.Text = row("event_place").ToString()
                                                         lblName.Font = New Font("Poppins", 10, FontStyle.Bold)

                                                         panel.Controls.Add(pb)
                                                         panel.Controls.Add(lblName)

                                                         ' Set the background color based on availability
                                                         Dim availStatus As String = row("Availability").ToString().ToLower()
                                                         If availStatus = "available" Then
                                                             panel.BackColor = Color.LightGreen
                                                         Else
                                                             panel.BackColor = Color.Orange
                                                         End If

                                                         ' Click handler to load event place details into fields
                                                         AddHandler panel.Click, Sub(sender, e)
                                                                                     txtEventPlace.Text = row("event_place").ToString()
                                                                                     txtEventType.Text = row("event_type").ToString()
                                                                                     txtCapacity.Text = row("capacity").ToString()
                                                                                     txtPricePerDay.Text = row("price_per_day").ToString()
                                                                                     If dt.Columns.Contains("features") Then
                                                                                         txtFeatures.Text = row("features").ToString()
                                                                                     Else
                                                                                         txtFeatures.Text = "Column not found!"
                                                                                     End If

                                                                                     txtImageUrl.Text = row("image_url").ToString()
                                                                                     txtAvailableDays.Text = row("available_days").ToString()
                                                                                     txtDescription.Text = row("description").ToString()
                                                                                     txtPlaceID.Text = row("place_id").ToString()

                                                                                     ' Populate the opening and closing hours
                                                                                     Dim openingTimeSpan As TimeSpan = CType(row("opening_hours"), TimeSpan)
                                                                                     Dim closingTimeSpan As TimeSpan = CType(row("closing_hours"), TimeSpan)
                                                                                     Dim openingTime As DateTime = DateTime.Today.Add(openingTimeSpan)
                                                                                     Dim closingTime As DateTime = DateTime.Today.Add(closingTimeSpan)

                                                                                     cbStartHour.SelectedItem = openingTime.ToString("hh")
                                                                                     cbStartMinutes.SelectedItem = openingTime.ToString("mm")
                                                                                     cbStartAMPM.SelectedItem = openingTime.ToString("tt")
                                                                                     cbEndHour.SelectedItem = closingTime.ToString("hh")
                                                                                     cbEndMinutes.SelectedItem = closingTime.ToString("mm")
                                                                                     cbEndAMPM.SelectedItem = closingTime.ToString("tt")

                                                                                     ' Show Update/Delete buttons only if the event place is available
                                                                                     If availStatus = "available" Then
                                                                                         btnUpdate.Visible = True
                                                                                         btnDelete.Visible = True
                                                                                     Else
                                                                                         btnUpdate.Visible = False
                                                                                         btnDelete.Visible = False
                                                                                     End If
                                                                                 End Sub

                                                         Return panel
                                                     End Function

        ' Loop through each DataRow and add the created panel to the single FlowLayoutPanel
        For Each row As DataRow In dt.Rows
            Dim panel As Panel = createPanel(row)
            flpEventPlaces.Controls.Add(panel)
        Next
    End Sub

End Class