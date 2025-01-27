<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class batch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(batch))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.batchNoInput = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.batchID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nameBatch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productNameGot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.manufacturingDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.expiryDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.theoreticalYield = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.practicalYield = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yieldPercentage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qcIncharge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productionIncharge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productionSupervisor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.productIDInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productNameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.manufacturingDateInput = New System.Windows.Forms.DateTimePicker()
        Me.expiryDateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.theoreticalYieldInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.practcalYieldInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yieldPercentageInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.qcInchargeInput = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.productionInchargeInput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.productionSupervisorInput = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.statusInput = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.NewToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.newfolder
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NewToolStripMenuItem.Text = "New"
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ExitToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.close32
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'batchNoInput
        '
        Me.batchNoInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchNoInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.batchNoInput.Location = New System.Drawing.Point(95, 33)
        Me.batchNoInput.MaxLength = 250
        Me.batchNoInput.Name = "batchNoInput"
        Me.batchNoInput.ReadOnly = True
        Me.batchNoInput.Size = New System.Drawing.Size(417, 25)
        Me.batchNoInput.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.batchID, Me.nameBatch, Me.productID, Me.productNameGot, Me.manufacturingDate, Me.expiryDate, Me.theoreticalYield, Me.practicalYield, Me.yieldPercentage, Me.qcIncharge, Me.productionIncharge, Me.productionSupervisor, Me.status})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 261)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(804, 427)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'batchID
        '
        Me.batchID.Text = "batchID"
        Me.batchID.Width = 0
        '
        'nameBatch
        '
        Me.nameBatch.Text = "Batch No."
        Me.nameBatch.Width = 150
        '
        'productID
        '
        Me.productID.Text = "productID"
        Me.productID.Width = 0
        '
        'productNameGot
        '
        Me.productNameGot.Text = "Product"
        Me.productNameGot.Width = 150
        '
        'manufacturingDate
        '
        Me.manufacturingDate.Text = "Manufacturing Date"
        Me.manufacturingDate.Width = 150
        '
        'expiryDate
        '
        Me.expiryDate.Text = "Expiry Date"
        Me.expiryDate.Width = 150
        '
        'theoreticalYield
        '
        Me.theoreticalYield.Text = "theoreticalYield"
        Me.theoreticalYield.Width = 0
        '
        'practicalYield
        '
        Me.practicalYield.Text = "practicalYield"
        Me.practicalYield.Width = 0
        '
        'yieldPercentage
        '
        Me.yieldPercentage.Text = "Yield (%)"
        Me.yieldPercentage.Width = 100
        '
        'qcIncharge
        '
        Me.qcIncharge.Text = "qcIncharge"
        Me.qcIncharge.Width = 0
        '
        'productionIncharge
        '
        Me.productionIncharge.Text = "productionIncharge"
        Me.productionIncharge.Width = 0
        '
        'productionSupervisor
        '
        Me.productionSupervisor.Text = "productionSupervisor"
        Me.productionSupervisor.Width = 0
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.EditToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.edit32
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DeleteToolStripMenuItem.Image = Global.ERP.My.Resources.Resources.trash32
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Batch No"
        '
        'productIDInput
        '
        Me.productIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productIDInput.Location = New System.Drawing.Point(95, 64)
        Me.productIDInput.MaxLength = 250
        Me.productIDInput.Name = "productIDInput"
        Me.productIDInput.ReadOnly = True
        Me.productIDInput.Size = New System.Drawing.Size(150, 25)
        Me.productIDInput.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Product"
        '
        'productNameInput
        '
        Me.productNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productNameInput.Location = New System.Drawing.Point(251, 64)
        Me.productNameInput.MaxLength = 250
        Me.productNameInput.Name = "productNameInput"
        Me.productNameInput.ReadOnly = True
        Me.productNameInput.Size = New System.Drawing.Size(541, 25)
        Me.productNameInput.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Manufacturing Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(369, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Expiry Date"
        '
        'manufacturingDateInput
        '
        Me.manufacturingDateInput.CustomFormat = "yyyy-MM-dd"
        Me.manufacturingDateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manufacturingDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.manufacturingDateInput.Location = New System.Drawing.Point(163, 96)
        Me.manufacturingDateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.manufacturingDateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.manufacturingDateInput.Name = "manufacturingDateInput"
        Me.manufacturingDateInput.Size = New System.Drawing.Size(200, 25)
        Me.manufacturingDateInput.TabIndex = 4
        '
        'expiryDateInput
        '
        Me.expiryDateInput.CustomFormat = "yyyy-MM-dd"
        Me.expiryDateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expiryDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.expiryDateInput.Location = New System.Drawing.Point(465, 95)
        Me.expiryDateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.expiryDateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.expiryDateInput.Name = "expiryDateInput"
        Me.expiryDateInput.Size = New System.Drawing.Size(200, 25)
        Me.expiryDateInput.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Theoretical Yield"
        '
        'theoreticalYieldInput
        '
        Me.theoreticalYieldInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theoreticalYieldInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.theoreticalYieldInput.Location = New System.Drawing.Point(139, 127)
        Me.theoreticalYieldInput.MaxLength = 250
        Me.theoreticalYieldInput.Name = "theoreticalYieldInput"
        Me.theoreticalYieldInput.ReadOnly = True
        Me.theoreticalYieldInput.Size = New System.Drawing.Size(150, 25)
        Me.theoreticalYieldInput.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(295, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Practical Yied"
        '
        'practcalYieldInput
        '
        Me.practcalYieldInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.practcalYieldInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.practcalYieldInput.Location = New System.Drawing.Point(400, 127)
        Me.practcalYieldInput.MaxLength = 250
        Me.practcalYieldInput.Name = "practcalYieldInput"
        Me.practcalYieldInput.ReadOnly = True
        Me.practcalYieldInput.Size = New System.Drawing.Size(150, 25)
        Me.practcalYieldInput.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(556, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Yield (%)"
        '
        'yieldPercentageInput
        '
        Me.yieldPercentageInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yieldPercentageInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.yieldPercentageInput.Location = New System.Drawing.Point(639, 127)
        Me.yieldPercentageInput.MaxLength = 250
        Me.yieldPercentageInput.Name = "yieldPercentageInput"
        Me.yieldPercentageInput.ReadOnly = True
        Me.yieldPercentageInput.Size = New System.Drawing.Size(150, 25)
        Me.yieldPercentageInput.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "QC In-Charge"
        '
        'qcInchargeInput
        '
        Me.qcInchargeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qcInchargeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.qcInchargeInput.Location = New System.Drawing.Point(174, 158)
        Me.qcInchargeInput.MaxLength = 250
        Me.qcInchargeInput.Name = "qcInchargeInput"
        Me.qcInchargeInput.ReadOnly = True
        Me.qcInchargeInput.Size = New System.Drawing.Size(522, 25)
        Me.qcInchargeInput.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Production In-Charge"
        '
        'productionInchargeInput
        '
        Me.productionInchargeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productionInchargeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productionInchargeInput.Location = New System.Drawing.Point(174, 189)
        Me.productionInchargeInput.MaxLength = 250
        Me.productionInchargeInput.Name = "productionInchargeInput"
        Me.productionInchargeInput.ReadOnly = True
        Me.productionInchargeInput.Size = New System.Drawing.Size(522, 25)
        Me.productionInchargeInput.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Production Supervisor"
        '
        'productionSupervisorInput
        '
        Me.productionSupervisorInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productionSupervisorInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productionSupervisorInput.Location = New System.Drawing.Point(174, 220)
        Me.productionSupervisorInput.MaxLength = 250
        Me.productionSupervisorInput.Name = "productionSupervisorInput"
        Me.productionSupervisorInput.ReadOnly = True
        Me.productionSupervisorInput.Size = New System.Drawing.Size(522, 25)
        Me.productionSupervisorInput.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(518, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 19)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Status"
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
        Me.statusInput.Location = New System.Drawing.Point(575, 35)
        Me.statusInput.Name = "statusInput"
        Me.statusInput.Size = New System.Drawing.Size(217, 25)
        Me.statusInput.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(702, 205)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 40)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(804, 228)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'batch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 688)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.statusInput)
        Me.Controls.Add(Me.expiryDateInput)
        Me.Controls.Add(Me.manufacturingDateInput)
        Me.Controls.Add(Me.productionSupervisorInput)
        Me.Controls.Add(Me.productionInchargeInput)
        Me.Controls.Add(Me.qcInchargeInput)
        Me.Controls.Add(Me.productNameInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.yieldPercentageInput)
        Me.Controls.Add(Me.practcalYieldInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.theoreticalYieldInput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.productIDInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.batchNoInput)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(820, 726)
        Me.MinimumSize = New System.Drawing.Size(820, 726)
        Me.Name = "batch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Creation"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents batchNoInput As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents batchID As System.Windows.Forms.ColumnHeader
    Friend WithEvents nameBatch As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents productIDInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents manufacturingDateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents expiryDateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents theoreticalYieldInput As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents practcalYieldInput As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents yieldPercentageInput As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents qcInchargeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents productionInchargeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents productionSupervisorInput As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents statusInput As System.Windows.Forms.ComboBox
    Friend WithEvents productID As System.Windows.Forms.ColumnHeader
    Friend WithEvents productNameGot As System.Windows.Forms.ColumnHeader
    Friend WithEvents manufacturingDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents expiryDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents theoreticalYield As System.Windows.Forms.ColumnHeader
    Friend WithEvents practicalYield As System.Windows.Forms.ColumnHeader
    Friend WithEvents yieldPercentage As System.Windows.Forms.ColumnHeader
    Friend WithEvents qcIncharge As System.Windows.Forms.ColumnHeader
    Friend WithEvents productionIncharge As System.Windows.Forms.ColumnHeader
    Friend WithEvents productionSupervisor As System.Windows.Forms.ColumnHeader
    Friend WithEvents status As System.Windows.Forms.ColumnHeader
End Class
