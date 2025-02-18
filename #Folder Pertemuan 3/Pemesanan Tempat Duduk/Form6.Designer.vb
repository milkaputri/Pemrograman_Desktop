<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Label5 = New Label()
        TempatDudukToolStripMenuItem = New ToolStripMenuItem()
        MakananToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        MinumanToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        TextBox1 = New TextBox()
        PembayaranToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label9 = New Label()
        TextBox9 = New TextBox()
        Label10 = New Label()
        btnSvPesanan3 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(522, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 21)
        Label5.TabIndex = 238
        Label5.Text = "MAKANAN"
        ' 
        ' TempatDudukToolStripMenuItem
        ' 
        TempatDudukToolStripMenuItem.Name = "TempatDudukToolStripMenuItem"
        TempatDudukToolStripMenuItem.Size = New Size(120, 24)
        TempatDudukToolStripMenuItem.Text = "Tempat Duduk"
        ' 
        ' MakananToolStripMenuItem
        ' 
        MakananToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MakananToolStripMenuItem.Name = "MakananToolStripMenuItem"
        MakananToolStripMenuItem.Size = New Size(83, 24)
        MakananToolStripMenuItem.Text = "Makanan"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(71, 6)
        ' 
        ' MinumanToolStripMenuItem
        ' 
        MinumanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2})
        MinumanToolStripMenuItem.Name = "MinumanToolStripMenuItem"
        MinumanToolStripMenuItem.Size = New Size(85, 24)
        MinumanToolStripMenuItem.Text = "Minuman"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(71, 6)
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(522, 179)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 216)
        TextBox1.TabIndex = 233
        ' 
        ' PembayaranToolStripMenuItem
        ' 
        PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        PembayaranToolStripMenuItem.Size = New Size(76, 24)
        PembayaranToolStripMenuItem.Text = "Pesanan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(293, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 35)
        Label3.TabIndex = 229
        Label3.Text = "PILIH MINUMAN ANDA"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TempatDudukToolStripMenuItem, MakananToolStripMenuItem, MinumanToolStripMenuItem, PembayaranToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(966, 28)
        MenuStrip1.TabIndex = 230
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(206, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(263, 27)
        TextBox2.TabIndex = 242
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Location = New Point(46, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 241
        Label1.Text = "Nama Pemesan :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(206, 198)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(263, 27)
        TextBox3.TabIndex = 244
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Location = New Point(46, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 243
        Label2.Text = "Tanggal Pesanan :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(206, 251)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(263, 27)
        TextBox4.TabIndex = 246
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Location = New Point(46, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 25)
        Label4.TabIndex = 245
        Label4.Text = "Jumlah Tamu :"
        ' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.FlatStyle = FlatStyle.Popup
        Label6.Location = New Point(46, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 25)
        Label6.TabIndex = 247
        Label6.Text = "Jam Berkunjung :"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(206, 310)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(263, 27)
        TextBox5.TabIndex = 248
        ' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.FlatStyle = FlatStyle.Popup
        Label7.Location = New Point(46, 370)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 25)
        Label7.TabIndex = 249
        Label7.Text = "Nomor Meja :"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(206, 368)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(263, 27)
        TextBox6.TabIndex = 250
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.FlatStyle = FlatStyle.Popup
        Label8.Location = New Point(46, 423)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 25)
        Label8.TabIndex = 251
        Label8.Text = "Note :"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(206, 421)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(263, 106)
        TextBox7.TabIndex = 252
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(728, 179)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(180, 216)
        TextBox8.TabIndex = 253
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.FlatStyle = FlatStyle.Popup
        Label9.Location = New Point(522, 425)
        Label9.Name = "Label9"
        Label9.Size = New Size(180, 25)
        Label9.TabIndex = 254
        Label9.Text = "TOTAL :"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(728, 423)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(180, 27)
        TextBox9.TabIndex = 255
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SaddleBrown
        Label10.Location = New Point(728, 147)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 21)
        Label10.TabIndex = 256
        Label10.Text = "MINUMAN"
        ' 
        ' btnSvPesanan3
        ' 
        btnSvPesanan3.BackColor = Color.DarkRed
        btnSvPesanan3.FlatStyle = FlatStyle.Popup
        btnSvPesanan3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSvPesanan3.ForeColor = SystemColors.ButtonFace
        btnSvPesanan3.Location = New Point(735, 498)
        btnSvPesanan3.Name = "btnSvPesanan3"
        btnSvPesanan3.Size = New Size(173, 29)
        btnSvPesanan3.TabIndex = 240
        btnSvPesanan3.Text = "SIMPAN PESANAN"
        btnSvPesanan3.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(966, 627)
        Controls.Add(Label10)
        Controls.Add(TextBox9)
        Controls.Add(Label9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(btnSvPesanan3)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(MenuStrip1)
        Name = "Form6"
        Text = "Form6"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents TempatDudukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MinumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSvPesanan3 As Button
End Class
