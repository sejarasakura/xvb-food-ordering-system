using System;
using System.Data.Entity.Migrations;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class OrderItem
    {
        public OrderItem(CartDetail data)
        {
            this.data = data;
            _upDownNumbering.Name = "upDownNumbering";
        }

        private CartDetail data;

        public void OrderItem_Load()
        {
            InitializeComponent();
            ckb.Checked = true;
            img.Image = ExFunctions.byteToImage(data.Food.image);
            info.Text = "Stock Remain: " + data.Food.stock.ToString() + "<br/><br/>Price:RM " + data.Food.price.ToString();
            title.Text = "<b style='font-size: 15px'>" + data.Food.title + "</b> <br />" + data.Food.descriptions;
            upDownNumbering.Value = Conversions.ToDecimal(data.quantity);
            upDownNumbering.Minimum = data.Food.stock == 0 ? 0 : 1;
            upDownNumbering.Maximum = Conversions.ToDecimal(data.Food.stock);
        }

        private void upDownNumbering_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    data.quantity = Conversions.ToInteger(upDownNumbering.Value);
                    data.add_datetime = DateTime.Now;
                    db.CartDetails.AddOrUpdate(data);
                    db.SaveChanges();
                    Console.WriteLine("Updated to quntity: {0}", db.CartDetails.Find(data.cart_id, data.food_id).quantity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            OrderItem_Load();
        }
    }
}