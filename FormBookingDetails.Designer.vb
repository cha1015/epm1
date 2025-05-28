<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookingDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblEventTime = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblNumGuests = New System.Windows.Forms.Label()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(70, 103)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(55, 25)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "Status"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatus.Location = New System.Drawing.Point(70, 391)
        Me.lblPaymentStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(121, 25)
        Me.lblPaymentStatus.TabIndex = 18
        Me.lblPaymentStatus.Text = "Payment Status"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(70, 359)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(83, 25)
        Me.lblTotalPrice.TabIndex = 17
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(70, 327)
        Me.lblServices.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(69, 25)
        Me.lblServices.TabIndex = 16
        Me.lblServices.Text = "Services"
        '
        'lblEventTime
        '
        Me.lblEventTime.AutoSize = True
        Me.lblEventTime.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTime.Location = New System.Drawing.Point(70, 295)
        Me.lblEventTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventTime.Name = "lblEventTime"
        Me.lblEventTime.Size = New System.Drawing.Size(46, 25)
        Me.lblEventTime.TabIndex = 15
        Me.lblEventTime.Text = "Time"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(70, 263)
        Me.lblEventDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(45, 25)
        Me.lblEventDate.TabIndex = 14
        Me.lblEventDate.Text = "Date"
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuests.Location = New System.Drawing.Point(70, 231)
        Me.lblNumGuests.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(138, 25)
        Me.lblNumGuests.TabIndex = 13
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.Location = New System.Drawing.Point(70, 199)
        Me.lblEventType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(88, 25)
        Me.lblEventType.TabIndex = 12
        Me.lblEventType.Text = "Event Type"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.Location = New System.Drawing.Point(70, 167)
        Me.lblEventPlace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(91, 25)
        Me.lblEventPlace.TabIndex = 11
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(70, 135)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(127, 25)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Customer Name"
        '
        'FormBookingDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 567)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPaymentStatus)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.lblEventTime)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.lblNumGuests)
        Me.Controls.Add(Me.lblEventType)
        Me.Controls.Add(Me.lblEventPlace)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Name = "FormBookingDetails"
        Me.Text = "FormBookingDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblEventTime As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents lblNumGuests As Label
    Friend WithEvents lblEventType As Label
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents lblCustomerName As Label
End Class
