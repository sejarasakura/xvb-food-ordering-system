using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VisualBasicAssignment
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class custmenu : Form
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
            pnlPicture = new FlowLayoutPanel();
            _btnReload = new Guna.UI2.WinForms.Guna2Button();
            _btnReload.Click += new EventHandler(btnReload_Click);
            SuspendLayout();
            // 
            // pnlPicture
            // 
            pnlPicture.Location = new Point(16, 15);
            pnlPicture.Margin = new Padding(4);
            pnlPicture.Name = "pnlPicture";
            pnlPicture.Size = new Size(1075, 498);
            pnlPicture.TabIndex = 0;
            // 
            // btnReload
            // 
            _btnReload.CheckedState.Parent = _btnReload;
            _btnReload.CustomImages.Parent = _btnReload;
            _btnReload.Font = new Font("Segoe UI", 9.0f);
            _btnReload.ForeColor = Color.White;
            _btnReload.HoverState.Parent = _btnReload;
            _btnReload.Location = new Point(958, 520);
            _btnReload.Name = "_btnReload";
            _btnReload.ShadowDecoration.Parent = _btnReload;
            _btnReload.Size = new Size(133, 26);
            _btnReload.TabIndex = 1;
            _btnReload.Text = "Reload";
            // 
            // custmenu
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 554);
            Controls.Add(_btnReload);
            Controls.Add(pnlPicture);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "custmenu";
            Text = "custmenu";
            Load += new EventHandler(custmenu_Load);
            ResumeLayout(false);
        }

        internal FlowLayoutPanel pnlPicture;
        private Guna.UI2.WinForms.Guna2Button _btnReload;

        internal Guna.UI2.WinForms.Guna2Button btnReload
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReload;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReload != null)
                {
                    _btnReload.Click -= btnReload_Click;
                }

                _btnReload = value;
                if (_btnReload != null)
                {
                    _btnReload.Click += btnReload_Click;
                }
            }
        }
    }
}