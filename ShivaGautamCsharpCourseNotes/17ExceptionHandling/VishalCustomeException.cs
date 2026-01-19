using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._17ExceptionHandling
{
    internal class VishalCustomeException: Exception
    {
        private string message="Negative number is not allowed";
        public string Message { get { return message; } }
    }
}
