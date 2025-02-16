Imports System.Media

Public Class Form2

    'Timer untuk permainan
    Private gameTimer As New Timer()
    Private moleTimer As New Timer()
    Private score As Integer = 0
    Private timeLeft As Integer = 30
    Private highScore As Integer = 0

    'Handler untuk klik mole
    Private Sub pbMole1_Click(sender As Object, e As EventArgs) Handles pbMole1.Click, pbMole2.Click, pbMole3.Click, PictureBox1.Click, pbMole5.Click, pbMole6.Click, PictureBox2.Click
        score += 1
        lblScore.Text = score.ToString()
        CType(sender, PictureBox).Visible = False
        PlaySound("kena.wav") 'Memainkan suara saat mole berhasil diklik
    End Sub

    'Handler untuk tombol reset
    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        ResetGame()
    End Sub

    'Handler saat form dimuat
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set interval timer
        gameTimer.Interval = 1000 '1 detik
        moleTimer.Interval = 1000 '1 detik
        AddHandler gameTimer.Tick, AddressOf GameTimer_Tick
        AddHandler moleTimer.Tick, AddressOf MoleTimer_Tick
        gameTimer.Start()
        moleTimer.Start()
        lblScore.Text = "0"
        lblTime.Text = "30"
        lblHighScore.Text = highScore.ToString()
    End Sub

    'Handler untuk game timer
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs)
        timeLeft -= 1
        lblTime.Text = timeLeft.ToString()

        If timeLeft <= 0 Then
            gameTimer.Stop()
            moleTimer.Stop()
            If score > highScore Then
                highScore = score
                lblHighScore.Text = highScore.ToString()
            End If
            PlaySound("clear.wav") 'Memainkan suara saat game selesai
            Dim result As DialogResult = MessageBox.Show("Waktu habis! Skor Anda: " & score & ". Main lagi?", "Game Over", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ResetGame()
            Else
                Me.Close()
            End If
        End If
    End Sub

    'Handler untuk mole timer
    Private Sub MoleTimer_Tick(sender As Object, e As EventArgs)
        RandomizeMole()
    End Sub

    'Method untuk menampilkan mole secara acak
    Private Sub RandomizeMole()
        'Sembunyikan semua mole
        HideAllMoles()

        'Tampilkan beberapa mole secara acak
        Dim rand As New Random()
        Dim numberOfMolesToShow As Integer = rand.Next(1, 4) 'Tampilkan 1 hingga 3 mole sekaligus

        For i As Integer = 1 To numberOfMolesToShow
            Dim moleIndex As Integer = rand.Next(1, 8)
            Select Case moleIndex
                Case 1
                    pbMole1.Visible = True
                Case 2
                    pbMole2.Visible = True
                Case 3
                    pbMole3.Visible = True
                Case 4
                    PictureBox1.Visible = True
                Case 5
                    pbMole5.Visible = True
                Case 6
                    pbMole6.Visible = True
                Case 7
                    PictureBox2.Visible = True
            End Select
        Next
    End Sub

    'Method untuk menyembunyikan semua mole
    Private Sub HideAllMoles()
        pbMole1.Visible = False
        pbMole2.Visible = False
        pbMole3.Visible = False
        PictureBox1.Visible = False
        pbMole5.Visible = False
        pbMole6.Visible = False
        PictureBox2.Visible = False
    End Sub

    'Method untuk mereset permainan
    Private Sub ResetGame()
        score = 0
        timeLeft = 30
        lblScore.Text = "0"
        lblTime.Text = "30"
        gameTimer.Start()
        moleTimer.Start()
        HideAllMoles() 'Sembunyikan semua mole saat reset
    End Sub

    'Method untuk memainkan suara
    Private Sub PlaySound(soundFile As String)
        Try
            Dim player As New SoundPlayer()
            player.SoundLocation = Application.StartupPath & "\Asset\" & soundFile
            player.Load() 'Memuat file suara
            player.Play() 'Memainkan suara
        Catch ex As Exception
            MessageBox.Show("Error playing sound: " & ex.Message)
        End Try
    End Sub

    'Handler untuk klik yang meleset (misalnya, klik di area kosong)
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        PlaySound("meleset.wav") 'Memainkan suara saat klik meleset
    End Sub
End Class