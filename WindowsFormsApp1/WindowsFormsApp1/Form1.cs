using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double z1, z2, x, y, tx, ty;
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(richTextBox_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(richTextBox_CheckedChanged);
            button1.Enabled = false;
          
        }

     

        private void richTextBox3_MouseEnter(object sender, EventArgs e)
        {
           richTextBox3.BackColor = Color.BlueViolet;
        }

        private void richTextBox3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.BackColor = DefaultBackColor;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool textcheck;
            if (radioButton1.Checked)
            {
                textcheck = double.TryParse(richTextBox1.Text, out x);
                textcheck = double.TryParse(richTextBox2.Text, out y);
                if (((y >= 0) & (y <= 360)) & ((x >= 0) & (x <= 360)))
                {
                    convGrad(x, y, out tx, out ty);
                    mathematic();
                    label3.Text = "z1=" + Convert.ToString(z1);
                    label4.Text = "z2=" + Convert.ToString(z2);

                }
                else
                {
                    Console.WriteLine("Угол в градусах должен быть от 0 до 360");
                }

            }


            else if (radioButton2.Checked)
            {
                textcheck = double.TryParse(richTextBox1.Text, out x);
                textcheck = double.TryParse(richTextBox2.Text, out y);
                if ((x > 0) & (x <= Math.PI) & (y > 0) & (y <= Math.PI))
                {
                    convRad(x, y, out tx, out ty);
                    mathematic();
                    label3.Text = ("z1=") + Convert.ToString(z1);
                    label4.Text = ("z2=") + Convert.ToString(z2);
                }

                else
                {
                    Console.WriteLine("Угол не в радианах");
                }


            }
            else
            {
                MessageBox.Show("Введите значение");
                return;
            }
        }

        void mathematic()
        {
            z1 = (Math.Pow((Math.Cos(x) - Math.Cos(y)), 2)) - (Math.Pow((Math.Sin(x) - Math.Sin(y)), 2));
            z2 = -4 * (Math.Pow((Math.Sin((x - y) / 2)), 2)) * Math.Cos(x + y);
        }



        static void convRad(double x, double y, out double tx, out double ty)
        {
            tx = (x * Math.PI) / 180;
            ty = (y * Math.PI) / 180;

        }
        static void convGrad(double x, double y, out double tx, out double ty)
        {
            tx = (x * 180) / Math.PI;
            ty = (y * 180) / Math.PI;
        }

        private void richTextBox_CheckedChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox1.Text.Length == 0 && richTextBox2.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

       




    }
}
