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
        double x,e;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;                  
            richTextBox1.Enabled = false;               
        }

        void Taylor()
        {
            e = Convert.ToDouble(richTextBox4.Text);
            if (1 < e || e < 0)
            {
                MessageBox.Show("Введенное значение точности находится вне условного диапазона");
            }
            else
            {
                x = Convert.ToDouble(richTextBox3.Text);
                int n = 0;
                double result = 0, diffResult = 0, currValue = 0, previousResult = 0;
                while (Math.Abs(diffResult) > e)
                {
                    currValue = (Math.Pow(-1, n) * Math.Pow(x, 2 * n) / factorial(n));
                    previousResult = result;
                    result += currValue;
                    diffResult = result - previousResult;
                    n++;
                }
            }
        }
        void factorial(int n)
        {
             long result = 1;
             for(int i=1;i<=n;i++)
             {
                 result *= i;
             }
        }
        }
    }
}