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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "7";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "10";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(629, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "27";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(523, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "20";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(417, 0);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "13";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(735, 0);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "34";
            // 
            // textDraws
            // 
            textDraws.Location = new Point(311, 58);
            textDraws.Name = "textDraws";
            textDraws.Size = new Size(100, 23);
            textDraws.TabIndex = 7;
            textDraws.Text = "10000";
            textDraws.TextChanged += textDraws_TextChanged;
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
            buttonStart.Location = new Point(428, 58);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 11;
            buttonStart.Text = "Start Lotto";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 3);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 13;
            label2.Text = "Din lottorad:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 61);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 14;
            label1.Text = "Antal dragningar:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 137);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 15;
            label3.Text = "5 rätt:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 137);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 16;
            label4.Text = "6 rätt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 137);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 17;
            label5.Text = "7 rätt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
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
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}