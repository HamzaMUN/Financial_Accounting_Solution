Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class subsidiaryActivity
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim conn As SqlConnection = New SqlConnection(constr)
    Dim conn2 As SqlConnection = New SqlConnection(constr)
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Public Property fiscalYearIDGot As Integer

    Private Sub subsidiaryActivity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
        Call loadSubCategory()
    End Sub

    Private Sub loadDate()
        Try
            conn.Open()
            comm = New SqlCommand("SELECT * FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "'", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                fromDate.Value = (reader(2).ToString)
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

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If chkPosted.Checked = True Then
            Call generateReportPosted(subCategory.SelectedValue)
        Else
            Call generateReport(subCategory.SelectedValue)
        End If
    End Sub

    Private Function generateReport(ByVal subCatID)
        Dim tblName As String = "rpt_subActivity" & subCatID
        Try
            conn.Open()
            Dim commStr As String = "DELETE FROM " & tblName
            comm = New SqlCommand(commStr, conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim endDateGot As Date = toDate.Value
        Dim endDateGotIncrement = endDateGot.AddDays(1)
        Dim endDate As String = String.Format("{0:yyyy-MM-dd}", endDateGotIncrement)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT subsidiaryLedgerID FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & subCatID & "' ORDER BY subsidiaryLedgerID ASC", conn)
            reader = comm.ExecuteReader
            Dim acIdGot As Integer
            Dim tblFieldName As String = ""
            If subCatID = 1 Then
                tblFieldName = "VRCustomer"
            ElseIf subCatID = 2 Then
                tblFieldName = "VRSupplier"
            ElseIf subCatID = 3 Then
                tblFieldName = "VREmployee"
            ElseIf subCatID = 4 Then
                tblFieldName = "VRLCSupplier"
            ElseIf subCatID = 5 Then
                tblFieldName = "VRCostCentre"
            End If
            Do While reader.Read = True 'Loop to load data realtime
                acIdGot = (reader(0).ToString)
                Dim DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing As Double
                DrOpening = 0
                CrOpening = 0
                DrActivity = 0
                CrActivity = 0
                DrClosing = 0
                CrClosing = 0
                Dim fromDateGot As String = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
                Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
                'Opening Balance
                Try
                    conn2.Open()
                    comm2 = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE " & tblFieldName & " = " & acIdGot & " AND VRDate < '" & fromDateGot & "' ", conn2)
                    reader2 = comm2.ExecuteReader
                    Dim opDebit, opCredit As Double
                    opDebit = 0
                    opCredit = 0
                    Do While reader2.Read = True 'Loop to load data realtime
                        opDebit = CDbl(Val((reader2(0)).ToString))
                        opCredit = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    If opDebit > opCredit Then
                        DrOpening = opDebit - opCredit
                        CrOpening = 0
                    ElseIf opDebit = opCredit Then
                        DrOpening = 0
                        CrOpening = 0
                    Else
                        DrOpening = 0
                        CrOpening = opCredit - opDebit
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                'Activity During the Year
                Try
                    conn2.Open()
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE " & tblFieldName & " = " & acIdGot & " AND (VRDate <= '" & toDateGot & "' AND VRDate >= '" & fromDateGot & "')"
                    comm2 = New SqlCommand(command2Str, conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True 'Loop to load data realtime
                        DrActivity = CDbl(Val((reader2(0)).ToString))
                        CrActivity = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    Dim netBal As Double = 0
                    netBal = DrOpening - CrOpening + DrActivity - CrActivity
                    If netBal > 0 Then
                        DrClosing = DrOpening - CrOpening + DrActivity - CrActivity
                        CrClosing = 0
                    ElseIf netBal = 0 Then
                        DrClosing = 0
                        CrClosing = 0
                    Else
                        DrClosing = 0
                        CrClosing = CrOpening - DrOpening + CrActivity - DrActivity
                    End If
                    Call genReportInsert(acIdGot, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing, tblName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim startDateRpt, endDateRpt As String
        startDateRpt = String.Format("{0:dd-MM-yyyy}", fromDate.Value)
        endDateRpt = String.Format("{0:dd-MM-yyyy}", toDate.Value)
        If subCatID = 1 Then
            subActivityPrint1.fiscalYearIDGot = fiscalYearIDGot
            subActivityPrint1.startDate = startDateRpt
            subActivityPrint1.endDate = endDateRpt
            subActivityPrint1.Show()
        ElseIf subCatID = 2 Then
            subActivityPrint2.fiscalYearIDGot = fiscalYearIDGot
            subActivityPrint2.startDate = startDateRpt
            subActivityPrint2.endDate = endDateRpt
            subActivityPrint2.Show()
        ElseIf subCatID = 3 Then
            subActivityPrint3.fiscalYearIDGot = fiscalYearIDGot
            subActivityPrint3.startDate = startDateRpt
            subActivityPrint3.endDate = endDateRpt
            subActivityPrint3.Show()
        ElseIf subCatID = 4 Then
            subActivityPrint4.fiscalYearIDGot = fiscalYearIDGot
            subActivityPrint4.startDate = startDateRpt
            subActivityPrint4.endDate = endDateRpt
            subActivityPrint4.Show()
        ElseIf subCatID = 5 Then
            subActivityPrint5.fiscalYearIDGot = fiscalYearIDGot
            subActivityPrint5.startDate = startDateRpt
            subActivityPrint5.endDate = endDateRpt
            subActivityPrint5.Show()
        End If
    End Function

    Private Function generateReportPosted(ByVal subCatID)
        Dim tblName As String = "rpt_subActivityPosted" & subCatID
        Try
            conn.Open()
            Dim commStr As String = "DELETE FROM " & tblName
            comm = New SqlCommand(commStr, conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim endDateGot As Date = toDate.Value
        Dim endDateGotIncrement = endDateGot.AddDays(1)
        Dim endDate As String = String.Format("{0:yyyy-MM-dd}", endDateGotIncrement)
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT subsidiaryLedgerID FROM subsidiaryLedger WHERE subsidiaryCategoryID = '" & subCatID & "' ORDER BY subsidiaryLedgerID ASC", conn)
            reader = comm.ExecuteReader
            Dim acIdGot As Integer
            Dim tblFieldName As String = ""
            If subCatID = 1 Then
                tblFieldName = "VRCustomer"
            ElseIf subCatID = 2 Then
                tblFieldName = "VRSupplier"
            ElseIf subCatID = 3 Then
                tblFieldName = "VREmployee"
            ElseIf subCatID = 4 Then
                tblFieldName = "VRLCSupplier"
            ElseIf subCatID = 5 Then
                tblFieldName = "VRCostCentre"
            End If
            Do While reader.Read = True 'Loop to load data realtime
                acIdGot = (reader(0).ToString)
                Dim DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing As Double
                DrOpening = 0
                CrOpening = 0
                DrActivity = 0
                CrActivity = 0
                DrClosing = 0
                CrClosing = 0
                Dim fromDateGot As String = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
                Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
                'Opening Balance
                Try
                    conn2.Open()
                    comm2 = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE (" & tblFieldName & " = " & acIdGot & ") AND (VRDate < '" & fromDateGot & "') AND (VRStatus = 'C') ", conn2)
                    reader2 = comm2.ExecuteReader
                    Dim opDebit, opCredit As Double
                    opDebit = 0
                    opCredit = 0
                    Do While reader2.Read = True 'Loop to load data realtime
                        opDebit = CDbl(Val((reader2(0)).ToString))
                        opCredit = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    If opDebit > opCredit Then
                        DrOpening = opDebit - opCredit
                        CrOpening = 0
                    ElseIf opDebit = opCredit Then
                        DrOpening = 0
                        CrOpening = 0
                    Else
                        DrOpening = 0
                        CrOpening = opCredit - opDebit
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                'Activity During the Year
                Try
                    conn2.Open()
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE " & tblFieldName & " = " & acIdGot & " AND (VRDate <= '" & toDateGot & "' AND VRDate >= '" & fromDateGot & "')  AND (VRStatus = 'C') "
                    comm2 = New SqlCommand(command2Str, conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True 'Loop to load data realtime
                        DrActivity = CDbl(Val((reader2(0)).ToString))
                        CrActivity = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    Dim netBal As Double = 0
                    netBal = DrOpening - CrOpening + DrActivity - CrActivity
                    If netBal > 0 Then
                        DrClosing = DrOpening - CrOpening + DrActivity - CrActivity
                        CrClosing = 0
                    ElseIf netBal = 0 Then
                        DrClosing = 0
                        CrClosing = 0
                    Else
                        DrClosing = 0
                        CrClosing = CrOpening - DrOpening + CrActivity - DrActivity
                    End If
                    Call genReportInsert(acIdGot, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing, tblName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim startDateRpt, endDateRpt As String
        startDateRpt = String.Format("{0:dd-MM-yyyy}", fromDate.Value)
        endDateRpt = String.Format("{0:dd-MM-yyyy}", toDate.Value)
        If subCatID = 1 Then
            subActivityPostedPrint1.fiscalYearIDGot = fiscalYearIDGot
            subActivityPostedPrint1.startDate = startDateRpt
            subActivityPostedPrint1.endDate = endDateRpt
            subActivityPostedPrint1.Show()
        ElseIf subCatID = 2 Then
            subActivityPostedPrint2.fiscalYearIDGot = fiscalYearIDGot
            subActivityPostedPrint2.startDate = startDateRpt
            subActivityPostedPrint2.endDate = endDateRpt
            subActivityPostedPrint2.Show()
        ElseIf subCatID = 3 Then
            subActivityPostedPrint3.fiscalYearIDGot = fiscalYearIDGot
            subActivityPostedPrint3.startDate = startDateRpt
            subActivityPostedPrint3.endDate = endDateRpt
            subActivityPostedPrint3.Show()
        ElseIf subCatID = 4 Then
            subActivityPostedPrint4.fiscalYearIDGot = fiscalYearIDGot
            subActivityPostedPrint4.startDate = startDateRpt
            subActivityPostedPrint4.endDate = endDateRpt
            subActivityPostedPrint4.Show()
        ElseIf subCatID = 5 Then
            subActivityPostedPrint5.fiscalYearIDGot = fiscalYearIDGot
            subActivityPostedPrint5.startDate = startDateRpt
            subActivityPostedPrint5.endDate = endDateRpt
            subActivityPostedPrint5.Show()
        End If
    End Function

    Private Function genReportInsert(ByVal acIDGot, ByVal DrOpening, ByVal CrOpening, ByVal DrActivity, ByVal CrActivity, ByVal DrClosing, ByVal CrClosing, ByVal tblName)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO " & tblName & "(subID, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing) VALUES ('" & acIDGot & "' , '" & DrOpening & "' , '" & CrOpening & "' , '" & DrActivity & "' , '" & CrActivity & "', '" & DrClosing & "', '" & CrClosing & "'  )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

End Class