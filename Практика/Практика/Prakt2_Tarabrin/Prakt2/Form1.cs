using System;
using System.Linq;
using System.Windows.Forms;

namespace Prakt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            resultOutput.Visible = false;
            button1.Enabled = false;

        }

        private void Sum(double e, double x)
        {
            double sum = x;

            double ln = Math.Log((1 + x) / (1 - x));

            double nplus = 0;
            double n = x;
            int count = 0;
            
            for (int i = 1; Math.Abs(nplus) <= e * sum && count != 1000; i++)
            {
                nplus = n * (x * x * (2 * i - 1) / (2 * i + 1));
                
                sum += nplus;

                count++;
            }

            sum *= 2;

            if (count == 1000)
            {
                label3.Visible = true;
                resultOutput.Visible = true;
                resultOutput.Text = string.Format("ln((1 + x) / (1 - x)) = {0:G7}\n", ln);
                resultOutput.Text += string.Format("Сумма ряда не найдена из-за большого\n количества итераций", sum);
            }
            else
            {
                label3.Visible = true;
                resultOutput.Visible = true;
                resultOutput.Text = string.Format("ln((1 + x) / (1 - x)) = {0:G7}\n", ln);
                resultOutput.Text += string.Format("Сумма ряда: {0:G7}\n", sum);
                resultOutput.Text += string.Format("Кол-во элементов в ряде: {0:G7}", count);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double eps = Convert.ToDouble(textBox1.Text);
            if ((eps > 0) && (eps < 1)){
                if (Math.Abs(x) < 1)
                {
                    Sum(eps, x);
                }
                else
                {
                    resultOutput.Text = "значение X не удовлетворяет ОДЗ";
                    resultOutput.Visible = true;
                }
            }
            else
            {
                resultOutput.Text = "значение eps не удовлетворяет ОДЗ";
                resultOutput.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.TextLength != 0 && textBox1.Text != "" && textBox1.TextLength != 0)
            {
                if (textBox2.Text[textBox2.TextLength - 1] != ',' && textBox1.Text[textBox1.TextLength - 1] != ',' && textBox2.Text != "-")
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }

            }
            else
            {
                button1.Enabled = false;
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.TextLength != 0 && textBox1.Text != "" && textBox1.TextLength != 0)
            {
                if (textBox2.Text[textBox2.TextLength - 1] != ',' && textBox1.Text[textBox1.TextLength - 1] != ',' && textBox2.Text != "-")
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }

            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs c)
        {
            if (c.KeyChar != ' ' && c.KeyChar == '\b' || (Char.IsNumber(c.KeyChar)
               || (!textBox1.Text.Contains(',') && c.KeyChar == ',' && textBox1.TextLength >= 1)))
            {

            }
            else
            {
                c.Handled = true;
            }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ' && e.KeyChar == '\b'
                || (Char.IsNumber(e.KeyChar) || (e.KeyChar == '-' && textBox2.TextLength == 0)
                || (!textBox2.Text.Contains(',') && e.KeyChar == ',' && textBox2.TextLength >= 1 && !textBox2.Text.Contains('-'))
                || (!textBox2.Text.Contains(',') && e.KeyChar == ',' && textBox2.TextLength >= 2 && textBox2.Text.Contains('-'))))
            {

            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
