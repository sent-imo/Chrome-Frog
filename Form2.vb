Public Class frmStart
    Dim isJumping As Boolean = False
    Dim jumpHeight As Integer = 10
    Dim gameSpeed As Integer = 10
    Dim fallSpeed As Integer = 8
    Dim score As Integer = 0
    Dim random As New Random()
    Dim keyIsPressed As Boolean = False
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picFrog.Size = New Size(90, 80)
        picFrog.BackColor = Color.Transparent
        picFrog.Top = Me.ClientSize.Height - picFrog.Height - 50
        picFrog.Left = 100

        picRock.Size = New Size(50, 30)
        picRock.BackColor = Color.Transparent
        picRock.Top = Me.ClientSize.Height - picRock.Height - 50
        picRock.Left = Me.ClientSize.Width

        GameTimer.Interval = 30
        GameTimer.Start()

        Me.DoubleBuffered = True
        Me.KeyPreview = True
    End Sub
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        picRock.Left -= gameSpeed

        If score > 5 And score < 10 Then
            gameSpeed = 10
        End If

        If score > 15 And score < 20 Then
            gameSpeed = 15
        End If

        If score > 25 And score < 30 Then
            gameSpeed = 20
        End If

        If score > 35 And score < 40 Then
            gameSpeed = 25
        End If

        If score > 45 And score < 50 Then
            gameSpeed = 30
        End If

        If score > 50 And score < 60 Then
            gameSpeed = 35
        End If

        If score > 70 And score < 80 Then
            gameSpeed = 40
        End If

        If score > 80 And score < 100 Then
            gameSpeed = 45
        End If

        If picRock.Left < -picRock.Width Then
            picRock.Left = Me.ClientSize.Width
            picRock.Top = Me.ClientSize.Height - picRock.Height - 50
            score += 1
            lblScore.Text = "Score: " & score
        End If

        If isJumping Then
            picFrog.Top -= jumpHeight
            jumpHeight -= 1

            If jumpHeight <= 0 Then
                isJumping = False
            End If
        Else

            If picFrog.Top < Me.ClientSize.Height - picFrog.Height - 50 Then
                picFrog.Top += fallSpeed

                If picFrog.Top > Me.ClientSize.Height - picFrog.Height - 50 Then
                    picFrog.Top = Me.ClientSize.Height - picFrog.Height - 50
                End If
            End If
        End If

        If picFrog.Bounds.IntersectsWith(picRock.Bounds) Then
            GameTimer.Stop()
            MessageBox.Show("Game Over! Score: " & score)
            Application.Restart()
        End If
    End Sub
    Private Sub frmStart_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim groundLevel As Integer = Me.ClientSize.Height - picFrog.Height - 50

        If (e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.W) AndAlso
       Not isJumping AndAlso picFrog.Top >= groundLevel Then

            isJumping = True
            jumpHeight = 15
        End If
    End Sub
End Class