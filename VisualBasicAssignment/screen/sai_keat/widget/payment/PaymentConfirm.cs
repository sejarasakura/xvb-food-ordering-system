using System;
using System.Data;
using System.Linq;

namespace VisualBasicAssignment
{
    public partial class PaymentConfirm
    {
        public PaymentConfirm()
        {
            InitializeComponent();
        }

        public Master master;

        private void OrderItem1_Load(object sender, EventArgs e)
        {
            var pay = DatabaseConnections.GetCurrentPayment();
            lblSubTotal.Text = string.Format("Sub Total: RM {0:0.00}", pay.net_pay);
            lblTax.Text = string.Format("Tax Charge: RM {0:0.00}", pay.tax_change);
            lblTotalAmount.Text = string.Format("Total Fees: RM {0:0.00}", pay.total_pay);
            lblDelivaryFees.Text = "Delivery Fees: RM 0.0";
            lblCustomerPaid.Text = string.Format("You Pay: RM {0:0.00}", pay.customer_paid);
            lblNote.Text = "Payment Note: <br/>" + pay.notes;
            lblPaymentId.Text = "Payment ID: " + pay.id.ToString();
            lblDate.Text = "Payment date: " + pay.payment_date.ToString();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    dgvDetails.DataSource = (from d in db.PaymentDetails
                                             where d.payment_id == pay.id
                                             select new { d.Food.title, d.quantity, d.Food.price }).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }
    }
}