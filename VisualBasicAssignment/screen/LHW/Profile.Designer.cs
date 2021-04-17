using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class Profile : Form
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
            _txtReset = new Guna.UI2.WinForms.Guna2Button();
            _txtReset.Click += new EventHandler(txtReset_Click);
            grpBox = new GroupBox();
            txtCPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            txtHPNumber = new Guna.UI2.WinForms.Guna2TextBox();
            txtFName = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtLName = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            _btnClear = new Guna.UI2.WinForms.Guna2Button();
            _btnClear.Click += new EventHandler(btnClear_Click);
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            lblId = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ImageDialog = new OpenFileDialog();
            _Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            _Guna2Button1.Click += new EventHandler(Guna2Button1_Click);
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtReset
            // 
            _txtReset.CheckedState.Parent = _txtReset;
            _txtReset.CustomImages.Parent = _txtReset;
            _txtReset.Font = new Font("Segoe UI", 9.0f);
            _txtReset.ForeColor = Color.White;
            _txtReset.HoverState.Parent = _txtReset;
            _txtReset.Location = new Point(464, 288);
            _txtReset.Name = "_txtReset";
            _txtReset.ShadowDecoration.Parent = _txtReset;
            _txtReset.Size = new Size(129, 45);
            _txtReset.TabIndex = 30;
            _txtReset.Text = "Edit";
            // 
            // grpBox
            // 
            grpBox.Controls.Add(txtCPassword);
            grpBox.Controls.Add(txtPassword);
            grpBox.Controls.Add(txtGender);
            grpBox.Controls.Add(txtHPNumber);
            grpBox.Controls.Add(txtFName);
            grpBox.Controls.Add(txtEmail);
            grpBox.Controls.Add(txtLName);
            grpBox.Controls.Add(txtName);
            grpBox.Controls.Add(_btnClear);
            grpBox.Controls.Add(_txtReset);
            grpBox.Controls.Add(lblConfirmPassword);
            grpBox.Controls.Add(lblPassword);
            grpBox.Controls.Add(lblEmail);
            grpBox.Controls.Add(lblUserName);
            grpBox.Controls.Add(lblId);
            grpBox.Controls.Add(Label4);
            grpBox.Controls.Add(Label3);
            grpBox.Controls.Add(Label2);
            grpBox.Controls.Add(Label1);
            grpBox.Font = new Font("Microsoft Sans Serif", 19.8f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, Conversions.ToByte(0));
            grpBox.Location = new Point(12, 12);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(788, 387);
            grpBox.TabIndex = 37;
            grpBox.TabStop = false;
            grpBox.Text = "Information";
            // 
            // txtCPassword
            // 
            txtCPassword.BackColor = Color.Transparent;
            txtCPassword.BorderRadius = 10;
            txtCPassword.Cursor = Cursors.IBeam;
            txtCPassword.DefaultText = "";
            txtCPassword.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtCPassword.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtCPassword.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtCPassword.DisabledState.Parent = txtCPassword;
            txtCPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtCPassword.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtCPassword.FocusedState.Parent = txtCPassword;
            txtCPassword.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtCPassword.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtCPassword.HoverState.Parent = txtCPassword;
            txtCPassword.Location = new Point(134, 329);
            txtCPassword.Margin = new Padding(2);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.PasswordChar = '*';
            txtCPassword.PlaceholderText = "Confirm Password";
            txtCPassword.SelectedText = "";
            txtCPassword.ShadowDecoration.Parent = txtCPassword;
            txtCPassword.Size = new Size(256, 39);
            txtCPassword.TabIndex = 59;
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
            txtPassword.Location = new Point(134, 274);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.Parent = txtPassword;
            txtPassword.Size = new Size(256, 39);
            txtPassword.TabIndex = 58;
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
            txtGender.Location = new Point(517, 215);
            txtGender.Margin = new Padding(2);
            txtGender.Name = "txtGender";
            txtGender.PasswordChar = '\0';
            txtGender.PlaceholderText = "Gender";
            txtGender.SelectedText = "";
            txtGender.ShadowDecoration.Parent = txtGender;
            txtGender.Size = new Size(256, 39);
            txtGender.TabIndex = 57;
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
            txtHPNumber.Location = new Point(134, 215);
            txtHPNumber.Margin = new Padding(2);
            txtHPNumber.Name = "txtHPNumber";
            txtHPNumber.PasswordChar = '\0';
            txtHPNumber.PlaceholderText = "H/P Number";
            txtHPNumber.SelectedText = "";
            txtHPNumber.ShadowDecoration.Parent = txtHPNumber;
            txtHPNumber.Size = new Size(256, 39);
            txtHPNumber.TabIndex = 57;
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
            txtFName.Location = new Point(517, 161);
            txtFName.Margin = new Padding(2);
            txtFName.Name = "txtFName";
            txtFName.PasswordChar = '\0';
            txtFName.PlaceholderText = "First Name";
            txtFName.SelectedText = "";
            txtFName.ShadowDecoration.Parent = txtFName;
            txtFName.Size = new Size(256, 39);
            txtFName.TabIndex = 56;
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
            txtEmail.Location = new Point(134, 161);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.Parent = txtEmail;
            txtEmail.Size = new Size(256, 39);
            txtEmail.TabIndex = 56;
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
            txtLName.Location = new Point(517, 109);
            txtLName.Margin = new Padding(2);
            txtLName.Name = "txtLName";
            txtLName.PasswordChar = '\0';
            txtLName.PlaceholderText = "Last Name";
            txtLName.SelectedText = "";
            txtLName.ShadowDecoration.Parent = txtLName;
            txtLName.Size = new Size(256, 39);
            txtLName.TabIndex = 55;
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
            txtName.Location = new Point(134, 109);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "User Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.Parent = txtName;
            txtName.Size = new Size(256, 39);
            txtName.TabIndex = 55;
            // 
            // btnClear
            // 
            _btnClear.CheckedState.Parent = _btnClear;
            _btnClear.CustomImages.Parent = _btnClear;
            _btnClear.Font = new Font("Segoe UI", 9.0f);
            _btnClear.ForeColor = Color.White;
            _btnClear.HoverState.Parent = _btnClear;
            _btnClear.Location = new Point(644, 288);
            _btnClear.Name = "_btnClear";
            _btnClear.ShadowDecoration.Parent = _btnClear;
            _btnClear.Size = new Size(129, 45);
            _btnClear.TabIndex = 30;
            _btnClear.Text = "Clear";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblConfirmPassword.Location = new Point(16, 215);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(112, 20);
            lblConfirmPassword.TabIndex = 54;
            lblConfirmPassword.Text = "H/P Number :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblPassword.Location = new Point(67, 161);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 20);
            lblPassword.TabIndex = 54;
            lblPassword.Text = "Email :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblEmail.Location = new Point(35, 274);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 20);
            lblEmail.TabIndex = 54;
            lblEmail.Text = "Password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblUserName.Location = new Point(24, 109);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 20);
            lblUserName.TabIndex = 52;
            lblUserName.Text = "User Name :";
            // 
            // lblId
            // 
            lblId.Font = new Font("Microsoft Sans Serif", 10.2f);
            lblId.Location = new Point(182, 66);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(243, 20);
            lblId.TabIndex = 50;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label4.Location = new Point(430, 215);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(80, 60);
            Label4.TabIndex = 51;
            Label4.Text = "Gender :" + '\r' + '\n' + "(f: female" + '\r' + '\n' + "/m: male)" + '\r' + '\n';
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label3.Location = new Point(408, 161);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(102, 20);
            Label3.TabIndex = 51;
            Label3.Text = "First Name :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label2.Location = new Point(408, 109);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(101, 20);
            Label2.TabIndex = 51;
            Label2.Text = "Last Name :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.2f);
            Label1.Location = new Point(92, 66);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(36, 20);
            Label1.TabIndex = 51;
            Label1.Text = "ID :";
            // 
            // ImageDialog
            // 
            ImageDialog.FileName = "OpenFileDialog1";
            ImageDialog.Multiselect = true;
            // 
            // Guna2Button1
            // 
            _Guna2Button1.CheckedState.Parent = _Guna2Button1;
            _Guna2Button1.CustomImages.Parent = _Guna2Button1;
            _Guna2Button1.Font = new Font("Segoe UI", 9.0f);
            _Guna2Button1.ForeColor = Color.White;
            _Guna2Button1.HoverState.Parent = _Guna2Button1;
            _Guna2Button1.Location = new Point(697, 406);
            _Guna2Button1.Name = "_Guna2Button1";
            _Guna2Button1.ShadowDecoration.Parent = _Guna2Button1;
            _Guna2Button1.Size = new Size(121, 32);
            _Guna2Button1.TabIndex = 60;
            _Guna2Button1.Text = "Report";
            // 
            // Profile
            // 
            AcceptButton = _txtReset;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(830, 450);
            Controls.Add(_Guna2Button1);
            Controls.Add(grpBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileScreen";
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            Load += new EventHandler(ProfileScreen_Load);
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Button _txtReset;

        internal Guna.UI2.WinForms.Guna2Button txtReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtReset != null)
                {
                    _txtReset.Click -= txtReset_Click;
                }

                _txtReset = value;
                if (_txtReset != null)
                {
                    _txtReset.Click += txtReset_Click;
                }
            }
        }

        internal GroupBox grpBox;
        internal Label lblEmail;
        internal Label lblUserName;
        internal Label lblId;
        internal Label Label1;
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

        internal Label lblConfirmPassword;
        internal Label lblPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtCPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtHPNumber;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Guna.UI2.WinForms.Guna2TextBox txtName;
        internal OpenFileDialog ImageDialog;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txtGender;
        internal Guna.UI2.WinForms.Guna2TextBox txtFName;
        internal Guna.UI2.WinForms.Guna2TextBox txtLName;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button1;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click -= Guna2Button1_Click;
                }

                _Guna2Button1 = value;
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click += Guna2Button1_Click;
                }
            }
        }
    }
}