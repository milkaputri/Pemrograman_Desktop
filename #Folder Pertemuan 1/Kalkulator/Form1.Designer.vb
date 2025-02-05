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
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        CmdEqual = New Button()
        CmdAddition = New Button()
        CmdInverse = New Button()
        CmdSubtract = New Button()
        CmdSqrt = New Button()
        CmdMultiply = New Button()
        CmdPowerOf = New Button()
        CmdDecimal = New Button()
        CmdSign = New Button()
        CmdDivision = New Button()
        Cmd0 = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd1 = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        Cmd7 = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(272, 69)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(3, 21)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(266, 27)
        txtInput.TabIndex = 2
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(CmdDecimal)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd7)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(12, 87)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(272, 243)
        Panel2.TabIndex = 1
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(212, 182)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(42, 37)
        CmdEqual.TabIndex = 22
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(164, 182)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(42, 37)
        CmdAddition.TabIndex = 21
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(212, 139)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(42, 37)
        CmdInverse.TabIndex = 20
        CmdInverse.Text = "1/x"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(164, 139)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(42, 37)
        CmdSubtract.TabIndex = 19
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(212, 96)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(57, 37)
        CmdSqrt.TabIndex = 18
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(164, 96)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(42, 37)
        CmdMultiply.TabIndex = 17
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(212, 53)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(42, 37)
        CmdPowerOf.TabIndex = 16
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(99, 182)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(42, 37)
        CmdDecimal.TabIndex = 15
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(51, 182)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(42, 37)
        CmdSign.TabIndex = 14
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(164, 53)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(42, 37)
        CmdDivision.TabIndex = 14
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(3, 182)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(42, 37)
        Cmd0.TabIndex = 13
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(99, 139)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(42, 37)
        Cmd3.TabIndex = 12
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(51, 139)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(42, 37)
        Cmd2.TabIndex = 11
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(3, 139)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(42, 37)
        Cmd1.TabIndex = 10
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(99, 96)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(42, 37)
        Cmd6.TabIndex = 9
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(51, 96)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(42, 37)
        Cmd5.TabIndex = 8
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(3, 96)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(42, 37)
        Cmd4.TabIndex = 7
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(98, 53)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(42, 37)
        Cmd9.TabIndex = 6
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(50, 53)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(42, 37)
        Cmd8.TabIndex = 5
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(3, 53)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(42, 37)
        Cmd7.TabIndex = 4
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(212, 10)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(42, 37)
        cmdC.TabIndex = 3
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(164, 10)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(42, 37)
        cmdCE.TabIndex = 2
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(3, 10)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(89, 37)
        cmdBackspace.TabIndex = 2
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdInverse As Button

End Class
