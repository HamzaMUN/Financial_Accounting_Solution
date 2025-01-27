Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class searchEmployee
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
    Public Property lcSupplierValGot As Integer
    Public Property costCentreValGot As Integer
    Public Property searchKeywordGot As String
    Public Property parentFormGot As String
    Private Sub searchemployee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If searchKeywordGot = "" Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & 3 & "' ", conn)
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
                comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerName ='" & searchKeywordGot & "'OR subsidiaryLedgerID LIKE '%" & searchKeywordGot & "%' OR subsidiaryLedgerName LIKE '%" & searchKeywordGot & "%' AND subsidiaryCategoryID = '" & 3 & "' ", conn)
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
                jv.employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                jv.employeeNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                jv.VREmployeeGot = "yes"
                If lcSupplierValGot = 1 Then
                    jv.lcSupplierCodeInput.ReadOnly = False
                    jv.lcSupplierCodeInput.Focus()
                ElseIf costCentreValGot = 1 Then
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
                jv.employeeCodeInput.Focus()
                jv.employeeCodeInput.Text = Nothing
                jv.employeeNameInput.Text = Nothing
                jv.Activate()
            End If
        ElseIf parentFormGot = "brv" Then
            If e.KeyCode = Keys.Enter Then
                brv.employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                brv.employeeNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                brv.VREmployeeGot = "yes"
                If lcSupplierValGot = 1 Then
                    brv.lcSupplierCodeInput.ReadOnly = False
                    brv.lcSupplierCodeInput.Focus()
                ElseIf costCentreValGot = 1 Then
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
                brv.employeeCodeInput.Focus()
                brv.employeeCodeInput.Text = Nothing
                brv.employeeNameInput.Text = Nothing
                brv.Activate()
            End If
        ElseIf parentFormGot = "bpv" Then
            If e.KeyCode = Keys.Enter Then
                bpv.employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                bpv.employeeNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                bpv.VREmployeeGot = "yes"
                If lcSupplierValGot = 1 Then
                    bpv.lcSupplierCodeInput.ReadOnly = False
                    bpv.lcSupplierCodeInput.Focus()
                ElseIf costCentreValGot = 1 Then
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
                bpv.employeeCodeInput.Focus()
                bpv.employeeCodeInput.Text = Nothing
                bpv.employeeNameInput.Text = Nothing
                bpv.Activate()
            End If
        ElseIf parentFormGot = "crv" Then
            If e.KeyCode = Keys.Enter Then
                crv.employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                crv.employeeNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                crv.VREmployeeGot = "yes"
                If lcSupplierValGot = 1 Then
                    crv.lcSupplierCodeInput.ReadOnly = False
                    crv.lcSupplierCodeInput.Focus()
                ElseIf costCentreValGot = 1 Then
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
                crv.employeeCodeInput.Focus()
                crv.employeeCodeInput.Text = Nothing
                crv.employeeNameInput.Text = Nothing
                crv.Activate()
            End If
        ElseIf parentFormGot = "cpv" Then
            If e.KeyCode = Keys.Enter Then
                cpv.employeeCodeInput.Text = ListView1.FocusedItem.SubItems.Item(0).Text
                cpv.employeeNameInput.Text = ListView1.FocusedItem.SubItems.Item(1).Text
                cpv.VREmployeeGot = "yes"
                If lcSupplierValGot = 1 Then
                    cpv.lcSupplierCodeInput.ReadOnly = False
                    cpv.lcSupplierCodeInput.Focus()
                ElseIf costCentreValGot = 1 Then
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
                cpv.employeeCodeInput.Focus()
                cpv.employeeCodeInput.Text = Nothing
                cpv.employeeNameInput.Text = Nothing
                cpv.Activate()
            End If
        Else
        End If
    End Sub

    Private Sub searchEmployee_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class