<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        lblFahrenheit = New Label()
        lblReamur = New Label()
        lblKelvin = New Label()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(12, 9)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(52, 15)
        lblCelcius.TabIndex = 1
        lblCelcius.Text = "CELCIUS"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(78, 6)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(100, 23)
        txtCelcius.TabIndex = 2
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(214, 6)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 3
        btnConvert.Text = "Convert"
        btnConvert.TextImageRelation = TextImageRelation.TextAboveImage
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(295, 6)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(31, 96)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(63, 15)
        lblFahrenheit.TabIndex = 5
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(170, 96)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(48, 15)
        lblReamur.TabIndex = 6
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(307, 96)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(39, 15)
        lblKelvin.TabIndex = 7
        lblKelvin.Text = "Kelvin"
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(12, 114)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(100, 23)
        txtFahrenheit.TabIndex = 8
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(144, 114)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(100, 23)
        txtReamur.TabIndex = 9
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(270, 114)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(100, 23)
        txtKelvin.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(lblFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
