<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        txtUsername = New TextBox()
        lblPasswordBaru = New Label()
        txtPassBaru = New TextBox()
        lblConfPass = New Label()
        txtConfPass = New TextBox()
        btnTutup = New Button()
        btnSimpan = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(70, 42)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(82, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(220, 39)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(240, 27)
        txtUsername.TabIndex = 1
        ' 
        ' lblPasswordBaru
        ' 
        lblPasswordBaru.AutoSize = True
        lblPasswordBaru.Location = New Point(70, 104)
        lblPasswordBaru.Name = "lblPasswordBaru"
        lblPasswordBaru.Size = New Size(111, 20)
        lblPasswordBaru.TabIndex = 2
        lblPasswordBaru.Text = "Password Baru :"
        ' 
        ' txtPassBaru
        ' 
        txtPassBaru.Location = New Point(220, 101)
        txtPassBaru.Name = "txtPassBaru"
        txtPassBaru.Size = New Size(240, 27)
        txtPassBaru.TabIndex = 3
        ' 
        ' lblConfPass
        ' 
        lblConfPass.AutoSize = True
        lblConfPass.Location = New Point(70, 173)
        lblConfPass.Name = "lblConfPass"
        lblConfPass.Size = New Size(134, 20)
        lblConfPass.TabIndex = 4
        lblConfPass.Text = "Confirm Password :"
        ' 
        ' txtConfPass
        ' 
        txtConfPass.Location = New Point(220, 170)
        txtConfPass.Name = "txtConfPass"
        txtConfPass.Size = New Size(240, 27)
        txtConfPass.TabIndex = 5
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(366, 223)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 6
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(257, 223)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 282)
        Controls.Add(btnSimpan)
        Controls.Add(btnTutup)
        Controls.Add(txtConfPass)
        Controls.Add(lblConfPass)
        Controls.Add(txtPassBaru)
        Controls.Add(lblPasswordBaru)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPasswordBaru As Label
    Friend WithEvents txtPassBaru As TextBox
    Friend WithEvents lblConfPass As Label
    Friend WithEvents txtConfPass As TextBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnSimpan As Button
End Class
