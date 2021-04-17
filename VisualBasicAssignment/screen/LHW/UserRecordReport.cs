using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class UserRecordReport
    {
        public UserRecordReport()
        {
            InitializeComponent();
            _dgv.Name = "dgv";
            _btnDisplay.Name = "btnDisplay";
            _btnLogout.Name = "btnLogout";
            _btnBack.Name = "btnBack";
            _btnShowAll.Name = "btnShowAll";
            _btnReset.Name = "btnReset";
            _Guna2Button1.Name = "Guna2Button1";
            _btnAdd.Name = "btnAdd";
        }

        private FoodShopEntities1 db = new FoodShopEntities1();
        public string username;

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            username = "";
            Close();
            DatabaseConnections.SetLoginUser(null);
            My.MyProject.Forms.Login.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var rs = from o in db.Users
                     where o.username.Contains(mskUsername.Text)
                     select new
                     {
                         o.user_id,
                         o.username,
                         o.user_email,
                         o.user_role,
                         o.first_name,
                         o.last_name,
                         o.phone_num,
                         o.gender,
                         o.password
                     };
            dgv.DataSource = rs.ToList();
            updateItem();
        }

        private void updateItem()
        {
            lblItem.Text = dgv.Rows.Count.ToString("0 item(s)");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mskUsername.Clear();
            dgv.Rows.Clear();
            mskUsername.Focus();
            updateItem();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Login.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var rs = from o in db.Users
                     select new
                     {
                         o.user_id,
                         o.username,
                         o.user_email,
                         o.user_role,
                         o.first_name,
                         o.last_name,
                         o.phone_num,
                         o.gender,
                         o.password
                     };
            dgv.DataSource = rs.ToList();
            updateItem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AddUser.ShowDialog(this);
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            string fid = Conversions.ToString(dgv.Rows[i].Cells[0].Value);
            My.MyProject.Forms.ModifyUser.fid = fid;
            My.MyProject.Forms.ModifyUser.Show();
        }
    }
}