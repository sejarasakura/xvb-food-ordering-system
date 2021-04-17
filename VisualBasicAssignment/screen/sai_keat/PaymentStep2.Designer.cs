using System.Diagnostics;
using System.Drawing;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PaymentStep2 : Master
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
            PaymentMethods1 = new PaymentMethods();
            SuspendLayout();
            // 
            // PaymentMethods1
            // 
            PaymentMethods1.Location = new Point(234, 189);
            PaymentMethods1.MaximumSize = new Size(1087, 535);
            PaymentMethods1.MinimumSize = new Size(1087, 535);
            PaymentMethods1.Name = "PaymentMethods1";
            PaymentMethods1.Size = new Size(1087, 535);
            PaymentMethods1.TabIndex = 8;
            // 
            // PaymentStep2
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            ClientSize = new Size(1333, 738);
            Controls.Add(PaymentMethods1);
            Name = "PaymentStep2";
            Controls.SetChildIndex(PaymentMethods1, 0);
            ResumeLayout(false);
        }

        internal PaymentMethods PaymentMethods1;
    }
}