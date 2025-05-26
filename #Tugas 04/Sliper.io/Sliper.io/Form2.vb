Imports System.IO

Public Class Form2
    Dim player As New Snake(Color.Lime)
    Dim bots As New List(Of Snake)
    Dim foods As New List(Of Point)
    Dim rand As New Random()
    Dim direction As Keys = Keys.Right
    Dim score As Integer = 0
    Dim gameTimer As New Timer With {.Interval = 150}
    Dim highScorePath As String = Path.Combine(Application.StartupPath, "highscore.txt")
    Dim highScore As Integer = 0
    Dim gridSize As Integer = 20
    Dim gridWidth As Integer
    Dim gridHeight As Integer

    Dim lives As Integer = 3
    Dim heartImage As Image = Image.FromFile("D:\Pemrograman Dekstop\Pemrograman_Desktop\#Tugas 04\Sliper.io\Sliper.io\assets\love.png")

    Public Sub RestartGame()
        direction = Keys.Right
        score = 0
        lives = If(Form1.SelectedLevel = 2, 1, 3)
        InitGame()
        gameTimer.Start()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        gridWidth = Me.ClientSize.Width \ gridSize
        gridHeight = Me.ClientSize.Height \ gridSize
        InitGame()
        AddHandler gameTimer.Tick, AddressOf GameLoop
        gameTimer.Start()
    End Sub

    Private Sub InitGame()
        player.Reset(New Point(10, 10))
        bots.Clear()

        If Form1.SelectedLevel = 1 Then
            bots.Add(New Snake(Color.Red))
            bots(0).Reset(New Point(5, 5))
            bots.Add(New Snake(Color.Orange))
            bots(1).Reset(New Point(15, 5))
            lives = 3
        ElseIf Form1.SelectedLevel = 2 Then
            lives = 1
            Dim colors As Color() = {Color.Red, Color.Orange, Color.Blue, Color.Purple}
            For i As Integer = 0 To colors.Length - 1
                Dim bot As New Snake(colors(i))
                bot.Reset(New Point(5 + i * 2, 5))
                bots.Add(bot)
            Next
        End If

        GenerateFoods()
        LoadHighScore()
    End Sub

    Private Sub GenerateFoods()
        foods.Clear()
        While foods.Count < 5
            Dim pt As New Point(rand.Next(0, gridWidth), rand.Next(0, gridHeight))
            If Not player.Body.Contains(pt) AndAlso Not bots.Any(Function(b) b.Body.Contains(pt)) Then
                foods.Add(pt)
            End If
        End While
    End Sub

    Private Sub GameLoop(sender As Object, e As EventArgs)
        Dim playerGrow As Boolean = False
        Dim botGrowStatus As New Dictionary(Of Snake, Boolean)

        ' Deteksi makanan dimakan player
        For i = foods.Count - 1 To 0 Step -1
            If player.Head = foods(i) Then
                playerGrow = True
                score += 10
                foods.RemoveAt(i)
                GenerateFoods()
            End If
        Next

        player.Move(direction, playerGrow, gridWidth, gridHeight)

        ' Deteksi makanan dimakan bot, dan set grow
        For Each bot In bots
            Dim growBot As Boolean = False
            For i = foods.Count - 1 To 0 Step -1
                If bot.Head = foods(i) Then
                    growBot = True
                    foods.RemoveAt(i)
                    GenerateFoods()
                End If
            Next
            botGrowStatus(bot) = growBot
        Next

        ' Gerakkan semua bot dengan info grow
        For Each bot In bots
            Dim grow = If(botGrowStatus.ContainsKey(bot), botGrowStatus(bot), False)
            bot.MoveBot(foods, rand, grow, gridWidth, gridHeight)
        Next

        ' Deteksi tabrakan player
        If player.CheckCollisionWith(player) OrElse bots.Any(Function(b) player.CheckCollisionWith(b)) Then
            lives -= 1
            If lives <= 0 Then
                GameOver()
                Exit Sub
            Else
                player.Reset(New Point(10, 10))
            End If
        End If

        ' Deteksi tabrakan antar bot dan player
        For Each bot In bots
            If bot.CheckCollisionWith(player) OrElse bots.Any(Function(b) b IsNot bot AndAlso bot.CheckCollisionWith(b)) Then
                bot.Reset(New Point(rand.Next(0, gridWidth), rand.Next(0, gridHeight)))
                score += 50
            End If
        Next

        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        For Each part In player.Body
            e.Graphics.FillRectangle(Brushes.Lime, part.X * gridSize, part.Y * gridSize, gridSize - 2, gridSize - 2)
        Next

        For Each bot In bots
            For Each part In bot.Body
                e.Graphics.FillRectangle(New SolidBrush(bot.Color), part.X * gridSize, part.Y * gridSize, gridSize - 2, gridSize - 2)
            Next
        Next

        For Each f In foods
            e.Graphics.FillEllipse(Brushes.Yellow, f.X * gridSize, f.Y * gridSize, gridSize - 2, gridSize - 2)
        Next

        Dim totalHeartWidth As Integer = lives * 30
        Dim startX As Integer = Me.ClientSize.Width - totalHeartWidth - 10
        Dim y As Integer = 10

        For i As Integer = 0 To lives - 1
            e.Graphics.DrawImage(heartImage, startX + i * 30, y, 25, 25)
        Next

        e.Graphics.DrawString("Level: " & Form1.SelectedLevel, New Font("Arial", 12, FontStyle.Bold), Brushes.White, 10, 10)
        e.Graphics.DrawString("Score: " & score, New Font("Arial", 12, FontStyle.Bold), Brushes.White, 10, 30)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up AndAlso direction <> Keys.Down Then direction = Keys.Up
        If e.KeyCode = Keys.Down AndAlso direction <> Keys.Up Then direction = Keys.Down
        If e.KeyCode = Keys.Left AndAlso direction <> Keys.Right Then direction = Keys.Left
        If e.KeyCode = Keys.Right AndAlso direction <> Keys.Left Then direction = Keys.Right

        ' Tambahkan ini untuk keluar saat ESC ditekan
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub


    Private Sub GameOver()
        gameTimer.Stop()
        SaveHighScore()
        Form3.SetScore(score, highScore)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub LoadHighScore()
        If File.Exists(highScorePath) Then
            Integer.TryParse(File.ReadAllText(highScorePath), highScore)
        End If
    End Sub

    Private Sub SaveHighScore()
        If score > highScore Then
            File.WriteAllText(highScorePath, score.ToString())
        End If
    End Sub
