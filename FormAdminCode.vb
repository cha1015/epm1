Public Class FormAdminCode
    Public Property AdminCode As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        AdminCode = txtAdminCode.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class