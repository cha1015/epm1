<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerView
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
        Me.lblPaymentSection = New System.Windows.Forms.Label()
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.dgvCurrentBooking = New System.Windows.Forms.DataGridView()
        Me.btnSelectBooking = New System.Windows.Forms.Button()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.lblCurrentBooking = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnEditInformation = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCurrentBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaymentSection
        '
        Me.lblPaymentSection.AutoSize = True
        Me.lblPaymentSection.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSection.Font = New System.Drawing.Font("Cinzel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPaymentSection.Location = New System.Drawing.Point(53, 299)
        Me.lblPaymentSection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentSection.Name = "lblPaymentSection"
        Me.lblPaymentSection.Size = New System.Drawing.Size(167, 23)
        Me.lblPaymentSection.TabIndex = 58
        Me.lblPaymentSection.Text = "Payment Section"
        '
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(57, 336)
        Me.dgvPaymentHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.RowHeadersWidth = 51
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(1151, 168)
        Me.dgvPaymentHistory.TabIndex = 57
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackgroundImage = Global.epm1.My.Resources.Resources.BttnConfPayment
        Me.btnConfirmPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmPayment.FlatAppearance.BorderSize = 0
        Me.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(1064, 552)
        Me.btnConfirmPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(144, 32)
        Me.btnConfirmPayment.TabIndex = 56
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'dgvCurrentBooking
        '
        Me.dgvCurrentBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentBooking.Location = New System.Drawing.Point(57, 142)
        Me.dgvCurrentBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCurrentBooking.Name = "dgvCurrentBooking"
        Me.dgvCurrentBooking.RowHeadersWidth = 51
        Me.dgvCurrentBooking.Size = New System.Drawing.Size(1151, 153)
        Me.dgvCurrentBooking.TabIndex = 53
        '
        'btnSelectBooking
        '
        Me.btnSelectBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectBooking.FlatAppearance.BorderSize = 0
        Me.btnSelectBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectBooking.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectBooking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectBooking.Location = New System.Drawing.Point(57, 512)
        Me.btnSelectBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectBooking.Name = "btnSelectBooking"
        Me.btnSelectBooking.Size = New System.Drawing.Size(1151, 32)
        Me.btnSelectBooking.TabIndex = 55
        Me.btnSelectBooking.Text = "Select Booking"
        Me.btnSelectBooking.UseVisualStyleBackColor = False
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.txtPaymentAmount.ForeColor = System.Drawing.Color.Gray
        Me.txtPaymentAmount.Location = New System.Drawing.Point(57, 552)
        Me.txtPaymentAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(999, 27)
        Me.txtPaymentAmount.TabIndex = 54
        '
        'lblCurrentBooking
        '
        Me.lblCurrentBooking.AutoSize = True
        Me.lblCurrentBooking.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentBooking.Font = New System.Drawing.Font("Cinzel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentBooking.Location = New System.Drawing.Point(57, 115)
        Me.lblCurrentBooking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentBooking.Name = "lblCurrentBooking"
        Me.lblCurrentBooking.Size = New System.Drawing.Size(173, 23)
        Me.lblCurrentBooking.TabIndex = 52
        Me.lblCurrentBooking.Text = "Current Booking"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogOut
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(1141, 53)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(90, 25)
        Me.btnLogOut.TabIndex = 51
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(1007, 55)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(39, 18)
        Me.lblRole.TabIndex = 50
        Me.lblRole.Text = "User"
        '
        'btnEditInformation
        '
        Me.btnEditInformation.BackColor = System.Drawing.Color.Transparent
        Me.btnEditInformation.BackgroundImage = Global.epm1.My.Resources.Resources.bttnEditInfo
        Me.btnEditInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditInformation.FlatAppearance.BorderSize = 0
        Me.btnEditInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditInformation.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditInformation.ForeColor = System.Drawing.Color.Black
        Me.btnEditInformation.Location = New System.Drawing.Point(1141, 25)
        Me.btnEditInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditInformation.Name = "btnEditInformation"
        Me.btnEditInformation.Size = New System.Drawing.Size(90, 25)
        Me.btnEditInformation.TabIndex = 49
        Me.btnEditInformation.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1006, 34)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(59, 21)
        Me.lblUsername.TabIndex = 48
        Me.lblUsername.Text = "Guest"
        '
        'FormCustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGCustomerView
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 617)
        Me.Controls.Add(Me.lblPaymentSection)
        Me.Controls.Add(Me.dgvPaymentHistory)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.dgvCurrentBooking)
        Me.Controls.Add(Me.btnSelectBooking)
        Me.Controls.Add(Me.txtPaymentAmount)
        Me.Controls.Add(Me.lblCurrentBooking)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnEditInformation)
        Me.Controls.Add(Me.lblUsername)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormCustomerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCustomerView"
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCurrentBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPaymentSection As Label
    Friend WithEvents dgvPaymentHistory As DataGridView
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents dgvCurrentBooking As DataGridView
    Friend WithEvents btnSelectBooking As Button
    Friend WithEvents txtPaymentAmount As TextBox
    Friend WithEvents lblCurrentBooking As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents btnEditInformation As Button
    Friend WithEvents lblUsername As Label
End Class
