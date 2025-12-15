using Tyuiu.DolgovIV.Sprint6.Task5.V9.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Lessons\source\repos\Tyuiu.DolgovIV.Sprint6\Tyuiu.DolgovIV.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 20;
                dataGridViewNums.Columns[1].Width = 50;



                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                this.chartFunction.Series[0].Points.Clear();

                double[] numMass = new double[ds.len];

                numMass = ds.LoadFromDataFile(path);

                for (global::System.Int32 i = 0; i < numMass.Length; i++)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                    chartFunction.Series[0].Points.AddXY(i, numMass[i]);
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
