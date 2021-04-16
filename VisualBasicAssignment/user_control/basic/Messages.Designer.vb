<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messages
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'lblContent
        '
        Me.lblContent.AutoSize = False
        Me.lblContent.BackColor = System.Drawing.Color.Transparent
        Me.lblContent.Location = New System.Drawing.Point(65, 37)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(338, 86)
        Me.lblContent.TabIndex = 4
        Me.lblContent.Text = "<warp>This is an error about no error messages x x x xxxxx xxx xx xx xxx xxxx</wa" &
    "rp>"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "Messages"
        Me.Size = New System.Drawing.Size(406, 126)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private lblMsg As System.Windows.Forms.Label
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Friend timer1 As System.Windows.Forms.Timer
    Private pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblContent As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
