<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        PictureBox1 = New PictureBox()
        imgGround = New PictureBox()
        picFrog = New PictureBox()
        picRock = New PictureBox()
        GameTimer = New Timer(components)
        lblScore = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgGround, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFrog, ComponentModel.ISupportInitialize).BeginInit()
        CType(picRock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.garden
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(-7, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(698, 409)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' imgGround
        ' 
        imgGround.BackgroundImage = CType(resources.GetObject("imgGround.BackgroundImage"), Image)
        imgGround.Location = New Point(-7, 358)
        imgGround.Name = "imgGround"
        imgGround.Size = New Size(710, 91)
        imgGround.TabIndex = 3
        imgGround.TabStop = False
        ' 
        ' picFrog
        ' 
        picFrog.BackColor = Color.Transparent
        picFrog.Image = CType(resources.GetObject("picFrog.Image"), Image)
        picFrog.Location = New Point(12, 272)
        picFrog.Name = "picFrog"
        picFrog.Size = New Size(100, 80)
        picFrog.SizeMode = PictureBoxSizeMode.Zoom
        picFrog.TabIndex = 4
        picFrog.TabStop = False
        ' 
        ' picRock
        ' 
        picRock.BackColor = Color.Transparent
        picRock.Image = CType(resources.GetObject("picRock.Image"), Image)
        picRock.Location = New Point(596, 322)
        picRock.Name = "picRock"
        picRock.Size = New Size(50, 30)
        picRock.SizeMode = PictureBoxSizeMode.Zoom
        picRock.TabIndex = 6
        picRock.TabStop = False
        picRock.Tag = "Obstacle"
        ' 
        ' GameTimer
        ' 
        GameTimer.Enabled = True
        GameTimer.Interval = 20
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Teal
        lblScore.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = SystemColors.ControlLight
        lblScore.Location = New Point(586, 9)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(70, 16)
        lblScore.TabIndex = 7
        lblScore.Text = "Score: "
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(686, 408)
        Controls.Add(lblScore)
        Controls.Add(picRock)
        Controls.Add(picFrog)
        Controls.Add(imgGround)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "frmStart"
        Text = "Start"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(imgGround, ComponentModel.ISupportInitialize).EndInit()
        CType(picFrog, ComponentModel.ISupportInitialize).EndInit()
        CType(picRock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgGround As PictureBox
    Friend WithEvents picFrog As PictureBox
    Friend WithEvents picRock As PictureBox
    Friend WithEvents GameTimer As Timer
    Friend WithEvents lblScore As Label
End Class
