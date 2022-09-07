using System;
using System.Windows.Forms;
using System.Drawing;
namespace Prakt4
{
    public partial class Settings : Form
    {

        Button form1button;
        int size;
        Timer timer;
        public Settings(Button settings, Timer timer1, int circle_width)
        {
            InitializeComponent();
            form1button = settings;
            size = circle_width;
            trackBarSize.Value = circle_width;
            trackBarSpeed.Value = timer1.Interval;
            timer = timer1;
        }
        private void changeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            Form1.brush2 = new SolidBrush (colorDialog1.Color);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1button.Enabled = true;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            Form1.circle_width = trackBarSize.Value;
            Form1.circle_height = trackBarSize.Value;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            try
            {

                timer.Interval = trackBarSpeed.Value;
            }
            catch
            {
                return;
            }
        }
    }
}
