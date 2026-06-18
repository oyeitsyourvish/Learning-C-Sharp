using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class E_PrimeNumber
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int str = 0;
            while (s <= a)
            {
                if (a % s == 0)
                {
                    str++;
                }
                s++;
            }
            if (str == 2)
            {
                Console.WriteLine("{0} is the Prime Number", a);
            }
            else
            {
                Console.WriteLine("{0} it is Not Prime Number", a);
            }
        }
    }
}
