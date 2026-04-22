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
    SuspendLayout();

    // listBox1
    listBox1.FormattingEnabled = true;
    listBox1.ItemHeight = 15;
    listBox1.Location = new Point(20, 20);
    listBox1.Name = "listBox1";
    listBox1.Size = new Size(250, 94);
    listBox1.TabIndex = 0;

    // listBoxCashier
    listBoxCashier.FormattingEnabled = true;
    listBoxCashier.ItemHeight = 15;
    listBoxCashier.Location = new Point(20, 150);
    listBoxCashier.Name = "listBoxCashier";
    listBoxCashier.Size = new Size(250, 94);
    listBoxCashier.TabIndex = 1;

    // button1
    button1.Location = new Point(320, 20);
    button1.Name = "button1";
    button1.Size = new Size(140, 23);
    button1.TabIndex = 2;
    button1.Text = "Load Test Products";
    button1.UseVisualStyleBackColor = true;
    button1.Click += button1_Click;

    // buttonSellProduct
    buttonSellProduct.Location = new Point(320, 150);
    buttonSellProduct.Name = "buttonSellProduct";
    buttonSellProduct.Size = new Size(140, 23);
    buttonSellProduct.TabIndex = 3;
    buttonSellProduct.Text = "Sell Selected Product";
    buttonSellProduct.UseVisualStyleBackColor = true;
    buttonSellProduct.Click += buttonSellProduct_Click;

    // button3
    button3.Location = new Point(320, 60);
    button3.Name = "button3";
    button3.Size = new Size(140, 23);
    button3.TabIndex = 4;
    button3.Text = "Remove selected product";
    button3.UseVisualStyleBackColor = true;
    button3.Click += button3_Click;

    // button4
    button4.Location = new Point(320, 90);
    button4.Name = "button4";
    button4.Size = new Size(173, 23);
    button4.TabIndex = 5;
    button4.Text = "Add stock to selected product";
    button4.UseVisualStyleBackColor = true;
    button4.Click += button4_Click;

    // Form1
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(800, 450);
    Controls.Add(button4);
    Controls.Add(button3);
    Controls.Add(buttonSellProduct);
    Controls.Add(button1);
    Controls.Add(listBoxCashier);
    Controls.Add(listBox1);
    Name = "Form1";
    Text = "Form1";
    Load += Form1_Load;
    ResumeLayout(false);
}

        #endregion
private ListBox listBox1;
private ListBox listBoxCashier;
private Button button1;
private Button buttonSellProduct;
private Button button3;
private Button button4;
    }
}