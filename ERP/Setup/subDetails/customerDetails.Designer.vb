<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerDetails
    Inherits system.windows.forms.form
    'Form overrides dispose to clean up the component list.    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer    Private components As System.ComponentModel.IContainer    'NOTE: The following procedure is required by the Windows Form Designer    'It can be modified using the Windows Form Designer.      'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerDetails))
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codeInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.landlineInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mobileInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contactPersonInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emailInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ntnInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.areaInput = New System.Windows.Forms.ComboBox()
        Me.subAreaInput = New System.Windows.Forms.ComboBox()
        Me.salePersonnelInput = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.nameInput.TabIndex = 24
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
        Me.Label3.TabIndex = 28
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
        Me.codeInput.TabIndex = 23
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
        Me.Label2.TabIndex = 27
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
        Me.btnSave.TabIndex = 9
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
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 265)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'addressInput
        '
        Me.addressInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.addressInput.Location = New System.Drawing.Point(157, 128)
        Me.addressInput.MaxLength = 250
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(496, 25)
        Me.addressInput.TabIndex = 0
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
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Address"
        '
        'landlineInput
        '
        Me.landlineInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landlineInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.landlineInput.Location = New System.Drawing.Point(157, 159)
        Me.landlineInput.MaxLength = 50
        Me.landlineInput.Name = "landlineInput"
        Me.landlineInput.Size = New System.Drawing.Size(496, 25)
        Me.landlineInput.TabIndex = 1
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
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Landline No."
        '
        'mobileInput
        '
        Me.mobileInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.mobileInput.Location = New System.Drawing.Point(157, 190)
        Me.mobileInput.MaxLength = 50
        Me.mobileInput.Name = "mobileInput"
        Me.mobileInput.Size = New System.Drawing.Size(496, 25)
        Me.mobileInput.TabIndex = 2
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
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Mobile No."
        '
        'contactPersonInput
        '
        Me.contactPersonInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactPersonInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.contactPersonInput.Location = New System.Drawing.Point(157, 221)
        Me.contactPersonInput.MaxLength = 250
        Me.contactPersonInput.Name = "contactPersonInput"
        Me.contactPersonInput.Size = New System.Drawing.Size(496, 25)
        Me.contactPersonInput.TabIndex = 3
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
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Contact Person"
        '
        'emailInput
        '
        Me.emailInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.emailInput.Location = New System.Drawing.Point(157, 252)
        Me.emailInput.MaxLength = 100
        Me.emailInput.Name = "emailInput"
        Me.emailInput.Size = New System.Drawing.Size(496, 25)
        Me.emailInput.TabIndex = 4
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
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Email Address"
        '
        'ntnInput
        '
        Me.ntnInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntnInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ntnInput.Location = New System.Drawing.Point(157, 283)
        Me.ntnInput.MaxLength = 50
        Me.ntnInput.Name = "ntnInput"
        Me.ntnInput.Size = New System.Drawing.Size(496, 25)
        Me.ntnInput.TabIndex = 5
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
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "NTN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(30, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Select Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(316, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Select Sub Area"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(30, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Select Salesman"
        '
        'areaInput
        '
        Me.areaInput.BackColor = System.Drawing.Color.White
        Me.areaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.areaInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.areaInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areaInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.areaInput.FormattingEnabled = True
        Me.areaInput.Items.AddRange(New Object() {""})
        Me.areaInput.Location = New System.Drawing.Point(157, 314)
        Me.areaInput.Name = "areaInput"
        Me.areaInput.Size = New System.Drawing.Size(153, 25)
        Me.areaInput.TabIndex = 6
        '
        'subAreaInput
        '
        Me.subAreaInput.BackColor = System.Drawing.Color.White
        Me.subAreaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subAreaInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subAreaInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subAreaInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subAreaInput.FormattingEnabled = True
        Me.subAreaInput.Items.AddRange(New Object() {""})
        Me.subAreaInput.Location = New System.Drawing.Point(437, 314)
        Me.subAreaInput.Name = "subAreaInput"
        Me.subAreaInput.Size = New System.Drawing.Size(216, 25)
        Me.subAreaInput.TabIndex = 7
        '
        'salePersonnelInput
        '
        Me.salePersonnelInput.BackColor = System.Drawing.Color.White
        Me.salePersonnelInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salePersonnelInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salePersonnelInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salePersonnelInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.salePersonnelInput.FormattingEnabled = True
        Me.salePersonnelInput.Items.AddRange(New Object() {""})
        Me.salePersonnelInput.Location = New System.Drawing.Point(157, 345)
        Me.salePersonnelInput.Name = "salePersonnelInput"
        Me.salePersonnelInput.Size = New System.Drawing.Size(496, 25)
        Me.salePersonnelInput.TabIndex = 8
        '
        'customerDetails
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 397)
        Me.Controls.Add(Me.salePersonnelInput)
        Me.Controls.Add(Me.subAreaInput)
        Me.Controls.Add(Me.areaInput)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "customerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Customer Details"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button    Friend WithEvents nameInput As TextBox    Friend WithEvents Label3 As Label    Friend WithEvents codeInput As TextBox    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addressInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents landlineInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mobileInput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents contactPersonInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents emailInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ntnInput As TextBox
    Friend WithEvents Label8 As Label    Friend WithEvents Label9 As Label    Friend WithEvents Label10 As Label    Friend WithEvents Label11 As Label    Friend WithEvents areaInput As ComboBox    Friend WithEvents subAreaInput As ComboBox
    Friend WithEvents salePersonnelInput As ComboBox
End Class