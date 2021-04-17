using System;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class StaffOrder
    {
        public StaffOrder()
        {
            InitializeComponent();
            _lnkPaymentReport.Name = "lnkPaymentReport";
            _linkSalesReport.Name = "linkSalesReport";
            _lnkNewOrder.Name = "lnkNewOrder";
        }

        public void switchPanel2(Control panel)
        {
            Panel1.Controls.Clear();
            panel.Show();
            panel.Visible = true;
            Panel1.Controls.Add(panel);
        }

        private void lnkNewOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switchPanel2(new NewOder());
        }

        private void linkSalesReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switchPanel2(new SalesReport());
        }

        private void lnkPaymentReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switchPanel2(new PaymnetReport());
        }

        private void StaffOrder_Load(object sender, EventArgs e)
        {
            switchPanel2(new NewOder());
        }
    }
}