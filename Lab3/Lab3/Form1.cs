using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {

        private string currentFilePath = "";
        private bool isModified = false;

        private void UpdateTitle()
        {
            string fileName = string.IsNullOrEmpty(currentFilePath)
                ? "namnlös.txt"
                : Path.GetFileName(currentFilePath);

            Text = isModified ? "*" + fileName : fileName;

        }
        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
            UpdateTitle();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}