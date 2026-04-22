using Store.Logic;
using Store.Models;
using System.Diagnostics.Eventing.Reader;

namespace Store
{
    public partial class Form1 : Form


    {
        private StoreManager storeManager = new StoreManager();
        public Form1()
        {
            InitializeComponent();


        }

        private void UpdateProductLists()
        {
            listBox1.Items.Clear();
            listBoxCashier.Items.Clear();

            foreach (Product product in storeManager.Products)
            {
                string productInfo = product.Name + " - Price: " + product.Price + " - Stock: " + product.QuantityInStock;

                listBox1.Items.Add(productInfo);
                listBoxCashier.Items.Add(productInfo);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeManager.Products.Clear();
            listBox1.Items.Clear();

            Book book = new Book(1, "Harry Potter", 199.0f, 10, "J.K. Rowling", "Fantasy", "Hardcover", "English");
            Film film = new Film(2, "Interception", 149.0f, 5, "Blu-ray", 148);
            Game game = new Game(3, "Minecraft", 299.0f, 8, "PC");

            storeManager.AddProduct(book);
            storeManager.AddProduct(film);
            storeManager.AddProduct(game);

            UpdateProductLists();

        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBoxCashier.SelectedIndex];

            bool sold = storeManager.SellProduct(selectedProduct.Id, 1);

            if (sold)
            {
                MessageBox.Show("Product sold successfully");
            }
            else
            {
                MessageBox.Show("Not enough items in stock");
            }
            UpdateProductLists();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBox1.SelectedIndex];

            bool removed = storeManager.RemoveProduct(selectedProduct.Id);

            if (removed)
            {
                MessageBox.Show("Product removed successfully");

            }
            else
            {
                MessageBox.Show("Could not remove product, product can only be removed when stock is 0");
            }

            UpdateProductLists();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBox1.SelectedIndex];
            selectedProduct.IncreaseStock(1);

            MessageBox.Show("Stock increased by 1");

            UpdateProductLists();

           
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}