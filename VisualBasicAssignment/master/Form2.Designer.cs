using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class Form2 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && component is object)
                {
                    component.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer component;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Panel1 = new Panel();
            Panel7 = new Panel();
            Panel6 = new Panel();
            Panel2 = new Panel();
            Panel3 = new Panel();
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Panel5 = new Panel();
            Label2 = new Label();
            Label1 = new Label();
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(Timer1_Tick);
            Panel4 = new Panel();
            PictureBox1 = new PictureBox();
            _btnMini = new Guna.UI2.WinForms.Guna2Button();
            _btnMini.MouseHover += new EventHandler(btnMini_MouseHover);
            _btnMini.MouseLeave += new EventHandler(btnMini_MouseLeave);
            _btnClose = new Guna.UI2.WinForms.Guna2Button();
            _btnClose.Click += new EventHandler(btnClose_Click);
            _btnClose.MouseHover += new EventHandler(btnClose_MouseHover);
            _btnClose.MouseLeave += new EventHandler(btnClose_MouseLeave);
            _btnOrder = new Guna.UI2.WinForms.Guna2Button();
            _btnOrder.Click += new EventHandler(btnOrder_Click);
            _btnAddfood = new Guna.UI2.WinForms.Guna2Button();
            _btnAddfood.Click += new EventHandler(btnAddFood_Click);
            _btnMenu = new Guna.UI2.WinForms.Guna2Button();
            _btnMenu.Click += new EventHandler(btnMenu_Click);
            _btnProfile = new Guna.UI2.WinForms.Guna2Button();
            _btnProfile.Click += new EventHandler(btnProfile_Click);
            _picIcon = new PictureBox();
            _picIcon.MouseHover += new EventHandler(picIcon_MouseHover);
            _picIcon.MouseLeave += new EventHandler(picIcon_MouseLeave);
            _btnNav = new Guna.UI2.WinForms.Guna2Button();
            _btnNav.Click += new EventHandler(btnNav_Click);
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_picIcon).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel1.Controls.Add(_btnOrder);
            Panel1.Controls.Add(_btnAddfood);
            Panel1.Controls.Add(_btnMenu);
            Panel1.Controls.Add(_btnProfile);
            Panel1.Controls.Add(Panel7);
            Panel1.Controls.Add(_picIcon);
            Panel1.Controls.Add(Panel6);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Left;
            Panel1.Location = new Point(0, 0);
            Panel1.MaximumSize = new Size(170, 600);
            Panel1.MinimumSize = new Size(50, 600);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(170, 600);
            Panel1.TabIndex = 2;
            // 
            // Panel7
            // 
            Panel7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel7.Dock = DockStyle.Top;
            Panel7.Location = new Point(0, 134);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(170, 16);
            Panel7.TabIndex = 14;
            // 
            // Panel6
            // 
            Panel6.Dock = DockStyle.Top;
            Panel6.Location = new Point(0, 26);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(170, 19);
            Panel6.TabIndex = 8;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel2.Controls.Add(_btnNav);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(170, 26);
            Panel2.TabIndex = 1;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)));
            Panel3.Controls.Add(_btnMini);
            Panel3.Controls.Add(_btnClose);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(170, 0);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(830, 26);
            Panel3.TabIndex = 6;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.ContainerControl = this;
            Guna2DragControl1.TargetControl = Panel3;
            // 
            // Guna2DragControl2
            // 
            Guna2DragControl2.ContainerControl = this;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(Label2);
            Panel5.Controls.Add(Label1);
            Panel5.Controls.Add(PictureBox1);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(170, 26);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(830, 124);
            Panel5.TabIndex = 7;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(186, 18);
            Label2.Name = "Label2";
            Label2.Size = new Size(101, 19);
            Label2.TabIndex = 3;
            Label2.Text = "UserName 123";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(186, 75);
            Label1.Name = "Label1";
            Label1.Size = new Size(256, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Hi This is TarUc food Ordering system";
            // 
            // Timer1
            // 
            _Timer1.Interval = 10;
            // 
            // Panel4
            // 
            Panel4.BackColor = SystemColors.Window;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(170, 150);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(830, 450);
            Panel4.TabIndex = 8;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            PictureBox1.Image = My.Resources.Resources.default_user;
            PictureBox1.Location = new Point(51, 18);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(90, 89);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // btnMini
            // 
            _btnMini.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(200)), Conversions.ToInteger(Conversions.ToByte(200)), Conversions.ToInteger(Conversions.ToByte(200)));
            _btnMini.CheckedState.Parent = _btnMini;
            _btnMini.CustomImages.Parent = _btnMini;
            _btnMini.Dock = DockStyle.Right;
            _btnMini.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)));
            _btnMini.Font = new Font("Segoe UI", 9.0f);
            _btnMini.ForeColor = Color.White;
            _btnMini.HoverState.Parent = _btnMini;
            _btnMini.Image = (Image)resources.GetObject("btnMini.Image");
            _btnMini.ImageSize = new Size(26, 26);
            _btnMini.Location = new Point(772, 0);
            _btnMini.Name = "_btnMini";
            _btnMini.ShadowDecoration.Parent = _btnMini;
            _btnMini.Size = new Size(30, 26);
            _btnMini.TabIndex = 6;
            // 
            // btnClose
            // 
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(52)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(219)));
            _btnClose.CheckedState.Parent = _btnClose;
            _btnClose.CustomImages.Parent = _btnClose;
            _btnClose.Dock = DockStyle.Right;
            _btnClose.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)));
            _btnClose.Font = new Font("Segoe UI", 9.0f);
            _btnClose.ForeColor = Color.White;
            _btnClose.HoverState.Parent = _btnClose;
            _btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            _btnClose.ImageSize = new Size(26, 26);
            _btnClose.Location = new Point(802, 0);
            _btnClose.Name = "_btnClose";
            _btnClose.ShadowDecoration.Parent = _btnClose;
            _btnClose.Size = new Size(28, 26);
            _btnClose.TabIndex = 5;
            // 
            // btnOrder
            // 
            _btnOrder.CheckedState.Parent = _btnOrder;
            _btnOrder.CustomImages.Parent = _btnOrder;
            _btnOrder.Dock = DockStyle.Top;
            _btnOrder.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnOrder.Font = new Font("Segoe UI", 9.0f);
            _btnOrder.ForeColor = Color.White;
            _btnOrder.HoverState.Parent = _btnOrder;
            _btnOrder.Image = My.Resources.Resources.payment;
            _btnOrder.Location = new Point(0, 300);
            _btnOrder.Name = "_btnOrder";
            _btnOrder.ShadowDecoration.Parent = _btnOrder;
            _btnOrder.Size = new Size(170, 50);
            _btnOrder.TabIndex = 18;
            _btnOrder.Text = "ORDER";
            _btnOrder.TextFormatNoPrefix = true;
            // 
            // btnAddfood
            // 
            _btnAddfood.CheckedState.Parent = _btnAddfood;
            _btnAddfood.CustomImages.Parent = _btnAddfood;
            _btnAddfood.Dock = DockStyle.Top;
            _btnAddfood.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnAddfood.Font = new Font("Segoe UI", 9.0f);
            _btnAddfood.ForeColor = Color.White;
            _btnAddfood.HoverState.Parent = _btnAddfood;
            _btnAddfood.Image = My.Resources.Resources.icons8_noodles_52;
            _btnAddfood.Location = new Point(0, 250);
            _btnAddfood.Name = "_btnAddfood";
            _btnAddfood.ShadowDecoration.Parent = _btnAddfood;
            _btnAddfood.Size = new Size(170, 50);
            _btnAddfood.TabIndex = 17;
            _btnAddfood.Text = "ADD FOOD";
            _btnAddfood.TextFormatNoPrefix = true;
            // 
            // btnMenu
            // 
            _btnMenu.CheckedState.Parent = _btnMenu;
            _btnMenu.CustomImages.Parent = _btnMenu;
            _btnMenu.Dock = DockStyle.Top;
            _btnMenu.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnMenu.Font = new Font("Segoe UI", 9.0f);
            _btnMenu.ForeColor = Color.White;
            _btnMenu.HoverState.Parent = _btnMenu;
            _btnMenu.Image = My.Resources.Resources.menu;
            _btnMenu.Location = new Point(0, 200);
            _btnMenu.Name = "_btnMenu";
            _btnMenu.ShadowDecoration.Parent = _btnMenu;
            _btnMenu.Size = new Size(170, 50);
            _btnMenu.TabIndex = 16;
            _btnMenu.Text = "MENU";
            _btnMenu.TextFormatNoPrefix = true;
            // 
            // btnProfile
            // 
            _btnProfile.CheckedState.Parent = _btnProfile;
            _btnProfile.CustomImages.Parent = _btnProfile;
            _btnProfile.Dock = DockStyle.Top;
            _btnProfile.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnProfile.Font = new Font("Segoe UI", 9.0f);
            _btnProfile.ForeColor = Color.White;
            _btnProfile.HoverState.Parent = _btnProfile;
            _btnProfile.Image = My.Resources.Resources.profile;
            _btnProfile.Location = new Point(0, 150);
            _btnProfile.Name = "_btnProfile";
            _btnProfile.ShadowDecoration.Parent = _btnProfile;
            _btnProfile.Size = new Size(170, 50);
            _btnProfile.TabIndex = 15;
            _btnProfile.Text = "PROFILE";
            _btnProfile.TextFormatNoPrefix = true;
            // 
            // picIcon
            // 
            _picIcon.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            _picIcon.Cursor = Cursors.Default;
            _picIcon.Dock = DockStyle.Top;
            _picIcon.ErrorImage = null;
            _picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            _picIcon.InitialImage = null;
            _picIcon.Location = new Point(0, 45);
            _picIcon.Name = "_picIcon";
            _picIcon.Size = new Size(170, 89);
            _picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            _picIcon.TabIndex = 13;
            _picIcon.TabStop = false;
            // 
            // btnNav
            // 
            _btnNav.CheckedState.Parent = _btnNav;
            _btnNav.CustomImages.Parent = _btnNav;
            _btnNav.Dock = DockStyle.Top;
            _btnNav.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnNav.Font = new Font("Segoe UI", 9.0f);
            _btnNav.ForeColor = Color.White;
            _btnNav.HoverState.Parent = _btnNav;
            _btnNav.Image = My.Resources.Resources.nav;
            _btnNav.Location = new Point(0, 0);
            _btnNav.Name = "_btnNav";
            _btnNav.ShadowDecoration.Parent = _btnNav;
            _btnNav.Size = new Size(170, 30);
            _btnNav.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(Panel4);
            Controls.Add(Panel5);
            Controls.Add(Panel3);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_picIcon).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
        }

        internal Panel Panel1;
        internal Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button _btnClose;

        internal Guna.UI2.WinForms.Guna2Button btnClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClose != null)
                {
                    _btnClose.Click -= btnClose_Click;
                    _btnClose.MouseHover -= btnClose_MouseHover;
                    _btnClose.MouseLeave -= btnClose_MouseLeave;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnClose_Click;
                    _btnClose.MouseHover += btnClose_MouseHover;
                    _btnClose.MouseLeave += btnClose_MouseLeave;
                }
            }
        }

        internal Panel Panel3;
        private Guna.UI2.WinForms.Guna2Button _btnMini;

        internal Guna.UI2.WinForms.Guna2Button btnMini
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMini;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMini != null)
                {
                    _btnMini.MouseHover -= btnMini_MouseHover;
                    _btnMini.MouseLeave -= btnMini_MouseLeave;
                }

                _btnMini = value;
                if (_btnMini != null)
                {
                    _btnMini.MouseHover += btnMini_MouseHover;
                    _btnMini.MouseLeave += btnMini_MouseLeave;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
        internal Panel Panel5;
        private Guna.UI2.WinForms.Guna2Button _btnNav;

        internal Guna.UI2.WinForms.Guna2Button btnNav
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNav;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNav != null)
                {
                    _btnNav.Click -= btnNav_Click;
                }

                _btnNav = value;
                if (_btnNav != null)
                {
                    _btnNav.Click += btnNav_Click;
                }
            }
        }

        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnOrder;

        internal Guna.UI2.WinForms.Guna2Button btnOrder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOrder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOrder != null)
                {
                    _btnOrder.Click -= btnOrder_Click;
                }

                _btnOrder = value;
                if (_btnOrder != null)
                {
                    _btnOrder.Click += btnOrder_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnAddfood;

        internal Guna.UI2.WinForms.Guna2Button btnAddfood
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddfood;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddfood != null)
                {
                    _btnAddfood.Click -= btnAddFood_Click;
                }

                _btnAddfood = value;
                if (_btnAddfood != null)
                {
                    _btnAddfood.Click += btnAddFood_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnMenu;

        internal Guna.UI2.WinForms.Guna2Button btnMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMenu != null)
                {
                    _btnMenu.Click -= btnMenu_Click;
                }

                _btnMenu = value;
                if (_btnMenu != null)
                {
                    _btnMenu.Click += btnMenu_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnProfile;

        internal Guna.UI2.WinForms.Guna2Button btnProfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnProfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnProfile != null)
                {
                    _btnProfile.Click -= btnProfile_Click;
                }

                _btnProfile = value;
                if (_btnProfile != null)
                {
                    _btnProfile.Click += btnProfile_Click;
                }
            }
        }

        internal Panel Panel7;
        private PictureBox _picIcon;

        internal PictureBox picIcon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _picIcon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_picIcon != null)
                {
                    _picIcon.MouseHover -= picIcon_MouseHover;
                    _picIcon.MouseLeave -= picIcon_MouseLeave;
                }

                _picIcon = value;
                if (_picIcon != null)
                {
                    _picIcon.MouseHover += picIcon_MouseHover;
                    _picIcon.MouseLeave += picIcon_MouseLeave;
                }
            }
        }

        internal Panel Panel6;
        internal Panel Panel4;
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        private System.ComponentModel.IContainer components;
    }
}