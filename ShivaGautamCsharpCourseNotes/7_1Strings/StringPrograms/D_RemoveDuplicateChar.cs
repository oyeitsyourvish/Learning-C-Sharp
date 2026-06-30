using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class D_RemoveDuplicateChar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string a = Console.ReadLine(); //programming
            string str = " ";
            for (int i = 0; i < a.Length; i++)
            {
                if (!str.Contains(a[i]))
                {
                    str += a[i];
                }
            }
            Console.WriteLine("Removed Duplicate Character and Final Word is : " + str);
        }
    }
}
