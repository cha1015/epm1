﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCurrentBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaymentSection
        '
        Me.lblPaymentSection.AutoSize = True
        Me.lblPaymentSection.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSection.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSection.Location = New System.Drawing.Point(39, 231)
        Me.lblPaymentSection.Name = "lblPaymentSection"
        Me.lblPaymentSection.Size = New System.Drawing.Size(130, 25)
        Me.lblPaymentSection.TabIndex = 58
        Me.lblPaymentSection.Text = "Payment Section"
        '
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(43, 257)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.RowHeadersWidth = 51
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(863, 176)
        Me.dgvPaymentHistory.TabIndex = 57
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(783, 471)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(123, 26)
        Me.btnConfirmPayment.TabIndex = 56
        Me.btnConfirmPayment.Text = "Confirm Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'dgvCurrentBooking
        '
        Me.dgvCurrentBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentBooking.Location = New System.Drawing.Point(43, 104)
        Me.dgvCurrentBooking.Name = "dgvCurrentBooking"
        Me.dgvCurrentBooking.RowHeadersWidth = 51
        Me.dgvCurrentBooking.Size = New System.Drawing.Size(863, 124)
        Me.dgvCurrentBooking.TabIndex = 53
        '
        'btnSelectBooking
        '
        Me.btnSelectBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectBooking.FlatAppearance.BorderSize = 0
        Me.btnSelectBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectBooking.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectBooking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectBooking.Location = New System.Drawing.Point(43, 439)
        Me.btnSelectBooking.Name = "btnSelectBooking"
        Me.btnSelectBooking.Size = New System.Drawing.Size(863, 26)
        Me.btnSelectBooking.TabIndex = 55
        Me.btnSelectBooking.Text = "Select Booking"
        Me.btnSelectBooking.UseVisualStyleBackColor = False
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentAmount.Location = New System.Drawing.Point(46, 472)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(731, 30)
        Me.txtPaymentAmount.TabIndex = 54
        '
        'lblCurrentBooking
        '
        Me.lblCurrentBooking.AutoSize = True
        Me.lblCurrentBooking.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentBooking.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBooking.Location = New System.Drawing.Point(43, 82)
        Me.lblCurrentBooking.Name = "lblCurrentBooking"
        Me.lblCurrentBooking.Size = New System.Drawing.Size(124, 25)
        Me.lblCurrentBooking.TabIndex = 52
        Me.lblCurrentBooking.Text = "Current Booking"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(816, 45)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(120, 34)
        Me.btnLogOut.TabIndex = 51
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(598, 36)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(42, 25)
        Me.lblRole.TabIndex = 50
        Me.lblRole.Text = "User"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(816, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 34)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.Text = "Edit Information"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(598, 5)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(53, 25)
        Me.lblUsername.TabIndex = 48
        Me.lblUsername.Text = "Guest"
        '
        'FormCustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblUsername)
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblUsername As Label
End Class
