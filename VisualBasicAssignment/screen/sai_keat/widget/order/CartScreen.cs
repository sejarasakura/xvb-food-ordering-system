using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace VisualBasicAssignment
{
    public partial class CartScreen
    {
        public CartScreen()
        {
            InitializeComponent();
            _btnPay.Name = "btnPay";
        }

        private List<CartDetail> details;

        private void CartScreen_Load(object sender, EventArgs e)
        {
            pnlPicture.AutoScroll = true;
            ReLoad();
        }

        private void ReLoad()
        {
            pnlPicture.Controls.Clear();
            using (var db = new FoodShopEntities1())
            {
                int id = DatabaseConnections.GetLoginUser().user_id;
                var cart_record = db.Carts.Where(s => s.customer_id == id).FirstOrDefault();
                if (cart_record is null)
                {
                    details = ExFunctions.CreateCart().CartDetails.ToList();
                }
                else
                {
                    details = cart_record.CartDetails.ToList();
                }

                try
                {
                    for (int i = 0, loopTo = details.Count; i <= loopTo; i++)
                    {
                        var items = new OrderItem(details[i]);
                        items.Visible = true;
                        Console.WriteLine("Order Id: {0}", details[i].food_id);
                        pnlPicture.Controls.Add(items);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentDetail pd;
            using (var db = new FoodShopEntities1())
            {
                OrderItem ctrl;
                var total = default(double);
                var newPaynment = new Payment();
                newPaynment.PaymentStatu = db.PaymentStatus.Find((object)Guid.Parse("20bd9f32-b531-4b7f-a89a-80babe9aa707"));
                newPaynment.user_id = DatabaseConnections.GetLoginUser().user_id;
                newPaynment.payment_date = DateTime.Now;
                newPaynment.id = Guid.NewGuid();
                newPaynment.notes = "";
                newPaynment.payment_method = Guid.Parse("9244ee14-b4b5-4f2c-833b-3b3c18d68764");
                newPaynment.payment_meta = "";
                for (int i = 0, loopTo = details.Count - 1; i <= loopTo; i++)
                {
                    ctrl = (OrderItem)pnlPicture.Controls[i];
                    if (ctrl.ckb.Checked)
                    {
                        total += Convert.ToDouble(details[i].Food.price * details[i].quantity);
                        pd = new PaymentDetail();
                        pd.add_date = DateTime.Now;
                        pd.quantity = details[i].quantity;
                        pd.food_id = details[i].food_id;
                        pd.payment_id = newPaynment.id;
                        db.CartDetails.Remove(db.CartDetails.Find(details[i].cart_id, details[i].food_id));
                        newPaynment.PaymentDetails.Add(pd);
                    }
                }

                newPaynment.net_pay = total;
                newPaynment.tax_change = total * 0.06d;
                newPaynment.total_pay = total * 1.06d;
                db.Payments.Add(newPaynment);
                try
                {
                    db.SaveChanges();
                    DatabaseConnections.SetCurrentPayment(newPaynment);
                    My.MyProject.Forms.PaymentStep1.Show();
                    ReLoad();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }
    }
}