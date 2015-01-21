<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblStandard = New System.Windows.Forms.Label()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.cmbxListItems = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.rtbInput = New System.Windows.Forms.RichTextBox()
        Me.lblRichText = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 419)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblSelection)
        Me.TabPage1.Controls.Add(Me.txtInput)
        Me.TabPage1.Controls.Add(Me.lblStandard)
        Me.TabPage1.Controls.Add(Me.lblSelectItem)
        Me.TabPage1.Controls.Add(Me.cmbxListItems)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TextBox & ComboBox"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(41, 118)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(346, 86)
        Me.txtInput.TabIndex = 3
        Me.txtInput.Text = "This is my textbox. It has multiple lines and"
        '
        'lblStandard
        '
        Me.lblStandard.AutoSize = True
        Me.lblStandard.Location = New System.Drawing.Point(38, 102)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(91, 13)
        Me.lblStandard.TabIndex = 2
        Me.lblStandard.Text = "Standard Textbox"
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Location = New System.Drawing.Point(38, 33)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(75, 13)
        Me.lblSelectItem.TabIndex = 1
        Me.lblSelectItem.Text = "Select an Item"
        '
        'cmbxListItems
        '
        Me.cmbxListItems.FormattingEnabled = True
        Me.cmbxListItems.Location = New System.Drawing.Point(41, 49)
        Me.cmbxListItems.Name = "cmbxListItems"
        Me.cmbxListItems.Size = New System.Drawing.Size(339, 21)
        Me.cmbxListItems.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblRichText)
        Me.TabPage2.Controls.Add(Me.rtbInput)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(594, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rich TextBox"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(594, 393)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Web Browser"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(594, 393)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Edit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(41, 244)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(22, 13)
        Me.lblSelection.TabIndex = 4
        Me.lblSelection.Text = "     "
        '
        'rtbInput
        '
        Me.rtbInput.Location = New System.Drawing.Point(20, 38)
        Me.rtbInput.Name = "rtbInput"
        Me.rtbInput.Size = New System.Drawing.Size(565, 345)
        Me.rtbInput.TabIndex = 0
        Me.rtbInput.Text = "This will hold .rtf files."
        '
        'lblRichText
        '
        Me.lblRichText.AutoSize = True
        Me.lblRichText.Location = New System.Drawing.Point(17, 12)
        Me.lblRichText.Name = "lblRichText"
        Me.lblRichText.Size = New System.Drawing.Size(117, 13)
        Me.lblRichText.TabIndex = 1
        Me.lblRichText.Text = "Type in text for rich text"
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 419)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm1"
        Me.Text = "Lab: Text Handling"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblStandard As System.Windows.Forms.Label
    Friend WithEvents lblSelectItem As System.Windows.Forms.Label
    Friend WithEvents cmbxListItems As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lblSelection As System.Windows.Forms.Label
    Friend WithEvents lblRichText As System.Windows.Forms.Label
    Friend WithEvents rtbInput As System.Windows.Forms.RichTextBox

End Class
