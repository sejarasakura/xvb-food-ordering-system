using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    public partial class NewOder
    {
        public NewOder()
        {
            InitializeComponent();
            _btnClear.Name = "btnClear";
            _btnAdd.Name = "btnAdd";
            _nudQuantity.Name = "nudQuantity";
            _dgvOrder.Name = "dgvOrder";
            _btnPayment.Name = "btnPayment";
            _Label1.Name = "Label1";
        }

        private void Page_Load(object sender, EventArgs e)
        {
            var u = DatabaseConnections.GetLoginUser();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    dgvOrder.DataSource = (from d in db.Foods
                                           select new { d.id, d.title, d.price }).ToList();
                    var cat = db.PaymentStatus.ToList();
                    cmbStatus.DataSource = cat;
                    cmbStatus.ValueMember = "id";
                    cmbStatus.DisplayMember = "name";
                    var met = db.PaymentMethods.ToList();
                    cmbMethod.DataSource = met;
                    cmbMethod.ValueMember = "id";
                    cmbMethod.DisplayMember = "name";
                    var user = db.Users.ToList();
                    cmbUser.DataSource = user;
                    cmbUser.ValueMember = "user_id";
                    cmbUser.DisplayMember = "username";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string foodName = Conversions.ToString(dgvOrder.SelectedRows[0].Cells[1].Value);
            lblTitle.Text = foodName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrder.Rows.Clear();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int foodId = Conversions.ToInteger(dgvOrder.SelectedRows[0].Cells[0].Value);
            var dgvr = dgvOrder.SelectedRows[0];
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    dgvOrderDetails.Rows.Add(dgvr.Cells[0].Value, dgvr.Cells[1].Value, dgvr.Cells[2].Value, nudQuantity.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentDetail pd;
            if (dgvOrderDetails.Rows.Count <= 0)
            {
                return;
            }

            using (var db = new FoodShopEntities1())
            {
                var total = default(double);
                var newPaynment = new Payment();
                newPaynment.payment_status = (Guid)cmbStatus.SelectedValue;
                newPaynment.user_id = Conversions.ToInteger(cmbUser.SelectedValue);
                newPaynment.payment_date = DateTime.Now;
                newPaynment.id = Guid.NewGuid();
                newPaynment.notes = "";
                newPaynment.payment_method = (Guid)cmbMethod.SelectedValue;
                newPaynment.payment_meta = "";
                for (int i = 0, loopTo = dgvOrderDetails.Rows.Count - 1; i <= loopTo; i++)
                {
                    int foodid = Conversions.ToInteger(dgvOrderDetails.Rows[i].Cells[0].Value);
                    int quan = Conversions.ToInteger(dgvOrderDetails.Rows[i].Cells[3].Value);
                    var food = db.Foods.Find((object)foodid);
                    total += Convert.ToDouble(food.price * quan);
                    pd = new PaymentDetail();
                    pd.add_date = DateTime.Now;
                    pd.quantity = quan;
                    pd.food_id = foodid;
                    pd.payment_id = newPaynment.id;
                    newPaynment.PaymentDetails.Add(pd);
                }

                newPaynment.net_pay = total;
                newPaynment.tax_change = total * 0.06d;
                newPaynment.total_pay = total * 1.06d;
                db.Payments.Add(newPaynment);
                try
                {
                    dgvOrderDetails.Rows.Clear();
                    MessageBox.Show("The order is sucessfull added to the system", "Payment order sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The order is no added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }
    }
}