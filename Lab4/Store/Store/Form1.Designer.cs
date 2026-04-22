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
            listBoxCashier = new ListBox();
            button1 = new Button();
            buttonSellProduct = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            Stock = new TabPage();
            Cashier = new TabPage();
            textId = new TextBox();
            textName = new TextBox();
            textPrice = new TextBox();
            textStock = new TextBox();
            textAuthor = new TextBox();
            textGenre = new TextBox();
            textFormat = new TextBox();
            textLanguage = new TextBox();
            buttonAddBook = new Button();
            tabControl1.SuspendLayout();
            Stock.SuspendLayout();
            Cashier.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 94);
            listBox1.TabIndex = 0;
            // 
            // listBoxCashier
            // 
            listBoxCashier.FormattingEnabled = true;
            listBoxCashier.ItemHeight = 15;
            listBoxCashier.Location = new Point(15, 16);
            listBoxCashier.Name = "listBoxCashier";
            listBoxCashier.Size = new Size(250, 94);
            listBoxCashier.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 141);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 2;
            button1.Text = "Load Test Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonSellProduct
            // 
            buttonSellProduct.Location = new Point(53, 168);
            buttonSellProduct.Name = "buttonSellProduct";
            buttonSellProduct.Size = new Size(140, 23);
            buttonSellProduct.TabIndex = 3;
            buttonSellProduct.Text = "Sell Selected Product";
            buttonSellProduct.UseVisualStyleBackColor = true;
            buttonSellProduct.Click += buttonSellProduct_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 170);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 4;
            button3.Text = "Remove selected product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 199);
            button4.Name = "button4";
            button4.Size = new Size(173, 23);
            button4.TabIndex = 5;
            button4.Text = "Add stock to selected product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Stock);
            tabControl1.Controls.Add(Cashier);
            tabControl1.Location = new Point(-1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 452);
            tabControl1.TabIndex = 6;
            // 
            // Stock
            // 
            Stock.Controls.Add(buttonAddBook);
            Stock.Controls.Add(textLanguage);
            Stock.Controls.Add(textFormat);
            Stock.Controls.Add(textGenre);
            Stock.Controls.Add(textAuthor);
            Stock.Controls.Add(textStock);
            Stock.Controls.Add(textPrice);
            Stock.Controls.Add(textName);
            Stock.Controls.Add(textId);
            Stock.Controls.Add(listBox1);
            Stock.Controls.Add(button4);
            Stock.Controls.Add(button1);
            Stock.Controls.Add(button3);
            Stock.Location = new Point(4, 24);
            Stock.Name = "Stock";
            Stock.Padding = new Padding(3);
            Stock.Size = new Size(781, 424);
            Stock.TabIndex = 0;
            Stock.Text = "Stock";
            Stock.UseVisualStyleBackColor = true;
            // 
            // Cashier
            // 
            Cashier.Controls.Add(listBoxCashier);
            Cashier.Controls.Add(buttonSellProduct);
            Cashier.Location = new Point(4, 24);
            Cashier.Name = "Cashier";
            Cashier.Padding = new Padding(3);
            Cashier.Size = new Size(781, 424);
            Cashier.TabIndex = 1;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            // 
            // textId
            // 
            textId.Location = new Point(342, 28);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 6;
            // 
            // textName
            // 
            textName.Location = new Point(342, 57);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 7;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(342, 112);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(100, 23);
            textPrice.TabIndex = 8;
            // 
            // textStock
            // 
            textStock.Location = new Point(342, 154);
            textStock.Name = "textStock";
            textStock.Size = new Size(100, 23);
            textStock.TabIndex = 9;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(342, 199);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(100, 23);
            textAuthor.TabIndex = 10;
            // 
            // textGenre
            // 
            textGenre.Location = new Point(342, 246);
            textGenre.Name = "textGenre";
            textGenre.Size = new Size(100, 23);
            textGenre.TabIndex = 11;
            // 
            // textFormat
            // 
            textFormat.Location = new Point(342, 302);
            textFormat.Name = "textFormat";
            textFormat.Size = new Size(100, 23);
            textFormat.TabIndex = 12;
            // 
            // textLanguage
            // 
            textLanguage.Location = new Point(342, 351);
            textLanguage.Name = "textLanguage";
            textLanguage.Size = new Size(100, 23);
            textLanguage.TabIndex = 13;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(31, 268);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(75, 23);
            buttonAddBook.TabIndex = 14;
            buttonAddBook.Text = "Add Book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Stock.ResumeLayout(false);
            Stock.PerformLayout();
            Cashier.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private ListBox listBoxCashier;
        private Button button1;
        private Button buttonSellProduct;
        private Button button3;
        private Button button4;
        private TabControl tabControl1;
        private TabPage Stock;
        private TabPage Cashier;
        private Button buttonAddBook;
        private TextBox textLanguage;
        private TextBox textFormat;
        private TextBox textGenre;
        private TextBox textAuthor;
        private TextBox textStock;
        private TextBox textPrice;
        private TextBox textName;
        private TextBox textId;
    }
}