End Class


'========== Snake.vb ==========
Public Class Snake
    Public Body As New List(Of Point)
    Private clr As Color

    Public Sub New(c As Color)
        clr = c
    End Sub

    Public Sub Reset(pos As Point)
        Body.Clear()
        Body.Add(pos)
    End Sub

    Public Sub Move(dir As Keys, Optional growNow As Boolean = False, Optional maxX As Integer = 40, Optional maxY As Integer = 25)
        Dim head = Body(0)
        Select Case dir
            Case Keys.Up : head.Y -= 1
            Case Keys.Down : head.Y += 1
            Case Keys.Left : head.X -= 1
            Case Keys.Right : head.X += 1
        End Select

        If head.X < 0 Then head.X = maxX - 1
        If head.X >= maxX Then head.X = 0
        If head.Y < 0 Then head.Y = maxY - 1
        If head.Y >= maxY Then head.Y = 0

        Body.Insert(0, head)
        If Not growNow Then Body.RemoveAt(Body.Count - 1)
    End Sub

    Public ReadOnly Property Head As Point
        Get
            Return Body(0)
        End Get
    End Property

    Public ReadOnly Property Color As Color
        Get
            Return clr
        End Get
    End Property

    Public Function CheckCollisionWith(other As Snake) As Boolean
        For i = 0 To other.Body.Count - 1
            If Me.Body(0) = other.Body(i) Then
                If other Is Me AndAlso i = 0 Then Continue For
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub MoveBot(foods As List(Of Point), rand As Random, Optional growNow As Boolean = False, Optional maxX As Integer = 40, Optional maxY As Integer = 25)
        If foods.Count = 0 Then Exit Sub

        Dim target = foods.OrderBy(Function(f) Distance(Body(0), f)).First()
        Dim dx = target.X - Body(0).X
        Dim dy = target.Y - Body(0).Y
        Dim newDir As Keys

        If Math.Abs(dx) > Math.Abs(dy) Then
            newDir = If(dx > 0, Keys.Right, Keys.Left)
        Else
            newDir = If(dy > 0, Keys.Down, Keys.Up)
        End If

        Move(newDir, growNow, maxX, maxY)
    End Sub

    Private Function Distance(p1 As Point, p2 As Point) As Integer
        Return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y)
    End Function
End Class
