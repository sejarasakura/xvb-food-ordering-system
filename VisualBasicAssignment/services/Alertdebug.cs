using System;
using System.Windows.Forms;

namespace VisualBasicAssignment.CustomAlertBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            var frm = new Form_Alert();
            frm.showAlert(msg, type);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alert("Success Alert", Form_Alert.enmType.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alert("Warning Alert", Form_Alert.enmType.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alert("Error Alert", Form_Alert.enmType.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alert("Info Alert", Form_Alert.enmType.Info);
        }
    }
}