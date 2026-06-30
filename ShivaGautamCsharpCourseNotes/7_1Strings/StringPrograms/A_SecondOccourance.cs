using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class A_SecondOccourance
    {
        public static void Main(string[] args)
        {
            string a = "Banana";
            char occ = 'a';
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == occ)
                {
                    count++;
                }
                if (count == 2)
                {
                    Console.WriteLine("Second Occ of '" + occ + "'is at index " + i);
                    System.Environment.Exit(0);
                }
            }

        }
    }
}
