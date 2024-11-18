using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_winkel
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }

        public Product(string name, decimal price, int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name} - {Price}euro ({Number} op voorraad)";
        }
    }

}
