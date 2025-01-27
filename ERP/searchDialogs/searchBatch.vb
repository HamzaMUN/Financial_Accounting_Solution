'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlDataAdapter
'Imports System.Configuration
Public Class searchBatch
    'Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    'Dim sqlconstr As SqlConnection = New SqlConnection
    'Dim conn As SqlConnection = New SqlConnection
    'Dim comm As SqlCommand = New SqlCommand
    'Dim adapter As New SqlDataAdapter
    'Dim table As New DataTable
    'Dim affector As Integer
    'Dim reader As SqlDataReader
    'Dim reader2 As SqlDataReader
    'Dim listShowAll As ListViewItem
    'Public Property searchKeywordGot As String
    'Public Property parentFormGot As String
    'Public Property productIDGot As Integer = 0

    'Private Sub searchBatch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    If searchKeywordGot = "" Then
    '        Try
    '            conn = New SqlConnection(constr)
    '            conn.Open()
    '            comm = New SqlCommand("SELECT * FROM batch WHERE productID = '" & productIDGot & "' AND  status = 'A' ", conn)
    '            reader = comm.ExecuteReader
    '            'clear list before loading records
    '            ListView1.Items.Clear()
    '            Do While reader.Read = True 'Loop to load data realtime
    '                listShowAll = ListView1.Items.Add(reader(1).ToString) 'Load Code from table
    '                listShowAll.SubItems.Add(reader(2).ToString) ' Load Name from table
    '            Loop
    '            conn.Close()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End Try
    '    Else
    '        Try
    '            conn = New SqlConnection(constr)
    '            conn.Open()
    '            comm = New SqlCommand("SELECT * FROM batch WHERE productID = '" & productIDGot & "' AND batchName ='" & searchKeywordGot & "' OR batchName LIKE '%" & searchKeywordGot & "%' AND status = 'A' ", conn)
    '            reader = comm.ExecuteReader
    '            'clear list before loading records
    '            ListView1.Items.Clear()
    '            Do While reader.Read = True 'Loop to load data realtime
    '                listShowAll = ListView1.Items.Add(reader(1).ToString) 'Load Code from table
    '                listShowAll.SubItems.Add(reader(2).ToString) ' Load Name from table
    '            Loop
    '            conn.Close()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End Try
    '    End If
    'End Sub

    'Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
    '    If parentFormGot = "grn" Then
    '        If e.KeyCode = Keys.Enter Then
    '            grn.batchCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
    '            grn.batchNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
    '            grn.qtyFocusGot = "yes"
    '            grn.qtyInput.ReadOnly = False
    '            grn.qtyInput.Text = 0
    '            grn.qtyInput.Focus()
    '            grn.Activate()
    '            Me.Close()
    '        ElseIf e.KeyCode = Keys.Escape Then
    '            Me.Close()
    '            grn.batchCodeInput.Focus()
    '            grn.qtyInput.ReadOnly = True
    '            grn.qtyInput.Text = Nothing
    '            grn.qtyFocusGot = Nothing
    '            grn.batchCodeInput.Text = Nothing
    '            grn.batchNameInput.Text = Nothing
    '            grn.Activate()
    '        End If
    '    ElseIf parentFormGot = "prn" Then
    '        If e.KeyCode = Keys.Enter Then
    '            storeOutward.batchCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
    '            storeOutward.batchNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
    '            storeOutward.qtyFocusGot = "yes"
    '            storeOutward.qtyInput.ReadOnly = False
    '            storeOutward.qtyInput.Text = 0
    '            storeOutward.qtyInput.Focus()
    '            storeOutward.Activate()
    '            Me.Close()
    '        ElseIf e.KeyCode = Keys.Escape Then
    '            Me.Close()
    '            storeOutward.batchCodeInput.Focus()
    '            storeOutward.qtyInput.ReadOnly = True
    '            storeOutward.qtyInput.Text = Nothing
    '            storeOutward.qtyFocusGot = Nothing
    '            storeOutward.batchCodeInput.Text = Nothing
    '            storeOutward.batchNameInput.Text = Nothing
    '            storeOutward.Activate()
    '        End If
    '    End If
    'End Sub

    'Private Sub searchBatch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    'End Sub
End Class