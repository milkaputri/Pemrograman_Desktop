Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHasil.Click

    End Sub

    Private Sub btnHitungAkarPangkat3_Click(sender As Object, e As EventArgs) Handles btnHitungAkarPangkat3.Click
        Dim nilai As Double
        If Double.TryParse(txtInput.Text, nilai) Then
            Dim hasil As Double = Math.Pow(nilai, 1 / 3)
            lblHasil.Text = "Akar Pangkat 3: " & hasil.ToString()
        Else
            lblHasil.Text = "Input tidak valid"
        End If
    End Sub
End Class
