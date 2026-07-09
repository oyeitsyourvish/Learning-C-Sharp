using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.IDispose_Destructor
{
    internal class DestructorExample
    {
        public DestructorExample()
        {
            Console.WriteLine("Constructor");
        }

        ~DestructorExample()
        {
            Console.WriteLine("Destructor");
        }
        public static void Main(string[] args)
        {

        }
    }
}
