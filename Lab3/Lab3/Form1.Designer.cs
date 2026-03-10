namespace Lab3
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            arkivToolStripMenuItem = new ToolStripMenuItem();
            nyToolStripMenuItem = new ToolStripMenuItem();
            oppnaToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            sparaSomToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            editor = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arkivToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            arkivToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nyToolStripMenuItem, oppnaToolStripMenuItem, saveToolStripMenuItem, sparaSomToolStripMenuItem, avslutaToolStripMenuItem });
            arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            arkivToolStripMenuItem.Size = new Size(37, 20);
            arkivToolStripMenuItem.Text = "File";
            // 
            // nyToolStripMenuItem
            // 
            nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            nyToolStripMenuItem.Size = new Size(180, 22);
            nyToolStripMenuItem.Text = "New";
            nyToolStripMenuItem.Click += nyToolStripMenuItem_Click;
            // 
            // oppnaToolStripMenuItem
            // 
            oppnaToolStripMenuItem.Name = "oppnaToolStripMenuItem";
            oppnaToolStripMenuItem.Size = new Size(180, 22);
            oppnaToolStripMenuItem.Text = "Open";
            oppnaToolStripMenuItem.Click += oppnaToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += sparaToolStripMenuItem_Click;
            // 
            // sparaSomToolStripMenuItem
            // 
            sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            sparaSomToolStripMenuItem.Size = new Size(180, 22);
            sparaSomToolStripMenuItem.Text = "Save As";
            sparaSomToolStripMenuItem.Click += sparaSomToolStripMenuItem_Click;
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(180, 22);
            avslutaToolStripMenuItem.Text = "Exit";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // editor
            // 
            editor.Dock = DockStyle.Fill;
            editor.Location = new Point(0, 24);
            editor.Name = "editor";
            editor.Size = new Size(800, 426);
            editor.TabIndex = 1;
            editor.Text = "";
            editor.TextChanged += Form1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "namnlös.txt";
            Load += Form1_Load;
            TextChanged += Form1_TextChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arkivToolStripMenuItem;
        private RichTextBox editor;
        private ToolStripMenuItem nyToolStripMenuItem;
        private ToolStripMenuItem oppnaToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem sparaSomToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
    }
}