using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._20ExtraConcept.Thread_Multithread
{
    internal class ThreadExample
    {
        public static void Print()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            // Create a new thread and start it
            Thread t = new Thread(Print);
            //it is a method of Thread class which is used to start the thread.
            t.Start();

            Console.WriteLine("Main Thread");
        }
    }
}
