<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnKeluar = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(89, 84)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(82, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(213, 81)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(225, 27)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(89, 135)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(77, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password :"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(213, 132)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(225, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(333, 186)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(105, 35)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(213, 186)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(105, 35)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 282)
        Controls.Add(btnLogin)
        Controls.Add(btnKeluar)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        KeyPreview = True
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnLogin As Button

End Class
