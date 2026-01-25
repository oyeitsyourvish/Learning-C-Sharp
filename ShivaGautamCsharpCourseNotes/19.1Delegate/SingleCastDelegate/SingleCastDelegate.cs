using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._1Delegate.SingleCastDelegate
{
    internal class SingleCastDelegate
    {
        // Step 1: Define a delegate
        public delegate void GreetDelegateWithoutParameter(); // Delegate that takes no parameters and returns void
        public delegate void GreetDelegateWithParameter(string name); // Delegate that takes a string parameter and returns void

        // Step 2: Create methods that match the delegate signature

        //Without Parameter
        public void MidnightGreet()
        {
            Console.WriteLine("So Jha Bhaiii This is Midnight Greet");
        }
        public void AfternonGreet()
        {
            Console.WriteLine("Uth Ja Bhaii This is Afternoon Greet");
        }

        //With Parameter
        public void MorningGreet(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }
        public void EveningGreet(string name)
        {
            Console.WriteLine("Good Evening, " + name);
        }
        public static void Main(string[] args)
        {
            SingleCastDelegate scd = new SingleCastDelegate();

            // Without Parameter
            // Instantiate the delegate and assign it to a method
            GreetDelegateWithoutParameter midnightDelegate = new GreetDelegateWithoutParameter(scd.MidnightGreet);
            GreetDelegateWithoutParameter afternoonDelegate = new GreetDelegateWithoutParameter(scd.AfternonGreet);
            // Invoke the delegate
            Console.WriteLine("Without parameter");
            midnightDelegate();
            afternoonDelegate();

            //With Parameter
            // Step 3: Instantiate the delegate and assign it to a method
            GreetDelegateWithParameter morningDelegate = new GreetDelegateWithParameter(scd.MorningGreet);
            GreetDelegateWithParameter eveningDelegate = new GreetDelegateWithParameter(scd.EveningGreet);
            // Step 4: Invoke the delegate
            Console.WriteLine("With Parameter");
            morningDelegate("Ajay");
            eveningDelegate("Vijay");
        }
    }
}
