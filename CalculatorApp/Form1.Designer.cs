namespace CalculatorApp
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
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonC = new Button();
            buttonEq = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(23, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(186, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(23, 53);
            button1.Name = "button1";
            button1.Size = new Size(42, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(71, 53);
            button2.Name = "button2";
            button2.Size = new Size(42, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(119, 53);
            button3.Name = "button3";
            button3.Size = new Size(42, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(23, 82);
            button4.Name = "button4";
            button4.Size = new Size(42, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(71, 82);
            button5.Name = "button5";
            button5.Size = new Size(42, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(119, 82);
            button6.Name = "button6";
            button6.Size = new Size(42, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(23, 111);
            button7.Name = "button7";
            button7.Size = new Size(42, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(71, 111);
            button8.Name = "button8";
            button8.Size = new Size(42, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(119, 111);
            button9.Name = "button9";
            button9.Size = new Size(42, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(71, 140);
            button0.Name = "button0";
            button0.Size = new Size(42, 23);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(23, 140);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(42, 23);
            buttonC.TabIndex = 11;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonEq
            // 
            buttonEq.Location = new Point(119, 140);
            buttonEq.Name = "buttonEq";
            buttonEq.Size = new Size(42, 23);
            buttonEq.TabIndex = 12;
            buttonEq.Text = "=";
            buttonEq.UseVisualStyleBackColor = true;
            buttonEq.Click += buttonEq_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(167, 53);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(42, 23);
            buttonPlus.TabIndex = 13;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(167, 82);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(42, 23);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(167, 111);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(42, 23);
            buttonMul.TabIndex = 15;
            buttonMul.Text = "x";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(167, 140);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(42, 23);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEq);
            Controls.Add(buttonC);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonC;
        private Button buttonEq;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMul;
        private Button buttonDiv;
    }
}