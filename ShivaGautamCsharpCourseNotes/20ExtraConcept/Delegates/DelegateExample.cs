using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First of all We create a delegate;
delegate void Calculator(int a, int b);

namespace CSharpBasicToAdvanced._20ExtraConcept.Delegates
{
    internal class DelegateExample
    {
        public static void Main(string[] args)
        {
            // we pass method address as a parameter 
            Calculator cl = Add;
            cl(10, 20);
        }
        static void Add(int a, int b)
        {
            Console.WriteLine("Addition is : " + (a + b));
        }
    }
}
