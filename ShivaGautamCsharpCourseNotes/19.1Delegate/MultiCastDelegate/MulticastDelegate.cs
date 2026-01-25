using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19._1Delegate.MultiCastDelegate
{
    internal class MulticastDelegate
    {
        public static void Main(string[] args)
        {
            /*
             * Mostly Used Multicast Delegate for Event Handling.
             
             Multicast Delegate :- A multicast delegate is a special type of delegate that
                                   can hold references to multiple methods.
             When you invoke a multicast delegate, it calls all the methods it references
             in the order they were added.
                - A delegate can store multiple methods using +=
                - Only possible if return type is void (or you ignore return value).                 
                - They are useful for implementing event handling systems where multiple methods need to
                  respond to a single event.
            */

            //When we want which methods to be called step by step we can use Multicast Delegate.
            //+= operator is used to add methods to the delegate invocation list.
            MulticastDelegateEx mcd = new MulticastDelegateEx();
            MulticastDelegateEx.CalculateDelegate cd ;
            Console.WriteLine("All Methods runs");
            cd = mcd.Add;
            cd += mcd.Subtract;
            cd += mcd.Multiply;
            cd += mcd.Divide;
            cd(20, 10); // Invoking Multicast Delegate


            // when we want which method should not be called we can use -= operator
            Console.WriteLine("\nAfter removing Subtract method from invocation list:");
            cd -= mcd.Subtract;
            cd(30, 10); // Invoking Multicast Delegate

        }
    }
}
