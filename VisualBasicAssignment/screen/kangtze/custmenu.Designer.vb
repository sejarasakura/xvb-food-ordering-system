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
        Me.btnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'pnlPicture
        '
        Me.pnlPicture.Location = New System.Drawing.Point(16, 15)
        Me.pnlPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Size = New System.Drawing.Size(1075, 498)
        Me.pnlPicture.TabIndex = 0
        '
        'btnReload
        '
        Me.btnReload.CheckedState.Parent = Me.btnReload
        Me.btnReload.CustomImages.Parent = Me.btnReload
        Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.HoverState.Parent = Me.btnReload
        Me.btnReload.Location = New System.Drawing.Point(958, 520)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.ShadowDecoration.Parent = Me.btnReload
        Me.btnReload.Size = New System.Drawing.Size(133, 26)
        Me.btnReload.TabIndex = 1
        Me.btnReload.Text = "Reload"
        '
        'custmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 554)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.pnlPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "custmenu"
        Me.Text = "custmenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPicture As FlowLayoutPanel
    Friend WithEvents btnReload As Guna.UI2.WinForms.Guna2Button
End Class
