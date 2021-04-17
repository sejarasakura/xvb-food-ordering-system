using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment.CustomAlertBoxDemo
{
    public partial class Form_Alert : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));

        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private enmAction action;
        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    {
                        timer1.Interval = 5000;
                        action = enmAction.close;
                        break;
                    }

                case enmAction.start:
                    {
                        timer1.Interval = 1;
                        Opacity += 0.1d;
                        if (x < Location.X)
                        {
                            Left -= 1;
                        }
                        else if (Opacity == 1.0d)
                        {
                            action = enmAction.wait;
                        }

                        break;
                    }

                case enmAction.close:
                    {
                        timer1.Interval = 1;
                        Opacity -= 0.1d;
                        Left -= 3;
                        if (Opacity == 0.0d)
                        {
                            Close();
                        }

                        break;
                    }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert(string msg, enmType type)
        {
            Opacity = 0.0d;
            StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i <= 10 - 1; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];
                if (frm is null)
                {
                    Name = fname;
                    x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }
            }

            x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            switch (type)
            {
                case enmType.Success:
                    {
                        pictureBox1.Image = (Image)resources.GetObject("success");
                        BackColor = Color.SeaGreen;
                        break;
                    }

                case enmType.Error:
                    {
                        pictureBox1.Image = (Image)resources.GetObject("error");
                        BackColor = Color.DarkRed;
                        break;
                    }

                case enmType.Info:
                    {
                        pictureBox1.Image = (Image)resources.GetObject("info");
                        BackColor = Color.RoyalBlue;
                        break;
                    }

                case enmType.Warning:
                    {
                        pictureBox1.Image = (Image)resources.GetObject("warning");
                        BackColor = Color.DarkOrange;
                        break;
                    }
            }

            lblMsg.Text = msg;
            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}