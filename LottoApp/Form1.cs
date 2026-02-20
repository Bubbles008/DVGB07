using System;
using System.Windows.Forms;
using System.Linq;

namespace LottoApp
{
    public partial class Form1 : Form
    {
        private readonly Random randomGenerator = new Random();
        private readonly int[] numberPool = new int[35];
        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i<35; i++)
           {
                numberPool[i] = i + 1;
           }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            textDraws.Clear();

            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] user = ReadUserRow();
                bool[] picked = new bool[36];
                foreach (int n in user) picked[n] = true;

                if (!int.TryParse(textDraws.Text.Trim(), out int draws) || draws <= 0)
                {
                    MessageBox.Show("Antal dragningar måste vara ett positivt heltal", "Fel",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long count5Right = 0, count6Right = 0, count7Right = 0;

                for (int i = 0; i < draws; i++)
                {
                    int matches = DrawAndCountMatches(picked);

                    if (matches == 5) count5Right++;
                    else if (matches == 6) count6Right++;
                    else if (matches == 7) count7Right++;
                }

                txt5.Text = count5Right.ToString();
                txt6.Text = count6Right.ToString();
                txt7.Text = count7Right.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int[] ReadUserRow()
        {
            TextBox[] boxes = new[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7
            };

            int[] nums = new int[7];

            for (int i = 0; i < 7; i++)
            {
                string inputText = boxes[i].Text.Trim();

                if (!int.TryParse(inputText, out int n))
                    throw new Exception("Alla 7 tal måste vara heltal");

                if (n < 1 || n > 35)
                    throw new Exception("Alla tal måste vara mellan 1 och 35");

                nums[i] = n;
            }

            if (nums.Distinct().Count() != 7)
                throw new Exception("Talen måste vara unika,inga dubletter");

            return nums;
        }

        private int DrawAndCountMatches(bool[] picked)
        {

            for (int i = 0; i < 7; i++)
            {
                int j = randomGenerator.Next(i, 35);
                int temp = numberPool[i];
                numberPool[i] = numberPool[j];
                numberPool[j] = temp;
            }

            int matches = 0;
            for (int i = 0; i < 7; i++)
            {
                int drawn = numberPool[i];
                if (picked[drawn]) matches++;
            }

            return matches;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textDraws_TextChanged(object sender, EventArgs e)
        {

        }
    }
}