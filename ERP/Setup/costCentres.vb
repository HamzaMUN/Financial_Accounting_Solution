Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class costCentres
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeSubCatGot As String = 5
    Dim saveType As String
    Dim codeGot As Integer
    Dim l1InputVal1 As Integer
    Private Sub costCentres_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call loadRecordsAll()
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & 5 & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
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
            l1InputVal1 = codeInput.Text.Substring(0, 1)
        End If
        If codeInput.Text = "" Then
            MsgBox("Please Enter a Valid Code")
            codeInput.Focus()
        ElseIf codeInput.Text < 5001 Then
            MsgBox("Please Enter a Valid Code (5001 to 5999)")
            codeInput.Focus()
        ElseIf codeInput.Text > 5999 Then
            MsgBox("Please Enter a Valid Code (5001 to 5999)")
            codeInput.Focus()
        ElseIf l1InputVal1 <> codeSubCatGot Then
            MsgBox("Please Enter a Valid Code (Begining with Category Code i.e " & codeSubCatGot & ")")
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
                    Dim valcommand1 As New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerID = @input1got OR subsidiaryLedgerName = @input2got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    valcommand1.Parameters.Add("@input2got", SqlDbType.VarChar).Value = nameInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO subsidiaryLedger(subsidiaryLedgerID, subsidiaryLedgerName, subsidiaryCategoryID) VALUES ('" & codeInput.Text & "' , '" & nameInput.Text & "' , '" & codeSubCatGot & "' )", conn)
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
                    comm = New SqlCommand("UPDATE subsidiaryLedger SET subsidiaryLedgerName = '" & nameInput.Text & "' WHERE subsidiaryLedgerID = '" & codeInput.Text & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    Call clearAll()
                    Call loadRecordsAll()
                    saveType = ""
                    codeInput.ReadOnly = True
                    nameInput.ReadOnly = True
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
        codeInput.ReadOnly = False
        nameInput.ReadOnly = False
        saveType = "new"
        codeInput.Focus()
        codeInput.Text = codeSubCatGot
        codeInput.SelectionStart = codeInput.Text.Length + 1
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            codeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
            codeInput.ReadOnly = True
            nameInput.ReadOnly = False
            nameInput.Focus()
            nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            saveType = "update"
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Validation for child records in Level 3
        'Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
        'Dim valadapter1 As New SqlDataAdapter(valcommand1)
        'Dim valtable1 As New DataTable()
        'valadapter1.Fill(valtable1)
        'If valtable1.Rows.Count() <= 0 Then
        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
        If delresponse = MsgBoxResult.Yes Then
            comm = New SqlCommand("DELETE FROM subsidiaryLedger WHERE subsidiaryLedgerID = '" & codeGot & "' ", conn)
            affector = comm.ExecuteNonQuery
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
        conn.Close()
    End Sub
End Class