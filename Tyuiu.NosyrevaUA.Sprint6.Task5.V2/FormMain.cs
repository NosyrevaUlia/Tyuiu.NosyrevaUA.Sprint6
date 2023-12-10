using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosyrevaUA.Sprint6.Task5.V2.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint6\Tyuiu.NosyrevaUA.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2";

        
        private void buttonDone_Click(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.AliceBlue;
           
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartNums.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartNums.ChartAreas[0].AxisY.Title = "Ось Y";

            chartNums.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartNums.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            buttonOpenFile.BackColor = Color.AliceBlue;
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            buttonHelp.BackColor = Color.AliceBlue;
            {
                MessageBox.Show("Таск 5 выполнила студент группы ИИПб-23-3 Носырева Юлия Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
