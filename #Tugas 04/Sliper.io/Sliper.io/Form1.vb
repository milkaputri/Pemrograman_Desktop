Public Class Form1
    Public Shared SelectedLevel As Integer = 1

    Private Sub btnPlayLv1_Click(sender As Object, e As EventArgs) Handles btnPlayLv1.Click
        SelectedLevel = 1
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlayLv2_Click(sender As Object, e As EventArgs) Handles btnPlayLv2.Click
        SelectedLevel = 2
        Form2.Show()
        Me.Hide()
    End Sub
End Class