<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaxCapacity = New System.Windows.Forms.TextBox()
        Me.pnlSignUpLogIn = New System.Windows.Forms.Panel()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.clbAvailableOn = New System.Windows.Forms.CheckedListBox()
        Me.txtMaxPrice = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.cbSort = New System.Windows.Forms.ComboBox()
        Me.txtMinPrice = New System.Windows.Forms.TextBox()
        Me.txtMinCapacity = New System.Windows.Forms.TextBox()
        Me.clbEventType = New System.Windows.Forms.CheckedListBox()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnCustomerView = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.flpResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlSignUpLogIn.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(43, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Sort By"
        '
        'txtMaxCapacity
        '
        Me.txtMaxCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtMaxCapacity.Location = New System.Drawing.Point(88, 229)
        Me.txtMaxCapacity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaxCapacity.Name = "txtMaxCapacity"
        Me.txtMaxCapacity.Size = New System.Drawing.Size(50, 20)
        Me.txtMaxCapacity.TabIndex = 61
        Me.txtMaxCapacity.Text = "Max"
        '
        'pnlSignUpLogIn
        '
        Me.pnlSignUpLogIn.BackColor = System.Drawing.Color.Transparent
        Me.pnlSignUpLogIn.Controls.Add(Me.btnLogIn)
        Me.pnlSignUpLogIn.Controls.Add(Me.btnSignUp)
        Me.pnlSignUpLogIn.Location = New System.Drawing.Point(820, 9)
        Me.pnlSignUpLogIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSignUpLogIn.Name = "pnlSignUpLogIn"
        Me.pnlSignUpLogIn.Size = New System.Drawing.Size(107, 63)
        Me.pnlSignUpLogIn.TabIndex = 69
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogInMain
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Location = New System.Drawing.Point(28, 36)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(66, 19)
        Me.btnLogIn.TabIndex = 1
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BackgroundImage = Global.epm1.My.Resources.Resources.BttnSignUpMain
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(28, 14)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(66, 19)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Capacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Available On"
        '
        'btnClearFilters
        '
        Me.btnClearFilters.BackColor = System.Drawing.Color.Transparent
        Me.btnClearFilters.BackgroundImage = Global.epm1.My.Resources.Resources.BttnClearAll
        Me.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearFilters.FlatAppearance.BorderSize = 0
        Me.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnClearFilters.Location = New System.Drawing.Point(26, 344)
        Me.btnClearFilters.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(72, 24)
        Me.btnClearFilters.TabIndex = 64
        Me.btnClearFilters.UseVisualStyleBackColor = False
        '
        'clbAvailableOn
        '
        Me.clbAvailableOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.clbAvailableOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAvailableOn.ForeColor = System.Drawing.Color.Gray
        Me.clbAvailableOn.FormattingEnabled = True
        Me.clbAvailableOn.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.clbAvailableOn.Location = New System.Drawing.Point(8, 126)
        Me.clbAvailableOn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbAvailableOn.Name = "clbAvailableOn"
        Me.clbAvailableOn.Size = New System.Drawing.Size(183, 64)
        Me.clbAvailableOn.TabIndex = 67
        '
        'txtMaxPrice
        '
        Me.txtMaxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtMaxPrice.Location = New System.Drawing.Point(86, 276)
        Me.txtMaxPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaxPrice.Name = "txtMaxPrice"
        Me.txtMaxPrice.Size = New System.Drawing.Size(50, 20)
        Me.txtMaxPrice.TabIndex = 63
        Me.txtMaxPrice.Text = "Max"
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Transparent
        Me.btnApply.BackgroundImage = Global.epm1.My.Resources.Resources.BttnApply
        Me.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnApply.FlatAppearance.BorderSize = 0
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnApply.Location = New System.Drawing.Point(103, 344)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(72, 24)
        Me.btnApply.TabIndex = 58
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'cbSort
        '
        Me.cbSort.Font = New System.Drawing.Font("Poppins", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSort.ForeColor = System.Drawing.Color.DimGray
        Me.cbSort.FormattingEnabled = True
        Me.cbSort.Items.AddRange(New Object() {"Alphabetical (A-Z)", "Alphabetical (Z-A)", "Capacity (Lowest to Highest)", "Capacity (Highest to Lowest)", "Price (Lowest to Highest)", "Price (Highest to Lowest)"})
        Me.cbSort.Location = New System.Drawing.Point(104, 98)
        Me.cbSort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbSort.Name = "cbSort"
        Me.cbSort.Size = New System.Drawing.Size(224, 22)
        Me.cbSort.TabIndex = 56
        '
        'txtMinPrice
        '
        Me.txtMinPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtMinPrice.Location = New System.Drawing.Point(8, 276)
        Me.txtMinPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMinPrice.Name = "txtMinPrice"
        Me.txtMinPrice.Size = New System.Drawing.Size(50, 20)
        Me.txtMinPrice.TabIndex = 62
        Me.txtMinPrice.Text = "Min"
        '
        'txtMinCapacity
        '
        Me.txtMinCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtMinCapacity.Location = New System.Drawing.Point(9, 229)
        Me.txtMinCapacity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMinCapacity.Name = "txtMinCapacity"
        Me.txtMinCapacity.Size = New System.Drawing.Size(50, 20)
        Me.txtMinCapacity.TabIndex = 60
        Me.txtMinCapacity.Text = "Min"
        '
        'clbEventType
        '
        Me.clbEventType.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.clbEventType.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbEventType.ForeColor = System.Drawing.Color.Gray
        Me.clbEventType.FormattingEnabled = True
        Me.clbEventType.Items.AddRange(New Object() {"Classes & Workshops", "    Coffee Workshop", "    Cooking", "    Fitness", "    Tea Workshop", "Corporate Event", "    Dining", "    Party", "Formal Meetings & Team Gatherings", "    Conference", "    Interview", "    Sales Meeting", "    Team Bonding", "    Training", "Parties & Celebrations", "    Anniversary", "    Baby Shower", "    Birthday Party", "    Holiday & Festive Celebrations", "        Deepavali", "        Hari Raya", "        Year-End Party", "    Graduation Party", "    Lunch/Dinner", "    Prom", "Shoots & Productions", "    Green Screen Shoot", "    Live Webinar", "    Video Production", "Weddings & Related Events", "    Bridal Shower", "    Ceremony", "    Engagement", "    Proposal", "    Reception", "    Solemnization", "    Wedding"})
        Me.clbEventType.Location = New System.Drawing.Point(8, 24)
        Me.clbEventType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbEventType.Name = "clbEventType"
        Me.clbEventType.Size = New System.Drawing.Size(185, 76)
        Me.clbEventType.TabIndex = 57
        '
        'pnlAccount
        '
        Me.pnlAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAccount.BackColor = System.Drawing.Color.Transparent
        Me.pnlAccount.Controls.Add(Me.btnLogOut)
        Me.pnlAccount.Controls.Add(Me.lblUsername)
        Me.pnlAccount.Controls.Add(Me.btnCustomerView)
        Me.pnlAccount.Controls.Add(Me.lblUser)
        Me.pnlAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAccount.Location = New System.Drawing.Point(740, 11)
        Me.pnlAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(213, 63)
        Me.pnlAccount.TabIndex = 68
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = Global.epm1.My.Resources.Resources.BttnLogOut
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(112, 33)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(66, 19)
        Me.btnLogOut.TabIndex = 40
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(9, 15)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 15)
        Me.lblUsername.TabIndex = 37
        Me.lblUsername.Text = "Username"
        '
        'btnCustomerView
        '
        Me.btnCustomerView.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomerView.BackgroundImage = Global.epm1.My.Resources.Resources.BttnMyAccount
        Me.btnCustomerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerView.FlatAppearance.BorderSize = 0
        Me.btnCustomerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustomerView.Location = New System.Drawing.Point(112, 11)
        Me.btnCustomerView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCustomerView.Name = "btnCustomerView"
        Me.btnCustomerView.Size = New System.Drawing.Size(66, 19)
        Me.btnCustomerView.TabIndex = 2
        Me.btnCustomerView.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(9, 34)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(34, 15)
        Me.lblUser.TabIndex = 39
        Me.lblUser.Text = "User"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.epm1.My.Resources.Resources.BttnSearch
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(674, 35)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(14, 15)
        Me.btnSearch.TabIndex = 66
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(240, 35)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(414, 14)
        Me.txtSearch.TabIndex = 65
        '
        'flpResults
        '
        Me.flpResults.AutoScroll = True
        Me.flpResults.BackColor = System.Drawing.Color.Transparent
        Me.flpResults.Location = New System.Drawing.Point(28, 132)
        Me.flpResults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flpResults.Name = "flpResults"
        Me.flpResults.Size = New System.Drawing.Size(886, 346)
        Me.flpResults.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cinzel", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Event Type"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.clbEventType)
        Me.pnlFilter.Controls.Add(Me.Label1)
        Me.pnlFilter.Controls.Add(Me.Label2)
        Me.pnlFilter.Controls.Add(Me.txtMaxCapacity)
        Me.pnlFilter.Controls.Add(Me.btnClearFilters)
        Me.pnlFilter.Controls.Add(Me.btnApply)
        Me.pnlFilter.Controls.Add(Me.Label4)
        Me.pnlFilter.Controls.Add(Me.clbAvailableOn)
        Me.pnlFilter.Controls.Add(Me.txtMaxPrice)
        Me.pnlFilter.Controls.Add(Me.Label3)
        Me.pnlFilter.Controls.Add(Me.txtMinCapacity)
        Me.pnlFilter.Controls.Add(Me.txtMinPrice)
        Me.pnlFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(938, 109)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(200, 382)
        Me.pnlFilter.TabIndex = 82
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.BackgroundImage = Global.epm1.My.Resources.Resources.BttnFilter
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFilter.Location = New System.Drawing.Point(692, 37)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(12, 13)
        Me.btnFilter.TabIndex = 83
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.epm1.My.Resources.Resources.BttnPrevious
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(169, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(18, 20)
        Me.btnBack.TabIndex = 84
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.epm1.My.Resources.Resources.BttnNext
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(193, 32)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(18, 20)
        Me.btnNext.TabIndex = 85
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.epm1.My.Resources.Resources.MainBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pnlSignUpLogIn)
        Me.Controls.Add(Me.cbSort)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.flpResults)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlSignUpLogIn.ResumeLayout(False)
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaxCapacity As TextBox
    Friend WithEvents pnlSignUpLogIn As Panel
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents clbAvailableOn As CheckedListBox
    Friend WithEvents txtMaxPrice As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents cbSort As ComboBox
    Friend WithEvents txtMinPrice As TextBox
    Friend WithEvents txtMinCapacity As TextBox
    Friend WithEvents clbEventType As CheckedListBox
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnCustomerView As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents flpResults As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
