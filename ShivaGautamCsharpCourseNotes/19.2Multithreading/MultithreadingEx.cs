using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._2Multithreading
{
    internal class MultithreadingEx
    {
        public void ThreadM()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("M1 Function(Method)" + i);
                Thread.Sleep(2000); // Sleep for 2000 milliseconds
            }
        }

        public void ThreadM2()
        { 
            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine("M2 Method(Function)" + i);
                Thread.Sleep(2000); // Sleep for 2000 milliseconds
            }
        }
        public void ParameterizedThread(object name)
        { 
            for (int i = 20; i <= 25; i++)
            {
                Console.WriteLine("Parameterized Method(Function)" + i);
                Thread.Sleep(2000); // Sleep for 2000 milliseconds
            }
        }
        public static void Main(string[] args)
        {
            MultithreadingEx mt = new MultithreadingEx(); // Creating object of MultithreadingEx class
                                                          //mt.ThreadM(); // here we are calling Display method using object directly but below we will
                                                          //mt.ThreadM2(); // here we are calling Display method using object directly but below we will
                                                          // see how to call it using Thread class
            ThreadStart ts = new ThreadStart(mt.ThreadM); // Creating ThreadStart delegate object (passing method as parameter called delegate)
            Thread t = new Thread(ts); // Creating Thread object and passing ThreadStart delegate object as parameter
            t.Start(); // Starting the thread which will call Display method

            //t.Join(); // Main thread will wait until t thread completes its execution if we don't use
                      // this then both threads will run simultaneously

            ThreadStart ts1 = new ThreadStart(mt.ThreadM2); // Creating ThreadStart delegate object (passing method as parameter called delegate)
            Thread t1 = new Thread(ts1); // Creating Thread object and passing ThreadStart delegate object as parameter
            t1.Start(); // Starting the thread which will call Display method



            // we cant pass parameter using ThreadStart delegate so we will use ParameterizedThreadStart delegate
            Thread pt = new Thread(mt.ParameterizedThread); // Creating ThreadStart delegate object (passing method as parameter called delegate)
            pt.Start("Adesh"); // Starting the thread which will call Display method
        }
    }
}
