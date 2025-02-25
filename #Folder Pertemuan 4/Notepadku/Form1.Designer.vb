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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        PageSetupToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UnfoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripSeparator()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FindNextToolStripMenuItem = New ToolStripMenuItem()
        ReplaceToolStripMenuItem = New ToolStripMenuItem()
        GoToToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        InsertDateTimeToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripSeparator()
        AboutNotepadKuToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusLine = New ToolStripStatusLabel()
        insertStripStatus = New ToolStripStatusLabel()
        capsStripStatus = New ToolStripStatusLabel()
        numStripStatus = New ToolStripStatusLabel()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        PrintDialog1 = New PrintDialog()
        PageSetupDialog1 = New PageSetupDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDocument2 = New Printing.PrintDocument()
        txtNotepad = New TextBox()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripMenuItem2, PageSetupToolStripMenuItem, PrintToolStripMenuItem, ToolStripMenuItem3, CloseToolStripMenuItem, ExitToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(46, 24)
        ToolStripMenuItem1.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(166, 26)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(166, 26)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(166, 26)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(166, 26)
        SaveAsToolStripMenuItem.Text = "Save &as..."
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(163, 6)
        ' 
        ' PageSetupToolStripMenuItem
        ' 
        PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        PageSetupToolStripMenuItem.Size = New Size(166, 26)
        PageSetupToolStripMenuItem.Text = "&Page Setup"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(166, 26)
        PrintToolStripMenuItem.Text = "P&rint"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(163, 6)
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(166, 26)
        CloseToolStripMenuItem.Text = "&Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(166, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UnfoToolStripMenuItem, ToolStripMenuItem4, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripMenuItem5, FindToolStripMenuItem, FindNextToolStripMenuItem, ReplaceToolStripMenuItem, GoToToolStripMenuItem, ToolStripMenuItem6, SelectAllToolStripMenuItem, InsertDateTimeToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UnfoToolStripMenuItem
        ' 
        UnfoToolStripMenuItem.Name = "UnfoToolStripMenuItem"
        UnfoToolStripMenuItem.Size = New Size(201, 26)
        UnfoToolStripMenuItem.Text = "Undo"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(198, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(201, 26)
        CutToolStripMenuItem.Text = "&Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(201, 26)
        CopyToolStripMenuItem.Text = "C&opy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(201, 26)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(198, 6)
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(201, 26)
        FindToolStripMenuItem.Text = "&Find..."
        ' 
        ' FindNextToolStripMenuItem
        ' 
        FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        FindNextToolStripMenuItem.Size = New Size(201, 26)
        FindNextToolStripMenuItem.Text = "Find &Next"
        ' 
        ' ReplaceToolStripMenuItem
        ' 
        ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        ReplaceToolStripMenuItem.Size = New Size(201, 26)
        ReplaceToolStripMenuItem.Text = "&Replace..."
        ' 
        ' GoToToolStripMenuItem
        ' 
        GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        GoToToolStripMenuItem.Size = New Size(201, 26)
        GoToToolStripMenuItem.Text = "&Go To..."
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(198, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(201, 26)
        SelectAllToolStripMenuItem.Text = "&Select All"
        ' 
        ' InsertDateTimeToolStripMenuItem
        ' 
        InsertDateTimeToolStripMenuItem.Name = "InsertDateTimeToolStripMenuItem"
        InsertDateTimeToolStripMenuItem.Size = New Size(201, 26)
        InsertDateTimeToolStripMenuItem.Text = "Insert Date &Time"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WordWrapToolStripMenuItem, FontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(70, 24)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' WordWrapToolStripMenuItem
        ' 
        WordWrapToolStripMenuItem.Checked = True
        WordWrapToolStripMenuItem.CheckState = CheckState.Checked
        WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        WordWrapToolStripMenuItem.Size = New Size(165, 26)
        WordWrapToolStripMenuItem.Text = "&Word wrap"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(165, 26)
        FontToolStripMenuItem.Text = "F&ont"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StatusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(158, 26)
        StatusBarToolStripMenuItem.Text = "&Status Bar"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem, ToolStripMenuItem7, AboutNotepadKuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(64, 24)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(213, 26)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(210, 6)
        ' 
        ' AboutNotepadKuToolStripMenuItem
        ' 
        AboutNotepadKuToolStripMenuItem.Name = "AboutNotepadKuToolStripMenuItem"
        AboutNotepadKuToolStripMenuItem.Size = New Size(213, 26)
        AboutNotepadKuToolStripMenuItem.Text = "About NotepadKu"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusLine, insertStripStatus, capsStripStatus, numStripStatus})
        StatusStrip1.Location = New Point(0, 420)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 30)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(50, 24)
        toolStripStatusReady.Text = "Ready"
        ' 
        ' toolStripStatusLine
        ' 
        toolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        toolStripStatusLine.BorderStyle = Border3DStyle.Etched
        toolStripStatusLine.Name = "toolStripStatusLine"
        toolStripStatusLine.Size = New Size(55, 24)
        toolStripStatusLine.Text = "Line: 1"
        ' 
        ' insertStripStatus
        ' 
        insertStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        insertStripStatus.BorderStyle = Border3DStyle.Etched
        insertStripStatus.Enabled = False
        insertStripStatus.Name = "insertStripStatus"
        insertStripStatus.Size = New Size(36, 24)
        insertStripStatus.Text = "INS"
        ' 
        ' capsStripStatus
        ' 
        capsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        capsStripStatus.BorderStyle = Border3DStyle.Etched
        capsStripStatus.Enabled = False
        capsStripStatus.Name = "capsStripStatus"
        capsStripStatus.Size = New Size(48, 24)
        capsStripStatus.Text = "CAPS"
        ' 
        ' numStripStatus
        ' 
        numStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        numStripStatus.BorderStyle = Border3DStyle.Etched
        numStripStatus.Enabled = False
        numStripStatus.Name = "numStripStatus"
        numStripStatus.Size = New Size(47, 24)
        numStripStatus.Text = "NUM"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "*.txt"
        OpenFileDialog1.FileName = "Untitled"
        OpenFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        OpenFileDialog1.Title = "Open File Text"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PageSetupDialog1
        ' 
        PageSetupDialog1.EnableMetric = True
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "*.txt"
        SaveFileDialog1.FileName = "Untitled.txt"
        SaveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        SaveFileDialog1.Title = " "
        ' 
        ' txtNotepad
        ' 
        txtNotepad.AcceptsReturn = True
        txtNotepad.AcceptsTab = True
        txtNotepad.AllowDrop = True
        txtNotepad.Dock = DockStyle.Fill
        txtNotepad.Location = New Point(0, 28)
        txtNotepad.Multiline = True
        txtNotepad.Name = "txtNotepad"
        txtNotepad.ScrollBars = ScrollBars.Both
        txtNotepad.Size = New Size(800, 392)
        txtNotepad.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNotepad)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        Name = "Form1"
        Text = "NotepadKu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents AboutNotepadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents txtNotepad As TextBox

End Class
