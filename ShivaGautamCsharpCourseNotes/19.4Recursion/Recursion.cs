using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._4Recursion
{
    internal class Recursion
    {
        public static void Main(string[] args)
        {
            /*
             Recursion is a programming technique where a function calls itself 
             in order to solve a problem.

             It has:
             1. Base Case → stops recursion
             2. Recursive Case → function calls itself
            */

            // Factorial of a number using recursion
            RecursionEx r = new RecursionEx();
            Console.WriteLine("Enter the No. of Factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int recursion = r.FactorialRecursion(n);

            Console.WriteLine($"Factorial of {n} is: " + recursion);
        }
    }
}
