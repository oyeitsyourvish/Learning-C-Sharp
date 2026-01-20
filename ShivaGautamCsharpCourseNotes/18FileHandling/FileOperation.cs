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
        String path = "e://hello.txt";
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
           /* StreamWriter sw = new StreamWriter(path); // Streamwriter class is used to write data into file
            sw.WriteLine("Hello Welcome to File Handling Write Or Add Data ");
            sw.Close();
           */

            // Another way to write data into file using File class and directly give content.
            File.WriteAllText(path, "Hello Welcome to File Handling in Write content");

            /*
            // Another way take user input as content and write into file
            String data = "";
            Console.WriteLine("Enter the File Content");
            data = Console.ReadLine();
            File.WriteAllText(path, data);
            */
            Console.WriteLine("Data Saved Successfully in Write content");
        }

        internal void AppendOnFile() //means to merge data into existing data
        {
            /*
            StreamWriter sw = new StreamWriter(path,true); // Streamwriter class is used to write data into file
            sw.WriteLine("Hello Welcome to File Handling in Appned Process");
            sw.Close();
            */
            // Another way to append data into file using File class and directly give content.
            File.AppendAllText(path, " \n Hello Welcome to File Handling in Append Process");

            /*
            // Another way take user input as content and append into file
            String data = "";
            Console.WriteLine("Enter the File Content to Append");
            data = Console.ReadLine();
            File.AppendAllText(path, " \n " + data);
            */

            Console.WriteLine("Data Saved Successfully in Append");
        }

        internal void ReadDataFromFile() // read data from file
        {
            try
            {
                /*
                StreamReader sr = new StreamReader(path); // StreamReader class is used to read data from file
                String data = sr.ReadToEnd(); // ReadToEnd() method is used to read all data from file
                Console.WriteLine(data);
                sr.Close();
                */

                // Another way to read data from file using File class
                String data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        internal void DeleteFile() // delete a file
        {
            /*
             if (File.Exists(path))
             {
                 File.Delete(path);
                 Console.WriteLine("File Deleted Successfully.");
             }
             else
             {
                 Console.WriteLine("File does not exist.");
             }
            */

            // Another way using try catch block to handle exception (its a good way to write code most of the time use try catch block)
            try
            {
                File.Delete(path);
                Console.WriteLine("File Deleted Successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }


    }
}