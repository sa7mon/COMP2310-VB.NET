<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowISBN
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
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblValidLabel = New System.Windows.Forms.Label()
        Me.lblIndustryLabel = New System.Windows.Forms.Label()
        Me.lblGroupLanguageLabel = New System.Windows.Forms.Label()
        Me.lblPublisherLabel = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblTitleLabel = New System.Windows.Forms.Label()
        Me.lblValid = New System.Windows.Forms.Label()
        Me.lblIndustry = New System.Windows.Forms.Label()
        Me.lblGroupLanguage = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(12, 27)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(147, 13)
        Me.lblISBN.TabIndex = 0
        Me.lblISBN.Text = "Type in an ISBN Number"
        '
        'lblValidLabel
        '
        Me.lblValidLabel.AutoSize = True
        Me.lblValidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidLabel.Location = New System.Drawing.Point(12, 58)
        Me.lblValidLabel.Name = "lblValidLabel"
        Me.lblValidLabel.Size = New System.Drawing.Size(56, 13)
        Me.lblValidLabel.TabIndex = 1
        Me.lblValidLabel.Text = "Is Valid?"
        '
        'lblIndustryLabel
        '
        Me.lblIndustryLabel.AutoSize = True
        Me.lblIndustryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndustryLabel.Location = New System.Drawing.Point(12, 92)
        Me.lblIndustryLabel.Name = "lblIndustryLabel"
        Me.lblIndustryLabel.Size = New System.Drawing.Size(89, 13)
        Me.lblIndustryLabel.TabIndex = 2
        Me.lblIndustryLabel.Text = "Industry (EAN)"
        '
        'lblGroupLanguageLabel
        '
        Me.lblGroupLanguageLabel.AutoSize = True
        Me.lblGroupLanguageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupLanguageLabel.Location = New System.Drawing.Point(12, 123)
        Me.lblGroupLanguageLabel.Name = "lblGroupLanguageLabel"
        Me.lblGroupLanguageLabel.Size = New System.Drawing.Size(103, 13)
        Me.lblGroupLanguageLabel.TabIndex = 3
        Me.lblGroupLanguageLabel.Text = "Group/Language"
        '
        'lblPublisherLabel
        '
        Me.lblPublisherLabel.AutoSize = True
        Me.lblPublisherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisherLabel.Location = New System.Drawing.Point(12, 158)
        Me.lblPublisherLabel.Name = "lblPublisherLabel"
        Me.lblPublisherLabel.Size = New System.Drawing.Size(59, 13)
        Me.lblPublisherLabel.TabIndex = 4
        Me.lblPublisherLabel.Text = "Publisher"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(165, 24)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(162, 20)
        Me.txtISBN.TabIndex = 5
        '
        'lblTitleLabel
        '
        Me.lblTitleLabel.AutoSize = True
        Me.lblTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLabel.Location = New System.Drawing.Point(12, 190)
        Me.lblTitleLabel.Name = "lblTitleLabel"
        Me.lblTitleLabel.Size = New System.Drawing.Size(32, 13)
        Me.lblTitleLabel.TabIndex = 6
        Me.lblTitleLabel.Text = "Title"
        '
        'lblValid
        '
        Me.lblValid.AutoSize = True
        Me.lblValid.Location = New System.Drawing.Point(162, 58)
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Size = New System.Drawing.Size(37, 13)
        Me.lblValid.TabIndex = 8
        Me.lblValid.Text = "          "
        '
        'lblIndustry
        '
        Me.lblIndustry.AutoSize = True
        Me.lblIndustry.Location = New System.Drawing.Point(162, 92)
        Me.lblIndustry.Name = "lblIndustry"
        Me.lblIndustry.Size = New System.Drawing.Size(40, 13)
        Me.lblIndustry.TabIndex = 9
        Me.lblIndustry.Text = "           "
        '
        'lblGroupLanguage
        '
        Me.lblGroupLanguage.AutoSize = True
        Me.lblGroupLanguage.Location = New System.Drawing.Point(162, 123)
        Me.lblGroupLanguage.Name = "lblGroupLanguage"
        Me.lblGroupLanguage.Size = New System.Drawing.Size(31, 13)
        Me.lblGroupLanguage.TabIndex = 10
        Me.lblGroupLanguage.Text = "        "
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(162, 158)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(43, 13)
        Me.lblPublisher.TabIndex = 11
        Me.lblPublisher.Text = "            "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(162, 190)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(49, 13)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "              "
        '
        'frmShowISBN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 272)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblGroupLanguage)
        Me.Controls.Add(Me.lblIndustry)
        Me.Controls.Add(Me.lblValid)
        Me.Controls.Add(Me.lblTitleLabel)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.lblPublisherLabel)
        Me.Controls.Add(Me.lblGroupLanguageLabel)
        Me.Controls.Add(Me.lblIndustryLabel)
        Me.Controls.Add(Me.lblValidLabel)
        Me.Controls.Add(Me.lblISBN)
        Me.Name = "frmShowISBN"
        Me.Text = "Show ISBN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents lblValidLabel As System.Windows.Forms.Label
    Friend WithEvents lblIndustryLabel As System.Windows.Forms.Label
    Friend WithEvents lblGroupLanguageLabel As System.Windows.Forms.Label
    Friend WithEvents lblPublisherLabel As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents lblTitleLabel As System.Windows.Forms.Label
    Friend WithEvents lblValid As System.Windows.Forms.Label
    Friend WithEvents lblIndustry As System.Windows.Forms.Label
    Friend WithEvents lblGroupLanguage As System.Windows.Forms.Label
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
