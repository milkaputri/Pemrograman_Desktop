Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Agar Form bisa menerima input keyboard
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form2.Show()
            Form2.RestartGame()
            Me.Hide()
        End If
    End Sub


    Public Sub SetScore(currentScore As Integer, highScore As Integer)
        lblScore.Text = "Score: " & currentScore
        lblHighScore.Text = "High Score: " & highScore
    End Sub

End Class
