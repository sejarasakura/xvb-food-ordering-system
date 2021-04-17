<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Master))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNav = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMini = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.picIcon)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.MaximumSize = New System.Drawing.Size(227, 738)
        Me.Panel1.MinimumSize = New System.Drawing.Size(67, 738)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 738)
        Me.Panel1.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 165)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(227, 20)
        Me.Panel7.TabIndex = 14
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.picIcon.Dock = System.Windows.Forms.DockStyle.Top
        Me.picIcon.ErrorImage = Nothing
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.InitialImage = Nothing
        Me.picIcon.Location = New System.Drawing.Point(0, 55)
        Me.picIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(227, 110)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcon.TabIndex = 13
        Me.picIcon.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 32)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(227, 23)
        Me.Panel6.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnNav)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 32)
        Me.Panel2.TabIndex = 1
        '
        'btnNav
        '
        Me.btnNav.CheckedState.Parent = Me.btnNav
        Me.btnNav.CustomImages.Parent = Me.btnNav
        Me.btnNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNav.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnNav.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNav.ForeColor = System.Drawing.Color.White
        Me.btnNav.HoverState.Parent = Me.btnNav
        Me.btnNav.Image = CType(resources.GetObject("btnNav.Image"), System.Drawing.Image)
        Me.btnNav.Location = New System.Drawing.Point(0, 0)
        Me.btnNav.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNav.Name = "btnNav"
        Me.btnNav.ShadowDecoration.Parent = Me.btnNav
        Me.btnNav.Size = New System.Drawing.Size(227, 37)
        Me.btnNav.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(170, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(830, 450)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnMini)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(227, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1106, 32)
        Me.Panel3.TabIndex = 6
        '
        'btnMini
        '
        Me.btnMini.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMini.CheckedState.Parent = Me.btnMini
        Me.btnMini.CustomImages.Parent = Me.btnMini
        Me.btnMini.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMini.FillColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMini.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMini.ForeColor = System.Drawing.Color.White
        Me.btnMini.HoverState.Parent = Me.btnMini
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnMini.Location = New System.Drawing.Point(1029, 0)
        Me.btnMini.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.ShadowDecoration.Parent = Me.btnMini
        Me.btnMini.Size = New System.Drawing.Size(40, 32)
        Me.btnMini.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnClose.Location = New System.Drawing.Point(1069, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(37, 32)
        Me.btnClose.TabIndex = 5
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.ContainerControl = Me
        Me.Guna2DragControl1.TargetControl = Me.Panel3
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.ContainerControl = Me
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.panelMessage)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(227, 32)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1106, 152)
        Me.Panel5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Functions"
        '
        'panelMessage
        '
        Me.panelMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelMessage.Location = New System.Drawing.Point(693, 0)
        Me.panelMessage.Name = "panelMessage"
        Me.panelMessage.Size = New System.Drawing.Size(411, 150)
        Me.panelMessage.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1333, 738)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Master"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMini As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnNav As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents panelMessage As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PaymentInfo1 As PaymentInfo
End Class
