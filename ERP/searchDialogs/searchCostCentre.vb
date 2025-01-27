Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchCostCentre
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
    Private Sub searchcostCentre_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If searchKeywordGot = "" Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & 5 & "' ", conn)
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
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerName ='" & searchKeywordGot & "'OR subsidiaryLedgerID LIKE '%" & searchKeywordGot & "%' OR subsidiaryLedgerName LIKE '%" & searchKeywordGot & "%' AND subsidiaryCategoryID = '" & 5 & "' ", conn)
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
                jv.costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                jv.costCentreNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                jv.VRCostCentreGot = "yes"
                jv.narrationFocusGot = "yes"
                jv.narrationInput.ReadOnly = False
                jv.narrationInput.Focus()
                jv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                jv.costCentreCodeInput.Focus()
                jv.costCentreCodeInput.Text = Nothing
                jv.costCentreNameInput.Text = Nothing
                jv.Activate()
            End If
        ElseIf parentFormGot = "brv" Then
            If e.KeyCode = Keys.Enter Then
                brv.costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                brv.costCentreNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                brv.VRCostCentreGot = "yes"
                brv.narrationFocusGot = "yes"
                brv.narrationInput.ReadOnly = False
                brv.narrationInput.Focus()
                brv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                brv.costCentreCodeInput.Focus()
                brv.costCentreCodeInput.Text = Nothing
                brv.costCentreNameInput.Text = Nothing
                brv.Activate()
            End If
        ElseIf parentFormGot = "bpv" Then
            If e.KeyCode = Keys.Enter Then
                bpv.costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                bpv.costCentreNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                bpv.VRCostCentreGot = "yes"
                bpv.narrationFocusGot = "yes"
                bpv.narrationInput.ReadOnly = False
                bpv.narrationInput.Focus()
                bpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                bpv.costCentreCodeInput.Focus()
                bpv.costCentreCodeInput.Text = Nothing
                bpv.costCentreNameInput.Text = Nothing
                bpv.Activate()
            End If
        ElseIf parentFormGot = "crv" Then
            If e.KeyCode = Keys.Enter Then
                crv.costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                crv.costCentreNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                crv.VRCostCentreGot = "yes"
                crv.narrationFocusGot = "yes"
                crv.narrationInput.ReadOnly = False
                crv.narrationInput.Focus()
                crv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                crv.costCentreCodeInput.Focus()
                crv.costCentreCodeInput.Text = Nothing
                crv.costCentreNameInput.Text = Nothing
                crv.Activate()
            End If
        ElseIf parentFormGot = "cpv" Then
            If e.KeyCode = Keys.Enter Then
                cpv.costCentreCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                cpv.costCentreNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                cpv.VRCostCentreGot = "yes"
                cpv.narrationFocusGot = "yes"
                cpv.narrationInput.ReadOnly = False
                cpv.narrationInput.Focus()
                cpv.Activate()
                Me.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
                cpv.costCentreCodeInput.Focus()
                cpv.costCentreCodeInput.Text = Nothing
                cpv.costCentreNameInput.Text = Nothing
                cpv.Activate()
            End If
        Else
        End If
    End Sub
    Private Sub searchCostCentre_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class