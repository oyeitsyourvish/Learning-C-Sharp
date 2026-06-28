using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7_1Strings
{
    internal class StringEx
    {
        public static void Main()
        {
            // String is a reference type in C# that represents a sequence of characters. It is immutable,
            // meaning that once a string is created, it cannot be changed. Any operation that appears to modify
            // a string actually creates a new string.
            string a = "Hello";

            Console.WriteLine("Common String Method");

            Console.WriteLine();
            Console.WriteLine("String in Upper Case");
            Console.WriteLine(a.ToUpper());

            Console.WriteLine();
            Console.WriteLine("String in Lower case");
            Console.WriteLine(a.ToLower());

            Console.WriteLine();
            Console.WriteLine("Trim Method Run");
            string b = "   Hello World   ";
            Console.WriteLine(b.Trim());

            Console.WriteLine();
            Console.WriteLine("Split Method Run");
            string Spl = "Apple,Banana,Mango,Pineapple";
            string[] fruits = Spl.Split(',');

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
            Console.WriteLine("Substring method run");
            string stri = "Programming";
            Console.WriteLine(stri.Substring(3));

            Console.WriteLine();
            Console.WriteLine("IndexOf Method Run");
            string c = "Rowdy Rathore";
            Console.WriteLine(c.IndexOf('y'));

            Console.WriteLine();
            Console.WriteLine("LastIndexOf Method Run");
            Console.WriteLine(c.LastIndexOf('o'));

            Console.WriteLine();
            Console.WriteLine("Remove Method run");
            Console.WriteLine(c.Remove(6));
        }
    }
}
