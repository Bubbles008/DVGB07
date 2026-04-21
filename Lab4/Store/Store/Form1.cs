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

        private void button1_Click(object sender, EventArgs e)
        {
            storeManager.Products.Clear();
            listBox1.Items.Clear();

            Book book = new Book(1,"Harry Potter", 199.0f,10, "J.K. Rowling", "Fantasy", "Hardcover","English");
            Film film = new Film(2, "Interception", 149.0f, 5, "Blu-ray", 148);
            Game game = new Game(3, "Minecraft", 299.0f, 8, "PC");

            storeManager.AddProduct(book);
            storeManager.AddProduct(film);
            storeManager.AddProduct(game);

            foreach( Product product in storeManager.Products)
            { 
                listBox1.Items.Add(product.Name + " - $" + product.Price + "- Stock:" + product.QuantityInStock); }

        }
    }
}