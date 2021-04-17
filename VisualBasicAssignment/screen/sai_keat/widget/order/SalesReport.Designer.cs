using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VisualBasicAssignment
{
    [DesignerGenerated()]
    public partial class SalesReport : MasterWidgetItemSm
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvReport = new Guna.UI2.WinForms.Guna2DataGridView();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label1 = new Label();
            _Guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            _Guna2DateTimePicker1.ValueChanged += new EventHandler(Guna2DateTimePicker1_ValueChanged);
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToOrderColumns = true;
            DataGridViewCellStyle1.BackColor = Color.White;
            dgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 30;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5f);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = DataGridViewCellStyle3;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvReport.Location = new Point(12, 50);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 24;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(858, 437);
            dgvReport.TabIndex = 27;
            dgvReport.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            dgvReport.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReport.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReport.ThemeStyle.BackColor = Color.White;
            dgvReport.ThemeStyle.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvReport.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(88)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvReport.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReport.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5f);
            dgvReport.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReport.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvReport.ThemeStyle.HeaderStyle.Height = 30;
            dgvReport.ThemeStyle.ReadOnly = true;
            dgvReport.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvReport.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5f);
            dgvReport.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            dgvReport.ThemeStyle.RowsStyle.Height = 24;
            dgvReport.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(255)));
            dgvReport.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(94)));
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2HtmlLabel1.Location = new Point(15, -40);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(126, 38);
            Guna2HtmlLabel1.TabIndex = 17;
            Guna2HtmlLabel1.Text = "My Order";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(12, 14);
            Label1.Name = "Label1";
            Label1.Size = new Size(238, 25);
            Label1.TabIndex = 28;
            Label1.Text = "Top Sales Monthly Report";
            // 
            // Guna2DateTimePicker1
            // 
            _Guna2DateTimePicker1.CheckedState.Parent = _Guna2DateTimePicker1;
            _Guna2DateTimePicker1.CustomFormat = "MMM, yyyy";
            _Guna2DateTimePicker1.FillColor = Color.CornflowerBlue;
            _Guna2DateTimePicker1.Font = new Font("Segoe UI", 9.0f);
            _Guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            _Guna2DateTimePicker1.HoverState.Parent = _Guna2DateTimePicker1;
            _Guna2DateTimePicker1.IndicateFocus = true;
            _Guna2DateTimePicker1.Location = new Point(887, 50);
            _Guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            _Guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            _Guna2DateTimePicker1.Name = "_Guna2DateTimePicker1";
            _Guna2DateTimePicker1.ShadowDecoration.Parent = _Guna2DateTimePicker1;
            _Guna2DateTimePicker1.Size = new Size(169, 36);
            _Guna2DateTimePicker1.TabIndex = 29;
            _Guna2DateTimePicker1.Value = new DateTime(2021, 4, 17, 20, 6, 26, 230);
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            Controls.Add(_Guna2DateTimePicker1);
            Controls.Add(Label1);
            Controls.Add(dgvReport);
            Controls.Add(Guna2HtmlLabel1);
            Name = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            Load += new EventHandler(Page_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2DataGridView dgvReport;
        internal Label Label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker _Guna2DateTimePicker1;

        internal Guna.UI2.WinForms.Guna2DateTimePicker Guna2DateTimePicker1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2DateTimePicker1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2DateTimePicker1 != null)
                {
                    _Guna2DateTimePicker1.ValueChanged -= Guna2DateTimePicker1_ValueChanged;
                }

                _Guna2DateTimePicker1 = value;
                if (_Guna2DateTimePicker1 != null)
                {
                    _Guna2DateTimePicker1.ValueChanged += Guna2DateTimePicker1_ValueChanged;
                }
            }
        }
    }
}