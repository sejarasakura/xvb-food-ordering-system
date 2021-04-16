<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class custmenu
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
        Me.pnlPicture = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'pnlPicture
        '
        Me.pnlPicture.Location = New System.Drawing.Point(12, 12)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Size = New System.Drawing.Size(806, 426)
        Me.pnlPicture.TabIndex = 0
        '
        'custmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 450)
        Me.Controls.Add(Me.pnlPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "custmenu"
        Me.Text = "custmenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPicture As FlowLayoutPanel
End Class
