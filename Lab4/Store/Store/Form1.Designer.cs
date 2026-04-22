namespace Store
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
            listBox1 = new ListBox();
            button1 = new Button();
            butonSellProduct = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPageStock = new TabPage();
            tabPageCashier = new TabPage();
            listBoxCashier = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            tabControl1.SuspendLayout();
            tabPageStock.SuspendLayout();
            tabPageCashier.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 94);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(6, 115);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 1;
            button1.Text = "Load Test Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // butonSellProduct
            // 
            butonSellProduct.Location = new Point(29, 201);
            butonSellProduct.Name = "butonSellProduct";
            butonSellProduct.Size = new Size(140, 23);
            butonSellProduct.TabIndex = 2;
            butonSellProduct.Text = "Sell Selected Product";
            butonSellProduct.UseVisualStyleBackColor = true;
            butonSellProduct.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 173);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 3;
            button3.Text = "Remove selected product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 202);
            button4.Name = "button4";
            button4.Size = new Size(173, 23);
            button4.TabIndex = 4;
            button4.Text = "Add stock to selected product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageStock);
            tabControl1.Controls.Add(tabPageCashier);
            tabControl1.Location = new Point(12, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 483);
            tabControl1.TabIndex = 5;
            // 
            // tabPageStock
            // 
            tabPageStock.Controls.Add(textBox8);
            tabPageStock.Controls.Add(listBox1);
            tabPageStock.Controls.Add(textBox7);
            tabPageStock.Controls.Add(textBox6);
            tabPageStock.Controls.Add(textBox5);
            tabPageStock.Controls.Add(textBox4);
            tabPageStock.Controls.Add(textBox3);
            tabPageStock.Controls.Add(textBox2);
            tabPageStock.Controls.Add(textBox1);
            tabPageStock.Controls.Add(button4);
            tabPageStock.Controls.Add(button1);
            tabPageStock.Controls.Add(button3);
            tabPageStock.Location = new Point(4, 24);
            tabPageStock.Name = "tabPageStock";
            tabPageStock.Padding = new Padding(3);
            tabPageStock.Size = new Size(459, 306);
            tabPageStock.TabIndex = 0;
            tabPageStock.Text = "Stock";
            tabPageStock.UseVisualStyleBackColor = true;
            // 
            // tabPageCashier
            // 
            tabPageCashier.Controls.Add(butonSellProduct);
            tabPageCashier.Controls.Add(listBoxCashier);
            tabPageCashier.Location = new Point(4, 24);
            tabPageCashier.Name = "tabPageCashier";
            tabPageCashier.Padding = new Padding(3);
            tabPageCashier.Size = new Size(797, 455);
            tabPageCashier.TabIndex = 1;
            tabPageCashier.Text = "Cashier";
            tabPageCashier.UseVisualStyleBackColor = true;
            // 
            // listBoxCashier
            // 
            listBoxCashier.FormattingEnabled = true;
            listBoxCashier.ItemHeight = 15;
            listBoxCashier.Location = new Point(6, 17);
            listBoxCashier.Name = "listBoxCashier";
            listBoxCashier.Size = new Size(251, 94);
            listBoxCashier.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(302, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(302, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(302, 202);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(302, 241);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(302, 280);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 486);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageStock.ResumeLayout(false);
            tabPageStock.PerformLayout();
            tabPageCashier.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button butonSellProduct;
        private Button button3;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPageStock;
        private TabPage tabPageCashier;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBoxCashier;
    }
}