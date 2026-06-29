using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class B_Palindrome
    {
        public static void Main(string[] args)
        {
            // A palindrome is a word, phrase, number, or other sequence of characters
            // that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).

            string a = Console.ReadLine();
            string rev = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                rev += a[i];
            }
            if (a == rev)
            {
                Console.WriteLine("Pelindrome");
            }
            else
            {
                Console.WriteLine("Not a Pelindrome");
            }
        }
    }
}
