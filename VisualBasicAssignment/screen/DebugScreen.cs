using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class DebugScreen
    {
        public DebugScreen()
        {
            InitializeComponent();
            _Guna2Button1.Name = "Guna2Button1";
            _Guna2Button2.Name = "Guna2Button2";
            _Guna2Button3.Name = "Guna2Button3";
            _Guna2Button5.Name = "Guna2Button5";
            _Guna2Button6.Name = "Guna2Button6";
            _Guna2Button7.Name = "Guna2Button7";
            _Guna2Button8.Name = "Guna2Button8";
        }

        private ComboBox.ObjectCollection combo;
        private Dictionary<string, Form> data_dic = new Dictionary<string, Form>();

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Screen.NAV_HOME_SCREEN.Show();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            // Screen.NAV_ORDER_SCREEN.Show()
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            // Screen.NAV_PAYMENT_SCREEN.Show()
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            Screen.NAV_SPLASH_SCREEN.Show();
        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
            // Screen.ALERT_DEBUG.Show()
        }

        private void Guna2Button8_Click(object sender, EventArgs e)
        {
            Screen.NAV_FORM1_CUST.Show();
        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            Screen.NAV_FORM2_STAFF.Show();
        }
    }
}