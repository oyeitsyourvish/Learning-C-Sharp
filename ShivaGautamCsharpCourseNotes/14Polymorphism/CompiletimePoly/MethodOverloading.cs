using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._14Polymorphism.CompiletimePoly
{
    public class MethodOverloading
    {
        public static void Main()
        {
            MethodOverloading m = new MethodOverloading();
            int AddStore = m.Add(6, 5);
            double SubDouble = m.Sub(6.3, 1.2);
            string str = m.Name("Vishal");
            Console.WriteLine(AddStore);
            Console.WriteLine(SubDouble);
            Console.WriteLine(str);

        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public string Name(string name)
        {
            return name;
        }
    }
}
