using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_winkel
{
    public interface PaymentGateway
    {
        bool ProcessPayment(decimal amount);
    }

}
