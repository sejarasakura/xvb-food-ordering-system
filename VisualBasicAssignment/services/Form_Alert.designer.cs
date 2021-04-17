using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment.CustomAlertBoxDemo
{
    public partial class Form_Alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <paramname>true if managed resources should be disposed; otherwise, false.</param>
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
            components = new Container();
            var resources = new ComponentResourceManager(typeof(Form_Alert));
            lblMsg = new Label();
            timer1 = new Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.ForeColor = Color.White;
            lblMsg.Location = new Point(65, 22);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(96, 17);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "Message Text";
            lblMsg.UseMnemonic = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(298, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 30);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form_Alert
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(347, 74);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblMsg);
            Name = "Form_Alert";
            Text = "Form_Alert";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        // TODO ERROR: Skipped EndRegionDirectiveTrivia 
        private Label lblMsg;
        private PictureBox pictureBox1;
        internal Timer timer1;
        private PictureBox pictureBox2;
    }
}