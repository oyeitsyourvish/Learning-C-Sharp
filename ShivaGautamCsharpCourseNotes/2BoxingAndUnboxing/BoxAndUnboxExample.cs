using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes.BoxingAndUnboxing
{
    internal class BoxAndUnboxExample
    {
        internal void BoxingE()
        {

            //We use Boxing when we dont know which type of data we are getting.
            //This is done by compliler implicitly no need typecast operator
            //There is no chances to data loss.
            int a = 1;
            object b;
            b = a;
            Console.WriteLine("this is Boxing "+ b);
        }
        internal void UnboxingE()
        {
            //We need to do it Explecitly using Typecast Operator 
            //There have chances to data loss
            object a = 100;
            int b = (int)a;
            Console.WriteLine("this is Unboxing "+ b);

        }
        static void Main(string[] args)
        {
            BoxAndUnboxExample example = new BoxAndUnboxExample();
            example.BoxingE();
            example.UnboxingE();
        }
    }
}
