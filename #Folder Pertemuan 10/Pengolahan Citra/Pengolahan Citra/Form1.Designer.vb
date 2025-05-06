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
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HistogramToolStripMenuItem, EfekToolStripMenuItem})
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
        BukaToolStripMenuItem.Size = New Size(224, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(224, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' PropertiToolStripMenuItem
        ' 
        PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        PropertiToolStripMenuItem.Size = New Size(224, 26)
        PropertiToolStripMenuItem.Text = "Properti"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(224, 26)
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
        TajamkanToolStripMenuItem.Size = New Size(224, 26)
        TajamkanToolStripMenuItem.Text = "Tajamkan"
        ' 
        ' KaburkanToolStripMenuItem
        ' 
        KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        KaburkanToolStripMenuItem.Size = New Size(224, 26)
        KaburkanToolStripMenuItem.Text = "Kaburkan"
        ' 
        ' Putar90DerajatToolStripMenuItem
        ' 
        Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Putar90DerajatToolStripMenuItem.Size = New Size(224, 26)
        Putar90DerajatToolStripMenuItem.Text = "Putar 90 derajat"
        ' 
        ' FlipHorisontalToolStripMenuItem
        ' 
        FlipHorisontalToolStripMenuItem.Name = "FlipHorisontalToolStripMenuItem"
        FlipHorisontalToolStripMenuItem.Size = New Size(224, 26)
        FlipHorisontalToolStripMenuItem.Text = "Flip Horisontal"
        ' 
        ' FlipVertikalToolStripMenuItem
        ' 
        FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        FlipVertikalToolStripMenuItem.Size = New Size(224, 26)
        FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 422)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Name = "frmUtama"
        Text = "Pengolahan Citra"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox

End Class
