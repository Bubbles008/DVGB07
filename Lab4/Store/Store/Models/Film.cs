using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Film : Product
    {
        public string Format {get; set;}
        public int Duration {get;set;}

        public Film(int id, string name, float price, int quantityInStock,
                    string format, int duration)
                    : base(id, name, price, quantityInStock)
        {
            Format=format;
            Duration = duration;
        }
    }
}
