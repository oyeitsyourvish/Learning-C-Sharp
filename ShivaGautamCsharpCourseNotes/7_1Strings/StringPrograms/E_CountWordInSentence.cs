using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class E_CountWordInSentence
    {
        public static void Main(string[] args)
        {
            string a = "I Love C Sharp";
            string[] str = a.Split(' ');
            foreach (string i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(str.Length);
        }
    }
}
