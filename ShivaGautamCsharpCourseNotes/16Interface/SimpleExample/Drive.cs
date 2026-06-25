using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._16Interface.SimpleExample
{
    internal class Drive
    {

        public static void Main()
        {
            Console.WriteLine("Credit Card");
            CreditCard cc = new CreditCard();
            cc.Pay();

            Console.WriteLine();
            Console.WriteLine("UPI");
            UPI u = new UPI();
            u.Pay();

            Console.WriteLine();
            Console.WriteLine("Cash On Delevery");
            CashImp c = new CashImp();
            c.Pay();
            c.Cod();

            Console.WriteLine();
            Console.WriteLine("UPI");
            IPayment i = new UPI();
            i.Pay();

            Console.WriteLine("Credit Card");
            IPayment ii = new CreditCard();
            ii.Pay();

            Console.WriteLine("COD");
            ICash ic = new CashImp();
            ic.Cod();



            //IPayment ip = new IPayment(); // we cant create obj or constructor for interface.



        }
    }
}
