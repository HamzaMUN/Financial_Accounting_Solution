Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Configuration
Public Class dbBackup
    Dim constr As String = ConfigurationManager.ConnectionStrings("erpConnect").ConnectionString
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Private Sub dbBackup_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If nameInput.Text = "" Then
            MsgBox("Please Choose a Backup Name")
            nameInput.Focus()
        Else
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                Dim fileNameGot As String = nameInput.Text
                Dim strquery As String
                strquery = "BACKUP DATABASE hx_erp_1 TO DISK = '" & Application.StartupPath & "\Backups\" & fileNameGot & ".BAK'"
                Try
                    comm = New SqlCommand(strquery, conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Backup has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class