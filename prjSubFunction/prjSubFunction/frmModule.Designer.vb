<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModule
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblHIghScoreData = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblRandData = New System.Windows.Forms.Label()
        Me.lblIsHigher = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGenerate.Location = New System.Drawing.Point(0, 155)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(255, 41)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(8, 23)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(157, 20)
        Me.lblHighScore.TabIndex = 1
        Me.lblHighScore.Text = "Curent High Score"
        '
        'lblHIghScoreData
        '
        Me.lblHIghScoreData.AutoSize = True
        Me.lblHIghScoreData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHIghScoreData.Location = New System.Drawing.Point(171, 23)
        Me.lblHIghScoreData.Name = "lblHIghScoreData"
        Me.lblHIghScoreData.Size = New System.Drawing.Size(41, 20)
        Me.lblHIghScoreData.TabIndex = 2
        Me.lblHIghScoreData.Text = "        "
        '
        'lblRand
        '
        Me.lblRand.AutoSize = True
        Me.lblRand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRand.Location = New System.Drawing.Point(3, 62)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(162, 20)
        Me.lblRand.TabIndex = 3
        Me.lblRand.Text = "Generated Number"
        '
        'lblRandData
        '
        Me.lblRandData.AutoSize = True
        Me.lblRandData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandData.Location = New System.Drawing.Point(171, 62)
        Me.lblRandData.Name = "lblRandData"
        Me.lblRandData.Size = New System.Drawing.Size(41, 20)
        Me.lblRandData.TabIndex = 4
        Me.lblRandData.Text = "        "
        '
        'lblIsHigher
        '
        Me.lblIsHigher.AutoSize = True
        Me.lblIsHigher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsHigher.Location = New System.Drawing.Point(82, 107)
        Me.lblIsHigher.Name = "lblIsHigher"
        Me.lblIsHigher.Size = New System.Drawing.Size(61, 20)
        Me.lblIsHigher.TabIndex = 5
        Me.lblIsHigher.Text = "             "
        '
        'frmModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 196)
        Me.Controls.Add(Me.lblIsHigher)
        Me.Controls.Add(Me.lblRandData)
        Me.Controls.Add(Me.lblRand)
        Me.Controls.Add(Me.lblHIghScoreData)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "frmModule"
        Me.Text = "Using a Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents lblHIghScoreData As System.Windows.Forms.Label
    Friend WithEvents lblRand As System.Windows.Forms.Label
    Friend WithEvents lblRandData As System.Windows.Forms.Label
    Friend WithEvents lblIsHigher As System.Windows.Forms.Label
End Class
