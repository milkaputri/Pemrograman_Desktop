Public Class frmUtama
    'Public namafile As String
    Dim namafile As String
    Dim originalImage As Bitmap
    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog1.FileName

                ' Muat gambar
                Dim img = Image.FromFile(filePath)

                ' Tampilkan di PictureBox dan sesuaikan ukuran
                pbGambar.Image = img
                pbGambar.SizeMode = PictureBoxSizeMode.Zoom ' agar proporsional dan memenuhi kotak

                ' Simpan gambar asli untuk keperluan trackbar atau efek lainnya
                originalImage = New Bitmap(img)

                ' Simpan nama file jika perlu
                namafile = filePath
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then
            MessageBox.Show("Tidak ada gambar yang bisa disimpan. Silakan buka gambar terlebih dahulu.")
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = pbGambar.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " +
        pbGambar.Image.Width.ToString + vbCr + "Tinggi: " +
        pbGambar.Image.Height.ToString)
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        For bar As Integer = 0 To pbGambar.Image.Height - 1
            For kol As Integer = 0 To pbGambar.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        'Dim img As Image
        'img = CType(bmp, Image)
        'PictureBox1.Image = img
        pbGambar.Image = bmp
    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        For bar As Integer = 0 To pbGambar.Image.Height - 1
            For kol As Integer = 0 To pbGambar.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        For bar As Integer = 0 To pbGambar.Image.Height - 1
            For kol As Integer = 0 To pbGambar.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        For bar As Integer = 0 To pbGambar.Image.Height - 1
            For kol As Integer = 0 To pbGambar.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub KurangiKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        For bar As Integer = 0 To pbGambar.Image.Height - 1
            For kol As Integer = 0 To pbGambar.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' Muat ulang gambar dari file
        If String.IsNullOrEmpty(namafile) Then Exit Sub

        Dim bmp As New Bitmap(namafile)
        pbGambar.Image = bmp

        ' Reset gambar asli juga agar efek trackbar kembali dari 0
        originalImage = New Bitmap(bmp)

        ' Reset nilai trackbar ke tengah (0)
        tbRed.Value = 0
        tbGreen.Value = 0
        tbBlue.Value = 0
    End Sub

    Private Sub TampilkanHistogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHistogramToolStripMenuItem.Click
        frmHistogram.ShowDialog()
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)

        ' Kernel Penajaman (Laplacian)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        Dim pembagi As Integer = 3 ' atau bisa 1 jika tidak ingin melemahkan efek

        ' Kernel Emboss
        ' Dim kernel As Integer() = {-2, -1, 0, -1, 1, 1, 0, 1, 2}
        ' Dim pembagi As Integer = 1

        ' Kernel Gaussian Blur
        ' Dim kernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}
        ' Dim pembagi As Integer = 16

        ' Kernel Sobel X (Deteksi Tepi Horizontal)
        '  Dim kernel As Integer() = {-1, 0, 1, -2, 0, 2, -1, 0, 1
        ' Dim pembagi As Integer = 1

        For bar As Integer = 1 To bmp.Height - 2
            For kol As Integer = 1 To bmp.Width - 2
                r = 0 : g = 0 : b = 0
                For i As Integer = 0 To 8
                    Dim px = bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3))
                    r += kernel(i) * px.R
                    g += kernel(i) * px.G
                    b += kernel(i) * px.B
                Next

                r = Math.Floor(r / pembagi)
                g = Math.Floor(g / pembagi)
                b = Math.Floor(b / pembagi)

                ' Clamp nilai warna
                r = Math.Min(255, Math.Max(0, r))
                g = Math.Min(255, Math.Max(0, g))
                b = Math.Min(255, Math.Max(0, b))

                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next

        pbGambar.Image = bmp
    End Sub


    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(pbGambar.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        For bar As Integer = 1 To pbGambar.Image.Height - 2
            For kol As Integer = 1 To pbGambar.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub Putar90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajatToolStripMenuItem.Click
        Dim bmp = New Bitmap(pbGambar.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        pbGambar.Image = bmp
    End Sub

    Private Sub FlipHorisontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorisontalToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then
            MessageBox.Show("Silakan buka gambar terlebih dahulu.")
            Exit Sub
        End If

        Dim srcBmp As New Bitmap(pbGambar.Image)
        Dim width As Integer = srcBmp.Width
        Dim height As Integer = srcBmp.Height
        Dim flippedBmp As New Bitmap(width, height)

        For y As Integer = 0 To height - 1
            For x As Integer = 0 To width - 1
                ' Salin pixel dari kanan ke kiri (mirror horizontal)
                flippedBmp.SetPixel(width - 1 - x, y, srcBmp.GetPixel(x, y))
            Next
        Next

        pbGambar.Image = flippedBmp
    End Sub


    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(pbGambar.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        pbGambar.Image = bmp
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        Dim borderForm As New FormBorder
        If borderForm.ShowDialog() = DialogResult.OK Then
            If pbGambar.Image Is Nothing Then Exit Sub
            Dim bmp As New Bitmap(pbGambar.Image)
            Using g As Graphics = Graphics.FromImage(bmp)
                Dim pen As New Pen(borderForm.SelectedColor, borderForm.SelectedThickness)
                g.DrawRectangle(pen, 0, 0, bmp.Width - 1, bmp.Height - 1)
            End Using
            pbGambar.Image = bmp
        End If
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        Dim wmForm As New FormWatermark
        If wmForm.ShowDialog() = DialogResult.OK Then
            If pbGambar.Image Is Nothing Then Exit Sub

            Dim bmp As New Bitmap(pbGambar.Image)
            Dim watermarkText As String = wmForm.WatermarkText ' misal "Tugas 3"

            Using g As Graphics = Graphics.FromImage(bmp)
                Dim font As New Font("Arial", 24, FontStyle.Bold)
                Dim brush As New SolidBrush(Color.FromArgb(100, Color.White)) ' transparan
                Dim stringSize As SizeF = g.MeasureString(watermarkText, font)

                ' Hitung jumlah baris dan kolom berdasarkan ukuran teks
                Dim spacingX As Integer = CInt(stringSize.Width + 40)
                Dim spacingY As Integer = CInt(stringSize.Height + 30)

                For y As Integer = 0 To bmp.Height Step spacingY
                    For x As Integer = 0 To bmp.Width Step spacingX
                        g.DrawString(watermarkText, font, brush, New PointF(x, y))
                    Next
                Next
            End Using

            pbGambar.Image = bmp
        End If
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)
                Dim R = 255 - c.R
                Dim G = 255 - c.G
                Dim B = 255 - c.B
                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next

        pbGambar.Image = bmp
    End Sub


    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)
                Dim R = Clamp(c.R * 2)
                Dim G = Clamp(c.G \ 2)
                Dim B = Clamp(c.B \ 2)
                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next
        pbGambar.Image = bmp
    End Sub


    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)
                Dim R = Clamp(c.R \ 2)
                Dim G = Clamp(c.G * 2)
                Dim B = Clamp(c.B \ 2)
                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next
        pbGambar.Image = bmp
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)
                Dim R = Clamp(c.R \ 2)
                Dim G = Clamp(c.G \ 2)
                Dim B = Clamp(c.B * 2)
                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next
        pbGambar.Image = bmp
    End Sub


    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)

                ' Kombinasi efek RGB manipulasi unik
                Dim R = Clamp((255 - c.B) + c.R \ 2)
                Dim G = Clamp(c.G * 2 \ 3)
                Dim B = Clamp(c.B \ 3 + c.R \ 3)

                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next

        pbGambar.Image = bmp
    End Sub


    Private Sub HistogramBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBalokToolStripMenuItem.Click
        If pbGambar.Image Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(pbGambar.Image)
        Dim binCount As Integer = 20
        Dim binSize As Integer = 256 \ binCount
        Dim histR(binCount - 1), histG(binCount - 1), histB(binCount - 1) As Integer

        ' Hitung histogram dengan bin
        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = bmp.GetPixel(x, y)
                Dim rIndex = Math.Min(c.R \ binSize, binCount - 1)
                Dim gIndex = Math.Min(c.G \ binSize, binCount - 1)
                Dim bIndex = Math.Min(c.B \ binSize, binCount - 1)

                histR(rIndex) += 1
                histG(gIndex) += 1
                histB(bIndex) += 1
            Next
        Next

        ' Cari nilai maksimum untuk skala tinggi bar
        Dim maxVal = Math.Max(histR.Max(), Math.Max(histG.Max(), histB.Max()))

        ' Ukuran histogram
        Dim barWidth As Integer = 10
        Dim spacing As Integer = 5
        Dim labelHeight As Integer = 20
        Dim histHeight As Integer = 200
        Dim totalBarWidth As Integer = (barWidth * 3 + spacing * 2) * binCount
        Dim histImg As New Bitmap(totalBarWidth, histHeight + labelHeight + 10)

        Using g As Graphics = Graphics.FromImage(histImg)
            g.Clear(Color.White)
            Dim font As New Font("Arial", 8)
            Dim brushBlack As New SolidBrush(Color.Black)

            For i = 0 To binCount - 1
                Dim rH = histR(i) * histHeight \ maxVal
                Dim gH = histG(i) * histHeight \ maxVal
                Dim bH = histB(i) * histHeight \ maxVal

                Dim xPos = i * (barWidth * 3 + spacing * 2)

                ' Gambar batang warna
                g.FillRectangle(Brushes.Red, xPos, histHeight - rH, barWidth, rH)
                g.FillRectangle(Brushes.Green, xPos + barWidth + spacing, histHeight - gH, barWidth, gH)
                g.FillRectangle(Brushes.Blue, xPos + 2 * (barWidth + spacing), histHeight - bH, barWidth, bH)

                ' Label bin bawah bar
                Dim label = $"{i * binSize}-{(i + 1) * binSize - 1}"
                g.DrawString(label, font, brushBlack, xPos, histHeight + 2)
            Next
        End Using

        ' Tampilkan histogram di form
        Dim formHist As New FormHistoBalok
        formHist.pbHistoBalok.Image = histImg
        formHist.pbHistoBalok.SizeMode = PictureBoxSizeMode.AutoSize

        ' Tooltip jika diarahkan mouse
        Dim tooltip As New ToolTip()
        AddHandler formHist.pbHistoBalok.MouseMove, Sub(sender2, e2)
                                                        Dim x = e2.X
                                                        Dim y = e2.Y
                                                        Dim groupWidth = barWidth * 3 + spacing * 2
                                                        Dim i = x \ groupWidth

                                                        If i >= 0 AndAlso i < binCount Then
                                                            Dim label = $"{i * binSize}-{(i + 1) * binSize - 1}" &
                        vbCrLf & $"R: {histR(i)}" &
                        vbCrLf & $"G: {histG(i)}" &
                        vbCrLf & $"B: {histB(i)}"
                                                            tooltip.SetToolTip(formHist.pbHistoBalok, label)
                                                        End If
                                                    End Sub

        formHist.ShowDialog()
    End Sub

    Private Sub tbRed_Scroll(sender As Object, e As EventArgs) Handles tbRed.Scroll
        UpdateRGB()
    End Sub

    Private Sub tbGreen_Scroll(sender As Object, e As EventArgs) Handles tbGreen.Scroll
        UpdateRGB()
    End Sub

    Private Sub tbBlue_Scroll(sender As Object, e As EventArgs) Handles tbBlue.Scroll
        UpdateRGB()
    End Sub

    Private Sub UpdateRGB()
        If originalImage Is Nothing Then Exit Sub

        Dim bmp As New Bitmap(originalImage) ' selalu dari gambar asli

        Dim rOffset = tbRed.Value
        Dim gOffset = tbGreen.Value
        Dim bOffset = tbBlue.Value

        For y = 0 To bmp.Height - 1
            For x = 0 To bmp.Width - 1
                Dim c = originalImage.GetPixel(x, y)
                Dim R = Clamp(c.R + rOffset)
                Dim G = Clamp(c.G + gOffset)
                Dim B = Clamp(c.B + bOffset)
                bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
        Next

        pbGambar.Image = bmp
    End Sub

    Private Function Clamp(value As Integer) As Integer
        Return Math.Max(0, Math.Min(255, value))
    End Function

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbRed.Minimum = -100 : tbRed.Maximum = 100 : tbRed.Value = 0
        tbGreen.Minimum = -100 : tbGreen.Maximum = 100 : tbGreen.Value = 0
        tbBlue.Minimum = -100 : tbBlue.Maximum = 100 : tbBlue.Value = 0
    End Sub
End Class
