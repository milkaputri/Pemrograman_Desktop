﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pbPlay = New PictureBox()
        CType(pbPlay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbPlay
        ' 
        pbPlay.BackColor = Color.Transparent
        pbPlay.BackgroundImage = CType(resources.GetObject("pbPlay.BackgroundImage"), Image)
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.Location = New Point(-1, 2)
        pbPlay.Name = "pbPlay"
        pbPlay.Size = New Size(682, 842)
        pbPlay.TabIndex = 0
        pbPlay.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 837)
        Controls.Add(pbPlay)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Whack a Mole!"
        CType(pbPlay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbPlay As PictureBox

End Class