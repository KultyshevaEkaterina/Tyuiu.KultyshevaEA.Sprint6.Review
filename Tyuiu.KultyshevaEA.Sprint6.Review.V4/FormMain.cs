using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KultyshevaEA.Sprint6.Review.V4.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Review.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public int row = 0;
        public int columns = 0;
        public int r1 = 0, r2 = 0;
        public int[,] MyArray;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Култышева Екатерина Александровна ИИПб-23-3\nСпринт 6 Ревью Вариант 4", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int First = Convert.ToInt32(textBoxK_KEA.Text);
                int Second = Convert.ToInt32(textBoxL_KEA.Text);
                int MyC = Convert.ToInt32(textBoxC_KEA.Text);

                int MyAnswer = ds.Result(MyArray, MyC, First, Second);

                textBoxResult_KEA.Text = Convert.ToString(MyAnswer);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxK_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMTRX_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int row = Convert.ToInt32(textBoxN_KEA.Text), columns = Convert.ToInt32(textBoxM_KEA.Text);
                int r1 = Convert.ToInt32(textBoxn1_KEA.Text), r2 = Convert.ToInt32(textBoxn2_KEA.Text);
                int[,] array = new int[row, columns];

                MyArray = ds.GetMatrix(row, columns, r1, r2);

                dataGridViewMtrx_KEA.RowCount = row;
                dataGridViewMtrx_KEA.ColumnCount = columns;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMtrx_KEA.Columns[i].Width = 100;
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMtrx_KEA.Rows[i].Cells[j].Value = Convert.ToString(MyArray[i, j]);
                    }
                }
                textBoxK_KEA.Enabled = true;
                textBoxL_KEA.Enabled = true;
                textBoxC_KEA.Enabled = true;
                buttonDone_KEA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
