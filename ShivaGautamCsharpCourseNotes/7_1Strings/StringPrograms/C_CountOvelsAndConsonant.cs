using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class C_CountOvelsAndConsonant
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            int ovel = 0;
            int conso = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    ovel++;
                }
                else
                {
                    conso++;
                }
            }
            Console.WriteLine($"Count of Ovels is {ovel} and Count of Consonant is {conso}");

        }
    }
}
