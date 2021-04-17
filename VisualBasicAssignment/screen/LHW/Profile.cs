using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class Profile
    {
        public Profile()
        {
            InitializeComponent();
            _txtReset.Name = "txtReset";
            _btnClear.Name = "btnClear";
            _Guna2Button1.Name = "Guna2Button1";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();
        public string username;

        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            var u = db.Users.FirstOrDefault(i => (i.username ?? "") == (username ?? ""));
            loaddata();
            if (u is object)
            {
                if (u.user_role == "s")
                {
                    grpBox.Text = "Staff Information";
                }
                else if (u.user_role == "c")
                {
                    grpBox.Text = "Customer Information";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtHPNumber.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();
            txtLName.Clear();
            txtFName.Clear();
            txtGender.Clear();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            var u = db.Users.FirstOrDefault(i => (i.username ?? "") == (username ?? ""));
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("User Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtName.Text ?? "") != (u.username ?? ""))
            {
                u.username = txtName.Text;
                db.SaveChanges();
                MessageBox.Show("The User Name already change!!!", "Successful Change User Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("User Email can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtEmail.Text ?? "") != (u.user_email ?? ""))
            {
                u.user_email = txtEmail.Text;
                db.SaveChanges();
                MessageBox.Show("The Email already change!!!", "Successful Change Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtHPNumber.Text))
            {
                MessageBox.Show("User H/P Number can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtHPNumber.Text ?? "") != (u.phone_num ?? ""))
            {
                u.phone_num = txtHPNumber.Text;
                db.SaveChanges();
                MessageBox.Show("The H/P Number already change!!!", "Successful Change H/P Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtLName.Text))
            {
                MessageBox.Show("User Last Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtLName.Text ?? "") != (u.last_name ?? ""))
            {
                u.last_name = txtLName.Text;
                db.SaveChanges();
                MessageBox.Show("The Last Name already change!!!", "Successful Change Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtFName.Text))
            {
                MessageBox.Show("First Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtFName.Text ?? "") != (u.first_name ?? ""))
            {
                u.first_name = txtFName.Text;
                db.SaveChanges();
                MessageBox.Show("The First Name already change!!!", "Successful Change First Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtGender.Text))
            {
                MessageBox.Show("Gender can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtGender.Text ?? "") != (u.gender ?? ""))
            {
                u.gender = txtGender.Text;
                db.SaveChanges();
                MessageBox.Show("The Gender already change!!!", "Successful Change Gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(txtCPassword.Text) & string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Invalid Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(txtCPassword.Text))
            {
                if ((txtCPassword.Text ?? "") == (txtPassword.Text ?? ""))
                {
                    u.password = txtPassword.Text;
                    db.SaveChanges();
                    MessageBox.Show("The Password already change!!!", "Successful Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("The Comfirm password is not same with the Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AutoGenerateCustId()
        {
            int rs = db.Users.Count();
            lblId.Text = (99999 + rs).ToString();
        }

        private void loaddata()
        {
            var rs = from s in db.Users
                     where (s.username ?? "") == (username ?? "")
                     select s;
            foreach (var result in rs)
            {
                AutoGenerateCustId();
                txtName.Text = result.username;
                txtEmail.Text = result.user_email;
                txtHPNumber.Text = result.phone_num;
                txtPassword.Text = result.password;
                txtLName.Text = result.last_name;
                txtFName.Text = result.first_name;
                txtGender.Text = result.gender;
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UserRecordReport.Show();
        }
    }
}