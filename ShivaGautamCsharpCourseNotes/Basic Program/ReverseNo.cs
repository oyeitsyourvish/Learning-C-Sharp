using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced.Basic_Program
{
    internal class ReverseNo
    {
        internal void reverse(int no)
        {
            int store = no;  //123
            int revStore=0;
            while (store > 0)
            {
                int temp = store%10;
                revStore = revStore * 10 + temp;
                store/=10;
            }
            Console.WriteLine("Reverse No is "+revStore);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            ReverseNo r = new ReverseNo();
            r.reverse(no);
        }
    }
}
