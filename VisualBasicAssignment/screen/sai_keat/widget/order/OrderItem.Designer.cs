using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class OrderItem : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            info = new Guna.UI2.WinForms.Guna2HtmlLabel();
            img = new PictureBox();
            _upDownNumbering = new Guna.UI2.WinForms.Guna2NumericUpDown();
            _upDownNumbering.ValueChanged += new EventHandler(upDownNumbering_ValueChanged);
            Label1 = new Label();
            ckb = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_upDownNumbering).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = false;
            title.BackColor = Color.Transparent;
            title.Location = new Point(172, 4);
            title.Name = "title";
            title.Size = new Size(306, 105);
            title.TabIndex = 2;
            // 
            // info
            // 
            info.AutoSize = false;
            info.BackColor = Color.Transparent;
            info.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            info.Location = new Point(484, 13);
            info.Name = "info";
            info.Size = new Size(128, 87);
            info.TabIndex = 3;
            // 
            // img
            // 
            img.Image = (Image)resources.GetObject("img.Image");
            img.Location = new Point(50, 4);
            img.Name = "img";
            img.Size = new Size(116, 105);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.TabIndex = 0;
            img.TabStop = false;
            // 
            // upDownNumbering
            // 
            _upDownNumbering.BackColor = Color.Transparent;
            _upDownNumbering.Cursor = Cursors.IBeam;
            _upDownNumbering.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            _upDownNumbering.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            _upDownNumbering.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _upDownNumbering.DisabledState.Parent = _upDownNumbering;
            _upDownNumbering.DisabledState.UpDownButtonFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(177)), Conversions.ToInteger(Conversions.ToByte(177)), Conversions.ToInteger(Conversions.ToByte(177)));
            _upDownNumbering.DisabledState.UpDownButtonForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(203)), Conversions.ToInteger(Conversions.ToByte(203)), Conversions.ToInteger(Conversions.ToByte(203)));
            _upDownNumbering.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _upDownNumbering.FocusedState.Parent = _upDownNumbering;
            _upDownNumbering.Font = new Font("Segoe UI", 9.0f);
            _upDownNumbering.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(126)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            _upDownNumbering.Location = new Point(651, 36);
            _upDownNumbering.Name = "_upDownNumbering";
            _upDownNumbering.ShadowDecoration.Parent = _upDownNumbering;
            _upDownNumbering.Size = new Size(100, 36);
            _upDownNumbering.TabIndex = 4;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(655, 13);
            Label1.Name = "Label1";
            Label1.Size = new Size(65, 17);
            Label1.TabIndex = 5;
            Label1.Text = "Quantity:";
            // 
            // ckb
            // 
            ckb.AutoSize = true;
            ckb.Location = new Point(10, 10);
            ckb.Name = "ckb";
            ckb.Size = new Size(18, 17);
            ckb.TabIndex = 6;
            ckb.TextAlign = ContentAlignment.MiddleCenter;
            ckb.UseVisualStyleBackColor = true;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ckb);
            Controls.Add(Label1);
            Controls.Add(_upDownNumbering);
            Controls.Add(info);
            Controls.Add(title);
            Controls.Add(img);
            Name = "OrderItem";
            Size = new Size(765, 115);
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ((System.ComponentModel.ISupportInitialize)_upDownNumbering).EndInit();
            Load += new EventHandler(OrderItems_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox img;
        internal Guna.UI2.WinForms.Guna2HtmlLabel title;
        internal Guna.UI2.WinForms.Guna2HtmlLabel info;
        private Guna.UI2.WinForms.Guna2NumericUpDown _upDownNumbering;

        internal Guna.UI2.WinForms.Guna2NumericUpDown upDownNumbering
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _upDownNumbering;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_upDownNumbering != null)
                {
                    _upDownNumbering.ValueChanged -= upDownNumbering_ValueChanged;
                }

                _upDownNumbering = value;
                if (_upDownNumbering != null)
                {
                    _upDownNumbering.ValueChanged += upDownNumbering_ValueChanged;
                }
            }
        }

        internal Label Label1;
        internal CheckBox ckb;
    }
}