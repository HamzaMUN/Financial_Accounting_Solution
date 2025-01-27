<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acL3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acL3))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.statusInput = New System.Windows.Forms.ComboBox()
        Me.linkInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.codeInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameL2Input = New System.Windows.Forms.ComboBox()
        Me.codeL2Input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.codeL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.controlL2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statusL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.linkL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(217, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Status"
        '
        'statusInput
        '
        Me.statusInput.BackColor = System.Drawing.Color.White
        Me.statusInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.statusInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.statusInput.FormattingEnabled = True
        Me.statusInput.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.statusInput.Location = New System.Drawing.Point(277, 147)
        Me.statusInput.Name = "statusInput"
        Me.statusInput.Size = New System.Drawing.Size(100, 25)
        Me.statusInput.TabIndex = 4
        '
        'linkInput
        '
        Me.linkInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.linkInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.linkInput.Location = New System.Drawing.Point(142, 147)
        Me.linkInput.MaxLength = 2
        Me.linkInput.Name = "linkInput"
        Me.linkInput.ReadOnly = True
        Me.linkInput.Size = New System.Drawing.Size(50, 25)
        Me.linkInput.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Link Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(217, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(667, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameInput.Location = New System.Drawing.Point(277, 105)
        Me.nameInput.MaxLength = 250
        Me.nameInput.Name = "nameInput"
        Me.nameInput.ReadOnly = True
        Me.nameInput.Size = New System.Drawing.Size(375, 25)
        Me.nameInput.TabIndex = 2
        '
        'codeInput
        '
        Me.codeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeInput.Location = New System.Drawing.Point(98, 105)
        Me.codeInput.MaxLength = 9
        Me.codeInput.Name = "codeInput"
        Me.codeInput.ReadOnly = True
        Me.codeInput.Size = New System.Drawing.Size(100, 25)
        Me.codeInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Code"
        '
        'nameL2Input
        '
        Me.nameL2Input.BackColor = System.Drawing.Color.White
        Me.nameL2Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameL2Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nameL2Input.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameL2Input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameL2Input.FormattingEnabled = True
        Me.nameL2Input.Items.AddRange(New Object() {""})
        Me.nameL2Input.Location = New System.Drawing.Point(277, 41)
        Me.nameL2Input.Name = "nameL2Input"
        Me.nameL2Input.Size = New System.Drawing.Size(375, 25)
        Me.nameL2Input.TabIndex = 0
        '
        'codeL2Input
        '
        Me.codeL2Input.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeL2Input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeL2Input.Location = New System.Drawing.Point(171, 41)
        Me.codeL2Input.MaxLength = 2
        Me.codeL2Input.Name = "codeL2Input"
        Me.codeL2Input.ReadOnly = True
        Me.codeL2Input.Size = New System.Drawing.Size(100, 25)
        Me.codeL2Input.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Group Account"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codeL3, Me.nameL3, Me.controlL2, Me.statusL3, Me.linkL3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 189)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(784, 373)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'codeL3
        '
        Me.codeL3.Text = "Code"
        Me.codeL3.Width = 100
        '
        'nameL3
        '
        Me.nameL3.Text = "Account Name"
        Me.nameL3.Width = 342
        '
        'controlL2
        '
        Me.controlL2.Text = "Control Account"
        Me.controlL2.Width = 200
        '
        'statusL3
        '
        Me.statusL3.Text = "Status"
        '
        'linkL3
        '
        Me.linkL3.Text = "Link"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.EditToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.edit32
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DeleteToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.trash32
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 25)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.NewToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.newfolder
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SaveToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.save32
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ExitToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.close32
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(784, 100)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(793, 50)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'acL3
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.statusInput)
        Me.Controls.Add(Me.linkInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.codeInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameL2Input)
        Me.Controls.Add(Me.codeL2Input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "acL3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 3 Chart of Accounts"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents statusInput As System.Windows.Forms.ComboBox
    Friend WithEvents linkInput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents nameInput As System.Windows.Forms.TextBox
    Friend WithEvents codeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameL2Input As System.Windows.Forms.ComboBox
    Friend WithEvents codeL2Input As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents codeL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents nameL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents controlL2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents linkL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
