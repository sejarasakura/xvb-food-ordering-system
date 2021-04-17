using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class Register
    {
        public Register()
        {
            InitializeComponent();
            _btnCreate.Name = "btnCreate";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();

        private void AutoGenerateCustId()
        {
            int rs = db.Users.Count();
            lblCustId.Text = (100000 + rs).ToString();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AutoGenerateCustId();
        }

        private bool IsDuplicatedName(string strName)
        {
            var db = new FoodShopEntities1();
            return db.Users.Any(o => (o.username ?? "") == (strName ?? ""));
        }

        private bool IsDuplicatedEmail(string strEmail)
        {
            var db = new FoodShopEntities1();
            return db.Users.Any(o => (o.user_email ?? "") == (strEmail ?? ""));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strName = txtUserName.Text.Trim();
            string strEmail = txtEmail.Text.Trim();
            string strPassword = txtPassword.Text.Trim();
            string strCPassword = txtConfirmPassword.Text.Trim();
            err.Tag = null;
            if (strName == "Username")
            {
                err.SetError(txtUserName, "Please type [Username]");
                err.Tag = err.Tag ?? txtUserName;
            }
            else if (IsDuplicatedName(strName))
            {
                err.SetError(txtUserName, "This [Username] is already taken");
                err.Tag = err.Tag ?? txtUserName;
            }
            else
            {
                err.SetError(txtUserName, null);
            }

            if (strEmail == "Email")
            {
                err.SetError(txtEmail, "Please type [Email]");
                err.Tag = err.Tag ?? txtEmail;
            }
            else if (IsDuplicatedEmail(strEmail))
            {
                err.SetError(txtEmail, "[Email] is already registered");
                err.Tag = err.Tag ?? txtEmail;
            }
            else
            {
                err.SetError(txtEmail, null);
            }

            if (strPassword == "Password" & strCPassword == "Confirm Password")
            {
                err.SetError(txtPassword, "Please type [Password]");
                err.Tag = err.Tag ?? txtPassword;
                err.SetError(txtConfirmPassword, "Please type [Confirm Password]");
                err.Tag = err.Tag ?? txtConfirmPassword;
            }
            else
            {
                err.SetError(txtPassword, null);
                err.SetError(txtConfirmPassword, null);
            }

            if ((strCPassword ?? "") != (strPassword ?? "") & strPassword != "Password" && strCPassword != "Confirm Password")
            {
                MessageBox.Show("Comfirm Password does not match!" + Constants.vbNewLine + "Please fill up again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (err.Tag is object)
            {
                ((Control)err.Tag).Focus();
                return;
            }

            var u = new User();
            u.user_id = Conversions.ToInteger(lblCustId.Text);
            u.username = strName;
            u.user_email = strEmail;
            u.password = strPassword;
            u.user_role = "c";
            var db = new FoodShopEntities1();
            db.Users.Add(u);
            db.SaveChanges();
            MessageBox.Show("Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}