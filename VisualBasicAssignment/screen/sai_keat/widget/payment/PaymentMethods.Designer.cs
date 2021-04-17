using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class PaymentMethods : MasterWidgetItem
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
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
            FoodTableAdapter1 = new FoodShopDataSetTableAdapters.FoodTableAdapter();
            _Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            _Guna2Button3.Click += new EventHandler(Guna2Button3_Click);
            Label5 = new Label();
            txbCardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            Label3 = new Label();
            txbExp = new Guna.UI2.WinForms.Guna2TextBox();
            Label2 = new Label();
            txbName = new Guna.UI2.WinForms.Guna2TextBox();
            Label1 = new Label();
            txbCCV = new Guna.UI2.WinForms.Guna2TextBox();
            _radMaster = new Guna.UI2.WinForms.Guna2RadioButton();
            _radMaster.CheckedChanged += new EventHandler(radMaster_CheckedChanged);
            _radVisa = new Guna.UI2.WinForms.Guna2RadioButton();
            _radVisa.CheckedChanged += new EventHandler(radVisa_CheckedChanged);
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // FoodTableAdapter1
            // 
            FoodTableAdapter1.ClearBeforeFill = true;
            // 
            // Guna2Button3
            // 
            _Guna2Button3.BorderRadius = 7;
            _Guna2Button3.CheckedState.Parent = _Guna2Button3;
            _Guna2Button3.CustomImages.Parent = _Guna2Button3;
            _Guna2Button3.FillColor = Color.MediumSeaGreen;
            _Guna2Button3.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Guna2Button3.ForeColor = Color.White;
            _Guna2Button3.HoverState.Parent = _Guna2Button3;
            _Guna2Button3.Location = new Point(754, 449);
            _Guna2Button3.Name = "_Guna2Button3";
            _Guna2Button3.ShadowDecoration.Parent = _Guna2Button3;
            _Guna2Button3.Size = new Size(235, 58);
            _Guna2Button3.TabIndex = 2;
            _Guna2Button3.Text = "Complete Payment";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(164, 137);
            Label5.Name = "Label5";
            Label5.Size = new Size(164, 29);
            Label5.TabIndex = 19;
            Label5.Text = "Card Number:";
            // 
            // txbCardNumber
            // 
            txbCardNumber.BorderRadius = 5;
            txbCardNumber.Cursor = Cursors.IBeam;
            txbCardNumber.DefaultText = "";
            txbCardNumber.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbCardNumber.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbCardNumber.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCardNumber.DisabledState.Parent = txbCardNumber;
            txbCardNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCardNumber.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCardNumber.FocusedState.Parent = txbCardNumber;
            txbCardNumber.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txbCardNumber.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCardNumber.HoverState.Parent = txbCardNumber;
            txbCardNumber.Location = new Point(389, 134);
            txbCardNumber.Margin = new Padding(5, 4, 5, 4);
            txbCardNumber.Name = "txbCardNumber";
            txbCardNumber.PasswordChar = '\0';
            txbCardNumber.PlaceholderText = "(Optional)";
            txbCardNumber.SelectedText = "";
            txbCardNumber.ShadowDecoration.Parent = txbCardNumber;
            txbCardNumber.Size = new Size(600, 50);
            txbCardNumber.TabIndex = 18;
            txbCardNumber.Tag = "";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(164, 229);
            Label3.Name = "Label3";
            Label3.Size = new Size(54, 29);
            Label3.TabIndex = 17;
            Label3.Text = "Exp";
            // 
            // txbExp
            // 
            txbExp.BorderRadius = 5;
            txbExp.Cursor = Cursors.IBeam;
            txbExp.DefaultText = "";
            txbExp.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbExp.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbExp.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbExp.DisabledState.Parent = txbExp;
            txbExp.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbExp.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbExp.FocusedState.Parent = txbExp;
            txbExp.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txbExp.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbExp.HoverState.Parent = txbExp;
            txbExp.Location = new Point(169, 279);
            txbExp.Margin = new Padding(5, 4, 5, 4);
            txbExp.Name = "txbExp";
            txbExp.PasswordChar = '\0';
            txbExp.PlaceholderText = "none";
            txbExp.SelectedText = "";
            txbExp.ShadowDecoration.Parent = txbExp;
            txbExp.Size = new Size(381, 50);
            txbExp.TabIndex = 16;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(164, 55);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 29);
            Label2.TabIndex = 15;
            Label2.Text = "Name: ";
            // 
            // txbName
            // 
            txbName.BorderRadius = 5;
            txbName.Cursor = Cursors.IBeam;
            txbName.DefaultText = "";
            txbName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbName.DisabledState.Parent = txbName;
            txbName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbName.FocusedState.Parent = txbName;
            txbName.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txbName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbName.HoverState.Parent = txbName;
            txbName.Location = new Point(389, 52);
            txbName.Margin = new Padding(5, 4, 5, 4);
            txbName.Name = "txbName";
            txbName.PasswordChar = '\0';
            txbName.PlaceholderText = "Full name";
            txbName.SelectedText = "";
            txbName.ShadowDecoration.Parent = txbName;
            txbName.Size = new Size(600, 50);
            txbName.TabIndex = 14;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(593, 229);
            Label1.Name = "Label1";
            Label1.Size = new Size(62, 29);
            Label1.TabIndex = 21;
            Label1.Text = "CCV";
            // 
            // txbCCV
            // 
            txbCCV.BorderRadius = 5;
            txbCCV.Cursor = Cursors.IBeam;
            txbCCV.DefaultText = "";
            txbCCV.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbCCV.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbCCV.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCCV.DisabledState.Parent = txbCCV;
            txbCCV.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCCV.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCCV.FocusedState.Parent = txbCCV;
            txbCCV.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txbCCV.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCCV.HoverState.Parent = txbCCV;
            txbCCV.Location = new Point(598, 279);
            txbCCV.Margin = new Padding(5, 4, 5, 4);
            txbCCV.Name = "txbCCV";
            txbCCV.PasswordChar = '\0';
            txbCCV.PlaceholderText = "none";
            txbCCV.SelectedText = "";
            txbCCV.ShadowDecoration.Parent = txbCCV;
            txbCCV.Size = new Size(391, 50);
            txbCCV.TabIndex = 20;
            // 
            // radMaster
            // 
            _radMaster.AutoSize = true;
            _radMaster.CheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _radMaster.CheckedState.BorderThickness = 0;
            _radMaster.CheckedState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _radMaster.CheckedState.InnerColor = Color.White;
            _radMaster.CheckedState.InnerOffset = -4;
            _radMaster.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _radMaster.Location = new Point(170, 367);
            _radMaster.Name = "_radMaster";
            _radMaster.Size = new Size(154, 33);
            _radMaster.TabIndex = 22;
            _radMaster.Text = "Mastercard";
            _radMaster.UncheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(125)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            _radMaster.UncheckedState.BorderThickness = 2;
            _radMaster.UncheckedState.FillColor = Color.Transparent;
            _radMaster.UncheckedState.InnerColor = Color.Transparent;
            // 
            // radVisa
            // 
            _radVisa.AutoSize = true;
            _radVisa.CheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _radVisa.CheckedState.BorderThickness = 0;
            _radVisa.CheckedState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _radVisa.CheckedState.InnerColor = Color.White;
            _radVisa.CheckedState.InnerOffset = -4;
            _radVisa.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _radVisa.Location = new Point(437, 367);
            _radVisa.Name = "_radVisa";
            _radVisa.Size = new Size(127, 33);
            _radVisa.TabIndex = 23;
            _radVisa.Text = "VIsacard";
            _radVisa.UncheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(125)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            _radVisa.UncheckedState.BorderThickness = 2;
            _radVisa.UncheckedState.FillColor = Color.Transparent;
            _radVisa.UncheckedState.InnerColor = Color.Transparent;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // PaymentMethods
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(_radVisa);
            Controls.Add(_radMaster);
            Controls.Add(Label1);
            Controls.Add(txbCCV);
            Controls.Add(Label5);
            Controls.Add(txbCardNumber);
            Controls.Add(Label3);
            Controls.Add(txbExp);
            Controls.Add(Label2);
            Controls.Add(txbName);
            Controls.Add(_Guna2Button3);
            Name = "PaymentMethods";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal FoodShopDataSetTableAdapters.FoodTableAdapter FoodTableAdapter1;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button3;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button3 != null)
                {
                    _Guna2Button3.Click -= Guna2Button3_Click;
                }

                _Guna2Button3 = value;
                if (_Guna2Button3 != null)
                {
                    _Guna2Button3.Click += Guna2Button3_Click;
                }
            }
        }

        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2TextBox txbCardNumber;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox txbExp;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txbName;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2TextBox txbCCV;
        private Guna.UI2.WinForms.Guna2RadioButton _radMaster;

        internal Guna.UI2.WinForms.Guna2RadioButton radMaster
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _radMaster;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_radMaster != null)
                {
                    _radMaster.CheckedChanged -= radMaster_CheckedChanged;
                }

                _radMaster = value;
                if (_radMaster != null)
                {
                    _radMaster.CheckedChanged += radMaster_CheckedChanged;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2RadioButton _radVisa;

        internal Guna.UI2.WinForms.Guna2RadioButton radVisa
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _radVisa;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_radVisa != null)
                {
                    _radVisa.CheckedChanged -= radVisa_CheckedChanged;
                }

                _radVisa = value;
                if (_radVisa != null)
                {
                    _radVisa.CheckedChanged += radVisa_CheckedChanged;
                }
            }
        }

        internal ErrorProvider err;
    }
}