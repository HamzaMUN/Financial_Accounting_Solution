<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subsidiaryActivity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subsidiaryActivity))
        Me.chkPosted = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.subCategory = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'chkPosted
        '
        Me.chkPosted.AutoSize = True
        Me.chkPosted.Location = New System.Drawing.Point(89, 198)
        Me.chkPosted.Name = "chkPosted"
        Me.chkPosted.Size = New System.Drawing.Size(165, 21)
        Me.chkPosted.TabIndex = 228
        Me.chkPosted.Text = "Only Posted/Confirmed"
        Me.chkPosted.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(34, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "From:"
        '
        'fromDate
        '
        Me.fromDate.CustomFormat = "yyyy-MM-dd"
        Me.fromDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDate.Location = New System.Drawing.Point(89, 94)
        Me.fromDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.fromDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(346, 25)
        Me.fromDate.TabIndex = 224
        '
        'toDate
        '
        Me.toDate.CustomFormat = "yyyy-MM-dd"
        Me.toDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(89, 141)
        Me.toDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.toDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(346, 25)
        Me.toDate.TabIndex = 223
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(346, 186)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 40)
        Me.btnPrint.TabIndex = 227
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(87, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Subsidiary Type"
        '
        'subCategory
        '
        Me.subCategory.BackColor = System.Drawing.Color.LightGray
        Me.subCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subCategory.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subCategory.FormattingEnabled = True
        Me.subCategory.Items.AddRange(New Object() {""})
        Me.subCategory.Location = New System.Drawing.Point(89, 52)
        Me.subCategory.Name = "subCategory"
        Me.subCategory.Size = New System.Drawing.Size(346, 25)
        Me.subCategory.TabIndex = 241
        '
        'subsidiaryActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.subCategory)
        Me.Controls.Add(Me.chkPosted)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fromDate)
        Me.Controls.Add(Me.toDate)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "subsidiaryActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidiary Activity Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkPosted As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents subCategory As System.Windows.Forms.ComboBox
End Class
