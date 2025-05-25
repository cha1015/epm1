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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCurrentBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaymentSection
        '
        Me.lblPaymentSection.AutoSize = True
        Me.lblPaymentSection.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSection.Font = New System.Drawing.Font("Cinzel", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSection.Location = New System.Drawing.Point(28, 250)
        Me.lblPaymentSection.Name = "lblPaymentSection"
        Me.lblPaymentSection.Size = New System.Drawing.Size(109, 15)
        Me.lblPaymentSection.TabIndex = 115
        Me.lblPaymentSection.Text = "Payment Section"
        '
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(32, 272)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.RowHeadersWidth = 51
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(880, 143)
        Me.dgvPaymentHistory.TabIndex = 114
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmPayment.BackgroundImage = Global.epm1.My.Resources.Resources.BttnConfPayment
        Me.btnConfirmPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmPayment.FlatAppearance.BorderSize = 0
        Me.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(803, 452)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(118, 27)
        Me.btnConfirmPayment.TabIndex = 113
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'dgvCurrentBooking
        '
        Me.dgvCurrentBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentBooking.Location = New System.Drawing.Point(32, 116)
        Me.dgvCurrentBooking.Name = "dgvCurrentBooking"
        Me.dgvCurrentBooking.RowHeadersWidth = 51
        Me.dgvCurrentBooking.Size = New System.Drawing.Size(880, 126)
        Me.dgvCurrentBooking.TabIndex = 110
        '
        'btnSelectBooking
        '
        Me.btnSelectBooking.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectBooking.BackgroundImage = Global.epm1.My.Resources.Resources.bttnSelectBooking
        Me.btnSelectBooking.FlatAppearance.BorderSize = 0
        Me.btnSelectBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectBooking.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectBooking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectBooking.Location = New System.Drawing.Point(803, 422)
        Me.btnSelectBooking.Name = "btnSelectBooking"
        Me.btnSelectBooking.Size = New System.Drawing.Size(118, 27)
        Me.btnSelectBooking.TabIndex = 112
        Me.btnSelectBooking.UseVisualStyleBackColor = False
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentAmount.Location = New System.Drawing.Point(32, 453)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(765, 24)
        Me.txtPaymentAmount.TabIndex = 111
        '
        'lblCurrentBooking
        '
        Me.lblCurrentBooking.AutoSize = True
        Me.lblCurrentBooking.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentBooking.Font = New System.Drawing.Font("Cinzel", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentBooking.Location = New System.Drawing.Point(28, 94)
        Me.lblCurrentBooking.Name = "lblCurrentBooking"
        Me.lblCurrentBooking.Size = New System.Drawing.Size(116, 15)
        Me.lblCurrentBooking.TabIndex = 109
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
        Me.btnLogOut.Location = New System.Drawing.Point(845, 44)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(88, 23)
        Me.btnLogOut.TabIndex = 108
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Cinzel", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.Transparent
        Me.lblRole.Location = New System.Drawing.Point(750, 43)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(34, 15)
        Me.lblRole.TabIndex = 107
        Me.lblRole.Text = "User"
        '
        'btnEditInformation
        '
        Me.btnEditInformation.BackColor = System.Drawing.Color.Transparent
        Me.btnEditInformation.BackgroundImage = Global.epm1.My.Resources.Resources.bttnEditInfo
        Me.btnEditInformation.FlatAppearance.BorderSize = 0
        Me.btnEditInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditInformation.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditInformation.ForeColor = System.Drawing.Color.Black
        Me.btnEditInformation.Location = New System.Drawing.Point(845, 18)
        Me.btnEditInformation.Name = "btnEditInformation"
        Me.btnEditInformation.Size = New System.Drawing.Size(88, 23)
        Me.btnEditInformation.TabIndex = 106
        Me.btnEditInformation.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(750, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(43, 15)
        Me.lblUsername.TabIndex = 105
        Me.lblUsername.Text = "Guest"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(198, 33)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(21, 21)
        Me.btnNext.TabIndex = 104
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(173, 33)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(21, 21)
        Me.btnBack.TabIndex = 103
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormCustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.BGCustomerView
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
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
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "FormCustomerView"
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
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
