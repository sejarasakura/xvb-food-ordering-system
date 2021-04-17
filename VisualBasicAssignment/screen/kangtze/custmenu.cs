using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class custmenu
    {
        public custmenu()
        {
            InitializeComponent();
            _btnReload.Name = "btnReload";
        }

        private Panel pnl;
        private PictureBox pic;
        private Label namelabel;
        private Label pricelabel;
        // Private WithEvents btnEdit As Button

        private void custmenu_Load(object sender, EventArgs e)
        {
            pnlPicture.AutoScroll = true;
            ReLoad();
        }

        private void ReLoad()
        {
            pnlPicture.Controls.Clear();
            byte[] arrImage;
            using (var db = new FoodShopEntities1())
            {
                var foods = (from d in db.Foods
                             orderby d.id descending
                             select d).ToList();
                try
                {
                    for (int i = 0, loopTo = foods.Count; i <= loopTo; i++)
                    {
                        arrImage = foods[i].image;
                        pic = new PictureBox();
                        pic.Width = 130;
                        pic.Height = 150;
                        pic.BackgroundImageLayout = ImageLayout.Stretch;
                        if (arrImage is object)
                        {
                            pic.BackgroundImage = ExFunctions.byteToImage(arrImage);
                        }

                        namelabel = new Label();
                        namelabel.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
                        namelabel.Text = "Name : " + foods[i].title;
                        namelabel.Dock = DockStyle.Top;
                        pricelabel = new Label();
                        pricelabel.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
                        pricelabel.Text = "Price : RM" + foods[i].price.ToString();
                        pricelabel.Dock = DockStyle.Top;
                        var btnView = new Button();
                        btnView.Name = foods[i].id.ToString();
                        btnView.Text = "View";
                        btnView.Click += Button_Click;
                        btnView.Dock = DockStyle.Top;
                        var btnAddCart = new Button();
                        btnAddCart.Name = foods[i].id.ToString();
                        btnAddCart.Text = "Add To Cart";
                        btnAddCart.Click += AddToCart;
                        btnAddCart.Dock = DockStyle.Top;
                        pnl = new Panel();
                        pnl.Controls.Add(pricelabel);
                        pnl.Controls.Add(namelabel);
                        pnl.Controls.Add(btnView);
                        pnl.Controls.Add(btnAddCart);
                        pnlPicture.Controls.Add(pic);
                        pnlPicture.Controls.Add(pnl);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void AddToCart(object sender, EventArgs e)
        {
            var btn = new Button();
            btn = (Button)sender;
            ExFunctions.addToCart(Conversions.ToInteger(btn.Name));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = new Button();
            btn = (Button)sender;
            MessageBox.Show(btn.Name + "clicked");
            Module1.detailid = btn.Name;
            My.MyProject.Forms.detail.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}