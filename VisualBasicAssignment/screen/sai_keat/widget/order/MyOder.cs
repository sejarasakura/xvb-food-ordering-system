using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class MyOder
    {
        public MyOder()
        {
            InitializeComponent();
            _lblDate.Name = "lblDate";
            _dgvOrder.Name = "dgvOrder";
        }

        private void Page_Load(object sender, EventArgs e)
        {
            var u = DatabaseConnections.GetLoginUser();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    dgvOrder.DataSource = (from d in db.Payments
                                           where d.user_id == u.user_id
                                           orderby d.payment_date descending
                                           select new { d.id, d.total_pay, d.PaymentStatu.name }).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }

                try
                {
                    if (dgvOrder.FirstDisplayedCell is object)
                    {
                        var data = Guid.Parse(Conversions.ToString(dgvOrder.FirstDisplayedCell.Value));
                        dgvOrderDetails.DataSource = (from d in db.PaymentDetails
                                                      where d.payment_id == data
                                                      orderby d.food_id ascending
                                                      select new { d.food_id, d.Food.title, d.quantity, d.Food.price }).ToList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new FoodShopEntities1())
            {
                Guid pid = (Guid)dgvOrder.SelectedRows[0].Cells[0].Value;
                var p = db.Payments.Find((object)pid);
                try
                {
                    lblPay.Text = "#" + p.id.ToString();
                    lblDate.Text = "Order Date:" + p.payment_date.ToString();
                    lblStatus.Text = "Status:" + p.PaymentStatu.name;
                    dgvOrderDetails.DataSource = (from d in db.PaymentDetails
                                                  where d.payment_id == pid
                                                  orderby d.food_id ascending
                                                  select new { d.food_id, d.Food.title, d.quantity, d.Food.price }).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
        }
    }
}