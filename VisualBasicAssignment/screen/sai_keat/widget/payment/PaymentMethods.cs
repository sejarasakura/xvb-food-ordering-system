using System;
using System.Data.Entity.Migrations;
using Guna.UI2.WinForms;

namespace VisualBasicAssignment
{
    public partial class PaymentMethods
    {
        public PaymentMethods()
        {
            InitializeComponent();
            _Guna2Button3.Name = "Guna2Button3";
            _radMaster.Name = "radMaster";
            _radVisa.Name = "radVisa";
        }

        public Master master;

        private void radVisa_CheckedChanged(object sender, EventArgs e)
        {
            Guna2RadioButton btn = (Guna2RadioButton)sender;
            if (btn.Checked)
            {
                radMaster.Checked = false;
                radVisa.Checked = true;
            }
        }

        private void radMaster_CheckedChanged(object sender, EventArgs e)
        {
            Guna2RadioButton btn = (Guna2RadioButton)sender;
            if (btn.Checked)
            {
                radMaster.Checked = true;
                radVisa.Checked = false;
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            err.Tag = null;
            if (!ValidatePayment.isName(txbName.Text))
            {
                err.SetError(txbName, "Please type your name!");
                err.Tag = err.Tag ?? txbName;
            }

            if (radMaster.Checked)
            {
                if (!ValidatePayment.isMastercard(txbCardNumber.Text))
                {
                    err.SetError(txbCardNumber, "Not master card format *Card number 16 number withoud white space!");
                    err.Tag = err.Tag ?? txbCardNumber;
                }
            }
            else if (!ValidatePayment.isVisacard(txbCardNumber.Text))
            {
                err.SetError(txbCardNumber, "Mot visa card format, Card number 16 number withoud white space!");
                err.Tag = err.Tag ?? txbCardNumber;
            }

            if (!ValidatePayment.isCCV(txbCCV.Text))
            {
                err.SetError(txbCCV, "Please type your CCV!");
                err.Tag = err.Tag ?? txbCCV;
            }

            if (!ValidatePayment.isExp(txbExp.Text))
            {
                err.SetError(txbExp, "Please type your EXP!");
                err.Tag = err.Tag ?? txbExp;
            }

            if (err.Tag is null)
            {
                using (var db = new FoodShopEntities1())
                {
                    try
                    {
                        var pay = DatabaseConnections.GetCurrentPayment();
                        pay.customer_paid = pay.total_pay;
                        pay.payment_meta = txbName.Text + "," + txbCardNumber.Text + "," + txbCCV.Text + "," + txbExp.Text;
                        // Set the payment status to completed
                        pay.payment_status = Guid.Parse("c595596d-8980-4138-bc20-a91056e1b1ce");
                        db.Payments.AddOrUpdate(pay);
                        db.SaveChanges();
                        master.Hide();
                        My.MyProject.Forms.PaymentStep3.Show();
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