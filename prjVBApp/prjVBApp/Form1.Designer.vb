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
        Me.lblPartPicture = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPartNo = New System.Windows.Forms.Label()
        Me.txtPartNo = New System.Windows.Forms.TextBox()
        Me.tabInst = New System.Windows.Forms.TabPage()
        Me.tabComments = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabControl1.SuspendLayout()
        Me.tabPart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInst.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(903, 495)
        Me.TabControl1.TabIndex = 0
        '
        'tabPart
        '
        Me.tabPart.Controls.Add(Me.lblPartPicture)
        Me.tabPart.Controls.Add(Me.RichTextBox1)
        Me.tabPart.Controls.Add(Me.lblDesc)
        Me.tabPart.Controls.Add(Me.PictureBox1)
        Me.tabPart.Controls.Add(Me.lblPartNo)
        Me.tabPart.Controls.Add(Me.txtPartNo)
        Me.tabPart.Location = New System.Drawing.Point(4, 22)
        Me.tabPart.Name = "tabPart"
        Me.tabPart.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPart.Size = New System.Drawing.Size(895, 469)
        Me.tabPart.TabIndex = 0
        Me.tabPart.Text = "Part"
        Me.tabPart.UseVisualStyleBackColor = True
        '
        'lblPartPicture
        '
        Me.lblPartPicture.AutoSize = True
        Me.lblPartPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartPicture.Location = New System.Drawing.Point(115, 71)
        Me.lblPartPicture.Name = "lblPartPicture"
        Me.lblPartPicture.Size = New System.Drawing.Size(158, 20)
        Me.lblPartPicture.TabIndex = 5
        Me.lblPartPicture.Text = "Part ##### Picture"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(455, 94)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(414, 336)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(571, 71)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(193, 20)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "Part ##### Description"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 336)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblPartNo
        '
        Me.lblPartNo.AutoSize = True
        Me.lblPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNo.Location = New System.Drawing.Point(28, 26)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(123, 20)
        Me.lblPartNo.TabIndex = 1
        Me.lblPartNo.Text = "Enter Part No."
        '
        'txtPartNo
        '
        Me.txtPartNo.Location = New System.Drawing.Point(157, 28)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.Size = New System.Drawing.Size(116, 20)
        Me.txtPartNo.TabIndex = 0
        '
        'tabInst
        '
        Me.tabInst.Controls.Add(Me.WebBrowser1)
        Me.tabInst.Location = New System.Drawing.Point(4, 22)
        Me.tabInst.Name = "tabInst"
        Me.tabInst.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInst.Size = New System.Drawing.Size(895, 469)
        Me.tabInst.TabIndex = 1
        Me.tabInst.Text = "Instructions"
        Me.tabInst.UseVisualStyleBackColor = True
        '
        'tabComments
        '
        Me.tabComments.Location = New System.Drawing.Point(4, 22)
        Me.tabComments.Name = "tabComments"
        Me.tabComments.Size = New System.Drawing.Size(895, 469)
        Me.tabComments.TabIndex = 2
        Me.tabComments.Text = "Comments"
        Me.tabComments.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(-4, 47)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(899, 422)
        Me.WebBrowser1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Part Painter"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPart.ResumeLayout(False)
        Me.tabPart.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInst.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPart As System.Windows.Forms.TabPage
    Friend WithEvents tabInst As System.Windows.Forms.TabPage
    Friend WithEvents tabComments As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPartNo As System.Windows.Forms.Label
    Friend WithEvents txtPartNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPartPicture As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
