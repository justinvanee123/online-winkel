using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_winkel
{
    public class ShoppingCart
    {
        private List<Product> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product.Number > 0)
            {
                cartItems.Add(product);
                product.Number--;  // Verlaag de voorraad
                Console.WriteLine($"{product.Name} toegevoegd aan de winkelwagen.");
            }
            else
            {
                Console.WriteLine($"{product.Name} is niet op voorraad.");
            }
        }

        public void RemoveProduct(Product product)
        {
            if (cartItems.Remove(product))
            {
                product.Number++;  // Verhoog de voorraad
                Console.WriteLine($"{product.Name} verwijderd uit de winkelwagen.");
            }
            else
            {
                Console.WriteLine($"{product.Name} is niet in de winkelwagen.");
            }
        }

        public decimal CalculateTotal()
        {
            return cartItems.Sum(item => item.Price);
        }

        public void ShowCart()
        {
            if (cartItems.Count == 0)
            {
                Console.WriteLine("Je winkelwagen is leeg.");
            }
            else
            {
                Console.WriteLine("Winkelwagen inhoud:");
                foreach (var item in cartItems)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Totale prijs: €{CalculateTotal()}");
            }
        }
    }

}
