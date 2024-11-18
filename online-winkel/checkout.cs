using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_winkel
{
    public class Checkout
    {
        private ShoppingCart cart;
        private PaymentGateway paymentGateway;

        public Checkout(ShoppingCart cart, PaymentGateway paymentGateway)
        {
            this.cart = cart;
            this.paymentGateway = paymentGateway;
        }

        public void ProcessCheckout()
        {
            decimal totalAmount = cart.CalculateTotal();
            if (totalAmount == 0)
            {
                Console.WriteLine("Je winkelwagen is leeg. Voeg eerst producten toe.");
                return;
            }

            Console.WriteLine($"Totale prijs voor betaling: {totalAmount} euro");
            bool paymentSuccess = paymentGateway.ProcessPayment(totalAmount);

            if (paymentSuccess)
            {
                Console.WriteLine("Afrekenen succesvol.");
            }
            else
            {
                Console.WriteLine("Betaling mislukt. Probeer opnieuw.");
            }
        }
    }

}
