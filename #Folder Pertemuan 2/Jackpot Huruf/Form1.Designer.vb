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
        components = New ComponentModel.Container()
        Button1 = New Button()
        lblSatu = New Label()
        lblDua = New Label()
        lblTiga = New Label()
        lblStatus = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer4 = New Timer(components)
        Timer3 = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Spin!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblSatu
        ' 
        lblSatu.BorderStyle = BorderStyle.Fixed3D
        lblSatu.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSatu.Location = New Point(12, 57)
        lblSatu.Name = "lblSatu"
        lblSatu.Size = New Size(94, 86)
        lblSatu.TabIndex = 1
        lblSatu.Text = "A"
        lblSatu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDua
        ' 
        lblDua.BorderStyle = BorderStyle.Fixed3D
        lblDua.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDua.Location = New Point(112, 57)
        lblDua.Name = "lblDua"
        lblDua.Size = New Size(94, 86)
        lblDua.TabIndex = 2
        lblDua.Text = "A"
        lblDua.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTiga
        ' 
        lblTiga.BorderStyle = BorderStyle.Fixed3D
        lblTiga.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTiga.Location = New Point(212, 57)
        lblTiga.Name = "lblTiga"
        lblTiga.Size = New Size(94, 86)
        lblTiga.TabIndex = 3
        lblTiga.Text = "A"
        lblTiga.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.BorderStyle = BorderStyle.Fixed3D
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(12, 152)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(69, 32)
        lblStatus.TabIndex = 4
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 9
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Timer3
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(326, 198)
        Controls.Add(lblStatus)
        Controls.Add(lblTiga)
        Controls.Add(lblDua)
        Controls.Add(lblSatu)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Jackpot Huruf"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblSatu As Label
    Friend WithEvents lblDua As Label
    Friend WithEvents lblTiga As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer3 As Timer

End Class
