Imports System.IO
Public Class NewActivate
    Dim activateKeyVal As String = "12345"
    Dim activateName As String = "Kishwer Naqvi"
    Dim activateCompany As String = "abc"
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        newActivationSave()
    End Sub

    Private Sub newActivationSave()
        If nameInput.Text = Nothing Then
            nameInput.Focus()
        ElseIf keyInput.Text = Nothing Then
            keyInput.Focus()
        ElseIf companyInput.Text = Nothing Then
            companyInput.Focus()
        Else
            If nameInput.Text = activateName And keyInput.Text = activateKeyVal And companyInput.Text = activateCompany Then
                Using activationKeyWrite As New StreamWriter("C:\Windows\System32\config\hxpkgauth1")
                    activationKeyWrite.WriteLine(keyInput.Text)
                End Using
                Using activationNameWrite As New StreamWriter("auth")
                    activationNameWrite.WriteLine(nameInput.Text)
                End Using
                MessageBox.Show("Activation Successful.", "Thanks for Activation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoginForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Please Confirm Your License.", "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class