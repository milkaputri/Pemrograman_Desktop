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
        PropertiToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        HistogramToolStripMenuItem = New ToolStripMenuItem()
        GreyscaleToolStripMenuItem = New ToolStripMenuItem()
        CerahkanToolStripMenuItem = New ToolStripMenuItem()
        GelapkanToolStripMenuItem = New ToolStripMenuItem()
        TambahKontrasToolStripMenuItem = New ToolStripMenuItem()
        KurangiKontrasToolStripMenuItem = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        TampilkanHistogramToolStripMenuItem = New ToolStripMenuItem()
        EfekToolStripMenuItem = New ToolStripMenuItem()
        TajamkanToolStripMenuItem = New ToolStripMenuItem()
        KaburkanToolStripMenuItem = New ToolStripMenuItem()
        Putar90DerajatToolStripMenuItem = New ToolStripMenuItem()
        FlipHorisontalToolStripMenuItem = New ToolStripMenuItem()
        FlipVertikalToolStripMenuItem = New ToolStripMenuItem()
        Tugas3ToolStripMenuItem = New ToolStripMenuItem()
        BorderToolStripMenuItem = New ToolStripMenuItem()
        WatermarkToolStripMenuItem = New ToolStripMenuItem()
        InversiWarnaToolStripMenuItem = New ToolStripMenuItem()
        RonaMerahToolStripMenuItem = New ToolStripMenuItem()
        RonaHijauToolStripMenuItem = New ToolStripMenuItem()
        RonaBiruToolStripMenuItem = New ToolStripMenuItem()
        RonaSpesialToolStripMenuItem = New ToolStripMenuItem()
        HistogramBalokToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        pbGambar = New PictureBox()
        tbRed = New TrackBar()
        tbGreen = New TrackBar()
        tbBlue = New TrackBar()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(pbGambar, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbRed, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbGreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbBlue, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HistogramToolStripMenuItem, EfekToolStripMenuItem, Tugas3ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, PropertiToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(145, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(145, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' PropertiToolStripMenuItem
        ' 
        PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        PropertiToolStripMenuItem.Size = New Size(145, 26)
        PropertiToolStripMenuItem.Text = "Properti"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(145, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' HistogramToolStripMenuItem
        ' 
        HistogramToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GreyscaleToolStripMenuItem, CerahkanToolStripMenuItem, GelapkanToolStripMenuItem, TambahKontrasToolStripMenuItem, KurangiKontrasToolStripMenuItem, ResetToolStripMenuItem, TampilkanHistogramToolStripMenuItem})
        HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        HistogramToolStripMenuItem.Size = New Size(93, 24)
        HistogramToolStripMenuItem.Text = "Histogram"
        ' 
        ' GreyscaleToolStripMenuItem
        ' 
        GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        GreyscaleToolStripMenuItem.Size = New Size(233, 26)
        GreyscaleToolStripMenuItem.Text = "Greyscale"
        ' 
        ' CerahkanToolStripMenuItem
        ' 
        CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        CerahkanToolStripMenuItem.Size = New Size(233, 26)
        CerahkanToolStripMenuItem.Text = "Cerahkan"
        ' 
        ' GelapkanToolStripMenuItem
        ' 
        GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        GelapkanToolStripMenuItem.Size = New Size(233, 26)
        GelapkanToolStripMenuItem.Text = "Gelapkan"
        ' 
        ' TambahKontrasToolStripMenuItem
        ' 
        TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        TambahKontrasToolStripMenuItem.Size = New Size(233, 26)
        TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        ' 
        ' KurangiKontrasToolStripMenuItem
        ' 
        KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        KurangiKontrasToolStripMenuItem.Size = New Size(233, 26)
        KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(233, 26)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' TampilkanHistogramToolStripMenuItem
        ' 
        TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        TampilkanHistogramToolStripMenuItem.Size = New Size(233, 26)
        TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        ' 
        ' EfekToolStripMenuItem
        ' 
        EfekToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TajamkanToolStripMenuItem, KaburkanToolStripMenuItem, Putar90DerajatToolStripMenuItem, FlipHorisontalToolStripMenuItem, FlipVertikalToolStripMenuItem})
        EfekToolStripMenuItem.Name = "EfekToolStripMenuItem"
        EfekToolStripMenuItem.Size = New Size(51, 24)
        EfekToolStripMenuItem.Text = "Efek"
        ' 
        ' TajamkanToolStripMenuItem
        ' 
        TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        TajamkanToolStripMenuItem.Size = New Size(197, 26)
        TajamkanToolStripMenuItem.Text = "Tajamkan"
        ' 
        ' KaburkanToolStripMenuItem
        ' 
        KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        KaburkanToolStripMenuItem.Size = New Size(197, 26)
        KaburkanToolStripMenuItem.Text = "Kaburkan"
        ' 
        ' Putar90DerajatToolStripMenuItem
        ' 
        Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Putar90DerajatToolStripMenuItem.Size = New Size(197, 26)
        Putar90DerajatToolStripMenuItem.Text = "Putar 90 derajat"
        ' 
        ' FlipHorisontalToolStripMenuItem
        ' 
        FlipHorisontalToolStripMenuItem.Name = "FlipHorisontalToolStripMenuItem"
        FlipHorisontalToolStripMenuItem.Size = New Size(197, 26)
        FlipHorisontalToolStripMenuItem.Text = "Flip Horisontal"
        ' 
        ' FlipVertikalToolStripMenuItem
        ' 
        FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        FlipVertikalToolStripMenuItem.Size = New Size(197, 26)
        FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        ' 
        ' Tugas3ToolStripMenuItem
        ' 
        Tugas3ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BorderToolStripMenuItem, WatermarkToolStripMenuItem, InversiWarnaToolStripMenuItem, RonaMerahToolStripMenuItem, RonaHijauToolStripMenuItem, RonaBiruToolStripMenuItem, RonaSpesialToolStripMenuItem, HistogramBalokToolStripMenuItem})
        Tugas3ToolStripMenuItem.Name = "Tugas3ToolStripMenuItem"
        Tugas3ToolStripMenuItem.Size = New Size(74, 24)
        Tugas3ToolStripMenuItem.Text = "Tugas 3"
        ' 
        ' BorderToolStripMenuItem
        ' 
        BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        BorderToolStripMenuItem.Size = New Size(203, 26)
        BorderToolStripMenuItem.Text = "Border"
        ' 
        ' WatermarkToolStripMenuItem
        ' 
        WatermarkToolStripMenuItem.Name = "WatermarkToolStripMenuItem"
        WatermarkToolStripMenuItem.Size = New Size(203, 26)
        WatermarkToolStripMenuItem.Text = "Watermark"
        ' 
        ' InversiWarnaToolStripMenuItem
        ' 
        InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        InversiWarnaToolStripMenuItem.Size = New Size(203, 26)
        InversiWarnaToolStripMenuItem.Text = "Inversi Warna"
        ' 
        ' RonaMerahToolStripMenuItem
        ' 
        RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        RonaMerahToolStripMenuItem.Size = New Size(203, 26)
        RonaMerahToolStripMenuItem.Text = "Rona Merah"
        ' 
        ' RonaHijauToolStripMenuItem
        ' 
        RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        RonaHijauToolStripMenuItem.Size = New Size(203, 26)
        RonaHijauToolStripMenuItem.Text = "Rona Hijau"
        ' 
        ' RonaBiruToolStripMenuItem
        ' 
        RonaBiruToolStripMenuItem.Name = "RonaBiruToolStripMenuItem"
        RonaBiruToolStripMenuItem.Size = New Size(203, 26)
        RonaBiruToolStripMenuItem.Text = "Rona Biru"
        ' 
        ' RonaSpesialToolStripMenuItem
        ' 
        RonaSpesialToolStripMenuItem.Name = "RonaSpesialToolStripMenuItem"
        RonaSpesialToolStripMenuItem.Size = New Size(203, 26)
        RonaSpesialToolStripMenuItem.Text = "Rona Spesial"
        ' 
        ' HistogramBalokToolStripMenuItem
        ' 
        HistogramBalokToolStripMenuItem.Name = "HistogramBalokToolStripMenuItem"
        HistogramBalokToolStripMenuItem.Size = New Size(203, 26)
        HistogramBalokToolStripMenuItem.Text = "Histogram Balok"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' pbGambar
        ' 
        pbGambar.Location = New Point(0, 28)
        pbGambar.Name = "pbGambar"
        pbGambar.Size = New Size(800, 348)
        pbGambar.TabIndex = 1
        pbGambar.TabStop = False
        ' 
        ' tbRed
        ' 
        tbRed.Location = New Point(30, 382)
        tbRed.Name = "tbRed"
        tbRed.Size = New Size(201, 56)
        tbRed.TabIndex = 2
        ' 
        ' tbGreen
        ' 
        tbGreen.Location = New Point(294, 382)
        tbGreen.Name = "tbGreen"
        tbGreen.Size = New Size(201, 56)
        tbGreen.TabIndex = 3
        ' 
        ' tbBlue
        ' 
        tbBlue.Location = New Point(570, 382)
        tbBlue.Name = "tbBlue"
        tbBlue.Size = New Size(201, 56)
        tbBlue.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 418)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 5
        Label1.Text = "Red"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(386, 418)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 6
        Label2.Text = "Green"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(664, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 20)
        Label3.TabIndex = 7
        Label3.Text = "Blue"
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbBlue)
        Controls.Add(tbGreen)
        Controls.Add(tbRed)
        Controls.Add(pbGambar)
        Controls.Add(MenuStrip1)
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pengolahan Citra"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbGambar, ComponentModel.ISupportInitialize).EndInit()
        CType(tbRed, ComponentModel.ISupportInitialize).EndInit()
        CType(tbGreen, ComponentModel.ISupportInitialize).EndInit()
        CType(tbBlue, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Putar90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorisontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents pbGambar As PictureBox
    Friend WithEvents Tugas3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBiruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpesialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramBalokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbRed As TrackBar
    Friend WithEvents tbGreen As TrackBar
    Friend WithEvents tbBlue As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
