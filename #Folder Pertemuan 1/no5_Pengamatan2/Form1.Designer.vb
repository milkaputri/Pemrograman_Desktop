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
        txtInput = New TextBox()
        btnHitungAkarPangkat3 = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(405, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 0
        ' 
        ' btnHitungAkarPangkat3
        ' 
        btnHitungAkarPangkat3.BackColor = Color.MistyRose
        btnHitungAkarPangkat3.Location = New Point(536, 12)
        btnHitungAkarPangkat3.Name = "btnHitungAkarPangkat3"
        btnHitungAkarPangkat3.Size = New Size(94, 29)
        btnHitungAkarPangkat3.TabIndex = 1
        btnHitungAkarPangkat3.Text = "Hitung"
        btnHitungAkarPangkat3.UseVisualStyleBackColor = False
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(405, 52)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(42, 20)
        lblHasil.TabIndex = 2
        lblHasil.Text = "Hasil"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(btnHitungAkarPangkat3)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnHitungAkarPangkat3 As Button
    Friend WithEvents lblHasil As Label

End Class
