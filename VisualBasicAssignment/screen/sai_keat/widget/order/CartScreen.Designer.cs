using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class CartScreen : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
            btnReload = new Guna.UI2.WinForms.Guna2Button();
            pnlPicture = new FlowLayoutPanel();
            _btnPay = new Guna.UI2.WinForms.Guna2Button();
            _btnPay.Click += new EventHandler(btnPay_Click);
            PictureBox1 = new PictureBox();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReload
            // 
            btnReload.CheckedState.Parent = btnReload;
            btnReload.CustomImages.Parent = btnReload;
            btnReload.Font = new Font("Segoe UI", 9.0f);
            btnReload.ForeColor = Color.White;
            btnReload.HoverState.Parent = btnReload;
            btnReload.Location = new Point(804, 517);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.Parent = btnReload;
            btnReload.Size = new Size(133, 26);
            btnReload.TabIndex = 3;
            btnReload.Text = "Reload";
            // 
            // pnlPicture
            // 
            pnlPicture.Location = new Point(177, 12);
            pnlPicture.Margin = new Padding(4);
            pnlPicture.Name = "pnlPicture";
            pnlPicture.Size = new Size(911, 498);
            pnlPicture.TabIndex = 2;
            // 
            // btnPay
            // 
            _btnPay.CheckedState.Parent = _btnPay;
            _btnPay.CustomImages.Parent = _btnPay;
            _btnPay.Font = new Font("Segoe UI", 9.0f);
            _btnPay.ForeColor = Color.White;
            _btnPay.HoverState.Parent = _btnPay;
            _btnPay.Location = new Point(955, 517);
            _btnPay.Name = "_btnPay";
            _btnPay.ShadowDecoration.Parent = _btnPay;
            _btnPay.Size = new Size(133, 26);
            _btnPay.TabIndex = 4;
            _btnPay.Text = "Paynow";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.cart;
            PictureBox1.Location = new Point(3, 70);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(167, 154);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 5;
            PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 22.2f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(4, 12);
            Label1.Name = "Label1";
            Label1.Size = new Size(96, 44);
            Label1.TabIndex = 6;
            Label1.Text = "Cart";
            // 
            // CartScreen
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Controls.Add(_btnPay);
            Controls.Add(btnReload);
            Controls.Add(pnlPicture);
            Name = "CartScreen";
            Size = new Size(1100, 551);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(CartScreen_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2Button btnReload;
        internal FlowLayoutPanel pnlPicture;
        private Guna.UI2.WinForms.Guna2Button _btnPay;

        internal Guna.UI2.WinForms.Guna2Button btnPay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPay != null)
                {
                    _btnPay.Click -= btnPay_Click;
                }

                _btnPay = value;
                if (_btnPay != null)
                {
                    _btnPay.Click += btnPay_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal Label Label1;
    }
}