﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentStep3
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
        Me.PaymentConfirm1 = New VisualBasicAssignment.PaymentConfirm()
        Me.SuspendLayout()
        '
        'PaymentConfirm1
        '
        Me.PaymentConfirm1.Location = New System.Drawing.Point(234, 191)
        Me.PaymentConfirm1.MaximumSize = New System.Drawing.Size(1087, 535)
        Me.PaymentConfirm1.MinimumSize = New System.Drawing.Size(1087, 535)
        Me.PaymentConfirm1.Name = "PaymentConfirm1"
        Me.PaymentConfirm1.Size = New System.Drawing.Size(1087, 535)
        Me.PaymentConfirm1.TabIndex = 8
        '
        'PaymentStep3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1333, 738)
        Me.Controls.Add(Me.PaymentConfirm1)
        Me.Name = "PaymentStep3"
        Me.Controls.SetChildIndex(Me.PaymentConfirm1, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaymentConfirm1 As PaymentConfirm
End Class
