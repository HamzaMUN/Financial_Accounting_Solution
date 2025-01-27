<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subWCoaLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subWCoaLedger))
        Me.detailRadio = New System.Windows.Forms.RadioButton()
        Me.summaryRadio = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.subIDInput2 = New System.Windows.Forms.TextBox()
        Me.coaCodeInput2 = New System.Windows.Forms.TextBox()
        Me.subIDInput1 = New System.Windows.Forms.TextBox()
        Me.coaCodeInput1 = New System.Windows.Forms.TextBox()
        Me.subNameInput2 = New System.Windows.Forms.TextBox()
        Me.subNameInput1 = New System.Windows.Forms.TextBox()
        Me.coaNameInput2 = New System.Windows.Forms.TextBox()
        Me.coaNameInput1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'detailRadio
        '
        Me.detailRadio.AutoSize = True
        Me.detailRadio.Location = New System.Drawing.Point(186, 322)
        Me.detailRadio.Name = "detailRadio"
        Me.detailRadio.Size = New System.Drawing.Size(67, 21)
        Me.detailRadio.TabIndex = 7
        Me.detailRadio.TabStop = True
        Me.detailRadio.Text = "Details"
        Me.detailRadio.UseVisualStyleBackColor = True
        '
        'summaryRadio
        '
        Me.summaryRadio.AutoSize = True
        Me.summaryRadio.Location = New System.Drawing.Point(92, 322)
        Me.summaryRadio.Name = "summaryRadio"
        Me.summaryRadio.Size = New System.Drawing.Size(82, 21)
        Me.summaryRadio.TabIndex = 6
        Me.summaryRadio.TabStop = True
        Me.summaryRadio.Text = "Summary"
        Me.summaryRadio.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 258
        Me.Label8.Text = "A/c Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "A/c Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(144, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 19)
        Me.Label6.TabIndex = 260
        Me.Label6.Text = "Subsidiary Accounts Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(143, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 19)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "Chart of Accounts Range"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "A/c Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 262
        Me.Label7.Text = "A/c Code"
        '
        'subIDInput2
        '
        Me.subIDInput2.BackColor = System.Drawing.Color.White
        Me.subIDInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subIDInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subIDInput2.Location = New System.Drawing.Point(92, 75)
        Me.subIDInput2.MaxLength = 250
        Me.subIDInput2.Name = "subIDInput2"
        Me.subIDInput2.Size = New System.Drawing.Size(75, 25)
        Me.subIDInput2.TabIndex = 1
        '
        'coaCodeInput2
        '
        Me.coaCodeInput2.BackColor = System.Drawing.Color.White
        Me.coaCodeInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaCodeInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaCodeInput2.Location = New System.Drawing.Point(92, 179)
        Me.coaCodeInput2.MaxLength = 250
        Me.coaCodeInput2.Name = "coaCodeInput2"
        Me.coaCodeInput2.Size = New System.Drawing.Size(128, 25)
        Me.coaCodeInput2.TabIndex = 3
        '
        'subIDInput1
        '
        Me.subIDInput1.BackColor = System.Drawing.Color.White
        Me.subIDInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subIDInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subIDInput1.Location = New System.Drawing.Point(92, 30)
        Me.subIDInput1.MaxLength = 250
        Me.subIDInput1.Name = "subIDInput1"
        Me.subIDInput1.Size = New System.Drawing.Size(75, 25)
        Me.subIDInput1.TabIndex = 0
        '
        'coaCodeInput1
        '
        Me.coaCodeInput1.BackColor = System.Drawing.Color.White
        Me.coaCodeInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaCodeInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaCodeInput1.Location = New System.Drawing.Point(92, 134)
        Me.coaCodeInput1.MaxLength = 250
        Me.coaCodeInput1.Name = "coaCodeInput1"
        Me.coaCodeInput1.Size = New System.Drawing.Size(128, 25)
        Me.coaCodeInput1.TabIndex = 2
        '
        'subNameInput2
        '
        Me.subNameInput2.BackColor = System.Drawing.Color.LightGray
        Me.subNameInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subNameInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subNameInput2.Location = New System.Drawing.Point(173, 75)
        Me.subNameInput2.MaxLength = 250
        Me.subNameInput2.Name = "subNameInput2"
        Me.subNameInput2.ReadOnly = True
        Me.subNameInput2.Size = New System.Drawing.Size(296, 25)
        Me.subNameInput2.TabIndex = 253
        '
        'subNameInput1
        '
        Me.subNameInput1.BackColor = System.Drawing.Color.LightGray
        Me.subNameInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subNameInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subNameInput1.Location = New System.Drawing.Point(173, 30)
        Me.subNameInput1.MaxLength = 250
        Me.subNameInput1.Name = "subNameInput1"
        Me.subNameInput1.ReadOnly = True
        Me.subNameInput1.Size = New System.Drawing.Size(296, 25)
        Me.subNameInput1.TabIndex = 256
        '
        'coaNameInput2
        '
        Me.coaNameInput2.BackColor = System.Drawing.Color.LightGray
        Me.coaNameInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaNameInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaNameInput2.Location = New System.Drawing.Point(226, 179)
        Me.coaNameInput2.MaxLength = 250
        Me.coaNameInput2.Name = "coaNameInput2"
        Me.coaNameInput2.ReadOnly = True
        Me.coaNameInput2.Size = New System.Drawing.Size(243, 25)
        Me.coaNameInput2.TabIndex = 254
        '
        'coaNameInput1
        '
        Me.coaNameInput1.BackColor = System.Drawing.Color.LightGray
        Me.coaNameInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaNameInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaNameInput1.Location = New System.Drawing.Point(226, 134)
        Me.coaNameInput1.MaxLength = 250
        Me.coaNameInput1.Name = "coaNameInput1"
        Me.coaNameInput1.ReadOnly = True
        Me.coaNameInput1.Size = New System.Drawing.Size(243, 25)
        Me.coaNameInput1.TabIndex = 255
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "From:"
        '
        'fromDate
        '
        Me.fromDate.CustomFormat = "yyyy-MM-dd"
        Me.fromDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDate.Location = New System.Drawing.Point(92, 222)
        Me.fromDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.fromDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(377, 25)
        Me.fromDate.TabIndex = 4
        '
        'toDate
        '
        Me.toDate.CustomFormat = "yyyy-MM-dd"
        Me.toDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(92, 269)
        Me.toDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.toDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(377, 25)
        Me.toDate.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(380, 311)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 40)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'subWCoaLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.detailRadio)
        Me.Controls.Add(Me.summaryRadio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.subIDInput2)
        Me.Controls.Add(Me.coaCodeInput2)
        Me.Controls.Add(Me.subIDInput1)
        Me.Controls.Add(Me.coaCodeInput1)
        Me.Controls.Add(Me.subNameInput2)
        Me.Controls.Add(Me.subNameInput1)
        Me.Controls.Add(Me.coaNameInput2)
        Me.Controls.Add(Me.coaNameInput1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fromDate)
        Me.Controls.Add(Me.toDate)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "subWCoaLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidiary Accounts Wise Chart of Accounts Ledgers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents detailRadio As System.Windows.Forms.RadioButton
    Friend WithEvents summaryRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents subIDInput2 As System.Windows.Forms.TextBox
    Friend WithEvents coaCodeInput2 As System.Windows.Forms.TextBox
    Friend WithEvents subIDInput1 As System.Windows.Forms.TextBox
    Friend WithEvents coaCodeInput1 As System.Windows.Forms.TextBox
    Friend WithEvents subNameInput2 As System.Windows.Forms.TextBox
    Friend WithEvents subNameInput1 As System.Windows.Forms.TextBox
    Friend WithEvents coaNameInput2 As System.Windows.Forms.TextBox
    Friend WithEvents coaNameInput1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
End Class
