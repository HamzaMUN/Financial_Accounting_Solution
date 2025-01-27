Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class newUser
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If userNameInput.Text = "" Then
            MessageBox.Show("Please Enter a valid User Name")
            userNameInput.Focus()
        ElseIf passwordInput.Text = "" Then
            MessageBox.Show("Please Choose a Password")
            passwordInput.Focus()
        ElseIf confirmPasswordInput.Text = "" Then
            MessageBox.Show("Please Confirm Your Password")
            confirmPasswordInput.Focus()
        ElseIf confirmPasswordInput.Text <> passwordInput.Text Then
            MessageBox.Show("Please Confirm Your Password")
            confirmPasswordInput.Focus()
        Else
            conn = New SqlConnection(constr)
            conn.Open()
            'SQL Validation for duplicate record
            Dim valcommand1 As New SqlCommand("SELECT * FROM userAuth WHERE userName = @input1got", conn)
            valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = userNameInput.Text
            Dim valadapter1 As New SqlDataAdapter(valcommand1)
            Dim valtable1 As New DataTable()
            valadapter1.Fill(valtable1)
            If valtable1.Rows.Count() <= 0 Then
                comm = New SqlCommand("INSERT INTO userAuth(userName, userPassword) VALUES ('" & userNameInput.Text & "' , '" & passwordInput.Text & "' )", conn)
                affector = comm.ExecuteNonQuery
                MessageBox.Show("New User has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call clearAll()
                userNameInput.Focus()
            Else
                MsgBox("User already exist!")
                Call clearAll()
                userNameInput.Focus()
            End If
            conn.Close()
        End If
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        userNameInput.Text = Nothing
        passwordInput.Text = Nothing
        confirmPasswordInput.Text = Nothing
    End Sub
    Private Sub newUser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class