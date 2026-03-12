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
            statusStrip1 = new StatusStrip();
            charCountLabel = new ToolStripStatusLabel();
            charNoSpacesLabel = new ToolStripStatusLabel();
            wordCountLabel = new ToolStripStatusLabel();
            lineCountLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            nyToolStripMenuItem.Size = new Size(114, 22);
            nyToolStripMenuItem.Text = "New";
            nyToolStripMenuItem.Click += nyToolStripMenuItem_Click;
            // 
            // oppnaToolStripMenuItem
            // 
            oppnaToolStripMenuItem.Name = "oppnaToolStripMenuItem";
            oppnaToolStripMenuItem.Size = new Size(114, 22);
            oppnaToolStripMenuItem.Text = "Open";
            oppnaToolStripMenuItem.Click += oppnaToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += sparaToolStripMenuItem_Click;
            // 
            // sparaSomToolStripMenuItem
            // 
            sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            sparaSomToolStripMenuItem.Size = new Size(114, 22);
            sparaSomToolStripMenuItem.Text = "Save As";
            sparaSomToolStripMenuItem.Click += sparaSomToolStripMenuItem_Click;
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(114, 22);
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { charCountLabel, charNoSpacesLabel, wordCountLabel, lineCountLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // charCountLabel
            // 
            charCountLabel.Name = "charCountLabel";
            charCountLabel.Size = new Size(49, 17);
            charCountLabel.Text = "Chars: 0";
            charCountLabel.Click += toolStripStatusLabel1_Click;
            // 
            // charNoSpacesLabel
            // 
            charNoSpacesLabel.Name = "charNoSpacesLabel";
            charNoSpacesLabel.Size = new Size(112, 17);
            charNoSpacesLabel.Text = "Chars (no spaces): 0";
            // 
            // wordCountLabel
            // 
            wordCountLabel.Name = "wordCountLabel";
            wordCountLabel.Size = new Size(53, 17);
            wordCountLabel.Text = "Words: 0";
            // 
            // lineCountLabel
            // 
            lineCountLabel.Name = "lineCountLabel";
            lineCountLabel.Size = new Size(46, 17);
            lineCountLabel.Text = "Lines: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(editor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "namnlös.txt";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel charCountLabel;
        private ToolStripStatusLabel charNoSpacesLabel;
        private ToolStripStatusLabel wordCountLabel;
        private ToolStripStatusLabel lineCountLabel;
    }
}