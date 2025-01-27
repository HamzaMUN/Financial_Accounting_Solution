Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class productDetail
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim conn2 As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeCatGot As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim input3c As String
    Dim statusConv As String
    Dim statusConvGot As String
    Dim inputVal1 As Integer
    Dim inputVal2 As Integer
    Dim inputVal3 As Integer
    Dim coaNameGot1 As String
    Dim keywordSearch As String
    Private Sub productDetail_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM productCategory ORDER BY productCatID", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            nameCatInput.DataSource = table
            nameCatInput.DisplayMember = "productCatName"
            nameCatInput.ValueMember = "productCatID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub nameCatInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nameCatInput.SelectedIndexChanged
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT productCatID FROM productCategory WHERE productCatName = @nameinput1got", conn)
            comm.Parameters.Add("@nameinput1got", SqlDbType.VarChar).Value = nameCatInput.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                codeCatGot = (reader(0).ToString) 'Load Code from table
                codeCatInput.Text = codeCatGot
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadRecordsAll()
        Call clearAll()
        Call lockAll()
        codeInput.ReadOnly = True
        genericNameInput.ReadOnly = True
        packingInput.ReadOnly = True
        assetHeadCodeInput.ReadOnly = True
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM productDetail WHERE productCatID = '" & codeCatGot & "' AND productName LIKE '%" & keywordSearch & "%' ORDER BY productID", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(1).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(2).ToString)
                listShowAll.SubItems.Add(reader(3).ToString)
                listShowAll.SubItems.Add(reader(4).ToString)
                listShowAll.SubItems.Add(reader(5).ToString)
                listShowAll.SubItems.Add(reader(6).ToString)
                listShowAll.SubItems.Add(reader(7).ToString)
                listShowAll.SubItems.Add(reader(8).ToString)
                listShowAll.SubItems.Add(reader(9).ToString)
                listShowAll.SubItems.Add(reader(10).ToString)
                listShowAll.SubItems.Add(reader(11).ToString)
                listShowAll.SubItems.Add(reader(12).ToString)
                listShowAll.SubItems.Add(reader(13).ToString)
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        SaveToolStripMenuItem.PerformClick()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveToolStripMenuItem.Click
        If codeInput.Text <> "" Then
            inputVal1 = codeInput.Text.Substring(0, 1)
            inputVal2 = codeInput.Text.Substring(0, 2)
            inputVal3 = codeInput.Text.Substring(0, 3)
        End If
        If codeInput.Text = "" Then
            MsgBox("Please Enter a Valid Code")
            codeInput.Focus()
        ElseIf codeInput.Text < 100001 Then
            MsgBox("Please Enter a Valid Code i.e. 6 digits (100001 to 999999)")
            codeInput.Focus()
        ElseIf inputVal1 <> codeCatGot And inputVal2 <> codeCatGot And inputVal3 <> codeCatGot Then
            MsgBox("Please Enter a Valid Code (Begining with Category Code i.e " & codeCatGot & ")")
            codeInput.Focus()
        ElseIf nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        ElseIf packingInput.Text = "" Then
            MsgBox("Please Enter a Valid Packing")
            packingInput.Focus()
        ElseIf storeInput.Text = "" Then
            MsgBox("Please Select Store Location for Product")
            storeInput.Focus()
        ElseIf assetHeadCodeInput.Text = "" Then
            MsgBox("Please Enter a Asset Head")
            assetHeadCodeInput.Focus()
        ElseIf assetHeadCodeInput.Text < 100000001 Then
            MsgBox("Please Enter a Valid Code (100000001 to 999999999)")
            assetHeadCodeInput.Focus()
        ElseIf revenueHeadCodeInput.Text = "" Then
            MsgBox("Please Enter a Revenue Head")
            revenueHeadCodeInput.Focus()
        ElseIf revenueHeadCodeInput.Text < 100000001 Then
            MsgBox("Please Enter a Valid Code (100000001 to 999999999)")
            revenueHeadCodeInput.Focus()
        ElseIf cgsHeadCodeInput.Text = "" Then
            MsgBox("Please Enter a CGS Head")
            cgsHeadCodeInput.Focus()
        ElseIf cgsHeadCodeInput.Text < 100000001 Then
            MsgBox("Please Enter a Valid Code (100000001 to 999999999)")
            cgsHeadCodeInput.Focus()
        ElseIf genericNameInput.Text = "" Then
            MsgBox("Please Enter a Valid Generic Name")
            genericNameInput.Focus()
        ElseIf licenseNoInput.Text = "" Then
            MsgBox("Please Enter a Valid License No.")
            licenseNoInput.Focus()
        ElseIf retailPriceInput.Text = "" Then
            MsgBox("Please Enter a Valid Retail Price")
            retailPriceInput.Focus()
        ElseIf tradePriceInput.Text = "" Then
            MsgBox("Please Enter a Valid Trade Price")
            tradePriceInput.Focus()
        ElseIf costPriceInput.Text = "" Then
            MsgBox("Please Enter a Valid Cost Price")
            costPriceInput.Focus()
        ElseIf distributionPriceInput.Text = "" Then
            MsgBox("Please Enter a Valid Distribution Price")
            distributionPriceInput.Focus()
        ElseIf retailPriceInput.Text < 0 Then
            MsgBox("Please Enter a Valid Retail Price")
            retailPriceInput.Focus()
        ElseIf tradePriceInput.Text < 0 Then
            MsgBox("Please Enter a Valid Trade Price")
            tradePriceInput.Focus()
        ElseIf costPriceInput.Text < 0 Then
            MsgBox("Please Enter a Valid Cost Price")
            costPriceInput.Focus()
        ElseIf distributionPriceInput.Text < 0 Then
            MsgBox("Please Enter a Valid Distribution Price")
            distributionPriceInput.Focus()
        Else
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM productDetail WHERE productID = @input1got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO productDetail(productCatID, productID, productName, productPacking, productStore, assetHead, revenueHead, cgsHead, genericName, licenseNo, retailPrice, tradePrice, costPrice, distributionPrice) VALUES ('" & codeCatGot & "' , '" & codeInput.Text & "' , '" & nameInput.Text & "', '" & packingInput.Text & "', '" & storeInput.Text & "', '" & assetHeadCodeInput.Text & "', '" & revenueHeadCodeInput.Text & "', '" & cgsHeadCodeInput.Text & "', '" & genericNameInput.Text & "', '" & licenseNoInput.Text & "', '" & retailPriceInput.Text & "', '" & tradePriceInput.Text & "', '" & costPriceInput.Text & "', '" & distributionPriceInput.Text & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call clearAll()
                        Call clearAll()
                        'Reload records on new entry
                        Call loadRecordsAll()
                        saveType = ""
                    Else
                        MsgBox("Record already exist!")
                    End If
                    conn.Close()
                ElseIf saveType = "update" Then
                    'Update existing record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("UPDATE productDetail SET productName = '" & nameInput.Text & "', productPacking = '" & packingInput.Text & "', productStore = '" & storeInput.Text & "', assetHead = '" & assetHeadCodeInput.Text & "', revenueHead = '" & revenueHeadCodeInput.Text & "', cgsHead = '" & cgsHeadCodeInput.Text & "', genericName = '" & genericNameInput.Text & "', licenseNo = '" & licenseNoInput.Text & "', retailPrice = '" & retailPriceInput.Text & "', tradePrice = '" & tradePriceInput.Text & "', costPrice = '" & costPriceInput.Text & "', distributionPrice = '" & distributionPriceInput.Text & "'  WHERE productID = '" & codeGot & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    Call clearAll()
                    Call lockAll()
                    Call loadRecordsAll()
                    saveType = ""
                Else
                    MsgBox("Please Click New or Select Edit an Existing Record")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Call clearAll()
        Call unLockAll()
        saveType = "new"
        codeInput.Focus()
        codeInput.Text = codeCatGot
        codeInput.SelectionStart = codeInput.Text.Length + 1
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
        packingInput.Text = Nothing
        storeInput.SelectedText = Nothing
        assetHeadCodeInput.Text = Nothing
        assetHeadNameInput.Text = Nothing
        revenueHeadCodeInput.Text = Nothing
        revenueHeadNameInput.Text = Nothing
        cgsHeadCodeInput.Text = Nothing
        cgsHeadNameInput.Text = Nothing
        genericNameInput.Text = Nothing
        licenseNoInput.Text = Nothing
        retailPriceInput.Text = Nothing
        tradePriceInput.Text = Nothing
        costPriceInput.Text = Nothing
        distributionPriceInput.Text = Nothing
    End Sub
    Private Sub lockAll()
        'Lock Input Fields on Clear
        codeInput.ReadOnly = True
        nameInput.ReadOnly = True
        packingInput.ReadOnly = True
        assetHeadCodeInput.ReadOnly = True
        revenueHeadCodeInput.ReadOnly = True
        cgsHeadCodeInput.ReadOnly = True
        genericNameInput.ReadOnly = True
        licenseNoInput.ReadOnly = True
        retailPriceInput.ReadOnly = True
        tradePriceInput.ReadOnly = True
        costPriceInput.ReadOnly = True
        distributionPriceInput.ReadOnly = True
    End Sub
    Private Sub unLockAll()
        'Lock Input Fields on Clear
        codeInput.ReadOnly = False
        nameInput.ReadOnly = False
        packingInput.ReadOnly = False
        assetHeadCodeInput.ReadOnly = False
        revenueHeadCodeInput.ReadOnly = False
        cgsHeadCodeInput.ReadOnly = False
        genericNameInput.ReadOnly = False
        licenseNoInput.ReadOnly = False
        retailPriceInput.ReadOnly = False
        tradePriceInput.ReadOnly = False
        costPriceInput.ReadOnly = False
        distributionPriceInput.ReadOnly = False
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        codeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
        codeInput.ReadOnly = True
        nameInput.ReadOnly = False
        packingInput.ReadOnly = False
        assetHeadCodeInput.ReadOnly = False
        revenueHeadCodeInput.ReadOnly = False
        cgsHeadCodeInput.ReadOnly = False
        genericNameInput.ReadOnly = False
        licenseNoInput.ReadOnly = False
        retailPriceInput.ReadOnly = False
        tradePriceInput.ReadOnly = False
        costPriceInput.ReadOnly = False
        distributionPriceInput.ReadOnly = False
        nameInput.Focus()
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        packingInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
        storeInput.Text = ListView1.FocusedItem.SubItems.Item(3).Text
        assetHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(4).Text
        revenueHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(5).Text
        cgsHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(6).Text
        genericNameInput.Text = ListView1.FocusedItem.SubItems.Item(7).Text
        licenseNoInput.Text = ListView1.FocusedItem.SubItems.Item(8).Text
        retailPriceInput.Text = ListView1.FocusedItem.SubItems.Item(9).Text
        tradePriceInput.Text = ListView1.FocusedItem.SubItems.Item(10).Text
        costPriceInput.Text = ListView1.FocusedItem.SubItems.Item(11).Text
        distributionPriceInput.Text = ListView1.FocusedItem.SubItems.Item(12).Text
        saveType = "update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Validation for child records in Transactions Table
        'Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
        'Dim valadapter1 As New SqlDataAdapter(valcommand1)
        'Dim valtable1 As New DataTable()
        'valadapter1.Fill(valtable1)
        'If valtable1.Rows.Count() <= 0 Then
        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
        If delresponse = MsgBoxResult.Yes Then
            comm = New SqlCommand("DELETE FROM productDetail WHERE productID = '" & codeGot & "' ", conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
            Call clearAll()
            MessageBox.Show("Record Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            saveType = ""
            'Reload records on new entry
            Call loadRecordsAll()
        Else
            Call loadRecordsAll()
        End If
        'Else
        '    MsgBox("Access Denied! Please Delete Linked Records First.")
        'End If
    End Sub

    Private Sub assetHeadCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles assetHeadCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If assetHeadCodeInput.ReadOnly = False Then
                Call searchQ1()
            End If
        End If
    End Sub
    Private Sub searchQ1()
        searchDialogL3.searchKeywordGot = assetHeadCodeInput.Text
        searchDialogL3.parentFormGot = "productDetail"
        searchDialogL3.searchQGot = 1
        searchDialogL3.filterHeadKeword = "A"
        searchDialogL3.filterHead = True
        searchDialogL3.Show()
    End Sub
    Private Sub revenueHeadCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles revenueHeadCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If revenueHeadCodeInput.ReadOnly = False Then
                Call searchQ2()
            End If
        End If
    End Sub
    Private Sub searchQ2()
        searchDialogL3.searchKeywordGot = revenueHeadCodeInput.Text
        searchDialogL3.parentFormGot = "productDetail"
        searchDialogL3.searchQGot = 2
        searchDialogL3.filterHeadKeword = "R"
        searchDialogL3.filterHead = True
        searchDialogL3.Show()
    End Sub
    Private Sub cgsHeadCodeInput_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cgsHeadCodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cgsHeadCodeInput.ReadOnly = False Then
                Call searchQ3()
            End If
        End If
    End Sub
    Private Sub searchQ3()
        searchDialogL3.searchKeywordGot = cgsHeadCodeInput.Text
        searchDialogL3.parentFormGot = "productDetail"
        searchDialogL3.searchQGot = 3
        searchDialogL3.filterHeadKeword = "C"
        searchDialogL3.filterHead = True
        searchDialogL3.Show()
    End Sub

    Private Sub productDetail_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Deactivate
        productDetail_LostFocus(sender, e)
        Me.Activate()
    End Sub

    Private Sub productDetail_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LostFocus
        Me.Activate()
    End Sub

    Private Sub searchInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchInput.TextChanged
        keywordSearch = searchInput.Text
        Call loadRecordsAll()
    End Sub

End Class