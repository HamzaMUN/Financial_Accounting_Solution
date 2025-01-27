Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class subWCoaLedger
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim conn As SqlConnection = New SqlConnection(constr)
    Dim conn2 As SqlConnection = New SqlConnection(constr)
    Dim conn3 As SqlConnection = New SqlConnection(constr)
    Dim comm As SqlCommand = New SqlCommand
    Dim comm2 As SqlCommand = New SqlCommand
    Dim comm3 As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim reader2 As SqlDataReader
    Dim reader3 As SqlDataReader
    Public Property fiscalYearIDGot As Integer

    Private Sub subWCoaLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadDate()
        summaryRadio.Checked = True
        subIDInput1.Focus()
    End Sub

    Private Sub loadDate()
        Try
            conn = New SqlConnection(constr)
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

    Private Sub coaCodeInput1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles coaCodeInput1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ1()
        End If
    End Sub

    Private Sub coaCodeInput2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles coaCodeInput2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ2()
        End If
    End Sub

    Private Sub subIDInput1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles subIDInput1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ3()
        End If
    End Sub

    Private Sub subIDInput2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles subIDInput2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchQ4()
        End If
    End Sub

    Private Sub searchQ1()
        searchDialogL3.searchKeywordGot = coaCodeInput1.Text
        searchDialogL3.parentFormGot = "subWCoaRange1"
        searchDialogL3.Show()
    End Sub

    Private Sub searchQ2()
        searchDialogL3.searchKeywordGot = coaCodeInput2.Text
        searchDialogL3.parentFormGot = "subWCoaRange2"
        searchDialogL3.Show()
    End Sub

    Private Sub searchQ3()
        searchSub.searchKeywordGot = subIDInput1.Text
        searchSub.parentFormGot = "subWCoaRange1"
        searchSub.Show()
    End Sub

    Private Sub searchQ4()
        searchSub.searchKeywordGot = subIDInput2.Text
        searchSub.parentFormGot = "subWCoaRange2"
        searchSub.Show()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If coaCodeInput1.Text <> Nothing And coaCodeInput2.Text <> Nothing And subIDInput1.Text <> Nothing And subIDInput2.Text <> Nothing And fromDate.Value < toDate.Value Then
            If summaryRadio.Checked = True Then
                Call genSummaryReport()
            ElseIf detailRadio.Checked = True Then
                Call genDetailReport()
            End If
        End If
    End Sub

    Private Sub genSummaryReport()
        Dim fromDateGot As String = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
        Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
        Dim coaAcID1, coaAcID2, subAcID1, subAcID2 As Integer
        If coaCodeInput1.Text < coaCodeInput2.Text Then
            coaAcID1 = coaCodeInput1.Text
            coaAcID2 = coaCodeInput2.Text
        Else
            coaAcID1 = coaCodeInput2.Text
            coaAcID2 = coaCodeInput1.Text
        End If
        If subIDInput1.Text < subIDInput2.Text Then
            subAcID1 = subIDInput1.Text
            subAcID2 = subIDInput2.Text
        Else
            subAcID1 = subIDInput2.Text
            subAcID2 = subIDInput1.Text
        End If
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_coaWsubSummary", conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT L3controlAcID FROM L3controlAc WHERE (L3controlAcID >= " & coaAcID1 & " AND L3controlAcID <= " & coaAcID2 & ") ORDER BY L3controlAcID ASC", conn)
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
                Try
                    conn3.Open()
                    comm3 = New SqlCommand("SELECT subsidiaryLedgerID FROM subsidiaryLedger WHERE (subsidiaryLedgerID >= " & subAcID1 & " AND subsidiaryLedgerID <= " & subAcID2 & ") ORDER BY subsidiaryLedgerID ASC", conn3)
                    reader3 = comm3.ExecuteReader
                    Dim subAcIDGot = 0
                    Do While reader3.Read = True 'Loop to load data realtime
                        subAcIDGot = (reader3(0).ToString)
                        'Opening Balance
                        Try
                            conn2.Open()
                            comm2 = New SqlCommand("SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND (VRCustomer = " & subAcIDGot & " OR VRSupplier = " & subAcIDGot & " OR VREmployee = " & subAcIDGot & " OR VRLCSupplier = " & subAcIDGot & " OR VRCostCentre = " & subAcIDGot & ") AND VRDate < '" & fromDateGot & "' ", conn2)
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
                            Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND (VRCustomer = " & subAcIDGot & " OR VRSupplier = " & subAcIDGot & " OR VREmployee = " & subAcIDGot & " OR VRLCSupplier = " & subAcIDGot & " OR VRCostCentre = " & subAcIDGot & ") AND (VRDate <= '" & toDateGot & "' AND VRDate >= '" & fromDateGot & "')"
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
                            Call genSummaryReportInsert(l3AcIdGot, subAcIDGot, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Loop
                    reader3.Close()
                    conn3.Close()
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
        subWCoaLedgerSummaryPrint.fiscalYearIDGot = fiscalYearIDGot
        subWCoaLedgerSummaryPrint.startDate = startDateRpt
        subWCoaLedgerSummaryPrint.endDate = endDateRpt
        subWCoaLedgerSummaryPrint.Show()
    End Sub

    Private Sub genDetailReport()
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_coaWsubDetail", conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn.Open()
            comm = New SqlCommand("DELETE FROM rpt_coaWsubDetail2", conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim fromDateGot As String = String.Format("{0:yyyy-MM-dd}", fromDate.Value)
        Dim toDateGot As String = String.Format("{0:yyyy-MM-dd}", toDate.Value)
        Dim coaAcID1, coaAcID2, subAcID1, subAcID2 As Integer
        If coaCodeInput1.Text < coaCodeInput2.Text Then
            coaAcID1 = coaCodeInput1.Text
            coaAcID2 = coaCodeInput2.Text
        Else
            coaAcID1 = coaCodeInput2.Text
            coaAcID2 = coaCodeInput1.Text
        End If
        If subIDInput1.Text < subIDInput2.Text Then
            subAcID1 = subIDInput1.Text
            subAcID2 = subIDInput2.Text
        Else
            subAcID1 = subIDInput2.Text
            subAcID2 = subIDInput1.Text
        End If
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            Dim commStr As String = "SELECT VRType, VRNo, VRDate, VrAcID, voucherDebit, voucherCredit, VRNaration, VRCustomer, VRSupplier, VREmployee, VRLCSupplier, VRCostCentre FROM voucherDetails WHERE (VrAcID >= " & coaAcID1 & " AND VrAcID <= " & coaAcID2 & ") AND (VRCustomer >= " & subAcID1 & " OR VRSupplier >= " & subAcID1 & " OR VREmployee >= " & subAcID1 & " OR VRLCSupplier >= " & subAcID1 & " OR VRCostCentre >= " & subAcID1 & ") AND (VRCustomer <= " & subAcID2 & " OR VRSupplier <= " & subAcID2 & " OR VREmployee <= " & subAcID2 & " OR VRLCSupplier <= " & subAcID2 & " OR VRCostCentre <= " & subAcID2 & ") AND (VRDate >= '" & fromDateGot & "' AND VRDate <= '" & toDateGot & "')"
            comm = New SqlCommand(commStr, conn)
            reader = comm.ExecuteReader
            Dim voucherNo, L3ControlAcID, subAcID, subCatID, customerID, supplierID, employeeID, lcSupplierID, costCentreID As Integer
            Dim debit, credit As Double
            Dim typeGot, dateGot, narration As String
            Dim dateGot1 As Date
            Do While reader.Read = True 'Loop to load data realtime
                typeGot = (reader(0).ToString)
                voucherNo = (reader(1).ToString)
                dateGot1 = (reader(2).ToString)
                dateGot = String.Format("{0:yyyy-MM-dd}", dateGot1)
                L3ControlAcID = (reader(3).ToString)
                debit = CDbl(Val((reader(4)).ToString))
                credit = CDbl(Val((reader(5)).ToString))
                narration = (reader(6).ToString)
                customerID = (reader(7).ToString)
                supplierID = (reader(8).ToString)
                employeeID = (reader(9).ToString)
                lcSupplierID = (reader(10).ToString)
                costCentreID = (reader(11).ToString)
                If customerID <> 0 Then
                    subAcID = customerID
                    subCatID = 1
                    Call genDetailReportInsert(typeGot, voucherNo, dateGot, L3ControlAcID, debit, credit, narration, subAcID, subCatID)
                End If
                If supplierID <> 0 Then
                    subAcID = supplierID
                    subCatID = 2
                    Call genDetailReportInsert(typeGot, voucherNo, dateGot, L3ControlAcID, debit, credit, narration, subAcID, subCatID)
                End If
                If employeeID <> 0 Then
                    subAcID = employeeID
                    subCatID = 3
                    Call genDetailReportInsert(typeGot, voucherNo, dateGot, L3ControlAcID, debit, credit, narration, subAcID, subCatID)
                End If
                If lcSupplierID <> 0 Then
                    subAcID = lcSupplierID
                    subCatID = 4
                    Call genDetailReportInsert(typeGot, voucherNo, dateGot, L3ControlAcID, debit, credit, narration, subAcID, subCatID)
                End If
                If costCentreID <> 0 Then
                    subAcID = costCentreID
                    subCatID = 5
                    Call genDetailReportInsert(typeGot, voucherNo, dateGot, L3ControlAcID, debit, credit, narration, subAcID, subCatID)
                End If
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT L3controlAcID FROM L3controlAc WHERE (L3controlAcID >= " & coaAcID1 & " AND L3controlAcID <= " & coaAcID2 & ") ORDER BY L3controlAcID ASC", conn)
            reader = comm.ExecuteReader
            Dim l3AcIdGot As Integer
            Dim opBalance As Double
            opBalance = 0
            Do While reader.Read = True 'Loop to load data realtime
                l3AcIdGot = (reader(0).ToString)
                Dim debitBal, creditBal As Double
                debitBal = 0
                creditBal = 0
                Try
                    conn3.Open()
                    comm3 = New SqlCommand("SELECT subsidiaryLedgerID FROM subsidiaryLedger WHERE (subsidiaryLedgerID >= " & subAcID1 & " AND subsidiaryLedgerID <= " & subAcID2 & ") ORDER BY subsidiaryLedgerID ASC", conn3)
                    reader3 = comm3.ExecuteReader
                    Dim subAcIDGot = 0
                    Do While reader3.Read = True 'Loop to load data realtime
                        subAcIDGot = (reader3(0).ToString)
                        Try
                            conn2.Open()
                            Dim command2Str As String = "SELECT SUM(voucherDebit) AS vrDebit, SUM(voucherCredit) AS vrCredit FROM voucherDetails WHERE VrAcID = " & l3AcIdGot & " AND (VRCustomer = " & subAcIDGot & " OR VRSupplier = " & subAcIDGot & " OR VREmployee = " & subAcIDGot & " OR VRLCSupplier = " & subAcIDGot & " OR VRCostCentre = " & subAcIDGot & ") AND VRDate < '" & fromDateGot & "'"
                            comm2 = New SqlCommand(command2Str, conn2)
                            reader2 = comm2.ExecuteReader
                            Do While reader2.Read = True 'Loop to load data realtime
                                debitBal = CDbl(Val((reader2(0)).ToString))
                                creditBal = CDbl(Val((reader2(1)).ToString))
                            Loop
                            reader2.Close()
                            conn2.Close()
                            opBalance = debitBal - creditBal
                            Dim subCatID As Integer = 0
                            If subAcIDGot > 1000 And subAcIDGot < 2000 Then
                                subCatID = 1
                            ElseIf subAcIDGot > 2000 And subAcIDGot < 3000 Then
                                subCatID = 2
                            ElseIf subAcIDGot > 3000 And subAcIDGot < 4000 Then
                                subCatID = 3
                            ElseIf subAcIDGot > 4000 And subAcIDGot < 5000 Then
                                subCatID = 4
                            ElseIf subAcIDGot > 5000 And subAcIDGot < 6000 Then
                                subCatID = 5
                            End If
                            Call genDetailReportInsert2(l3AcIdGot, subAcIDGot, subCatID, opBalance)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Loop
                    reader3.Close()
                    conn3.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        subWCoaLedgerDetailPrint.startDate = fromDateGot
        subWCoaLedgerDetailPrint.endDate = toDateGot
        subWCoaLedgerDetailPrint.fiscalYearIDGot = fiscalYearIDGot
        subWCoaLedgerDetailPrint.Show()
    End Sub

    Private Function genDetailReportInsert(ByVal type, ByVal voucherNo, ByVal dateGot, ByVal L3ControlAcID, ByRef debit, ByVal credit, ByVal narration, ByVal subsidiaryLedgerID, ByVal subsidiaryCategoryID)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_coaWsubDetail(type, voucherNo, date, L3ControlAcID, debit, credit, narration, subsidiaryLedgerID, subsidiaryCategoryID) VALUES ('" & type & "' , " & voucherNo & " , '" & dateGot & "' , " & L3ControlAcID & " , " & debit & " , " & credit & " , '" & narration & "', " & subsidiaryLedgerID & ", " & subsidiaryCategoryID & " )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Function genDetailReportInsert2(ByVal L3ControlAcID, ByVal subsidiaryLedgerID, ByVal subsidiaryCategoryID, ByVal balance)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_coaWsubDetail2(L3ControlAcID, subsidiaryLedgerID, subsidiaryCategoryID, balance) VALUES (" & L3ControlAcID & " , " & subsidiaryLedgerID & " , " & subsidiaryCategoryID & " , " & balance & " )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Function genSummaryReportInsert(ByVal acIDGot, ByVal subLedgerID, ByVal DrOpening, ByVal CrOpening, ByVal DrActivity, ByVal CrActivity, ByVal DrClosing, ByVal CrClosing)
        Try
            conn2.Open()
            comm2 = New SqlCommand("INSERT INTO rpt_coaWsubSummary(L3controlAcID, subsidiaryLedgerID, DrOpening, CrOpening, DrActivity, CrActivity, DrClosing, CrClosing) VALUES ('" & acIDGot & "' , '" & subLedgerID & "', '" & DrOpening & "' , '" & CrOpening & "' , '" & DrActivity & "' , '" & CrActivity & "', '" & DrClosing & "', '" & CrClosing & "'  )", conn2)
            affector = comm2.ExecuteNonQuery
            conn2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function
End Class