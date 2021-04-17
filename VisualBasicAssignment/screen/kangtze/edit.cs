using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class edit
    {
        public edit()
        {
            InitializeComponent();
            _btnCancel.Name = "btnCancel";
            _btnCreate.Name = "btnCreate";
        }

        private DataSet ds = new DataSet();
        private SqlDataAdapter da;

        private void edit_Load(object sender, EventArgs e)
        {
            string cmdstr = "select * from food where food_id='" + Module1.editid + "'";
            // PictureBox1.Image = Image.FromStream(ms)
            byte[] arrImage;
            if (Module1.openconnect() == true)
            {
                ds.Clear();
                da = new SqlDataAdapter(cmdstr, Module1.con);
                da.Fill(ds, "Food");
                if (ds.Tables["Food"].Rows.Count == 1)
                {
                    arrImage = (byte[])ds.Tables["Food"].Rows[0][2];
                    var ms = new MemoryStream(arrImage);
                    var bitmap = new Bitmap(Image.FromStream(ms));
                    txtName.Text = Conversions.ToString(ds.Tables["Food"].Rows[0][1]);
                    txtDesc.Text = Conversions.ToString(ds.Tables["Food"].Rows[0][3]);
                    txtPrice.Text = Conversions.ToString(ds.Tables["Food"].Rows[0][4]);
                    lblComboBox.Text = Conversions.ToString(ds.Tables["Food"].Rows[0][5]);
                    pcbProduct.Image = bitmap;
                }

                Module1.closeconnect();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string cmdstr = "update [food] set [food_name]=@name, [food_price]=@price, [food_category]=@category  where food_id='" + Module1.editid + "'";
            SqlCommand cmd;
            if (Module1.openconnect() == true)
            {
                cmd = new SqlCommand(cmdstr, Module1.con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.ExecuteNonQuery();
                Module1.closeconnect();
            }

            Close();
        }
    }
}