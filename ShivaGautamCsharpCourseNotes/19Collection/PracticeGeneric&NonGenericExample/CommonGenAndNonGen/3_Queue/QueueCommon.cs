using System.Collections;
using System.Collections.Generic;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.CommonGenAndNonGen._3_Queue
{
    internal class QueueCommon
    {
        public static void Main(string[] args)
        {
            // Queue :- - A Queue is a collection that stores data in the order it is added.
            //          - The first element added is the first element removed.
            //          - This is called FIFO (First In, First Out).
            //          - Think of people standing in a line at a ticket counter..
            // Methods: 1-Enqueue(), 2-Dequeue(), 3-Peek(), 4-Contains(), 5-Clear(), 6-Count, 7-ToArray()

            // Non-Generic Queue Example it store different types of data in a single queue.
            Non_Generic_Queue();

            // Generic Queue Example it store only one type of data in a single queue.
            Generic_Queue();
        }

        private static void Non_Generic_Queue()
        {

            Console.WriteLine("Non_Generic Queue Started");
            Queue q = new Queue();

            //Enqueue() means add an element to the rear of the queue.
            q.Enqueue(10);
            q.Enqueue("vishal");
            q.Enqueue(true);
            q.Enqueue("string");
            q.Enqueue(20);

            //foreach (var i in q)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();


            //Dequeue() removes the first (front) element.
            q.Dequeue();
            //foreach (var i in q)
            //{
            //    Console.WriteLine(i);
            //}

            // Peek() returns the front element without removing it.
            Console.WriteLine(q.Peek());

            // Count() Returns the total number of elements.
            Console.WriteLine(q.Count);


            // Contains() Checks whether an element exists.
            Console.WriteLine(q.Contains(20));
            Console.WriteLine();


            // ToArray
            Console.WriteLine("Convert it into object array");
            Object[] arr = q.ToArray();
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

        }

        private static void Generic_Queue()
        {
            Console.WriteLine();
            Console.WriteLine("Generic Queue Started");

            //All the methods are same like Non_Generic Just declaration is different.
            Queue<int> q = new Queue<int>();
            q.Enqueue(300);
            q.Enqueue(100);
            q.Enqueue(200);
            //
            int[] arr = q.ToArray();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
