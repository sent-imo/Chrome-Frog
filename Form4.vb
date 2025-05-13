Public Class frmAbout
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub mnuMainmenu_Click(sender As Object, e As EventArgs) Handles mnuMainmenu.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs)
        Dim ans
        ans = MsgBox("Do you want to exit?", 1 + 32, "Exit")
        If ans = vbOK Then
            End
            If ans = vbCancel Then
                Show
            End If
        End If
    End Sub

    Private Sub mnuHow_Click(sender As Object, e As EventArgs) Handles mnuHow.Click
        frmHow.Show()
        Me.Hide()
    End Sub
End Class