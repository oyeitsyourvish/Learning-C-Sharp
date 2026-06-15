using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._6LogicBuilding
{
    public class A_OddorEvenIfOddSquareElseQube
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check Odd or Even if it is Odd print its Square else its Qube");
            Console.WriteLine();
            Console.WriteLine("Enter the The Value");
            int a = Convert.ToInt32(Console.ReadLine());

            //OddEven(a);
            LastDegitOddEven(a);

        }

        public static void OddEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("A is Even and its Square is " + (a * a));
            }
            else
            {
                Console.WriteLine("A is Odd and its Cube is " + (a * a * a));
            }
        }
        public static void LastDegitOddEven(int a)
        {
            int b = a % 10;
            if (b % 2 == 0)
            {
                Console.WriteLine("A is Even and its Square is " + (b * b));
            }
            else
            {
                Console.WriteLine("A is Odd and its Cube is " + (b * b * b));
            }
        }
    }
}
