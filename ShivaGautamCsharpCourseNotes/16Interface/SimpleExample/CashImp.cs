using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._16Interface.SimpleExample
{
    internal class CashImp : ICash, IPayment
    {
        public void Cod()
        {
            Console.WriteLine("Payment done by Cash");
        }

        public void Pay()
        {
            Console.WriteLine("Payment done by UPI or CC at Cash on Delivery time");
        }

    }
}
