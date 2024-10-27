using Tyuiu.FedorovaDA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            groupTask_FDA = new GroupBox();
            textBoxTask_FDA = new TextBox();
            groupEnter_FDA = new GroupBox();
            textBoxStartSter_FDA = new TextBox();
            textBoxStopStep_FDA = new TextBox();
            textStopStep_FDA = new TextBox();
            textStartStep_FDA = new TextBox();
            buttonQuestion_FDA = new Button();
            buttonDone_FDA = new Button();
            groupResult_FDA = new GroupBox();
            textBoxResult_FDA = new TextBox();
            groupTask_FDA.SuspendLayout();
            groupEnter_FDA.SuspendLayout();
            groupResult_FDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupTask_FDA
            // 
            groupTask_FDA.Controls.Add(textBoxTask_FDA);
            groupTask_FDA.Location = new Point(23, 12);
            groupTask_FDA.Name = "groupTask_FDA";
            groupTask_FDA.Size = new Size(584, 329);
            groupTask_FDA.TabIndex = 0;
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
            // groupEnter_FDA
            // 
            groupEnter_FDA.Controls.Add(textBoxStartSter_FDA);
            groupEnter_FDA.Controls.Add(textBoxStopStep_FDA);
            groupEnter_FDA.Controls.Add(textStopStep_FDA);
            groupEnter_FDA.Controls.Add(textStartStep_FDA);
            groupEnter_FDA.Location = new Point(23, 359);
            groupEnter_FDA.Name = "groupEnter_FDA";
            groupEnter_FDA.Size = new Size(342, 107);
            groupEnter_FDA.TabIndex = 1;
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
            // buttonQuestion_FDA
            // 
            buttonQuestion_FDA.BackColor = Color.FromArgb(192, 255, 255);
            buttonQuestion_FDA.Location = new Point(371, 370);
            buttonQuestion_FDA.Name = "buttonQuestion_FDA";
            buttonQuestion_FDA.Size = new Size(115, 96);
            buttonQuestion_FDA.TabIndex = 2;
            buttonQuestion_FDA.Text = "Справка";
            buttonQuestion_FDA.UseVisualStyleBackColor = false;
            buttonQuestion_FDA.Click += buttonQuestion_FDA_Click;
            // 
            // buttonDone_FDA
            // 
            buttonDone_FDA.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_FDA.Location = new Point(492, 370);
            buttonDone_FDA.Name = "buttonDone_FDA";
            buttonDone_FDA.Size = new Size(115, 96);
            buttonDone_FDA.TabIndex = 3;
            buttonDone_FDA.Text = "Выполнить";
            buttonDone_FDA.UseVisualStyleBackColor = false;
            buttonDone_FDA.Click += buttonDone_FDA_Click;
            // 
            // groupResult_FDA
            // 
            groupResult_FDA.Controls.Add(textBoxResult_FDA);
            groupResult_FDA.Location = new Point(624, 12);
            groupResult_FDA.Name = "groupResult_FDA";
            groupResult_FDA.Size = new Size(468, 454);
            groupResult_FDA.TabIndex = 4;
            groupResult_FDA.TabStop = false;
            groupResult_FDA.Text = "Вывод данных";
            // 
            // textBoxResult_FDA
            // 
            textBoxResult_FDA.BackColor = SystemColors.Control;
            textBoxResult_FDA.BorderStyle = BorderStyle.None;
            textBoxResult_FDA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_FDA.Location = new Point(6, 26);
            textBoxResult_FDA.Multiline = true;
            textBoxResult_FDA.Name = "textBoxResult_FDA";
            textBoxResult_FDA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_FDA.Size = new Size(456, 421);
            textBoxResult_FDA.TabIndex = 0;
            // 
            // FormMain
            // 
            ClientSize = new Size(1126, 514);
            Controls.Add(groupResult_FDA);
            Controls.Add(buttonDone_FDA);
            Controls.Add(buttonQuestion_FDA);
            Controls.Add(groupEnter_FDA);
            Controls.Add(groupTask_FDA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Федорова Д.А.";
            groupTask_FDA.ResumeLayout(false);
            groupTask_FDA.PerformLayout();
            groupEnter_FDA.ResumeLayout(false);
            groupEnter_FDA.PerformLayout();
            groupResult_FDA.ResumeLayout(false);
            groupResult_FDA.PerformLayout();
            ResumeLayout(false);
        }

        DataService ds = new DataService();
        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartSter_FDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_FDA.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_FDA.Text = "";
                textBoxResult_FDA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_FDA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_FDA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxResult_FDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_FDA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-24-1 Федорова Дарья Артемовна", "Сообщение");
        }
    }
}
