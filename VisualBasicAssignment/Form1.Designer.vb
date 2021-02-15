<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNav = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMini = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnOrder)
        Me.Panel1.Controls.Add(Me.btnCart)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.picIcon)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(170, 600)
        Me.Panel1.MinimumSize = New System.Drawing.Size(50, 600)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 600)
        Me.Panel1.TabIndex = 2
        '
        'btnOrder
        '
        Me.btnOrder.CheckedState.Parent = Me.btnOrder
        Me.btnOrder.CustomImages.Parent = Me.btnOrder
        Me.btnOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOrder.ForeColor = System.Drawing.Color.White
        Me.btnOrder.HoverState.Parent = Me.btnOrder
        Me.btnOrder.Image = CType(resources.GetObject("btnOrder.Image"), System.Drawing.Image)
        Me.btnOrder.Location = New System.Drawing.Point(0, 300)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.ShadowDecoration.Parent = Me.btnOrder
        Me.btnOrder.Size = New System.Drawing.Size(170, 50)
        Me.btnOrder.TabIndex = 18
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.TextFormatNoPrefix = True
        '
        'btnCart
        '
        Me.btnCart.CheckedState.Parent = Me.btnCart
        Me.btnCart.CustomImages.Parent = Me.btnCart
        Me.btnCart.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCart.ForeColor = System.Drawing.Color.White
        Me.btnCart.HoverState.Parent = Me.btnCart
        Me.btnCart.Image = CType(resources.GetObject("btnCart.Image"), System.Drawing.Image)
        Me.btnCart.Location = New System.Drawing.Point(0, 250)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.ShadowDecoration.Parent = Me.btnCart
        Me.btnCart.Size = New System.Drawing.Size(170, 50)
        Me.btnCart.TabIndex = 17
        Me.btnCart.Text = "CART"
        Me.btnCart.TextFormatNoPrefix = True
        '
        'btnMenu
        '
        Me.btnMenu.CheckedState.Parent = Me.btnMenu
        Me.btnMenu.CustomImages.Parent = Me.btnMenu
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.HoverState.Parent = Me.btnMenu
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(0, 200)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.ShadowDecoration.Parent = Me.btnMenu
        Me.btnMenu.Size = New System.Drawing.Size(170, 50)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.TextFormatNoPrefix = True
        '
        'btnProfile
        '
        Me.btnProfile.CheckedState.Parent = Me.btnProfile
        Me.btnProfile.CustomImages.Parent = Me.btnProfile
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfile.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.HoverState.Parent = Me.btnProfile
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Location = New System.Drawing.Point(0, 150)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.ShadowDecoration.Parent = Me.btnProfile
        Me.btnProfile.Size = New System.Drawing.Size(170, 50)
        Me.btnProfile.TabIndex = 15
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.TextFormatNoPrefix = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 134)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(170, 16)
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
        Me.picIcon.Location = New System.Drawing.Point(0, 45)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(170, 89)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcon.TabIndex = 13
        Me.picIcon.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 26)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(170, 19)
        Me.Panel6.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnNav)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 26)
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
        Me.btnNav.Image = Global.assignment.My.Resources.Resources.nav
        Me.btnNav.Location = New System.Drawing.Point(0, 0)
        Me.btnNav.Name = "btnNav"
        Me.btnNav.ShadowDecoration.Parent = Me.btnNav
        Me.btnNav.Size = New System.Drawing.Size(170, 30)
        Me.btnNav.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnMini)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(170, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(830, 26)
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
        Me.btnMini.Location = New System.Drawing.Point(772, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.ShadowDecoration.Parent = Me.btnMini
        Me.btnMini.Size = New System.Drawing.Size(30, 26)
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
        Me.btnClose.Location = New System.Drawing.Point(802, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(28, 26)
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
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(170, 26)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(830, 124)
        Me.Panel5.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(170, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(830, 450)
        Me.Panel4.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents btnOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
End Class
