using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {

        private string currentFilePath = "";
        private bool isModified = false;


        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string fileName = string.IsNullOrEmpty(currentFilePath)
                ? "namnlös.txt"
                : Path.GetFileName(currentFilePath);

            Text = isModified ? "*" + fileName : fileName;

        }

        private bool AskToSaveChanges()
        {
            if (!isModified)
                return true;

            DialogResult result = MessageBox.Show(
                "You have unsaved changes. Do you want to save the file?",
                "Save changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                return SaveFile();
            }
            else if (result == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                return SaveFileAs();
            }

            File.WriteAllText(currentFilePath, editor.Text);
            isModified = false;
            UpdateTitle();
            return true;
        }

        private bool SaveFileAs()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textfiler|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                File.WriteAllText(currentFilePath, editor.Text);
                isModified = false;
                UpdateTitle();
                return true;
            }

            return false;
        }

        private void OpenFile()
        {
            if (!AskToSaveChanges())
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                editor.Text = File.ReadAllText(currentFilePath);
                isModified = false;
                UpdateTitle();
            }
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

        private void nyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AskToSaveChanges())
                return;
            editor.Clear();
            currentFilePath = "";
            isModified = false;
            UpdateTitle();


        }
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void oppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(!AskToSaveChanges())
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}