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
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblEventPlace = New System.Windows.Forms.Label()
        Me.lblEventType = New System.Windows.Forms.Label()
        Me.lblNumGuests = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblEventTime = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(41, 130)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(99, 19)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblEventPlace
        '
        Me.lblEventPlace.AutoSize = True
        Me.lblEventPlace.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPlace.Location = New System.Drawing.Point(41, 156)
        Me.lblEventPlace.Name = "lblEventPlace"
        Me.lblEventPlace.Size = New System.Drawing.Size(72, 19)
        Me.lblEventPlace.TabIndex = 1
        Me.lblEventPlace.Text = "Event Place"
        '
        'lblEventType
        '
        Me.lblEventType.AutoSize = True
        Me.lblEventType.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventType.Location = New System.Drawing.Point(41, 182)
        Me.lblEventType.Name = "lblEventType"
        Me.lblEventType.Size = New System.Drawing.Size(68, 19)
        Me.lblEventType.TabIndex = 2
        Me.lblEventType.Text = "Event Type"
        '
        'lblNumGuests
        '
        Me.lblNumGuests.AutoSize = True
        Me.lblNumGuests.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGuests.Location = New System.Drawing.Point(41, 208)
        Me.lblNumGuests.Name = "lblNumGuests"
        Me.lblNumGuests.Size = New System.Drawing.Size(109, 19)
        Me.lblNumGuests.TabIndex = 3
        Me.lblNumGuests.Text = "Number of Guests"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(41, 234)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(35, 19)
        Me.lblEventDate.TabIndex = 4
        Me.lblEventDate.Text = "Date"
        '
        'lblEventTime
        '
        Me.lblEventTime.AutoSize = True
        Me.lblEventTime.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTime.Location = New System.Drawing.Point(41, 260)
        Me.lblEventTime.Name = "lblEventTime"
        Me.lblEventTime.Size = New System.Drawing.Size(36, 19)
        Me.lblEventTime.TabIndex = 5
        Me.lblEventTime.Text = "Time"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(41, 286)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(55, 19)
        Me.lblServices.TabIndex = 6
        Me.lblServices.Text = "Services"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(41, 312)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(66, 19)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatus.Location = New System.Drawing.Point(41, 338)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(94, 19)
        Me.lblPaymentStatus.TabIndex = 8
        Me.lblPaymentStatus.Text = "Payment Status"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(41, 104)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 19)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status"
        '
        'FormBookingDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
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

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblEventPlace As Label
    Friend WithEvents lblEventType As Label
    Friend WithEvents lblNumGuests As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents lblEventTime As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents lblStatus As Label
End Class
