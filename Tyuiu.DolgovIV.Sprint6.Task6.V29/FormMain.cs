using System.IO;
using Tyuiu.DolgovIV.Sprint6.Task6.V29.Lib;


namespace Tyuiu.DolgovIV.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }

    }
}
