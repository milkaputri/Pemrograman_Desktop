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
        Dim PictureBox1 As PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        NumericUpDown1 = New NumericUpDown()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        lblBook = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCariMeja = New Button()
        MonthCalendar1 = New MonthCalendar()
        Label5 = New Label()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.SeaShell
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(429, 628)
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(623, 412)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(262, 27)
        NumericUpDown1.TabIndex = 32
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(622, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(263, 27)
        TextBox1.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(668, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Location = New Point(462, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 25
        Label1.Text = "Nama Pemesan :"
        ' 
        ' lblBook
        ' 
        lblBook.AutoSize = True
        lblBook.BackColor = Color.Transparent
        lblBook.Font = New Font("Georgia", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBook.ForeColor = Color.SaddleBrown
        lblBook.Location = New Point(456, 43)
        lblBook.Name = "lblBook"
        lblBook.Size = New Size(405, 35)
        lblBook.TabIndex = 24
        lblBook.Text = "PESAN TEMPAT DUDUK"
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Location = New Point(462, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 27)
        Label2.TabIndex = 34
        Label2.Text = "Tanggal Pemesan :"
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Location = New Point(462, 412)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 27)
        Label3.TabIndex = 36
        Label3.Text = "Jumlah Tamu :"
        ' 
        ' btnCariMeja
        ' 
        btnCariMeja.BackColor = Color.DarkRed
        btnCariMeja.FlatStyle = FlatStyle.Popup
        btnCariMeja.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCariMeja.ForeColor = SystemColors.ButtonFace
        btnCariMeja.Location = New Point(781, 456)
        btnCariMeja.Name = "btnCariMeja"
        btnCariMeja.Size = New Size(104, 29)
        btnCariMeja.TabIndex = 37
        btnCariMeja.Text = "CARI MEJA"
        btnCariMeja.UseVisualStyleBackColor = False
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(623, 136)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Location = New Point(462, 366)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 27)
        Label5.TabIndex = 38
        Label5.Text = "Waktu Berkunjung :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(622, 366)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(263, 27)
        TextBox2.TabIndex = 39
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(966, 627)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(btnCariMeja)
        Controls.Add(Label3)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(NumericUpDown1)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(lblBook)
        Name = "Form2"
        Text = "Form Pemilihan Meja"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBook As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCariMeja As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
