
namespace Tyuiu.NosyrevaUA.Sprint6.Task5.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.splitterleftcentre = new System.Windows.Forms.Splitter();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.chartNums = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelCentre.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.buttonHelp);
            this.panelUp.Controls.Add(this.buttonOpenFile);
            this.panelUp.Controls.Add(this.buttonDone);
            this.panelUp.Controls.Add(this.groupBoxDescription);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(869, 100);
            this.panelUp.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxInput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(233, 350);
            this.panelLeft.TabIndex = 1;
            // 
            // panelCentre
            // 
            this.panelCentre.Controls.Add(this.chartNums);
            this.panelCentre.Controls.Add(this.splitterleftcentre);
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(233, 100);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(636, 350);
            this.panelCentre.TabIndex = 2;
            // 
            // splitterleftcentre
            // 
            this.splitterleftcentre.Location = new System.Drawing.Point(0, 0);
            this.splitterleftcentre.Name = "splitterleftcentre";
            this.splitterleftcentre.Size = new System.Drawing.Size(3, 350);
            this.splitterleftcentre.TabIndex = 0;
            this.splitterleftcentre.TabStop = false;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBox1);
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 3);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(523, 100);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие:";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewNums);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(233, 350);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Вывод данных:";
            // 
            // chartNums
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNums.ChartAreas.Add(chartArea1);
            this.chartNums.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartNums.Legends.Add(legend1);
            this.chartNums.Location = new System.Drawing.Point(3, 0);
            this.chartNums.Name = "chartNums";
            this.chartNums.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNums.Series.Add(series1);
            this.chartNums.Size = new System.Drawing.Size(633, 350);
            this.chartNums.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone.Location = new System.Drawing.Point(530, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(107, 81);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpenFile.Location = new System.Drawing.Point(643, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(107, 81);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(756, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(107, 81);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // dataGridViewNums
            // 
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.RowHeadersWidth = 62;
            this.dataGridViewNums.RowTemplate.Height = 28;
            this.dataGridViewNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums.Size = new System.Drawing.Size(227, 325);
            this.dataGridViewNums.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(517, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести в" +
    "се отрицательные числа. Построить диаграмму по этим значениям. \r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUp);
            this.MinimumSize = new System.Drawing.Size(891, 506);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Носырева Ю. А.|";
            this.panelUp.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelCentre.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCentre;
        private System.Windows.Forms.Splitter splitterleftcentre;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNums;
        private System.Windows.Forms.DataGridView dataGridViewNums;
        private System.Windows.Forms.TextBox textBox1;
    }
}

