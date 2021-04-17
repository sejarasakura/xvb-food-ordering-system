<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethods
    Inherits VisualBasicAssignment.MasterWidgetItem

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FoodTableAdapter1 = New VisualBasicAssignment.FoodShopDataSetTableAdapters.FoodTableAdapter()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbCardNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbExp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbCCV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.radMaster = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radVisa = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FoodTableAdapter1
        '
        Me.FoodTableAdapter1.ClearBeforeFill = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 7
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(754, 449)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(235, 58)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "Complete Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 29)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Card Number:"
        '
        'txbCardNumber
        '
        Me.txbCardNumber.BorderRadius = 5
        Me.txbCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbCardNumber.DefaultText = ""
        Me.txbCardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbCardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbCardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCardNumber.DisabledState.Parent = Me.txbCardNumber
        Me.txbCardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCardNumber.FocusedState.Parent = Me.txbCardNumber
        Me.txbCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCardNumber.HoverState.Parent = Me.txbCardNumber
        Me.txbCardNumber.Location = New System.Drawing.Point(389, 134)
        Me.txbCardNumber.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txbCardNumber.Name = "txbCardNumber"
        Me.txbCardNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCardNumber.PlaceholderText = "(Optional)"
        Me.txbCardNumber.SelectedText = ""
        Me.txbCardNumber.ShadowDecoration.Parent = Me.txbCardNumber
        Me.txbCardNumber.Size = New System.Drawing.Size(600, 50)
        Me.txbCardNumber.TabIndex = 18
        Me.txbCardNumber.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Exp"
        '
        'txbExp
        '
        Me.txbExp.BorderRadius = 5
        Me.txbExp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbExp.DefaultText = ""
        Me.txbExp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbExp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbExp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbExp.DisabledState.Parent = Me.txbExp
        Me.txbExp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbExp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbExp.FocusedState.Parent = Me.txbExp
        Me.txbExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbExp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbExp.HoverState.Parent = Me.txbExp
        Me.txbExp.Location = New System.Drawing.Point(169, 279)
        Me.txbExp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txbExp.Name = "txbExp"
        Me.txbExp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbExp.PlaceholderText = "none"
        Me.txbExp.SelectedText = ""
        Me.txbExp.ShadowDecoration.Parent = Me.txbExp
        Me.txbExp.Size = New System.Drawing.Size(381, 50)
        Me.txbExp.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name: "
        '
        'txbName
        '
        Me.txbName.BorderRadius = 5
        Me.txbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbName.DefaultText = ""
        Me.txbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbName.DisabledState.Parent = Me.txbName
        Me.txbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbName.FocusedState.Parent = Me.txbName
        Me.txbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbName.HoverState.Parent = Me.txbName
        Me.txbName.Location = New System.Drawing.Point(389, 52)
        Me.txbName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txbName.Name = "txbName"
        Me.txbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbName.PlaceholderText = "Full name"
        Me.txbName.SelectedText = ""
        Me.txbName.ShadowDecoration.Parent = Me.txbName
        Me.txbName.Size = New System.Drawing.Size(600, 50)
        Me.txbName.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(593, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CCV"
        '
        'txbCCV
        '
        Me.txbCCV.BorderRadius = 5
        Me.txbCCV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbCCV.DefaultText = ""
        Me.txbCCV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbCCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbCCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCCV.DisabledState.Parent = Me.txbCCV
        Me.txbCCV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCCV.FocusedState.Parent = Me.txbCCV
        Me.txbCCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCCV.HoverState.Parent = Me.txbCCV
        Me.txbCCV.Location = New System.Drawing.Point(598, 279)
        Me.txbCCV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txbCCV.Name = "txbCCV"
        Me.txbCCV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCCV.PlaceholderText = "none"
        Me.txbCCV.SelectedText = ""
        Me.txbCCV.ShadowDecoration.Parent = Me.txbCCV
        Me.txbCCV.Size = New System.Drawing.Size(391, 50)
        Me.txbCCV.TabIndex = 20
        '
        'radMaster
        '
        Me.radMaster.AutoSize = True
        Me.radMaster.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMaster.CheckedState.BorderThickness = 0
        Me.radMaster.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMaster.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radMaster.CheckedState.InnerOffset = -4
        Me.radMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMaster.Location = New System.Drawing.Point(170, 367)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Size = New System.Drawing.Size(154, 33)
        Me.radMaster.TabIndex = 22
        Me.radMaster.Text = "Mastercard"
        Me.radMaster.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radMaster.UncheckedState.BorderThickness = 2
        Me.radMaster.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radMaster.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radVisa
        '
        Me.radVisa.AutoSize = True
        Me.radVisa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radVisa.CheckedState.BorderThickness = 0
        Me.radVisa.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radVisa.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radVisa.CheckedState.InnerOffset = -4
        Me.radVisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVisa.Location = New System.Drawing.Point(437, 367)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(127, 33)
        Me.radVisa.TabIndex = 23
        Me.radVisa.Text = "VIsacard"
        Me.radVisa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radVisa.UncheckedState.BorderThickness = 2
        Me.radVisa.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radVisa.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'PaymentMethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.Controls.Add(Me.radVisa)
        Me.Controls.Add(Me.radMaster)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbCCV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbCardNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbExp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Name = "PaymentMethods"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FoodTableAdapter1 As FoodShopDataSetTableAdapters.FoodTableAdapter
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txbCardNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbExp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbCCV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents radMaster As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radVisa As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents err As ErrorProvider
End Class
