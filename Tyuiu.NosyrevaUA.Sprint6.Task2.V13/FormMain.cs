using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosyrevaUA.Sprint6.Task2.V13.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep.Text);
                int stop = Convert.ToInt32(textBoxStopStep.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);
     
                this.chartFunc.Titles.Add("График функции sin(x) +2x/3 - cos(x)*4x");
                this.chartFunc.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunc.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridRes.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartFunc.Series[0].Points.AddXY(start, valueArray[i]);

                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студент группы ИИПб-23-3 Носырева Юлия Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
