<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coaLedgerRange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coaLedgerRange))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.coaCodeInput1 = New System.Windows.Forms.TextBox()
        Me.coaNameInput1 = New System.Windows.Forms.TextBox()
        Me.coaNameInput2 = New System.Windows.Forms.TextBox()
        Me.coaCodeInput2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 225
        Me.Label1.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "From:"
        '
        'fromDate
        '
        Me.fromDate.CustomFormat = "yyyy-MM-dd"
        Me.fromDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDate.Location = New System.Drawing.Point(95, 116)
        Me.fromDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.fromDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(377, 25)
        Me.fromDate.TabIndex = 2
        '
        'toDate
        '
        Me.toDate.CustomFormat = "yyyy-MM-dd"
        Me.toDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(95, 163)
        Me.toDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.toDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(377, 25)
        Me.toDate.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 229
        Me.Label7.Text = "A/c Code"
        '
        'coaCodeInput1
        '
        Me.coaCodeInput1.BackColor = System.Drawing.Color.White
        Me.coaCodeInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaCodeInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaCodeInput1.Location = New System.Drawing.Point(95, 31)
        Me.coaCodeInput1.MaxLength = 250
        Me.coaCodeInput1.Name = "coaCodeInput1"
        Me.coaCodeInput1.Size = New System.Drawing.Size(128, 25)
        Me.coaCodeInput1.TabIndex = 0
        '
        'coaNameInput1
        '
        Me.coaNameInput1.BackColor = System.Drawing.Color.LightGray
        Me.coaNameInput1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaNameInput1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaNameInput1.Location = New System.Drawing.Point(229, 31)
        Me.coaNameInput1.MaxLength = 250
        Me.coaNameInput1.Name = "coaNameInput1"
        Me.coaNameInput1.ReadOnly = True
        Me.coaNameInput1.Size = New System.Drawing.Size(243, 25)
        Me.coaNameInput1.TabIndex = 228
        '
        'coaNameInput2
        '
        Me.coaNameInput2.BackColor = System.Drawing.Color.LightGray
        Me.coaNameInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaNameInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaNameInput2.Location = New System.Drawing.Point(229, 76)
        Me.coaNameInput2.MaxLength = 250
        Me.coaNameInput2.Name = "coaNameInput2"
        Me.coaNameInput2.ReadOnly = True
        Me.coaNameInput2.Size = New System.Drawing.Size(243, 25)
        Me.coaNameInput2.TabIndex = 228
        '
        'coaCodeInput2
        '
        Me.coaCodeInput2.BackColor = System.Drawing.Color.White
        Me.coaCodeInput2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaCodeInput2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaCodeInput2.Location = New System.Drawing.Point(95, 76)
        Me.coaCodeInput2.MaxLength = 250
        Me.coaCodeInput2.Name = "coaCodeInput2"
        Me.coaCodeInput2.Size = New System.Drawing.Size(128, 25)
        Me.coaCodeInput2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "A/c Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(145, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 19)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Chart of Accounts Range"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(383, 210)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 40)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'coaLedgerRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.coaCodeInput2)
        Me.Controls.Add(Me.coaCodeInput1)
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
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "coaLedgerRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts Ledger in Range"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents coaCodeInput1 As System.Windows.Forms.TextBox
    Friend WithEvents coaNameInput1 As System.Windows.Forms.TextBox
    Friend WithEvents coaNameInput2 As System.Windows.Forms.TextBox
    Friend WithEvents coaCodeInput2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
