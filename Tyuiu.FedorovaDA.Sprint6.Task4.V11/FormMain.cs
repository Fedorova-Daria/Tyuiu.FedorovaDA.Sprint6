using Tyuiu.FedorovaDA.Sprint6.Task4.V11.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_FDA.Text);
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


                formsPlot_FDA.Plot.Title("������ �������");
                formsPlot_FDA.Plot.XLabel("��� X");
                formsPlot_FDA.Plot.YLabel("��� Y");


                formsPlot_FDA.Refresh();
                string strLine;

                textBoxResult_FDA.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(Convert.ToString(valueArray[i]));
                    textBoxResult_FDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFile.txt" });
                File.WriteAllText(path, textBoxResult_FDA.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n ������� ���?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ������-24-1 �������� ����� ���������", "���������");
        }
    }
}
