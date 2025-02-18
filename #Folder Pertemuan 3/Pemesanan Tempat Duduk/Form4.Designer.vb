<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        TempatDudukToolStripMenuItem = New ToolStripMenuItem()
        MakananToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        MinumanToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        PembayaranToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Button3 = New Button()
        btnSvPesanan1 = New Button()
        Label1 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        ListBox2 = New ListBox()
        ListBox5 = New ListBox()
        ListBox1 = New ListBox()
        ListBox6 = New ListBox()
        ListBox4 = New ListBox()
        ListBox3 = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(293, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(397, 35)
        Label3.TabIndex = 195
        Label3.Text = "PILIH MAKANAN ANDA"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TempatDudukToolStripMenuItem, MakananToolStripMenuItem, MinumanToolStripMenuItem, PembayaranToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(966, 28)
        MenuStrip1.TabIndex = 197
        MenuStrip1.Text = "MenuStrip1"
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
        ' PembayaranToolStripMenuItem
        ' 
        PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        PembayaranToolStripMenuItem.Size = New Size(104, 24)
        PembayaranToolStripMenuItem.Text = "Pembayaran"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(660, 140)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 294)
        TextBox1.TabIndex = 200
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(660, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 21)
        Label5.TabIndex = 207
        Label5.Text = "PESANAN SAYA"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkRed
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(660, 455)
        Button3.Name = "Button3"
        Button3.Size = New Size(144, 29)
        Button3.TabIndex = 209
        Button3.Text = "LIHAT PESANAN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnSvPesanan1
        ' 
        btnSvPesanan1.BackColor = Color.DarkRed
        btnSvPesanan1.FlatStyle = FlatStyle.Popup
        btnSvPesanan1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSvPesanan1.ForeColor = SystemColors.ButtonFace
        btnSvPesanan1.Location = New Point(660, 517)
        btnSvPesanan1.Name = "btnSvPesanan1"
        btnSvPesanan1.Size = New Size(159, 29)
        btnSvPesanan1.TabIndex = 210
        btnSvPesanan1.Text = "SIMPAN PESANAN"
        btnSvPesanan1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(50, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 21)
        Label1.TabIndex = 198
        Label1.Text = "REKOMENDASI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(347, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 21)
        Label4.TabIndex = 205
        Label4.Text = "MENU MINUMAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(50, 375)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 21)
        Label2.TabIndex = 203
        Label2.Text = "FAVORITE"
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 18
        ListBox2.Items.AddRange(New Object() {"Nasi Gorneg Teri", "Udah Saus Padang", "Kepiting Asam Manis", "Ayam Bakar Madu", "Lele Goreng Terbang", "Ayam Goreng Sambal Matah", "Beef Teriyaki"})
        ListBox2.Location = New Point(50, 410)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(174, 184)
        ListBox2.TabIndex = 204
        ' 
        ' ListBox5
        ' 
        ListBox5.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox5.FormattingEnabled = True
        ListBox5.ItemHeight = 18
        ListBox5.Items.AddRange(New Object() {"Rp8.000", "Rp5.000", "Rp7.000", "Rp14.000", "Rp10.000", "Rp3.000", "Rp3.000", ""})
        ListBox5.Location = New Point(219, 410)
        ListBox5.Name = "ListBox5"
        ListBox5.Size = New Size(86, 184)
        ListBox5.TabIndex = 212
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Items.AddRange(New Object() {"Ayam Ingkung", "Udang Saus Padang", "Gurame Asam Manis", "Ayam Goreng Lengkuas", "Kwetiau Goreng", "Cah Kangkung", "Capcay", "Tumis Kangkung"})
        ListBox1.Location = New Point(50, 140)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(174, 184)
        ListBox1.TabIndex = 199
        ' 
        ' ListBox6
        ' 
        ListBox6.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox6.FormattingEnabled = True
        ListBox6.ItemHeight = 18
        ListBox6.Items.AddRange(New Object() {"Rp3.000", "Rp3.000", "Rp3.500", "Rp3.500", "", "Rp65.000", "Rp20.000", "Rp18.000", "Rp18.000", "Rp20.000", "", "Rp23.000", "Rp23.000", "Rp23.000", "Rp23.000", "Rp30.000", "Rp30.000", "Rp30.000", "Rp30.000", "Rp45.000", "Rp45.000", "Rp23.000", "Rp23.000", "Rp23.000", "Rp23.000", "", "Rp16.000", "Rp20.000", "Rp18.000", "Rp16.000", "Rp16.000", "Rp16.000", "Rp16.000", "", "Rp10.000", "Rp10.000", "Rp15.000", "", "Rp2.500", "Rp2.500", "Rp2.500", "Rp2.500", "Rp3.000"})
        ListBox6.Location = New Point(529, 140)
        ListBox6.Name = "ListBox6"
        ListBox6.Size = New Size(95, 454)
        ListBox6.TabIndex = 213
        ' 
        ' ListBox4
        ' 
        ListBox4.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 18
        ListBox4.Items.AddRange(New Object() {"Rp8.000", "Rp5.000", "Rp7.000", "Rp14.000", "Rp10.000", "Rp3.000", "Rp3.000", ""})
        ListBox4.Location = New Point(219, 140)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(86, 184)
        ListBox4.TabIndex = 211
        ' 
        ' ListBox3
        ' 
        ListBox3.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 18
        ListBox3.Items.AddRange(New Object() {"Nasi Putih", "Nasi Uduk", "Nasi Daun Jeruk", "Nasi Mentega", "", "Ayam Ingkung", "Ayam Bakar Madu", "Ayam Goreng Kremes", "Ayam Goreng Lengkuas", "Ayam Goreng Sambal Matah", "", "Udang Saus Padang", "Udang Asam Manis", "Udang Bakar Madu", "Udang Goreng Tepung", "Gurame Saus Padang", "Gurame Asam Manis", "Gurame Bakar Madu", "Gurame Goreng Tepung", "Kepiting Saus Padang", "Kepiring Asam Manis", "Cumi Saus Padang", "Cumi Asam Manis", "Cumi Bakar Madu", "Cumi Goreng Tepung", "", "Nasi Goreng ", "Nasi Goreng Seafood", "Nasi Goreng Teri", "Kwetiau Rebus", "Kwetiau Goreng", "Bakmi Rebus", "Bakmi Goreng", "", "Cah Kangkung ", "Tumis Kangkug", "Capcay", "", "Sambal Bawang", "Sambal Trasi", "Sambal Tomat", "Sambal Ijo", "Sambal Matah"})
        ListBox3.Location = New Point(347, 140)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(183, 454)
        ListBox3.TabIndex = 206
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(966, 627)
        Controls.Add(ListBox6)
        Controls.Add(ListBox5)
        Controls.Add(ListBox4)
        Controls.Add(btnSvPesanan1)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(ListBox3)
        Controls.Add(Label4)
        Controls.Add(ListBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "Form4"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TempatDudukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MinumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSvPesanan1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
End Class
