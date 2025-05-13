
Public Class frmStart
    Dim isJumping As Boolean = False
    Dim jumpHeight As Integer = 10
    Dim gameSpeed As Integer = 15
    Dim fallSpeed As Integer = 10
    Dim score As Integer = 0
    Dim random As New Random()
    Dim keyIsPressed As Boolean = False
    Dim nextObstacleOffset As Integer = 0
    Dim obstacleTypes As String() = {"Rock", "Bird"}
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picFrog.Size = New Size(90, 80)
        picFrog.BackColor = Color.Transparent
        picFrog.Top = Me.ClientSize.Height - picFrog.Height - 50
        picFrog.Left = 100

        picRock.Size = New Size(50, 30)
        picRock.BackColor = Color.Transparent
        picRock.Top = Me.ClientSize.Height - picRock.Height - 50
        picRock.Left = Me.ClientSize.Width
        picRock.Visible = False

        picBird.Size = New Size(70, 50)
        picBird.BackColor = Color.Transparent
        picBird.Left = Me.ClientSize.Width
        picBird.Visible = False

        nextObstacleOffset = random.Next(100, 200)

        GameTimer.Interval = 30
        GameTimer.Start()

        Me.DoubleBuffered = True
        Me.KeyPreview = True
    End Sub
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If picRock.Visible Then picRock.Left -= gameSpeed
        If picBird.Visible Then picBird.Left -= gameSpeed + (random.Next(1, 2))
        If score > 5 Then gameSpeed = 20 + (score \ 10)
        If gameSpeed > 100 Then gameSpeed = 100
        HandleObstacles()

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

        If (picRock.Visible AndAlso picFrog.Bounds.IntersectsWith(picRock.Bounds)) Or
           (picBird.Visible AndAlso picFrog.Bounds.IntersectsWith(picBird.Bounds)) Then
            GameTimer.Stop()
            MessageBox.Show("Game Over! Score: " & score)
            frmMainMenu.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub HandleObstacles()
        If Not picRock.Visible AndAlso Not picBird.Visible Then
            nextObstacleOffset -= gameSpeed
            If nextObstacleOffset <= 0 Then
                SpawnRandomObstacle()
                nextObstacleOffset = random.Next(100, 200)
            End If
        End If

        If picRock.Visible AndAlso picRock.Left < -picRock.Width Then
            picRock.Visible = False
            score += 1
            lblScore.Text = "Score: " & score
            My.Computer.Audio.Play("C:\Users\Fixfone\source\repos\Chrome Frog\Resources\jump.wav")
        End If

        If picBird.Visible AndAlso picBird.Left < -picBird.Width Then
            picBird.Visible = False
            score += 1
            lblScore.Text = "Score: " & score
            My.Computer.Audio.Play("C:\Users\Fixfone\source\repos\Chrome Frog\Resources\jump.wav")
        End If
    End Sub
    Private Sub SpawnRandomObstacle()
        Dim obstacleType As String = obstacleTypes(random.Next(0, obstacleTypes.Length))

        Select Case obstacleType
            Case "Rock"
                picRock.Left = Me.ClientSize.Width
                picRock.Top = Me.ClientSize.Height - picRock.Height - 50
                picRock.Visible = True

            Case "Bird"
                picBird.Left = Me.ClientSize.Width
                picBird.Top = random.Next(Me.ClientSize.Height \ 3, Me.ClientSize.Height \ 2)
                picBird.Visible = True
        End Select
    End Sub
    Private Sub frmStart_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim groundLevel As Integer = Me.ClientSize.Height - picFrog.Height - 50

        If (e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.W) AndAlso
           Not isJumping AndAlso picFrog.Top >= groundLevel Then
            isJumping = True
            jumpHeight = 15
        End If
    End Sub

    Private Sub mnuMainmenu_Click(sender As Object, e As EventArgs)
        frmMainMenu.Show
        Hide
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

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs)
        frmAbout.Show
        Hide
    End Sub

    Private Sub mnuHow_Click(sender As Object, e As EventArgs) Handles mnuHow.Click
        frmHow.Show()
        Me.Hide()
    End Sub
End Class