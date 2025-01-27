<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trialSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trialSummary))
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPosted = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'toDate
        '
        Me.toDate.CustomFormat = "yyyy-MM-dd"
        Me.toDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(95, 41)
        Me.toDate.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.toDate.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(346, 25)
        Me.toDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "As on:"
        '
        'chkPosted
        '
        Me.chkPosted.AutoSize = True
        Me.chkPosted.Location = New System.Drawing.Point(95, 98)
        Me.chkPosted.Name = "chkPosted"
        Me.chkPosted.Size = New System.Drawing.Size(165, 21)
        Me.chkPosted.TabIndex = 217
        Me.chkPosted.Text = "Only Posted/Confirmed"
        Me.chkPosted.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(352, 86)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 40)
        Me.btnPrint.TabIndex = 216
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'trialSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 162)
        Me.Controls.Add(Me.chkPosted)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toDate)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 200)
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "trialSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trial Balances in Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents chkPosted As System.Windows.Forms.CheckBox
End Class
