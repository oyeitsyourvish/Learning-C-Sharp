using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class E_EvenOvels
    {
        public static void Main(string[] args)
        {
            int[] a = { 6, 4, 3, 8, 5, 7 };

            ArrayEven(a);
            ArrayEvenRev(a);
            ArrayOvel();

        }
        public static void ArrayEven(int[] a)
        {
            Console.WriteLine("Array Even Program");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine();
        }

        public static void ArrayEvenRev(int[] a)
        {
            Console.WriteLine("Array Even Reverse Program");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine();
        }

        public static void ArrayOvel()
        {
            Console.WriteLine("Print Oval Program");
            char[] a = { 'a', 'b', 'u', 'r' };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
