Public Class FormWelcome


    Private Sub FormWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeTimer.Interval = 1000
        welcomeTimer.Start()
    End Sub

    Private Sub welcomeTimer_Tick(sender As Object, e As EventArgs) Handles welcomeTimer.Tick
        welcomeTimer.Stop()
        Dim mainForm As New FormMain()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


End Class

