<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRecordReport
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblSelUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnDisplay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnShowAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.mskUsername = New System.Windows.Forms.MaskedTextBox()
        Me.lblItem = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(33, 63)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(719, 224)
        Me.dgv.TabIndex = 4
        '
        'lblSelUser
        '
        Me.lblSelUser.AutoSize = False
        Me.lblSelUser.BackColor = System.Drawing.Color.Transparent
        Me.lblSelUser.Location = New System.Drawing.Point(12, 12)
        Me.lblSelUser.Name = "lblSelUser"
        Me.lblSelUser.Size = New System.Drawing.Size(200, 27)
        Me.lblSelUser.TabIndex = 9
        Me.lblSelUser.Text = "Select User Name:"
        '
        'btnDisplay
        '
        Me.btnDisplay.CheckedState.Parent = Me.btnDisplay
        Me.btnDisplay.CustomImages.Parent = Me.btnDisplay
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.HoverState.Parent = Me.btnDisplay
        Me.btnDisplay.Location = New System.Drawing.Point(444, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.ShadowDecoration.Parent = Me.btnDisplay
        Me.btnDisplay.Size = New System.Drawing.Size(132, 45)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(656, 382)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(132, 45)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log Out"
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(444, 382)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(132, 45)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        '
        'btnShowAll
        '
        Me.btnShowAll.CheckedState.Parent = Me.btnShowAll
        Me.btnShowAll.CustomImages.Parent = Me.btnShowAll
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.HoverState.Parent = Me.btnShowAll
        Me.btnShowAll.Location = New System.Drawing.Point(656, 314)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.ShadowDecoration.Parent = Me.btnShowAll
        Me.btnShowAll.Size = New System.Drawing.Size(132, 45)
        Me.btnShowAll.TabIndex = 3
        Me.btnShowAll.Text = "Show All"
        '
        'btnReset
        '
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(656, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.Size = New System.Drawing.Size(132, 45)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        '
        'mskUsername
        '
        Me.mskUsername.Location = New System.Drawing.Point(229, 12)
        Me.mskUsername.Name = "mskUsername"
        Me.mskUsername.Size = New System.Drawing.Size(148, 22)
        Me.mskUsername.TabIndex = 11
        '
        'lblItem
        '
        Me.lblItem.AutoSize = False
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Location = New System.Drawing.Point(26, 308)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(168, 51)
        Me.lblItem.TabIndex = 9
        Me.lblItem.Text = "0 item(s)"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(529, 242)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(132, 45)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Display"
        '
        'btnAdd
        '
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(444, 314)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(132, 45)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        '
        'UserRecordReport
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mskUsername)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblSelUser)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "UserRecordReport"
        Me.Text = "User Record"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblSelUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDisplay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mskUsername As MaskedTextBox
    Friend WithEvents lblItem As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
End Class
