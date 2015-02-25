<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmByrefByval
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
        Me.btnRunSub = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRunSub
        '
        Me.btnRunSub.Location = New System.Drawing.Point(39, 133)
        Me.btnRunSub.Name = "btnRunSub"
        Me.btnRunSub.Size = New System.Drawing.Size(213, 32)
        Me.btnRunSub.TabIndex = 0
        Me.btnRunSub.Text = "Go!"
        Me.btnRunSub.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(12, 12)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(263, 102)
        Me.txtLog.TabIndex = 1
        '
        'txtPara
        '
        Me.txtPara.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtPara.Location = New System.Drawing.Point(12, 196)
        Me.txtPara.Multiline = True
        Me.txtPara.Name = "txtPara"
        Me.txtPara.ReadOnly = True
        Me.txtPara.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPara.Size = New System.Drawing.Size(263, 96)
        Me.txtPara.TabIndex = 2
        '
        'frmByrefByval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 304)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnRunSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmByrefByval"
        Me.Text = "ByRef / ByVal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRunSub As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
End Class
