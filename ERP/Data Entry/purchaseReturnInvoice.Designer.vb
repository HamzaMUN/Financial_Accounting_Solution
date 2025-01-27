<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseReturnInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchaseReturnInvoice))
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productNameGot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grossValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gstValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.recordID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gstRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statusInput = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.partyCatInput = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.valueAfterGST = New System.Windows.Forms.TextBox()
        Me.valueGST = New System.Windows.Forms.TextBox()
        Me.valueInput = New System.Windows.Forms.TextBox()
        Me.percentGST = New System.Windows.Forms.TextBox()
        Me.rateInput = New System.Windows.Forms.TextBox()
        Me.qtyInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.productIDInput = New System.Windows.Forms.TextBox()
        Me.productNameInput = New System.Windows.Forms.TextBox()
        Me.voucherNo = New System.Windows.Forms.TextBox()
        Me.labelcustomer = New System.Windows.Forms.Label()
        Me.partyIDInput = New System.Windows.Forms.TextBox()
        Me.partyNameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.storeLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnUnPost = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.grossValueOutput = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalInvoiceValue = New System.Windows.Forms.TextBox()
        Me.totalGST = New System.Windows.Forms.TextBox()
        Me.costValueOutput = New System.Windows.Forms.TextBox()
        Me.detailBtn = New System.Windows.Forms.RadioButton()
        Me.masterBtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qty
        '
        Me.qty.Text = "Quantity"
        Me.qty.Width = 100
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
        Me.Label1.TabIndex = 367
        Me.Label1.Text = "Status"
        '
        'productNameGot
        '
        Me.productNameGot.Text = "Product Name"
        Me.productNameGot.Width = 150
        '
        'rate
        '
        Me.rate.Text = "Rate"
        Me.rate.Width = 100
        '
        'productID
        '
        Me.productID.Text = "Product ID"
        Me.productID.Width = 0
        '
        'grossValue
        '
        Me.grossValue.Text = "Gross Value"
        Me.grossValue.Width = 100
        '
        'value
        '
        Me.value.Text = "Value"
        Me.value.Width = 100
        '
        'gstValue
        '
        Me.gstValue.Text = "GST (Value)"
        Me.gstValue.Width = 100
        '
        'recordID
        '
        Me.recordID.Text = "recordID"
        Me.recordID.Width = 0
        '
        'gstRate
        '
        Me.gstRate.Text = "gstRate"
        Me.gstRate.Width = 0
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
        Me.statusInput.TabIndex = 366
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(582, 661)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 19)
        Me.Label16.TabIndex = 344
        Me.Label16.Text = "Total Invoice Value"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(640, 631)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 19)
        Me.Label15.TabIndex = 345
        Me.Label15.Text = "Total GST"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(599, 599)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Total Cost Value"
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
        Me.Panel1.TabIndex = 365
        '
        'partyCatInput
        '
        Me.partyCatInput.BackColor = System.Drawing.Color.White
        Me.partyCatInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partyCatInput.Enabled = False
        Me.partyCatInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.partyCatInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partyCatInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.partyCatInput.FormattingEnabled = True
        Me.partyCatInput.Items.AddRange(New Object() {"Supplier", "LC Supplier"})
        Me.partyCatInput.Location = New System.Drawing.Point(0, 25)
        Me.partyCatInput.Name = "partyCatInput"
        Me.partyCatInput.Size = New System.Drawing.Size(300, 25)
        Me.partyCatInput.TabIndex = 229
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
        Me.dateInput.Enabled = False
        Me.dateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateInput.Location = New System.Drawing.Point(274, 136)
        Me.dateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.dateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.dateInput.Name = "dateInput"
        Me.dateInput.Size = New System.Drawing.Size(200, 25)
        Me.dateInput.TabIndex = 319
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(556, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 19)
        Me.Label10.TabIndex = 359
        Me.Label10.Text = "Gross Value"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(308, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 19)
        Me.Label9.TabIndex = 360
        Me.Label9.Text = "GST (Value)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(566, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 19)
        Me.Label11.TabIndex = 358
        Me.Label11.Text = "Cost Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 361
        Me.Label4.Text = "GST (%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(357, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 363
        Me.Label6.Text = "Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(66, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 362
        Me.Label12.Text = "Quantity"
        '
        'valueAfterGST
        '
        Me.valueAfterGST.BackColor = System.Drawing.Color.LightGray
        Me.valueAfterGST.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueAfterGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.valueAfterGST.Location = New System.Drawing.Point(652, 279)
        Me.valueAfterGST.MaxLength = 50
        Me.valueAfterGST.Name = "valueAfterGST"
        Me.valueAfterGST.ReadOnly = True
        Me.valueAfterGST.Size = New System.Drawing.Size(130, 25)
        Me.valueAfterGST.TabIndex = 322
        '
        'valueGST
        '
        Me.valueGST.BackColor = System.Drawing.Color.LightGray
        Me.valueGST.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.valueGST.Location = New System.Drawing.Point(404, 279)
        Me.valueGST.MaxLength = 50
        Me.valueGST.Name = "valueGST"
        Me.valueGST.ReadOnly = True
        Me.valueGST.Size = New System.Drawing.Size(130, 25)
        Me.valueGST.TabIndex = 325
        '
        'valueInput
        '
        Me.valueInput.BackColor = System.Drawing.Color.LightGray
        Me.valueInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.valueInput.Location = New System.Drawing.Point(652, 248)
        Me.valueInput.MaxLength = 50
        Me.valueInput.Name = "valueInput"
        Me.valueInput.ReadOnly = True
        Me.valueInput.Size = New System.Drawing.Size(130, 25)
        Me.valueInput.TabIndex = 323
        '
        'percentGST
        '
        Me.percentGST.BackColor = System.Drawing.Color.White
        Me.percentGST.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.percentGST.Location = New System.Drawing.Point(138, 279)
        Me.percentGST.MaxLength = 50
        Me.percentGST.Name = "percentGST"
        Me.percentGST.ReadOnly = True
        Me.percentGST.Size = New System.Drawing.Size(130, 25)
        Me.percentGST.TabIndex = 318
        '
        'rateInput
        '
        Me.rateInput.BackColor = System.Drawing.Color.White
        Me.rateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.rateInput.Location = New System.Drawing.Point(404, 248)
        Me.rateInput.MaxLength = 50
        Me.rateInput.Name = "rateInput"
        Me.rateInput.ReadOnly = True
        Me.rateInput.Size = New System.Drawing.Size(130, 25)
        Me.rateInput.TabIndex = 317
        '
        'qtyInput
        '
        Me.qtyInput.BackColor = System.Drawing.Color.LightGray
        Me.qtyInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.qtyInput.Location = New System.Drawing.Point(138, 248)
        Me.qtyInput.MaxLength = 50
        Me.qtyInput.Name = "qtyInput"
        Me.qtyInput.ReadOnly = True
        Me.qtyInput.Size = New System.Drawing.Size(130, 25)
        Me.qtyInput.TabIndex = 324
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(73, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 357
        Me.Label8.Text = "Product"
        '
        'productIDInput
        '
        Me.productIDInput.BackColor = System.Drawing.Color.LightGray
        Me.productIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productIDInput.Location = New System.Drawing.Point(138, 217)
        Me.productIDInput.MaxLength = 50
        Me.productIDInput.Name = "productIDInput"
        Me.productIDInput.ReadOnly = True
        Me.productIDInput.Size = New System.Drawing.Size(130, 25)
        Me.productIDInput.TabIndex = 321
        '
        'productNameInput
        '
        Me.productNameInput.BackColor = System.Drawing.Color.LightGray
        Me.productNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productNameInput.Location = New System.Drawing.Point(274, 217)
        Me.productNameInput.MaxLength = 250
        Me.productNameInput.Name = "productNameInput"
        Me.productNameInput.ReadOnly = True
        Me.productNameInput.Size = New System.Drawing.Size(508, 25)
        Me.productNameInput.TabIndex = 356
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
        Me.voucherNo.TabIndex = 364
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
        Me.labelcustomer.TabIndex = 355
        Me.labelcustomer.Text = "Supplier"
        '
        'partyIDInput
        '
        Me.partyIDInput.BackColor = System.Drawing.Color.LightGray
        Me.partyIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partyIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.partyIDInput.Location = New System.Drawing.Point(140, 167)
        Me.partyIDInput.MaxLength = 50
        Me.partyIDInput.Name = "partyIDInput"
        Me.partyIDInput.ReadOnly = True
        Me.partyIDInput.Size = New System.Drawing.Size(130, 25)
        Me.partyIDInput.TabIndex = 320
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
        Me.partyNameInput.TabIndex = 354
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
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Voucher No."
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.recordID, Me.productID, Me.productNameGot, Me.storeLocation, Me.qty, Me.rate, Me.value, Me.gstRate, Me.gstValue, Me.grossValue})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(12, 324)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(810, 263)
        Me.ListView1.TabIndex = 341
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'storeLocation
        '
        Me.storeLocation.Text = "Store"
        Me.storeLocation.Width = 150
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
        Me.btnExit.TabIndex = 338
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
        Me.btnPost.TabIndex = 337
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
        Me.btnUnPost.TabIndex = 336
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
        Me.btnFind.TabIndex = 335
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
        Me.btnPrint.TabIndex = 334
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
        Me.btnLast.TabIndex = 333
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
        Me.btnNext.TabIndex = 332
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
        Me.btnPrevious.TabIndex = 331
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
        Me.btnFirst.TabIndex = 330
        Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'grossValueOutput
        '
        Me.grossValueOutput.BackColor = System.Drawing.Color.LightGray
        Me.grossValueOutput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossValueOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.grossValueOutput.Location = New System.Drawing.Point(722, 597)
        Me.grossValueOutput.MaxLength = 50
        Me.grossValueOutput.Name = "grossValueOutput"
        Me.grossValueOutput.ReadOnly = True
        Me.grossValueOutput.Size = New System.Drawing.Size(100, 25)
        Me.grossValueOutput.TabIndex = 350
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
        Me.btnDone.TabIndex = 329
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
        Me.btnSave.TabIndex = 328
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
        Me.btnEdit.TabIndex = 327
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
        Me.btnDelete.TabIndex = 326
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
        Me.btnNew.TabIndex = 316
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "Date"
        '
        'totalInvoiceValue
        '
        Me.totalInvoiceValue.BackColor = System.Drawing.Color.LightGray
        Me.totalInvoiceValue.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalInvoiceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.totalInvoiceValue.Location = New System.Drawing.Point(722, 659)
        Me.totalInvoiceValue.MaxLength = 50
        Me.totalInvoiceValue.Name = "totalInvoiceValue"
        Me.totalInvoiceValue.ReadOnly = True
        Me.totalInvoiceValue.Size = New System.Drawing.Size(100, 25)
        Me.totalInvoiceValue.TabIndex = 349
        '
        'totalGST
        '
        Me.totalGST.BackColor = System.Drawing.Color.LightGray
        Me.totalGST.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalGST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.totalGST.Location = New System.Drawing.Point(722, 628)
        Me.totalGST.MaxLength = 50
        Me.totalGST.Name = "totalGST"
        Me.totalGST.ReadOnly = True
        Me.totalGST.Size = New System.Drawing.Size(100, 25)
        Me.totalGST.TabIndex = 352
        '
        'costValueOutput
        '
        Me.costValueOutput.BackColor = System.Drawing.Color.LightGray
        Me.costValueOutput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costValueOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.costValueOutput.Location = New System.Drawing.Point(722, 597)
        Me.costValueOutput.MaxLength = 50
        Me.costValueOutput.Name = "costValueOutput"
        Me.costValueOutput.ReadOnly = True
        Me.costValueOutput.Size = New System.Drawing.Size(100, 25)
        Me.costValueOutput.TabIndex = 351
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
        Me.detailBtn.TabIndex = 340
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
        Me.masterBtn.TabIndex = 339
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
        Me.PictureBox3.Location = New System.Drawing.Point(0, 209)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(835, 109)
        Me.PictureBox3.TabIndex = 353
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(835, 100)
        Me.PictureBox2.TabIndex = 346
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 593)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(835, 95)
        Me.Panel2.TabIndex = 368
        '
        'purchaseReturnInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 688)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.statusInput)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dateInput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.valueAfterGST)
        Me.Controls.Add(Me.valueGST)
        Me.Controls.Add(Me.valueInput)
        Me.Controls.Add(Me.percentGST)
        Me.Controls.Add(Me.rateInput)
        Me.Controls.Add(Me.qtyInput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.productIDInput)
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
        Me.Controls.Add(Me.grossValueOutput)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalInvoiceValue)
        Me.Controls.Add(Me.totalGST)
        Me.Controls.Add(Me.costValueOutput)
        Me.Controls.Add(Me.detailBtn)
        Me.Controls.Add(Me.masterBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 726)
        Me.MinimumSize = New System.Drawing.Size(850, 726)
        Me.Name = "purchaseReturnInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return Invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productNameGot As System.Windows.Forms.ColumnHeader
    Friend WithEvents rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents productID As System.Windows.Forms.ColumnHeader
    Friend WithEvents grossValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents value As System.Windows.Forms.ColumnHeader
    Friend WithEvents gstValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents recordID As System.Windows.Forms.ColumnHeader
    Friend WithEvents gstRate As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents partyCatInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents valueAfterGST As System.Windows.Forms.TextBox
    Friend WithEvents valueGST As System.Windows.Forms.TextBox
    Friend WithEvents valueInput As System.Windows.Forms.TextBox
    Friend WithEvents percentGST As System.Windows.Forms.TextBox
    Friend WithEvents rateInput As System.Windows.Forms.TextBox
    Friend WithEvents qtyInput As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents productIDInput As System.Windows.Forms.TextBox
    Friend WithEvents productNameInput As System.Windows.Forms.TextBox
    Friend WithEvents voucherNo As System.Windows.Forms.TextBox
    Friend WithEvents labelcustomer As System.Windows.Forms.Label
    Friend WithEvents partyIDInput As System.Windows.Forms.TextBox
    Friend WithEvents partyNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents storeLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents btnUnPost As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents grossValueOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalInvoiceValue As System.Windows.Forms.TextBox
    Friend WithEvents totalGST As System.Windows.Forms.TextBox
    Friend WithEvents costValueOutput As System.Windows.Forms.TextBox
    Friend WithEvents detailBtn As System.Windows.Forms.RadioButton
    Friend WithEvents masterBtn As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
