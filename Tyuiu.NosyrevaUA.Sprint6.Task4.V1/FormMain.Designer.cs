
namespace Tyuiu.NosyrevaUA.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxStopput = new System.Windows.Forms.TextBox();
            this.textBoxStartput = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.panel1);
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(541, 123);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Location = new System.Drawing.Point(7, 26);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(526, 82);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V19.txt по на" +
    "жатию кнопки.\r\n";
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.textBoxDone);
            this.groupBoxOutPut.Location = new System.Drawing.Point(13, 143);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(302, 512);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод:";
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDone.Location = new System.Drawing.Point(7, 17);
            this.textBoxDone.Multiline = true;
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.ReadOnly = true;
            this.textBoxDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDone.Size = new System.Drawing.Size(289, 489);
            this.textBoxDone.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxStopput);
            this.groupBoxInput.Controls.Add(this.textBoxStartput);
            this.groupBoxInput.Controls.Add(this.textBoxStop);
            this.groupBoxInput.Controls.Add(this.textBoxStart);
            this.groupBoxInput.Location = new System.Drawing.Point(560, 23);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(254, 113);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxStopput
            // 
            this.textBoxStopput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopput.Location = new System.Drawing.Point(141, 42);
            this.textBoxStopput.Name = "textBoxStopput";
            this.textBoxStopput.ReadOnly = true;
            this.textBoxStopput.Size = new System.Drawing.Size(100, 19);
            this.textBoxStopput.TabIndex = 1;
            this.textBoxStopput.Text = "Конец шага:";
            // 
            // textBoxStartput
            // 
            this.textBoxStartput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartput.Location = new System.Drawing.Point(7, 42);
            this.textBoxStartput.Name = "textBoxStartput";
            this.textBoxStartput.ReadOnly = true;
            this.textBoxStartput.Size = new System.Drawing.Size(100, 19);
            this.textBoxStartput.TabIndex = 1;
            this.textBoxStartput.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(141, 74);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop.TabIndex = 0;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(7, 74);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(820, 39);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 97);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(953, 39);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 97);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Схоранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(1084, 39);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(115, 97);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // chartFunc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunc.Legends.Add(legend2);
            this.chartFunc.Location = new System.Drawing.Point(332, 143);
            this.chartFunc.Name = "chartFunc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunc.Series.Add(series2);
            this.chartFunc.Size = new System.Drawing.Size(877, 512);
            this.chartFunc.TabIndex = 0;
            this.chartFunc.Text = "chartFunc";
            this.chartFunc.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title2.Name = "TitleFunc";
            title2.Text = "График функции (5 * x + 2.5) / (Sin(x) - 2) + 2 ";
            this.chartFunc.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 113);
            this.panel1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 667);
            this.Controls.Add(this.chartFunc);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxDescription);
            this.MinimumSize = new System.Drawing.Size(1243, 723);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Носырева Ю. А.|";
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStopput;
        private System.Windows.Forms.TextBox textBoxStartput;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.Panel panel1;
    }
}

