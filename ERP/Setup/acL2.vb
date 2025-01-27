Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class acL2
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeL1Got As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim l1InputVal1 As Integer
    Private Sub acL2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L1groupAc ORDER BY L1groupAcID ASC", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            nameL1Input.DataSource = table
            nameL1Input.DisplayMember = "L1groupAcName"
            nameL1Input.ValueMember = "L1groupAcID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub nameL1Input_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nameL1Input.SelectedIndexChanged
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT L1groupAcID FROM L1groupAc WHERE L1groupAcName = @nameinput1got", conn)
            comm.Parameters.Add("@nameinput1got", SqlDbType.VarChar).Value = nameL1Input.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                codeL1Got = (reader(0).ToString) 'Load Code from table
                codeL1Input.Text = codeL1Got
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadRecordsAll()
        Call clearAll()
        codeInput.ReadOnly = True
        nameInput.ReadOnly = True
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L2controlAc WHERE L1groupAcID = '" & codeL1Got & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                listShowAll.SubItems.Add(nameL1Input.Text) ' Load Name from table L1

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
            l1InputVal1 = codeInput.Text.Substring(0, 2)
        End If
        If codeInput.Text = "" Then
            MsgBox("Please Enter a Valid Code")
            codeInput.Focus()
        ElseIf codeInput.Text < 1001 Then
            MsgBox("Please Enter a Valid Code (1001 to 9999)")
            codeInput.Focus()
        ElseIf l1InputVal1 <> codeL1Got Then
            MsgBox("Please Enter a Valid Code (Begining with Group Code i.e " & codeL1Got & ")")
            codeInput.Focus()
        ElseIf nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        Else
            Dim input1 As Integer = codeInput.Text
            Dim input2 As String = nameInput.Text
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM L2controlAc WHERE L2controlAcID = @input1got OR L2controlAcName = @input2got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    valcommand1.Parameters.Add("@input2got", SqlDbType.VarChar).Value = nameInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO L2controlAc(L2controlAcID, L2controlAcName, L1groupAcID) VALUES ('" & codeInput.Text & "' , '" & nameInput.Text & "' , '" & codeL1Got & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        Call clearAll()
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call clearAll()
                        codeInput.ReadOnly = True
                        nameInput.ReadOnly = True
                        'Reload records on new entry
                        Call loadRecordsAll()
                    Else
                        MsgBox("Record already exist!")
                    End If
                    conn.Close()
                ElseIf saveType = "update" Then
                    'Update existing record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("UPDATE L2controlAc SET L2controlAcName = '" & nameInput.Text & "' WHERE L2controlAcID = '" & codeInput.Text & "' ", conn)
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
        saveType = "new"
        codeInput.Focus()
        codeInput.Text = codeL1Got
        codeInput.SelectionStart = codeInput.Text.Length + 1
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        codeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
        codeInput.ReadOnly = True
        nameInput.ReadOnly = False
        nameInput.Focus()
        nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        saveType = "update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Validation for child records in Level 3
        Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
        Dim valadapter1 As New SqlDataAdapter(valcommand1)
        Dim valtable1 As New DataTable()
        valadapter1.Fill(valtable1)
        If valtable1.Rows.Count() <= 0 Then
            Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
            If delresponse = MsgBoxResult.Yes Then
                comm = New SqlCommand("DELETE FROM L2controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
                affector = comm.ExecuteNonQuery
                Call clearAll()
                MessageBox.Show("Record Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                saveType = ""
                'Reload records on new entry
                Call loadRecordsAll()
            Else
                Call loadRecordsAll()
            End If
        Else
            MsgBox("Access Denied! Please Delete Linked Records First.")
        End If
        conn.Close()
    End Sub
End Class