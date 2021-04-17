using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class ModifyUser
    {
        public ModifyUser()
        {
            InitializeComponent();
            _btnBack.Name = "btnBack";
            _btnClear.Name = "btnClear";
            _btnUpdate.Name = "btnUpdate";
        }

        public string fid;
        private FoodShopEntities1 db = new FoodShopEntities1();

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            var rs = from u in db.Users
                     where u.user_id == Conversions.ToDouble(fid)
                     select u;
            foreach (var result in rs)
            {
                lblId.Text = fid;
                txtName.Text = result.username;
                txtEmail.Text = result.user_email;
                txtRole.Text = result.user_role;
                txtFName.Text = result.first_name;
                txtLName.Text = result.last_name;
                txtHPNumber.Text = result.phone_num;
                txtGender.Text = result.gender;
                txtPassword.Text = result.password;
                txtRole.Text = result.user_role;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var u = db.Users.FirstOrDefault(i => i.user_id == Conversions.ToDouble(fid));
            try
            {
                u.username = txtName.Text;
                u.user_email = txtEmail.Text;
                u.user_role = txtRole.Text;
                u.first_name = txtFName.Text;
                u.last_name = txtLName.Text;
                u.phone_num = txtHPNumber.Text;
                u.gender = txtGender.Text;
                u.password = txtPassword.Text;
                u.user_role = txtRole.Text;
                db.SaveChanges();
                MessageBox.Show("The data have been updated!!!", "Update Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid!!!" + Constants.vbNewLine + "Please fill up all, thanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }
    }
}