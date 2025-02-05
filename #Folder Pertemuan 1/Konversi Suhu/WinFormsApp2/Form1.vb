Imports System.Diagnostics.Eventing

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCelcius.Click

    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        txtFahrenheit.Text = CStr(fahrenheit)
        txtReamur.Text = CStr(reamur)
        txtKelvin.Text = CStr(kelvin)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub lblKelvin_Click(sender As Object, e As EventArgs) Handles lblKelvin.Click

    End Sub

    Private Sub lblFahrenheit_Click(sender As Object, e As EventArgs) Handles lblFahrenheit.Click

    End Sub
End Class
