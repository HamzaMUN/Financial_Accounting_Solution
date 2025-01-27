<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeeDetails
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.    <System.Diagnostics.DebuggerNonUserCode()> _    Protected Overrides Sub Dispose(ByVal disposing As Boolean)        Try            If disposing AndAlso components IsNot Nothing Then                components.Dispose()            End If        Finally            MyBase.Dispose(disposing)        End Try    End Sub    'Required by the Windows Form Designer    Private components As System.ComponentModel.IContainer    'NOTE: The following procedure is required by the Windows Form Designer    'It can be modified using the Windows Form Designer.      'Do not modify it using the code editor.    <System.Diagnostics.DebuggerStepThrough()> _    Private Sub InitializeComponent()        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeeDetails))
        Me.ntnInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.emailInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.contactPersonInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mobileInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.landlineInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codeInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ntnInput
        '
        Me.ntnInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntnInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ntnInput.Location = New System.Drawing.Point(157, 283)
        Me.ntnInput.MaxLength = 50
        Me.ntnInput.Name = "ntnInput"
        Me.ntnInput.Size = New System.Drawing.Size(496, 25)
        Me.ntnInput.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(30, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "NTN"
        '
        'emailInput
        '
        Me.emailInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.emailInput.Location = New System.Drawing.Point(157, 252)
        Me.emailInput.MaxLength = 100
        Me.emailInput.Name = "emailInput"
        Me.emailInput.Size = New System.Drawing.Size(496, 25)
        Me.emailInput.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Email Address"
        '
        'contactPersonInput
        '
        Me.contactPersonInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactPersonInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.contactPersonInput.Location = New System.Drawing.Point(157, 221)
        Me.contactPersonInput.MaxLength = 250
        Me.contactPersonInput.Name = "contactPersonInput"
        Me.contactPersonInput.Size = New System.Drawing.Size(496, 25)
        Me.contactPersonInput.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Contact Person"
        '
        'mobileInput
        '
        Me.mobileInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.mobileInput.Location = New System.Drawing.Point(157, 190)
        Me.mobileInput.MaxLength = 50
        Me.mobileInput.Name = "mobileInput"
        Me.mobileInput.Size = New System.Drawing.Size(496, 25)
        Me.mobileInput.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Mobile No."
        '
        'landlineInput
        '
        Me.landlineInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landlineInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.landlineInput.Location = New System.Drawing.Point(157, 159)
        Me.landlineInput.MaxLength = 50
        Me.landlineInput.Name = "landlineInput"
        Me.landlineInput.Size = New System.Drawing.Size(496, 25)
        Me.landlineInput.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Landline No."
        '
        'addressInput
        '
        Me.addressInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.addressInput.Location = New System.Drawing.Point(157, 128)
        Me.addressInput.MaxLength = 250
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(496, 25)
        Me.addressInput.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Address"
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameInput.Location = New System.Drawing.Point(157, 72)
        Me.nameInput.MaxLength = 250
        Me.nameInput.Name = "nameInput"
        Me.nameInput.ReadOnly = True
        Me.nameInput.Size = New System.Drawing.Size(400, 25)
        Me.nameInput.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Name"
        '
        'codeInput
        '
        Me.codeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeInput.Location = New System.Drawing.Point(157, 36)
        Me.codeInput.MaxLength = 4
        Me.codeInput.Name = "codeInput"
        Me.codeInput.ReadOnly = True
        Me.codeInput.Size = New System.Drawing.Size(100, 25)
        Me.codeInput.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Code"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(563, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 67
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(660, 100)
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 201)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'employeeDetails
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 332)
        Me.Controls.Add(Me.ntnInput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.emailInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.contactPersonInput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mobileInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.landlineInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addressInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codeInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "employeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Employee Details"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub    Friend WithEvents ntnInput As TextBox    Friend WithEvents Label8 As Label    Friend WithEvents emailInput As TextBox    Friend WithEvents Label7 As Label    Friend WithEvents contactPersonInput As TextBox    Friend WithEvents Label6 As Label    Friend WithEvents mobileInput As TextBox    Friend WithEvents Label5 As Label    Friend WithEvents landlineInput As TextBox    Friend WithEvents Label4 As Label    Friend WithEvents addressInput As TextBox    Friend WithEvents Label1 As Label    Friend WithEvents btnSave As Button    Friend WithEvents nameInput As TextBox    Friend WithEvents Label3 As Label    Friend WithEvents codeInput As TextBox    Friend WithEvents Label2 As Label    Friend WithEvents PictureBox2 As PictureBox    Friend WithEvents PictureBox1 As PictureBoxEnd Class
