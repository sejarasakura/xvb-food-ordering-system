using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class AddUser : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            txtHPNumber = new Guna.UI2.WinForms.Guna2TextBox();
            txtFName = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtLName = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            _btnClear = new Guna.UI2.WinForms.Guna2Button();
            _btnClear.Click += new EventHandler(btnClear_Click);
            _btnAdd = new Guna.UI2.WinForms.Guna2Button();
            _btnAdd.Click += new EventHandler(btnAdd_Click);
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            lblId = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            _btnBack = new Guna.UI2.WinForms.Guna2Button();
            _btnBack.Click += new EventHandler(Back_Click);
            lblRole = new Label();
            txtRole = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderRadius = 10;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtPassword.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtPassword.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPassword.DisabledState.Parent = txtPassword;
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPassword.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPassword.FocusedState.Parent = txtPassword;
            txtPassword.Font = new Font("Segoe UI Semilight", 12.0f);
            txtPassword.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPassword.HoverState.Parent = txtPassword;
            txtPassword.Location = new Point(140, 282);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.Parent = txtPassword;
            txtPassword.Size = new Size(256, 39);
            txtPassword.TabIndex = 77;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.Transparent;
            txtGender.BorderRadius = 10;
            txtGender.Cursor = Cursors.IBeam;
            txtGender.DefaultText = "";
            txtGender.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtGender.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtGender.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtGender.DisabledState.Parent = txtGender;
            txtGender.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtGender.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtGender.FocusedState.Parent = txtGender;
            txtGender.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtGender.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtGender.HoverState.Parent = txtGender;
            txtGender.Location = new Point(523, 223);
            txtGender.Margin = new Padding(2);
            txtGender.Name = "txtGender";
            txtGender.PasswordChar = '\0';
            txtGender.PlaceholderText = "Gender";
            txtGender.SelectedText = "";
            txtGender.ShadowDecoration.Parent = txtGender;
            txtGender.Size = new Size(256, 39);
            txtGender.TabIndex = 76;
            // 
            // txtHPNumber
            // 
            txtHPNumber.BackColor = Color.Transparent;
            txtHPNumber.BorderRadius = 10;
            txtHPNumber.Cursor = Cursors.IBeam;
            txtHPNumber.DefaultText = "";
            txtHPNumber.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtHPNumber.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtHPNumber.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtHPNumber.DisabledState.Parent = txtHPNumber;
            txtHPNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtHPNumber.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtHPNumber.FocusedState.Parent = txtHPNumber;
            txtHPNumber.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHPNumber.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtHPNumber.HoverState.Parent = txtHPNumber;
            txtHPNumber.Location = new Point(140, 223);
            txtHPNumber.Margin = new Padding(2);
            txtHPNumber.Name = "txtHPNumber";
            txtHPNumber.PasswordChar = '\0';
            txtHPNumber.PlaceholderText = "H/P Number";
            txtHPNumber.SelectedText = "";
            txtHPNumber.ShadowDecoration.Parent = txtHPNumber;
            txtHPNumber.Size = new Size(256, 39);
            txtHPNumber.TabIndex = 75;
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.Transparent;
            txtFName.BorderRadius = 10;
            txtFName.Cursor = Cursors.IBeam;
            txtFName.DefaultText = "";
            txtFName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtFName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtFName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtFName.DisabledState.Parent = txtFName;
            txtFName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtFName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtFName.FocusedState.Parent = txtFName;
            txtFName.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtFName.HoverState.Parent = txtFName;
            txtFName.Location = new Point(523, 169);
            txtFName.Margin = new Padding(2);
            txtFName.Name = "txtFName";
            txtFName.PasswordChar = '\0';
            txtFName.PlaceholderText = "First Name";
            txtFName.SelectedText = "";
            txtFName.ShadowDecoration.Parent = txtFName;
            txtFName.Size = new Size(256, 39);
            txtFName.TabIndex = 74;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.BorderRadius = 10;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtEmail.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtEmail.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtEmail.DisabledState.Parent = txtEmail;
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtEmail.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtEmail.FocusedState.Parent = txtEmail;
            txtEmail.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtEmail.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtEmail.HoverState.Parent = txtEmail;
            txtEmail.Location = new Point(140, 169);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.Parent = txtEmail;
            txtEmail.Size = new Size(256, 39);
            txtEmail.TabIndex = 73;
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.Transparent;
            txtLName.BorderRadius = 10;
            txtLName.Cursor = Cursors.IBeam;
            txtLName.DefaultText = "";
            txtLName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtLName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtLName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtLName.DisabledState.Parent = txtLName;
            txtLName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtLName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtLName.FocusedState.Parent = txtLName;
            txtLName.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtLName.HoverState.Parent = txtLName;
            txtLName.Location = new Point(523, 117);
            txtLName.Margin = new Padding(2);
            txtLName.Name = "txtLName";
            txtLName.PasswordChar = '\0';
            txtLName.PlaceholderText = "Last Name";
            txtLName.SelectedText = "";
            txtLName.ShadowDecoration.Parent = txtLName;
            txtLName.Size = new Size(256, 39);
            txtLName.TabIndex = 72;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.BorderRadius = 10;
            txtName.Cursor = Cursors.IBeam;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtName.DisabledState.Parent = txtName;
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtName.FocusedState.Parent = txtName;
            txtName.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtName.HoverState.Parent = txtName;
            txtName.Location = new Point(140, 117);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "User Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.Parent = txtName;
            txtName.Size = new Size(256, 39);
            txtName.TabIndex = 71;
            // 
            // btnClear
            // 
            _btnClear.CheckedState.Parent = _btnClear;
            _btnClear.CustomImages.Parent = _btnClear;
            _btnClear.Font = new Font("Segoe UI", 9.0f);
            _btnClear.ForeColor = Color.White;
            _btnClear.HoverState.Parent = _btnClear;
            _btnClear.Location = new Point(650, 296);
            _btnClear.Name = "_btnClear";
            _btnClear.ShadowDecoration.Parent = _btnClear;
            _btnClear.Size = new Size(129, 45);
            _btnClear.TabIndex = 61;
            _btnClear.Text = "Clear";
            // 
            // btnAdd
            // 
            _btnAdd.CheckedState.Parent = _btnAdd;
            _btnAdd.CustomImages.Parent = _btnAdd;
            _btnAdd.Font = new Font("Segoe UI", 9.0f);
            _btnAdd.ForeColor = Color.White;
            _btnAdd.HoverState.Parent = _btnAdd;
            _btnAdd.Location = new Point(469, 374);
            _btnAdd.Name = "_btnAdd";
            _btnAdd.ShadowDecoration.Parent = _btnAdd;
            _btnAdd.Size = new Size(129, 45);
            _btnAdd.TabIndex = 60;
            _btnAdd.Text = "Add";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblConfirmPassword.Location = new Point(22, 223);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(112, 20);
            lblConfirmPassword.TabIndex = 68;
            lblConfirmPassword.Text = "H/P Number :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblPassword.Location = new Point(73, 169);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 20);
            lblPassword.TabIndex = 69;
            lblPassword.Text = "Email :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblEmail.Location = new Point(41, 282);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 20);
            lblEmail.TabIndex = 70;
            lblEmail.Text = "Password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblUserName.Location = new Point(30, 117);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 20);
            lblUserName.TabIndex = 67;
            lblUserName.Text = "User Name :";
            // 
            // lblId
            // 
            lblId.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblId.Location = new Point(188, 74);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(243, 20);
            lblId.TabIndex = 62;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label4.Location = new Point(436, 223);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(80, 60);
            Label4.TabIndex = 64;
            Label4.Text = "Gender :" + '\r' + '\n' + "(f: female" + '\r' + '\n' + "/m: male)" + '\r' + '\n';
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label3.Location = new Point(414, 169);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(102, 20);
            Label3.TabIndex = 63;
            Label3.Text = "First Name :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label2.Location = new Point(414, 117);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(101, 20);
            Label2.TabIndex = 65;
            Label2.Text = "Last Name :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label1.Location = new Point(98, 74);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(36, 20);
            Label1.TabIndex = 66;
            Label1.Text = "ID :";
            // 
            // btnBack
            // 
            _btnBack.CheckedState.Parent = _btnBack;
            _btnBack.CustomImages.Parent = _btnBack;
            _btnBack.DialogResult = DialogResult.Cancel;
            _btnBack.Font = new Font("Segoe UI", 9.0f);
            _btnBack.ForeColor = Color.White;
            _btnBack.HoverState.Parent = _btnBack;
            _btnBack.Location = new Point(650, 374);
            _btnBack.Name = "_btnBack";
            _btnBack.ShadowDecoration.Parent = _btnBack;
            _btnBack.Size = new Size(129, 45);
            _btnBack.TabIndex = 61;
            _btnBack.Text = "Back";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblRole.Location = new Point(81, 339);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(53, 20);
            lblRole.TabIndex = 70;
            lblRole.Text = "Role :";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.Transparent;
            txtRole.BorderRadius = 10;
            txtRole.Cursor = Cursors.IBeam;
            txtRole.DefaultText = "";
            txtRole.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtRole.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtRole.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtRole.DisabledState.Parent = txtRole;
            txtRole.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtRole.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtRole.FocusedState.Parent = txtRole;
            txtRole.Font = new Font("Segoe UI Semilight", 12.0f);
            txtRole.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtRole.HoverState.Parent = txtRole;
            txtRole.Location = new Point(140, 339);
            txtRole.Margin = new Padding(2);
            txtRole.Name = "txtRole";
            txtRole.PasswordChar = '\0';
            txtRole.PlaceholderText = "Role";
            txtRole.SelectedText = "";
            txtRole.ShadowDecoration.Parent = txtRole;
            txtRole.Size = new Size(256, 39);
            txtRole.TabIndex = 77;
            // 
            // AddUser
            // 
            AcceptButton = _btnAdd;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _btnBack;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtGender);
            Controls.Add(txtHPNumber);
            Controls.Add(txtFName);
            Controls.Add(txtEmail);
            Controls.Add(txtLName);
            Controls.Add(txtName);
            Controls.Add(_btnBack);
            Controls.Add(_btnClear);
            Controls.Add(_btnAdd);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(lblEmail);
            Controls.Add(lblUserName);
            Controls.Add(lblId);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "AddUser";
            Text = "AddUser";
            Load += new EventHandler(AddUser_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtGender;
        internal Guna.UI2.WinForms.Guna2TextBox txtHPNumber;
        internal Guna.UI2.WinForms.Guna2TextBox txtFName;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Guna.UI2.WinForms.Guna2TextBox txtLName;
        internal Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button _btnClear;

        internal Guna.UI2.WinForms.Guna2Button btnClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClear != null)
                {
                    _btnClear.Click -= btnClear_Click;
                }

                _btnClear = value;
                if (_btnClear != null)
                {
                    _btnClear.Click += btnClear_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnAdd;

        internal Guna.UI2.WinForms.Guna2Button btnAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd != null)
                {
                    _btnAdd.Click -= btnAdd_Click;
                }

                _btnAdd = value;
                if (_btnAdd != null)
                {
                    _btnAdd.Click += btnAdd_Click;
                }
            }
        }

        internal Label lblConfirmPassword;
        internal Label lblPassword;
        internal Label lblEmail;
        internal Label lblUserName;
        internal Label lblId;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        private Guna.UI2.WinForms.Guna2Button _btnBack;

        internal Guna.UI2.WinForms.Guna2Button btnBack
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnBack;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnBack != null)
                {
                    _btnBack.Click -= Back_Click;
                }

                _btnBack = value;
                if (_btnBack != null)
                {
                    _btnBack.Click += Back_Click;
                }
            }
        }

        internal Label lblRole;
        internal Guna.UI2.WinForms.Guna2TextBox txtRole;
    }
}