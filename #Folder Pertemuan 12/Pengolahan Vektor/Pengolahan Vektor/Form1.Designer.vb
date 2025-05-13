<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        ShapeIsian = New Panel()
        ShapeTepi = New Panel()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        RadioElipsIsi = New RadioButton()
        RadioKotakIsi = New RadioButton()
        RadioElips = New RadioButton()
        RadioKotak = New RadioButton()
        RadioGaris = New RadioButton()
        RadioBebas = New RadioButton()
        Warna2 = New GroupBox()
        btnGbrUlang = New Button()
        btnBersihkan = New Button()
        btnUndo = New Button()
        Warna5 = New Panel()
        Warna6 = New Panel()
        Warna4 = New Panel()
        Warna3 = New Panel()
        Warna7 = New Panel()
        Warna1 = New Panel()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        Warna2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(956, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(142, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(142, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(142, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ShapeIsian)
        GroupBox1.Controls.Add(ShapeTepi)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(RadioElipsIsi)
        GroupBox1.Controls.Add(RadioKotakIsi)
        GroupBox1.Controls.Add(RadioElips)
        GroupBox1.Controls.Add(RadioKotak)
        GroupBox1.Controls.Add(RadioGaris)
        GroupBox1.Controls.Add(RadioBebas)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.Location = New Point(0, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(156, 454)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tools"
        ' 
        ' ShapeIsian
        ' 
        ShapeIsian.BackColor = Color.White
        ShapeIsian.BorderStyle = BorderStyle.FixedSingle
        ShapeIsian.Location = New Point(80, 360)
        ShapeIsian.Name = "ShapeIsian"
        ShapeIsian.Size = New Size(46, 46)
        ShapeIsian.TabIndex = 14
        ' 
        ' ShapeTepi
        ' 
        ShapeTepi.BackColor = Color.Black
        ShapeTepi.Location = New Point(16, 360)
        ShapeTepi.Name = "ShapeTepi"
        ShapeTepi.Size = New Size(46, 46)
        ShapeTepi.TabIndex = 13
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(16, 295)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(77, 27)
        NumericUpDown1.TabIndex = 12
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 272)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 11
        Label1.Text = "Ukuran Garis Tepi:"
        ' 
        ' RadioElipsIsi
        ' 
        RadioElipsIsi.AutoSize = True
        RadioElipsIsi.Location = New Point(23, 185)
        RadioElipsIsi.Name = "RadioElipsIsi"
        RadioElipsIsi.Size = New Size(79, 24)
        RadioElipsIsi.TabIndex = 10
        RadioElipsIsi.TabStop = True
        RadioElipsIsi.Text = "Elips Isi"
        RadioElipsIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioKotakIsi
        ' 
        RadioKotakIsi.AutoSize = True
        RadioKotakIsi.Location = New Point(23, 155)
        RadioKotakIsi.Name = "RadioKotakIsi"
        RadioKotakIsi.Size = New Size(86, 24)
        RadioKotakIsi.TabIndex = 9
        RadioKotakIsi.TabStop = True
        RadioKotakIsi.Text = "Kotak Isi"
        RadioKotakIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioElips
        ' 
        RadioElips.AutoSize = True
        RadioElips.Location = New Point(23, 125)
        RadioElips.Name = "RadioElips"
        RadioElips.Size = New Size(61, 24)
        RadioElips.TabIndex = 8
        RadioElips.TabStop = True
        RadioElips.Text = "Elips"
        RadioElips.UseVisualStyleBackColor = True
        ' 
        ' RadioKotak
        ' 
        RadioKotak.AutoSize = True
        RadioKotak.Location = New Point(23, 95)
        RadioKotak.Name = "RadioKotak"
        RadioKotak.Size = New Size(68, 24)
        RadioKotak.TabIndex = 7
        RadioKotak.TabStop = True
        RadioKotak.Text = "Kotak"
        RadioKotak.UseVisualStyleBackColor = True
        ' 
        ' RadioGaris
        ' 
        RadioGaris.AutoSize = True
        RadioGaris.Location = New Point(23, 65)
        RadioGaris.Name = "RadioGaris"
        RadioGaris.Size = New Size(63, 24)
        RadioGaris.TabIndex = 6
        RadioGaris.TabStop = True
        RadioGaris.Text = "Garis"
        RadioGaris.UseVisualStyleBackColor = True
        ' 
        ' RadioBebas
        ' 
        RadioBebas.AutoSize = True
        RadioBebas.Location = New Point(23, 35)
        RadioBebas.Name = "RadioBebas"
        RadioBebas.Size = New Size(70, 24)
        RadioBebas.TabIndex = 5
        RadioBebas.TabStop = True
        RadioBebas.Text = "Bebas"
        RadioBebas.UseVisualStyleBackColor = True
        ' 
        ' Warna2
        ' 
        Warna2.Controls.Add(btnGbrUlang)
        Warna2.Controls.Add(btnBersihkan)
        Warna2.Controls.Add(btnUndo)
        Warna2.Controls.Add(Warna5)
        Warna2.Controls.Add(Warna6)
        Warna2.Controls.Add(Warna4)
        Warna2.Controls.Add(Warna3)
        Warna2.Controls.Add(Warna7)
        Warna2.Controls.Add(Warna1)
        Warna2.Dock = DockStyle.Bottom
        Warna2.Location = New Point(156, 401)
        Warna2.Name = "Warna2"
        Warna2.Size = New Size(800, 81)
        Warna2.TabIndex = 2
        Warna2.TabStop = False
        Warna2.Text = "Warna"
        ' 
        ' btnGbrUlang
        ' 
        btnGbrUlang.Location = New Point(621, 26)
        btnGbrUlang.Name = "btnGbrUlang"
        btnGbrUlang.Size = New Size(121, 29)
        btnGbrUlang.TabIndex = 8
        btnGbrUlang.Text = "Gambar Ulang!"
        btnGbrUlang.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(441, 26)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(133, 29)
        btnBersihkan.TabIndex = 7
        btnBersihkan.Text = "Bersihkan Kanvas"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(341, 26)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(94, 29)
        btnUndo.TabIndex = 6
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Warna5
        ' 
        Warna5.BackColor = Color.Black
        Warna5.BorderStyle = BorderStyle.FixedSingle
        Warna5.Location = New Point(243, 26)
        Warna5.Name = "Warna5"
        Warna5.Size = New Size(38, 36)
        Warna5.TabIndex = 5
        ' 
        ' Warna6
        ' 
        Warna6.BackColor = Color.White
        Warna6.BorderStyle = BorderStyle.FixedSingle
        Warna6.Location = New Point(199, 26)
        Warna6.Name = "Warna6"
        Warna6.Size = New Size(38, 36)
        Warna6.TabIndex = 4
        ' 
        ' Warna4
        ' 
        Warna4.BackColor = Color.Blue
        Warna4.BorderStyle = BorderStyle.FixedSingle
        Warna4.Location = New Point(155, 26)
        Warna4.Name = "Warna4"
        Warna4.Size = New Size(38, 36)
        Warna4.TabIndex = 3
        ' 
        ' Warna3
        ' 
        Warna3.BackColor = Color.Green
        Warna3.BorderStyle = BorderStyle.FixedSingle
        Warna3.Location = New Point(111, 26)
        Warna3.Name = "Warna3"
        Warna3.Size = New Size(38, 36)
        Warna3.TabIndex = 2
        ' 
        ' Warna7
        ' 
        Warna7.BackColor = Color.Yellow
        Warna7.BorderStyle = BorderStyle.FixedSingle
        Warna7.Location = New Point(67, 26)
        Warna7.Name = "Warna7"
        Warna7.Size = New Size(38, 36)
        Warna7.TabIndex = 1
        ' 
        ' Warna1
        ' 
        Warna1.BackColor = Color.Red
        Warna1.BorderStyle = BorderStyle.FixedSingle
        Warna1.Location = New Point(23, 26)
        Warna1.Name = "Warna1"
        Warna1.Size = New Size(38, 36)
        Warna1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Dock = DockStyle.Right
        GroupBox3.Location = New Point(731, 28)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(225, 373)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Objek"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 20)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(213, 347)
        TextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(156, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(575, 373)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 482)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox3)
        Controls.Add(Warna2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmUtama"
        Text = "Corat-Coret Vektor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        Warna2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Warna2 As GroupBox
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Warna7 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents btnUndo As Button
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents TextBox1 As TextBox

End Class
