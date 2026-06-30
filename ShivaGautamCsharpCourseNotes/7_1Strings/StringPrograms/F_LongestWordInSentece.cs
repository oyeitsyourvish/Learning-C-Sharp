using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class F_LongestWordInSentece
    {
        public static void Main(string[] args)
        {
            string a = "I Love C sharp Programming in coding";
            string[] aarr = a.Split(' ');
            string longword = " ";
            for (int i = 0; i < aarr.Length; i++)
            {
                if (aarr[i].Length > longword.Length)
                {
                    longword = aarr[i];
                }
            }
            Console.WriteLine("Longest Word is : " + longword);
        }
    }
}
