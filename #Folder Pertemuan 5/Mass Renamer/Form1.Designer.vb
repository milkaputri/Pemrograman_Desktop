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
        cbCaseE = New ComboBox()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        cbCaseF = New ComboBox()
        txtInsertAfterF = New TextBox()
        txtWithThisF = New TextBox()
        txtRightCropNCharF = New TextBox()
        txtReplaceWithE = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        txtInsertAfterE = New TextBox()
        txtWithThisE = New TextBox()
        txtRightCropNCharE = New TextBox()
        txtInsertBeforeF = New TextBox()
        TpExtension = New TabPage()
        lblWithThisE = New Label()
        lblCaseE = New Label()
        rbRightCropNCharE = New RadioButton()
        rbLeftCropNCharE = New RadioButton()
        rbInsertAfterE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        ImageList1 = New ImageList(components)
        btnRename = New Button()
        btnPreview = New Button()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        gbPlace = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        TpAutoNumber = New TabPage()
        gbWith = New GroupBox()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        rbRightCropNCharF = New RadioButton()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lblPreview = New Label()
        lblOri = New Label()
        txtExt = New TextBox()
        lblExt = New Label()
        btnPath = New Button()
        txtPath = New TextBox()
        lblPath = New Label()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        TpFilename = New TabPage()
        rbLeftCropNCharF = New RadioButton()
        rbInsertAfterF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        btnUndo = New Button()
        TpExtension.SuspendLayout()
        gbPlace.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        TpAutoNumber.SuspendLayout()
        gbWith.SuspendLayout()
        TabControl1.SuspendLayout()
        TpFilename.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(550, 7)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(212, 28)
        cbCaseE.TabIndex = 31
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(152, 112)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(238, 27)
        txtLeftCropNCharE.TabIndex = 27
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(152, 77)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(238, 27)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(152, 42)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(271, 27)
        txtReplaceThisE.TabIndex = 25
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(553, 10)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(212, 28)
        cbCaseF.TabIndex = 15
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(511, 80)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(254, 27)
        txtInsertAfterF.TabIndex = 14
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(511, 45)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(254, 27)
        txtWithThisF.TabIndex = 13
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(553, 115)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(174, 27)
        txtRightCropNCharF.TabIndex = 12
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(152, 7)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(343, 27)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(155, 115)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(238, 27)
        txtLeftCropNCharF.TabIndex = 11
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(155, 45)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(271, 27)
        txtReplaceThisF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(155, 10)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(343, 27)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(435, 51)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(73, 20)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "With This:"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(507, 18)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(43, 20)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case:"
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(508, 77)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(254, 27)
        txtInsertAfterE.TabIndex = 30
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(508, 42)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(254, 27)
        txtWithThisE.TabIndex = 29
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(550, 112)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(174, 27)
        txtRightCropNCharE.TabIndex = 28
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(155, 80)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(238, 27)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' TpExtension
        ' 
        TpExtension.Controls.Add(cbCaseE)
        TpExtension.Controls.Add(txtInsertAfterE)
        TpExtension.Controls.Add(txtWithThisE)
        TpExtension.Controls.Add(txtRightCropNCharE)
        TpExtension.Controls.Add(txtLeftCropNCharE)
        TpExtension.Controls.Add(txtInsertBeforeE)
        TpExtension.Controls.Add(txtReplaceThisE)
        TpExtension.Controls.Add(txtReplaceWithE)
        TpExtension.Controls.Add(lblWithThisE)
        TpExtension.Controls.Add(lblCaseE)
        TpExtension.Controls.Add(rbRightCropNCharE)
        TpExtension.Controls.Add(rbLeftCropNCharE)
        TpExtension.Controls.Add(rbInsertAfterE)
        TpExtension.Controls.Add(rbInsertBeforeE)
        TpExtension.Controls.Add(rbReplaceThisE)
        TpExtension.Controls.Add(rbReplaceWithE)
        TpExtension.Location = New Point(4, 29)
        TpExtension.Name = "TpExtension"
        TpExtension.Padding = New Padding(3)
        TpExtension.Size = New Size(771, 160)
        TpExtension.TabIndex = 1
        TpExtension.Text = "Extension"
        TpExtension.UseVisualStyleBackColor = True
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(432, 48)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(73, 20)
        lblWithThisE.TabIndex = 23
        lblWithThisE.Text = "With This:"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(504, 15)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(43, 20)
        lblCaseE.TabIndex = 22
        lblCaseE.Text = "Case:"
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(399, 116)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(148, 24)
        rbRightCropNCharE.TabIndex = 21
        rbRightCropNCharE.TabStop = True
        rbRightCropNCharE.Text = "Right Crop n char:"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(11, 116)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(138, 24)
        rbLeftCropNCharE.TabIndex = 20
        rbLeftCropNCharE.TabStop = True
        rbLeftCropNCharE.Text = "Left Crop n char:"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(399, 81)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(106, 24)
        rbInsertAfterE.TabIndex = 19
        rbInsertAfterE.TabStop = True
        rbInsertAfterE.Text = "Insert After:"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(11, 81)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(117, 24)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.TabStop = True
        rbInsertBeforeE.Text = "Insert Before:"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(11, 46)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(116, 24)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.TabStop = True
        rbReplaceThisE.Text = "Replace This:"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(11, 11)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(121, 24)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace With:"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(798, 534)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(112, 29)
        btnRename.TabIndex = 24
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(798, 499)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(112, 29)
        btnPreview.TabIndex = 23
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(24, 74)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(136, 24)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(24, 35)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(125, 24)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(18, 19)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(250, 124)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(163, 74)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(150, 27)
        nudIncrementBy.TabIndex = 3
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(163, 35)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(150, 27)
        nudStartWithNumber.TabIndex = 2
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' TpAutoNumber
        ' 
        TpAutoNumber.Controls.Add(gbWith)
        TpAutoNumber.Controls.Add(gbPlace)
        TpAutoNumber.Location = New Point(4, 29)
        TpAutoNumber.Name = "TpAutoNumber"
        TpAutoNumber.Size = New Size(771, 160)
        TpAutoNumber.TabIndex = 2
        TpAutoNumber.Text = "Autonumber"
        TpAutoNumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(304, 19)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(353, 125)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With:"
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(27, 76)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(98, 20)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(27, 37)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(130, 20)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start with number:"
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(402, 119)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(148, 24)
        rbRightCropNCharF.TabIndex = 5
        rbRightCropNCharF.TabStop = True
        rbRightCropNCharF.Text = "Right Crop n char:"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.Location = New Point(13, 82)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(438, 368)
        lvOri.TabIndex = 20
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        chFileName.Width = 100
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 100
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        chAttribute.Width = 100
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        chCreated.Width = 100
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        chAccessed.Width = 100
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        chModified.Width = 100
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(472, 59)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(90, 20)
        lblPreview.TabIndex = 19
        lblPreview.Text = "Preview File:"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(13, 59)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(92, 20)
        lblOri.TabIndex = 18
        lblOri.Text = "Original File:"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(809, 12)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(101, 27)
        txtExt.TabIndex = 17
        txtExt.Text = "*.*"
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(750, 15)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(59, 20)
        lblExt.TabIndex = 16
        lblExt.Text = "File Ext:"
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(680, 11)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(64, 29)
        btnPath.TabIndex = 15
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(59, 12)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(615, 27)
        txtPath.TabIndex = 14
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(13, 15)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(40, 20)
        lblPath.TabIndex = 13
        lblPath.Text = "Path:"
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(472, 82)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(438, 368)
        lvPreview.TabIndex = 21
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        chFileName2.Width = 100
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        chExtension2.Width = 100
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        chAttribute2.Width = 100
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        chCreated2.Width = 100
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        chAccessed2.Width = 100
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        chModified2.Width = 100
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpFilename)
        TabControl1.Controls.Add(TpExtension)
        TabControl1.Controls.Add(TpAutoNumber)
        TabControl1.Location = New Point(13, 470)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(779, 193)
        TabControl1.TabIndex = 22
        ' 
        ' TpFilename
        ' 
        TpFilename.Controls.Add(cbCaseF)
        TpFilename.Controls.Add(txtInsertAfterF)
        TpFilename.Controls.Add(txtWithThisF)
        TpFilename.Controls.Add(txtRightCropNCharF)
        TpFilename.Controls.Add(txtLeftCropNCharF)
        TpFilename.Controls.Add(txtInsertBeforeF)
        TpFilename.Controls.Add(txtReplaceThisF)
        TpFilename.Controls.Add(txtReplaceWithF)
        TpFilename.Controls.Add(lblWithThisF)
        TpFilename.Controls.Add(lblCaseF)
        TpFilename.Controls.Add(rbRightCropNCharF)
        TpFilename.Controls.Add(rbLeftCropNCharF)
        TpFilename.Controls.Add(rbInsertAfterF)
        TpFilename.Controls.Add(rbInsertBeforeF)
        TpFilename.Controls.Add(rbReplaceThisF)
        TpFilename.Controls.Add(rbReplaceWithF)
        TpFilename.Location = New Point(4, 29)
        TpFilename.Name = "TpFilename"
        TpFilename.Padding = New Padding(3)
        TpFilename.Size = New Size(771, 160)
        TpFilename.TabIndex = 0
        TpFilename.Text = "Filename"
        TpFilename.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(14, 119)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(138, 24)
        rbLeftCropNCharF.TabIndex = 4
        rbLeftCropNCharF.TabStop = True
        rbLeftCropNCharF.Text = "Left Crop n char:"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(402, 84)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(106, 24)
        rbInsertAfterF.TabIndex = 3
        rbInsertAfterF.TabStop = True
        rbInsertAfterF.Text = "Insert After:"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(14, 84)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(117, 24)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.TabStop = True
        rbInsertBeforeF.Text = "Insert Before:"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(14, 49)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(116, 24)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.TabStop = True
        rbReplaceThisF.Text = "Replace This:"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(14, 14)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(121, 24)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With:"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(798, 569)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(112, 29)
        btnUndo.TabIndex = 25
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 674)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Controls.Add(lvPreview)
        Controls.Add(TabControl1)
        Controls.Add(btnUndo)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TpExtension.ResumeLayout(False)
        TpExtension.PerformLayout()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        TpAutoNumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        TabControl1.ResumeLayout(False)
        TpFilename.ResumeLayout(False)
        TpFilename.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnRename As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblOri As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblExt As Label
    Friend WithEvents btnPath As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents btnUndo As Button

End Class
