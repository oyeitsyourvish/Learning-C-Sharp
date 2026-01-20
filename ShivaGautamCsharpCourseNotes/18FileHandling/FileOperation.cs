using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShivaGautamCsharpCourseNotes._18FileHandling
{
    internal class FileOperation
    {
        String path = "e://hello1.txt";
        internal void CreateFile()  // create a file
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File is already Exist");
            }
            else
            {
                using (File.Create(path)) ;
                Console.WriteLine("File Created successfully.");
            }
        }

        internal void WriteOrAddData() // write data into file
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Hello Welcome to File Handling");
            sw.Close();
        }
    }
}