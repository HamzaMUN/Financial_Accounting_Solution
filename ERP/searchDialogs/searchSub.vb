Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchSub
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
    Private Sub searchSub_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If searchKeywordGot = "" Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger ORDER BY subsidiaryLedgerID ASC", conn)
                reader = comm.ExecuteReader
                'clear list before loading records
                ListView1.Items.Clear()
                Do While reader.Read = True 'Loop to load data realtime
                    listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                    listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                    Dim subCatId As Integer = (reader(2).ToString)
                    If subCatId = 1 Then
                        listShowAll.SubItems.Add("Customer")
                    ElseIf subCatId = 2 Then
                        listShowAll.SubItems.Add("Supplier")
                    ElseIf subCatId = 3 Then
                        listShowAll.SubItems.Add("Employee")
                    ElseIf subCatId = 4 Then
                        listShowAll.SubItems.Add("LC Supplier")
                    ElseIf subCatId = 5 Then
                        listShowAll.SubItems.Add("Cost Center")
                    End If
                Loop
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerName ='" & searchKeywordGot & "'OR subsidiaryLedgerID LIKE '%" & searchKeywordGot & "%' OR subsidiaryLedgerName LIKE '%" & searchKeywordGot & "%' ORDER BY subsidiaryLedgerID ASC ", conn)
                reader = comm.ExecuteReader
                'clear list before loading records
                ListView1.Items.Clear()
                Do While reader.Read = True 'Loop to load data realtime
                    listShowAll = ListView1.Items.Add(reader(0).ToString) 'Load Code from table
                    listShowAll.SubItems.Add(reader(1).ToString) ' Load Name from table
                    Dim subCatId As Integer = (reader(2).ToString)
                    If subCatId = 1 Then
                        listShowAll.SubItems.Add("Customer")
                    ElseIf subCatId = 2 Then
                        listShowAll.SubItems.Add("Supplier")
                    ElseIf subCatId = 3 Then
                        listShowAll.SubItems.Add("Employee")
                    ElseIf subCatId = 4 Then
                        listShowAll.SubItems.Add("LC Supplier")
                    ElseIf subCatId = 5 Then
                        listShowAll.SubItems.Add("Cost Center")
                    End If
                Loop
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

    End Sub
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
        If parentFormGot = "coaWSubRange1" Then
            If e.KeyCode = Keys.Enter Then
                coaWSubLedger.subIDInput1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaWSubLedger.subNameInput1.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaWSubLedger.subIDInput2.Focus()
                coaWSubLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaWSubLedger.subIDInput1.Focus()
                coaWSubLedger.subIDInput1.Text = Nothing
                coaWSubLedger.subNameInput1.Text = Nothing
                coaWSubLedger.Activate()
            End If
        ElseIf parentFormGot = "coaWSubRange2" Then
            If e.KeyCode = Keys.Enter Then
                coaWSubLedger.subIDInput2.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                coaWSubLedger.subNameInput2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                coaWSubLedger.fromDate.Focus()
                coaWSubLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                coaWSubLedger.subIDInput2.Focus()
                coaWSubLedger.subIDInput2.Text = Nothing
                coaWSubLedger.subNameInput2.Text = Nothing
                coaWSubLedger.Activate()
            End If
        ElseIf parentFormGot = "subWCoaRange1" Then
            If e.KeyCode = Keys.Enter Then
                subWCoaLedger.subIDInput1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                subWCoaLedger.subNameInput1.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                subWCoaLedger.subIDInput2.Focus()
                subWCoaLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                subWCoaLedger.subIDInput1.Focus()
                subWCoaLedger.subIDInput1.Text = Nothing
                subWCoaLedger.subNameInput1.Text = Nothing
                subWCoaLedger.Activate()
            End If
        ElseIf parentFormGot = "subWCoaRange2" Then
            If e.KeyCode = Keys.Enter Then
                subWCoaLedger.subIDInput2.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                subWCoaLedger.subNameInput2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                subWCoaLedger.coaCodeInput1.Focus()
                subWCoaLedger.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                subWCoaLedger.subIDInput2.Focus()
                subWCoaLedger.subIDInput2.Text = Nothing
                subWCoaLedger.subNameInput2.Text = Nothing
                subWCoaLedger.Activate()
            End If
        Else
        End If
    End Sub
    Private Sub searchSub_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class