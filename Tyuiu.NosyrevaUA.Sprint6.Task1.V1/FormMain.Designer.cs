
namespace Tyuiu.NosyrevaUA.Sprint6.Task1.V1
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
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescriptionOfTask = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxResDesc = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxStepInput = new System.Windows.Forms.GroupBox();
            this.textBoxSecondStep = new System.Windows.Forms.TextBox();
            this.textBoxFirstStep = new System.Windows.Forms.TextBox();
            this.textBoxStepSecondInput = new System.Windows.Forms.TextBox();
            this.textBoxStepFirstInput = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.textBoxStepInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxDescriptionOfTask);
            this.groupBoxDescription.Location = new System.Drawing.Point(13, 12);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(545, 198);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие";
            // 
            // textBoxDescriptionOfTask
            // 
            this.textBoxDescriptionOfTask.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDescriptionOfTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescriptionOfTask.Location = new System.Drawing.Point(7, 25);
            this.textBoxDescriptionOfTask.Multiline = true;
            this.textBoxDescriptionOfTask.Name = "textBoxDescriptionOfTask";
            this.textBoxDescriptionOfTask.ReadOnly = true;
            this.textBoxDescriptionOfTask.Size = new System.Drawing.Size(522, 167);
            this.textBoxDescriptionOfTask.TabIndex = 0;
            this.textBoxDescriptionOfTask.Text = "Протабулировать функцию cos(2x) + (sin(x)) / (x + 2,5) + 2x на заданном диапазоне" +
    ".\r\nРезультат вывести в таблице.\r\n";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxResDesc);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(565, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(244, 299);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResDesc
            // 
            this.textBoxResDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResDesc.Location = new System.Drawing.Point(7, 25);
            this.textBoxResDesc.Name = "textBoxResDesc";
            this.textBoxResDesc.ReadOnly = true;
            this.textBoxResDesc.Size = new System.Drawing.Size(100, 19);
            this.textBoxResDesc.TabIndex = 1;
            this.textBoxResDesc.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(7, 55);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(240, 255);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // textBoxStepInput
            // 
            this.textBoxStepInput.Controls.Add(this.textBoxSecondStep);
            this.textBoxStepInput.Controls.Add(this.textBoxFirstStep);
            this.textBoxStepInput.Controls.Add(this.textBoxStepSecondInput);
            this.textBoxStepInput.Controls.Add(this.textBoxStepFirstInput);
            this.textBoxStepInput.Location = new System.Drawing.Point(13, 225);
            this.textBoxStepInput.Name = "textBoxStepInput";
            this.textBoxStepInput.Size = new System.Drawing.Size(296, 102);
            this.textBoxStepInput.TabIndex = 2;
            this.textBoxStepInput.TabStop = false;
            this.textBoxStepInput.Text = "Ввод данных";
            // 
            // textBoxSecondStep
            // 
            this.textBoxSecondStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSecondStep.Location = new System.Drawing.Point(151, 36);
            this.textBoxSecondStep.Name = "textBoxSecondStep";
            this.textBoxSecondStep.ReadOnly = true;
            this.textBoxSecondStep.Size = new System.Drawing.Size(100, 19);
            this.textBoxSecondStep.TabIndex = 1;
            this.textBoxSecondStep.Text = "Конец шага:";
            // 
            // textBoxFirstStep
            // 
            this.textBoxFirstStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstStep.Location = new System.Drawing.Point(7, 36);
            this.textBoxFirstStep.Name = "textBoxFirstStep";
            this.textBoxFirstStep.ReadOnly = true;
            this.textBoxFirstStep.Size = new System.Drawing.Size(100, 19);
            this.textBoxFirstStep.TabIndex = 1;
            this.textBoxFirstStep.Text = "Старт шага:";
            // 
            // textBoxStepSecondInput
            // 
            this.textBoxStepSecondInput.Location = new System.Drawing.Point(151, 71);
            this.textBoxStepSecondInput.Name = "textBoxStepSecondInput";
            this.textBoxStepSecondInput.Size = new System.Drawing.Size(133, 26);
            this.textBoxStepSecondInput.TabIndex = 0;
            // 
            // textBoxStepFirstInput
            // 
            this.textBoxStepFirstInput.Location = new System.Drawing.Point(7, 71);
            this.textBoxStepFirstInput.Name = "textBoxStepFirstInput";
            this.textBoxStepFirstInput.Size = new System.Drawing.Size(133, 26);
            this.textBoxStepFirstInput.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp.Location = new System.Drawing.Point(315, 237);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(91, 90);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(414, 237);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(145, 90);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 335);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxStepInput);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxDescription);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Носырева Ю. А.";
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.textBoxStepInput.ResumeLayout(false);
            this.textBoxStepInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxDescriptionOfTask;
        private System.Windows.Forms.GroupBox textBoxStepInput;
        private System.Windows.Forms.TextBox textBoxStepSecondInput;
        private System.Windows.Forms.TextBox textBoxStepFirstInput;
        private System.Windows.Forms.TextBox textBoxSecondStep;
        private System.Windows.Forms.TextBox textBoxFirstStep;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxResDesc;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

