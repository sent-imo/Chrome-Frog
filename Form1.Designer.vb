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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdStart
        ' 
        cmdStart.AllowDrop = True
        cmdStart.AutoSize = True
        cmdStart.BackColor = Color.Teal
        cmdStart.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdStart.ForeColor = SystemColors.ControlLight
        cmdStart.Location = New Point(297, 200)
        cmdStart.Name = "cmdStart"
        cmdStart.Size = New Size(93, 35)
        cmdStart.TabIndex = 0
        cmdStart.Text = "&Start"
        cmdStart.UseVisualStyleBackColor = False
        ' 
        ' lblChromeFrog
        ' 
        lblChromeFrog.AutoSize = True
        lblChromeFrog.BackColor = Color.Transparent
        lblChromeFrog.Font = New Font("ISOCPEUR", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChromeFrog.ForeColor = Color.White
        lblChromeFrog.Location = New Point(79, 44)
        lblChromeFrog.Name = "lblChromeFrog"
        lblChromeFrog.Size = New Size(529, 118)
        lblChromeFrog.TabIndex = 1
        lblChromeFrog.Text = "Chrome Frog"
        lblChromeFrog.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CmdHowToPlay
        ' 
        CmdHowToPlay.BackColor = Color.Teal
        CmdHowToPlay.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CmdHowToPlay.ForeColor = SystemColors.ControlLight
        CmdHowToPlay.Location = New Point(257, 241)
        CmdHowToPlay.Name = "CmdHowToPlay"
        CmdHowToPlay.Size = New Size(172, 35)
        CmdHowToPlay.TabIndex = 2
        CmdHowToPlay.Text = "&How To Play"
        CmdHowToPlay.UseVisualStyleBackColor = False
        ' 
        ' cmdAbout
        ' 
        cmdAbout.BackColor = Color.Teal
        cmdAbout.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdAbout.ForeColor = SystemColors.ControlLight
        cmdAbout.Location = New Point(297, 282)
        cmdAbout.Name = "cmdAbout"
        cmdAbout.Size = New Size(93, 35)
        cmdAbout.TabIndex = 3
        cmdAbout.Text = "&About"
        cmdAbout.UseVisualStyleBackColor = False
        ' 
        ' cmdExit
        ' 
        cmdExit.BackColor = Color.Teal
        cmdExit.Font = New Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdExit.ForeColor = SystemColors.ControlLight
        cmdExit.Location = New Point(297, 323)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(93, 35)
        cmdExit.TabIndex = 4
        cmdExit.Text = "&Exit"
        cmdExit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.garden
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(688, 414)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
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
        DoubleBuffered = True
        Font = New Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ImeMode = ImeMode.Off
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMainMenu"
        RightToLeft = RightToLeft.No
        Text = "Main Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdStart As Button
    Friend WithEvents lblChromeFrog As Label
    Friend WithEvents CmdHowToPlay As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
