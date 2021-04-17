using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class NewOder : MasterWidgetItemSm
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            _btnClear = new Guna.UI2.WinForms.Guna2Button();
            _btnClear.Click += new EventHandler(btnClear_Click);
            _btnAdd = new Guna.UI2.WinForms.Guna2Button();
            _btnAdd.Click += new EventHandler(btnAdd_Click);
            lblTitle = new Label();
            _nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            _nudQuantity.ValueChanged += new EventHandler(nudQuantity_ValueChanged);
            _dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            _dgvOrder.CellClick += new DataGridViewCellEventHandler(dgvOrder_CellContentClick);
            Guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvOrderDetails = new DataGridView();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _btnPayment = new Guna.UI2.WinForms.Guna2Button();
            _btnPayment.Click += new EventHandler(btnPayment_Click);
            cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            _Label1 = new Label();
            _Label1.Click += new EventHandler(Label1_Click);
            Label2 = new Label();
            cmbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            Label3 = new Label();
            cmbMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            id = new DataGridViewTextBoxColumn();
            Food = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            quantituy = new DataGridViewTextBoxColumn();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.AutoSize = true;
            Panel1.Controls.Add(_btnClear);
            Panel1.Controls.Add(_btnAdd);
            Panel1.Controls.Add(lblTitle);
            Panel1.Controls.Add(_nudQuantity);
            Panel1.Controls.Add(_dgvOrder);
            Panel1.Controls.Add(Guna2HtmlLabel7);
            Panel1.Controls.Add(dgvOrderDetails);
            Panel1.Location = new Point(4, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(784, 475);
            Panel1.TabIndex = 22;
            // 
            // btnClear
            // 
            _btnClear.CheckedState.Parent = _btnClear;
            _btnClear.CustomImages.Parent = _btnClear;
            _btnClear.Font = new Font("Segoe UI", 9.0f);
            _btnClear.ForeColor = Color.White;
            _btnClear.HoverState.Parent = _btnClear;
            _btnClear.Location = new Point(661, 111);
            _btnClear.Name = "_btnClear";
            _btnClear.ShadowDecoration.Parent = _btnClear;
            _btnClear.Size = new Size(116, 35);
            _btnClear.TabIndex = 35;
            _btnClear.Text = "Clear";
            // 
            // btnAdd
            // 
            _btnAdd.CheckedState.Parent = _btnAdd;
            _btnAdd.CustomImages.Parent = _btnAdd;
            _btnAdd.Font = new Font("Segoe UI", 9.0f);
            _btnAdd.ForeColor = Color.White;
            _btnAdd.HoverState.Parent = _btnAdd;
            _btnAdd.Location = new Point(661, 15);
            _btnAdd.Name = "_btnAdd";
            _btnAdd.ShadowDecoration.Parent = _btnAdd;
            _btnAdd.Size = new Size(116, 35);
            _btnAdd.TabIndex = 33;
            _btnAdd.Text = "Add";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.Location = new Point(352, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 25);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Quantity";
            // 
            // nudQuantity
            // 
            _nudQuantity.BackColor = Color.Transparent;
            _nudQuantity.Cursor = Cursors.IBeam;
            _nudQuantity.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            _nudQuantity.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            _nudQuantity.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            _nudQuantity.DisabledState.Parent = _nudQuantity;
            _nudQuantity.DisabledState.UpDownButtonFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(177)), Conversions.ToInteger(Conversions.ToByte(177)), Conversions.ToInteger(Conversions.ToByte(177)));
            _nudQuantity.DisabledState.UpDownButtonForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(203)), Conversions.ToInteger(Conversions.ToByte(203)), Conversions.ToInteger(Conversions.ToByte(203)));
            _nudQuantity.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            _nudQuantity.FocusedState.Parent = _nudQuantity;
            _nudQuantity.Font = new Font("Segoe UI", 9.0f);
            _nudQuantity.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(126)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            _nudQuantity.Location = new Point(492, 14);
            _nudQuantity.Name = "_nudQuantity";
            _nudQuantity.ShadowDecoration.Parent = _nudQuantity;
            _nudQuantity.Size = new Size(154, 36);
            _nudQuantity.TabIndex = 31;
            _nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvOrder
            // 
            _dgvOrder.AllowUserToAddRows = false;
            _dgvOrder.AllowUserToDeleteRows = false;
            _dgvOrder.AllowUserToOrderColumns = true;
            DataGridViewCellStyle1.BackColor = Color.White;
            _dgvOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvOrder.BackgroundColor = Color.White;
            _dgvOrder.BorderStyle = BorderStyle.None;
            _dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvOrder.ColumnHeadersHeight = 30;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvOrder.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvOrder.EnableHeadersVisualStyles = false;
            _dgvOrder.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvOrder.Location = new Point(3, 3);
            _dgvOrder.Name = "_dgvOrder";
            _dgvOrder.ReadOnly = true;
            _dgvOrder.RowHeadersVisible = false;
            _dgvOrder.RowHeadersWidth = 51;
            _dgvOrder.RowTemplate.Height = 24;
            _dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvOrder.Size = new Size(343, 467);
            _dgvOrder.TabIndex = 27;
            _dgvOrder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            _dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            _dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            _dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            _dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            _dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            _dgvOrder.ThemeStyle.BackColor = Color.White;
            _dgvOrder.ThemeStyle.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvOrder.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            _dgvOrder.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5f);
            _dgvOrder.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            _dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            _dgvOrder.ThemeStyle.HeaderStyle.Height = 30;
            _dgvOrder.ThemeStyle.ReadOnly = true;
            _dgvOrder.ThemeStyle.RowsStyle.BackColor = Color.White;
            _dgvOrder.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvOrder.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5f);
            _dgvOrder.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            _dgvOrder.ThemeStyle.RowsStyle.Height = 24;
            _dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            // 
            // Guna2HtmlLabel7
            // 
            Guna2HtmlLabel7.BackColor = Color.Transparent;
            Guna2HtmlLabel7.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel7.Location = new Point(352, 111);
            Guna2HtmlLabel7.Name = "Guna2HtmlLabel7";
            Guna2HtmlLabel7.Size = new Size(97, 22);
            Guna2HtmlLabel7.TabIndex = 26;
            Guna2HtmlLabel7.Text = "Order details: ";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToOrderColumns = true;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { id, Food, Price, quantituy });
            dgvOrderDetails.Location = new Point(352, 152);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 24;
            dgvOrderDetails.Size = new Size(429, 318);
            dgvOrderDetails.TabIndex = 0;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2HtmlLabel1.Location = new Point(15, -40);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(126, 38);
            Guna2HtmlLabel1.TabIndex = 17;
            Guna2HtmlLabel1.Text = "My Order";
            // 
            // btnPayment
            // 
            _btnPayment.CheckedState.Parent = _btnPayment;
            _btnPayment.CustomImages.Parent = _btnPayment;
            _btnPayment.Font = new Font("Segoe UI", 9.0f);
            _btnPayment.ForeColor = Color.White;
            _btnPayment.HoverState.Parent = _btnPayment;
            _btnPayment.Location = new Point(878, 443);
            _btnPayment.Name = "_btnPayment";
            _btnPayment.ShadowDecoration.Parent = _btnPayment;
            _btnPayment.Size = new Size(189, 35);
            _btnPayment.TabIndex = 36;
            _btnPayment.Text = "Add Order";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.Transparent;
            cmbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FocusedColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbStatus.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbStatus.FocusedState.Parent = cmbStatus;
            cmbStatus.Font = new Font("Segoe UI", 10.0f);
            cmbStatus.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(68)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(112)));
            cmbStatus.HoverState.Parent = cmbStatus;
            cmbStatus.ItemHeight = 30;
            cmbStatus.ItemsAppearance.Parent = cmbStatus;
            cmbStatus.Location = new Point(886, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.ShadowDecoration.Parent = cmbStatus;
            cmbStatus.Size = new Size(181, 36);
            cmbStatus.TabIndex = 37;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.Location = new Point(794, 17);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(57, 20);
            _Label1.TabIndex = 38;
            _Label1.Text = "Status";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(794, 72);
            Label2.Name = "Label2";
            Label2.Size = new Size(45, 20);
            Label2.TabIndex = 40;
            Label2.Text = "User";
            // 
            // cmbUser
            // 
            cmbUser.BackColor = Color.Transparent;
            cmbUser.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.FocusedColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbUser.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbUser.FocusedState.Parent = cmbUser;
            cmbUser.Font = new Font("Segoe UI", 10.0f);
            cmbUser.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(68)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(112)));
            cmbUser.HoverState.Parent = cmbUser;
            cmbUser.ItemHeight = 30;
            cmbUser.ItemsAppearance.Parent = cmbUser;
            cmbUser.Location = new Point(886, 61);
            cmbUser.Name = "cmbUser";
            cmbUser.ShadowDecoration.Parent = cmbUser;
            cmbUser.Size = new Size(181, 36);
            cmbUser.TabIndex = 39;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(794, 125);
            Label3.Name = "Label3";
            Label3.Size = new Size(64, 20);
            Label3.TabIndex = 42;
            Label3.Text = "Method";
            // 
            // cmbMethod
            // 
            cmbMethod.BackColor = Color.Transparent;
            cmbMethod.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.FocusedColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbMethod.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            cmbMethod.FocusedState.Parent = cmbMethod;
            cmbMethod.Font = new Font("Segoe UI", 10.0f);
            cmbMethod.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(68)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(112)));
            cmbMethod.HoverState.Parent = cmbMethod;
            cmbMethod.ItemHeight = 30;
            cmbMethod.ItemsAppearance.Parent = cmbMethod;
            cmbMethod.Location = new Point(886, 114);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.ShadowDecoration.Parent = cmbMethod;
            cmbMethod.Size = new Size(181, 36);
            cmbMethod.TabIndex = 41;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // Food
            // 
            Food.HeaderText = "Food";
            Food.MinimumWidth = 6;
            Food.Name = "Food";
            Food.ReadOnly = true;
            Food.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // quantituy
            // 
            quantituy.HeaderText = "Quantity";
            quantituy.MinimumWidth = 6;
            quantituy.Name = "quantituy";
            quantituy.Width = 125;
            // 
            // NewOder
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(Label3);
            Controls.Add(cmbMethod);
            Controls.Add(Label2);
            Controls.Add(cmbUser);
            Controls.Add(_Label1);
            Controls.Add(cmbStatus);
            Controls.Add(_btnPayment);
            Controls.Add(Panel1);
            Controls.Add(Guna2HtmlLabel1);
            Name = "NewOder";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            Load += new EventHandler(Page_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView _dgvOrder;

        internal Guna.UI2.WinForms.Guna2DataGridView dgvOrder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvOrder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvOrder != null)
                {
                    _dgvOrder.CellClick -= dgvOrder_CellContentClick;
                }

                _dgvOrder = value;
                if (_dgvOrder != null)
                {
                    _dgvOrder.CellClick += dgvOrder_CellContentClick;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel7;
        internal DataGridView dgvOrderDetails;
        internal Label lblTitle;
        private Guna.UI2.WinForms.Guna2NumericUpDown _nudQuantity;

        internal Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudQuantity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudQuantity != null)
                {
                    _nudQuantity.ValueChanged -= nudQuantity_ValueChanged;
                }

                _nudQuantity = value;
                if (_nudQuantity != null)
                {
                    _nudQuantity.ValueChanged += nudQuantity_ValueChanged;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnClear;

        internal Guna.UI2.WinForms.Guna2Button btnClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClear != null)
                {
                    _btnClear.Click -= btnClear_Click;
                }

                _btnClear = value;
                if (_btnClear != null)
                {
                    _btnClear.Click += btnClear_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnPayment;

        internal Guna.UI2.WinForms.Guna2Button btnPayment
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPayment;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPayment != null)
                {
                    _btnPayment.Click -= btnPayment_Click;
                }

                _btnPayment = value;
                if (_btnPayment != null)
                {
                    _btnPayment.Click += btnPayment_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnAdd;

        internal Guna.UI2.WinForms.Guna2Button btnAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd != null)
                {
                    _btnAdd.Click -= btnAdd_Click;
                }

                _btnAdd = value;
                if (_btnAdd != null)
                {
                    _btnAdd.Click += btnAdd_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                    _Label1.Click -= Label1_Click;
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                    _Label1.Click += Label1_Click;
                }
            }
        }

        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbUser;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbMethod;
        internal DataGridViewTextBoxColumn id;
        internal DataGridViewTextBoxColumn Food;
        internal DataGridViewTextBoxColumn Price;
        internal DataGridViewTextBoxColumn quantituy;
    }
}