using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._9_2Modifiers
{
    internal class _6_ReadonlyModifier
    {
        public readonly int empId;
        public _6_ReadonlyModifier(int id)
        {
            this.empId = id;
        }


        // Once empid assigned during declaration we cant modify or change it.
        //public void changId()
        //{
        //    empId = 200;
        //}

        public static void Main(string[] args)
        {
            _6_ReadonlyModifier e = new _6_ReadonlyModifier(101);
            Console.WriteLine("Assigned id is {0}", e.empId);
        }
    }
}
