using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class UserRecordReport : Form
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
            _dgv = new DataGridView();
            _dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
            lblSelUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _btnDisplay = new Guna.UI2.WinForms.Guna2Button();
            _btnDisplay.Click += new EventHandler(btnDisplay_Click);
            _btnLogout = new Guna.UI2.WinForms.Guna2Button();
            _btnLogout.Click += new EventHandler(btnLogout_Click);
            _btnBack = new Guna.UI2.WinForms.Guna2Button();
            _btnBack.Click += new EventHandler(btnBack_Click);
            _btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            _btnShowAll.Click += new EventHandler(btnShowAll_Click);
            _btnReset = new Guna.UI2.WinForms.Guna2Button();
            _btnReset.Click += new EventHandler(btnReset_Click);
            mskUsername = new MaskedTextBox();
            lblItem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            _Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            _Guna2Button1.Click += new EventHandler(btnDisplay_Click);
            _btnAdd = new Guna.UI2.WinForms.Guna2Button();
            _btnAdd.Click += new EventHandler(btnAdd_Click);
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgv.Location = new Point(33, 63);
            _dgv.Name = "_dgv";
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 24;
            _dgv.Size = new Size(719, 224);
            _dgv.TabIndex = 4;
            // 
            // lblSelUser
            // 
            lblSelUser.AutoSize = false;
            lblSelUser.BackColor = Color.Transparent;
            lblSelUser.Location = new Point(12, 12);
            lblSelUser.Name = "lblSelUser";
            lblSelUser.Size = new Size(200, 27);
            lblSelUser.TabIndex = 9;
            lblSelUser.Text = "Select User Name:";
            // 
            // btnDisplay
            // 
            _btnDisplay.CheckedState.Parent = _btnDisplay;
            _btnDisplay.CustomImages.Parent = _btnDisplay;
            _btnDisplay.Font = new Font("Segoe UI", 9.0f);
            _btnDisplay.ForeColor = Color.White;
            _btnDisplay.HoverState.Parent = _btnDisplay;
            _btnDisplay.Location = new Point(444, 12);
            _btnDisplay.Name = "_btnDisplay";
            _btnDisplay.ShadowDecoration.Parent = _btnDisplay;
            _btnDisplay.Size = new Size(132, 45);
            _btnDisplay.TabIndex = 3;
            _btnDisplay.Text = "Display";
            // 
            // btnLogout
            // 
            _btnLogout.CheckedState.Parent = _btnLogout;
            _btnLogout.CustomImages.Parent = _btnLogout;
            _btnLogout.Font = new Font("Segoe UI", 9.0f);
            _btnLogout.ForeColor = Color.White;
            _btnLogout.HoverState.Parent = _btnLogout;
            _btnLogout.Location = new Point(656, 382);
            _btnLogout.Name = "_btnLogout";
            _btnLogout.ShadowDecoration.Parent = _btnLogout;
            _btnLogout.Size = new Size(132, 45);
            _btnLogout.TabIndex = 3;
            _btnLogout.Text = "Log Out";
            // 
            // btnBack
            // 
            _btnBack.CheckedState.Parent = _btnBack;
            _btnBack.CustomImages.Parent = _btnBack;
            _btnBack.Font = new Font("Segoe UI", 9.0f);
            _btnBack.ForeColor = Color.White;
            _btnBack.HoverState.Parent = _btnBack;
            _btnBack.Location = new Point(444, 382);
            _btnBack.Name = "_btnBack";
            _btnBack.ShadowDecoration.Parent = _btnBack;
            _btnBack.Size = new Size(132, 45);
            _btnBack.TabIndex = 3;
            _btnBack.Text = "Back";
            // 
            // btnShowAll
            // 
            _btnShowAll.CheckedState.Parent = _btnShowAll;
            _btnShowAll.CustomImages.Parent = _btnShowAll;
            _btnShowAll.Font = new Font("Segoe UI", 9.0f);
            _btnShowAll.ForeColor = Color.White;
            _btnShowAll.HoverState.Parent = _btnShowAll;
            _btnShowAll.Location = new Point(656, 314);
            _btnShowAll.Name = "_btnShowAll";
            _btnShowAll.ShadowDecoration.Parent = _btnShowAll;
            _btnShowAll.Size = new Size(132, 45);
            _btnShowAll.TabIndex = 3;
            _btnShowAll.Text = "Show All";
            // 
            // btnReset
            // 
            _btnReset.CheckedState.Parent = _btnReset;
            _btnReset.CustomImages.Parent = _btnReset;
            _btnReset.Font = new Font("Segoe UI", 9.0f);
            _btnReset.ForeColor = Color.White;
            _btnReset.HoverState.Parent = _btnReset;
            _btnReset.Location = new Point(656, 12);
            _btnReset.Name = "_btnReset";
            _btnReset.ShadowDecoration.Parent = _btnReset;
            _btnReset.Size = new Size(132, 45);
            _btnReset.TabIndex = 3;
            _btnReset.Text = "Reset";
            // 
            // mskUsername
            // 
            mskUsername.Location = new Point(229, 12);
            mskUsername.Name = "mskUsername";
            mskUsername.Size = new Size(148, 22);
            mskUsername.TabIndex = 11;
            // 
            // lblItem
            // 
            lblItem.AutoSize = false;
            lblItem.BackColor = Color.Transparent;
            lblItem.Location = new Point(26, 308);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(168, 51);
            lblItem.TabIndex = 9;
            lblItem.Text = "0 item(s)";
            // 
            // Guna2Button1
            // 
            _Guna2Button1.CheckedState.Parent = _Guna2Button1;
            _Guna2Button1.CustomImages.Parent = _Guna2Button1;
            _Guna2Button1.Font = new Font("Segoe UI", 9.0f);
            _Guna2Button1.ForeColor = Color.White;
            _Guna2Button1.HoverState.Parent = _Guna2Button1;
            _Guna2Button1.Location = new Point(529, 242);
            _Guna2Button1.Name = "_Guna2Button1";
            _Guna2Button1.ShadowDecoration.Parent = _Guna2Button1;
            _Guna2Button1.Size = new Size(132, 45);
            _Guna2Button1.TabIndex = 3;
            _Guna2Button1.Text = "Display";
            // 
            // btnAdd
            // 
            _btnAdd.CheckedState.Parent = _btnAdd;
            _btnAdd.CustomImages.Parent = _btnAdd;
            _btnAdd.Font = new Font("Segoe UI", 9.0f);
            _btnAdd.ForeColor = Color.White;
            _btnAdd.HoverState.Parent = _btnAdd;
            _btnAdd.Location = new Point(444, 314);
            _btnAdd.Name = "_btnAdd";
            _btnAdd.ShadowDecoration.Parent = _btnAdd;
            _btnAdd.Size = new Size(132, 45);
            _btnAdd.TabIndex = 3;
            _btnAdd.Text = "Add";
            // 
            // UserRecordReport
            // 
            AcceptButton = _btnDisplay;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mskUsername);
            Controls.Add(lblItem);
            Controls.Add(lblSelUser);
            Controls.Add(_dgv);
            Controls.Add(_btnReset);
            Controls.Add(_Guna2Button1);
            Controls.Add(_btnDisplay);
            Controls.Add(_btnAdd);
            Controls.Add(_btnShowAll);
            Controls.Add(_btnBack);
            Controls.Add(_btnLogout);
            Name = "UserRecordReport";
            Text = "User Record";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            Load += new EventHandler(Admin_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _dgv;

        internal DataGridView dgv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgv != null)
                {
                    _dgv.RowHeaderMouseDoubleClick -= dgv_RowHeaderMouseDoubleClick;
                }

                _dgv = value;
                if (_dgv != null)
                {
                    _dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel lblSelUser;
        private Guna.UI2.WinForms.Guna2Button _btnDisplay;

        internal Guna.UI2.WinForms.Guna2Button btnDisplay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDisplay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDisplay != null)
                {
                    _btnDisplay.Click -= btnDisplay_Click;
                }

                _btnDisplay = value;
                if (_btnDisplay != null)
                {
                    _btnDisplay.Click += btnDisplay_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnLogout;

        internal Guna.UI2.WinForms.Guna2Button btnLogout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnLogout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnLogout != null)
                {
                    _btnLogout.Click -= btnLogout_Click;
                }

                _btnLogout = value;
                if (_btnLogout != null)
                {
                    _btnLogout.Click += btnLogout_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnBack;

        internal Guna.UI2.WinForms.Guna2Button btnBack
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnBack;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnBack != null)
                {
                    _btnBack.Click -= btnBack_Click;
                }

                _btnBack = value;
                if (_btnBack != null)
                {
                    _btnBack.Click += btnBack_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnShowAll;

        internal Guna.UI2.WinForms.Guna2Button btnShowAll
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnShowAll;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnShowAll != null)
                {
                    _btnShowAll.Click -= btnShowAll_Click;
                }

                _btnShowAll = value;
                if (_btnShowAll != null)
                {
                    _btnShowAll.Click += btnShowAll_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnReset;

        internal Guna.UI2.WinForms.Guna2Button btnReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReset != null)
                {
                    _btnReset.Click -= btnReset_Click;
                }

                _btnReset = value;
                if (_btnReset != null)
                {
                    _btnReset.Click += btnReset_Click;
                }
            }
        }

        internal MaskedTextBox mskUsername;
        internal Guna.UI2.WinForms.Guna2HtmlLabel lblItem;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button1;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click -= btnDisplay_Click;
                }

                _Guna2Button1 = value;
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click += btnDisplay_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _btnAdd;

        internal Guna.UI2.WinForms.Guna2Button btnAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd != null)
                {
                    _btnAdd.Click -= btnAdd_Click;
                }

                _btnAdd = value;
                if (_btnAdd != null)
                {
                    _btnAdd.Click += btnAdd_Click;
                }
            }
        }
    }
}