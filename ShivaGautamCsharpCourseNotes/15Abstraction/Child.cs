using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaGautamCsharpCourseNotes._15Abstraction
{
    internal class Child : Abstract
    {
        internal override void rectanlge()
        {
            area = param1 * param2;
        }

        internal override void tringle()
        {
            area = (param1 * param2) / 2;
        }
    }
}
