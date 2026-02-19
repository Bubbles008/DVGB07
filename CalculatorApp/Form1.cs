using System;
using System.Windows.Forms; 

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private bool newEntry = true;

        public Form1()
        {
            InitializeComponent();

            //Starting point
            txtDisplay.Text = "0";
            newEntry = true;

            button0.Click += (sender, eventArgs) => Digit(0);
            button1.Click += (sender, eventArgs) => Digit(1);
            button2.Click += (sender, eventArgs) => Digit(2);
            button3.Click += (sender, eventArgs) => Digit(3);
            button4.Click += (sender, eventArgs) => Digit(4);
            button5.Click += (sender, eventArgs) => Digit(5);
            button6.Click += (sender, eventArgs) => Digit(6);
            button7.Click += (sender, eventArgs) => Digit(7);
            button8.Click += (sender, eventArgs) => Digit(8);
            button9.Click += (sender, eventArgs) => Digit(9);


        }

        private void Digit(int d)
        {
            if (newEntry) 
            {
                txtDisplay.Text = d.ToString();
                newEntry = false;
                return;
                
            }
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = d.ToString();
                return;
            }

            string candidate = txtDisplay.Text + d.ToString();


            long temp; 
            if(!long.TryParse(candidate, out temp))
            {
                MessageBox.Show("Talet är för stort");
                return;
            }

            txtDisplay.Text = candidate;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void buttonEq_Click(object sender, EventArgs e)
        {

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {

        }
    }
}