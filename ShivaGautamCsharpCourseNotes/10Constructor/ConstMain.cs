using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._10Constructor
{
    internal class ConstMain
    {
        public static void Main(string[] args)
        {
            
            ConstructorEx c = new ConstructorEx(); // it excute non-static non-parameterized constructor.

            ConstructorEx cc = new ConstructorEx(5,10); // it execute nonstatic parameterzied const.


            //Example of Copy Constructor

            CopyConstructor Copyc = new CopyConstructor();  
            CopyConstructor Copycc = new CopyConstructor(Copyc);

        }
    }
}
