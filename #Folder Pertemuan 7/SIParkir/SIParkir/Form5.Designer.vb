<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        lblPeriode = New Label()
        cbBulan = New ComboBox()
        txtTahun = New TextBox()
        btnTampilkan = New Button()
        lblLaporan = New Label()
        btnTutup = New Button()
        txtLaporan = New TextBox()
        SuspendLayout()
        ' 
        ' lblPeriode
        ' 
        lblPeriode.AutoSize = True
        lblPeriode.Location = New Point(30, 30)
        lblPeriode.Name = "lblPeriode"
        lblPeriode.Size = New Size(66, 20)
        lblPeriode.TabIndex = 0
        lblPeriode.Text = "Periode :"
        ' 
        ' cbBulan
        ' 
        cbBulan.FormattingEnabled = True
        cbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        cbBulan.Location = New Point(111, 27)
        cbBulan.Name = "cbBulan"
        cbBulan.Size = New Size(134, 28)
        cbBulan.TabIndex = 1
        cbBulan.Text = "Pilih Bulan"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(251, 27)
        txtTahun.Name = "txtTahun"
        txtTahun.PlaceholderText = "Tahun"
        txtTahun.Size = New Size(125, 27)
        txtTahun.TabIndex = 2
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(418, 26)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(131, 29)
        btnTampilkan.TabIndex = 3
        btnTampilkan.Text = "Tampilkan!"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' lblLaporan
        ' 
        lblLaporan.AutoSize = True
        lblLaporan.Location = New Point(30, 80)
        lblLaporan.Name = "lblLaporan"
        lblLaporan.Size = New Size(70, 20)
        lblLaporan.TabIndex = 4
        lblLaporan.Text = "Laporan :"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(678, 398)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 6
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' txtLaporan
        ' 
        txtLaporan.BorderStyle = BorderStyle.FixedSingle
        txtLaporan.Location = New Point(30, 103)
        txtLaporan.Multiline = True
        txtLaporan.Name = "txtLaporan"
        txtLaporan.Size = New Size(742, 277)
        txtLaporan.TabIndex = 7
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtLaporan)
        Controls.Add(btnTutup)
        Controls.Add(lblLaporan)
        Controls.Add(btnTampilkan)
        Controls.Add(txtTahun)
        Controls.Add(cbBulan)
        Controls.Add(lblPeriode)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Laporan Pendapatan Parkir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPeriode As Label
    Friend WithEvents cbBulan As ComboBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents lblLaporan As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents txtLaporan As TextBox
End Class
