'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlDataAdapter
'Imports System.Configuration
Public Class storeOutward
    'Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    'Dim sqlconstr As SqlConnection = New SqlConnection
    'Dim conn As SqlConnection = New SqlConnection
    'Dim comm As SqlCommand = New SqlCommand
    'Dim comm2 As SqlCommand = New SqlCommand
    'Dim comm3 As SqlCommand = New SqlCommand
    'Dim adapter As New SqlDataAdapter
    'Dim table As New DataTable
    'Dim tableLoad As New DataTable
    'Dim affector As Integer
    'Dim affector2 As Integer
    'Dim reader As SqlDataReader
    'Dim listShowAll As ListViewItem
    'Dim voucherLevel As String
    'Dim todaysMonth As String = String.Format("{0:MM}", Date.Now)
    'Dim voucherMonthGot As String = todaysMonth
    'Dim voucherStatusGot As String = "O"
    'Dim locked As String
    'Dim index As Integer = 0
    'Dim position As Integer = 0
    'Dim saveType As String
    'Dim findInput As Integer
    'Public Property userNameGot As String
    'Public Property fiscalYearIDGot As String
    'Public Property remarksFocusGot As String
    'Public Property batchFocusGot As String
    'Public Property qtyFocusGot As String
    'Public Property a219 As String
    'Public Property a220 As String
    'Public Property a221 As String
    'Public Property a222 As String
    'Public Property a223 As String
    'Dim masterVoucherID As Integer
    'Dim todaysDate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
    'Private Sub storeOutward_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    '    Call loadDate()
    '    Try
    '        conn = New SqlConnection(constr)
    '        conn.Open()
    '        comm = New SqlCommand("SELECT * FROM voucherStatus", conn)
    '        adapter = New SqlDataAdapter(comm)
    '        table = New DataTable()
    '        adapter.Fill(table)
    '        statusInput.DisplayMember = "voucherStatusDisplay"
    '        statusInput.ValueMember = "voucherStatusValue"
    '        statusInput.DataSource = table
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    '    Try
    '        conn = New SqlConnection(constr)
    '        conn.Open()
    '        comm = New SqlCommand("SELECT * FROM subsidiaryCategory WHERE subsidiaryCatID = 2 OR subsidiaryCatID = 4", conn)
    '        adapter = New SqlDataAdapter(comm)
    '        table = New DataTable()
    '        adapter.Fill(table)
    '        partyCatInput.DisplayMember = "subsidiaryCatName"
    '        partyCatInput.ValueMember = "subsidiaryCatID"
    '        partyCatInput.DataSource = table
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    '    masterBtn.Checked = True
    '    If masterBtn.Checked = True Then
    '        voucherLevel = "master"
    '    ElseIf detailBtn.Checked = True Then
    '        voucherLevel = "detail"
    '    End If
    '    index = 0
    '    showData(index)
    'End Sub

    'Private Sub loadDate()
    '    Try
    '        conn = New SqlConnection(constr)
    '        conn.Open()
    '        comm = New SqlCommand("SELECT * FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "'", conn)
    '        reader = comm.ExecuteReader
    '        'clear list before loading records
    '        ListView1.Items.Clear()
    '        Do While reader.Read = True 'Loop to load data realtime
    '            dateInput.MinDate = (reader(2).ToString)
    '            dateInput.MaxDate = (reader(3).ToString)
    '        Loop
    '        reader.Close()
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Public Sub showData(ByVal position As Integer)
    '    Try
    '        conn = New SqlConnection(constr)
    '        conn.Open()
    '        comm = New SqlCommand("SELECT * FROM voucherMaster WHERE VRStatus = @input1got AND fiscalYear = @input2got AND VRType = @input3got ORDER BY VRMasterID DESC", conn)
    '        comm.Parameters.Add("@input1got", SqlDbType.VarChar).Value = voucherStatusGot
    '        comm.Parameters.Add("@input2got", SqlDbType.Int).Value = fiscalYearIDGot
    '        comm.Parameters.Add("@input3got", SqlDbType.VarChar).Value = "PRN"
    '        adapter = New SqlDataAdapter(comm)
    '        tableLoad = New DataTable()
    '        adapter.Fill(tableLoad)
    '        If tableLoad.Rows.Count() = 0 Then
    '            Exit Sub
    '        ElseIf tableLoad.Rows.Count() <> 0 Then
    '            masterVoucherID = tableLoad.Rows(position)(0).ToString()
    '            voucherNo.Text = tableLoad.Rows(position)(4).ToString()
    '            dateInput.Value = tableLoad.Rows(position)(5).ToString()
    '            remarksInput.Text = tableLoad.Rows(position)(13).ToString()
    '            partyCatInput.SelectedValue = tableLoad.Rows(position)(16).ToString()
    '            Dim partyCatIDGot As Integer = tableLoad.Rows(position)(16).ToString()
    '            partyIDInput.Text = tableLoad.Rows(position)(15).ToString()
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryCategoryID = @input1got AND subsidiaryLedgerID = @input2got ", conn)
    '                comm.Parameters.Add("@input1got", SqlDbType.Int).Value = partyCatIDGot
    '                comm.Parameters.Add("@input2got", SqlDbType.Int).Value = partyIDInput.Text
    '                reader = comm.ExecuteReader
    '                Do While reader.Read = True
    '                    partyNameInput.Text = reader(0).ToString
    '                Loop
    '                reader.Close()
    '                conn.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("SELECT * FROM Stock WHERE DocNo = '" & voucherNo.Text & "' AND DocType = '" & "PRN" & "' AND FiscalYear = '" & fiscalYearIDGot & "' ORDER BY id ASC", conn)
    '                reader = comm.ExecuteReader
    '                'clear list before loading records
    '                ListView1.Items.Clear()
    '                Do While reader.Read = True 'Loop to load data realtime
    '                    listShowAll = ListView1.Items.Add(reader(0).ToString)
    '                    listShowAll.SubItems.Add(reader(9).ToString)
    '                    Dim productIDGot1 As Integer = reader(9).ToString
    '                    Try
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        comm2 = New SqlCommand("SELECT productName FROM ProductDetail WHERE productID = '" & productIDGot1 & "' ", conn)
    '                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
    '                        Do While reader2.Read = True
    '                            listShowAll.SubItems.Add(reader2(0).ToString)
    '                        Loop
    '                        reader2.Close()
    '                        conn.Close()
    '                    Catch ex As Exception
    '                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End Try
    '                    Dim batchNoGot As Integer = reader(32).ToString 'Batch No
    '                    listShowAll.SubItems.Add(batchNoGot)
    '                    Try
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        comm2 = New SqlCommand("SELECT batchName FROM batch WHERE batchCode = '" & batchNoGot & "' ", conn)
    '                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
    '                        Do While reader2.Read = True
    '                            listShowAll.SubItems.Add(reader2(0).ToString) 'Batch Name
    '                        Loop
    '                        reader2.Close()
    '                        conn.Close()
    '                    Catch ex As Exception
    '                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End Try
    '                    Try
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        comm2 = New SqlCommand("SELECT productPacking FROM ProductDetail WHERE productID = '" & productIDGot1 & "' ", conn)
    '                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
    '                        Do While reader2.Read = True
    '                            listShowAll.SubItems.Add(reader2(0).ToString) 'UOM
    '                        Loop
    '                        reader2.Close()
    '                        conn.Close()
    '                    Catch ex As Exception
    '                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End Try
    '                    listShowAll.SubItems.Add(reader(31).ToString)
    '                    listShowAll.SubItems.Add(reader(11).ToString)
    '                    listShowAll.SubItems.Add(reader(29).ToString)
    '                    listShowAll.SubItems.Add(reader(28).ToString)
    '                    listShowAll.SubItems.Add(reader(30).ToString)
    '                    listShowAll.SubItems.Add(reader(38).ToString)
    '                    Dim qtyTotal As Decimal = 0
    '                    Dim dbTemp As Decimal = 0
    '                    For Each lvItem As ListViewItem In ListView1.Items
    '                        If Decimal.TryParse(lvItem.SubItems(7).Text, dbTemp) Then
    '                            qtyTotal += dbTemp
    '                        End If
    '                    Next
    '                    totalQtyOutput.Text = (FormatNumber(qtyTotal, 2, TriState.False, TriState.True, TriState.True))
    '                Loop
    '                conn.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '        Else
    '            Call resetMaster()
    '        End If
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub masterBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles masterBtn.CheckedChanged
    '    If masterBtn.Checked = True Then
    '        voucherLevel = "master"
    '    ElseIf detailBtn.Checked = True Then
    '        voucherLevel = "detail"
    '    End If
    'End Sub
    'Private Sub detailBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles detailBtn.CheckedChanged
    '    If masterBtn.Checked = True Then
    '        voucherLevel = "master"
    '    ElseIf detailBtn.Checked = True Then
    '        voucherLevel = "detail"
    '    End If
    'End Sub
    'Private Sub statusInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles statusInput.SelectedIndexChanged
    '    If locked = "yes" Then
    '    Else
    '        Call resetMaster()
    '        voucherNo.Text = Nothing
    '        remarksInput.Text = Nothing
    '        voucherStatusGot = statusInput.SelectedValue
    '        showData(index)
    '    End If
    'End Sub
    'Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
    '    If locked = "yes" Then
    '    Else
    '        Me.Close()
    '    End If
    'End Sub
    'Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
    '    If locked = "yes" Then

    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index = tableLoad.Rows.Count() - 1
    '            showData(index)
    '        End If
    '    End If
    'End Sub
    'Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
    '    If locked = "yes" Then
    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index -= 1
    '            If index < 0 Then
    '                index = 0
    '            End If
    '            showData(index)
    '        End If
    '    End If
    'End Sub
    'Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
    '    If locked = "yes" Then
    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index += 1
    '            If index > tableLoad.Rows.Count() - 1 Then
    '                index = tableLoad.Rows.Count() - 1
    '            End If
    '            showData(index)
    '        End If
    '    End If
    'End Sub
    'Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
    '    If locked = "yes" Then
    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index = 0
    '            showData(index)
    '        End If
    '    End If
    'End Sub

    'Private Sub resetMaster()
    '    If voucherLevel = "master" And locked = Nothing Then
    '        index = 0
    '        voucherNo.Text = Nothing
    '        remarksInput.Text = Nothing
    '        partyCatInput.SelectedText = Nothing
    '        partyIDInput.Text = Nothing
    '        partyNameInput.Text = Nothing
    '        ListView1.Items.Clear()
    '        totalQtyOutput.Text = Nothing
    '        clearAll()
    '    End If
    'End Sub

    'Private Sub clearAll()
    '    ListView1.Items.Clear()
    '    warehouseInput.SelectedText = Nothing
    '    productIDInput.Text = Nothing
    '    remarksFocusGot = Nothing
    '    productNameInput.Text = Nothing
    '    batchCodeInput.Text = Nothing
    '    batchNameInput.Text = Nothing
    '    availableQTY.Text = Nothing
    '    qtyInput.Text = Nothing
    '    biltyNoInput.Text = Nothing
    '    balanceQTY.Text = Nothing
    '    manualInvoiceInput.Text = Nothing
    '    transporterInput.Text = Nothing
    '    totalQtyOutput.Text = Nothing
    '    remarksFocusGot = Nothing
    '    batchFocusGot = Nothing
    '    qtyFocusGot = Nothing
    'End Sub
    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
    '    detailBtn.Checked = True
    'End Sub
    'Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
    '    If a219 = 1 Then
    '        locked = "yes"
    '        statusInput.Enabled = False
    '        saveType = "new"
    '        statusInput.SelectedValue = "O"
    '        If masterBtn.Checked = True Then
    '            Call clearAll()
    '            voucherNo.Text = Nothing
    '            partyIDInput.Text = Nothing
    '            partyNameInput.Text = Nothing
    '            remarksInput.Text = Nothing
    '            partyIDInput.ReadOnly = False
    '            dateInput.Focus()
    '        ElseIf detailBtn.Checked = True Then
    '            partyCatInput.Enabled = False
    '            dateInput.Enabled = False
    '            productIDInput.ReadOnly = False
    '            warehouseInput.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
    '    If a220 = 1 Then
    '        locked = "yes"
    '        saveType = "update"
    '        If masterBtn.Checked = True Then
    '            dateInput.Focus()
    '            statusInput.Enabled = False
    '            partyCatInput.Enabled = False
    '            partyIDInput.ReadOnly = False
    '        ElseIf detailBtn.Checked = True And ListView1.SelectedItems.Count > 0 Then
    '            warehouseInput.SelectedItem = ListView1.FocusedItem.SubItems.Item(6).Text
    '            statusInput.Enabled = False
    '            partyCatInput.Enabled = False
    '            dateInput.Enabled = False
    '            productIDInput.ReadOnly = False
    '            productIDInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
    '            productNameInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
    '            batchCodeInput.ReadOnly = False
    '            batchCodeInput.Text = ListView1.FocusedItem.SubItems.Item(3).Text
    '            batchNameInput.Text = ListView1.FocusedItem.SubItems.Item(4).Text
    '            qtyInput.ReadOnly = False
    '            qtyInput.Text = ListView1.FocusedItem.SubItems.Item(7).Text
    '            biltyNoInput.ReadOnly = False
    '            biltyNoInput.Text = ListView1.FocusedItem.SubItems.Item(9).Text
    '            manualInvoiceInput.ReadOnly = False
    '            manualInvoiceInput.Text = ListView1.FocusedItem.SubItems.Item(10).Text
    '            transporterInput.ReadOnly = False
    '            transporterInput.Text = ListView1.FocusedItem.SubItems.Item(8).Text
    '            productIDInput.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub dateInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If partyIDInput.ReadOnly = False Then
    '            partyCatInput.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub partyIDInput_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles partyIDInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If remarksFocusGot = "yes" Then
    '            remarksInput.Focus()
    '        Else
    '            If partyIDInput.ReadOnly = False Then
    '                Call searchQ1()
    '                remarksFocusGot = Nothing
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub productIDInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles productIDInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If batchFocusGot = "yes" Then
    '            batchCodeInput.Focus()
    '            batchFocusGot = Nothing
    '            batchCodeInput.ReadOnly = False
    '            Call loadAvailableQuantity()
    '        Else
    '            If productIDInput.ReadOnly = False Then
    '                Call searchQ2()
    '                batchFocusGot = Nothing
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub batchCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles batchCodeInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If qtyFocusGot = "yes" Then
    '            qtyInput.Focus()
    '            qtyFocusGot = Nothing
    '            Call loadAvailableQuantity()
    '        Else
    '            If productIDInput.ReadOnly = False Then
    '                Call searchQ3()
    '                qtyFocusGot = Nothing
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub qtyInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles qtyInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If qtyInput.Text <> Nothing And qtyInput.Text > 0 Then
    '            Call loadBalanceQuantity()
    '            biltyNoInput.ReadOnly = False
    '            biltyNoInput.Focus()
    '        Else
    '            qtyInput.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub biltyNoInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles biltyNoInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        manualInvoiceInput.ReadOnly = False
    '        manualInvoiceInput.Focus()
    '    End If
    'End Sub

    'Private Sub manualInvoiceInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles manualInvoiceInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        transporterInput.ReadOnly = False
    '        transporterInput.Focus()
    '    End If
    'End Sub

    'Private Sub transporterInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles transporterInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If transporterInput.ReadOnly = False And locked = "yes" Then
    '            Call saveNewDetail()
    '        End If
    '    End If
    'End Sub

    'Private Sub searchQ1()
    '    If partyCatInput.SelectedValue = 2 Then
    '        searchSupplier.searchKeywordGot = partyIDInput.Text
    '        searchSupplier.parentFormGot = "prn"
    '        searchSupplier.Show()
    '    ElseIf partyCatInput.SelectedValue = 4 Then
    '        searchLCSupplier.searchKeywordGot = partyIDInput.Text
    '        searchLCSupplier.parentFormGot = "prn"
    '        searchLCSupplier.Show()
    '    End If
    'End Sub
    'Private Sub searchQ2()
    '    searchProduct.searchKeywordGot = productIDInput.Text
    '    searchProduct.parentFormGot = "prn"
    '    searchProduct.Show()
    'End Sub
    'Private Sub searchQ3()
    '    If productIDInput.Text = Nothing Then
    '        productIDInput.Focus()
    '    Else
    '        searchBatch.searchKeywordGot = batchCodeInput.Text
    '        searchBatch.parentFormGot = "prn"
    '        searchBatch.productIDGot = productIDInput.Text
    '        searchBatch.Show()
    '    End If
    'End Sub

    'Public Sub loadAvailableQuantity()
    '    availableQTY.Text = 0
    '    If productIDInput.Text <> Nothing Then
    '        Try
    '            conn = New SqlConnection(constr)
    '            conn.Open()
    '            Dim valcommand1 As New SqlCommand("SELECT * FROM Stock WHERE ProductID = '" & productIDInput.Text & "' AND consumedFlag = '" & "F" & "' ", conn)
    '            Dim valadapter1 As New SqlDataAdapter(valcommand1)
    '            Dim valtable1 As New DataTable()
    '            valadapter1.Fill(valtable1)
    '            If valtable1.Rows.Count() > 0 Then
    '                comm = New SqlCommand("SELECT SUM(balanceQty) as AvailableQTYSum FROM Stock WHERE ProductID = '" & productIDInput.Text & "' AND consumedFlag = '" & "F" & "' ", conn)
    '                reader = comm.ExecuteReader
    '                Do While reader.Read = True
    '                    availableQTY.Text = (reader(0))
    '                Loop
    '                reader.Close()
    '            End If
    '            conn.Close()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End Try
    '    End If
    'End Sub

    'Private Sub loadBalanceQuantity()
    '    balanceQTY.Text = Val(availableQTY.Text) + Val(qtyInput.Text)
    'End Sub

    'Private Sub btnPost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPost.Click
    '    If a222 = 1 Then
    '        If tableLoad.Rows.Count() <> 0 Then
    '            If locked = "yes" Then
    '            Else
    '                If statusInput.SelectedValue = "O" Then
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    Dim delresponse = MsgBox("Are you sure you want to Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Post Voucher")
    '                    If delresponse = MsgBoxResult.Yes Then
    '                        comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'C' WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        comm = New SqlCommand("UPDATE Stock SET Status = 'C', PostDate = '" & todaysDate & "', PostBy = '" & userNameGot & "' WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRN" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        MessageBox.Show("Voucher Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Call resetMaster()
    '                        index = 0
    '                        showData(index)
    '                    End If
    '                    conn.Close()
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub btnUnPost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnPost.Click
    '    If a223 = 1 Then
    '        If tableLoad.Rows.Count() <> 0 Then
    '            If locked = "yes" Then

    '            Else
    '                If statusInput.SelectedValue = "C" Then
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    Dim delresponse = MsgBox("Are you sure you want to Un-Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Un Post Voucher")
    '                    If delresponse = MsgBoxResult.Yes Then
    '                        comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'O' WHERE VRMasterID = " & masterVoucherID & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        comm = New SqlCommand("UPDATE Stock SET Status = 'O', PostDate = '" & todaysDate & "', PostBy = '" & userNameGot & "' WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRN" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        MessageBox.Show("Voucher Un-Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Call resetMaster()
    '                        index = 0
    '                        showData(index)
    '                    End If
    '                    conn.Close()
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
    '    If locked = "yes" Then
    '    Else
    '        'findInput = InputBox("Enter Voucher No:", "Find Vouchers", , , )
    '        'index = findInput - 1
    '        'showData(index)
    '    End If
    'End Sub

    'Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
    '    If locked = "yes" Then
    '    Else
    '        'jvPrint.userNameGot = userNameGot
    '        'jvPrint.fiscalYearIDGot = fiscalYearIDGot
    '        'jvPrint.VoucherIDGot = masterVoucherID
    '        'jvPrint.Show()
    '    End If
    'End Sub

    'Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click
    '    If locked = "yes" Then
    '        locked = Nothing
    '        statusInput.Enabled = True
    '        partyCatInput.Enabled = True
    '        dateInput.Enabled = True
    '        partyIDInput.ReadOnly = True
    '        remarksInput.ReadOnly = True
    '        remarksInput.ReadOnly = True
    '        productIDInput.ReadOnly = True
    '        batchCodeInput.ReadOnly = True
    '        qtyInput.ReadOnly = True
    '        biltyNoInput.ReadOnly = True
    '        manualInvoiceInput.ReadOnly = True
    '        transporterInput.ReadOnly = True
    '        Call resetMaster()
    '        Call clearAll()
    '        index = 0
    '        showData(index)
    '    Else

    '    End If
    'End Sub

    'Private Sub remarksInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles remarksInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If remarksInput.ReadOnly = False And saveType = "new" And masterBtn.Checked = True And locked = "yes" Then
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("SELECT TOP 1 VRNo FROM voucherMaster WHERE VRType = @input1got OR VRType = @input2got AND fiscalYear = @input3got ORDER BY VRNo DESC", conn)
    '                comm.Parameters.Add("@input1got", SqlDbType.VarChar).Value = "PRN"
    '                comm.Parameters.Add("@input2got", SqlDbType.VarChar).Value = "PRV"
    '                comm.Parameters.Add("@input3got", SqlDbType.Int).Value = fiscalYearIDGot
    '                reader = comm.ExecuteReader
    '                Dim voucherNoGot As Integer = 0
    '                Do While reader.Read = True 'Loop to load data realtime
    '                    voucherNoGot = (reader(0).ToString)
    '                Loop
    '                conn.Close()
    '                voucherNo.Text = voucherNoGot + 1
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("INSERT INTO voucherMaster(VRType, VRNo, VRDate, VRPostDate, VRStatus, userName, fiscalYear, VRMonth, VRRemarks, PartyID, PartyCatID) VALUES ('" & "PRN" & "', " & voucherNo.Text & "  , '" & dateInput.Text & "'  , '" & todaysDate & "'  , '" & "O" & "'  , '" & userNameGot & "'  , " & fiscalYearIDGot & "  , '" & todaysMonth & "'  , '" & remarksInput.Text & "', '" & partyIDInput.Text & "', '" & partyCatInput.SelectedValue & "' )", conn)
    '                affector = comm.ExecuteNonQuery
    '                partyCatInput.Enabled = False
    '                dateInput.Enabled = False
    '                productIDInput.ReadOnly = False
    '                warehouseInput.Focus()
    '                Call clearAll()
    '                conn.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '        End If
    '    End If
    'End Sub

    'Private Sub saveNewDetail()
    '    If transporterInput.ReadOnly = False And saveType = "new" And locked = "yes" And qtyInput.Text <> Nothing Then
    '        If warehouseInput.SelectedItem = Nothing Then
    '            warehouseInput.Focus()
    '        ElseIf productIDInput.Text = Nothing Then
    '            productIDInput.Focus()
    '        ElseIf batchCodeInput.Text = Nothing Then
    '            batchCodeInput.Focus()
    '        ElseIf qtyInput.Text = Nothing Or qtyInput.Text = 0 Or qtyInput.Text < 0 Then
    '            qtyInput.Focus()
    '        Else
    '            Dim productCatIDGot As Integer = 0
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("SELECT productCatID FROM ProductDetail WHERE productID = " & productIDInput.Text & " ", conn)
    '                reader = comm.ExecuteReader
    '                Do While reader.Read = True
    '                    productCatIDGot = reader(0).ToString
    '                Loop
    '                reader.Close()
    '                conn.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("INSERT INTO Stock(DocType, DocNo, DocDate, TransDate, PartyID, PartyCatID, ProductID, ProductCatID, Quantity, Status, userName, FiscalYear, FiscalMonth, BiltyNo, Transporter, ManualDocID, StoreLocation, BatchID, consumedFlag, consumedQty, balanceQty) VALUES ( '" & "PRN" & "', '" & voucherNo.Text & "' , '" & dateInput.Text & "' , '" & todaysDate & "' , '" & partyIDInput.Text & "' , '" & partyCatInput.SelectedValue & "' , '" & productIDInput.Text & "' , '" & productCatIDGot & "' , '" & qtyInput.Text & "' , '" & "O" & "' , '" & userNameGot & "' , '" & fiscalYearIDGot & "' , '" & todaysMonth & "' , '" & biltyNoInput.Text & "' , '" & transporterInput.Text & "' , '" & manualInvoiceInput.Text & "' , '" & warehouseInput.SelectedItem & "' , '" & batchCodeInput.Text & "', '" & "F" & "', '" & 0 & "', '" & qtyInput.Text & "' )", conn)
    '                affector = comm.ExecuteNonQuery
    '                conn.Close()
    '                Call clearAll()
    '                productIDInput.ReadOnly = False
    '                productIDInput.Focus()
    '                showData(index)
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '        End If
    '    End If
    'End Sub

    'Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
    '    If a221 = 1 Then
    '        If tableLoad.Rows.Count() <> 0 Then
    '            If locked = Nothing And statusInput.SelectedValue = "O" Then
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                If masterBtn.Checked = True Then
    '                    Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
    '                    If delresponse = MsgBoxResult.Yes Then
    '                        comm = New SqlCommand("DELETE FROM Stock WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRN" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        comm = New SqlCommand("DELETE FROM voucherMaster WHERE VRNo = " & voucherNo.Text & " AND VRType = '" & "PRN" & "' AND VRStatus = '" & "O" & "' AND fiscalYear = " & fiscalYearIDGot & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        MessageBox.Show("Voucher Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Call resetMaster()
    '                        index = 0
    '                        showData(index)
    '                    End If
    '                ElseIf detailBtn.Checked = True And ListView1.SelectedItems.Count > 0 Then
    '                    Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
    '                    If delresponse = MsgBoxResult.Yes Then
    '                        comm = New SqlCommand("DELETE FROM Stock WHERE id = '" & ListView1.FocusedItem.SubItems.Item(0).Text & "' AND DocNo = " & voucherNo.Text & " AND DocType = '" & "PRN" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        MessageBox.Show("Record Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        showData(index)
    '                    End If
    '                End If
    '                conn.Close()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
    '    If locked = "yes" And saveType = "update" Then
    '        If masterBtn.Checked = True Then
    '            conn = New SqlConnection(constr)
    '            conn.Open()
    '            comm = New SqlCommand("UPDATE voucherMaster SET VRDate = '" & dateInput.Text & "', VREditDate = '" & todaysDate & "', VRRemarks = '" & remarksInput.Text & "', PartyID = " & partyIDInput.Text & ", PartyCatID = " & partyCatInput.SelectedValue & " WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
    '            affector = comm.ExecuteNonQuery
    '            conn.Close()
    '            MessageBox.Show("Voucher has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            showData(index)
    '        ElseIf detailBtn.Checked = True And productIDInput.Text <> Nothing And batchCodeInput.Text <> Nothing And qtyInput.Text <> Nothing And ListView1.SelectedItems.Count > 0 Then
    '            conn.Open()
    '            If tableLoad.Rows.Count() <> 0 Then
    '                If qtyInput.Text = 0 Or qtyInput.Text < 0 Then
    '                    qtyInput.Focus()
    '                Else
    '                    Dim productCatIDGot As Integer = 0
    '                    comm = New SqlCommand("SELECT productCatID FROM ProductDetail WHERE productID = " & productIDInput.Text & " ", conn)
    '                    reader = comm.ExecuteReader
    '                    Do While reader.Read = True
    '                        productCatIDGot = reader(0).ToString
    '                    Loop
    '                    reader.Close()
    '                    Dim costPriceGot As Decimal = 0
    '                    Dim salesTaxRateGot As Decimal = 0
    '                    Dim costValueCalc As Decimal = 0
    '                    Dim salesTaxValue As Decimal = 0
    '                    comm = New SqlCommand("SELECT * FROM Stock WHERE id = '" & ListView1.FocusedItem.SubItems.Item(0).Text & "' ", conn)
    '                    reader = comm.ExecuteReader
    '                    Do While reader.Read = True
    '                        costPriceGot = reader(16).ToString
    '                        salesTaxRateGot = reader(20).ToString
    '                    Loop
    '                    reader.Close()
    '                    costValueCalc = costPriceGot * Val(qtyInput.Text)
    '                    salesTaxValue = ((costValueCalc * salesTaxRateGot) / 100)
    '                    comm = New SqlCommand("UPDATE Stock SET EditDate = '" & todaysDate & "', ProductID = '" & productIDInput.Text & "', ProductCatID = '" & productCatIDGot & "', Quantity = '" & qtyInput.Text & "', CostValue = '" & costValueCalc & "', SaleTaxValue = '" & salesTaxValue & "', BiltyNo = '" & biltyNoInput.Text & "', Transporter = '" & transporterInput.Text & "' , ManualDocID = '" & manualInvoiceInput.Text & "', StoreLocation = '" & warehouseInput.SelectedItem & "', BatchID = '" & batchCodeInput.Text & "', EditBy = '" & userNameGot & "', consumedFlag = '" & "F" & "', consumedQty = '" & 0 & "', balanceQty = '" & qtyInput.Text & "' WHERE id = '" & ListView1.FocusedItem.SubItems.Item(0).Text & "' ", conn)
    '                    affector = comm.ExecuteNonQuery
    '                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    showData(index)
    '                End If
    '            End If
    '            conn.Close()
    '        End If
    '    End If
    'End Sub

    'Private Sub qtyInput_TextChanged(sender As Object, e As System.EventArgs) Handles qtyInput.TextChanged
    '    Call loadBalanceQuantity()
    'End Sub

End Class