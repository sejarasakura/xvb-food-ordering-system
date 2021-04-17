<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderItem))
        Me.title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.info = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.upDownNumbering = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckb = New System.Windows.Forms.CheckBox()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upDownNumbering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = False
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Location = New System.Drawing.Point(172, 4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(306, 105)
        Me.title.TabIndex = 2
        '
        'info
        '
        Me.info.AutoSize = False
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(484, 13)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(128, 87)
        Me.info.TabIndex = 3
        '
        'img
        '
        Me.img.Image = CType(resources.GetObject("img.Image"), System.Drawing.Image)
        Me.img.Location = New System.Drawing.Point(50, 4)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(116, 105)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img.TabIndex = 0
        Me.img.TabStop = False
        '
        'upDownNumbering
        '
        Me.upDownNumbering.BackColor = System.Drawing.Color.Transparent
        Me.upDownNumbering.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.upDownNumbering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.upDownNumbering.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.upDownNumbering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.upDownNumbering.DisabledState.Parent = Me.upDownNumbering
        Me.upDownNumbering.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.upDownNumbering.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.upDownNumbering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upDownNumbering.FocusedState.Parent = Me.upDownNumbering
        Me.upDownNumbering.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.upDownNumbering.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.upDownNumbering.Location = New System.Drawing.Point(651, 36)
        Me.upDownNumbering.Name = "upDownNumbering"
        Me.upDownNumbering.ShadowDecoration.Parent = Me.upDownNumbering
        Me.upDownNumbering.Size = New System.Drawing.Size(100, 36)
        Me.upDownNumbering.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(655, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Quantity:"
        '
        'ckb
        '
        Me.ckb.AutoSize = True
        Me.ckb.Location = New System.Drawing.Point(10, 10)
        Me.ckb.Name = "ckb"
        Me.ckb.Size = New System.Drawing.Size(18, 17)
        Me.ckb.TabIndex = 6
        Me.ckb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckb.UseVisualStyleBackColor = True
        '
        'OrderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ckb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.upDownNumbering)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.img)
        Me.Name = "OrderItem"
        Me.Size = New System.Drawing.Size(765, 115)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upDownNumbering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents info As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents upDownNumbering As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ckb As CheckBox
End Class
