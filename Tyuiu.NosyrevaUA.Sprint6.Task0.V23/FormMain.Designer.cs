
namespace Tyuiu.NosyrevaUA.Sprint6.Task0.V23
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.textBoxGetXInput = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutY = new System.Windows.Forms.TextBox();
            this.textBoxResultOutput = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxDataInput.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxDescription);
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Location = new System.Drawing.Point(30, 31);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(674, 235);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 22);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(326, 210);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(464, 25);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(204, 104);
            this.pictureBoxFormula.TabIndex = 0;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.Controls.Add(this.textBoxGetXInput);
            this.groupBoxDataInput.Controls.Add(this.textBoxX);
            this.groupBoxDataInput.Location = new System.Drawing.Point(30, 290);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(420, 133);
            this.groupBoxDataInput.TabIndex = 1;
            this.groupBoxDataInput.TabStop = false;
            this.groupBoxDataInput.Text = "Ввод Данных";
            // 
            // textBoxGetXInput
            // 
            this.textBoxGetXInput.Location = new System.Drawing.Point(11, 78);
            this.textBoxGetXInput.Name = "textBoxGetXInput";
            this.textBoxGetXInput.Size = new System.Drawing.Size(126, 26);
            this.textBoxGetXInput.TabIndex = 1;
            this.textBoxGetXInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetXInput_KeyPress);
            // 
            // textBoxX
            // 
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxX.Location = new System.Drawing.Point(11, 35);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(126, 19);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Text = "Переменная Х:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxOutPutY);
            this.groupBoxResult.Controls.Add(this.textBoxResultOutput);
            this.groupBoxResult.Location = new System.Drawing.Point(456, 290);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(248, 133);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод Данных";
            // 
            // textBoxOutPutY
            // 
            this.textBoxOutPutY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPutY.Location = new System.Drawing.Point(26, 34);
            this.textBoxOutPutY.Name = "textBoxOutPutY";
            this.textBoxOutPutY.ReadOnly = true;
            this.textBoxOutPutY.Size = new System.Drawing.Size(100, 19);
            this.textBoxOutPutY.TabIndex = 1;
            this.textBoxOutPutY.Text = "Результат:";
            // 
            // textBoxResultOutput
            // 
            this.textBoxResultOutput.Location = new System.Drawing.Point(26, 78);
            this.textBoxResultOutput.Name = "textBoxResultOutput";
            this.textBoxResultOutput.ReadOnly = true;
            this.textBoxResultOutput.Size = new System.Drawing.Size(159, 26);
            this.textBoxResultOutput.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(525, 429);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(179, 57);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(456, 429);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(63, 55);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 512);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxDataInput);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 23 | Носырева Ю. А.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResultOutput;
        private System.Windows.Forms.TextBox textBoxGetXInput;
        private System.Windows.Forms.TextBox textBoxOutPutY;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
    }
}

