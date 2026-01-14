using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._9_1AccessModifiers
{
    internal class Example
    {
        private void Private()
        {
            Console.WriteLine("Private Method");
        }
        internal void Internal()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Protected()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void ProtectedInternal()
        {
            Console.WriteLine("Protected Internal Method");
        }
        public void Public()
        {
            Console.WriteLine("Public Method");
        }
    }
}
