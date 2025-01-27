Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class productCategory
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim saveType As String
    Dim codeGot As Integer
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM productCategory ORDER BY productCatID", conn)
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

    Private Sub clearAll()
        'Clear Input Fields on Click New
        codeInput.Text = Nothing
        nameInput.Text = Nothing
    End Sub

    Private Sub productCategory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call loadRecordsAll()
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
        If nameInput.Text = "" Then
            MsgBox("Please Enter a Valid Name")
            nameInput.Focus()
        Else
            Try
                If saveType = "new" Then
                    'Save New Record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    'SQL Validation for duplicate record
                    Dim valcommand1 As New SqlCommand("SELECT * FROM productCategory WHERE productCatID = @input1got OR productCatName = @input2got", conn)
                    valcommand1.Parameters.Add("@input1got", SqlDbType.Int).Value = codeInput.Text
                    valcommand1.Parameters.Add("@input2got", SqlDbType.VarChar).Value = nameInput.Text
                    Dim valadapter1 As New SqlDataAdapter(valcommand1)
                    Dim valtable1 As New DataTable()
                    valadapter1.Fill(valtable1)
                    If valtable1.Rows.Count() <= 0 Then
                        comm = New SqlCommand("INSERT INTO productCategory(productCatID, productCatName) VALUES ('" & codeInput.Text & "', '" & nameInput.Text & "' )", conn)
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
                    Else
                        MsgBox("Record already exist!")
                    End If
                    conn.Close()
                ElseIf saveType = "update" Then
                    'Update existing record
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("UPDATE productCategory SET productCatID = '" & codeInput.Text & "', productCatName = '" & nameInput.Text & "' WHERE productCatID = '" & codeInput.Text & "' ", conn)
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

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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
        'SQL Validation for child records in Level 2
        Dim valcommand1 As New SqlCommand("SELECT * FROM productDetail WHERE productCatID = '" & codeGot & "' ", conn)
        Dim valadapter1 As New SqlDataAdapter(valcommand1)
        Dim valtable1 As New DataTable()
        valadapter1.Fill(valtable1)
        If valtable1.Rows.Count() <= 0 Then
            Dim delresponse = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "Delete Record")
            If delresponse = MsgBoxResult.Yes Then
                comm = New SqlCommand("DELETE FROM productCategory WHERE productCatID = '" & codeGot & "' ", conn)
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
        Else
            MsgBox("Access Denied! Please Delete Linked Records First.")
        End If
    End Sub

End Class