using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class staffmenu
    {
        public staffmenu()
        {
            InitializeComponent();
            _btnReload.Name = "btnReload";
        }

        private Panel pnl;
        private PictureBox pic;
        private Label namelabel;
        private Label pricelabel;
        private Label desclabel;
        // Private WithEvents btnEdit As Button

        private void custmenu_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void ReLoad()
        {
            pnlPicture.Controls.Clear();
            byte[] arrImage;
            using (var db = new FoodShopEntities1())
            {
                var foods = DatabaseConnections.db.Foods.ToList();
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
                        desclabel = new Label();
                        desclabel.Font = new Font("Garamond", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
                        desclabel.Text = foods[i].descriptions;
                        desclabel.Dock = DockStyle.Fill;
                        var btnEdit = new Button();
                        btnEdit.Name = foods[i].id.ToString();
                        btnEdit.Text = "Edit";
                        btnEdit.Click += Button_Click;
                        btnEdit.Dock = DockStyle.Top;
                        pnl = new Panel();
                        pnl.Controls.Add(pricelabel);
                        pnl.Controls.Add(namelabel);
                        pnl.Controls.Add(desclabel);
                        pnl.Controls.Add(btnEdit);
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

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = new Button();
            btn = (Button)sender;
            MessageBox.Show(btn.Name + "clicked");
            Module1.editid = btn.Name;
            My.MyProject.Forms.edit.ShowDialog();
            Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}