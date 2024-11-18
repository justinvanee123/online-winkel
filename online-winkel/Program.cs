using online_winkel;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Producten aanmaken
        Product product1 = new Product("poster",20, 100);
        Product product2 = new Product("shirt",40, 100);
        Product product3 = new Product("beker",10, 100);

        // Winkelwagen en PaymentGateway aanmaken
        ShoppingCart cart = new ShoppingCart();
        PaymentGateway paymentGateway = new PaymentGatewayImpl();
        Checkout checkout = new Checkout(cart, paymentGateway);

        // Simulatie van gebruikersinteracties
        bool shopping = true;
        while (shopping)
        {
            Console.WriteLine("\nOnline Shop:");
            Console.WriteLine("1. Bekijk producten");
            Console.WriteLine("2. Voeg product toe aan winkelwagen");
            Console.WriteLine("3. Verwijder product uit winkelwagen");
            Console.WriteLine("4. Bekijk winkelwagen");
            Console.WriteLine("5. Afrekenen");
            Console.WriteLine("6. Verlaat de winkel");

            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Beschikbare producten:");
                    Console.WriteLine(product1);
                    Console.WriteLine(product2);
                    Console.WriteLine(product3);
                    break;

                case "2":
                    Console.Write("Voer de naam van het product in om toe te voegen: ");
                    string productName = Console.ReadLine();
                    if (productName == "poster") cart.AddProduct(product1);
                    else if (productName == "shirt") cart.AddProduct(product2);
                    else if (productName == "beker") cart.AddProduct(product3);
                    else Console.WriteLine("Product niet gevonden.");
                    break;

                case "3":
                    Console.Write("Voer de naam van het product in om te verwijderen: ");
                    string removeProductName = Console.ReadLine();
                    if (removeProductName == "Laptop") cart.RemoveProduct(product1);
                    else if (removeProductName == "Smartphone") cart.RemoveProduct(product2);
                    else if (removeProductName == "Headphones") cart.RemoveProduct(product3);
                    else Console.WriteLine("Product niet gevonden.");
                    break;

                case "4":
                    cart.ShowCart();
                    break;

                case "5":
                    checkout.ProcessCheckout();
                    break;

                case "6":
                    shopping = false;
                    Console.WriteLine("Bedankt voor je bezoek!");
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze.");
                    break;
            }
        }
    }
}
