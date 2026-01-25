using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._7Array.Examples
{
    internal class StudMain
    {
        public static void Main(string[] args)
        {
            Student[] obj = new Student[5];
            for(int i =0; i < obj.Length; i++)
            {
                obj[i] = new Student();
                Console.WriteLine("Enter the Roll No");
                int rn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name No");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Fess No");
                int fees = Convert.ToInt32(Console.ReadLine());

                obj[i].accept(rn, name, fees);
            }

            int max = 0;
            int studind = 0; ;
            for(int i = 0; i < obj.Length; i++)
            {
                if (max < obj[i].fees)
                {
                    max = obj[i].fees;
                    studind = i;
                }
            }
            Console.WriteLine("Max fees is :  " + max);
            obj[studind].display();
        }
    }
}
