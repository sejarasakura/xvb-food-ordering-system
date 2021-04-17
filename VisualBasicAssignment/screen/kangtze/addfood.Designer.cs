using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class addfood : Form
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
            label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            Label6 = new Label();
            _btnUpload = new Guna.UI2.WinForms.Guna2Button();
            _btnUpload.Click += new EventHandler(btnUpload_Click);
            ofdImage = new OpenFileDialog();
            _btnCreate = new Guna.UI2.WinForms.Guna2Button();
            _btnCreate.Click += new EventHandler(btnCreate_Click);
            _btnCancel = new Guna.UI2.WinForms.Guna2Button();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            pcbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 26.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 39);
            label1.TabIndex = 0;
            label1.Text = "Add Food";
            // 
            // Label2
            // 
            Label2.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(27, 76);
            Label2.Name = "Label2";
            Label2.Size = new Size(150, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Food Name :";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(27, 123);
            Label3.Name = "Label3";
            Label3.Size = new Size(150, 17);
            Label3.TabIndex = 2;
            Label3.Text = "Food Description :";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(27, 164);
            Label4.Name = "Label4";
            Label4.Size = new Size(150, 20);
            Label4.TabIndex = 3;
            Label4.Text = "Food Price :";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(27, 209);
            Label5.Name = "Label5";
            Label5.Size = new Size(150, 20);
            Label5.TabIndex = 4;
            Label5.Text = "Food Category :";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtName.DisabledState.Parent = txtName;
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtName.FocusedState.Parent = txtName;
            txtName.Font = new Font("Segoe UI", 9.0f);
            txtName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtName.HoverState.Parent = txtName;
            txtName.Location = new Point(183, 67);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.Parent = txtName;
            txtName.Size = new Size(200, 29);
            txtName.TabIndex = 5;
            // 
            // txtDesc
            // 
            txtDesc.Cursor = Cursors.IBeam;
            txtDesc.DefaultText = "";
            txtDesc.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtDesc.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtDesc.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtDesc.DisabledState.Parent = txtDesc;
            txtDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtDesc.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtDesc.FocusedState.Parent = txtDesc;
            txtDesc.Font = new Font("Segoe UI", 9.0f);
            txtDesc.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtDesc.HoverState.Parent = txtDesc;
            txtDesc.Location = new Point(183, 111);
            txtDesc.Name = "txtDesc";
            txtDesc.PasswordChar = '\0';
            txtDesc.PlaceholderText = "";
            txtDesc.SelectedText = "";
            txtDesc.ShadowDecoration.Parent = txtDesc;
            txtDesc.Size = new Size(200, 29);
            txtDesc.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txtPrice.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txtPrice.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPrice.DisabledState.Parent = txtPrice;
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txtPrice.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPrice.FocusedState.Parent = txtPrice;
            txtPrice.Font = new Font("Segoe UI", 9.0f);
            txtPrice.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtPrice.HoverState.Parent = txtPrice;
            txtPrice.Location = new Point(183, 155);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.Parent = txtPrice;
            txtPrice.Size = new Size(200, 29);
            txtPrice.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Transparent;
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FocusedColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbCategory.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbCategory.FocusedState.Parent = cmbCategory;
            cmbCategory.Font = new Font("Segoe UI", 10.0f);
            cmbCategory.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(68)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(112)));
            cmbCategory.HoverState.Parent = cmbCategory;
            cmbCategory.ItemHeight = 30;
            cmbCategory.ItemsAppearance.Parent = cmbCategory;
            cmbCategory.Location = new Point(183, 193);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.ShadowDecoration.Parent = cmbCategory;
            cmbCategory.Size = new Size(200, 36);
            cmbCategory.TabIndex = 9;
            // 
            // Label6
            // 
            Label6.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(27, 252);
            Label6.Name = "Label6";
            Label6.Size = new Size(150, 20);
            Label6.TabIndex = 10;
            Label6.Text = "Food Image :";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpload
            // 
            _btnUpload.CheckedState.Parent = _btnUpload;
            _btnUpload.CustomImages.Parent = _btnUpload;
            _btnUpload.Font = new Font("Segoe UI", 9.0f);
            _btnUpload.ForeColor = Color.White;
            _btnUpload.HoverState.Parent = _btnUpload;
            _btnUpload.Location = new Point(183, 242);
            _btnUpload.Margin = new Padding(2);
            _btnUpload.Name = "_btnUpload";
            _btnUpload.ShadowDecoration.Parent = _btnUpload;
            _btnUpload.Size = new Size(115, 30);
            _btnUpload.TabIndex = 31;
            _btnUpload.Text = "Upload Image";
            // 
            // ofdImage
            // 
            ofdImage.FileName = "OpenFileDialog1";
            // 
            // btnCreate
            // 
            _btnCreate.CheckedState.Parent = _btnCreate;
            _btnCreate.CustomImages.Parent = _btnCreate;
            _btnCreate.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnCreate.Font = new Font("Segoe UI", 9.0f);
            _btnCreate.ForeColor = Color.White;
            _btnCreate.HoverState.Parent = _btnCreate;
            _btnCreate.Location = new Point(57, 330);
            _btnCreate.Margin = new Padding(2);
            _btnCreate.Name = "_btnCreate";
            _btnCreate.ShadowDecoration.Parent = _btnCreate;
            _btnCreate.Size = new Size(120, 40);
            _btnCreate.TabIndex = 33;
            _btnCreate.Text = "Create Food";
            // 
            // btnCancel
            // 
            _btnCancel.CheckedState.Parent = _btnCancel;
            _btnCancel.CustomImages.Parent = _btnCancel;
            _btnCancel.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(3)), Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(205)));
            _btnCancel.Font = new Font("Segoe UI", 9.0f);
            _btnCancel.ForeColor = Color.White;
            _btnCancel.HoverState.Parent = _btnCancel;
            _btnCancel.Location = new Point(201, 330);
            _btnCancel.Margin = new Padding(2);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.ShadowDecoration.Parent = _btnCancel;
            _btnCancel.Size = new Size(120, 40);
            _btnCancel.TabIndex = 34;
            _btnCancel.Text = "Cancel";
            // 
            // pcbProduct
            // 
            pcbProduct.Location = new Point(443, 67);
            pcbProduct.Name = "pcbProduct";
            pcbProduct.ShadowDecoration.Parent = pcbProduct;
            pcbProduct.Size = new Size(300, 200);
            pcbProduct.TabIndex = 32;
            pcbProduct.TabStop = false;
            // 
            // addfood
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_btnCancel);
            Controls.Add(_btnCreate);
            Controls.Add(pcbProduct);
            Controls.Add(_btnUpload);
            Controls.Add(Label6);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addfood";
            ShowInTaskbar = false;
            Text = "addfood";
            ((System.ComponentModel.ISupportInitialize)pcbProduct).EndInit();
            Load += new EventHandler(Page_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label label1;
        internal Label Label3;
        public Label Label2;
        internal Label Label4;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2TextBox txtName;
        internal Guna.UI2.WinForms.Guna2TextBox txtDesc;
        internal Guna.UI2.WinForms.Guna2TextBox txtPrice;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        internal Label Label6;
        private Guna.UI2.WinForms.Guna2Button _btnUpload;

        internal Guna.UI2.WinForms.Guna2Button btnUpload
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUpload;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUpload != null)
                {
                    _btnUpload.Click -= btnUpload_Click;
                }

                _btnUpload = value;
                if (_btnUpload != null)
                {
                    _btnUpload.Click += btnUpload_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2PictureBox pcbProduct;
        internal OpenFileDialog ofdImage;
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
                    _btnCancel.Click -= btnCancel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                }
            }
        }
    }
}