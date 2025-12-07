using Tyuiu.DolgovIV.Sprint6.Task2.V10.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task2.V10
{
    public partial class FormMain_DIV : Form
    {
        DataService ds = new DataService();
        public FormMain_DIV()
        {
            InitializeComponent();
            buttonDone_DIV.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStepInput_DIV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStepInput_DIV.Text);

                int j = startStep;

                this.chartResult_DIV.Titles.Add("График функции");

                this.chartResult_DIV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_DIV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < ds.GetMassFunction(startStep, stopStep).Length; i++)
                {
                    this.dataGridViewResult_DIV.Rows.Add(Convert.ToString(j), Convert.ToString(ds.GetMassFunction(startStep, stopStep)[i]));

                    this.chartResult_DIV.Series[0].Points.AddXY(j, ds.GetMassFunction(startStep, stopStep)[i]);

                    j++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2. Выполнил студент группы АСОиУБ-25-1 Долгов Илья Витальевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_DIV.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_DIV.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_DIV.BackColor = Color.Blue;
        }
    }
}
