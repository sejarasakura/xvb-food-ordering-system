using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
            _txtName.Name = "txtName";
            _txtPassword.Name = "txtPassword";
            _btnCancel.Name = "btnCancel";
            _btnLogin.Name = "btnLogin";
            _LinkLabel1.Name = "LinkLabel1";
            _LinkLabel2.Name = "LinkLabel2";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();

        public void Page_Load(object Sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            var dbName = db.Users.SingleOrDefault(c => (c.username ?? "") == (Name ?? ""));
            btnCancel.BackColor = (Color)VRColor.WARNING_COLOR;
            btnLogin.BackColor = (Color)VRColor.COLORED_BG;
            MaximumSize = Size;
            // No Content
        }

        private void cancleBtnOnclick(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var db = new FoodShopEntities1();
            string name = txtName.Text;
            string password = txtPassword.Text;
            var dbName = db.Users.SingleOrDefault(c => (c.username ?? "") == (name ?? ""));
            var dbPassword = db.Users.SingleOrDefault(c => (c.password ?? "") == (txtPassword.Text ?? "") & (c.username ?? "") == (name ?? ""));
            err.Tag = null;
            if (string.IsNullOrEmpty(name))
            {
                err.SetError(txtName, "Please type username!");
                err.Tag = err.Tag ?? txtName;
            }

            if (string.IsNullOrEmpty(password))
            {
                err.SetError(txtPassword, "Please type password!");
                err.Tag = err.Tag ?? txtPassword;
            }
            else if (dbName is null)
            {
                err.SetError(txtName, "Please Insert Valid Username!");
                err.Tag = err.Tag ?? txtName;
            }
            else if (dbPassword is null)
            {
                err.SetError(txtPassword, "Please Insert Valid Password!");
                err.Tag = err.Tag ?? txtPassword;
            }
            else if (dbName.user_role == "c")
            {
                Hide();
                My.MyProject.Forms.Profile.username = name;
                DatabaseConnections.SetLoginUser(dbName);
                Screen.NAV_FORM1_CUST.Show();
            }
            else if (dbName.user_role == "s")
            {
                Hide();
                My.MyProject.Forms.Profile.username = name;
                DatabaseConnections.SetLoginUser(dbName);
                Screen.NAV_FORM2_STAFF.Show();
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Register.Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Register.ShowDialog(this);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.ForgotPassword.ShowDialog(this);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}