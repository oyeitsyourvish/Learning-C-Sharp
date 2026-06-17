using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    public class Calci
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
    }
    public class StaticModifier
    {
        public static int RetSome(int a)
        {
            Console.WriteLine("This is Static");
            return a;
        }

        public void GetSome()
        {
            Console.WriteLine("Non Static");
        }

        public static void Main()
        {
            Console.WriteLine(Calci.add(5, 6));
            Console.WriteLine(RetSome(5));
            //Console.WriteLine(GetSome()); // object reference required for non-static field

        }

    }
}
