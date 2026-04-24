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
            buttonAddFilm = new Button();
            label17 = new Label();
            textFilmLength = new TextBox();
            textFilmFormat = new TextBox();
            textFilmStock = new TextBox();
            textFilmPrice = new TextBox();
            textFilmName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            textFilmId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ID = new Label();
            buttonAddBook = new Button();
            textLanguage = new TextBox();
            textFormat = new TextBox();
            textGenre = new TextBox();
            textAuthor = new TextBox();
            textStock = new TextBox();
            textPrice = new TextBox();
            textName = new TextBox();
            textId = new TextBox();
            Cashier = new TabPage();
            tabControl1.SuspendLayout();
            Stock.SuspendLayout();
            Cashier.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(655, 94);
            listBox1.TabIndex = 0;
            // 
            // listBoxCashier
            // 
            listBoxCashier.AllowDrop = true;
            listBoxCashier.FormattingEnabled = true;
            listBoxCashier.ItemHeight = 15;
            listBoxCashier.Location = new Point(15, 16);
            listBoxCashier.Name = "listBoxCashier";
            listBoxCashier.Size = new Size(250, 94);
            listBoxCashier.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(9, 110);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 2;
            button1.Text = "Load Test Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonSellProduct
            // 
            buttonSellProduct.Location = new Point(36, 138);
            buttonSellProduct.Name = "buttonSellProduct";
            buttonSellProduct.Size = new Size(140, 23);
            buttonSellProduct.TabIndex = 3;
            buttonSellProduct.Text = "Sell Selected Product";
            buttonSellProduct.UseVisualStyleBackColor = true;
            buttonSellProduct.Click += buttonSellProduct_Click;
            // 
            // button3
            // 
            button3.Location = new Point(155, 110);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 4;
            button3.Text = "Remove selected product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(9, 150);
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
            Stock.Controls.Add(buttonAddFilm);
            Stock.Controls.Add(label17);
            Stock.Controls.Add(textFilmLength);
            Stock.Controls.Add(textFilmFormat);
            Stock.Controls.Add(textFilmStock);
            Stock.Controls.Add(textFilmPrice);
            Stock.Controls.Add(textFilmName);
            Stock.Controls.Add(label16);
            Stock.Controls.Add(label15);
            Stock.Controls.Add(label14);
            Stock.Controls.Add(label13);
            Stock.Controls.Add(label12);
            Stock.Controls.Add(label11);
            Stock.Controls.Add(textFilmId);
            Stock.Controls.Add(label10);
            Stock.Controls.Add(label9);
            Stock.Controls.Add(label8);
            Stock.Controls.Add(label7);
            Stock.Controls.Add(label6);
            Stock.Controls.Add(label5);
            Stock.Controls.Add(label4);
            Stock.Controls.Add(label3);
            Stock.Controls.Add(label2);
            Stock.Controls.Add(label1);
            Stock.Controls.Add(ID);
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
            Stock.Click += Stock_Click;
            // 
            // buttonAddFilm
            // 
            buttonAddFilm.Location = new Point(353, 395);
            buttonAddFilm.Name = "buttonAddFilm";
            buttonAddFilm.Size = new Size(75, 23);
            buttonAddFilm.TabIndex = 39;
            buttonAddFilm.Text = "Add Film";
            buttonAddFilm.UseVisualStyleBackColor = true;
            buttonAddFilm.Click += buttonAddFilm_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(289, 200);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 38;
            label17.Text = "Film";
            label17.Click += label17_Click;
            // 
            // textFilmLength
            // 
            textFilmLength.Location = new Point(392, 316);
            textFilmLength.Name = "textFilmLength";
            textFilmLength.Size = new Size(100, 23);
            textFilmLength.TabIndex = 37;
            // 
            // textFilmFormat
            // 
            textFilmFormat.Location = new Point(279, 316);
            textFilmFormat.Name = "textFilmFormat";
            textFilmFormat.Size = new Size(100, 23);
            textFilmFormat.TabIndex = 36;
            // 
            // textFilmStock
            // 
            textFilmStock.Location = new Point(392, 271);
            textFilmStock.Name = "textFilmStock";
            textFilmStock.Size = new Size(100, 23);
            textFilmStock.TabIndex = 35;
            // 
            // textFilmPrice
            // 
            textFilmPrice.Location = new Point(279, 271);
            textFilmPrice.Name = "textFilmPrice";
            textFilmPrice.Size = new Size(100, 23);
            textFilmPrice.TabIndex = 34;
            // 
            // textFilmName
            // 
            textFilmName.Location = new Point(392, 233);
            textFilmName.Name = "textFilmName";
            textFilmName.Size = new Size(100, 23);
            textFilmName.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(392, 298);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 32;
            label16.Text = "Length";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(279, 298);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 31;
            label15.Text = "Format";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(392, 258);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 30;
            label14.Text = "Stock";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(279, 258);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 29;
            label13.Text = "Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(392, 220);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 28;
            label12.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(279, 215);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 27;
            label11.Text = "ID";
            // 
            // textFilmId
            // 
            textFilmId.Location = new Point(279, 233);
            textFilmId.Name = "textFilmId";
            textFilmId.Size = new Size(100, 23);
            textFilmId.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 200);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 25;
            label10.Text = "Book";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(121, 349);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 24;
            label9.Text = "Language";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 349);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 23;
            label8.Text = "Format";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 300);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 22;
            label7.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 300);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 21;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 259);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 20;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 258);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 19;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 215);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 18;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 324);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 17;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 221);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(3, 215);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 15;
            ID.Text = "ID";
            ID.Click += label1_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(74, 396);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(75, 23);
            buttonAddBook.TabIndex = 14;
            buttonAddBook.Text = "Add Book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // textLanguage
            // 
            textLanguage.Location = new Point(121, 367);
            textLanguage.Name = "textLanguage";
            textLanguage.Size = new Size(100, 23);
            textLanguage.TabIndex = 13;
            // 
            // textFormat
            // 
            textFormat.Location = new Point(3, 367);
            textFormat.Name = "textFormat";
            textFormat.Size = new Size(100, 23);
            textFormat.TabIndex = 12;
            // 
            // textGenre
            // 
            textGenre.Location = new Point(120, 318);
            textGenre.Name = "textGenre";
            textGenre.Size = new Size(100, 23);
            textGenre.TabIndex = 11;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(3, 318);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(100, 23);
            textAuthor.TabIndex = 10;
            // 
            // textStock
            // 
            textStock.Location = new Point(120, 271);
            textStock.Name = "textStock";
            textStock.Size = new Size(100, 23);
            textStock.TabIndex = 9;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(0, 271);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(100, 23);
            textPrice.TabIndex = 8;
            // 
            // textName
            // 
            textName.Location = new Point(120, 233);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 7;
            // 
            // textId
            // 
            textId.Location = new Point(3, 233);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 6;
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
        private Label ID;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private TextBox textFilmPrice;
        private TextBox textFilmName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textFilmId;
        private Label label17;
        private TextBox textFilmLength;
        private TextBox textFilmFormat;
        private TextBox textFilmStock;
        private Button buttonAddFilm;
    }
}