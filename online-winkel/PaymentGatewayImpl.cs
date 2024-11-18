using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_winkel
{
    public class PaymentGatewayImpl : PaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Betaling van €{amount} wordt verwerkt...");
            // Simuleer een succesvolle betaling
            Console.WriteLine("Betaling succesvol verwerkt.");
            return true;
        }
    }

}
