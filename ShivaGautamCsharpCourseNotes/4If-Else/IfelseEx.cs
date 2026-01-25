using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.If_Else
{
    internal class IfelseEx
    {
        public static void Main(string[] args)
        {
            /*If-Else Is used to solve the condition base program to create separate block for
             true cond and false cond use if and else
            */
            //# Five different combination;
            // 1)Simple if : it will excute when cond is true else it not excute.
            SimpleIf(13);
            // 2)If-Else : 
             IfElse(4);
            // 3)Nested If-Else : it is used create multiple cond program in if block or else block.
            NestedIfElse(12,13,9);
            // 4)Ladder or Else--If : it is combination of single if and multiple else if and else block.
            // 5)Multiple-If : it is combination of more than one if statement.
        }
        internal static void SimpleIf(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("It is Even");
                System.Environment.Exit(0);
            }
            Console.WriteLine("It is Odd");
        }
        internal static void IfElse(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(a*a);
            }
            else
            {
                Console.WriteLine(a*a*a);
            }
        }
        internal static void NestedIfElse(int a, int b, int c)
        {
            if(a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greater");

                }
                else
                {
                    Console.WriteLine("C is greater");
                }               
            }
            if (b > c)
            {
                Console.WriteLine("B Is greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
        }
    }
}
