using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C__Fasad.Entities.Classes;

class Payment
{
    public void PaymentWentThrough() => Console.WriteLine("Payment Received");
    public void PaymentFailed() => Console.WriteLine("Payment Not Received");

}
