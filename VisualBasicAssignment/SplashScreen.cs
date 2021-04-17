using System;
using Microsoft.VisualBasic;

namespace VisualBasicAssignment
{
    public partial class SplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        public void InitializeComponentCustom()
        {
            // Initializing action'
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Panel2.Width >= 100 & Panel2.Width <= 120 | Panel2.Width > 600)
            {
                Panel2.Width = (int)Math.Round(Panel2.Width + Conversion.Int(2f * VBMath.Rnd() + 1f));
            }
            else if (Panel2.Width < 100)
            {
                Panel2.Width = (int)Math.Round(Panel2.Width + Conversion.Int(3f * VBMath.Rnd() + 0f));
            }
            else
            {
                Panel2.Width = (int)Math.Round(Panel2.Width + Conversion.Int(6f * VBMath.Rnd() + 0f));
            }

            if (Panel2.Width >= 650)
            {
                Timer1.Stop();
                Screen.NAV_LOGIN_SCREEN.Show();
                Hide();
            }
        }
    }
}