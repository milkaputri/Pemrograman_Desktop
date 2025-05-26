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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        lblDeskripsi = New Label()
        btnPlayLv1 = New Button()
        btnPlayLv2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(191, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 190)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(131, 283)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(382, 38)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Sliper.io | Ular Petualangan!"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.ForeColor = Color.WhiteSmoke
        lblDeskripsi.Location = New Point(163, 346)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(312, 100)
        lblDeskripsi.TabIndex = 2
        lblDeskripsi.Text = "Ayo main Sliper IO - Game ular" & vbCrLf & "paling viral! Seru-seruan jadi ular lapar," & vbCrLf & "balap rebut makanan, dan jegal lawan biar" & vbCrLf & "jadi yang terpanjang!" & vbCrLf & "Main langsung dari laptop/ Pc masingmasing!" & vbCrLf
        lblDeskripsi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPlayLv1
        ' 
        btnPlayLv1.FlatStyle = FlatStyle.Flat
        btnPlayLv1.Location = New Point(215, 463)
        btnPlayLv1.Name = "btnPlayLv1"
        btnPlayLv1.Size = New Size(200, 50)
        btnPlayLv1.TabIndex = 3
        btnPlayLv1.Text = "▶ BERMAIN LEVEL 1"
        btnPlayLv1.UseVisualStyleBackColor = True
        ' 
        ' btnPlayLv2
        ' 
        btnPlayLv2.FlatStyle = FlatStyle.Flat
        btnPlayLv2.Location = New Point(215, 532)
        btnPlayLv2.Name = "btnPlayLv2"
        btnPlayLv2.Size = New Size(200, 50)
        btnPlayLv2.TabIndex = 4
        btnPlayLv2.Text = "▶ BERMAIN LEVEL 2"
        btnPlayLv2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(632, 603)
        Controls.Add(btnPlayLv2)
        Controls.Add(btnPlayLv1)
        Controls.Add(lblDeskripsi)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game Sliper.io"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPlayLv1 As Button
    Friend WithEvents btnPlayLv2 As Button

End Class
