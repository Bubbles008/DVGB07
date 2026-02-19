using System;
using System.Windows.Forms; 

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private bool newEntry = true;
        private long currentValue = 0;
        private char pendingOperator = '\0';
        private long lastRightOperand = 0;
        private char lastOperator = '\0';


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

            buttonC.Click += (sender, eventArgs) => ClearAll();
            buttonEq.Click += (sender, eventArgs) => HandleEquals();



            buttonPlus.Click += (sender, eventArgs) => HandleOperator('+');
            buttonMinus.Click += (sender, eventArgs) => HandleOperator('-');
            buttonMul.Click += (sender, eventArgs) => HandleOperator('*');
            buttonDiv.Click += (sender, eventArgs) => HandleOperator('/');



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

        private void ClearAll()
        {
            txtDisplay.Text = "0";
            newEntry = true; 
            currentValue = 0;
            pendingOperator = '\0';
            lastRightOperand = 0;
            lastOperator = '\0';
        }

        private long ReadDisplay()
        {
            long displayValue;
            if (!long.TryParse(txtDisplay.Text, out displayValue))
                throw new Exception("Ogiltigt tal i display");
            return displayValue;
        }

        private void HandleEquals()
        {
            try
            {
                long displayValue = ReadDisplay();

                if(pendingOperator != '\0')
                {
                    long result = Apply(currentValue, displayValue, pendingOperator);
                    txtDisplay.Text = result.ToString();

                    lastOperator = pendingOperator;
                    lastRightOperand = displayValue;

                    currentValue = result; 
                    pendingOperator = '\0';
                    newEntry = true;
                }
                else if(lastOperator != '\0')
                {
                    long result = Apply(displayValue, lastRightOperand, lastOperator);
                    txtDisplay.Text = result.ToString();
                    newEntry = true; 
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division med 0 är inte tillåten");
                ClearAll();
            }
            catch(OverflowException)
            {
                MessageBox.Show("Resultatet är för stort/litet");
                ClearAll();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                ClearAll();
            }
        }

        private void HandleOperator(char operatorSymbol)
        {
            try
            {
                long displayValue = ReadDisplay();
                if (pendingOperator == '\0')
                {
                    currentValue = displayValue;
                }
                else if(!newEntry)
                {
                    currentValue = Apply(currentValue, displayValue, pendingOperator);
                    txtDisplay.Text = currentValue.ToString();

                }
                pendingOperator = operatorSymbol;
                    newEntry = true; 

                    lastOperator = '\0';
                    lastRightOperand = 0;

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division med 0 är inte tillåten");
                ClearAll();
            }
            catch(OverflowException)
            {
                MessageBox.Show("Resultatet är för stort/litet");
                ClearAll();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                ClearAll();
            }
        }

        private long Apply(long a, long b, char operatorSymbol)
        {
            checked
            {
                if (operatorSymbol == '+') return a + b;
                if (operatorSymbol == '-') return a - b;
                if (operatorSymbol == '*') return a * b;
                if (operatorSymbol == '/')
                {
                    if (b == 0) throw new DivideByZeroException();
                    return a / b; 
                }
                throw new Exception("Okänd operator");
            }
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