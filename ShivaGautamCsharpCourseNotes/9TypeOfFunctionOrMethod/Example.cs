using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9TypeOfFunctionOrMethod
{
    internal class Example
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No Parameter No Return Type");
            NoParameterNoReturnType npnr = new NoParameterNoReturnType();
            npnr.Something();

            Console.WriteLine("No Parameter With Return Type");
            NoParameterWithReturnType npwr = new NoParameterWithReturnType();
            int returnvalue = npwr.Something();
            Console.WriteLine(returnvalue);

            Console.WriteLine("With Parameter No Return Type ");
            NoReturnTypeWithParameter nrtwp = new NoReturnTypeWithParameter();
            nrtwp.Something(6);

            Console.WriteLine("With Parameter With Return Type");
            WithParameterWithReturnType wpwr = new WithParameterWithReturnType();
            int store = wpwr.Something(8,7);
            Console.WriteLine(store);

        }

    }
}
