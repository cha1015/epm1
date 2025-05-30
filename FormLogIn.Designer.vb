<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogIn))
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lnklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblGeneralError = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(274, 258)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 14)
        Me.lblPassword.TabIndex = 40
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Cinzel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(274, 229)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 14)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "Email"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogIn
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Black
        Me.btnLogIn.Location = New System.Drawing.Point(407, 386)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(135, 32)
        Me.btnLogIn.TabIndex = 36
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnShowPass
        '
        Me.btnShowPass.BackColor = System.Drawing.Color.Transparent
        Me.btnShowPass.FlatAppearance.BorderSize = 0
        Me.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPass.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.ForeColor = System.Drawing.Color.Black
        Me.btnShowPass.Location = New System.Drawing.Point(647, 251)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(23, 23)
        Me.btnShowPass.TabIndex = 38
        Me.btnShowPass.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.Location = New System.Drawing.Point(352, 224)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 23)
        Me.txtEmail.TabIndex = 32
        '
        'lnklblSignUp
        '
        Me.lnklblSignUp.AutoSize = True
        Me.lnklblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lnklblSignUp.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lnklblSignUp.ForeColor = System.Drawing.Color.Black
        Me.lnklblSignUp.LinkColor = System.Drawing.Color.Gray
        Me.lnklblSignUp.Location = New System.Drawing.Point(273, 313)
        Me.lnklblSignUp.Name = "lnklblSignUp"
        Me.lnklblSignUp.Size = New System.Drawing.Size(182, 19)
        Me.lnklblSignUp.TabIndex = 35
        Me.lnklblSignUp.TabStop = True
        Me.lnklblSignUp.Text = "Don't have an account? Sign Up"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.txtPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtPass.Location = New System.Drawing.Point(352, 253)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(289, 23)
        Me.txtPass.TabIndex = 33
        '
        'lblGeneralError
        '
        Me.lblGeneralError.AutoSize = True
        Me.lblGeneralError.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneralError.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.lblGeneralError.ForeColor = System.Drawing.Color.DimGray
        Me.lblGeneralError.Location = New System.Drawing.Point(558, 313)
        Me.lblGeneralError.Name = "lblGeneralError"
        Me.lblGeneralError.Size = New System.Drawing.Size(112, 19)
        Me.lblGeneralError.TabIndex = 42
        Me.lblGeneralError.Text = "Invalid credentials."
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(46, 11)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 26)
        Me.btnNext.TabIndex = 89
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(20, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 26)
        Me.btnBack.TabIndex = 88
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.Log_In__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblGeneralError)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lnklblSignUp)
        Me.Controls.Add(Me.txtPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnShowPass As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lnklblSignUp As LinkLabel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblGeneralError As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
