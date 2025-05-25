Public Class Welcome
    Private WithEvents startupTimer As New Timer()

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        startupTimer.Interval = 7000
        startupTimer.Start()
    End Sub

    Private Sub startupTimer_Tick(sender As Object, e As EventArgs) Handles startupTimer.Tick
        startupTimer.Stop()

        Dim mainForm As New FormMain()
        mainForm.Show()


        Me.Hide()
    End Sub
End Class
