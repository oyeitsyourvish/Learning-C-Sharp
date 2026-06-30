using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class D_FindDuplicateChar
    {
        public static void Main()
        {
            string a = "tushaart";
            string str = " ";
            string dup = " ";
            for (int i = 0; i < a.Length; i++)
            {
                if (!str.Contains(a[i]))
                {
                    str += a[i];
                }
                else
                {
                    dup += a[i];
                }
            }
            Console.WriteLine("Duplicate Character Are : " + dup);
        }
    }
}
