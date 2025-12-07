using System.Windows.Forms;
using Tyuiu.DolgovIV.Sprint6.Task0.V9.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {

        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResultOutput_DIV.Text = Convert.ToString(dataService.Calculate(Convert.ToInt32(textBoxVarInputX_DIV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxVarInputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 3)
            {
                e.Handled = true;
            }
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0. Выполнил студент группы АСОиУБ-25-1 Долгов Илья Витальевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_DIV_Enter(object sender, EventArgs e)
        {

        }
    }
}
