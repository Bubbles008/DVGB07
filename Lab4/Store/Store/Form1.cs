using Store.Logic;
using Store.Models;

namespace Store
{
    public partial class Form1 : Form
    {
        private StoreManager storeManager = new StoreManager();
        private ShoppingCart shoppingCart = new ShoppingCart();

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
                string productInfo = "";

                if (product is Book book)
                {
                    productInfo = "ID: " + book.Id +
                                  " | Book: " + book.Name +
                                  " | Price: " + book.Price +
                                  " | Stock: " + book.QuantityInStock +
                                  " | Author: " + book.Author +
                                  " | Genre: " + book.Genre +
                                  " | Format: " + book.Format +
                                  " | Language: " + book.Language;
                }
                else if (product is Film film)
                {
                    productInfo = "ID: " + film.Id +
                                  " | Film: " + film.Name +
                                  " | Price: " + film.Price +
                                  " | Stock: " + film.QuantityInStock +
                                  " | Format: " + film.Format +
                                  " | Length: " + film.Duration;
                }
                else if (product is Game game)
                {
                    productInfo = "ID: " + game.Id +
                                  " | Game: " + game.Name +
                                  " | Price: " + game.Price +
                                  " | Stock: " + game.QuantityInStock +
                                  " | Platform: " + game.Platform;
                }
                else
                {
                    productInfo = "ID: " + product.Id +
                                  " | Name: " + product.Name +
                                  " | Price: " + product.Price +
                                  " | Stock: " + product.QuantityInStock;
                }

                listBox1.Items.Add(productInfo);
                listBoxCashier.Items.Add(productInfo);
            }
        }

        private void UpdateCartList()
        {
            listBoxCart.Items.Clear();

            foreach (Product product in shoppingCart.Items)
            {
                string cartInfo = "ID: " + product.Id +
                                  " | " + product.Name +
                                  " | Price: " + product.Price;

                listBoxCart.Items.Add(cartInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeManager.Products.Clear();
            shoppingCart.Items.Clear();

            Book book = new Book(1, "Harry Potter", 199.0f, 10, "J.K. Rowling", "Fantasy", "Hardcover", "English");
            Film film = new Film(2, "Interception", 149.0f, 5, "Blu-ray", 148);
            Game game = new Game(3, "Minecraft", 299.0f, 8, "PC");

            storeManager.AddProduct(book);
            storeManager.AddProduct(film);
            storeManager.AddProduct(game);

            UpdateProductLists();
            UpdateCartList();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxCashier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBoxCashier.SelectedIndex];

            if (selectedProduct.QuantityInStock <= 0)
            {
                MessageBox.Show("This product is out of stock");
                return;
            }

            shoppingCart.AddItem(selectedProduct);
            UpdateCartList();

            MessageBox.Show("Product added to cart");
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Items.Count == 0)
            {
                MessageBox.Show("The cart is empty");
                return;
            }

            foreach (Product product in shoppingCart.Items)
            {
                storeManager.SellProduct(product.Id, 1);
            }

            shoppingCart.Items.Clear();

            UpdateProductLists();
            UpdateCartList();

            MessageBox.Show("Purchase completed");
        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use Add To Cart and Checkout instead of direct sale.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            Product selectedProduct = storeManager.Products[listBox1.SelectedIndex];

            if (selectedProduct.QuantityInStock != 0)
            {
                DialogResult result = MessageBox.Show(
                    "This product still has stock. Do you really want to remove it?",
                    "Confirm removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            bool removed = storeManager.RemoveProduct(selectedProduct.Id);

            if (removed)
            {
                MessageBox.Show("Product removed successfully");
            }
            else
            {
                storeManager.Products.Remove(selectedProduct);
                MessageBox.Show("Product removed successfully");
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            int id;
            int stock;
            float price;

            if (!int.TryParse(textId.Text, out id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            if (!float.TryParse(textPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Invalid price");
                return;
            }

            if (!int.TryParse(textStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock");
                return;
            }

            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textAuthor.Text) ||
                string.IsNullOrWhiteSpace(textGenre.Text) ||
                string.IsNullOrWhiteSpace(textFormat.Text) ||
                string.IsNullOrWhiteSpace(textLanguage.Text))
            {
                MessageBox.Show("Please fill in all of the fields");
                return;
            }

            foreach (Product product in storeManager.Products)
            {
                if (product.Id == id)
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

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            int id;
            int stock;
            int length;
            float price;

            if (!int.TryParse(textFilmId.Text, out id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            if (!float.TryParse(textFilmPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Invalid price");
                return;
            }

            if (!int.TryParse(textFilmStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock");
                return;
            }

            if (!int.TryParse(textFilmLength.Text, out length) || length < 0)
            {
                MessageBox.Show("Invalid length");
                return;
            }

            if (string.IsNullOrWhiteSpace(textFilmName.Text) ||
                string.IsNullOrWhiteSpace(textFilmFormat.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            foreach (Product product in storeManager.Products)
            {
                if (product.Id == id)
                {
                    MessageBox.Show("A product with this ID already exists");
                    return;
                }
            }

            Film newFilm = new Film(
                id,
                textFilmName.Text,
                price,
                stock,
                textFilmFormat.Text,
                length
            );

            storeManager.AddProduct(newFilm);
            UpdateProductLists();

            textFilmId.Clear();
            textFilmName.Clear();
            textFilmPrice.Clear();
            textFilmStock.Clear();
            textFilmFormat.Clear();
            textFilmLength.Clear();

            MessageBox.Show("Film added successfully");
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            int id;
            int stock;
            float price;

            if (!int.TryParse(textGameId.Text, out id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            if (!float.TryParse(textGamePrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Invalid price");
                return;
            }

            if (!int.TryParse(textGameStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock");
                return;
            }

            if (string.IsNullOrWhiteSpace(textGameName.Text) ||
                string.IsNullOrWhiteSpace(textGamePlatform.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            foreach (Product product in storeManager.Products)
            {
                if (product.Id == id)
                {
                    MessageBox.Show("A product with this ID already exists");
                    return;
                }
            }

            Game newGame = new Game(
                id,
                textGameName.Text,
                price,
                stock,
                textGamePlatform.Text
            );

            storeManager.AddProduct(newGame);
            UpdateProductLists();

            textGameId.Clear();
            textGameName.Clear();
            textGamePrice.Clear();
            textGameStock.Clear();
            textGamePlatform.Clear();

            MessageBox.Show("Game added successfully");
        }
    }
}