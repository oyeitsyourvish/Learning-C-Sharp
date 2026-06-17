using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    sealed class Par
    {
        public void some() { }
    }

    public class Parent
    {
        public virtual void Some()
        {
            Console.WriteLine("This is Parent Some Method");
        }
    }
    public class SealedModifier : Parent // : Par //(We cannot Inherit Sealed Class)
    {
        public sealed override void Some() // Cant override sealed method/property
        {
            Console.WriteLine("hello");
        }
    }
}
