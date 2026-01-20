using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._18FileHandling
{
    internal class FileHandlingMain
    {
        /* FILE HANDLING in C# :- if we want to store program output permanently under computer hard disk
         then we use file handling Operation.
         - C# provide System.IO namespace to perform file handling operation.
            1.Create a file
            2.Write data into file
            3.Read data from file
            4.Append a file (to merge data into existing data)
            5.Delete a file
         */
        public static void Main(string[] args)
        {
            FileOperation fo = new FileOperation();
            fo.CreateFile();
            fo.WriteOrAddData();
        }
    }
}
