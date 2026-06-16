using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._5SwitchCase
{
    internal class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the A Value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the B Value");
            int b = Convert.ToInt32(Console.ReadLine());
            for (; ; )
            {
                Console.WriteLine("1.Addition       2.Substraction      3.Multiplication        4.Division      5.Exit");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Addition of a and b is = " + (a + b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Substraction of a and b is = " + (a - b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Multiplication of a and b is = " + (a * b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) / Convert.ToInt32(Console.ReadLine()));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Application Closed");
                            System.Environment.Exit(1);
                            break;
                        }

                }
            }
        }
    }
}
