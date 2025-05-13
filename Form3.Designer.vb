<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHow))
        cmdBack = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox4 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        mnuHome = New ToolStripMenuItem()
        mnuMainmenu = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuOther = New ToolStripMenuItem()
        mnuHow = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmdBack
        ' 
        cmdBack.BackColor = Color.Teal
        cmdBack.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdBack.ForeColor = SystemColors.ActiveCaptionText
        cmdBack.Location = New Point(12, 27)
        cmdBack.Name = "cmdBack"
        cmdBack.Size = New Size(75, 23)
        cmdBack.TabIndex = 1
        cmdBack.Text = "&Back"
        cmdBack.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.garden
        PictureBox1.Location = New Point(586, -54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(691, 12)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Minecraft", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(245, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 27)
        Label1.TabIndex = 4
        Label1.Text = "How To Play?"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(200, 99)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 50)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(439, 99)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 50)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(108, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(472, 12)
        Label2.TabIndex = 7
        Label2.Text = "To make the frog jump, simply press the spacebar or the W key on"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(102, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(485, 12)
        Label3.TabIndex = 8
        Label3.Text = "your keyboard. The longer you survive, the higher your score climbs. "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(599, 12)
        Label4.TabIndex = 9
        Label4.Text = "Time your jumps carefully and stay alert, because one wrong move can end the run!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(127, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(435, 12)
        Label5.TabIndex = 10
        Label5.Text = "Whether you're aiming to beat your personal best or climb the"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(67, 322)
        Label6.Name = "Label6"
        Label6.Size = New Size(554, 12)
        Label6.TabIndex = 11
        Label6.Text = "global leaderboard, this endless adventure will keep you coming back for more."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Minecraft", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(217, 354)
        Label7.Name = "Label7"
        Label7.Size = New Size(255, 12)
        Label7.TabIndex = 12
        Label7.Text = "Dive in and see how far you can go!"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.garden
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(691, 410)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuHome, mnuOther})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(688, 24)
        MenuStrip1.TabIndex = 14
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
        ' frmHow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(688, 407)
        Controls.Add(MenuStrip1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(cmdBack)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        DoubleBuffered = True
        Name = "frmHow"
        Text = "How To Play"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuMainmenu As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuOther As ToolStripMenuItem
    Friend WithEvents mnuHow As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
