﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addfood
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pcbProduct = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.pcbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Garamond", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(25, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(164, 39)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Add Food"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Food Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Food Description :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Food Price :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Food Category :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(183, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(200, 29)
        Me.txtName.TabIndex = 5
        '
        'txtDesc
        '
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.DefaultText = ""
        Me.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.DisabledState.Parent = Me.txtDesc
        Me.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.FocusedState.Parent = Me.txtDesc
        Me.txtDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.HoverState.Parent = Me.txtDesc
        Me.txtDesc.Location = New System.Drawing.Point(183, 111)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesc.PlaceholderText = ""
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.ShadowDecoration.Parent = Me.txtDesc
        Me.txtDesc.Size = New System.Drawing.Size(200, 29)
        Me.txtDesc.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(183, 155)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(200, 29)
        Me.txtPrice.TabIndex = 7
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.Parent = Me.cmbCategory
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.HoverState.Parent = Me.cmbCategory
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.ItemsAppearance.Parent = Me.cmbCategory
        Me.cmbCategory.Location = New System.Drawing.Point(183, 193)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ShadowDecoration.Parent = Me.cmbCategory
        Me.cmbCategory.Size = New System.Drawing.Size(200, 36)
        Me.cmbCategory.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Food Image :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.CheckedState.Parent = Me.btnUpload
        Me.btnUpload.CustomImages.Parent = Me.btnUpload
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.HoverState.Parent = Me.btnUpload
        Me.btnUpload.Location = New System.Drawing.Point(183, 242)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.ShadowDecoration.Parent = Me.btnUpload
        Me.btnUpload.Size = New System.Drawing.Size(115, 30)
        Me.btnUpload.TabIndex = 31
        Me.btnUpload.Text = "Upload Image"
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        '
        'btnCreate
        '
        Me.btnCreate.CheckedState.Parent = Me.btnCreate
        Me.btnCreate.CustomImages.Parent = Me.btnCreate
        Me.btnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.Parent = Me.btnCreate
        Me.btnCreate.Location = New System.Drawing.Point(57, 330)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.Parent = Me.btnCreate
        Me.btnCreate.Size = New System.Drawing.Size(120, 40)
        Me.btnCreate.TabIndex = 33
        Me.btnCreate.Text = "Create Food"
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(201, 330)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(120, 40)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        '
        'pcbProduct
        '
        Me.pcbProduct.Location = New System.Drawing.Point(443, 67)
        Me.pcbProduct.Name = "pcbProduct"
        Me.pcbProduct.ShadowDecoration.Parent = Me.pcbProduct
        Me.pcbProduct.Size = New System.Drawing.Size(300, 200)
        Me.pcbProduct.TabIndex = 32
        Me.pcbProduct.TabStop = False
        '
        'addfood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.pcbProduct)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addfood"
        Me.ShowInTaskbar = False
        Me.Text = "addfood"
        CType(Me.pcbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pcbProduct As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class