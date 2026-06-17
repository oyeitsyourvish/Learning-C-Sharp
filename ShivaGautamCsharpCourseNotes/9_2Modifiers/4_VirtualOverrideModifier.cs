using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    public class ParentCl
    {
        public virtual void Bark()
        {
            Console.WriteLine("Parent Dog Bark");
        }
    }
    internal class _4_VirtualOverrideModifier : ParentCl
    {
        public override void Bark()
        {
            Console.WriteLine("Child Dog Bark");
        }

        public static void Main()
        {
            //UpCasting
            ParentCl p = new _4_VirtualOverrideModifier();
            p.Bark();


            _4_VirtualOverrideModifier c = new _4_VirtualOverrideModifier();
            c.Bark();

        }
    }
}
