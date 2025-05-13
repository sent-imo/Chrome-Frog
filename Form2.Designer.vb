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
        imgGround = New PictureBox()
        picFrog = New PictureBox()
        picRock = New PictureBox()
        GameTimer = New Timer(components)
        lblScore = New Label()
        picBird = New PictureBox()
        MenuStrip2 = New MenuStrip()
        mnuHome = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        mnuOthers = New ToolStripMenuItem()
        mnuHow = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        CType(imgGround, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFrog, ComponentModel.ISupportInitialize).BeginInit()
        CType(picRock, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBird, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
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
        picFrog.Size = New Size(93, 80)
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
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Minecraft", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = SystemColors.ActiveCaptionText
        lblScore.Location = New Point(577, 39)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(69, 16)
        lblScore.TabIndex = 7
        lblScore.Text = "Score: "
        ' 
        ' picBird
        ' 
        picBird.BackColor = Color.Transparent
        picBird.Image = CType(resources.GetObject("picBird.Image"), Image)
        picBird.Location = New Point(470, 184)
        picBird.Name = "picBird"
        picBird.Size = New Size(77, 52)
        picBird.SizeMode = PictureBoxSizeMode.Zoom
        picBird.TabIndex = 8
        picBird.TabStop = False
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.GripStyle = ToolStripGripStyle.Visible
        MenuStrip2.Items.AddRange(New ToolStripItem() {mnuHome, mnuOthers})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(686, 24)
        MenuStrip2.TabIndex = 10
        MenuStrip2.Text = "Menu Bar"
        ' 
        ' mnuHome
        ' 
        mnuHome.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3})
        mnuHome.Name = "mnuHome"
        mnuHome.Size = New Size(52, 20)
        mnuHome.Text = "&Home"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.ShortcutKeys = Keys.Alt Or Keys.M
        ToolStripMenuItem2.Size = New Size(176, 22)
        ToolStripMenuItem2.Text = "&Main Menu"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.ShortcutKeys = Keys.Alt Or Keys.F4
        ToolStripMenuItem3.Size = New Size(176, 22)
        ToolStripMenuItem3.Text = "Exit"
        ' 
        ' mnuOthers
        ' 
        mnuOthers.DropDownItems.AddRange(New ToolStripItem() {mnuHow, mnuAbout})
        mnuOthers.Name = "mnuOthers"
        mnuOthers.ShortcutKeys = Keys.Alt Or Keys.A
        mnuOthers.Size = New Size(49, 20)
        mnuOthers.Text = "&Other"
        ' 
        ' mnuHow
        ' 
        mnuHow.Name = "mnuHow"
        mnuHow.ShortcutKeys = Keys.Alt Or Keys.P
        mnuHow.Size = New Size(180, 22)
        mnuHow.Text = "How to Play"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.ShortcutKeys = Keys.Alt Or Keys.A
        mnuAbout.Size = New Size(180, 22)
        mnuAbout.Text = "&About"
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(686, 408)
        Controls.Add(MenuStrip2)
        Controls.Add(picBird)
        Controls.Add(lblScore)
        Controls.Add(picRock)
        Controls.Add(picFrog)
        Controls.Add(imgGround)
        DoubleBuffered = True
        Name = "frmStart"
        Text = "Start"
        CType(imgGround, ComponentModel.ISupportInitialize).EndInit()
        CType(picFrog, ComponentModel.ISupportInitialize).EndInit()
        CType(picRock, ComponentModel.ISupportInitialize).EndInit()
        CType(picBird, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents imgGround As PictureBox
    Friend WithEvents picFrog As PictureBox
    Friend WithEvents picRock As PictureBox
    Friend WithEvents GameTimer As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents picBird As PictureBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents mnuOthers As ToolStripMenuItem
    Friend WithEvents mnuHow As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
