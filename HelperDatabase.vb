Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class HelperDatabase
    ' ------------------ Create a New Customer ------------------
    Public Shared Function CreateNewCustomer(name As String, birthday As Date, sex As String, address As String, age As Integer) As CustomerResult
        Dim result As New CustomerResult()
        Dim insertQuery As String = "INSERT INTO Customers (name, birthday, sex, address, age) VALUES (@name, @birthday, @sex, @address, @age); SELECT LAST_INSERT_ID();"

        Dim params As New Dictionary(Of String, Object) From {
            {"@name", name},
            {"@birthday", birthday},
            {"@sex", sex},
            {"@address", address},
            {"@age", age}
        }

        Dim customerId As Object = DBHelper.ExecuteScalarQuery(insertQuery, params)

        result.CustomerId = If(customerId IsNot Nothing, Convert.ToInt32(customerId), -1)
        result.ErrorMessage = If(result.CustomerId > 0, String.Empty, "Failed to create customer")

        Return result
    End Function

    ' ------------------ Insert User-Customer Relationship ------------------
    Public Shared Sub InsertUserCustomer(userId As Integer, customerId As Integer)
        Dim query As String = "INSERT INTO UserCustomers (user_id, customer_id) VALUES (@user_id, @customer_id)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@user_id", userId},
            {"@customer_id", customerId}
        }
        DBHelper.ExecuteQuery(query, params)
    End Sub

    ' ------------------ Save Booking Services ------------------
    Public Shared Sub SaveBookingServices(bookingId As Integer, catering As Boolean, clown As Boolean, singer As Boolean, dancer As Boolean, videoke As Boolean)
        ' Delete previous entries
        Dim deleteQuery As String = "DELETE FROM BookingServices WHERE booking_id = @bookingId"
        Dim deleteParams As New Dictionary(Of String, Object) From {{"@bookingId", bookingId}}
        DBHelper.ExecuteQuery(deleteQuery, deleteParams)

        ' Insert selected services dynamically
        Dim serviceList As New List(Of String) ' List to store selected services
        Dim insertQuery As String = "INSERT INTO BookingServices (booking_id, service_id) VALUES (@bookingId, @serviceId)"

        Using connection As MySqlConnection = DBHelper.GetConnection()
            Try
                connection.Open()
                Using cmd As New MySqlCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@bookingId", bookingId)

                    ' Add each selected service to the service list
                    Dim serviceSelections As Dictionary(Of Integer, Boolean) = New Dictionary(Of Integer, Boolean) From {
                    {1, catering},
                    {2, clown},
                    {3, singer},
                    {4, dancer},
                    {5, videoke}
                }

                    For Each service In serviceSelections
                        If service.Value Then
                            cmd.Parameters.AddWithValue("@serviceId", service.Key)
                            cmd.ExecuteNonQuery()
                            serviceList.Add(service.Key.ToString()) ' Add the service ID to the list
                            cmd.Parameters.RemoveAt("@serviceId") ' Reset parameter for next iteration
                        End If
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Error saving booking services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using

        ' Now update the services_availed column in the bookings table with a concatenated list of selected services
        Dim services As String = String.Join(", ", serviceList)
        Dim updateQuery As String = "UPDATE bookings SET services_availed = @services WHERE booking_id = @bookingId"
        Dim updateParams As New Dictionary(Of String, Object) From {
        {"@services", services},
        {"@bookingId", bookingId}
    }
        DBHelper.ExecuteQuery(updateQuery, updateParams)
    End Sub

    ' ------------------ Load Booked Dates ------------------
    Public Shared Function LoadBookedDates(placeId As Integer) As List(Of Date)
        Dim bookedDates As New List(Of Date)
        Dim query As String = "SELECT event_date, event_end_date FROM Bookings WHERE place_id = @place_id"

        Dim params As New Dictionary(Of String, Object) From {{"@place_id", placeId}}

        Dim dt As DataTable = DBHelper.GetDataTable(query, params)
        For Each row As DataRow In dt.Rows
            Dim startDate As Date = Convert.ToDateTime(row("event_date"))
            Dim endDate As Date = Convert.ToDateTime(row("event_end_date"))

            ' Add all dates in the range to the booked list
            For Each d As Date In Enumerable.Range(0, (endDate - startDate).Days + 1).Select(Function(i) startDate.AddDays(i))
                bookedDates.Add(d)
            Next
        Next


        Return bookedDates
    End Function

    ' ------------------ Populate Event Type Combo ------------------
    Public Shared Sub PopulateEventTypeCombo(eventPlaceName As String, cbEventType As ComboBox)
        cbEventType.Items.Clear()

        Dim query As String = "SELECT event_type FROM eventplace WHERE event_place = @event_place"
        Dim params As New Dictionary(Of String, Object) From {{"@event_place", eventPlaceName}}
        Dim dt As DataTable = DBHelper.GetDataTable(query, params)

        For Each row As DataRow In dt.Rows
            Dim eventTypes As String = row("event_type").ToString()
            Dim separatedTypes As String() = eventTypes.Split(","c)
            For Each eventType As String In separatedTypes
                cbEventType.Items.Add(eventType.Trim())
            Next
        Next
    End Sub

    Public Shared Function PlaceBooking(customerId As Integer, placeId As Integer, numGuests As Integer, eventDateStart As Date,
                                      eventStartTime As String, eventEndTime As String, eventEndDate As Date, totalPrice As Decimal) As Integer
        ' ------------------ Check if customer exists ------------------
        Dim checkCustomerQuery As String = "SELECT COUNT(*) FROM Customers WHERE customer_id = @customer_id"
        Dim checkCustomerParams As New Dictionary(Of String, Object) From {
        {"@customer_id", customerId}
    }
        Dim customerExists As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(checkCustomerQuery, checkCustomerParams))
        If customerExists = 0 Then
            MessageBox.Show("Customer not found! Please create a customer record first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End If

        ' ------------------ Duplicate Booking Check ------------------
        Dim checkQuery As String = "SELECT COUNT(*) FROM Bookings WHERE place_id = @place_id AND event_date = @event_date"
        Dim checkParams As New Dictionary(Of String, Object) From {
        {"@place_id", placeId},
        {"@event_date", eventDateStart}
    }
        Dim duplicateCount As Integer = Convert.ToInt32(DBHelper.ExecuteScalarQuery(checkQuery, checkParams))
        If duplicateCount > 0 Then
            Return -1
        End If

        ' ------------------ Time String Correction & Parsing ------------------
        Dim timeFormats() As String = {"h:mm tt", "hh:mm tt"}

        Dim correctedEventStartTime As String = eventStartTime.Trim()
        If Not correctedEventStartTime.Contains(":") Then
            correctedEventStartTime &= ":00"  ' Append default minutes if missing.
        End If
        If Not (correctedEventStartTime.ToUpper().Contains("AM") OrElse correctedEventStartTime.ToUpper().Contains("PM")) Then
            correctedEventStartTime &= " AM"  ' Append default meridiem if missing.
        End If

        Dim parsedStart As DateTime
        If Not DateTime.TryParseExact(correctedEventStartTime, timeFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedStart) Then
            Throw New FormatException("eventStartTime string format is not recognized: " & eventStartTime)
        End If

        Dim correctedEventEndTime As String = eventEndTime.Trim()
        If Not correctedEventEndTime.Contains(":") Then
            correctedEventEndTime &= ":00"
        End If
        If Not (correctedEventEndTime.ToUpper().Contains("AM") OrElse correctedEventEndTime.ToUpper().Contains("PM")) Then
            correctedEventEndTime &= " AM"
        End If

        Dim parsedEnd As DateTime
        If Not DateTime.TryParseExact(correctedEventEndTime, timeFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedEnd) Then
            Throw New FormatException("eventEndTime string format is not recognized: " & eventEndTime)
        End If

        Dim formattedStartTime As String = parsedStart.ToString("HH:mm:ss")
        Dim formattedEndTime As String = parsedEnd.ToString("HH:mm:ss")

        ' ------------------ Insert Booking ------------------
        Dim insertQuery As String = "INSERT INTO Bookings (customer_id, place_id, num_guests, event_date, event_time, event_end_time, event_end_date, total_price) " &
                                "VALUES (@customer_id, @place_id, @num_guests, @event_date, @event_time, @event_end_time, @event_end_date, @total_price)"
        Dim insertParams As New Dictionary(Of String, Object) From {
        {"@customer_id", customerId},
        {"@place_id", placeId},
        {"@num_guests", numGuests},
        {"@event_date", eventDateStart},
        {"@event_time", formattedStartTime},
        {"@event_end_time", formattedEndTime},
        {"@event_end_date", eventEndDate},  ' New field added for multi-day events
        {"@total_price", totalPrice}
    }

        Dim insertResult As Integer = DBHelper.ExecuteQuery(insertQuery, insertParams)
        ' If the insert did not affect any rows, then fail.
        If insertResult <= 0 Then
            Return -1
        End If

        ' ------------------ Retrieve Last Inserted Booking ID ------------------
        Dim bookingIdQuery As String = "SELECT LAST_INSERT_ID();"
        Dim bookingIdObj As Object = DBHelper.ExecuteScalarQuery(bookingIdQuery, New Dictionary(Of String, Object)())
        Return If(bookingIdObj IsNot Nothing, Convert.ToInt32(bookingIdObj), -1)
    End Function


    ' ------------------ Insert Payment Record ------------------
    Public Shared Sub InsertPaymentRecord(bookingId As Integer, customerId As Integer, amountToPay As Decimal)
        Dim query As String = "INSERT INTO payments (booking_id, customer_id, amount_to_pay) VALUES (@booking_id, @customer_id, @amount_to_pay)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@booking_id", bookingId},
            {"@customer_id", customerId},
            {"@amount_to_pay", amountToPay}
        }
        DBHelper.ExecuteQuery(query, params)
    End Sub

    Public Shared Function GetCustomerData(userId As Integer) As DataTable
        Dim query As String = "SELECT name, birthday, sex, address FROM Customers WHERE user_id = @userId"
        Dim parameters As New Dictionary(Of String, Object) From {{"@userId", userId}}
        Return DBHelper.GetDataTable(query, parameters)
    End Function

    Public Shared Function GetLastBooking(userId As Integer) As DataTable
        Dim query As String = "SELECT event_type, num_guests FROM Bookings WHERE customer_id = @userId ORDER BY booking_id DESC LIMIT 1"
        Dim params As New Dictionary(Of String, Object) From {{"@userId", userId}}
        Return DBHelper.GetDataTable(query, params)
    End Function

    ' Fetch detailed booking information for the admin view
    Public Shared Function GetBookingDetails(bookingId As Integer) As DataTable
        Dim query As String = "
        SELECT 
            b.booking_id, 
            b.customer_id, 
            e.event_place, 
            e.event_type, 
            b.num_guests, 
            b.event_date, 
            b.event_end_date, 
            b.event_time, 
            b.event_end_time, 
            b.total_price, 
            b.status, 
            b.services_availed, 
            p.payment_status, 
            i.invoice_date,  
            GROUP_CONCAT(s.service_name ORDER BY s.service_name) AS services_availed  -- Corrected join
        FROM bookings b
        JOIN customers c ON b.customer_id = c.customer_id
        JOIN eventplace e ON b.place_id = e.place_id
        LEFT JOIN payments p ON b.booking_id = p.booking_id
        LEFT JOIN invoices i ON b.booking_id = i.invoice_id  
        LEFT JOIN bookingservices bs ON b.booking_id = bs.booking_id
        LEFT JOIN services s ON bs.service_id = s.service_id  -- Added join with services table
        WHERE b.booking_id = @booking_id
        GROUP BY b.booking_id
        "

        Dim parameters As New Dictionary(Of String, Object) From {{"@booking_id", bookingId}}

        ' Get the data
        Dim dt As DataTable = DBHelper.GetDataTable(query, parameters)

        ' Check if there is any data
        If dt.Rows.Count = 0 Then
            ' If no data found, return an empty DataTable or log the error
            MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return dt
    End Function

End Class
