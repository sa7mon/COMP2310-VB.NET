<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPart = New System.Windows.Forms.TabPage()
        Me.tabInst = New System.Windows.Forms.TabPage()
        Me.tabComments = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPart)
        Me.TabControl1.Controls.Add(Me.tabInst)
        Me.TabControl1.Controls.Add(Me.tabComments)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 532)
        Me.TabControl1.TabIndex = 0
        '
        'tabPart
        '
        Me.tabPart.Location = New System.Drawing.Point(4, 22)
        Me.tabPart.Name = "tabPart"
        Me.tabPart.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPart.Size = New System.Drawing.Size(733, 506)
        Me.tabPart.TabIndex = 0
        Me.tabPart.Text = "Part"
        Me.tabPart.UseVisualStyleBackColor = True
        '
        'tabInst
        '
        Me.tabInst.Location = New System.Drawing.Point(4, 22)
        Me.tabInst.Name = "tabInst"
        Me.tabInst.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInst.Size = New System.Drawing.Size(601, 321)
        Me.tabInst.TabIndex = 1
        Me.tabInst.Text = "Instructions"
        Me.tabInst.UseVisualStyleBackColor = True
        '
        'tabComments
        '
        Me.tabComments.Location = New System.Drawing.Point(4, 22)
        Me.tabComments.Name = "tabComments"
        Me.tabComments.Size = New System.Drawing.Size(601, 321)
        Me.tabComments.TabIndex = 2
        Me.tabComments.Text = "Comments"
        Me.tabComments.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Part Painter"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPart As System.Windows.Forms.TabPage
    Friend WithEvents tabInst As System.Windows.Forms.TabPage
    Friend WithEvents tabComments As System.Windows.Forms.TabPage

End Class
