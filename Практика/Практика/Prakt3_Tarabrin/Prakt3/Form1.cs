using System;
using System.Windows.Forms;
using System.IO;

namespace Prakt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            input.MaxLength = 7;
            label2.Visible = false;

        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != ' ' && e.KeyChar == '\b' || Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if ((toThree.Checked == true || toFive.Checked == true || toSeven.Checked == true )&& input.Text != "")
            {
                changeCountSyst.Enabled = true;
            }
        }

        private void change(long num)
        {
            CountSysConverter numToConvert = new CountSysConverter(Convert.ToInt32(input.Text));
            try
            {
                StreamWriter file = new StreamWriter("history.txt", true);
                file.WriteLine("Input value in 10 system");
                file.WriteLine(Convert.ToInt32(input.Text));
                if (toThree.Checked == true)
                {
                    num = numToConvert.Convertnum(3);
                    result.Text = "Результат\n" + num;
                    file.WriteLine(Convert.ToInt32(input.Text) + " in 3 System --> " + num);
                    file.WriteLine("=============================");
                    file.Close();
                }
                else if (toFive.Checked == true)
                {
                    num = numToConvert.Convertnum(5);
                    result.Text = "Результат\n" + num;   
                    file.WriteLine(Convert.ToInt32(input.Text) + " in 5 System --> " + num);
                    file.WriteLine("=============================");
                    file.Close();
                }
                else
                {
                    num = numToConvert.Convertnum(7);
                    result.Text = "Результат\n" + num;
                    file.WriteLine(Convert.ToInt32(input.Text) + " in 7 System --> " + num);
                    file.WriteLine("=============================");
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void changeCountSyst_Click(object sender, EventArgs e)
        {
            change(Convert.ToInt64(input.Text));
            result.Visible = true;
            
        }

        private void toThree_CheckedChanged(object sender, EventArgs e)
        {
            if ((toThree.Checked == true || toFive.Checked == true || toSeven.Checked == true) && input.Text != "")
            {
                changeCountSyst.Enabled = true;
            }
        }

        private void toFive_CheckedChanged(object sender, EventArgs e)
        {
            if ((toThree.Checked == true || toFive.Checked == true || toSeven.Checked == true) && input.Text != "")
            {
                changeCountSyst.Enabled = true;
            }
        }

        private void toSeven_CheckedChanged(object sender, EventArgs e)
        {
            if ((toThree.Checked == true || toFive.Checked == true || toSeven.Checked == true) && input.Text != "")
            {
                changeCountSyst.Enabled = true;
            }
        }

        private void result_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void result_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
