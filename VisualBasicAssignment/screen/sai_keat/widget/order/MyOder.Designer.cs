using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class MyOder : MasterWidgetItem
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOder));
            Panel1 = new Panel();
            lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _lblDate.Click += new EventHandler(lblDate_Click);
            lblPay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            _dgvOrder.CellClick += new DataGridViewCellEventHandler(dgvOrder_CellContentClick);
            Guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvOrderDetails = new DataGridView();
            LinkLabel4 = new LinkLabel();
            LinkLabel3 = new LinkLabel();
            LinkLabel2 = new LinkLabel();
            LinkLabel1 = new LinkLabel();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PictureBox1 = new PictureBox();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.AutoSize = true;
            Panel1.Controls.Add(lblStatus);
            Panel1.Controls.Add(_lblDate);
            Panel1.Controls.Add(lblPay);
            Panel1.Controls.Add(_dgvOrder);
            Panel1.Controls.Add(Guna2HtmlLabel7);
            Panel1.Controls.Add(dgvOrderDetails);
            Panel1.Location = new Point(21, 44);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(784, 475);
            Panel1.TabIndex = 22;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblStatus.Location = new Point(362, 72);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(404, 22);
            lblStatus.TabIndex = 30;
            lblStatus.Text = "Order Date: ";
            // 
            // lblDate
            // 
            _lblDate.AutoSize = false;
            _lblDate.BackColor = Color.Transparent;
            _lblDate.Font = new Font("Microsoft Sans Serif", 9.8f);
            _lblDate.Location = new Point(362, 44);
            _lblDate.Name = "_lblDate";
            _lblDate.Size = new Size(404, 22);
            _lblDate.TabIndex = 29;
            _lblDate.Text = "Order Date: ";
            // 
            // lblPay
            // 
            lblPay.AutoSize = false;
            lblPay.BackColor = Color.Transparent;
            lblPay.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblPay.Location = new Point(362, 16);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(404, 22);
            lblPay.TabIndex = 28;
            lblPay.Text = "Payment ID: ";
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
            Guna2HtmlLabel7.AutoSize = false;
            Guna2HtmlLabel7.BackColor = Color.Transparent;
            Guna2HtmlLabel7.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel7.Location = new Point(362, 116);
            Guna2HtmlLabel7.Name = "Guna2HtmlLabel7";
            Guna2HtmlLabel7.Size = new Size(419, 22);
            Guna2HtmlLabel7.TabIndex = 26;
            Guna2HtmlLabel7.Text = "Order details: ";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToOrderColumns = true;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(352, 144);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 24;
            dgvOrderDetails.Size = new Size(429, 326);
            dgvOrderDetails.TabIndex = 0;
            // 
            // LinkLabel4
            // 
            LinkLabel4.AutoSize = true;
            LinkLabel4.Location = new Point(201, 5);
            LinkLabel4.Name = "LinkLabel4";
            LinkLabel4.Size = new Size(59, 17);
            LinkLabel4.TabIndex = 21;
            LinkLabel4.TabStop = true;
            LinkLabel4.Text = "Recived";
            // 
            // LinkLabel3
            // 
            LinkLabel3.AutoSize = true;
            LinkLabel3.Location = new Point(103, 5);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(92, 17);
            LinkLabel3.TabIndex = 20;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "To Deliveried";
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(44, 5);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(53, 17);
            LinkLabel2.TabIndex = 19;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "To Pay";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(15, 5);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(23, 17);
            LinkLabel1.TabIndex = 18;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "All";
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
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(15, 26);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(1056, 10);
            Guna2Separator1.TabIndex = 16;
            // 
            // Guna2HtmlLabel5
            // 
            Guna2HtmlLabel5.AutoSize = false;
            Guna2HtmlLabel5.BackColor = Color.Transparent;
            Guna2HtmlLabel5.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel5.Location = new Point(834, 385);
            Guna2HtmlLabel5.Name = "Guna2HtmlLabel5";
            Guna2HtmlLabel5.Size = new Size(200, 22);
            Guna2HtmlLabel5.TabIndex = 28;
            Guna2HtmlLabel5.Text = "Recived: (7)";
            // 
            // Guna2HtmlLabel6
            // 
            Guna2HtmlLabel6.AutoSize = false;
            Guna2HtmlLabel6.BackColor = Color.Transparent;
            Guna2HtmlLabel6.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel6.Location = new Point(834, 343);
            Guna2HtmlLabel6.Name = "Guna2HtmlLabel6";
            Guna2HtmlLabel6.Size = new Size(200, 22);
            Guna2HtmlLabel6.TabIndex = 27;
            Guna2HtmlLabel6.Text = "To Deliveried: (2)";
            // 
            // Guna2HtmlLabel4
            // 
            Guna2HtmlLabel4.AutoSize = false;
            Guna2HtmlLabel4.BackColor = Color.Transparent;
            Guna2HtmlLabel4.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel4.Location = new Point(834, 296);
            Guna2HtmlLabel4.Name = "Guna2HtmlLabel4";
            Guna2HtmlLabel4.Size = new Size(200, 22);
            Guna2HtmlLabel4.TabIndex = 26;
            Guna2HtmlLabel4.Text = "To pay: (1 order)";
            // 
            // Guna2HtmlLabel3
            // 
            Guna2HtmlLabel3.AutoSize = false;
            Guna2HtmlLabel3.BackColor = Color.Transparent;
            Guna2HtmlLabel3.Font = new Font("Microsoft Sans Serif", 9.8f);
            Guna2HtmlLabel3.Location = new Point(834, 254);
            Guna2HtmlLabel3.Name = "Guna2HtmlLabel3";
            Guna2HtmlLabel3.Size = new Size(200, 22);
            Guna2HtmlLabel3.TabIndex = 25;
            Guna2HtmlLabel3.Text = "All: (10 order)";
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.AutoSize = false;
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2HtmlLabel2.Location = new Point(824, 44);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(200, 38);
            Guna2HtmlLabel2.TabIndex = 24;
            Guna2HtmlLabel2.Text = "Overall";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(863, 88);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(160, 143);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 23;
            PictureBox1.TabStop = false;
            // 
            // MyOder
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(Panel1);
            Controls.Add(LinkLabel4);
            Controls.Add(LinkLabel3);
            Controls.Add(LinkLabel2);
            Controls.Add(LinkLabel1);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2Separator1);
            Controls.Add(Guna2HtmlLabel5);
            Controls.Add(Guna2HtmlLabel6);
            Controls.Add(Guna2HtmlLabel4);
            Controls.Add(Guna2HtmlLabel3);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(PictureBox1);
            Name = "MyOder";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Page_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal LinkLabel LinkLabel4;
        internal LinkLabel LinkLabel3;
        internal LinkLabel LinkLabel2;
        internal LinkLabel LinkLabel1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel5;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel6;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel4;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel3;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal PictureBox PictureBox1;
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
        private Guna.UI2.WinForms.Guna2HtmlLabel _lblDate;

        internal Guna.UI2.WinForms.Guna2HtmlLabel lblDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblDate != null)
                {
                    _lblDate.Click -= lblDate_Click;
                }

                _lblDate = value;
                if (_lblDate != null)
                {
                    _lblDate.Click += lblDate_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel lblPay;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
    }
}