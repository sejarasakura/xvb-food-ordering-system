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
        Me.FoodTableAdapter1 = New VisualBasicAssignment.FoodShopDataSetTableAdapters.FoodTableAdapter()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbCompanyName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbAddressDetails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'FoodTableAdapter1
        '
        Me.FoodTableAdapter1.ClearBeforeFill = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(467, 475)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(230, 45)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "Credit Card checkout"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.Label5.Location = New System.Drawing.Point(250, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Card Number:"
        '
        'txbCompanyName
        '
        Me.txbCompanyName.BorderRadius = 5
        Me.txbCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbCompanyName.DefaultText = ""
        Me.txbCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCompanyName.DisabledState.Parent = Me.txbCompanyName
        Me.txbCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCompanyName.FocusedState.Parent = Me.txbCompanyName
        Me.txbCompanyName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCompanyName.HoverState.Parent = Me.txbCompanyName
        Me.txbCompanyName.Location = New System.Drawing.Point(389, 207)
        Me.txbCompanyName.Name = "txbCompanyName"
        Me.txbCompanyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCompanyName.PlaceholderText = "(Optional)"
        Me.txbCompanyName.SelectedText = ""
        Me.txbCompanyName.ShadowDecoration.Parent = Me.txbCompanyName
        Me.txbCompanyName.Size = New System.Drawing.Size(470, 32)
        Me.txbCompanyName.TabIndex = 18
        Me.txbCompanyName.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.Label3.Location = New System.Drawing.Point(250, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Address Details: "
        '
        'txbAddressDetails
        '
        Me.txbAddressDetails.BorderRadius = 5
        Me.txbAddressDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbAddressDetails.DefaultText = ""
        Me.txbAddressDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbAddressDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbAddressDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAddressDetails.DisabledState.Parent = Me.txbAddressDetails
        Me.txbAddressDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAddressDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAddressDetails.FocusedState.Parent = Me.txbAddressDetails
        Me.txbAddressDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbAddressDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAddressDetails.HoverState.Parent = Me.txbAddressDetails
        Me.txbAddressDetails.Location = New System.Drawing.Point(389, 251)
        Me.txbAddressDetails.Name = "txbAddressDetails"
        Me.txbAddressDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbAddressDetails.PlaceholderText = "none"
        Me.txbAddressDetails.SelectedText = ""
        Me.txbAddressDetails.ShadowDecoration.Parent = Me.txbAddressDetails
        Me.txbAddressDetails.Size = New System.Drawing.Size(470, 32)
        Me.txbAddressDetails.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.Label2.Location = New System.Drawing.Point(250, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
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
        Me.txbName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbName.HoverState.Parent = Me.txbName
        Me.txbName.Location = New System.Drawing.Point(389, 164)
        Me.txbName.Name = "txbName"
        Me.txbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbName.PlaceholderText = "Full name"
        Me.txbName.SelectedText = ""
        Me.txbName.ShadowDecoration.Parent = Me.txbName
        Me.txbName.Size = New System.Drawing.Size(470, 32)
        Me.txbName.TabIndex = 14
        '
        'PaymentMethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbCompanyName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbAddressDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Name = "PaymentMethods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FoodTableAdapter1 As FoodShopDataSetTableAdapters.FoodTableAdapter
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txbCompanyName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbAddressDetails As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbName As Guna.UI2.WinForms.Guna2TextBox
End Class
