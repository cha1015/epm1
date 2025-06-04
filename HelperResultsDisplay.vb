Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Linq
Imports System.Text.RegularExpressions

Public Class HelperResultsDisplay

    Public Shared Sub PopulateFlowPanel(ByVal flp As FlowLayoutPanel, ByVal dt As DataTable, ByVal panelCreator As Func(Of DataRow, Panel))
        flp.WrapContents = True
        flp.AutoScroll = True
        flp.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim panel As Panel = panelCreator(row)
            flp.Controls.Add(panel)
        Next
    End Sub

    Public Shared Sub PopulateEventPlaces(ByVal flpResults As FlowLayoutPanel, ByVal dt As DataTable,
                                            ByVal btnBookHandler As EventHandler,
                                            ByVal btnUpdateHandler As EventHandler,
                                            ByVal btnDeleteHandler As EventHandler,
                                            ByVal isAdmin As Boolean)
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpResults.Width - scrollbarWidth - (10 * 6)
        ' Dim panelWidth As Integer = availableWidth \ 3
        Dim maxPanelWidth As Integer = 280
        Dim panelWidth As Integer = Math.Min(maxPanelWidth, availableWidth \ 3)
        Dim panelHeight As Integer = 280

        Dim toolTip As New ToolTip()

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(panelWidth, panelHeight)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)


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


                                                         Dim lblName As New Label()
                                                         lblName.AutoSize = False
                                                         lblName.Size = New Size(panelWidth - 20, 22)
                                                         lblName.Location = New Point(5, 140)
                                                         lblName.Text = row("event_place").ToString()
                                                         lblName.Font = New Font("Poppins", 10, FontStyle.Bold)

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
        Dim names As String() = serviceNames.Split(","c)
        Dim serviceNamesList As New List(Of String)()

        For Each serviceName As String In names
            serviceName = serviceName.Trim()

            If Not String.IsNullOrEmpty(serviceName) Then

                serviceNamesList.Add(serviceName)
            End If
        Next

        Dim result As String = String.Join(", ", serviceNamesList)
        Return result
    End Function


    Private Shared Function CreateBookingPanel(ByVal row As DataRow,
                                               ByVal panelWidth As Integer,
                                               ByVal panelHeight As Integer,
                                               ByVal status As String,
                                               ByVal approveHandler As EventHandler,
                                               ByVal rejectHandler As EventHandler) As Panel
        Dim panel As New Panel()

        panel.Size = New Size(panelWidth, panelHeight)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Margin = New Padding(10)


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


        Dim lblName As New Label With {
    .Text = "User: " & If(row.Table.Columns.Contains("name"), row("name").ToString(), "N/A"),
    .Location = New Point(5, 145),
    .Size = New Size(panelWidth - 20, 22),
    .Font = New Font("Poppins", 10, FontStyle.Bold)
}


        Dim lblEventPlace As New Label With {
        .Text = "Event Place: " & row("event_place").ToString(),
        .Location = New Point(5, 170),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

        Dim lblEventType As New Label With {
        .Text = "Event Type: " & row("event_type").ToString(),
        .Location = New Point(5, 190),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

        Dim lblGuests As New Label With {
        .Text = "Guests: " & row("num_guests").ToString(),
        .Location = New Point(5, 210),
        .Size = New Size(panelWidth - 20, 20),
        .Font = New Font("Poppins", 8)
    }

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

        Dim lblServices As New Label With {
    .Text = "Services: " & String.Join(", ", services.Split(","c)),
    .Location = New Point(5, 310),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}
        Debug.WriteLine("Services to display: " & lblServices.Text)

        Dim lblTotalPrice As New Label With {
    .Text = "Total Price: ₱" & row("total_price").ToString(),
    .Location = New Point(5, 330),
    .Size = New Size(panelWidth - 20, 20),
    .Font = New Font("Poppins", 8)
}

        If status = "Pending" Then
            Dim btnApprove As New Button()
            btnApprove.Text = "Approve"
            btnApprove.Size = New Size(panelWidth - 20, 30)
            btnApprove.Location = New Point((panelWidth - btnApprove.Width) / 2, 350)
            btnApprove.Tag = row
            AddHandler btnApprove.Click, approveHandler
            btnApprove.FlatStyle = FlatStyle.Flat
            btnApprove.Font = New Font("Poppins", 8)
            btnApprove.BackColor = Color.LightGreen

            Dim btnReject As New Button()
            btnReject.Text = "Reject"
            btnReject.Size = New Size(panelWidth - 20, 30)
            btnReject.Location = New Point((panelWidth - btnReject.Width) / 2, btnApprove.Location.Y + btnApprove.Height + 5)
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
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Pending", approveHandler, rejectHandler)

                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330),
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
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Approved", Nothing, Nothing)

                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330),
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
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, "Rejected", Nothing, Nothing)

                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330),
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
                                                         Dim services As String = GetServiceNamesByIds(row("services_availed").ToString())

                                                         Dim panel As Panel = CreateBookingPanel(row, panelWidth, panelHeight, row("status").ToString(), Nothing, Nothing)

                                                         Dim lblServices As New Label With {
                                                         .Text = "Services: " & services,
                                                         .Location = New Point(5, 330),
                                                         .Size = New Size(panelWidth - 20, 20),
                                                         .Font = New Font("Poppins", 8)
                                                     }

                                                         panel.Controls.Add(lblServices)
                                                         Return panel
                                                     End Function

        PopulateFlowPanel(flpAll, dt, createPanel)
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
                                                  ByVal btnAdd As Button,
                                                  ByVal btnUpdate As Button,
                                                  ByVal btnDelete As Button)

        flpEventPlaces.Controls.Clear()

        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        Dim availableWidth As Integer = flpEventPlaces.Width - scrollbarWidth - (10 * 6)
        Dim panelWidth As Integer = availableWidth \ 3
        Dim panelHeight As Integer = 180

        Dim createPanel As Func(Of DataRow, Panel) = Function(row As DataRow)
                                                         Dim panel As New Panel()
                                                         panel.Size = New Size(panelWidth, panelHeight)
                                                         panel.BorderStyle = BorderStyle.FixedSingle
                                                         panel.Margin = New Padding(10)

                                                         Dim pb As New PictureBox()
                                                         pb.Size = New Size(panelWidth, 120)
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

                                                         Dim lblName As New Label()
                                                         lblName.AutoSize = False
                                                         lblName.Size = New Size(panelWidth, 22)
                                                         lblName.Location = New Point(0, 120)
                                                         lblName.Text = row("event_place").ToString()
                                                         lblName.Font = New Font("Poppins", 10, FontStyle.Bold)

                                                         panel.Controls.Add(pb)
                                                         panel.Controls.Add(lblName)

                                                         Dim availStatus As String = row("Availability").ToString().ToLower()
                                                         If availStatus = "available" Then
                                                             panel.BackColor = Color.LightGreen
                                                         Else
                                                             panel.BackColor = Color.LightPink
                                                         End If

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

                                                                                     If dt.Columns.Contains("available_days") Then
                                                                                         txtAvailableDays.Text = row("available_days").ToString()
                                                                                     Else
                                                                                         Debug.WriteLine("Column 'available_days' not found in DataTable!")
                                                                                     End If

                                                                                     txtAvailableDays.Text = row("available_days").ToString()
                                                                                     txtDescription.Text = row("description").ToString()
                                                                                     txtPlaceID.Text = row("place_id").ToString()

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

                                                                                     If availStatus = "available" Then
                                                                                         btnAdd.Visible = False
                                                                                         btnUpdate.Visible = True
                                                                                         btnDelete.Visible = True
                                                                                     Else
                                                                                         btnAdd.Visible = False
                                                                                         btnUpdate.Visible = False
                                                                                         btnDelete.Visible = False
                                                                                     End If
                                                                                 End Sub

                                                         Return panel

                                                         AddHandler flpEventPlaces.Click, Sub(sender, e)
                                                                                              txtEventPlace.Text = " "
                                                                                              txtEventType.Text = " "
                                                                                              txtCapacity.Text = " "
                                                                                              txtPricePerDay.Text = " "
                                                                                              txtFeatures.Text = " "
                                                                                              txtImageUrl.Text = " "
                                                                                              cbStartHour.SelectedIndex = -1
                                                                                              cbStartMinutes.SelectedIndex = -1
                                                                                              cbStartAMPM.SelectedIndex = -1
                                                                                              cbEndHour.SelectedIndex = -1
                                                                                              cbEndMinutes.SelectedIndex = -1
                                                                                              cbEndAMPM.SelectedIndex = -1
                                                                                              txtAvailableDays.Text = " "
                                                                                              txtDescription.Text = " "
                                                                                              txtPlaceID.Text = " "

                                                                                              btnAdd.Visible = True
                                                                                              btnUpdate.Visible = False
                                                                                              btnDelete.Visible = False
                                                                                          End Sub

                                                     End Function

        For Each row As DataRow In dt.Rows
            Dim panel As Panel = createPanel(row)
            flpEventPlaces.Controls.Add(panel)
        Next
    End Sub

End Class