<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coaLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coaLedger))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.startDateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.endDateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.l3ControlAc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.l3ControlAcTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.l2AcCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.openingBalOutput = New System.Windows.Forms.TextBox()
        Me.drActivityOutput = New System.Windows.Forms.TextBox()
        Me.crActivityOutput = New System.Windows.Forms.TextBox()
        Me.closingBalOutput = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.ERP.My.Resources.Resources.close32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(924, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(829, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 40)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBalance
        '
        Me.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.Image = Global.ERP.My.Resources.Resources.l1ac32
        Me.btnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBalance.Location = New System.Drawing.Point(682, 12)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(141, 40)
        Me.btnBalance.TabIndex = 3
        Me.btnBalance.Text = "Show Balance"
        Me.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Search:"
        '
        'searchInput
        '
        Me.searchInput.BackColor = System.Drawing.Color.White
        Me.searchInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.searchInput.Location = New System.Drawing.Point(24, 90)
        Me.searchInput.MaxLength = 250
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(401, 25)
        Me.searchInput.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(12, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(994, 72)
        Me.PictureBox2.TabIndex = 211
        Me.PictureBox2.TabStop = False
        '
        'startDateInput
        '
        Me.startDateInput.CustomFormat = "yyyy-MM-dd"
        Me.startDateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDateInput.Location = New System.Drawing.Point(431, 90)
        Me.startDateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.startDateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.startDateInput.Name = "startDateInput"
        Me.startDateInput.Size = New System.Drawing.Size(200, 25)
        Me.startDateInput.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(427, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Starting Date"
        '
        'endDateInput
        '
        Me.endDateInput.CustomFormat = "yyyy-MM-dd"
        Me.endDateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDateInput.Location = New System.Drawing.Point(637, 90)
        Me.endDateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.endDateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.endDateInput.Name = "endDateInput"
        Me.endDateInput.Size = New System.Drawing.Size(200, 25)
        Me.endDateInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(633, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Ending Date"
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.l3ControlAc, Me.l3ControlAcTitle, Me.l2AcCode})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(12, 136)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(994, 439)
        Me.ListView1.TabIndex = 217
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'l3ControlAc
        '
        Me.l3ControlAc.Text = "A/c Code"
        Me.l3ControlAc.Width = 140
        '
        'l3ControlAcTitle
        '
        Me.l3ControlAcTitle.Text = "A/c Title"
        Me.l3ControlAcTitle.Width = 630
        '
        'l2AcCode
        '
        Me.l2AcCode.Text = "Control A/c Code"
        Me.l2AcCode.Width = 200
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 597)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 36)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "Opening Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(300, 597)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 36)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "Debit Activity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(533, 597)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 36)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Credit Activity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(771, 597)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 36)
        Me.Label7.TabIndex = 218
        Me.Label7.Text = "Closing Balance"
        '
        'openingBalOutput
        '
        Me.openingBalOutput.BackColor = System.Drawing.Color.White
        Me.openingBalOutput.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openingBalOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.openingBalOutput.Location = New System.Drawing.Point(12, 636)
        Me.openingBalOutput.MaxLength = 50
        Me.openingBalOutput.Name = "openingBalOutput"
        Me.openingBalOutput.ReadOnly = True
        Me.openingBalOutput.Size = New System.Drawing.Size(250, 44)
        Me.openingBalOutput.TabIndex = 219
        Me.openingBalOutput.Text = "0"
        Me.openingBalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'drActivityOutput
        '
        Me.drActivityOutput.BackColor = System.Drawing.Color.White
        Me.drActivityOutput.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drActivityOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.drActivityOutput.Location = New System.Drawing.Point(268, 636)
        Me.drActivityOutput.MaxLength = 50
        Me.drActivityOutput.Name = "drActivityOutput"
        Me.drActivityOutput.ReadOnly = True
        Me.drActivityOutput.Size = New System.Drawing.Size(240, 44)
        Me.drActivityOutput.TabIndex = 219
        Me.drActivityOutput.Text = "0"
        Me.drActivityOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'crActivityOutput
        '
        Me.crActivityOutput.BackColor = System.Drawing.Color.White
        Me.crActivityOutput.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crActivityOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.crActivityOutput.Location = New System.Drawing.Point(514, 636)
        Me.crActivityOutput.MaxLength = 50
        Me.crActivityOutput.Name = "crActivityOutput"
        Me.crActivityOutput.ReadOnly = True
        Me.crActivityOutput.Size = New System.Drawing.Size(240, 44)
        Me.crActivityOutput.TabIndex = 219
        Me.crActivityOutput.Text = "0"
        Me.crActivityOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'closingBalOutput
        '
        Me.closingBalOutput.BackColor = System.Drawing.Color.White
        Me.closingBalOutput.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closingBalOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.closingBalOutput.Location = New System.Drawing.Point(760, 636)
        Me.closingBalOutput.MaxLength = 50
        Me.closingBalOutput.Name = "closingBalOutput"
        Me.closingBalOutput.ReadOnly = True
        Me.closingBalOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.closingBalOutput.Size = New System.Drawing.Size(250, 44)
        Me.closingBalOutput.TabIndex = 219
        Me.closingBalOutput.Text = "0"
        Me.closingBalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coaLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 692)
        Me.Controls.Add(Me.closingBalOutput)
        Me.Controls.Add(Me.crActivityOutput)
        Me.Controls.Add(Me.drActivityOutput)
        Me.Controls.Add(Me.openingBalOutput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.endDateInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startDateInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 720)
        Me.MinimumSize = New System.Drawing.Size(1024, 720)
        Me.Name = "coaLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts Ledger"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnBalance As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents searchInput As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents startDateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents endDateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents openingBalOutput As System.Windows.Forms.TextBox
    Friend WithEvents drActivityOutput As System.Windows.Forms.TextBox
    Friend WithEvents crActivityOutput As System.Windows.Forms.TextBox
    Friend WithEvents closingBalOutput As System.Windows.Forms.TextBox
    Friend WithEvents l3ControlAc As System.Windows.Forms.ColumnHeader
    Friend WithEvents l3ControlAcTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents l2AcCode As System.Windows.Forms.ColumnHeader
End Class
