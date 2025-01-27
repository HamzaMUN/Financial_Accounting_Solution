Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class subArea
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeAreaGot As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim l1InputVal1 As Integer
    Private Sub acL2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM area", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            nameAreaInput.DataSource = table
            nameAreaInput.DisplayMember = "areaName"
            nameAreaInput.ValueMember = "areaID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub nameL1Input_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nameAreaInput.SelectedIndexChanged
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT areaID FROM area WHERE areaName = @nameinput1got", conn)
            comm.Parameters.Add("@nameinput1got", SqlDbType.VarChar).Value = nameAreaInput.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                codeAreaGot = (reader(0).ToString) 'Load Code from table
                codeAreaInput.Text = codeAreaGot
            Loop
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadRecordsAll()
        Call clearAll()
        nameInput.ReadOnly = True
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subArea WHERE areaID = '" & codeAreaGot & "'", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                listShowAll.SubItems.Add(nameAreaInput.Text) ' Load Name from table area

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
        If nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        Else
            Dim input2 As String = nameInput.Text
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM subArea WHERE subAreaName = @input1got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = nameInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO subArea(subAreaName, areaID) VALUES ('" & nameInput.Text & "' , '" & codeAreaGot & "' )", conn)
                        affector = comm.ExecuteNonQuery
                        Call clearAll()
                        MessageBox.Show("New Record has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call clearAll()
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
                    comm = New SqlCommand("UPDATE subArea SET subAreaName = '" & nameInput.Text & "' WHERE subAreaID = '" & codeGot & "' ", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call clearAll()
                    Call loadRecordsAll()
                    saveType = ""
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
        nameInput.ReadOnly = False
        saveType = "new"
        nameInput.Focus()
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        nameInput.Text = Nothing
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        nameInput.ReadOnly = False
        nameInput.Focus()
        nameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        saveType = "update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        codeGot = ListView1.FocusedItem.SubItems.Item(0).Text
        conn = New SqlConnection(constr)
        conn.Open()
        ''SQL Validation for child records
        'Dim valcommand1 As New SqlCommand("SELECT * FROM L3controlAc WHERE L2controlAcID = '" & codeGot & "' ", conn)
        'Dim valadapter1 As New SqlDataAdapter(valcommand1)
        'Dim valtable1 As New DataTable()
        'valadapter1.Fill(valtable1)
        'If valtable1.Rows.Count() <= 0 Then
        Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
        If delresponse = MsgBoxResult.Yes Then
            comm = New SqlCommand("DELETE FROM subArea WHERE subAreaID = '" & codeGot & "' ", conn)
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