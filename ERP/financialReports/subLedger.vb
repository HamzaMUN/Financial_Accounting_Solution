Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class subLedger
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

    Private Sub subLedger_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
        Call loadSubCategory()
        Call loadRecordsAll()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim acCodeSelected As Integer = ListView1.FocusedItem.SubItems.Item(0).Text
            Dim startDate, endDate As String
            startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
            endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
            Dim subCatTypeIdGot As Integer = Val(acCodeSelected.ToString.Substring(0, 1))
            If subCatTypeIdGot = 1 Then
                subLedgerPrint1.startDate = startDate
                subLedgerPrint1.endDate = endDate
                subLedgerPrint1.acCodeGot = acCodeSelected
                subLedgerPrint1.opBalGot = calcOpBal(acCodeSelected)
                subLedgerPrint1.fiscalYearIDGot = fiscalYearIDGot
                subLedgerPrint1.Show()
            ElseIf subCatTypeIdGot = 2 Then
                subLedgerPrint2.startDate = startDate
                subLedgerPrint2.endDate = endDate
                subLedgerPrint2.acCodeGot = acCodeSelected
                subLedgerPrint2.opBalGot = calcOpBal(acCodeSelected)
                subLedgerPrint2.fiscalYearIDGot = fiscalYearIDGot
                subLedgerPrint2.Show()
            ElseIf subCatTypeIdGot = 3 Then
                subLedgerPrint3.startDate = startDate
                subLedgerPrint3.endDate = endDate
                subLedgerPrint3.acCodeGot = acCodeSelected
                subLedgerPrint3.opBalGot = calcOpBal(acCodeSelected)
                subLedgerPrint3.fiscalYearIDGot = fiscalYearIDGot
                subLedgerPrint3.Show()
            ElseIf subCatTypeIdGot = 4 Then
                subLedgerPrint4.startDate = startDate
                subLedgerPrint4.endDate = endDate
                subLedgerPrint4.acCodeGot = acCodeSelected
                subLedgerPrint4.opBalGot = calcOpBal(acCodeSelected)
                subLedgerPrint4.fiscalYearIDGot = fiscalYearIDGot
                subLedgerPrint4.Show()
            ElseIf subCatTypeIdGot = 5 Then
                subLedgerPrint5.startDate = startDate
                subLedgerPrint5.endDate = endDate
                subLedgerPrint5.acCodeGot = acCodeSelected
                subLedgerPrint5.opBalGot = calcOpBal(acCodeSelected)
                subLedgerPrint5.fiscalYearIDGot = fiscalYearIDGot
                subLedgerPrint5.Show()
            End If
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
            Dim subCatIdGot As Integer = subCategory.SelectedIndex + 1
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand(" SELECT * FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & subCatIdGot & "' AND (subsidiaryLedgerID LIKE '%" & searchInput.Text & "%' OR subsidiaryLedgerName LIKE '%" & searchInput.Text & "%' OR subsidiaryLedgerName = '" & searchInput.Text & "') ORDER BY subsidiaryLedgerID ASC", conn)
            reader = comm.ExecuteReader
            'clear list before loading records
            ListView1.Items.Clear()
            Do While reader.Read = True 'Loop to load data realtime
                listShowAll = ListView1.Items.Add(reader(0).ToString)
                listShowAll.SubItems.Add(reader(1).ToString)
                Dim subCatIdGot1 As Integer = (reader(2).ToString)
                Dim subCatNameGot1 As String = ""
                If subCatIdGot1 = 1 Then
                    subCatNameGot1 = "Customers"
                ElseIf subCatIdGot1 = 2 Then
                    subCatNameGot1 = "Suppliers"
                ElseIf subCatIdGot1 = 3 Then
                    subCatNameGot1 = "Employees"
                ElseIf subCatIdGot1 = 4 Then
                    subCatNameGot1 = "LC Suppliers"
                ElseIf subCatIdGot1 = 5 Then
                    subCatNameGot1 = "Cost Centres"
                End If
                listShowAll.SubItems.Add(subCatNameGot1)
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

    Private Sub loadSubCategory()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT TOP 5 subsidiaryCatID, subsidiaryCatName FROM subsidiaryCategory ORDER BY subsidiaryCatID ASC", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            subCategory.DataSource = table
            subCategory.DisplayMember = "subsidiaryCatName"
            subCategory.ValueMember = "subsidiaryCatID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub calcBal()
        If ListView1.SelectedItems.Count > 0 Then
            Dim acCodeSelected As Integer = ListView1.FocusedItem.SubItems.Item(0).Text
            Dim openingBalGot As Double = calcOpBal(acCodeSelected)
            openingBalOutput.Text = openingBalGot
            Dim debitActivityGot As Double = calcDrActivity(acCodeSelected)
            drActivityOutput.Text = debitActivityGot
            Dim creditActivityGot As Double = calcCrActivity(acCodeSelected)
            crActivityOutput.Text = creditActivityGot
            Dim closingBalGot As Double = 0.0
            closingBalGot = openingBalGot + debitActivityGot - creditActivityGot
            closingBalOutput.Text = closingBalGot
        End If
    End Sub

    Private Function calcOpBal(ByVal acCodeGot) As Double
        Dim drOpGot, crOpGot, opBalGot As Double
        Dim subCatTypeIdGot As Integer = Val(acCodeGot.ToString.Substring(0, 1))
        Dim subCatTypeGot As String = ""
        If subCatTypeIdGot = 1 Then
            subCatTypeGot = "VRCustomer"
        ElseIf subCatTypeIdGot = 2 Then
            subCatTypeGot = "VRSupplier"
        ElseIf subCatTypeIdGot = 3 Then
            subCatTypeGot = "VREmployee"
        ElseIf subCatTypeIdGot = 4 Then
            subCatTypeGot = "VRLCSupplier"
        ElseIf subCatTypeIdGot = 5 Then
            subCatTypeGot = "VRCostCentre"
        End If
        Dim startDate As String = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            Dim commString As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE " & subCatTypeGot & " = " & acCodeGot & " AND VRDate < '" & startDate & "' "
            comm = New SqlCommand(commString, conn)
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

    Private Function calcDrActivity(ByVal acCodeGot) As Double
        Dim DrBalGot As Double = 0.0
        Dim startDate, endDate As String
        startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
        Dim subCatTypeIdGot As Integer = Val(acCodeGot.ToString.Substring(0, 1))
        Dim subCatTypeGot As String = ""
        If subCatTypeIdGot = 1 Then
            subCatTypeGot = "VRCustomer"
        ElseIf subCatTypeIdGot = 2 Then
            subCatTypeGot = "VRSupplier"
        ElseIf subCatTypeIdGot = 3 Then
            subCatTypeGot = "VREmployee"
        ElseIf subCatTypeIdGot = 4 Then
            subCatTypeGot = "VRLCSupplier"
        ElseIf subCatTypeIdGot = 5 Then
            subCatTypeGot = "VRCostCentre"
        End If
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            Dim commString As String = "SELECT SUM(voucherDebit) AS vrDebit FROM voucherDetails WHERE " & subCatTypeGot & " = " & acCodeGot & "  AND VRDate >= '" & startDate & "' AND VRDate <= '" & endDate & "' "
            comm = New SqlCommand(commString, conn)
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

    Private Function calcCrActivity(ByVal acCodeGot) As Double
        Dim crBalGot As Double = 0.0
        Dim startDate, endDate As String
        startDate = String.Format("{0:yyyy-MM-dd}", startDateInput.Value)
        endDate = String.Format("{0:yyyy-MM-dd}", endDateInput.Value)
        Dim subCatTypeIdGot As Integer = Val(acCodeGot.ToString.Substring(0, 1))
        Dim subCatTypeGot As String = ""
        If subCatTypeIdGot = 1 Then
            subCatTypeGot = "VRCustomer"
        ElseIf subCatTypeIdGot = 2 Then
            subCatTypeGot = "VRSupplier"
        ElseIf subCatTypeIdGot = 3 Then
            subCatTypeGot = "VREmployee"
        ElseIf subCatTypeIdGot = 4 Then
            subCatTypeGot = "VRLCSupplier"
        ElseIf subCatTypeIdGot = 5 Then
            subCatTypeGot = "VRCostCentre"
        End If
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            Dim commString As String = "SELECT SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE " & subCatTypeGot & " = " & acCodeGot & "  AND VRDate >= '" & startDate & "' AND VRDate <= '" & endDate & "' "
            comm = New SqlCommand(commString, conn)
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

    Private Sub subCategory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles subCategory.SelectedIndexChanged
        openingBalOutput.Text = Nothing
        drActivityOutput.Text = Nothing
        crActivityOutput.Text = Nothing
        closingBalOutput.Text = Nothing
        Call loadRecordsAll()
    End Sub
End Class