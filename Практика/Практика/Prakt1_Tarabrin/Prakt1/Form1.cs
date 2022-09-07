using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Prakt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calcButton.Enabled = false;
            input.MaxLength = 10;
            input2.MaxLength = 10;
        }


        //Проверка на ввод только допустимых символов: цифр, знака "-" вначале и знака "," если введена какая-либо цифра
        private void input_KeyPress(object sender, KeyPressEventArgs c)
        {
            if (c.KeyChar != ' ' && c.KeyChar == '\b' ||
                  (Char.IsNumber(c.KeyChar) || (c.KeyChar == '-' && input.TextLength == 0) ||
                   (!input.Text.Contains(',') && c.KeyChar == ',' && input.TextLength >= 1 && !input.Text.Contains('-')) ||
                   (!input.Text.Contains(',') && c.KeyChar == ',' && input.TextLength >= 2 && input.Text.Contains('-'))
                  )
               )
            {

            }
            else
            {
                c.Handled = true;
            }
        }
        private void input2_KeyPress(object sender, KeyPressEventArgs c)
        {
            if (c.KeyChar != ' ' && c.KeyChar == '\b' ||
                  (Char.IsNumber(c.KeyChar) || (c.KeyChar == '-' && input2.TextLength == 0) ||
                   (!input2.Text.Contains(',') && c.KeyChar == ',' && input2.TextLength >= 1 && !input2.Text.Contains('-')) ||
                   (!input2.Text.Contains(',') && c.KeyChar == ',' && input2.TextLength >= 2 && input2.Text.Contains('-'))
                  )
               )
            {

            }
            else
            {
                c.Handled = true;
            }
        }

        // смена цвета фона надписи при наведении мыши на метку
        private void result_MouseEnter(object sender, EventArgs e)
        {
            result.BackColor = Color.Orange;
        }
        // возвращение цвета фона метки после при покидания метки мышью
        private void result_MouseLeave(object sender, EventArgs e)
        {
            result.BackColor = Color.Bisque;
        }

        //Вычисление z1 и z1
        private void calcButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (degree.Checked == true)
            {
                a = Convert.ToDouble(input.Text);
                a = a * (Math.PI / 180);

                b = Convert.ToDouble(input2.Text);
                b = a * (Math.PI / 180);
            }
            else
            {
                a = Convert.ToDouble(input.Text);
                b = Convert.ToDouble(input2.Text);
            }

            double z1 = Math.Pow((Math.Cos(a) - Math.Cos(b)), 2) - Math.Pow((Math.Sin(a) - Math.Cos(b)), 2);
            double z2 = -4 * (Math.Pow((double)Math.Sin(a - b) / 2, 2) * Math.Cos(a + b));
            result.Text = "Результат: \n z1=" + String.Format("{0:G4}", z1) + "\n z2=" + String.Format("{0:G4}", z2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //блокировка кнопки на случай, если поле пустое или содержит лишь '-' и/или ','
        private void EnableBtnIfNeed()
        {
            var inputsAreCorrect = 0;
            if (input.Text != "")
            {
                if (input.Text[input.TextLength - 1] != ',')
                {
                    if (input.Text[input.TextLength - 1] != '-')
                    {
                        inputsAreCorrect++;
                    }
                }
            }
            if (input2.Text != "")
            {
                if (input2.Text[input2.TextLength - 1] != ',')
                {
                    if (input2.Text[input2.TextLength - 1] != '-')
                    {
                        inputsAreCorrect++;
                    }
                }
            }
            if(inputsAreCorrect == 2)
                calcButton.Enabled = true;
            else
                calcButton.Enabled = false;
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            EnableBtnIfNeed();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            EnableBtnIfNeed();

        }
    }
}
