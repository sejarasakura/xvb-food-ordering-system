using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class Login : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            _txtName = new Guna.UI2.WinForms.Guna2TextBox();
            _txtName.TextChanged += new EventHandler(tbxName_TextChanged);
            _txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            _txtPassword.TextChanged += new EventHandler(txtPassword_TextChanged);
            lblUserName = new Label();
            lblPassword = new Label();
            _btnCancel = new Guna.UI2.WinForms.Guna2Button();
            _btnCancel.Click += new EventHandler(cancleBtnOnclick);
            _btnLogin = new Guna.UI2.WinForms.Guna2Button();
            _btnLogin.Click += new EventHandler(loginBtn_Click);
            Guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            PictureBox1 = new PictureBox();
            err = new ErrorProvider(components);
            _LinkLabel1 = new LinkLabel();
            _LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            _LinkLabel2 = new LinkLabel();
            _LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            _txtName.BackColor = Color.Transparent;
            _txtName.BorderRadius = 10;
            _txtName.Cursor = Cursors.IBeam;
            _txtName.DefaultText = "";
            _txtName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            _txtName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            _txtName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _txtName.DisabledState.Parent = _txtName;
            _txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _txtName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtName.FocusedState.Parent = _txtName;
            _txtName.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtName.HoverState.Parent = _txtName;
            _txtName.Location = new Point(188, 271);
            _txtName.Margin = new Padding(2);
            _txtName.Name = "_txtName";
            _txtName.PasswordChar = '\0';
            _txtName.PlaceholderText = "";
            _txtName.SelectedText = "";
            _txtName.ShadowDecoration.Parent = _txtName;
            _txtName.Size = new Size(465, 51);
            _txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            _txtPassword.BackColor = Color.Transparent;
            _txtPassword.BorderRadius = 10;
            _txtPassword.Cursor = Cursors.IBeam;
            _txtPassword.DefaultText = "";
            _txtPassword.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            _txtPassword.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            _txtPassword.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _txtPassword.DisabledState.Parent = _txtPassword;
            _txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _txtPassword.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtPassword.FocusedState.Parent = _txtPassword;
            _txtPassword.Font = new Font("Segoe UI Semilight", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtPassword.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtPassword.HoverState.Parent = _txtPassword;
            _txtPassword.Location = new Point(188, 346);
            _txtPassword.Margin = new Padding(2);
            _txtPassword.Name = "_txtPassword";
            _txtPassword.PasswordChar = '\0';
            _txtPassword.PlaceholderText = "";
            _txtPassword.SelectedText = "";
            _txtPassword.ShadowDecoration.Parent = _txtPassword;
            _txtPassword.Size = new Size(465, 51);
            _txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblUserName.ForeColor = SystemColors.ControlDarkDark;
            lblUserName.Location = new Point(184, 249);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(249, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username / Registeration Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPassword.ForeColor = SystemColors.ControlDarkDark;
            lblPassword.Location = new Point(184, 324);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // btnCancel
            // 
            _btnCancel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(240)), Conversions.ToInteger(Conversions.ToByte(173)), Conversions.ToInteger(Conversions.ToByte(78)));
            _btnCancel.CheckedState.Parent = _btnCancel;
            _btnCancel.CustomImages.Parent = _btnCancel;
            _btnCancel.DialogResult = DialogResult.Cancel;
            _btnCancel.Font = new Font("Segoe UI", 12.0f);
            _btnCancel.ForeColor = Color.White;
            _btnCancel.HoverState.Parent = _btnCancel;
            _btnCancel.Location = new Point(188, 479);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.ShadowDecoration.Parent = _btnCancel;
            _btnCancel.Size = new Size(207, 62);
            _btnCancel.TabIndex = 3;
            _btnCancel.Text = "Cancel";
            // 
            // btnLogin
            // 
            _btnLogin.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(155)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnLogin.CheckedState.Parent = _btnLogin;
            _btnLogin.CustomImages.Parent = _btnLogin;
            _btnLogin.Font = new Font("Segoe UI", 12.0f);
            _btnLogin.ForeColor = Color.White;
            _btnLogin.HoverState.Parent = _btnLogin;
            _btnLogin.Location = new Point(432, 479);
            _btnLogin.Name = "_btnLogin";
            _btnLogin.ShadowDecoration.Parent = _btnLogin;
            _btnLogin.Size = new Size(207, 62);
            _btnLogin.TabIndex = 4;
            _btnLogin.Text = "Login";
            // 
            // Guna2BorderlessForm1
            // 
            Guna2BorderlessForm1.ContainerControl = this;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Cursor = Cursors.Default;
            PictureBox1.Location = new Point(302, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(220, 220);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // LinkLabel1
            // 
            _LinkLabel1.AutoSize = true;
            _LinkLabel1.Location = new Point(185, 410);
            _LinkLabel1.Name = "_LinkLabel1";
            _LinkLabel1.Size = new Size(122, 17);
            _LinkLabel1.TabIndex = 7;
            _LinkLabel1.TabStop = true;
            _LinkLabel1.Text = "Forgot Password?";
            // 
            // LinkLabel2
            // 
            _LinkLabel2.AutoSize = true;
            _LinkLabel2.Location = new Point(185, 443);
            _LinkLabel2.Name = "_LinkLabel2";
            _LinkLabel2.Size = new Size(125, 17);
            _LinkLabel2.TabIndex = 7;
            _LinkLabel2.TabStop = true;
            _LinkLabel2.Text = "Create an Account";
            // 
            // Login
            // 
            AcceptButton = _btnLogin;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = _btnCancel;
            ClientSize = new Size(830, 566);
            Controls.Add(_LinkLabel2);
            Controls.Add(_LinkLabel1);
            Controls.Add(PictureBox1);
            Controls.Add(_btnLogin);
            Controls.Add(_btnCancel);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(_txtPassword);
            Controls.Add(_txtName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Screen";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            Load += new EventHandler(Page_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtName;

        internal Guna.UI2.WinForms.Guna2TextBox txtName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtName != null)
                {
                    _txtName.TextChanged -= tbxName_TextChanged;
                }

                _txtName = value;
                if (_txtName != null)
                {
                    _txtName.TextChanged += tbxName_TextChanged;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtPassword;

        internal Guna.UI2.WinForms.Guna2TextBox txtPassword
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPassword;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPassword != null)
                {
                    _txtPassword.TextChanged -= txtPassword_TextChanged;
                }

                _txtPassword = value;
                if (_txtPassword != null)
                {
                    _txtPassword.TextChanged += txtPassword_TextChanged;
                }
            }
        }

        internal Label lblUserName;
        internal Label lblPassword;
        private Guna.UI2.WinForms.Guna2Button _btnCancel;

        internal Guna.UI2.WinForms.Guna2Button btnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel != null)
                {
                    _btnCancel.Click -= cancleBtnOnclick;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += cancleBtnOnclick;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnLogin;

        internal Guna.UI2.WinForms.Guna2Button btnLogin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnLogin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnLogin != null)
                {
                    _btnLogin.Click -= loginBtn_Click;
                }

                _btnLogin = value;
                if (_btnLogin != null)
                {
                    _btnLogin.Click += loginBtn_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal Guna.UI2.WinForms.Guna2BorderlessForm Guna2BorderlessForm1;
        internal ErrorProvider err;
        private LinkLabel _LinkLabel1;

        internal LinkLabel LinkLabel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LinkLabel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LinkLabel1 != null)
                {
                    _LinkLabel1.LinkClicked -= LinkLabel1_LinkClicked;
                }

                _LinkLabel1 = value;
                if (_LinkLabel1 != null)
                {
                    _LinkLabel1.LinkClicked += LinkLabel1_LinkClicked;
                }
            }
        }

        private LinkLabel _LinkLabel2;

        internal LinkLabel LinkLabel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LinkLabel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LinkLabel2 != null)
                {
                    _LinkLabel2.LinkClicked -= LinkLabel2_LinkClicked;
                }

                _LinkLabel2 = value;
                if (_LinkLabel2 != null)
                {
                    _LinkLabel2.LinkClicked += LinkLabel2_LinkClicked;
                }
            }
        }
    }
}