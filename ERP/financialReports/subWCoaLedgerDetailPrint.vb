Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Public Class subWCoaLedgerDetailPrint
    Public Property startDate As String
    Public Property endDate As String
    Public Property fiscalYearIDGot As Integer
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Private Sub subWCoaLedgerDetailPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadAll()
    End Sub

    Private Sub loadAll()
        Dim loopCounter As Integer = 0
        Dim dbServerName, dbName, dbUserId, dbPassword As String
        For Each word As String In Split(constr, ";")
            For Each word2 As String In Split(word, "=")
                loopCounter = loopCounter + 1
                If loopCounter = 2 Then
                    dbServerName = word2
                ElseIf loopCounter = 4 Then
                    dbName = word2
                ElseIf loopCounter = 8 Then
                    dbUserId = word2
                ElseIf loopCounter = 10 Then
                    dbPassword = word2
                End If
            Next
        Next
        Dim fiscalYear As String = ""
        Try
            Dim conn As SqlConnection = New SqlConnection(constr)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand(" SELECT fiscalYearName FROM fiscalYear WHERE fiscalYearID = '" & fiscalYearIDGot & "' ", conn)
            Dim reader As SqlDataReader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                fiscalYear = (reader(0).ToString)
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Dim pfields As New ParameterFields

        Dim pfield1, pfield2, pfield3 As New ParameterField
        Dim pdiscrete1, pdiscrete2, pdiscrete3 As New ParameterDiscreteValue

        'First Parameter for Start Date
        pfield1.Name = "fromDate"
        pdiscrete1.Value = startDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        'Second Parameter for Ending Date
        pfield2.Name = "toDate"
        pdiscrete2.Value = endDate
        pfield2.CurrentValues.Add(pdiscrete2)
        pfields.Add(pfield2)

        'Third Parameter for Fiscal Year
        pfield3.Name = "fiscalYear"
        pdiscrete3.Value = fiscalYear
        pfield3.CurrentValues.Add(pdiscrete3)
        pfields.Add(pfield3)

        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim crConnectionInfo As New ConnectionInfo()
        Dim CrTables As Tables
        Dim CrTable As Table

        'Declare ReportDocument object and load your existing report
        'Make sure that you give the correct path for the document else it will give exception
        Dim crReportDocument As New ReportDocument()
        crReportDocument.Load("D:\Hexagon Solutions\ERP\rpt\fr\sub_W_coa_l_r1.rpt")

        CrTables = crReportDocument.Database.Tables

        For Each CrTable In CrTables

            crtableLogoninfo = CrTable.LogOnInfo
            'Read MachineName\InstanceName,Database details from User interface
            'and load them into crConnectionInfo object
            crConnectionInfo.ServerName = dbServerName
            crConnectionInfo.DatabaseName = dbName
            crConnectionInfo.UserID = dbUserId
            crConnectionInfo.Password = dbPassword
            crConnectionInfo.IntegratedSecurity = False
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)

        Next

        crReportDocument.ReportOptions.EnableSaveDataWithReport = False
        'Refresh the ReportViewer Object
        CrystalReportViewer1.RefreshReport()
        'Bind the ReportDocument to ReportViewer Object
        CrystalReportViewer1.ReportSource = crReportDocument
        CrystalReportViewer1.ParameterFieldInfo = pfields

    End Sub
End Class