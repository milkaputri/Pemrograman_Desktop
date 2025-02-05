Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblOctal.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtOctal.TextChanged

    End Sub

    Private Sub txtBiner_TextChanged(sender As Object, e As EventArgs) Handles txtBinary.TextChanged

    End Sub

    Private Sub txtBasis_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decimalNumber As Integer
        Dim binaryNumber As String
        Dim octalNumber As String
        Dim hexadecimalNumber As String

        ' Mengambil input dari textbox
        decimalNumber = Val(txtDecimal.Text)

        ' Konversi ke basis 2
        binaryNumber = Convert.ToString(decimalNumber, 2)

        ' Konversi ke basis 8
        octalNumber = Convert.ToString(decimalNumber, 8)

        ' Konversi ke basis 16
        hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper()

        ' Menampilkan hasil konversi
        txtBinary.Text = binaryNumber
        txtOctal.Text = octalNumber
        txtHexa.Text = hexadecimalNumber

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
