using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._9_1AccessModifiers
{
    sealed class SealedClass
    {
        // Sealed Class :- if we want to protect class from inheritance or avoid inheritantce 
                         // - we cant inherites sealed class. we cant access in main class we only acces it same class.

        internal void func()
        {
            Console.WriteLine("Sealed Class");
        }

    }
}
