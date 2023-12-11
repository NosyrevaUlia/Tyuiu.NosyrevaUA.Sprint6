
namespace Tyuiu.NosyrevaUA.Sprint6.Task7.V1
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.splitterLeftRight = new System.Windows.Forms.Splitter();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panelUp.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.buttonHelp);
            this.panelUp.Controls.Add(this.buttonSave);
            this.panelUp.Controls.Add(this.buttonDone);
            this.panelUp.Controls.Add(this.buttonOpenFile);
            this.panelUp.Controls.Add(this.groupBoxDescription);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1198, 220);
            this.panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp.Location = new System.Drawing.Point(1086, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 73);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(253, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 73);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            // 
            // buttonDone
            // 
            this.buttonDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone.BackgroundImage")));
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone.Enabled = false;
            this.buttonDone.Location = new System.Drawing.Point(132, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(100, 73);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.BackgroundImage")));
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 73);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 92);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(1198, 128);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 22);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(1192, 103);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.dataGridViewIn);
            this.groupBoxIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxIn.Location = new System.Drawing.Point(0, 220);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(604, 429);
            this.groupBoxIn.TabIndex = 1;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.RowHeadersWidth = 62;
            this.dataGridViewIn.RowTemplate.Height = 28;
            this.dataGridViewIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewIn.Size = new System.Drawing.Size(598, 404);
            this.dataGridViewIn.TabIndex = 0;
            // 
            // splitterLeftRight
            // 
            this.splitterLeftRight.Location = new System.Drawing.Point(604, 220);
            this.splitterLeftRight.Name = "splitterLeftRight";
            this.splitterLeftRight.Size = new System.Drawing.Size(3, 429);
            this.splitterLeftRight.TabIndex = 2;
            this.splitterLeftRight.TabStop = false;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.dataGridViewOut);
            this.groupBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut.Location = new System.Drawing.Point(607, 220);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(591, 429);
            this.groupBoxOut.TabIndex = 3;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.RowHeadersWidth = 62;
            this.dataGridViewOut.RowTemplate.Height = 28;
            this.dataGridViewOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOut.Size = new System.Drawing.Size(585, 404);
            this.dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            this.toolTipButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.splitterLeftRight);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.panelUp);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 1 | Носырева Ю. А.|";
            this.panelUp.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.Splitter splitterLeftRight;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}

