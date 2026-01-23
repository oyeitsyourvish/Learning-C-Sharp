using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._19Collection.Common_Generic_Non_Generic.Queue
{
    internal class Queue
    {
        public static void Main(string[] args)
        {
            /*
             Queue in C# :- is a collection class that follows the FIFO (First In First Out) principle.
                   It means that the first element added to the queue will be the first one to be removed.

            - It is used when you want to maintain the order of elements and process them in the same order
            they were added.

            - Queue is useful in scenarios like task scheduling, breadth-first search algorithms, and
            handling requests in a server.

            - In C#, the Queue class is available in the System.Collections namespace for non-generic queues
            and in the System.Collections.Generic namespace for generic queues.


             */
            QueueEx ex = new QueueEx();
            ex.QueueExample_Non_Generic(); // Non-Generic Queue Example
            ex.QueueExample_Generic(); // Generic Queue Example
        }
    }
}
