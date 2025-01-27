Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration

Public Class acL1
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim saveType As String
    Dim codeGot As Integer
    Dim classConv As String
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM L1groupAc ORDER BY L1groupAcID ASC", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                Dim classGot As Integer = reader(2).ToString
                If classGot = 1 Then
                    classConv = "ASSET"
                ElseIf classGot = 2 Then
                    classConv = "LIABILITY"
                ElseIf classGot = 3 Then
                    classConv = "CAPITAL"
                ElseIf classGot = 4 Then
                    classConv = "INCOME"
                ElseIf classGot = 5 Then
                    classConv = "EXPENSE"
                End If
                listShowAll.SubItems.Add(classConv) ' Load Class from table
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
        classInput.Text = Nothing
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        SaveToolStripMenuItem.PerformClick()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Call clearAll()
        codeInput.ReadOnly = False
        nameInput.ReadOnly = False
        saveType = "new"
        codeInput.Focus()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveToolStripMenuItem.Click
        If codeInput.Text = "" Then
            MsgBox("Please Enter a Valid Code")
            codeInput.Focus()
        ElseIf codeInput.Text < 10 Then
            MsgBox("Please Enter a Valid Code (10 to 99)")
            codeInput.Focus()
        ElseIf nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        ElseIf classInput.Text = "" Then
            MsgBox("Please Select a Valid Class")
            classInput.Focus()
        Else
            Dim input1 As Integer = codeInput.Text
            Dim input2 As String = nameInput.Text
            Dim input3 As String = classInput.Text
            Dim input3c As Integer
            If input3 = "ASSET" Then
                input3c = 1
            ElseIf input3 = "LIABILITY" Then
                input3c = 2
            ElseIf input3 = "CAPITAL" Then
                input3c = 3
            ElseIf input3 = "INCOME" Then
                input3c = 4
            ElseIf input3 = "EXPENSE" Then
                input3c = 5
            End If
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM L1groupAc WHERE L1groupAcID = @input1got OR L1groupAcName = @input2got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    valcommand1.Parameters.Add("@input2got", SqlDbType.VarChar).Value = nameInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO L1groupAc(L1groupAcID, L1groupAcName, L1acHeadID) VALUES ('" & codeInput.Text & "' , '" & nameInput.Text & "' , '" & input3c & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        Call clearAll()
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        saveType = "new"
                        codeInput.Focus()
                        'Reload records on new entry
                        Call loadRecordsAll()
                        saveType = ""
                        codeInput.ReadOnly = True
                        nameInput.ReadOnly = True
                        conn.Close()
                    Else
                        MsgBox("Record already exist!")
                    End If
                ElseIf saveType = "update" Then
                    'Update existing record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("UPDATE L1groupAc SET L1groupAcName = '" & nameInput.Text & "', L1acHeadID = '" & input3c & "' WHERE L1groupAcID = '" & codeInput.Text & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call clearAll()
                    Call loadRecordsAll()
                    saveType = ""
                    codeInput.ReadOnly = True
                    nameInput.ReadOnly = True
                    conn.Close()
                Else
                    MsgBox("Please Click New or Select Edit an Existing Record")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        codeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
        codeInput.ReadOnly = True
        nameInput.ReadOnly = False
        nameInput.Focus()
        nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        classInput.Text = ListView1.FocusedItem.SubItems.Item(2).Text
        saveType = "update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Validation for child records in Level 2
        Dim valcommand1 As New SqlCommand("SELECT * FROM L2controlAc WHERE L1groupAcID = '" & codeGot & "' ", conn)
        Dim valadapter1 As New SqlDataAdapter(valcommand1)
        Dim valtable1 As New DataTable()
        valadapter1.Fill(valtable1)
        If valtable1.Rows.Count() <= 0 Then
            Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
            If delresponse = MsgBoxResult.Yes Then
                comm = New SqlCommand("DELETE FROM L1groupAc WHERE L1groupAcID = '" & codeGot & "' ", conn)
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

    Private Sub acL1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadRecordsAll()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class