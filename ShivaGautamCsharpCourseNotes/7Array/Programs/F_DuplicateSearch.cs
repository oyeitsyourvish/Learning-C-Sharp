using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class F_DuplicateSearch
    {
        public static void Main(string[] args)
        {
            int[] a = { 10, 50, 20, 50, 30, 20 };
            Duplicate(a);
            Search(a);
        }
        public static void Duplicate(int[] a)
        {
            Console.WriteLine("Printing Duplicate Array");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }

        public static void Search(int[] a)
        {
            Console.WriteLine("Enter the number which you want to search");
            int j = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == j)
                {
                    ++count;
                }
            }
            Console.WriteLine($"{j} Record Found {count} times");
        }
    }
}
