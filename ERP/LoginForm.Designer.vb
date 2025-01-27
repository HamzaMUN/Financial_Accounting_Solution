<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.loginLabel2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fiscalYearInput = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.usernameInput = New System.Windows.Forms.TextBox()
        Me.loginLabel6 = New System.Windows.Forms.Label()
        Me.loginLabel5 = New System.Windows.Forms.Label()
        Me.loginLabel4 = New System.Windows.Forms.Label()
        Me.loginLabel1 = New System.Windows.Forms.Label()
        Me.login_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.login_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginLabel2
        '
        Me.loginLabel2.AutoSize = True
        Me.loginLabel2.BackColor = System.Drawing.Color.Transparent
        Me.loginLabel2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel2.ForeColor = System.Drawing.Color.White
        Me.loginLabel2.Location = New System.Drawing.Point(192, 236)
        Me.loginLabel2.Name = "loginLabel2"
        Me.loginLabel2.Size = New System.Drawing.Size(58, 14)
        Me.loginLabel2.TabIndex = 18
        Me.loginLabel2.Text = "Version 1.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "www.facebook.com/HexagonSolutionz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Contact Us: 0331-4543140"
        '
        'fiscalYearInput
        '
        Me.fiscalYearInput.BackColor = System.Drawing.Color.White
        Me.fiscalYearInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fiscalYearInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fiscalYearInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiscalYearInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.fiscalYearInput.FormattingEnabled = True
        Me.fiscalYearInput.Items.AddRange(New Object() {""})
        Me.fiscalYearInput.Location = New System.Drawing.Point(18, 83)
        Me.fiscalYearInput.Name = "fiscalYearInput"
        Me.fiscalYearInput.Size = New System.Drawing.Size(203, 25)
        Me.fiscalYearInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Fiscal Year"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(18, 259)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(203, 44)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'passwordInput
        '
        Me.passwordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.passwordInput.Location = New System.Drawing.Point(18, 216)
        Me.passwordInput.MaxLength = 100
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(203, 25)
        Me.passwordInput.TabIndex = 2
        Me.passwordInput.UseSystemPasswordChar = True
        '
        'usernameInput
        '
        Me.usernameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.usernameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.usernameInput.Location = New System.Drawing.Point(18, 150)
        Me.usernameInput.MaxLength = 100
        Me.usernameInput.Name = "usernameInput"
        Me.usernameInput.Size = New System.Drawing.Size(203, 25)
        Me.usernameInput.TabIndex = 1
        '
        'loginLabel6
        '
        Me.loginLabel6.AutoSize = True
        Me.loginLabel6.BackColor = System.Drawing.SystemColors.Control
        Me.loginLabel6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel6.Location = New System.Drawing.Point(15, 187)
        Me.loginLabel6.Name = "loginLabel6"
        Me.loginLabel6.Size = New System.Drawing.Size(70, 17)
        Me.loginLabel6.TabIndex = 24
        Me.loginLabel6.Text = "Password"
        '
        'loginLabel5
        '
        Me.loginLabel5.AutoSize = True
        Me.loginLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.loginLabel5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel5.Location = New System.Drawing.Point(15, 120)
        Me.loginLabel5.Name = "loginLabel5"
        Me.loginLabel5.Size = New System.Drawing.Size(75, 17)
        Me.loginLabel5.TabIndex = 23
        Me.loginLabel5.Text = "Username"
        '
        'loginLabel4
        '
        Me.loginLabel4.AutoSize = True
        Me.loginLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.loginLabel4.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel4.Location = New System.Drawing.Point(299, 22)
        Me.loginLabel4.Name = "loginLabel4"
        Me.loginLabel4.Size = New System.Drawing.Size(178, 22)
        Me.loginLabel4.TabIndex = 22
        Me.loginLabel4.Text = "MEMBERS LOGIN"
        '
        'loginLabel1
        '
        Me.loginLabel1.AutoSize = True
        Me.loginLabel1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel1.ForeColor = System.Drawing.Color.White
        Me.loginLabel1.Location = New System.Drawing.Point(6, 253)
        Me.loginLabel1.Name = "loginLabel1"
        Me.loginLabel1.Size = New System.Drawing.Size(219, 19)
        Me.loginLabel1.TabIndex = 15
        Me.loginLabel1.Text = "Hexa ERP Financial Module"
        '
        'login_logo
        '
        Me.login_logo.ErrorImage = Nothing
        Me.login_logo.Image = CType(resources.GetObject("login_logo.Image"), System.Drawing.Image)
        Me.login_logo.InitialImage = Nothing
        Me.login_logo.Location = New System.Drawing.Point(8, 12)
        Me.login_logo.Name = "login_logo"
        Me.login_logo.Size = New System.Drawing.Size(250, 225)
        Me.login_logo.TabIndex = 13
        Me.login_logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.passwordInput)
        Me.Panel1.Controls.Add(Me.usernameInput)
        Me.Panel1.Controls.Add(Me.fiscalYearInput)
        Me.Panel1.Controls.Add(Me.loginLabel6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.loginLabel5)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(269, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 314)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(4, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 46)
        Me.Panel2.TabIndex = 31
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 327)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(521, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 32
        Me.StatusStrip1.Text = "© All Rights Reserved by"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(324, 17)
        Me.ToolStripStatusLabel1.Text = "© 2018 All Rights Reserved by Hexagon Solutionz (Pvt.) Limited."
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 349)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.loginLabel2)
        Me.Controls.Add(Me.loginLabel4)
        Me.Controls.Add(Me.loginLabel1)
        Me.Controls.Add(Me.login_logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hexa ERP Financial Module - Login"
        Me.TopMost = True
        CType(Me.login_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fiscalYearInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents passwordInput As System.Windows.Forms.TextBox
    Friend WithEvents usernameInput As System.Windows.Forms.TextBox
    Friend WithEvents loginLabel6 As System.Windows.Forms.Label
    Friend WithEvents loginLabel5 As System.Windows.Forms.Label
    Friend WithEvents loginLabel4 As System.Windows.Forms.Label
    Friend WithEvents loginLabel1 As System.Windows.Forms.Label
    Friend WithEvents login_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
