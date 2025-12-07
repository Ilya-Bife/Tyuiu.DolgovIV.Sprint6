using Tyuiu.DolgovIV.Sprint6.Task1.V7.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task1.V7
{

    public partial class FormMain_DIV : Form
    {
        DataService ds = new DataService();
        public FormMain_DIV()
        {
            InitializeComponent();
        }

        private void textBox1_TextCanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                textBoxStartStepInput_DIV.Text += Convert.ToString(ds.GetMassFunction(-5, 5)[i]) + " ";
            }
        }



        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStepInput_DIV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStepInput_DIV.Text);

                string strLine;

                textBoxResult_DIV.Text = "";
                textBoxResult_DIV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_DIV.AppendText("+    X     |   f(X)   +" + Environment.NewLine);
                textBoxResult_DIV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < 11; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}  |", startStep, ds.GetMassFunction(-5, 5)[i]);
                    textBoxResult_DIV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DIV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1. Выполнил студент группы АСОиУБ-25-1 Долгов Илья Витальевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void groupBoxTask_DIV_Enter(object sender, EventArgs e)
        {

        }
    }
}
