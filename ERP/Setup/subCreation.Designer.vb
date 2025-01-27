<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subCreation
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then                components.Dispose()            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer    Private components As System.ComponentModel.IContainer    'NOTE: The following procedure is required by the Windows Form Designer    'It can be modified using the Windows Form Designer.      'Do not modify it using the code editor.    <System.Diagnostics.DebuggerStepThrough()> _    Private Sub InitializeComponent()        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subCreation))
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codeInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameL1Input = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupL2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameL2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codeL2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.codeL1Input = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SaveToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.save32
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DeleteToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.trash32
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.EditToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.edit32
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(538, 130)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameInput.Location = New System.Drawing.Point(157, 143)
        Me.nameInput.MaxLength = 250
        Me.nameInput.Name = "nameInput"
        Me.nameInput.ReadOnly = True
        Me.nameInput.Size = New System.Drawing.Size(374, 25)
        Me.nameInput.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Name"
        '
        'codeInput
        '
        Me.codeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeInput.Location = New System.Drawing.Point(157, 107)
        Me.codeInput.MaxLength = 4
        Me.codeInput.Name = "codeInput"
        Me.codeInput.ReadOnly = True
        Me.codeInput.Size = New System.Drawing.Size(100, 25)
        Me.codeInput.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Code"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.NewToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.newfolder
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'nameL1Input
        '
        Me.nameL1Input.BackColor = System.Drawing.Color.White
        Me.nameL1Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameL1Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nameL1Input.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameL1Input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameL1Input.FormattingEnabled = True
        Me.nameL1Input.Items.AddRange(New Object() {""})
        Me.nameL1Input.Location = New System.Drawing.Point(263, 41)
        Me.nameL1Input.Name = "nameL1Input"
        Me.nameL1Input.Size = New System.Drawing.Size(365, 25)
        Me.nameL1Input.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Account Type"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.EditDetailsToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(216, 70)
        '
        'EditDetailsToolStripMenuItem
        '
        Me.EditDetailsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.EditDetailsToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.details
        Me.EditDetailsToolStripMenuItem.Name = "EditDetailsToolStripMenuItem"
        Me.EditDetailsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditDetailsToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EditDetailsToolStripMenuItem.Text = "Edit Details"
        '
        'groupL2
        '
        Me.groupL2.Text = "Subsidiary Account Type"
        Me.groupL2.Width = 279
        '
        'nameL2
        '
        Me.nameL2.Text = "Subsidiary Account Name"
        Me.nameL2.Width = 311
        '
        'codeL2
        '
        Me.codeL2.Text = "Code"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codeL2, Me.nameL2, Me.groupL2})
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
        Me.ListView1.Size = New System.Drawing.Size(684, 373)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ExitToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.close32
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'codeL1Input
        '
        Me.codeL1Input.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeL1Input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeL1Input.Location = New System.Drawing.Point(157, 41)
        Me.codeL1Input.MaxLength = 2
        Me.codeL1Input.Name = "codeL1Input"
        Me.codeL1Input.ReadOnly = True
        Me.codeL1Input.Size = New System.Drawing.Size(100, 25)
        Me.codeL1Input.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(684, 100)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 50)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'subCreation
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codeInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameL1Input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.codeL1Input)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 600)
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "subCreation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidiary Ledgers Creation"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSave As Button    Friend WithEvents nameInput As TextBox
    Friend WithEvents Label3 As Label    Friend WithEvents codeInput As TextBox    Friend WithEvents Label2 As Label
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem    Friend WithEvents nameL1Input As ComboBox    Friend WithEvents Label1 As Label    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip    Friend WithEvents groupL2 As ColumnHeader    Friend WithEvents nameL2 As ColumnHeader    Friend WithEvents codeL2 As ColumnHeader    Friend WithEvents ListView1 As ListView    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem    Friend WithEvents codeL1Input As TextBox    Friend WithEvents PictureBox2 As PictureBox    Friend WithEvents PictureBox1 As PictureBox    Friend WithEvents MenuStrip1 As MenuStrip    Friend WithEvents EditDetailsToolStripMenuItem As ToolStripMenuItemEnd Class
