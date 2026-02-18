using System;
using System.Linq;
using System.Windows.Forms;

namespace LottoApp
{
    public partial class Form1 : Form
    {
        private readonly Random _rng = new Random();
        private readonly int[] _pool = Enumerable.Range(1, 35).ToArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Antal dragningar måste vara ett positivt heltal.", "Fel",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long c5 = 0, c6 = 0, c7 = 0;

                for (int i = 0; i < draws; i++)
                {
                    int matches = DrawAndCountMatches(picked);

                    if (matches == 5) c5++;
                    else if (matches == 6) c6++;
                    else if (matches == 7) c7++;
                }

                txt5.Text = c5.ToString();
                txt6.Text = c6.ToString();
                txt7.Text = c7.ToString();
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
                string s = boxes[i].Text.Trim();

                if (!int.TryParse(s, out int n))
                    throw new Exception("Alla 7 tal måste vara heltal.");

                if (n < 1 || n > 35)
                    throw new Exception("Alla tal måste vara mellan 1 och 35.");

                nums[i] = n;
            }

            if (nums.Distinct().Count() != 7)
                throw new Exception("Talen måste vara unika (inga dubletter).");

            return nums;
        }

        private int DrawAndCountMatches(bool[] picked)
        {
      
            for (int i = 0; i < 7; i++)
            {
                int j = _rng.Next(i, 35);
                int tmp = _pool[i];
                _pool[i] = _pool[j];
                _pool[j] = tmp;
            }

            int matches = 0;
            for (int i = 0; i < 7; i++)
            {
                int drawn = _pool[i];
                if (picked[drawn]) matches++;
            }

            return matches;
        }
    }
}