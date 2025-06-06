﻿Module HelperNavigation
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