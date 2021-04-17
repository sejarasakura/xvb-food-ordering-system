using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class PaymentInfo : MasterWidgetItem
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
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfo));
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lblTitle = new Label();
            Guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            txbAddressDetails2 = new Guna.UI2.WinForms.Guna2TextBox();
            Label5 = new Label();
            txbCompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            Label4 = new Label();
            txbNote = new Guna.UI2.WinForms.Guna2TextBox();
            ckbHavingHere = new Guna.UI2.WinForms.Guna2CheckBox();
            Label3 = new Label();
            txbAddressDetails = new Guna.UI2.WinForms.Guna2TextBox();
            Label2 = new Label();
            txbName = new Guna.UI2.WinForms.Guna2TextBox();
            Label1 = new Label();
            txbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dgvPaymnet = new Guna.UI2.WinForms.Guna2DataGridView();
            Guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            _btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            _btnCheckout.Click += new EventHandler(btnCheckout_Click);
            PictureBox4 = new PictureBox();
            PictureBox3 = new PictureBox();
            PictureBox2 = new PictureBox();
            PictureBox1 = new PictureBox();
            err = new ErrorProvider(components);
            Guna2ShadowPanel1.SuspendLayout();
            Guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymnet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(3, 56);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(1044, 12);
            Guna2Separator1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.Location = new Point(442, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Checkout";
            // 
            // Guna2ShadowPanel1
            // 
            Guna2ShadowPanel1.BackColor = Color.Transparent;
            Guna2ShadowPanel1.Controls.Add(txbAddressDetails2);
            Guna2ShadowPanel1.Controls.Add(Label5);
            Guna2ShadowPanel1.Controls.Add(txbCompanyName);
            Guna2ShadowPanel1.Controls.Add(Label4);
            Guna2ShadowPanel1.Controls.Add(txbNote);
            Guna2ShadowPanel1.Controls.Add(ckbHavingHere);
            Guna2ShadowPanel1.Controls.Add(Label3);
            Guna2ShadowPanel1.Controls.Add(txbAddressDetails);
            Guna2ShadowPanel1.Controls.Add(Label2);
            Guna2ShadowPanel1.Controls.Add(txbName);
            Guna2ShadowPanel1.Controls.Add(Label1);
            Guna2ShadowPanel1.Controls.Add(txbPhoneNumber);
            Guna2ShadowPanel1.FillColor = Color.White;
            Guna2ShadowPanel1.Location = new Point(13, 74);
            Guna2ShadowPanel1.Name = "Guna2ShadowPanel1";
            Guna2ShadowPanel1.Radius = 3;
            Guna2ShadowPanel1.ShadowColor = Color.Black;
            Guna2ShadowPanel1.Size = new Size(632, 448);
            Guna2ShadowPanel1.TabIndex = 2;
            // 
            // txbAddressDetails2
            // 
            txbAddressDetails2.BorderRadius = 5;
            txbAddressDetails2.Cursor = Cursors.IBeam;
            txbAddressDetails2.DefaultText = "";
            txbAddressDetails2.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbAddressDetails2.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbAddressDetails2.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbAddressDetails2.DisabledState.Parent = txbAddressDetails2;
            txbAddressDetails2.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbAddressDetails2.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbAddressDetails2.FocusedState.Parent = txbAddressDetails2;
            txbAddressDetails2.Font = new Font("Segoe UI", 9.0f);
            txbAddressDetails2.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbAddressDetails2.HoverState.Parent = txbAddressDetails2;
            txbAddressDetails2.Location = new Point(149, 159);
            txbAddressDetails2.Name = "txbAddressDetails2";
            txbAddressDetails2.PasswordChar = '\0';
            txbAddressDetails2.PlaceholderText = "none";
            txbAddressDetails2.SelectedText = "";
            txbAddressDetails2.ShadowDecoration.Parent = txbAddressDetails2;
            txbAddressDetails2.Size = new Size(470, 32);
            txbAddressDetails2.TabIndex = 14;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.8f);
            Label5.Location = new Point(10, 71);
            Label5.Name = "Label5";
            Label5.Size = new Size(133, 20);
            Label5.TabIndex = 13;
            Label5.Text = "Company Name:";
            // 
            // txbCompanyName
            // 
            txbCompanyName.BorderRadius = 5;
            txbCompanyName.Cursor = Cursors.IBeam;
            txbCompanyName.DefaultText = "";
            txbCompanyName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbCompanyName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbCompanyName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCompanyName.DisabledState.Parent = txbCompanyName;
            txbCompanyName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbCompanyName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCompanyName.FocusedState.Parent = txbCompanyName;
            txbCompanyName.Font = new Font("Segoe UI", 9.0f);
            txbCompanyName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbCompanyName.HoverState.Parent = txbCompanyName;
            txbCompanyName.Location = new Point(149, 65);
            txbCompanyName.Name = "txbCompanyName";
            txbCompanyName.PasswordChar = '\0';
            txbCompanyName.PlaceholderText = "(Optional)";
            txbCompanyName.SelectedText = "";
            txbCompanyName.ShadowDecoration.Parent = txbCompanyName;
            txbCompanyName.Size = new Size(470, 32);
            txbCompanyName.TabIndex = 12;
            txbCompanyName.Tag = "";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.8f);
            Label4.Location = new Point(10, 313);
            Label4.Name = "Label4";
            Label4.Size = new Size(63, 20);
            Label4.TabIndex = 11;
            Label4.Text = "Notes: ";
            // 
            // txbNote
            // 
            txbNote.BorderRadius = 5;
            txbNote.Cursor = Cursors.IBeam;
            txbNote.DefaultText = "";
            txbNote.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbNote.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbNote.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbNote.DisabledState.Parent = txbNote;
            txbNote.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbNote.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbNote.FocusedState.Parent = txbNote;
            txbNote.Font = new Font("Segoe UI", 9.0f);
            txbNote.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbNote.HoverState.Parent = txbNote;
            txbNote.Location = new Point(149, 307);
            txbNote.Name = "txbNote";
            txbNote.PasswordChar = '\0';
            txbNote.PlaceholderText = "Leave notes to us";
            txbNote.SelectedText = "";
            txbNote.ShadowDecoration.Parent = txbNote;
            txbNote.Size = new Size(470, 32);
            txbNote.TabIndex = 10;
            // 
            // ckbHavingHere
            // 
            ckbHavingHere.AutoSize = true;
            ckbHavingHere.CheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            ckbHavingHere.CheckedState.BorderRadius = 0;
            ckbHavingHere.CheckedState.BorderThickness = 0;
            ckbHavingHere.CheckedState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            ckbHavingHere.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ckbHavingHere.Location = new Point(428, 397);
            ckbHavingHere.Name = "ckbHavingHere";
            ckbHavingHere.Size = new Size(191, 29);
            ckbHavingHere.TabIndex = 7;
            ckbHavingHere.Text = "Having lunch here";
            ckbHavingHere.UncheckedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(125)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            ckbHavingHere.UncheckedState.BorderRadius = 0;
            ckbHavingHere.UncheckedState.BorderThickness = 0;
            ckbHavingHere.UncheckedState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(125)), Conversions.ToInteger(Conversions.ToByte(137)), Conversions.ToInteger(Conversions.ToByte(149)));
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.8f);
            Label3.Location = new Point(10, 115);
            Label3.Name = "Label3";
            Label3.Size = new Size(139, 20);
            Label3.TabIndex = 6;
            Label3.Text = "Address Details: ";
            // 
            // txbAddressDetails
            // 
            txbAddressDetails.BorderRadius = 5;
            txbAddressDetails.Cursor = Cursors.IBeam;
            txbAddressDetails.DefaultText = "";
            txbAddressDetails.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbAddressDetails.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbAddressDetails.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbAddressDetails.DisabledState.Parent = txbAddressDetails;
            txbAddressDetails.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbAddressDetails.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbAddressDetails.FocusedState.Parent = txbAddressDetails;
            txbAddressDetails.Font = new Font("Segoe UI", 9.0f);
            txbAddressDetails.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbAddressDetails.HoverState.Parent = txbAddressDetails;
            txbAddressDetails.Location = new Point(149, 109);
            txbAddressDetails.Name = "txbAddressDetails";
            txbAddressDetails.PasswordChar = '\0';
            txbAddressDetails.PlaceholderText = "none";
            txbAddressDetails.SelectedText = "";
            txbAddressDetails.ShadowDecoration.Parent = txbAddressDetails;
            txbAddressDetails.Size = new Size(470, 32);
            txbAddressDetails.TabIndex = 5;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.8f);
            Label2.Location = new Point(10, 28);
            Label2.Name = "Label2";
            Label2.Size = new Size(63, 20);
            Label2.TabIndex = 4;
            Label2.Text = "Name: ";
            // 
            // txbName
            // 
            txbName.BorderRadius = 5;
            txbName.Cursor = Cursors.IBeam;
            txbName.DefaultText = "";
            txbName.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbName.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbName.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbName.DisabledState.Parent = txbName;
            txbName.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbName.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbName.FocusedState.Parent = txbName;
            txbName.Font = new Font("Segoe UI", 9.0f);
            txbName.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbName.HoverState.Parent = txbName;
            txbName.Location = new Point(149, 22);
            txbName.Name = "txbName";
            txbName.PasswordChar = '\0';
            txbName.PlaceholderText = "Full name";
            txbName.SelectedText = "";
            txbName.ShadowDecoration.Parent = txbName;
            txbName.Size = new Size(470, 32);
            txbName.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.8f);
            Label1.Location = new Point(10, 265);
            Label1.Name = "Label1";
            Label1.Size = new Size(130, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Phone Number: ";
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.BorderRadius = 5;
            txbPhoneNumber.Cursor = Cursors.IBeam;
            txbPhoneNumber.DefaultText = "";
            txbPhoneNumber.DisabledState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)), Conversions.ToInteger(Conversions.ToByte(208)));
            txbPhoneNumber.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(226)));
            txbPhoneNumber.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbPhoneNumber.DisabledState.Parent = txbPhoneNumber;
            txbPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)), Conversions.ToInteger(Conversions.ToByte(138)));
            txbPhoneNumber.FocusedState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbPhoneNumber.FocusedState.Parent = txbPhoneNumber;
            txbPhoneNumber.Font = new Font("Segoe UI", 9.0f);
            txbPhoneNumber.HoverState.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(94)), Conversions.ToInteger(Conversions.ToByte(148)), Conversions.ToInteger(Conversions.ToByte(255)));
            txbPhoneNumber.HoverState.Parent = txbPhoneNumber;
            txbPhoneNumber.Location = new Point(149, 259);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.PasswordChar = '\0';
            txbPhoneNumber.PlaceholderText = "eg. 60183927135";
            txbPhoneNumber.SelectedText = "";
            txbPhoneNumber.ShadowDecoration.Parent = txbPhoneNumber;
            txbPhoneNumber.Size = new Size(470, 32);
            txbPhoneNumber.TabIndex = 0;
            // 
            // Guna2ShadowPanel2
            // 
            Guna2ShadowPanel2.AutoScroll = true;
            Guna2ShadowPanel2.BackColor = Color.Transparent;
            Guna2ShadowPanel2.Controls.Add(dgvPaymnet);
            Guna2ShadowPanel2.FillColor = Color.White;
            Guna2ShadowPanel2.Location = new Point(651, 74);
            Guna2ShadowPanel2.Name = "Guna2ShadowPanel2";
            Guna2ShadowPanel2.Radius = 3;
            Guna2ShadowPanel2.ShadowColor = Color.Black;
            Guna2ShadowPanel2.Size = new Size(396, 320);
            Guna2ShadowPanel2.TabIndex = 3;
            // 
            // dgvPaymnet
            // 
            dgvPaymnet.AllowUserToAddRows = false;
            dgvPaymnet.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            dgvPaymnet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvPaymnet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymnet.BackgroundColor = Color.White;
            dgvPaymnet.BorderStyle = BorderStyle.None;
            dgvPaymnet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPaymnet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPaymnet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvPaymnet.ColumnHeadersHeight = 27;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPaymnet.DefaultCellStyle = DataGridViewCellStyle3;
            dgvPaymnet.EnableHeadersVisualStyles = false;
            dgvPaymnet.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvPaymnet.Location = new Point(16, 12);
            dgvPaymnet.Name = "dgvPaymnet";
            dgvPaymnet.ReadOnly = true;
            dgvPaymnet.RowHeadersVisible = false;
            dgvPaymnet.RowHeadersWidth = 51;
            dgvPaymnet.RowTemplate.Height = 24;
            dgvPaymnet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymnet.Size = new Size(363, 292);
            dgvPaymnet.TabIndex = 1;
            dgvPaymnet.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            dgvPaymnet.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPaymnet.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPaymnet.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPaymnet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPaymnet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPaymnet.ThemeStyle.BackColor = Color.White;
            dgvPaymnet.ThemeStyle.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvPaymnet.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvPaymnet.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPaymnet.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5f);
            dgvPaymnet.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPaymnet.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPaymnet.ThemeStyle.HeaderStyle.Height = 27;
            dgvPaymnet.ThemeStyle.ReadOnly = true;
            dgvPaymnet.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPaymnet.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPaymnet.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5f);
            dgvPaymnet.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            dgvPaymnet.ThemeStyle.RowsStyle.Height = 24;
            dgvPaymnet.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvPaymnet.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            // 
            // btnCheckout
            // 
            _btnCheckout.BorderRadius = 5;
            _btnCheckout.CheckedState.Parent = _btnCheckout;
            _btnCheckout.CustomImages.Parent = _btnCheckout;
            _btnCheckout.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnCheckout.Font = new Font("Segoe UI Black", 16.0f, FontStyle.Bold);
            _btnCheckout.ForeColor = Color.White;
            _btnCheckout.HoverState.Parent = _btnCheckout;
            _btnCheckout.Location = new Point(652, 401);
            _btnCheckout.Name = "_btnCheckout";
            _btnCheckout.ShadowDecoration.Parent = _btnCheckout;
            _btnCheckout.Size = new Size(395, 64);
            _btnCheckout.TabIndex = 8;
            _btnCheckout.Text = "Checkout";
            // 
            // PictureBox4
            // 
            PictureBox4.Image = (Image)resources.GetObject("PictureBox4.Image");
            PictureBox4.Location = new Point(963, 471);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(67, 51);
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox4.TabIndex = 7;
            PictureBox4.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(876, 471);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(81, 51);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 6;
            PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(757, 471);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(93, 51);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 5;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(651, 471);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(81, 51);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 4;
            PictureBox1.TabStop = false;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // PaymentInfo
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            BackColor = Color.Gainsboro;
            Controls.Add(_btnCheckout);
            Controls.Add(PictureBox4);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(Guna2ShadowPanel2);
            Controls.Add(Guna2ShadowPanel1);
            Controls.Add(lblTitle);
            Controls.Add(Guna2Separator1);
            Name = "PaymentInfo";
            Guna2ShadowPanel1.ResumeLayout(false);
            Guna2ShadowPanel1.PerformLayout();
            Guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPaymnet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            Load += new EventHandler(PaymentInfo_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal Label lblTitle;
        internal Guna.UI2.WinForms.Guna2ShadowPanel Guna2ShadowPanel1;
        internal Guna.UI2.WinForms.Guna2TextBox txbPhoneNumber;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox txbAddressDetails;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txbName;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2CheckBox ckbHavingHere;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2TextBox txbCompanyName;
        internal Label Label4;
        internal Guna.UI2.WinForms.Guna2TextBox txbNote;
        internal Guna.UI2.WinForms.Guna2ShadowPanel Guna2ShadowPanel2;
        internal Guna.UI2.WinForms.Guna2ShadowForm Guna2ShadowForm1;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox4;
        private Guna.UI2.WinForms.Guna2Button _btnCheckout;

        internal Guna.UI2.WinForms.Guna2Button btnCheckout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCheckout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCheckout != null)
                {
                    _btnCheckout.Click -= btnCheckout_Click;
                }

                _btnCheckout = value;
                if (_btnCheckout != null)
                {
                    _btnCheckout.Click += btnCheckout_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2DataGridView dgvPaymnet;
        internal Guna.UI2.WinForms.Guna2TextBox txbAddressDetails2;
        internal ErrorProvider err;
    }
}