﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'btnRunSub
        '
        Me.btnRunSub.Location = New System.Drawing.Point(114, 12)
        Me.btnRunSub.Name = "btnRunSub"
        Me.btnRunSub.Size = New System.Drawing.Size(107, 32)
        Me.btnRunSub.TabIndex = 0
        Me.btnRunSub.Text = "Go!"
        Me.btnRunSub.UseVisualStyleBackColor = True
        '
        'frmByrefByval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 260)
        Me.Controls.Add(Me.btnRunSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmByrefByval"
        Me.Text = "ByRef / ByVal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRunSub As System.Windows.Forms.Button
End Class
