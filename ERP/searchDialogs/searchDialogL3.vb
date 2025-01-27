Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchDialogL3
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim coaCodeSent As Integer
    Dim subCatGot As Integer
    Dim customerValGot As Integer
    Dim supplierValGot As Integer
    Dim employeeValGot As Integer
    Dim lcSupplierValGot As Integer
    Dim costCentreValGot As Integer
    Public Property searchKeywordGot As String
    Public Property parentFormGot As String
    Public Property searchQGot As Integer
    Public Property filterHeadKeword As String
    Public Property filterHead As Boolean
    Private Sub searchDialogL3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If filterHead = True Then
            If searchKeywordGot = "" Then
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM L3controlAc WHERE L3controlAcLink1 = '" & filterHeadKeword & "' ORDER BY L3controlAcID ASC ", conn)
                    reader = comm.ExecuteReader
                    'clear list before loading records
                    ListView1.Items.Clear()
                    Dim l2Code As Integer = 0
                    Do While reader.Read = True 'Loop to load data realtime
                        listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                        listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                        l2Code = (reader(2).ToString)
                        Dim conn2 As SqlConnection = New SqlConnection(constr)
                        conn2.Open()
                        Dim comm2 As SqlCommand = New SqlCommand("SELECT * FROM L2controlAc WHERE L2controlAcID = '" & l2Code & "' ", conn2)
                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
                        Dim l1Code As Integer = 0
                        Do While reader2.Read = True
                            listShowAll.SubItems.Add(reader2(1).ToString)
                            l1Code = (reader2(2).ToString)
                            Dim conn3 As SqlConnection = New SqlConnection(constr)
                            conn3.Open()
                            Dim comm3 As SqlCommand = New SqlCommand("SELECT L1groupAcName FROM L1groupAc WHERE L1groupAcID = '" & l1Code & "' ", conn3)
                            Dim reader3 As SqlDataReader = comm3.ExecuteReader
                            Do While reader3.Read = True
                                listShowAll.SubItems.Add(reader3(0).ToString)
                            Loop
                            reader3.Close()
                            conn3.Close()
                        Loop
                        reader2.Close()
                        conn2.Close()
                    Loop
                    reader.Close()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM L3controlAc WHERE L3controlAcLink1 = '" & filterHeadKeword & "' AND L3controlAcName ='" & searchKeywordGot & "'OR L3controlAcID LIKE '%" & searchKeywordGot & "%' OR L3controlAcName LIKE '%" & searchKeywordGot & "%'  ORDER BY L3controlAcID ASC", conn)
                    reader = comm.ExecuteReader
                    'clear list before loading records
                    ListView1.Items.Clear()
                    Dim l2Code As Integer = 0
                    Do While reader.Read = True 'Loop to load data realtime
                        listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                        listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                        l2Code = reader(2).ToString
                        MessageBox.Show(l2Code)
                        Dim conn2 As SqlConnection = New SqlConnection(constr)
                        conn2.Open()
                        Dim comm2 As SqlCommand = New SqlCommand("SELECT * FROM L2controlAc WHERE L2controlAcID = '" & l2Code & "' ", conn2)
                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
                        Dim l1Code As Integer = 0
                        Do While reader2.Read = True
                            listShowAll.SubItems.Add(reader2(1).ToString)
                            l1Code = (reader2(2).ToString)
                            Dim conn3 As SqlConnection = New SqlConnection(constr)
                            conn3.Open()
                            Dim comm3 As SqlCommand = New SqlCommand("SELECT L1groupAcName FROM L1groupAc WHERE L1groupAcID = '" & l1Code & "' ", conn3)
                            Dim reader3 As SqlDataReader = comm3.ExecuteReader
                            Do While reader3.Read = True
                                listShowAll.SubItems.Add(reader3(0).ToString)
                            Loop
                            reader3.Close()
                            conn3.Close()
                        Loop
                        reader2.Close()
                        conn2.Close()
                    Loop
                    reader.Close()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Else
            If searchKeywordGot = "" Then
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM L3controlAc ORDER BY L3controlAcID ASC", conn)
                    reader = comm.ExecuteReader
                    'clear list before loading records
                    ListView1.Items.Clear()
                    Dim l2Code As Integer = 0
                    Do While reader.Read = True 'Loop to load data realtime
                        listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                        listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                        l2Code = (reader(2).ToString)
                        Dim conn2 As SqlConnection = New SqlConnection(constr)
                        conn2.Open()
                        Dim comm2 As SqlCommand = New SqlCommand("SELECT * FROM L2controlAc WHERE L2controlAcID = '" & l2Code & "' ", conn2)
                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
                        Dim l1Code As Integer = 0
                        Do While reader2.Read = True
                            listShowAll.SubItems.Add(reader2(1).ToString)
                            l1Code = (reader2(2).ToString)
                            Dim conn3 As SqlConnection = New SqlConnection(constr)
                            conn3.Open()
                            Dim comm3 As SqlCommand = New SqlCommand("SELECT L1groupAcName FROM L1groupAc WHERE L1groupAcID = '" & l1Code & "' ", conn3)
                            Dim reader3 As SqlDataReader = comm3.ExecuteReader
                            Do While reader3.Read = True
                                listShowAll.SubItems.Add(reader3(0).ToString)
                            Loop
                            reader3.Close()
                            conn3.Close()
                        Loop
                        reader2.Close()
                        conn2.Close()
                    Loop
                    reader.Close()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM L3controlAc WHERE L3controlAcName ='" & searchKeywordGot & "'OR L3controlAcID LIKE '%" & searchKeywordGot & "%' OR L3controlAcName LIKE '%" & searchKeywordGot & "%' ORDER BY L3controlAcID ASC", conn)
                    reader = comm.ExecuteReader
                    'clear list before loading records
                    ListView1.Items.Clear()
                    Dim l2Code As Integer = 0
                    Do While reader.Read = True 'Loop to load data realtime
                        listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                        listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                        l2Code = (reader(2).ToString)
                        Dim conn2 As SqlConnection = New SqlConnection(constr)
                        conn2.Open()
                        Dim comm2 As SqlCommand = New SqlCommand("SELECT * FROM L2controlAc WHERE L2controlAcID = '" & l2Code & "' ", conn2)
                        Dim reader2 As SqlDataReader = comm2.ExecuteReader
                        Dim l1Code As Integer = 0
                        Do While reader2.Read = True
                            listShowAll.SubItems.Add(reader2(1).ToString)
                            l1Code = (reader2(2).ToString)
                            Dim conn3 As SqlConnection = New SqlConnection(constr)
                            conn3.Open()
                            Dim comm3 As SqlCommand = New SqlCommand("SELECT L1groupAcName FROM L1groupAc WHERE L1groupAcID = '" & l1Code & "' ", conn3)
                            Dim reader3 As SqlDataReader = comm3.ExecuteReader
                            Do While reader3.Read = True
                                listShowAll.SubItems.Add(reader3(0).ToString)
                            Loop
                            reader3.Close()
                            conn3.Close()
                        Loop
                        reader2.Close()
                        conn2.Close()
                    Loop
                    reader.Close()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
        If parentFormGot = "productDetail" Then
            If searchQGot = 1 Then
                If e.KeyCode = Keys.Enter Then
                    productDetail.assetHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                    productDetail.assetHeadNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                    productDetail.revenueHeadCodeInput.Focus()
                    productDetail.Activate()
                    Me.Close()
                ElseIf e.KeyCode = Keys.Escape Then
                    Me.Close()
                    productDetail.assetHeadCodeInput.Focus()
                    productDetail.assetHeadCodeInput.Text = Nothing
                    productDetail.assetHeadNameInput.Text = Nothing
                    productDetail.Activate()
                End If
            ElseIf searchQGot = 2 Then
                If e.KeyCode = Keys.Enter Then
                    productDetail.revenueHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                    productDetail.revenueHeadNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                    productDetail.cgsHeadCodeInput.Focus()
                    productDetail.Activate()
                    Me.Close()
                ElseIf e.KeyCode = Keys.Escape Then
                    Me.Close()
                    productDetail.revenueHeadCodeInput.Focus()
                    productDetail.revenueHeadCodeInput.Text = Nothing
                    productDetail.revenueHeadNameInput.Text = Nothing
                    productDetail.Activate()
                End If
            ElseIf searchQGot = 3 Then
                If e.KeyCode = Keys.Enter Then
                    productDetail.cgsHeadCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                    productDetail.cgsHeadNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                    productDetail.genericNameInput.Focus()
                    productDetail.Activate()
                    Me.Close()
                ElseIf e.KeyCode = Keys.Escape Then
                    Me.Close()
                    productDetail.cgsHeadCodeInput.Focus()
                    productDetail.cgsHeadCodeInput.Text = Nothing
                    productDetail.cgsHeadNameInput.Text = Nothing
                    productDetail.Activate()
                End If
            End If
        ElseIf parentFormGot = "jv" Then
            If e.KeyCode = Keys.Enter Then
                coaCodeSent = ListView1.FocusedItem.SubItems.Item(0).Text
                jv.coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                jv.coaNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & coaCodeSent & "'", conn)
                    Dim adapter1 As New SqlDataAdapter(comm)
                    Dim table1 As New DataTable()
                    adapter1.Fill(table1)
                    If table1.Rows.Count() > 0 Then
                        reader2 = comm.ExecuteReader
                        Do While reader2.Read = True
                            subCatGot = (reader2(2).ToString)
                            If subCatGot = 1 Then
                                customerValGot = 1
                                jv.customerValGot = 1
                            ElseIf subCatGot = 2 Then
                                supplierValGot = 1
                                jv.supplierValGot = 1
                            ElseIf subCatGot = 3 Then
                                employeeValGot = 1
                                jv.employeeValGot = 1
                            ElseIf subCatGot = 4 Then
                                lcSupplierValGot = 1
                                jv.lcSupplierValGot = 1
                            ElseIf subCatGot = 5 Then
                                costCentreValGot = 1
                                jv.costCentreValGot = 1
                            End If
                        Loop
                        If customerValGot = 1 Then
                            jv.customerCodeInput.ReadOnly = False
                            jv.customerCodeInput.Focus()
                        ElseIf supplierValGot = 1 Then
                            jv.supplierCodeInput.ReadOnly = False
                            jv.supplierCodeInput.Focus()
                        ElseIf employeeValGot = 1 Then
                            jv.employeeCodeInput.ReadOnly = False
                            jv.employeeCodeInput.Focus()
                        ElseIf lcSupplierValGot = 1 Then
                            jv.lcSupplierCodeInput.ReadOnly = False
                            jv.lcSupplierCodeInput.Focus()
                        ElseIf costCentreValGot = 1 Then
                            jv.costCentreCodeInput.ReadOnly = False
                            jv.costCentreCodeInput.Focus()
                        End If
                    Else
                        jv.narrationFocusGot = "yes"
                        jv.narrationInput.ReadOnly = False
                        jv.narrationInput.Focus()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                jv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                jv.coaCodeInput.Focus()
                jv.coaCodeInput.Text = Nothing
                jv.coaNameInput.Text = Nothing
                jv.Activate()
            End If
        ElseIf parentFormGot = "brv" Then
            If e.KeyCode = Keys.Enter Then
                coaCodeSent = ListView1.FocusedItem.SubItems.Item(0).Text
                brv.coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                brv.coaNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & coaCodeSent & "'", conn)
                    Dim adapter1 As New SqlDataAdapter(comm)
                    Dim table1 As New DataTable()
                    adapter1.Fill(table1)
                    If table1.Rows.Count() > 0 Then
                        reader2 = comm.ExecuteReader
                        Do While reader2.Read = True
                            subCatGot = (reader2(2).ToString)
                            If subCatGot = 1 Then
                                customerValGot = 1
                                brv.customerValGot = 1
                            ElseIf subCatGot = 2 Then
                                supplierValGot = 1
                                brv.supplierValGot = 1
                            ElseIf subCatGot = 3 Then
                                employeeValGot = 1
                                brv.employeeValGot = 1
                            ElseIf subCatGot = 4 Then
                                lcSupplierValGot = 1
                                brv.lcSupplierValGot = 1
                            ElseIf subCatGot = 5 Then
                                costCentreValGot = 1
                                brv.costCentreValGot = 1
                            End If
                        Loop
                        If customerValGot = 1 Then
                            brv.customerCodeInput.ReadOnly = False
                            brv.customerCodeInput.Focus()
                        ElseIf supplierValGot = 1 Then
                            brv.supplierCodeInput.ReadOnly = False
                            brv.supplierCodeInput.Focus()
                        ElseIf employeeValGot = 1 Then
                            brv.employeeCodeInput.ReadOnly = False
                            brv.employeeCodeInput.Focus()
                        ElseIf lcSupplierValGot = 1 Then
                            brv.lcSupplierCodeInput.ReadOnly = False
                            brv.lcSupplierCodeInput.Focus()
                        ElseIf costCentreValGot = 1 Then
                            brv.costCentreCodeInput.ReadOnly = False
                            brv.costCentreCodeInput.Focus()
                        End If
                    Else
                        brv.narrationFocusGot = "yes"
                        brv.narrationInput.ReadOnly = False
                        brv.narrationInput.Focus()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                brv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                brv.coaCodeInput.Focus()
                brv.coaCodeInput.Text = Nothing
                brv.coaNameInput.Text = Nothing
                brv.Activate()
            End If
        ElseIf parentFormGot = "bpv" Then
            If e.KeyCode = Keys.Enter Then
                coaCodeSent = ListView1.FocusedItem.SubItems.Item(0).Text
                bpv.coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                bpv.coaNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & coaCodeSent & "'", conn)
                    Dim adapter1 As New SqlDataAdapter(comm)
                    Dim table1 As New DataTable()
                    adapter1.Fill(table1)
                    If table1.Rows.Count() > 0 Then
                        reader2 = comm.ExecuteReader
                        Do While reader2.Read = True
                            subCatGot = (reader2(2).ToString)
                            If subCatGot = 1 Then
                                customerValGot = 1
                                bpv.customerValGot = 1
                            ElseIf subCatGot = 2 Then
                                supplierValGot = 1
                                bpv.supplierValGot = 1
                            ElseIf subCatGot = 3 Then
                                employeeValGot = 1
                                bpv.employeeValGot = 1
                            ElseIf subCatGot = 4 Then
                                lcSupplierValGot = 1
                                bpv.lcSupplierValGot = 1
                            ElseIf subCatGot = 5 Then
                                costCentreValGot = 1
                                bpv.costCentreValGot = 1
                            End If
                        Loop
                        If customerValGot = 1 Then
                            bpv.customerCodeInput.ReadOnly = False
                            bpv.customerCodeInput.Focus()
                        ElseIf supplierValGot = 1 Then
                            bpv.supplierCodeInput.ReadOnly = False
                            bpv.supplierCodeInput.Focus()
                        ElseIf employeeValGot = 1 Then
                            bpv.employeeCodeInput.ReadOnly = False
                            bpv.employeeCodeInput.Focus()
                        ElseIf lcSupplierValGot = 1 Then
                            bpv.lcSupplierCodeInput.ReadOnly = False
                            bpv.lcSupplierCodeInput.Focus()
                        ElseIf costCentreValGot = 1 Then
                            bpv.costCentreCodeInput.ReadOnly = False
                            bpv.costCentreCodeInput.Focus()
                        End If
                    Else
                        bpv.narrationFocusGot = "yes"
                        bpv.narrationInput.ReadOnly = False
                        bpv.narrationInput.Focus()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                bpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                bpv.coaCodeInput.Focus()
                bpv.coaCodeInput.Text = Nothing
                bpv.coaNameInput.Text = Nothing
                bpv.Activate()
            End If
        ElseIf parentFormGot = "crv" Then
            If e.KeyCode = Keys.Enter Then
                coaCodeSent = ListView1.FocusedItem.SubItems.Item(0).Text
                crv.coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                crv.coaNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & coaCodeSent & "'", conn)
                    Dim adapter1 As New SqlDataAdapter(comm)
                    Dim table1 As New DataTable()
                    adapter1.Fill(table1)
                    If table1.Rows.Count() > 0 Then
                        reader2 = comm.ExecuteReader
                        Do While reader2.Read = True
                            subCatGot = (reader2(2).ToString)
                            If subCatGot = 1 Then
                                customerValGot = 1
                                crv.customerValGot = 1
                            ElseIf subCatGot = 2 Then
                                supplierValGot = 1
                                crv.supplierValGot = 1
                            ElseIf subCatGot = 3 Then
                                employeeValGot = 1
                                crv.employeeValGot = 1
                            ElseIf subCatGot = 4 Then
                                lcSupplierValGot = 1
                                crv.lcSupplierValGot = 1
                            ElseIf subCatGot = 5 Then
                                costCentreValGot = 1
                                crv.costCentreValGot = 1
                            End If
                        Loop
                        If customerValGot = 1 Then
                            crv.customerCodeInput.ReadOnly = False
                            crv.customerCodeInput.Focus()
                        ElseIf supplierValGot = 1 Then
                            crv.supplierCodeInput.ReadOnly = False
                            crv.supplierCodeInput.Focus()
                        ElseIf employeeValGot = 1 Then
                            crv.employeeCodeInput.ReadOnly = False
                            crv.employeeCodeInput.Focus()
                        ElseIf lcSupplierValGot = 1 Then
                            crv.lcSupplierCodeInput.ReadOnly = False
                            crv.lcSupplierCodeInput.Focus()
                        ElseIf costCentreValGot = 1 Then
                            crv.costCentreCodeInput.ReadOnly = False
                            crv.costCentreCodeInput.Focus()
                        End If
                    Else
                        crv.narrationFocusGot = "yes"
                        crv.narrationInput.ReadOnly = False
                        crv.narrationInput.Focus()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                crv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                crv.coaCodeInput.Focus()
                crv.coaCodeInput.Text = Nothing
                crv.coaNameInput.Text = Nothing
                crv.Activate()
            End If
        ElseIf parentFormGot = "cpv" Then
            If e.KeyCode = Keys.Enter Then
                coaCodeSent = ListView1.FocusedItem.SubItems.Item(0).Text
                cpv.coaCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                cpv.coaNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & coaCodeSent & "'", conn)
                    Dim adapter1 As New SqlDataAdapter(comm)
                    Dim table1 As New DataTable()
                    adapter1.Fill(table1)
                    If table1.Rows.Count() > 0 Then
                        reader2 = comm.ExecuteReader
                        Do While reader2.Read = True
                            subCatGot = (reader2(2).ToString)
                            If subCatGot = 1 Then
                                customerValGot = 1
                                cpv.customerValGot = 1
                            ElseIf subCatGot = 2 Then
                                supplierValGot = 1
                                cpv.supplierValGot = 1
                            ElseIf subCatGot = 3 Then
                                employeeValGot = 1
                                cpv.employeeValGot = 1
                            ElseIf subCatGot = 4 Then
                                lcSupplierValGot = 1
                                cpv.lcSupplierValGot = 1
                            ElseIf subCatGot = 5 Then
                                costCentreValGot = 1
                                cpv.costCentreValGot = 1
                            End If
                        Loop
                        If customerValGot = 1 Then
                            cpv.customerCodeInput.ReadOnly = False
                            cpv.customerCodeInput.Focus()
                        ElseIf supplierValGot = 1 Then
                            cpv.supplierCodeInput.ReadOnly = False
                            cpv.supplierCodeInput.Focus()
                        ElseIf employeeValGot = 1 Then
                            cpv.employeeCodeInput.ReadOnly = False
                            cpv.employeeCodeInput.Focus()
                        ElseIf lcSupplierValGot = 1 Then
                            cpv.lcSupplierCodeInput.ReadOnly = False
                            cpv.lcSupplierCodeInput.Focus()
                        ElseIf costCentreValGot = 1 Then
                            cpv.costCentreCodeInput.ReadOnly = False
                            cpv.costCentreCodeInput.Focus()
                        End If
                    Else
                        cpv.narrationFocusGot = "yes"
                        cpv.narrationInput.ReadOnly = False
                        cpv.narrationInput.Focus()
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                cpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                cpv.coaCodeInput.Focus()
                cpv.coaCodeInput.Text = Nothing
                cpv.coaNameInput.Text = Nothing
                cpv.Activate()
            End If
        ElseIf parentFormGot = "coaRange1" Then
            If e.KeyCode = Keys.Enter Then
                coaLedgerRange.coaCodeInput1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaLedgerRange.coaNameInput1.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaLedgerRange.coaCodeInput2.Focus()
                coaLedgerRange.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaLedgerRange.coaCodeInput1.Focus()
                coaLedgerRange.coaCodeInput1.Text = Nothing
                coaLedgerRange.coaNameInput1.Text = Nothing
                coaLedgerRange.Activate()
            End If
        ElseIf parentFormGot = "coaRange2" Then
            If e.KeyCode = Keys.Enter Then
                coaLedgerRange.coaCodeInput2.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaLedgerRange.coaNameInput2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaLedgerRange.fromDate.Focus()
                coaLedgerRange.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaLedgerRange.coaCodeInput2.Focus()
                coaLedgerRange.coaCodeInput2.Text = Nothing
                coaLedgerRange.coaNameInput2.Text = Nothing
                coaLedgerRange.Activate()
            End If
        ElseIf parentFormGot = "coaWSubRange1" Then
            If e.KeyCode = Keys.Enter Then
                coaWSubLedger.coaCodeInput1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaWSubLedger.coaNameInput1.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaWSubLedger.coaCodeInput2.Focus()
                coaWSubLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaWSubLedger.coaCodeInput1.Focus()
                coaWSubLedger.coaCodeInput1.Text = Nothing
                coaWSubLedger.coaNameInput1.Text = Nothing
                coaWSubLedger.Activate()
            End If
        ElseIf parentFormGot = "coaWSubRange2" Then
            If e.KeyCode = Keys.Enter Then
                coaWSubLedger.coaCodeInput2.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaWSubLedger.coaNameInput2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaWSubLedger.subIDInput1.Focus()
                coaWSubLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaWSubLedger.coaCodeInput2.Focus()
                coaWSubLedger.coaCodeInput2.Text = Nothing
                coaWSubLedger.coaNameInput2.Text = Nothing
                coaWSubLedger.Activate()
            End If
        ElseIf parentFormGot = "subWCoaRange1" Then
            If e.KeyCode = Keys.Enter Then
                subWCoaLedger.coaCodeInput1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                subWCoaLedger.coaNameInput1.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                subWCoaLedger.coaCodeInput2.Focus()
                subWCoaLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                subWCoaLedger.coaCodeInput1.Focus()
                subWCoaLedger.coaCodeInput1.Text = Nothing
                subWCoaLedger.coaNameInput1.Text = Nothing
                subWCoaLedger.Activate()
            End If
        ElseIf parentFormGot = "subWCoaRange2" Then
            If e.KeyCode = Keys.Enter Then
                subWCoaLedger.coaCodeInput2.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                subWCoaLedger.coaNameInput2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                subWCoaLedger.fromDate.Focus()
                subWCoaLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                subWCoaLedger.coaCodeInput2.Focus()
                subWCoaLedger.coaCodeInput2.Text = Nothing
                subWCoaLedger.coaNameInput2.Text = Nothing
                subWCoaLedger.Activate()
            End If
        Else
        End If
    End Sub

    Private Sub searchDialogL3_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class