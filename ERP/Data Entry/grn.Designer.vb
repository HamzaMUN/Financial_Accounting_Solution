<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusInput = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.warehouseInput = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.partyCatInput = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.manualInvoiceInput = New System.Windows.Forms.TextBox()
        Me.transporterInput = New System.Windows.Forms.TextBox()
        Me.biltyNoInput = New System.Windows.Forms.TextBox()
        Me.qtyInput = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.batchCodeInput = New System.Windows.Forms.TextBox()
        Me.productIDInput = New System.Windows.Forms.TextBox()
        Me.batchNameInput = New System.Windows.Forms.TextBox()
        Me.productNameInput = New System.Windows.Forms.TextBox()
        Me.voucherNo = New System.Windows.Forms.TextBox()
        Me.labelcustomer = New System.Windows.Forms.Label()
        Me.partyIDInput = New System.Windows.Forms.TextBox()
        Me.partyNameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.recordID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productNameGot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.batchNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.batchName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.uom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.storeLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transporter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biltyNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.manualInvoiceNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnUnPost = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.remarksInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.balanceQTY = New System.Windows.Forms.TextBox()
        Me.totalQtyOutput = New System.Windows.Forms.TextBox()
        Me.detailBtn = New System.Windows.Forms.RadioButton()
        Me.masterBtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.availableQTY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(587, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 366
        Me.Label1.Text = "Status"
        '
        'statusInput
        '
        Me.statusInput.BackColor = System.Drawing.Color.White
        Me.statusInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.statusInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.statusInput.FormattingEnabled = True
        Me.statusInput.Items.AddRange(New Object() {"POSTED", "UN POSTED"})
        Me.statusInput.Location = New System.Drawing.Point(644, 63)
        Me.statusInput.Name = "statusInput"
        Me.statusInput.Size = New System.Drawing.Size(137, 25)
        Me.statusInput.TabIndex = 365
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(46, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 344
        Me.Label6.Text = "Store Name"
        '
        'warehouseInput
        '
        Me.warehouseInput.BackColor = System.Drawing.Color.White
        Me.warehouseInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.warehouseInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.warehouseInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warehouseInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.warehouseInput.FormattingEnabled = True
        Me.warehouseInput.Items.AddRange(New Object() {"Raw Material Store", "Consumables Store", "Main Warehouse"})
        Me.warehouseInput.Location = New System.Drawing.Point(140, 249)
        Me.warehouseInput.Name = "warehouseInput"
        Me.warehouseInput.Size = New System.Drawing.Size(360, 25)
        Me.warehouseInput.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(608, 662)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Total Quantity"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Panel1.Controls.Add(Me.partyCatInput)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(481, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 53)
        Me.Panel1.TabIndex = 364
        '
        'partyCatInput
        '
        Me.partyCatInput.BackColor = System.Drawing.Color.White
        Me.partyCatInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partyCatInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.partyCatInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partyCatInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.partyCatInput.FormattingEnabled = True
        Me.partyCatInput.Location = New System.Drawing.Point(0, 25)
        Me.partyCatInput.Name = "partyCatInput"
        Me.partyCatInput.Size = New System.Drawing.Size(300, 25)
        Me.partyCatInput.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 232
        Me.Label5.Text = "Party Type"
        '
        'dateInput
        '
        Me.dateInput.CustomFormat = "yyyy-MM-dd"
        Me.dateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateInput.Location = New System.Drawing.Point(274, 136)
        Me.dateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.dateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.dateInput.Name = "dateInput"
        Me.dateInput.Size = New System.Drawing.Size(200, 25)
        Me.dateInput.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 19)
        Me.Label17.TabIndex = 360
        Me.Label17.Text = "Manual Invoice #"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(276, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 19)
        Me.Label16.TabIndex = 359
        Me.Label16.Text = "Transporter"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(295, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 358
        Me.Label15.Text = "Bilty No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(521, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 19)
        Me.Label10.TabIndex = 362
        Me.Label10.Text = "Balance Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(65, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 361
        Me.Label12.Text = "Quantity"
        '
        'manualInvoiceInput
        '
        Me.manualInvoiceInput.BackColor = System.Drawing.Color.White
        Me.manualInvoiceInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manualInvoiceInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.manualInvoiceInput.Location = New System.Drawing.Point(138, 373)
        Me.manualInvoiceInput.MaxLength = 50
        Me.manualInvoiceInput.Name = "manualInvoiceInput"
        Me.manualInvoiceInput.ReadOnly = True
        Me.manualInvoiceInput.Size = New System.Drawing.Size(130, 25)
        Me.manualInvoiceInput.TabIndex = 10
        '
        'transporterInput
        '
        Me.transporterInput.BackColor = System.Drawing.Color.White
        Me.transporterInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transporterInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.transporterInput.Location = New System.Drawing.Point(370, 373)
        Me.transporterInput.MaxLength = 50
        Me.transporterInput.Name = "transporterInput"
        Me.transporterInput.ReadOnly = True
        Me.transporterInput.Size = New System.Drawing.Size(412, 25)
        Me.transporterInput.TabIndex = 11
        '
        'biltyNoInput
        '
        Me.biltyNoInput.BackColor = System.Drawing.Color.White
        Me.biltyNoInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biltyNoInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.biltyNoInput.Location = New System.Drawing.Point(370, 342)
        Me.biltyNoInput.MaxLength = 50
        Me.biltyNoInput.Name = "biltyNoInput"
        Me.biltyNoInput.ReadOnly = True
        Me.biltyNoInput.Size = New System.Drawing.Size(130, 25)
        Me.biltyNoInput.TabIndex = 9
        '
        'qtyInput
        '
        Me.qtyInput.BackColor = System.Drawing.Color.White
        Me.qtyInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.qtyInput.Location = New System.Drawing.Point(138, 342)
        Me.qtyInput.MaxLength = 50
        Me.qtyInput.Name = "qtyInput"
        Me.qtyInput.ReadOnly = True
        Me.qtyInput.Size = New System.Drawing.Size(130, 25)
        Me.qtyInput.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(74, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 357
        Me.Label9.Text = "Batch #"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(74, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 356
        Me.Label8.Text = "Product"
        '
        'batchCodeInput
        '
        Me.batchCodeInput.BackColor = System.Drawing.Color.White
        Me.batchCodeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchCodeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.batchCodeInput.Location = New System.Drawing.Point(140, 311)
        Me.batchCodeInput.MaxLength = 50
        Me.batchCodeInput.Name = "batchCodeInput"
        Me.batchCodeInput.ReadOnly = True
        Me.batchCodeInput.Size = New System.Drawing.Size(128, 25)
        Me.batchCodeInput.TabIndex = 7
        '
        'productIDInput
        '
        Me.productIDInput.BackColor = System.Drawing.Color.White
        Me.productIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productIDInput.Location = New System.Drawing.Point(140, 280)
        Me.productIDInput.MaxLength = 50
        Me.productIDInput.Name = "productIDInput"
        Me.productIDInput.ReadOnly = True
        Me.productIDInput.Size = New System.Drawing.Size(128, 25)
        Me.productIDInput.TabIndex = 6
        '
        'batchNameInput
        '
        Me.batchNameInput.BackColor = System.Drawing.Color.LightGray
        Me.batchNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.batchNameInput.Location = New System.Drawing.Point(274, 311)
        Me.batchNameInput.MaxLength = 250
        Me.batchNameInput.Name = "batchNameInput"
        Me.batchNameInput.ReadOnly = True
        Me.batchNameInput.Size = New System.Drawing.Size(226, 25)
        Me.batchNameInput.TabIndex = 354
        '
        'productNameInput
        '
        Me.productNameInput.BackColor = System.Drawing.Color.LightGray
        Me.productNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productNameInput.Location = New System.Drawing.Point(274, 280)
        Me.productNameInput.MaxLength = 250
        Me.productNameInput.Name = "productNameInput"
        Me.productNameInput.ReadOnly = True
        Me.productNameInput.Size = New System.Drawing.Size(508, 25)
        Me.productNameInput.TabIndex = 355
        '
        'voucherNo
        '
        Me.voucherNo.BackColor = System.Drawing.Color.LightGray
        Me.voucherNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.voucherNo.Location = New System.Drawing.Point(140, 136)
        Me.voucherNo.MaxLength = 9
        Me.voucherNo.Name = "voucherNo"
        Me.voucherNo.ReadOnly = True
        Me.voucherNo.Size = New System.Drawing.Size(130, 25)
        Me.voucherNo.TabIndex = 0
        '
        'labelcustomer
        '
        Me.labelcustomer.AutoSize = True
        Me.labelcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.labelcustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcustomer.ForeColor = System.Drawing.Color.White
        Me.labelcustomer.Location = New System.Drawing.Point(70, 170)
        Me.labelcustomer.Name = "labelcustomer"
        Me.labelcustomer.Size = New System.Drawing.Size(64, 19)
        Me.labelcustomer.TabIndex = 353
        Me.labelcustomer.Text = "Supplier"
        '
        'partyIDInput
        '
        Me.partyIDInput.BackColor = System.Drawing.Color.White
        Me.partyIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partyIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.partyIDInput.Location = New System.Drawing.Point(140, 167)
        Me.partyIDInput.MaxLength = 50
        Me.partyIDInput.Name = "partyIDInput"
        Me.partyIDInput.ReadOnly = True
        Me.partyIDInput.Size = New System.Drawing.Size(130, 25)
        Me.partyIDInput.TabIndex = 3
        '
        'partyNameInput
        '
        Me.partyNameInput.BackColor = System.Drawing.Color.LightGray
        Me.partyNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partyNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.partyNameInput.Location = New System.Drawing.Point(274, 167)
        Me.partyNameInput.MaxLength = 250
        Me.partyNameInput.Name = "partyNameInput"
        Me.partyNameInput.ReadOnly = True
        Me.partyNameInput.Size = New System.Drawing.Size(507, 25)
        Me.partyNameInput.TabIndex = 352
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 346
        Me.Label2.Text = "Voucher No."
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.recordID, Me.productID, Me.productNameGot, Me.batchNo, Me.batchName, Me.uom, Me.storeLocation, Me.qty, Me.transporter, Me.biltyNo, Me.manualInvoiceNo})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(12, 417)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(810, 237)
        Me.ListView1.TabIndex = 341
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'recordID
        '
        Me.recordID.Text = "recordID"
        Me.recordID.Width = 0
        '
        'productID
        '
        Me.productID.Text = "Product ID"
        Me.productID.Width = 0
        '
        'productNameGot
        '
        Me.productNameGot.Text = "Product Name"
        Me.productNameGot.Width = 300
        '
        'batchNo
        '
        Me.batchNo.Text = "Batch #"
        Me.batchNo.Width = 0
        '
        'batchName
        '
        Me.batchName.Text = "Batch Name"
        Me.batchName.Width = 100
        '
        'uom
        '
        Me.uom.Text = "UOM"
        Me.uom.Width = 100
        '
        'storeLocation
        '
        Me.storeLocation.Text = "Store"
        Me.storeLocation.Width = 200
        '
        'qty
        '
        Me.qty.Text = "Quantity"
        Me.qty.Width = 100
        '
        'transporter
        '
        Me.transporter.Text = "Transporter"
        Me.transporter.Width = 0
        '
        'biltyNo
        '
        Me.biltyNo.Text = "Bilty No"
        Me.biltyNo.Width = 0
        '
        'manualInvoiceNo
        '
        Me.manualInvoiceNo.Text = "Manual Invoice No"
        Me.manualInvoiceNo.Width = 0
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.ERP.My.Resources.Resources.close32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(734, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(47, 40)
        Me.btnExit.TabIndex = 337
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Image = Global.ERP.My.Resources.Resources.lock32
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(681, 17)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(47, 40)
        Me.btnPost.TabIndex = 336
        Me.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnUnPost
        '
        Me.btnUnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnPost.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnPost.Image = Global.ERP.My.Resources.Resources.unlock32
        Me.btnUnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnPost.Location = New System.Drawing.Point(628, 17)
        Me.btnUnPost.Name = "btnUnPost"
        Me.btnUnPost.Size = New System.Drawing.Size(47, 40)
        Me.btnUnPost.TabIndex = 335
        Me.btnUnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnPost.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Image = Global.ERP.My.Resources.Resources.find32
        Me.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFind.Location = New System.Drawing.Point(575, 17)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(47, 40)
        Me.btnFind.TabIndex = 334
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.ERP.My.Resources.Resources.print32
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(522, 17)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(47, 40)
        Me.btnPrint.TabIndex = 333
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Image = Global.ERP.My.Resources.Resources.last32
        Me.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLast.Location = New System.Drawing.Point(469, 17)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(47, 40)
        Me.btnLast.TabIndex = 332
        Me.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Image = Global.ERP.My.Resources.Resources.next32
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(416, 17)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(47, 40)
        Me.btnNext.TabIndex = 331
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Image = Global.ERP.My.Resources.Resources.previous32
        Me.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevious.Location = New System.Drawing.Point(363, 17)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(47, 40)
        Me.btnPrevious.TabIndex = 330
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Image = Global.ERP.My.Resources.Resources.first32
        Me.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst.Location = New System.Drawing.Point(310, 17)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(47, 40)
        Me.btnFirst.TabIndex = 329
        Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Image = Global.ERP.My.Resources.Resources.done32
        Me.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDone.Location = New System.Drawing.Point(257, 17)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(47, 40)
        Me.btnDone.TabIndex = 328
        Me.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ERP.My.Resources.Resources.save32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(151, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(47, 40)
        Me.btnSave.TabIndex = 327
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.ERP.My.Resources.Resources.edit32
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(98, 17)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(47, 40)
        Me.btnEdit.TabIndex = 326
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.ERP.My.Resources.Resources.trash32
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(204, 17)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(47, 40)
        Me.btnDelete.TabIndex = 325
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.ERP.My.Resources.Resources.new32
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(45, 17)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(47, 40)
        Me.btnNew.TabIndex = 324
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(62, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "Remarks"
        '
        'remarksInput
        '
        Me.remarksInput.BackColor = System.Drawing.Color.White
        Me.remarksInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.remarksInput.Location = New System.Drawing.Point(139, 198)
        Me.remarksInput.MaxLength = 250
        Me.remarksInput.Name = "remarksInput"
        Me.remarksInput.ReadOnly = True
        Me.remarksInput.Size = New System.Drawing.Size(642, 25)
        Me.remarksInput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(270, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "Date"
        '
        'balanceQTY
        '
        Me.balanceQTY.BackColor = System.Drawing.Color.LightGray
        Me.balanceQTY.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceQTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.balanceQTY.Location = New System.Drawing.Point(652, 342)
        Me.balanceQTY.MaxLength = 50
        Me.balanceQTY.Name = "balanceQTY"
        Me.balanceQTY.ReadOnly = True
        Me.balanceQTY.Size = New System.Drawing.Size(130, 25)
        Me.balanceQTY.TabIndex = 349
        '
        'totalQtyOutput
        '
        Me.totalQtyOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.totalQtyOutput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalQtyOutput.ForeColor = System.Drawing.Color.White
        Me.totalQtyOutput.Location = New System.Drawing.Point(719, 660)
        Me.totalQtyOutput.MaxLength = 50
        Me.totalQtyOutput.Name = "totalQtyOutput"
        Me.totalQtyOutput.ReadOnly = True
        Me.totalQtyOutput.Size = New System.Drawing.Size(100, 25)
        Me.totalQtyOutput.TabIndex = 350
        '
        'detailBtn
        '
        Me.detailBtn.AutoSize = True
        Me.detailBtn.BackColor = System.Drawing.SystemColors.Control
        Me.detailBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.detailBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailBtn.Location = New System.Drawing.Point(420, 65)
        Me.detailBtn.Name = "detailBtn"
        Me.detailBtn.Size = New System.Drawing.Size(64, 21)
        Me.detailBtn.TabIndex = 339
        Me.detailBtn.TabStop = True
        Me.detailBtn.Text = "Detail"
        Me.detailBtn.UseVisualStyleBackColor = False
        '
        'masterBtn
        '
        Me.masterBtn.AutoSize = True
        Me.masterBtn.BackColor = System.Drawing.SystemColors.Control
        Me.masterBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.masterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masterBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masterBtn.Location = New System.Drawing.Point(340, 65)
        Me.masterBtn.Name = "masterBtn"
        Me.masterBtn.Size = New System.Drawing.Size(73, 21)
        Me.masterBtn.TabIndex = 338
        Me.masterBtn.TabStop = True
        Me.masterBtn.Text = "Master"
        Me.masterBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 94)
        Me.PictureBox1.TabIndex = 342
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(0, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(835, 170)
        Me.PictureBox3.TabIndex = 351
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(835, 132)
        Me.PictureBox2.TabIndex = 345
        Me.PictureBox2.TabStop = False
        '
        'availableQTY
        '
        Me.availableQTY.BackColor = System.Drawing.Color.LightGray
        Me.availableQTY.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availableQTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.availableQTY.Location = New System.Drawing.Point(652, 311)
        Me.availableQTY.MaxLength = 50
        Me.availableQTY.Name = "availableQTY"
        Me.availableQTY.ReadOnly = True
        Me.availableQTY.Size = New System.Drawing.Size(130, 25)
        Me.availableQTY.TabIndex = 349
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(514, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 19)
        Me.Label11.TabIndex = 362
        Me.Label11.Text = "Available Quantity"
        '
        'grn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 688)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.statusInput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.warehouseInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dateInput)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.manualInvoiceInput)
        Me.Controls.Add(Me.transporterInput)
        Me.Controls.Add(Me.biltyNoInput)
        Me.Controls.Add(Me.qtyInput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.batchCodeInput)
        Me.Controls.Add(Me.productIDInput)
        Me.Controls.Add(Me.batchNameInput)
        Me.Controls.Add(Me.productNameInput)
        Me.Controls.Add(Me.voucherNo)
        Me.Controls.Add(Me.labelcustomer)
        Me.Controls.Add(Me.partyIDInput)
        Me.Controls.Add(Me.partyNameInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnUnPost)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.remarksInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.availableQTY)
        Me.Controls.Add(Me.balanceQTY)
        Me.Controls.Add(Me.totalQtyOutput)
        Me.Controls.Add(Me.detailBtn)
        Me.Controls.Add(Me.masterBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 726)
        Me.MinimumSize = New System.Drawing.Size(850, 726)
        Me.Name = "grn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Inward / GRN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents statusInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents warehouseInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents partyCatInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents manualInvoiceInput As System.Windows.Forms.TextBox
    Friend WithEvents transporterInput As System.Windows.Forms.TextBox
    Friend WithEvents biltyNoInput As System.Windows.Forms.TextBox
    Friend WithEvents qtyInput As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents batchCodeInput As System.Windows.Forms.TextBox
    Friend WithEvents productIDInput As System.Windows.Forms.TextBox
    Friend WithEvents batchNameInput As System.Windows.Forms.TextBox
    Friend WithEvents productNameInput As System.Windows.Forms.TextBox
    Friend WithEvents voucherNo As System.Windows.Forms.TextBox
    Friend WithEvents labelcustomer As System.Windows.Forms.Label
    Friend WithEvents partyIDInput As System.Windows.Forms.TextBox
    Friend WithEvents partyNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents productID As System.Windows.Forms.ColumnHeader
    Friend WithEvents productNameGot As System.Windows.Forms.ColumnHeader
    Friend WithEvents uom As System.Windows.Forms.ColumnHeader
    Friend WithEvents storeLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents transporter As System.Windows.Forms.ColumnHeader
    Friend WithEvents biltyNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents manualInvoiceNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents btnUnPost As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents remarksInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents balanceQTY As System.Windows.Forms.TextBox
    Friend WithEvents totalQtyOutput As System.Windows.Forms.TextBox
    Friend WithEvents detailBtn As System.Windows.Forms.RadioButton
    Friend WithEvents masterBtn As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents batchNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents availableQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents recordID As System.Windows.Forms.ColumnHeader
    Friend WithEvents batchName As System.Windows.Forms.ColumnHeader
End Class
