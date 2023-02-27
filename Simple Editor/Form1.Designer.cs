namespace Simple_Editor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mainToolBar = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            mainStatusBar = new StatusStrip();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            textEditor = new RichTextBox();
            mainMenu.SuspendLayout();
            mainToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(7, 3, 0, 3);
            mainMenu.Size = new Size(914, 30);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator2, openToolStripMenuItem, toolStripSeparator4, saveToolStripMenuItem, saveasToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(141, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(138, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(138, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(141, 26);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveasToolStripMenuItem
            // 
            saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            saveasToolStripMenuItem.Size = new Size(141, 26);
            saveasToolStripMenuItem.Text = "Save &as";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 26);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mainToolBar
            // 
            mainToolBar.ImageScalingSize = new Size(20, 20);
            mainToolBar.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripSeparator1 });
            mainToolBar.Location = new Point(0, 30);
            mainToolBar.Name = "mainToolBar";
            mainToolBar.Size = new Size(914, 27);
            mainToolBar.TabIndex = 2;
            mainToolBar.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(43, 24);
            toolStripButtonNew.Text = "New";
            toolStripButtonNew.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButtonNew.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // mainStatusBar
            // 
            mainStatusBar.ImageScalingSize = new Size(20, 20);
            mainStatusBar.Location = new Point(0, 578);
            mainStatusBar.Name = "mainStatusBar";
            mainStatusBar.Padding = new Padding(1, 0, 16, 0);
            mainStatusBar.Size = new Size(914, 22);
            mainStatusBar.TabIndex = 3;
            mainStatusBar.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // textEditor
            // 
            textEditor.Dock = DockStyle.Fill;
            textEditor.Location = new Point(0, 57);
            textEditor.Margin = new Padding(3, 4, 3, 4);
            textEditor.Name = "textEditor";
            textEditor.Size = new Size(914, 521);
            textEditor.TabIndex = 4;
            textEditor.Text = "";
            textEditor.TextChanged += textEditor_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textEditor);
            Controls.Add(mainStatusBar);
            Controls.Add(mainToolBar);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Simple Edit";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            mainToolBar.ResumeLayout(false);
            mainToolBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveasToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip mainToolBar;
        private StatusStrip mainStatusBar;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private RichTextBox textEditor;
        private ToolStripButton toolStripButtonNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
    }
}