Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchProduct
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
    Public Property searchKeywordGot As String
    Public Property parentFormGot As String

    Private Sub searchProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If searchKeywordGot = "" Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM ProductDetail", conn)
                reader = comm.ExecuteReader
                'clear list before loading records
                ListView1.Items.Clear()
                Do While reader.Read = True 'Loop to load data realtime
                    listShowAll = ListView1.Items.Add(reader(1).ToString) 'Load Code from table
                    listShowAll.SubItems.Add(reader(2).ToString) ' Load Name from table
                Loop
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM ProductDetail WHERE productName ='" & searchKeywordGot & "'OR productID LIKE '%" & searchKeywordGot & "%' OR productName LIKE '%" & searchKeywordGot & "%'", conn)
                reader = comm.ExecuteReader
                'clear list before loading records
                ListView1.Items.Clear()
                Do While reader.Read = True 'Loop to load data realtime
                    listShowAll = ListView1.Items.Add(reader(1).ToString) 'Load Code from table
                    listShowAll.SubItems.Add(reader(2).ToString) ' Load Name from table
                Loop
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
        If parentFormGot = "batch" Then
            If e.KeyCode = Keys.Enter Then
                batch.productIDInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                batch.productNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                batch.manufacturingDateInput.Focus()
                batch.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                batch.productIDInput.Focus()
                batch.productIDInput.Text = Nothing
                batch.productNameInput.Text = Nothing
                batch.Activate()
            End If
            'ElseIf parentFormGot = "grn" Then
            '    If e.KeyCode = Keys.Enter Then
            '        grn.productIDInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
            '        grn.productNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            '        grn.batchFocusGot = "yes"
            '        grn.batchCodeInput.ReadOnly = False
            '        grn.batchCodeInput.Focus()
            '        Call grn.loadAvailableQuantity()
            '        grn.Activate()
            '        Me.Close()
            '    ElseIf e.KeyCode = Keys.Escape Then
            '        Me.Close()
            '        grn.productIDInput.Focus()
            '        grn.batchFocusGot = Nothing
            '        grn.productIDInput.Text = Nothing
            '        grn.productNameInput.Text = Nothing
            '        grn.Activate()
            '    End If
            'ElseIf parentFormGot = "prn" Then
            '    If e.KeyCode = Keys.Enter Then
            '        storeOutward.productIDInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
            '        storeOutward.productNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            '        storeOutward.batchFocusGot = "yes"
            '        storeOutward.batchCodeInput.ReadOnly = False
            '        storeOutward.batchCodeInput.Focus()
            '        Call storeOutward.loadAvailableQuantity()
            '        storeOutward.Activate()
            '        Me.Close()
            '    ElseIf e.KeyCode = Keys.Escape Then
            '        Me.Close()
            '        storeOutward.productIDInput.Focus()
            '        storeOutward.batchFocusGot = Nothing
            '        storeOutward.productIDInput.Text = Nothing
            '        storeOutward.productNameInput.Text = Nothing
            '        storeOutward.Activate()
            '    End If
        End If
    End Sub

    Private Sub searchProduct_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class