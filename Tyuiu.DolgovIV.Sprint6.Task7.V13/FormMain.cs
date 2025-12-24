using Tyuiu.DolgovIV.Sprint6.Task7.V13.Lib;


namespace Tyuiu.DolgovIV.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";

        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] array = new int[rows, columns];

            array = LoadFromFileData(openFilePath);

            dataGridViewInPut_DIV.ColumnCount = columns;
            dataGridViewInPut_DIV.RowCount = rows;
            dataGridViewOutPut_DIV.ColumnCount = columns;
            dataGridViewOutPut_DIV.RowCount = rows;

            for (int i = 0; i <= columns; i++)
            {
                dataGridViewInPut_DIV.Columns[i].Width = 25;
                dataGridViewOutPut_DIV.Columns[i].Width = 25;
            }

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut_DIV.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            array = ds.GetMatrix(openFilePath);
            buttonResult_DIV.Enabled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_DIV.Rows[i].Cells[j].Value = arrayValues[i, j];

                }
            }

            buttonSaveFile_DIV.Enabled = true;
        }

        private void dataGridViewOutPut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);

            }

            int rows = dataGridViewOutPut_DIV.RowCount;
            int columns = dataGridViewOutPut_DIV.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_DIV.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOutPut_DIV.Rows[i].Cells[j].Value;
                    }

                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_DIV.RowCount = 50;
            dataGridViewOutPut_DIV.RowCount = 50;

            dataGridViewInPut_DIV.ColumnCount = 50;
            dataGridViewOutPut_DIV.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_DIV.Columns[i].Width = 25;
                dataGridViewOutPut_DIV.Columns[i].Width = 25;
            }
        }

        private void dataGridViewInPut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBoxInfo_DIV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
