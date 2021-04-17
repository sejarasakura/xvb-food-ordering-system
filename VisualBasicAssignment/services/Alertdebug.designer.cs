using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment.CustomAlertBoxDemo
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // TODO ERROR: Skipped RegionDirectiveTrivia 
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(169, 101);
            button1.Name = "button1";
            button1.Size = new Size(204, 58);
            button1.TabIndex = 0;
            button1.Text = "Success";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(169, 165);
            button2.Name = "button2";
            button2.Size = new Size(204, 58);
            button2.TabIndex = 0;
            button2.Text = "Warning";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(169, 229);
            button3.Name = "button3";
            button3.Size = new Size(204, 58);
            button3.TabIndex = 0;
            button3.Text = "Error";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new EventHandler(button3_Click);
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(169, 293);
            button4.Name = "button4";
            button4.Size = new Size(204, 58);
            button4.TabIndex = 0;
            button4.Text = "info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new EventHandler(button4_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 35);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 1;
            label1.Text = "C# Ui Academy";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(555, 413);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        // TODO ERROR: Skipped EndRegionDirectiveTrivia 
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}