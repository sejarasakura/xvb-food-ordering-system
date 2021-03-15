<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentScreen
    Inherits VisualBasicAssignment.Master

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PaymentInfo1 = New VisualBasicAssignment.PaymentInfo()
        Me.SuspendLayout()
        '
        'PaymentInfo1
        '
        Me.PaymentInfo1.BackColor = System.Drawing.Color.Gainsboro
        Me.PaymentInfo1.Location = New System.Drawing.Point(234, 191)
        Me.PaymentInfo1.MaximumSize = New System.Drawing.Size(1087, 535)
        Me.PaymentInfo1.MinimumSize = New System.Drawing.Size(1087, 535)
        Me.PaymentInfo1.Name = "PaymentInfo1"
        Me.PaymentInfo1.Size = New System.Drawing.Size(1087, 535)
        Me.PaymentInfo1.TabIndex = 8
        '
        'PaymentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1333, 738)
        Me.Controls.Add(Me.PaymentInfo1)
        Me.Name = "PaymentScreen"
        Me.Controls.SetChildIndex(Me.PaymentInfo1, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaymentInfo1 As PaymentInfo
End Class
