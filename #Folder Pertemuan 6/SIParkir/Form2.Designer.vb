<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblUsername = New Label()
        lblPassBaru = New Label()
        lblKetikLagi = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Times New Roman", 10.2F)
        lblUsername.Location = New Point(95, 59)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(78, 19)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassBaru
        ' 
        lblPassBaru.AutoSize = True
        lblPassBaru.Font = New Font("Times New Roman", 10.2F)
        lblPassBaru.Location = New Point(95, 107)
        lblPassBaru.Name = "lblPassBaru"
        lblPassBaru.Size = New Size(110, 19)
        lblPassBaru.TabIndex = 1
        lblPassBaru.Text = "Password Baru"
        ' 
        ' lblKetikLagi
        ' 
        lblKetikLagi.AutoSize = True
        lblKetikLagi.Font = New Font("Times New Roman", 10.2F)
        lblKetikLagi.Location = New Point(96, 163)
        lblKetikLagi.Name = "lblKetikLagi"
        lblKetikLagi.RightToLeft = RightToLeft.Yes
        lblKetikLagi.Size = New Size(81, 19)
        lblKetikLagi.TabIndex = 2
        lblKetikLagi.Text = "Ketik Lagi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(245, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(245, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(211, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(245, 156)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(211, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 10.2F)
        Button1.Location = New Point(245, 213)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 10.2F)
        Button2.Location = New Point(362, 213)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Tutup"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 282)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(lblKetikLagi)
        Controls.Add(lblPassBaru)
        Controls.Add(lblUsername)
        Name = "Form2"
        Text = "SIParkir - Ubah Proifile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassBaru As Label
    Friend WithEvents lblKetikLagi As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
