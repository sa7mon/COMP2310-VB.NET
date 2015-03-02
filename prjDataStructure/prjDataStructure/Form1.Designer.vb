<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.msItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbVinylInfo = New System.Windows.Forms.GroupBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.txtCollection = New System.Windows.Forms.TextBox()
        Me.ReadListFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu.SuspendLayout()
        Me.gbVinylInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(53, 25)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(100, 20)
        Me.txtAlbum.TabIndex = 0
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(204, 25)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 20)
        Me.txtArtist.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(356, 25)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(53, 20)
        Me.txtYear.TabIndex = 2
        '
        'msMenu
        '
        Me.msMenu.BackColor = System.Drawing.SystemColors.GrayText
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msItemFile})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(632, 24)
        Me.msMenu.TabIndex = 3
        Me.msMenu.Text = "MenuStrip1"
        '
        'msItemFile
        '
        Me.msItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msItemSave, Me.ReadListFromFileToolStripMenuItem, Me.msItemExit})
        Me.msItemFile.Name = "msItemFile"
        Me.msItemFile.Size = New System.Drawing.Size(37, 20)
        Me.msItemFile.Text = "File"
        '
        'msItemSave
        '
        Me.msItemSave.Name = "msItemSave"
        Me.msItemSave.Size = New System.Drawing.Size(171, 22)
        Me.msItemSave.Text = "Save List to File"
        '
        'msItemExit
        '
        Me.msItemExit.Name = "msItemExit"
        Me.msItemExit.Size = New System.Drawing.Size(98, 22)
        Me.msItemExit.Text = "Exit"
        '
        'gbVinylInfo
        '
        Me.gbVinylInfo.Controls.Add(Me.lblYear)
        Me.gbVinylInfo.Controls.Add(Me.lblArtist)
        Me.gbVinylInfo.Controls.Add(Me.lblAlbum)
        Me.gbVinylInfo.Controls.Add(Me.txtAlbum)
        Me.gbVinylInfo.Controls.Add(Me.txtYear)
        Me.gbVinylInfo.Controls.Add(Me.txtArtist)
        Me.gbVinylInfo.Location = New System.Drawing.Point(12, 27)
        Me.gbVinylInfo.Name = "gbVinylInfo"
        Me.gbVinylInfo.Size = New System.Drawing.Size(426, 64)
        Me.gbVinylInfo.TabIndex = 4
        Me.gbVinylInfo.TabStop = False
        Me.gbVinylInfo.Text = "Vinyl"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(318, 28)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(165, 28)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(33, 13)
        Me.lblArtist.TabIndex = 4
        Me.lblArtist.Text = "Artist:"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(8, 28)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(39, 13)
        Me.lblAlbum.TabIndex = 3
        Me.lblAlbum.Text = "Album:"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Location = New System.Drawing.Point(482, 40)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(104, 42)
        Me.btnSaveItem.TabIndex = 5
        Me.btnSaveItem.Text = "Save Vinyl to List"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'txtCollection
        '
        Me.txtCollection.Location = New System.Drawing.Point(12, 106)
        Me.txtCollection.Multiline = True
        Me.txtCollection.Name = "txtCollection"
        Me.txtCollection.Size = New System.Drawing.Size(608, 201)
        Me.txtCollection.TabIndex = 6
        '
        'ReadListFromFileToolStripMenuItem
        '
        Me.ReadListFromFileToolStripMenuItem.Name = "ReadListFromFileToolStripMenuItem"
        Me.ReadListFromFileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReadListFromFileToolStripMenuItem.Text = "Read List from File"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 319)
        Me.Controls.Add(Me.txtCollection)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Controls.Add(Me.gbVinylInfo)
        Me.Controls.Add(Me.msMenu)
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmMain"
        Me.Text = "My Record Collection"
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.gbVinylInfo.ResumeLayout(False)
        Me.gbVinylInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAlbum As System.Windows.Forms.TextBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents msItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbVinylInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents lblAlbum As System.Windows.Forms.Label
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents txtCollection As System.Windows.Forms.TextBox
    Friend WithEvents ReadListFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
