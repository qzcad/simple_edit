using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

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

        internal TextStatisticsProvider TextStatisticsProvider
        {
            get => default;
            set
            {
            }
        }

        internal ZnuNewsProvider ZnuNewsProvider
        {
            get => default;
            set
            {
            }
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
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
            this.textEditor.Clear();
            this.textChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.SaveChanges();
                this.filePath = this.openFileDialog.FileName;
                string text = System.IO.File.ReadAllText(this.filePath);
                this.textEditor.Text = text;
                this.textChanged = false;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
            this.ShowStatistics();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveChanges();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }

        private void ShowStatistics()
        {
            TextStatisticsProvider provider = new TextStatisticsProvider(this.textEditor.Text);
            var stats = provider.Calc();
            this.mainStatusBar.Items.Clear();
            foreach (var pair in stats)
            {
                this.mainStatusBar.Items.Add(pair.Value);
            }
        }

        private void loadZNUNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZnuNewsProvider provider = new ZnuNewsProvider();
            textEditor.Text += provider.Load();
        }
    }
}