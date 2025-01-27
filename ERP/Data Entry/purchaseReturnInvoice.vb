'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlDataAdapter
'Imports System.Configuration
Public Class purchaseReturnInvoice
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
    'Dim findInput As Integer
    'Public Property userNameGot As String
    'Public Property fiscalYearIDGot As String
    'Public Property a219 As String
    'Public Property a220 As String
    'Public Property a221 As String
    'Public Property a222 As String
    'Public Property a223 As String
    'Dim masterVoucherID As Integer
    'Dim todaysDate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
    'Private Sub purchaseReturnInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    '        comm.Parameters.Add("@input3got", SqlDbType.VarChar).Value = "PRI"
    '        adapter = New SqlDataAdapter(comm)
    '        tableLoad = New DataTable()
    '        adapter.Fill(tableLoad)
    '        If tableLoad.Rows.Count() = 0 Then
    '            Exit Sub
    '        ElseIf tableLoad.Rows.Count() <> 0 Then
    '            masterVoucherID = tableLoad.Rows(position)(0).ToString()
    '            voucherNo.Text = tableLoad.Rows(position)(4).ToString()
    '            dateInput.Value = tableLoad.Rows(position)(5).ToString()
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
    '                comm = New SqlCommand("SELECT * FROM Stock WHERE DocNo = '" & voucherNo.Text & "' AND DocType = '" & "PRI" & "' AND FiscalYear = '" & fiscalYearIDGot & "' ORDER BY id ASC", conn)
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
    '                    listShowAll.SubItems.Add(reader(31).ToString)
    '                    listShowAll.SubItems.Add(reader(11).ToString)
    '                    listShowAll.SubItems.Add(reader(16).ToString)
    '                    listShowAll.SubItems.Add(reader(17).ToString)
    '                    listShowAll.SubItems.Add(reader(20).ToString)
    '                    listShowAll.SubItems.Add(reader(21).ToString)
    '                    listShowAll.SubItems.Add(Val(reader(17).ToString) + Val(reader(21).ToString))
    '                    Dim valueTotal As Decimal = 0
    '                    Dim gstTotal As Decimal = 0
    '                    Dim invoiceValueTotal As Decimal = 0
    '                    Dim dbTemp1 As Decimal = 0
    '                    For Each lvItem As ListViewItem In ListView1.Items
    '                        If Decimal.TryParse(lvItem.SubItems(6).Text, dbTemp1) Then
    '                            valueTotal += dbTemp1
    '                        End If
    '                    Next
    '                    Dim dbTemp2 As Decimal = 0
    '                    For Each lvItem As ListViewItem In ListView1.Items
    '                        If Decimal.TryParse(lvItem.SubItems(8).Text, dbTemp2) Then
    '                            gstTotal += dbTemp2
    '                        End If
    '                    Next
    '                    invoiceValueTotal = valueTotal - gstTotal
    '                    grossValueOutput.Text = (FormatNumber(valueTotal, 2, TriState.False, TriState.True, TriState.True))
    '                    totalGST.Text = (FormatNumber(gstTotal, 2, TriState.False, TriState.True, TriState.True))
    '                    totalInvoiceValue.Text = (FormatNumber(invoiceValueTotal, 2, TriState.False, TriState.True, TriState.True))
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
    'Private Sub statusInput_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles statusInput.SelectedIndexChanged
    '    If locked = "yes" Then
    '    Else
    '        Call resetMaster()
    '        voucherNo.Text = Nothing
    '        voucherStatusGot = statusInput.SelectedValue
    '        showData(index)
    '    End If
    'End Sub
    'Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
    '    If locked = "yes" Then
    '    Else
    '        Me.Close()
    '    End If
    'End Sub
    'Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
    '    If locked = "yes" Then

    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index = tableLoad.Rows.Count() - 1
    '            showData(index)
    '        End If
    '    End If
    'End Sub
    'Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
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
    'Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
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
    'Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
    '    If locked = "yes" Then
    '    Else
    '        If voucherLevel = "master" Then
    '            Call clearAll()
    '            index = 0
    '            showData(index)
    '        End If
    '    End If
    'End Sub

    'Public Sub resetMaster()
    '    If voucherLevel = "master" And locked = Nothing Then
    '        index = 0
    '        voucherNo.Text = Nothing
    '        partyCatInput.SelectedText = Nothing
    '        partyIDInput.Text = Nothing
    '        partyNameInput.Text = Nothing
    '        ListView1.Items.Clear()
    '        costValueOutput.Text = Nothing
    '        totalGST.Text = Nothing
    '        totalInvoiceValue.Text = Nothing
    '        Call clearAll()
    '    End If
    'End Sub

    'Private Sub clearAll()
    '    ListView1.Items.Clear()
    '    productIDInput.Text = Nothing
    '    productNameInput.Text = Nothing
    '    qtyInput.Text = Nothing
    '    rateInput.Text = Nothing
    '    valueInput.Text = Nothing
    '    percentGST.Text = Nothing
    '    valueGST.Text = Nothing
    '    valueAfterGST.Text = Nothing
    'End Sub

    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
    '    detailBtn.Checked = True
    'End Sub

    'Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
    '    If a219 = 1 Then
    '        statusInput.SelectedValue = "O"
    '        Call newPRILoadFunction()
    '    End If
    'End Sub

    'Private Sub newPRILoadFunction()
    '    searchPRN.parentFormGot = "pri"
    '    searchPRN.fiscalYearIDGot = fiscalYearIDGot
    '    searchPRN.userNameGot = userNameGot
    '    searchPRN.ShowDialog()
    'End Sub

    'Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
    '    Call editRecordFunction()
    'End Sub

    'Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
    '    Call editRecordFunction()
    'End Sub

    'Private Sub editRecordFunction()
    '    If a220 = 1 Then
    '        locked = "yes"
    '        If detailBtn.Checked = True And ListView1.SelectedItems.Count > 0 Then
    '            productIDInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
    '            productNameInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
    '            qtyInput.Text = ListView1.FocusedItem.SubItems.Item(4).Text
    '            rateInput.Text = ListView1.FocusedItem.SubItems.Item(5).Text
    '            valueInput.Text = ListView1.FocusedItem.SubItems.Item(6).Text
    '            percentGST.Text = ListView1.FocusedItem.SubItems.Item(7).Text
    '            valueGST.Text = ListView1.FocusedItem.SubItems.Item(8).Text
    '            valueAfterGST.Text = ListView1.FocusedItem.SubItems.Item(9).Text
    '            rateInput.ReadOnly = False
    '            percentGST.ReadOnly = False
    '            rateInput.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub btnPost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPost.Click
    '    If a222 = 1 Then
    '        If tableLoad.Rows.Count() <> 0 Then
    '            If locked = "yes" Then
    '            Else
    '                If statusInput.SelectedValue = "O" Then
    '                    Dim thisFlagVal As Integer = 0
    '                    Try
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        'Validation if this record has already been used in next step of production or not
    '                        Dim valcommand1 As New SqlCommand("SELECT * FROM Stock WHERE DocType = @input1got AND DocNo = @input2got AND CostPrice IS NULL", conn)
    '                        valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = "PRI"
    '                        valcommand1.Parameters.Add("@input2got", SqlDbType.Int).Value = voucherNo.Text
    '                        Dim valadapter1 As New SqlDataAdapter(valcommand1)
    '                        Dim logintable1 As New DataTable()
    '                        valadapter1.Fill(logintable1)
    '                        If logintable1.Rows.Count() <= 0 Then
    '                            thisFlagVal = 1
    '                        Else
    '                            thisFlagVal = 0
    '                        End If
    '                        conn.Close()
    '                    Catch ex As Exception
    '                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End Try
    '                    If thisFlagVal = 1 Then
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        Dim delresponse = MsgBox("Are you sure you want to Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Post Voucher")
    '                        If delresponse = MsgBoxResult.Yes Then
    '                            comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'C' WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            comm = New SqlCommand("UPDATE Stock SET Status = 'C', PostDate = '" & todaysDate & "', PostBy = '" & userNameGot & "' WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRI" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            MessageBox.Show("Voucher Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Call resetMaster()
    '                            index = 0
    '                            showData(index)
    '                        End If
    '                        conn.Close()
    '                    Else
    '                        MessageBox.Show("Please make sure, you have applied all the rates correctly!", "Entry Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End If
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
    '                    Dim thisFlagVal As Integer = 0
    '                    Try
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        'Validation if this record has already been used in next step of production or not
    '                        Dim valcommand1 As New SqlCommand("SELECT * FROM voucherMaster WHERE VRMasterID = @input1got AND lockStatus = @input2got", conn)
    '                        valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = masterVoucherID
    '                        valcommand1.Parameters.Add("@input2got", SqlDbType.Char).Value = "T"
    '                        Dim valadapter1 As New SqlDataAdapter(valcommand1)
    '                        Dim logintable1 As New DataTable()
    '                        valadapter1.Fill(logintable1)
    '                        If logintable1.Rows.Count() <= 0 Then
    '                            thisFlagVal = 1
    '                        Else
    '                            thisFlagVal = 0
    '                        End If
    '                        conn.Close()
    '                    Catch ex As Exception
    '                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End Try
    '                    If thisFlagVal = 1 Then
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        Dim delresponse = MsgBox("Are you sure you want to Un-Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Un Post Voucher")
    '                        If delresponse = MsgBoxResult.Yes Then
    '                            comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'O' WHERE VRMasterID = " & masterVoucherID & " ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            comm = New SqlCommand("UPDATE Stock SET Status = 'O', PostDate = '" & todaysDate & "', PostBy = '" & userNameGot & "' WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRI" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            MessageBox.Show("Voucher Un-Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Call resetMaster()
    '                            index = 0
    '                            showData(index)
    '                        End If
    '                        conn.Close()
    '                    Else
    '                        MessageBox.Show("This record has already been used either in Production or Sales Step!", "Entry Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
    '    If locked = "yes" Then
    '    Else
    '        findInput = InputBox("Enter Voucher No:", "Find Vouchers", , , )
    '        index = findInput - 1
    '        showData(index)
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
    '        masterBtn.Checked = True
    '        voucherLevel = "master"
    '        statusInput.Enabled = True
    '        rateInput.ReadOnly = True
    '        percentGST.ReadOnly = True
    '        Call resetMaster()
    '        Call clearAll()
    '        index = 0
    '        showData(index)
    '    Else

    '    End If
    'End Sub

    'Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
    '    If a221 = 1 Then
    '        If tableLoad.Rows.Count() <> 0 Then
    '            If locked = Nothing And statusInput.SelectedValue = "O" Then
    '                Dim thisFlagVal As Integer = 0
    '                Try
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    'Validation if this record has already been used in next step of production or not
    '                    Dim valcommand1 As New SqlCommand("SELECT * FROM voucherMaster WHERE VRMasterID = @input1got AND lockStatus = @input2got", conn)
    '                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = masterVoucherID
    '                    valcommand1.Parameters.Add("@input2got", SqlDbType.Char).Value = "T"
    '                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
    '                    Dim logintable1 As New DataTable()
    '                    valadapter1.Fill(logintable1)
    '                    If logintable1.Rows.Count() <= 0 Then
    '                        thisFlagVal = 1
    '                    Else
    '                        thisFlagVal = 0
    '                    End If
    '                    conn.Close()
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End Try
    '                If thisFlagVal = 1 Then
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    If masterBtn.Checked = True Then
    '                        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
    '                        If delresponse = MsgBoxResult.Yes Then
    '                            comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'C', VRType = '" & "PRN" & "'  WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            comm = New SqlCommand("UPDATE Stock SET DocType = '" & "PRN" & "', Status = 'C', EditDate = '" & todaysDate & "', EditBy = '" & userNameGot & "' WHERE DocNo = " & voucherNo.Text & " AND DocType = '" & "PRI" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                            affector = comm.ExecuteNonQuery
    '                            MessageBox.Show("Voucher Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Call resetMaster()
    '                            index = 0
    '                            showData(index)
    '                        End If
    '                    End If
    '                    conn.Close()
    '                Else
    '                    MessageBox.Show("This record has already been used either in Production or Sales Step!", "Entry Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
    '    If locked = "yes" Then
    '        If detailBtn.Checked = True And rateInput.Text <> Nothing And ListView1.SelectedItems.Count > 0 Then
    '            If tableLoad.Rows.Count() <> 0 Then
    '                Dim thisFlagVal As Integer = 0
    '                Try
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    'Validation if this record has already been used in next step of production or not
    '                    Dim valcommand1 As New SqlCommand("SELECT * FROM Stock WHERE thisID = @input1got", conn)
    '                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = ListView1.FocusedItem.SubItems.Item(0).Text
    '                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
    '                    Dim logintable1 As New DataTable()
    '                    valadapter1.Fill(logintable1)
    '                    If logintable1.Rows.Count() <= 0 Then
    '                        thisFlagVal = 1
    '                    Else
    '                        thisFlagVal = 0
    '                    End If
    '                    conn.Close()
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End Try
    '                If thisFlagVal = 1 Then
    '                    If rateInput.Text = 0 Or rateInput.Text < 0 Then
    '                        rateInput.Focus()
    '                    ElseIf percentGST.Text < 0 Then
    '                        percentGST.Focus()
    '                    ElseIf percentGST.Text = Nothing Then
    '                        percentGST.Text = 0
    '                        valueGST.Text = 0
    '                        valueAfterGST = valueInput
    '                    Else
    '                        conn = New SqlConnection(constr)
    '                        conn.Open()
    '                        comm = New SqlCommand("UPDATE Stock SET EditDate = '" & todaysDate & "', CostPrice = '" & rateInput.Text & "', CostValue = '" & valueInput.Text & "', SaleTaxRate = '" & percentGST.Text & "', SaleTaxValue = '" & valueGST.Text & "' , EditBy = '" & userNameGot & "' WHERE id = '" & ListView1.FocusedItem.SubItems.Item(0).Text & "' ", conn)
    '                        affector = comm.ExecuteNonQuery
    '                        conn.Close()
    '                        MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Call clearAll()
    '                        showData(index)
    '                    End If
    '                Else
    '                    MessageBox.Show("This record has already been used either in Production or Sales Step!", "Entry Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub rateInput_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles rateInput.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If rateInput.Text <> Nothing And rateInput.Text <> 0 Then
    '            percentGST.Focus()
    '            Call calAllValues()
    '        End If
    '    End If
    'End Sub

    'Private Sub rateInput_TextChanged(sender As Object, e As System.EventArgs) Handles rateInput.TextChanged
    '    Call calAllValues()
    'End Sub

    'Private Sub percentGST_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles percentGST.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If rateInput.Text = Nothing Or rateInput.Text = 0 Then
    '            rateInput.Focus()
    '        Else
    '            Call calAllValues()
    '            btnSave.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub percentGST_TextChanged(sender As Object, e As System.EventArgs) Handles percentGST.TextChanged
    '    Call calAllValues()
    'End Sub

    'Private Sub calAllValues()
    '    valueInput.Text = Val(qtyInput.Text) * Val(rateInput.Text)
    '    valueGST.Text = (Val(qtyInput.Text) * ((Val(percentGST.Text) * Val(rateInput.Text)) / 100))
    '    valueAfterGST.Text = Val(valueInput.Text) - Val(valueGST.Text)
    'End Sub

End Class