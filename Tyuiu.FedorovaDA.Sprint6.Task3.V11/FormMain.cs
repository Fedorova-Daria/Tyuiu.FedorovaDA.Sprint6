using Tyuiu.FedorovaDA.Sprint6.Task3.V11.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrix = new int[,]{
        { 27, -15, 14, 2, 27 },
        { -8, 14, -10, 33, 0 },
        { 1, 7, -11, -11, 23 },
        { -13, -20, 15, -16, 34 },
        { -3, 1, -1, 5, 1 } };
        

        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrix);
            string output = "";

            
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    output += result[i, j].ToString().PadLeft(4) + " ";
                }
                output += Environment.NewLine;
            }

            textBoxResult_FDA.Text = output;
        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-24-1 Федорова Дарья Артемовна", "Сообщение");
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            {
                int rows = mtrix.GetUpperBound(0) + 1;
                int colm = mtrix.Length / rows;

                dataGridView_FDA.ColumnCount = colm;
                dataGridView_FDA.RowCount = rows;

                for (int i = 0; i < colm; i++)
                {
                    dataGridView_FDA.Columns[i].Width = 50;

                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colm; j++)
                    {
                        dataGridView_FDA.Rows[i].Cells[j].Value = Convert.ToString(mtrix[i, j]);
                    }
                }
            }
        }
    }
}
