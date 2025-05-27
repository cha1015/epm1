'Public Class HelperNavigation

'    Public Shared BackHistory As New Stack(Of System.Windows.Forms.Form)()
'    Public Shared ForwardHistory As New Stack(Of System.Windows.Forms.Form)() ' ✅ Ensure this is declared
'    Private Shared LastForm As System.Windows.Forms.Form ' To keep track of the last form


'    Public Shared Sub GoNext(currentForm As System.Windows.Forms.Form, nextForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
'        If nextForm IsNot Nothing Then
'            BackHistory.Push(currentForm) ' Store current form for back navigation
'            LastForm = nextForm ' Store the last form
'            nextForm.Show()
'            currentForm.Hide()

'            ' Clear forward history when moving forward
'            ForwardHistory.Clear()

'            UpdateButtonStates(btnNext, btnBack)
'        End If
'    End Sub

'    Public Shared Sub GoBack(currentForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
'        If BackHistory.Count > 0 Then
'            Dim previousForm As System.Windows.Forms.Form = BackHistory.Pop()
'            ForwardHistory.Push(currentForm) ' Save current form in forward history
'            previousForm.Show()
'            currentForm.Hide()
'        End If
'    End Sub


'    Public Shared Sub GoNextAgain(currentForm As System.Windows.Forms.Form, btnNext As Button, btnBack As Button)
'        If ForwardHistory.Count > 0 Then ' ✅ Ensure there's a form to redo
'            Dim redoForm As System.Windows.Forms.Form = ForwardHistory.Pop() ' Get the last undone form
'            BackHistory.Push(currentForm) ' Store current form for back navigation
'            redoForm.Show()
'            currentForm.Hide()

'            ' Ensure Redo is tracking the right history
'            LastForm = redoForm

'            UpdateButtonStates(btnNext, btnBack)
'        Else
'            'MessageBox.Show("No next form to redo!") ' Prevent error
'            btnNext.Enabled = False ' Disable next button if no form to redo    
'        End If
'    End Sub


'    Private Shared Sub UpdateButtonStates(btnNext As Button, btnBack As Button)
'        btnBack.Enabled = BackHistory.Count > 0
'        btnNext.Enabled = LastForm IsNot Nothing ' Enable next if there is a last form
'    End Sub
'End Class

Module HelperNavigation
    Private backStack As New Stack(Of Form)
    Private forwardStack As New Stack(Of Form)
    Private lastForm As Form = Nothing


    Public Sub RegisterNewForm(currentForm As Form)
        If lastForm IsNot Nothing Then
            backStack.Push(lastForm)
            forwardStack.Clear()
        End If

        lastForm = currentForm
        UpdateButtons(currentForm)
    End Sub

    Public Sub GoBack(currentForm As Form)
        If backStack.Count > 0 Then
            Dim previousForm As Form = backStack.Pop()
            forwardStack.Push(currentForm)

            If previousForm.WindowState = FormWindowState.Minimized Then
                previousForm.WindowState = FormWindowState.Normal
            End If

            previousForm.Show()
            previousForm.BringToFront()
            previousForm.Activate()

            currentForm.Hide()

            lastForm = previousForm
            UpdateButtons(previousForm)
        End If
    End Sub


    Public Sub GoNext(currentForm As Form)
        If forwardStack.Count > 0 Then
            Dim nextForm As Form = forwardStack.Pop()
            backStack.Push(currentForm)

            nextForm.Show()
            currentForm.Hide()

            lastForm = nextForm
            UpdateButtons(nextForm)
        End If
    End Sub

    Private Sub UpdateButtons(currentForm As Form)
        Dim btnBack = TryCast(currentForm.Controls("btnBack"), Button)
        Dim btnNext = TryCast(currentForm.Controls("btnNext"), Button)

        If btnBack IsNot Nothing Then btnBack.Enabled = backStack.Count > 0
        If btnNext IsNot Nothing Then btnNext.Enabled = forwardStack.Count > 0
    End Sub
End Module
