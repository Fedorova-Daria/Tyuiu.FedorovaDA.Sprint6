namespace Tyuiu.FedorovaDA.Sprint6.Task4.V11
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
            buttonDone_FDA = new Button();
            formsPlot_FDA = new ScottPlot.WinForms.FormsPlot();
            textBoxStartStep_FDA = new TextBox();
            textBoxStopStep_FDA = new TextBox();
            groupBoxTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            groupBoxData_FDA = new GroupBox();
            textStopStep_FDA = new TextBox();
            textStartStep_FDA = new TextBox();
            groupBoxResult_FDA = new GroupBox();
            textBoxResult_FDA = new TextBox();
            buttonQuestion_FDA = new Button();
            buttonSave_FDA = new Button();
            groupBoxTask_FDA.SuspendLayout();
            groupBoxData_FDA.SuspendLayout();
            groupBoxResult_FDA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_FDA.Location = new Point(863, 23);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(126, 80);
            buttonDone_FDA.TabIndex = 0;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = false;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // formsPlot_FDA
            // 
            formsPlot_FDA.DisplayScale = 1.25F;
            formsPlot_FDA.Location = new Point(360, 134);
            formsPlot_FDA.Name = "formsPlot_FDA";
            formsPlot_FDA.Size = new Size(887, 506);
            formsPlot_FDA.TabIndex = 1;
            // 
            // textBoxStartStep_FDA
            // 
            textBoxStartStep_FDA.Location = new Point(6, 55);
            textBoxStartStep_FDA.Name = "textBoxStartStep_FDA";
            textBoxStartStep_FDA.Size = new Size(134, 27);
            textBoxStartStep_FDA.TabIndex = 2;
            // 
            // textBoxStopStep_FDA
            // 
            textBoxStopStep_FDA.Location = new Point(164, 55);
            textBoxStopStep_FDA.Name = "textBoxStopStep_FDA";
            textBoxStopStep_FDA.Size = new Size(135, 27);
            textBoxStopStep_FDA.TabIndex = 3;
            // 
            // groupBoxTask_FDA
            // 
            groupBoxTask_FDA.Controls.Add(textBoxTask_FDA);
            groupBoxTask_FDA.Location = new Point(12, 12);
            groupBoxTask_FDA.Name = "groupBoxTask_FDA";
            groupBoxTask_FDA.Size = new Size(530, 116);
            groupBoxTask_FDA.TabIndex = 4;
            groupBoxTask_FDA.TabStop = false;
            groupBoxTask_FDA.Text = "Условие";
            // 
            // textBoxTask_FDA
            // 
            textBoxTask_FDA.BorderStyle = BorderStyle.None;
            textBoxTask_FDA.Location = new Point(6, 26);
            textBoxTask_FDA.Multiline = true;
            textBoxTask_FDA.Name = "textBoxTask_FDA";
            textBoxTask_FDA.ReadOnly = true;
            textBoxTask_FDA.Size = new Size(518, 84);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = "Протабулируйте функцию на заданном диапазоне от -5 до 5\r\nРезультат вывести в textBox. Построить график функции и сохранить в файл OutPutFileTask.txt по нажатию кнопки\r\n\r\n";
            // 
            // groupBoxData_FDA
            // 
            groupBoxData_FDA.Controls.Add(textStopStep_FDA);
            groupBoxData_FDA.Controls.Add(textStartStep_FDA);
            groupBoxData_FDA.Controls.Add(textBoxStartStep_FDA);
            groupBoxData_FDA.Controls.Add(textBoxStopStep_FDA);
            groupBoxData_FDA.Location = new Point(548, 12);
            groupBoxData_FDA.Name = "groupBoxData_FDA";
            groupBoxData_FDA.Size = new Size(309, 116);
            groupBoxData_FDA.TabIndex = 5;
            groupBoxData_FDA.TabStop = false;
            groupBoxData_FDA.Text = "Ввод данных";
            // 
            // textStopStep_FDA
            // 
            textStopStep_FDA.BorderStyle = BorderStyle.None;
            textStopStep_FDA.Location = new Point(164, 29);
            textStopStep_FDA.Name = "textStopStep_FDA";
            textStopStep_FDA.ReadOnly = true;
            textStopStep_FDA.Size = new Size(125, 20);
            textStopStep_FDA.TabIndex = 5;
            textStopStep_FDA.Text = "Конец шага";
            // 
            // textStartStep_FDA
            // 
            textStartStep_FDA.BorderStyle = BorderStyle.None;
            textStartStep_FDA.Location = new Point(6, 29);
            textStartStep_FDA.Name = "textStartStep_FDA";
            textStartStep_FDA.ReadOnly = true;
            textStartStep_FDA.Size = new Size(125, 20);
            textStartStep_FDA.TabIndex = 4;
            textStartStep_FDA.Text = "Старт шага";
            // 
            // groupBoxResult_FDA
            // 
            groupBoxResult_FDA.Controls.Add(textBoxResult_FDA);
            groupBoxResult_FDA.Location = new Point(12, 130);
            groupBoxResult_FDA.Name = "groupBoxResult_FDA";
            groupBoxResult_FDA.Size = new Size(342, 510);
            groupBoxResult_FDA.TabIndex = 5;
            groupBoxResult_FDA.TabStop = false;
            groupBoxResult_FDA.Text = "Вывод";
            // 
            // textBoxResult_FDA
            // 
            textBoxResult_FDA.BackColor = SystemColors.ControlLightLight;
            textBoxResult_FDA.Location = new Point(6, 26);
            textBoxResult_FDA.Multiline = true;
            textBoxResult_FDA.Name = "textBoxResult_FDA";
            textBoxResult_FDA.ReadOnly = true;
            textBoxResult_FDA.Size = new Size(330, 466);
            textBoxResult_FDA.TabIndex = 0;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.BackColor = Color.FromArgb(192, 255, 255);
            buttonQuestion_FDA.Location = new Point(1127, 23);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(126, 80);
            buttonQuestion_FDA.TabIndex = 6;
            buttonQuestion_FDA.Text = "Справка";
            buttonQuestion_FDA.UseVisualStyleBackColor = false;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // buttonSave_FDA
            // 
            buttonSave_FDA.BackColor = Color.FromArgb(255, 255, 192);
            buttonSave_FDA.Location = new Point(995, 23);
            buttonSave_FDA.Name = "buttonSave_FDA";
            buttonSave_FDA.Size = new Size(126, 80);
            buttonSave_FDA.TabIndex = 7;
            buttonSave_FDA.Text = "Сохранить";
            buttonSave_FDA.UseVisualStyleBackColor = false;
            buttonSave_FDA.Click += buttonSave_FDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 634);
            Controls.Add(buttonSave_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(groupBoxResult_FDA);
            Controls.Add(groupBoxData_FDA);
            Controls.Add(groupBoxTask_FDA);
            Controls.Add(formsPlot_FDA);
            Controls.Add(buttonDone_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 11 | Федорова Д.А.";
            groupBoxTask_FDA.ResumeLayout(false);
            groupBoxTask_FDA.PerformLayout();
            groupBoxData_FDA.ResumeLayout(false);
            groupBoxData_FDA.PerformLayout();
            groupBoxResult_FDA.ResumeLayout(false);
            groupBoxResult_FDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_FDA;
        private ScottPlot.WinForms.FormsPlot formsPlot_FDA;
        private TextBox textBoxStartStep_FDA;
        private TextBox textBoxStopStep_FDA;
        private GroupBox groupBoxTask_FDA;
        private GroupBox groupBoxData_FDA;
        private TextBox textBoxTask_FDA;
        private GroupBox groupBoxResult_FDA;
        private Button buttonQuestion_FDA;
        private Button buttonSave_FDA;
        private TextBox textStopStep_FDA;
        private TextBox textStartStep_FDA;
        private TextBox textBoxResult_FDA;
    }
}
