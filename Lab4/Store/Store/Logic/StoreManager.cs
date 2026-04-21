using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Logic
{
    public class StoreManager
    {
        public List<Product> Products { get; set; }

        public StoreManager()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int id)
        {
            Product productToRemove = Products.Find(p => p.Id == id);

            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }

            return false;
        }

        public bool SellProduct(int id, int amount)
        {
            Product product = Products.Find(p => p.Id == id);

            if (product != null && product.IsAvailable(amount))
            {
                product.DecreaseStock(amount);
                return true;
            }

            return false;

    }
}
}
