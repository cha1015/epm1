Public Class FormCustomerAdminInfo
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If HelperNavigation.ForwardHistory.Count > 0 Then ' ✅ Ensure the right reference
            Dim nextForm As System.Windows.Forms.Form = HelperNavigation.ForwardHistory.Pop() ' ✅ Retrieve last undone form
            HelperNavigation.GoNext(Me, nextForm, btnNext, btnBack) ' ✅ Restore previous form
        Else
            btnNext.Enabled = False ' Disable next button if no form to redo
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HelperNavigation.GoBack(Me, btnNext, btnBack)
    End Sub
End Class