<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newUser))
        Me.confirmPasswordInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userNameInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'confirmPasswordInput
        '
        Me.confirmPasswordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPasswordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.confirmPasswordInput.Location = New System.Drawing.Point(204, 157)
        Me.confirmPasswordInput.Margin = New System.Windows.Forms.Padding(4)
        Me.confirmPasswordInput.MaxLength = 50
        Me.confirmPasswordInput.Name = "confirmPasswordInput"
        Me.confirmPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPasswordInput.Size = New System.Drawing.Size(200, 25)
        Me.confirmPasswordInput.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Confirm Password"
        '
        'passwordInput
        '
        Me.passwordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.passwordInput.Location = New System.Drawing.Point(204, 110)
        Me.passwordInput.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordInput.MaxLength = 50
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordInput.Size = New System.Drawing.Size(200, 25)
        Me.passwordInput.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'userNameInput
        '
        Me.userNameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.userNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.userNameInput.Location = New System.Drawing.Point(204, 64)
        Me.userNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userNameInput.MaxLength = 50
        Me.userNameInput.Name = "userNameInput"
        Me.userNameInput.Size = New System.Drawing.Size(200, 25)
        Me.userNameInput.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User Name"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(324, 203)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'newUser
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 282)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.confirmPasswordInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passwordInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userNameInput)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 320)
        Me.MinimumSize = New System.Drawing.Size(500, 320)
        Me.Name = "newUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents confirmPasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passwordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
