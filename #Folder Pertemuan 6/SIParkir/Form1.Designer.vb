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
        lblUsername = New Label()
        lblPassword = New Label()
        tbUsername = New TextBox()
        tbPasword = New TextBox()
        btnLogin = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(111, 66)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(82, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(111, 112)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(79, 20)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(236, 63)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(199, 27)
        tbUsername.TabIndex = 2
        ' 
        ' tbPasword
        ' 
        tbPasword.Location = New Point(236, 105)
        tbPasword.Name = "tbPasword"
        tbPasword.Size = New Size(199, 27)
        tbPasword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Times New Roman", 10.2F)
        btnLogin.Location = New Point(236, 171)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 31)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Font = New Font("Times New Roman", 10.2F)
        btnKeluar.Location = New Point(341, 173)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(551, 282)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(tbPasword)
        Controls.Add(tbUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "Form1"
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPasword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button

End Class
