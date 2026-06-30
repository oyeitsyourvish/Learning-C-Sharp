using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings
{
    internal class A_ReverseString
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter the string");
            string a = Console.ReadLine();

            string reversed = " ";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversed += a[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
