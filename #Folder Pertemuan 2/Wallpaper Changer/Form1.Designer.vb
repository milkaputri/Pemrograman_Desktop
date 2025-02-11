<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        GarisBatasToolStripMenuItem = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        TimerWall = New Timer(components)
        ToolStripStatusReady = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lblPath = New Label()
        txtPath = New TextBox()
        btnBrowse = New Button()
        TimerElapsed = New Timer(components)
        lblInterval = New Label()
        clbWallpaper = New CheckedListBox()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        cbInterval = New ComboBox()
        btnRun = New Button()
        MenuStrip1.SuspendLayout()
        ToolStripStatusReady.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(790, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, GarisBatasToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(122, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' GarisBatasToolStripMenuItem
        ' 
        GarisBatasToolStripMenuItem.Name = "GarisBatasToolStripMenuItem"
        GarisBatasToolStripMenuItem.Size = New Size(119, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(122, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(224, 26)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' TimerWall
        ' 
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.ImageScalingSize = New Size(20, 20)
        ToolStripStatusReady.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusCurrent})
        ToolStripStatusReady.Location = New Point(0, 376)
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(790, 26)
        ToolStripStatusReady.TabIndex = 1
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(53, 20)
        ToolStripStatusLabel1.Text = "Ready."
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(172, 20)
        ToolStripStatusCurrent.Text = "Current Wallpaper: none."
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(25, 37)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(90, 20)
        lblPath.TabIndex = 2
        lblPath.Text = "Folder Path :"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(121, 34)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(569, 27)
        txtPath.TabIndex = 3
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(696, 37)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(36, 29)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(366, 304)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(61, 20)
        lblInterval.TabIndex = 6
        lblInterval.Text = "Interval:"
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(25, 117)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(313, 246)
        clbWallpaper.TabIndex = 7
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(366, 90)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(128, 24)
        cbPreview.TabIndex = 8
        cbPreview.Text = "Preview Image"
        cbPreview.TextImageRelation = TextImageRelation.ImageBeforeText
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(366, 117)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 184)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(356, 174)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 20)
        Label1.TabIndex = 10
        Label1.Text = "Please select one or more"
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 secs", "30 secs", "1 minutes"})
        cbInterval.Location = New Point(433, 307)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(151, 28)
        cbInterval.TabIndex = 11
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(633, 307)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(94, 29)
        btnRun.TabIndex = 12
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(790, 402)
        Controls.Add(btnRun)
        Controls.Add(cbInterval)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(clbWallpaper)
        Controls.Add(lblInterval)
        Controls.Add(btnBrowse)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Controls.Add(ToolStripStatusReady)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStripStatusReady.ResumeLayout(False)
        ToolStripStatusReady.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerWall As Timer
    Friend WithEvents ToolStripStatusReady As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GarisBatasToolStripMenuItem As ToolStripSeparator
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents lblInterval As Label
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents btnRun As Button

End Class
