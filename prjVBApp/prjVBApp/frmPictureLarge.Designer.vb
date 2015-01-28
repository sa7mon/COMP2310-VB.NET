<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPictureLarge
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
        Me.picboxViewer = New System.Windows.Forms.PictureBox()
        CType(Me.picboxViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxViewer
        '
        Me.picboxViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picboxViewer.Location = New System.Drawing.Point(0, 0)
        Me.picboxViewer.Name = "picboxViewer"
        Me.picboxViewer.Size = New System.Drawing.Size(679, 453)
        Me.picboxViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxViewer.TabIndex = 0
        Me.picboxViewer.TabStop = False
        '
        'frmPictureLarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 453)
        Me.Controls.Add(Me.picboxViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPictureLarge"
        Me.Text = "Picture Viewer"
        CType(Me.picboxViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picboxViewer As System.Windows.Forms.PictureBox
End Class
