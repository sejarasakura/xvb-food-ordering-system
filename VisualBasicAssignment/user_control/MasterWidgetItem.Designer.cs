using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MasterWidgetItem : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
            SuspendLayout();
            // 
            // MasterWidgetItem
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            MaximumSize = new Size(1087, 535);
            MinimumSize = new Size(1087, 535);
            Name = "MasterWidgetItem";
            Size = new Size(1087, 535);
            ResumeLayout(false);
        }
    }
}