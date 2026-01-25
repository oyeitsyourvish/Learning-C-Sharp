using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array
{
    internal class ArrayDef
    {
        public static void Main(string[] args)
        {
            // 1. We can define array This is Basic to difine array
            int[] a = { 5, 6, 5, 6, 5, 4 };

            // 2. This is the second type to define array first we mention the size then insert the data
            int[] b = new int[5];
            b[0] = 25;
            b[1] = 5;
            b[2] = 65;
            b[3] = 23;
            b[4] = 33;

            // 3. This is the Third Type to define we can Get size and data from user
            Console.WriteLine("Enter the Array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] c = new int[size];
            Console.WriteLine("Enter the Array element");
            for(int i =0; i< c.Length; i++)
            {
                c[i] = Convert.ToInt32(Console.ReadLine());
            }

            //FOR YOU WANT TO PRINT ARRAY THERE ARE ASLO 2 TYPE TO PRINT

            //1. Using index
            Console.WriteLine("This is using Index in A Array and A of 2 index is : "+a[2]);

            //2. Using For Loop
            Console.WriteLine("This is using For Loop in B Array and values are : ");
            for(int i=0; i<= b.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("This is using Foreach in c Array and values are : ");
            //3. Using Foreach
            foreach(int i in c)
            {
                Console.WriteLine(i);
            }
        }
    }
}
