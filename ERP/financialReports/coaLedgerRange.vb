Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class coaLedgerRange
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

    Private Sub coaLedgerRange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
        coaCodeInput1.Focus()
    End Sub

    Private Sub loadDate()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "'", conn)
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                fromDate.Value = (reader(2).ToString)
                toDate.Value = (reader(3).ToString)
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub coaCodeInput1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles coaCodeInput1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ1()
        End If
    End Sub

    Private Sub coaCodeInput2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles coaCodeInput2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ2()
        End If
    End Sub

    Private Sub searchQ1()
        searchDialogL3.searchKeywordGot = coaCodeInput1.Text
        searchDialogL3.parentFormGot = "coaRange1"
        searchDialogL3.Show()
    End Sub

    Private Sub searchQ2()
        searchDialogL3.searchKeywordGot = coaCodeInput2.Text
        searchDialogL3.parentFormGot = "coaRange2"
        searchDialogL3.Show()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        If coaCodeInput1.Text <> Nothing And coaCodeInput2.Text <> Nothing And fromDate.Value < toDate.Value Then
            Call generateReport()
        End If
    End Sub

    Private Sub generateReport()
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_coaRange", conn)
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
            Dim opBal As Double = 0
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
                Dim debitBal, creditBal As Double
                debitBal = 0
                creditBal = 0
                Dim fromDateGot As String = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
                Try
                    conn2.Open()
                    Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND VRDate <= '" & fromDateGot & "'"
                    comm2 = New SqlCommand(command2Str, conn2)
                    reader2 = comm2.ExecuteReader
                    Do While reader2.Read = True 'Loop to load data realtime
                        debitBal = CDbl(Val((reader2(0)).ToString))
                        creditBal = CDbl(Val((reader2(1)).ToString))
                    Loop
                    reader2.Close()
                    conn2.Close()
                    opBal = debitBal - creditBal
                    Call genReportInsert(l3AcIdGot, opBal)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim startDate2, endDate2 As String
        startDate2 = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
        endDate2 = String.Format("{0:yyyy-MM-dd}", toDate.Value)
        coaLedgerRangePrint.startDate = startDate2
        coaLedgerRangePrint.endDate = endDate2
        coaLedgerRangePrint.l3AcId1 = coaCodeInput1.Text
        coaLedgerRangePrint.l3AcId2 = coaCodeInput2.Text
        coaLedgerRangePrint.fiscalYearIDGot = fiscalYearIDGot
        coaLedgerRangePrint.Show()
    End Sub

    Private Function genReportInsert(ByVal acIDGot, ByVal bal)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_coaRange(L3ControlAcID, bal) VALUES ('" & acIDGot & "' , '" & bal & "' )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

End Class