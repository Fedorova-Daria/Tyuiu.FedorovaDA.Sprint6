using System.Windows.Forms;
using ScottPlot;
using System;
using Tyuiu.FedorovaDA.Sprint6.Task5.V16.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Daria\source\repos\Tyuiu.FedorovaDA.Sprint6\Tyuiu.FedorovaDA.Sprint6.Task5.V16\bin\Debug\net8.0-windows\InPutFileTask5V16.txt";
        private void SetupPlot()
        {
            formsPlotResult_FDA.Plot.Title("������������� �����");
            formsPlotResult_FDA.Plot.XLabel("�����");
            formsPlotResult_FDA.Plot.YLabel("��������");
        }
        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                double[] positiveNumbers = ds.LoadFromDataFile("InPutFileTask5V16.txt");

                dataGridViewResult_FDA.Rows.Clear();
                formsPlotResult_FDA.Plot.Clear();

                if (dataGridViewResult_FDA.Columns.Count == 0)
                {
                    dataGridViewResult_FDA.Columns.Add("Value", "��������");
                }

                for (int i = 0; i < positiveNumbers.Length; i++)
                {
                    dataGridViewResult_FDA.Rows.Add(positiveNumbers[i].ToString(""));
                }

                double[] positions = new double[positiveNumbers.Length];
                for (int i = 0; i < positions.Length; i++)
                {
                    positions[i] = i + 1;
                }

                var bar = formsPlotResult_FDA.Plot.Add.Bars(positiveNumbers);


                formsPlotResult_FDA.Refresh();

                if (positiveNumbers.Length == 0)
                {
                    MessageBox.Show("������������� ����� � ����� �� �������", "����������",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_FDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ ������-24-1 �������� ����� ���������", "���������");
        }
    }
}
