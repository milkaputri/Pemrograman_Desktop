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
        Label2 = New Label()
        lblBinary = New Label()
        lblOctal = New Label()
        lblDecimal = New Label()
        lblHexa = New Label()
        btnConvert = New Button()
        txtBinary = New TextBox()
        txtOctal = New TextBox()
        txtDecimal = New TextBox()
        txtHexa = New TextBox()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
        Label2.TabIndex = 2
        Label2.Text = "Hasil Konversi Basis"
        ' 
        ' lblBinary
        ' 
        lblBinary.AutoSize = True
        lblBinary.Location = New Point(15, 132)
        lblBinary.Name = "lblBinary"
        lblBinary.Size = New Size(40, 15)
        lblBinary.TabIndex = 3
        lblBinary.Text = "Binary"
        ' 
        ' lblOctal
        ' 
        lblOctal.AutoSize = True
        lblOctal.Location = New Point(174, 132)
        lblOctal.Name = "lblOctal"
        lblOctal.Size = New Size(35, 15)
        lblOctal.TabIndex = 4
        lblOctal.Text = "Octal"
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.Location = New Point(15, 18)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(50, 15)
        lblDecimal.TabIndex = 5
        lblDecimal.Text = "Decimal"
        ' 
        ' lblHexa
        ' 
        lblHexa.AutoSize = True
        lblHexa.Location = New Point(342, 132)
        lblHexa.Name = "lblHexa"
        lblHexa.Size = New Size(34, 15)
        lblHexa.TabIndex = 6
        lblHexa.Text = "Hexa"
        ' 
        ' btnConvert
        ' 
        btnConvert.BackColor = SystemColors.GradientActiveCaption
        btnConvert.Location = New Point(15, 68)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 7
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = False
        ' 
        ' txtBinary
        ' 
        txtBinary.Location = New Point(15, 150)
        txtBinary.Name = "txtBinary"
        txtBinary.Size = New Size(100, 23)
        txtBinary.TabIndex = 8
        ' 
        ' txtOctal
        ' 
        txtOctal.Location = New Point(174, 150)
        txtOctal.Name = "txtOctal"
        txtOctal.Size = New Size(100, 23)
        txtOctal.TabIndex = 9
        ' 
        ' txtDecimal
        ' 
        txtDecimal.Location = New Point(15, 39)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(100, 23)
        txtDecimal.TabIndex = 10
        ' 
        ' txtHexa
        ' 
        txtHexa.Location = New Point(342, 150)
        txtHexa.Name = "txtHexa"
        txtHexa.Size = New Size(100, 23)
        txtHexa.TabIndex = 11
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClose.ForeColor = SystemColors.ControlLightLight
        btnClose.Location = New Point(96, 68)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 12
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(txtHexa)
        Controls.Add(txtDecimal)
        Controls.Add(txtOctal)
        Controls.Add(txtBinary)
        Controls.Add(btnConvert)
        Controls.Add(lblHexa)
        Controls.Add(lblDecimal)
        Controls.Add(lblOctal)
        Controls.Add(lblBinary)
        Controls.Add(Label2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBinary As Label
    Friend WithEvents lblOctal As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblHexa As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtBinary As TextBox
    Friend WithEvents txtOctal As TextBox
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents txtHexa As TextBox
    Friend WithEvents btnClose As Button

End Class
