Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class acL3
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeL2Got As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim input3c As String
    Dim statusConv As String
    Dim statusConvGot As String
    Dim l2InputVal1 As Integer
    Private Sub acL3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L2controlAc", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            nameL2Input.DataSource = table
            nameL2Input.DisplayMember = "L2controlAcName"
            nameL2Input.ValueMember = "L2controlAcID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub nameL1Input_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nameL2Input.SelectedIndexChanged
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT L2controlAcID FROM L2controlAc WHERE L2controlAcName = @nameinput1got", conn)
            comm.Parameters.Add("@nameinput1got", SqlDbType.VarChar).Value = nameL2Input.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                codeL2Got = (reader(0).ToString) 'Load Code from table
                codeL2Input.Text = codeL2Got
            Loop
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadRecordsAll()
        Call clearAll()
        codeInput.ReadOnly = True
        nameInput.ReadOnly = True
        linkInput.ReadOnly = True
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeL2Got & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                listShowAll.SubItems.Add(nameL2Input.Text) ' Load Name from table L1
                listShowAll.SubItems.Add(reader(3).ToString) ' Load Account Status from table
                listShowAll.SubItems.Add(reader(4).ToString) ' Load Link Code from table
            Loop
            reader.Close()
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
            l2InputVal1 = codeInput.Text.Substring(0, 4)
        End If
        If codeInput.Text = "" Then
            MsgBox("Please Enter a Valid Code")
            codeInput.Focus()
        ElseIf codeInput.Text < 100000001 Then
            MsgBox("Please Enter a Valid Code (100000001 to 999999999)")
            codeInput.Focus()
        ElseIf l2InputVal1 <> codeL2Got Then
            MsgBox("Please Enter a Valid Code (Begining with Control Account Code i.e " & codeL2Got & ")")
            codeInput.Focus()
        ElseIf nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        ElseIf linkInput.Text = "" Then
            MsgBox("Please Enter a Valid Link Code")
            linkInput.Focus()
        ElseIf statusInput.Text = "" Then
            MsgBox("Please Select Account Status")
            statusInput.Focus()
        Else
            Dim input1 As Integer = codeInput.Text
            Dim input2 As String = nameInput.Text
            Dim input3 As String = statusInput.Text
            If input3 = "ACTIVE" Then
                input3c = "A"
            ElseIf input3 = "INACTIVE" Then
                input3c = "I"
            End If
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L3controlAcID = @input1got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO L3controlAc(L3controlAcID, L3controlAcName, L2controlAcID, acStatus, L3controlAcLink1) VALUES ('" & codeInput.Text & "' , '" & nameInput.Text & "' , '" & codeL2Got & "', '" & input3c & "', '" & linkInput.Text & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        Call clearAll()
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call clearAll()
                        codeInput.ReadOnly = True
                        nameInput.ReadOnly = True
                        linkInput.ReadOnly = True
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
                    comm = New SqlCommand("UPDATE L3controlAc SET L3controlAcName = '" & nameInput.Text & "', acStatus = '" & input3c & "', L3controlAcLink1 = '" & linkInput.Text & "'  WHERE L3controlAcID = '" & codeGot & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call clearAll()
                    Call loadRecordsAll()
                    saveType = ""
                    codeInput.ReadOnly = True
                    nameInput.ReadOnly = True
                Else
                    MsgBox("Please Click New or Select Edit an Existing Record")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Call clearAll()
        codeInput.ReadOnly = False
        nameInput.ReadOnly = False
        linkInput.ReadOnly = False
        saveType = "new"
        codeInput.Focus()
        codeInput.Text = codeL2Got
        codeInput.SelectionStart = codeInput.Text.Length + 1
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
        linkInput.Text = Nothing
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        codeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
        codeInput.ReadOnly = True
        nameInput.ReadOnly = False
        linkInput.ReadOnly = False
        nameInput.Focus()
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        statusConv = ListView1.FocusedItem.SubItems.Item(3).Text
        linkInput.Text = ListView1.FocusedItem.SubItems.Item(4).Text
        If statusConv = "A" Then
            statusConvGot = "ACTIVE"
        ElseIf statusConv = "I" Then
            statusConvGot = "INACTIVE"
        End If
        statusInput.Text = statusConvGot
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
            comm = New SqlCommand("DELETE FROM L3controlAc WHERE L3controlAcID = '" & codeGot & "' ", conn)
            affector = comm.ExecuteNonQuery
            Call clearAll()
            MessageBox.Show("Record Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            saveType = ""
            'Reload records on new entry
            Call loadRecordsAll()
        Else
            Call loadRecordsAll()
        End If
        conn.Close()
        'Else
        '    MsgBox("Access Denied! Please Delete Linked Records First.")
        'End If
    End Sub
End Class