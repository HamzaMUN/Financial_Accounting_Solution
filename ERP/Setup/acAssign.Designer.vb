<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acAssign
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acAssign))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subLedgerInput = New System.Windows.Forms.ComboBox()
        Me.coaCodeInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.coaNameInput = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.acAssignID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codeL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameL3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acTypeID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.acTypeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Subsidiary Ledger"
        '
        'subLedgerInput
        '
        Me.subLedgerInput.BackColor = System.Drawing.Color.White
        Me.subLedgerInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subLedgerInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subLedgerInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subLedgerInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.subLedgerInput.FormattingEnabled = True
        Me.subLedgerInput.Items.AddRange(New Object() {""})
        Me.subLedgerInput.Location = New System.Drawing.Point(174, 105)
        Me.subLedgerInput.Name = "subLedgerInput"
        Me.subLedgerInput.Size = New System.Drawing.Size(486, 25)
        Me.subLedgerInput.TabIndex = 54
        '
        'coaCodeInput
        '
        Me.coaCodeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaCodeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaCodeInput.Location = New System.Drawing.Point(174, 53)
        Me.coaCodeInput.MaxLength = 250
        Me.coaCodeInput.Name = "coaCodeInput"
        Me.coaCodeInput.ReadOnly = True
        Me.coaCodeInput.Size = New System.Drawing.Size(118, 25)
        Me.coaCodeInput.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Chart of Account"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(684, 164)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'coaNameInput
        '
        Me.coaNameInput.BackColor = System.Drawing.Color.White
        Me.coaNameInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coaNameInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.coaNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coaNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.coaNameInput.FormattingEnabled = True
        Me.coaNameInput.Items.AddRange(New Object() {""})
        Me.coaNameInput.Location = New System.Drawing.Point(308, 53)
        Me.coaNameInput.Name = "coaNameInput"
        Me.coaNameInput.Size = New System.Drawing.Size(352, 25)
        Me.coaNameInput.TabIndex = 50
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(570, 136)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 25)
        Me.MenuStrip1.TabIndex = 59
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
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.acAssignID, Me.codeL3, Me.nameL3, Me.acTypeID, Me.acTypeName})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 198)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(684, 364)
        Me.ListView1.TabIndex = 58
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'acAssignID
        '
        Me.acAssignID.Text = "acAssignID"
        Me.acAssignID.Width = 0
        '
        'codeL3
        '
        Me.codeL3.Text = "Code"
        Me.codeL3.Width = 100
        '
        'nameL3
        '
        Me.nameL3.Text = "Account Name"
        Me.nameL3.Width = 360
        '
        'acTypeID
        '
        Me.acTypeID.Text = "acTypeID"
        Me.acTypeID.Width = 0
        '
        'acTypeName
        '
        Me.acTypeName.Text = "Assigned Subsidiary Type"
        Me.acTypeName.Width = 200
        '
        'acAssign
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.subLedgerInput)
        Me.Controls.Add(Me.coaCodeInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.coaNameInput)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 600)
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "acAssign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Assigning"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents subLedgerInput As System.Windows.Forms.ComboBox
    Friend WithEvents coaCodeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents coaNameInput As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents codeL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents nameL3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents acTypeID As System.Windows.Forms.ColumnHeader
    Friend WithEvents acTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents acAssignID As System.Windows.Forms.ColumnHeader
End Class
