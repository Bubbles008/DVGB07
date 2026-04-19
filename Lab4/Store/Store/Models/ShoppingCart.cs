using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; }
        
        public ShoppingCart()
        {
            Items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            Items.Add(prodct);
        }

        public void RemoveItem(Prodct product)
        {
            Items.Remove(product);
        }

        public float GetTotalPrice()
        {
            float total = 0;
            foreach (Product product in Items)
            {
                total +=product.Price; 
            }
            return total; 
        }
    }
}
