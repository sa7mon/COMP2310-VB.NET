<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallStackDemo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCallStackDemo))
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtBottom = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTop
        '
        Me.txtTop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop.Location = New System.Drawing.Point(12, 12)
        Me.txtTop.Multiline = True
        Me.txtTop.Name = "txtTop"
        Me.txtTop.ReadOnly = True
        Me.txtTop.Size = New System.Drawing.Size(363, 142)
        Me.txtTop.TabIndex = 0
        Me.txtTop.Text = resources.GetString("txtTop.Text")
        '
        'txtBottom
        '
        Me.txtBottom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBottom.Location = New System.Drawing.Point(12, 217)
        Me.txtBottom.Multiline = True
        Me.txtBottom.Name = "txtBottom"
        Me.txtBottom.ReadOnly = True
        Me.txtBottom.Size = New System.Drawing.Size(363, 249)
        Me.txtBottom.TabIndex = 1
        Me.txtBottom.Text = resources.GetString("txtBottom.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCallStackDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBottom)
        Me.Controls.Add(Me.txtTop)
        Me.Name = "frmCallStackDemo"
        Me.Text = "callStackDemo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    Friend WithEvents txtBottom As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
