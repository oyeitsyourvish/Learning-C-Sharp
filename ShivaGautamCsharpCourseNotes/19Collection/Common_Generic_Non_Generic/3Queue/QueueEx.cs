using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Common_Generic_Non_Generic.Queue
{
    internal class QueueEx
    {
        internal void QueueExample_Non_Generic()
        {
            try
            {
                Console.WriteLine("Example of Non-Generic Queue"); // we can store different data types in Queue cause it is non-generic collection.
                System.Collections.Queue ex = new System.Collections.Queue(); // creating object of Queue class
                ex.Enqueue("Mumbai"); // adding elements using Enqueue method
                ex.Enqueue(25);
                ex.Enqueue("Delhi");
                foreach (object item in ex) // displaying elements using foreach loop
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("After Dequeue Method: Removing Front Element");
                ex.Dequeue(); // removing front element using Dequeue method
                foreach (object item in ex)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine("After Peek Method Viewing Front Element");
                Console.WriteLine(ex.Peek()); ; // viewing front element using Peek method
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong");
            }
        }

        internal void QueueExample_Generic()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Example of Generic Queue"); // we can store specific data type in Generic Queue.
            try
            {
                System.Collections.Generic.Queue<string> ex = new System.Collections.Generic.Queue<string>(); // creating object of Generic Queue class
                ex.Enqueue("Apple"); // adding elements using Enqueue method
                ex.Enqueue("Banana");
                ex.Enqueue("Cherry");
                foreach (object item in ex) // displaying elements using foreach loop
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("After Dequeue Method: Removing Front Element");
                ex.Dequeue(); // removing front element using Dequeue method
                foreach (object item in ex)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine("After Peek Method Viewing Front Element");
                Console.WriteLine(ex.Peek()); ; // viewing front element using Peek method
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
