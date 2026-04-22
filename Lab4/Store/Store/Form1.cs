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

            foreach (Product product in storeManager.Products)
            {
                listBox1.Items.Add(product.Name + " - $" + product.Price + "- Stock:" + product.QuantityInStock);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBox1.SelectedIndex];

            bool sold = storeManager.SellProduct(selectedProduct.Id, 1);

            if (sold)
            {
                MessageBox.Show("Product sold successfully");
            }
            else
            {
                MessageBox.Show("Not enough items in stock");
            }
            listBox1.Items.Clear();

            foreach (Product product in storeManager.Products)
            {
                listBox1.Items.Add(product.Name + "- Price: " + product.Price + " -Stock: " + product.QuantityInStock);
            }
        }

    }
}