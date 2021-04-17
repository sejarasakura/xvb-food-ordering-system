using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class ForgotPassword : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            _btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            _btnSubmit.Click += new EventHandler(Guna2Button1_Click);
            lblEmail = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblPhone = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            Label4 = new Label();
            Label5 = new Label();
            txtPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(292, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(158, 17);
            Label1.TabIndex = 0;
            Label1.Text = "Recover your Password";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(292, 57);
            Label2.Name = "Label2";
            Label2.Size = new Size(154, 17);
            Label2.TabIndex = 1;
            Label2.Text = "Forgot your Password?";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(212, 95);
            Label3.Name = "Label3";
            Label3.Size = new Size(322, 17);
            Label3.TabIndex = 2;
            Label3.Text = "Enter your the following to receive your password.";
            // 
            // btnSubmit
            // 
            _btnSubmit.CheckedState.Parent = _btnSubmit;
            _btnSubmit.CustomImages.Parent = _btnSubmit;
            _btnSubmit.Font = new Font("Segoe UI", 9.0f);
            _btnSubmit.ForeColor = Color.White;
            _btnSubmit.HoverState.Parent = _btnSubmit;
            _btnSubmit.Location = new Point(295, 393);
            _btnSubmit.Name = "_btnSubmit";
            _btnSubmit.ShadowDecoration.Parent = _btnSubmit;
            _btnSubmit.Size = new Size(180, 45);
            _btnSubmit.TabIndex = 7;
            _btnSubmit.Text = "Submit";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(225, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtEmail.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtEmail.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtEmail.DisabledState.Parent = txtEmail;
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtEmail.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtEmail.FocusedState.Parent = txtEmail;
            txtEmail.Font = new Font("Segoe UI", 9.0f);
            txtEmail.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtEmail.HoverState.Parent = txtEmail;
            txtEmail.Location = new Point(295, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.Parent = txtEmail;
            txtEmail.Size = new Size(200, 36);
            txtEmail.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(164, 183);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 17);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone Number :";
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtUsername.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtUsername.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtUsername.DisabledState.Parent = txtUsername;
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtUsername.Enabled = false;
            txtUsername.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtUsername.FocusedState.Parent = txtUsername;
            txtUsername.Font = new Font("Segoe UI", 9.0f);
            txtUsername.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtUsername.HoverState.Parent = txtUsername;
            txtUsername.Location = new Point(295, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.Parent = txtUsername;
            txtUsername.Size = new Size(200, 36);
            txtUsername.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(188, 260);
            Label4.Name = "Label4";
            Label4.Size = new Size(87, 17);
            Label4.TabIndex = 8;
            Label4.Text = "User Name :";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(198, 321);
            Label5.Name = "Label5";
            Label5.Size = new Size(77, 17);
            Label5.TabIndex = 8;
            Label5.Text = "Password :";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Cursor = Cursors.IBeam;
            txtPhoneNum.DefaultText = "";
            txtPhoneNum.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtPhoneNum.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtPhoneNum.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPhoneNum.DisabledState.Parent = txtPhoneNum;
            txtPhoneNum.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPhoneNum.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPhoneNum.FocusedState.Parent = txtPhoneNum;
            txtPhoneNum.Font = new Font("Segoe UI", 9.0f);
            txtPhoneNum.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPhoneNum.HoverState.Parent = txtPhoneNum;
            txtPhoneNum.Location = new Point(295, 183);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PasswordChar = '\0';
            txtPhoneNum.PlaceholderText = "";
            txtPhoneNum.SelectedText = "";
            txtPhoneNum.ShadowDecoration.Parent = txtPhoneNum;
            txtPhoneNum.Size = new Size(200, 36);
            txtPhoneNum.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtPassword.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtPassword.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPassword.DisabledState.Parent = txtPassword;
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPassword.Enabled = false;
            txtPassword.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPassword.FocusedState.Parent = txtPassword;
            txtPassword.Font = new Font("Segoe UI", 9.0f);
            txtPassword.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPassword.HoverState.Parent = txtPassword;
            txtPassword.Location = new Point(295, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.Parent = txtPassword;
            txtPassword.Size = new Size(200, 36);
            txtPassword.TabIndex = 10;
            // 
            // ForgotPassword
            // 
            AcceptButton = _btnSubmit;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(_btnSubmit);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "ForgotPassword";
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        private Guna.UI2.WinForms.Guna2Button _btnSubmit;

        internal Guna.UI2.WinForms.Guna2Button btnSubmit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSubmit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSubmit != null)
                {
                    _btnSubmit.Click -= Guna2Button1_Click;
                }

                _btnSubmit = value;
                if (_btnSubmit != null)
                {
                    _btnSubmit.Click += Guna2Button1_Click;
                }
            }
        }

        internal Label lblEmail;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Label lblPhone;
        internal Guna.UI2.WinForms.Guna2TextBox txtUsername;
        internal Label Label4;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2TextBox txtPhoneNum;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
    }
}