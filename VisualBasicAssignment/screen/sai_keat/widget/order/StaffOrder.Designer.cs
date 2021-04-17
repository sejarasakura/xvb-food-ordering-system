using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class StaffOrder : MasterWidgetItem
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
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            _lnkPaymentReport = new LinkLabel();
            _lnkPaymentReport.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkPaymentReport_LinkClicked);
            _linkSalesReport = new LinkLabel();
            _linkSalesReport.LinkClicked += new LinkLabelLinkClickedEventHandler(linkSalesReport_LinkClicked);
            _lnkNewOrder = new LinkLabel();
            _lnkNewOrder.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkNewOrder_LinkClicked);
            Panel1 = new Panel();
            SuspendLayout();
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
            // lnkPaymentReport
            // 
            _lnkPaymentReport.AutoSize = true;
            _lnkPaymentReport.Location = new Point(183, 8);
            _lnkPaymentReport.Name = "_lnkPaymentReport";
            _lnkPaymentReport.Size = new Size(110, 17);
            _lnkPaymentReport.TabIndex = 43;
            _lnkPaymentReport.TabStop = true;
            _lnkPaymentReport.Text = "Payment Report";
            // 
            // linkSalesReport
            // 
            _linkSalesReport.AutoSize = true;
            _linkSalesReport.Location = new Point(89, 7);
            _linkSalesReport.Name = "_linkSalesReport";
            _linkSalesReport.Size = new Size(90, 17);
            _linkSalesReport.TabIndex = 42;
            _linkSalesReport.TabStop = true;
            _linkSalesReport.Text = "Sales Report";
            // 
            // lnkNewOrder
            // 
            _lnkNewOrder.AutoSize = true;
            _lnkNewOrder.Location = new Point(14, 7);
            _lnkNewOrder.Name = "_lnkNewOrder";
            _lnkNewOrder.Size = new Size(76, 17);
            _lnkNewOrder.TabIndex = 40;
            _lnkNewOrder.TabStop = true;
            _lnkNewOrder.Text = "New Order";
            // 
            // Panel1
            // 
            Panel1.Location = new Point(3, 42);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1084, 493);
            Panel1.TabIndex = 44;
            // 
            // StaffOrder
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(Panel1);
            Controls.Add(_lnkPaymentReport);
            Controls.Add(_linkSalesReport);
            Controls.Add(_lnkNewOrder);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2Separator1);
            Name = "StaffOrder";
            Load += new EventHandler(StaffOrder_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        private LinkLabel _lnkPaymentReport;

        internal LinkLabel lnkPaymentReport
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lnkPaymentReport;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lnkPaymentReport != null)
                {
                    _lnkPaymentReport.LinkClicked -= lnkPaymentReport_LinkClicked;
                }

                _lnkPaymentReport = value;
                if (_lnkPaymentReport != null)
                {
                    _lnkPaymentReport.LinkClicked += lnkPaymentReport_LinkClicked;
                }
            }
        }

        private LinkLabel _linkSalesReport;

        internal LinkLabel linkSalesReport
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _linkSalesReport;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_linkSalesReport != null)
                {
                    _linkSalesReport.LinkClicked -= linkSalesReport_LinkClicked;
                }

                _linkSalesReport = value;
                if (_linkSalesReport != null)
                {
                    _linkSalesReport.LinkClicked += linkSalesReport_LinkClicked;
                }
            }
        }

        private LinkLabel _lnkNewOrder;

        internal LinkLabel lnkNewOrder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lnkNewOrder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lnkNewOrder != null)
                {
                    _lnkNewOrder.LinkClicked -= lnkNewOrder_LinkClicked;
                }

                _lnkNewOrder = value;
                if (_lnkNewOrder != null)
                {
                    _lnkNewOrder.LinkClicked += lnkNewOrder_LinkClicked;
                }
            }
        }

        internal Panel Panel1;
    }
}