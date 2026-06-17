using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class D_FactorOfNumber
    {
        public static void Main(string[] args)
        {
            FactorWithWhileLoop();
            FactorWithForLoop();
        }

        public static void FactorWithWhileLoop()
        {
            Console.WriteLine("Enter a number to find its factors: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            Console.WriteLine($"Factors of {a} are:");
            while (s <= a)
            {
                if (a % s == 0)
                {
                    Console.WriteLine(s);
                }
                s++;
            }
        }

        public static void FactorWithForLoop()
        {
            Console.WriteLine("Enter a number to find its factors: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factors of {number} are:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
