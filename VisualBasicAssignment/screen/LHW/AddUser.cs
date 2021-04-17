using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class AddUser
    {
        public AddUser()
        {
            InitializeComponent();
            _btnClear.Name = "btnClear";
            _btnAdd.Name = "btnAdd";
            _btnBack.Name = "btnBack";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();
        public string username;

        private void AddUser_Load(object sender, EventArgs e)
        {
            AutoGenerateId();
        }

        private void AutoGenerateId()
        {
            int rs = db.Users.Count();
            lblId.Text = (99999 + rs).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var u = new User();
                u.user_id = Conversions.ToInteger(lblId.Text);
                u.username = txtName.Text;
                u.user_email = txtEmail.Text;
                u.phone_num = txtHPNumber.Text;
                u.password = txtPassword.Text;
                u.last_name = txtLName.Text;
                u.first_name = txtFName.Text;
                u.gender = txtGender.Text;
                u.user_role = txtRole.Text;
                db.Users.Add(u);
                db.SaveChanges();
                MessageBox.Show("User has been added.", "Add Data Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoGenerateId();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid!!!" + Constants.vbNewLine + "Please fill up all, thanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtHPNumber.Text = "";
            txtPassword.Text = "";
            txtLName.Text = "";
            txtFName.Text = "";
            txtGender.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}