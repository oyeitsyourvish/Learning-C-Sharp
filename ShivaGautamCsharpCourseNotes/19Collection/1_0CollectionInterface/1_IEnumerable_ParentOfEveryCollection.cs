using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasicToAdvanced._19Collection._1_0CollectionInterface
{
    internal class IEnumerable_ParentOfEveryCollection
    {
        public static void Main(string[] args)
        {
            // IEnumerable : it is Parent of almost all collection.
            /*   Purpose :- Only allows reading data one by one.
                 Methods :- GetEnumerator()
            */

            List<int> num = new List<int>
            { 10,
              20,
              40,
              30
            };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            // foreach internally uses IEnumerable and its GetEnumerator (reading data one by one
            // (real life ex. we read a book and using finger on every word which we read or point that word))

        }
    }
}
