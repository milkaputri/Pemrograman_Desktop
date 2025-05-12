<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWatermark
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnBatalWm = New Button()
        btnSimpanWM = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kata Watermark :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 27)
        TextBox1.TabIndex = 1
        ' 
        ' btnBatalWm
        ' 
        btnBatalWm.Location = New Point(149, 78)
        btnBatalWm.Name = "btnBatalWm"
        btnBatalWm.Size = New Size(94, 29)
        btnBatalWm.TabIndex = 2
        btnBatalWm.Text = "Batal"
        btnBatalWm.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanWM
        ' 
        btnSimpanWM.Location = New Point(304, 78)
        btnSimpanWM.Name = "btnSimpanWM"
        btnSimpanWM.Size = New Size(94, 29)
        btnSimpanWM.TabIndex = 3
        btnSimpanWM.Text = "Simpan"
        btnSimpanWM.TextImageRelation = TextImageRelation.ImageAboveText
        btnSimpanWM.UseVisualStyleBackColor = True
        ' 
        ' FormWatermark
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 132)
        Controls.Add(btnSimpanWM)
        Controls.Add(btnBatalWm)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "FormWatermark"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Watermark"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBatalWm As Button
    Friend WithEvents btnSimpanWM As Button
End Class
