using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19._2Multithreading
{
    internal class SingleThreadingEx
    {
        public void SingleThreading()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread is "+i);
                Thread.Sleep(2000); // Sleep for 2000 milliseconds
            }
        }
        public static void Main(string[] args)
        {
            SingleThreadingEx st = new SingleThreadingEx(); // Creating object of MultithreadingEx class
            //st.SingleThreading(); // here we are calling Display method using object directly but below we will
                                        // see how to call it using Thread class
            ThreadStart ts = new ThreadStart(st.SingleThreading); // Creating ThreadStart delegate object (passing method as parameter called delegate)
            Thread t = new Thread(ts); // Creating Thread object and passing ThreadStart delegate object as parameter
            t.Start(); // Starting the thread which will call Display method
        }
    }
}
