<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashMain
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
        Me.pbRecords = New System.Windows.Forms.PictureBox()
        Me.lblMainText = New System.Windows.Forms.Label()
        Me.lblLoadingText = New System.Windows.Forms.Label()
        CType(Me.pbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRecords
        '
        Me.pbRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbRecords.Image = Global.prjDataStructure.My.Resources.Resources.vinyls
        Me.pbRecords.Location = New System.Drawing.Point(0, 0)
        Me.pbRecords.Name = "pbRecords"
        Me.pbRecords.Size = New System.Drawing.Size(644, 267)
        Me.pbRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRecords.TabIndex = 0
        Me.pbRecords.TabStop = False
        '
        'lblMainText
        '
        Me.lblMainText.AutoSize = True
        Me.lblMainText.Font = New System.Drawing.Font("Microsoft New Tai Lue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainText.Location = New System.Drawing.Point(177, 270)
        Me.lblMainText.Name = "lblMainText"
        Me.lblMainText.Size = New System.Drawing.Size(267, 29)
        Me.lblMainText.TabIndex = 1
        Me.lblMainText.Text = "My Record Collection v1.0"
        '
        'lblLoadingText
        '
        Me.lblLoadingText.AutoSize = True
        Me.lblLoadingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingText.Location = New System.Drawing.Point(255, 319)
        Me.lblLoadingText.Name = "lblLoadingText"
        Me.lblLoadingText.Size = New System.Drawing.Size(82, 20)
        Me.lblLoadingText.TabIndex = 2
        Me.lblLoadingText.Text = "Loading...."
        '
        'splashMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoadingText)
        Me.Controls.Add(Me.lblMainText)
        Me.Controls.Add(Me.pbRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splashMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbRecords As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainText As System.Windows.Forms.Label
    Friend WithEvents lblLoadingText As System.Windows.Forms.Label

End Class
