// Author Lim Sai Keat
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public class ExFunctions
    {
        public static Image byteToImage(byte[] b)
        {
            try
            {
                var ms = new System.IO.MemoryStream(b); // This is correct...
                var returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                return null;
            }
        }

        public static Cart CreateCart()
        {
            using (var db = new FoodShopEntities1())
            {
                var newCart = new Cart();
                newCart.customer_id = DatabaseConnections.GetLoginUser().user_id;
                try
                {
                    db.Carts.Add(newCart);
                    db.SaveChanges();
                    return newCart;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static void addToCart(int productId, int quantity = 1)
        {
            var cd = new CartDetail();
            using (var db = new FoodShopEntities1())
            {
                Cart cart = null;
                var user = DatabaseConnections.GetLoginUser();
                var carts = db.Carts.Where(s => s.customer_id == user.user_id);
                if (carts.Count() <= 0)
                {
                    cart = CreateCart();
                }
                else
                {
                    cart = carts.FirstOrDefault();
                }

                if (cart is object)
                {
                    // string userid = Session["UserId"].ToString(); //user id for the logged in user
                    int lProductid = productId; // get product id from the selected product
                    int pidininteger = lProductid;
                    var product = db.Foods.Find((object)pidininteger);
                    cd.food_id = pidininteger; // art id
                    cd.quantity = quantity;
                    cd.add_datetime = DateTime.Now; // added item must be recorded on real time\
                    cd.cart_id = cart.id;
                    var old_details = db.CartDetails.Find(cart.id, cd.food_id);
                    if (old_details is object)
                    {
                        old_details.quantity = old_details.quantity + quantity;
                        db.CartDetails.AddOrUpdate(old_details);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("You have successful added " + db.Foods.Find((object)cd.food_id).title + " to your shopping cart!", "Successfully added to cart!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception __unusedException1__)
                        {
                            MessageBox.Show("This art that you are trying to add is already existed in your shopping cart", "Art already existed in your cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        db.CartDetails.Add(cd);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("You have successful added " + db.Foods.Find((object)cd.food_id).title + " to your shopping cart!", "Successfully added to cart!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception __unusedException1__)
                        {
                            MessageBox.Show("This art that you are trying to add is already existed in your shopping cart", "Art already existed in your cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}