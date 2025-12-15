using Tyuiu.DolgovIV.Sprint6.Task3.V28.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        int[,] matr = new int[5, 5] { { -9, 8, 9, 16, -18 }, { -13, -11, -20, -15, 9 }, { 18, 13, -12, -15, -11 }, { 10, -2, 19, -4, -10, }, { 6, -20, -4, 13, -14 } };
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            int row = matr.GetUpperBound(0) + 1;
            int col = matr.Length / row;

            dataGridViewMatrix.RowCount = row;
            dataGridViewMatrix.ColumnCount = col;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < row; i++)
            {
                for (global::System.Int32 j = 0; j < col; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sunder, EventArgs e)
        {
            int[,] resmatr = dataService.Calculate(matr);

            int row = resmatr.GetUpperBound(0) + 1;
            int col = resmatr.Length / row;

            dataGridViewMatrix.RowCount = row;
            dataGridViewMatrix.ColumnCount = col;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < row; i++)
            {
                for (global::System.Int32 j = 0; j < col; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(resmatr[i, j]);
                }
            }

        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3. Выполнил студент группы АСОиУБ-25-1 Долгов Илья Витальевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
