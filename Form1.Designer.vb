<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        cmdStart = New Button()
        lblChromeFrog = New Label()
        CmdHowToPlay = New Button()
        cmdAbout = New Button()
        cmdExit = New Button()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        mnuHome = New ToolStripMenuItem()
        mnuMainmenu = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuOther = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        mnuHow = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmdStart
        ' 
        cmdStart.AllowDrop = True
        cmdStart.AutoSize = True
        cmdStart.BackColor = Color.Teal
        cmdStart.Font = New Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdStart.ForeColor = SystemColors.ActiveCaptionText
        cmdStart.Location = New Point(296, 191)
        cmdStart.Name = "cmdStart"
        cmdStart.Size = New Size(93, 35)
        cmdStart.TabIndex = 0
        cmdStart.Text = "&Start"
        cmdStart.UseVisualStyleBackColor = False
        ' 
        ' lblChromeFrog
        ' 
        lblChromeFrog.AllowDrop = True
        lblChromeFrog.AutoSize = True
        lblChromeFrog.BackColor = Color.Transparent
        lblChromeFrog.Font = New Font("Minecraft", 65.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChromeFrog.ForeColor = SystemColors.ActiveCaptionText
        lblChromeFrog.Location = New Point(39, 86)
        lblChromeFrog.Name = "lblChromeFrog"
        lblChromeFrog.Size = New Size(609, 87)
        lblChromeFrog.TabIndex = 1
        lblChromeFrog.Text = "Chrome Frog"
        lblChromeFrog.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CmdHowToPlay
        ' 
        CmdHowToPlay.BackColor = Color.Teal
        CmdHowToPlay.Font = New Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CmdHowToPlay.ForeColor = SystemColors.ActiveCaptionText
        CmdHowToPlay.Location = New Point(256, 240)
        CmdHowToPlay.Name = "CmdHowToPlay"
        CmdHowToPlay.Size = New Size(172, 35)
        CmdHowToPlay.TabIndex = 2
        CmdHowToPlay.Text = "&How To Play"
        CmdHowToPlay.UseVisualStyleBackColor = False
        ' 
        ' cmdAbout
        ' 
        cmdAbout.BackColor = Color.Teal
        cmdAbout.Font = New Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdAbout.ForeColor = SystemColors.ActiveCaptionText
        cmdAbout.Location = New Point(296, 289)
        cmdAbout.Name = "cmdAbout"
        cmdAbout.Size = New Size(93, 35)
        cmdAbout.TabIndex = 3
        cmdAbout.Text = "&About"
        cmdAbout.UseVisualStyleBackColor = False
        ' 
        ' cmdExit
        ' 
        cmdExit.BackColor = Color.Teal
        cmdExit.Font = New Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdExit.ForeColor = SystemColors.ActiveCaptionText
        cmdExit.Location = New Point(296, 338)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(93, 35)
        cmdExit.TabIndex = 4
        cmdExit.Text = "&Exit"
        cmdExit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.garden
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(685, 411)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuHome, mnuOther})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(686, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "Menu Bar"
        ' 
        ' mnuHome
        ' 
        mnuHome.DropDownItems.AddRange(New ToolStripItem() {mnuMainmenu, mnuExit})
        mnuHome.Name = "mnuHome"
        mnuHome.Size = New Size(52, 20)
        mnuHome.Text = "&Home"
        ' 
        ' mnuMainmenu
        ' 
        mnuMainmenu.Name = "mnuMainmenu"
        mnuMainmenu.ShortcutKeys = Keys.Alt Or Keys.M
        mnuMainmenu.Size = New Size(176, 22)
        mnuMainmenu.Text = "&Main Menu"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuExit.Size = New Size(176, 22)
        mnuExit.Text = "Exit"
        ' 
        ' mnuOther
        ' 
        mnuOther.DropDownItems.AddRange(New ToolStripItem() {mnuHow, mnuAbout})
        mnuOther.Name = "mnuOther"
        mnuOther.Size = New Size(49, 20)
        mnuOther.Text = "&Other"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.ShortcutKeys = Keys.Alt Or Keys.A
        mnuAbout.Size = New Size(175, 22)
        mnuAbout.Text = "&About"
        ' 
        ' mnuHow
        ' 
        mnuHow.Name = "mnuHow"
        mnuHow.ShortcutKeys = Keys.Alt Or Keys.P
        mnuHow.Size = New Size(175, 22)
        mnuHow.Text = "How to Play"
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(6F, 12F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.garden
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(686, 413)
        Controls.Add(cmdExit)
        Controls.Add(cmdAbout)
        Controls.Add(CmdHowToPlay)
        Controls.Add(lblChromeFrog)
        Controls.Add(cmdStart)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Font = New Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ImeMode = ImeMode.Off
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMainMenu"
        RightToLeft = RightToLeft.No
        Text = "Main Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdStart As Button
    Friend WithEvents lblChromeFrog As Label
    Friend WithEvents CmdHowToPlay As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuOther As ToolStripMenuItem
    Friend WithEvents mnuMainmenu As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHow As ToolStripMenuItem
End Class
