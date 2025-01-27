Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class trialSummary
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

    Private Sub trialSummary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
    End Sub

    Private Sub loadDate()
        
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
            comm = New SqlCommand("DELETE FROM rpt_TrialSummary", conn)
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
            Dim DrClosing, CrClosing As Double
            DrClosing = 0
            CrClosing = 0
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
                Dim debitBal, creditBal As Double
                debitBal = 0
                creditBal = 0
                Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
                Try
                    conn2.Open()
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND VRDate <= '" & toDateGot & "'"
                    comm2 = New SqlCommand(command2Str, conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True 'Loop to load data realtime
                        debitBal = CDbl(Val((reader2(0)).ToString))
                        creditBal = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    If debitBal > creditBal Then
                        DrClosing = debitBal - creditBal
                        CrClosing = 0
                    ElseIf debitBal = creditBal Then
                        DrClosing = 0
                        CrClosing = 0
                    Else
                        DrClosing = 0
                        CrClosing = creditBal - debitBal
                    End If
                    Call genReportInsert(l3AcIdGot, DrClosing, CrClosing)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim dateOn As String
        dateOn = String.Format("{0:dd-MM-yyyy}", toDate.Value)
        trialSummaryPrint.dateON = dateOn
        trialSummaryPrint.Show()
    End Sub
    Private Function genReportInsert(ByVal acIDGot, ByVal DrClosing, ByVal CrClosing)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_TrialSummary(L3ControlAcID, debit, credit) VALUES ('" & acIDGot & "' , '" & DrClosing & "' , '" & CrClosing & "' )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub generateReportPosted()
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_TrialSummaryPosted", conn)
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
            Dim DrClosing, CrClosing As Double
            DrClosing = 0
            CrClosing = 0
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
                Dim debitBal, creditBal As Double
                debitBal = 0
                creditBal = 0
                Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
                Try
                    conn2.Open()
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE (VrAcID = " & l3AcIdGot & ") AND (VRDate <= '" & toDateGot & "') AND VRStatus = 'C'"
                    comm2 = New SqlCommand(command2Str, conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True 'Loop to load data realtime
                        debitBal = CDbl(Val((reader2(0)).ToString))
                        creditBal = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    If debitBal > creditBal Then
                        DrClosing = debitBal - creditBal
                        CrClosing = 0
                    ElseIf debitBal = creditBal Then
                        DrClosing = 0
                        CrClosing = 0
                    Else
                        DrClosing = 0
                        CrClosing = creditBal - debitBal
                    End If
                    Call genReportInsertPosted(l3AcIdGot, DrClosing, CrClosing)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim dateOn As String
        dateOn = String.Format("{0:dd-MM-yyyy}", toDate.Value)
        trialSummaryPostedPrint.dateON = dateOn
        trialSummaryPostedPrint.Show()
    End Sub

    Private Function genReportInsertPosted(ByVal acIDGot, ByVal DrClosing, ByVal CrClosing)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_TrialSummaryPosted(L3ControlAcID, debit, credit) VALUES ('" & acIDGot & "' , '" & DrClosing & "' , '" & CrClosing & "' )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

End Class