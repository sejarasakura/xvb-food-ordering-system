using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class PaymentConfirm : MasterWidgetItem
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentConfirm));
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LinkLabel1 = new LinkLabel();
            LinkLabel2 = new LinkLabel();
            LinkLabel3 = new LinkLabel();
            LinkLabel4 = new LinkLabel();
            Panel1 = new Panel();
            lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPaymentId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNote = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDelivaryFees = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCustomerPaid = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PictureBox1 = new PictureBox();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(31, 78);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(1056, 10);
            Guna2Separator1.TabIndex = 0;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2HtmlLabel1.Location = new Point(31, 12);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(251, 38);
            Guna2HtmlLabel1.TabIndex = 4;
            Guna2HtmlLabel1.Text = "Payment Complete";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(31, 57);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(23, 17);
            LinkLabel1.TabIndex = 5;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "All";
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(60, 57);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(53, 17);
            LinkLabel2.TabIndex = 6;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "To Pay";
            // 
            // LinkLabel3
            // 
            LinkLabel3.AutoSize = true;
            LinkLabel3.Location = new Point(119, 57);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(92, 17);
            LinkLabel3.TabIndex = 7;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "To Deliveried";
            // 
            // LinkLabel4
            // 
            LinkLabel4.AutoSize = true;
            LinkLabel4.Location = new Point(217, 58);
            LinkLabel4.Name = "LinkLabel4";
            LinkLabel4.Size = new Size(59, 17);
            LinkLabel4.TabIndex = 8;
            LinkLabel4.TabStop = true;
            LinkLabel4.Text = "Recived";
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.AutoSize = true;
            Panel1.Controls.Add(lblDate);
            Panel1.Controls.Add(lblPaymentId);
            Panel1.Controls.Add(lblNote);
            Panel1.Controls.Add(dgvDetails);
            Panel1.Location = new Point(37, 96);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(764, 416);
            Panel1.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.AutoSize = false;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblDate.Location = new Point(493, 44);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(265, 22);
            lblDate.TabIndex = 18;
            lblDate.Text = "Payment Date: ";
            // 
            // lblPaymentId
            // 
            lblPaymentId.AutoSize = false;
            lblPaymentId.BackColor = Color.Transparent;
            lblPaymentId.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblPaymentId.Location = new Point(21, 12);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(737, 22);
            lblPaymentId.TabIndex = 17;
            lblPaymentId.Text = "Payment : Guid ";
            // 
            // lblNote
            // 
            lblNote.AutoSize = false;
            lblNote.BackColor = Color.Transparent;
            lblNote.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNote.Location = new Point(493, 134);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(265, 273);
            lblNote.TabIndex = 1;
            lblNote.Text = "Payment note:<br/> Note";
            // 
            // dgvDetails
            // 
            DataGridViewCellStyle4.BackColor = Color.White;
            dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.BackgroundColor = Color.White;
            dgvDetails.BorderStyle = BorderStyle.None;
            dgvDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvDetails.ColumnHeadersHeight = 50;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.White;
            DataGridViewCellStyle6.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDetails.DefaultCellStyle = DataGridViewCellStyle6;
            dgvDetails.EnableHeadersVisualStyles = false;
            dgvDetails.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvDetails.Location = new Point(17, 44);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersVisible = false;
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.RowTemplate.Height = 24;
            dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetails.Size = new Size(461, 363);
            dgvDetails.TabIndex = 0;
            dgvDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDetails.ThemeStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5f);
            dgvDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDetails.ThemeStyle.HeaderStyle.Height = 50;
            dgvDetails.ThemeStyle.ReadOnly = false;
            dgvDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5f);
            dgvDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            dgvDetails.ThemeStyle.RowsStyle.Height = 24;
            dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2HtmlLabel2.Location = new Point(839, 96);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(198, 38);
            Guna2HtmlLabel2.TabIndex = 11;
            Guna2HtmlLabel2.Text = "Make Payment";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = false;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblSubTotal.Location = new Point(836, 306);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(200, 22);
            lblSubTotal.TabIndex = 12;
            lblSubTotal.Text = "Sub Total: RM 199.00";
            // 
            // lblTax
            // 
            lblTax.AutoSize = false;
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblTax.Location = new Point(836, 348);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(200, 22);
            lblTax.TabIndex = 13;
            lblTax.Text = "Tax Charges: RM 19.90";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = false;
            lblTotalAmount.BackColor = Color.Transparent;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblTotalAmount.Location = new Point(836, 437);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(200, 22);
            lblTotalAmount.TabIndex = 15;
            lblTotalAmount.Text = "Total Fees: RM 221.00";
            // 
            // lblDelivaryFees
            // 
            lblDelivaryFees.AutoSize = false;
            lblDelivaryFees.BackColor = Color.Transparent;
            lblDelivaryFees.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblDelivaryFees.Location = new Point(836, 395);
            lblDelivaryFees.Name = "lblDelivaryFees";
            lblDelivaryFees.Size = new Size(200, 22);
            lblDelivaryFees.TabIndex = 14;
            lblDelivaryFees.Text = "Delivary Fees: RM 3.00";
            // 
            // lblCustomerPaid
            // 
            lblCustomerPaid.AutoSize = false;
            lblCustomerPaid.BackColor = Color.Transparent;
            lblCustomerPaid.Font = new Font("Microsoft Sans Serif", 9.8f);
            lblCustomerPaid.Location = new Point(836, 481);
            lblCustomerPaid.Name = "lblCustomerPaid";
            lblCustomerPaid.Size = new Size(200, 22);
            lblCustomerPaid.TabIndex = 16;
            lblCustomerPaid.Text = "You Pay: RM 221.00";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(861, 140);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(177, 143);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 10;
            PictureBox1.TabStop = false;
            // 
            // PaymentConfirm
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(lblCustomerPaid);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblDelivaryFees);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(PictureBox1);
            Controls.Add(Panel1);
            Controls.Add(LinkLabel4);
            Controls.Add(LinkLabel3);
            Controls.Add(LinkLabel2);
            Controls.Add(LinkLabel1);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2Separator1);
            Name = "PaymentConfirm";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(OrderItem1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal LinkLabel LinkLabel1;
        internal LinkLabel LinkLabel2;
        internal LinkLabel LinkLabel3;
        internal LinkLabel LinkLabel4;
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblSubTotal;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblTax;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblTotalAmount;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblDelivaryFees;
        internal Guna.UI2.WinForms.Guna2DataGridView dgvDetails;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblPaymentId;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblNote;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerPaid;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
    }
}