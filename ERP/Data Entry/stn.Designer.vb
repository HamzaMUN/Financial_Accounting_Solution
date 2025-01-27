<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stn))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.availableQTY = New System.Windows.Forms.TextBox()
        Me.balanceQTY = New System.Windows.Forms.TextBox()
        Me.totalQtyOutput = New System.Windows.Forms.TextBox()
        Me.detailBtn = New System.Windows.Forms.RadioButton()
        Me.masterBtn = New System.Windows.Forms.RadioButton()
        Me.dateInput = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.manualInvoiceInput = New System.Windows.Forms.TextBox()
        Me.statusInput = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.warehouseFromInput = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.transporterInput = New System.Windows.Forms.TextBox()
        Me.biltyNoInput = New System.Windows.Forms.TextBox()
        Me.qtyInput = New System.Windows.Forms.TextBox()
        Me.voucherNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.batchCodeInput = New System.Windows.Forms.TextBox()
        Me.batchNameInput = New System.Windows.Forms.TextBox()
        Me.storeLocationFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.productNameGot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.batchNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.uom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.storeLocationTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transporter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.biltyNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.manualInvoiceNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.productIDInput = New System.Windows.Forms.TextBox()
        Me.productNameInput = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.warehouseToInput = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.balanceToQty = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(587, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 473
        Me.Label1.Text = "Status"
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.ERP.My.Resources.Resources.close32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(734, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(47, 40)
        Me.btnExit.TabIndex = 443
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
        Me.btnPost.Location = New System.Drawing.Point(681, 18)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(47, 40)
        Me.btnPost.TabIndex = 442
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
        Me.btnUnPost.Location = New System.Drawing.Point(628, 18)
        Me.btnUnPost.Name = "btnUnPost"
        Me.btnUnPost.Size = New System.Drawing.Size(47, 40)
        Me.btnUnPost.TabIndex = 441
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
        Me.btnFind.Location = New System.Drawing.Point(575, 18)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(47, 40)
        Me.btnFind.TabIndex = 440
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
        Me.btnPrint.Location = New System.Drawing.Point(522, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(47, 40)
        Me.btnPrint.TabIndex = 439
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
        Me.btnLast.Location = New System.Drawing.Point(469, 18)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(47, 40)
        Me.btnLast.TabIndex = 438
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
        Me.btnNext.Location = New System.Drawing.Point(416, 18)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(47, 40)
        Me.btnNext.TabIndex = 437
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
        Me.btnPrevious.Location = New System.Drawing.Point(363, 18)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(47, 40)
        Me.btnPrevious.TabIndex = 436
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
        Me.btnFirst.Location = New System.Drawing.Point(310, 18)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(47, 40)
        Me.btnFirst.TabIndex = 435
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
        Me.btnDone.Location = New System.Drawing.Point(257, 18)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(47, 40)
        Me.btnDone.TabIndex = 434
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
        Me.btnSave.Location = New System.Drawing.Point(151, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(47, 40)
        Me.btnSave.TabIndex = 433
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
        Me.btnEdit.Location = New System.Drawing.Point(98, 18)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(47, 40)
        Me.btnEdit.TabIndex = 432
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
        Me.btnDelete.Location = New System.Drawing.Point(204, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(47, 40)
        Me.btnDelete.TabIndex = 431
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
        Me.btnNew.Location = New System.Drawing.Point(45, 18)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(47, 40)
        Me.btnNew.TabIndex = 430
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(476, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 454
        Me.Label4.Text = "Remarks"
        '
        'remarksInput
        '
        Me.remarksInput.BackColor = System.Drawing.Color.White
        Me.remarksInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.remarksInput.Location = New System.Drawing.Point(480, 137)
        Me.remarksInput.MaxLength = 250
        Me.remarksInput.Name = "remarksInput"
        Me.remarksInput.ReadOnly = True
        Me.remarksInput.Size = New System.Drawing.Size(301, 25)
        Me.remarksInput.TabIndex = 422
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(270, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 453
        Me.Label3.Text = "Date"
        '
        'availableQTY
        '
        Me.availableQTY.BackColor = System.Drawing.Color.LightGray
        Me.availableQTY.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availableQTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.availableQTY.Location = New System.Drawing.Point(651, 258)
        Me.availableQTY.MaxLength = 50
        Me.availableQTY.Name = "availableQTY"
        Me.availableQTY.ReadOnly = True
        Me.availableQTY.Size = New System.Drawing.Size(130, 25)
        Me.availableQTY.TabIndex = 455
        '
        'balanceQTY
        '
        Me.balanceQTY.BackColor = System.Drawing.Color.LightGray
        Me.balanceQTY.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceQTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.balanceQTY.Location = New System.Drawing.Point(651, 289)
        Me.balanceQTY.MaxLength = 50
        Me.balanceQTY.Name = "balanceQTY"
        Me.balanceQTY.ReadOnly = True
        Me.balanceQTY.Size = New System.Drawing.Size(130, 25)
        Me.balanceQTY.TabIndex = 456
        '
        'totalQtyOutput
        '
        Me.totalQtyOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.totalQtyOutput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalQtyOutput.ForeColor = System.Drawing.Color.White
        Me.totalQtyOutput.Location = New System.Drawing.Point(719, 661)
        Me.totalQtyOutput.MaxLength = 50
        Me.totalQtyOutput.Name = "totalQtyOutput"
        Me.totalQtyOutput.ReadOnly = True
        Me.totalQtyOutput.Size = New System.Drawing.Size(100, 25)
        Me.totalQtyOutput.TabIndex = 457
        '
        'detailBtn
        '
        Me.detailBtn.AutoSize = True
        Me.detailBtn.BackColor = System.Drawing.SystemColors.Control
        Me.detailBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.detailBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailBtn.Location = New System.Drawing.Point(420, 66)
        Me.detailBtn.Name = "detailBtn"
        Me.detailBtn.Size = New System.Drawing.Size(64, 21)
        Me.detailBtn.TabIndex = 445
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
        Me.masterBtn.Location = New System.Drawing.Point(340, 66)
        Me.masterBtn.Name = "masterBtn"
        Me.masterBtn.Size = New System.Drawing.Size(73, 21)
        Me.masterBtn.TabIndex = 444
        Me.masterBtn.TabStop = True
        Me.masterBtn.Text = "Master"
        Me.masterBtn.UseVisualStyleBackColor = False
        '
        'dateInput
        '
        Me.dateInput.CustomFormat = "yyyy-MM-dd"
        Me.dateInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateInput.Location = New System.Drawing.Point(274, 137)
        Me.dateInput.MaxDate = New Date(2099, 6, 30, 0, 0, 0, 0)
        Me.dateInput.MinDate = New Date(2001, 7, 1, 0, 0, 0, 0)
        Me.dateInput.Name = "dateInput"
        Me.dateInput.Size = New System.Drawing.Size(200, 25)
        Me.dateInput.TabIndex = 421
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(30, 323)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 19)
        Me.Label17.TabIndex = 467
        Me.Label17.Text = "Manual D.C #"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(277, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 19)
        Me.Label16.TabIndex = 466
        Me.Label16.Text = "Transporter"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(294, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 465
        Me.Label15.Text = "Bilty No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(513, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 19)
        Me.Label11.TabIndex = 470
        Me.Label11.Text = "Available Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(520, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 19)
        Me.Label10.TabIndex = 469
        Me.Label10.Text = "Balance Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(66, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 468
        Me.Label12.Text = "Quantity"
        '
        'manualInvoiceInput
        '
        Me.manualInvoiceInput.BackColor = System.Drawing.Color.White
        Me.manualInvoiceInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manualInvoiceInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.manualInvoiceInput.Location = New System.Drawing.Point(139, 320)
        Me.manualInvoiceInput.MaxLength = 50
        Me.manualInvoiceInput.Name = "manualInvoiceInput"
        Me.manualInvoiceInput.ReadOnly = True
        Me.manualInvoiceInput.Size = New System.Drawing.Size(130, 25)
        Me.manualInvoiceInput.TabIndex = 426
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
        Me.statusInput.Location = New System.Drawing.Point(644, 64)
        Me.statusInput.Name = "statusInput"
        Me.statusInput.Size = New System.Drawing.Size(137, 25)
        Me.statusInput.TabIndex = 472
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 19)
        Me.Label6.TabIndex = 450
        Me.Label6.Text = "Transfer From"
        '
        'warehouseFromInput
        '
        Me.warehouseFromInput.BackColor = System.Drawing.Color.White
        Me.warehouseFromInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.warehouseFromInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.warehouseFromInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warehouseFromInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.warehouseFromInput.FormattingEnabled = True
        Me.warehouseFromInput.Items.AddRange(New Object() {"Raw Material Store", "Consumables Store", "Main Warehouse"})
        Me.warehouseFromInput.Location = New System.Drawing.Point(139, 196)
        Me.warehouseFromInput.Name = "warehouseFromInput"
        Me.warehouseFromInput.Size = New System.Drawing.Size(360, 25)
        Me.warehouseFromInput.TabIndex = 446
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(608, 663)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 449
        Me.Label7.Text = "Total Quantity"
        '
        'transporterInput
        '
        Me.transporterInput.BackColor = System.Drawing.Color.White
        Me.transporterInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transporterInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.transporterInput.Location = New System.Drawing.Point(369, 320)
        Me.transporterInput.MaxLength = 50
        Me.transporterInput.Name = "transporterInput"
        Me.transporterInput.ReadOnly = True
        Me.transporterInput.Size = New System.Drawing.Size(412, 25)
        Me.transporterInput.TabIndex = 428
        '
        'biltyNoInput
        '
        Me.biltyNoInput.BackColor = System.Drawing.Color.White
        Me.biltyNoInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biltyNoInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.biltyNoInput.Location = New System.Drawing.Point(369, 289)
        Me.biltyNoInput.MaxLength = 50
        Me.biltyNoInput.Name = "biltyNoInput"
        Me.biltyNoInput.ReadOnly = True
        Me.biltyNoInput.Size = New System.Drawing.Size(130, 25)
        Me.biltyNoInput.TabIndex = 429
        '
        'qtyInput
        '
        Me.qtyInput.BackColor = System.Drawing.Color.White
        Me.qtyInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.qtyInput.Location = New System.Drawing.Point(139, 289)
        Me.qtyInput.MaxLength = 50
        Me.qtyInput.Name = "qtyInput"
        Me.qtyInput.ReadOnly = True
        Me.qtyInput.Size = New System.Drawing.Size(128, 25)
        Me.qtyInput.TabIndex = 427
        '
        'voucherNo
        '
        Me.voucherNo.BackColor = System.Drawing.Color.LightGray
        Me.voucherNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.voucherNo.Location = New System.Drawing.Point(140, 137)
        Me.voucherNo.MaxLength = 9
        Me.voucherNo.Name = "voucherNo"
        Me.voucherNo.ReadOnly = True
        Me.voucherNo.Size = New System.Drawing.Size(130, 25)
        Me.voucherNo.TabIndex = 471
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 452
        Me.Label2.Text = "Voucher No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(73, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 463
        Me.Label8.Text = "Product"
        '
        'batchCodeInput
        '
        Me.batchCodeInput.BackColor = System.Drawing.Color.White
        Me.batchCodeInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchCodeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.batchCodeInput.Location = New System.Drawing.Point(139, 258)
        Me.batchCodeInput.MaxLength = 50
        Me.batchCodeInput.Name = "batchCodeInput"
        Me.batchCodeInput.ReadOnly = True
        Me.batchCodeInput.Size = New System.Drawing.Size(128, 25)
        Me.batchCodeInput.TabIndex = 425
        '
        'batchNameInput
        '
        Me.batchNameInput.BackColor = System.Drawing.Color.LightGray
        Me.batchNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.batchNameInput.Location = New System.Drawing.Point(273, 258)
        Me.batchNameInput.MaxLength = 250
        Me.batchNameInput.Name = "batchNameInput"
        Me.batchNameInput.ReadOnly = True
        Me.batchNameInput.Size = New System.Drawing.Size(226, 25)
        Me.batchNameInput.TabIndex = 461
        '
        'storeLocationFrom
        '
        Me.storeLocationFrom.Text = "Store"
        Me.storeLocationFrom.Width = 150
        '
        'productID
        '
        Me.productID.Text = "Product ID"
        Me.productID.Width = 0
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.productID, Me.productNameGot, Me.batchNo, Me.uom, Me.storeLocationFrom, Me.storeLocationTo, Me.qty, Me.transporter, Me.biltyNo, Me.manualInvoiceNo})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(12, 391)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(810, 264)
        Me.ListView1.TabIndex = 447
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'productNameGot
        '
        Me.productNameGot.Text = "Product Name"
        Me.productNameGot.Width = 200
        '
        'batchNo
        '
        Me.batchNo.Text = "Batch #"
        Me.batchNo.Width = 100
        '
        'uom
        '
        Me.uom.Text = "UOM"
        Me.uom.Width = 100
        '
        'storeLocationTo
        '
        Me.storeLocationTo.Text = "Transfer To"
        Me.storeLocationTo.Width = 150
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(73, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 464
        Me.Label9.Text = "Batch #"
        '
        'productIDInput
        '
        Me.productIDInput.BackColor = System.Drawing.Color.White
        Me.productIDInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productIDInput.Location = New System.Drawing.Point(139, 227)
        Me.productIDInput.MaxLength = 50
        Me.productIDInput.Name = "productIDInput"
        Me.productIDInput.ReadOnly = True
        Me.productIDInput.Size = New System.Drawing.Size(128, 25)
        Me.productIDInput.TabIndex = 424
        '
        'productNameInput
        '
        Me.productNameInput.BackColor = System.Drawing.Color.LightGray
        Me.productNameInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.productNameInput.Location = New System.Drawing.Point(273, 227)
        Me.productNameInput.MaxLength = 250
        Me.productNameInput.Name = "productNameInput"
        Me.productNameInput.ReadOnly = True
        Me.productNameInput.Size = New System.Drawing.Size(508, 25)
        Me.productNameInput.TabIndex = 462
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 94)
        Me.PictureBox1.TabIndex = 448
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(835, 76)
        Me.PictureBox2.TabIndex = 451
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(0, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(835, 199)
        Me.PictureBox3.TabIndex = 458
        Me.PictureBox3.TabStop = False
        '
        'warehouseToInput
        '
        Me.warehouseToInput.BackColor = System.Drawing.Color.White
        Me.warehouseToInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.warehouseToInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.warehouseToInput.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warehouseToInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.warehouseToInput.FormattingEnabled = True
        Me.warehouseToInput.Items.AddRange(New Object() {"Raw Material Store", "Consumables Store", "Main Warehouse"})
        Me.warehouseToInput.Location = New System.Drawing.Point(139, 351)
        Me.warehouseToInput.Name = "warehouseToInput"
        Me.warehouseToInput.Size = New System.Drawing.Size(360, 25)
        Me.warehouseToInput.TabIndex = 446
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 450
        Me.Label5.Text = "Transfer To"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(520, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 19)
        Me.Label13.TabIndex = 469
        Me.Label13.Text = "Balance Quantity"
        '
        'balanceToQty
        '
        Me.balanceToQty.BackColor = System.Drawing.Color.LightGray
        Me.balanceToQty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceToQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.balanceToQty.Location = New System.Drawing.Point(651, 351)
        Me.balanceToQty.MaxLength = 50
        Me.balanceToQty.Name = "balanceToQty"
        Me.balanceToQty.ReadOnly = True
        Me.balanceToQty.Size = New System.Drawing.Size(130, 25)
        Me.balanceToQty.TabIndex = 456
        '
        'stn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 688)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.balanceToQty)
        Me.Controls.Add(Me.balanceQTY)
        Me.Controls.Add(Me.totalQtyOutput)
        Me.Controls.Add(Me.detailBtn)
        Me.Controls.Add(Me.masterBtn)
        Me.Controls.Add(Me.dateInput)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.manualInvoiceInput)
        Me.Controls.Add(Me.statusInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.warehouseToInput)
        Me.Controls.Add(Me.warehouseFromInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.transporterInput)
        Me.Controls.Add(Me.biltyNoInput)
        Me.Controls.Add(Me.qtyInput)
        Me.Controls.Add(Me.voucherNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.batchCodeInput)
        Me.Controls.Add(Me.batchNameInput)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.productIDInput)
        Me.Controls.Add(Me.productNameInput)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 726)
        Me.MinimumSize = New System.Drawing.Size(850, 726)
        Me.Name = "stn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Note"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents availableQTY As System.Windows.Forms.TextBox
    Friend WithEvents balanceQTY As System.Windows.Forms.TextBox
    Friend WithEvents totalQtyOutput As System.Windows.Forms.TextBox
    Friend WithEvents detailBtn As System.Windows.Forms.RadioButton
    Friend WithEvents masterBtn As System.Windows.Forms.RadioButton
    Friend WithEvents dateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents manualInvoiceInput As System.Windows.Forms.TextBox
    Friend WithEvents statusInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents warehouseFromInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents transporterInput As System.Windows.Forms.TextBox
    Friend WithEvents biltyNoInput As System.Windows.Forms.TextBox
    Friend WithEvents qtyInput As System.Windows.Forms.TextBox
    Friend WithEvents voucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents batchCodeInput As System.Windows.Forms.TextBox
    Friend WithEvents batchNameInput As System.Windows.Forms.TextBox
    Friend WithEvents storeLocationFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents productID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents productNameGot As System.Windows.Forms.ColumnHeader
    Friend WithEvents batchNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents uom As System.Windows.Forms.ColumnHeader
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents transporter As System.Windows.Forms.ColumnHeader
    Friend WithEvents biltyNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents manualInvoiceNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents productIDInput As System.Windows.Forms.TextBox
    Friend WithEvents productNameInput As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents warehouseToInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents balanceToQty As System.Windows.Forms.TextBox
    Friend WithEvents storeLocationTo As System.Windows.Forms.ColumnHeader
End Class
