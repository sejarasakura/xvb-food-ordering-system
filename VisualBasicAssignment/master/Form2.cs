﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    public partial class Form2
    {
        public Form2()
        {
            InitializeComponent();
            _btnMini.Name = "btnMini";
            _btnClose.Name = "btnClose";
            _btnOrder.Name = "btnOrder";
            _btnAddfood.Name = "btnAddfood";
            _btnMenu.Name = "btnMenu";
            _btnProfile.Name = "btnProfile";
            _picIcon.Name = "picIcon";
            _btnNav.Name = "btnNav";
        }

        private bool statusMax = true;
        private int navindex;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            // btnClose.Image = My.Resources.icons8_close_window_96
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            // btnClose.Image = My.Resources.icons8_close_window_96__1_
        }

        private void btnMini_MouseHover(object sender, EventArgs e)
        {
            // btnMini.Image = My.Resources.icons8_macos_minimize_90
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            // btnMini.Image = My.Resources.icons8_macos_minimize_96__1_
        }

        private void picIcon_MouseHover(object sender, EventArgs e)
        {
            // picIcon.Image = My.Resources.icon2
        }

        private void picIcon_MouseLeave(object sender, EventArgs e)
        {
            // picIcon.Image = My.Resources.icon1
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (statusMax == true)
            {
                btnProfile.Text = "";
                btnMenu.Text = "";
                btnAddfood.Text = "";
                btnOrder.Text = "";
                Panel1.Width -= 10;
                if (Panel1.Size == Panel1.MinimumSize)
                {
                    statusMax = false;
                    Timer1.Stop();
                }
            }
            else
            {
                btnProfile.Text = "PROFILE";
                btnMenu.Text = "MENU";
                btnAddfood.Text = "CART";
                btnOrder.Text = "ORDER";
                Panel1.Width += 10;
                if (Panel1.Size == Panel1.MaximumSize)
                {
                    statusMax = true;
                    Timer1.Stop();
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.FillColor = Color.White;
            btnProfile.ForeColor = Color.Black;
            checkNav(1);
            switchPanel(My.MyProject.Forms.Profile);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            btnAddfood.FillColor = Color.White;
            btnAddfood.ForeColor = Color.Black;
            checkNav(2);
            switchPanel(My.MyProject.Forms.addfood);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnOrder.FillColor = Color.White;
            btnOrder.ForeColor = Color.Black;
            checkNav(3);
            switchPanel2(new StaffOrder());
        }

        public void switchPanel2(Control panel)
        {
            Panel4.Controls.Clear();
            panel.Show();
            panel.Visible = true;
            Panel4.Controls.Add(panel);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.FillColor = Color.White;
            btnMenu.ForeColor = Color.Black;
            checkNav(4);
            switchPanel(My.MyProject.Forms.custmenu);
        }

        private void checkNav(int index)
        {
            switch (index)
            {
                case 1:
                    {
                        btnAddfood.FillColor = Color.FromArgb(3, 139, 205);
                        btnAddfood.ForeColor = Color.White;
                        btnOrder.FillColor = Color.FromArgb(3, 139, 205);
                        btnOrder.ForeColor = Color.White;
                        btnMenu.FillColor = Color.FromArgb(3, 139, 205);
                        btnMenu.ForeColor = Color.White;
                        break;
                    }

                case 2:
                    {
                        btnProfile.FillColor = Color.FromArgb(3, 139, 205);
                        btnProfile.ForeColor = Color.White;
                        btnOrder.FillColor = Color.FromArgb(3, 139, 205);
                        btnOrder.ForeColor = Color.White;
                        btnMenu.FillColor = Color.FromArgb(3, 139, 205);
                        btnMenu.ForeColor = Color.White;
                        break;
                    }

                case 3:
                    {
                        btnProfile.FillColor = Color.FromArgb(3, 139, 205);
                        btnProfile.ForeColor = Color.White;
                        btnAddfood.FillColor = Color.FromArgb(3, 139, 205);
                        btnAddfood.ForeColor = Color.White;
                        btnMenu.FillColor = Color.FromArgb(3, 139, 205);
                        btnMenu.ForeColor = Color.White;
                        break;
                    }

                case 4:
                    {
                        btnProfile.FillColor = Color.FromArgb(3, 139, 205);
                        btnProfile.ForeColor = Color.White;
                        btnAddfood.FillColor = Color.FromArgb(3, 139, 205);
                        btnAddfood.ForeColor = Color.White;
                        btnOrder.FillColor = Color.FromArgb(3, 139, 205);
                        btnOrder.ForeColor = Color.White;
                        break;
                    }
            }
        }

        public void switchPanel(Form panel)
        {
            Panel4.Controls.Clear();
            panel.TopLevel = false;
            Panel4.Controls.Add(panel);
            panel.Show();
        }





        // Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        // ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid)
        // End Sub

    }
}