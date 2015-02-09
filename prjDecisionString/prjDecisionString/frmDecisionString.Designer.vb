<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecisionString
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
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.radioFast = New System.Windows.Forms.RadioButton()
        Me.radioFaster = New System.Windows.Forms.RadioButton()
        Me.radioFastest = New System.Windows.Forms.RadioButton()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.grpHours = New System.Windows.Forms.GroupBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.grpNonProfit = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPackage.SuspendLayout()
        Me.grpHours.SuspendLayout()
        Me.grpNonProfit.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'numHours
        '
        Me.numHours.Location = New System.Drawing.Point(81, 39)
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(50, 20)
        Me.numHours.TabIndex = 0
        Me.numHours.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'radioFast
        '
        Me.radioFast.AutoSize = True
        Me.radioFast.Location = New System.Drawing.Point(20, 19)
        Me.radioFast.Name = "radioFast"
        Me.radioFast.Size = New System.Drawing.Size(45, 17)
        Me.radioFast.TabIndex = 1
        Me.radioFast.TabStop = True
        Me.radioFast.Text = "Fast"
        Me.radioFast.UseVisualStyleBackColor = True
        '
        'radioFaster
        '
        Me.radioFaster.AutoSize = True
        Me.radioFaster.Location = New System.Drawing.Point(20, 42)
        Me.radioFaster.Name = "radioFaster"
        Me.radioFaster.Size = New System.Drawing.Size(54, 17)
        Me.radioFaster.TabIndex = 2
        Me.radioFaster.TabStop = True
        Me.radioFaster.Text = "Faster"
        Me.radioFaster.UseVisualStyleBackColor = True
        '
        'radioFastest
        '
        Me.radioFastest.AutoSize = True
        Me.radioFastest.Location = New System.Drawing.Point(20, 65)
        Me.radioFastest.Name = "radioFastest"
        Me.radioFastest.Size = New System.Drawing.Size(59, 17)
        Me.radioFastest.TabIndex = 3
        Me.radioFastest.TabStop = True
        Me.radioFastest.Text = "Fastest"
        Me.radioFastest.UseVisualStyleBackColor = True
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.radioFast)
        Me.grpPackage.Controls.Add(Me.radioFastest)
        Me.grpPackage.Controls.Add(Me.radioFaster)
        Me.grpPackage.Location = New System.Drawing.Point(12, 26)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(133, 93)
        Me.grpPackage.TabIndex = 4
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Package"
        '
        'grpHours
        '
        Me.grpHours.Controls.Add(Me.lblHours)
        Me.grpHours.Controls.Add(Me.numHours)
        Me.grpHours.Location = New System.Drawing.Point(151, 26)
        Me.grpHours.Name = "grpHours"
        Me.grpHours.Size = New System.Drawing.Size(139, 93)
        Me.grpHours.TabIndex = 5
        Me.grpHours.TabStop = False
        Me.grpHours.Text = "Hours"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(6, 41)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(69, 13)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "Hours Used: "
        '
        'grpNonProfit
        '
        Me.grpNonProfit.Controls.Add(Me.CheckBox1)
        Me.grpNonProfit.Controls.Add(Me.Label1)
        Me.grpNonProfit.Location = New System.Drawing.Point(296, 26)
        Me.grpNonProfit.Name = "grpNonProfit"
        Me.grpNonProfit.Size = New System.Drawing.Size(181, 93)
        Me.grpNonProfit.TabIndex = 6
        Me.grpNonProfit.TabStop = False
        Me.grpNonProfit.Text = "Non-Profit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Non-Profit Organization? "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(137, 43)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Yes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.TextBox1)
        Me.grpInfo.Controls.Add(Me.lblPhone)
        Me.grpInfo.Controls.Add(Me.lblLastName)
        Me.grpInfo.Controls.Add(Me.lblFirstName)
        Me.grpInfo.Controls.Add(Me.txtLastName)
        Me.grpInfo.Controls.Add(Me.txtFirstName)
        Me.grpInfo.Location = New System.Drawing.Point(12, 134)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(246, 105)
        Me.grpInfo.TabIndex = 7
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Customer Information"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(75, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(139, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(75, 49)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(139, 20)
        Me.txtLastName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(6, 26)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(63, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(5, 52)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name: "
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(24, 78)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 20)
        Me.TextBox1.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(305, 142)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 49)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmDecisionString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 253)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpNonProfit)
        Me.Controls.Add(Me.grpHours)
        Me.Controls.Add(Me.grpPackage)
        Me.Name = "frmDecisionString"
        Me.Text = "ISP Price Calculator"
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.grpHours.ResumeLayout(False)
        Me.grpHours.PerformLayout()
        Me.grpNonProfit.ResumeLayout(False)
        Me.grpNonProfit.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents numHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents radioFast As System.Windows.Forms.RadioButton
    Friend WithEvents radioFaster As System.Windows.Forms.RadioButton
    Friend WithEvents radioFastest As System.Windows.Forms.RadioButton
    Friend WithEvents grpPackage As System.Windows.Forms.GroupBox
    Friend WithEvents grpHours As System.Windows.Forms.GroupBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents grpNonProfit As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
