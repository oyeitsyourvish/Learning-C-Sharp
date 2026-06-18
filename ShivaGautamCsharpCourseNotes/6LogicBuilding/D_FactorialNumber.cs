using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    internal class D_FactorialNumber
    {
        public static void Main()
        {
            // factorial (7! = 7*6*5*4*3*2*1)
            //in increasing way
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial in Increasing way");
            int facto = 1;
            for (int i = 1; i <= num; i++)
            {
                facto *= i;
            }
            Console.WriteLine("{0} factorial is {1}", num, facto);


            Console.WriteLine();
            Console.WriteLine();
            // in decreasing way 
            Console.WriteLine("Factorial In Decresing Way");
            int factoInc = 1;
            for (int i = num; i >= 1; i--)
            {
                factoInc *= i; //1*7
            }
            Console.WriteLine("{0} factorial is {1}", num, factoInc);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Factorial Using While Loop");
            WhileLoopFactorial();
        }

        public static void WhileLoopFactorial()
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int fact = 1;
            while (s <= a)
            {
                fact *= s;
                s++;
            }
            Console.WriteLine($"{a} Factorial is {fact}");
        }
    }
}
