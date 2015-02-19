<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParseXML
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
        Me.gridData = New System.Windows.Forms.DataGridView()
        Me.btnReadXML = New System.Windows.Forms.Button()
        Me.btnShowSchema = New System.Windows.Forms.Button()
        Me.txtSchema = New System.Windows.Forms.TextBox()
        Me.datasetAuthors = New System.Data.DataSet()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetAuthors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridData
        '
        Me.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridData.Location = New System.Drawing.Point(12, 132)
        Me.gridData.Name = "gridData"
        Me.gridData.Size = New System.Drawing.Size(876, 309)
        Me.gridData.TabIndex = 0
        '
        'btnReadXML
        '
        Me.btnReadXML.Location = New System.Drawing.Point(498, 33)
        Me.btnReadXML.Name = "btnReadXML"
        Me.btnReadXML.Size = New System.Drawing.Size(100, 41)
        Me.btnReadXML.TabIndex = 1
        Me.btnReadXML.Text = "Read XML"
        Me.btnReadXML.UseVisualStyleBackColor = True
        '
        'btnShowSchema
        '
        Me.btnShowSchema.Location = New System.Drawing.Point(604, 33)
        Me.btnShowSchema.Name = "btnShowSchema"
        Me.btnShowSchema.Size = New System.Drawing.Size(100, 41)
        Me.btnShowSchema.TabIndex = 2
        Me.btnShowSchema.Text = "Show Schema"
        Me.btnShowSchema.UseVisualStyleBackColor = True
        '
        'txtSchema
        '
        Me.txtSchema.Location = New System.Drawing.Point(12, 12)
        Me.txtSchema.Multiline = True
        Me.txtSchema.Name = "txtSchema"
        Me.txtSchema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSchema.Size = New System.Drawing.Size(298, 114)
        Me.txtSchema.TabIndex = 3
        '
        'datasetAuthors
        '
        Me.datasetAuthors.DataSetName = "NewDataSet"
        '
        'frmParseXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 453)
        Me.Controls.Add(Me.txtSchema)
        Me.Controls.Add(Me.btnShowSchema)
        Me.Controls.Add(Me.btnReadXML)
        Me.Controls.Add(Me.gridData)
        Me.Name = "frmParseXML"
        Me.Text = "Parse XML"
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetAuthors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridData As System.Windows.Forms.DataGridView
    Friend WithEvents btnReadXML As System.Windows.Forms.Button
    Friend WithEvents btnShowSchema As System.Windows.Forms.Button
    Friend WithEvents txtSchema As System.Windows.Forms.TextBox
    Friend WithEvents datasetAuthors As System.Data.DataSet

End Class
