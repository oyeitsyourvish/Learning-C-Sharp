using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class A_MethodProgram
    {
        public static void Main()
        {
            Sorting();
            Reverse();
            IndexOf();

            //Passing 
            int[] a = { 5, 2, 8, 1, 4 };
            Passing(a);

        }

        public static void Sorting()
        {
            Console.WriteLine("Sorting Method");
            int[] a = { 5, 2, 8, 1, 4 };
            Array.Sort(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Reverse()
        {
            Console.WriteLine();
            Console.WriteLine("Reverse Method");
            int[] a = { 5, 2, 8, 1, 4 };
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void IndexOf()
        {
            Console.WriteLine();
            Console.WriteLine("IndexOf Method");
            int[] a = { 5, 2, 8, 1, 4 };
            int str = Array.IndexOf(a, 8);
            Console.WriteLine(str);
        }

        public static void Passing(int[] a)
        {
            Console.WriteLine();
            Console.WriteLine("Passing Array to Method");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
