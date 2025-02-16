<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbRefresh = New PictureBox()
        pbMole1 = New PictureBox()
        pbMole2 = New PictureBox()
        pbMole3 = New PictureBox()
        PictureBox1 = New PictureBox()
        pbMole5 = New PictureBox()
        pbMole6 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblScore = New Label()
        lblTime = New Label()
        Label1 = New Label()
        lblHighScore = New Label()
        CType(pbRefresh, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbRefresh
        ' 
        pbRefresh.BackColor = Color.Transparent
        pbRefresh.BackgroundImage = CType(resources.GetObject("pbRefresh.BackgroundImage"), Image)
        pbRefresh.BackgroundImageLayout = ImageLayout.Stretch
        pbRefresh.Location = New Point(0, 0)
        pbRefresh.Name = "pbRefresh"
        pbRefresh.Size = New Size(65, 62)
        pbRefresh.TabIndex = 0
        pbRefresh.TabStop = False
        ' 
        ' pbMole1
        ' 
        pbMole1.BackColor = Color.Transparent
        pbMole1.BackgroundImage = CType(resources.GetObject("pbMole1.BackgroundImage"), Image)
        pbMole1.BackgroundImageLayout = ImageLayout.Stretch
        pbMole1.Location = New Point(57, 276)
        pbMole1.Name = "pbMole1"
        pbMole1.Size = New Size(134, 127)
        pbMole1.TabIndex = 1
        pbMole1.TabStop = False
        pbMole1.Visible = False
        ' 
        ' pbMole2
        ' 
        pbMole2.BackColor = Color.Transparent
        pbMole2.BackgroundImage = CType(resources.GetObject("pbMole2.BackgroundImage"), Image)
        pbMole2.BackgroundImageLayout = ImageLayout.Stretch
        pbMole2.Location = New Point(317, 209)
        pbMole2.Name = "pbMole2"
        pbMole2.Size = New Size(134, 127)
        pbMole2.TabIndex = 2
        pbMole2.TabStop = False
        pbMole2.Visible = False
        ' 
        ' pbMole3
        ' 
        pbMole3.BackColor = Color.Transparent
        pbMole3.BackgroundImage = CType(resources.GetObject("pbMole3.BackgroundImage"), Image)
        pbMole3.BackgroundImageLayout = ImageLayout.Stretch
        pbMole3.Location = New Point(464, 344)
        pbMole3.Name = "pbMole3"
        pbMole3.Size = New Size(134, 127)
        pbMole3.TabIndex = 3
        pbMole3.TabStop = False
        pbMole3.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(187, 409)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(134, 127)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' pbMole5
        ' 
        pbMole5.BackColor = Color.Transparent
        pbMole5.BackgroundImage = CType(resources.GetObject("pbMole5.BackgroundImage"), Image)
        pbMole5.BackgroundImageLayout = ImageLayout.Stretch
        pbMole5.Location = New Point(490, 492)
        pbMole5.Name = "pbMole5"
        pbMole5.Size = New Size(134, 127)
        pbMole5.TabIndex = 5
        pbMole5.TabStop = False
        pbMole5.Visible = False
        ' 
        ' pbMole6
        ' 
        pbMole6.BackColor = Color.Transparent
        pbMole6.BackgroundImage = CType(resources.GetObject("pbMole6.BackgroundImage"), Image)
        pbMole6.BackgroundImageLayout = ImageLayout.Stretch
        pbMole6.Location = New Point(48, 564)
        pbMole6.Name = "pbMole6"
        pbMole6.Size = New Size(134, 127)
        pbMole6.TabIndex = 6
        pbMole6.TabStop = False
        pbMole6.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(328, 651)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(134, 127)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = SystemColors.ButtonHighlight
        lblScore.Location = New Point(37, 180)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(73, 78)
        lblScore.TabIndex = 8
        lblScore.Text = "0"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Felix Titling", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = SystemColors.ButtonHighlight
        lblTime.Location = New Point(564, 164)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(64, 68)
        lblTime.TabIndex = 9
        lblTime.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Imprint MT Shadow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(256, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 52)
        Label1.TabIndex = 10
        Label1.Text = "High Score"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.BackColor = Color.Transparent
        lblHighScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHighScore.ForeColor = SystemColors.ButtonHighlight
        lblHighScore.Location = New Point(339, 128)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(73, 78)
        lblHighScore.TabIndex = 11
        lblHighScore.Text = "0"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 837)
        Controls.Add(lblHighScore)
        Controls.Add(Label1)
        Controls.Add(lblTime)
        Controls.Add(lblScore)
        Controls.Add(PictureBox2)
        Controls.Add(pbMole6)
        Controls.Add(pbMole5)
        Controls.Add(PictureBox1)
        Controls.Add(pbMole3)
        Controls.Add(pbMole2)
        Controls.Add(pbMole1)
        Controls.Add(pbRefresh)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Whack a Mole!"
        CType(pbRefresh, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents pbMole1 As PictureBox
    Friend WithEvents pbMole2 As PictureBox
    Friend WithEvents pbMole3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbMole5 As PictureBox
    Friend WithEvents pbMole6 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHighScore As Label

End Class