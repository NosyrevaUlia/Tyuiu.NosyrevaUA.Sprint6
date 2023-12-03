
namespace Tyuiu.NosyrevaUA.Sprint6.Task3.V20
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
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.dataGridViewInput);
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(769, 425);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Условие";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Location = new System.Drawing.Point(377, 26);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersWidth = 62;
            this.dataGridViewInput.RowTemplate.Height = 28;
            this.dataGridViewInput.Size = new System.Drawing.Size(304, 325);
            this.dataGridViewInput.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(7, 26);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(363, 393);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewRes);
            this.groupBoxOutPut.Location = new System.Drawing.Point(788, 13);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(362, 374);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Результат";
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.Location = new System.Drawing.Point(47, 26);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.RowHeadersWidth = 62;
            this.dataGridViewRes.RowTemplate.Height = 28;
            this.dataGridViewRes.Size = new System.Drawing.Size(274, 325);
            this.dataGridViewRes.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(956, 393);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(52, 45);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(1031, 393);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(119, 45);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxDescription);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Носырева Ю. А.|";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.DataGridView dataGridViewInput;
    }
}

