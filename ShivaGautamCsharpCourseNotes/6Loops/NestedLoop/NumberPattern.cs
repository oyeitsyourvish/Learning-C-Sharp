using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Loops.NestedLoop
{
    internal class NumberPattern
    {
        public static void Main(string[] args)
        {
            //Program 1.
            Program1();
            /*1 2 3 4 5
              1 2 3 4 5
              1 2 3 4 5
              1 2 3 4 5
              1 2 3 4 5*/


            //Program 2.
            Program2();
            /* 1 1 1 1 1
               2 2 2 2 2
               3 3 3 3 3
               4 4 4 4 4
               5 5 5 5 5 */

            Program3();
            /* 1
               1 2
               1 2 3
               1 2 3 4
               1 2 3 4 5 */

            Program4();
            /*1 2 3 4 5
              1 2 3 4
              1 2 3
              1 2
              1*/

            Program5();
            /*5 5 5 5 5
              4 4 4 4
              3 3 3
              2 2
              1*/

            Program6();
            /* 1
               2 2
               3 3 3
               4 4 4 4
               5 5 5 5 5*/

            Program7();
            /* 1 2 3 4 5
               5 4 3 2
               1 2 3
               5 4
               1*/

            Program8();
            /*A B C D E
              A B C D
              A B C
              A B
              A*/

            Program9();
            /* A b C d E
               A b C d
               A b C
               A b
               A*/

            Program10();
            /*  *
               ***
              *****    */

            Program11();
            /*  *
               ***
              *****
               ***
                *       */

            Program12();
            /* 12345
                1234
                 123
                  12
                   1  */

        }
        public static void Program12()
        {
            Console.WriteLine("Program 12");
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space<i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 6-i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Program11()
        {
            Console.WriteLine("Program 11");

            for (int i = 1; i <= 5; i++)
            {
                if (i <= 3)   // Upper pyramid
                {
                    // Spaces
                    for (int space = 3 - i; space > 0; space--)
                    {
                        Console.Write(" ");
                    }

                    // Stars
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                }
                else          // Lower pyramid
                {
                    // Spaces
                    for (int space = 1; space <= i - 3; space++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * (5 - i) + 1; j++)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void Program10()
        {
            Console.WriteLine("Program 10");
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 2; space >= i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Program9()
        {
            Console.WriteLine("Program 9");
            for (int i = 1; i <= 5; i++)
            {
                char ch = 'A';
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write((char)(ch + 32) + " "); //after the second column prin in small char.
                        ch++;
                    }
                    else
                    {
                        Console.Write(ch++ + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Program8()
        {
            Console.WriteLine("Program 8");
            for (int i = 1; i <= 5; i++)
            {
                char ch = 'A';
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(ch++ + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program7()
        {
            Console.WriteLine("Program 7");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(6 - j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Program6()
        {
            Console.WriteLine("Program 5");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program5()
        {
            Console.WriteLine("Program 5");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program4()
        {
            Console.WriteLine("Program 4");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program3()
        {
            Console.WriteLine("Program 3");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program2()
        {
            Console.WriteLine("Program 2");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Program1()
        {
            Console.WriteLine("Program 1");
            for (int i = 1; i <= 5; i++)  //outer loop use for ROW
            {
                for (int j = 1; j <= 5; j++) // Inner loop use for COLUMN
                {
                    Console.Write(j + " "); //for pring the full iteration in one that why take write.
                }
                Console.WriteLine(); // for print the new line 
            }
        }
    }
}
