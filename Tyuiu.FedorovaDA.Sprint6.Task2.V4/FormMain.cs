using Tyuiu.FedorovaDA.Sprint6.Task2.V4.Lib;
using ScottPlot;
using ScottPlot.WinForms;
using System.Drawing;
using System.Windows.Forms;
namespace Tyuiu.FedorovaDA.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            buttonDone_FDA = new Button();
            buttonQuestion_FDA = new Button();
            groupEnter_FDA = new GroupBox();
            textBoxStartSter_FDA = new TextBox();
            textBoxStopStep_FDA = new TextBox();
            textStopStep_FDA = new TextBox();
            textStartStep_FDA = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView_FDA = new DataGridView();
            formsPlot_FDA = new FormsPlot();
            textResult_FDA = new TextBox();
            bindingSource1 = new BindingSource(components);
            ColumnnX_FDA = new DataGridViewTextBoxColumn();
            ColumnnF_FDA = new DataGridViewTextBoxColumn();
            groupTask_FDA.SuspendLayout();
            groupEnter_FDA.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_FDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupTask_FDA
            // 
            groupTask_FDA.Controls.Add(textBoxTask_FDA);
            groupTask_FDA.Location = new Point(12, 21);
            groupTask_FDA.Name = "groupTask_FDA";
            groupTask_FDA.Size = new Size(584, 338);
            groupTask_FDA.TabIndex = 1;
            groupTask_FDA.TabStop = false;
            groupTask_FDA.Text = "Условие";
            // 
            // textBoxTask_FDA
            // 
            textBoxTask_FDA.BackColor = SystemColors.Control;
            textBoxTask_FDA.BorderStyle = BorderStyle.None;
            textBoxTask_FDA.Location = new Point(6, 26);
            textBoxTask_FDA.Multiline = true;
            textBoxTask_FDA.Name = "textBoxTask_FDA";
            textBoxTask_FDA.ReadOnly = true;
            textBoxTask_FDA.Size = new Size(555, 283);
            textBoxTask_FDA.TabIndex = 0;
            textBoxTask_FDA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            buttonDone_FDA.Location = new Point(481, 376);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(115, 96);
            buttonDone_FDA.TabIndex = 6;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = false;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            buttonQuestion_FDA.Location = new Point(360, 376);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(115, 96);
            buttonQuestion_FDA.TabIndex = 5;
            buttonQuestion_FDA.Text = "Справка";
            buttonQuestion_FDA.UseVisualStyleBackColor = false;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // groupEnter_FDA
            // 
            groupEnter_FDA.Controls.Add(textBoxStartSter_FDA);
            groupEnter_FDA.Controls.Add(textBoxStopStep_FDA);
            groupEnter_FDA.Controls.Add(textStopStep_FDA);
            groupEnter_FDA.Controls.Add(textStartStep_FDA);
            groupEnter_FDA.Location = new Point(12, 365);
            groupEnter_FDA.Name = "groupEnter_FDA";
            groupEnter_FDA.Size = new Size(342, 107);
            groupEnter_FDA.TabIndex = 4;
            groupEnter_FDA.TabStop = false;
            groupEnter_FDA.Text = "Ввод данных";
            // 
            // textBoxStartSter_FDA
            // 
            textBoxStartSter_FDA.Location = new Point(6, 73);
            textBoxStartSter_FDA.Name = "textBoxStartSter_FDA";
            textBoxStartSter_FDA.Size = new Size(125, 27);
            textBoxStartSter_FDA.TabIndex = 3;
            // 
            // textBoxStopStep_FDA
            // 
            textBoxStopStep_FDA.Location = new Point(200, 73);
            textBoxStopStep_FDA.Name = "textBoxStopStep_FDA";
            textBoxStopStep_FDA.Size = new Size(125, 27);
            textBoxStopStep_FDA.TabIndex = 2;
            // 
            // textStopStep_FDA
            // 
            textStopStep_FDA.BackColor = SystemColors.Control;
            textStopStep_FDA.BorderStyle = BorderStyle.None;
            textStopStep_FDA.Location = new Point(200, 35);
            textStopStep_FDA.Name = "textStopStep_FDA";
            textStopStep_FDA.ReadOnly = true;
            textStopStep_FDA.Size = new Size(94, 20);
            textStopStep_FDA.TabIndex = 1;
            textStopStep_FDA.Text = "Конец шага";
            // 
            // textStartStep_FDA
            // 
            textStartStep_FDA.BackColor = SystemColors.Control;
            textStartStep_FDA.BorderStyle = BorderStyle.None;
            textStartStep_FDA.Location = new Point(6, 35);
            textStartStep_FDA.Name = "textStartStep_FDA";
            textStartStep_FDA.ReadOnly = true;
            textStartStep_FDA.Size = new Size(94, 20);
            textStartStep_FDA.TabIndex = 0;
            textStartStep_FDA.Text = "Старт шага";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_FDA);
            groupBox2.Controls.Add(formsPlot_FDA);
            groupBox2.Controls.Add(textResult_FDA);
            groupBox2.Location = new Point(602, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 451);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // dataGridView_FDA
            // 
            dataGridView_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_FDA.Columns.AddRange(new DataGridViewColumn[] { ColumnnX_FDA, ColumnnF_FDA });
            dataGridView_FDA.Location = new Point(14, 47);
            dataGridView_FDA.Name = "dataGridView_FDA";
            dataGridView_FDA.RowHeadersVisible = false;
            dataGridView_FDA.RowHeadersWidth = 51;
            dataGridView_FDA.Size = new Size(165, 397);
            dataGridView_FDA.TabIndex = 4;
            // 
            // formsPlot_FDA
            // 
            formsPlot_FDA.DisplayScale = 1.25F;
            formsPlot_FDA.Location = new Point(185, 47);
            formsPlot_FDA.Name = "formsPlot_FDA";
            formsPlot_FDA.Size = new Size(332, 398);
            formsPlot_FDA.TabIndex = 3;
            // 
            // textResult_FDA
            // 
            textResult_FDA.BackColor = SystemColors.Control;
            textResult_FDA.BorderStyle = BorderStyle.None;
            textResult_FDA.Location = new Point(14, 21);
            textResult_FDA.Name = "textResult_FDA";
            textResult_FDA.ReadOnly = true;
            textResult_FDA.Size = new Size(94, 20);
            textResult_FDA.TabIndex = 2;
            textResult_FDA.Text = "Результат:";
            // 
            // ColumnnX_FDA
            // 
            ColumnnX_FDA.HeaderText = "X";
            ColumnnX_FDA.MinimumWidth = 6;
            ColumnnX_FDA.Name = "ColumnnX_FDA";
            ColumnnX_FDA.ReadOnly = true;
            ColumnnX_FDA.Width = 85;
            // 
            // ColumnnF_FDA
            // 
            ColumnnF_FDA.HeaderText = "F(x)";
            ColumnnF_FDA.MinimumWidth = 6;
            ColumnnF_FDA.Name = "ColumnnF_FDA";
            ColumnnF_FDA.ReadOnly = true;
            ColumnnF_FDA.Width = 85;
            // 
            // FormMain
            // 
            ClientSize = new Size(1137, 484);
            Controls.Add(groupBox2);
            Controls.Add(buttonDone_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(groupEnter_FDA);
            Controls.Add(groupTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 4 | Федорова Д.А.";
            groupTask_FDA.ResumeLayout(false);
            groupTask_FDA.PerformLayout();
            groupEnter_FDA.ResumeLayout(false);
            groupEnter_FDA.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_FDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        DataService ds = new DataService();
        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartSter_FDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_FDA.Text);

                double[] valueArray;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                double[] xData = new double[len];
                double[] yData = new double[len];

                for (int i = 0; i < len; i++)
                {
                    xData[i] = startStep + i;
                    yData[i] = valueArray[i];
                }


                formsPlot_FDA.Plot.Clear();


                var scatter = formsPlot_FDA.Plot.Add.Scatter(xData, yData);


                formsPlot_FDA.Plot.Title("График функции");
                formsPlot_FDA.Plot.XLabel("Ось X");
                formsPlot_FDA.Plot.YLabel("Ось Y");


                formsPlot_FDA.Refresh();





                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_FDA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Федорова Дарья Артемовна", "Сообщение");
        }
    }
}
