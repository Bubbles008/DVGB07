using Store.Models;
using System.Text;

namespace Store.Logic
{
    public class CsvHandler
    {
        private string filePath;

        public CsvHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveProducts(List<Product> products)
        {
            List<string> lines = new List<string>();

            foreach (Product product in products)
            {
                if (product is Book book)
                {
                    lines.Add(string.Join(";",
                        "Book",
                        book.Id,
                        book.Name,
                        book.Price,
                        book.QuantityInStock,
                        book.Author,
                        book.Genre,
                        book.Format,
                        book.Language));
                }
                else if (product is Film film)
                {
                    lines.Add(string.Join(";",
                        "Film",
                        film.Id,
                        film.Name,
                        film.Price,
                        film.QuantityInStock,
                        film.Format,
                        film.Duration));
                }
                else if (product is Game game)
                {
                    lines.Add(string.Join(";",
                        "Game",
                        game.Id,
                        game.Name,
                        game.Price,
                        game.QuantityInStock,
                        game.Platform));
                }
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            if (!File.Exists(filePath))
            {
                return products;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                if (parts.Length == 0)
                {
                    continue;
                }

                try
                {
                    if (parts[0] == "Book" && parts.Length >= 9)
                    {
                        Book book = new Book(
                            int.Parse(parts[1]),
                            parts[2],
                            float.Parse(parts[3]),
                            int.Parse(parts[4]),
                            parts[5],
                            parts[6],
                            parts[7],
                            parts[8]
                        );

                        products.Add(book);
                    }
                    else if (parts[0] == "Film" && parts.Length >= 7)
                    {
                        Film film = new Film(
                            int.Parse(parts[1]),
                            parts[2],
                            float.Parse(parts[3]),
                            int.Parse(parts[4]),
                            parts[5],
                            int.Parse(parts[6])
                        );

                        products.Add(film);
                    }
                    else if (parts[0] == "Game" && parts.Length >= 6)
                    {
                        Game game = new Game(
                            int.Parse(parts[1]),
                            parts[2],
                            float.Parse(parts[3]),
                            int.Parse(parts[4]),
                            parts[5]
                        );

                        products.Add(game);
                    }
                }
                catch
                {
                }
            }

            return products;
        }
    }
}