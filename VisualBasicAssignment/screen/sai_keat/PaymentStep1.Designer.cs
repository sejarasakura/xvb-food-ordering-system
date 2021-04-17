using System.Diagnostics;
using System.Drawing;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PaymentStep1 : Master
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
            PaymentInfo1 = new PaymentInfo();
            SuspendLayout();
            // 
            // PaymentInfo1
            // 
            PaymentInfo1.BackColor = Color.Gainsboro;
            PaymentInfo1.Location = new Point(227, 189);
            PaymentInfo1.MaximumSize = new Size(1087, 535);
            PaymentInfo1.MinimumSize = new Size(1087, 535);
            PaymentInfo1.Name = "PaymentInfo1";
            PaymentInfo1.Size = new Size(1087, 535);
            PaymentInfo1.TabIndex = 8;
            // 
            // PaymentStep1
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            ClientSize = new Size(1333, 738);
            Controls.Add(PaymentInfo1);
            Name = "PaymentStep1";
            Controls.SetChildIndex(PaymentInfo1, 0);
            ResumeLayout(false);
        }

        internal PaymentInfo PaymentInfo1;
    }
}