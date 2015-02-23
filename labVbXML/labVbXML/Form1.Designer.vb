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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtParagraph = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnXPath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(12, 9)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 0
        Me.lblResults.Text = "Results"
        '
        'txtParagraph
        '
        Me.txtParagraph.Location = New System.Drawing.Point(60, 12)
        Me.txtParagraph.Multiline = True
        Me.txtParagraph.Name = "txtParagraph"
        Me.txtParagraph.Size = New System.Drawing.Size(520, 265)
        Me.txtParagraph.TabIndex = 1
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(590, 23)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(101, 28)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "Use XMLReader"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnXPath
        '
        Me.btnXPath.Location = New System.Drawing.Point(590, 88)
        Me.btnXPath.Name = "btnXPath"
        Me.btnXPath.Size = New System.Drawing.Size(101, 23)
        Me.btnXPath.TabIndex = 3
        Me.btnXPath.Text = "Use XPath"
        Me.btnXPath.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 289)
        Me.Controls.Add(Me.btnXPath)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtParagraph)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "frmMain"
        Me.Text = "Parsing XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents txtParagraph As System.Windows.Forms.TextBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnXPath As System.Windows.Forms.Button

End Class
