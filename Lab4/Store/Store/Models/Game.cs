using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Game
    {
        public string Platform {get; set;}

        public Game(int id, string name, float price, int quantityInStock,
        string platform)
        : base(id, name, price, quantityInStock)
        {
            Platform = platform;
        }
    }
}

