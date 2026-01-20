using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._18FileHandling
{
    internal class FileHandlingMain
    {
        // In More Detail Check Shiva Tutorial site File Handling Operations
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
            //fo.CreateFile();  // 1.Create a file

            fo.WriteOrAddData(); //2.Write data into file
            // when we call this method every time it will overwrite existing data.
            // (means if there is new data present it should replace with new data.)

            //fo.AppendOnFile(); //4.Append a file (to merge data into existing data)
            // when we call this method every time it will append data into existing data.
            // (means if there is data present it should merge with that data with new data.)

            fo.ReadDataFromFile(); //3.Read data from file

            //fo.DeleteFile(); //5.Delete a file
        }
    }
}
