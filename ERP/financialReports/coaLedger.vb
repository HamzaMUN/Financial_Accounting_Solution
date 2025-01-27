Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class coaLedger
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim listShowAll As ListViewItem
    Public Property fiscalYearIDGot As Integer

    Private Sub coaLedger_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
        Call loadRecordsAll()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim l3AcCodeGot As Integer = ListView1.FocusedItem.SubItems.Item(0).Text
            Dim startDate, endDate As String
            startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
            endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
            coaLedgerPrint.startDate = startDate
            coaLedgerPrint.endDate = endDate
            coaLedgerPrint.l3AcId = l3AcCodeGot
            coaLedgerPrint.opBalGot = calcOpBal(l3AcCodeGot)
            coaLedgerPrint.fiscalYearIDGot = fiscalYearIDGot
            coaLedgerPrint.Show()
        End If
    End Sub

    Private Sub btnBalance_Click(sender As System.Object, e As System.EventArgs) Handles btnBalance.Click
        Call calcBal()
    End Sub

    Private Sub searchInput_TextChanged(sender As System.Object, e As System.EventArgs) Handles searchInput.TextChanged
        Call loadRecordsAll()
    End Sub

    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand(" SELECT * FROM L3controlAc WHERE acStatus = 'A' AND (L3controlAcName = '" & searchInput.Text & "' OR L3controlAcID LIKE '%" & searchInput.Text & "%' OR L3controlAcName LIKE '%" & searchInput.Text & "%') ORDER BY L3controlAcID ASC", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString)
                listShowAll.SubItems.Add(reader(1).ToString)
                listShowAll.SubItems.Add(reader(2).ToString)
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub loadDate()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "'", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                startDateInput.Value = (reader(2).ToString)
                endDateInput.Value = (reader(3).ToString)
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub calcBal()
        If ListView1.SelectedItems.Count > 0 Then
            Dim l3AcCodeGot As Integer = ListView1.FocusedItem.SubItems.Item(0).Text
            Dim openingBalGot As Double = calcOpBal(l3AcCodeGot)
            openingBalOutput.Text = openingBalGot
            Dim debitActivityGot As Double = calcDrActivity(l3AcCodeGot)
            drActivityOutput.Text = debitActivityGot
            Dim creditActivityGot As Double = calcCrActivity(l3AcCodeGot)
            crActivityOutput.Text = creditActivityGot
            Dim closingBalGot As Double = 0.0
                closingBalGot = openingBalGot + debitActivityGot - creditActivityGot
            closingBalOutput.Text = closingBalGot
        End If
    End Sub

    Private Function calcOpBal(ByVal l3AcIdGot) As Double
        Dim drOpGot, crOpGot, opBalGot As Double
        Dim startDate As String = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = '" & l3AcIdGot & "' AND VRDate < '" & startDate & "' ", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                drOpGot = CDbl(Val((reader(0)).ToString))
                crOpGot = CDbl(Val((reader(1)).ToString))
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        opBalGot = drOpGot - crOpGot
        Return opBalGot
    End Function

    Private Function calcDrActivity(ByVal l3AcIdGot) As Double
        Dim DrBalGot As Double = 0.0
        Dim startDate, endDate As String
        startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit FROM voucherDetails WHERE VrAcID = '" & l3AcIdGot & "' AND VRDate >= '" & startDate & "' AND VRDate <= '" & endDate & "' ", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                DrBalGot = CDbl(Val((reader(0)).ToString))
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return DrBalGot
    End Function

    Private Function calcCrActivity(ByVal l3AcIdGot) As Double
        Dim crBalGot As Double = 0.0
        Dim startDate, endDate As String
        startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = '" & l3AcIdGot & "' AND VRDate >= '" & startDate & "' AND VRDate <= '" & endDate & "' ", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                crBalGot = CDbl(Val((reader(0)).ToString))
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return crBalGot
    End Function

End Class