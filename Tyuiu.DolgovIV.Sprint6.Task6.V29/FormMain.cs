
using Tyuiu.DolgovIV.Sprint6.Task6.V29.Lib;


namespace Tyuiu.DolgovIV.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonLoad_DIV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DIV.ShowDialog();
            openFilePath = openFileDialogTask_DIV.FileName;
            textBoxIn_DIV.Text = File.ReadAllText(openFilePath);
            groupBoxIn_DIV.Text = groupBoxIn_DIV.Text + "  " + openFileDialogTask_DIV.FileName;
            buttonDone_DIV.Enabled = true;
        }

        private void buttonDone_DIV_Click(object sender, EventArgs e)
        {
            textBoxOut_DIV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_DIV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTask_DIV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOut_DIV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
