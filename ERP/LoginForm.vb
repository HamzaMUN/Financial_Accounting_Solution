Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class LoginForm
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadFiscalYears()
    End Sub

    Private Sub LoadFiscalYears()
        'Load Fiscal Years from database to a dropdown
        conn = New SqlConnection(constr)
        conn.Open()
        comm = New SqlCommand("SELECT * FROM fiscalYear ORDER BY fiscalYearID DESC", conn)
        adapter = New SqlDataAdapter(comm)
        table = New DataTable()
        adapter.Fill(table)
        fiscalYearInput.DataSource = table
        fiscalYearInput.DisplayMember = "fiscalYearName"
        fiscalYearInput.ValueMember = "fiscalYearID"
        conn.Close()
    End Sub

    Private Sub LoginButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginButton.Click
        conn = New SqlConnection(constr)
        conn.Open()
        'SQL Authentication for User
        Dim valcommand1 As New SqlCommand("SELECT * FROM userAuth WHERE userName = @uname AND userPassword = @pass", conn)
        valcommand1.Parameters.Add("@uname", SqlDbType.VarChar).Value = usernameInput.Text
        valcommand1.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordInput.Text
        Dim valadapter1 As New SqlDataAdapter(valcommand1)
        Dim logintable1 As New DataTable()
        valadapter1.Fill(logintable1)
        If logintable1.Rows.Count() <= 0 Then
            MsgBox("Please Check Your Username and Password")
        Else
            Call LoginAuthDone()
        End If
        conn.Close()
    End Sub
    Private Sub LoginAuthDone()
        Dim userNameSub As String = usernameInput.Text
        Dim dateTimeNow As String = String.Format("{0:MMMM dd, yyyy hh:mm:ss tt}", Date.Now)
        Dashboard.Text = "Hexa Enterprise Resource Planning (" & String.Format("Version {0}", My.Application.Info.Version.ToString) & ") | WELCOME ***" & userNameSub & "*** | Logged In: " & dateTimeNow
        Dashboard.userNameGot = usernameInput.Text
        Dashboard.fiscalYearIDGot = fiscalYearInput.SelectedValue
        Dashboard.Show()
        Me.Close()
    End Sub
    Private Sub Label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.Click
        Dim facebookPage As String = "https://www.facebook.com/HexagonSolutionz"
        Process.Start(facebookPage)
    End Sub

    Private Sub Label4_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim webPageURL As String = "https://www.hexagonsolutionz.com"
        Process.Start(webPageURL)
    End Sub

End Class