﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Me.dsRecords = New System.Data.DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gridRecords = New System.Windows.Forms.DataGridView()
        Me.btnDashConcat = New System.Windows.Forms.Button()
        CType(Me.dsRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsRecords
        '
        Me.dsRecords.DataSetName = "NewDataSet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Read XML"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gridRecords
        '
        Me.gridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRecords.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridRecords.Location = New System.Drawing.Point(0, 186)
        Me.gridRecords.Name = "gridRecords"
        Me.gridRecords.Size = New System.Drawing.Size(688, 160)
        Me.gridRecords.TabIndex = 1
        '
        'btnDashConcat
        '
        Me.btnDashConcat.Location = New System.Drawing.Point(72, 55)
        Me.btnDashConcat.Name = "btnDashConcat"
        Me.btnDashConcat.Size = New System.Drawing.Size(107, 44)
        Me.btnDashConcat.TabIndex = 2
        Me.btnDashConcat.Text = "Concatenate"
        Me.btnDashConcat.UseVisualStyleBackColor = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 346)
        Me.Controls.Add(Me.btnDashConcat)
        Me.Controls.Add(Me.gridRecords)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmCollection"
        Me.Text = "Collection"
        CType(Me.dsRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsRecords As System.Data.DataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gridRecords As System.Windows.Forms.DataGridView
    Friend WithEvents btnDashConcat As System.Windows.Forms.Button

End Class
