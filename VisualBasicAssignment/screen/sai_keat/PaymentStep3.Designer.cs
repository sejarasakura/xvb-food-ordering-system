using System.Diagnostics;
using System.Drawing;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PaymentStep3 : Master
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
            PaymentConfirm1 = new PaymentConfirm();
            SuspendLayout();
            // 
            // PaymentConfirm1
            // 
            PaymentConfirm1.Location = new Point(234, 191);
            PaymentConfirm1.MaximumSize = new Size(1087, 535);
            PaymentConfirm1.MinimumSize = new Size(1087, 535);
            PaymentConfirm1.Name = "PaymentConfirm1";
            PaymentConfirm1.Size = new Size(1087, 535);
            PaymentConfirm1.TabIndex = 8;
            // 
            // PaymentStep3
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            ClientSize = new Size(1333, 738);
            Controls.Add(PaymentConfirm1);
            Name = "PaymentStep3";
            Controls.SetChildIndex(PaymentConfirm1, 0);
            ResumeLayout(false);
        }

        internal PaymentConfirm PaymentConfirm1;
    }
}