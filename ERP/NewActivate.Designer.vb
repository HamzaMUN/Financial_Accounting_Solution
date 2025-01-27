<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewActivate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewActivate))
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.keyInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.companyInput = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameInput
        '
        Me.nameInput.BackColor = System.Drawing.Color.White
        Me.nameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameInput.Location = New System.Drawing.Point(161, 24)
        Me.nameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.nameInput.MaxLength = 50
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(286, 25)
        Me.nameInput.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(104, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Activation Key"
        '
        'keyInput
        '
        Me.keyInput.BackColor = System.Drawing.Color.White
        Me.keyInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.keyInput.Location = New System.Drawing.Point(161, 57)
        Me.keyInput.Margin = New System.Windows.Forms.Padding(4)
        Me.keyInput.MaxLength = 25
        Me.keyInput.Name = "keyInput"
        Me.keyInput.Size = New System.Drawing.Size(286, 25)
        Me.keyInput.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Company Name"
        '
        'companyInput
        '
        Me.companyInput.BackColor = System.Drawing.Color.White
        Me.companyInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.companyInput.Location = New System.Drawing.Point(161, 90)
        Me.companyInput.Margin = New System.Windows.Forms.Padding(4)
        Me.companyInput.MaxLength = 250
        Me.companyInput.Name = "companyInput"
        Me.companyInput.Size = New System.Drawing.Size(286, 25)
        Me.companyInput.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.done32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(242, 123)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Validate"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnExit.Image = Global.ERP.My.Resources.Resources.close32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(362, 123)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'NewActivate
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 186)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.companyInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.keyInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewActivate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software Activation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents nameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents keyInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents companyInput As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
