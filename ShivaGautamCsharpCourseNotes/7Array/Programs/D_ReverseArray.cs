using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class D_ReverseArray
    {
        public static void Main(string[] args)
        {
            ReverseUsingLoop();
            ReverseMethod();
        }

        public static void ReverseUsingLoop()
        {
            Console.WriteLine("Reverse Array Using For Loop");
            int[] a = { 10, 20, 30, 40, 50 };
            for (int i = 0; i > a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void ReverseMethod()
        {
            Console.WriteLine("Reverse Array Using Reverse Method");
            int[] a = { 10, 20, 30, 40, 50 };
            for (int i = 0; i > a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Array.Reverse(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
