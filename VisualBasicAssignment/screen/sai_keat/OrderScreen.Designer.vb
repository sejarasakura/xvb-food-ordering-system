<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderScreen
    Inherits VisualBasicAssignment.Master

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
        Me.MyOder1 = New VisualBasicAssignment.MyOder()
        Me.SuspendLayout()
        '
        'MyOder1
        '
        Me.MyOder1.Location = New System.Drawing.Point(234, 191)
        Me.MyOder1.MaximumSize = New System.Drawing.Size(1087, 535)
        Me.MyOder1.MinimumSize = New System.Drawing.Size(1087, 535)
        Me.MyOder1.Name = "MyOder1"
        Me.MyOder1.Size = New System.Drawing.Size(1087, 535)
        Me.MyOder1.TabIndex = 8
        '
        'OrderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1333, 738)
        Me.Controls.Add(Me.MyOder1)
        Me.Name = "OrderScreen"
        Me.Controls.SetChildIndex(Me.MyOder1, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyOder1 As MyOder
End Class
