using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class addfood
    {
        public addfood()
        {
            InitializeComponent();
            _btnUpload.Name = "btnUpload";
            _btnCreate.Name = "btnCreate";
            _btnCancel.Name = "btnCancel";
        }

        private void Page_Load(object sender, EventArgs e)
        {
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    var cat = db.Catergories.ToList();
                    cmbCategory.DataSource = cat;
                    cmbCategory.ValueMember = "id";
                    cmbCategory.DisplayMember = "name";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImage.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                if (ofdImage.ShowDialog() == DialogResult.OK)
                {
                    pcbProduct.Image = new Bitmap(ofdImage.FileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            pcbProduct.Image.Save(ms, pcbProduct.Image.RawFormat);
            var f = new Food();
            f.add_date = DateTime.Now;
            f.catergory_id = (int?)cmbCategory.SelectedValue;
            f.descriptions = txtDesc.Text;
            f.duty_staff_id = DatabaseConnections.GetLoginUser().user_id;
            f.title = txtName.Text;
            f.price = Conversions.ToDouble(txtPrice.Text);
            f.stock = 100;
            f.image = ms.ToArray();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    db.Foods.Add(f);
                    db.SaveChanges();
                    MessageBox.Show("Updates sucessful" + db.Foods.Count().ToString(), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDesc.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }
    }
}