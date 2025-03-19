<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        lblNamaPelanggan = New Label()
        txtNamaPelanggan = New TextBox()
        lblNomorPlat = New Label()
        txtNomorPlat = New TextBox()
        lblBiaya = New Label()
        txtTarifLangganan = New TextBox()
        lblTglBerlaku = New Label()
        lblId = New Label()
        lblHasilIdPelanggan = New Label()
        lblJenis = New Label()
        cmbJenis = New ComboBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        lblKendaraanTerdaftarLangganan = New Label()
        DataGridView1 = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colNoPlat = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colBiaya = New DataGridViewTextBoxColumn()
        colJenis = New DataGridViewTextBoxColumn()
        colExpired = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        btnCancel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaPelanggan
        ' 
        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Location = New Point(30, 30)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(133, 20)
        lblNamaPelanggan.TabIndex = 0
        lblNamaPelanggan.Text = "Nama Pelanggan : "
        ' 
        ' txtNamaPelanggan
        ' 
        txtNamaPelanggan.Location = New Point(169, 27)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.Size = New Size(309, 27)
        txtNamaPelanggan.TabIndex = 1
        ' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(30, 80)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(92, 20)
        lblNomorPlat.TabIndex = 2
        lblNomorPlat.Text = "Nomor Plat :"
        ' 
        ' txtNomorPlat
        ' 
        txtNomorPlat.Location = New Point(169, 77)
        txtNomorPlat.Name = "txtNomorPlat"
        txtNomorPlat.Size = New Size(242, 27)
        txtNomorPlat.TabIndex = 3
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(30, 130)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(118, 20)
        lblBiaya.TabIndex = 4
        lblBiaya.Text = "Tarif langganan :"
        ' 
        ' txtTarifLangganan
        ' 
        txtTarifLangganan.Location = New Point(169, 127)
        txtTarifLangganan.Name = "txtTarifLangganan"
        txtTarifLangganan.Size = New Size(242, 27)
        txtTarifLangganan.TabIndex = 5
        ' 
        ' lblTglBerlaku
        ' 
        lblTglBerlaku.AutoSize = True
        lblTglBerlaku.Location = New Point(30, 180)
        lblTglBerlaku.Name = "lblTglBerlaku"
        lblTglBerlaku.Size = New Size(115, 20)
        lblTglBerlaku.TabIndex = 6
        lblTglBerlaku.Text = "Berlaku hingga :"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(514, 30)
        lblId.Name = "lblId"
        lblId.Size = New Size(104, 20)
        lblId.TabIndex = 8
        lblId.Text = "ID Pelanggan :"
        lblId.Visible = False
        ' 
        ' lblHasilIdPelanggan
        ' 
        lblHasilIdPelanggan.AutoSize = True
        lblHasilIdPelanggan.Location = New Point(624, 30)
        lblHasilIdPelanggan.Name = "lblHasilIdPelanggan"
        lblHasilIdPelanggan.Size = New Size(0, 20)
        lblHasilIdPelanggan.TabIndex = 9
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(431, 80)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(47, 20)
        lblJenis.TabIndex = 10
        lblJenis.Text = "Jenis :"
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bis/Truk"})
        cmbJenis.Location = New Point(484, 77)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(128, 28)
        cmbJenis.TabIndex = 11
        cmbJenis.Text = "Pilih Jenis"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(431, 176)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(531, 176)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(631, 176)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblKendaraanTerdaftarLangganan
        ' 
        lblKendaraanTerdaftarLangganan.AutoSize = True
        lblKendaraanTerdaftarLangganan.Location = New Point(30, 243)
        lblKendaraanTerdaftarLangganan.Name = "lblKendaraanTerdaftarLangganan"
        lblKendaraanTerdaftarLangganan.Size = New Size(223, 20)
        lblKendaraanTerdaftarLangganan.TabIndex = 15
        lblKendaraanTerdaftarLangganan.Text = "Kendaraan terdaftar langganan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colId, colNoPlat, colNama, colBiaya, colJenis, colExpired})
        DataGridView1.Location = New Point(30, 266)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(795, 172)
        DataGridView1.TabIndex = 16
        ' 
        ' colId
        ' 
        colId.HeaderText = "Id"
        colId.MinimumWidth = 6
        colId.Name = "colId"
        colId.Width = 115
        ' 
        ' colNoPlat
        ' 
        colNoPlat.HeaderText = "No Plat"
        colNoPlat.MinimumWidth = 6
        colNoPlat.Name = "colNoPlat"
        colNoPlat.Width = 125
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama Pemilik"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.Width = 125
        ' 
        ' colBiaya
        ' 
        colBiaya.HeaderText = "Biaya"
        colBiaya.MinimumWidth = 6
        colBiaya.Name = "colBiaya"
        colBiaya.Width = 125
        ' 
        ' colJenis
        ' 
        colJenis.HeaderText = "Jenis"
        colJenis.MinimumWidth = 6
        colJenis.Name = "colJenis"
        colJenis.Width = 125
        ' 
        ' colExpired
        ' 
        colExpired.HeaderText = "Expired"
        colExpired.MinimumWidth = 6
        colExpired.Name = "colExpired"
        colExpired.Width = 125
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(169, 175)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(242, 27)
        DateTimePicker1.TabIndex = 18
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(731, 176)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 19
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        btnCancel.Visible = False
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 450)
        Controls.Add(btnCancel)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Controls.Add(lblKendaraanTerdaftarLangganan)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(cmbJenis)
        Controls.Add(lblJenis)
        Controls.Add(lblHasilIdPelanggan)
        Controls.Add(lblId)
        Controls.Add(lblTglBerlaku)
        Controls.Add(txtTarifLangganan)
        Controls.Add(lblBiaya)
        Controls.Add(txtNomorPlat)
        Controls.Add(lblNomorPlat)
        Controls.Add(txtNamaPelanggan)
        Controls.Add(lblNamaPelanggan)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents txtNomorPlat As TextBox
    Friend WithEvents lblBiaya As Label
    Friend WithEvents txtTarifLangganan As TextBox
    Friend WithEvents lblTglBerlaku As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblHasilIdPelanggan As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblKendaraanTerdaftarLangganan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colBiaya As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colExpired As DataGridViewTextBoxColumn
End Class
