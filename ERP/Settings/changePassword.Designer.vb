<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changePassword))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.confirmPasswordInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newPasswordInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userNameInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(323, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'confirmPasswordInput
        '
        Me.confirmPasswordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPasswordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.confirmPasswordInput.Location = New System.Drawing.Point(203, 212)
        Me.confirmPasswordInput.Margin = New System.Windows.Forms.Padding(4)
        Me.confirmPasswordInput.MaxLength = 50
        Me.confirmPasswordInput.Name = "confirmPasswordInput"
        Me.confirmPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPasswordInput.ReadOnly = True
        Me.confirmPasswordInput.Size = New System.Drawing.Size(200, 25)
        Me.confirmPasswordInput.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Confirm Password"
        '
        'newPasswordInput
        '
        Me.newPasswordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPasswordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.newPasswordInput.Location = New System.Drawing.Point(203, 165)
        Me.newPasswordInput.Margin = New System.Windows.Forms.Padding(4)
        Me.newPasswordInput.MaxLength = 50
        Me.newPasswordInput.Name = "newPasswordInput"
        Me.newPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPasswordInput.ReadOnly = True
        Me.newPasswordInput.Size = New System.Drawing.Size(200, 25)
        Me.newPasswordInput.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "New Password"
        '
        'btnDone
        '
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(323, 118)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(80, 30)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'passwordInput
        '
        Me.passwordInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.passwordInput.Location = New System.Drawing.Point(203, 75)
        Me.passwordInput.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordInput.MaxLength = 50
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordInput.Size = New System.Drawing.Size(200, 25)
        Me.passwordInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Password"
        '
        'userNameInput
        '
        Me.userNameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.userNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.userNameInput.Location = New System.Drawing.Point(203, 29)
        Me.userNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.userNameInput.MaxLength = 50
        Me.userNameInput.Name = "userNameInput"
        Me.userNameInput.Size = New System.Drawing.Size(200, 25)
        Me.userNameInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "User Name"
        '
        'changePassword
        '
        Me.AcceptButton = Me.btnDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 312)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.confirmPasswordInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.newPasswordInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.passwordInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userNameInput)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 350)
        Me.MinimumSize = New System.Drawing.Size(500, 350)
        Me.Name = "changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents confirmPasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents newPasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents passwordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
