using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicToAdvanced._17ExceptionHandling.Program
{
    internal class ExceptionHandlePro
    {
        public static void Main(string[] args)
        {
            try
            {
                int b = 0;
                int a = 10 / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Handled");
            }
            finally
            {
                Console.WriteLine("Always Execute Finally");
            }
            ThorwsException();
        }

        public static void ThorwsException()
        {
            int amt = 0;
            if (amt <= 0)
            {
                throw new ArgumentException("Amount must be greater than 1");
            }

        }
    }
}
