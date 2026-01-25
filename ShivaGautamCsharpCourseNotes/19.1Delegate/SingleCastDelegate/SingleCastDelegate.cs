using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19._1Delegate.SingleCastDelegate
{
    internal class SingleCastDelegate
    {
        // Step 1: Define a delegate
        public delegate void GreetDelegate(string name);

        // Step 2: Create methods that match the delegate signature
        public void MorningGreet(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }
        public void EveningGreet(string name)
        {
            Console.WriteLine("Good Evening, " + name);
        }
    }
}
