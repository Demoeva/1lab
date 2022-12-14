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
        double z1, z2, x,y,tx,ty;
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            button1.Enabled = false;
            richTextBox1.Enabled = false;
        }

        void mathematic()
        {
            z1 = (Math.Pow((Math.Cos(x)-Math.Cos(y)), 2))-(Math.Pow((Math.Sin(x) - Math.Sin(y)), 2));
            z2 = -4*(Math.Pow((Math.Sin((x-y)/2)),2))*Math.Cos(x+y);
        }

       

        static void convRad(double x,double y, out double tx,out double ty)
        {
            tx= (x * Math.PI) / 180;
            ty= (y * Math.PI) / 180;
         
        }
        static void convGrad(double x,double y, out double tx, out double ty)
        {
           tx= (x * 180) / Math.PI;
            ty = (y * 180) / Math.PI;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            RadioButton radioButton = sender as RadioButton;

            if (radioButton1.Checked)
            {
                richTextBox1.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                richTextBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool textcheck;
            if (radioButton1.Checked)
            {
                textcheck = double.TryParse(richTextBox1.Text, out x);
                textcheck = double.TryParse(richTextBox4.Text, out y);
                if (((y >= 0) & (y <= 360)) & ((x >= 0) & (x <= 360)))
                {
                    convGrad(x, y, out tx, out ty);
                    mathematic();
                    label1.Text = "z1=" + Convert.ToString(z1);
                    label2.Text = "z2=" + Convert.ToString(z2);

                }
                 else
                {
                    Console.WriteLine("Угол в градусах должен быть от 0 до 360");
                }

            }
           
        
            else if (radioButton2.Checked)
            {
                    textcheck=  double.TryParse(richTextBox1.Text, out x);
                    textcheck= double.TryParse(richTextBox4.Text, out y);
                if ((x > 0) & (x <= Math.PI)& (y > 0) & (y <= Math.PI))
                {
                    convRad(x, y, out tx, out ty);
                    mathematic();
                    label1.Text = ("z1=") + Convert.ToString(z1);
                    label2.Text = ("z2=") + Convert.ToString(z2);
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



       
    }
}
