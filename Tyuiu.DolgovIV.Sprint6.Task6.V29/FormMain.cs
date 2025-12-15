
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

        private void buttonLoad_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAA.ShowDialog();
            openFilePath = openFileDialogTask_SAA.FileName;
            textBoxIn_SAA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_SAA.Text = groupBoxIn_SAA.Text + "  " + openFileDialogTask_SAA.FileName;
            buttonDone_SAA.Enabled = true;
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            textBoxOut_SAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxTask_SAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
