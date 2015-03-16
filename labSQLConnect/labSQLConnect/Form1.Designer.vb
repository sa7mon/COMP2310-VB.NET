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
        Me.dgResult = New System.Windows.Forms.DataGridView()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.lblQuery = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstUser = New System.Windows.Forms.ComboBox()
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgResult
        '
        Me.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResult.Location = New System.Drawing.Point(2, 88)
        Me.dgResult.Name = "dgResult"
        Me.dgResult.Size = New System.Drawing.Size(631, 248)
        Me.dgResult.TabIndex = 0
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(82, 5)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(540, 37)
        Me.txtQuery.TabIndex = 1
        '
        'lblQuery
        '
        Me.lblQuery.AutoSize = True
        Me.lblQuery.Location = New System.Drawing.Point(35, 9)
        Me.lblQuery.Name = "lblQuery"
        Me.lblQuery.Size = New System.Drawing.Size(41, 13)
        Me.lblQuery.TabIndex = 2
        Me.lblQuery.Text = "Query: "
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(207, 48)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(102, 34)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit Query"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstUser
        '
        Me.lstUser.FormattingEnabled = True
        Me.lstUser.Location = New System.Drawing.Point(315, 56)
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(121, 21)
        Me.lstUser.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 337)
        Me.Controls.Add(Me.lstUser)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQuery)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.dgResult)
        Me.Name = "frmMain"
        Me.Text = "Database Code Demo"
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgResult As System.Windows.Forms.DataGridView
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents lblQuery As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lstUser As System.Windows.Forms.ComboBox

End Class
