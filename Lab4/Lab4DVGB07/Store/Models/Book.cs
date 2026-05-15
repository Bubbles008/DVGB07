using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Book : Product
    {
        public string Author { get; set;}
        public string Genre {get; set; }

        public string Format{get;set;}
        public string Language{get; set;}

        public Book(int id, string name, float price, int quantityInStock,
                    string author, string genre, string format, string language)
            : base(id, name, price, quantityInStock)
            {
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
        }


    }

}
