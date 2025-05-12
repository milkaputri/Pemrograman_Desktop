Public Class FormWatermark
    Public Property WatermarkText As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        WatermarkText = TextBox1.Text
    End Sub

    Private Sub btnBatalWm_Click(sender As Object, e As EventArgs) Handles btnBatalWm.Click
        Me.Close()
    End Sub

    Private Sub btnSimpanWM_Click(sender As Object, e As EventArgs) Handles btnSimpanWM.Click
        WatermarkText = TextBox1.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FormWatermark_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class