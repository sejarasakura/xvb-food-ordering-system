<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationScreenStaff
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
        Me.lblStaffRegistration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStaffName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSalary = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblMobileNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.lblPosition = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblMaritalStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtStaffName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.radMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMobileNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.radSingle = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radMarried = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPosition = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'lblStaffRegistration
        '
        Me.lblStaffRegistration.AutoSize = False
        Me.lblStaffRegistration.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffRegistration.Location = New System.Drawing.Point(248, 12)
        Me.lblStaffRegistration.Name = "lblStaffRegistration"
        Me.lblStaffRegistration.Size = New System.Drawing.Size(275, 53)
        Me.lblStaffRegistration.TabIndex = 0
        Me.lblStaffRegistration.Text = "Staff Registration"
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = False
        Me.lblStaffName.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(102, 86)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(168, 34)
        Me.lblStaffName.TabIndex = 1
        Me.lblStaffName.Text = "Staff Name"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = False
        Me.lblSalary.BackColor = System.Drawing.Color.Transparent
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(102, 328)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(103, 34)
        Me.lblSalary.TabIndex = 2
        Me.lblSalary.Text = "Salary"
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = False
        Me.lblMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNumber.Location = New System.Drawing.Point(102, 370)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(137, 34)
        Me.lblMobileNumber.TabIndex = 3
        Me.lblMobileNumber.Text = "Mobile Number"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = False
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(102, 244)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(103, 34)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = False
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(102, 137)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(103, 34)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = False
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(102, 190)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(103, 34)
        Me.lblPosition.TabIndex = 7
        Me.lblPosition.Text = "Position"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = False
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(102, 284)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(75, 34)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address"
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = False
        Me.lblMaritalStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaritalStatus.Location = New System.Drawing.Point(102, 421)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(137, 34)
        Me.lblMaritalStatus.TabIndex = 9
        Me.lblMaritalStatus.Text = "Marital Status"
        '
        'txtStaffName
        '
        Me.txtStaffName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStaffName.DefaultText = ""
        Me.txtStaffName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStaffName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStaffName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStaffName.DisabledState.Parent = Me.txtStaffName
        Me.txtStaffName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStaffName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStaffName.FocusedState.Parent = Me.txtStaffName
        Me.txtStaffName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStaffName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStaffName.HoverState.Parent = Me.txtStaffName
        Me.txtStaffName.Location = New System.Drawing.Point(276, 84)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStaffName.PlaceholderText = ""
        Me.txtStaffName.SelectedText = ""
        Me.txtStaffName.ShadowDecoration.Parent = Me.txtStaffName
        Me.txtStaffName.Size = New System.Drawing.Size(272, 36)
        Me.txtStaffName.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(276, 126)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(272, 36)
        Me.txtEmail.TabIndex = 12
        '
        'radMale
        '
        Me.radMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMale.CheckedState.BorderThickness = 0
        Me.radMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radMale.CheckedState.InnerOffset = -4
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(276, 244)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(121, 21)
        Me.radMale.TabIndex = 14
        Me.radMale.Text = "Male"
        Me.radMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radMale.UncheckedState.BorderThickness = 2
        Me.radMale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radFemale
        '
        Me.radFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radFemale.CheckedState.BorderThickness = 0
        Me.radFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radFemale.CheckedState.InnerOffset = -4
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(427, 244)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(121, 21)
        Me.radFemale.TabIndex = 15
        Me.radFemale.Text = "Female"
        Me.radFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radFemale.UncheckedState.BorderThickness = 2
        Me.radFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(276, 284)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(272, 36)
        Me.txtAddress.TabIndex = 16
        '
        'txtSalary
        '
        Me.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalary.DefaultText = ""
        Me.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSalary.DisabledState.Parent = Me.txtSalary
        Me.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSalary.FocusedState.Parent = Me.txtSalary
        Me.txtSalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSalary.HoverState.Parent = Me.txtSalary
        Me.txtSalary.Location = New System.Drawing.Point(276, 326)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalary.PlaceholderText = ""
        Me.txtSalary.SelectedText = ""
        Me.txtSalary.ShadowDecoration.Parent = Me.txtSalary
        Me.txtSalary.Size = New System.Drawing.Size(272, 36)
        Me.txtSalary.TabIndex = 17
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMobileNumber.DefaultText = ""
        Me.txtMobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMobileNumber.DisabledState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMobileNumber.FocusedState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMobileNumber.HoverState.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Location = New System.Drawing.Point(276, 368)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobileNumber.PlaceholderText = ""
        Me.txtMobileNumber.SelectedText = ""
        Me.txtMobileNumber.ShadowDecoration.Parent = Me.txtMobileNumber
        Me.txtMobileNumber.Size = New System.Drawing.Size(272, 36)
        Me.txtMobileNumber.TabIndex = 18
        '
        'radSingle
        '
        Me.radSingle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radSingle.CheckedState.BorderThickness = 0
        Me.radSingle.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radSingle.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radSingle.CheckedState.InnerOffset = -4
        Me.radSingle.Location = New System.Drawing.Point(276, 421)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(121, 21)
        Me.radSingle.TabIndex = 19
        Me.radSingle.Text = "Single"
        Me.radSingle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radSingle.UncheckedState.BorderThickness = 2
        Me.radSingle.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radSingle.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radMarried
        '
        Me.radMarried.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMarried.CheckedState.BorderThickness = 0
        Me.radMarried.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMarried.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radMarried.CheckedState.InnerOffset = -4
        Me.radMarried.Location = New System.Drawing.Point(427, 421)
        Me.radMarried.Name = "radMarried"
        Me.radMarried.Size = New System.Drawing.Size(121, 21)
        Me.radMarried.TabIndex = 20
        Me.radMarried.Text = "Married"
        Me.radMarried.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radMarried.UncheckedState.BorderThickness = 2
        Me.radMarried.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radMarried.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btnSubmit
        '
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(276, 472)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(180, 45)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(71, 472)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(503, 472)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(180, 45)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        '
        'txtPosition
        '
        Me.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPosition.DefaultText = ""
        Me.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPosition.DisabledState.Parent = Me.txtPosition
        Me.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPosition.FocusedState.Parent = Me.txtPosition
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPosition.HoverState.Parent = Me.txtPosition
        Me.txtPosition.Location = New System.Drawing.Point(276, 177)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosition.PlaceholderText = ""
        Me.txtPosition.SelectedText = ""
        Me.txtPosition.ShadowDecoration.Parent = Me.txtPosition
        Me.txtPosition.Size = New System.Drawing.Size(272, 36)
        Me.txtPosition.TabIndex = 24
        '
        'RegistrationScreenStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 564)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radMarried)
        Me.Controls.Add(Me.radSingle)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.lblMaritalStatus)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblMobileNumber)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffRegistration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrationScreenStaff"
        Me.Text = "RegistrationScreenStaff"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStaffRegistration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStaffName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSalary As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMobileNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents lblPosition As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMaritalStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStaffName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents radMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMobileNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents radSingle As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radMarried As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPosition As Guna.UI2.WinForms.Guna2TextBox
End Class
