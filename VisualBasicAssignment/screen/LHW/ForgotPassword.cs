using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class ForgotPassword
    {
        public ForgotPassword()
        {
            InitializeComponent();
            _btnSubmit.Name = "btnSubmit";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = db.Users;
                bool check = false;
                foreach (var result in rs)
                {
                    if ((result.phone_num ?? "") == (txtPhoneNum.Text ?? "") & (result.user_email ?? "") == (txtEmail.Text ?? ""))
                    {
                        check = true;
                    }
                }

                if (check == true)
                {
                    rs = from s in db.Users
                         where (s.user_email ?? "") == (txtEmail.Text ?? "") & (s.phone_num ?? "") == (txtPhoneNum.Text ?? "")
                         select s;
                    foreach (var result in rs)
                    {
                        txtUsername.Text = result.username;
                        txtPassword.Text = result.password;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid both or one the Email or Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}