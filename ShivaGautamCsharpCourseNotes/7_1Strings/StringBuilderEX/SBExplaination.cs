using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace CSharpBasicToAdvanced._7_1Strings.StringBuilderEX
{
    internal class SBExplaination
    {
        public static void Main(string[] args)
        {
            // This is Normal string when we run it 100 time it will create hundred object 
            // it use more memory
            string result = "";
            for (int i = 1; i <= 100; i++)
            {
                result += i;
            }
            Console.WriteLine(result);

            // This is SB when we run it 100 times it will create 1 obj and modifying it till the 100
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
