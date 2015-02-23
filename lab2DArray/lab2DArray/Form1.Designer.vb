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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.lblFifth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(99, 114)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(191, 46)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(12, 12)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(39, 13)
        Me.lblFirst.TabIndex = 2
        Me.lblFirst.Text = "Label1"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(84, 12)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(39, 13)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Label2"
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Location = New System.Drawing.Point(165, 12)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(39, 13)
        Me.lblThird.TabIndex = 4
        Me.lblThird.Text = "Label3"
        '
        'lblFourth
        '
        Me.lblFourth.AutoSize = True
        Me.lblFourth.Location = New System.Drawing.Point(251, 12)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(39, 13)
        Me.lblFourth.TabIndex = 5
        Me.lblFourth.Text = "Label4"
        '
        'lblFifth
        '
        Me.lblFifth.AutoSize = True
        Me.lblFifth.Location = New System.Drawing.Point(336, 12)
        Me.lblFifth.Name = "lblFifth"
        Me.lblFifth.Size = New System.Drawing.Size(39, 13)
        Me.lblFifth.TabIndex = 6
        Me.lblFifth.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 201)
        Me.Controls.Add(Me.lblFifth)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblFourth As System.Windows.Forms.Label
    Friend WithEvents lblFifth As System.Windows.Forms.Label

End Class
