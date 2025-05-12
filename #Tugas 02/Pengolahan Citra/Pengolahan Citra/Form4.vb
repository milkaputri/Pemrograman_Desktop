Public Class FormBorder
    Public Property SelectedColor As Color
    Public Property SelectedThickness As Integer
    Private Sub cbWarnaBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWarnaBorder.SelectedIndexChanged
        Select Case cbWarnaBorder.SelectedItem.ToString()
            Case "Red" : SelectedColor = Color.Red
            Case "Green" : SelectedColor = Color.Green
            Case "Blue" : SelectedColor = Color.Blue
            Case "Black" : SelectedColor = Color.Black
            Case "White" : SelectedColor = Color.White
        End Select
    End Sub

    Private Sub cbKetebalanBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKetebalanBorder.SelectedIndexChanged
        Dim ketebalanStr = cbKetebalanBorder.SelectedItem.ToString().Replace("px", "").Trim()
        Integer.TryParse(ketebalanStr, SelectedThickness)
    End Sub

    Private Sub btnBatalBorder_Click(sender As Object, e As EventArgs) Handles btnBatalBorder.Click
        Me.Close()
    End Sub

    Private Sub btnSimpanBorder_Click(sender As Object, e As EventArgs) Handles btnSimpanBorder.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FormBorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class