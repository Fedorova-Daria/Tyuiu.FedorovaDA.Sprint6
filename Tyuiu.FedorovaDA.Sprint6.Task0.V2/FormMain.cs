using Tyuiu.FedorovaDA.Sprint6.Task0.V2.Lib;
namespace Tyuiu.FedorovaDA.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_FDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_FDA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_FDA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_FDA_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 1) && (e.KeyChar == 0))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-24-1 Федорова Дарья Артемовна", "Сообщение");
        }
    }
}
