Public Class FormWelcome


    Private Sub FormWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeTimer.Interval = 5000 ' 7 seconds
        welcomeTimer.Start()
    End Sub

    Private Sub welcomeTimer_Tick(sender As Object, e As EventArgs) Handles welcomeTimer.Tick
        welcomeTimer.Stop()
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub

End Class
