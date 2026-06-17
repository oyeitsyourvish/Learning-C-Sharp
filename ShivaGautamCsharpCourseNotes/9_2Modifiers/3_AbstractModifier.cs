using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    abstract class Pare
    {
        public abstract void Some();
    }

    internal class _3_AbstractModifier : Pare
    {
        public override void Some()
        {
            Console.WriteLine("This is Implemented abstract method from parent to overriden in child");
        }
        public static void Main()
        {
            _3_AbstractModifier a = new _3_AbstractModifier();
            a.Some();
        }

    }
}
