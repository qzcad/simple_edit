namespace Simple_Editor
{
    public partial class MainForm : Form
    {
        private string filePath;
        private bool textChanged;

        public MainForm()
        {
            InitializeComponent();

            this.filePath = "";
            this.textChanged = false;
        }

        private void WriteText(string filePath)
        {
            this.filePath = filePath;
            System.IO.File.WriteAllText(this.filePath, this.textEditor.Text);
            this.textChanged = false;
        }

        private void SaveAs()
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.WriteText(this.saveFileDialog.FileName);
            }
        }

        private void Save()
        {
            if (this.filePath == null || this.filePath == "")
            {
                this.SaveAs();
            }
            else
            {
                this.WriteText(this.filePath);
            }
        }

        private void SaveChanges()
        {
            if (this.textChanged) 
            { 
                if (MessageBox.Show("Save changes?", "Text is changed", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    this.Save();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textEditor.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.filePath = this.openFileDialog.FileName;
                string text = System.IO.File.ReadAllText(this.filePath);
                this.textEditor.Text = text;
                this.textChanged = false;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
        }
    }
}