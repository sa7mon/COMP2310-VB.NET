﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.radioFast = New System.Windows.Forms.RadioButton()
        Me.radioFaster = New System.Windows.Forms.RadioButton()
        Me.radioFastest = New System.Windows.Forms.RadioButton()
        Me.grpPackage = New System.Windows.Forms.GroupBox()
        Me.grpHours = New System.Windows.Forms.GroupBox()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.grpNonProfit = New System.Windows.Forms.GroupBox()
        Me.cbNonProfit = New System.Windows.Forms.CheckBox()
        Me.lblNonProfit = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpPackage.SuspendLayout()
        Me.grpHours.SuspendLayout()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNonProfit.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'radioFast
        '
        Me.radioFast.AutoSize = True
        Me.radioFast.Checked = True
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
        Me.radioFastest.Text = "Fastest"
        Me.radioFastest.UseVisualStyleBackColor = True
        '
        'grpPackage
        '
        Me.grpPackage.Controls.Add(Me.radioFast)
        Me.grpPackage.Controls.Add(Me.radioFastest)
        Me.grpPackage.Controls.Add(Me.radioFaster)
        Me.grpPackage.Location = New System.Drawing.Point(12, 11)
        Me.grpPackage.Name = "grpPackage"
        Me.grpPackage.Size = New System.Drawing.Size(133, 93)
        Me.grpPackage.TabIndex = 4
        Me.grpPackage.TabStop = False
        Me.grpPackage.Text = "Package"
        '
        'grpHours
        '
        Me.grpHours.Controls.Add(Me.numHours)
        Me.grpHours.Controls.Add(Me.lblHours)
        Me.grpHours.Location = New System.Drawing.Point(151, 11)
        Me.grpHours.Name = "grpHours"
        Me.grpHours.Size = New System.Drawing.Size(139, 93)
        Me.grpHours.TabIndex = 5
        Me.grpHours.TabStop = False
        Me.grpHours.Text = "Hours"
        '
        'numHours
        '
        Me.numHours.Location = New System.Drawing.Point(70, 39)
        Me.numHours.Maximum = New Decimal(New Integer() {744, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(63, 20)
        Me.numHours.TabIndex = 2
        Me.numHours.Value = New Decimal(New Integer() {50, 0, 0, 0})
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
        Me.grpNonProfit.Controls.Add(Me.cbNonProfit)
        Me.grpNonProfit.Controls.Add(Me.lblNonProfit)
        Me.grpNonProfit.Location = New System.Drawing.Point(296, 11)
        Me.grpNonProfit.Name = "grpNonProfit"
        Me.grpNonProfit.Size = New System.Drawing.Size(186, 93)
        Me.grpNonProfit.TabIndex = 6
        Me.grpNonProfit.TabStop = False
        Me.grpNonProfit.Text = "Non-Profit"
        '
        'cbNonProfit
        '
        Me.cbNonProfit.AutoSize = True
        Me.cbNonProfit.Checked = True
        Me.cbNonProfit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNonProfit.Location = New System.Drawing.Point(137, 43)
        Me.cbNonProfit.Name = "cbNonProfit"
        Me.cbNonProfit.Size = New System.Drawing.Size(44, 17)
        Me.cbNonProfit.TabIndex = 1
        Me.cbNonProfit.Text = "Yes"
        Me.cbNonProfit.UseVisualStyleBackColor = True
        '
        'lblNonProfit
        '
        Me.lblNonProfit.AutoSize = True
        Me.lblNonProfit.Location = New System.Drawing.Point(6, 45)
        Me.lblNonProfit.Name = "lblNonProfit"
        Me.lblNonProfit.Size = New System.Drawing.Size(125, 13)
        Me.lblNonProfit.TabIndex = 0
        Me.lblNonProfit.Text = "Non-Profit Organization? "
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtPhone)
        Me.grpInfo.Controls.Add(Me.lblPhone)
        Me.grpInfo.Controls.Add(Me.lblLastName)
        Me.grpInfo.Controls.Add(Me.lblFirstName)
        Me.grpInfo.Controls.Add(Me.txtLastName)
        Me.grpInfo.Controls.Add(Me.txtFirstName)
        Me.grpInfo.Location = New System.Drawing.Point(12, 119)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(278, 105)
        Me.grpInfo.TabIndex = 7
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Customer Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(75, 75)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(93, 20)
        Me.txtPhone.TabIndex = 5
        Me.txtPhone.Text = "123-456-7890"
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
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(5, 52)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name: "
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
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(75, 49)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(139, 20)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = "Dole"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(75, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(139, 20)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Text = "Bob"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(296, 127)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(186, 49)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmDecisionString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 235)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpNonProfit)
        Me.Controls.Add(Me.grpHours)
        Me.Controls.Add(Me.grpPackage)
        Me.Name = "frmDecisionString"
        Me.Text = "ISP Price Calculator"
        Me.grpPackage.ResumeLayout(False)
        Me.grpPackage.PerformLayout()
        Me.grpHours.ResumeLayout(False)
        Me.grpHours.PerformLayout()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNonProfit.ResumeLayout(False)
        Me.grpNonProfit.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radioFast As System.Windows.Forms.RadioButton
    Friend WithEvents radioFaster As System.Windows.Forms.RadioButton
    Friend WithEvents radioFastest As System.Windows.Forms.RadioButton
    Friend WithEvents grpPackage As System.Windows.Forms.GroupBox
    Friend WithEvents grpHours As System.Windows.Forms.GroupBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents grpNonProfit As System.Windows.Forms.GroupBox
    Friend WithEvents cbNonProfit As System.Windows.Forms.CheckBox
    Friend WithEvents lblNonProfit As System.Windows.Forms.Label
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents numHours As System.Windows.Forms.NumericUpDown

End Class
