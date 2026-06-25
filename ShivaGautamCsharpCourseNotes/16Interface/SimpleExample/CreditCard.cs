using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._16Interface.SimpleExample
{
    internal class CreditCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Payment");
        }
    }
}
