Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class changePassword
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If newPasswordInput.Text = "" Then
            MessageBox.Show("Please Choose a New Password")
            newPasswordInput.Focus()
        ElseIf confirmPasswordInput.Text = "" Then
            MessageBox.Show("Please Confirm Your Password")
            confirmPasswordInput.Focus()
        ElseIf confirmPasswordInput.Text <> newPasswordInput.Text Then
            MessageBox.Show("Please Confirm Your Password")
            confirmPasswordInput.Focus()
        Else
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("UPDATE userAuth SET userPassword = '" & newPasswordInput.Text & "' WHERE userName = '" & userNameInput.Text & "' ", conn)
            affector = comm.ExecuteNonQuery
            MessageBox.Show("Password has been Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clearAll()
            newPasswordInput.ReadOnly = True
            confirmPasswordInput.ReadOnly = True
            newPasswordInput.Text = Nothing
            confirmPasswordInput.Text = Nothing
            userNameInput.Focus()
            conn.Close()
        End If
    End Sub
    Private Sub clearAll()
        'Clear Input Fields on Click New
        userNameInput.Text = Nothing
        passwordInput.Text = Nothing
    End Sub
    Private Sub newUser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click
        If userNameInput.Text = "" Then
            MessageBox.Show("Please Enter a User Name")
            userNameInput.Focus()
        ElseIf passwordInput.Text = "" Then
            MessageBox.Show("Please Enter Your Password")
            passwordInput.Focus()
        ElseIf newPasswordInput.Text <> "" Then
            btnSave.PerformClick()
        Else
            conn = New SqlConnection(constr)
            conn.Open()
            'SQL Validation for duplicate record
            Dim valcommand1 As New SqlCommand("SELECT * FROM userAuth WHERE userName = @input1got AND userPassword = @input2got", conn)
            valcommand1.Parameters.Add("@input1got", SqlDbType.VarChar).Value = userNameInput.Text
            valcommand1.Parameters.Add("@input2got", SqlDbType.VarChar).Value = passwordInput.Text
            Dim valadapter1 As New SqlDataAdapter(valcommand1)
            Dim valtable1 As New DataTable()
            valadapter1.Fill(valtable1)
            If valtable1.Rows.Count() > 0 Then
                newPasswordInput.ReadOnly = False
                confirmPasswordInput.ReadOnly = False
                newPasswordInput.Focus()
            Else
                MsgBox("Please Check Your Username and Password")
                Call clearAll()
                userNameInput.Focus()
            End If
            conn.Close()
        End If
    End Sub
End Class