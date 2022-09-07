using System;
using System.Windows.Forms;

namespace prakt5_Erdniev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillArrButton.Enabled = false;
            dataGridView1.RowCount = 1;
            numForCalcs.Enabled = false;
        }



        private void calculate_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridView1.ColumnCount];
            int numforcalcs = int.Parse(numForCalcs.Text);
            long sum = 0;
            long mult = 1;
            int appropriateindexes = 0;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                arr[i] = int.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                if (i % numforcalcs == 0)
                {
                    sum += arr[i];
                    mult *= arr[i];
                    appropriateindexes++;
                }
                appropriateindexes++;
            }
            sumOutput.Text = "Сумма: " + sum.ToString();
            if (mult > long.MaxValue || mult <= 0)
            {
                multOutput.Text = "Произведение: число слишком большое ";
            }
            else
            {

                multOutput.Text = "Произведение " + mult.ToString();
            }
            int[] modifiedarr = Array.getNewArray(arr, appropriateindexes, numforcalcs);
            try
            {
                dataGridView1.ColumnCount = modifiedarr.Length;
                for (int i = 0; i < modifiedarr.Length; i++)
                {
                    dataGridView1.Columns[i].Name = i.ToString();
                    dataGridView1.Rows[0].Cells[i].Value = modifiedarr[i];
                }
            }
            catch (Exception)
            {
                sumOutput.Text = "";
                multOutput.Text = "Кол.-во элементов массива превышает доступный предел,\n заполните массив новыми числами";
                calculate.Enabled = false;
            }


        }

        private void fillArrButton_Click(object sender, EventArgs e)
        {
            int arrsize = int.Parse(arraySize.Value.ToString());
            bool random = true;
            if (randomly.Checked == true)
            {
                random = true;
            }
            else if (randomly.Checked == false)
            {
                random = false;
            }
            int[] arr = Array.getArray(arrsize, random);

            dataGridView1.ColumnCount = arrsize;

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }

            numForCalcs.Enabled = true;
        }
        private void checkinput1()
        {
            if (randomly.Checked == true && arraySize.Value != 0) { fillArrButton.Enabled = true; } else if (manually.Checked == true && arraySize.Value != 0) { fillArrButton.Enabled = true; } else { fillArrButton.Enabled = false; }

        }
        private void arraySize_ValueChanged(object sender, EventArgs e)
        {
            checkinput1();
        }

        private void randomly_Click(object sender, EventArgs e)
        {
            checkinput1();
        }

        private void manually_Click(object sender, EventArgs e)
        {
            checkinput1();
        }

        private void numForCalcs_MouseMove(object sender, MouseEventArgs e)
        {
            hint.Visible = true;
        }

        private void numForCalcs_MouseLeave(object sender, EventArgs e)
        {
            hint.Visible = false;
        }

        private void numForCalcs_TextChanged(object sender, EventArgs e)
        {
            if (numForCalcs.Text != "")
            {
                calculate.Enabled = true;
            }
        }
    }
}
