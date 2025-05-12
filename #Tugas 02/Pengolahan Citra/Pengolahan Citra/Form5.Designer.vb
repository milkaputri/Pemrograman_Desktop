<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistoBalok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnTutupHistoBalok = New Button()
        pbHistoBalok = New PictureBox()
        CType(pbHistoBalok, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTutupHistoBalok
        ' 
        btnTutupHistoBalok.Location = New Point(318, 411)
        btnTutupHistoBalok.Name = "btnTutupHistoBalok"
        btnTutupHistoBalok.Size = New Size(94, 29)
        btnTutupHistoBalok.TabIndex = 3
        btnTutupHistoBalok.Text = "Tutup"
        btnTutupHistoBalok.UseVisualStyleBackColor = True
        ' 
        ' pbHistoBalok
        ' 
        pbHistoBalok.Dock = DockStyle.Top
        pbHistoBalok.Location = New Point(0, 0)
        pbHistoBalok.Name = "pbHistoBalok"
        pbHistoBalok.Size = New Size(438, 377)
        pbHistoBalok.TabIndex = 2
        pbHistoBalok.TabStop = False
        ' 
        ' FormHistoBalok
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 450)
        Controls.Add(btnTutupHistoBalok)
        Controls.Add(pbHistoBalok)
        Name = "FormHistoBalok"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(pbHistoBalok, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTutupHistoBalok As Button
    Friend WithEvents pbHistoBalok As PictureBox
End Class
