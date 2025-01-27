'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlDataAdapter
'Imports System.Configuration
Public Class searchGRN
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
    'Public Property parentFormGot As String
    'Public Property fiscalYearIDGot As Integer
    'Public Property userNameGot As String
    'Dim masterVoucherID As Integer
    'Dim voucherNoGot As Integer
    'Dim todaysDate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)

    'Private Sub searchGRN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        conn = New SqlConnection(constr)
    '        conn.Open()
    '        comm = New SqlCommand("SELECT * FROM voucherMaster WHERE VRStatus = @input1got AND fiscalYear = @input2got AND VRType = @input3got ORDER BY VRMasterID ASC", conn)
    '        comm.Parameters.Add("@input1got", SqlDbType.VarChar).Value = "C"
    '        comm.Parameters.Add("@input2got", SqlDbType.Int).Value = fiscalYearIDGot
    '        comm.Parameters.Add("@input3got", SqlDbType.VarChar).Value = "GRN"
    '        reader = comm.ExecuteReader
    '        'clear list before loading records
    '        ListView1.Items.Clear()
    '        Do While reader.Read = True 'Loop to load data realtime
    '            listShowAll = ListView1.Items.Add(reader(0).ToString)
    '            listShowAll.SubItems.Add(reader(4).ToString)
    '            Dim partyIDGot As Integer = reader(15).ToString
    '            Dim partyCatIDGot As Integer = reader(16).ToString
    '            Try
    '                conn = New SqlConnection(constr)
    '                conn.Open()
    '                comm = New SqlCommand("SELECT subsidiaryLedgerName FROM subsidiaryLedger WHERE subsidiaryCategoryID = @input1got AND subsidiaryLedgerID = @input2got ", conn)
    '                comm.Parameters.Add("@input1got", SqlDbType.Int).Value = partyCatIDGot
    '                comm.Parameters.Add("@input2got", SqlDbType.Int).Value = partyIDGot
    '                reader2 = comm.ExecuteReader
    '                Do While reader2.Read = True
    '                    listShowAll.SubItems.Add(reader2(0).ToString)
    '                Loop
    '                reader2.Close()
    '                conn.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End Try
    '        Loop
    '        reader.Close()
    '        conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
    '    If parentFormGot = "pjv" Then
    '        If e.KeyCode = Keys.Enter Then
    '            If ListView1.SelectedItems.Count > 0 Then
    '                masterVoucherID = ListView1.FocusedItem.SubItems.Item(0).Text
    '                voucherNoGot = ListView1.FocusedItem.SubItems.Item(1).Text
    '                Try
    '                    conn = New SqlConnection(constr)
    '                    conn.Open()
    '                    comm = New SqlCommand("UPDATE voucherMaster SET VRStatus = 'O', VRType = '" & "PJV" & "'  WHERE VRMasterID = '" & masterVoucherID & "' ", conn)
    '                    affector = comm.ExecuteNonQuery
    '                    comm = New SqlCommand("UPDATE Stock SET DocType = '" & "PJV" & "', Status = 'O', EditDate = '" & todaysDate & "', EditBy = '" & userNameGot & "' WHERE DocNo = " & voucherNoGot & " AND DocType = '" & "GRN" & "' AND FiscalYear = " & fiscalYearIDGot & " ", conn)
    '                    affector = comm.ExecuteNonQuery
    '                    MessageBox.Show("New Purchase Invoice Generated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Call purchaseInvoice.resetMaster()
    '                    Dim index As Integer = 0
    '                    purchaseInvoice.showData(index)
    '                    purchaseInvoice.ListView1.Focus()
    '                    purchaseInvoice.Activate()
    '                    Me.Close()
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End Try
    '            End If
    '        ElseIf e.KeyCode = Keys.Escape Then
    '            Me.Close()
    '            purchaseInvoice.btnNew.Focus()
    '            purchaseInvoice.Activate()
    '        End If
    '    End If
    'End Sub

    'Private Sub searchGRN_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    'End Sub
End Class