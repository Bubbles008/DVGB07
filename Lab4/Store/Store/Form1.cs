using Store.Logic;
using Store.Models;

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
            if (listBoxCashier.SelectedIndex == -1)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            int id;
            int stock;
            float price; 

            if(!int.TryParse(textId.Text, out id))
            {
                MessageBox.Show("ID Invalid");
                return; 
            }
            if(!float.TryParse(textPrice.Text, out price))
            {
                MessageBox.Show("Invalid price");
                return;
            }
            if(!int.TryParse(textStock.Text, out stock))
            {
                MessageBox.Show("Invalid stock");
                return; 
            }
            if(string.IsNullOrWhiteSpace(textName.Text) ||
               string.IsNullOrWhiteSpace(textAuthor.Text) ||
               string.IsNullOrWhiteSpace(textGenre.Text) ||
               string.IsNullOrWhiteSpace(textFormat.Text) ||
               string.IsNullOrWhiteSpace(textLanguage.Text))

            {
                MessageBox.Show("Please fill in all of the fields");
                return; 
            }
            foreach ( Product product in storeManager.Products)
            {
                if(product.Id == id)
                {
                    MessageBox.Show("A product with this ID already exists");
                    return; 
                }

        }
        Book newBook = new Book(
            id,
            textName.Text,
            price,
            stock,
            textAuthor.Text,
            textGenre.Text,
            textFormat.Text,
            textLanguage.Text
            );

            storeManager.AddProduct(newBook);
            UpdateProductLists();

            textId.Clear();
            textName.Clear();
            textPrice.Clear();
            textStock.Clear();
            textAuthor.Clear();
            textGenre.Clear();
            textFormat.Clear();
            textLanguage.Clear();

            MessageBox.Show("Book added successfully");

        }
    }
}