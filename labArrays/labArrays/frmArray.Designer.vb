<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArray
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
        Me.btnShowSingle = New System.Windows.Forms.Button()
        Me.btnShow2D = New System.Windows.Forms.Button()
        Me.chkSort = New System.Windows.Forms.CheckBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowSingle
        '
        Me.btnShowSingle.Location = New System.Drawing.Point(34, 34)
        Me.btnShowSingle.Name = "btnShowSingle"
        Me.btnShowSingle.Size = New System.Drawing.Size(132, 43)
        Me.btnShowSingle.TabIndex = 0
        Me.btnShowSingle.Text = "Show Single Array"
        Me.btnShowSingle.UseVisualStyleBackColor = True
        '
        'btnShow2D
        '
        Me.btnShow2D.Location = New System.Drawing.Point(184, 34)
        Me.btnShow2D.Name = "btnShow2D"
        Me.btnShow2D.Size = New System.Drawing.Size(126, 43)
        Me.btnShow2D.TabIndex = 1
        Me.btnShow2D.Text = "Show 2D Array"
        Me.btnShow2D.UseVisualStyleBackColor = True
        '
        'chkSort
        '
        Me.chkSort.AutoSize = True
        Me.chkSort.Location = New System.Drawing.Point(94, 115)
        Me.chkSort.Name = "chkSort"
        Me.chkSort.Size = New System.Drawing.Size(81, 17)
        Me.chkSort.TabIndex = 2
        Me.chkSort.Text = "CheckBox1"
        Me.chkSort.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(331, 34)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(299, 334)
        Me.txtResult.TabIndex = 3
        '
        'frmArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 375)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.chkSort)
        Me.Controls.Add(Me.btnShow2D)
        Me.Controls.Add(Me.btnShowSingle)
        Me.Name = "frmArray"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowSingle As System.Windows.Forms.Button
    Friend WithEvents btnShow2D As System.Windows.Forms.Button
    Friend WithEvents chkSort As System.Windows.Forms.CheckBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
