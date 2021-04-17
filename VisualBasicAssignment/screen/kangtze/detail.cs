using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class detail
    {
        public detail()
        {
            InitializeComponent();
            _btnBack.Name = "btnBack";
        }

        private DataSet ds = new DataSet();
        private SqlDataAdapter da;

        private void detail_Load(object sender, EventArgs e)
        {
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    var f = db.Foods.Find((object)Conversions.ToInteger(Module1.detailid));
                    if (f is null)
                    {
                    }
                    else
                    {
                        lblName.Text = f.title;
                        lblDesc.Text = f.descriptions;
                        lblPrice.Text = string.Format("RM {0:0.00}", f.price);
                        pcbProduct.Image = ExFunctions.byteToImage(f.image);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}