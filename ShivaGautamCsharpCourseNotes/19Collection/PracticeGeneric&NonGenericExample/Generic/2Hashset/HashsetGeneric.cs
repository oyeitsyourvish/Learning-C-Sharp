using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._19Collection.PracticeGeneric_NonGenericExample.Generic._2Hashset
{
    internal class HashsetGeneric
    {
        public static void Main(string[] args)
        {
            // HashSet :- it store only unique values not duplicate. and all methods are same.
            HashSet<int> h = new HashSet<int>();
            h.Add(30);
            h.Add(20);
            h.Add(30);
            h.Add(30);
            h.Add(40);


            foreach (int i in h)
            {
                Console.WriteLine(i);
            }

        }
    }
}
