using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings.StringPrograms
{
    internal class G_Anagram
    {
        public static void Main(string[] args)
        {
            // Anagram means rearranging the letters of a word to form another word. For example, "listen" and "silent" are anagrams of each other.
            string a = "listen";
            string b = "silent";

            char[] aa = a.ToCharArray();
            char[] bb = b.ToCharArray();

            Array.Sort(aa);
            Array.Sort(bb);
            if (new string(aa) == new string(bb))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}
