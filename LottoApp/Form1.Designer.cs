namespace LottoApp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textDraws = new TextBox();
            txt7 = new TextBox();
            txt6 = new TextBox();
            txt5 = new TextBox();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(629, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(523, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(417, 0);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(735, 0);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // textDraws
            // 
            textDraws.Location = new Point(311, 58);
            textDraws.Name = "textDraws";
            textDraws.Size = new Size(100, 23);
            textDraws.TabIndex = 7;
            // 
            // txt7
            // 
            txt7.Location = new Point(523, 129);
            txt7.Name = "txt7";
            txt7.Size = new Size(100, 23);
            txt7.TabIndex = 8;
            // 
            // txt6
            // 
            txt6.Location = new Point(362, 129);
            txt6.Name = "txt6";
            txt6.Size = new Size(100, 23);
            txt6.TabIndex = 9;
            // 
            // txt5
            // 
            txt5.Location = new Point(205, 129);
            txt5.Name = "txt5";
            txt5.Size = new Size(100, 23);
            txt5.TabIndex = 10;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(454, 58);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 11;
            buttonStart.Text = "Start Lotto";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(buttonStart);
            Controls.Add(txt5);
            Controls.Add(txt6);
            Controls.Add(txt7);
            Controls.Add(textDraws);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textDraws;
        private TextBox txt7;
        private TextBox txt6;
        private TextBox txt5;
        private Button buttonStart;
    }
}