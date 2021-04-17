using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HomeScreen : Master
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            Panel4 = new Panel();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            Panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Panel4
            // 
            Panel4.Controls.Add(Guna2HtmlLabel1);
            Panel4.Location = new Point(234, 191);
            Panel4.MaximumSize = new Size(1087, 535);
            Panel4.MinimumSize = new Size(1087, 535);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1087, 535);
            Panel4.TabIndex = 8;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.AutoSize = false;
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Location = new Point(3, 2);
            Guna2HtmlLabel1.MaximumSize = new Size(1085, 533);
            Guna2HtmlLabel1.MinimumSize = new Size(1085, 533);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(1085, 533);
            Guna2HtmlLabel1.TabIndex = 0;
            Guna2HtmlLabel1.Text = resources.GetString("Guna2HtmlLabel1.Text");
            // 
            // DataRepeater1
            // 
            DataRepeater1.Controls.Add(DataRepeater1.ItemTemplate);
            DataRepeater1.Location = new Point(0, 0);
            DataRepeater1.Name = "DataRepeater1";
            DataRepeater1.Size = new Size(240, 150);
            DataRepeater1.TabIndex = 0;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            ClientSize = new Size(1333, 738);
            Controls.Add(Panel4);
            Name = "HomeScreen";
            Controls.SetChildIndex(Panel4, 0);
            Panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal Panel Panel4;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Microsoft.VisualBasic.PowerPacks.DataRepeater DataRepeater1;
    }
}