using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class Master : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            Panel1 = new Panel();
            Panel7 = new Panel();
            picIcon = new PictureBox();
            Panel6 = new Panel();
            Panel2 = new Panel();
            btnNav = new Guna.UI2.WinForms.Guna2Button();
            Panel4 = new Panel();
            Panel3 = new Panel();
            btnMini = new Guna.UI2.WinForms.Guna2Button();
            _btnClose = new Guna.UI2.WinForms.Guna2Button();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Panel5 = new Panel();
            Label1 = new Label();
            panelMessage = new FlowLayoutPanel();
            Timer1 = new Timer(components);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel1.Controls.Add(Panel7);
            Panel1.Controls.Add(picIcon);
            Panel1.Controls.Add(Panel6);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Left;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(4);
            Panel1.MaximumSize = new Size(227, 738);
            Panel1.MinimumSize = new Size(67, 738);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(227, 738);
            Panel1.TabIndex = 2;
            // 
            // Panel7
            // 
            Panel7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel7.Dock = DockStyle.Top;
            Panel7.Location = new Point(0, 165);
            Panel7.Margin = new Padding(4);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(227, 20);
            Panel7.TabIndex = 14;
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            picIcon.Cursor = Cursors.Default;
            picIcon.Dock = DockStyle.Top;
            picIcon.ErrorImage = null;
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.InitialImage = null;
            picIcon.Location = new Point(0, 55);
            picIcon.Margin = new Padding(4);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(227, 110);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 13;
            picIcon.TabStop = false;
            // 
            // Panel6
            // 
            Panel6.Dock = DockStyle.Top;
            Panel6.Location = new Point(0, 32);
            Panel6.Margin = new Padding(4);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(227, 23);
            Panel6.TabIndex = 8;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel2.Controls.Add(btnNav);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 0);
            Panel2.Margin = new Padding(4);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(227, 32);
            Panel2.TabIndex = 1;
            // 
            // btnNav
            // 
            btnNav.CheckedState.Parent = btnNav;
            btnNav.CustomImages.Parent = btnNav;
            btnNav.Dock = DockStyle.Top;
            btnNav.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            btnNav.Font = new Font("Segoe UI", 9.0f);
            btnNav.ForeColor = Color.White;
            btnNav.HoverState.Parent = btnNav;
            btnNav.Image = (Image)resources.GetObject("btnNav.Image");
            btnNav.Location = new Point(0, 0);
            btnNav.Margin = new Padding(4);
            btnNav.Name = "btnNav";
            btnNav.ShadowDecoration.Parent = btnNav;
            btnNav.Size = new Size(227, 37);
            btnNav.TabIndex = 0;
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
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)));
            Panel3.Controls.Add(btnMini);
            Panel3.Controls.Add(_btnClose);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(227, 0);
            Panel3.Margin = new Padding(4);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1106, 32);
            Panel3.TabIndex = 6;
            // 
            // btnMini
            // 
            btnMini.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(200)), Conversions.ToInteger(Conversions.ToByte(200)), Conversions.ToInteger(Conversions.ToByte(200)));
            btnMini.CheckedState.Parent = btnMini;
            btnMini.CustomImages.Parent = btnMini;
            btnMini.Dock = DockStyle.Right;
            btnMini.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(215)));
            btnMini.Font = new Font("Segoe UI", 9.0f);
            btnMini.ForeColor = Color.White;
            btnMini.HoverState.Parent = btnMini;
            btnMini.Image = (Image)resources.GetObject("btnMini.Image");
            btnMini.ImageSize = new Size(26, 26);
            btnMini.Location = new Point(1029, 0);
            btnMini.Margin = new Padding(4);
            btnMini.Name = "btnMini";
            btnMini.ShadowDecoration.Parent = btnMini;
            btnMini.Size = new Size(40, 32);
            btnMini.TabIndex = 6;
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
            _btnClose.Location = new Point(1069, 0);
            _btnClose.Margin = new Padding(4);
            _btnClose.Name = "_btnClose";
            _btnClose.ShadowDecoration.Parent = _btnClose;
            _btnClose.Size = new Size(37, 32);
            _btnClose.TabIndex = 5;
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
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(Label1);
            Panel5.Controls.Add(panelMessage);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(227, 32);
            Panel5.Margin = new Padding(4);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1106, 152);
            Panel5.TabIndex = 7;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Adobe Gothic Std B", 22.2f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(19, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(358, 48);
            Label1.TabIndex = 1;
            Label1.Text = "Payment Functions";
            // 
            // panelMessage
            // 
            panelMessage.Dock = DockStyle.Right;
            panelMessage.Location = new Point(693, 0);
            panelMessage.Name = "panelMessage";
            panelMessage.Size = new Size(411, 150);
            panelMessage.TabIndex = 0;
            // 
            // Timer1
            // 
            Timer1.Interval = 10;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1333, 738);
            Controls.Add(Panel5);
            Controls.Add(Panel3);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Master";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            Panel2.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
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
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnClose_Click;
                }
            }
        }

        internal Panel Panel3;
        internal Guna.UI2.WinForms.Guna2Button btnMini;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
        internal Panel Panel5;
        internal Guna.UI2.WinForms.Guna2Button btnNav;
        internal Timer Timer1;
        internal Panel Panel7;
        internal Panel Panel4;
        internal PictureBox picIcon;
        internal Panel Panel6;
        internal FlowLayoutPanel panelMessage;
        internal Label Label1;
        internal PaymentInfo PaymentInfo1;
    }
}