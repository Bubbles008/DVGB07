using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(int id, string name, float price, int quantityInStock)
        {
            Id=id; 
            Name=name;
            Price=price;
            QuantityInStock=quantityInStock;
        }
        public void IncreaseStock(int amount)
        {
            QuantityInStock += amount; 
        }
        public void DecreaseStock(int amount)
        {
            QuantityInStock -= amount;
        }

        public bool IsAvailable(int amount)
        {
            return QuantityInStock >= amount; 
        }

    }

}
