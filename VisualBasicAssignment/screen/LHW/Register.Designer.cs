using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class Register : Form
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
            components = new System.ComponentModel.Container();
            GroupBox1 = new GroupBox();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCustId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _btnCreate = new Guna.UI2.WinForms.Guna2Button();
            _btnCreate.Click += new EventHandler(btnCreate_Click);
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            err = new ErrorProvider(components);
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.White;
            GroupBox1.Controls.Add(Guna2HtmlLabel1);
            GroupBox1.Controls.Add(lblCustId);
            GroupBox1.Controls.Add(_btnCreate);
            GroupBox1.Controls.Add(txtConfirmPassword);
            GroupBox1.Controls.Add(txtPassword);
            GroupBox1.Controls.Add(txtEmail);
            GroupBox1.Controls.Add(txtUserName);
            GroupBox1.Font = new Font("Lucida Console", 15.75f);
            GroupBox1.Location = new Point(16, 15);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(794, 407);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Registration";
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.AutoSize = false;
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Segoe UI Semilight", 12.0f);
            Guna2HtmlLabel1.Location = new Point(149, 52);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(161, 43);
            Guna2HtmlLabel1.TabIndex = 6;
            Guna2HtmlLabel1.Text = "Customer Id:";
            // 
            // lblCustId
            // 
            lblCustId.AutoSize = false;
            lblCustId.BackColor = Color.Transparent;
            lblCustId.Font = new Font("Segoe UI Semilight", 12.0f);
            lblCustId.Location = new Point(316, 52);
            lblCustId.Name = "lblCustId";
            lblCustId.Size = new Size(269, 43);
            lblCustId.TabIndex = 6;
            lblCustId.Text = null;
            // 
            // btnCreate
            // 
            _btnCreate.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(155)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnCreate.CheckedState.Parent = _btnCreate;
            _btnCreate.CustomImages.Parent = _btnCreate;
            _btnCreate.Font = new Font("Segoe UI", 12.0f);
            _btnCreate.ForeColor = Color.White;
            _btnCreate.HoverState.Parent = _btnCreate;
            _btnCreate.Location = new Point(283, 338);
            _btnCreate.Name = "_btnCreate";
            _btnCreate.ShadowDecoration.Parent = _btnCreate;
            _btnCreate.Size = new Size(207, 62);
            _btnCreate.TabIndex = 5;
            _btnCreate.Text = "Create Account";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.Transparent;
            txtConfirmPassword.BorderRadius = 10;
            txtConfirmPassword.Cursor = Cursors.IBeam;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtConfirmPassword.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtConfirmPassword.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtConfirmPassword.DisabledState.Parent = txtConfirmPassword;
            txtConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtConfirmPassword.FocusedState.Parent = txtConfirmPassword;
            txtConfirmPassword.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtConfirmPassword.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtConfirmPassword.HoverState.Parent = txtConfirmPassword;
            txtConfirmPassword.Location = new Point(149, 282);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.Parent = txtConfirmPassword;
            txtConfirmPassword.Size = new Size(465, 51);
            txtConfirmPassword.TabIndex = 4;
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
            txtPassword.Location = new Point(149, 227);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.Parent = txtPassword;
            txtPassword.Size = new Size(465, 51);
            txtPassword.TabIndex = 3;
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
            txtEmail.Location = new Point(149, 172);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.Parent = txtEmail;
            txtEmail.Size = new Size(465, 51);
            txtEmail.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Transparent;
            txtUserName.BorderRadius = 10;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtUserName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtUserName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtUserName.DisabledState.Parent = txtUserName;
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtUserName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtUserName.FocusedState.Parent = txtUserName;
            txtUserName.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtUserName.HoverState.Parent = txtUserName;
            txtUserName.Location = new Point(149, 117);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "User Name";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.Parent = txtUserName;
            txtUserName.Size = new Size(465, 51);
            txtUserName.TabIndex = 1;
            // 
            // err
            // 
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            err.ContainerControl = this;
            // 
            // Register
            // 
            AcceptButton = _btnCreate;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(830, 450);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            Load += new EventHandler(Register_Load);
            ResumeLayout(false);
        }

        internal GroupBox GroupBox1;
        internal Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button _btnCreate;

        internal Guna.UI2.WinForms.Guna2Button btnCreate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCreate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCreate != null)
                {
                    _btnCreate.Click -= btnCreate_Click;
                }

                _btnCreate = value;
                if (_btnCreate != null)
                {
                    _btnCreate.Click += btnCreate_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Guna.UI2.WinForms.Guna2AnimateWindow Guna2AnimateWindow1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblCustId;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal ErrorProvider err;
    }
}