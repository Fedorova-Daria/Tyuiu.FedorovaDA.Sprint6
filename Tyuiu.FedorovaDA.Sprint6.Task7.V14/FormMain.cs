using Tyuiu.FedorovaDA.Sprint6.Task7.V14.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_FDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_FDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_FDA_Click(object sender, EventArgs e)
        {
            openFileDialog_FDA.ShowDialog();
            openFilePath = openFileDialog_FDA.FileName;

            int[,] arrayValues = new int[rows, cols];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewOpen_FDA.ColumnCount = cols;
            dataGridViewOpen_FDA.RowCount = rows;
            dataGridViewSave_FDA.ColumnCount = cols;
            dataGridViewSave_FDA.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewOpen_FDA.Columns[i].Width = 25;
                dataGridViewSave_FDA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOpen_FDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_FDA.Enabled = true;

        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewSave_FDA.Rows[r].Cells[c].Value = arrayValues[r, c];

                }
            }
            buttonSaveFile_FDA.Enabled = true;
        }

        private void buttonSaveFile_FDA_Click(object sender, EventArgs e)
        {
            saveFileDialog_FDA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_FDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_FDA.ShowDialog();

            string path = saveFileDialog_FDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewSave_FDA.RowCount;
            int cols = dataGridViewSave_FDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewSave_FDA.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str += dataGridViewSave_FDA.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
        private void buttonOpenFile_FDA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FDA.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_FDA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FDA.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_FDA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FDA.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonQuestion_FDA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FDA.ToolTipTitle = "Данные о пользователе";
        }
    }
}
