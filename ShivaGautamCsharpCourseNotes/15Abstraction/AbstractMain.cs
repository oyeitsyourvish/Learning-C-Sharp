using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._15Abstraction
{
    internal class AbstractMain
    {
        public static void Main(string[] args)
        {
            /* Abstraction :- Hiding the implementation and showing the functionality called as abstraction.
            it is also part of design pattern in asp.net.
            - We cant create object in abstract class.
            - Abstract class only declare mthod which can override in childe or derived class.
            - we can stor normal method as well as abstract but in intrface only we store abstract.

            */

            Child c = new Child();
            c.accept(10, 2);
            c.rectanlge();
            c.display();

            Child c2 = new Child(); 
            c2.accept(10, 2);
            c2.tringle();
            c2.display();
        }
    }
}
