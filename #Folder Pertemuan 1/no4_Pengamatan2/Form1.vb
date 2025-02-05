Public Class Form1
    Private Function Faktorial(n As Integer) As Long
        If n = 0 OrElse n = 1 Then
            Return 1
        Else
            Return n * Faktorial(n - 1)
        End If
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHasil.Click

    End Sub

    Private Sub btnHitungFaktorial_Click(sender As Object, e As EventArgs) Handles btnHitungFaktorial.Click
        Dim n As Integer
        If Integer.TryParse(txtInput.Text, n) Then
            lblHasil.Text = "Faktorial: " & Faktorial(n).ToString()
        Else
            lblHasil.Text = "Input tidak valid"
        End If
    End Sub
End Class
