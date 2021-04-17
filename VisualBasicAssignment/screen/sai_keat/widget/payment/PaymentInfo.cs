using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;

namespace VisualBasicAssignment
{
    public partial class PaymentInfo
    {
        public PaymentInfo()
        {
            // This call is required by the designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.

            lblTitle.Left = (int)Math.Round(Width / 2d - lblTitle.Width / 2d);
            var u = DatabaseConnections.GetLoginUser();
            var p = DatabaseConnections.GetCurrentPayment();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    dgvPaymnet.DataSource = (from d in db.PaymentDetails
                                             where d.payment_id == p.id
                                             select new { d.Food.title, d.Food.price, d.quantity }).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception payment info caught: {0}", ex);
                }
            }

            _btnCheckout.Name = "btnCheckout";
        }

        public Master master;

        private void PaymentInfo_Load(object sender, EventArgs e)
        {
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            err.Tag = null;
            if (!ValidatePayment.isName(txbName.Text))
            {
                err.SetError(txbName, "Please type your name!");
                err.Tag = err.Tag ?? txbName;
            }

            if (!ValidatePayment.isPhoneNumber(txbPhoneNumber.Text))
            {
                Console.WriteLine("Validate {0}", txbPhoneNumber.Text);
                err.SetError(txbPhoneNumber, "Please type phone number!");
                err.Tag = err.Tag ?? txbPhoneNumber;
            }

            if (err.Tag is null)
            {
                using (var db = new FoodShopEntities1())
                {
                    try
                    {
                        var pay = DatabaseConnections.GetCurrentPayment();
                        pay.notes = txbCompanyName.Text + ", " + txbNote.Text + "(" + txbAddressDetails.Text + txbAddressDetails2.Text + ") TO [" + txbName.Text + ", " + txbPhoneNumber.Text + "]";
                        db.Payments.AddOrUpdate(pay);
                        db.SaveChanges();
                        master.Hide();
                        My.MyProject.Forms.PaymentStep2.Show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception caught: {0}", ex);
                    }
                }
            }
        }
    }
}