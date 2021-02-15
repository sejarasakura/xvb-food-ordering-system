<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentChoice
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
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.SuspendLayout()
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BorderRadius = 10
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2VScrollBar1.HoverState.Parent = Nothing
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(1020, 0)
        Me.Guna2VScrollBar1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2VScrollBar1.MouseWheelBarPartitions = 10
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.PressedState.Parent = Me.Guna2VScrollBar1
        Me.Guna2VScrollBar1.ScrollbarSize = 14
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(14, 618)
        Me.Guna2VScrollBar1.TabIndex = 0
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        '
        'PaymentChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Name = "PaymentChoice"
        Me.Size = New System.Drawing.Size(1034, 618)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
End Class
