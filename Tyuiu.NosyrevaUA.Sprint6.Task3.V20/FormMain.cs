using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosyrevaUA.Sprint6.Task3.V20.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mat = new int[5,5] { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
       

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mat.GetUpperBound(0) + 1;
            int cols = mat.Length / rows;

            dataGridViewInput.ColumnCount = cols;
            dataGridViewInput.RowCount = rows;

            for (int i = 0; i <cols; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = Convert.ToString(mat[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mat);
            int rows = res.GetUpperBound(0) + 1;
            int cols = res.Length / rows;

            dataGridViewRes.ColumnCount = cols;
            dataGridViewRes.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewRes.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(mat[i, j]);
                }
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИИПб-23-3 Носырева Юлия Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
