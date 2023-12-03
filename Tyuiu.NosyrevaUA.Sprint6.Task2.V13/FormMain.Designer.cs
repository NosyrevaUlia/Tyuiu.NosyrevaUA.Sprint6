
namespace Tyuiu.NosyrevaUA.Sprint6.Task2.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.textBoxstop = new System.Windows.Forms.TextBox();
            this.textBoxstart = new System.Windows.Forms.TextBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridRes = new System.Windows.Forms.DataGridView();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxDataInput.SuspendLayout();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxQuestion);
            this.groupBoxDescription.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(713, 311);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Location = new System.Drawing.Point(7, 25);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(700, 213);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Протабулировать функцию sin(x) +2x/3 - cos(x)*4x на заданном диапазоне.\r\nРезульта" +
    "т вывести в и построить график функции.";
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.Controls.Add(this.textBoxstop);
            this.groupBoxDataInput.Controls.Add(this.textBoxstart);
            this.groupBoxDataInput.Controls.Add(this.textBoxStopStep);
            this.groupBoxDataInput.Controls.Add(this.textBoxStartStep);
            this.groupBoxDataInput.Location = new System.Drawing.Point(13, 330);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(359, 124);
            this.groupBoxDataInput.TabIndex = 1;
            this.groupBoxDataInput.TabStop = false;
            this.groupBoxDataInput.Text = "Ввод данных";
            // 
            // textBoxstop
            // 
            this.textBoxstop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxstop.Location = new System.Drawing.Point(183, 49);
            this.textBoxstop.Name = "textBoxstop";
            this.textBoxstop.ReadOnly = true;
            this.textBoxstop.Size = new System.Drawing.Size(170, 19);
            this.textBoxstop.TabIndex = 1;
            this.textBoxstop.Text = "Конец шага:";
            // 
            // textBoxstart
            // 
            this.textBoxstart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxstart.Location = new System.Drawing.Point(7, 49);
            this.textBoxstart.Name = "textBoxstart";
            this.textBoxstart.ReadOnly = true;
            this.textBoxstart.Size = new System.Drawing.Size(170, 19);
            this.textBoxstart.TabIndex = 1;
            this.textBoxstart.Text = "Старт шага:";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(183, 82);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(170, 26);
            this.textBoxStopStep.TabIndex = 0;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(7, 82);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(170, 26);
            this.textBoxStartStep.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(378, 340);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(108, 114);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(492, 340);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(234, 114);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.chartFunc);
            this.groupBoxOutPut.Controls.Add(this.dataGridRes);
            this.groupBoxOutPut.Location = new System.Drawing.Point(732, 13);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(538, 425);
            this.groupBoxOutPut.TabIndex = 4;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // dataGridRes
            // 
            this.dataGridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridRes.Location = new System.Drawing.Point(7, 36);
            this.dataGridRes.Name = "dataGridRes";
            this.dataGridRes.RowHeadersVisible = false;
            this.dataGridRes.RowHeadersWidth = 62;
            this.dataGridRes.RowTemplate.Height = 28;
            this.dataGridRes.Size = new System.Drawing.Size(185, 389);
            this.dataGridRes.TabIndex = 0;
            // 
            // chartFunc
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartFunc.Legends.Add(legend5);
            this.chartFunc.Location = new System.Drawing.Point(198, 36);
            this.chartFunc.Name = "chartFunc";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunc.Series.Add(series5);
            this.chartFunc.Size = new System.Drawing.Size(334, 383);
            this.chartFunc.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 55;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 8;
            this.Y.Name = "Y";
            this.Y.Width = 55;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 480);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxDataInput);
            this.Controls.Add(this.groupBoxDescription);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Носырева Ю. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.TextBox textBoxstop;
        private System.Windows.Forms.TextBox textBoxstart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

