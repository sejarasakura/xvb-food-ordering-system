<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDesc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pcbProduct = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.pcbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Garamond", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(35, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 39)
        Me.lblName.TabIndex = 47
        Me.lblName.Text = "Food"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = False
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Location = New System.Drawing.Point(42, 78)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(300, 151)
        Me.lblDesc.TabIndex = 62
        Me.lblDesc.Text = Nothing
        '
        'pcbProduct
        '
        Me.pcbProduct.Location = New System.Drawing.Point(407, 78)
        Me.pcbProduct.Name = "pcbProduct"
        Me.pcbProduct.ShadowDecoration.Parent = Me.pcbProduct
        Me.pcbProduct.Size = New System.Drawing.Size(200, 162)
        Me.pcbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProduct.TabIndex = 58
        Me.pcbProduct.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(42, 309)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(120, 40)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "Back"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = False
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Garamond", 20.0!)
        Me.lblPrice.Location = New System.Drawing.Point(42, 269)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(300, 35)
        Me.lblPrice.TabIndex = 63
        Me.lblPrice.Text = Nothing
        '
        'detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pcbProduct)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "detail"
        Me.Text = "detail"
        CType(Me.pcbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbProduct As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDesc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPrice As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
