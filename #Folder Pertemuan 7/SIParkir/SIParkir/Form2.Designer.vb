<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblNomorPlat = New Label()
        txtNoPlat = New TextBox()
        lblJenis = New Label()
        cbJenis = New ComboBox()
        lblBiayaParkir = New Label()
        PictureBox1 = New PictureBox()
        lblInformasi = New Label()
        lblTanggal = New Label()
        lblJam = New Label()
        lblJamMuncul = New Label()
        lblKendaraanSedangParkir = New Label()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        Colkeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        ColId = New DataGridViewTextBoxColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuDelete = New ToolStripMenuItem()
        pnlPlat = New Panel()
        lblPlat = New Label()
        pnlHarga = New Panel()
        lblHarga = New Label()
        pnlInput = New Panel()
        Label1 = New Label()
        pnlGrid = New Panel()
        lblJmlKendaraan = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        pnlPlat.SuspendLayout()
        pnlHarga.SuspendLayout()
        pnlInput.SuspendLayout()
        pnlGrid.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1089, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(67, 24)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(159, 26)
        AturProfilToolStripMenuItem.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(159, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(240, 26)
        LanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(240, 26)
        LaporanToolStripMenuItem.Text = "Laporan Pendapatan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(12, 172)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(92, 20)
        lblNomorPlat.TabIndex = 2
        lblNomorPlat.Text = "Nomor Plat :"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.BorderStyle = BorderStyle.FixedSingle
        txtNoPlat.Location = New Point(126, 169)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(232, 27)
        txtNoPlat.TabIndex = 3
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(12, 215)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(51, 20)
        lblJenis.TabIndex = 4
        lblJenis.Text = "Jenis : "
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis/Truk"})
        cbJenis.Location = New Point(126, 212)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(139, 28)
        cbJenis.TabIndex = 5
        cbJenis.Text = "Pilih Jenis"
        ' 
        ' lblBiayaParkir
        ' 
        lblBiayaParkir.AutoSize = True
        lblBiayaParkir.Location = New Point(12, 319)
        lblBiayaParkir.Name = "lblBiayaParkir"
        lblBiayaParkir.Size = New Size(96, 20)
        lblBiayaParkir.TabIndex = 8
        lblBiayaParkir.Text = "Biaya Parkir : "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._2931142_minimize_minus_remove_line_icon
        PictureBox1.Location = New Point(12, 392)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Location = New Point(12, 443)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(75, 20)
        lblInformasi.TabIndex = 12
        lblInformasi.Text = "Informasi "
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(12, 476)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(68, 20)
        lblTanggal.TabIndex = 13
        lblTanggal.Text = "Tanggal :"
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Location = New Point(219, 476)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(46, 20)
        lblJam.TabIndex = 15
        lblJam.Text = "Jam : "
        ' 
        ' lblJamMuncul
        ' 
        lblJamMuncul.AutoSize = True
        lblJamMuncul.Location = New Point(259, 476)
        lblJamMuncul.Name = "lblJamMuncul"
        lblJamMuncul.Size = New Size(63, 20)
        lblJamMuncul.TabIndex = 16
        lblJamMuncul.Text = "00:00:00"
        ' 
        ' lblKendaraanSedangParkir
        ' 
        lblKendaraanSedangParkir.AutoSize = True
        lblKendaraanSedangParkir.Location = New Point(391, 172)
        lblKendaraanSedangParkir.Name = "lblKendaraanSedangParkir"
        lblKendaraanSedangParkir.Size = New Size(181, 20)
        lblKendaraanSedangParkir.TabIndex = 17
        lblKendaraanSedangParkir.Text = "Kendaraan sedang parkir :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, Colkeluar, ColHarga, ColJenis, ColId})
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(675, 327)
        DataGridView1.TabIndex = 18
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.MinimumWidth = 6
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.Width = 125
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.MinimumWidth = 6
        ColMasuk.Name = "ColMasuk"
        ColMasuk.Width = 125
        ' 
        ' Colkeluar
        ' 
        Colkeluar.HeaderText = "Keluar"
        Colkeluar.MinimumWidth = 6
        Colkeluar.Name = "Colkeluar"
        Colkeluar.Width = 125
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.Width = 125
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 6
        ColJenis.Name = "ColJenis"
        ColJenis.Width = 125
        ' 
        ' ColId
        ' 
        ColId.HeaderText = "Id"
        ColId.MinimumWidth = 6
        ColId.Name = "ColId"
        ColId.ReadOnly = True
        ColId.Visible = False
        ColId.Width = 125
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuDelete})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(123, 28)
        ' 
        ' ToolStripMenuDelete
        ' 
        ToolStripMenuDelete.Name = "ToolStripMenuDelete"
        ToolStripMenuDelete.Size = New Size(122, 24)
        ToolStripMenuDelete.Text = "Delete"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.Controls.Add(lblPlat)
        pnlPlat.Dock = DockStyle.Top
        pnlPlat.Location = New Point(0, 28)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.Size = New Size(1089, 125)
        pnlPlat.TabIndex = 27
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Font = New Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlat.Location = New Point(275, 0)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(548, 133)
        lblPlat.TabIndex = 0
        lblPlat.Text = "R 6872 ZH"
        ' 
        ' pnlHarga
        ' 
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.Controls.Add(lblHarga)
        pnlHarga.Location = New Point(126, 303)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.Size = New Size(232, 74)
        pnlHarga.TabIndex = 28
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(3, 9)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(79, 50)
        lblHarga.TabIndex = 0
        lblHarga.Text = "Rp."
        ' 
        ' pnlInput
        ' 
        pnlInput.BorderStyle = BorderStyle.Fixed3D
        pnlInput.Controls.Add(Label1)
        pnlInput.Location = New Point(0, 162)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(371, 125)
        pnlInput.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.AutoScroll = True
        pnlGrid.Controls.Add(DataGridView1)
        pnlGrid.Location = New Point(391, 195)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(675, 327)
        pnlGrid.TabIndex = 30
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Location = New Point(12, 512)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(310, 20)
        lblJmlKendaraan.TabIndex = 31
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 546)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(pnlHarga)
        Controls.Add(pnlPlat)
        Controls.Add(lblKendaraanSedangParkir)
        Controls.Add(lblJamMuncul)
        Controls.Add(lblJam)
        Controls.Add(lblTanggal)
        Controls.Add(lblInformasi)
        Controls.Add(PictureBox1)
        Controls.Add(lblBiayaParkir)
        Controls.Add(cbJenis)
        Controls.Add(lblJenis)
        Controls.Add(txtNoPlat)
        Controls.Add(lblNomorPlat)
        Controls.Add(MenuStrip1)
        Controls.Add(pnlInput)
        Controls.Add(pnlGrid)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        pnlPlat.ResumeLayout(False)
        pnlPlat.PerformLayout()
        pnlHarga.ResumeLayout(False)
        pnlHarga.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        pnlGrid.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents lblBiayaParkir As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblJamMuncul As Label
    Friend WithEvents lblKendaraanSedangParkir As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuDelete As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents Colkeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents Label1 As Label
End Class
