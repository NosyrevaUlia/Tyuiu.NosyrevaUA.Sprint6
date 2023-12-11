using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.NosyrevaUA.Sprint6.Task7.V1.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)| *.csv | Все файлы(*.*) | *.* ";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        //МЕТОД ДЛЯ ЧТЕНИЯ ДАННЫХ ИЗ ФАЙЛА
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath); 
            //разделение по строкам
            fileData =  fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries ); //!!!!!

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            //Выделение массива данных
            int[,] arrayValues = new int[rows, colums];
            //заполняем массив
            for(int r = 0; r<rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for(int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            //выделим массив данных
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = colums;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = colums;
            dataGridViewOut.RowCount = rows;
            //ширина столбцов
            for(int i = 0; i<colums; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            //добавим данные в In
            for(int r = 0; r< rows; r++)
            {
                for (int c = 0; c< colums; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c]; 
                }
            }

            arrayValues = ds.GetMatrix(openFilePath); //у меня ж там не матрица дана в библе... а так, LoadFromFileData(openFilePath)
            buttonDone.Enabled = true;
        }

        


        private void buttonDone_Click(object sender, EventArgs e)
        {
            //выделение массива данных
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            //добавить данные
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo info = new FileInfo(path);
            bool fileex = info.Exists;

            if(fileex)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int colums = dataGridViewOut.ColumnCount;

            string str = "";
            for(int i = 0; i< rows; i++)
            {
                for (int j = 0; j< colums; j++)
                {
                    if(j!=colums-1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }


        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        
    }
}
