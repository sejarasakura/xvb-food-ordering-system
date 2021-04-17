using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class detail : Form
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
            lblName = new Label();
            lblDesc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pcbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            _btnBack = new Guna.UI2.WinForms.Guna2Button();
            _btnBack.Click += new EventHandler(btnBack_Click);
            lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pcbProduct).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Garamond", 26.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.Location = new Point(35, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 39);
            lblName.TabIndex = 47;
            lblName.Text = "Food";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = false;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Location = new Point(42, 78);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(300, 151);
            lblDesc.TabIndex = 62;
            lblDesc.Text = null;
            // 
            // pcbProduct
            // 
            pcbProduct.Location = new Point(407, 78);
            pcbProduct.Name = "pcbProduct";
            pcbProduct.ShadowDecoration.Parent = pcbProduct;
            pcbProduct.Size = new Size(200, 162);
            pcbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbProduct.TabIndex = 58;
            pcbProduct.TabStop = false;
            // 
            // btnBack
            // 
            _btnBack.CheckedState.Parent = _btnBack;
            _btnBack.CustomImages.Parent = _btnBack;
            _btnBack.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnBack.Font = new Font("Segoe UI", 9.0f);
            _btnBack.ForeColor = Color.White;
            _btnBack.HoverState.Parent = _btnBack;
            _btnBack.Location = new Point(42, 309);
            _btnBack.Margin = new Padding(2);
            _btnBack.Name = "_btnBack";
            _btnBack.ShadowDecoration.Parent = _btnBack;
            _btnBack.Size = new Size(120, 40);
            _btnBack.TabIndex = 60;
            _btnBack.Text = "Back";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = false;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Garamond", 20.0f);
            lblPrice.Location = new Point(42, 269);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(300, 35);
            lblPrice.TabIndex = 63;
            lblPrice.Text = null;
            // 
            // detail
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(lblPrice);
            Controls.Add(lblDesc);
            Controls.Add(_btnBack);
            Controls.Add(pcbProduct);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "detail";
            Text = "detail";
            ((System.ComponentModel.ISupportInitialize)pcbProduct).EndInit();
            Load += new EventHandler(detail_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2PictureBox pcbProduct;
        internal Label lblName;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblDesc;
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
                    _btnBack.Click -= btnBack_Click;
                }

                _btnBack = value;
                if (_btnBack != null)
                {
                    _btnBack.Click += btnBack_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
    }
}