Imports System.IO
Public Class AppValidation
    Dim activateKeyVal As String = "12345"
    Dim activationName As String = "Kishwer Naqvi"
    Private Sub AppValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        activateVal1()
    End Sub
    Private Sub activateVal1()
        If File.Exists("C:\Windows\System32\config\hxpkgauth1") Then
            activateVal2()
        Else
            activateVal3()
        End If
    End Sub
    Private Sub activateVal2()
        If File.Exists("auth") Then
            activateVal4()
        Else
            activateVal5()
        End If
    End Sub
    Private Sub activateVal3()
        Using File.Create("C:\Windows\System32\config\hxpkgauth1")

        End Using
        activateVal2()
    End Sub
    Private Sub activateVal4()
        Dim activateReader As New StreamReader("C:\Windows\System32\config\hxpkgauth1")
        Dim activateReader2 As New StreamReader("auth")
        If activateReader.ReadLine() = activateKeyVal And activateReader2.ReadLine() = activationName Then
            LoginForm.Show()
            Me.Close()
        Else
            NewActivate.Show()
            Me.Close()
        End If
    End Sub
    Private Sub activateVal5()
        Using File.Create("auth")

        End Using
        activateVal4()
    End Sub
End Class