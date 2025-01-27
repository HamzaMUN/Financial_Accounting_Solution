<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subArea))
        Me.codeAreaInput = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.codeSubArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameSubArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.areaName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameAreaInput = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'codeAreaInput
        '
        Me.codeAreaInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeAreaInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.codeAreaInput.Location = New System.Drawing.Point(157, 42)
        Me.codeAreaInput.MaxLength = 2
        Me.codeAreaInput.Name = "codeAreaInput"
        Me.codeAreaInput.ReadOnly = True
        Me.codeAreaInput.Size = New System.Drawing.Size(100, 25)
        Me.codeAreaInput.TabIndex = 31
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(684, 77)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 25)
        Me.MenuStrip1.TabIndex = 27
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
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codeSubArea, Me.nameSubArea, Me.areaName})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 167)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(684, 395)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'codeSubArea
        '
        Me.codeSubArea.Text = "Code"
        '
        'nameSubArea
        '
        Me.nameSubArea.Text = "Name"
        Me.nameSubArea.Width = 295
        '
        'areaName
        '
        Me.areaName.Text = "Area"
        Me.areaName.Width = 316
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
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'nameAreaInput
        '
        Me.nameAreaInput.BackColor = System.Drawing.Color.White
        Me.nameAreaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameAreaInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nameAreaInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameAreaInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameAreaInput.FormattingEnabled = True
        Me.nameAreaInput.Items.AddRange(New Object() {""})
        Me.nameAreaInput.Location = New System.Drawing.Point(263, 42)
        Me.nameAreaInput.Name = "nameAreaInput"
        Me.nameAreaInput.Size = New System.Drawing.Size(365, 25)
        Me.nameAreaInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Select Area"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(553, 103)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.nameInput.Location = New System.Drawing.Point(157, 112)
        Me.nameInput.MaxLength = 250
        Me.nameInput.Name = "nameInput"
        Me.nameInput.ReadOnly = True
        Me.nameInput.Size = New System.Drawing.Size(374, 25)
        Me.nameInput.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 50)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'subArea
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.codeAreaInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.nameAreaInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 600)
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "subArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Area Creation"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents codeAreaInput As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents codeSubArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents nameSubArea As System.Windows.Forms.ColumnHeader
    Friend WithEvents areaName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nameAreaInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents nameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
