<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginScreen))
        Me.tbxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.cancleBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.loginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxName
        '
        Me.tbxName.BackColor = System.Drawing.Color.Transparent
        Me.tbxName.BorderRadius = 10
        Me.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxName.DefaultText = ""
        Me.tbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxName.DisabledState.Parent = Me.tbxName
        Me.tbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxName.FocusedState.Parent = Me.tbxName
        Me.tbxName.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxName.HoverState.Parent = Me.tbxName
        Me.tbxName.Location = New System.Drawing.Point(74, 430)
        Me.tbxName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxName.PlaceholderText = ""
        Me.tbxName.SelectedText = ""
        Me.tbxName.ShadowDecoration.Parent = Me.tbxName
        Me.tbxName.Size = New System.Drawing.Size(465, 51)
        Me.tbxName.TabIndex = 0
        '
        'tbxPassword
        '
        Me.tbxPassword.BackColor = System.Drawing.Color.Transparent
        Me.tbxPassword.BorderRadius = 10
        Me.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxPassword.DefaultText = ""
        Me.tbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword.DisabledState.Parent = Me.tbxPassword
        Me.tbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword.FocusedState.Parent = Me.tbxPassword
        Me.tbxPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword.HoverState.Parent = Me.tbxPassword
        Me.tbxPassword.Location = New System.Drawing.Point(74, 542)
        Me.tbxPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxPassword.PlaceholderText = ""
        Me.tbxPassword.SelectedText = ""
        Me.tbxPassword.ShadowDecoration.Parent = Me.tbxPassword
        Me.tbxPassword.Size = New System.Drawing.Size(465, 51)
        Me.tbxPassword.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblName.Location = New System.Drawing.Point(70, 399)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(249, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Username / Registeration Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPassword.Location = New System.Drawing.Point(70, 520)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'cancleBtn
        '
        Me.cancleBtn.BackColor = System.Drawing.Color.Transparent
        Me.cancleBtn.CheckedState.Parent = Me.cancleBtn
        Me.cancleBtn.CustomImages.Parent = Me.cancleBtn
        Me.cancleBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancleBtn.ForeColor = System.Drawing.Color.White
        Me.cancleBtn.HoverState.Parent = Me.cancleBtn
        Me.cancleBtn.Location = New System.Drawing.Point(74, 648)
        Me.cancleBtn.Name = "cancleBtn"
        Me.cancleBtn.ShadowDecoration.Parent = Me.cancleBtn
        Me.cancleBtn.Size = New System.Drawing.Size(207, 62)
        Me.cancleBtn.TabIndex = 7
        Me.cancleBtn.BackColor = VRColor.WARNING_COLOR
        Me.cancleBtn.Text = "Cancle"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.CheckedState.Parent = Me.loginBtn
        Me.loginBtn.CustomImages.Parent = Me.loginBtn
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.HoverState.Parent = Me.loginBtn
        Me.loginBtn.Location = New System.Drawing.Point(332, 648)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.ShadowDecoration.Parent = Me.loginBtn
        Me.loginBtn.Size = New System.Drawing.Size(207, 62)
        Me.loginBtn.TabIndex = 7
        Me.loginBtn.BackColor = VRColor.COLORED_BG
        Me.loginBtn.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.VisualBasicAssignment.My.Resources.Resources.default_user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(201, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 778)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.cancleBtn)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents cancleBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
