Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class bpv
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim comm3 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim tableLoad As New DataTable
    Dim affector As Integer
    Dim affector2 As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim voucherLevel As String
    Dim todaysMonth As String = String.Format("{0:MM}", Date.Now)
    Dim voucherMonthGot As String = todaysMonth
    Dim voucherStatusGot As String = "O"
    Dim locked As String
    Dim index As Integer = 0
    Dim position As Integer = 0
    Dim saveType As String
    Public Property userNameGot As String
    Public Property fiscalYearIDGot As String
    Public Property VRCustomerGot As String
    Public Property VRSupplierGot As String
    Public Property VREmployeeGot As String
    Public Property VRLCSupplierGot As String
    Public Property VRCostCentreGot As String
    Public Property narrationFocusGot As String
    Public Property customerValGot As String
    Public Property supplierValGot As String
    Public Property employeeValGot As String
    Public Property lcSupplierValGot As String
    Public Property costCentreValGot As String
    Public Property a219 As String
    Public Property a220 As String
    Public Property a221 As String
    Public Property a222 As String
    Public Property a223 As String
    Dim masterVoucherID As Integer
    Dim fiscalYearStartDateGot, fiscalYearEndDateGot As Date
    Dim todaysDate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
    Private Sub bpv_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call loadDate()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM months", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            monthInput.DisplayMember = "monthName"
            monthInput.ValueMember = "monthID"
            monthInput.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM voucherStatus", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            statusInput.DisplayMember = "voucherStatusDisplay"
            statusInput.ValueMember = "voucherStatusValue"
            statusInput.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        monthInput.SelectedValue = todaysMonth
        masterBtn.Checked = True
        If masterBtn.Checked = True Then
            voucherLevel = "master"
        ElseIf detailBtn.Checked = True Then
            voucherLevel = "detail"
        End If
        index = 0
        showData(index)
    End Sub

    Private Sub loadDate()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                dateInput.MinDate = (reader(2).ToString)
                fiscalYearStartDateGot = (reader(2).ToString)
                dateInput.MaxDate = (reader(3).ToString)
                fiscalYearEndDateGot = (reader(3).ToString)
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub showData(ByVal position As Integer)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM voucherMaster WHERE VRStatus = @input1got AND fiscalYear = @input2got AND VRMonth = @input3got AND VRType = @input4got ORDER BY VRMasterID DESC", conn)
            comm.Parameters.Add("@input1got", SqlDbType.VarChar).Value = voucherStatusGot
            comm.Parameters.Add("@input2got", SqlDbType.Int).Value = fiscalYearIDGot
            comm.Parameters.Add("@input3got", SqlDbType.VarChar).Value = voucherMonthGot
            comm.Parameters.Add("@input4got", SqlDbType.VarChar).Value = "BPV"
            adapter = New SqlDataAdapter(comm)
            tableLoad = New DataTable()
            adapter.Fill(tableLoad)
            If tableLoad.Rows.Count() = 0 Then
                Exit Sub
            ElseIf tableLoad.Rows.Count() <> 0 Then
                masterVoucherID = tableLoad.Rows(position)(0).ToString()
                voucherNo.Text = tableLoad.Rows(position)(4).ToString()
                dateInput.Value = tableLoad.Rows(position)(5).ToString()
                remarksInput.Text = tableLoad.Rows(position)(13).ToString()
                chequeInput.Text = tableLoad.Rows(position)(14).ToString()
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM voucherDetails WHERE VRNo = '" & voucherNo.Text & "' AND VRType = '" & "BPV" & "' AND fiscalYear = '" & fiscalYearIDGot & "' AND VRMonth = '" & voucherMonthGot & "' ORDER BY voucherDetailID ASC", conn)
                    reader = comm.ExecuteReader
                    'clear list before loading records
                    ListView1.Items.Clear()
                    Do While reader.Read = True 'Loop to load data realtime
                        listShowAll = ListView1.Items.Add(reader(8).ToString)
                        listShowAll.SubItems.Add(reader(11).ToString)
                        listShowAll.SubItems.Add(reader(9).ToString)
                        listShowAll.SubItems.Add(reader(10).ToString)
                        listShowAll.SubItems.Add(reader(0).ToString)
                        listShowAll.SubItems.Add(reader(16).ToString)
                        listShowAll.SubItems.Add(reader(17).ToString)
                        listShowAll.SubItems.Add(reader(18).ToString)
                        listShowAll.SubItems.Add(reader(19).ToString)
                        listShowAll.SubItems.Add(reader(20).ToString)
                        Dim dbTotal As Decimal = 0
                        Dim dbTemp As Decimal
                        For Each lvItem As ListViewItem In ListView1.Items
                            If Decimal.TryParse(lvItem.SubItems(2).Text, dbTemp) Then
                                dbTotal += dbTemp
                            End If
                        Next
                        Dim crTotal As Decimal = 0
                        Dim crTemp As Decimal
                        For Each lvItem As ListViewItem In ListView1.Items
                            If Decimal.TryParse(lvItem.SubItems(3).Text, crTemp) Then
                                crTotal += crTemp
                            End If
                        Next
                        debitOutput.Text = (FormatNumber(dbTotal, 2, TriState.False, TriState.True, TriState.True))
                        creditOutput.Text = (FormatNumber(crTotal, 2, TriState.False, TriState.True, TriState.True))
                        Dim diffGot As Decimal = 0
                        diffGot = dbTotal - crTotal
                        differenceOutput.Text = (FormatNumber(diffGot, 2, TriState.False, TriState.True, TriState.True))
                        If diffGot = 0 Then
                            differenceOutput.BackColor = Color.LimeGreen
                        ElseIf diffGot > 0 Or diffGot < 0 Then
                            differenceOutput.BackColor = Color.Maroon
                        End If
                    Loop
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                Call resetMaster()
            End If
            conn.Close()
            dateInput.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub masterBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles masterBtn.CheckedChanged
        If masterBtn.Checked = True Then
            voucherLevel = "master"
        ElseIf detailBtn.Checked = True Then
            voucherLevel = "detail"
        End If
    End Sub
    Private Sub detailBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles detailBtn.CheckedChanged
        If masterBtn.Checked = True Then
            voucherLevel = "master"
        ElseIf detailBtn.Checked = True Then
            voucherLevel = "detail"
        End If
    End Sub
    Private Sub monthInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles monthInput.SelectedIndexChanged
        If locked = "yes" Then
        Else
            Call resetMaster()
            voucherNo.Text = Nothing
            remarksInput.Text = Nothing
            chequeInput.Text = Nothing
            voucherMonthGot = monthInput.SelectedValue
            showData(index)
        End If
    End Sub
    Private Sub statusInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles statusInput.SelectedIndexChanged
        If locked = "yes" Then
        Else
            Call resetMaster()
            voucherNo.Text = Nothing
            remarksInput.Text = Nothing
            chequeInput.Text = Nothing
            voucherStatusGot = statusInput.SelectedValue
            showData(index)
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        If locked = "yes" Then
        Else
            Me.Close()
        End If
    End Sub
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        If locked = "yes" Then

        Else
            If voucherLevel = "master" Then
                Call clearAll()
                index = tableLoad.Rows.Count() - 1
                showData(index)
            End If
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        If locked = "yes" Then
        Else
            If voucherLevel = "master" Then
                Call clearAll()
                index -= 1
                If index < 0 Then
                    index = 0
                End If
                showData(index)
            End If
        End If
    End Sub
    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        If locked = "yes" Then
        Else
            If voucherLevel = "master" Then
                Call clearAll()
                index += 1
                If index > tableLoad.Rows.Count() - 1 Then
                    index = tableLoad.Rows.Count() - 1
                End If
                showData(index)
            End If
        End If
    End Sub
    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        If locked = "yes" Then
        Else
            If voucherLevel = "master" Then
                Call clearAll()
                index = 0
                showData(index)
            End If
        End If
    End Sub
    Private Sub resetMaster()
        If voucherLevel = "master" And locked = Nothing Then
            index = 0
            voucherNo.Text = Nothing
            remarksInput.Text = Nothing
            ListView1.Items.Clear()
            differenceOutput.Text = Nothing
            debitOutput.Text = Nothing
            creditOutput.Text = Nothing
            Call clearAll()
        End If
    End Sub
    Private Sub clearAll()
        coaCodeInput.Text = Nothing
        coaNameInput.Text = Nothing
        narrationFocusGot = Nothing
        ListView1.Items.Clear()
        differenceOutput.Text = Nothing
        debitOutput.Text = Nothing
        creditOutput.Text = Nothing
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
        detailBtn.Checked = True
    End Sub
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        If a219 = 1 Then
            locked = "yes"
            monthInput.Enabled = False
            statusInput.Enabled = False
            saveType = "new"
            statusInput.SelectedValue = "O"
            If masterBtn.Checked = True Then
                dateInput.Enabled = True
                Call loadNewDateRange()
                Call clearAll()
                chequeInput.Text = Nothing
                voucherNo.Text = Nothing
                remarksInput.ReadOnly = False
                remarksInput.Text = Nothing
                dateInput.Focus()
            ElseIf detailBtn.Checked = True Then
                dateInput.Enabled = False
                coaCodeInput.ReadOnly = False
                coaCodeInput.Focus()
            End If
        End If
    End Sub

    Private Sub loadNewDateRange()
        dateInput.MinDate = fiscalYearStartDateGot
        dateInput.MaxDate = fiscalYearEndDateGot
        Dim monthValue As String = monthInput.SelectedValue
        Dim yearValueGot As String = ""
        If monthValue > fiscalYearEndDateGot.Month Then
            yearValueGot = fiscalYearStartDateGot.Year
        Else
            yearValueGot = fiscalYearEndDateGot.Year
        End If
        'Setting up Minimum Date Value
        Dim minDateGot As Date = fiscalYearStartDateGot
        minDateGot = yearValueGot & "-" & monthValue & "-01"
        dateInput.MinDate = minDateGot
        'Setting up Maximum Date Value
        Dim maxDateGot As Date = fiscalYearEndDateGot
        Dim DaysInMonth As Integer = Date.DaysInMonth(yearValueGot, monthValue)
        maxDateGot = yearValueGot & "-" & monthValue & "-" & DaysInMonth
        dateInput.MaxDate = maxDateGot
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If a220 = 1 Then
            locked = "yes"
            monthInput.Enabled = False
            statusInput.Enabled = False
            saveType = "update"
            If masterBtn.Checked = True Then
                dateInput.Enabled = True
                dateInput.Focus()
                remarksInput.ReadOnly = False
                chequeInput.ReadOnly = False
            ElseIf detailBtn.Checked = True And ListView1.SelectedItems.Count > 0 Then
                dateInput.Enabled = False
                coaCodeInput.ReadOnly = False
                coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT L3controlAcName FROM L3controlAc WHERE L3controlAcID = '" & ListView1.FocusedItem.SubItems.Item(0).Text & "' ", conn)
                    reader = comm.ExecuteReader
                    Do While reader.Read = True 'Loop to load data realtime
                        coaNameInput.Text = (reader(0).ToString)
                    Loop
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                narrationInput.ReadOnly = False
                narrationInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                debitInput.ReadOnly = False
                debitInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
                creditInput.ReadOnly = False
                creditInput.Text = ListView1.FocusedItem.SubItems.Item(3).Text
                If ListView1.FocusedItem.SubItems.Item(5).Text <> 0 Then
                    customerCodeInput.Text = ListView1.FocusedItem.SubItems.Item(5).Text
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & ListView1.FocusedItem.SubItems.Item(5).Text & "' ", conn)
                        reader = comm.ExecuteReader
                        Do While reader.Read = True 'Loop to load data realtime
                            customerNameInput.Text = (reader(0).ToString)
                        Loop
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    customerCodeInput.ReadOnly = False
                    VRCustomerGot = "yes"
                    customerValGot = 1
                    customerCodeInput.Focus()
                End If
                If ListView1.FocusedItem.SubItems.Item(6).Text <> 0 Then
                    supplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(6).Text
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & ListView1.FocusedItem.SubItems.Item(6).Text & "' ", conn)
                        reader = comm.ExecuteReader
                        Do While reader.Read = True 'Loop to load data realtime
                            supplierNameInput.Text = (reader(0).ToString)
                        Loop
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    supplierCodeInput.ReadOnly = False
                    VRSupplierGot = "yes"
                    supplierValGot = 1
                    supplierCodeInput.Focus()
                End If
                If ListView1.FocusedItem.SubItems.Item(7).Text <> 0 Then
                    employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(7).Text
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & ListView1.FocusedItem.SubItems.Item(7).Text & "' ", conn)
                        reader = comm.ExecuteReader
                        Do While reader.Read = True 'Loop to load data realtime
                            employeeNameInput.Text = (reader(0).ToString)
                        Loop
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    employeeCodeInput.ReadOnly = False
                    VREmployeeGot = "yes"
                    employeeValGot = 1
                    employeeCodeInput.Focus()
                End If
                If ListView1.FocusedItem.SubItems.Item(8).Text <> 0 Then
                    lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(8).Text
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & ListView1.FocusedItem.SubItems.Item(8).Text & "' ", conn)
                        reader = comm.ExecuteReader
                        Do While reader.Read = True 'Loop to load data realtime
                            lcSupplierNameInput.Text = (reader(0).ToString)
                        Loop
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    lcSupplierCodeInput.ReadOnly = False
                    VRLCSupplierGot = "yes"
                    lcSupplierValGot = 1
                    lcSupplierCodeInput.Focus()
                End If
                If ListView1.FocusedItem.SubItems.Item(9).Text <> 0 Then
                    costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(9).Text
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & ListView1.FocusedItem.SubItems.Item(9).Text & "' ", conn)
                        reader = comm.ExecuteReader
                        Do While reader.Read = True 'Loop to load data realtime
                            costCentreNameInput.Text = (reader(0).ToString)
                        Loop
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    costCentreCodeInput.ReadOnly = False
                    VRCostCentreGot = "yes"
                    costCentreValGot = 1
                    costCentreCodeInput.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub dateInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If remarksInput.ReadOnly = False Then
                remarksInput.Focus()
            End If
        End If
    End Sub

    Private Sub coaCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles coaCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If narrationFocusGot = "yes" Then
                narrationInput.Focus()
                narrationFocusGot = Nothing
            ElseIf narrationFocusGot = "sub" Then
                customerCodeInput.Focus()
                narrationFocusGot = Nothing
            Else
                If coaCodeInput.ReadOnly = False Then
                    Call searchQ1()
                    narrationFocusGot = Nothing
                End If
            End If
        End If
    End Sub
    Private Sub customerCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles customerCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VRCustomerGot = "yes" Then
                narrationInput.ReadOnly = False
                narrationInput.Focus()
                VRCustomerGot = Nothing
            Else
                If customerValGot = 1 Then
                    Call searchQ2()
                End If
            End If
        End If
    End Sub
    Private Sub supplierCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles supplierCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VRSupplierGot = "yes" Then
                narrationInput.ReadOnly = False
                narrationInput.Focus()
                VRSupplierGot = Nothing
            Else
                If supplierValGot = 1 Then
                    Call searchQ3()
                End If
            End If
        End If
    End Sub
    Private Sub employeeCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles employeeCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VREmployeeGot = "yes" Then
                narrationInput.ReadOnly = False
                narrationInput.Focus()
                VREmployeeGot = Nothing
            Else
                If employeeValGot = 1 Then
                    Call searchQ4()
                End If
            End If
        End If
    End Sub
    Private Sub lcSupplierCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles lcSupplierCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VRLCSupplierGot = "yes" Then
                narrationInput.ReadOnly = False
                narrationInput.Focus()
                VRLCSupplierGot = Nothing
            Else
                If lcSupplierValGot = 1 Then
                    Call searchQ5()
                End If
            End If
        End If
    End Sub
    Private Sub costCentreCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles costCentreCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VRCostCentreGot = "yes" Then
                narrationInput.ReadOnly = False
                narrationInput.Focus()
                VRCostCentreGot = Nothing
            Else
                If costCentreValGot = 1 Then
                    Call searchQ6()
                End If
            End If
        End If
    End Sub
    Private Sub searchQ1()
        searchDialogL3.searchKeywordGot = coaCodeInput.Text
        searchDialogL3.parentFormGot = "bpv"
        searchDialogL3.Show()
    End Sub
    Private Sub searchQ2()
        searchCustomer.searchKeywordGot = customerCodeInput.Text
        searchCustomer.parentFormGot = "bpv"
        searchCustomer.supplierValGot = supplierValGot
        searchCustomer.employeeValGot = employeeValGot
        searchCustomer.lcSupplierValGot = lcSupplierValGot
        searchCustomer.costCentreValGot = costCentreValGot
        searchCustomer.Show()
    End Sub
    Private Sub searchQ3()
        searchSupplier.searchKeywordGot = supplierCodeInput.Text
        searchSupplier.parentFormGot = "bpv"
        searchSupplier.employeeValGot = employeeValGot
        searchSupplier.lcSupplierValGot = lcSupplierValGot
        searchSupplier.costCentreValGot = costCentreValGot
        searchSupplier.Show()
    End Sub
    Private Sub searchQ4()
        searchEmployee.searchKeywordGot = employeeCodeInput.Text
        searchEmployee.parentFormGot = "bpv"
        searchEmployee.lcSupplierValGot = lcSupplierValGot
        searchEmployee.costCentreValGot = costCentreValGot
        searchEmployee.Show()
    End Sub
    Private Sub searchQ5()
        searchLCSupplier.searchKeywordGot = lcSupplierCodeInput.Text
        searchLCSupplier.parentFormGot = "bpv"
        searchLCSupplier.costCentreValGot = costCentreValGot
        searchLCSupplier.Show()
    End Sub
    Private Sub searchQ6()
        searchCostCentre.searchKeywordGot = costCentreCodeInput.Text
        searchCostCentre.parentFormGot = "bpv"
        searchCostCentre.Show()
    End Sub
    Private Sub btnPost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPost.Click
        If a222 = 1 Then
            If tableLoad.Rows.Count() <> 0 Then
                If locked = "yes" Then
                Else
                    If statusInput.SelectedValue = "O" And Val(differenceOutput.Text) = 0 And differenceOutput.Text <> Nothing Then
                        conn = New SqlConnection(constr)
                        conn.Open()
                        Dim delresponse = MsgBox("Are you sure you want to Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Post Voucher")
                        If delresponse = MsgBoxResult.Yes Then
                            comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'C' WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            comm = New SqlCommand("UPDATE voucherDetails SET VRStatus = 'C', Postby = '" & userNameGot & "' WHERE VRNo = " & voucherNo.Text & " AND VRType = '" & "BPV" & "' AND fiscalYear = " & fiscalYearIDGot & " AND VRMonth = '" & voucherMonthGot & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            MessageBox.Show("Voucher Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            index = 0
                            voucherNo.Text = Nothing
                            remarksInput.Text = Nothing
                            chequeInput.Text = Nothing
                            ListView1.Items.Clear()
                            showData(index)
                        End If
                        conn.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnUnPost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnPost.Click
        If a223 = 1 Then
            If tableLoad.Rows.Count() <> 0 Then
                If locked = "yes" Then

                Else
                    If statusInput.SelectedValue = "C" Then
                        conn = New SqlConnection(constr)
                        conn.Open()
                        Dim delresponse = MsgBox("Are you sure you want to Un-Post this voucher?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Un Post Voucher")
                        If delresponse = MsgBoxResult.Yes Then
                            comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'O' WHERE VRMasterID = " & masterVoucherID & " ", conn)
                            affector = comm.ExecuteNonQuery
                            comm = New SqlCommand("UPDATE voucherDetails SET VRStatus = 'O', Postby = '" & userNameGot & "' WHERE VRNo = " & voucherNo.Text & " AND VRType = '" & "BPV" & "' AND fiscalYear = " & fiscalYearIDGot & " AND VRMonth = '" & voucherMonthGot & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            MessageBox.Show("Voucher Un-Posted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            index = 0
                            voucherNo.Text = Nothing
                            remarksInput.Text = Nothing
                            chequeInput.Text = Nothing
                            ListView1.Items.Clear()
                            showData(index)
                        End If
                        conn.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        If locked = "yes" Then
        Else
            Dim findInput As String = InputBox("Enter Voucher No:", "Find Vouchers", , , )
            If findInput <> "" Then
                Dim totalRecords As Integer = tableLoad.Rows.Count()
                If findInput <= totalRecords Then
                    index = totalRecords - findInput
                    showData(index)
                End If
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        If locked = "yes" Or voucherNo.Text = Nothing Then
        Else
            bpvPrint.bpvNoGot = voucherNo.Text
            bpvPrint.fiscalYearGot = fiscalYearIDGot
            bpvPrint.vrMonthGot = monthInput.SelectedValue
            bpvPrint.userNameGot = userNameGot
            bpvPrint.Show()
        End If
    End Sub

    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click
        If locked = "yes" Then
            locked = Nothing
            monthInput.Enabled = True
            statusInput.Enabled = True
            dateInput.Enabled = True
            Call loadDate()
            remarksInput.ReadOnly = True
            coaCodeInput.ReadOnly = True
            customerCodeInput.ReadOnly = True
            supplierCodeInput.ReadOnly = True
            employeeCodeInput.ReadOnly = True
            lcSupplierCodeInput.ReadOnly = True
            costCentreCodeInput.ReadOnly = True
            narrationInput.ReadOnly = True
            coaCodeInput.Text = Nothing
            coaNameInput.Text = Nothing
            customerCodeInput.Text = Nothing
            customerNameInput.Text = Nothing
            supplierCodeInput.Text = Nothing
            supplierNameInput.Text = Nothing
            employeeCodeInput.Text = Nothing
            employeeNameInput.Text = Nothing
            lcSupplierCodeInput.Text = Nothing
            lcSupplierNameInput.Text = Nothing
            costCentreCodeInput.Text = Nothing
            costCentreNameInput.Text = Nothing
            narrationInput.Text = Nothing
            debitInput.ReadOnly = True
            creditInput.ReadOnly = True
            debitInput.Text = Nothing
            creditInput.Text = Nothing
            index = 0
            Call resetMaster()
            showData(index)
        Else

        End If
    End Sub

    Private Sub remarksInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles remarksInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If remarksInput.ReadOnly = False And saveType = "new" And masterBtn.Checked = True And locked = "yes" Then
                chequeInput.ReadOnly = False
                chequeInput.Focus()
            End If
        End If
    End Sub
    Private Sub chequeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles chequeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chequeInput.ReadOnly = False And saveType = "new" And masterBtn.Checked = True And locked = "yes" Then
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT TOP 1 VRNo FROM voucherMaster WHERE fiscalYear = @input2got AND VRMonth = @input3got AND VRType = @input4got ORDER BY VRNo DESC", conn)
                    comm.Parameters.Add("@input2got", SqlDbType.Int).Value = fiscalYearIDGot
                    comm.Parameters.Add("@input3got", SqlDbType.VarChar).Value = voucherMonthGot
                    comm.Parameters.Add("@input4got", SqlDbType.VarChar).Value = "BPV"
                    reader = comm.ExecuteReader
                    Dim voucherNoGot As Integer = 0
                    Do While reader.Read = True 'Loop to load data realtime
                        voucherNoGot = (reader(0).ToString)
                    Loop
                    conn.Close()
                    voucherNo.Text = voucherNoGot + 1
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("INSERT INTO voucherMaster(VRType, VRNo, VRDate, VRPostDate, VRStatus, userName, fiscalYear, VRMonth, VRRemarks, ChNumber) VALUES ('" & "BPV" & "', " & voucherNo.Text & "  , '" & dateInput.Text & "'  , '" & todaysDate & "'  , '" & "O" & "'  , '" & userNameGot & "'  , " & fiscalYearIDGot & "  , '" & monthInput.SelectedValue & "'  , '" & remarksInput.Text & "' , '" & chequeInput.Text & "' )", conn)
                    affector = comm.ExecuteNonQuery
                    dateInput.Enabled = False
                    coaCodeInput.ReadOnly = False
                    coaCodeInput.Focus()
                    Call clearAll()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub narrationInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles narrationInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If narrationInput.ReadOnly = False And locked = "yes" Then
                debitInput.ReadOnly = False
                creditInput.ReadOnly = False
                debitInput.Text = 0
                creditInput.Text = 0
                debitInput.Focus()
            End If
        End If
    End Sub

    Private Sub debitInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles debitInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If debitInput.ReadOnly = False And locked = "yes" Then
                If debitInput.Text = 0 Then
                    creditInput.Text = 0
                    creditInput.Focus()
                Else
                    Call saveNewDetail()
                End If
            End If
        End If
    End Sub

    Private Sub creditInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles creditInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If creditInput.ReadOnly = False And locked = "yes" Then
                If creditInput.Text <> 0 Then
                    Call saveNewDetail()
                Else
                    debitInput.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub saveNewDetail()
        If debitInput.ReadOnly = False And saveType = "new" And locked = "yes" And coaCodeInput.Text <> Nothing Then
            If debitInput.Text = 0 And creditInput.Text = 0 Then
                debitInput.Focus()
            ElseIf debitInput.Text <> 0 And creditInput.Text <> 0 Then
                creditInput.Focus()
            ElseIf customerValGot = 1 And customerCodeInput.Text = Nothing Then
                customerCodeInput.Focus()
            ElseIf supplierValGot = 1 And supplierCodeInput.Text = Nothing Then
                supplierCodeInput.Focus()
            ElseIf employeeValGot = 1 And employeeCodeInput.Text = Nothing Then
                employeeCodeInput.Focus()
            ElseIf lcSupplierValGot = 1 And lcSupplierCodeInput.Text = Nothing Then
                lcSupplierCodeInput.Focus()
            ElseIf costCentreValGot = 1 And costCentreCodeInput.Text = Nothing Then
                costCentreCodeInput.Focus()
            Else
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("INSERT INTO voucherDetails(VRType, VRNo, VRDate, VRPostDate, VrAcID, voucherDebit, voucherCredit, VRNaration, userName, fiscalYear, L1groupAcID, L2controlAcID, VRCustomer, VRSupplier, VREmployee, VRLCSupplier, VRCostCentre, VRStatus, VRMonth) VALUES ( '" & "BPV" & "', " & voucherNo.Text & " , '" & dateInput.Text & "'  , '" & todaysDate & "'  , '" & coaCodeInput.Text & "'  , '" & debitInput.Text & "'  , '" & creditInput.Text & "', '" & narrationInput.Text & "', '" & userNameGot & "'  , " & fiscalYearIDGot & "  , '" & coaCodeInput.Text.Substring(0, 2) & "'  , '" & coaCodeInput.Text.Substring(0, 4) & "', '" & customerCodeInput.Text & "' , '" & supplierCodeInput.Text & "' , '" & employeeCodeInput.Text & "' , '" & lcSupplierCodeInput.Text & "' , '" & costCentreCodeInput.Text & "' ,'" & "O" & "' , '" & voucherMonthGot & "' )", conn)
                    affector = comm.ExecuteNonQuery
                    conn.Close()
                    Call clearAll()
                    dateInput.Enabled = False
                    coaCodeInput.ReadOnly = False
                    coaCodeInput.Focus()
                    showData(index)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If a221 = 1 Then
            If tableLoad.Rows.Count() <> 0 Then
                If locked = Nothing And statusInput.SelectedValue = "O" Then
                    conn = New SqlConnection(constr)
                    conn.Open()
                    If masterBtn.Checked = True Then
                        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
                        If delresponse = MsgBoxResult.Yes Then
                            comm = New SqlCommand("DELETE FROM voucherDetails WHERE VRNo = " & voucherNo.Text & " AND VRType = '" & "BPV" & "' AND fiscalYear = " & fiscalYearIDGot & " AND VRMonth = '" & voucherMonthGot & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            comm = New SqlCommand("DELETE FROM voucherMaster WHERE VRNo = " & voucherNo.Text & " AND VRType = '" & "BPV" & "' AND VRStatus = '" & "O" & "' AND fiscalYear = " & fiscalYearIDGot & " AND VRMonth = '" & voucherMonthGot & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            MessageBox.Show("Voucher Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            index = 0
                            voucherNo.Text = Nothing
                            remarksInput.Text = Nothing
                            chequeInput.Text = Nothing
                            ListView1.Items.Clear()
                            showData(index)
                        End If
                    ElseIf detailBtn.Checked = True And ListView1.SelectedItems.Count > 0 Then
                        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
                        If delresponse = MsgBoxResult.Yes Then
                            comm = New SqlCommand("DELETE FROM voucherDetails WHERE voucherDetailID = '" & ListView1.FocusedItem.SubItems.Item(4).Text & "' AND VRNo = " & voucherNo.Text & " AND VRType = '" & "BPV" & "' AND fiscalYear = " & fiscalYearIDGot & " AND VRMonth = '" & voucherMonthGot & "' ", conn)
                            affector = comm.ExecuteNonQuery
                            MessageBox.Show("Voucher Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            showData(index)
                        End If
                    End If
                    conn.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If locked = "yes" And saveType = "update" Then
            If masterBtn.Checked = True Then
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("UPDATE voucherMaster SET VRDate = '" & dateInput.Text & "', VREditDate = '" & todaysDate & "', VRRemarks = '" & remarksInput.Text & "', ChNumber = '" & chequeInput.Text & "' WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
                affector = comm.ExecuteNonQuery
                comm = New SqlCommand("UPDATE voucherDetails SET VRDate = '" & dateInput.Text & "', VREditDate = '" & todaysDate & "' WHERE VRType = '" & "BPV" & "' AND VRNo = '" & voucherNo.Text & "' AND fiscalYear = '" & fiscalYearIDGot & "' AND VRMonth = '" & monthInput.SelectedValue & "' ", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                MessageBox.Show("Voucher has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showData(index)
            ElseIf detailBtn.Checked = True And coaCodeInput.Text <> Nothing And ListView1.SelectedItems.Count > 0 Then
                If tableLoad.Rows.Count() <> 0 Then
                    If debitInput.Text = 0 And creditInput.Text = 0 Then
                        debitInput.Focus()
                    ElseIf debitInput.Text <> 0 And creditInput.Text <> 0 Then
                        creditInput.Focus()
                    Else
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("UPDATE voucherDetails SET VREditDate = '" & todaysDate & "', VrAcID = '" & coaCodeInput.Text & "', voucherDebit = '" & debitInput.Text & "', voucherCredit = '" & creditInput.Text & "', VRNaration = '" & narrationInput.Text & "', userName = '" & userNameGot & "' , L1groupAcID = '" & coaCodeInput.Text.Substring(0, 2) & "', L2controlAcID = '" & coaCodeInput.Text.Substring(0, 4) & "', VRCustomer = '" & customerCodeInput.Text & "', VRSupplier = '" & supplierCodeInput.Text & "',  VREmployee = '" & employeeCodeInput.Text & "', VRLCSupplier = '" & lcSupplierCodeInput.Text & "', VRCostCentre = '" & costCentreCodeInput.Text & "' WHERE voucherDetailID = '" & ListView1.FocusedItem.SubItems.Item(4).Text & "' ", conn)
                        affector = comm.ExecuteNonQuery
                        conn.Close()
                        MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        showData(index)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub coaCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coaCodeInput.TextChanged
        Call clearSub()
    End Sub
    Private Sub clearSub()
        customerValGot = Nothing
        supplierValGot = Nothing
        employeeValGot = Nothing
        lcSupplierValGot = Nothing
        costCentreValGot = Nothing
        customerCodeInput.Text = Nothing
        customerNameInput.Text = Nothing
        supplierCodeInput.Text = Nothing
        supplierNameInput.Text = Nothing
        employeeCodeInput.Text = Nothing
        employeeNameInput.Text = Nothing
        lcSupplierCodeInput.Text = Nothing
        lcSupplierNameInput.Text = Nothing
        costCentreCodeInput.Text = Nothing
        costCentreNameInput.Text = Nothing
    End Sub

    Private Sub customerCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerCodeInput.TextChanged
        VRCustomerGot = Nothing
    End Sub

    Private Sub supplierCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supplierCodeInput.TextChanged
        VRSupplierGot = Nothing
    End Sub

    Private Sub employeeCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles employeeCodeInput.TextChanged
        VREmployeeGot = Nothing
    End Sub

    Private Sub lcSupplierCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lcSupplierCodeInput.TextChanged
        VRLCSupplierGot = Nothing
    End Sub

    Private Sub costCentreCodeInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles costCentreCodeInput.TextChanged
        VRCostCentreGot = Nothing
    End Sub
End Class