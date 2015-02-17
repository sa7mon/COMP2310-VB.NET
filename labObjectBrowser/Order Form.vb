Public Class OrderForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBoard As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblTotalPricelbl As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtYellow As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents PhonePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblSkateboard As System.Windows.Forms.Label
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblYellow As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.lblTotalBoard = New System.Windows.Forms.Label
        Me.btnDone = New System.Windows.Forms.Button
        Me.lblTotalPricelbl = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtYellow = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.PhonePictureBox = New System.Windows.Forms.PictureBox
        Me.lblSkateboard = New System.Windows.Forms.Label
        Me.txtBlue = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblYellow = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblZip = New System.Windows.Forms.Label
        Me.lblBlue = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblMessage = New System.Windows.Forms.Label
        CType(Me.PhonePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(24, 88)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(59, 16)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "&Address:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(158, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(221, 19)
        Me.lblHeading.TabIndex = 21
        Me.lblHeading.Text = "Skate-Away Sales Order Form"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(414, 64)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(80, 23)
        Me.txtPrice.TabIndex = 15
        Me.txtPrice.Text = "200"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(208, 136)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(56, 23)
        Me.txtZip.TabIndex = 9
        Me.txtZip.Text = "12345-6789"
        '
        'lblTotalBoard
        '
        Me.lblTotalBoard.AutoSize = True
        Me.lblTotalBoard.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBoard.Location = New System.Drawing.Point(296, 128)
        Me.lblTotalBoard.Name = "lblTotalBoard"
        Me.lblTotalBoard.Size = New System.Drawing.Size(115, 16)
        Me.lblTotalBoard.TabIndex = 22
        Me.lblTotalBoard.Text = "Total skateboards:"
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(325, 256)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(120, 23)
        Me.btnDone.TabIndex = 20
        Me.btnDone.Text = "&Done"
        '
        'lblTotalPricelbl
        '
        Me.lblTotalPricelbl.AutoSize = True
        Me.lblTotalPricelbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPricelbl.Location = New System.Drawing.Point(296, 159)
        Me.lblTotalPricelbl.Name = "lblTotalPricelbl"
        Me.lblTotalPricelbl.Size = New System.Drawing.Size(74, 16)
        Me.lblTotalPricelbl.TabIndex = 23
        Me.lblTotalPricelbl.Text = "Total price:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(72, 256)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 23)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "&Calculate Order"
        '
        'txtYellow
        '
        Me.txtYellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtYellow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYellow.Location = New System.Drawing.Point(208, 200)
        Me.txtYellow.Name = "txtYellow"
        Me.txtYellow.Size = New System.Drawing.Size(56, 23)
        Me.txtYellow.TabIndex = 13
        Me.txtYellow.Text = "5"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(83, 136)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(54, 23)
        Me.txtState.TabIndex = 7
        Me.txtState.Text = "AZ"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(414, 88)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(80, 23)
        Me.txtTax.TabIndex = 17
        Me.txtTax.Text = ".05"
        '
        'PhonePictureBox
        '
        Me.PhonePictureBox.Image = CType(resources.GetObject("PhonePictureBox.Image"), System.Drawing.Image)
        Me.PhonePictureBox.Location = New System.Drawing.Point(86, 21)
        Me.PhonePictureBox.Name = "PhonePictureBox"
        Me.PhonePictureBox.Size = New System.Drawing.Size(34, 35)
        Me.PhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhonePictureBox.TabIndex = 0
        Me.PhonePictureBox.TabStop = False
        '
        'lblSkateboard
        '
        Me.lblSkateboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSkateboard.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkateboard.Location = New System.Drawing.Point(416, 128)
        Me.lblSkateboard.Name = "lblSkateboard"
        Me.lblSkateboard.Size = New System.Drawing.Size(80, 23)
        Me.lblSkateboard.TabIndex = 24
        '
        'txtBlue
        '
        Me.txtBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBlue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(208, 176)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(56, 23)
        Me.txtBlue.TabIndex = 11
        Me.txtBlue.Text = "20"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(83, 88)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(182, 23)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "1234 TestAddress"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(416, 159)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(80, 23)
        Me.lblTotalPrice.TabIndex = 25
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(296, 88)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(92, 16)
        Me.lblTax.TabIndex = 16
        Me.lblTax.Text = "Sales tax &rate:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(83, 64)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "TestName"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(296, 64)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(110, 16)
        Me.lblPrice.TabIndex = 14
        Me.lblPrice.Text = "Skateboard pr&ice:"
        '
        'lblYellow
        '
        Me.lblYellow.AutoSize = True
        Me.lblYellow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYellow.Location = New System.Drawing.Point(24, 200)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(172, 16)
        Me.lblYellow.TabIndex = 12
        Me.lblYellow.Text = "&Yellow skateboards ordered:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(199, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "C&lear Screen"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(24, 112)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(34, 16)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "Ci&ty:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(24, 136)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(43, 16)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "&State:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(176, 136)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(31, 16)
        Me.lblZip.TabIndex = 8
        Me.lblZip.Text = "&ZIP:"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(24, 176)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(159, 16)
        Me.lblBlue.TabIndex = 10
        Me.lblBlue.Text = "&Blue skateboards ordered:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(24, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(83, 112)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(182, 23)
        Me.txtCity.TabIndex = 5
        Me.txtCity.Text = "citytesting"
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(296, 192)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(200, 48)
        Me.lblMessage.TabIndex = 26
        Me.lblMessage.Text = "MessageLabel"
        '
        'OrderForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(520, 301)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblSkateboard)
        Me.Controls.Add(Me.lblTotalPricelbl)
        Me.Controls.Add(Me.lblTotalBoard)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYellow)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtYellow)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PhonePictureBox)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skate-Away Sales"
        CType(Me.PhonePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'prepare screen for next order
        Me.txtName.Text = ""
        Me.txtAddress.Text = ""
        Me.txtCity.Text = ""
        Me.txtZip.Text = ""
        Me.txtBlue.Text = ""
        Me.txtYellow.Text = ""
        Me.txtState.Text = "IL"
        Me.lblSkateboard.Text = ""
        Me.lblTotalPrice.Text = ""
        Me.lblMessage.Text = ""
        'send focus to the Name text box
        Me.txtName.Focus()

    End Sub

    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'calculate total number of skateboards and total price
        Me.lblSkateboard.Text = Val(Me.txtBlue.Text) + Val(Me.txtYellow.Text)
        Me.lblTotalPrice.Text = Val(Me.lblSkateboard.Text) * Val(Me.txtPrice.Text) _
            * (1 + Val(Me.txtTax.Text))
        Me.lblTotalPrice.Text = Format(Me.lblTotalPrice.Text, "currency")
        'send the focus to the Clear Screen button
        Me.btnClear.Focus()

    End Sub

    Private Sub txtBlue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBlue.TextChanged
        Me.lblSkateboard.Text = ""
        Me.lblTotalPrice.Text = ""
        Me.lblMessage.Text = ""
    End Sub
End Class
