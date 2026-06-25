using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Programs
{
    internal class C_LargestAndSecondLargestNumber
    {
        public static void Main(string[] args)
        {
            int[] a = { 10, 30, 50, 20, 40 };
            //LargestNumber(a);
            //LowestNumber(a);
            SecondLargest(a);
            //SecondLowest(a);

        }
        public static void LargestNumber(int[] a)
        {
            int largest = a[0]; //5, 8
            foreach (int i in a)
            {
                if (largest < i) //5<2, 5<8, 8<1, 8<4
                {
                    largest = i; //8,
                }
            }
            Console.WriteLine("Largest Number in array is : " + largest);
        }
        public static void LowestNumber(int[] a)
        {
            int lowest = a[0];
            foreach (int i in a)
            {
                if (lowest > i)
                {
                    lowest = i;
                }
            }
            Console.WriteLine("Lowest Number in array is : " + lowest);
        }
        public static void SecondLargest(int[] a)
        {
            //Array.Sort(a);
            //Console.WriteLine("Second Largest Number in array is : " + a[a.Length - 2]);

            // Another Way
            int first = int.MinValue;  //it take the smallest possible value of int
            int second = int.MinValue;
            foreach (int i in a)
            {
                if (i > first) //10>0, 30>10, 50>30, 20>50false, 40>50false
                {
                    second = first;  //0, 10, 30
                    first = i;       //10, 30, 50
                }
                else if (i > second && i != first) //20>30false, 40>30 and  40!=50
                {
                    second = i; //second = 40
                }
            }
            Console.WriteLine("Largest Number in Arra is : " + first);
            Console.WriteLine("Second Largest Number in Arra is : " + second);

        }
        public static void SecondLowest(int[] a)
        {
            Array.Sort(a);
            Console.WriteLine("Second Lowest Number in array is : " + a[1]);
        }
    }
}
