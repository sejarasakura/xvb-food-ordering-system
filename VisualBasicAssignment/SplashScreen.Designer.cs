using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class SplashScreen : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Panel1 = new Panel();
            Panel2 = new Panel();
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(Timer1_Tick);
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(38)), Conversions.ToInteger(Conversions.ToByte(46)));
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Dock = DockStyle.Bottom;
            Panel1.Location = new Point(0, 389);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(700, 11);
            Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(97)), Conversions.ToInteger(Conversions.ToByte(148)));
            Panel2.Location = new Point(0, 389);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(46, 11);
            Panel2.TabIndex = 2;
            // 
            // Timer1
            // 
            _Timer1.Enabled = true;
            _Timer1.Interval = 15;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = My.Resources.Resources.splash_screen;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Dock = DockStyle.Fill;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(700, 400);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
        }

        internal PictureBox PictureBox1;
        internal Panel Panel1;
        internal Panel Panel2;
        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }
    }
}