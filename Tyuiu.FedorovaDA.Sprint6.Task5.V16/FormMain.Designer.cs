namespace Tyuiu.FedorovaDA.Sprint6.Task5.V16
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            groupBoxResult_FDA = new GroupBox();
            dataGridViewResult_FDA = new DataGridView();
            ColumnResult_FDA = new DataGridViewTextBoxColumn();
            buttonDone_FDA = new Button();
            buttonOpenFile_FDA = new Button();
            buttonQuestion_FDA = new Button();
            formsPlotResult_FDA = new ScottPlot.WinForms.FormsPlot();
            groupBoxTask_FDA.SuspendLayout();
            groupBoxResult_FDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_FDA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_FDA
            // 
            groupBoxTask_FDA.Controls.Add(textBoxTask_FDA);
            groupBoxTask_FDA.Location = new Point(12, 12);
            groupBoxTask_FDA.Name = "groupBoxTask_FDA";
            groupBoxTask_FDA.Size = new Size(637, 117);
            groupBoxTask_FDA.TabIndex = 0;
            groupBoxTask_FDA.TabStop = false;
            groupBoxTask_FDA.Text = "Условие";
            // 
            // textBoxTask_FDA
            // 
            textBoxTask_FDA.Location = new Point(6, 17);
            textBoxTask_FDA.Multiline = true;
            textBoxTask_FDA.Name = "textBoxTask_FDA";
            textBoxTask_FDA.ReadOnly = true;
            textBoxTask_FDA.Size = new Size(625, 94);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = resources.GetString("textBoxTask_FDA.Text");
            // 
            // groupBoxResult_FDA
            // 
            groupBoxResult_FDA.Controls.Add(dataGridViewResult_FDA);
            groupBoxResult_FDA.Location = new Point(12, 135);
            groupBoxResult_FDA.Name = "groupBoxResult_FDA";
            groupBoxResult_FDA.Size = new Size(243, 450);
            groupBoxResult_FDA.TabIndex = 1;
            groupBoxResult_FDA.TabStop = false;
            groupBoxResult_FDA.Text = "Вывод данных";
            // 
            // dataGridViewResult_FDA
            // 
            dataGridViewResult_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_FDA.Columns.AddRange(new DataGridViewColumn[] { ColumnResult_FDA });
            dataGridViewResult_FDA.Location = new Point(6, 26);
            dataGridViewResult_FDA.Name = "dataGridViewResult_FDA";
            dataGridViewResult_FDA.RowHeadersWidth = 51;
            dataGridViewResult_FDA.Size = new Size(231, 418);
            dataGridViewResult_FDA.TabIndex = 0;
            // 
            // ColumnResult_FDA
            // 
            ColumnResult_FDA.HeaderText = "";
            ColumnResult_FDA.MinimumWidth = 6;
            ColumnResult_FDA.Name = "ColumnResult_FDA";
            ColumnResult_FDA.ReadOnly = true;
            ColumnResult_FDA.Width = 125;
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.Location = new Point(655, 28);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(115, 86);
            buttonDone_FDA.TabIndex = 2;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = true;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // buttonOpenFile_FDA
            // 
            buttonOpenFile_FDA.Location = new Point(776, 28);
            buttonOpenFile_FDA.Name = "buttonOpenFile_FDA";
            buttonOpenFile_FDA.Size = new Size(115, 86);
            buttonOpenFile_FDA.TabIndex = 3;
            buttonOpenFile_FDA.Text = "Открыть файл";
            buttonOpenFile_FDA.UseVisualStyleBackColor = true;
            buttonOpenFile_FDA.Click += buttonOpenFile_FDA_Click;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.Location = new Point(897, 28);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(115, 86);
            buttonQuestion_FDA.TabIndex = 4;
            buttonQuestion_FDA.Text = "Справка";
            buttonQuestion_FDA.UseVisualStyleBackColor = true;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // formsPlotResult_FDA
            // 
            formsPlotResult_FDA.DisplayScale = 1.25F;
            formsPlotResult_FDA.Location = new Point(261, 135);
            formsPlotResult_FDA.Name = "formsPlotResult_FDA";
            formsPlotResult_FDA.Size = new Size(751, 459);
            formsPlotResult_FDA.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 597);
            Controls.Add(formsPlotResult_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(buttonOpenFile_FDA);
            Controls.Add(buttonDone_FDA);
            Controls.Add(groupBoxResult_FDA);
            Controls.Add(groupBoxTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 16 | Федорова Д.А.";
            groupBoxTask_FDA.ResumeLayout(false);
            groupBoxTask_FDA.PerformLayout();
            groupBoxResult_FDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_FDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_FDA;
        private GroupBox groupBoxResult_FDA;
        private Button buttonDone_FDA;
        private Button buttonOpenFile_FDA;
        private Button buttonQuestion_FDA;
        private DataGridView dataGridViewResult_FDA;
        private DataGridViewTextBoxColumn ColumnResult_FDA;
        private ScottPlot.WinForms.FormsPlot formsPlotResult_FDA;
        private TextBox textBoxTask_FDA;
    }
}
