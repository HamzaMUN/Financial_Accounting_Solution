<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashScreen))
        Me.loginLabel3 = New System.Windows.Forms.Label()
        Me.loginLabel2 = New System.Windows.Forms.Label()
        Me.loginLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.login_logo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.login_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginLabel3
        '
        Me.loginLabel3.AutoSize = True
        Me.loginLabel3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel3.Location = New System.Drawing.Point(20, 275)
        Me.loginLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.loginLabel3.Name = "loginLabel3"
        Me.loginLabel3.Size = New System.Drawing.Size(311, 14)
        Me.loginLabel3.TabIndex = 14
        Me.loginLabel3.Text = "© 2018 All Rights Reserved by Hexagon Solutionz (Pvt.) Limited."
        Me.loginLabel3.UseWaitCursor = True
        '
        'loginLabel2
        '
        Me.loginLabel2.AutoSize = True
        Me.loginLabel2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel2.Location = New System.Drawing.Point(419, 26)
        Me.loginLabel2.Name = "loginLabel2"
        Me.loginLabel2.Size = New System.Drawing.Size(58, 14)
        Me.loginLabel2.TabIndex = 13
        Me.loginLabel2.Text = "Version 1.1"
        Me.loginLabel2.UseWaitCursor = True
        '
        'loginLabel1
        '
        Me.loginLabel1.AutoSize = True
        Me.loginLabel1.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.loginLabel1.Location = New System.Drawing.Point(239, 45)
        Me.loginLabel1.Name = "loginLabel1"
        Me.loginLabel1.Size = New System.Drawing.Size(262, 109)
        Me.loginLabel1.TabIndex = 11
        Me.loginLabel1.Text = "Hexa"
        Me.loginLabel1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(254, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enterprise Resource Planning"
        Me.Label1.UseWaitCursor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(396, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(23, 242)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(454, 23)
        Me.ProgressBar1.TabIndex = 19
        Me.ProgressBar1.UseWaitCursor = True
        '
        'login_logo
        '
        Me.login_logo.BackColor = System.Drawing.Color.Transparent
        Me.login_logo.Image = Global.ERP.My.Resources.Resources.logo
        Me.login_logo.Location = New System.Drawing.Point(-2, 21)
        Me.login_logo.Name = "login_logo"
        Me.login_logo.Size = New System.Drawing.Size(250, 215)
        Me.login_logo.TabIndex = 9
        Me.login_logo.TabStop = False
        Me.login_logo.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(258, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "www.facebook.com/HexagonSolutionz"
        Me.Label3.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(259, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Contact Us: 0331-4543140"
        Me.Label4.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(254, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 40)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'splashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loginLabel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginLabel2)
        Me.Controls.Add(Me.loginLabel1)
        Me.Controls.Add(Me.login_logo)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splashScreen"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen"
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.login_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginLabel3 As Label

    Friend WithEvents loginLabel2 As Label

    Friend WithEvents loginLabel1 As Label

    Friend WithEvents login_logo As PictureBox

    Friend WithEvents Label1 As Label

    Friend WithEvents Timer1 As Timer

    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class