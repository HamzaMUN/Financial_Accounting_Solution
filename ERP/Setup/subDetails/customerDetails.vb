Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class customerDetails
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
    Public Property customerIDGot As String
    Private Sub customerDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        codeInput.Text = customerIDGot
        areaInput.SelectedIndex = -1
        subAreaInput.SelectedIndex = -1
        salePersonnelInput.SelectedIndex = -1
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
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM area", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            areaInput.DisplayMember = "areaName"
            areaInput.ValueMember = "areaID"
            areaInput.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Call loadSubAreaAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM salesPersonnel", conn)
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            salePersonnelInput.DataSource = table
            salePersonnelInput.DisplayMember = "salesPersonnelName"
            salePersonnelInput.ValueMember = "salesPersonnelID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT areaName FROM area WHERE areaID = @codeinput1got", conn)
            comm.Parameters.Add("@codeinput1got", SqlDbType.VarChar).Value = areaIDGot1
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                areaInput.Text = (reader(0).ToString)
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT subAreaName FROM subArea WHERE subAreaID = @codeinput1got", conn)
            comm.Parameters.Add("@codeinput1got", SqlDbType.VarChar).Value = subAreaIDGot1
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                subAreaInput.Text = (reader(0).ToString)
            Loop
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT salesPersonnelName FROM salesPersonnel WHERE salesPersonnelID = @codeinput1got", conn)
            comm.Parameters.Add("@codeinput1got", SqlDbType.VarChar).Value = salePersonnelIDGot1
            reader = comm.ExecuteReader
            Do While reader.Read = True 'Loop to load data realtime
                salePersonnelInput.Text = (reader(0).ToString)
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
    Private Sub loadSubAreaAll()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("SELECT * FROM subArea WHERE areaID = @areaIDGot1", conn)
            comm.Parameters.Add("@areaIDGot1", SqlDbType.VarChar).Value = areaInput.SelectedValue
            adapter = New SqlDataAdapter(comm)
            table = New DataTable()
            adapter.Fill(table)
            subAreaInput.DataSource = table
            subAreaInput.DisplayMember = "subAreaName"
            subAreaInput.ValueMember = "subAreaID"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub areaInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles areaInput.SelectedIndexChanged
        Call loadSubAreaAll()
        subAreaInput.SelectedIndex = -1
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        conn = New SqlConnection(constr)
        conn.Open()
        comm = New SqlCommand("UPDATE subsidiaryLedger SET subsidiaryAddress = '" & addressInput.Text & "',subsidiaryLandlineNo = '" & landlineInput.Text & "',subsidiaryMobileNo = '" & mobileInput.Text & "',subsidiaryContactPerson = '" & contactPersonInput.Text & "',subsidiaryEmail = '" & emailInput.Text & "',ntn = '" & ntnInput.Text & "',areadID = '" & areaInput.SelectedValue & "',subAreaID = '" & subAreaInput.SelectedValue & "',salesPersonnelID = '" & salePersonnelInput.SelectedValue & "' WHERE subsidiaryLedgerID = '" & customerIDGot & "' ", conn)
        affector = comm.ExecuteNonQuery
        MessageBox.Show("Record has been updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
        Call loadRecordsAll()
    End Sub
    Private Sub customerDetails_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class