Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class acAssign
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim reader3 As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeL3Got As Integer
    Dim nameL3Got As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim subIDGot As Integer
    Dim subNameGot As String
    Private Sub acAssign_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L3controlAc", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            coaNameInput.DataSource = table
            coaNameInput.DisplayMember = "L3controlAcName"
            coaNameInput.ValueMember = "L3controlAcID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT TOP 5 subsidiaryCatID, subsidiaryCatName FROM subsidiaryCategory ORDER BY subsidiaryCatID ASC", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            subLedgerInput.DataSource = table
            subLedgerInput.DisplayMember = "subsidiaryCatName"
            subLedgerInput.ValueMember = "subsidiaryCatID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub coaNameInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles coaNameInput.SelectedIndexChanged
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT L3controlAcID FROM L3controlAc WHERE L3controlAcName = @nameinput1got", conn)
            comm.Parameters.Add("@nameinput1got", SqlDbType.VarChar).Value = coaNameInput.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                codeL3Got = (reader(0).ToString) 'Load Code from table
                coaCodeInput.Text = codeL3Got
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadRecordsAll()
        Call clearAll()
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = '" & codeL3Got & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString)
                listShowAll.SubItems.Add(codeL3Got)
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT L3controlAcName FROM L3controlAc WHERE L3controlAcID = '" & codeL3Got & "'", conn)
                    reader2 = comm.ExecuteReader
                    Do While reader2.Read = True
                        nameL3Got = (reader2(0).ToString)
                    Loop
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                listShowAll.SubItems.Add(nameL3Got)
                subIDGot = (reader(2).ToString)
                listShowAll.SubItems.Add(subIDGot)
                Try
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("SELECT subsidiaryCatName FROM subsidiaryCategory WHERE subsidiaryCatID = '" & subIDGot & "'", conn)
                    reader3 = comm.ExecuteReader
                    Do While reader3.Read = True
                        subNameGot = (reader3(0).ToString)
                    Loop
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                listShowAll.SubItems.Add(subNameGot)
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
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                Dim valcommand1 As New SqlCommand("SELECT * FROM subsidiaryAssign WHERE L3controlAcID = @input1got AND subsidiaryCatID = @input2got", conn)
                valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeL3Got
                valcommand1.Parameters.Add("@input2got", SqlDbType.Int).Value = subLedgerInput.SelectedValue
                Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                    comm = New SqlCommand("INSERT INTO subsidiaryAssign(L3controlAcID, subsidiaryCatID) VALUES ('" & codeL3Got & "' , '" & subLedgerInput.SelectedValue & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        Call clearAll()
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                comm = New SqlCommand("UPDATE subsidiaryAssign SET L3controlAcID = '" & codeL3Got & "', subsidiaryCatID = '" & subLedgerInput.SelectedValue & "' WHERE subsidiaryAssignID = '" & codeGot & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call clearAll()
                    Call loadRecordsAll()
                    saveType = ""
                Else
                    MsgBox("Please Click New or Select Edit an Existing Record")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Call clearAll()
        saveType = "new"
        coaNameInput.Focus()
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        subLedgerInput.SelectedIndex = -1
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        subLedgerInput.Focus()
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        subLedgerInput.SelectedValue = ListView1.FocusedItem.SubItems.Item(3).Text
        saveType = "update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
        If delresponse = MsgBoxResult.Yes Then
            comm = New SqlCommand("DELETE FROM subsidiaryAssign WHERE subsidiaryAssignID = '" & codeGot & "' ", conn)
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
    End Sub
End Class