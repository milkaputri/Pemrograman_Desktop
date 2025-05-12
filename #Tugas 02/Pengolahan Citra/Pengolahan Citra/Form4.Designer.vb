<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBorder
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
        Label2 = New Label()
        cbWarnaBorder = New ComboBox()
        cbKetebalanBorder = New ComboBox()
        btnBatalBorder = New Button()
        btnSimpanBorder = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 20)
        Label1.TabIndex = 0
        Label1.Text = "Warna Border :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ketebalan Border :"
        ' 
        ' cbWarnaBorder
        ' 
        cbWarnaBorder.FormattingEnabled = True
        cbWarnaBorder.Items.AddRange(New Object() {"Red", "Green", "Blue", "Black", "White"})
        cbWarnaBorder.Location = New Point(208, 23)
        cbWarnaBorder.Name = "cbWarnaBorder"
        cbWarnaBorder.Size = New Size(151, 28)
        cbWarnaBorder.TabIndex = 2
        ' 
        ' cbKetebalanBorder
        ' 
        cbKetebalanBorder.FormattingEnabled = True
        cbKetebalanBorder.Items.AddRange(New Object() {"1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px", "10px"})
        cbKetebalanBorder.Location = New Point(208, 74)
        cbKetebalanBorder.Name = "cbKetebalanBorder"
        cbKetebalanBorder.Size = New Size(151, 28)
        cbKetebalanBorder.TabIndex = 3
        ' 
        ' btnBatalBorder
        ' 
        btnBatalBorder.Location = New Point(33, 136)
        btnBatalBorder.Name = "btnBatalBorder"
        btnBatalBorder.Size = New Size(94, 29)
        btnBatalBorder.TabIndex = 4
        btnBatalBorder.Text = "Batal"
        btnBatalBorder.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanBorder
        ' 
        btnSimpanBorder.Location = New Point(265, 136)
        btnSimpanBorder.Name = "btnSimpanBorder"
        btnSimpanBorder.Size = New Size(94, 29)
        btnSimpanBorder.TabIndex = 5
        btnSimpanBorder.Text = "Simpan"
        btnSimpanBorder.UseVisualStyleBackColor = True
        ' 
        ' FormBorder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 205)
        Controls.Add(btnSimpanBorder)
        Controls.Add(btnBatalBorder)
        Controls.Add(cbKetebalanBorder)
        Controls.Add(cbWarnaBorder)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormBorder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbWarnaBorder As ComboBox
    Friend WithEvents cbKetebalanBorder As ComboBox
    Friend WithEvents btnBatalBorder As Button
    Friend WithEvents btnSimpanBorder As Button
End Class
