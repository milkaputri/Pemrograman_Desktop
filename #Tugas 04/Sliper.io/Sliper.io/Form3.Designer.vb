<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblDeskripsi = New Label()
        Label1 = New Label()
        lblScore = New Label()
        lblHighScore = New Label()
        SuspendLayout()
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.ForeColor = Color.WhiteSmoke
        lblDeskripsi.Location = New Point(476, 293)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(168, 60)
        lblDeskripsi.TabIndex = 3
        lblDeskripsi.Text = "Mulai Lagi (Tekan Enter)" & vbCrLf & "Exit (Tekan ESC)" & vbCrLf & vbCrLf
        lblDeskripsi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(437, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 54)
        Label1.TabIndex = 4
        Label1.Text = "Game Over!"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.ForeColor = Color.Yellow
        lblScore.Location = New Point(450, 379)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(65, 20)
        lblScore.TabIndex = 5
        lblScore.Text = "Score : 0"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.ForeColor = Color.Yellow
        lblHighScore.Location = New Point(552, 379)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(101, 20)
        lblHighScore.TabIndex = 6
        lblHighScore.Text = "High Score : 0"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1137, 677)
        Controls.Add(lblHighScore)
        Controls.Add(lblScore)
        Controls.Add(Label1)
        Controls.Add(lblDeskripsi)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScoreTertinggi As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHighScore As Label
End Class
