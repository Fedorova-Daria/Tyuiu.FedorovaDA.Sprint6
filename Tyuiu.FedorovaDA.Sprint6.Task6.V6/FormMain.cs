using Tyuiu.FedorovaDA.Sprint6.Task6.V6.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonFile_FDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_FDA.ShowDialog();
            openFilePath = openFileDialogTask_FDA.FileName;
            textBoxIn_FDA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_FDA.Text = groupBoxInput_FDA.Text + " " + openFileDialogTask_FDA.FileName;
            buttonDone_FDA.Enabled = true;
        }

        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_FDA.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonQuestion_FDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
