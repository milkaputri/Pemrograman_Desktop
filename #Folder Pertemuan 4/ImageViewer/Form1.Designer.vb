<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImageViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageViewer))
        ImageList1 = New ImageList(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusDimension = New ToolStripStatusLabel()
        ToolStripStatusBits = New ToolStripStatusLabel()
        ToolStripStatusResolution = New ToolStripStatusLabel()
        ToolStripStatusRawFormat = New ToolStripStatusLabel()
        ToolTip1 = New ToolTip(components)
        lvImage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        SplitContainerUtama = New SplitContainer()
        tvDrive = New TreeView()
        SplitContainerBawah = New SplitContainer()
        SplitContainerBawah2 = New SplitContainer()
        tcProperties = New TabControl()
        TabControl1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabControl2 = New TabPage()
        lvExif = New ListView()
        chProperty = New ColumnHeader()
        chValue = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerUtama.Panel1.SuspendLayout()
        SplitContainerUtama.Panel2.SuspendLayout()
        SplitContainerUtama.SuspendLayout()
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah.Panel1.SuspendLayout()
        SplitContainerBawah.Panel2.SuspendLayout()
        SplitContainerBawah.SuspendLayout()
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah2.Panel1.SuspendLayout()
        SplitContainerBawah2.Panel2.SuspendLayout()
        SplitContainerBawah2.SuspendLayout()
        tcProperties.SuspendLayout()
        TabControl1.SuspendLayout()
        TabControl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.png")
        ImageList1.Images.SetKeyName(1, "folder.png")
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusDimension, ToolStripStatusBits, ToolStripStatusResolution, ToolStripStatusRawFormat})
        StatusStrip1.Location = New Point(0, 420)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 30)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(50, 24)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusDimension
        ' 
        ToolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        ToolStripStatusDimension.Name = "ToolStripStatusDimension"
        ToolStripStatusDimension.Size = New Size(84, 24)
        ToolStripStatusDimension.Text = "Dimension"
        ' 
        ' ToolStripStatusBits
        ' 
        ToolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusBits.BorderStyle = Border3DStyle.Etched
        ToolStripStatusBits.Name = "ToolStripStatusBits"
        ToolStripStatusBits.Size = New Size(68, 24)
        ToolStripStatusBits.Text = "# of bits"
        ' 
        ' ToolStripStatusResolution
        ' 
        ToolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        ToolStripStatusResolution.Name = "ToolStripStatusResolution"
        ToolStripStatusResolution.Size = New Size(83, 24)
        ToolStripStatusResolution.Text = "Resolution"
        ' 
        ' ToolStripStatusRawFormat
        ' 
        ToolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        ToolStripStatusRawFormat.Name = "ToolStripStatusRawFormat"
        ToolStripStatusRawFormat.Size = New Size(92, 24)
        ToolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        ' 
        ' lvImage
        ' 
        lvImage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        lvImage.Dock = DockStyle.Fill
        lvImage.GridLines = True
        lvImage.Location = New Point(0, 0)
        lvImage.Name = "lvImage"
        lvImage.Size = New Size(624, 217)
        lvImage.SmallImageList = ImageList1
        lvImage.TabIndex = 0
        ToolTip1.SetToolTip(lvImage, "Image file(s)")
        lvImage.UseCompatibleStateImageBehavior = False
        lvImage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Modified Date"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = " Attributes "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 199)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto")
        ' 
        ' SplitContainerUtama
        ' 
        SplitContainerUtama.Dock = DockStyle.Fill
        SplitContainerUtama.Location = New Point(0, 0)
        SplitContainerUtama.Name = "SplitContainerUtama"
        ' 
        ' SplitContainerUtama.Panel1
        ' 
        SplitContainerUtama.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainerUtama.Panel2
        ' 
        SplitContainerUtama.Panel2.Controls.Add(SplitContainerBawah)
        SplitContainerUtama.Size = New Size(800, 420)
        SplitContainerUtama.SplitterDistance = 172
        SplitContainerUtama.TabIndex = 1
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(172, 420)
        tvDrive.TabIndex = 0
        ' 
        ' SplitContainerBawah
        ' 
        SplitContainerBawah.Dock = DockStyle.Fill
        SplitContainerBawah.Location = New Point(0, 0)
        SplitContainerBawah.Name = "SplitContainerBawah"
        SplitContainerBawah.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainerBawah.Panel1
        ' 
        SplitContainerBawah.Panel1.Controls.Add(lvImage)
        ' 
        ' SplitContainerBawah.Panel2
        ' 
        SplitContainerBawah.Panel2.Controls.Add(SplitContainerBawah2)
        SplitContainerBawah.Size = New Size(624, 420)
        SplitContainerBawah.SplitterDistance = 217
        SplitContainerBawah.TabIndex = 0
        ' 
        ' SplitContainerBawah2
        ' 
        SplitContainerBawah2.Dock = DockStyle.Fill
        SplitContainerBawah2.Location = New Point(0, 0)
        SplitContainerBawah2.Name = "SplitContainerBawah2"
        ' 
        ' SplitContainerBawah2.Panel1
        ' 
        SplitContainerBawah2.Panel1.Controls.Add(tcProperties)
        ' 
        ' SplitContainerBawah2.Panel2
        ' 
        SplitContainerBawah2.Panel2.Controls.Add(PictureBox1)
        SplitContainerBawah2.Size = New Size(624, 199)
        SplitContainerBawah2.SplitterDistance = 274
        SplitContainerBawah2.TabIndex = 0
        ' 
        ' tcProperties
        ' 
        tcProperties.Controls.Add(TabControl1)
        tcProperties.Controls.Add(TabControl2)
        tcProperties.Location = New Point(3, 3)
        tcProperties.Name = "tcProperties"
        tcProperties.SelectedIndex = 0
        tcProperties.Size = New Size(269, 193)
        tcProperties.TabIndex = 1
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(PropertyGrid1)
        TabControl1.Location = New Point(4, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Padding(3)
        TabControl1.Size = New Size(261, 160)
        TabControl1.TabIndex = 0
        TabControl1.Text = "Image Properties"
        TabControl1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(255, 154)
        PropertyGrid1.TabIndex = 1
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(lvExif)
        TabControl2.Location = New Point(4, 29)
        TabControl2.Name = "TabControl2"
        TabControl2.Padding = New Padding(3)
        TabControl2.Size = New Size(261, 160)
        TabControl2.TabIndex = 1
        TabControl2.Text = "EXIF Metadata"
        TabControl2.UseVisualStyleBackColor = True
        ' 
        ' lvExif
        ' 
        lvExif.Columns.AddRange(New ColumnHeader() {chProperty, chValue})
        lvExif.Dock = DockStyle.Fill
        lvExif.GridLines = True
        lvExif.Location = New Point(3, 3)
        lvExif.Name = "lvExif"
        lvExif.Size = New Size(255, 154)
        lvExif.TabIndex = 0
        lvExif.UseCompatibleStateImageBehavior = False
        lvExif.View = View.Details
        ' 
        ' chProperty
        ' 
        chProperty.Text = "Property"
        chProperty.Width = 125
        ' 
        ' chValue
        ' 
        chValue.Text = "Value"
        chValue.Width = 125
        ' 
        ' ImageViewer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainerUtama)
        Controls.Add(StatusStrip1)
        Name = "ImageViewer"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.Panel1.ResumeLayout(False)
        SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.ResumeLayout(False)
        SplitContainerBawah.Panel1.ResumeLayout(False)
        SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah.ResumeLayout(False)
        SplitContainerBawah2.Panel1.ResumeLayout(False)
        SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah2.ResumeLayout(False)
        tcProperties.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents lvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Private WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents tcProperties As TabControl
    Friend WithEvents TabControl1 As TabPage
    Friend WithEvents TabControl2 As TabPage
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tvDrive As TreeView

End Class
