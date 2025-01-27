Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class trialDetails
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

    Private Sub trialDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
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

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If chkPosted.Checked = True Then
            Call generateReportPosted()
        Else
            Call generateReport()
        End If
    End Sub

    Private Sub generateReport()
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_TrialDetails", conn)
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
            comm = New SqlCommand("SELECT L3controlAcID FROM L3controlAc ORDER BY L3controlAcID ASC", conn)
            reader = comm.ExecuteReader
            Dim l3AcIdGot As Integer
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
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
                    comm2 = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND VRDate < '" & fromDateGot & "' ", conn2)
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
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND (VRDate <= '" & toDateGot & "' AND VRDate >= '" & fromDateGot & "')"
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
                    Call genReportInsert(l3AcIdGot, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing)
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
        trialDetailsPrint.fiscalYearIDGot = fiscalYearIDGot
        trialDetailsPrint.startDate = startDateRpt
        trialDetailsPrint.endDate = endDateRpt
        trialDetailsPrint.Show()
    End Sub
    Private Function genReportInsert(ByVal acIDGot, ByVal DrOpening, ByVal CrOpening, ByVal DrActivity, ByVal CrActivity, ByVal DrClosing, ByVal CrClosing)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_TrialDetails(L3controlAcID, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing) VALUES ('" & acIDGot & "' , '" & DrOpening & "' , '" & CrOpening & "' , '" & DrActivity & "' , '" & CrActivity & "', '" & DrClosing & "', '" & CrClosing & "'  )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub generateReportPosted()
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_TrialDetailsPosted", conn)
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
            comm = New SqlCommand("SELECT L3controlAcID FROM L3controlAc ORDER BY L3controlAcID ASC", conn)
            reader = comm.ExecuteReader
            Dim l3AcIdGot As Integer
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
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
                    comm2 = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE (VrAcID = " & l3AcIdGot & ") AND (VRDate < '" & fromDateGot & "') AND (VRStatus = 'C') ", conn2)
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
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND (VRDate <= '" & toDateGot & "' AND VRDate >= '" & fromDateGot & "')  AND (VRStatus = 'C') "
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
                    Call genReportInsertPosted(l3AcIdGot, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing)
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
        trialDetailsPostedPrint.fiscalYearIDGot = fiscalYearIDGot
        trialDetailsPostedPrint.startDate = startDateRpt
        trialDetailsPostedPrint.endDate = endDateRpt
        trialDetailsPostedPrint.Show()
    End Sub
    Private Function genReportInsertPosted(ByVal acIDGot, ByVal DrOpening, ByVal CrOpening, ByVal DrActivity, ByVal CrActivity, ByVal DrClosing, ByVal CrClosing)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_TrialDetailsPosted(L3controlAcID, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing) VALUES ('" & acIDGot & "' , '" & DrOpening & "' , '" & CrOpening & "' , '" & DrActivity & "' , '" & CrActivity & "', '" & DrClosing & "', '" & CrClosing & "'  )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

End Class