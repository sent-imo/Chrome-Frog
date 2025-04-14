Public Class frmMainMenu
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        frmStart.Show()
        Me.Hide()
    End Sub
    Private Sub CmdHowToPlay_Click(sender As Object, e As EventArgs) Handles CmdHowToPlay.Click
        frmHow.Show()
        Me.Hide()
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub
    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
        Me.Hide()
    End Sub
End Class