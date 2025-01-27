Public Class splashScreen
    Private Sub splashScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1.5)
        Label2.Text = "Loading... " & ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim facebookPage As String = "https://www.facebook.com/HexagonSolutionz"
        Process.Start(facebookPage)
    End Sub
End Class