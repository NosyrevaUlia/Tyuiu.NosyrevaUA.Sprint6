
namespace Tyuiu.NosyrevaUA.Sprint6.Task6.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoDescription1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.splitterLeftRight = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipFirstTry = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp.SuspendLayout();
            this.groupBoDescription1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.buttonHelp);
            this.panelUp.Controls.Add(this.buttonDone);
            this.panelUp.Controls.Add(this.buttonOpenFile);
            this.panelUp.Controls.Add(this.groupBoDescription1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1050, 219);
            this.panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp.Location = new System.Drawing.Point(937, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(101, 85);
            this.buttonHelp.TabIndex = 1;
            this.toolTipFirstTry.SetToolTip(this.buttonHelp, "Сведения о программе");
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone.BackgroundImage")));
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone.Enabled = false;
            this.buttonDone.Location = new System.Drawing.Point(134, 13);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(101, 85);
            this.buttonDone.TabIndex = 1;
            this.toolTipFirstTry.SetToolTip(this.buttonDone, "Выводит первое слово каждой строки в результирующею строку");
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.BackgroundImage")));
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(101, 85);
            this.buttonOpenFile.TabIndex = 1;
            this.toolTipFirstTry.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // groupBoDescription1
            // 
            this.groupBoDescription1.Controls.Add(this.textBoxDescription);
            this.groupBoDescription1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoDescription1.Location = new System.Drawing.Point(0, 104);
            this.groupBoDescription1.Name = "groupBoDescription1";
            this.groupBoDescription1.Size = new System.Drawing.Size(1050, 115);
            this.groupBoDescription1.TabIndex = 0;
            this.groupBoDescription1.TabStop = false;
            this.groupBoDescription1.Text = "Условие:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 22);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(1044, 90);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxInput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 219);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(544, 380);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxIn);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(544, 380);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            this.textBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn.Location = new System.Drawing.Point(3, 22);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ReadOnly = true;
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(538, 355);
            this.textBoxIn.TabIndex = 0;
            // 
            // splitterLeftRight
            // 
            this.splitterLeftRight.Location = new System.Drawing.Point(544, 219);
            this.splitterLeftRight.Name = "splitterLeftRight";
            this.splitterLeftRight.Size = new System.Drawing.Size(3, 380);
            this.splitterLeftRight.TabIndex = 2;
            this.splitterLeftRight.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxOutput);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(547, 219);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(503, 380);
            this.panelRight.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxOut);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(503, 380);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut.Location = new System.Drawing.Point(3, 22);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(497, 355);
            this.textBoxOut.TabIndex = 0;
            this.toolTipFirstTry.SetToolTip(this.textBoxOut, "Открыть файл\r\nВыберите нужный файл для обработки");
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 599);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitterLeftRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUp);
            this.MinimumSize = new System.Drawing.Size(1072, 655);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Носырева Ю. А.|";
            this.panelUp.ResumeLayout(false);
            this.groupBoDescription1.ResumeLayout(false);
            this.groupBoDescription1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.GroupBox groupBoDescription1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitterLeftRight;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ToolTip toolTipFirstTry;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
    }
}

