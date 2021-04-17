<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlPicture = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReload
        '
        Me.btnReload.CheckedState.Parent = Me.btnReload
        Me.btnReload.CustomImages.Parent = Me.btnReload
        Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.HoverState.Parent = Me.btnReload
        Me.btnReload.Location = New System.Drawing.Point(804, 517)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.ShadowDecoration.Parent = Me.btnReload
        Me.btnReload.Size = New System.Drawing.Size(133, 26)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "Reload"
        '
        'pnlPicture
        '
        Me.pnlPicture.Location = New System.Drawing.Point(177, 12)
        Me.pnlPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Size = New System.Drawing.Size(911, 498)
        Me.pnlPicture.TabIndex = 2
        '
        'btnPay
        '
        Me.btnPay.CheckedState.Parent = Me.btnPay
        Me.btnPay.CustomImages.Parent = Me.btnPay
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.HoverState.Parent = Me.btnPay
        Me.btnPay.Location = New System.Drawing.Point(955, 517)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.ShadowDecoration.Parent = Me.btnPay
        Me.btnPay.Size = New System.Drawing.Size(133, 26)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Paynow"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VisualBasicAssignment.My.Resources.Resources.cart
        Me.PictureBox1.Location = New System.Drawing.Point(3, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cart"
        '
        'CartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.pnlPicture)
        Me.Name = "CartScreen"
        Me.Size = New System.Drawing.Size(1100, 551)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlPicture As FlowLayoutPanel
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
