Public Class frmMainMenu
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Dim gameForm As New frmStart()
        gameForm.Show()
        Me.Hide()
    End Sub
    Private Sub CmdHowToPlay_Click(sender As Object, e As EventArgs) Handles CmdHowToPlay.Click
        frmHow.Show()
        Me.Hide()
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim ans
        ans = MsgBox("Do you want to exit?", 1 + 32, "Exit")
        If ans = vbOK Then
            End
            If ans = vbCancel Then
                Me.Show()
            End If
        End If
    End Sub
    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
        Me.Hide()
    End Sub

    Private Sub frmMainMenu_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        MenuStrip1.SendToBack()
        MenuStrip1.BringToFront()

        If Me.Visible Then
            My.Computer.Audio.Play("C:\Users\Fixfone\source\repos\Chrome Frog\Resources\Cipher2.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim ans
        ans = MsgBox("Do you want to exit?", 1 + 32, "Exit")
        If ans = vbOK Then
            End
            If ans = vbCancel Then
                Me.Show()
            End If
        End If
    End Sub
    Private Sub mnuHow_Click(sender As Object, e As EventArgs) Handles mnuHow.Click
        frmHow.Show()
        Me.Hide()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
        Me.Hide()
    End Sub

End Class