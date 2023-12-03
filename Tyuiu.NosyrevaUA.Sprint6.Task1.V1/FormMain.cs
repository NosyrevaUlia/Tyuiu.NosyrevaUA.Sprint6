using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosyrevaUA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task1.V1
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
                int start = Convert.ToInt32(textBoxStepFirstInput.Text);
                int stop = Convert.ToInt32(textBoxStepSecondInput.Text);

                string strLine;
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}    |  {1,6:f2}   | ", start, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    start++;
                }

                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы ИИПб-23-3 Носырева Юлия Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
