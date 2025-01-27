Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class lcSupplierDetails
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim table As New DataTable
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim listShowAll As ListViewItem
    Dim codeL1Got As String
    Dim saveType As String
    Dim codeGot As Integer
    Dim l1InputVal1 As Integer
    Dim areaIDGot1 As String
    Dim subAreaIDGot1 As String
    Dim salePersonnelIDGot1 As String
    Public Property lcSupplierIDGot As String
    Private Sub lcSupplierDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        codeInput.Text = lcSupplierIDGot
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerID = @codeinput1got", conn)
            comm.Parameters.Add("@codeinput1got", SqlDbType.VarChar).Value = codeInput.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                nameInput.Text = (reader(1).ToString)
                addressInput.Text = (reader(3).ToString)
                landlineInput.Text = (reader(4).ToString)
                mobileInput.Text = (reader(5).ToString)
                contactPersonInput.Text = (reader(6).ToString)
                emailInput.Text = (reader(7).ToString)
                ntnInput.Text = (reader(8).ToString)
                areaIDGot1 = (reader(9).ToString)
                subAreaIDGot1 = (reader(10).ToString)
                salePersonnelIDGot1 = (reader(11).ToString)
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub loadRecordsAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subsidiaryLedger WHERE subsidiaryLedgerID = @codeinput1got", conn)
            comm.Parameters.Add("@codeinput1got", SqlDbType.VarChar).Value = codeInput.Text
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                nameInput.Text = (reader(1).ToString)
                addressInput.Text = (reader(3).ToString)
                landlineInput.Text = (reader(4).ToString)
                mobileInput.Text = (reader(5).ToString)
                contactPersonInput.Text = (reader(6).ToString)
                emailInput.Text = (reader(7).ToString)
                ntnInput.Text = (reader(8).ToString)
                areaIDGot1 = (reader(9).ToString)
                subAreaIDGot1 = (reader(10).ToString)
                salePersonnelIDGot1 = (reader(11).ToString)
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        conn = New SqlConnection(constr)
        conn.Open()
        comm = New SqlCommand("UPDATE subsidiaryLedger SET subsidiaryAddress = '" & addressInput.Text & "',subsidiaryLandlineNo = '" & landlineInput.Text & "',subsidiaryMobileNo = '" & mobileInput.Text & "',subsidiaryContactPerson = '" & contactPersonInput.Text & "',subsidiaryEmail = '" & emailInput.Text & "',ntn = '" & ntnInput.Text & "' WHERE subsidiaryLedgerID = '" & lcSupplierIDGot & "' ", conn)
        affector = comm.ExecuteNonQuery
        MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
        Call loadRecordsAll()
    End Sub
    Private Sub lcSupplierDetails_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class