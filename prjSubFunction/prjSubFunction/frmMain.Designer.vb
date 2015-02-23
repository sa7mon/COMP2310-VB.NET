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
        Me.btnXMLFunction = New System.Windows.Forms.Button()
        Me.btnByvalByref = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnXMLFunction
        '
        Me.btnXMLFunction.Location = New System.Drawing.Point(12, 17)
        Me.btnXMLFunction.Name = "btnXMLFunction"
        Me.btnXMLFunction.Size = New System.Drawing.Size(251, 45)
        Me.btnXMLFunction.TabIndex = 0
        Me.btnXMLFunction.Text = "Open XML / Function"
        Me.btnXMLFunction.UseVisualStyleBackColor = True
        '
        'btnByvalByref
        '
        Me.btnByvalByref.Location = New System.Drawing.Point(12, 89)
        Me.btnByvalByref.Name = "btnByvalByref"
        Me.btnByvalByref.Size = New System.Drawing.Size(251, 45)
        Me.btnByvalByref.TabIndex = 1
        Me.btnByvalByref.Text = "Open ByRef / ByVal"
        Me.btnByvalByref.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(251, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Open Using a Module"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 220)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnByvalByref)
        Me.Controls.Add(Me.btnXMLFunction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnXMLFunction As System.Windows.Forms.Button
    Friend WithEvents btnByvalByref As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
