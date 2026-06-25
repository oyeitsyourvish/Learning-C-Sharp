using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._16Interface.SimpleExample
{
    internal class UPI : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment done by UPI");
        }

    }
}
