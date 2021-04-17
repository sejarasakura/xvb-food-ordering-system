using System;
using System.ComponentModel;

namespace VisualBasicAssignment
{
    public partial class Master
    {
        public Master()
        {
            InitializeComponent();
            _btnClose.Name = "btnClose";
        }

        private bool statusMax = true;
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(Master));

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }


        // Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        // ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid,
        // Color.Black, 1, ButtonBorderStyle.Solid)
        // End Sub

    }
}