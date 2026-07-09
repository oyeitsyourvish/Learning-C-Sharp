using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.IDispose_Destructor
{
    internal class DisposeExample : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Executed");
        }
        public static void Main(string[] args)
        {
            FileStream file = new FileStream("Demo.txt", FileMode.Open); //this file is not exist in our pc thats why it gives the error otherwise it work perfectly.

            // Read file

            file.Dispose();
        }
    }
}
