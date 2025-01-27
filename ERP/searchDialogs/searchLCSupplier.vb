Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchLCSupplier
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
    Public Property costCentreValGot As Integer
    Public Property searchKeywordGot As String
    Public Property parentFormGot As String
    Private Sub searchlcSupplier_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If searchKeywordGot = "" Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & 4 & "' ", conn)
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
        Else
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerName ='" & searchKeywordGot & "'OR subsidiaryLedgerID LIKE '%" & searchKeywordGot & "%' OR subsidiaryLedgerName LIKE '%" & searchKeywordGot & "%' AND subsidiaryCategoryID = '" & 4 & "' ", conn)
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
        End If

    End Sub
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ListView1.KeyDown
        If parentFormGot = "jv" Then
            If e.KeyCode = Keys.Enter Then
                jv.lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                jv.lcSupplierNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                jv.VRlcSupplierGot = "yes"
                If costCentreValGot = 1 Then
                    jv.costCentreCodeInput.ReadOnly = False
                    jv.costCentreCodeInput.Focus()
                Else
                    jv.narrationFocusGot = "yes"
                    jv.narrationInput.ReadOnly = False
                    jv.narrationInput.Focus()
                End If
                jv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                jv.lcSupplierCodeInput.Focus()
                jv.lcSupplierCodeInput.Text = Nothing
                jv.lcSupplierNameInput.Text = Nothing
                jv.Activate()
            End If
        ElseIf parentFormGot = "brv" Then
            If e.KeyCode = Keys.Enter Then
                brv.lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                brv.lcSupplierNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                brv.VRLCSupplierGot = "yes"
                If costCentreValGot = 1 Then
                    brv.costCentreCodeInput.ReadOnly = False
                    brv.costCentreCodeInput.Focus()
                Else
                    brv.narrationFocusGot = "yes"
                    brv.narrationInput.ReadOnly = False
                    brv.narrationInput.Focus()
                End If
                brv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                brv.lcSupplierCodeInput.Focus()
                brv.lcSupplierCodeInput.Text = Nothing
                brv.lcSupplierNameInput.Text = Nothing
                brv.Activate()
            End If
        ElseIf parentFormGot = "bpv" Then
            If e.KeyCode = Keys.Enter Then
                bpv.lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                bpv.lcSupplierNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                bpv.VRLCSupplierGot = "yes"
                If costCentreValGot = 1 Then
                    bpv.costCentreCodeInput.ReadOnly = False
                    bpv.costCentreCodeInput.Focus()
                Else
                    bpv.narrationFocusGot = "yes"
                    bpv.narrationInput.ReadOnly = False
                    bpv.narrationInput.Focus()
                End If
                bpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                bpv.lcSupplierCodeInput.Focus()
                bpv.lcSupplierCodeInput.Text = Nothing
                bpv.lcSupplierNameInput.Text = Nothing
                bpv.Activate()
            End If
        ElseIf parentFormGot = "crv" Then
            If e.KeyCode = Keys.Enter Then
                crv.lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                crv.lcSupplierNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                crv.VRLCSupplierGot = "yes"
                If costCentreValGot = 1 Then
                    crv.costCentreCodeInput.ReadOnly = False
                    crv.costCentreCodeInput.Focus()
                Else
                    crv.narrationFocusGot = "yes"
                    crv.narrationInput.ReadOnly = False
                    crv.narrationInput.Focus()
                End If
                crv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                crv.lcSupplierCodeInput.Focus()
                crv.lcSupplierCodeInput.Text = Nothing
                crv.lcSupplierNameInput.Text = Nothing
                crv.Activate()
            End If
        ElseIf parentFormGot = "cpv" Then
            If e.KeyCode = Keys.Enter Then
                cpv.lcSupplierCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                cpv.lcSupplierNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                cpv.VRLCSupplierGot = "yes"
                If costCentreValGot = 1 Then
                    cpv.costCentreCodeInput.ReadOnly = False
                    cpv.costCentreCodeInput.Focus()
                Else
                    cpv.narrationFocusGot = "yes"
                    cpv.narrationInput.ReadOnly = False
                    cpv.narrationInput.Focus()
                End If
                cpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                cpv.lcSupplierCodeInput.Focus()
                cpv.lcSupplierCodeInput.Text = Nothing
                cpv.lcSupplierNameInput.Text = Nothing
                cpv.Activate()
            End If
            'ElseIf parentFormGot = "grn" Then
            '    If e.KeyCode = Keys.Enter Then
            '        grn.partyIDInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
            '        grn.partyNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            '        grn.remarksFocusGot = "yes"
            '        grn.remarksInput.ReadOnly = False
            '        grn.remarksInput.Focus()
            '        grn.Activate()
            '        Me.Close()
            '    ElseIf e.KeyCode = Keys.Escape Then
            '        Me.Close()
            '        grn.partyIDInput.Focus()
            '        grn.remarksFocusGot = Nothing
            '        grn.partyIDInput.Text = Nothing
            '        grn.partyNameInput.Text = Nothing
            '        grn.Activate()
            '    End If
            'ElseIf parentFormGot = "prn" Then
            '    If e.KeyCode = Keys.Enter Then
            '        storeOutward.partyIDInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
            '        storeOutward.partyNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
            '        storeOutward.remarksFocusGot = "yes"
            '        storeOutward.remarksInput.ReadOnly = False
            '        storeOutward.remarksInput.Focus()
            '        storeOutward.Activate()
            '        Me.Close()
            'ElseIf e.KeyCode = Keys.Escape Then
            '    Me.Close()
            '    storeOutward.partyIDInput.Focus()
            '    storeOutward.remarksFocusGot = Nothing
            '    storeOutward.partyIDInput.Text = Nothing
            '    storeOutward.partyNameInput.Text = Nothing
            '    storeOutward.Activate()
            'End If
        Else
        End If
    End Sub
    Private Sub searchLCSupplier_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class