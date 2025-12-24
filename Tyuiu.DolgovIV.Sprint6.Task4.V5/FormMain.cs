using Tyuiu.DolgovIV.Sprint6.Task4.V5.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();



        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartInput.Text);
                int stopStep = Convert.ToInt32(textBoxEndInput.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valuearray;
                valuearray = new double[len];

                valuearray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X:";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y:";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();

                for (global::System.Int32 i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valuearray[i]);
                    textBoxResult.AppendText(valuearray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{(Directory.GetCurrentDirectory())}\OutPutFileTask4V5.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранен \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Сбой в сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
