
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelUp = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInstop = new System.Windows.Forms.TextBox();
            this.textBoxInstart = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.panelCentre.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUp.Controls.Add(this.buttonHelp);
            this.panelUp.Controls.Add(this.buttonSave);
            this.panelUp.Controls.Add(this.buttonDone);
            this.panelUp.Controls.Add(this.groupBoxInput);
            this.panelUp.Controls.Add(this.groupBoxDescription);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1071, 143);
            this.panelUp.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInstop);
            this.groupBoxInput.Controls.Add(this.textBoxInstart);
            this.groupBoxInput.Controls.Add(this.textBoxStop);
            this.groupBoxInput.Controls.Add(this.textBoxStart);
            this.groupBoxInput.Location = new System.Drawing.Point(436, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(239, 137);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxInstop
            // 
            this.textBoxInstop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInstop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstop.Location = new System.Drawing.Point(128, 69);
            this.textBoxInstop.Name = "textBoxInstop";
            this.textBoxInstop.ReadOnly = true;
            this.textBoxInstop.Size = new System.Drawing.Size(100, 19);
            this.textBoxInstop.TabIndex = 0;
            this.textBoxInstop.Text = "Конец шага:";
            // 
            // textBoxInstart
            // 
            this.textBoxInstart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInstart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstart.Location = new System.Drawing.Point(3, 69);
            this.textBoxInstart.Name = "textBoxInstart";
            this.textBoxInstart.ReadOnly = true;
            this.textBoxInstart.Size = new System.Drawing.Size(100, 19);
            this.textBoxInstart.TabIndex = 0;
            this.textBoxInstart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(128, 101);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop.TabIndex = 0;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(3, 101);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart.TabIndex = 0;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(436, 137);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 22);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(430, 112);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // panelCentre
            // 
            this.panelCentre.BackColor = System.Drawing.SystemColors.Control;
            this.panelCentre.Controls.Add(this.chartFunc);
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(0, 143);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(1071, 381);
            this.panelCentre.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.groupBoxRes);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 143);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 381);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.textBoxDone);
            this.groupBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(200, 381);
            this.groupBoxRes.TabIndex = 0;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Вывод";
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDone.Location = new System.Drawing.Point(3, 22);
            this.textBoxDone.Multiline = true;
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.ReadOnly = true;
            this.textBoxDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDone.Size = new System.Drawing.Size(194, 356);
            this.textBoxDone.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 143);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 381);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // chartFunc
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea3);
            this.chartFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunc.Legends.Add(legend3);
            this.chartFunc.Location = new System.Drawing.Point(0, 0);
            this.chartFunc.Name = "chartFunc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunc.Series.Add(series3);
            this.chartFunc.Size = new System.Drawing.Size(1071, 381);
            this.chartFunc.TabIndex = 0;
            this.chartFunc.Text = "chartFunc";
            title3.Name = "TitleFunc";
            title3.Text = "График функции (5*x+2,5) / (Sin(x)-2) + 2 ";
            this.chartFunc.Titles.Add(title3);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone.Location = new System.Drawing.Point(681, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(112, 122);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(799, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 122);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(950, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(109, 122);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 524);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelUp);
            this.MinimumSize = new System.Drawing.Size(1093, 580);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Носырева Ю. А.|";
            this.panelUp.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.panelCentre.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelCentre;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInstop;
        private System.Windows.Forms.TextBox textBoxInstart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
    }
}

