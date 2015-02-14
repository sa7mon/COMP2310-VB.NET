<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Me.lblTotalData = New System.Windows.Forms.Label()
        Me.lblDiscountData = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblSubTotalData = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblAccNumber = New System.Windows.Forms.Label()
        Me.lblAccNumData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotalData
        '
        Me.lblTotalData.AutoSize = True
        Me.lblTotalData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalData.Location = New System.Drawing.Point(131, 90)
        Me.lblTotalData.Name = "lblTotalData"
        Me.lblTotalData.Size = New System.Drawing.Size(53, 20)
        Me.lblTotalData.TabIndex = 20
        Me.lblTotalData.Text = "           "
        '
        'lblDiscountData
        '
        Me.lblDiscountData.AutoSize = True
        Me.lblDiscountData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountData.Location = New System.Drawing.Point(131, 67)
        Me.lblDiscountData.Name = "lblDiscountData"
        Me.lblDiscountData.Size = New System.Drawing.Size(53, 20)
        Me.lblDiscountData.TabIndex = 19
        Me.lblDiscountData.Text = "           "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(73, 90)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 20)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total: "
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(45, 67)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(80, 20)
        Me.lblDiscount.TabIndex = 17
        Me.lblDiscount.Text = "Discount: "
        '
        'lblSubTotalData
        '
        Me.lblSubTotalData.AutoSize = True
        Me.lblSubTotalData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalData.Location = New System.Drawing.Point(131, 43)
        Me.lblSubTotalData.Name = "lblSubTotalData"
        Me.lblSubTotalData.Size = New System.Drawing.Size(49, 20)
        Me.lblSubTotalData.TabIndex = 16
        Me.lblSubTotalData.Text = "          "
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(48, 43)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(77, 20)
        Me.lblSubTotal.TabIndex = 15
        Me.lblSubTotal.Text = "Subtotal: "
        '
        'lblAccNumber
        '
        Me.lblAccNumber.AutoSize = True
        Me.lblAccNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblAccNumber.Name = "lblAccNumber"
        Me.lblAccNumber.Size = New System.Drawing.Size(113, 20)
        Me.lblAccNumber.TabIndex = 21
        Me.lblAccNumber.Text = "Account Num: "
        '
        'lblAccNumData
        '
        Me.lblAccNumData.AutoSize = True
        Me.lblAccNumData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNumData.Location = New System.Drawing.Point(131, 9)
        Me.lblAccNumData.Name = "lblAccNumData"
        Me.lblAccNumData.Size = New System.Drawing.Size(53, 20)
        Me.lblAccNumData.TabIndex = 22
        Me.lblAccNumData.Text = "           "
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 131)
        Me.Controls.Add(Me.lblAccNumData)
        Me.Controls.Add(Me.lblAccNumber)
        Me.Controls.Add(Me.lblTotalData)
        Me.Controls.Add(Me.lblDiscountData)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubTotalData)
        Me.Controls.Add(Me.lblSubTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmResult"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalData As System.Windows.Forms.Label
    Friend WithEvents lblDiscountData As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalData As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblAccNumber As System.Windows.Forms.Label
    Friend WithEvents lblAccNumData As System.Windows.Forms.Label
End Class
