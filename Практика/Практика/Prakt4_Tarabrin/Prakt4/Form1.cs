using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prakt4
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush1, rec1);
            e.Graphics.FillEllipse(brush2, rec2);
          
        }

        public static SolidBrush brush2 = new SolidBrush(Color.Pink);
        public static int dx = 1;
        public static int circle_width = 10, circle_height = 10;
        public static int circle_x, circle_y;

        SolidBrush brush1 = new SolidBrush(Color.Teal);
        public static int x_center;
        public static int surface_width = 170, surface_height = 170;// ширина и высота большого круга

        int surface_x, surface_y;//координаты большого круга

        Rectangle rec1;
        Rectangle rec2;
        enum STATUS { Left, Right };
        STATUS flag;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
               Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
            surface_x = ClientSize.Width / 2 - (surface_width / 2);
            surface_y = ClientSize.Height / 2 - (surface_height / 2);

            circle_x = ClientSize.Width / 2 - (circle_width / 2);
            circle_y = ClientSize.Height / 2 ;

            x_center = ClientSize.Width / 2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                button1.Text = "Старт";
            else
                button1.Text = "Стоп";

            timer1.Enabled = !timer1.Enabled;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            rec1 = new Rectangle(surface_x, surface_y, surface_width, surface_height);
            rec2 = new Rectangle(circle_x, circle_y - (circle_height / 2), circle_width, circle_height);
            Invalidate(rec1, true);
            Invalidate(rec2, true);


            if (flag == STATUS.Left)
            {
                circle_x -= dx;
            }
            if (flag == STATUS.Right)
            {
                circle_x += dx;
            }

            if (circle_x >= x_center - circle_width / 2)
            {
                flag = STATUS.Left;
            }
            else if (circle_x <= ClientSize.Width/2 -surface_width/2)
            {
                flag = STATUS.Right;
            }

            Invalidate(rec1, true);
            Invalidate();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settingsform = new Settings(settings, timer1, circle_width);
            settingsform.Show();
            settings.Enabled = false;
        }



    }
}
