using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class B_SumOfArray
    {
        public static void Main(string[] args)
        {
            int[] a = { 13, 14, 13, 11, 12 };

            SumOfArray(a);

        }
        public static void SumOfArray(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Array is : " + sum);
        }
    }
}
